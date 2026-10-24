



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_RPT_PECAS_REG_AG]
	-- Add the parameters for the stored procedure here
	@dt1 date,
	@dt2 date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

--select * from

--(SELECT dbo.[1TabPeças].Família, REPLACE(dbo.[1TabPeças].Origem, '.', '') AS Origem,
--	COUNT(dbo.[1TabPeças].IDPeça) AS I,
--	SUM(dbo.[1TabPeças].Custo) AS Custo,
--	SUM(CASE WHEN [Família] = 'Ou' THEN [TotalQtde] ELSE [OuroQtde] END) AS OT, 
--    SUM(CASE WHEN [Família] = 'Ou' THEN [TotalValor] ELSE [OuroV] END) AS OV,
--	SUM(CASE WHEN [Família] = 'Ag' THEN [PrataQtde] ELSE 0 END) AS AgT,
--	SUM(CASE WHEN [Família] = 'Ag' THEN [TotalValor] ELSE 0 END) AS AgV
--FROM dbo.[1TabPeças] LEFT OUTER JOIN dbo.METAIS ON dbo.[1TabPeças].IDPeça = dbo.METAIS.Id
--WHERE (dbo.[1TabPeças].DataReg BETWEEN @dt1 AND @dt2)
--GROUP BY dbo.[1TabPeças].Família, REPLACE(dbo.[1TabPeças].Origem, '.', '')
	
--UNION ALL

--SELECT dbo.[1TabPeças].Família, 'W' AS Origem, COUNT(dbo.[1TabPeças].IDPeça) AS I,
--	SUM(dbo.[1TabPeças].Custo) AS Custo,
--	SUM(CASE WHEN [Família] = 'Ou' THEN [TotalQtde] ELSE [OuroQtde] END) AS OT, 
--	SUM(CASE WHEN [Família] = 'Ou' THEN [TotalValor] ELSE [OuroV] END) AS OV,
--	SUM(CASE WHEN [Família] = 'Ag' THEN [PrataQtde] ELSE 0 END) AS AgT,
--	SUM(CASE WHEN [Família] = 'Ag' THEN [TotalValor] ELSE 0 END) AS AgV
--FROM dbo.[1TabPeças] LEFT OUTER JOIN dbo.METAIS ON dbo.[1TabPeças].IDPeça = dbo.METAIS.Id
--WHERE dbo.[1TabPeças].DataReg BETWEEN @dt1 AND @dt2 AND (dbo.[1TabPeças].Oficial = 1)
--GROUP BY dbo.[1TabPeças].Família

--UNION ALL

--SELECT dbo.[1TabPeças].Família, 'V' AS Origem, COUNT(dbo.[1TabPeças].IDPeça) AS I,
--	SUM(dbo.[1TabPeças].Custo) AS Custo,
--	SUM(CASE WHEN [Família] = 'Ou' THEN [TotalQtde] ELSE [OuroQtde] END) AS OT, 
--	SUM(CASE WHEN [Família] = 'Ou' THEN [TotalValor] ELSE [OuroV] END) AS OV,
--	SUM(CASE WHEN [Família] = 'Ag' THEN [PrataQtde] ELSE 0 END) AS AgT,
--	SUM(CASE WHEN [Família] = 'Ag' THEN [TotalValor] ELSE 0 END) AS AgV
--FROM dbo.[1TabPeças] LEFT OUTER JOIN dbo.METAIS ON dbo.[1TabPeças].IDPeça = dbo.METAIS.Id
--WHERE dbo.[1TabPeças].DataReg BETWEEN @dt1 AND @dt2 AND (dbo.[1TabPeças].Volta = 1)
--GROUP BY dbo.[1TabPeças].Família) a

--where Família <> 'Boutique';
----order by Família desc;

select * from

(SELECT        dbo.[1TabPeças].Família, REPLACE(dbo.[1TabPeças].Origem, '.', '') AS Origem, isnull(dbo.[1TabPeças].Oficial,0) as Oficial, dbo.[1TabPeças].Volta, COUNT(dbo.[1TabPeças].IDPeça) AS I, SUM(dbo.[1TabPeças].Custo) AS Custo, SUM(dbo.[1TabPeças].PrVenda) AS PrVenda, SUM(isnull(dbo.[1TabPeças].MOExt,0)+isnull(dbo.[1TabPeças].MOInt,0)) AS MO, sum(dbo.[1TabPeças].vFund) as vFund, sum(dbo.[1TabPeças].pFund) as pFund,
                         SUM(CASE WHEN [Família] = 'Ou' THEN [TotalQtde] ELSE [OuroQtde] END) AS OT, SUM(CASE WHEN [Família] = 'Ou' THEN [TotalValor] ELSE [OuroV] END) AS OV, SUM(CASE WHEN [Família] = 'Ag' THEN [PrataQtde] ELSE 0 END) 
                         AS AgT, SUM(CASE WHEN [Família] = 'Ag' THEN [TotalValor] ELSE 0 END) AS AgV
FROM            dbo.[1TabPeças] LEFT OUTER JOIN
                         dbo.METAIS ON dbo.[1TabPeças].IDPeça = dbo.METAIS.Id
WHERE (dbo.[1TabPeças].DataReg BETWEEN @dt1 AND @dt2)

GROUP BY dbo.[1TabPeças].Família, REPLACE(dbo.[1TabPeças].Origem, '.', ''), isnull(dbo.[1TabPeças].Oficial, 0), dbo.[1TabPeças].Volta) a
where Família = 'Ag'
and isnull(Volta, 0) = 0;

END
