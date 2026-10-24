
CREATE VIEW [dbo].[CCDeb old]
AS
SELECT     IDCliente AS Cliente, DataVenda AS Data, 'Débito' AS Tp, 'Venda' AS Op, CCDeb * - 1 AS VValor, Id
FROM         dbo.VENDAS
WHERE     (CCDeb * - 1 <> 0)
