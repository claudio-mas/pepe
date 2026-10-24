
CREATE VIEW [dbo].[CCTransf]
AS
SELECT        Cliente, Data, 'Transferência Bancária' AS Tp, CASE WHEN [IdConserto] > 0 THEN [ValorTransf ] ELSE [ValorTransf ] * - 1 END AS VValor, CASE WHEN [IdConserto] > 0 THEN 'Conserto' ELSE 'Crédito' END AS Op, 
                         CASE WHEN [IdConserto] > 0 THEN IdConserto ELSE [Conta Corrente].ID END AS ID
FROM            dbo.[Conta Corrente]
WHERE        (ValorTransf <> 0)
