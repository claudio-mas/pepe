CREATE VIEW [dbo].[Vendas Cartão]
AS
SELECT        Venda, COUNT(Id) AS Parcelas
FROM            dbo.[Vencto Cartão]
GROUP BY Venda
