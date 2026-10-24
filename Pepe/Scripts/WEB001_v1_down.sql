/* ============================================================================
   WEB001_v1_down.sql  --  Desfaz o WEB001_v1_up.sql
   ----------------------------------------------------------------------------
   Remove o usuario e o login pepe_web, as tabelas web.RegistroAcesso,
   web.Sessao e web.Usuario e o schema web. Nao toca em nenhum objeto do
   legado (dbo). ATENCAO: apaga os usuarios, sessoes e registros de acesso
   da versao web.

   Idempotente: rodar duas vezes nao faz nada na segunda.

   Como rodar (conectado ao mesmo banco do _up):
     sqlcmd -S 127.0.0.1,14330 -U sa -d BDTorras -I -b -f 65001 -i Pepe\Scripts\WEB001_v1_down.sql
   ============================================================================ */

SET NOCOUNT ON;
SET QUOTED_IDENTIFIER ON;
GO

IF DB_NAME() NOT IN (N'BDTorras', N'BDTorrasTeste')
BEGIN
    RAISERROR(N'WEB001: conecte-se ao BDTorras (ou ao BDTorrasTeste) antes de rodar este script.', 16, 1);
    SET NOEXEC ON;
END
GO

IF EXISTS (SELECT 1 FROM sys.database_principals WHERE name = N'pepe_web')
    DROP USER pepe_web;
GO

-- O login e da instancia: so sai se nenhum outro banco tiver usuario para ele.
IF EXISTS (SELECT 1 FROM sys.server_principals WHERE name = N'pepe_web')
BEGIN
    DECLARE @emUso int = 0, @db sysname, @sql nvarchar(max);
    DECLARE bancos CURSOR LOCAL FAST_FORWARD FOR
        SELECT name FROM sys.databases WHERE state_desc = 'ONLINE' AND name <> DB_NAME();
    OPEN bancos;
    FETCH NEXT FROM bancos INTO @db;
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = N'SELECT @n = COUNT(*) FROM ' + QUOTENAME(@db) + N'.sys.database_principals p '
                 + N'JOIN sys.server_principals s ON s.sid = p.sid WHERE s.name = N''pepe_web''';
        DECLARE @n int = 0;
        EXEC sp_executesql @sql, N'@n int OUTPUT', @n = @n OUTPUT;
        SET @emUso += @n;
        FETCH NEXT FROM bancos INTO @db;
    END
    CLOSE bancos;
    DEALLOCATE bancos;

    IF @emUso = 0
        DROP LOGIN pepe_web;
    ELSE
        PRINT N'WEB001_v1_down: login pepe_web mantido (ainda usado em outro banco).';
END
GO

IF OBJECT_ID(N'web.RegistroAcesso', N'U') IS NOT NULL DROP TABLE web.RegistroAcesso;
IF OBJECT_ID(N'web.Sessao', N'U') IS NOT NULL DROP TABLE web.Sessao;
IF OBJECT_ID(N'web.Usuario', N'U') IS NOT NULL DROP TABLE web.Usuario;
GO

IF SCHEMA_ID(N'web') IS NOT NULL AND NOT EXISTS (SELECT 1 FROM sys.objects WHERE schema_id = SCHEMA_ID(N'web'))
    DROP SCHEMA web;
GO

SET NOEXEC OFF;
GO

PRINT N'WEB001_v1_down: schema web e usuario pepe_web removidos de ' + DB_NAME() + N'.';
GO
