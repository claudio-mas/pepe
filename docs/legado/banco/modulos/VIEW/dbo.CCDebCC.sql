
CREATE VIEW [dbo].[CCDebCC]
AS
SELECT        Cliente, Data, 'Débito' AS Tp, 'Conserto' AS Op, CASE WHEN [Venda] IS NOT NULL THEN 'Venda' ELSE (CASE WHEN [Conserto] > 0 THEN 'Conserto' ELSE 'Débito' END) END AS Op2, ABS(Valor) AS VValor, ID
FROM            dbo.[Conta Corrente]
WHERE        (IdConserto > 0) AND (CCDeb <> 0)
