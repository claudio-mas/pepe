// Gera src/db/tipos.ts com o kysely-codegen, introspectando o banco de teste como pepe_web:
// só entram os objetos que a web pode ler (research.md R10), com os nomes originais do banco
// (constituição VI.2). Pré-requisito: banco de teste preparado (tests/banco-teste/preparar.ts).
//
// Uso (em web/apps/api): pnpm gerar-tipos
import { execFileSync } from 'node:child_process';
import { readFileSync, writeFileSync } from 'node:fs';
import { fileURLToPath } from 'node:url';

import { configBancoTeste } from './preparar.js';

const config = configBancoTeste();
const destino = fileURLToPath(new URL('../../src/db/tipos.ts', import.meta.url));

execFileSync(
  'pnpm',
  ['exec', 'kysely-codegen', '--dialect', 'mssql', '--default-schema', 'dbo', '--out-file', destino],
  {
    stdio: 'inherit',
    shell: process.platform === 'win32',
    env: {
      ...process.env,
      NODE_NO_WARNINGS: '1',
      DATABASE_URL:
        `Server=${config.servidor},${config.porta};Database=${config.banco};` +
        `User Id=${config.usuario};Password=${config.senha};Encrypt=false;TrustServerCertificate=true`,
    },
  },
);

const gerado = readFileSync(destino, 'utf8');
writeFileSync(
  destino,
  '// GERADO por `pnpm gerar-tipos` (tests/banco-teste/gerar-tipos.ts). Não edite à mão.\n' + gerado,
  'utf8',
);
