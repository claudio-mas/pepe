CREATE VIEW dbo.VI_CC
AS
SELECT        ID, Cliente, Data, Valor, Venda, NCartão, Vencto, Conserto, Parcela, IdConserto, Real, Ouro, Dolar, Cartão, Cheque, FormaCheque, FormaCartão, ChequeCC, CartãoCC, DolarCC, CashCC, OuroCC, Banco, NomeCartão, CCDeb, 
                         ValorFinal, SSMA_TimeStamp, ValorTransf, BancoTransf, Obs, Saldo, Aut, AutDeb
FROM            dbo.[Conta Corrente]
WHERE        (Obs <> N'Lançamento para zerar saldo') OR
                         (Obs IS NULL)
