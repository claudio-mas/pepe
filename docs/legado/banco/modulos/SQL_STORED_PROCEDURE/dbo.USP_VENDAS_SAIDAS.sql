



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_VENDAS_SAIDAS]
	-- Add the parameters for the stored procedure here
	@dt1 date,
	@dt2 date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	--	SELECT VENDAS.Id, VENDAS.Venda,
--isnull([Nome],'S/ Nome') AS N,
--iif(Família='Ou' And [Vendas].[Tipo] = 'Interna' And [Vendas].[Vendedora] = 'Loja',[VENDAS DET].Comissão, 0) As ComOuro,
--iif((Família='Ag' Or Família = 'Ou / Ag') And [Vendas].[Tipo] = 'Interna' And [Vendas].[Vendedora] = 'Loja',[VENDAS DET].Comissão, 0) As ComFamilia,
--iif(Família='Boutique' And [Vendas].[Tipo] = 'Interna' And [Vendas].[Vendedora] = 'Loja',[VENDAS DET].Comissão, 0) As ComBou,
--IIf([Vendas].[Tipo] is null,'',[Vendas].[Tipo]) + ' / ' + IIf([Vendas].[Tipo]='Externa',[Vendas].[Vendedora], IIf([Vendas].[Vendedora]='P.T.','P.T.','Loja')) AS TP,
--IIf([Vendas].[Tipo] is null,Null,Left([Vendas].[Tipo],3) + '. ' + IIf([Vendas].[Tipo]='Externa',[Vendas].[Vendedora],IIf([Vendas].[Vendedora]='P.T.','P.T.','Loja'))) AS TPP,
--VENDAS.Vendedora, VENDAS.DataVenda, [1TabPeças].DataReg, [1TabPeças].Custo, [1TabPeças].Modêlo, IIf([Origem]='Outros','Ou',[Origem]) AS O,
--[1TabPeças].Oficial, format([vendas].[DataVenda],'mmyyyy') AS mesDV, [1TabPeças].DataFabric, Format([DataReg],'mmyyyy') AS mesDF, VENDAS.ValorFinal, VENDAS.Real, VENDAS.Dolar,
--VENDAS.ContaCorrente, VENDAS.CCCheque, [VENDAS DET].Comissão, VENDAS.Ouro, [VENDAS DET].ValorVenda, VENDAS.Desconto, VENDAS.CCDeb, VENDAS.Troca, VENDAS.Cartão,
--[Vendas Cartão].Parcelas, VENDAS.Cheque, [Vendas Cheque].Parcelas AS ParcelasCH, IIf([Oficial]=1,'W','') AS w
--FROM
--(((VENDAS LEFT JOIN Clientes ON VENDAS.IDCliente = Clientes.IDCliente) LEFT JOIN [Vendas Cartão] ON VENDAS.Id = [Vendas Cartão].Venda) INNER JOIN ([1TabPeças] INNER JOIN [VENDAS DET] ON [1TabPeças].IDPeça = [VENDAS DET].Peça) ON VENDAS.Id = [VENDAS DET].Venda) LEFT JOIN [Vendas Cheque] ON VENDAS.Id = [Vendas Cheque].Venda
--WHERE (((VENDAS.Venda) Is Not Null) AND ((VENDAS.DataVenda) Between @dt1 And @dt2));

Select sum(t.Custo) as TCusto From
(Select Id, Saida, Venda, N, TP, TPP, Vendedora, DataVenda, DataReg, Custo, Classe, Modêlo, O, Oficial, mesDV, DataFabric, mesDF, Família,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, ValorFinal, 0) as ValorFinal,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Real, 0) as Real,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Dolar, 0) as Dolar,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.ContaCorrente, 0) as ContaCorrente,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.CCCheque, 0) as CCCheque,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.ComTot, 0) as ComTot,
Comissão,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Ouro, 0) as Ouro,
ValorVenda,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Desconto, 0) as Desconto,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.CCDeb, 0) as CCDeb,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Troca, 0) as Troca,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Cartão, 0) as Cartão,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Cartão1, 0) as Cartão1,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Cartão2, 0) as Cartão2,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Deb1, 0) as Deb1,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.valCC, 0) as valCC,
iif(a.Cartão1 > 0, FormaCartão,'') as Parc1,
iif(a.Cartão2 > 0, FormaCartão2,'') as Parc2,
iif(a.Deb1 > 0, 'Deb.','') As ParcDeb,
iif(NomeCDeb is not null and FormaCartão is not null, FormaCartão + '+Deb.', iif(NomeCDeb is not null,'Deb.', FormaCartão)) as Parcelas,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Cheque, 0) as Cheque,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.ValorTransf, 0) as ValorTransf,
FormaCheque as ParcelasCH, w, ComOuro, ComFamilia, ComBou --, valCC
from 	
	(SELECT        dbo.VENDAS.Id, dbo.VENDAS.Venda, ISNULL(dbo.Clientes.Nome, 'S/ Nome') AS N, dbo.VENDAS.Vendedora, dbo.VENDAS.DataVenda, dbo.[1TabPeças].DataReg, dbo.[1TabPeças].Custo, dbo.[1TabPeças].Modêlo, dbo.[1TabPeças].Família, dbo.[1TabPeças].Saida,
	iif(Família='Ou' And [Vendas].[Tipo] = 'Interna' And [Vendas].[Vendedora] = 'Loja',[VENDAS DET].Comissão, 0) As ComOuro,
iif((Família='Ag' Or Família = 'Ou / Ag') And [Vendas].[Tipo] = 'Interna' And [Vendas].[Vendedora] = 'Loja',[VENDAS DET].Comissão, 0) As ComFamilia,
iif(Família='Boutique' And [Vendas].[Tipo] = 'Interna' And [Vendas].[Vendedora] = 'Loja',[VENDAS DET].Comissão, 0) As ComBou,
IIf([Vendas].[Tipo] is null,'',[Vendas].[Tipo]) + ' / ' + IIf([Vendas].[Tipo]='Externa',[Vendas].[Vendedora], IIf([Vendas].[Vendedora]='P.T.','P.T.','Loja')) AS TP,
IIf([Vendas].[Tipo] is null,Null,Left([Vendas].[Tipo],3) + '. ' + IIf([Vendas].[Tipo]='Externa',[Vendas].[Vendedora],IIf([Vendas].[Vendedora]='P.T.','P.T.','Loja'))) AS TPP,
IIf([Origem]='Outros','Ou',[Origem]) AS O,  IIf([Oficial]=1,'W','') AS w, dbo.VENDAS.Comissão AS ComTot,
iif(ChequeCC = 1, isnull([Vendas].Cheque, 0), 0) + iif(CartãoCC = 1, isnull([Vendas].Cartão, 0), 0) + iif(CartãoCC2 = 1, isnull(Cartão2, 0), 0)
	+ iif(DolarCC = 1, isnull(Dolar, 0), 0) + iif(CashCC = 1, isnull([Vendas].[Real], 0), 0) + iif(OuroCC = 1, isnull(Ouro, 0), 0)
	+ isnull(CCDeb, 0) as valCC,
                         dbo.[1TabPeças].Classe, dbo.[1TabPeças].Oficial, format(dbo.VENDAS.DataVenda, 'mmyyyy') AS mesDV, dbo.[1TabPeças].DataFabric, Format(dbo.[1TabPeças].DataReg, 'mmyyyy') AS mesDF, dbo.VENDAS.ValorFinal, dbo.VENDAS.Real, 
                         dbo.VENDAS.Dolar, dbo.VENDAS.ContaCorrente, dbo.VENDAS.CCCheque, dbo.[VENDAS DET].Comissão, dbo.VENDAS.Ouro, dbo.[VENDAS DET].ValorVenda, dbo.VENDAS.Desconto, dbo.VENDAS.CCDeb, dbo.VENDAS.Troca, 
                         isnull(dbo.VENDAS.Deb, 0) + Isnull(dbo.VENDAS.Cartão, 0) as Cartão,
						 Isnull(dbo.VENDAS.Cartão, 0) as Cartão1,
						 Isnull(dbo.VENDAS.Cartão2, 0) as Cartão2,
						 Isnull(dbo.VENDAS.Deb, 0) as Deb1,
						 dbo.VENDAS.NomeCDeb, dbo.VENDAS.Cheque, dbo.VENDAS.FormaCartão, dbo.VENDAS.FormaCartão2, dbo.VENDAS.FormaCheque, dbo.VENDAS.ValorTransf
FROM            dbo.VENDAS LEFT OUTER JOIN
                         dbo.Clientes ON dbo.VENDAS.IDCliente = dbo.Clientes.IDCliente INNER JOIN
                         dbo.[1TabPeças] INNER JOIN
                         dbo.[VENDAS DET] ON dbo.[1TabPeças].IDPeça = dbo.[VENDAS DET].Peça ON dbo.VENDAS.Id = dbo.[VENDAS DET].Venda) a
WHERE (Venda Is Not Null) AND (isnull(Saida,0)=0) AND (DataVenda Between @dt1 And @dt2)) t

END
