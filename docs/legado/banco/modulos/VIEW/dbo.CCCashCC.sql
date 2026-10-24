
CREATE VIEW [dbo].[CCCashCC]
AS
SELECT        Cliente, Data, 'Cash' AS Tp, CASE WHEN [Real] > 0 THEN [Real] * - 1 ELSE [Real] END AS VValor, 'Crédito' AS Op, ID
FROM            dbo.[Conta Corrente]
WHERE        (CASE WHEN [Real] > 0 THEN [Real] * - 1 ELSE [Real] END <> 0) AND (CashCC = 1)
