CREATE VIEW dbo.CCOuroCC
AS
SELECT     Cliente, Data, 'Ouro' AS Tp, Ouro AS VValor, 'Crédito' AS Op, ID
FROM         dbo.[Conta Corrente]
WHERE     (OuroCC = 1) AND (Ouro <> 0)
