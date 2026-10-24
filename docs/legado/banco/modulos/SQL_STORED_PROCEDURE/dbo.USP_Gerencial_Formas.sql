



CREATE PROCEDURE [dbo].[USP_Gerencial_Formas]
	@dt1 date,
	@dt2 date
AS
BEGIN
	SET NOCOUNT ON;

	SELECT        Forma, Total
FROM            (SELECT        'Cheques' AS Forma, SUM(VValor) AS Total
    FROM            dbo.[Vencto Cheques]
    WHERE        (Venda > 0) AND (Vencto between @dt1 AND @dt2)
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
    UNION ALL
    SELECT        'Déb. C/C' AS Forma, SUM(CCDeb) AS DebCC
    FROM            dbo.VENDAS AS VENDAS_2
    WHERE        (DataVenda BETWEEN @dt1 AND @dt2)
    UNION ALL
    SELECT        'Transf. Banc.' AS Forma, SUM(ValorTransf) AS Transf
    FROM            dbo.VENDAS AS VENDAS_1
    WHERE        (DataVenda BETWEEN @dt1 AND @dt2)) AS a
WHERE        (Total > 0)


END

