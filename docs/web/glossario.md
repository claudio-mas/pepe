# Glossário do domínio (rascunho)

Vocabulário da joalheria como aparece no sistema. Entradas marcadas **(a confirmar)** são dedução a partir do código e
precisam da validação do dono. Na coluna "No banco / código", caminhos relativos a `Pepe/`.

| Termo | Significado | No banco / código |
|---|---|---|
| Cliente | Pessoa que compra, encomenda conserto ou tem conta corrente na loja. Nome de exibição = `ISNULL(Nome, Cliente)`. | `Clientes` (`IDCliente`, `Nome`) |
| Mala direta (nome) | Nome do cliente como sai no envelope ou etiqueta. Na tela aparece como "Mala direta", mas a **coluna se chama `Cliente`**. Nas etiquetas tem preferência sobre `Nome`. | `Clientes.Cliente`; `docs/legado/10-clientes.md` |
| Cliente oculto | Cliente que não pode ser excluído por ter histórico (vendas, consertos, CC) e foi tirado das listas e dos combos. Continua nos relatórios históricos. Uso novo, da web. | `Clientes.Oculto`; RN-CLI-018 |
| Etiqueta (marcação) | Cliente marcado para sair na próxima impressão de etiquetas de mala direta; a marcação fica gravada no banco e é compartilhada entre os usuários (decisão do dono). | `Clientes.Imp` |
| Vendedora | Quem atende a venda ou o conserto; base da comissão. | `Vendedoras` |
| Venda | Registro de uma venda: cliente (ou "sem cadastro"), data, formas de pagamento, valor final, comissão. | `VENDAS` (`Id`, `Venda` = nº da venda, `DataVenda`, `SEMCADASTRO`, `ValorFinal`) |
| Item de venda | Peça vendida numa venda. | `[VENDAS DET]` |
| Venda interna | `VENDAS.Tipo = 'Interna'`: é o tipo normal (15.268 de 15.611 vendas), gravado também pela venda aberta a partir do cadastro de clientes. Os outros tipos ficam para o inventário de Vendas. | `frmClientesDG.vb:111`; `docs/legado/90-banco.md` |
| Peça | Joia do estoque, identificada por nº de ficha/modelo; tem classe, família, custo, preço, foto e situação (em estoque ou vendida). | `[1TabPeças]` (`IDPeça`, `Modêlo`, `Classe`, `Vendida`, `Custo`, `Foto`) |
| Ficha | Número que identifica a peça fisicamente. Na "volta", a peça ganha novo nº de ficha. | `frmVolta.vb` |
| Classe | Tipo da peça: `AN` (anel), `BR` (brinco), `GAR` (gargantilha), `PEN` (pingente), `PUL` (pulseira), `ALI` (aliança), `OUT` (peça diversa). Há classes legadas em peças vendidas (`BOU`, `BUT`). Os relatórios `Balanço41BR`/`42GAR`/`43OUT`/`44PEN` são o balanço por classe. | `[1TabPeças].Classe`; `Scripts/BOU_v1_up.sql` |
| Situação da peça | Em estoque = `Vendida = 0` e `Saida = 0`. O desktop troca `Vendida` nulo por 0 antes de vários relatórios. | `[1TabPeças].Vendida`, `.Saida`; `frmDevPrincipal.vb:192` |
| Família | O metal da peça: `Ou` (ouro), `Ag` (prata), `Ou / Ag`, `Boutique` (sem ouro nem prata). | `[1TabPeças].Familia`; `Scripts/BOU_v1_up.sql` |
| Boutique | Peça sem ouro nem prata (bijuteria/acessório). Até o `BOU_v1` também era uma classe; hoje é só família. | idem |
| Metais / Pedras | Composição da peça: metais (com peso) e pedras usados. | `METAIS`, `PEDRAS` |
| Histórico da peça | Registro das alterações de preço de cada peça. | `[1TabPeçasHistórico]` |
| Reajuste | Atualização de preços das peças em estoque, aplicada em lote e reversível. | `Reajustes`, `frmReajuste` + `frmSenha` |
| Volta | Retorno ao estoque de uma peça vendida, com novo nº de ficha. | `USP_VOLTA`, `frmVolta` |
| Clonar peça | Criar uma peça nova a partir de outra. | `USP_CLONA_PECA` |
| Conserto | Serviço de reparo/ajuste de joia para um cliente, com valor, pagamento e prazo. | `CONSERTOS` |
| Saída | Retirada de uma peça do estoque por qualquer motivo que não seja venda. O motivo ("Saída para") vem de uma lista mantida pelo próprio usuário. | `Saidas` (`IdMotivo`) → `TiposSaidas` (`Id`, `Motivo`); `frmSaidasDG` |
| Conta corrente (CC) | Saldo do cliente com a loja: vendas e consertos lançados a prazo e pagamentos recebidos. Não é uma tabela única: a view `CC` une vendas, consertos e lançamentos marcados como "na CC". | `CC`, `CC2`, `[Conta Corrente]`, `USP_UPDATE_SALDO_CC` |
| Extrato | Movimento da conta corrente de um cliente num período. | `tabExtrato` (tabela de trabalho), `rptExtratoCC` |
| Parcela de cartão | Vencimento a receber de uma venda, conserto ou CC paga no cartão. | `[Vencto Cartão]` (`Venda`, `IdConserto`, `IdCC`, `Parcela`, `Vencto`, `Pagto`) |
| Cheque pré | Cheque pré-datado recebido, controlado por vencimento e destino/uso. | `[Vencto Cheques]` (`Vencto`, `Uso`, `Destino`) |
| Cheque avulso | Cheque registrado fora de uma venda de peça. | `frmChequeAvulso` |
| `idcc = -1` | Parcela órfã, de um lançamento de CC que não foi concluído. O desktop as apaga ao abrir Vendas, Cartões e Cheques. **(a confirmar)** | `frmDevPrincipal.vb:39` |
| Cartões (cadastro) | Bandeiras/maquininhas e suas taxas. | `Cartões`, `frmTaxasCartão` |
| Getnet | Adquirente dos cartões. A planilha de recebimentos é importada para conciliar com as parcelas. | `Getnet`, `Getnet_temp`, `VI_Getnet` |
| Aut / AutDeb | Código de autorização da transação no crédito e no débito. | `VENDAS.Aut`, `VENDAS.AutDeb`, `[Vencto Cartão]` |
| Cotação | Valores do dia para dólar, ouro e prata, usados na precificação; uma por dia. | `Cotação` (`ValDolar`, `ValOuro`, `ValPrata`, `DataCot`) |
| Ouro fino / 18k | Base do cálculo de metal; 18k = 75% de ouro fino. | `GerencialNovoDados.vb:289` |
| Matéria-prima | Estoque de material (metal etc.) e seu consumo, inclusive em consertos. | `tabMatPrima`, `tabMateriaPrima`, `USP_MATPRIMA` |
| Balanço | Conjunto de relatórios de inventário do estoque. | `Relatorios/Balanço*` |
| Relatório gerencial | Visão consolidada do período: vendas, formas de pagamento, consertos, saídas, metais. | `Relatorios/GerencialNovo*`, `VW_RG2_*` |
| Inconsistências | Lista de registros com problema (ex.: venda sem peça, peça marcada para excluir) para corrigir. | `frmInconsist` |
