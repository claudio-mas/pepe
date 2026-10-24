// Hook preHandler que exige sessão válida em todo /api, menos nas rotas marcadas com config.publica
// (POST e DELETE /api/sessao). Responde 401 (SemSessao) e a SPA volta para a entrada (research.md R7).
import type { FastifyInstance, FastifyReply, FastifyRequest } from 'fastify';

import { registrarAcesso } from './registro.js';
import { precisaTocar, situacaoDaSessao } from './regras.js';
import { apagarCookieDeSessao } from './rotas.js';
import { apagarSessao, buscarSessao, NOME_DO_COOKIE, tocarSessao } from './sessao.js';

export interface UsuarioDaSessao {
  id: number;
  login: string;
  nome: string;
}

declare module 'fastify' {
  interface FastifyContextConfig {
    /** Rota da API que não exige sessão. */
    publica?: boolean;
  }
  interface FastifyRequest {
    usuario?: UsuarioDaSessao;
  }
}

const SEM_SESSAO = 'Entre para continuar.';
const SESSAO_EXPIRADA = 'Sua sessão expirou. Entre de novo.';

function recusar(reply: FastifyReply, mensagem: string): FastifyReply {
  return apagarCookieDeSessao(reply).status(401).send({ mensagem });
}

export function exigirSessao(app: FastifyInstance): void {
  app.addHook('preHandler', async (request: FastifyRequest, reply: FastifyReply) => {
    const rota = request.routeOptions.url;
    if (request.is404 || !rota || !rota.startsWith('/api/')) return;
    if (request.routeOptions.config.publica) return;

    const identificador = request.cookies[NOME_DO_COOKIE];
    if (!identificador) return recusar(reply, SEM_SESSAO);
    const sessao = await buscarSessao(app.banco, identificador);
    if (!sessao) return recusar(reply, SEM_SESSAO);

    const agora = new Date();
    const situacao = situacaoDaSessao(sessao, sessao.usuario, agora);
    if (situacao !== 'valida') {
      await app.banco.transaction().execute(async (trx) => {
        await apagarSessao(trx, sessao.idSessao);
        if (situacao === 'expirada') {
          await registrarAcesso(trx, {
            evento: 'SESSAO_EXPIRADA',
            login: sessao.usuario.login,
            idUsuario: sessao.usuario.id,
            ip: request.ip,
            agora,
          });
        }
      });
      return recusar(reply, situacao === 'expirada' ? SESSAO_EXPIRADA : SEM_SESSAO);
    }

    if (precisaTocar(sessao, agora)) await tocarSessao(app.banco, sessao.idSessao, agora);
    request.usuario = { id: sessao.usuario.id, login: sessao.usuario.login, nome: sessao.usuario.nome };
    request.idUsuario = sessao.usuario.id;
  });
}
