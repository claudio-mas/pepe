

CREATE PROCEDURE [dbo].[USP_Cheques] 
AS
BEGIN
	SET NOCOUNT ON;

delete from tabCheques;

INSERT INTO tabCheques
([IDV], IdVenda, [N], [Venda], [DataVenda], [Destino], [Parcela], [VValor], [Pagto], [Cheque], [Banco], [Uso], [Obs], [Vencto])

SELECT
	dbo.[Vencto Cheques].Id AS IdCheque, dbo.VENDAS.Id AS IdVenda,
	ISNULL(dbo.Clientes.Nome,ISNULL(dbo.Clientes.Cliente, dbo.VENDAS.SEMCADASTRO)) AS N,
	ISNULL(dbo.VENDAS.Venda, 'Avulso') AS Vd, 
	dbo.VENDAS.DataVenda, dbo.[Vencto Cheques].Destino, dbo.[Vencto Cheques].Parcela, dbo.[Vencto Cheques].VValor, dbo.[Vencto Cheques].Pagto,
	dbo.[Vencto Cheques].Cheque, dbo.[Vencto Cheques].Banco, dbo.[Vencto Cheques].Uso, dbo.[Vencto Cheques].Obs, dbo.[Vencto Cheques].Vencto
FROM
	dbo.[Vencto Cheques] INNER JOIN dbo.VENDAS ON dbo.[Vencto Cheques].Venda = dbo.VENDAS.Id
						LEFT OUTER JOIN dbo.Clientes ON dbo.VENDAS.IDCliente = dbo.Clientes.IDCliente;
--WHERE        (dbo.VENDAS.Venda IS NOT NULL);

INSERT INTO tabCheques
([IDV], IdConserto, [N], [Venda], [DataVenda], [Destino], [Parcela], [VValor], [Pagto], [Cheque], [Banco], [Uso], [Obs], [Vencto])

SELECT
	dbo.[Vencto Cheques].Id AS IdCheque,
	dbo.CONSERTOS.ID AS IdConserto,
	ISNULL(dbo.Clientes.Nome, dbo.Clientes.Cliente) AS N,
	'Conserto' AS Venda,
	dbo.CONSERTOS.DT,
	dbo.[Vencto Cheques].Destino, 
	dbo.[Vencto Cheques].Parcela,
	dbo.[Vencto Cheques].VValor,
	dbo.[Vencto Cheques].Pagto,
	dbo.[Vencto Cheques].Cheque,
	dbo.[Vencto Cheques].Banco,
	dbo.[Vencto Cheques].Uso,
	dbo.[Vencto Cheques].Obs, 
	dbo.[Vencto Cheques].Vencto
FROM
	dbo.Clientes INNER JOIN dbo.CONSERTOS ON dbo.Clientes.IDCliente = dbo.CONSERTOS.CLIENTE
				INNER JOIN dbo.[Vencto Cheques] ON dbo.CONSERTOS.ID = dbo.[Vencto Cheques].IdConserto;

INSERT INTO tabCheques
([IDV], IdCC, [N], [Venda], [DataVenda], [Destino], [Parcela], [VValor], [Pagto], [Cheque], [Banco], [Uso], [Obs], [Vencto])

SELECT 
	dbo.[Vencto Cheques].Id AS IdCheque,
	dbo.[Conta Corrente].ID AS IdCC,
	ISNULL(dbo.Clientes.Nome, dbo.Clientes.Cliente) AS N,
	'C/C' AS Venda,
	dbo.[Conta Corrente].Data,
	dbo.[Vencto Cheques].Destino, 
	dbo.[Vencto Cheques].Parcela,
	dbo.[Vencto Cheques].VValor,
	dbo.[Vencto Cheques].Pagto,
	dbo.[Vencto Cheques].Cheque,
	dbo.[Vencto Cheques].Banco,
	dbo.[Vencto Cheques].Uso,
	dbo.[Vencto Cheques].Obs, 
	dbo.[Vencto Cheques].Vencto
FROM
	dbo.[Conta Corrente] INNER JOIN dbo.[Vencto Cheques]
	ON dbo.[Conta Corrente].ID = dbo.[Vencto Cheques].IdCC
	INNER JOIN dbo.Clientes ON dbo.[Conta Corrente].Cliente = dbo.Clientes.IDCliente;

END

