
CREATE VIEW dbo.VW_RG2_ESTOQUE
AS
SELECT
    p.[IDPeça]                                          AS IdPeca,
    CASE WHEN p.[Família] IN ('Ou', 'Ag')
         THEN p.[Família] ELSE 'Bou' END                AS Familia,
    CAST(ISNULL(p.Custo, 0)   AS float)                 AS Custo,
    CAST(ISNULL(m.TotalValor, 0) AS float)              AS ValorMetal,
    CAST(ISNULL(p.PrVenda, 0) AS float)                 AS PrVenda,
    CAST(ISNULL(m.OuroQtde, 0)  - ISNULL(m.OuroV, 0)  AS float)  AS GramasOuro,
    CAST(ISNULL(m.PrataQtde, 0) - ISNULL(m.PrataV, 0) AS float)  AS GramasPrata
FROM       dbo.[1TabPeças]   p
LEFT  JOIN dbo.METAIS        m ON m.Id       = p.[IDPeça]
LEFT  JOIN dbo.[VENDAS DET]  d ON d.[Peça]   = p.[IDPeça]
LEFT  JOIN dbo.VENDAS        v ON v.Id       = d.Venda
WHERE  v.DataVenda IS NULL
  AND  (p.Vendida = 0 OR p.Vendida IS NULL)
  AND  p.[Modêlo] IS NOT NULL
  AND  ISNULL(p.Saida, 0) = 0;
-- O INNER JOIN dbo.PEENBase do EmEstoque.txt foi OMITIDO de proposito -- ver
-- comentario completo em RG2_v1_up.sql, secao 5.
