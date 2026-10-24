
CREATE VIEW [dbo].[CCChequeCC]
AS
SELECT        Cliente, Data, CASE WHEN [Cheque] > 0 THEN [Cheque] * - 1 ELSE [Cheque] END AS VValor, 'Cheque' AS Tp, 'Crédito' AS Op, ID
FROM            dbo.[Conta Corrente]
WHERE        (CASE WHEN [Cheque] > 0 THEN [Cheque] * - 1 ELSE [Cheque] END <> 0) AND (Venda IS NULL)
