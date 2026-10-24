// Prepara o banco de teste sintético (research.md R12): sobe o contêiner de web/docker-compose.teste.yml,
// recria o BDTorrasTeste (estrutura.sql), aplica o script real Pepe/Scripts/WEB001_v1_up.sql e carrega dados.sql.
//
// Usado como globalSetup do Vitest (e depois do Playwright). Também roda sozinho:
//   pnpm exec tsx tests/banco-teste/preparar.ts
import { execFileSync } from 'node:child_process';
import { randomBytes } from 'node:crypto';
import { existsSync, readFileSync, writeFileSync } from 'node:fs';
import { fileURLToPath } from 'node:url';

import * as Tedious from 'tedious';

import type { ConfigBanco } from '../../src/config.js';

const raizWeb = fileURLToPath(new URL('../../../../', import.meta.url));
const raizRepositorio = fileURLToPath(new URL('../../../../../', import.meta.url));
const arquivoEnv = raizWeb + '.env.teste.local';
const arquivoCompose = raizWeb + 'docker-compose.teste.yml';

export const BANCO_TESTE = 'BDTorrasTeste';
export const PORTA_TESTE = 14331;

interface SenhasTeste {
  sa: string;
  web: string;
}

/** Senha aleatória que atende à política do SQL Server (maiúscula, minúscula, dígito e símbolo). */
function senhaAleatoria(): string {
  return randomBytes(18).toString('base64url').replace(/[-_]/g, 'x') + 'Aa1!';
}

/** Lê web/.env.teste.local; se não existir, cria com senhas aleatórias (o arquivo é ignorado pelo git). */
export function lerSenhasTeste(): SenhasTeste {
  if (!existsSync(arquivoEnv)) {
    writeFileSync(
      arquivoEnv,
      `# Gerado por tests/banco-teste/preparar.ts. Só para o contêiner de teste.\n` +
        `PEPE_TESTE_SA_SENHA=${senhaAleatoria()}\nPEPE_TESTE_WEB_SENHA=${senhaAleatoria()}\n`,
      'utf8',
    );
  }
  const valores = Object.fromEntries(
    readFileSync(arquivoEnv, 'utf8')
      .split(/\r?\n/)
      .filter((l) => /^[A-Z_]+=/.test(l))
      .map((l) => [l.slice(0, l.indexOf('=')), l.slice(l.indexOf('=') + 1)]),
  );
  const sa = valores.PEPE_TESTE_SA_SENHA;
  const web = valores.PEPE_TESTE_WEB_SENHA;
  if (!sa || !web) throw new Error(`Defina PEPE_TESTE_SA_SENHA e PEPE_TESTE_WEB_SENHA em ${arquivoEnv}`);
  return { sa, web };
}

/** Configuração de conexão dos testes: o login pepe_web, com as mesmas permissões da produção (R10). */
export function configBancoTeste(senhas = lerSenhasTeste()): ConfigBanco {
  return {
    servidor: '127.0.0.1',
    porta: PORTA_TESTE,
    banco: BANCO_TESTE,
    usuario: 'pepe_web',
    senha: senhas.web,
    criptografar: false,
    confiarCertificado: true,
  };
}

function conectarComoSa(senha: string, banco = 'master'): Promise<Tedious.Connection> {
  return new Promise((resolve, reject) => {
    const conexao = new Tedious.Connection({
      server: '127.0.0.1',
      authentication: { type: 'default', options: { userName: 'sa', password: senha } },
      options: {
        port: PORTA_TESTE,
        database: banco,
        encrypt: false,
        trustServerCertificate: true,
        connectTimeout: 5_000,
        // Sem limite por lote: o CREATE DATABASE do primeiro uso do contêiner pode passar de 15 s
        requestTimeout: 0,
      },
    });
    conexao.on('error', () => undefined);
    conexao.connect((erro) => (erro ? reject(erro) : resolve(conexao)));
  });
}

function executarLote(conexao: Tedious.Connection, sql: string): Promise<void> {
  return new Promise((resolve, reject) => {
    conexao.execSqlBatch(new Tedious.Request(sql, (erro) => (erro ? reject(erro) : resolve())));
  });
}

/** Executa um script com lotes separados por GO, trocando variáveis $(NOME) como o sqlcmd. */
async function executarScript(conexao: Tedious.Connection, arquivo: string, variaveis: Record<string, string> = {}) {
  let texto = readFileSync(arquivo, 'utf8').replace(/^\uFEFF/, '');
  for (const [nome, valor] of Object.entries(variaveis)) texto = texto.replaceAll(`$(${nome})`, valor);
  const lotes = texto.split(/^\s*GO\s*$/im).filter((l) => l.trim() !== '');
  for (const lote of lotes) {
    try {
      await executarLote(conexao, lote);
    } catch (erro) {
      const inicio = lote.trim().split('\n')[0];
      throw new Error(`Falha em ${arquivo} (lote que começa com "${inicio}"): ${(erro as Error).message}`, {
        cause: erro,
      });
    }
  }
}

async function aguardarServidor(senhaSa: string): Promise<Tedious.Connection> {
  const limite = Date.now() + 120_000;
  let ultimoErro: unknown;
  while (Date.now() < limite) {
    try {
      return await conectarComoSa(senhaSa);
    } catch (erro) {
      ultimoErro = erro;
      await new Promise((r) => setTimeout(r, 2_000));
    }
  }
  throw new Error(`O SQL Server de teste não respondeu em 2 minutos: ${(ultimoErro as Error)?.message}`);
}

export async function prepararBancoTeste(): Promise<ConfigBanco> {
  const senhas = lerSenhasTeste();
  execFileSync('docker', ['compose', '--env-file', arquivoEnv, '-f', arquivoCompose, 'up', '-d', '--wait'], {
    stdio: 'ignore',
  });
  const conexao = await aguardarServidor(senhas.sa);
  try {
    await executarScript(conexao, fileURLToPath(new URL('./estrutura.sql', import.meta.url)));
    await executarScript(conexao, raizRepositorio + 'Pepe/Scripts/WEB001_v1_up.sql', { SENHA_PEPE_WEB: senhas.web });
    await executarScript(conexao, fileURLToPath(new URL('./dados.sql', import.meta.url)));
  } finally {
    conexao.close();
  }
  return configBancoTeste(senhas);
}

/** globalSetup do Vitest: prepara o banco uma vez e entrega a configuração aos testes (inject('bancoTeste')). */
export default async function setup({ provide }: { provide: (chave: 'bancoTeste', valor: ConfigBanco) => void }) {
  provide('bancoTeste', await prepararBancoTeste());
}

declare module 'vitest' {
  export interface ProvidedContext {
    bancoTeste: ConfigBanco;
  }
}

if (process.argv[1] && fileURLToPath(import.meta.url) === process.argv[1]) {
  prepararBancoTeste()
    .then((c) => console.log(`Banco de teste pronto: ${c.servidor},${c.porta} / ${c.banco} (usuário ${c.usuario}).`))
    .catch((erro: unknown) => {
      console.error(erro);
      process.exitCode = 1;
    });
}
