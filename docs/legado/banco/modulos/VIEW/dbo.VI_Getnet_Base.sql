CREATE VIEW dbo.VI_Getnet_Base
AS
SELECT        [Cliente], [Venda], [DataVenda], [ValorFinal], cast([Parc] AS integer) AS Parc, [Parcelas], [Vencto], [VValor], [Pagto], [Aut], [Total Getnet], [Valor Parcela Getnet], 1 AS x, FormaCartão
FROM            [dbo].[getnet1]
UNION ALL
SELECT        [Cliente], [Venda], [DataVenda], [ValorFinal], cast([Parc] AS integer) AS Parc, [Parcelas], [Vencto], [VValor], [Pagto], [Aut], [Total Getnet], [Valor Parcela Getnet], 2 AS x, FormaCartão
FROM            [dbo].[getnet2]
UNION ALL
SELECT        [Cliente], [Venda], [DataVenda], [ValorFinal], cast([Parc] AS integer) AS Parc, [Parcelas], [Vencto], [VValor], [Pagto], [Aut], [Total Getnet], [Valor Parcela Getnet], 3 AS x, FormaCartão
FROM            [dbo].[getnet3]
UNION ALL
SELECT        [Cliente], [Venda], [DataVenda], [ValorFinal], cast([Parc] AS integer) AS Parc, [Parcelas], [Vencto], [VValor], [Pagto], [Aut], [Total Getnet], [Valor Parcela Getnet], 3 AS x, FormaCartão
FROM            [dbo].[getnet4]
UNION ALL
SELECT        [Cliente], [Venda], [DataVenda], [ValorFinal], cast([Parc] AS integer) AS Parc, [Parcelas], [Vencto], [VValor], [Pagto], [Aut], [Total Getnet], [Valor Parcela Getnet], 5 AS x, FormaCartão
FROM            [dbo].[getnet5]
