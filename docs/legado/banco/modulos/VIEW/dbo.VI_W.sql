
CREATE VIEW [dbo].[VI_W]
AS
SELECT        dbo.VENDAS.Id, dbo.VENDAS.DataVenda, dbo.[VENDAS DET].ValorVenda
FROM            dbo.[1TabPeças] INNER JOIN
                         dbo.[VENDAS DET] ON dbo.[1TabPeças].IDPeça = dbo.[VENDAS DET].Peça INNER JOIN
                         dbo.VENDAS ON dbo.[VENDAS DET].Venda = dbo.VENDAS.Id
WHERE        (dbo.[1TabPeças].Oficial = 1)
