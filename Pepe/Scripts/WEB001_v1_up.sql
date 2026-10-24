/* ============================================================================
   WEB001_v1_up.sql  --  Versao web, entrega 001: schema web e login pepe_web
   ----------------------------------------------------------------------------
   Cria SO objetos novos (constituicao I.1 e I.2):
     - schema web com web.Usuario, web.Sessao e web.RegistroAcesso
       (specs/001-consulta-clientes/data-model.md, secao 1);
     - login e usuario pepe_web, com SELECT apenas nas fontes da entrega
       (dbo.Clientes, dbo.CC, dbo.VENDAS, dbo.[VENDAS DET], dbo.[1TabPecas])
       e leitura/escrita apenas no schema web (research.md R10).
   Nenhum objeto existente e alterado.

   Idempotente: rodar duas vezes nao faz nada na segunda.

   Como rodar (conectado AO BANCO CERTO; primeiro na copia do Docker):
     sqlcmd -S 127.0.0.1,14330 -U sa -d BDTorras -I -b -f 65001 ^
            -v SENHA_PEPE_WEB="<senha forte>" -i Pepe\Scripts\WEB001_v1_up.sql
   -f 65001 e obrigatorio: o arquivo e UTF-8 e cita [1TabPecas] com cedilha.
   A senha vai so pela variavel do sqlcmd: nunca a escreva neste arquivo.
   O servidor precisa aceitar autenticacao do SQL Server (modo misto).

   Desfazer: WEB001_v1_down.sql.
   ============================================================================ */

SET NOCOUNT ON;
SET XACT_ABORT ON;
SET QUOTED_IDENTIFIER ON;
SET ANSI_NULLS ON;
GO

-- Trava de seguranca: so roda no BDTorras ou no banco de teste sintetico.
IF DB_NAME() NOT IN (N'BDTorras', N'BDTorrasTeste')
BEGIN
    RAISERROR(N'WEB001: conecte-se ao BDTorras (ou ao BDTorrasTeste) antes de rodar este script.', 16, 1);
    SET NOEXEC ON;
END
GO

IF SCHEMA_ID(N'web') IS NULL
    EXEC(N'CREATE SCHEMA web AUTHORIZATION dbo');
GO

IF OBJECT_ID(N'web.Usuario', N'U') IS NULL
BEGIN
    CREATE TABLE web.Usuario (
        IdUsuario        int IDENTITY(1, 1) NOT NULL CONSTRAINT PK_web_Usuario PRIMARY KEY,
        Login            nvarchar(50)  NOT NULL,
        Nome             nvarchar(100) NOT NULL,
        HashSenha        nvarchar(255) NOT NULL,
        Ativo            bit           NOT NULL CONSTRAINT DF_web_Usuario_Ativo DEFAULT (1),
        TentativasFalhas int           NOT NULL CONSTRAINT DF_web_Usuario_Tentativas DEFAULT (0),
        BloqueadoAte     datetime2(0)  NULL,
        CriadoEm         datetime2(0)  NOT NULL CONSTRAINT DF_web_Usuario_CriadoEm DEFAULT (SYSDATETIME()),
        UltimoAcesso     datetime2(0)  NULL
    );
    CREATE UNIQUE INDEX UX_web_Usuario_Login ON web.Usuario (Login);
END
GO

IF OBJECT_ID(N'web.Sessao', N'U') IS NULL
BEGIN
    CREATE TABLE web.Sessao (
        IdSessao   char(64)     NOT NULL CONSTRAINT PK_web_Sessao PRIMARY KEY, -- SHA-256 (hex) do id do cookie
        IdUsuario  int          NOT NULL CONSTRAINT FK_web_Sessao_Usuario REFERENCES web.Usuario (IdUsuario),
        CriadaEm   datetime2(0) NOT NULL,
        UltimoUso  datetime2(0) NOT NULL,
        ExpiraEm   datetime2(0) NOT NULL
    );
    CREATE INDEX IX_web_Sessao_Usuario ON web.Sessao (IdUsuario);
END
GO

IF OBJECT_ID(N'web.RegistroAcesso', N'U') IS NULL
BEGIN
    CREATE TABLE web.RegistroAcesso (
        IdRegistro bigint IDENTITY(1, 1) NOT NULL CONSTRAINT PK_web_RegistroAcesso PRIMARY KEY,
        Momento    datetime2(0) NOT NULL CONSTRAINT DF_web_RegistroAcesso_Momento DEFAULT (SYSDATETIME()),
        Login      nvarchar(50) NOT NULL,
        IdUsuario  int          NULL,
        Evento     varchar(20)  NOT NULL CONSTRAINT CK_web_RegistroAcesso_Evento
                   CHECK (Evento IN ('ENTRADA', 'ENTRADA_RECUSADA', 'BLOQUEIO', 'SAIDA', 'SESSAO_EXPIRADA')),
        Ip         varchar(45)  NULL
    );
    CREATE INDEX IX_web_RegistroAcesso_Momento ON web.RegistroAcesso (Momento);
END
GO

-- Login do servidor (nivel de instancia). O banco padrao e o banco atual.
IF NOT EXISTS (SELECT 1 FROM sys.server_principals WHERE name = N'pepe_web')
BEGIN
    DECLARE @sql nvarchar(max) =
        N'CREATE LOGIN pepe_web WITH PASSWORD = N''' + REPLACE(N'$(SENHA_PEPE_WEB)', N'''', N'''''')
        + N''', DEFAULT_DATABASE = ' + QUOTENAME(DB_NAME()) + N', CHECK_POLICY = ON, CHECK_EXPIRATION = OFF';
    EXEC (@sql);
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.database_principals WHERE name = N'pepe_web')
    CREATE USER pepe_web FOR LOGIN pepe_web WITH DEFAULT_SCHEMA = dbo;
GO

-- Legado: so leitura, e so nas fontes da entrega 001 (FR-015, FR-022).
GRANT SELECT ON OBJECT::dbo.Clientes        TO pepe_web;
GRANT SELECT ON OBJECT::dbo.CC              TO pepe_web;
GRANT SELECT ON OBJECT::dbo.VENDAS          TO pepe_web;
GRANT SELECT ON OBJECT::dbo.[VENDAS DET]    TO pepe_web;
GRANT SELECT ON OBJECT::dbo.[1TabPeças]     TO pepe_web;

-- Schema web: leitura e escrita.
GRANT SELECT, INSERT, UPDATE, DELETE ON SCHEMA::web TO pepe_web;
GO

SET NOEXEC OFF;
GO

PRINT N'WEB001_v1_up: schema web e login pepe_web prontos em ' + DB_NAME() + N'.';
GO
