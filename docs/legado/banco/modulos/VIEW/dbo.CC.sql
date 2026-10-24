
CREATE VIEW [dbo].[CC]
AS
SELECT        CONSERTOS.ID, CONSERTOS.CLIENTE, CONSERTOS.DT AS Data, CONSERTOS.Cartão AS VValor, 'Cartão' AS Tp, 'Conserto' AS Op, 1 AS Ident, 'x' AS obs
FROM            CONSERTOS
WHERE        (((CONSERTOS.CartãoCC) = 1))
UNION ALL
SELECT        CONSERTOS.ID, CONSERTOS.CLIENTE, CONSERTOS.DT AS Data, CONSERTOS.Real AS VValor, 'Cash' AS Tp, 'Conserto' AS Op, 2 AS Ident, 'x' AS obs
FROM            CONSERTOS
WHERE        (((CONSERTOS.CashCC) = 1))
UNION ALL
SELECT        CONSERTOS.ID, CONSERTOS.CLIENTE, CONSERTOS.DT AS Data, CONSERTOS.Cheque AS VValor, 'Cheque' AS Tp, 'Conserto' AS Op, 3 AS Ident, 'x' AS obs
FROM            CONSERTOS
WHERE        (((CONSERTOS.ChequeCC) = 1))
UNION ALL
SELECT        CONSERTOS.ID, CONSERTOS.CLIENTE, CONSERTOS.Dt AS Data, Abs([CCDeb]) * - 1 AS VValor, 'Débito' AS Tp, 'Conserto' AS Op, 4 AS Ident, 'x' AS obs
FROM            CONSERTOS
WHERE        (((Abs([CCDeb]) * - 1) < 0))
UNION ALL
SELECT        CONSERTOS.ID, CONSERTOS.CLIENTE, CONSERTOS.DT AS Data, CONSERTOS.Dolar AS VValor, 'Dólar' AS Tp, 'Conserto' AS Op, 5 AS Ident, 'x' AS obs
FROM            CONSERTOS
WHERE        (((CONSERTOS.DolarCC) = 1))
UNION ALL
SELECT        CONSERTOS.ID, CONSERTOS.CLIENTE, CONSERTOS.DT AS Data, CONSERTOS.Ouro AS VValor, 'Ouro' AS Tp, 'Conserto' AS Op, 6 AS Ident, 'x' AS obs
FROM            CONSERTOS
WHERE        (((CONSERTOS.OuroCC) = 1))
UNION ALL
SELECT        VENDAS.ID, VENDAS.IdCliente AS CLIENTE, VENDAS.DataVenda AS Data, VENDAS.Cartão AS VValor, 'Cartão' AS Tp, 'Venda' AS Op, 7 AS Ident, 'x' AS obs
FROM            VENDAS
WHERE        (((VENDAS.CartãoCC) = 1))
UNION ALL
SELECT        VENDAS.ID, VENDAS.IdCliente AS CLIENTE, VENDAS.DataVenda AS Data, VENDAS.Real AS VValor, 'Cash' AS Tp, 'Venda' AS Op, 8 AS Ident, 'x' AS obs
FROM            VENDAS
WHERE        (((VENDAS.CashCC) = 1))
UNION ALL
SELECT        VENDAS.ID, VENDAS.IdCliente AS CLIENTE, VENDAS.DataVenda AS Data, VENDAS.Cheque AS VValor, 'Cheque' AS Tp, 'Venda' AS Op, 9 AS Ident, 'x' AS obs
FROM            VENDAS
WHERE        (((VENDAS.ChequeCC) = 1))
UNION ALL
SELECT        VENDAS.ID, VENDAS.IDCliente AS CLIENTE, VENDAS.DataVenda AS Data, Abs([CCDeb]) * - 1 AS VValor, 'Débito' AS Tp, 'Venda' AS Op, 10 AS Ident, 'x' AS obs
FROM            VENDAS
WHERE        (((Abs([CCDeb]) * - 1) < 0))
UNION ALL
SELECT        VENDAS.ID, VENDAS.IdCliente AS CLIENTE, VENDAS.DataVenda AS Data, case when DolarCC = 1 Then (VENDAS.Dolar * -1) else VENDAS.Dolar end AS VValor, 'Dólar' AS Tp, 'Venda' AS Op, 11 AS Ident, 'x' AS obs
FROM            VENDAS
WHERE        (((VENDAS.DolarCC) = 1))
UNION ALL
SELECT        VENDAS.ID, VENDAS.IdCliente AS CLIENTE, VENDAS.DataVenda AS Data, VENDAS.Ouro AS VValor, 'Ouro' AS Tp, 'Venda' AS Op, 12 AS Ident, 'x' AS obs
FROM            VENDAS
WHERE        (((VENDAS.OuroCC) = 1))
UNION ALL
SELECT        [Conta Corrente].ID, [Conta Corrente].CLIENTE, [Conta Corrente].Data, [Conta Corrente].Cartão AS VValor, 'Cartão' AS Tp, 'C/C' AS Op, 13 AS Ident, 'x' AS obs
FROM            [Conta Corrente]
WHERE        ((([Conta Corrente].Cartão) > 0) AND (([Conta Corrente].CartãoCC) = 1) AND (([Conta Corrente].Venda) IS NULL) AND (([Conta Corrente].IdConserto) = 0 OR
                         ([Conta Corrente].IdConserto) IS NULL))
UNION ALL
SELECT        [Conta Corrente].ID, [Conta Corrente].CLIENTE, [Conta Corrente].Data, [Conta Corrente].Real AS VValor, 'Cash' AS Tp, 'C/C' AS Op, 14 AS Ident, Obs
FROM            [Conta Corrente]
WHERE        ((([Conta Corrente].Real) <> 0) AND (([Conta Corrente].CashCC) = 1) AND (([Conta Corrente].Venda) IS NULL) AND (([Conta Corrente].IdConserto) = 0 OR
                         ([Conta Corrente].IdConserto) IS NULL))
UNION ALL
SELECT        [Conta Corrente].ID, [Conta Corrente].CLIENTE, [Conta Corrente].Data, [Conta Corrente].Cheque AS VValor, 'Cheque' AS Tp, 'C/C' AS Op, 15 AS Ident, Obs
FROM            [Conta Corrente]
WHERE        ((([Conta Corrente].Cheque) > 0) AND (([Conta Corrente].ChequeCC) = 1) AND (([Conta Corrente].Venda) IS NULL) AND (([Conta Corrente].IdConserto) = 0 OR
                         ([Conta Corrente].IdConserto) IS NULL))
UNION ALL
SELECT        [Conta Corrente].ID, [Conta Corrente].CLIENTE, [Conta Corrente].Data, Abs([CCDeb]) * - 1 AS VValor, 'Débito' AS Tp, 'C/C' AS Op, 16 AS Ident, Obs
FROM            [Conta Corrente]
WHERE        (((Abs([CCDeb]) * - 1) < 0) AND (([Conta Corrente].Venda) IS NULL) AND (([Conta Corrente].IdConserto) = 0 OR
                         ([Conta Corrente].IdConserto) IS NULL))
UNION ALL
SELECT        [Conta Corrente].ID, [Conta Corrente].CLIENTE, [Conta Corrente].Data, [Conta Corrente].Dolar AS VValor, 'Dólar' AS Tp, 'C/C' AS Op, 17 AS Ident, Obs
FROM            [Conta Corrente]
WHERE        ((([Conta Corrente].Dolar) > 0) AND (([Conta Corrente].DolarCC) = 1) AND (([Conta Corrente].Venda) IS NULL) AND (([Conta Corrente].IdConserto) = 0 OR
                         ([Conta Corrente].IdConserto) IS NULL))
UNION ALL
SELECT        [Conta Corrente].ID, [Conta Corrente].CLIENTE, [Conta Corrente].Data, [Conta Corrente].Ouro AS VValor, 'Ouro' AS Tp, 'C/C' AS Op, 18 AS Ident, Obs
FROM            [Conta Corrente]
WHERE        ((([Conta Corrente].Ouro) > 0) AND (([Conta Corrente].OuroCC) = 1) AND (([Conta Corrente].Venda) IS NULL) AND (([Conta Corrente].IdConserto) = 0 OR
                         ([Conta Corrente].IdConserto) IS NULL))
UNION ALL
SELECT        ID, Cliente, Data, ValorTransf AS VValor, 'Transf.' AS Tp, 'C/C' AS Op, 19 AS Ident, Obs
FROM            [Conta Corrente]
WHERE        (Venda IS NULL) AND (IdConserto = 0 OR
                         IdConserto IS NULL) AND (ValorTransf > 0)
