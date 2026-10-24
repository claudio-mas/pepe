# Pepe Web — roteiro

Versão web do sistema de gestão da joalheria: uma SPA com sidebar no lugar das ribbons, sobre o **mesmo banco SQL Server
`BDTorras`**, desenvolvida com Spec-Driven Development (GitHub Spec Kit) assistido por agentes de IA.

## Decisões já tomadas

| Tema | Decisão |
|---|---|
| Migração | **Convivência módulo a módulo** (strangler): desktop e web rodam juntos sobre o mesmo banco; cada tela do desktop é aposentada quando o módulo web equivalente for aceito. |
| Hospedagem | **Intranet**: backend num servidor na loja, ao lado do `PEPETORRAS-PC\SQLEXPRESS`. |
| Stack | **Node.js + TypeScript** full-stack (detalhes em ADR, ver Fase 3). |
| Método | **GitHub Spec Kit** (`constitution → specify → clarify → plan → tasks → analyze → implement`). |
| Repositório | Este mesmo repositório: o código web vai para `web/`, e os agentes leem o legado em `Pepe/` como fonte de verdade. |

## Fases

| # | Fase | Saída | Situação |
|---|---|---|---|
| 0 | Fundação | Constituição, glossário, este roteiro | **rascunhos** em `docs/web/` |
| 1 | Inventário do legado | `docs/legado/`: mapa de navegação, índice de módulos, um inventário por módulo, catálogo de RNs, catálogo do banco e matriz CRUD | mapa, índice e **Clientes** (`10-clientes.md`) prontos; extrator do catálogo do banco pronto, aguardando execução (`docs/legado/banco/`); demais módulos pendentes |
| 2 | Golden master | Roteiro de captura dos resultados do legado em períodos fixos, rodado sobre uma cópia do banco | pendente |
| 3 | PRD + ADRs | `docs/web/PRD.md`, `docs/web/adr/NNNN-*.md` | pendente |
| 4 | Ordem dos módulos | Roadmap no PRD | proposta abaixo |
| 5 | Ciclo Spec Kit por módulo | `specs/NNN-<modulo>/` (spec, plan, tasks) + código em `web/` | pendente |

### Por que não começar direto pelo PRD

As regras de negócio estão espalhadas por ~120 arquivos `.vb`, 13 DataSets tipados, SQL concatenado em ADODB, LINQ to
SQL, ~35 pares de relatórios e procs/views do banco. Algumas são até disparadas pelos botões da ribbon antes de abrir a
tela (ver `docs/legado/00-mapa-de-navegacao.md`). Um PRD escrito antes do inventário sai raso ou inventa regra.
E sem golden master, "a web está certa" vira opinião.

### Fase 1 — como fazer o inventário de um módulo

Para cada módulo de `docs/legado/01-modulos.md`, um agente lê as telas e os relatórios do módulo e produz
`docs/legado/<nn>-<modulo>.md` com:
1. Telas: campos (nome no banco ↔ rótulo na tela), filtros, ações e atalhos.
2. Fluxos: o que acontece em cada ação, na ordem, com o SQL efetivamente executado.
3. Regras `RN-<MÓD>-nnn`: enunciado em linguagem de negócio + origem `arquivo:linha` + confiança (alta, média ou "a confirmar").
4. Matriz CRUD: tabela × (C, R, U, D), incluindo o que as procs fazem.
5. Dúvidas para o dono.

Regra: **nenhuma RN sem origem**. O que for dedução do agente fica marcado como "a confirmar".

### Fase 2 — golden master

- Restaurar uma cópia do backup no contêiner Docker (`Pepe/Docker/restaurar-bdtorras.ps1`).
- Para cada relatório e cálculo crítico, registrar filtros + período + resultado do legado (PDF exportado e valores-chave).
  Períodos-padrão: um mês recente completo e um mês antigo (como na conversão do `Vendas`: 07/2026 e 02/2021).
- Os resultados ficam **fora do git** (dados de clientes, LGPD). No repositório entra só o roteiro de captura, em
  `docs/web/golden-master.md`.
- Esses resultados viram critério de aceite das specs: a web precisa bater valor a valor.

### Fase 3 — ADRs previstos

1. Stack. Proposta: API **Fastify** + **Kysely** (`kysely-codegen` sobre `mssql`/tedious; SQL-first, lida bem com
   views, procs e nomes acentuados); SPA **React + Vite + TanStack Router/Query**; **Zod** em `packages/shared`;
   Vitest + Playwright; monorepo pnpm (`web/apps/api`, `web/apps/spa`, `web/packages/shared`).
2. Autenticação e perfis: usuários reais (hoje é uma senha compartilhada), hash argon2, sessão por cookie, tabelas no schema `web`.
3. Convivência no banco: transações, concorrência otimista (`SSMA_TimeStamp`, a coluna `rowversion` herdada da
   migração do Access, onde existir; comparação de valores originais onde não existir), procs legadas como contrato, o
   que fazer com o SQL de manutenção que o desktop roda ao abrir as telas.
4. Relatórios: HTML imprimível × PDF gerado no servidor.
5. Etiquetas (endereço e aniversário) e impressão local.
6. Fotos das peças (hoje em coluna binária de `[1TabPeças]`).
7. Importação da planilha Getnet sem DevExpress.
8. Implantação na loja: serviço Windows ou Docker, HTTPS interno e **backup do banco**. Hoje o backup é feito pelo
   próprio desktop às quartas-feiras; quando o desktop sair, esse papel precisa de outro dono.

### Fase 4 — ordem dos módulos (proposta)

1. **Fatia vertical de validação**, só leitura: login, sidebar, consulta de clientes e um relatório simples com golden
   master. Prova stack, conexão, implantação na loja e convivência.
2. Cotações; clientes (edição); estoque; matéria-prima.
3. Consertos; saídas.
4. Vendas; conta corrente; financeiro (cartões, cheques, Getnet). É o núcleo de maior risco, por isso fica por último
   e com golden master forte.
5. Relatórios restantes e gerencial.

### Fase 5 — ciclo por módulo

`/speckit.specify` (alimentado por `docs/legado/<módulo>.md` + RNs) → `/speckit.clarify` (dúvidas ao dono) →
`/speckit.plan` → `/speckit.tasks` → `/speckit.analyze` → `/speckit.implement`.
Aceite: testes de contrato da API, E2E Playwright, golden master batendo e revisão do dono.

## Para começar o Spec Kit

Na máquina de desenvolvimento, na raiz do repositório:

```powershell
uvx --from git+https://github.com/github/spec-kit.git specify init --here --ai claude
```

Depois, levar o conteúdo de `docs/web/constituicao-rascunho.md` para `.specify/memory/constitution.md` (via
`/speckit.constitution`).

## Documentos

- [`constituicao-rascunho.md`](constituicao-rascunho.md): princípios inegociáveis para humanos e agentes.
- [`glossario.md`](glossario.md): vocabulário do domínio.
- [`../legado/00-mapa-de-navegacao.md`](../legado/00-mapa-de-navegacao.md): ribbon → telas → SQL prévio.
- [`../legado/01-modulos.md`](../legado/01-modulos.md): módulos, tabelas, sidebar proposta, candidatos a código morto.
