
CREATE VIEW [dbo].[Gerencial2]
AS
SELECT        TOP (100) PERCENT dbo.[1TabPeças].Classe AS Peça, dbo.[1TabPeças].Modêlo AS Ficha, dbo.[1TabPeças].Família AS Tipo, dbo.[1TabPeças].Origem, CAST(dbo.VENDAS.DataVenda AS DATETIME) AS [Data da Venda], 
                         ISNULL(dbo.[1TabPeças].MOExt, 0) + ISNULL(dbo.[1TabPeças].MOInt, 0) AS [Mão de Obra], dbo.[1TabPeças].Outras
FROM            dbo.VENDAS INNER JOIN
                         dbo.[VENDAS DET] ON dbo.VENDAS.Id = dbo.[VENDAS DET].Venda INNER JOIN
                         dbo.[1TabPeças] ON dbo.[VENDAS DET].Peça = dbo.[1TabPeças].IDPeça
WHERE        (CAST(dbo.VENDAS.DataVenda AS DATETIME) IS NOT NULL)
ORDER BY [Data da Venda], Peça, Ficha
