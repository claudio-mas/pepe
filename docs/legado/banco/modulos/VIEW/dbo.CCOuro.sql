
CREATE VIEW [dbo].[CCOuro]
AS
SELECT        Cliente, Data, 'Ouro' AS Tp, CASE WHEN [Valor] > 0 THEN [Valor] * - 1 ELSE [Valor] END AS VValor, CASE WHEN [IdConserto] > 0 THEN 'Conserto' ELSE 'Crédito' END AS Op, 
                         CASE WHEN [IdConserto] > 0 THEN IdConserto ELSE [Conta Corrente].ID END AS ID
FROM            dbo.[Conta Corrente]
WHERE        (Valor <> 0) AND (OuroCC = 1)
