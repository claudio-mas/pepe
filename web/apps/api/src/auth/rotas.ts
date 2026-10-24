// POST/GET/DELETE /api/sessao (contracts/openapi.yaml; FR-001, FR-002, FR-006; research.md R7).
// A recusa tem sempre a mesma mensagem, para não revelar se o login existe, está inativo ou bloqueado.
import { esquemaCredenciais, type UsuarioConectado } from '@pepe/shared';
import type { FastifyInstance, FastifyReply } from 'fastify';

import { ErroHttp } from '../erros.js';
import { registrarAcesso } from './registro.js';
import { aposAcerto, aposFalha, podeEntrar } from './regras.js';
import { verificarSenha } from './senha.js';
import { apagarSessao, buscarSessao, criarSessao, limparSessoesVencidas, NOME_DO_COOKIE } from './sessao.js';
import { normalizarLogin } from './usuarios.js';

const MENSAGEM_RECUSA = 'Usuário ou senha inválidos.';
/** Tentativas de entrada por endereço por minuto; o bloqueio por usuário (5 erros) é à parte. */
const ENTRADAS_POR_MINUTO = 30;

const opcoesDoCookie = { httpOnly: true, secure: true, sameSite: 'strict', path: '/' } as const;

export function apagarCookieDeSessao(reply: FastifyReply): FastifyReply {
  return reply.clearCookie(NOME_DO_COOKIE, opcoesDoCookie);
}

export async function rotasSessao(app: FastifyInstance): Promise<void> {
  app.post(
    '/sessao',
    {
      config: {
        publica: true,
        rateLimit: {
          max: ENTRADAS_POR_MINUTO,
          timeWindow: '1 minute',
          errorResponseBuilder: () =>
            new ErroHttp(429, 'Muitas tentativas de entrada. Aguarde um minuto e tente de novo.'),
        },
      },
    },
    async (request, reply): Promise<UsuarioConectado> => {
      const credenciais = esquemaCredenciais.safeParse(request.body);
      if (!credenciais.success) throw new ErroHttp(400, 'Parâmetro inválido.');
      const login = normalizarLogin(credenciais.data.login);
      const { senha } = credenciais.data;
      const agora = new Date();
      const banco = app.banco;
      const recusar = () => new ErroHttp(401, MENSAGEM_RECUSA);

      const usuario = await banco
        .selectFrom('web.Usuario')
        .select(['IdUsuario', 'Login', 'Nome', 'HashSenha', 'Ativo', 'TentativasFalhas', 'BloqueadoAte'])
        .where('Login', '=', login)
        .executeTakeFirst();

      if (!usuario) {
        await verificarSenha(null, senha);
        await registrarAcesso(banco, { evento: 'ENTRADA_RECUSADA', login, idUsuario: null, ip: request.ip, agora });
        throw recusar();
      }

      const estado = {
        ativo: Boolean(usuario.Ativo),
        tentativasFalhas: usuario.TentativasFalhas,
        bloqueadoAte: usuario.BloqueadoAte,
      };
      // A senha é conferida sempre, para o tempo de resposta não revelar o motivo da recusa
      const senhaCerta = await verificarSenha(usuario.HashSenha, senha);
      const id = usuario.IdUsuario;

      if (!podeEntrar(estado, agora)) {
        await registrarAcesso(banco, { evento: 'ENTRADA_RECUSADA', login, idUsuario: id, ip: request.ip, agora });
        throw recusar();
      }

      if (!senhaCerta) {
        const falha = aposFalha(estado, agora);
        await banco.transaction().execute(async (trx) => {
          await trx
            .updateTable('web.Usuario')
            .set({ TentativasFalhas: falha.tentativasFalhas, BloqueadoAte: falha.bloqueadoAte })
            .where('IdUsuario', '=', id)
            .execute();
          await registrarAcesso(trx, {
            evento: falha.bloqueou ? 'BLOQUEIO' : 'ENTRADA_RECUSADA',
            login,
            idUsuario: id,
            ip: request.ip,
            agora,
          });
        });
        throw recusar();
      }

      // Constituição IV.1: usuário, sessão e registro numa única transação
      const identificador = await banco.transaction().execute(async (trx) => {
        const acerto = aposAcerto();
        await trx
          .updateTable('web.Usuario')
          .set({ TentativasFalhas: acerto.tentativasFalhas, BloqueadoAte: acerto.bloqueadoAte, UltimoAcesso: agora })
          .where('IdUsuario', '=', id)
          .execute();
        await limparSessoesVencidas(trx, agora, id);
        const novo = await criarSessao(trx, id, agora);
        await registrarAcesso(trx, { evento: 'ENTRADA', login, idUsuario: id, ip: request.ip, agora });
        return novo;
      });

      request.idUsuario = id;
      reply.setCookie(NOME_DO_COOKIE, identificador, opcoesDoCookie);
      return { login: usuario.Login, nome: usuario.Nome };
    },
  );

  app.get('/sessao', async (request): Promise<UsuarioConectado> => {
    // O hook exigir-sessao já garantiu a sessão
    const usuario = request.usuario;
    if (!usuario) throw new ErroHttp(401, 'Entre para continuar.');
    return { login: usuario.login, nome: usuario.nome };
  });

  // Sair nunca falha: sem sessão válida, só apaga o cookie
  app.delete('/sessao', { config: { publica: true } }, async (request, reply) => {
    const identificador = request.cookies[NOME_DO_COOKIE];
    if (identificador) {
      const sessao = await buscarSessao(app.banco, identificador);
      if (sessao) {
        const agora = new Date();
        await app.banco.transaction().execute(async (trx) => {
          await apagarSessao(trx, sessao.idSessao);
          await registrarAcesso(trx, {
            evento: 'SAIDA',
            login: sessao.usuario.login,
            idUsuario: sessao.usuario.id,
            ip: request.ip,
            agora,
          });
        });
        request.idUsuario = sessao.usuario.id;
      }
    }
    return apagarCookieDeSessao(reply).status(204).send();
  });
}
