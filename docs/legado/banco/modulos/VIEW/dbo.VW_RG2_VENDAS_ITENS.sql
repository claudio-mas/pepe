
CREATE VIEW dbo.VW_RG2_VENDAS_ITENS
AS
SELECT
    v.Id                                        AS IdVenda,
    v.DataVenda                                 AS DataVenda,
    d.Id                                        AS IdItem,
    d.[Peça]                                    AS IdPeca,
    ISNULL(p.Oficial, 0)                        AS Oficial,
    CASE WHEN ISNULL(p.Oficial, 0) = 1
         THEN 'ENC' ELSE 'LOJA' END             AS Canal,
    CASE WHEN p.[Família] IN ('Ou', 'Ag')
         THEN p.[Família] ELSE 'Bou' END        AS Familia,
    CAST(ISNULL(d.ValorVenda, 0) AS float)      AS ValorItemBruto,
    CAST(ISNULL(v.ValorFinal, 0) AS float)      AS ValorVendaFinal,
    CAST(SUM(ISNULL(d.ValorVenda, 0)) OVER (PARTITION BY v.Id) AS float)
                                                AS ValorVendaBruto,
    CAST(CASE
            WHEN SUM(ISNULL(d.ValorVenda, 0)) OVER (PARTITION BY v.Id) = 0 THEN 0
            ELSE ISNULL(d.ValorVenda, 0) * ISNULL(v.ValorFinal, 0)
                 / SUM(ISNULL(d.ValorVenda, 0)) OVER (PARTITION BY v.Id)
         END AS float)                          AS ValorItemLiquido
FROM       dbo.VENDAS        v
INNER JOIN dbo.[VENDAS DET]  d ON d.Venda    = v.Id
INNER JOIN dbo.[1TabPeças]   p ON p.[IDPeça] = d.[Peça];
