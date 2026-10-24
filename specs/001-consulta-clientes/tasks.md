---

description: "Tarefas da entrega 001 — consulta de clientes na web"
---

# Tasks: Consulta de clientes na web (primeira entrega)

**Input**: Design documents from `/specs/001-consulta-clientes/`

**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: **incluídos**. A constituição (III.2) exige testes de contrato da API, E2E das jornadas principais e golden
master para aceitar um módulo. Em cada história, os testes vêm antes da implementação e devem falhar primeiro.

**Organization**: tarefas agrupadas por história (US1 a US4 da spec) para entrega e teste independentes.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: pode rodar em paralelo (arquivos diferentes, sem dependência de tarefa incompleta)
- **[Story]**: história da spec (US1, US2, US3, US4)
- Caminhos relativos à raiz do repositório. O código fica em `web/` (plan.md, "Project Structure")

## Referências rápidas

- Regras de negócio: `docs/legado/10-clientes.md` (RN-CLI-001 a 022); banco: `docs/legado/90-banco.md`
- Estrutura das tabelas legadas: `docs/legado/banco/02_colunas.csv`; view `CC`: `docs/legado/banco/modulos/VIEW/dbo.CC.sql`
- Decisões técnicas: `research.md` (R1 a R15); dados: `data-model.md`; contrato: `contracts/openapi.yaml`
- Constituição: `.specify/memory/constitution.md`. Nunca alterar objeto existente do banco (I.1); SQL sempre
  parametrizado (IV.2); nenhum dado de cliente em log (V.3)

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: criar o monorepo e as ferramentas

- [X] T001 Criar o workspace pnpm em `web/`: `web/package.json` (privado, `"engines": { "node": ">=24" }`, scripts `lint`, `test`, `build`, `dev` que delegam aos pacotes), `web/pnpm-workspace.yaml` (`apps/*`, `packages/*`), `web/tsconfig.base.json` (`strict: true`, `noUncheckedIndexedAccess: true`, módulos ESM) e `web/.gitignore` (`node_modules/`, `dist/`, `coverage/`, `playwright-report/`, `test-results/`, `*.local.json`)
- [X] T002 [P] Criar o pacote `web/packages/shared` (`package.json` com nome `@pepe/shared`, dependência `zod`, `tsconfig.json`, `src/index.ts` exportando `src/esquemas/`)
- [X] T003 [P] Criar o pacote `web/apps/api` (`package.json` com `fastify@5`, `@fastify/static`, `@fastify/cookie`, `@fastify/rate-limit`, `kysely`, `tedious`, `tarn`, `@node-rs/argon2`, `zod`, `@pepe/shared` (workspace); dev: `vitest`, `tsx`, `kysely-codegen`; `tsconfig.json`; scripts `dev` (tsx watch), `build` (tsc para `dist/`), `test`, `gerar-tipos`, `usuario`)
- [X] T004 [P] Criar o pacote `web/apps/spa` com Vite + React 19 + TypeScript (`package.json` com `@mantine/core@9`, `@mantine/hooks`, `@mantine/dates`, `dayjs`, `@tanstack/react-router`, `@tanstack/react-query`, `@pepe/shared`; dev: `@playwright/test`, `@tanstack/router-plugin`; `vite.config.ts` com proxy de `/api` para a API em desenvolvimento e saída do build em `web/apps/spa/dist`)
- [X] T005 [P] Configurar ESLint (flat config, `typescript-eslint`) e Prettier na raiz de `web/` (`web/eslint.config.js`, `web/.prettierrc`), com o script `lint` rodando nos três pacotes
- [X] T006 [P] Configurar o Vitest em `web/apps/api/vitest.config.ts` e `web/packages/shared/vitest.config.ts`, e o Playwright em `web/apps/spa/playwright.config.ts` (navegador Chromium, `baseURL` da API de teste, `locale: 'pt-BR'`)

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: banco (schema `web` e banco de teste), servidor, autenticação e o esqueleto da SPA. Todas as histórias dependem disto.

**⚠️ CRITICAL**: nenhuma história começa antes do fim desta fase

### Banco

- [X] T007 Criar `Pepe/Scripts/WEB001_v1_up.sql`, idempotente, com comentários sem acento como os outros scripts. Conteúdo:
  - `CREATE SCHEMA web`.
  - `web.Usuario`: `IdUsuario int IDENTITY PK`; `Login nvarchar(50) NOT NULL` com índice único; `Nome nvarchar(100) NOT NULL`; `HashSenha nvarchar(255) NOT NULL`; `Ativo bit NOT NULL DEFAULT 1`; `TentativasFalhas int NOT NULL DEFAULT 0`; `BloqueadoAte datetime2(0) NULL`; `CriadoEm datetime2(0) NOT NULL DEFAULT SYSDATETIME()`; `UltimoAcesso datetime2(0) NULL`.
  - `web.Sessao`: `IdSessao char(64) PK` (SHA-256 hex do identificador do cookie); `IdUsuario int NOT NULL` com FK para `web.Usuario`; `CriadaEm datetime2(0) NOT NULL`; `UltimoUso datetime2(0) NOT NULL`; `ExpiraEm datetime2(0) NOT NULL`.
  - `web.RegistroAcesso`: `IdRegistro bigint IDENTITY PK`; `Momento datetime2(0) NOT NULL DEFAULT SYSDATETIME()`; `Login nvarchar(50) NOT NULL`; `IdUsuario int NULL`; `Evento varchar(20) NOT NULL`, com `CHECK` em (`ENTRADA`, `ENTRADA_RECUSADA`, `BLOQUEIO`, `SAIDA`, `SESSAO_EXPIRADA`); `Ip varchar(45) NULL`.
  - Login SQL e usuário `pepe_web`, com a senha recebida por variável `sqlcmd` `$(SENHA_PEPE_WEB)`, nunca escrita no script.
  - `GRANT SELECT` **só** em `dbo.Clientes`, `dbo.CC`, `dbo.VENDAS`, `dbo.[VENDAS DET]` e `dbo.[1TabPeças]`.
  - `GRANT SELECT, INSERT, UPDATE, DELETE ON SCHEMA::web`.
  - Nenhum objeto existente alterado (constituição I.1; research.md R10).
- [X] T008 Criar `Pepe/Scripts/WEB001_v1_down.sql`, que desfaz exatamente o T007 (remove usuário e login `pepe_web`, as três tabelas e o schema `web`), idempotente
- [X] T009 Criar `web/docker-compose.teste.yml` com um SQL Server 2022 só para testes (contêiner `pepe_web_teste`, `127.0.0.1:14331`, senha por variável de ambiente lida de `web/.env.teste.local`, que é ignorado pelo git). Feito sem `MSSQL_COLLATION`: trocar a collation do servidor travou a instância na primeira inicialização; a collation da produção fica no banco (T010)
- [X] T010 Criar `web/apps/api/tests/banco-teste/estrutura.sql`. Ele cria o banco `BDTorrasTeste` com `COMPATIBILITY_LEVEL = 120` e collation `Latin1_General_CI_AS`, e:
  - as tabelas `dbo.Clientes` (as 23 colunas, com os mesmos nomes, tipos, tamanhos e nulidade de `docs/legado/banco/02_colunas.csv`, inclusive `SSMA_TimeStamp timestamp`, `Imp bit DEFAULT 0` e `Oculto bit DEFAULT 0`);
  - `dbo.VENDAS`, `dbo.[VENDAS DET]`, `dbo.[1TabPeças]`, `dbo.CONSERTOS` e `dbo.[Conta Corrente]`, cada uma com **todas** as colunas citadas pela view `CC` e pelas consultas de `data-model.md`, nos tipos do catálogo;
  - a view `dbo.CC`, copiada **sem alteração** de `docs/legado/banco/modulos/VIEW/dbo.CC.sql`.
- [X] T011 Criar `web/apps/api/tests/banco-teste/dados.sql` com dados **inventados** (nenhum dado real, constituição V.3), cobrindo os casos de `quickstart.md` §1:
  - cliente só com mala direta;
  - cliente sem `Nome` nem `Cliente`;
  - clientes com `Oculto = 1` e com `Oculto` nulo;
  - dois clientes com o mesmo `Nome`;
  - um nome com acento (ex.: "José Araújo");
  - um cliente com lançamentos de CC vindos de `CONSERTOS`, `VENDAS` e `[Conta Corrente]` (flags `CashCC`/`CartãoCC`/`ChequeCC` e `CCDeb` preenchidos);
  - um cliente com 3 peças compradas e outro sem nenhuma;
  - uma venda com `IDCliente` inexistente (órfã);
  - clientes com e sem `DataCad` em pelo menos dois meses diferentes;
  - mais de 120 clientes no total, para testar a paginação.
- [X] T012 Criar `web/apps/api/tests/banco-teste/preparar.ts`, que sobe o contêiner do T009 se preciso, aplica `estrutura.sql`, `Pepe/Scripts/WEB001_v1_up.sql` (com uma senha de teste) e `dados.sql`, e é usado como `globalSetup` do Vitest e do Playwright
- [X] T013 Criar `web/apps/api/src/config.ts`. Ele lê o JSON do caminho em `PEPE_WEB_CONFIG` e valida com Zod: `bancoDeDados` (servidor, porta, banco, usuário, senha), `porta`, `certificado` e `chave` (caminhos do PEM), `origemPublica`. Se faltar configuração, o serviço não sobe e mostra a mensagem do erro, sem nenhum segredo. Criar também `web/apps/api/config.exemplo.json`, sem valores reais
- [X] T014 Criar `web/apps/api/src/db/kysely.ts`: `Kysely` com `MssqlDialect` (`tedious` + `tarn`), pool `min: 0`, `max: 5` (research.md R3), `trustServerCertificate` configurável, e função de encerramento para os testes
- [X] T015 Configurar o script `gerar-tipos` (`kysely-codegen --dialect mssql --default-schema dbo`, conectando como `pepe_web`, para entrarem só os objetos que a web lê e as tabelas novas saírem como `web.Usuario` etc.) contra o `BDTorrasTeste` e gerar `web/apps/api/src/db/tipos.ts`, restrito aos schemas `dbo` e `web`, com aviso "gerado, não editar". Commitar o arquivo gerado (ele não tem segredo)
- [X] T016 Criar `web/apps/api/src/server.ts`. Ele exporta `construirApp(config)` e sobe o Fastify com:
  - HTTPS (certificado e chave da configuração);
  - prefixo `/api`;
  - `@fastify/static` servindo `web/apps/spa/dist`, com fallback para `index.html` nas rotas da SPA;
  - tratador de erro que devolve `{ mensagem }` em português, sem pilha nem SQL (contrato `Erro`);
  - **log conforme research.md R9**: serializador de requisição só com `method`, `routeOptions.url` (o padrão da rota), `statusCode`, `responseTime` e `idUsuario`, **sem URL real nem query string**, e `redact` de `req.headers.cookie`, `req.headers.authorization` e corpo.
- [X] T017 [P] Criar os esquemas Zod `Erro`, `Credenciais` (`login` 1 a 50, `senha` 1 a 200) e `UsuarioConectado` em `web/packages/shared/src/esquemas/sessao.ts`, iguais a `contracts/openapi.yaml`

### Autenticação (research.md R7, R8; FR-001, FR-002, FR-004, FR-025)

- [ ] T018 [P] Teste unitário das regras de sessão e bloqueio em `web/apps/api/tests/unit/regras-sessao.test.ts`:
  - a sessão vale enquanto `agora < ExpiraEm` e `UltimoUso` tem menos de 30 minutos;
  - o teto é de 12 h depois da entrada;
  - o usuário inativo ou bloqueado invalida a sessão;
  - 5 falhas seguidas bloqueiam por 15 minutos, e o acerto zera o contador.
- [ ] T019 [P] Teste de contrato de `POST/GET/DELETE /api/sessao` em `web/apps/api/tests/contrato/sessao.test.ts`:
  - entrada correta → 200 com `UsuarioConectado` e cookie `pepe_sessao` `HttpOnly`, `Secure`, `SameSite=Strict`;
  - usuário errado e senha errada → 401 com **a mesma** mensagem;
  - usuário inativo → 401;
  - 6ª tentativa → bloqueado;
  - `GET` sem cookie → 401;
  - `DELETE` → 204 e sessão apagada;
  - eventos gravados em `web.RegistroAcesso`.
- [ ] T020 Implementar `web/apps/api/src/auth/senha.ts`: hash e verificação argon2id com `@node-rs/argon2`, formato PHC; verificação em tempo constante também quando o usuário não existe, comparando com um hash fixo para não revelar logins
- [ ] T021 Implementar `web/apps/api/src/auth/sessao.ts`. Ele faz:
  - criar: 32 bytes aleatórios em base64url no cookie; em `web.Sessao` vai **só** o SHA-256 hex;
  - validar: as regras do T018;
  - tocar: atualizar `UltimoUso` no máximo uma vez por minuto;
  - encerrar;
  - limpar as sessões vencidas na inicialização e na entrada do usuário.
- [ ] T022 Implementar `web/apps/api/src/auth/rotas.ts` com `POST/GET/DELETE /api/sessao`, conforme `contracts/openapi.yaml`:
  - a entrada atualiza `web.Usuario` (`TentativasFalhas`, `BloqueadoAte`, `UltimoAcesso`), cria `web.Sessao` e grava `web.RegistroAcesso` **numa única transação** (constituição IV.1);
  - mensagem única de recusa;
  - `@fastify/rate-limit` no `POST` por IP;
  - registros `ENTRADA`, `ENTRADA_RECUSADA`, `BLOQUEIO` e `SAIDA`.
- [ ] T023 Implementar `web/apps/api/src/auth/exigir-sessao.ts`: um hook `preHandler` aplicado a todo `/api`, menos `POST /api/sessao`. Ele responde 401 (`SemSessao`) quando a sessão é inválida, registra `SESSAO_EXPIRADA` quando é o caso e põe `idUsuario` na requisição para o log
- [ ] T024 Implementar `web/apps/api/src/cli/usuario.ts` (script `pnpm --filter api usuario <criar|desativar|reativar|senha|listar>`):
  - a senha é digitada **sem eco**, duas vezes, e nunca vem por argumento, arquivo ou log (research.md R8);
  - senha com no mínimo 10 caracteres;
  - login em minúsculas, só letras, dígitos, `.` e `-`, com até 50 caracteres;
  - desativar encerra as sessões do usuário.

### Esqueleto da SPA (FR-005, FR-006)

- [ ] T025 [P] Criar `web/apps/spa/src/formatacao.ts`: datas `dd/MM/aaaa`, moeda `R$ 1.234,56`, CPF `000.000.000-00` a partir de 11 dígitos, e vazio (nunca "null") para valores nulos (constituição VI.3), mais o teste `web/apps/spa/src/formatacao.test.ts`
- [ ] T026 Criar `web/apps/spa/src/api/cliente.ts` (`fetch` com `credentials: 'include'`, respostas validadas com os esquemas de `@pepe/shared`; ao receber 401, guarda a rota atual e manda para `/entrar`) e `web/apps/spa/src/api/consulta.ts` (`QueryClient` do TanStack Query, mensagem clara quando o banco não responde, nunca tela em branco)
- [ ] T027 Criar a rota `web/apps/spa/src/rotas/entrar.tsx`: formulário de usuário e senha (Mantine), que mostra a mensagem da API e, depois de entrar, volta à rota guardada
- [ ] T028 Criar o layout `web/apps/spa/src/rotas/__root.tsx` e `web/apps/spa/src/rotas/_autenticado.tsx` com o `AppShell` do Mantine:
  - barra lateral com os grupos de `docs/legado/01-modulos.md`, mostrando **só** "Cadastros › Clientes" e "Relatórios › Clientes cadastrados" (FR-005);
  - topo com o nome do usuário e "Sair" (FR-006);
  - `MantineProvider` e `DatesProvider` com `locale: 'pt-br'`.

**Checkpoint**: banco de teste no ar, entrada e saída funcionando, barra lateral visível. As histórias podem começar.

---

## Phase 3: User Story 1 - Encontrar um cliente (Priority: P1) 🎯 MVP

**Goal**: lista de clientes com pesquisa sem diferenciar acento, paginada, com os ocultos só sob demanda.

**Independent Test**: entrar, abrir Clientes, pesquisar um cliente conhecido e conferir os dados com o desktop
(spec, US1).

### Tests for User Story 1 ⚠️

> Escrever primeiro e ver falhar

- [ ] T029 [P] [US1] Teste unitário do nome de exibição e do filtro de oculto em `web/packages/shared/tests/regras-cliente.test.ts`:
  - `nomeExibicao = Nome ?? Cliente` (RN-CLI-002);
  - cliente sem os dois fica fora (RN-CLI-001);
  - `Oculto` nulo conta como visível.
- [ ] T030 [P] [US1] Teste de contrato de `GET /api/clientes` em `web/apps/api/tests/contrato/clientes-lista.test.ts`:
  - pesquisa "jose araujo" encontra "José Araújo";
  - busca por telefone;
  - cliente só com mala direta aparece com o nome de mala direta;
  - cliente sem nome nem mala direta nunca aparece;
  - oculto só com `ocultos=true`, e com `oculto: true`;
  - homônimos aparecem os dois;
  - ordenação pelo nome de exibição;
  - `pagina`/`porPagina`/`total` corretos;
  - `porPagina=500` → 400;
  - sem sessão → 401.
- [ ] T031 [P] [US1] Teste E2E da US1 em `web/apps/spa/tests/e2e/us1-encontrar-cliente.spec.ts`: os cenários de aceite 1.1 a 1.5 da spec

### Implementation for User Story 1

- [ ] T032 [P] [US1] Criar os esquemas Zod `ClienteResumo` e `PaginaClientes` e a função `nomeExibicao` em `web/packages/shared/src/esquemas/clientes.ts`, iguais a `contracts/openapi.yaml`
- [ ] T033 [US1] Implementar `listarClientes({ busca, ocultos, pagina, porPagina })` em `web/apps/api/src/clientes/consultas.ts` com Kysely e parâmetros ligados (research.md R5, R6):
  - filtro fixo `ISNULL(Nome, Cliente) IS NOT NULL`;
  - sem `ocultos`, `ISNULL(Oculto, 0) = 0`;
  - pesquisa `LIKE '%' + @busca + '%'` com `COLLATE Latin1_General_CI_AI` sobre `Nome`, `Cliente` e `Telefone`;
  - ordem por `ISNULL(Nome, Cliente) COLLATE Latin1_General_CI_AI`, depois `IDCliente`;
  - `OFFSET/FETCH`, mais a consulta de contagem;
  - nada de `OPENJSON`.
- [ ] T034 [US1] Implementar `GET /api/clientes` em `web/apps/api/src/clientes/rotas.ts`, com a validação dos parâmetros do contrato (`busca` até 100, `porPagina` de 10 a 100, padrão 50) e registro em `server.ts`
- [ ] T035 [US1] Criar a rota `web/apps/spa/src/rotas/_autenticado/clientes/index.tsx`:
  - campo de pesquisa com espera de 300 ms;
  - chave "mostrar ocultos";
  - tabela paginada com nome de exibição, título, mala direta, endereço, bairro, telefone e aniversário (FR-009);
  - marca visual "oculto";
  - linha clicável para `/clientes/$id`;
  - mensagem quando não houver resultado.

**Checkpoint**: US1 funciona e passa nos testes sozinha (MVP)

---

## Phase 4: User Story 2 - Consultar a ficha do cliente (Priority: P2)

**Goal**: ficha só de leitura, com o cadastro e os lançamentos de conta corrente.

**Independent Test**: abrir a ficha de clientes escolhidos e conferir campo a campo e lançamento a lançamento com o
desktop (spec, US2).

### Tests for User Story 2 ⚠️

- [ ] T036 [P] [US2] Teste de contrato de `GET /api/clientes/{id}` em `web/apps/api/tests/contrato/clientes-ficha.test.ts`:
  - devolve todos os campos de `ClienteFicha`;
  - `cpf` com 11 dígitos;
  - `versao` em hexadecimal;
  - **sem** `Fax`, `CPF_MD`, `Saldo`, `Imp`;
  - oculto abre com `oculto: true`;
  - `DataCad` nulo → `dataCadastro: null`;
  - id inexistente → 404;
  - cliente sem nome nem mala direta → 404.
- [ ] T037 [P] [US2] Teste de contrato de `GET /api/clientes/{id}/conta-corrente` em `web/apps/api/tests/contrato/clientes-cc.test.ts`:
  - lançamentos das três origens (`Venda`, `Conserto`, lançamento de CC) com `forma` e `valor`, e débito negativo;
  - ordem por `Data` e depois `Ident`;
  - cliente sem lançamentos → lista vazia;
  - a venda órfã não aparece em cliente nenhum;
  - id inexistente → 404.
- [ ] T038 [P] [US2] Teste E2E da US2 em `web/apps/spa/tests/e2e/us2-ficha.spec.ts`: os cenários 2.1 a 2.4 da spec, conferindo também que não há nenhum campo editável

### Implementation for User Story 2

- [ ] T039 [P] [US2] Criar os esquemas Zod `ClienteFicha` e `LancamentoCC` em `web/packages/shared/src/esquemas/clientes.ts`
- [ ] T040 [US2] Implementar `obterFicha(id)` em `web/apps/api/src/clientes/consultas.ts`:
  - colunas de `data-model.md` `ClienteFicha`;
  - `versao` = `SSMA_TimeStamp` convertido para hexadecimal;
  - `null` quando o cliente não existe ou não tem nome de exibição.
- [ ] T041 [US2] Implementar `listarContaCorrente(id)` em `web/apps/api/src/clientes/consultas.ts`: `SELECT ID, Data, Op, Tp, VValor, Ident FROM dbo.CC WHERE CLIENTE = @id ORDER BY Data, Ident`, a mesma fonte do desktop (`dsCliente.CC`; RN-CLI-017). Mapear para `idOrigem`, `data`, `operacao`, `forma`, `valor`
- [ ] T042 [US2] Implementar `GET /api/clientes/{id}` e `GET /api/clientes/{id}/conta-corrente` em `web/apps/api/src/clientes/rotas.ts`, com 404 (`NaoEncontrado`) quando `obterFicha` devolve `null`
- [ ] T043 [US2] Criar a rota `web/apps/spa/src/rotas/_autenticado/clientes/$id.tsx`:
  - campos só de leitura (FR-013, com o CPF formatado);
  - aviso "oculto";
  - abas "Cadastro" e "Conta corrente";
  - tabela de CC com data, operação, forma e valor em `R$`, débitos em vermelho;
  - "Voltar" preserva a pesquisa da lista.

**Checkpoint**: US1 e US2 funcionam, cada uma por conta própria

---

## Phase 5: User Story 3 - Ver as peças compradas pelo cliente (Priority: P3)

**Goal**: aba "Peças compradas" na ficha, sem custo nem margem.

**Independent Test**: comparar a lista de clientes escolhidos com a tela "Compras" do desktop (spec, US3).
**Depende da ficha** (T043) para a aba.

### Tests for User Story 3 ⚠️

- [ ] T044 [P] [US3] Teste de contrato de `GET /api/clientes/{id}/pecas-compradas` em `web/apps/api/tests/contrato/clientes-pecas.test.ts`:
  - as 3 peças do cliente de teste em ordem de `DataVenda` decrescente e depois `VENDAS.Id` decrescente;
  - campos `dataVenda`, `numeroVenda`, `classe`, `modelo`, `descricao`, `observacoes`;
  - a resposta **não tem** custo, preço nem comissão (FR-017);
  - cliente sem compras → lista vazia;
  - id inexistente → 404.
- [ ] T045 [P] [US3] Teste E2E da US3 em `web/apps/spa/tests/e2e/us3-pecas-compradas.spec.ts`: cenários 3.1 e 3.2

### Implementation for User Story 3

- [ ] T046 [P] [US3] Criar o esquema Zod `PecaComprada` em `web/packages/shared/src/esquemas/clientes.ts`
- [ ] T047 [US3] Implementar `listarPecasCompradas(id)` em `web/apps/api/src/clientes/consultas.ts`:
  - junção `dbo.VENDAS` ⨝ `dbo.[VENDAS DET]` (`[VENDAS DET].Venda = VENDAS.Id`) ⨝ `dbo.[1TabPeças]` (`[VENDAS DET].Peça = [1TabPeças].IDPeça`), filtrada por `VENDAS.IDCliente = @id`;
  - selecionar só `DataVenda`, `Venda`, `Classe`, `Modêlo`, `Descrição` e `Obs`;
  - ordem `DataVenda DESC`, depois `VENDAS.Id DESC`.
- [ ] T048 [US3] Implementar `GET /api/clientes/{id}/pecas-compradas` em `web/apps/api/src/clientes/rotas.ts` (404 se `obterFicha` devolver `null`)
- [ ] T049 [US3] Adicionar a aba "Peças compradas" em `web/apps/spa/src/rotas/_autenticado/clientes/$id.tsx`: tabela com data, nº da venda, classe + modelo, descrição e observações, e o aviso "Não há compras registradas" quando a lista vier vazia

**Checkpoint**: US1, US2 e US3 funcionam

---

## Phase 6: User Story 4 - Emitir o relatório de clientes cadastrados (Priority: P4)

**Goal**: relatório por período ou sem período, com versão para impressão em A4 e golden master.

**Independent Test**: emitir nos períodos de referência e em "sem período" e comparar com o desktop (spec, US4).

### Tests for User Story 4 ⚠️

- [ ] T050 [P] [US4] Teste de contrato de `GET /api/relatorios/clientes-cadastrados` em `web/apps/api/tests/contrato/relatorio-clientes-cadastrados.test.ts`:
  - sem `de`/`ate` → todos com nome de exibição, **inclusive os ocultos** (FR-021);
  - com período → `DataCad` entre as datas, **as duas inclusive**;
  - `total` igual ao número de linhas;
  - `emitidoEm` presente;
  - só `de` → 400;
  - `ate` anterior a `de` → 400.
- [ ] T051 [P] [US4] Teste E2E da US4 em `web/apps/spa/tests/e2e/us4-relatorio.spec.ts`:
  - cenários 4.1 a 4.3;
  - a versão de impressão (`page.emulateMedia({ media: 'print' })`) mostra título, período e data de emissão, sem a barra lateral.

### Implementation for User Story 4

- [ ] T052 [P] [US4] Criar os esquemas Zod `LinhaClientesCadastrados` e `RelatorioClientesCadastrados` em `web/packages/shared/src/esquemas/relatorios.ts`
- [ ] T053 [US4] Implementar `relatorioClientesCadastrados({ de, ate })` em `web/apps/api/src/relatorios/clientes-cadastrados.ts`, com a mesma lógica de `Pepe/Relatorios/ClientesCadastradosRpt.resx` (RN-CLI-012): `ISNULL(Nome, Cliente) IS NOT NULL` e, com período, `DataCad BETWEEN @de AND @ate`, sem filtrar `Oculto`, ordenado pelo nome de exibição
- [ ] T054 [US4] Implementar `GET /api/relatorios/clientes-cadastrados` em `web/apps/api/src/relatorios/rotas.ts`: validação de `de`/`ate` conforme o contrato, `emitidoEm` com a hora do servidor
- [ ] T055 [US4] Criar a rota `web/apps/spa/src/rotas/_autenticado/relatorios/clientes-cadastrados.tsx`:
  - período padrão = mês corrente;
  - chave "sem período";
  - tabela e contagem;
  - botão "Imprimir" (`window.print()`).

  Criar também `web/apps/spa/src/rotas/_autenticado/relatorios/impressao.css`: `@page { size: A4; margin: 15mm }`, cabeçalho com título, período e data de emissão, barra lateral e controles escondidos na impressão.
- [ ] T056 [US4] Criar o script de golden master `web/apps/api/scripts/golden-master/clientes-cadastrados.ts`, que roda **na cópia real** (Docker, conexão pela configuração):
  - executa a consulta do desktop, copiada **literalmente** de `Pepe/Relatorios/ClientesCadastradosRpt.resx` (as duas queries: com e sem período), e a função do T053;
  - compara contagem e o conjunto de linhas, com SHA-256 de cada linha normalizada;
  - roda para "sem período" e para os dois meses de 2026 com mais cadastros (research.md R13; o script os descobre e os registra);
  - grava o resultado **fora do repositório**, num caminho por parâmetro, padrão a pasta temporária do usuário;
  - termina com código diferente de zero se houver qualquer diferença.

**Checkpoint**: as quatro histórias funcionam de forma independente

---

## Phase 7: Polish & Cross-Cutting Concerns

**Purpose**: paridade, privacidade de log, documentação e instalação na loja

- [ ] T057 [P] Teste de log sem dado pessoal em `web/apps/api/tests/contrato/log-sem-dado-pessoal.test.ts`: captura a saída do logger durante pesquisas e aberturas de ficha e falha se aparecer o texto pesquisado, um nome, um telefone ou um CPF do banco de teste (SC-006; constituição V.3)
- [ ] T058 [P] Criar o script de paridade `web/apps/api/scripts/golden-master/paridade-ficha.ts` (SC-003), que roda na cópia real:
  - sorteia 20 clientes com nome de exibição;
  - compara o cadastro, os lançamentos de CC (consulta do desktop `SELECT Id, Cliente, Data, VValor, Tp, Op, Ident FROM CC WHERE Cliente = @IdCli`) e as peças compradas (junção do `dsCliente.Compras`) com as funções da API;
  - grava o resultado fora do repositório e sai com código diferente de zero se houver diferença.
- [ ] T059 [P] Escrever `docs/web/golden-master.md`: como preparar a cópia, rodar T056 e T058, onde ficam os resultados (fora do git), como registrar os meses de referência e o critério de aprovação
- [ ] T060 [P] Escrever os ADRs `docs/web/adr/0001-stack.md` (research.md R1 a R4), `docs/web/adr/0002-autenticacao.md` (R7, R8, R15), `docs/web/adr/0004-relatorios.md` (R11) e `docs/web/adr/0008-implantacao.md` (R14), cada um com contexto, decisão, alternativas e consequências
- [ ] T061 Configurar o build de produção: o script `build` de `web/package.json` compila `shared`, `spa` e `api`, e `apps/api/dist/server.js` serve `apps/spa/dist`. Conferir com `node web/apps/api/dist/server.js`, apontando para uma configuração de teste
- [ ] T062 [P] Criar os arquivos de instalação em `web/implantacao/`:
  - `pepe-web.xml` (WinSW: serviço "Pepe Web", `node apps\api\dist\server.js`, variável `PEPE_WEB_CONFIG`, reinício automático, logs com rotação);
  - `instalar.ps1` (instala ou atualiza o serviço, sem tocar na configuração);
  - `docs/web/implantacao.md` (WinSW, certificado com `mkcert` e instalação da raiz no computador do dono, aplicação do `WEB001_v1_up.sql` no `PEPETORRAS-PC\SQLEXPRESS` depois do Docker, criação do primeiro usuário pelo T024, atualização e reversão).
- [ ] T063 [P] Atualizar `docs/web/README.md` (Fase 0 a 5: a entrega 001 em andamento, ADRs criados) e o `CLAUDE.md` (seção "Versão web": como subir o banco de teste, rodar testes, lint e build em `web/`)
- [ ] T064 Rodar `pnpm lint` e `pnpm test` (unitários, contrato e E2E) em `web/` e corrigir o que falhar
- [ ] T065 Rodar a validação de `specs/001-consulta-clientes/quickstart.md`: §2 (usuários), §3 (golden master e paridade na cópia real, T056 e T058 sem diferença) e, com o dono, §4 (instalação na loja, SC-002, SC-005 e SC-006)

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: sem dependências
- **Foundational (Phase 2)**: depende do Setup e **bloqueia todas as histórias**
- **US1 a US4 (Phases 3 a 6)**: dependem da Phase 2
- **Polish (Phase 7)**: T057 depende de US1 e US2; T058 depende de US2 e US3; T061 a T065 dependem das histórias que forem entrar

### User Story Dependencies

- **US1 (P1)**: só da Phase 2
- **US2 (P2)**: só da Phase 2. A ficha abre pela URL `/clientes/$id`; o link a partir da lista (US1) é uma comodidade
- **US3 (P3)**: a **API** depende só da Phase 2; a **aba** depende da página da ficha (T043, US2)
- **US4 (P4)**: só da Phase 2

### Within Each User Story

- Testes primeiro, e falhando
- Esquema Zod → consulta → rota → tela
- `web/apps/api/src/clientes/consultas.ts`, `rotas.ts` e `web/packages/shared/src/esquemas/clientes.ts` são compartilhados por US1 a US3: as tarefas que mexem neles não rodam em paralelo entre histórias

### Parallel Opportunities

- Phase 1: T002 a T006 em paralelo depois do T001
- Phase 2: T017, T018, T019 e T025 em paralelo; banco (T007 a T012) em paralelo com o servidor (T013 a T016)
- Em cada história, os testes [P] em paralelo; o esquema Zod [P] em paralelo com os testes
- US4 inteira em paralelo com US1 a US3 (arquivos próprios)

---

## Parallel Example: User Story 1

```bash
# Testes da US1, juntos:
Task: "T029 Teste unitário do nome de exibição e do filtro de oculto em web/packages/shared/tests/regras-cliente.test.ts"
Task: "T030 Teste de contrato de GET /api/clientes em web/apps/api/tests/contrato/clientes-lista.test.ts"
Task: "T031 Teste E2E da US1 em web/apps/spa/tests/e2e/us1-encontrar-cliente.spec.ts"

# Junto com os testes:
Task: "T032 Esquemas ClienteResumo e PaginaClientes em web/packages/shared/src/esquemas/clientes.ts"
```

## Parallel Example: US4 ao lado de US2

```bash
Task: "T050 Teste de contrato do relatório em web/apps/api/tests/contrato/relatorio-clientes-cadastrados.test.ts"
Task: "T036 Teste de contrato da ficha em web/apps/api/tests/contrato/clientes-ficha.test.ts"
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Phase 1: Setup
2. Phase 2: Foundational (banco de teste, schema `web`, servidor, autenticação, esqueleto da SPA)
3. Phase 3: US1
4. **Parar e validar**: testes da US1 verdes e conferência de alguns clientes com o desktop
5. Instalar no servidor da loja só se o dono quiser ver o MVP lá (T061, T062)

### Incremental Delivery

1. Setup + Foundational → base pronta
2. US1 → testar → demonstrar (MVP)
3. US2 → testar → demonstrar
4. US3 → testar → demonstrar
5. US4 + golden master (T056) → testar → demonstrar
6. Polish → paridade (T058), ADRs, instalação na loja e validação com o dono (T065)

### Uma pessoa (ou um agente) por vez

Ordem sugerida: T001 → T006, T007 → T028, depois US1, US2, US3 e US4, e por fim a Phase 7. Um commit por tarefa ou
por grupo lógico, em português, com Conventional Commits (`feat(web-clientes): …`).

---

## Notes

- [P] = arquivos diferentes, sem dependência
- [Story] liga a tarefa à história da spec
- Testes devem falhar antes da implementação
- Nada de dado real em teste, fixture ou commit (constituição V.3). O golden master grava fora do repositório
- Nenhuma tarefa altera objeto existente do `BDTorras`. A única mudança de banco é o par `WEB001_v1`, que cria objetos
  novos no schema `web` e o login `pepe_web`
