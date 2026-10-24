
CREATE VIEW [dbo].[CCDolarCC]
AS
SELECT        Cliente, Data, 'Dolar' AS Tp, CASE WHEN [Dolar] > 0 THEN [Dolar] * - 1 ELSE [Dolar] END AS VValor, 'Crédito' AS Op, ID
FROM            dbo.[Conta Corrente]
WHERE        (CASE WHEN [Dolar] > 0 THEN [Dolar] * - 1 ELSE [Dolar] END <> 0) AND (DolarCC = 1)
