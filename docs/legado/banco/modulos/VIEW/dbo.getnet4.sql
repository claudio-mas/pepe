CREATE VIEW dbo.getnet4
AS
SELECT        'Conserto' AS Venda, dbo.CONSERTOS.DT AS DataVenda, dbo.CONSERTOS.VVALOR AS ValorFinal, LEFT(dbo.[Vencto Cartão].Parcela, CHARINDEX('/', dbo.[Vencto Cartão].Parcela) - 1) AS Parc, dbo.[Vencto Cartão].Vencto, 
                         dbo.[Vencto Cartão].VValor, dbo.[Vencto Cartão].Pagto, dbo.[Vencto Cartão].AutDeb AS Aut, dbo.getnet.Total AS [Total Getnet], dbo.getnet.Liquido AS [Valor Parcela Getnet], ISNULL(dbo.Clientes.Nome, dbo.Clientes.Cliente) 
                         AS Cliente, CASE WHEN [Vencto Cartão].Parcela IS NULL THEN NULL ELSE RIGHT([Vencto Cartão].Parcela, len([Vencto Cartão].Parcela) - CHARINDEX('/', [Vencto Cartão].Parcela)) END AS Parcelas, 
                         dbo.CONSERTOS.FormaCartão
FROM            dbo.[Vencto Cartão] INNER JOIN
                         dbo.CONSERTOS ON dbo.[Vencto Cartão].IdConserto = dbo.CONSERTOS.ID INNER JOIN
                         dbo.Clientes ON dbo.CONSERTOS.CLIENTE = dbo.Clientes.IDCliente LEFT OUTER JOIN
                         dbo.getnet ON dbo.[Vencto Cartão].AutDeb = dbo.getnet.Aut AND LEFT(dbo.[Vencto Cartão].Parcela, CHARINDEX('/', dbo.[Vencto Cartão].Parcela) - 1) = dbo.getnet.Parcela
WHERE        (dbo.[Vencto Cartão].AutDeb IS NOT NULL)
