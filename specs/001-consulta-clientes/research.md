# Research: Consulta de clientes na web (001)

Fase 0 do `/speckit-plan`. Cada item fecha uma decisão técnica que a spec deixou para o plano. Formato: **Decisão**,
**Por quê**, **Alternativas**. As decisões de stack (R1 a R4) são o conteúdo do **ADR 1** do roteiro
(`docs/web/README.md`, Fase 3); as demais alimentam os ADRs 2, 3, 4 e 8.

## R1. Runtime e organização do código

- **Decisão**: Node.js 24 LTS, TypeScript em modo `strict`, monorepo pnpm em `web/` com três pacotes:
  `apps/api`, `apps/spa` e `packages/shared`. As versões exatas ficam travadas no `pnpm-lock.yaml`.
- **Por quê**: decisão do dono (Node/TS full-stack). O monorepo deixa os esquemas de validação (R4) compartilhados
  sem publicar pacote. O Node 24 é a LTS ativa em 10/2026.
- **Alternativas**: Node 22 (em manutenção até 04/2027: troca de versão logo depois da primeira entrega);
  repositórios separados (perde o legado em `Pepe/` como fonte de verdade ao lado, contra a constituição).

## R2. API HTTP

- **Decisão**: Fastify 5, servindo a API em `/api` e os arquivos estáticos da SPA no mesmo processo
  (`@fastify/static`), com HTTPS direto no Fastify.
- **Por quê**: um processo só (constituição VII.1); validação de entrada e saída por esquema; registro de log
  embutido (pino) com controle fino do que sai (R9).
- **Alternativas**: Express (sem validação por esquema nativa); NestJS (estrutura demais para uma loja); Next.js
  (SSR e servidor de borda não trazem nada numa intranet com uma SPA).

## R3. Acesso ao SQL Server

- **Decisão**: Kysely com o dialeto `MssqlDialect` (drivers `tedious` + `tarn`), tipos gerados por `kysely-codegen`
  a partir do banco. Pool pequeno (mín. 0, máx. 5 conexões).
- **Por quê**: SQL-first. As consultas da entrega são `SELECT`s sobre tabelas e views legadas com nomes acentuados e
  com espaço (`[1TabPeças]`, `[VENDAS DET]`, view `CC`), que o Kysely trata como identificadores entre colchetes.
  Os tipos gerados são o "lugar único" de mapeamento de nomes (constituição VI.2). Parâmetros sempre ligados
  (constituição IV.2). O SQL Server Express limita CPU e memória, e o servidor é dividido com o desktop e com o
  terceiro sistema: daí o pool pequeno.
- **Alternativas**: Prisma (introspecção ruim de views e procs legadas, nomes com acento exigem `@map` em tudo,
  cliente pesado); Drizzle (suporte a SQL Server menos maduro); `mssql` puro (sem tipos).

## R4. SPA e validação compartilhada

- **Decisão**: React 19 + Vite + TanStack Router (rotas tipadas, layout com barra lateral) + TanStack Query (cache e
  estados de carga e erro). Componentes de interface Mantine 9 (`AppShell` com `Navbar`, tabela, campos, datas em
  pt-BR). Esquemas Zod em `packages/shared`, usados pela API (validação) e pela SPA (tipos).
- **Por quê**: o `AppShell` do Mantine já é a "barra lateral no lugar das ribbons", e tabela paginada, campos e datas
  vêm prontos, sem CSS próprio. Isso justifica a dependência (constituição VII.2). Zod compartilhado garante que a
  SPA e a API concordam sobre o formato (testes de contrato, constituição III.2).
- **Alternativas**: componentes próprios com TanStack Table e CSS (mais código para manter); MUI (mais pesado, visual
  menos neutro); Angular (outra linguagem de templates; a decisão foi TS + React no roteiro).

## R4a. Design system: Cloudscape UI como tema do Mantine

- **Decisão**: o visual segue o design system do dono, o Cloudscape UI (`github.com/claudio-mas/cloudscape-ui`), usado
  como **tema do Mantine**, não no lugar dele. A dependência `cloudscape-ui` vem do repositório do GitHub fixa num
  commit (nunca pelo nome no npm, onde o nome não é dele). Da biblioteca, a SPA usa só o `tokens.css` (as variáveis
  `--cs-*`, com tema claro e escuro) e o `Icon`, que é SVG puro. Em `web/apps/spa/src/tema/`:
  - `tema.ts`: tema do Mantine com toda cor, fonte, espaço, canto e sombra apontando para uma variável `--cs-*`. A cor
    principal é uma escala derivada de `--cs-color-brand` (`tema.css`), e as cores de base do Mantine (fundo, texto,
    bordas) são trocadas pelas do kit;
  - `componentes.module.css`: o desenho dos componentes do kit aplicado aos do Mantine (botão principal em pílula com
    o degradê da marca, item ativo da barra lateral com a barra de 3 px, cabeçalho e barra lateral sem bordas);
  - `esquema.tsx`: claro, escuro ou "Sistema" (padrão), escolhido no menu do usuário e guardado pelo Mantine; o esquema
    resolvido vai para `data-cs-theme` no `<html>`, que liga o tema escuro dos tokens;
  - `marca.css` e `Marca.tsx`: cores e logotipo da joalheria, tirados de pepetorras.com.br, que substituem os do kit.
    Botões e destaques em `#996633` (a cor de destaque do site) com degradê até o marrom `#5C4535`, bronze claro
    `#d6a76f` no escuro, contraste conferido; logotipo completo na entrada e só o nome no cabeçalho (o lema
    "identidade e tradição" fica ilegível a 28 px); o ícone do site como favicon. A fonte continua a do kit (Segoe
    UI): a Poppins do site exigiria baixar fonte de fora ou uma dependência nova, sem ganho para a loja.
- **Por quê**: o kit traz os tokens e 18 componentes desenhados para uma tela de arquivos; faltam campo de senha,
  chave, tabela genérica com paginação, abas, seletor de período em pt-BR, aviso de erro e diálogo, que a spec 001
  usa e o Mantine já tem (R4). Usar os componentes do kit junto com os do Mantine também não dá: o `components.css`
  aplica regras a todo botão e campo dentro de `.cs-ui` e quebraria os do Mantine. Como tema, os tokens continuam a
  fonte única do visual: atualizar o commit da dependência atualiza o Pepe.
- **Alternativas**: trocar o Mantine pelos componentes do kit (uns oito componentes novos para escrever e manter,
  entre eles um calendário; contraria a constituição VII); copiar o `tokens.css` para o projeto (mais simples, mas
  deixa de acompanhar o kit).

## R5. Pesquisa de clientes sem diferenciar acento

- **Decisão**: a pesquisa compara com `COLLATE Latin1_General_CI_AI` sobre `Nome`, `Cliente` e `Telefone`
  (`LIKE '%' + @texto + '%'`), e a ordenação usa `ISNULL(Nome, Cliente) COLLATE Latin1_General_CI_AI`. Paginação com
  `OFFSET … FETCH`, 50 por página, mais a contagem total. O telefone é comparado sem parênteses, espaços e hífen,
  dos dois lados (`REPLACE` aninhado na coluna, e o mesmo no texto digitado): "988880001" acha "(11) 98888-0001"
  (pedido do dono, 24/10/2026). Os curingas do `LIKE` (`%`, `_`, `[`) digitados são escapados.
- **Por quê**: o banco é `Latin1_General_CI_AS`, que diferencia acento (FR-010). Trocar a collation só na expressão
  não altera nenhum objeto (constituição I.1). Não há índice em `Nome` (`docs/legado/90-banco.md` §5), mas com cerca
  de 5.300 clientes a varredura completa leva poucos milissegundos: dá folga para SC-002 (1 s) sem índice novo.
- **Alternativas**: índice novo (exige ADR, I.1; desnecessário nesse volume); full-text search (outra peça para
  administrar no Express); normalizar no Node (traria a tabela inteira a cada busca).

## R6. Compatibilidade com o nível 120 (SQL Server 2014)

- **Decisão**: as consultas da web usam só recursos disponíveis no nível 120: `OFFSET/FETCH`, `ROW_NUMBER`,
  `COLLATE`, `ISNULL`/`COALESCE`, `CONCAT`. Ficam proibidos `OPENJSON`/`JSON_VALUE` em consultas (exigem nível 130) e
  qualquer recurso novo sem teste no nível 120. O banco de teste (R12) roda com `COMPATIBILITY_LEVEL = 120`.
- **Por quê**: o nível vem do backup da loja (`docs/legado/90-banco.md` §1). Mudar o nível seria alterar o banco
  compartilhado.
- **Alternativas**: subir o nível de compatibilidade (afeta o desktop e o terceiro sistema; fora de questão).

## R7. Usuários, senhas e sessões

- **Decisão**:
  - **Senhas** com argon2id (`@node-rs/argon2`, binário pronto para Windows, sem compilação).
  - **Sessão no servidor**, em `web.Sessao`: o cookie leva só um identificador aleatório de 256 bits, com
    `HttpOnly`, `Secure` e `SameSite=Strict`. Expira após 30 minutos sem uso, e no máximo 12 horas depois da entrada.
  - **Bloqueio**: 5 senhas erradas seguidas bloqueiam o usuário por 15 minutos.
  - **Mensagem de erro** única para usuário ou senha errados (cenário 1.5).
- **Por quê**: constituição V.2 e V.4; FR-001, FR-002. A sessão no banco permite que um usuário desativado perca o
  acesso na próxima ação (caso-limite da spec), coisa que um token autocontido (JWT) não garante.
- **Alternativas**: JWT (não revoga na hora); `bcrypt` (argon2id é o recomendado; `bcrypt` exige compilação nativa no
  Windows); autenticação do Windows/AD (a loja não tem domínio, a confirmar no ADR 2).

## R8. Procedimento técnico de usuários (FR-004)

- **Decisão**: comando de linha (`pnpm --filter api usuario <criar|desativar|reativar|senha|listar>`), rodado no
  servidor. A senha é digitada sem eco no terminal e nunca passa por argumento de linha de comando, arquivo ou log.
- **Por quê**: decisão do dono (sem tela de administração nesta entrega). Argumento de linha de comando fica no
  histórico do shell; daí a digitação sem eco.
- **Alternativas**: script SQL com hash calculado à mão (frágil); tela de administração (adiada pelo dono).

## R9. Registro de log sem dado pessoal (FR-024, FR-025)

- **Decisão**: o log de requisições grava método, **padrão da rota** (`/api/clientes/:id`, não a URL real), status,
  duração e id do usuário. A **query string não é registrada**, porque a pesquisa leva nomes e telefones. O `redact` do
  pino corta `cookie`, `authorization` e corpo. Entradas, saídas e tentativas recusadas vão para `web.RegistroAcesso`
  (login, data e hora, resultado, IP), sem nenhum dado de cliente.
- **Por quê**: constituição V.3. O log padrão do Fastify registra a URL completa, com a query string, e vazaria o
  texto pesquisado.
- **Alternativas**: não logar requisições (perde o diagnóstico); mascarar a query string (frágil: basta um campo novo
  para vazar).

## R10. Usuário de banco da web e permissões

- **Decisão**: login SQL próprio, `pepe_web`, com:
  - **`SELECT` só** nas fontes desta entrega (`dbo.Clientes`, `dbo.CC`, `dbo.VENDAS`, `dbo.[VENDAS DET]`,
    `dbo.[1TabPeças]`);
  - **`SELECT`, `INSERT`, `UPDATE` e `DELETE`** no schema `web`.

  Criação e remoção por um par de scripts `_up`/`_down` em `Pepe/Scripts/`.
- **Por quê**: FR-015 ("nenhuma tela grava") e FR-022 garantidos pelo próprio banco, não só pelo código. Criar login,
  usuário e schema não altera objeto existente (constituição I.1, I.2).
- **Alternativas**: usar o `sa` ou o login do desktop (qualquer defeito da web poderia gravar no legado).

## R11. Relatório "Clientes cadastrados" e impressão (ADR 4)

- **Decisão**: o relatório é uma página da SPA com uma versão para impressão em CSS (`@page { size: A4 }`, cabeçalho
  com título, período e data de emissão). A impressão usa a do navegador, que também gera PDF. Sem gerador de PDF no
  servidor nesta entrega. A consulta reproduz a do desktop (`Relatorios/ClientesCadastradosRpt.resx`, RN-CLI-012):
  `ISNULL(Nome, Cliente) IS NOT NULL` e, com período, `DataCad BETWEEN @dt1 AND @dt2`, inclusive os ocultos (FR-021).
- **Por quê**: o relatório é uma lista simples. Imprimir pelo navegador resolve sem dependência nova.
- **Alternativas**: PDF no servidor (Playwright/Chromium ou pdfmake: dependência pesada ou layout manual, só se um
  relatório futuro precisar); RDLC/DevExpress (é o que se quer deixar).

## R12. Testes e golden master

- **Decisão**:
  - **Unitários** (Vitest): regras puras, como o nome de exibição, a formatação do CPF e a regra de oculto.
  - **Contrato** (Vitest + Fastify `inject`): cada rota, comparada com os esquemas Zod de `packages/shared` e com
    `contracts/openapi.yaml`, contra um **banco de teste sintético** num contêiner SQL Server. O banco só tem as
    tabelas e views usadas, com a estrutura copiada do catálogo (`docs/legado/banco/02_colunas.csv` e
    `modulos/VIEW/dbo.CC.sql`), nível 120 e dados inventados. Nenhum dado real entra no repositório
    (constituição V.3).
  - **E2E** (Playwright): as quatro histórias, sobre o mesmo banco de teste.
  - **Golden master** do relatório e da paridade (SC-003, SC-004), na **cópia real** no Docker da máquina de
    desenvolvimento: um script roda a consulta do desktop e a da web para os períodos de referência e compara
    contagem e conteúdo linha a linha. A saída (contagens e um resumo criptográfico por linha) fica fora do git; no
    repositório só entra o roteiro (`docs/web/golden-master.md`).
- **Por quê**: constituição III; o legado não tem testes e o banco real tem dados pessoais.
- **Alternativas**: testar contra a cópia real (dados pessoais nos testes); mocks do banco (não pegam erros de SQL,
  collation e nível de compatibilidade, que são o maior risco aqui).

## R13. Períodos de referência do golden master

- **Decisão**: "sem período", mais **dois meses de 2026 com cadastros**. Os meses são escolhidos na captura a partir
  da cópia, como os meses com mais cadastros, e registrados no roteiro.
- **Por quê**: só 373 clientes têm `DataCad` (`docs/legado/90-banco.md` §7), e 02/2021, usado no `Vendas`, pode não
  ter nenhum cadastro.
- **Alternativas**: períodos fixos agora (risco de período vazio, que não prova nada).

## R14. Implantação no servidor da loja (ADR 8, parte desta entrega)

- **Decisão**:
  - **Serviço do Windows** rodando `node apps/api/dist/server.js` com a SPA já compilada, registrado com WinSW.
  - **HTTPS** com certificado de uma autoridade local da loja, gerado com `mkcert`. A raiz é instalada só no
    computador do dono nesta entrega.
  - **Configuração** em arquivo fora do repositório: conexão, porta, caminho do certificado e segredo de sessão.
  - **Atualização**: copiar a nova versão e reiniciar o serviço.
- **Por quê**: o servidor é Windows (`PEPETORRAS-PC`), e Docker no Windows da loja seria uma peça a mais para manter
  (constituição VII.1). O WinSW é um executável único com XML de configuração. O certificado próprio atende V.4 sem
  depender da internet.
- **Alternativas**: Docker Desktop no servidor (licença e recursos, num servidor que já roda o Express); IIS com
  iisnode (projeto abandonado); `pm2` (no Windows não sobe sozinho com o sistema).

## R15. Exceções à constituição

- **Decisão**: a entrega tem **um perfil só** (FR-003), contra a constituição V.2 ("perfis de acesso"). A exceção é
  registrada em *Complexity Tracking* no plano. Ela vale só enquanto o único usuário é o dono, e os perfis entram antes
  de qualquer conta de vendedora.
- **Por quê**: decisão do dono; a governança exige que a exceção fique escrita no plano.
