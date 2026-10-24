
CREATE VIEW [dbo].[CCOld]
AS
SELECT        Id, Cliente, Data, VValor, Tp, Op, 1 AS Ident
FROM            [CCCash]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 2 AS Ident
FROM            [CCCashVenda]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 3 AS Ident
FROM            [CCDolar]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 4 AS Ident
FROM            [CCDolarVenda]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 5 AS Ident
FROM            [CCOuro]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 6 AS Ident
FROM            [CCOuroVenda]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 7 AS Ident
FROM            [CCCartãoConserto]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 8 AS Ident
FROM            [CCCartãoVenda]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 9 AS Ident
FROM            [CCChequeConserto]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 10 AS Ident
FROM            [CCChequeVenda]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 11 AS Ident
FROM            [CCChequeCC]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 12 AS Ident
FROM            [CCCartãoCC]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 13 AS Ident
FROM            [CCDeb]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 14 AS Ident
FROM            [CCDebCC]
UNION ALL
/*SELECT        Id, Cliente, Data, VValor, Tp, Op, 15 AS Ident FROM            [CCCashCC] UNION ALL*/ SELECT Id, Cliente, Data, VValor, Tp, Op, 16 AS Ident
FROM            [CCDolarCC]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 17 AS Ident
FROM            [CCOuroCC]
UNION ALL
SELECT        Id, Cliente, Data, VValor, Tp, Op, 18 AS Ident
FROM            [CCTransf]
