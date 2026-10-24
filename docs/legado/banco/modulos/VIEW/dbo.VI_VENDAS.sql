CREATE VIEW dbo.VI_VENDAS
AS
SELECT        Id, DataVenda, Real, Ouro, Dolar, ValorTransf, CCDeb, Comissão, ValorFinal, IIF([Vendedora] = 'Loja' OR
                         [Vendedora] = 'P.T.', [Vendedora], 'Outros') AS V, Deb, IIF(ChequeCC = 1, ISNULL([Vendas].Cheque, 0), 0) + IIF(CartãoCC = 1, ISNULL([Vendas].Cartão, 0), 0) + IIF(CartãoCC2 = 1, ISNULL(Cartão2, 0), 0) + IIF(DolarCC = 1, 
                         ISNULL(Dolar, 0), 0) + IIF(CashCC = 1, ISNULL([Vendas].[Real], 0), 0) + IIF(OuroCC = 1, ISNULL(Ouro, 0), 0) + ISNULL(CCDeb, 0) AS valCC, 
                         (CASE WHEN ChequeCC = 1 THEN Cheque ELSE 0 END + CASE WHEN CartãoCC = 1 THEN Cartão ELSE 0 END + CASE WHEN CartãoCC2 = 1 THEN Cartão2 ELSE 0 END + CASE WHEN DolarCC = 1 THEN Dolar ELSE 0 END + CASE
                          WHEN CashCC = 1 THEN Real ELSE 0 END + CASE WHEN OuroCC = 1 THEN Ouro ELSE 0 END) AS CCCred, Cartão, Cartão2, FormaCartão, FormaCartão2, /* Novos campos calculados:*/ IIF(FormaCartão = 'A vista', Cartão, 0) 
                         AS CartãoVista, IIF(FormaCartão2 = 'A vista', Cartão2, 0) AS CartãoVista2, IIF(FormaCartão <> 'A vista', Cartão, 0) AS CartãoParc, IIF(FormaCartão2 <> 'A vista', Cartão2, 0) AS CartãoParc2, (IIF(FormaCartão = 'A vista', Cartão, 0) 
                         + IIF(FormaCartão2 = 'A vista', Cartão2, 0)) AS TotalCartãoVista, (IIF(FormaCartão <> 'A vista', Cartão, 0) + IIF(FormaCartão2 <> 'A vista', Cartão2, 0)) AS TotalCartãoParc
FROM            dbo.VENDAS
WHERE        Venda IS NOT NULL
