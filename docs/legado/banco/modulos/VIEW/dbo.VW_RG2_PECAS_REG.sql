
CREATE VIEW dbo.VW_RG2_PECAS_REG
AS
SELECT
    p.[IDPeça]                                          AS IdPeca,
    p.DataReg                                           AS DataReg,
    ISNULL(NULLIF(LTRIM(RTRIM(p.Origem)), ''), 'F.F.')  AS Origem,
    CASE WHEN p.[Família] IN ('Ou', 'Ag')
         THEN p.[Família] ELSE 'Bou' END                AS Familia,
    CAST(ISNULL(p.Custo, 0) AS float)                   AS Custo,
    CAST(ISNULL(m.OuroQtde, 0)  - ISNULL(m.OuroV, 0)  AS float)  AS GramasOuro,
    CAST(ISNULL(m.PrataQtde, 0) - ISNULL(m.PrataV, 0) AS float)  AS GramasPrata,
    CAST(ISNULL(m.TotalValor, 0) AS float)              AS ValorMetal,
    CAST(ISNULL(p.MOExt, 0) + ISNULL(p.MOInt, 0) AS float)       AS MO
FROM      dbo.[1TabPeças] p
LEFT JOIN dbo.METAIS      m ON m.Id = p.[IDPeça];
