// Apoio dos testes de contrato: monta a API sobre o banco de teste e entra com um usuário próprio do teste.
// Cada arquivo de teste usa logins próprios (os arquivos rodam em paralelo sobre o mesmo banco).
import { inject } from 'vitest';

import { criarUsuario } from '../../src/auth/usuarios.js';
import { type Banco, criarBanco } from '../../src/db/kysely.js';
import { construirApp, type OpcoesApp } from '../../src/server.js';

export const SENHA_DE_TESTE = 'senha-de-teste-123';

export interface AppDeTeste {
  app: Awaited<ReturnType<typeof construirApp>>;
  banco: Banco;
  fechar: () => Promise<void>;
  /** Cria (se preciso) o usuário e devolve o cabeçalho Cookie de uma sessão válida. */
  entrarComo: (login: string) => Promise<string>;
}

/** `logger`: por padrão sem log; o teste de log sem dado pessoal passa um logger com destino próprio. */
export async function montarAppDeTeste(opcoes: Pick<OpcoesApp, 'logger'> = {}): Promise<AppDeTeste> {
  const banco = criarBanco(inject('bancoTeste'));
  const app = await construirApp({ banco, diretorioSpa: '/nao/existe', logger: opcoes.logger ?? false });
  return {
    app,
    banco,
    fechar: async () => {
      await app.close();
      await banco.destroy();
    },
    entrarComo: async (login) => {
      const existe = await banco
        .selectFrom('web.Usuario')
        .select('IdUsuario')
        .where('Login', '=', login)
        .executeTakeFirst();
      if (!existe) await criarUsuario(banco, { login, nome: `Teste ${login}`, senha: SENHA_DE_TESTE });
      const resposta = await app.inject({
        method: 'POST',
        url: '/api/sessao',
        payload: { login, senha: SENHA_DE_TESTE },
      });
      if (resposta.statusCode !== 200) throw new Error(`Entrada de ${login} falhou: ${resposta.statusCode}`);
      return cookieDaResposta(resposta.headers['set-cookie']);
    },
  };
}

/** Extrai "pepe_sessao=..." do Set-Cookie, no formato do cabeçalho Cookie. */
export function cookieDaResposta(setCookie: string | string[] | undefined): string {
  const linhas = Array.isArray(setCookie) ? setCookie : setCookie ? [setCookie] : [];
  const linha = linhas.find((l) => l.startsWith('pepe_sessao='));
  if (!linha) throw new Error('Resposta sem cookie pepe_sessao');
  return linha.split(';')[0] ?? '';
}
