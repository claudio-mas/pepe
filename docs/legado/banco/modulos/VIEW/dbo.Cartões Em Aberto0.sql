CREATE VIEW [dbo].[Cartões Em Aberto0]
AS
SELECT        dbo.[Vencto Cartão].IdCC, dbo.[Vencto Cartão].IdConserto, dbo.[Vencto Cartão].Id AS IDC, ISNULL(dbo.VENDAS.SEMCADASTRO, dbo.Clientes.Nome) AS N, dbo.Clientes.Nome, dbo.VENDAS.Venda, 
                         dbo.VENDAS.DataVenda, dbo.VENDAS.NomeCartão, dbo.[Vencto Cartão].Parcela, dbo.[Vencto Cartão].VValor, dbo.[Vencto Cartão].Pagto, dbo.[Vencto Cartão].Vencto, dbo.VENDAS.ValorFinal
FROM            dbo.VENDAS LEFT OUTER JOIN
                         dbo.Clientes ON dbo.VENDAS.IDCliente = dbo.Clientes.IDCliente RIGHT OUTER JOIN
                         dbo.[Vencto Cartão] ON dbo.VENDAS.Id = dbo.[Vencto Cartão].Venda
