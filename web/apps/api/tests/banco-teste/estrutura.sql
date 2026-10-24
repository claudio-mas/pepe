/* ============================================================================
   estrutura.sql  --  Banco de teste sintético da versão web (BDTorrasTeste)
   ----------------------------------------------------------------------------
   GERADO por tests/banco-teste/gerar-estrutura.ts a partir de
   docs/legado/banco/02_colunas.csv, 03_chaves.csv e modulos/VIEW/dbo.CC.sql.
   Não edite à mão: rode o gerador de novo.

   Só para o contêiner de teste (web/docker-compose.teste.yml): apaga e recria
   o BDTorrasTeste e o login pepe_web dessa instância. Nunca rode no BDTorras.
   Nível de compatibilidade 120, como a produção (research.md R6).
   ============================================================================ */

SET QUOTED_IDENTIFIER ON;
GO
IF DB_ID(N'BDTorras') IS NOT NULL
    RAISERROR(N'Esta instância tem o BDTorras: estrutura.sql só roda no contêiner de teste.', 20, 1) WITH LOG;
GO
IF DB_ID(N'BDTorrasTeste') IS NOT NULL
BEGIN
    ALTER DATABASE BDTorrasTeste SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE BDTorrasTeste;
END
GO
IF EXISTS (SELECT 1 FROM sys.server_principals WHERE name = N'pepe_web')
    DROP LOGIN pepe_web;
GO
CREATE DATABASE BDTorrasTeste COLLATE Latin1_General_CI_AS;
GO
ALTER DATABASE BDTorrasTeste SET COMPATIBILITY_LEVEL = 120;
GO
USE BDTorrasTeste;
GO

CREATE TABLE dbo.[Clientes] (
    [IDCliente] int IDENTITY(1, 1) NOT NULL,
    [Título] nvarchar(10) NULL,
    [Nome] nvarchar(75) NULL,
    [Endereço] nvarchar(80) NULL,
    [Bairro] nvarchar(20) NULL,
    [Cidade] nvarchar(20) NULL,
    [Estado] nvarchar(2) NULL,
    [CEP] nvarchar(9) NULL,
    [Telefone] nvarchar(30) NULL,
    [Fax] nvarchar(15) NULL,
    [Imp] bit NULL DEFAULT ((0)),
    [Cliente] nvarchar(50) NULL,
    [Aniv] datetime2(0) NULL,
    [Indicaçao] nvarchar(250) NULL,
    [Medidas] nvarchar(250) NULL,
    [Saldo] real NULL DEFAULT ((0)),
    [Oculto] bit NULL DEFAULT ((0)),
    [Email] nvarchar(200) NULL,
    [SSMA_TimeStamp] timestamp NULL,
    [CPF] nvarchar(11) NULL,
    [CPF_MD] nvarchar(11) NULL,
    [DataCad] date NULL,
    [NaoZerarCC] int NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([IDCliente])
);
GO

CREATE TABLE dbo.[VENDAS] (
    [Id] int IDENTITY(1, 1) NOT NULL,
    [Venda] nvarchar(8) NULL,
    [IDCliente] int NULL DEFAULT ((0)),
    [DataVenda] datetime2(0) NULL,
    [Tipo] nvarchar(7) NULL,
    [Vendedora] nvarchar(20) NULL,
    [Real] float NULL DEFAULT ((0)),
    [Ouro] float NULL DEFAULT ((0)),
    [Dolar] real NULL DEFAULT ((0)),
    [Cheque] float NULL DEFAULT ((0)),
    [DC] nvarchar(50) NULL,
    [Pré1] float NULL DEFAULT ((0)),
    [PosPré1] datetime2(0) NULL,
    [DP1] nvarchar(50) NULL,
    [Pré2] float NULL DEFAULT ((0)),
    [PosPré2] datetime2(0) NULL,
    [DP2] nvarchar(50) NULL,
    [Pré3] float NULL DEFAULT ((0)),
    [PosPré3] datetime2(0) NULL,
    [DP3] nvarchar(50) NULL,
    [Pré4] float NULL DEFAULT ((0)),
    [PosPré4] datetime2(0) NULL,
    [DP4] nvarchar(50) NULL,
    [Pré5] float NULL DEFAULT ((0)),
    [PosPré5] datetime2(0) NULL,
    [DP5] nvarchar(50) NULL,
    [Cartão] float NULL DEFAULT ((0)),
    [ContaCorrente] float NULL DEFAULT ((0)),
    [CCCheque] float NULL DEFAULT ((0)),
    [CredDeb] tinyint NULL DEFAULT ((0)),
    [ValorVenda] float NULL DEFAULT ((0)),
    [Comissão] float NULL DEFAULT ((0)),
    [Desconto] float NULL DEFAULT ((0)),
    [ValorFinal] float NULL DEFAULT ((0)),
    [Destino] nvarchar(300) NULL,
    [FormaCartão] nvarchar(15) NULL,
    [Conserto] float NULL DEFAULT ((0)),
    [NomeCartão] nvarchar(15) NULL,
    [CCDeb] float NULL DEFAULT ((0)),
    [Troca] float NULL DEFAULT ((0)),
    [Credito] float NULL DEFAULT ((0)),
    [SEMCADASTRO] nvarchar(80) NULL,
    [ChequeCC] bit NULL DEFAULT ((0)),
    [CartãoCC] bit NULL DEFAULT ((0)),
    [DolarCC] bit NULL DEFAULT ((0)),
    [CashCC] bit NULL DEFAULT ((0)),
    [OuroCC] bit NULL DEFAULT ((0)),
    [FormaCheque] nvarchar(15) NULL,
    [Banco] nvarchar(50) NULL,
    [SSMA_TimeStamp] timestamp NULL,
    [Peças] nvarchar(max) NULL,
    [MD] bit NULL,
    [ValorTransf] money NULL,
    [BancoTransf] nvarchar(50) NULL,
    [Excluir] bit NULL,
    [Deb] float NULL,
    [NomeCDeb] nvarchar(15) NULL,
    [Cartão2] float NULL,
    [FormaCartão2] nvarchar(15) NULL,
    [NomeCartão2] nvarchar(15) NULL,
    [CartãoCC2] bit NULL,
    [Saldo] money NULL,
    [Aut] nvarchar(10) NULL,
    [AutDeb] nvarchar(10) NULL,
    [Aut2] nvarchar(10) NULL,
    [Cartão3] float NULL,
    [FormaCartão3] nvarchar(15) NULL,
    [NomeCartão3] nvarchar(15) NULL,
    [CartãoCC3] bit NULL,
    [Aut3] nvarchar(10) NULL,
    CONSTRAINT [PK_VENDAS] PRIMARY KEY ([Id])
);
GO

CREATE TABLE dbo.[VENDAS DET] (
    [Id] int IDENTITY(1, 1) NOT NULL,
    [Venda] int NULL DEFAULT ((0)),
    [Peça] int NULL DEFAULT ((0)),
    [ValorVenda] float NULL DEFAULT ((0)),
    [SSMA_TimeStamp] timestamp NULL,
    [Comissão] money NULL DEFAULT ((0)),
    [PrVenda] money NULL,
    [Desconto] money NULL,
    CONSTRAINT [PK_VENDAS_DET] PRIMARY KEY ([Id])
);
GO

CREATE TABLE dbo.[1TabPeças] (
    [IDPeça] int IDENTITY(1, 1) NOT NULL,
    [IDCliente] nvarchar(75) NULL,
    [Num] float NULL DEFAULT ((0)),
    [Classe] nvarchar(20) NULL,
    [Modêlo] nvarchar(15) NULL,
    [Descrição] nvarchar(200) NULL,
    [Oficial] bit NULL DEFAULT ((0)),
    [Família] nvarchar(12) NULL DEFAULT (NULL),
    [Quant] tinyint NULL DEFAULT ((0)),
    [Origem] nvarchar(10) NULL DEFAULT (NULL),
    [DataIn] datetime2(0) NULL,
    [Custo] money NULL DEFAULT ((0)),
    [Dólar] real NULL DEFAULT ((0)),
    [Posição] nvarchar(7) NULL,
    [Vendida] bit NULL DEFAULT ((0)),
    [DataVenda] datetime2(0) NULL,
    [Tipo] nvarchar(7) NULL,
    [Vendedora] nvarchar(20) NULL,
    [Valor] money NULL DEFAULT ((0)),
    [Comissão] money NULL DEFAULT ((0)),
    [Com2] money NULL DEFAULT ((0)),
    [Real] money NULL DEFAULT ((0)),
    [DólarVenda] real NULL DEFAULT ((0)),
    [Cheque] money NULL DEFAULT ((0)),
    [Pré] money NULL DEFAULT ((0)),
    [PosiçãoPré] datetime2(0) NULL,
    [Cartão] money NULL DEFAULT ((0)),
    [ContaCorrente] money NULL DEFAULT ((0)),
    [Desconto] money NULL DEFAULT ((0)),
    [A Receber] bit NULL DEFAULT ((0)),
    [Pré-2] money NULL DEFAULT ((0)),
    [PosPré2] datetime2(0) NULL,
    [Pré-3] money NULL DEFAULT ((0)),
    [PosPré3] datetime2(0) NULL,
    [Conserto] money NULL DEFAULT ((0)),
    [PC] nvarchar(5) NULL,
    [PCQtde] float NULL DEFAULT ((0)),
    [Espécie] nvarchar(30) NULL,
    [MOExt] float NULL DEFAULT ((0)),
    [MOInt] float NULL DEFAULT ((0)),
    [Custo2] float NULL DEFAULT ((0)),
    [Oficina] float NULL DEFAULT ((0)),
    [DataReg] date NULL,
    [Desenho] nvarchar(50) NULL,
    [Madeira] float NULL DEFAULT ((0)),
    [Couro] float NULL DEFAULT ((0)),
    [Cravação] float NULL DEFAULT ((0)),
    [Outras] float NULL DEFAULT ((0)),
    [Obs] nvarchar(250) NULL,
    [SSMA_TimeStamp] timestamp NOT NULL,
    [DataFabric] date NULL,
    [PrVenda] money NULL,
    [CustoAnt] money NULL,
    [PrVendaAnt] money NULL,
    [Excluir] bit NULL,
    [Volta] bit NULL,
    [IdPeçaOrigem] int NULL,
    [Saida] bit NULL,
    [Foto] image NULL,
    [SizeMode] int NULL,
    [vFund] money NULL,
    [pFund] float NULL,
    [Local] nchar(3) NULL,
    CONSTRAINT [PK_1TabPeças] PRIMARY KEY ([IDPeça])
);
GO

CREATE TABLE dbo.[CONSERTOS] (
    [ID] int IDENTITY(1, 1) NOT NULL,
    [CLIENTE] int NULL DEFAULT ((0)),
    [DT] datetime2(0) NULL,
    [VVALOR] float NULL DEFAULT ((0)),
    [FORMA] int NULL DEFAULT ((0)),
    [COMISSÃO] float NULL DEFAULT ((0)),
    [VENDEDORA] int NULL DEFAULT ((0)),
    [SEMCADASTRO] nvarchar(80) NULL,
    [OBS] nvarchar(250) NULL,
    [Real] float NULL DEFAULT ((0)),
    [Ouro] float NULL DEFAULT ((0)),
    [Dolar] real NULL DEFAULT ((0)),
    [Cartão] float NULL DEFAULT ((0)),
    [Cheque] float NULL DEFAULT ((0)),
    [FormaCheque] nvarchar(15) NULL,
    [FormaCartão] nvarchar(15) NULL,
    [ChequeCC] bit NULL DEFAULT ((0)),
    [CartãoCC] bit NULL DEFAULT ((0)),
    [DolarCC] bit NULL DEFAULT ((0)),
    [CashCC] bit NULL DEFAULT ((0)),
    [OuroCC] bit NULL DEFAULT ((0)),
    [Banco] nvarchar(50) NULL,
    [NomeCartão] nvarchar(15) NULL,
    [CCDeb] float NULL DEFAULT ((0)),
    [ValorFinal] float NULL DEFAULT ((0)),
    [SSMA_TimeStamp] timestamp NOT NULL,
    [Custo] float NULL DEFAULT ((0)),
    [Debito] float NULL,
    [NomeCartãoDébito] nvarchar(15) NULL,
    [ValorTransfC] money NULL,
    [BancoTransfC] nvarchar(50) NULL,
    [Saldo] money NULL,
    [Aut] nvarchar(10) NULL,
    [AutDeb] nvarchar(10) NULL,
    CONSTRAINT [PK_CONSERTOS] PRIMARY KEY ([ID])
);
GO

CREATE TABLE dbo.[Conta Corrente] (
    [ID] int IDENTITY(1, 1) NOT NULL,
    [Cliente] int NULL DEFAULT ((0)),
    [Data] datetime2(0) NULL,
    [Valor] real NULL DEFAULT ((0)),
    [Venda] nvarchar(15) NULL,
    [NCartão] nvarchar(15) NULL,
    [Vencto] datetime2(0) NULL,
    [Conserto] int NULL DEFAULT ((0)),
    [Parcela] nvarchar(10) NULL,
    [IdConserto] int NULL DEFAULT ((0)),
    [Real] float NULL DEFAULT ((0)),
    [Ouro] float NULL DEFAULT ((0)),
    [Dolar] real NULL DEFAULT ((0)),
    [Cartão] float NULL DEFAULT ((0)),
    [Cheque] float NULL DEFAULT ((0)),
    [FormaCheque] nvarchar(15) NULL,
    [FormaCartão] nvarchar(15) NULL,
    [ChequeCC] bit NULL DEFAULT ((0)),
    [CartãoCC] bit NULL DEFAULT ((0)),
    [DolarCC] bit NULL DEFAULT ((0)),
    [CashCC] bit NULL DEFAULT ((0)),
    [OuroCC] bit NULL DEFAULT ((0)),
    [Banco] nvarchar(50) NULL,
    [NomeCartão] nvarchar(15) NULL,
    [CCDeb] float NULL DEFAULT ((0)),
    [ValorFinal] float NULL DEFAULT ((0)),
    [SSMA_TimeStamp] timestamp NOT NULL,
    [ValorTransf] money NULL,
    [BancoTransf] nvarchar(50) NULL,
    [Obs] nvarchar(250) NULL,
    [Saldo] money NULL,
    [Aut] nvarchar(10) NULL,
    [AutDeb] nvarchar(10) NULL,
    CONSTRAINT [PK_Conta_Corrente] PRIMARY KEY ([ID])
);
GO

CREATE VIEW [dbo].[CC]
AS
SELECT        CONSERTOS.ID, CONSERTOS.CLIENTE, CONSERTOS.DT AS Data, CONSERTOS.Cartão AS VValor, 'Cartão' AS Tp, 'Conserto' AS Op, 1 AS Ident, 'x' AS obs
FROM            CONSERTOS
WHERE        (((CONSERTOS.CartãoCC) = 1))
UNION ALL
SELECT        CONSERTOS.ID, CONSERTOS.CLIENTE, CONSERTOS.DT AS Data, CONSERTOS.Real AS VValor, 'Cash' AS Tp, 'Conserto' AS Op, 2 AS Ident, 'x' AS obs
FROM            CONSERTOS
WHERE        (((CONSERTOS.CashCC) = 1))
UNION ALL
SELECT        CONSERTOS.ID, CONSERTOS.CLIENTE, CONSERTOS.DT AS Data, CONSERTOS.Cheque AS VValor, 'Cheque' AS Tp, 'Conserto' AS Op, 3 AS Ident, 'x' AS obs
FROM            CONSERTOS
WHERE        (((CONSERTOS.ChequeCC) = 1))
UNION ALL
SELECT        CONSERTOS.ID, CONSERTOS.CLIENTE, CONSERTOS.Dt AS Data, Abs([CCDeb]) * - 1 AS VValor, 'Débito' AS Tp, 'Conserto' AS Op, 4 AS Ident, 'x' AS obs
FROM            CONSERTOS
WHERE        (((Abs([CCDeb]) * - 1) < 0))
UNION ALL
SELECT        CONSERTOS.ID, CONSERTOS.CLIENTE, CONSERTOS.DT AS Data, CONSERTOS.Dolar AS VValor, 'Dólar' AS Tp, 'Conserto' AS Op, 5 AS Ident, 'x' AS obs
FROM            CONSERTOS
WHERE        (((CONSERTOS.DolarCC) = 1))
UNION ALL
SELECT        CONSERTOS.ID, CONSERTOS.CLIENTE, CONSERTOS.DT AS Data, CONSERTOS.Ouro AS VValor, 'Ouro' AS Tp, 'Conserto' AS Op, 6 AS Ident, 'x' AS obs
FROM            CONSERTOS
WHERE        (((CONSERTOS.OuroCC) = 1))
UNION ALL
SELECT        VENDAS.ID, VENDAS.IdCliente AS CLIENTE, VENDAS.DataVenda AS Data, VENDAS.Cartão AS VValor, 'Cartão' AS Tp, 'Venda' AS Op, 7 AS Ident, 'x' AS obs
FROM            VENDAS
WHERE        (((VENDAS.CartãoCC) = 1))
UNION ALL
SELECT        VENDAS.ID, VENDAS.IdCliente AS CLIENTE, VENDAS.DataVenda AS Data, VENDAS.Real AS VValor, 'Cash' AS Tp, 'Venda' AS Op, 8 AS Ident, 'x' AS obs
FROM            VENDAS
WHERE        (((VENDAS.CashCC) = 1))
UNION ALL
SELECT        VENDAS.ID, VENDAS.IdCliente AS CLIENTE, VENDAS.DataVenda AS Data, VENDAS.Cheque AS VValor, 'Cheque' AS Tp, 'Venda' AS Op, 9 AS Ident, 'x' AS obs
FROM            VENDAS
WHERE        (((VENDAS.ChequeCC) = 1))
UNION ALL
SELECT        VENDAS.ID, VENDAS.IDCliente AS CLIENTE, VENDAS.DataVenda AS Data, Abs([CCDeb]) * - 1 AS VValor, 'Débito' AS Tp, 'Venda' AS Op, 10 AS Ident, 'x' AS obs
FROM            VENDAS
WHERE        (((Abs([CCDeb]) * - 1) < 0))
UNION ALL
SELECT        VENDAS.ID, VENDAS.IdCliente AS CLIENTE, VENDAS.DataVenda AS Data, case when DolarCC = 1 Then (VENDAS.Dolar * -1) else VENDAS.Dolar end AS VValor, 'Dólar' AS Tp, 'Venda' AS Op, 11 AS Ident, 'x' AS obs
FROM            VENDAS
WHERE        (((VENDAS.DolarCC) = 1))
UNION ALL
SELECT        VENDAS.ID, VENDAS.IdCliente AS CLIENTE, VENDAS.DataVenda AS Data, VENDAS.Ouro AS VValor, 'Ouro' AS Tp, 'Venda' AS Op, 12 AS Ident, 'x' AS obs
FROM            VENDAS
WHERE        (((VENDAS.OuroCC) = 1))
UNION ALL
SELECT        [Conta Corrente].ID, [Conta Corrente].CLIENTE, [Conta Corrente].Data, [Conta Corrente].Cartão AS VValor, 'Cartão' AS Tp, 'C/C' AS Op, 13 AS Ident, 'x' AS obs
FROM            [Conta Corrente]
WHERE        ((([Conta Corrente].Cartão) > 0) AND (([Conta Corrente].CartãoCC) = 1) AND (([Conta Corrente].Venda) IS NULL) AND (([Conta Corrente].IdConserto) = 0 OR
                         ([Conta Corrente].IdConserto) IS NULL))
UNION ALL
SELECT        [Conta Corrente].ID, [Conta Corrente].CLIENTE, [Conta Corrente].Data, [Conta Corrente].Real AS VValor, 'Cash' AS Tp, 'C/C' AS Op, 14 AS Ident, Obs
FROM            [Conta Corrente]
WHERE        ((([Conta Corrente].Real) <> 0) AND (([Conta Corrente].CashCC) = 1) AND (([Conta Corrente].Venda) IS NULL) AND (([Conta Corrente].IdConserto) = 0 OR
                         ([Conta Corrente].IdConserto) IS NULL))
UNION ALL
SELECT        [Conta Corrente].ID, [Conta Corrente].CLIENTE, [Conta Corrente].Data, [Conta Corrente].Cheque AS VValor, 'Cheque' AS Tp, 'C/C' AS Op, 15 AS Ident, Obs
FROM            [Conta Corrente]
WHERE        ((([Conta Corrente].Cheque) > 0) AND (([Conta Corrente].ChequeCC) = 1) AND (([Conta Corrente].Venda) IS NULL) AND (([Conta Corrente].IdConserto) = 0 OR
                         ([Conta Corrente].IdConserto) IS NULL))
UNION ALL
SELECT        [Conta Corrente].ID, [Conta Corrente].CLIENTE, [Conta Corrente].Data, Abs([CCDeb]) * - 1 AS VValor, 'Débito' AS Tp, 'C/C' AS Op, 16 AS Ident, Obs
FROM            [Conta Corrente]
WHERE        (((Abs([CCDeb]) * - 1) < 0) AND (([Conta Corrente].Venda) IS NULL) AND (([Conta Corrente].IdConserto) = 0 OR
                         ([Conta Corrente].IdConserto) IS NULL))
UNION ALL
SELECT        [Conta Corrente].ID, [Conta Corrente].CLIENTE, [Conta Corrente].Data, [Conta Corrente].Dolar AS VValor, 'Dólar' AS Tp, 'C/C' AS Op, 17 AS Ident, Obs
FROM            [Conta Corrente]
WHERE        ((([Conta Corrente].Dolar) > 0) AND (([Conta Corrente].DolarCC) = 1) AND (([Conta Corrente].Venda) IS NULL) AND (([Conta Corrente].IdConserto) = 0 OR
                         ([Conta Corrente].IdConserto) IS NULL))
UNION ALL
SELECT        [Conta Corrente].ID, [Conta Corrente].CLIENTE, [Conta Corrente].Data, [Conta Corrente].Ouro AS VValor, 'Ouro' AS Tp, 'C/C' AS Op, 18 AS Ident, Obs
FROM            [Conta Corrente]
WHERE        ((([Conta Corrente].Ouro) > 0) AND (([Conta Corrente].OuroCC) = 1) AND (([Conta Corrente].Venda) IS NULL) AND (([Conta Corrente].IdConserto) = 0 OR
                         ([Conta Corrente].IdConserto) IS NULL))
UNION ALL
SELECT        ID, Cliente, Data, ValorTransf AS VValor, 'Transf.' AS Tp, 'C/C' AS Op, 19 AS Ident, Obs
FROM            [Conta Corrente]
WHERE        (Venda IS NULL) AND (IdConserto = 0 OR
                         IdConserto IS NULL) AND (ValorTransf > 0)
GO
