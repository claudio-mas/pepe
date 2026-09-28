/* ============================================================================
   BOU_v1_down.sql  --  rollback de BOU_v1_up.sql
   ----------------------------------------------------------------------------
   Devolve Classe='BOU' as 13 pecas migradas para 'OUT'.

   So volta quem esta em 'OUT': se alguma peca tiver sido reclassificada a mao
   depois da migracao (para AN, PEN, etc), ela e deixada como esta -- reverter
   por cima apagaria uma decisao mais recente que a migracao.

   Nao desfaz a remocao de "BOU" do combo em frmEstoque.Designer.vb.
   ============================================================================ */

USE BDTorras;
GO

SET NOCOUNT ON;
GO

DECLARE @alvo TABLE (IDPeca int PRIMARY KEY);
INSERT INTO @alvo (IDPeca) VALUES
    (26345), (26346), (27927), (29565), (33372), (33517), (33522),
    (33801), (42510), (45191), (45207), (45209), (45294);

PRINT '--- ANTES DO ROLLBACK ---';
SELECT p.[IDPeça], p.Classe, p.[Modêlo], p.[Família]
FROM dbo.[1TabPeças] p JOIN @alvo a ON a.IDPeca = p.[IDPeça]
ORDER BY p.[IDPeça];

BEGIN TRANSACTION;

UPDATE p
   SET p.Classe = 'BOU'
  FROM dbo.[1TabPeças] p
  JOIN @alvo a ON a.IDPeca = p.[IDPeça]
 WHERE p.Classe = 'OUT';

DECLARE @n int = @@ROWCOUNT;

COMMIT TRANSACTION;

PRINT 'Revertidas ' + CAST(@n AS varchar(10)) + ' peca(s) de OUT para BOU.';
IF @n <> 13
    PRINT 'ATENCAO: esperado 13. As demais nao estavam em OUT -- conferir na mao.';
GO

PRINT '--- DEPOIS DO ROLLBACK ---';
SELECT p.[IDPeça], p.Classe, p.[Modêlo], p.[Família]
FROM dbo.[1TabPeças] p
WHERE p.[IDPeça] IN (26345, 26346, 27927, 29565, 33372, 33517, 33522,
                     33801, 42510, 45191, 45207, 45209, 45294)
ORDER BY p.[IDPeça];
GO
