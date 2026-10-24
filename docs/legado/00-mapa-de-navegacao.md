# Mapa de navegação do sistema desktop

Levantado a partir de `Pepe/Datasets/frmDevPrincipal.vb` (handlers) e `frmDevPrincipal.Designer.vb` (páginas, grupos e
legendas da ribbon), versão 6.0.3. Referências no formato `arquivo:linha`, relativas a `Pepe/`.

Legenda da coluna **Visível**: "sim" = aparece na ribbon; "oculto" = `Visibility = OnlyInCustomizing` (só aparece no
modo de personalização, ou seja, inacessível ao usuário).

## Entrada

1. `ApplicationEvents.vb` (`Startup`) → `modConexao.PrepararConexao()` → `frmAcesso`.
2. `frmAcesso.vb:12` — o login pede **só uma senha** (sem usuário). Ela é comparada com **duas senhas fixas no código**,
   sem distinção de perfil. A validação remota que existia está comentada. → `frmDevPrincipal.Show()`.
3. `frmDevPrincipal_Load` (`frmDevPrincipal.vb:70`) — **backup do banco às quartas-feiras**, uma vez por dia:
   `BACKUP DATABASE BDTorras TO DISK = 'G:\Meu Drive\Backup Sistema\Backup{1,2}.bak'`, com rodízio entre dois arquivos e
   o controle "já fez hoje" em `My.Settings.BackupSQL`.
4. `frmDevPrincipal_Activated` (`:287`) — os avisos de cartões e cheques a vencer na semana estão **desligados** (o
   `Exit Sub` da linha 290 vem antes do código). O botão "Não exibir avisos" (`ckAvisos`) fica oculto.

Padrão das telas: cada formulário é aberto pela instância padrão do VB (`frmX.Show()`), esconde a `frmDevPrincipal` no
`Load` e a restaura no `FormClosing`.

## Ribbon

### Página PRINCIPAL

| Grupo | Botão | Visível | Abre | SQL rodado antes de abrir |
|---|---|---|---|---|
| CADASTROS | Clientes | sim | `frmClientesDG` | — |
| CADASTROS | Estoque | sim | `frmEstoqueDG` | — |
| CADASTROS | Reajuste | sim | `frmReajuste` | — |
| COMERCIAL | Vendas | sim | `frmVendasDG` | `:64` apaga `[Vencto Cartão]`/`[Vencto Cheques]` com `idcc = -1`; `:65` recalcula `vendas.peças = dbo.fPeças(Id)` de **todas** as vendas desde 01/01/2020 |
| COMERCIAL | Consertos | sim | `frmConsertos` | — |
| COMERCIAL | Saídas | sim | `frmSaidasDG` | — |
| FINANCEIRO | Cartão de Crédito | sim | `Financeiro/frmCartoesDG` | `:52` limpeza `idcc = -1` (como em Vendas) + `exec USP_Cartões` |
| FINANCEIRO | Importação Getnet | sim | `Financeiro/frmGetnet` | — |
| FINANCEIRO | Controle Getnet | sim | `Financeiro/frmGetnetDG` | `:413-416` quatro `UPDATE` que sincronizam `Aut`/`AutDeb` de `VENDAS` para `[Vencto Cartão]` (a partir de 12/2022) |
| FINANCEIRO | Cheques | sim | `Financeiro/frmChequesDG` | `:39` limpeza `idcc = -1` + `exec USP_Cheques` |
| FINANCEIRO | Conta Corrente | sim | `frmCCdg` | — |
| FINANCEIRO | Preço do ouro | oculto | `Financeiro/frmOuro` (modal) | `:423` roda `C:\Sistema\Paco\GetDolar.exe` e espera 5 s |
| FINANCEIRO | Cotação Dólar, Ouro e Prata | sim | `frmCota` (modal) | — |

### Página RELATÓRIOS

| Botão | Visível | Abre | SQL rodado antes de abrir |
|---|---|---|---|
| Vendas | sim | `Relatorios/VendasBase` | — |
| Cartão | sim | `Relatorios/CartãoBase` | — |
| Consertos | sim | `Relatorios/ConsertosBase` | — |
| Contas correntes | sim | `Relatorios/CCNovoBase` | — |
| Peças vendidas | sim | `Relatorios/PeçasVendidasBase` | `:192` `update [1TabPeças] set Vendida = 0 where Vendida is null` |
| Peças registradas | sim | `Relatorios/PeçasRegBase` | — |
| Custos de peças vendidas | sim | `Relatorios/CustoPeçasVendidasBase` | — |
| Clientes sem compras | sim | `Relatorios/ClientesSemComprasBase` | — |
| Compras por cliente | sim | `Relatorios/ComprasPorClienteBase` | — |
| Peças em estoque | sim | `Relatorios/PeçasEmEstoqueNovoBase` | `:224` mesmo `update ... Vendida = 0` |
| Balanço | sim | 4 pré-visualizações em sequência: `Balanço5`, `Balanço4`, `Balanço3`, `Balanço2` (`:229`) | `:230` mesmo `update ... Vendida = 0` |
| Relatório gerencial old | oculto | `Relatorios/GerencialBase` | — |
| Relatório gerencial | sim | `Relatorios/GerencialNovoBase` | — |
| Cheques pré | sim | `Relatorios/ChequesPreBase` | — |
| Cartões a receber | sim | `Relatorios/CartoesAReceberBase` | — |
| Geral de clientes | sim | `Relatorios/GeralClientesBase` | — |
| Tabela de preços | sim | `Relatorios/Tabela de Preços Base` | — |
| Clientes cadastrados | sim | `Relatorios/ClientesCadastrados` | — |
| Matéria prima | sim | `frmMatPrimaDG` | — |
| Saídas | sim | `Relatorios/frmSaidasBase` | — |
| Inconsistências | sim | `frmInconsist` | — |

### Página RELATÓRIOS ANTIGOS

| Botão | Visível | Abre |
|---|---|---|
| Endereços de clientes | sim | `Relatorios/EndereçosClientesBase` |
| Telefones de clientes | sim | `Relatorios/TelefonesClientesBase` |
| Peças em estoque (antigo) | sim | `Relatorios/PeçasEmEstoqueBase` (`:218`, mesmo `update ... Vendida = 0`) |
| Sair | sim | encerra o aplicativo |

### Página SAÍDA DO SISTEMA

| Botão | Abre |
|---|---|
| Trocar usuário | volta ao `frmAcesso` (como só existe senha, sem usuário, na prática é "bloquear") |
| Sair | `Application.Exit()` |

### Página SKINS

A galeria de temas do DevExpress não tem equivalente funcional. Na web isso vira tema claro/escuro.

### Botões declarados mas fora da ribbon

`BarButtonItem1` "Lançamento de boletas", `BarButtonItem7` "Entradas F.P." (oculto), `BarButtonItem24` "Cheques pré",
`BarButtonItem2` "Importar planilha" e `BarButtonItem3` "Verificar recebimentos". Nenhum está ligado a um grupo nem a um
handler. São candidatos a código morto (ver `01-modulos.md`).

## Navegação entre telas (fora da ribbon)

| De | Para | Onde |
|---|---|---|
| `frmClientesDG` | `frmClientes` (ficha) | `frmClientesDG.vb:49,55` |
| `frmClientesDG` | `frmNewVenda` (nova venda para o cliente; faz `insert into vendas`) | `:115` |
| `frmClientesDG` | `frmEtiquetas`, `frmEtiqAniv` (etiquetas de endereço e de aniversário) | `:90,125` |
| `frmClientesDG` | `EndereçosClientesBase`, `TelefonesClientesBase` | `:188,193` |
| `frmClientes` | `frmCompras` (modal), `frmVendasClienteBase`, `frmConsertosfrm`, `frmNewVenda`, `frmCC` | `frmClientes.vb:219-271` |
| `frmVendasDG` | `frmNewVenda` | `frmVendasDG.vb:45,51` |
| `frmNewVenda` | `frmVendaCC` (modal: lançar a venda na conta corrente) | `frmNewVenda.vb:1237` |
| `frmNewVenda` | `frmTaxasCartão` (modal: cadastro de cartões e taxas, tabela `Cartões`; grava ao fechar) | `frmNewVenda.vb:576` |
| `frmVendaCC` | `frmConsertosfrm`, `frmNewVenda`, `frmCC` | `frmVendaCC.vb:21-34` |
| `frmConsertos` | `frmConsertosfrm` (ficha do conserto) | `frmConsertos.vb:103,109` |
| `frmConsertosfrm` | `frmVendaCC` (modal) | `frmConsertosfrm.vb:895` |
| `frmEstoqueDG` | `frmEstoque` (ficha da peça) | `frmEstoqueDG.vb:41,48` |
| `frmEstoque` | `frmPastaFotos` (modal), `frmNewVenda`, `frmVolta` (modal: "volta" da peça vendida ao estoque com novo nº de ficha, `exec USP_VOLTA`) | `frmEstoque.vb:290,743,758` |
| `frmReajuste` | `frmSenha` (modal; aplica e desfaz o reajuste de preços com histórico) | `frmReajuste.vb:68,83` |
| `frmCCdg` | `frmClientes`, `frmRptCartõesBase`, relatórios `rptExtratoCC` e `rpt_CC_Saldos` | `frmCCdg.vb:44,81,98,125` |
| `frmChequesDG` | `frmChequeAvulso`, `frmRptChequesBase` | `Financeiro/frmChequesDG.vb:137,176` |
| `frmCartoesDG` | `frmRptCartõesBase` | `Financeiro/frmCartoesDG.vb:181` |
| `frmMatPrimaDG` | `frmConsertosfrm`, relatório `rptMatPrima` | `frmMatPrimaDG.vb:113,119,158` |
| `frmInconsist` | `frmEstoque`, `frmNewVenda` (corrigir o registro inconsistente) | `frmInconsist.vb:56-77` |
| `modConn` | `frmEstoque` | `modConn.vb:165` |

## Observações para a versão web

- **Manutenção disfarçada de navegação.** Vários botões corrigem dados antes de abrir a tela: limpeza de parcelas
  órfãs (`idcc = -1`), `Vendida = 0` onde está nulo, recálculo de `vendas.peças` e sincronização de autorizações Getnet.
  Na convivência, esse SQL **continua rodando pelo desktop**. A web não pode depender de que ele já tenha rodado: cada
  regra precisa ser tratada na leitura (ex.: `ISNULL(Vendida, 0)`) ou virar um job explícito. Cada caso vira uma RN no
  inventário do módulo.
- **O backup do banco é feito pelo cliente desktop.** Se o desktop for aposentado, o backup precisa de outro dono
  (agente do SQL Server, tarefa agendada no servidor da loja). Isso é um item de ADR.
- **Autenticação inexistente na prática**: uma senha compartilhada, sem usuário e sem perfil. A web vai precisar de
  usuários reais. Decidir perfis (dono, vendedora) é item do PRD.
- **Dependências da máquina local**: `GetDolar.exe`, o caminho `G:\Meu Drive\...` do backup, a pasta de fotos e a
  impressora de etiquetas.
