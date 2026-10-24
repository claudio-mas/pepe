
CREATE VIEW [dbo].[CCCashVenda]
AS
SELECT        dbo.[Conta Corrente].Cliente, dbo.[Conta Corrente].Data, 'Cash' AS Tp, dbo.[Conta Corrente].Valor AS VValor, 'Venda' AS Op, dbo.VENDAS.Id
FROM            dbo.VENDAS INNER JOIN
                         dbo.[Conta Corrente] ON dbo.VENDAS.Venda = dbo.[Conta Corrente].Venda
WHERE        (dbo.VENDAS.CashCC = 1)
