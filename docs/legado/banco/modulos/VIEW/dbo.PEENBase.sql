
CREATE VIEW [dbo].[PEENBase]
AS
SELECT        dbo.[1TabPeças].IDPeça, dbo.PEDRAS.DiamantesCT, dbo.PEDRAS.RubisCT, dbo.PEDRAS.SafirasCT, dbo.PEDRAS.EsmeraldasCT, dbo.PEDRAS.PedrasCT, dbo.PEDRAS.BrasCT, dbo.PEDRAS.PerolasCT, 
                         dbo.PEDRAS.Diamantes2CT
FROM            dbo.PEDRAS RIGHT OUTER JOIN
                         dbo.[1TabPeças] ON dbo.PEDRAS.Id = dbo.[1TabPeças].IDPeça
WHERE        (dbo.[1TabPeças].Modêlo IS NOT NULL)
