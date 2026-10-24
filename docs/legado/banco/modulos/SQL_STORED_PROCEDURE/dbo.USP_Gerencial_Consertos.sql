



CREATE PROCEDURE [dbo].[USP_Gerencial_Consertos]
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
		FROM            dbo.CONSERTOS
		WHERE        (DT BETWEEN @dt1 AND @dt2)
	UNION ALL
		SELECT        'Cartão' AS Forma, SUM(Cartão + Debito) AS Total
		FROM            dbo.CONSERTOS
		WHERE        (DT BETWEEN @dt1 AND @dt2)
    UNION ALL
		SELECT        'Cash' AS Forma, SUM(Real) AS Cash
		FROM            dbo.CONSERTOS
		WHERE        (DT BETWEEN @dt1 AND @dt2)
    UNION ALL
		SELECT        'Ouro' AS Forma, SUM(Ouro) AS Ouro
		FROM            dbo.CONSERTOS AS CONSERTOS_1
		WHERE        (DT BETWEEN @dt1 AND @dt2)
    UNION ALL
		SELECT        'Dolar' AS Forma, SUM(Dolar) AS Dolar
		FROM            dbo.CONSERTOS AS CONSERTOS_2
		WHERE        (DT BETWEEN @dt1 AND @dt2)
  --  UNION ALL
		--SELECT        'Déb. C/C' AS Forma, SUM(CCDeb) AS DebCC
		--FROM            dbo.VENDAS AS VENDAS_2
		--WHERE        (DataVenda BETWEEN @dt1 AND @dt2) And (Venda is not null)
	UNION ALL
		SELECT        'Déb. C/C' AS Forma, ABS(SUM(CCDeb)) AS DebCC
		FROM            dbo.CONSERTOS
		WHERE        (DT BETWEEN @dt1 AND @dt2)
--UNION ALL
--		SELECT        'Outros' AS Forma, ABS(SUM(VValor)) AS DebCC
--		FROM            dbo.CONSERTOS
--		WHERE        (DT BETWEEN @dt1 AND @dt2) And (ISNULL(ValorFinal, 0) = 0) And (ISNULL(Real, 0) = 0) And (ISNULL(Ouro, 0) = 0) And (ISNULL(Dolar, 0) = 0) And (ISNULL(Cartão, 0) = 0) And (ISNULL(Debito, 0) = 0) And (ISNULL(CCDeb, 0) = 0) And (ISNULL(Cheque, 0) = 0) And (ISNULL(ValorTransfC, 0) = 0)
    UNION ALL
		SELECT        'Transf. Bancária' AS Forma, SUM(ValorTransfc) AS Transf
		FROM            dbo.CONSERTOS AS CONSERTOS_3
		WHERE        (DT BETWEEN @dt1 AND @dt2)) AS a
WHERE        (Total > 0)

END

