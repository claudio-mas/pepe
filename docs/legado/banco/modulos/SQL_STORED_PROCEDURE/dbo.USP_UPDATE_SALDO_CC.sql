-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_UPDATE_SALDO_CC] (@IdCliente integer, @op integer=0)
AS
 
DECLARE @cmdSQL VARCHAR(1000)
SET @cmdSQL = ';WITH Saldos1 As (
    Select Dt, Id, VValor, Debito, Credito,
    sum(isnull(Credito,0) + isnull(Debito,0)) over (order by IdCliente, Dt, Historico, Credito) As Saldo
    FROM Saldos
    WHERE    (IdCliente = ' + CAST(@IdCliente As VARCHAR(10)) + ')'
 
 
SET @cmdSQL += ')' + CHAR(10)
 
SET @cmdSQL += 'Update Saldos SET Saldo = S.Saldo FROM Saldos INNER JOIN Saldos1 As S' + CHAR(10)
SET @cmdSQL += 'ON Saldos.Id = S.Id'

 if @op=1 begin UPDATE Saldos SET Saldo = 0; EXEC (@cmdSQL); end;

 if @op=0
	begin
	delete from Saldos;
	insert into Saldos (Dt, IdCLIENTE, Historico, VValor, Debito, Credito, Saldo)
		(SELECT dbo.CC.Data, dbo.CC.CLIENTE, CASE CC.Op WHEN 'Conserto' THEN dbo.CC.Op + ' (' + CC.Tp + ')' WHEN 'Venda' THEN dbo.CC.Op + ' ' + Vendas.Venda + ' (' + CC.Tp + ')' WHEN 'C/C' THEN dbo.CC.Op + ' (' + CC.Tp + ')' END AS Historico,
		dbo.CC.VValor, iif(dbo.CC.VValor < 0, dbo.CC.VValor, 0) as Debito, iif(dbo.CC.VValor >= 0, dbo.CC.VValor, 0) as Credito, 0
		FROM dbo.CC INNER JOIN dbo.Clientes ON dbo.CC.CLIENTE = dbo.Clientes.IDCliente LEFT OUTER JOIN dbo.VENDAS ON dbo.CC.ID = dbo.VENDAS.Id
		WHERE (dbo.CC.CLIENTE IS NOT NULL)); -- ORDER BY dbo.CC.CLIENTE, dbo.CC.Data, Historico, Debito)

	end

