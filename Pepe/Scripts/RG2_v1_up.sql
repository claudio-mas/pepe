/* ============================================================================
   RG2_v1_up.sql  --  Relatorio Gerencial Novo, Fase 1
   ----------------------------------------------------------------------------
   ADITIVO. Nao altera e nao remove nenhum objeto existente.
   Cria:
     - coluna dbo.Cotacao.ValPrata (money NULL)
     - dbo.VW_RG2_VENDAS_ITENS
     - dbo.VW_RG2_PECAS_VENDIDAS
     - dbo.VW_RG2_PECAS_REG
     - dbo.VW_RG2_ESTOQUE

   Prefixo VW_RG2_ deliberadamente diferente de VI_ (views antigas) e USP_
   (procs antigas), para ficar obvio no SSMS o que pertence ao relatorio novo.

   RODAR PRIMEIRO NUMA COPIA DE BDTorras. Rollback: RG2_v1_down.sql
   ============================================================================ */

USE BDTorras;
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO


/* ---------------------------------------------------------------------------
   1. Cotacao da prata
   ---------------------------------------------------------------------------
   NULLable de proposito: frmCota.vb e o CotacaoTableAdapter de dsMatPrima fazem
   INSERT com lista explicita de colunas, entao continuam validos sem alteracao.
   Semantica: R$ por grama de prata 925, ja no valor final (sem fator de teor) --
   e como a planilha usa a celula, em "=145*I6".
   --------------------------------------------------------------------------- */
IF COL_LENGTH('dbo.Cotação', 'ValPrata') IS NULL
BEGIN
    ALTER TABLE dbo.[Cotação] ADD ValPrata money NULL;
    PRINT 'Cotacao.ValPrata criada.';
END
ELSE
    PRINT 'Cotacao.ValPrata ja existe -- nada a fazer.';
GO

-- Opcional: sem backfill, todo periodo cujo registro de cotacao seja anterior a
-- esta migracao mostra a prata zerada. Descomente e ajuste o valor se quiser
-- que o historico exiba algo.
-- UPDATE dbo.[Cotação] SET ValPrata = 18.00 WHERE ValPrata IS NULL;
-- GO


/* ---------------------------------------------------------------------------
   2. VW_RG2_VENDAS_ITENS  --  item de venda com canal, familia e valor rateado
   ---------------------------------------------------------------------------
   Canal:  ENC  = encomenda  (1TabPecas.Oficial = 1) -- e o "W" do relatorio antigo
           LOJA = o complemento
   Familia: Ou / Ag / Bou (qualquer coisa fora de Ou e Ag cai em Bou)

   ValorItemLiquido rateia VENDAS.ValorFinal (que ja tem desconto aplicado) pelos
   itens, proporcionalmente ao ValorVenda bruto de cada um. Assim
   SUM(ValorItemLiquido) = SUM(VENDAS.ValorFinal) das vendas que tem itens, e a
   quebra por metal fecha com o total.

   ATENCAO: vendas SEM linha em [VENDAS DET] nao aparecem aqui. Medir com o
   BLOCO 4 de RG2_v0_investigacao.sql antes de confiar no total.

   A view NAO filtra data (mesma convencao das VI_*); quem filtra e o consumidor.
   --------------------------------------------------------------------------- */
IF OBJECT_ID('dbo.VW_RG2_VENDAS_ITENS', 'V') IS NOT NULL
    DROP VIEW dbo.VW_RG2_VENDAS_ITENS;
GO

CREATE VIEW dbo.VW_RG2_VENDAS_ITENS
AS
SELECT
    v.Id                                        AS IdVenda,
    v.DataVenda                                 AS DataVenda,
    d.Id                                        AS IdItem,
    d.[Peça]                                    AS IdPeca,
    ISNULL(p.Oficial, 0)                        AS Oficial,
    CASE WHEN ISNULL(p.Oficial, 0) = 1
         THEN 'ENC' ELSE 'LOJA' END             AS Canal,
    CASE WHEN p.[Família] IN ('Ou', 'Ag')
         THEN p.[Família] ELSE 'Bou' END        AS Familia,
    CAST(ISNULL(d.ValorVenda, 0) AS float)      AS ValorItemBruto,
    CAST(ISNULL(v.ValorFinal, 0) AS float)      AS ValorVendaFinal,
    CAST(SUM(ISNULL(d.ValorVenda, 0)) OVER (PARTITION BY v.Id) AS float)
                                                AS ValorVendaBruto,
    CAST(CASE
            WHEN SUM(ISNULL(d.ValorVenda, 0)) OVER (PARTITION BY v.Id) = 0 THEN 0
            ELSE ISNULL(d.ValorVenda, 0) * ISNULL(v.ValorFinal, 0)
                 / SUM(ISNULL(d.ValorVenda, 0)) OVER (PARTITION BY v.Id)
         END AS float)                          AS ValorItemLiquido
FROM       dbo.VENDAS        v
INNER JOIN dbo.[VENDAS DET]  d ON d.Venda    = v.Id
INNER JOIN dbo.[1TabPeças]   p ON p.[IDPeça] = d.[Peça];
GO


/* ---------------------------------------------------------------------------
   3. VW_RG2_PECAS_VENDIDAS  --  secao 6 do relatorio
   ---------------------------------------------------------------------------
   OuroV / PrataV sao QUANTIDADES (metal de volta), nao valores -- confirmado em
   frmEstoque.vb:493-501, onde entram subtraindo de TotalQtde. Peso liquido,
   portanto, e Qtde - V.

   Outras e DERIVADO (Custo - ValorMetal - MO) e nao a coluna crua 1TabPecas.Outras,
   porque Custo = TotalValor + MOExt + MOInt + Cravacao + pedras + Oficina +
   Madeira + Couro + Outras (frmEstoque.vb:504-526): a coluna crua e so uma das
   parcelas, a derivada e o resto todo.
   DIVERGENCIA CONSCIENTE: VI_PECAS_VENDAS.Outras (usada pelo relatorio antigo) e a
   coluna crua, entao la "Custo <> Metal + MO + Outros". Aqui fecha por construcao.

   NAO se usa VI_METAIS/VI_METAIS_VENDAS aqui, e de proposito: naquelas views,
       CASE WHEN Familia = 'Ou' THEN TotalValor ELSE OuroV END AS OV
   devolve REAIS para peca de ouro e GRAMAS para as demais, na mesma coluna.
   Estas views leem METAIS direto, onde a unidade de cada coluna e sempre a mesma.
   --------------------------------------------------------------------------- */
IF OBJECT_ID('dbo.VW_RG2_PECAS_VENDIDAS', 'V') IS NOT NULL
    DROP VIEW dbo.VW_RG2_PECAS_VENDIDAS;
GO

CREATE VIEW dbo.VW_RG2_PECAS_VENDIDAS
AS
SELECT
    p.[IDPeça]                                          AS IdPeca,
    d.Id                                                AS IdItem,
    v.DataVenda                                         AS DataVenda,
    CASE WHEN p.[Família] IN ('Ou', 'Ag')
         THEN p.[Família] ELSE 'Bou' END                AS Familia,
    CAST(ISNULL(p.Custo, 0) AS float)                   AS Custo,
    CAST(ISNULL(m.OuroQtde, 0)  - ISNULL(m.OuroV, 0)  AS float)  AS GramasOuro,
    CAST(ISNULL(m.PrataQtde, 0) - ISNULL(m.PrataV, 0) AS float)  AS GramasPrata,
    CAST(ISNULL(m.TotalValor, 0) AS float)              AS ValorMetal,
    CAST(ISNULL(p.MOExt, 0) + ISNULL(p.MOInt, 0) AS float)       AS MO,
    CAST(ISNULL(p.Custo, 0)
         - ISNULL(m.TotalValor, 0)
         - (ISNULL(p.MOExt, 0) + ISNULL(p.MOInt, 0)) AS float)   AS Outras,
    CAST(ISNULL(d.ValorVenda, 0) AS float)              AS PrecoVenda
FROM       dbo.[1TabPeças]   p
INNER JOIN dbo.[VENDAS DET]  d ON d.[Peça] = p.[IDPeça]
INNER JOIN dbo.VENDAS        v ON v.Id     = d.Venda
LEFT  JOIN dbo.METAIS        m ON m.Id     = p.[IDPeça];
GO


/* ---------------------------------------------------------------------------
   4. VW_RG2_PECAS_REG  --  secao 7 do relatorio
   ---------------------------------------------------------------------------
   ISNULL(Origem, 'F.F.'): o relatorio antigo usa LINQ "Origem <> 'F.P.'", que em
   SQL de tres valores EXCLUI as linhas com Origem NULL. Aqui elas entram em F.F.
   Isso e uma correcao intencional e pode fazer o F.F. novo ficar MAIOR que o
   antigo -- medir com o BLOCO 3 de RG2_v0_investigacao.sql.
   --------------------------------------------------------------------------- */
IF OBJECT_ID('dbo.VW_RG2_PECAS_REG', 'V') IS NOT NULL
    DROP VIEW dbo.VW_RG2_PECAS_REG;
GO

CREATE VIEW dbo.VW_RG2_PECAS_REG
AS
SELECT
    p.[IDPeça]                                          AS IdPeca,
    p.DataReg                                           AS DataReg,
    ISNULL(NULLIF(LTRIM(RTRIM(p.Origem)), ''), 'F.F.')  AS Origem,
    CASE WHEN p.[Família] IN ('Ou', 'Ag')
         THEN p.[Família] ELSE 'Bou' END                AS Familia,
    CAST(ISNULL(p.Custo, 0) AS float)                   AS Custo,
    CAST(ISNULL(m.OuroQtde, 0)  - ISNULL(m.OuroV, 0)  AS float)  AS GramasOuro,
    CAST(ISNULL(m.PrataQtde, 0) - ISNULL(m.PrataV, 0) AS float)  AS GramasPrata,
    CAST(ISNULL(m.TotalValor, 0) AS float)              AS ValorMetal,
    CAST(ISNULL(p.MOExt, 0) + ISNULL(p.MOInt, 0) AS float)       AS MO
FROM      dbo.[1TabPeças] p
LEFT JOIN dbo.METAIS      m ON m.Id = p.[IDPeça];
GO


/* ---------------------------------------------------------------------------
   5. VW_RG2_ESTOQUE  --  secao 10 do relatorio
   ---------------------------------------------------------------------------
   Reproduz o WHERE canonico de Pepe\Resources\EmEstoque.txt para que o TOTAL bata
   com o do relatorio antigo, mas quebrado por Familia e incluindo prata.

   O SQL original e uma traducao de Access com RIGHT OUTER JOIN encadeado; esta
   reescrita e semanticamente equivalente MAS PRECISA SER VALIDADA:
       SELECT COUNT(*) FROM dbo.VW_RG2_ESTOQUE;
   tem que dar o mesmo numero que o "Qtd" do BLOCO 7 de RG2_v0_investigacao.sql.
   Se divergir, trocar o corpo pela query original usada como subquery.

   Nao filtra data: e posicao de HOJE. Mesma limitacao do relatorio antigo.
   --------------------------------------------------------------------------- */
IF OBJECT_ID('dbo.VW_RG2_ESTOQUE', 'V') IS NOT NULL
    DROP VIEW dbo.VW_RG2_ESTOQUE;
GO

CREATE VIEW dbo.VW_RG2_ESTOQUE
AS
SELECT
    p.[IDPeça]                                          AS IdPeca,
    CASE WHEN p.[Família] IN ('Ou', 'Ag')
         THEN p.[Família] ELSE 'Bou' END                AS Familia,
    CAST(ISNULL(p.Custo, 0)   AS float)                 AS Custo,
    CAST(ISNULL(p.PrVenda, 0) AS float)                 AS PrVenda,
    CAST(ISNULL(m.OuroQtde, 0)  - ISNULL(m.OuroV, 0)  AS float)  AS GramasOuro,
    CAST(ISNULL(m.PrataQtde, 0) - ISNULL(m.PrataV, 0) AS float)  AS GramasPrata
FROM       dbo.[1TabPeças]   p
LEFT  JOIN dbo.METAIS        m ON m.Id       = p.[IDPeça]
LEFT  JOIN dbo.[VENDAS DET]  d ON d.[Peça]   = p.[IDPeça]
LEFT  JOIN dbo.VENDAS        v ON v.Id       = d.Venda
WHERE  v.DataVenda IS NULL
  AND  (p.Vendida = 0 OR p.Vendida IS NULL)
  AND  p.[Modêlo] IS NOT NULL
  AND  ISNULL(p.Saida, 0) = 0;
-- O INNER JOIN dbo.PEENBase do EmEstoque.txt foi OMITIDO de proposito.
-- PEENBase e "SELECT ... FROM PEDRAS RIGHT JOIN [1TabPecas] WHERE Modelo IS NOT NULL",
-- ou seja: todas as pecas com Modelo preenchido, com ou sem pedras. Esse filtro ja
-- esta explicito no WHERE acima, entao o join so acrescenta risco -- se PEDRAS tiver
-- mais de uma linha por peca, ele DUPLICA a peca no total.
-- Se o COUNT desta view divergir do Qtd do relatorio antigo, a causa mais provavel e
-- exatamente essa duplicacao, e quem esta inflado e o antigo. Conferir com:
--     SELECT COUNT(*) FROM dbo.PEDRAS;
--     SELECT COUNT(DISTINCT Id) FROM dbo.PEDRAS;
GO


/* ---------------------------------------------------------------------------
   6. Validacao pos-migracao -- rodar e conferir
   --------------------------------------------------------------------------- */
PRINT '=== VALIDACAO ===';

-- (a) Estoque novo tem que bater com o Qtd do relatorio antigo
SELECT 'VW_RG2_ESTOQUE' AS View_, COUNT(*) AS Qtd FROM dbo.VW_RG2_ESTOQUE;

-- (b) O rateio tem que fechar com ValorFinal
DECLARE @dt1 date = '2026-07-01', @dt2 date = '2026-07-28';   -- limite superior exclusivo

SELECT 'Rateado'   AS Metrica, ISNULL(SUM(ValorItemLiquido), 0) AS Valor
FROM   dbo.VW_RG2_VENDAS_ITENS
WHERE  DataVenda >= @dt1 AND DataVenda < @dt2
UNION ALL
SELECT 'ValorFinal', ISNULL(SUM(v.ValorFinal), 0)
FROM   dbo.VENDAS v
WHERE  v.DataVenda >= @dt1 AND v.DataVenda < @dt2
  AND  EXISTS (SELECT 1 FROM dbo.[VENDAS DET] d WHERE d.Venda = v.Id);

-- (c) As quatro views respondem
SELECT 'VW_RG2_VENDAS_ITENS'   AS View_, COUNT(*) AS Linhas FROM dbo.VW_RG2_VENDAS_ITENS
UNION ALL SELECT 'VW_RG2_PECAS_VENDIDAS', COUNT(*) FROM dbo.VW_RG2_PECAS_VENDIDAS
UNION ALL SELECT 'VW_RG2_PECAS_REG',      COUNT(*) FROM dbo.VW_RG2_PECAS_REG
UNION ALL SELECT 'VW_RG2_ESTOQUE',        COUNT(*) FROM dbo.VW_RG2_ESTOQUE;
GO
