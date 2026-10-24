
CREATE VIEW [dbo].[CCRpt22]
AS
SELECT        dbo.CCRpt1.Nome, ISNULL(dbo.CCRpt2.Anterior, 0) AS Anterior, dbo.CCRpt1.D, dbo.CCRpt1.Saldo
FROM            dbo.CCRpt1 LEFT OUTER JOIN
                         dbo.CCRpt2 ON dbo.CCRpt1.Nome = dbo.CCRpt2.Nome
