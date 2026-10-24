
CREATE VIEW [dbo].[Gerencial]
AS
SELECT        TOP (100) PERCENT dbo.[1TabPeças].Classe AS Peça, dbo.[1TabPeças].Modêlo AS Ficha, CAST(dbo.[1TabPeças].DataReg AS datetime) AS [Data de Registro], dbo.[1TabPeças].Origem, dbo.[1TabPeças].Família AS Tipo, 
                         dbo.[1TabPeças].Custo, CASE WHEN [Família] = 'Ou' THEN [TotalValor] ELSE [OuroV] END AS [Au (R$)], ISNULL(dbo.[1TabPeças].MOExt, 0) + ISNULL(dbo.[1TabPeças].MOInt, 0) AS [Mão de Obra], (ISNULL(dbo.[1TabPeças].Custo, 
                         0) - (CASE WHEN [Família] = 'Ou' THEN [TotalValor] ELSE [OuroV] END)) - (ISNULL(dbo.[1TabPeças].MOExt, 0) + ISNULL(dbo.[1TabPeças].MOInt, 0)) AS Outros
FROM            dbo.[1TabPeças] LEFT OUTER JOIN
                         dbo.METAIS ON dbo.[1TabPeças].IDPeça = dbo.METAIS.Id
WHERE        (CAST(dbo.[1TabPeças].DataReg AS datetime) IS NOT NULL)
ORDER BY [Data de Registro], Peça, Ficha
