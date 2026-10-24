# Índice de módulos do sistema desktop

Visão de primeiro nível para fatiar o inventário (Fase 1) e as specs (Fase 5). Cada módulo vai ganhar um arquivo
próprio, `docs/legado/<nn>-<modulo>.md`, com telas, campos, validações, cálculos, as regras de negócio (`RN-<MÓD>-nnn`
com origem `arquivo:linha`) e a matriz CRUD completa.

As colunas "Tabelas" e "Escritas" abaixo são **preliminares**. Saíram dos TableAdapters dos `.xsd`, do
`Relatorios/lqGerencial.dbml` e de uma varredura textual de `INSERT`/`UPDATE`/`DELETE`/`EXEC` no código. Escritas feitas
por TableAdapter (`UpdateAll`) e por procs só serão confirmadas no inventário de cada módulo.

Caminhos relativos a `Pepe/`.

## Proposta de sidebar

| Grupo | Itens | Origem na ribbon |
|---|---|---|
| Cadastros | Clientes, Estoque, Reajuste de preços, Matéria-prima | PRINCIPAL › CADASTROS (+ Matéria prima, hoje em RELATÓRIOS) |
| Comercial | Vendas, Consertos, Saídas | PRINCIPAL › COMERCIAL |
| Financeiro | Conta corrente, Cartões, Cheques, Getnet (importação + controle), Cotações | PRINCIPAL › FINANCEIRO |
| Relatórios | Os relatórios agrupados por assunto (vendas, peças, clientes, financeiro, gerencial) | RELATÓRIOS + RELATÓRIOS ANTIGOS |
| Administração | Inconsistências, Usuários (novo), Cadastro de cartões e taxas | RELATÓRIOS › Inconsistências; `frmTaxasCartão` |

## Módulos

### CLI — Clientes
- **Telas**: `frmClientesDG` (lista), `frmClientes` (ficha), `frmCompras` (modal a partir da ficha), `frmEtiquetas`, `frmEtiqAniv`.
- **Relatórios**: `ClientesCadastrados`, `ClientesSemComprasBase`, `ComprasPorClienteBase`, `GeralClientesBase`,
  `EndereçosClientesBase`, `TelefonesClientesBase`, `frmVendasClienteBase` (`USP_RPT_VENDA_CLIENTE`), etiquetas
  (`rptEtiquetas`, `rptEtiquetasAniv`).
- **Tabelas**: `Clientes`, `Vendedoras`, `VENDAS`, `[VENDAS DET]`, `[Vencto Cheques]`, `CC`.
- **Escritas**: `update Clientes set Imp` (marca para etiqueta); `insert into vendas` (nova venda a partir da lista);
  ficha via TableAdapter; `frmClientes` apaga parcelas em `[Vencto Cartão]`/`[Vencto Cheques]`.
- **Dados pessoais**: nome, endereço, telefones, aniversário. É o foco de LGPD.

### EST — Estoque de peças
- **Telas**: `frmEstoqueDG` (lista), `frmEstoque` (ficha da peça, 868 linhas), `frmPastaFotos`, `frmVolta`, `frmReajuste` + `frmSenha`.
- **Relatórios**: `PeçasEmEstoqueNovoBase`, `PeçasEmEstoqueBase` (antigo), `PeçasRegBase` (+ subs; `USP_RPT_PECAS_REG*`),
  `PeçasVendidasBase` (+ sub; `USP_PECAS_VENDIDAS_PIVOT`), `CustoPeçasVendidasBase`, `Tabela de Preços Base`, Balanço
  (`Balanço2`–`Balanço5`).
- **Tabelas**: `[1TabPeças]`, `[1TabPeçasHistórico]`, `METAIS`, `PEDRAS`, `Reajustes`, views `VI_PEÇAS*`, `VI_METAIS*`,
  `VW_RG2_ESTOQUE`, `VW_RG2_PECAS_*`.
- **Escritas**: `update [1TabPeças]`; `insert into METAIS`/`PEDRAS`; `exec USP_CLONA_PECA`; `exec USP_VOLTA`; o
  reajuste (`frmSenha`) grava e desfaz em `Reajustes` e `[1TabPeçasHistórico]` e atualiza preços em `[1TabPeças]`.
- **Particularidades**: foto gravada **no banco** (coluna binária `[1TabPeças].Foto`, `frmEstoque.vb:800-812`);
  importação em lote de fotos de uma pasta (`frmPastaFotos`); família/metal Ou, Ag, Boutique (`Scripts/BOU_v1_up.sql`).

### VEN — Vendas
- **Telas**: `frmVendasDG` (lista), `frmNewVenda` (lançamento, 1279 linhas: o coração do sistema), `frmVendaCC`
  (modal: venda na conta corrente), `frmTaxasCartão` (modal).
- **Relatórios**: `VendasBase` + `Vendas` + `VendasSaidas` (`USP_RPT_VENDAS`, `USP_VENDAS_SAIDAS`).
- **Tabelas**: `VENDAS`, `[VENDAS DET]`, `[1TabPeças]`, `Clientes`, `Vendedoras`, `[Vencto Cartão]`, `[Vencto Cheques]`,
  `[Conta Corrente]`, `CC`, `Cartões`; função `dbo.fPeças`.
- **Escritas**: `insert`/`delete` em `VENDAS` e `[VENDAS DET]`; `update VENDAS set` comissão, peças, débito, cartão de
  débito, transferência; geração e remoção de parcelas em `[Vencto Cartão]`/`[Vencto Cheques]`; lançamentos em
  `[Conta Corrente]`; baixa da peça em `[1TabPeças]`.
- **Risco**: máximo. Uma venda grava em pelo menos 6 tabelas, em comandos ADODB soltos, montados por concatenação
  de strings e **sem transação** (nenhuma ocorrência de `BeginTrans`/`Transaction` em `frmNewVenda.vb`,
  `frmConsertosfrm.vb`, `frmCC.vb` nem `modConn.vb`). A web tem que reproduzir o mesmo resultado gravado, mas dentro de
  uma transação e com parâmetros.

### CON — Consertos
- **Telas**: `frmConsertos` (lista), `frmConsertosfrm` (ficha, 918 linhas).
- **Relatórios**: `ConsertosBase`; entra no gerencial (`USP_Gerencial_Consertos`, `VI_CONSERTOS`).
- **Tabelas**: `CONSERTOS`, `Clientes`, `Vendedoras`, `[Conta Corrente]`, `[Vencto Cartão]`, `[Vencto Cheques]`.
- **Escritas**: `insert`/`delete` em `CONSERTOS`; parcelas de cartão e cheque; lançamentos em conta corrente.
- Também é aberto pela matéria-prima (`frmMatPrimaDG`), que consome material nos consertos.

### SAI — Saídas
- **Telas**: `frmSaidasDG`.
- **Relatórios**: `frmSaidasBase` (`rptSaidas`); entra em `VendasSaidas` e no gerencial (`VI_SAIDAS`).
- **Tabelas**: `Saidas`, `TiposSaidas` (cadastro de motivos: `Id`, `Motivo`), `[1TabPeças]`.
- **Escritas**: grade editável em `Saidas` (TableAdapter); `update [1TabPeças]` (baixa e custo da peça).
- **Definição (dono, 24/10/2026)**: saída é a retirada de uma peça do estoque por qualquer motivo que não seja venda. O
  motivo é a coluna "Saída para" (`Saidas.IdMotivo` → `TiposSaidas.Id`, `frmSaidasDG.Designer.vb:363-365`), e a
  lista de motivos é dado mantido pelo usuário, não fixa no código.

### CC — Conta corrente
- **Telas**: `frmCCdg` (saldos por cliente), `frmCC` (extrato e lançamentos).
- **Relatórios**: `CCNovoBase`, `rptExtratoCC`, `rpt_CC_Saldos`; views `VI_CC`, `VI_CC2`, `CCNovoGer`.
- **Tabelas**: `CC`, `CC2`, `[Conta Corrente]`, `tabExtrato`, `tabCartõesRpt`, `[Vencto Cartão]`, `[Vencto Cheques]`.
- **Escritas**: `exec USP_UPDATE_SALDO_CC`, `exec USP_CC_SALDO_INICIAL`; `tabExtrato` é tabela de trabalho (apagada e
  preenchida a cada relatório); lançamentos em `[Conta Corrente]`.
- **Risco**: alto. O saldo é recalculado por proc; `Scripts/CCFIX_v1_*.sql` indica correção recente. Precisa de golden
  master forte.

### FIN — Cartões, cheques e Getnet
- **Telas**: `Financeiro/frmCartoesDG`, `Financeiro/frmChequesDG`, `frmChequeAvulso`, `Financeiro/frmGetnet`
  (importação da planilha, aba "CARTÕES", via `DevExpress.Spreadsheet`), `Financeiro/frmGetnetDG` (conciliação, `VI_Getnet`).
- **Relatórios**: `CartãoBase`, `CartoesAReceberBase`, `ChequesPreBase`, `frmRptCartõesBase`, `frmRptChequesBase`.
- **Tabelas**: `[Vencto Cartão]`, `[Vencto Cheques]`, `tabCartões`, `tabCheques`, `tabCartõesRpt`, `tabChequesRpt`,
  `Cartões`, `Getnet`, `Getnet_temp`, `VENDAS`.
- **Escritas**: `exec USP_Cartões`/`USP_Cheques` (preparam as tabelas `tab*` ao abrir); `insert` em `Getnet`/`Getnet_temp`;
  `frmChequeAvulso` registra o cheque avulso como uma linha de `VENDAS` e gera as parcelas em `[Vencto Cheques]` (`frmChequeAvulso.vb:124`); ao excluir, apaga as duas (`:271-272`).
- **Na web**: a importação da planilha Getnet precisa de outro leitor de Excel no servidor (ex.: SheetJS/ExcelJS).

### COT — Cotações
- **Telas**: `frmCota` (dólar, ouro e prata; uma cotação por dia), `Financeiro/frmOuro` (oculto; depende do `GetDolar.exe`).
- **Tabelas**: `Cotação` (a coluna `ValPrata` vem de `Scripts/RG2_v1_up.sql`).
- **Estado global**: `valDolar`, `valOuro`, `valPrata` em `modInternas.vb`, usados no cálculo de preços. Na web vira
  "cotação vigente" consultada no servidor.

### MP — Matéria-prima
- **Telas**: `frmMatPrimaDG` (hoje na página RELATÓRIOS, mas edita dados).
- **Relatórios**: `rptMatPrima`.
- **Tabelas**: `tabMatPrima`, `tabMateriaPrima`, `Meses`; `exec USP_MATPRIMA`.

### GER — Relatórios gerenciais
- `GerencialNovoBase` + `GerencialNovo` + `GerencialNovoDados` (atual; views `VW_RG2_*` + `lqGerencial.dbml`);
  `GerencialBase` (antigo, oculto, mas é a referência de vários critérios do novo: `GerencialNovoDados.vb:269,289`).
- Procs: `USP_Gerencial_Cartoes`, `USP_Gerencial_Consertos`. Views: `VI_GER_CRED`, `VI_GER_DEB`, `VI_VENDAS`,
  `VI_VENDIDAS`, `VI_W`.
- Já existe o harness `Scripts/VerificaLayout.vb`, e a conferência valor a valor é a prática do projeto. Bom candidato a
  golden master.

### ADM — Administração e qualidade de dados
- **Telas**: `frmInconsist` (lista registros com erro e abre a tela para corrigir; apaga peças e vendas marcadas como
  "excluir"), `frmAcesso` (login), `frmConexao` (configuração de conexão por máquina).
- **Tabelas**: tabelas de inconsistência (`Inconsist1`, `2`, `4` e `5` nos DataSets; a confirmar se são views).
- **Na web**: usuários, perfis e auditoria são novos (tabelas no schema `web`).

## Fora do escopo da web (confirmado pelo dono em 24/10/2026)

Nenhum item abaixo vira spec nem tela na web. Itens que servem de referência de cálculo continuam valendo como fonte de RN.

| Item | Evidência |
|---|---|
| `frmVenda`, `frmVendaPeça` | Só se referenciam entre si; a venda atual é a `frmNewVenda` |
| `AForm1`, `ccvendaconserto`, `x.vb` | Nenhuma referência |
| `Relatorios/Balanço.vb` | Fora do `.vbproj` |
| `Balanço0`, `BalançoBase` | Só são abertos pela linha comentada `frmDevPrincipal.vb:231` |
| `Balanço41BR`, `Balanço42GAR`, `Balanço43OUT`, `Balanço44PEN` | Nenhuma referência fora dos próprios arquivos |
| `rptMateriaPrima` | Só aparece em código comentado |
| `GerencialBase` (botão oculto) | Substituído pelo `GerencialNovoBase`; vale como referência de cálculo, não como tela |
| `PeçasEmEstoqueBase` (página RELATÓRIOS ANTIGOS) | Existe a versão nova `PeçasEmEstoqueNovoBase` |
| `Financeiro/frmOuro` (botão oculto) | Substituído por `frmCota` |
| Botões soltos da ribbon (`BarButtonItem1/2/3/7/24`) | Sem grupo nem handler |
| Avisos de vencimento (`frmDevPrincipal.vb:287-345`) | Desligados por `Exit Sub`. O dono decidiu que **não voltam** na web |

## Próximos inventários (ordem sugerida, alinhada ao roadmap)

1. [`10-clientes.md`](10-clientes.md) (fatia de validação: só leitura). **Pronto.**
2. `11-cotacoes.md`, `12-estoque.md`, `13-materia-prima.md`
3. `14-consertos.md`, `15-saidas.md`
4. `16-vendas.md`, `17-conta-corrente.md`, `18-financeiro.md`
5. `19-relatorios.md` (um quadro por relatório: filtros, fonte, colunas, totais e período de referência para o golden master)
6. [`90-banco.md`](90-banco.md): análise do catálogo extraído do `BDTorras` (saída em [`banco/`](banco/README.md)). **Pronto.**
