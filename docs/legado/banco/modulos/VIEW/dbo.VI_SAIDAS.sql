
CREATE VIEW [dbo].[VI_SAIDAS]
AS
SELECT        TOP (100) PERCENT Saidas.DataSaida, [1TabPeças].Classe + [1TabPeças].Modêlo AS Ficha, Saidas.Custo, Saidas.ValorSaida, TiposSaidas.Motivo, Saidas.Observações
FROM            dbo.Saidas AS Saidas LEFT OUTER JOIN
                         dbo.TiposSaidas AS TiposSaidas ON TiposSaidas.Id = Saidas.IdMotivo INNER JOIN
                         dbo.[1TabPeças] AS [1TabPeças] ON [1TabPeças].IDPeça = Saidas.IdPeça
