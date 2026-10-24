
CREATE VIEW [dbo].[CCDolarVenda]
AS
SELECT        Cliente, Data, Tp, VValor, Op, MIN(ID) AS ID
FROM            dbo.CCDolarVendaBase
GROUP BY Cliente, Data, Tp, VValor, Op
