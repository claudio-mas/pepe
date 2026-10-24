

CREATE PROCEDURE [dbo].[USP_CC_SALDO_INICIAL] @DT date
AS
BEGIN
	SET NOCOUNT ON;

update tb set tb.SaldoInicial = a.SaldoIni
From
(SELECT        dbo.CC.CLIENTE, SUM(dbo.CC.VValor) AS SaldoIni
FROM            dbo.CC RIGHT OUTER JOIN
                         dbo.Clientes ON dbo.CC.CLIENTE = dbo.Clientes.IDCliente
WHERE        (dbo.CC.Data < @dt)
GROUP BY dbo.CC.CLIENTE) a
inner join tabExtrato tb on tb.IdCliente=a.CLIENTE;

END

