CREATE VIEW [dbo].[VI_CC_SALDOS]
AS
SELECT        ISNULL(dbo.Clientes.Nome, dbo.Clientes.Cliente) AS Cliente, SUM(dbo.CC.VValor) AS Saldo
FROM            dbo.Clientes INNER JOIN
                         dbo.CC ON dbo.Clientes.IDCliente = dbo.CC.CLIENTE
GROUP BY ISNULL(dbo.Clientes.Nome, dbo.Clientes.Cliente)
HAVING        (ISNULL(dbo.Clientes.Nome, dbo.Clientes.Cliente) IS NOT NULL)
