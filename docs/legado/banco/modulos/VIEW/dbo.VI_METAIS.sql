
CREATE VIEW [dbo].[VI_METAIS]
AS
SELECT        dbo.METAIS.Id, dbo.[1TabPeças].DataReg, dbo.METAIS.OuroQtde, dbo.METAIS.OuroV, dbo.[1TabPeças].Origem, dbo.[1TabPeças].Família, CASE WHEN [Família] = 'Ou' THEN [TotalQtde] ELSE [OuroQtde] END AS OT, 
                         CASE WHEN [Família] = 'Ou' THEN [TotalValor] ELSE [OuroV] END AS OV
FROM            dbo.[1TabPeças] INNER JOIN
                         dbo.METAIS ON dbo.[1TabPeças].IDPeça = dbo.METAIS.Id
