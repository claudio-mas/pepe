
CREATE VIEW dbo.VW_RG2_PECAS_VENDIDAS
AS
SELECT
    p.[IDPeça]                                          AS IdPeca,
    d.Id                                                AS IdItem,
    v.DataVenda                                         AS DataVenda,
    CASE WHEN p.[Família] IN ('Ou', 'Ag')
         THEN p.[Família] ELSE 'Bou' END                AS Familia,
    CAST(ISNULL(p.Custo, 0) AS float)                   AS Custo,
    CAST(ISNULL(m.OuroQtde, 0)  - ISNULL(m.OuroV, 0)  AS float)  AS GramasOuro,
    CAST(ISNULL(m.PrataQtde, 0) - ISNULL(m.PrataV, 0) AS float)  AS GramasPrata,
    CAST(ISNULL(m.TotalValor, 0) AS float)              AS ValorMetal,
    CAST(ISNULL(p.MOExt, 0) + ISNULL(p.MOInt, 0) AS float)       AS MO,
    CAST(ISNULL(p.Custo, 0)
         - ISNULL(m.TotalValor, 0)
         - (ISNULL(p.MOExt, 0) + ISNULL(p.MOInt, 0)) AS float)   AS Outras,
    CAST(ISNULL(d.ValorVenda, 0) AS float)              AS PrecoVenda
FROM       dbo.[1TabPeças]   p
INNER JOIN dbo.[VENDAS DET]  d ON d.[Peça] = p.[IDPeça]
INNER JOIN dbo.VENDAS        v ON v.Id     = d.Venda
LEFT  JOIN dbo.METAIS        m ON m.Id     = p.[IDPeça];
