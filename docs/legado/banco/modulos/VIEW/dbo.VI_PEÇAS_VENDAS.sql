
CREATE VIEW [dbo].[VI_PEÇAS_VENDAS]
AS
SELECT        dbo.[1TabPeças].IDPeça, dbo.[1TabPeças].Custo, dbo.[1TabPeças].DataReg, dbo.[1TabPeças].Origem, dbo.[1TabPeças].MOExt, dbo.[1TabPeças].MOInt, ISNULL(dbo.[1TabPeças].MOExt, 0) + ISNULL(dbo.[1TabPeças].MOInt, 0) 
                         AS MO, dbo.VENDAS.DataVenda, dbo.[1TabPeças].Outras
FROM            dbo.VENDAS INNER JOIN
                         dbo.[VENDAS DET] ON dbo.VENDAS.Id = dbo.[VENDAS DET].Venda INNER JOIN
                         dbo.[1TabPeças] ON dbo.[VENDAS DET].Peça = dbo.[1TabPeças].IDPeça
