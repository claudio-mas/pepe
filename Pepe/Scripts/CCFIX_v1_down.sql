/* =============================================================================
   CCFIX_v1_down.sql

   Reverte CCFIX_v1_up.sql: restaura os valores float bit-exatos dos lançamentos
   48498 e 51229 da cliente "Sonia Monçores Velloso" (IDCliente 6147) a partir de
   dbo.CCFIX_v1_Backup e remove a tabela de backup.

   Depois de rodar isto, o Débitos C/C do gerencial volta a exibir -34.542,00
   (com a duplicidade intermitente da cliente).
   ============================================================================= */

SET NOCOUNT ON;
SET XACT_ABORT ON;

IF OBJECT_ID('dbo.CCFIX_v1_Backup', 'U') IS NULL
BEGIN
    RAISERROR('CCFIX_v1_down: dbo.CCFIX_v1_Backup não existe. Nada a reverter.', 16, 1);
    RETURN;
END

BEGIN TRANSACTION;

UPDATE  cc
SET     cc.Real = CONVERT(float, b.RealBin)
FROM    dbo.[Conta Corrente] AS cc
JOIN    dbo.CCFIX_v1_Backup  AS b ON b.ID = cc.ID
WHERE   cc.ID IN (48498, 51229);

/* Confere que os bits voltaram exatamente ao original. */
DECLARE @divergentes int;

SELECT  @divergentes = COUNT(*)
FROM    dbo.[Conta Corrente] AS cc
JOIN    dbo.CCFIX_v1_Backup  AS b ON b.ID = cc.ID
WHERE   CONVERT(varbinary(8), cc.Real) <> b.RealBin;

IF @divergentes <> 0
BEGIN
    ROLLBACK TRANSACTION;
    RAISERROR('CCFIX_v1_down: %d lançamento(s) não voltaram ao valor original. Reversão abortada.', 16, 1, @divergentes);
    RETURN;
END

DROP TABLE dbo.CCFIX_v1_Backup;

COMMIT TRANSACTION;

PRINT 'CCFIX_v1_down: OK. Valores originais restaurados e backup removido.';
