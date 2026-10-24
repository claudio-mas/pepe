
CREATE VIEW [dbo].[CCChequeVenda]
AS
SELECT        Id, CLIENTE, Data, VValor, Tp, Op
FROM            (SELECT        dbo.VENDAS.Id, dbo.VENDAS.IDCliente AS CLIENTE, dbo.VENDAS.DataVenda AS Data, dbo.VENDAS.Cheque * - 1 AS VValor, 'Cheque' AS Tp, 'Venda' AS Op
                          FROM            dbo.VENDAS INNER JOIN
                                                    dbo.[Vencto Cheques] ON dbo.VENDAS.Id = dbo.[Vencto Cheques].Venda
                          WHERE        (dbo.VENDAS.ChequeCC = 1) AND (dbo.VENDAS.DataVenda >= CONVERT(DATETIME, '2006-07-15 00:00:00', 102))) AS a
GROUP BY Id, CLIENTE, Data, VValor, Tp, Op
