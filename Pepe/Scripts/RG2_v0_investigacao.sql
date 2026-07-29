/* ============================================================================
   RG2_v0_investigacao.sql  --  Relatorio Gerencial Novo, Fase 0
   ----------------------------------------------------------------------------
   SOMENTE LEITURA. Nao cria, nao altera e nao apaga nada.
   Rodar em BDTorras (SSMS) e guardar a saida de cada bloco.

   Objetivo: responder as perguntas A-1..A-7 do plano e medir os casos-limite
   que definem as regras de negocio D-1..D-6.
   ============================================================================ */

USE BDTorras;
GO

/* ---------------------------------------------------------------------------
   BLOCO 1 -- Definicao das views e procs existentes
   Responde: A-1 (VI_VENDAS.V), A-2 (OT/OV), A-3 (VI_PECAS.MO),
             A-4 (VI_PECAS_VENDAS.Outras), A-6 (PEENBase), A-7 (SP cartoes)

   >>> RODAR COM "Results to Text" (Ctrl+T) <<<
   sp_helptext devolve o codigo em linhas de ate 255 caracteres, preservando as
   quebras. Em modo Grid (Ctrl+D) o texto vem numa celula so, truncado e ilegivel
   -- que foi o que aconteceu na primeira tentativa.
   --------------------------------------------------------------------------- */
PRINT '=== BLOCO 1: definicoes ===';
GO

PRINT ''; PRINT '----- VI_VENDAS (A-1: de onde sai a coluna V) -----';
EXEC sp_helptext 'dbo.VI_VENDAS';
GO
PRINT ''; PRINT '----- VI_METAIS (A-2: OT e OV sao gramas ou reais?) -----';
EXEC sp_helptext 'dbo.VI_METAIS';
GO
PRINT ''; PRINT '----- VI_PECAS (A-3: MO inclui o que?) -----';
EXEC sp_helptext 'dbo.VI_PEÇAS';
GO
PRINT ''; PRINT '----- VI_PECAS_VENDAS (A-4: Outras ja e derivado?) -----';
EXEC sp_helptext 'dbo.VI_PEÇAS_VENDAS';
GO
PRINT ''; PRINT '----- VI_METAIS_VENDAS -----';
EXEC sp_helptext 'dbo.VI_METAIS_VENDAS';
GO
PRINT ''; PRINT '----- VI_VENDIDAS -----';
EXEC sp_helptext 'dbo.VI_VENDIDAS';
GO
PRINT ''; PRINT '----- PEENBase (A-6: qual o criterio?) -----';
EXEC sp_helptext 'dbo.PEENBase';
GO
PRINT ''; PRINT '----- VI_CONSERTOS -----';
EXEC sp_helptext 'dbo.VI_CONSERTOS';
GO
PRINT ''; PRINT '----- USP_Gerencial_Cartoes (A-7: retorna Percentual?) -----';
EXEC sp_helptext 'dbo.USP_Gerencial_Cartoes';
GO
PRINT ''; PRINT '----- USP_Gerencial_Consertos -----';
EXEC sp_helptext 'dbo.USP_Gerencial_Consertos';
GO

-- VI_W ja confirmado: SELECT VENDAS.Id, VENDAS.DataVenda, [VENDAS DET].ValorVenda
-- FROM [1TabPecas] JOIN [VENDAS DET] JOIN VENDAS WHERE [1TabPecas].Oficial = 1
-- ou seja: nivel de ITEM e criterio Oficial=1, igual ao Canal='ENC' de
-- VW_RG2_VENDAS_ITENS. Nao precisa rodar de novo.


/* ---------------------------------------------------------------------------
   BLOCO 2 -- Tipos das colunas de METAIS
   Responde: A-5 (TotalValor e dinheiro?)
   --------------------------------------------------------------------------- */
PRINT '=== BLOCO 2: colunas de METAIS ===';

SELECT  c.column_id, c.name AS Coluna, t.name AS Tipo,
        c.max_length, c.precision, c.scale, c.is_nullable
FROM    sys.columns c
JOIN    sys.types   t ON t.user_type_id = c.user_type_id
WHERE   c.object_id = OBJECT_ID(N'dbo.METAIS')
ORDER BY c.column_id;

-- Amostra para conferir a olho se TotalValor tem cara de dinheiro (R$)
-- e se OuroV/PrataV tem cara de gramas.
SELECT TOP (20)
        Id, OuroQtde, OuroV, PrataQtde, PrataV,
        PerdaQtde, SistemaQtde, TotalQtde,
        TotalValor, SistemaValor
FROM    dbo.METAIS
WHERE   ISNULL(OuroQtde,0) <> 0 OR ISNULL(PrataQtde,0) <> 0
ORDER BY Id DESC;
GO


/* ---------------------------------------------------------------------------
   BLOCO 3 -- Dominio de Familia e Origem em 1TabPecas
   Responde: D-2 (quantas pecas 'Bou'?), R-4, R-16
   --------------------------------------------------------------------------- */
PRINT '=== BLOCO 3: dominios Familia / Origem ===';

SELECT  ISNULL([Família], N'(NULL)') AS Familia, COUNT(*) AS Qtd
FROM    dbo.[1TabPeças]
GROUP BY [Família]
ORDER BY Qtd DESC;

SELECT  ISNULL(Origem, N'(NULL)') AS Origem, COUNT(*) AS Qtd
FROM    dbo.[1TabPeças]
GROUP BY Origem
ORDER BY Qtd DESC;

-- Cruzamento Origem x Familia: e o formato exato da secao 7 do relatorio novo
SELECT  ISNULL(Origem, N'(NULL)')    AS Origem,
        ISNULL([Família], N'(NULL)') AS Familia,
        COUNT(*)                     AS Qtd
FROM    dbo.[1TabPeças]
GROUP BY Origem, [Família]
ORDER BY Origem, Familia;
GO


/* ---------------------------------------------------------------------------
   BLOCO 4 -- Integridade dos joins usados pelas views novas
   Responde: R-8 (peca vendida 2x), R-9 (peca sem METAIS), R-1 (venda sem itens)
   --------------------------------------------------------------------------- */
PRINT '=== BLOCO 4: integridade dos joins ===';

-- R-9: pecas sem linha correspondente em METAIS
SELECT  COUNT(*) AS PecasSemMetais
FROM    dbo.[1TabPeças] p
LEFT JOIN dbo.METAIS    m ON m.Id = p.[IDPeça]
WHERE   m.Id IS NULL;

-- R-8: pecas com mais de uma linha em [VENDAS DET] (venda refeita/devolucao)
SELECT  COUNT(*) AS PecasVendidasMaisDeUmaVez
FROM    ( SELECT [Peça]
          FROM   dbo.[VENDAS DET]
          GROUP BY [Peça]
          HAVING COUNT(*) > 1 ) x;

-- R-1: vendas sem nenhum item em [VENDAS DET] (sumiriam da secao 3)
SELECT  COUNT(*) AS VendasSemItens
FROM    dbo.VENDAS v
WHERE   NOT EXISTS (SELECT 1 FROM dbo.[VENDAS DET] d WHERE d.Venda = v.Id);

-- Peso dessas vendas sem item, no periodo de referencia
SELECT  ISNULL(SUM(v.ValorFinal), 0) AS ValorVendasSemItens
FROM    dbo.VENDAS v
WHERE   NOT EXISTS (SELECT 1 FROM dbo.[VENDAS DET] d WHERE d.Venda = v.Id)
  AND   v.DataVenda >= '2026-07-01' AND v.DataVenda < '2026-07-28';
GO


/* ---------------------------------------------------------------------------
   BLOCO 5 -- Datas com componente de hora
   Responde: R-15 (usar <= dt2 ou < dt2+1?)
   --------------------------------------------------------------------------- */
PRINT '=== BLOCO 5: datas com hora ===';

SELECT  'VENDAS.DataVenda'  AS Campo,
        SUM(CASE WHEN CAST(DataVenda AS time) <> '00:00:00' THEN 1 ELSE 0 END) AS ComHora,
        COUNT(*) AS Total
FROM    dbo.VENDAS
UNION ALL
SELECT  '1TabPecas.DataReg',
        SUM(CASE WHEN CAST(DataReg AS time) <> '00:00:00' THEN 1 ELSE 0 END),
        COUNT(*)
FROM    dbo.[1TabPeças];
GO


/* ---------------------------------------------------------------------------
   BLOCO 6 -- Conferencia da relacao Custo = Metal + MO + Outros
   Responde: A-5 e D-3 (valor do metal e historico ou cotacao atual?)
   Se a mediana de Diff for ~0, TotalValor e dinheiro e a formula fecha.
   --------------------------------------------------------------------------- */
PRINT '=== BLOCO 6: Custo = TotalValor + MOExt + MOInt + ... ===';

SELECT TOP (30)
        p.[IDPeça],
        p.[Família],
        p.Custo,
        m.TotalValor                                   AS ValorMetal,
        ISNULL(p.MOExt,0) + ISNULL(p.MOInt,0)          AS MO,
        p.Custo - ISNULL(m.TotalValor,0)
                - (ISNULL(p.MOExt,0)+ISNULL(p.MOInt,0)) AS OutrosDerivado
FROM    dbo.[1TabPeças] p
LEFT JOIN dbo.METAIS    m ON m.Id = p.[IDPeça]
WHERE   p.Custo > 0
ORDER BY p.[IDPeça] DESC;
GO


/* ---------------------------------------------------------------------------
   BLOCO 7 -- Baseline numerico do relatorio ATUAL (01/07/2026 a 27/07/2026)
   Serve para comparar contra o relatorio novo nas Fases 5 e 6.
   --------------------------------------------------------------------------- */
PRINT '=== BLOCO 7: baseline 01/07/2026 a 27/07/2026 ===';

DECLARE @dt1 date = '2026-07-01';
DECLARE @dt2 date = '2026-07-27';

-- Total de vendas como o relatorio antigo calcula (VI_VENDAS.ValorFinal, V='Loja')
SELECT  'TT2 (VI_VENDAS V=Loja, ValorFinal)' AS Metrica,
        ISNULL(SUM(ValorFinal), 0)           AS Valor
FROM    dbo.VI_VENDAS
WHERE   DataVenda >= @dt1 AND DataVenda <= @dt2 AND V = N'Loja';

-- W / Encomendas como o relatorio antigo calcula (item-level, Oficial=1)
SELECT  'W (VENDAS DET, Oficial=1)' AS Metrica,
        ISNULL(SUM(d.ValorVenda), 0) AS Valor
FROM    dbo.[1TabPeças] p
JOIN    dbo.[VENDAS DET] d ON d.[Peça] = p.[IDPeça]
JOIN    dbo.VENDAS       v ON v.Id     = d.Venda
WHERE   v.DataVenda >= @dt1 AND v.DataVenda <= @dt2
  AND   p.Oficial = 1;

-- Soma bruta de todos os itens no periodo (para medir a divergencia de R-1)
SELECT  'Soma bruta [VENDAS DET]' AS Metrica,
        ISNULL(SUM(d.ValorVenda), 0) AS Valor
FROM    dbo.[VENDAS DET] d
JOIN    dbo.VENDAS       v ON v.Id = d.Venda
WHERE   v.DataVenda >= @dt1 AND v.DataVenda <= @dt2;

-- Soma de ValorFinal de todas as vendas com item (alvo do rateio)
SELECT  'SUM(VENDAS.ValorFinal) com item' AS Metrica,
        ISNULL(SUM(v.ValorFinal), 0)      AS Valor
FROM    dbo.VENDAS v
WHERE   v.DataVenda >= @dt1 AND v.DataVenda <= @dt2
  AND   EXISTS (SELECT 1 FROM dbo.[VENDAS DET] d WHERE d.Venda = v.Id);

-- Estoque atual pelo criterio canonico de EmEstoque.txt (nao filtra data)
SELECT  'Estoque (EmEstoque.txt)' AS Metrica,
        COUNT(dbo.[1TabPeças].[IDPeça]) AS Qtd,
        SUM(dbo.METAIS.OuroQtde)        AS Au,
        SUM(dbo.[1TabPeças].Custo)      AS Custo,
        SUM(dbo.[1TabPeças].PrVenda)    AS PrVenda
FROM    dbo.VENDAS
RIGHT OUTER JOIN dbo.[VENDAS DET] ON dbo.VENDAS.Id = dbo.[VENDAS DET].Venda
RIGHT OUTER JOIN dbo.[1TabPeças]
LEFT  OUTER JOIN dbo.METAIS   ON dbo.[1TabPeças].[IDPeça] = dbo.METAIS.Id
INNER JOIN       dbo.PEENBase ON dbo.[1TabPeças].[IDPeça] = dbo.PEENBase.[IDPeça]
                              ON dbo.[VENDAS DET].[Peça]  = dbo.[1TabPeças].[IDPeça]
WHERE   (dbo.VENDAS.DataVenda IS NULL)
  AND   (dbo.[1TabPeças].Vendida = 0 OR dbo.[1TabPeças].Vendida IS NULL)
  AND   (dbo.[1TabPeças].[Modêlo] IS NOT NULL)
  AND   (ISNULL(dbo.[1TabPeças].Saida, 0) = 0);
GO


/* ---------------------------------------------------------------------------
   BLOCO 8 -- Saida das stored procedures dos subrelatorios
   Responde: A-7 (a SP de cartoes retorna a coluna Percentual?)
   --------------------------------------------------------------------------- */
PRINT '=== BLOCO 8: SPs dos subrelatorios ===';

EXEC dbo.USP_Gerencial_Cartoes   @dt1 = '2026-07-01', @dt2 = '2026-07-27';
EXEC dbo.USP_Gerencial_Consertos @dt1 = '2026-07-01', @dt2 = '2026-07-27';
GO


/* ---------------------------------------------------------------------------
   BLOCO 9 -- Cotacao: estado atual da tabela
   Confirma que nao existe coluna de prata (motivo do ALTER da Fase 1)
   --------------------------------------------------------------------------- */
PRINT '=== BLOCO 9: tabela Cotacao ===';

SELECT  c.column_id, c.name AS Coluna, t.name AS Tipo, c.is_nullable
FROM    sys.columns c
JOIN    sys.types   t ON t.user_type_id = c.user_type_id
WHERE   c.object_id = OBJECT_ID(N'dbo.Cotação')
ORDER BY c.column_id;

SELECT TOP (10) * FROM dbo.[Cotação] ORDER BY DataCot DESC, Id DESC;
GO
