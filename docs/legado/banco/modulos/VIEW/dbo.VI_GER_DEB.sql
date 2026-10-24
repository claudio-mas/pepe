
CREATE VIEW [dbo].[VI_GER_DEB]
AS
SELECT        Pagto, Parcela, VValor, NomeCartão
FROM            dbo.[Vencto Cartão]
WHERE        (Parcela = '1/1') AND (NomeCartão LIKE '%Débito%')
