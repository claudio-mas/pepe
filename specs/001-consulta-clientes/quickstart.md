# Quickstart: validar a entrega 001 (consulta de clientes)

Guia para provar, de ponta a ponta, que a entrega funciona. Contratos em [`contracts/openapi.yaml`](contracts/openapi.yaml);
dados em [`data-model.md`](data-model.md); decisões em [`research.md`](research.md). Os comandos exatos de cada
pacote são definidos nas tarefas (`tasks.md`). Aqui ficam os cenários e os resultados esperados.

## Pré-requisitos

- Máquina de desenvolvimento com Node.js 24 LTS, pnpm e Docker.
- Contêiner `bdtorras_mssql` com a cópia restaurada do `BDTorras` (`docs/Configurar-maquina-nova.md`), para o golden
  master.
- Contêiner do **banco de teste sintético** (R12), para os testes automáticos. Ele é criado pelos scripts de teste e
  nunca tem dado real.
- Scripts do schema `web` e do login `pepe_web` aplicados primeiro na cópia do Docker (constituição I.3).

## 1. Testes automáticos (banco sintético)

| Etapa | O que roda | Esperado |
|---|---|---|
| Unitários | regras puras: nome de exibição, formatação de CPF, filtro de oculto, validação de período | todos passam |
| Contrato | cada rota de `contracts/openapi.yaml` contra o banco sintético, validando com os esquemas de `packages/shared` | respostas batem com o contrato; `401` sem sessão; `404` para cliente inexistente ou sem nome |
| E2E | as 4 histórias da spec no navegador | todos os cenários de aceite passam |

Comandos, em `web/` (com o Docker no ar): `pnpm -r test` roda os unitários e os de contrato, e
`pnpm --filter @pepe/spa test:e2e` roda os E2E. Os E2E compilam a SPA e sobem sozinhos o servidor de teste
(`apps/api/tests/e2e/servidor.ts`), que recria o banco sintético e cria o usuário E2E. Para usar um Chromium já
instalado, defina `PEPE_E2E_CHROMIUM` com o caminho do executável; para testar outro servidor, `PEPE_WEB_URL`.
Os dois comandos recriam o mesmo banco de teste: rode um de cada vez.

Casos que o banco sintético precisa ter: cliente só com mala direta; cliente sem nome nem mala direta; cliente
oculto (`Oculto = 1`) e com `Oculto` nulo; nomes repetidos; nome com acento (pesquisado sem acento); cliente com
lançamentos de CC das três origens; cliente com peças compradas e cliente sem nenhuma; venda de cliente inexistente
(órfã); clientes com e sem `DataCad`.

## 2. Procedimento de usuários (FR-004)

1. Criar um usuário pelo comando `usuario criar`, com a senha digitada sem eco. → aparece em `usuario listar`.
2. Entrar na web com ele. → entra; `web.RegistroAcesso` tem um `ENTRADA`.
3. Errar a senha 5 vezes. → bloqueado por 15 minutos; registro `BLOQUEIO`; a mensagem não diz se o erro foi no
   usuário ou na senha.
4. `usuario desativar` com a sessão aberta. → a próxima ação na web volta para a tela de entrada.
5. Conferir que a senha não aparece em nenhum arquivo, log ou histórico do terminal.

## 3. Golden master e paridade (cópia real, Docker)

Roteiro completo em `docs/web/golden-master.md` (criado nas tarefas). Saída fora do git (constituição V.3).

| Verificação | Como | Esperado |
|---|---|---|
| SC-004: relatório "Clientes cadastrados" | rodar a consulta do desktop (`ClientesCadastradosRpt.resx`) e a da web para "sem período" e para os dois meses de referência (R13) | mesma contagem; mesmo conjunto de linhas (comparação por resumo criptográfico de cada linha) |
| SC-003: paridade da ficha | sortear 20 clientes; comparar cadastro, lançamentos de CC (`dsCliente.CC`) e peças compradas (`dsCliente.Compras`) com as respostas da API | nenhuma diferença |
| Conferência visual | abrir 5 desses clientes no desktop e na web, lado a lado | o dono confirma |

## 4. Instalação no servidor da loja (R14)

1. Aplicar no `PEPETORRAS-PC\SQLEXPRESS` os mesmos scripts já testados no Docker (schema `web`, login `pepe_web`).
2. Instalar o serviço do Windows, o certificado e o arquivo de configuração fora do repositório.
3. No computador do dono: abrir `https://pepetorras-pc` (ou o nome configurado). → tela de entrada, sem alerta de
   certificado.
4. **SC-002**: com o desktop aberto e em uso, fazer 20 pesquisas variadas. → todas respondem em até 1 segundo.
5. **SC-005**: durante um dia de uso em paralelo, o desktop e o terceiro sistema (`VI_Pecas_Web`) seguem normais.
6. **SC-006**: procurar no log do serviço os nomes e telefones pesquisados no dia. → nenhuma ocorrência.

## 5. Critério de pronto

Testes automáticos verdes, golden master sem diferença, instalação na loja validada pelo dono (itens 4.3 a 4.6) e
nenhum `INSERT`/`UPDATE`/`DELETE` em tabela `dbo` vindo do login `pepe_web` (garantido pelas permissões, R10).
