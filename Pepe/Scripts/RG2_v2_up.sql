/* ============================================================================
   RG2_v2_up.sql  --  Relatorio Gerencial Novo, custo de reposicao no estoque
   ----------------------------------------------------------------------------
   ADITIVO. Estende dbo.VW_RG2_ESTOQUE (criada em RG2_v1_up.sql) com a coluna
   ValorMetal (METAIS.TotalValor), necessaria para a secao 10 decidir, peca a
   peca, se ha valor de metal cadastrado antes de reavaliar pelo preco de hoje.

   Nao cria nem remove nenhuma outra view; VW_RG2_VENDAS_ITENS,
   VW_RG2_PECAS_VENDIDAS e VW_RG2_PECAS_REG ficam exatamente como em
   RG2_v1_up.sql.

   Motivacao: seçoes 6 e 7 do relatorio usam custo HISTORICO (1TabPecas.Custo);
   a secao 10 (posicao de estoque) passa a usar custo de REPOSICAO (metal ao
   preco de hoje). Peca sem ValorMetal cadastrado nao e reavaliada -- nessas
   pecas o metal ja esta embutido em "Outras"/no custo geral, e reavaliar por
   cima contaria o metal duas vezes. Decisao do usuario, 2026-08-06.

   RODAR PRIMEIRO NUMA COPIA DE BDTorras. Rollback: RG2_v2_down.sql
   ============================================================================ */

USE BDTorras;
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO


/* ---------------------------------------------------------------------------
   VW_RG2_ESTOQUE  --  secao 10 do relatorio (recriada com ValorMetal)
   ---------------------------------------------------------------------------
   Identica a definicao de RG2_v1_up.sql, so acrescenta:
       CAST(ISNULL(m.TotalValor, 0) AS float) AS ValorMetal
   Nenhum join, filtro ou outra coluna muda.
   --------------------------------------------------------------------------- */
IF OBJECT_ID('dbo.VW_RG2_ESTOQUE', 'V') IS NOT NULL
    DROP VIEW dbo.VW_RG2_ESTOQUE;
GO

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
GO


/* ---------------------------------------------------------------------------
   Validacao pos-migracao -- rodar e conferir
   --------------------------------------------------------------------------- */
PRINT '=== VALIDACAO ===';

-- (a) Qtd tem que continuar igual a antes da migracao -- a coluna nova nao muda o WHERE.
SELECT 'VW_RG2_ESTOQUE' AS View_, COUNT(*) AS Qtd FROM dbo.VW_RG2_ESTOQUE;

-- (b) Quantas pecas por familia ficam sem reavaliacao por falta de metal cadastrado.
SELECT Familia,
       COUNT(*) AS Qtd,
       SUM(CASE WHEN ValorMetal = 0 AND (GramasOuro > 0 OR GramasPrata > 0)
                THEN 1 ELSE 0 END) AS SemMetalCadastrado
FROM   dbo.VW_RG2_ESTOQUE
GROUP BY Familia;
GO
