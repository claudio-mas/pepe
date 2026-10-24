
CREATE VIEW [dbo].[CCCartãoCC]
AS
SELECT        ID, Cliente, Data, VValor, Tp, Op
FROM            (SELECT        dbo.[Conta Corrente].ID, dbo.[Conta Corrente].Cliente, dbo.[Conta Corrente].Data, CASE WHEN [Cartão] > 0 THEN [Cartão] * - 1 ELSE [Cartão] END AS VValor, 'Cartão' AS Tp, 'Crédito' AS Op
                          FROM            dbo.[Conta Corrente] INNER JOIN
                                                    dbo.[Vencto Cartão] ON dbo.[Conta Corrente].ID = dbo.[Vencto Cartão].IdCC
                          WHERE        (dbo.[Conta Corrente].CartãoCC = 1)) AS a
GROUP BY ID, Cliente, Data, VValor, Tp, Op
