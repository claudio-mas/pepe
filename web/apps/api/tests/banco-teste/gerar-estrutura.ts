// Gera tests/banco-teste/estrutura.sql a partir do catálogo do banco real (docs/legado/banco/).
// As tabelas do banco de teste ficam idênticas às da produção (nomes, tipos, tamanhos, nulidade,
// identidade, padrões e PK), e a view CC é copiada sem alteração. Nenhum dado real é lido.
//
// Uso (em web/apps/api): pnpm exec tsx tests/banco-teste/gerar-estrutura.ts
// Rode de novo quando o catálogo for reexportado (Pepe/Scripts/Exportar-Catalogo.ps1).

import { readFileSync, writeFileSync } from 'node:fs';
import { fileURLToPath } from 'node:url';

const catalogo = fileURLToPath(new URL('../../../../../docs/legado/banco/', import.meta.url));
const destino = fileURLToPath(new URL('./estrutura.sql', import.meta.url));

// Tabelas lidas pela entrega 001 e as que a view CC usa (data-model.md, seção 2)
const TABELAS = ['Clientes', 'VENDAS', 'VENDAS DET', '1TabPeças', 'CONSERTOS', 'Conta Corrente'];

type Linha = Record<string, string>;

/** CSV no formato do Exportar-Catalogo.ps1: vírgula, aspas duplas com "" para escapar. */
function lerCsv(arquivo: string): Linha[] {
  const texto = readFileSync(catalogo + arquivo, 'utf8').replace(/^\uFEFF/, '');
  const registros: string[][] = [];
  let campo = '';
  let registro: string[] = [];
  let entreAspas = false;
  for (let i = 0; i < texto.length; i++) {
    const c = texto[i];
    if (entreAspas) {
      if (c === '"' && texto[i + 1] === '"') {
        campo += '"';
        i++;
      } else if (c === '"') entreAspas = false;
      else campo += c;
    } else if (c === '"') entreAspas = true;
    else if (c === ',') {
      registro.push(campo);
      campo = '';
    } else if (c === '\n' || c === '\r') {
      if (c === '\r' && texto[i + 1] === '\n') i++;
      registro.push(campo);
      campo = '';
      if (registro.some((v) => v !== '')) registros.push(registro);
      registro = [];
    } else campo += c;
  }
  if (campo !== '' || registro.length) registros.push([...registro, campo]);
  const [cabecalho, ...dados] = registros;
  if (!cabecalho) throw new Error(`${arquivo} vazio`);
  return dados.map((r) => Object.fromEntries(cabecalho.map((nome, i) => [nome, r[i] ?? ''])));
}

function tipoSql(c: Linha): string {
  const tipo = c.tipo ?? '';
  const tamanho = Number(c.tamanho);
  switch (tipo) {
    case 'nvarchar':
    case 'varchar':
    case 'nchar':
    case 'char':
    case 'varbinary':
    case 'binary':
      return `${tipo}(${tamanho === -1 ? 'max' : tamanho})`;
    case 'datetime2':
    case 'time':
    case 'datetimeoffset':
      return `${tipo}(${c.escala})`;
    case 'decimal':
    case 'numeric':
      return `${tipo}(${c.precisao}, ${c.escala})`;
    default:
      return tipo;
  }
}

const colunas = lerCsv('02_colunas.csv');
const chaves = lerCsv('03_chaves.csv');

const blocos: string[] = [];
for (const tabela of TABELAS) {
  const cols = colunas
    .filter((c) => c.schema === 'dbo' && c.objeto === tabela && c.tipo_objeto === 'USER_TABLE')
    .sort((a, b) => Number(a.ordem) - Number(b.ordem));
  if (!cols.length) throw new Error(`Tabela ${tabela} não encontrada no catálogo`);
  const pk = chaves.find((k) => k.tabela === tabela && k.tipo === 'PRIMARY_KEY_CONSTRAINT');
  const linhas = cols.map((c) => {
    const partes = [`[${c.coluna}]`, tipoSql(c)];
    if (c.identidade === '1') partes.push('IDENTITY(1, 1)');
    partes.push(c.aceita_nulo === '1' ? 'NULL' : 'NOT NULL');
    if (c.padrao) partes.push(`DEFAULT ${c.padrao}`);
    return '    ' + partes.join(' ');
  });
  if (pk) {
    const colsPk = (pk.colunas ?? '')
      .split(',')
      .map((n) => `[${n.trim()}]`)
      .join(', ');
    linhas.push(`    CONSTRAINT [PK_${tabela.replace(/\s/g, '_')}] PRIMARY KEY (${colsPk})`);
  }
  blocos.push(`CREATE TABLE dbo.[${tabela}] (\n${linhas.join(',\n')}\n);\nGO`);
}

const viewCC = readFileSync(catalogo + 'modulos/VIEW/dbo.CC.sql', 'utf8')
  .replace(/^\uFEFF/, '')
  .trim();

const sql = `/* ============================================================================
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

${blocos.join('\n\n')}

${viewCC}
GO
`;

writeFileSync(destino, sql, 'utf8');
console.log(`estrutura.sql gerado com ${TABELAS.length} tabelas e a view CC.`);
