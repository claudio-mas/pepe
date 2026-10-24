
CREATE VIEW [dbo].[CCCash]
AS
SELECT        Cliente, Data, 'Cash' AS Tp, CASE WHEN [IdConserto] > 0 THEN [Real] ELSE [Real] * - 1 END AS VValor, CASE WHEN [IdConserto] > 0 THEN 'Conserto' ELSE 'Crédito' END AS Op, 
                         CASE WHEN [IdConserto] > 0 THEN IdConserto ELSE [Conta Corrente].ID END AS ID
FROM            dbo.[Conta Corrente]
WHERE        (CASE WHEN [IdConserto] > 0 THEN [Real] ELSE [Real] * - 1 END <> 0) AND (CashCC = 1) AND (Venda IS NULL)
