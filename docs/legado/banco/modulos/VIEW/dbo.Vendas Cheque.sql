CREATE VIEW [dbo].[Vendas Cheque]
AS
SELECT        Venda, COUNT(Id) AS Parcelas
FROM            dbo.[Vencto Cheques]
GROUP BY Venda
