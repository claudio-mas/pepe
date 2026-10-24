CREATE VIEW dbo.BasePrecos
AS
SELECT        Ficha, LEFT(Descrição, CHARINDEX('-', Descrição) - 2) AS Classe, PrVenda, PrAtualizado
FROM            dbo.PeçasEstoque
WHERE        (LEFT(Descrição, CHARINDEX('-', Descrição) - 2) IN ('AN', 'BR', 'GAR', 'PEN', 'PUL', 'BOU', 'ALI', 'OUT')) AND (PrAtualizado <> PrVenda) AND (Descrição IS NOT NULL) AND (CHARINDEX('-', Descrição) > 0)
