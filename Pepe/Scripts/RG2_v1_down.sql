/* ============================================================================
   RG2_v1_down.sql  --  rollback de RG2_v1_up.sql
   ----------------------------------------------------------------------------
   Remove os objetos criados para o Relatorio Gerencial Novo.
   Nao toca em nenhum objeto anterior a essa migracao.

   ATENCAO: dropar Cotacao.ValPrata DESCARTA as cotacoes de prata ja digitadas.
   Por isso esse trecho vem comentado -- descomente conscientemente.
   ============================================================================ */

USE BDTorras;
GO

IF OBJECT_ID('dbo.VW_RG2_ESTOQUE', 'V')        IS NOT NULL DROP VIEW dbo.VW_RG2_ESTOQUE;
IF OBJECT_ID('dbo.VW_RG2_PECAS_REG', 'V')      IS NOT NULL DROP VIEW dbo.VW_RG2_PECAS_REG;
IF OBJECT_ID('dbo.VW_RG2_PECAS_VENDIDAS', 'V') IS NOT NULL DROP VIEW dbo.VW_RG2_PECAS_VENDIDAS;
IF OBJECT_ID('dbo.VW_RG2_VENDAS_ITENS', 'V')   IS NOT NULL DROP VIEW dbo.VW_RG2_VENDAS_ITENS;
GO

PRINT 'Views VW_RG2_* removidas.';
GO

/* Descomente para remover tambem a coluna de cotacao da prata.
   Antes disso, o frmCota precisa voltar a NAO gravar ValPrata,
   senao o INSERT passa a falhar.

IF COL_LENGTH('dbo.Cotação', 'ValPrata') IS NOT NULL
BEGIN
    ALTER TABLE dbo.[Cotação] DROP COLUMN ValPrata;
    PRINT 'Cotacao.ValPrata removida.';
END
GO
*/
