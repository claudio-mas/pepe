


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_RPT_VENDA_CLIENTE]
	-- Add the parameters for the stored procedure here
	@IdCli int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


--Select Id, IdCliente, Venda, N, TP, TPP, Vendedora, DataVenda, DataReg, Custo, Modêlo, O, Oficial, mesDV, DataFabric, mesDF,
--iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, ValorFinal, 0) as ValorFinal,
--iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Real, 0) as Real,
--iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Dolar, 0) as Dolar,
--iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.ContaCorrente, 0) as ContaCorrente,
--iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.CCCheque, 0) as CCCheque,
--Comissão,
--iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Ouro, 0) as Ouro,
--ValorVenda,
--iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Desconto, 0) as Desconto,
--iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.CCDeb, 0) as CCDeb,
--iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Troca, 0) as Troca,
--iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Cartão, 0) as Cartão,
--FormaCartão as Parcelas,
--iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Cheque, 0) as Cheque,
--FormaCheque as ParcelasCH, w, ComOuro, ComFamilia, ComBou, ValorTransf
--from 	
--	(SELECT        dbo.VENDAS.Id, dbo.VENDAS.Venda, ISNULL(dbo.Clientes.Nome, 'S/ Nome') AS N, dbo.VENDAS.Vendedora, dbo.VENDAS.DataVenda, dbo.[1TabPeças].DataReg, dbo.[1TabPeças].Custo, dbo.[1TabPeças].Modêlo,
--	iif(Família='Ou' And [Vendas].[Tipo] = 'Interna' And [Vendas].[Vendedora] = 'Loja',[VENDAS DET].Comissão, 0) As ComOuro,
--iif((Família='Ag' Or Família = 'Ou / Ag') And [Vendas].[Tipo] = 'Interna' And [Vendas].[Vendedora] = 'Loja',[VENDAS DET].Comissão, 0) As ComFamilia,
--iif(Família='Boutique' And [Vendas].[Tipo] = 'Interna' And [Vendas].[Vendedora] = 'Loja',[VENDAS DET].Comissão, 0) As ComBou,
--IIf([Vendas].[Tipo] is null,'',[Vendas].[Tipo]) + ' / ' + IIf([Vendas].[Tipo]='Externa',[Vendas].[Vendedora], IIf([Vendas].[Vendedora]='P.T.','P.T.','Loja')) AS TP,
--IIf([Vendas].[Tipo] is null,Null,Left([Vendas].[Tipo],3) + '. ' + IIf([Vendas].[Tipo]='Externa',[Vendas].[Vendedora],IIf([Vendas].[Vendedora]='P.T.','P.T.','Loja'))) AS TPP,
--IIf([Origem]='Outros','Ou',[Origem]) AS O,  IIf([Oficial]=1,'W','') AS w,
--                         dbo.[1TabPeças].Oficial, format(dbo.VENDAS.DataVenda, 'mmyyyy') AS mesDV, dbo.[1TabPeças].DataFabric, Format(dbo.[1TabPeças].DataReg, 'mmyyyy') AS mesDF, dbo.VENDAS.ValorFinal, dbo.VENDAS.Real, 
--                         dbo.VENDAS.Dolar, dbo.VENDAS.ContaCorrente, dbo.VENDAS.CCCheque, dbo.[VENDAS DET].Comissão, dbo.VENDAS.Ouro, dbo.[VENDAS DET].ValorVenda, dbo.VENDAS.Desconto, dbo.VENDAS.CCDeb, dbo.VENDAS.Troca, 
--                         dbo.VENDAS.Cartão, dbo.VENDAS.Cheque, dbo.VENDAS.FormaCartão, dbo.VENDAS.FormaCheque, dbo.VENDAS.ValorTransf, dbo.Clientes.IDCliente
--FROM            dbo.VENDAS LEFT OUTER JOIN
--                         dbo.Clientes ON dbo.VENDAS.IDCliente = dbo.Clientes.IDCliente INNER JOIN
--                         dbo.[1TabPeças] INNER JOIN
--                         dbo.[VENDAS DET] ON dbo.[1TabPeças].IDPeça = dbo.[VENDAS DET].Peça ON dbo.VENDAS.Id = dbo.[VENDAS DET].Venda) a

Select t.*, sum(Desconto) over (partition by Venda order by Venda) TDesc From
(Select Id, Venda, N, TP, TPP, Vendedora, DataVenda, DataReg, Custo, Classe, Modêlo, O, Oficial, mesDV, DataFabric, mesDF,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, ValorFinal, 0) as ValorFinal,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Real, 0) as Real,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Dolar, 0) as Dolar,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.ContaCorrente, 0) as ContaCorrente,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.CCCheque, 0) as CCCheque,
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
iif(a.Cartão1 > 0, FormaCartão,'') as Parc1,
iif(a.Cartão2 > 0, FormaCartão2,'') as Parc2,
iif(a.Deb1 > 0, 'Deb.','') As ParcDeb,
iif(NomeCDeb is not null and FormaCartão is not null, FormaCartão + '+Deb.', iif(NomeCDeb is not null,'Deb.', FormaCartão)) as Parcelas,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.Cheque, 0) as Cheque,
iif(ROW_NUMBER() OVER(PARTITION BY Id ORDER BY id)=1, a.ValorTransf, 0) as ValorTransf, IDCliente,
FormaCheque as ParcelasCH, w, ComOuro, ComFamilia, ComBou
from 	
	(SELECT        dbo.VENDAS.Id, dbo.VENDAS.Venda, ISNULL(dbo.Clientes.Nome, 'S/ Nome') AS N, dbo.VENDAS.Vendedora, dbo.VENDAS.DataVenda, dbo.[1TabPeças].DataReg, dbo.[1TabPeças].Custo, dbo.[1TabPeças].Modêlo,
	iif(Família='Ou' And [Vendas].[Tipo] = 'Interna' And [Vendas].[Vendedora] = 'Loja',[VENDAS DET].Comissão, 0) As ComOuro,
iif((Família='Ag' Or Família = 'Ou / Ag') And [Vendas].[Tipo] = 'Interna' And [Vendas].[Vendedora] = 'Loja',[VENDAS DET].Comissão, 0) As ComFamilia,
iif(Família='Boutique' And [Vendas].[Tipo] = 'Interna' And [Vendas].[Vendedora] = 'Loja',[VENDAS DET].Comissão, 0) As ComBou,
IIf([Vendas].[Tipo] is null,'',[Vendas].[Tipo]) + ' / ' + IIf([Vendas].[Tipo]='Externa',[Vendas].[Vendedora], IIf([Vendas].[Vendedora]='P.T.','P.T.','Loja')) AS TP,
IIf([Vendas].[Tipo] is null,Null,Left([Vendas].[Tipo],3) + '. ' + IIf([Vendas].[Tipo]='Externa',[Vendas].[Vendedora],IIf([Vendas].[Vendedora]='P.T.','P.T.','Loja'))) AS TPP,
IIf([Origem]='Outros','Ou',[Origem]) AS O,  IIf([Oficial]=1,'W','') AS w,
                         dbo.[1TabPeças].Classe, dbo.[1TabPeças].Oficial, format(dbo.VENDAS.DataVenda, 'mmyyyy') AS mesDV, dbo.[1TabPeças].DataFabric, Format(dbo.[1TabPeças].DataReg, 'mmyyyy') AS mesDF, dbo.VENDAS.ValorFinal, dbo.VENDAS.Real, 
                         dbo.VENDAS.Dolar, dbo.VENDAS.ContaCorrente, dbo.VENDAS.CCCheque, dbo.[VENDAS DET].Comissão, dbo.VENDAS.Ouro, dbo.[VENDAS DET].ValorVenda, dbo.VENDAS.Desconto, dbo.VENDAS.CCDeb, dbo.VENDAS.Troca, 
                         isnull(dbo.VENDAS.Deb, 0) + Isnull(dbo.VENDAS.Cartão, 0) as Cartão, dbo.Clientes.IDCliente,
						 Isnull(dbo.VENDAS.Cartão, 0) as Cartão1,
						 Isnull(dbo.VENDAS.Cartão2, 0) as Cartão2,
						 Isnull(dbo.VENDAS.Deb, 0) as Deb1,
						 dbo.VENDAS.NomeCDeb, dbo.VENDAS.Cheque, dbo.VENDAS.FormaCartão, dbo.VENDAS.FormaCartão2, dbo.VENDAS.FormaCheque, dbo.VENDAS.ValorTransf
FROM            dbo.VENDAS LEFT OUTER JOIN
                         dbo.Clientes ON dbo.VENDAS.IDCliente = dbo.Clientes.IDCliente INNER JOIN
                         dbo.[1TabPeças] INNER JOIN
                         dbo.[VENDAS DET] ON dbo.[1TabPeças].IDPeça = dbo.[VENDAS DET].Peça ON dbo.VENDAS.Id = dbo.[VENDAS DET].Venda) a
WHERE IDCliente = @IdCli) t
order by t.Venda, t.ValorFinal;


END
