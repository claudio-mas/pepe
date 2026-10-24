

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_PECAS_VENDIDAS_PIVOT]
	-- Add the parameters for the stored procedure here
	@dt1 date, 
	@dt2 date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT
RodapeVendidas1.TipoPeça, RodapeVendidas1.W, RodapeVendidas1.NW,
RodapeVendidas2.[F.P.], RodapeVendidas2.[F.F.]
FROM

(SELECT        TipoPeça, SUM(W) AS W, SUM(NW) AS NW
FROM
(SELECT TipoPeça, W, NW
FROM
(SELECT 
--IIf([Classe]<>'GAR',[Classe],IIf(Left([Modêlo],4)='cord','COR',Left([Modêlo],3))) AS TipoPeça,
[1TabPeças].[Classe] AS TipoPeça,
[1TabPeças].Origem,
IIf([Oficial]=1,'W','NW') AS W2,
Count([VENDAS DET].Id) AS Qtde
FROM VENDAS INNER JOIN ([1TabPeças] INNER JOIN [VENDAS DET] ON [1TabPeças].IDPeça = [VENDAS DET].Peça) ON VENDAS.Id = [VENDAS DET].Venda
WHERE (((VENDAS.DataVenda) Between @dt1 And @dt2))
--GROUP BY IIf([Classe]<>'GAR',[Classe], IIf(Left([Modêlo],4)='cord','COR', Left([Modêlo],3))), [1TabPeças].Origem, IIf([Oficial]=1,'W','NW')) as 
GROUP BY [1TabPeças].[Classe], [1TabPeças].Origem, IIf([Oficial]=1,'W','NW')) as 
RodapeVendidasBase
PIVOT (sum(Qtde) for W2 In ([W],[NW])) p) x

GROUP BY TipoPeça) RodapeVendidas1

INNER JOIN

(SELECT TipoPeça, [F.P.], [F.F.]
FROM

(SELECT 
--IIf([Classe]<>'GAR',[Classe],IIf(Left([Modêlo],4)='cord','COR',Left([Modêlo],3))) AS TipoPeça,
[Classe] AS TipoPeça,
[1TabPeças].Origem,
Count([VENDAS DET].Id) AS Qtde
FROM VENDAS INNER JOIN ([1TabPeças] INNER JOIN [VENDAS DET] ON [1TabPeças].IDPeça = [VENDAS DET].Peça) ON VENDAS.Id = [VENDAS DET].Venda
--WHERE (((VENDAS.DataVenda) Between '01/01/2020' And '31/01/2020'))
WHERE (((VENDAS.DataVenda) Between @dt1 And @dt2))
GROUP BY [Classe], [1TabPeças].Origem) as 
RodapeVendidasBase

PIVOT (sum(Qtde) for Origem In ([F.P.],[F.F.])) p) RodapeVendidas2

ON

RodapeVendidas1.TipoPeça = RodapeVendidas2.TipoPeça Order By 1;

END
