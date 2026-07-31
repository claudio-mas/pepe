/* ============================================================================
   BOU_v1_up.sql  --  elimina BOU como tipo de peca (coluna Classe)
   ----------------------------------------------------------------------------
   "BOU" existia nos dois eixos de 1TabPecas ao mesmo tempo:

     Familia -> o metal: 'Ou', 'Ag', 'Ou / Ag', 'Boutique' (= sem ouro nem prata)
     Classe  -> o tipo de peca: AN, BR, GAR, PEN, PUL, BOU, ALI, OUT

   Boutique passa a existir SO como Familia. As pecas que tinham Classe='BOU'
   viram Classe='OUT' ("peca diversa"), que e o papel que BOU vinha cumprindo
   na pratica -- as 13 pecas alvo tem Familia='Ag', ou seja, tem prata e nao
   sao boutique. Nenhuma informacao se perde: o metal continua na Familia.

   ESCOPO: somente pecas EM ESTOQUE (Vendida=0 e Saida=0). As 369 pecas 'BOU'
   e 108 'BUT' ja vendidas ficam intocadas, e nenhum relatorio historico muda.

   Os IDPeca vao literais de proposito: o rollback fica deterministico, e uma
   venda registrada entre escrever e rodar o script nao muda o conjunto afetado.

   Idempotente: rodar duas vezes nao faz nada na segunda.

   RODAR PRIMEIRO NUMA COPIA DE BDTorras. Rollback: BOU_v1_down.sql
   ============================================================================ */

USE BDTorras;
GO

SET NOCOUNT ON;
GO

DECLARE @alvo TABLE (IDPeca int PRIMARY KEY);
INSERT INTO @alvo (IDPeca) VALUES
    (26345), (26346), (27927), (29565), (33372), (33517), (33522),
    (33801), (42510), (45191), (45207), (45209), (45294);

PRINT '--- ANTES ---';
SELECT p.[IDPeça], p.Classe, p.[Modêlo], p.[Família], p.Vendida, p.Saida
FROM dbo.[1TabPeças] p JOIN @alvo a ON a.IDPeca = p.[IDPeça]
ORDER BY p.[IDPeça];

DECLARE @pendentes int = (SELECT COUNT(*) FROM dbo.[1TabPeças] p JOIN @alvo a ON a.IDPeca = p.[IDPeça] WHERE p.Classe = 'BOU');
DECLARE @jafeitas  int = (SELECT COUNT(*) FROM dbo.[1TabPeças] p JOIN @alvo a ON a.IDPeca = p.[IDPeça] WHERE p.Classe = 'OUT');

IF @pendentes = 0 AND @jafeitas = 13
BEGIN
    PRINT 'Migracao ja aplicada -- as 13 pecas ja estao como OUT. Nada a fazer.';
END
ELSE IF @pendentes + @jafeitas <> 13
BEGIN
    /* Alguma das 13 nao esta nem em BOU nem em OUT: o estado da base nao e o
       que foi levantado. Nao adivinhar -- parar e conferir na mao. */
    RAISERROR('Estado inesperado: %d em BOU e %d em OUT, somando != 13. Nada foi gravado.', 16, 1, @pendentes, @jafeitas);
END
ELSE
BEGIN
    BEGIN TRANSACTION;

    UPDATE p
       SET p.Classe = 'OUT'
      FROM dbo.[1TabPeças] p
      JOIN @alvo a ON a.IDPeca = p.[IDPeça]
     WHERE p.Classe = 'BOU';

    DECLARE @n int = @@ROWCOUNT;

    IF @n <> @pendentes
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR('Esperava atualizar %d linhas, atualizou %d. ROLLBACK -- nada foi gravado.', 16, 1, @pendentes, @n);
    END
    ELSE
    BEGIN
        COMMIT TRANSACTION;
        PRINT 'COMMIT: ' + CAST(@n AS varchar(10)) + ' peca(s) migrada(s) de BOU para OUT.';
    END
END
GO

PRINT '--- DEPOIS ---';

SELECT 'BOU ainda em estoque (esperado 0)' AS conferencia, COUNT(*) AS qtd
FROM dbo.[1TabPeças]
WHERE Classe = 'BOU' AND ISNULL(Vendida, 0) = 0 AND ISNULL(Saida, 0) = 0
UNION ALL
SELECT 'Total de pecas em estoque (esperado 585)', COUNT(*)
FROM dbo.[1TabPeças]
WHERE ISNULL(Vendida, 0) = 0 AND ISNULL(Saida, 0) = 0;

SELECT p.[IDPeça], p.Classe, p.[Modêlo], p.[Família]
FROM dbo.[1TabPeças] p
WHERE p.[IDPeça] IN (26345, 26346, 27927, 29565, 33372, 33517, 33522,
                     33801, 42510, 45191, 45207, 45209, 45294)
ORDER BY p.[IDPeça];
GO
