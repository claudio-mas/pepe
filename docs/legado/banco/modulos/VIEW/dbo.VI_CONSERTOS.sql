CREATE VIEW dbo.VI_CONSERTOS
AS
SELECT        VVALOR AS Tot, DT, COMISSÃO AS Comis, ID, Custo, Real, Ouro, Dolar, Debito, ValorTransfC, CCDeb, 
                         CASE WHEN ChequeCC = 1 THEN Cheque ELSE 0 END + CASE WHEN CartãoCC = 1 THEN Cartão ELSE 0 END + CASE WHEN DolarCC = 1 THEN Dolar ELSE 0 END + CASE WHEN CashCC = 1 THEN Real ELSE 0 END + CASE WHEN
                          OuroCC = 1 THEN Ouro ELSE 0 END AS CCCred
FROM            dbo.CONSERTOS
