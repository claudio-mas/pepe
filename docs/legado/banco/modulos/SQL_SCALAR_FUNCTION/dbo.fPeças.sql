
CREATE FUNCTION [dbo].[fPeças] (@IdVenda int)
RETURNS NVARCHAR(MAX)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @texto nvarchar(max)

	SELECT @texto = ISNULL(@Texto,'') + Classe + Modêlo + ' / '
		FROM
			(SELECT        TOP (100) PERCENT dbo.[VENDAS DET].Venda, dbo.[1TabPeças].Modêlo, dbo.[1TabPeças].Classe
FROM            dbo.[1TabPeças] INNER JOIN
                         dbo.[VENDAS DET] ON dbo.[1TabPeças].IDPeça = dbo.[VENDAS DET].Peça
WHERE        (dbo.[VENDAS DET].Venda = @IdVenda)) AS A
			
	-- Return the result of the function
	RETURN left(@texto, len(@texto) - 1)

END
