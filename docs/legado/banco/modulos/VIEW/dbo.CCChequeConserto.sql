
CREATE VIEW [dbo].[CCChequeConserto]
AS
SELECT        ID, CLIENTE, Data, VValor, Tp, Op
FROM            (SELECT        dbo.CONSERTOS.ID, dbo.CONSERTOS.CLIENTE, dbo.CONSERTOS.DT AS Data, CASE WHEN [Consertos].[Cheque] > 0 THEN [CONSERTOS].[Cheque] * - 1 ELSE [CONSERTOS].[Cheque] END AS VValor, 
                                                    'Cheque' AS Tp, 'Conserto' AS Op
                          FROM            dbo.CONSERTOS INNER JOIN
                                                    dbo.[Vencto Cheques] ON dbo.CONSERTOS.ID = dbo.[Vencto Cheques].IdConserto
                          WHERE        (dbo.CONSERTOS.ChequeCC = 1)) AS a
GROUP BY ID, CLIENTE, Data, VValor, Tp, Op
