
CREATE VIEW [dbo].[VI_Getnet]
AS
SELECT        TOP (100) PERCENT dbo.VI_Getnet_Base.*
FROM            dbo.VI_Getnet_Base
ORDER BY Venda, Parc
