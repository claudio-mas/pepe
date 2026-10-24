
CREATE VIEW [dbo].[CCRpt2]
AS
SELECT        dbo.CC.Cliente, dbo.Clientes.Nome, SUM(dbo.CC.VValor) AS Anterior
FROM            dbo.Clientes INNER JOIN
                         dbo.CC ON dbo.Clientes.IDCliente = dbo.CC.Cliente INNER JOIN
                         dbo.CCRpt1 ON dbo.Clientes.Nome = dbo.CCRpt1.Nome AND dbo.CC.Data < dbo.CCRpt1.D
GROUP BY dbo.CC.Cliente, dbo.Clientes.Nome
