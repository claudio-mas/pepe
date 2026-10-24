// Servidor da versão web (research.md R2): um único processo Fastify serve a API em /api e a SPA compilada,
// por HTTPS (constituição V.4). O log nunca registra a URL real nem a query string, porque a pesquisa de
// clientes leva nomes e telefones (research.md R9; constituição V.3).
import { existsSync, readFileSync } from 'node:fs';
import { join } from 'node:path';
import { fileURLToPath } from 'node:url';

import fastifyCookie from '@fastify/cookie';
import fastifyRateLimit from '@fastify/rate-limit';
import fastifyStatic from '@fastify/static';
import Fastify, { type FastifyInstance, type FastifyServerOptions, LogController } from 'fastify';

import { exigirSessao } from './auth/exigir-sessao.js';
import { rotasSessao } from './auth/rotas.js';
import { limparSessoesVencidas } from './auth/sessao.js';
import { rotasClientes } from './clientes/rotas.js';
import { lerConfig } from './config.js';
import { bancoIndisponivel, MENSAGEM_BANCO_INDISPONIVEL } from './db/indisponivel.js';
import { type Banco, criarBanco } from './db/kysely.js';
import { ErroHttp } from './erros.js';
import { rotasRelatorios } from './relatorios/rotas.js';

export { ErroHttp };

declare module 'fastify' {
  interface FastifyRequest {
    /** Preenchido pela verificação de sessão (auth/exigir-sessao.ts); entra no log no lugar de dados do usuário. */
    idUsuario?: number;
  }
  interface FastifyInstance {
    banco: Banco;
  }
}

const MENSAGEM_ERRO_INTERNO = 'Erro interno. Tente de novo; se continuar, avise o responsável pelo sistema.';
const DIRETORIO_SPA_PADRAO = fileURLToPath(new URL('../../spa/dist/', import.meta.url));

export interface OpcoesApp {
  banco: Banco;
  /** Certificado e chave em PEM. Sem eles o servidor fica em HTTP: só para testes com inject(). */
  https?: { cert: Buffer; key: Buffer };
  diretorioSpa?: string;
  /** Configuração do logger (pino). Os testes passam um stream próprio para inspecionar o log. */
  logger?: FastifyServerOptions['logger'];
}

export async function construirApp(opcoes: OpcoesApp): Promise<FastifyInstance> {
  const app = Fastify({
    ...(opcoes.https ? { https: opcoes.https } : {}),
    logger: opcoes.logger ?? {
      level: 'info',
      redact: ['req.headers.cookie', 'req.headers.authorization', 'res.headers["set-cookie"]'],
    },
    // O log padrão de requisição registra a URL completa; o onResponse abaixo registra só o padrão da rota.
    logController: new LogController({ disableRequestLogging: true }),
    trustProxy: false,
  }) as unknown as FastifyInstance;

  app.decorate('banco', opcoes.banco);

  app.addHook('onResponse', async (request, reply) => {
    request.log.info(
      {
        metodo: request.method,
        rota: request.routeOptions.url ?? '(sem rota)',
        status: reply.statusCode,
        ms: Math.round(reply.elapsedTime),
        idUsuario: request.idUsuario,
      },
      'requisição',
    );
  });

  app.setErrorHandler(
    (erro: Error & { statusCode?: number; validation?: unknown; code?: string; number?: number }, request, reply) => {
      if (erro instanceof ErroHttp) {
        return reply.status(erro.statusCode).send({ mensagem: erro.message });
      }
      if (erro.validation) {
        return reply.status(400).send({ mensagem: 'Parâmetro inválido.' });
      }
      if (bancoIndisponivel(erro)) {
        request.log.error({ erro: { nome: erro.constructor.name, codigo: erro.code } }, 'banco indisponível');
        return reply.status(503).send({ mensagem: MENSAGEM_BANCO_INDISPONIVEL });
      }
      const status = erro.statusCode && erro.statusCode >= 400 && erro.statusCode < 500 ? erro.statusCode : 500;
      if (status >= 500) {
        // Só nome e códigos: a mensagem de um erro do banco pode citar o valor de um campo (dado pessoal).
        request.log.error({ erro: { nome: erro.name, codigo: erro.code, numeroSql: erro.number } }, 'erro interno');
        return reply.status(500).send({ mensagem: MENSAGEM_ERRO_INTERNO });
      }
      return reply.status(status).send({ mensagem: 'Requisição inválida.' });
    },
  );

  const diretorioSpa = opcoes.diretorioSpa ?? DIRETORIO_SPA_PADRAO;
  const temSpa = existsSync(join(diretorioSpa, 'index.html'));
  if (temSpa) {
    await app.register(fastifyStatic, { root: diretorioSpa, wildcard: false, index: ['index.html'] });
  }

  app.setNotFoundHandler((request, reply) => {
    const rotaDaApi = request.url === '/api' || request.url.startsWith('/api/');
    if (rotaDaApi || !temSpa || request.method !== 'GET') {
      return reply.status(404).send({ mensagem: 'Recurso não encontrado.' });
    }
    // Rotas da SPA (ex.: /clientes/12): o roteador do navegador resolve a partir do index.html
    return reply.type('text/html').sendFile('index.html');
  });

  await app.register(fastifyCookie);
  // Sem limite global: só a entrada (POST /api/sessao) tem limite por endereço
  await app.register(fastifyRateLimit, { global: false });
  exigirSessao(app);

  // Rotas da API, sempre com prefixo /api
  await app.register(rotasSessao, { prefix: '/api' });
  await app.register(rotasClientes, { prefix: '/api' });
  await app.register(rotasRelatorios, { prefix: '/api' });

  return app;
}

async function iniciar(): Promise<void> {
  const config = lerConfig();
  const banco = criarBanco(config.bancoDeDados);
  await limparSessoesVencidas(banco, new Date());
  const app = await construirApp({
    banco,
    https: { cert: readFileSync(config.https.certificado), key: readFileSync(config.https.chave) },
    ...(config.diretorioSpa ? { diretorioSpa: config.diretorioSpa } : {}),
  });
  app.addHook('onClose', async () => {
    await banco.destroy();
  });
  for (const sinal of ['SIGINT', 'SIGTERM'] as const) {
    process.once(sinal, () => {
      void app.close().then(() => process.exit(0));
    });
  }
  await app.listen({ port: config.porta, host: config.host });
}

if (process.argv[1] && fileURLToPath(import.meta.url) === process.argv[1]) {
  iniciar().catch((erro: unknown) => {
    console.error(erro instanceof Error ? erro.message : erro);
    process.exit(1);
  });
}
