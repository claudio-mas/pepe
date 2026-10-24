
CREATE VIEW [dbo].[VI_GER_CRED]
AS
SELECT        VValor, Pagto, Parcela, CASE WHEN VC.Parcela = '1/1' THEN 'A vista' ELSE 'Parcelado' END AS CondPag, NomeCartão
FROM            dbo.[Vencto Cartão] AS VC
WHERE        (Venda > 0) AND (NOT (NomeCartão LIKE '%Débito%')) AND (Pagto IS NOT NULL) OR
                         (NOT (NomeCartão LIKE '%Débito%')) AND (Pagto IS NOT NULL) AND (IdConserto > 0) OR
                         (NOT (NomeCartão LIKE '%Débito%')) AND (Pagto IS NOT NULL) AND (IdCC > 0)
