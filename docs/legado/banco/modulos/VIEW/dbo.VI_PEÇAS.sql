
CREATE VIEW [dbo].[VI_PEÇAS]
AS
SELECT        IDPeça, Custo, DataReg, Origem, MOExt, MOInt, ISNULL(MOExt, 0) + ISNULL(MOInt, 0) AS MO
FROM            dbo.[1TabPeças]
