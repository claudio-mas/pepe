
CREATE VIEW [dbo].[CCCartãoConserto]
AS
SELECT        ID, CLIENTE, DT AS Data, VValor, Tp, Op
FROM            (SELECT        dbo.CONSERTOS.ID, dbo.CONSERTOS.CLIENTE, dbo.CONSERTOS.DT, CASE WHEN [Cartão] > 0 THEN [Cartão] * - 1 ELSE [Cartão] END AS VValor, 'Cartão' AS Tp, 'Conserto' AS Op
                          FROM            dbo.CONSERTOS INNER JOIN
                                                    dbo.[Vencto Cartão] ON dbo.CONSERTOS.ID = dbo.[Vencto Cartão].IdConserto
                          WHERE        (dbo.CONSERTOS.CartãoCC = 1)) AS a
GROUP BY ID, CLIENTE, DT, VValor, Tp, Op
