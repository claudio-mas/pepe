CREATE VIEW dbo.VI_VENDIDAS
AS
SELECT        dbo.[VENDAS DET].Peça, dbo.[1TabPeças].Custo, dbo.VENDAS.DataVenda, dbo.[1TabPeças].PrVenda AS ValorVenda
FROM            dbo.[1TabPeças] INNER JOIN
                         dbo.VENDAS INNER JOIN
                         dbo.[VENDAS DET] ON dbo.VENDAS.Id = dbo.[VENDAS DET].Venda ON dbo.[1TabPeças].IDPeça = dbo.[VENDAS DET].Peça
