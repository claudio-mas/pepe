# Equipe de agentes no Maestri

Como montar, no [Maestri](https://www.themaestri.app) (Windows 11), a equipe que continua a versão web:
**Regente**, **Dev**, **Testador** e **Revisor**. Cada papel tem o texto das instruções em um arquivo desta pasta
(`regente.md`, `dev.md`, `testador.md`, `revisor.md`), pronto para colar em *Settings → Agents*.

Os nomes de menus abaixo seguem a documentação oficial do Maestri (em inglês); o app em português pode rotulá-los
diferente. O que o Maestri faz com as instruções de um papel (um `CLAUDE.md`/`AGENTS.md` numa subpasta do projeto) foi
lido na documentação, não testado: confira na primeira execução, como diz a seção "Primeira vez".

## O fluxo de uma entrega

```
Dono ──pede──▶ Regente ──brief na nota──▶ Testador ──testes falhando (vermelho)──▶ Dev
                  ▲                                                                  │
                  │                         Testador ◀──── "implementado" ───────────┘
                  │                            │ roda tudo (lint, tipos, testes, E2E)
                  │                            ▼
                  └───── veredito ◀──── Revisor (só lê o diff e comenta)
                  │
                  └─ commit, push e PR em rascunho ──▶ Dono revisa e mescla
```

1. **Regente** lê `specs/<NNN>/tasks.md`, escolhe o próximo bloco de tarefas (uma história ou fase = um PR), cria a
   branch a partir do `master` atualizado e escreve o brief numa nota compartilhada.
2. **Testador** escreve os testes das tarefas primeiro e confirma que falham pelo motivo certo.
3. **Dev** implementa até os testes passarem, sem mexer nos testes.
4. **Testador** roda a bateria completa.
5. **Revisor** lê o diff e devolve os achados. **Dev** corrige; o Testador roda de novo.
6. **Regente** faz commit, push e abre o PR em rascunho. **Só o dono mescla.**

## Montagem no canvas

Um workspace do Maestri apontando para a raiz do repositório (`C:\Sistema\Paco\Pepe`) e **um andar (floor) por
entrega**: o andar é uma cópia isolada com branch própria, então o `master` do dono fica intocado. No andar, quatro
terminais:

| Terminal | Papel | Agente | Observações |
|---|---|---|---|
| Regente | `regente.md` | Claude Code | Marque **Maestro** (Edit Terminal → Details). Conecta-se à nota "Brief" e a todos. |
| Dev | `dev.md` | Claude Code | Conectado ao Regente, ao Testador e à nota "Brief". |
| Testador | `testador.md` | Claude Code | Conectado ao Regente, ao Dev e à nota "Brief". |
| Revisor | `revisor.md` | **Outro agente** (ex.: Codex) | Conectado só ao Regente e à nota "Brief". Modo somente leitura, se o preset oferecer. |

A nota **Brief** (arquivo Markdown do Maestri) é a fonte única da tarefa: tarefas escolhidas, critérios de pronto,
decisões do dono e o estado atual de cada papel. Os agentes escrevem nela; você lê o andamento ali.

Para o Regente montar a equipe sozinho, ele é o único que precisa do Maestro marcado. Na primeira mensagem, mencione
`@Maestro` no Prompt Composer (isso carrega a skill `/maestri-manager`) e peça, por exemplo:

> Monte a equipe da entrega: Dev e Testador em Claude Code, Revisor em Codex. Papéis: Dev, Testador e Revisor.
> Conecte os quatro à nota Brief. O Revisor só se conecta a você e à nota.

## Regras de ouro (valem para os quatro; estão repetidas em cada papel)

1. **Nunca** mesclar, nunca dar push no `master`, nunca publicar (`Publicar-ClickOnce.ps1`) nem mexer na loja.
2. **O banco real não é dos agentes.** Golden master e paridade na cópia real (`golden-master`, `paridade-ficha`)
   só o dono roda, com a configuração que fica fora do repositório. Os agentes usam só o banco de teste sintético.
3. **Só um papel mexe no banco de teste de cada vez: o Testador.** `pnpm -r test` e o E2E recriam o `BDTorrasTeste`
   e usam a porta 3999; duas execuções ao mesmo tempo se atropelam. O Dev roda só lint, tipos e testes unitários.
4. Nenhum dado de cliente em log, teste, commit ou nota (constituição V.3). Senhas e configurações nunca entram no git.
5. Commit com arquivos escolhidos um a um (`Pepe/bin` e `Pepe/obj` são versionados: nada de `git add -A`) e mensagem
   gravada em arquivo UTF-8 (`git commit -F`).
6. Dúvida de negócio ou de escopo: **perguntar ao dono**, uma pergunta de cada vez, antes de seguir.

## Primeira vez

- Depois de abrir o Maestri pela primeira vez, olhe o que ele gravou nas configurações dos agentes (`~/.claude`,
  `~/.codex`): uma análise de terceiros relatou que, na primeira execução no Windows, ele instalou 28 pastas de skills nas
  configurações dos agentes. Confira se concorda. A versão para Windows é recente (primeira versão pública em
  agosto de 2026), então espere arestas.
- Confira onde cada papel guardou o `CLAUDE.md`/`AGENTS.md` e se o agente continua lendo o `CLAUDE.md` da raiz do
  repositório. O Codex **não** lê o `CLAUDE.md`: por isso `revisor.md` manda ler os arquivos do projeto explicitamente.
- Pré-requisitos na máquina: Docker Desktop em execução, Node 24 e pnpm 12.15.0 (`corepack prepare pnpm@12.15.0
  --activate`), `pnpm install` em `web/`, e uma vez `pnpm --filter @pepe/spa exec playwright install chromium`.

## Primeira tarefa sugerida

> Termine a entrega 001 (`specs/001-consulta-clientes`): T059 a T064, em um único PR. T065 é com o dono. O golden
> master já passou na cópia real (5.168, 6 e 5 linhas, sem diferença); registre esse resultado, sem dado de cliente.

Depois da 001, o Regente usa o ciclo do Spec Kit (`/speckit-specify`, `-clarify`, `-plan`, `-tasks`, `-implement`)
para o próximo módulo. As perguntas de esclarecimento da especificação são sempre ao dono.
