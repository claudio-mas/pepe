
CREATE VIEW [dbo].[CC2]
AS
SELECT        a.ID, a.IDCliente, a.DT, a.Real, a.Ouro, a.Dolar, a.Cheque, a.Cartão, a.CCDeb, b.Cli AS Cliente, a.tp, a.ValorTransf, a.Saldo
FROM            (SELECT        ID, Cliente AS IDCliente, Data AS DT, CASE WHEN CashCC = 1 THEN Real ELSE NULL END AS Real, CASE WHEN OuroCC = 1 THEN Ouro ELSE NULL END AS Ouro, CASE WHEN DolarCC = 1 THEN Dolar ELSE NULL 
                                                    END AS Dolar, CASE WHEN ChequeCC = 1 THEN Cheque ELSE NULL END AS Cheque, CASE WHEN CartãoCC = 1 THEN Cartão ELSE NULL END AS Cartão, CCDeb, 'C.C.' AS tp, ValorTransf, Saldo
                          FROM            dbo.[Conta Corrente]
                          WHERE        (Venda IS NULL) AND (IdConserto = 0 OR
                                                    IdConserto IS NULL) AND (CASE WHEN CashCC = 1 THEN isnull(Real, 0) ELSE 0 END + CASE WHEN OuroCC = 1 THEN isnull(Ouro, 0) ELSE 0 END + CASE WHEN DolarCC = 1 THEN isnull(Dolar, 0) 
                                                    ELSE 0 END + CASE WHEN ChequeCC = 1 THEN isnull(Cheque, 0) ELSE 0 END + CASE WHEN CartãoCC = 1 THEN isnull(Cartão, 0) ELSE 0 END > 0)
                          UNION ALL
                          SELECT        ID, CLIENTE, DT, CASE WHEN CashCC = 1 THEN Real ELSE NULL END AS Real, CASE WHEN OuroCC = 1 THEN Ouro ELSE NULL END AS Ouro, CASE WHEN DolarCC = 1 THEN Dolar ELSE NULL END AS Dolar, 
                                                   CASE WHEN ChequeCC = 1 THEN Cheque ELSE NULL END AS Cheque, CASE WHEN CartãoCC = 1 THEN Cartão ELSE NULL END AS Cartão, CCDeb, 'Conserto' AS tp, NULL AS ValorTransfC, Saldo
                          FROM            dbo.CONSERTOS
                          WHERE        (ChequeCC = 1) OR
                                                   (CartãoCC = 1) OR
                                                   (DolarCC = 1) OR
                                                   (OuroCC = 1) OR
                                                   (CashCC = 1) OR
                                                   (CCDeb > 0)
                          UNION ALL
                          SELECT        Id, IDCliente, DataVenda AS DT, CASE WHEN CashCC = 1 THEN Real ELSE NULL END AS Real, CASE WHEN OuroCC = 1 THEN Ouro ELSE NULL END AS Ouro, CASE WHEN DolarCC = 1 THEN Dolar ELSE NULL 
                                                   END AS Dolar, CASE WHEN ChequeCC = 1 THEN Cheque ELSE NULL END AS Cheque, CASE WHEN CartãoCC = 1 THEN Cartão ELSE NULL END AS Cartão, CCDeb, Venda AS tp, NULL AS ValorTransf, Saldo
                          FROM            dbo.VENDAS
                          WHERE        (ChequeCC = 1) OR
                                                   (CartãoCC = 1) OR
                                                   (DolarCC = 1) OR
                                                   (OuroCC = 1) OR
                                                   (CashCC = 1) OR
                                                   (CCDeb > 0)) AS a INNER JOIN
                             (SELECT        ISNULL(Nome, Cliente) AS Cli, IDCliente
                               FROM            dbo.Clientes
                               WHERE        (ISNULL(Nome, Cliente) IS NOT NULL)) AS b ON a.IDCliente = b.IDCliente
