
CREATE VIEW [dbo].[Beth]
AS
SELECT        TOP (100) PERCENT dbo.[1TabPeças].Classe + dbo.[1TabPeças].Modêlo AS Ficha, CONVERT(VARCHAR, dbo.VENDAS.DataVenda, 103) AS Data, dbo.[1TabPeças].Obs AS Descrição, dbo.METAIS.OuroQtde AS [Peso Ouro], 
                         dbo.VENDAS.ValorFinal AS [Preço Venda]
FROM            dbo.[1TabPeças] INNER JOIN
                         dbo.[VENDAS DET] ON dbo.[1TabPeças].IDPeça = dbo.[VENDAS DET].Peça INNER JOIN
                         dbo.VENDAS ON dbo.[VENDAS DET].Venda = dbo.VENDAS.Id LEFT OUTER JOIN
                         dbo.METAIS ON dbo.[1TabPeças].IDPeça = dbo.METAIS.Id
WHERE        (dbo.VENDAS.IDCliente = 4781)
ORDER BY Data
