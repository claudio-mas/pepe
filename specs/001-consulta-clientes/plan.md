# Implementation Plan: Consulta de clientes na web (primeira entrega)

**Branch**: `claude/tender-archimedes-nhe0fh` (spec `001-consulta-clientes`) | **Date**: 2026-10-24 | **Spec**: [spec.md](spec.md)

**Input**: Feature specification from `/specs/001-consulta-clientes/spec.md`

**Note**: This template is filled in by the `/speckit-plan` command; its definition describes the execution workflow.

## Summary

Primeira entrega da web, só de leitura: entrada por usuário próprio, barra lateral, lista e pesquisa de clientes
(ocultos só sob demanda), ficha com a conta corrente, peças compradas e o relatório "Clientes cadastrados". A
abordagem:
- **Processo**: um único processo Node.js 24 + Fastify serve a API e a SPA (React + Vite + TanStack + Mantine) por
  HTTPS, num serviço do Windows no servidor da loja.
- **Banco**: o processo lê o `BDTorras` com Kysely, por um login SQL que só tem `SELECT` nas fontes legadas.
  Usuários, sessões e o registro de acessos ficam em tabelas novas no schema `web`.
- **Paridade**: provada por golden master contra a cópia real no Docker. Os testes automáticos rodam num banco
  sintético, sem dado pessoal.

## Technical Context

**Language/Version**: TypeScript 5 (modo `strict`) sobre Node.js 24 LTS (R1)

**Primary Dependencies**:
- API: Fastify 5 (+ `@fastify/static`, `@fastify/cookie`, `@fastify/rate-limit`) e Kysely com `MssqlDialect`
  (`tedious` + `tarn`); tipos do banco gerados por `kysely-codegen` (R2, R3).
- Senhas: `@node-rs/argon2` (R7).
- SPA: React 19, Vite 8, TanStack Router e TanStack Query, Mantine 9 (R4), com o tema do design system Cloudscape UI
  (`cloudscape-ui`, do GitHub, fixo num commit; R4a).
- Compartilhado: Zod.
- As versões exatas ficam travadas no lockfile (`web/pnpm-lock.yaml`). Ajustes da implantação da Fase 1: Mantine 9
  (a versão atual; o plano falava em 8), TypeScript 6.0 (o `typescript-eslint` ainda não aceita o 7) e `tedious` 19
  (o `kysely-codegen` exige versão abaixo da 20).

**Storage**: SQL Server Express (`PEPETORRAS-PC\SQLEXPRESS`, ~650 MB, collation `Latin1_General_CI_AS`, nível de
compatibilidade 120). Leitura de `dbo.Clientes`, `dbo.CC` (view), `dbo.VENDAS`, `dbo.[VENDAS DET]` e
`dbo.[1TabPeças]`; escrita só em `web.Usuario`, `web.Sessao` e `web.RegistroAcesso` ([data-model.md](data-model.md)).

**Testing**:
- Vitest para unitários e contrato (Fastify `inject` contra o banco sintético em contêiner, nível 120).
- Playwright para E2E.
- Golden master por script na cópia real (R12, R13).

**Target Platform**: Windows Server/Windows do `PEPETORRAS-PC` (serviço do Windows via WinSW, R14); navegadores atuais
(Chrome/Edge) nos computadores da loja. Desenvolvimento em Windows 11 com Docker.

**Project Type**: aplicação web (API + SPA) num monorepo pnpm em `web/`.

**Performance Goals**: pesquisa de clientes em até 1 s em 95% das buscas, com cerca de 5.300 clientes e o desktop em
uso (SC-002); ficha (cadastro, CC e peças) em até 1 s.

**Constraints**:
- Nenhuma alteração em objeto existente do banco (I.1).
- Consultas compatíveis com o nível 120: sem `OPENJSON` (R6).
- Pool de no máximo 5 conexões, por causa dos limites do Express.
- Nenhum dado de cliente em log: rota registrada pelo padrão, sem query string (R9).
- Só leitura no legado, garantida pelas permissões do login (R10).
- HTTPS na intranet.

**Scale/Scope**: 1 usuário nesta entrega (o dono), poucos usuários depois; 5.279 clientes; 4 telas (entrada, lista,
ficha com abas, relatório); 7 rotas de API.

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Princípio | Como o plano atende | Situação |
|---|---|---|
| I.1 Não alterar objeto existente | Só `SELECT` no legado; collation trocada na expressão, não na coluna (R5); nenhum índice novo | ✅ |
| I.2 Objetos novos no schema `web` | `web.Usuario`, `web.Sessao`, `web.RegistroAcesso` | ✅ |
| I.3 Scripts `_up`/`_down`, primeiro no Docker | Schema `web` e login `pepe_web` por par de scripts em `Pepe/Scripts/` (tarefas) | ✅ |
| I.4 Gravar como o desktop | Nada é gravado no legado nesta entrega | ✅ (não se aplica) |
| I.5 Não depender do SQL de manutenção do desktop | As consultas não dependem de `Vendida`/`peças` corrigidos pelo desktop; a regra de oculto usa `ISNULL(Oculto, 0)` | ✅ |
| I.6 Terceiro sistema (`VI_Pecas_Web`) | Só leitura; nenhuma coluna da view é tocada | ✅ |
| II Regras rastreáveis | Cada rota e campo citam RN-CLI ou FR ([data-model.md](data-model.md)) | ✅ |
| III Paridade comprovada | Golden master do relatório e paridade da ficha em 20 clientes (R12) | ✅ |
| IV.1 Transação em gravação múltipla | Entrada: atualizar `web.Usuario`, criar `web.Sessao` e registrar em `web.RegistroAcesso` numa transação | ✅ |
| IV.2 SQL parametrizado | Kysely com parâmetros ligados; nenhuma concatenação | ✅ |
| IV.3 Concorrência otimista | A ficha já devolve `versao` (`SSMA_TimeStamp`) para a edição futura; sem gravação agora | ✅ (não se aplica) |
| V.1 Sem segredo no repositório | Configuração fora do repositório (R14) | ✅ |
| V.2 Usuários individuais, argon2id, **perfis** | Usuários individuais e argon2id ✅; **perfil único** nesta entrega | ⚠️ Exceção justificada abaixo |
| V.3 Dados pessoais fora de log e do git | Log sem query string; testes em banco sintético; golden master fora do git | ✅ |
| V.4 HTTPS e sessão com expiração | Certificado local; 30 min sem uso, teto de 12 h (R7) | ✅ |
| VI Domínio em português | Glossário nas telas; tipos gerados com os nomes originais; pt-BR na SPA | ✅ |
| VII Simplicidade | Um processo, uma SPA, um banco; cada dependência justificada em research.md | ✅ |

**Resultado (antes da Fase 0)**: aprovado, com uma exceção registrada em *Complexity Tracking*.

**Reavaliação (depois da Fase 1)**: o desenho (data-model, contratos, quickstart) não introduziu violação nova. As
tabelas do schema `web` têm FK só entre si. Nenhum contrato expõe custo ou margem (FR-017). O contrato `/clientes`
aceita `ocultos=true` só como filtro de leitura. **Aprovado.**

## Project Structure

### Documentation (this feature)

```text
specs/001-consulta-clientes/
├── plan.md              # este arquivo
├── research.md          # Fase 0: decisões R1 a R15
├── data-model.md        # Fase 1: schema web e modelos de leitura
├── quickstart.md        # Fase 1: roteiro de validação
├── contracts/
│   └── openapi.yaml     # Fase 1: contrato da API
├── checklists/
│   └── requirements.md  # checklist de qualidade da spec
└── tasks.md             # Fase 2 (/speckit-tasks; ainda não criado)
```

### Source Code (repository root)

```text
web/
├── package.json                 # workspace pnpm, scripts de conjunto (lint, test, build)
├── pnpm-workspace.yaml
├── apps/
│   ├── api/
│   │   ├── src/
│   │   │   ├── server.ts        # Fastify: HTTPS, static da SPA, plugins, log sem dado pessoal (R9)
│   │   │   ├── config.ts        # leitura da configuração fora do repositório (R14)
│   │   │   ├── db/
│   │   │   │   ├── kysely.ts    # dialeto MSSQL, pool (máx. 5)
│   │   │   │   └── tipos.ts     # gerado por kysely-codegen (não editar)
│   │   │   ├── auth/            # sessão, argon2id, bloqueio, registro de acesso (R7)
│   │   │   ├── clientes/        # rotas e consultas: lista, ficha, CC, peças compradas
│   │   │   ├── relatorios/      # clientes cadastrados
│   │   │   └── cli/usuario.ts   # procedimento técnico de usuários (R8)
│   │   └── tests/
│   │       ├── contrato/        # rotas × openapi.yaml × esquemas Zod
│   │       ├── unit/
│   │       └── banco-teste/     # criação do banco sintético (estrutura do catálogo, nível 120, dados inventados)
│   └── spa/
│       ├── src/
│       │   ├── rotas/           # TanStack Router: entrada, layout com barra lateral, clientes, ficha, relatório
│       │   ├── componentes/
│       │   ├── api/             # cliente HTTP + TanStack Query
│       │   └── formatacao.ts    # datas, moeda, CPF em pt-BR
│       └── tests/e2e/           # Playwright: as 4 histórias
└── packages/
    └── shared/
        └── src/esquemas/        # Zod: Credenciais, ClienteResumo, ClienteFicha, LancamentoCC, PecaComprada, Relatório

Pepe/Scripts/
├── WEB001_v1_up.sql             # schema web + tabelas + login/usuário pepe_web com permissões (R10)
└── WEB001_v1_down.sql

docs/web/
├── golden-master.md             # roteiro de captura (sem dados)
└── adr/
    ├── 0001-stack.md            # R1 a R4
    ├── 0002-autenticacao.md     # R7, R8, R15
    ├── 0004-relatorios.md       # R11
    └── 0008-implantacao.md      # R14
```

**Structure Decision**: monorepo pnpm em `web/`, com uma API (que também serve a SPA compilada) e uma SPA, mais um
pacote de esquemas compartilhados, como previsto no roteiro e na constituição ("Restrições técnicas"). Os scripts de
banco seguem a convenção já existente em `Pepe/Scripts/` (pares `_up`/`_down`, prefixo próprio `WEB001`). Os ADRs
desta entrega registram as decisões do research.md; o ADR 3 (convivência) fica para a primeira entrega que gravar no
legado.

## Complexity Tracking

> **Fill ONLY if Constitution Check has violations that must be justified**

| Violation | Why Needed | Simpler Alternative Rejected Because |
|-----------|------------|-------------------------------------|
| V.2: entrega com **um perfil só** (sem perfis de acesso) | Decisão do dono (24/10/2026): nesta entrega o único usuário é o dono, que vê tudo. Perfis sem um segundo tipo de usuário seriam código sem uso | Criar perfis agora (Dono/Vendedora) exigiria decidir regras de visibilidade que o dono adiou. **Condição**: os perfis entram antes de qualquer conta de vendedora, por um novo par de scripts (coluna `Perfil` em `web.Usuario`) |
