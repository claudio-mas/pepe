
CREATE VIEW [dbo].[CCCartãoVenda]
AS
SELECT        Id, IDCliente AS Cliente, Data, VValor, Tp, Op
FROM            (SELECT        dbo.VENDAS.Id, dbo.VENDAS.IDCliente, dbo.VENDAS.DataVenda AS Data, CASE WHEN [Cartão] > 0 THEN [Cartão] * - 1 ELSE [Cartão] END AS VValor, 'Cartão' AS Tp, 'Venda' AS Op
                          FROM            dbo.VENDAS INNER JOIN
                                                    dbo.[Vencto Cartão] ON dbo.VENDAS.Id = dbo.[Vencto Cartão].Venda
                          WHERE        (dbo.VENDAS.CartãoCC = 1) AND (dbo.VENDAS.DataVenda >= CONVERT(DATETIME, '2006-07-15 00:00:00', 102))) AS a
GROUP BY Id, IDCliente, Data, VValor, Tp, Op
