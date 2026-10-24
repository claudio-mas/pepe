
CREATE VIEW [dbo].[CCDeb]
AS
SELECT        dbo.[Conta Corrente].Cliente, dbo.[Conta Corrente].Data, 'Débito' AS Tp, CASE WHEN [Conta Corrente].[Venda] IS NOT NULL 
                         THEN 'Venda' ELSE CASE WHEN [Conta Corrente].[Conserto] > 0 THEN 'Conserto' ELSE 'Débito' END END AS Op, ABS(dbo.[Conta Corrente].CCDeb) AS VValor, CASE WHEN vendas.id IS NULL 
                         THEN [Conta Corrente].ID ELSE Vendas.id END AS ID
FROM            dbo.[Conta Corrente] LEFT OUTER JOIN
                         dbo.VENDAS ON dbo.[Conta Corrente].Venda = dbo.VENDAS.Venda
WHERE        (dbo.[Conta Corrente].CCDeb <> 0) AND (dbo.[Conta Corrente].IdConserto = 0 OR
                         dbo.[Conta Corrente].IdConserto IS NULL)
