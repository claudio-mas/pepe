CREATE VIEW [dbo].[Cheques Base]
AS
SELECT        TOP (100) PERCENT dbo.[Vencto Cheques].IdCC, dbo.[Vencto Cheques].IdConserto, dbo.[Vencto Cheques].Id AS IDV, ISNULL(dbo.VENDAS.SEMCADASTRO, dbo.Clientes.Nome) AS N, dbo.Clientes.Nome, 
                         dbo.VENDAS.Venda, dbo.VENDAS.DataVenda, ISNULL(dbo.[Vencto Cheques].Vencto, dbo.VENDAS.DataVenda) AS DataVendaAnt, dbo.[Vencto Cheques].Destino, dbo.[Vencto Cheques].Parcela, 
                         dbo.[Vencto Cheques].VValor, dbo.[Vencto Cheques].Pagto, dbo.[Vencto Cheques].Cheque, dbo.VENDAS.Banco, dbo.[Vencto Cheques].Uso, dbo.[Vencto Cheques].Obs, dbo.[Vencto Cheques].Vencto, 
                         dbo.VENDAS.ValorFinal
FROM            dbo.VENDAS LEFT OUTER JOIN
                         dbo.Clientes ON dbo.VENDAS.IDCliente = dbo.Clientes.IDCliente RIGHT OUTER JOIN
                         dbo.[Vencto Cheques] ON dbo.VENDAS.Id = dbo.[Vencto Cheques].Venda
