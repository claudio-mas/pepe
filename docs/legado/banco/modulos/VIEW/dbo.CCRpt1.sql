
CREATE VIEW [dbo].[CCRpt1]
AS
SELECT        TOP (100) PERCENT dbo.Clientes.Nome, MAX(dbo.CC.Data) AS D, SUM(dbo.CC.VValor) AS Saldo
FROM            dbo.Clientes INNER JOIN
                         dbo.CC ON dbo.Clientes.IDCliente = dbo.CC.Cliente
GROUP BY dbo.Clientes.Nome
ORDER BY D DESC
