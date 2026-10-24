




CREATE PROCEDURE [dbo].[USP_Gerencial_Cartoes]
	@dt1 date,
	@dt2 date
AS
BEGIN
	SET NOCOUNT ON;

--	SELECT        NomeCartão AS Forma, SUM(VValor) AS Total
--FROM            dbo.[Vencto Cartão]
--WHERE        (Vencto BETWEEN @dt1 AND @dt2) AND (Venda > 0)
--GROUP BY NomeCartão

SELECT        Forma, Total, Total / sum(Total) over() * 100 as Percentual
FROM
	(SELECT        'Cheque' AS Forma, SUM(Cheque) AS Total
		FROM            dbo.[VENDAS]
		WHERE        (DataVenda BETWEEN @dt1 AND @dt2)
	UNION ALL
		SELECT        'Cartão' AS Forma, SUM(isnull(Cartão,0) + isnull(Cartão2,0) + isnull(Deb,0)) AS Total
		FROM            dbo.VENDAS
		WHERE        (DataVenda BETWEEN @dt1 AND @dt2)
    UNION ALL
		SELECT        'Cash' AS Forma, SUM(Real) AS Cash
		FROM            dbo.VENDAS
		WHERE        (DataVenda BETWEEN @dt1 AND @dt2)
    UNION ALL
		SELECT        'Ouro' AS Forma, SUM(Ouro) AS Ouro
		FROM            dbo.VENDAS AS VENDAS_4
		WHERE        (DataVenda BETWEEN @dt1 AND @dt2)
    UNION ALL
		SELECT        'Dolar' AS Forma, SUM(Dolar) AS Dolar
		FROM            dbo.VENDAS AS VENDAS_3
		WHERE        (DataVenda BETWEEN @dt1 AND @dt2)
  --  UNION ALL
		--SELECT        'Déb. C/C' AS Forma, SUM(CCDeb) AS DebCC
		--FROM            dbo.VENDAS AS VENDAS_2
		--WHERE        (DataVenda BETWEEN @dt1 AND @dt2) And (Venda is not null)
UNION ALL
		SELECT        'Déb. C/C' AS Forma, SUM(abs(CCDeb)) AS DebCC
		FROM            dbo.[VENDAS]
		WHERE        (DataVenda BETWEEN @dt1 AND @dt2) --and Venda is not null
	--UNION ALL
	--	SELECT        'Créd. C/C' AS Forma, ABS(SUM(abs(isnull(Real, 0)) + abs(isnull(Ouro, 0)) + abs(isnull(Dolar, 0)) + abs(isnull(Cartão, 0)) + abs(isnull(Cheque, 0)) + abs(isnull(ValorTransf, 0)))) AS CredCC
	--	FROM            dbo.[Vendas]
	--	WHERE        (DataVenda BETWEEN @dt1 AND @dt2)
    UNION ALL
		SELECT        'Transf. Bancária' AS Forma, SUM(ValorTransf) AS Transf
		FROM            dbo.VENDAS AS VENDAS_1
		WHERE        (DataVenda BETWEEN @dt1 AND @dt2)) AS a
WHERE        (Total > 0)

END

