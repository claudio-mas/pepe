# Constituição do Pepe Web

Vale para pessoas e agentes. Toda spec, plano e tarefa DEVE respeitar estes princípios, e o `/speckit-analyze` DEVE
apontar violações. Contexto do projeto: `docs/web/README.md` (roteiro), `docs/web/glossario.md` e `docs/legado/`
(inventário do sistema desktop).

## Core Principles

### I. O banco é compartilhado com o desktop

1. NÃO PODE alterar nem remover objeto existente do `BDTorras` (tabela, coluna, view, proc, função, gatilho).
   Índice novo em tabela existente só entra com ADR (`docs/legado/90-banco.md` §5).
2. Objetos novos ficam no schema **`web`** (tabelas da aplicação web: usuários, sessões, auditoria) ou, se forem de
   leitura analítica, com o prefixo `VW_RG2_*`, como já é a convenção.
3. Toda mudança de banco é um par aditivo `_up.sql`/`_down.sql` em `Pepe/Scripts/`, rodado **primeiro no contêiner
   Docker** com uma cópia do banco.
4. Enquanto houver desktop em uso, a web DEVE gravar **exatamente o que o desktop gravaria**: mesmas tabelas, mesmos
   campos derivados, mesmas procs. Uma diferença intencional só entra com ADR e com o desktop ajustado junto.
5. A web NÃO PODE depender do SQL de manutenção que o desktop roda ao abrir as telas
   (`docs/legado/00-mapa-de-navegacao.md`): cada caso é tratado na leitura ou vira job explícito.
6. Há um **terceiro sistema** usando o `BDTorras`, mantido pelo dono, que só lê a view `VI_Pecas_Web`, e ele DEVE
   continuar funcionando. A view e as colunas de que ela depende (em `[1TabPeças]`, `PEDRAS`, `METAIS`,
   `[VENDAS DET]`, `VENDAS` e `Clientes`; lista em `docs/legado/90-banco.md` §6) não mudam de nome, tipo nem
   significado. As views `Beth` e `BasePrecos` não são usadas, mas ficam no banco.

Por quê: desktop, web e o terceiro sistema dividem o mesmo banco durante toda a migração, que é módulo a módulo.
O banco não tem FK nem gatilho, então a integridade depende de cada sistema gravar do mesmo jeito.

### II. Regras de negócio rastreáveis

1. Nenhuma regra é implementada sem uma RN catalogada em `docs/legado/` (`RN-<MÓD>-nnn`), com origem `arquivo:linha`
   no legado ou decisão registrada do dono.
2. Toda spec DEVE listar as RNs que cobre e os critérios de aceite de cada uma.
3. Divergência entre o código legado e o que o dono diz: vale o dono, e a divergência fica registrada.

Por quê: as regras estão espalhadas por formulários, DataSets, SQL concatenado e procs. Regra sem origem é regra
inventada.

### III. Paridade comprovada

1. Relatórios e cálculos (saldos, totais, comissões, custos, gerencial) têm **golden master**: a web DEVE bater valor
   a valor com o legado nos períodos de referência.
2. Um módulo só é aceito com testes de contrato da API, E2E das jornadas principais e golden master verde.

Por quê: sem uma referência objetiva, "a web está certa" vira opinião.

### IV. Gravação segura

1. Toda operação que grava em mais de uma tabela DEVE rodar **numa transação** (o legado não usa transação; a web usa).
2. SQL **sempre parametrizado**. NÃO PODE concatenar valores em SQL (o legado concatena).
3. Conflito de edição simultânea com o desktop: concorrência otimista. Onde existir `SSMA_TimeStamp` (19 tabelas,
   `docs/legado/90-banco.md` §2), a gravação compara essa coluna. Onde não existir, compara os valores originais das
   colunas editadas. Zero linhas afetadas = conflito, mostrado ao usuário.

### V. Segurança e dados pessoais

1. Sem segredo no código nem no repositório. Configuração por variável de ambiente ou arquivo fora do git.
2. Usuários individuais, senha com hash (argon2id), perfis de acesso. A senha compartilhada do desktop não é
   reaproveitada.
3. Dados de clientes (nome, endereço, telefone, CPF, aniversário) são pessoais (LGPD): só ficam visíveis para quem
   precisa, NÃO PODEM ir para logs e NÃO PODEM entrar no git (nem em golden master, nem em fixtures de teste, salvo
   anonimizados).
4. Intranet não é desculpa: HTTPS interno e sessão com expiração.

### VI. Domínio em português

1. Vocabulário do `docs/web/glossario.md` em telas, specs e código de domínio.
2. Nomes do banco são preservados exatamente, com acento (`[1TabPeças]`, `[Vencto Cartão]`), e o mapeamento para
   nomes TypeScript fica num único lugar (tipos gerados).
3. Cultura pt-BR na interface: datas `dd/MM/aaaa`, moeda `R$ 1.234,56`, vírgula decimal. No banco e na API, valores
   são tipados (nunca texto formatado).

### VII. Simplicidade

1. Uma loja, poucos usuários: sem microserviços, sem filas, sem cache distribuído. Um processo de API, uma SPA, um
   banco.
2. Dependência nova DEVE se justificar no plano da spec.
3. Nada de copiar a UI do desktop tela a tela: a spec descreve a tarefa do usuário, e a tela web é desenhada para ela.

## Restrições técnicas

- **Stack**: Node.js + TypeScript nos dois lados (API e SPA). A escolha das bibliotecas é o ADR 1
  (`docs/web/README.md`, Fase 3). Proposta: Fastify + Kysely (`mssql`/tedious) na API, React + Vite + TanStack
  Router/Query na SPA, Zod compartilhado, Vitest + Playwright.
- **Código** em `web/` neste mesmo repositório (monorepo pnpm), ao lado do legado em `Pepe/`, que é a fonte de verdade
  das regras.
- **Banco**: SQL Server **Express** na loja (`PEPETORRAS-PC\SQLEXPRESS`, ~650 MB), nível de compatibilidade **120**.
  As consultas da web DEVEM funcionar nesse nível e caber nos limites de memória e CPU do Express, que o servidor
  divide com o desktop e com o terceiro sistema.
- **Implantação**: intranet, num servidor na loja (ADR 8).
- **Navegação**: SPA com sidebar no lugar das ribbons; grupos em `docs/legado/01-modulos.md`.

## Fluxo de desenvolvimento

1. **Inventário antes da spec**: um módulo só ganha spec depois de ter o inventário em `docs/legado/<nn>-<módulo>.md`,
   com as dúvidas do dono respondidas ou explicitamente adiadas.
2. **Ciclo por módulo**: `/speckit-specify` → `/speckit-clarify` → `/speckit-plan` → `/speckit-tasks` →
   `/speckit-analyze` → `/speckit-implement`.
3. **Ordem dos módulos**: a do roteiro (`docs/web/README.md`, Fase 4). A primeira entrega é só leitura.
4. **Golden master** capturado no contêiner Docker, com o roteiro no repositório e os dados fora dele (V.3).
5. **Commits** em português, Conventional Commits com escopo (`feat(web-clientes): …`); o corpo explica o porquê e o
   que foi verificado. Cada entrega vai por PR.

## Governance

- Esta constituição prevalece sobre qualquer outra prática no trabalho da web. O `CLAUDE.md` continua valendo para o
  desktop e para as convenções gerais do repositório.
- Emenda: PR que altera este arquivo, com o motivo no corpo e aprovação do dono. Se a emenda mudar regra já usada em
  spec, o PR lista as specs afetadas.
- Versão (SemVer): MAJOR = princípio removido ou redefinido; MINOR = princípio ou seção nova, ou regra ampliada;
  PATCH = redação.
- Toda revisão de PR da web confere a aderência a esta constituição. Uma exceção precisa ficar escrita no plano da
  spec, com justificativa.

**Version**: 1.0.0 | **Ratified**: 2026-10-24 | **Last Amended**: 2026-10-24
