CREATE VIEW dbo.getnet5
AS
SELECT        'C. C.' AS Venda, dbo.[Conta Corrente].Data AS DataVenda, dbo.[Conta Corrente].Cartão AS ValorFinal, LEFT(dbo.[Vencto Cartão].Parcela, CHARINDEX('/', dbo.[Vencto Cartão].Parcela) - 1) AS Parc, dbo.[Vencto Cartão].Vencto, 
                         dbo.[Vencto Cartão].VValor, dbo.[Vencto Cartão].Pagto, dbo.[Vencto Cartão].Aut, dbo.getnet.Total AS [Total Getnet], dbo.getnet.Liquido AS [Valor Parcela Getnet], ISNULL(dbo.Clientes.Nome, dbo.[Conta Corrente].Cliente) AS Cliente, 
                         CASE WHEN [Vencto Cartão].Parcela IS NULL THEN NULL ELSE RIGHT([Vencto Cartão].Parcela, len([Vencto Cartão].Parcela) - CHARINDEX('/', [Vencto Cartão].Parcela)) END AS Parcelas, dbo.[Conta Corrente].FormaCartão
FROM            dbo.[Vencto Cartão] INNER JOIN
                         dbo.[Conta Corrente] ON dbo.[Vencto Cartão].IdCC = dbo.[Conta Corrente].ID INNER JOIN
                         dbo.Clientes ON dbo.[Conta Corrente].Cliente = dbo.Clientes.IDCliente LEFT OUTER JOIN
                         dbo.getnet ON dbo.[Vencto Cartão].Aut = dbo.getnet.Aut AND LEFT(dbo.[Vencto Cartão].Parcela, CHARINDEX('/', dbo.[Vencto Cartão].Parcela) - 1) = dbo.getnet.Parcela
WHERE        (dbo.[Vencto Cartão].Aut IS NOT NULL)
