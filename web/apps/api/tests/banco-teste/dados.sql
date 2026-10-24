/* ============================================================================
   dados.sql  --  Dados INVENTADOS do banco de teste (BDTorrasTeste)
   ----------------------------------------------------------------------------
   Nenhum dado real (constituicao V.3). Cobre os casos de
   specs/001-consulta-clientes/quickstart.md secao 1. Os IDs sao fixos para os
   testes poderem citar os casos pelo numero.

   Clientes:
      1  Jose Araujo (com acento no banco): cadastro completo, CPF, marco/2026
      2  so nome de mala direta (Nome nulo)
      3  sem Nome e sem mala direta: nunca aparece (RN-CLI-001)
      4  oculto (Oculto = 1), cadastrado em marco/2026
      5  Oculto nulo: conta como visivel
      6, 7  homonimos ("Ana Souza")
      8  tres pecas compradas em duas vendas
      9  sem compras
     10  lancamentos de CC das tres origens (venda, conserto e C/C)
    101..215  enchimento para a paginacao (115 clientes); cada 5o cadastrado
              em abril/2026
   Orfaos (cliente inexistente): venda 3 (cliente 9999), conserto 2 (9998),
   lancamento de C/C 2 (9997).
   ============================================================================ */

SET NOCOUNT ON;
SET QUOTED_IDENTIFIER ON;
GO
USE BDTorrasTeste;
GO

SET IDENTITY_INSERT dbo.Clientes ON;
INSERT dbo.Clientes (IDCliente, [Título], Nome, Cliente, [Endereço], Bairro, Cidade, Estado, CEP, Telefone,
                     Email, CPF, Aniv, Medidas, [Indicaçao], Oculto, Imp, DataCad)
VALUES
 (1,  N'Sr.',  N'José Araújo',         N'Sr. José Araújo',  N'Rua das Acácias, 10', N'Jardim',  N'São Paulo', N'SP',
      N'01001-000', N'(11) 98888-0001', N'jose@exemplo.test', N'12345678909', '1980-05-17', N'Aro 22', N'Maria', 0, 0, '2026-03-10'),
 (2,  NULL,    NULL,                   N'Sra. Beatriz Lima', N'Av. Central, 200',   N'Centro',  N'Campinas',  N'SP',
      N'13010-000', N'(19) 97777-0002', NULL, NULL, NULL, NULL, NULL, 0, 0, NULL),
 (3,  NULL,    NULL,                   NULL,                N'Rua Sem Nome, 1',    NULL, NULL, NULL, NULL, N'(11) 90000-0003',
      NULL, NULL, NULL, NULL, NULL, 0, 0, NULL),
 (4,  N'Sr.',  N'Carlos Oculto',       NULL,                N'Rua Escondida, 4',   N'Vila',    N'Santos',    N'SP',
      NULL, N'(13) 96666-0004', NULL, NULL, NULL, NULL, NULL, 1, 0, '2026-03-15'),
 (5,  N'Sra.', N'Daniela Nula',        NULL,                NULL, NULL, NULL, NULL, NULL, N'(11) 95555-0005',
      NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
 (6,  N'Sra.', N'Ana Souza',           NULL,                N'Rua Um, 6',          N'Bela Vista', N'São Paulo', N'SP',
      NULL, N'(11) 94444-0006', NULL, NULL, '1990-01-06', NULL, NULL, 0, 0, NULL),
 (7,  N'Sra.', N'Ana Souza',           NULL,                N'Rua Sete, 7',        N'Moema',   N'São Paulo', N'SP',
      NULL, N'(11) 93333-0007', NULL, NULL, '1975-07-07', NULL, NULL, 0, 0, NULL),
 (8,  N'Sr.',  N'Eduardo Compras',     NULL,                N'Rua Oito, 8',        N'Centro',  N'São Paulo', N'SP',
      NULL, N'(11) 92222-0008', NULL, NULL, NULL, NULL, NULL, 0, 0, NULL),
 (9,  N'Sra.', N'Fernanda Sem Compras', NULL,               N'Rua Nove, 9',        N'Centro',  N'São Paulo', N'SP',
      NULL, N'(11) 91111-0009', NULL, NULL, NULL, NULL, NULL, 0, 0, NULL),
 (10, N'Sr.',  N'Gabriel Conta',       NULL,                N'Rua Dez, 10',        N'Centro',  N'São Paulo', N'SP',
      NULL, N'(11) 90000-0010', NULL, NULL, NULL, NULL, NULL, 0, 0, NULL);

-- Enchimento para a paginacao: 115 clientes; cada 5o cadastrado em abril/2026
DECLARE @i int = 101;
WHILE @i <= 215
BEGIN
    INSERT dbo.Clientes (IDCliente, Nome, Telefone, Oculto, Imp, DataCad)
    VALUES (@i, N'Cliente Teste ' + RIGHT(N'000' + CAST(@i AS nvarchar(3)), 3),
            N'(11) 5000-' + RIGHT(N'0000' + CAST(@i AS nvarchar(4)), 4), 0, 0,
            CASE WHEN @i % 5 = 0 THEN DATEFROMPARTS(2026, 4, 1 + @i % 28) END);
    SET @i += 1;
END
SET IDENTITY_INSERT dbo.Clientes OFF;
GO

-- Pecas (so as colunas lidas pela entrega)
SET IDENTITY_INSERT dbo.[1TabPeças] ON;
INSERT dbo.[1TabPeças] ([IDPeça], Classe, [Modêlo], [Descrição], Obs, Vendida)
VALUES
 (1, N'AN',  N'1001', N'Anel solitário em ouro 18k',   N'Aro 22', 1),
 (2, N'BR',  N'2002', N'Brinco argola em prata',       NULL,      1),
 (3, N'PEN', N'3003', N'Pingente gota com ametista',   N'Corrente 45 cm', 1),
 (4, N'PUL', N'4004', N'Pulseira riviera',             NULL,      1);
SET IDENTITY_INSERT dbo.[1TabPeças] OFF;
GO

-- Vendas: 1 e 2 do cliente 8 (pecas compradas), 3 orfa, 4 e 5 do cliente 10 (CC)
SET IDENTITY_INSERT dbo.VENDAS ON;
INSERT dbo.VENDAS (Id, Venda, IDCliente, DataVenda, Tipo, Vendedora, ValorFinal, [CartãoCC], [Cartão], CCDeb,
                   CashCC, ChequeCC, DolarCC, OuroCC)
VALUES
 (1, N'0001/26', 8,    '2026-01-10', N'Interna', N'Loja', 1500, 0, NULL, NULL, 0, 0, 0, 0),
 (2, N'0002/26', 8,    '2026-02-20', N'Interna', N'Loja', 900,  0, NULL, NULL, 0, 0, 0, 0),
 (3, N'0003/26', 9999, '2026-02-21', N'Interna', N'Loja', 700,  0, NULL, NULL, 0, 0, 0, 0),
 (4, N'0004/26', 10,   '2026-02-01', N'Interna', N'Loja', 500,  1, 500,  NULL, 0, 0, 0, 0),
 (5, N'0005/26', 10,   '2026-02-15', N'Interna', N'Loja', 200,  0, NULL, 200,  0, 0, 0, 0);
SET IDENTITY_INSERT dbo.VENDAS OFF;

SET IDENTITY_INSERT dbo.[VENDAS DET] ON;
INSERT dbo.[VENDAS DET] (Id, Venda, [Peça], ValorVenda)
VALUES (1, 1, 1, 1500), (2, 2, 2, 400), (3, 2, 3, 500), (4, 3, 4, 700);
SET IDENTITY_INSERT dbo.[VENDAS DET] OFF;
GO

-- Consertos: 1 do cliente 10 em CC (cash), 2 orfao
SET IDENTITY_INSERT dbo.CONSERTOS ON;
INSERT dbo.CONSERTOS (ID, CLIENTE, DT, VVALOR, Real, Cheque, CashCC, ChequeCC, [CartãoCC], DolarCC, OuroCC)
VALUES
 (1, 10,   '2026-01-05', 150, 150,  NULL, 1, 0, 0, 0, 0),
 (2, 9998, '2026-01-06', 80,  NULL, 80,   0, 1, 0, 0, 0);
SET IDENTITY_INSERT dbo.CONSERTOS OFF;
GO

-- Lancamentos de conta corrente: 1 do cliente 10 (cash), 2 orfao
SET IDENTITY_INSERT dbo.[Conta Corrente] ON;
INSERT dbo.[Conta Corrente] (ID, Cliente, Data, Real, CashCC, Venda, IdConserto, Obs)
VALUES
 (1, 10,   '2026-03-01', 300, 1, NULL, 0, N'Pagamento'),
 (2, 9997, '2026-03-02', 50,  1, NULL, 0, NULL);
SET IDENTITY_INSERT dbo.[Conta Corrente] OFF;
GO
