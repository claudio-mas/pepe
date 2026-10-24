
CREATE VIEW [dbo].[CCNovoGer]
AS
SELECT        dbo.CCRpt1.Nome AS Cliente, dbo.CCRpt1.D, dbo.CCRpt22.Anterior, dbo.CCRpt1.Saldo
FROM            dbo.CCRpt1 INNER JOIN
                         dbo.CC INNER JOIN
                         dbo.Clientes ON dbo.CC.CLIENTE = dbo.Clientes.IDCliente ON dbo.CCRpt1.Nome = dbo.Clientes.Nome AND dbo.CCRpt1.D = dbo.CC.Data INNER JOIN
                         dbo.CCRpt22 ON dbo.Clientes.Nome = dbo.CCRpt22.Nome
WHERE        (dbo.CC.obs <> N'Lançamento para zerar saldo') OR
                         (dbo.CC.obs IS NULL) OR
                         (dbo.Clientes.NaoZerarCC = 1)
GROUP BY dbo.CCRpt1.Nome, dbo.CCRpt1.D, dbo.CCRpt22.Anterior, dbo.CCRpt1.Saldo
HAVING        (dbo.CCRpt1.Saldo <> 0)
