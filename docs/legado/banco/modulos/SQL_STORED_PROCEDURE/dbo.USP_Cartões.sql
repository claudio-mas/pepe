



CREATE PROCEDURE [dbo].[USP_Cartões] 
AS
BEGIN
	SET NOCOUNT ON;

delete from tabcartões;

update [Vencto Cartão] set Pagto = Vencto Where Vencto <= convert(varchar, getdate(), 103) and Pagto is Null;

INSERT INTO [tabCartões] ([IdCC],[N1],[N],[Venda],[DataVenda],[NomeCartão],[Parcela],[VValor],[Pagto],[Vencto],[IDC],[Baixar], Total)
SELECT        c0.IdCC, ISNULL(dbo.CONSERTOS.SEMCADASTRO, c0.N) AS N1, CASE WHEN [IdCC] <> NULL AND [IdCC] > 0 THEN [C0].[N] ELSE isnull(isnull([SEMCADASTRO], [C0].[N]), [Clientes].[Nome]) END AS N, 
                         CASE WHEN [C0].[Venda] <> NULL THEN [C0].[Venda] ELSE (CASE WHEN [IdCC] <> NULL AND [IdCC] > 0 THEN 'C/C' ELSE
	 (CASE WHEN [IdConserto] IS NULL OR [IdConserto] = 0 THEN
	 
	 --isnull([C0].[Venda], 'Avulso')
	 iif([C0].[Venda] Is Null and [C0].[IdCC] is Null, 'Avulso', iif([C0].[Venda] Is Null,'C.C.', [C0].[Venda]))

	 ELSE 'Conserto' END) END) END AS Venda, CASE WHEN [IdCC] <> NULL AND [IdCC] > 0 THEN [CC2].[Data] ELSE isnull([C0].[DataVenda], [Consertos].[DT]) END AS DataVenda, 
                         CASE WHEN [IdCC] <> NULL AND [IdCC] > 0 THEN [CC2].[NCartão] ELSE isnull([C0].[NomeCartão], isnull([Consertos].[NomeCartão], [CONSERTOS].[NomeCartãoDébito])) END AS NomeCartão, c0.Parcela, c0.VValor, c0.Pagto, 
                         c0.Vencto, c0.IDC, 0 AS baixar, isnull(c0.ValorFinal, 0) + isnull(dbo.CONSERTOS.Cartão, 0) + isnull(cc2.Cartão, 0) as VTotal
FROM            dbo.Clientes RIGHT OUTER JOIN
                         dbo.CONSERTOS ON dbo.Clientes.IDCliente = dbo.CONSERTOS.CLIENTE RIGHT OUTER JOIN
                             (SELECT        dbo.[Vencto Cartão].IdCC, dbo.[Vencto Cartão].IdConserto, dbo.[Vencto Cartão].Id AS IDC, ISNULL(dbo.VENDAS.SEMCADASTRO, ISNULL(Clientes_2.Nome, dbo.Clientes.Nome)) AS N, Clientes_2.Nome, dbo.VENDAS.Venda, 
                         ISNULL(dbo.VENDAS.DataVenda, dbo.[Conta Corrente].Data) AS DataVenda, dbo.[Vencto Cartão].NomeCartão, dbo.[Vencto Cartão].Parcela, dbo.[Vencto Cartão].VValor, dbo.[Vencto Cartão].Pagto, dbo.[Vencto Cartão].Vencto, 
                         dbo.VENDAS.ValorFinal
FROM            dbo.Clientes RIGHT OUTER JOIN
                         dbo.[Conta Corrente] ON dbo.Clientes.IDCliente = dbo.[Conta Corrente].Cliente RIGHT OUTER JOIN
                         dbo.[Vencto Cartão] ON dbo.[Conta Corrente].ID = dbo.[Vencto Cartão].IdCC LEFT OUTER JOIN
                         dbo.VENDAS LEFT OUTER JOIN
                         dbo.Clientes AS Clientes_2 ON dbo.VENDAS.IDCliente = Clientes_2.IDCliente ON dbo.[Vencto Cartão].Venda = dbo.VENDAS.Id) AS c0 ON dbo.CONSERTOS.ID = c0.IdConserto LEFT OUTER JOIN
                             (SELECT        dbo.[Conta Corrente].ID, ISNULL(Clientes_1.Nome, Clientes_1.Cliente) AS N, dbo.[Conta Corrente].NomeCartão AS NCartão, dbo.[Conta Corrente].Data, cast(dbo.[Conta Corrente].Cartão as float) as Cartão
                               FROM            dbo.Clientes AS Clientes_1 INNER JOIN
                                                         dbo.[Conta Corrente] ON Clientes_1.IDCliente = dbo.[Conta Corrente].Cliente INNER JOIN
                                                         dbo.[Vencto Cartão] AS [Vencto Cartão_1] ON dbo.[Conta Corrente].ID = [Vencto Cartão_1].IdCC
                               GROUP BY dbo.[Conta Corrente].ID, ISNULL(Clientes_1.Nome, Clientes_1.Cliente), dbo.[Conta Corrente].NomeCartão, dbo.[Conta Corrente].Data, cast(dbo.[Conta Corrente].Cartão as float)) AS cc2 ON c0.IdCC = cc2.ID;


END

