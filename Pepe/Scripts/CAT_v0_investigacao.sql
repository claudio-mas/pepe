/* ============================================================================
   CAT_v0_investigacao.sql  --  Catalogo do BDTorras para a versao web
   ----------------------------------------------------------------------------
   SOMENTE LEITURA. Nao cria, nao altera e nao apaga nada.

   Objetivo: levantar a estrutura do banco (tabelas, colunas, chaves, FKs,
   indices, views, procs, funcoes, gatilhos, dependencias) e responder as
   perguntas abertas no inventario do legado (docs/legado/10-clientes.md):
   FKs de Clientes, coluna SSMA_TimeStamp, o que sao CC, NVendasBase e tabcep.

   LGPD: nenhum bloco devolve dado pessoal. So estrutura e contagens.

   Como rodar:
   - Preferido: Pepe\Scripts\Exportar-Catalogo.ps1 (grava cada bloco em CSV
     em docs\legado\banco\ e cada view/proc/funcao/gatilho em .sql).
   - No SSMS: rodar tudo; cada bloco devolve um resultado. Os blocos sao
     independentes (separados por GO): se um falhar, os outros rodam.

   Cada bloco comeca com "-- @@ <nome>": e o nome do arquivo CSV gerado pelo
   Exportar-Catalogo.ps1. Bloco sem marcador nao e exportado.
   ============================================================================ */

USE BDTorras;
-- Os metodos XML (.value) usados para juntar listas exigem QUOTED_IDENTIFIER ON.
-- SSMS e SqlClient ja ligam; o sqlcmd nao (sem a opcao -I).
SET QUOTED_IDENTIFIER ON;
GO

-- @@ 00_banco
-- Identificacao da copia catalogada.
SELECT DB_NAME()                                   AS banco,
       CONVERT(nvarchar(128), SERVERPROPERTY('ProductVersion')) AS versao_sql,
       CONVERT(nvarchar(128), SERVERPROPERTY('Edition'))        AS edicao,
       d.compatibility_level                       AS nivel_compatibilidade,
       d.collation_name                            AS collation,
       GETDATE()                                   AS capturado_em
FROM sys.databases d
WHERE d.name = DB_NAME();
GO

-- @@ 01_tabelas
-- Tabelas com nº de linhas, identidade, coluna rowversion (SSMA_TimeStamp) e PK.
SELECT s.name AS [schema],
       t.name AS tabela,
       (SELECT SUM(p.rows) FROM sys.partitions p
         WHERE p.object_id = t.object_id AND p.index_id IN (0, 1)) AS linhas,
       (SELECT ic.name FROM sys.identity_columns ic
         WHERE ic.object_id = t.object_id) AS coluna_identidade,
       STUFF((SELECT ', ' + c.name
                FROM sys.columns c
                JOIN sys.types ty ON ty.user_type_id = c.user_type_id
               WHERE c.object_id = t.object_id AND ty.name = 'timestamp'
               FOR XML PATH(''), TYPE).value('.', 'nvarchar(max)'), 1, 2, '') AS coluna_rowversion,
       kc.name AS chave_primaria,
       t.create_date AS criada_em,
       t.modify_date AS alterada_em
FROM sys.tables t
JOIN sys.schemas s ON s.schema_id = t.schema_id
LEFT JOIN sys.key_constraints kc ON kc.parent_object_id = t.object_id AND kc.type = 'PK'
WHERE t.is_ms_shipped = 0
ORDER BY s.name, t.name;
GO

-- @@ 02_colunas
-- Colunas de tabelas e views. Tamanho em caracteres para nchar/nvarchar (-1 = max).
SELECT s.name AS [schema],
       o.name AS objeto,
       o.type_desc AS tipo_objeto,
       c.column_id AS ordem,
       c.name AS coluna,
       ty.name AS tipo,
       CASE WHEN ty.name IN ('nchar', 'nvarchar') AND c.max_length > 0
            THEN c.max_length / 2 ELSE c.max_length END AS tamanho,
       c.precision AS precisao,
       c.scale AS escala,
       c.is_nullable AS aceita_nulo,
       c.is_identity AS identidade,
       c.is_computed AS calculada,
       dc.definition AS padrao,
       cc.definition AS formula,
       c.collation_name AS collation
FROM sys.columns c
JOIN sys.objects o ON o.object_id = c.object_id
JOIN sys.schemas s ON s.schema_id = o.schema_id
JOIN sys.types ty ON ty.user_type_id = c.user_type_id
LEFT JOIN sys.default_constraints dc ON dc.object_id = c.default_object_id
LEFT JOIN sys.computed_columns cc ON cc.object_id = c.object_id AND cc.column_id = c.column_id
WHERE o.type IN ('U', 'V') AND o.is_ms_shipped = 0
ORDER BY s.name, o.name, c.column_id;
GO

-- @@ 03_chaves
-- Chaves primarias e restricoes UNIQUE.
SELECT s.name AS [schema],
       t.name AS tabela,
       kc.name AS restricao,
       kc.type_desc AS tipo,
       STUFF((SELECT ', ' + c.name
                FROM sys.index_columns ic
                JOIN sys.columns c ON c.object_id = ic.object_id AND c.column_id = ic.column_id
               WHERE ic.object_id = kc.parent_object_id AND ic.index_id = kc.unique_index_id
               ORDER BY ic.key_ordinal
               FOR XML PATH(''), TYPE).value('.', 'nvarchar(max)'), 1, 2, '') AS colunas
FROM sys.key_constraints kc
JOIN sys.tables t ON t.object_id = kc.parent_object_id
JOIN sys.schemas s ON s.schema_id = t.schema_id
ORDER BY s.name, t.name, kc.type_desc;
GO

-- @@ 04_fks
-- Chaves estrangeiras declaradas (com acao de DELETE/UPDATE e se estao ativas).
SELECT fk.name AS fk,
       OBJECT_SCHEMA_NAME(fk.parent_object_id) AS [schema],
       OBJECT_NAME(fk.parent_object_id) AS tabela,
       STUFF((SELECT ', ' + COL_NAME(fkc.parent_object_id, fkc.parent_column_id)
                FROM sys.foreign_key_columns fkc
               WHERE fkc.constraint_object_id = fk.object_id
               ORDER BY fkc.constraint_column_id
               FOR XML PATH(''), TYPE).value('.', 'nvarchar(max)'), 1, 2, '') AS colunas,
       OBJECT_NAME(fk.referenced_object_id) AS tabela_referenciada,
       STUFF((SELECT ', ' + COL_NAME(fkc.referenced_object_id, fkc.referenced_column_id)
                FROM sys.foreign_key_columns fkc
               WHERE fkc.constraint_object_id = fk.object_id
               ORDER BY fkc.constraint_column_id
               FOR XML PATH(''), TYPE).value('.', 'nvarchar(max)'), 1, 2, '') AS colunas_referenciadas,
       fk.delete_referential_action_desc AS ao_excluir,
       fk.update_referential_action_desc AS ao_alterar,
       fk.is_disabled AS desativada,
       fk.is_not_trusted AS nao_confiavel
FROM sys.foreign_keys fk
ORDER BY tabela_referenciada, tabela, fk.name;
GO

-- @@ 05_indices
-- Indices fora das PKs.
SELECT OBJECT_SCHEMA_NAME(i.object_id) AS [schema],
       OBJECT_NAME(i.object_id) AS tabela,
       i.name AS indice,
       i.type_desc AS tipo,
       i.is_unique AS unico,
       STUFF((SELECT ', ' + c.name + CASE WHEN ic.is_descending_key = 1 THEN ' DESC' ELSE '' END
                FROM sys.index_columns ic
                JOIN sys.columns c ON c.object_id = ic.object_id AND c.column_id = ic.column_id
               WHERE ic.object_id = i.object_id AND ic.index_id = i.index_id AND ic.is_included_column = 0
               ORDER BY ic.key_ordinal
               FOR XML PATH(''), TYPE).value('.', 'nvarchar(max)'), 1, 2, '') AS colunas,
       STUFF((SELECT ', ' + c.name
                FROM sys.index_columns ic
                JOIN sys.columns c ON c.object_id = ic.object_id AND c.column_id = ic.column_id
               WHERE ic.object_id = i.object_id AND ic.index_id = i.index_id AND ic.is_included_column = 1
               FOR XML PATH(''), TYPE).value('.', 'nvarchar(max)'), 1, 2, '') AS incluidas,
       i.filter_definition AS filtro
FROM sys.indexes i
JOIN sys.objects o ON o.object_id = i.object_id
WHERE o.type = 'U' AND o.is_ms_shipped = 0 AND i.type > 0 AND i.is_primary_key = 0
ORDER BY tabela, indice;
GO

-- @@ 06_modulos
-- Views, procs, funcoes e gatilhos com o codigo-fonte.
-- O Exportar-Catalogo.ps1 grava cada definicao em modulos\<tipo>\<schema>.<nome>.sql
-- e tira a coluna "definicao" do CSV.
SELECT o.type_desc AS tipo,
       s.name AS [schema],
       o.name AS nome,
       OBJECT_NAME(o.parent_object_id) AS tabela_do_gatilho,
       o.create_date AS criado_em,
       o.modify_date AS alterado_em,
       m.definition AS definicao
FROM sys.sql_modules m
JOIN sys.objects o ON o.object_id = m.object_id
JOIN sys.schemas s ON s.schema_id = o.schema_id
WHERE o.is_ms_shipped = 0
ORDER BY o.type_desc, s.name, o.name;
GO

-- @@ 07_parametros
-- Parametros de procs e funcoes.
SELECT OBJECT_SCHEMA_NAME(p.object_id) AS [schema],
       OBJECT_NAME(p.object_id) AS objeto,
       o.type_desc AS tipo_objeto,
       p.parameter_id AS ordem,
       p.name AS parametro,
       TYPE_NAME(p.user_type_id) AS tipo,
       p.max_length AS tamanho,
       p.is_output AS saida,
       p.has_default_value AS tem_padrao
FROM sys.parameters p
JOIN sys.objects o ON o.object_id = p.object_id
WHERE o.is_ms_shipped = 0 AND o.type IN ('P', 'FN', 'IF', 'TF', 'FS', 'FT')
ORDER BY objeto, p.parameter_id;
GO

-- @@ 08_gatilhos
-- Gatilhos de tabela: eventos, se estao ativos e se sao INSTEAD OF.
SELECT OBJECT_SCHEMA_NAME(tr.parent_id) AS [schema],
       OBJECT_NAME(tr.parent_id) AS tabela,
       tr.name AS gatilho,
       tr.is_disabled AS desativado,
       tr.is_instead_of_trigger AS instead_of,
       STUFF((SELECT ', ' + te.type_desc
                FROM sys.trigger_events te
               WHERE te.object_id = tr.object_id
               FOR XML PATH(''), TYPE).value('.', 'nvarchar(max)'), 1, 2, '') AS eventos
FROM sys.triggers tr
WHERE tr.parent_class = 1 AND tr.is_ms_shipped = 0
ORDER BY tabela, gatilho;
GO

-- @@ 09_dependencias
-- Quem (view/proc/funcao/gatilho) le ou grava qual objeto. Base da matriz CRUD.
SELECT DISTINCT
       OBJECT_SCHEMA_NAME(d.referencing_id) AS [schema],
       OBJECT_NAME(d.referencing_id) AS objeto,
       o.type_desc AS tipo_objeto,
       d.referenced_schema_name AS schema_referenciado,
       d.referenced_entity_name AS objeto_referenciado,
       ro.type_desc AS tipo_referenciado,
       d.is_ambiguous AS ambiguo
FROM sys.sql_expression_dependencies d
JOIN sys.objects o ON o.object_id = d.referencing_id
LEFT JOIN sys.objects ro ON ro.object_id = d.referenced_id
WHERE o.is_ms_shipped = 0 AND o.type IN ('V', 'P', 'FN', 'IF', 'TF', 'TR')
ORDER BY objeto, objeto_referenciado;
GO

-- @@ 10_colunas_cliente
-- Colunas que parecem apontar para o cliente fora da tabela Clientes
-- (FKs implicitas: o legado quase nao declara FK).
SELECT OBJECT_SCHEMA_NAME(c.object_id) AS [schema],
       OBJECT_NAME(c.object_id) AS objeto,
       o.type_desc AS tipo_objeto,
       c.name AS coluna,
       TYPE_NAME(c.user_type_id) AS tipo,
       CASE WHEN TYPE_NAME(c.user_type_id) IN ('nchar', 'nvarchar') AND c.max_length > 0
            THEN c.max_length / 2 ELSE c.max_length END AS tamanho
FROM sys.columns c
JOIN sys.objects o ON o.object_id = c.object_id
WHERE o.type IN ('U', 'V') AND o.is_ms_shipped = 0
  AND c.name LIKE '%client%'
  AND OBJECT_NAME(c.object_id) <> 'Clientes'
ORDER BY objeto, coluna;
GO

-- @@ 11_clientes_resumo
-- Perfil da tabela Clientes, so com contagens (sem dado pessoal).
SELECT COUNT(*) AS total,
       SUM(CASE WHEN Nome IS NULL AND Cliente IS NULL THEN 1 ELSE 0 END) AS sem_nome_nem_mala_direta,
       SUM(CASE WHEN Nome IS NULL AND Cliente IS NOT NULL THEN 1 ELSE 0 END) AS so_mala_direta,
       SUM(CASE WHEN Nome IS NOT NULL AND Cliente IS NULL THEN 1 ELSE 0 END) AS so_nome,
       SUM(CASE WHEN Oculto = 1 THEN 1 ELSE 0 END) AS oculto_1,
       SUM(CASE WHEN Oculto = 0 THEN 1 ELSE 0 END) AS oculto_0,
       SUM(CASE WHEN Oculto IS NULL THEN 1 ELSE 0 END) AS oculto_nulo,
       SUM(CASE WHEN Imp = 1 THEN 1 ELSE 0 END) AS marcados_etiqueta,
       SUM(CASE WHEN NULLIF(LTRIM(RTRIM(CPF)), '') IS NOT NULL THEN 1 ELSE 0 END) AS com_cpf,
       SUM(CASE WHEN CPF LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' THEN 1 ELSE 0 END) AS cpf_11_digitos,
       SUM(CASE WHEN Email LIKE '%@%' THEN 1 ELSE 0 END) AS com_email,
       SUM(CASE WHEN Aniv IS NOT NULL THEN 1 ELSE 0 END) AS com_aniversario,
       SUM(CASE WHEN DataCad IS NULL THEN 1 ELSE 0 END) AS sem_data_cadastro,
       MIN(DataCad) AS primeiro_cadastro,
       MAX(DataCad) AS ultimo_cadastro,
       (SELECT COUNT(*) FROM (SELECT Nome FROM dbo.Clientes WHERE Nome IS NOT NULL
                              GROUP BY Nome HAVING COUNT(*) > 1) x) AS nomes_repetidos
FROM dbo.Clientes;
GO

-- @@ 12_medidas
-- Medidas que dependem de colunas ainda nao confirmadas: cada uma roda em
-- SQL dinamico dentro de TRY/CATCH e, se falhar, devolve o erro na linha.
SET NOCOUNT ON;
DECLARE @m TABLE (ordem int IDENTITY, medida nvarchar(100), valor bigint NULL, erro nvarchar(2000) NULL);
DECLARE @q TABLE (ordem int IDENTITY, medida nvarchar(100), sql nvarchar(max));

INSERT @q (medida, sql) VALUES
 (N'clientes_com_vendas',
  N'SELECT @v = COUNT(*) FROM dbo.Clientes c WHERE EXISTS (SELECT 1 FROM dbo.VENDAS v WHERE v.IDCliente = c.IDCliente)'),
 (N'clientes_com_consertos',
  N'SELECT @v = COUNT(*) FROM dbo.Clientes c WHERE EXISTS (SELECT 1 FROM dbo.CONSERTOS k WHERE k.CLIENTE = c.IDCliente)'),
 (N'clientes_com_conta_corrente',
  N'SELECT @v = COUNT(*) FROM dbo.Clientes c WHERE EXISTS (SELECT 1 FROM dbo.[Conta Corrente] x WHERE x.Cliente = c.IDCliente)'),
 (N'clientes_com_algum_historico',
  N'SELECT @v = COUNT(*) FROM dbo.Clientes c WHERE EXISTS (SELECT 1 FROM dbo.VENDAS v WHERE v.IDCliente = c.IDCliente)
      OR EXISTS (SELECT 1 FROM dbo.CONSERTOS k WHERE k.CLIENTE = c.IDCliente)
      OR EXISTS (SELECT 1 FROM dbo.[Conta Corrente] x WHERE x.Cliente = c.IDCliente)'),
 (N'vendas_sem_cliente',
  N'SELECT @v = COUNT(*) FROM dbo.VENDAS WHERE IDCliente IS NULL'),
 (N'vendas_com_cliente_inexistente',
  N'SELECT @v = COUNT(*) FROM dbo.VENDAS v WHERE v.IDCliente IS NOT NULL AND NOT EXISTS (SELECT 1 FROM dbo.Clientes c WHERE c.IDCliente = v.IDCliente)'),
 (N'consertos_com_cliente_inexistente',
  N'SELECT @v = COUNT(*) FROM dbo.CONSERTOS k WHERE k.CLIENTE IS NOT NULL AND NOT EXISTS (SELECT 1 FROM dbo.Clientes c WHERE c.IDCliente = k.CLIENTE)'),
 (N'cc_com_cliente_inexistente',
  N'SELECT @v = COUNT(*) FROM dbo.[Conta Corrente] x WHERE x.Cliente IS NOT NULL AND NOT EXISTS (SELECT 1 FROM dbo.Clientes c WHERE c.IDCliente = x.Cliente)'),
 (N'vendas_internas',
  N'SELECT @v = COUNT(*) FROM dbo.VENDAS WHERE Tipo = ''Interna'''),
 (N'tabcep_linhas',
  N'SELECT @v = COUNT_BIG(*) FROM dbo.tabcep'),
 (N'nvendasbase_linhas',
  N'SELECT @v = COUNT_BIG(*) FROM dbo.NVendasBase'),
 (N'cc_linhas',
  N'SELECT @v = COUNT_BIG(*) FROM dbo.CC');

DECLARE @i int = 1, @n int = (SELECT COUNT(*) FROM @q), @medida nvarchar(100), @sql nvarchar(max), @v bigint;
WHILE @i <= @n
BEGIN
    SELECT @medida = medida, @sql = sql FROM @q WHERE ordem = @i;
    SET @v = NULL;
    BEGIN TRY
        EXEC sp_executesql @sql, N'@v bigint OUTPUT', @v = @v OUTPUT;
        INSERT @m (medida, valor) VALUES (@medida, @v);
    END TRY
    BEGIN CATCH
        INSERT @m (medida, erro) VALUES (@medida, ERROR_MESSAGE());
    END CATCH
    SET @i += 1;
END

SELECT medida, valor, erro FROM @m ORDER BY ordem;
GO

-- @@ 13_objetos_citados
-- Objetos citados em docs/legado/ cuja natureza esta "a confirmar":
-- tabela, view, proc, funcao ou inexistente.
SELECT n.nome,
       COALESCE(o.type_desc, N'NAO EXISTE') AS tipo,
       o.create_date AS criado_em,
       o.modify_date AS alterado_em
FROM (VALUES
 (N'CC'), (N'CC2'), (N'CCNovoGer'), (N'NVendasBase'), (N'tabcep'), (N'Compras'),
 (N'tabExtrato'), (N'tabCartões'), (N'tabCheques'), (N'tabCartõesRpt'), (N'tabChequesRpt'),
 (N'tabMatPrima'), (N'tabMateriaPrima'), (N'Meses'), (N'Getnet'), (N'Getnet_temp'), (N'VI_Getnet'),
 (N'Inconsist1'), (N'Inconsist2'), (N'Inconsist4'), (N'Inconsist5'),
 (N'Saidas'), (N'TiposSaidas'), (N'Reajustes'), (N'Cotação'), (N'Cartões'), (N'Vendedoras'),
 (N'USP_Cheques'), (N'USP_Cartões'), (N'USP_UPDATE_SALDO_CC'), (N'USP_CC_SALDO_INICIAL'),
 (N'USP_VOLTA'), (N'USP_CLONA_PECA'), (N'USP_MATPRIMA'), (N'USP_RPT_VENDA_CLIENTE'),
 (N'USP_RPT_VENDAS'), (N'USP_VENDAS_SAIDAS'), (N'fPeças')
) AS n(nome)
LEFT JOIN sys.objects o ON o.object_id = OBJECT_ID(N'dbo.' + QUOTENAME(n.nome))
ORDER BY tipo, n.nome;
GO
