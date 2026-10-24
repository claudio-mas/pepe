
CREATE VIEW [dbo].[CCOuroVenda]
AS
SELECT        MIN(ID) AS ID, Cliente, Data, Tp, VValor, Op
FROM            (SELECT        dbo.[Conta Corrente].ID, dbo.[Conta Corrente].Cliente, dbo.[Conta Corrente].Data, 'Ouro' AS Tp, CASE WHEN [Vendas].[Ouro] > 0 THEN [Vendas].[Ouro] * - 1 ELSE [Vendas].[Ouro] END AS VValor, 'Venda' AS Op
                          FROM            dbo.VENDAS INNER JOIN
                                                    dbo.[Conta Corrente] ON dbo.VENDAS.Venda = dbo.[Conta Corrente].Venda
                          WHERE        (CASE WHEN [Vendas].[Ouro] > 0 THEN [Vendas].[Ouro] * - 1 ELSE [Vendas].[Ouro] END <> 0) AND (dbo.VENDAS.OuroCC = 1) AND (dbo.[Conta Corrente].OuroCC = 0)) AS a
GROUP BY Cliente, Data, Tp, VValor, Op
