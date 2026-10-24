
CREATE VIEW [dbo].[CCDolarVendaBase]
AS
SELECT        dbo.[Conta Corrente].Cliente, dbo.[Conta Corrente].Data, 'Dolar' AS Tp, CASE WHEN [Vendas].[Dolar] > 0 THEN [Vendas].[Dolar] * - 1 ELSE [Vendas].[Dolar] END AS VValor, 'Venda' AS Op, dbo.[Conta Corrente].ID
FROM            dbo.VENDAS INNER JOIN
                         dbo.[Conta Corrente] ON dbo.VENDAS.Venda = dbo.[Conta Corrente].Venda
WHERE        (dbo.VENDAS.DolarCC = 1) AND (dbo.[Conta Corrente].DolarCC = 0)
