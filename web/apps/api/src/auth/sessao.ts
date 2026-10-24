// Sessões no servidor (research.md R7; data-model.md web.Sessao). O cookie leva um identificador aleatório de
// 256 bits; no banco fica só o SHA-256 dele, então quem lê a tabela não consegue usar uma sessão.
import { createHash, randomBytes } from 'node:crypto';

import type { Banco } from '../db/kysely.js';
import { type EstadoSessao, type EstadoUsuario, INATIVIDADE_MAXIMA_MS, novaSessao } from './regras.js';

export const NOME_DO_COOKIE = 'pepe_sessao';

export function hashDoIdentificador(identificador: string): string {
  return createHash('sha256').update(identificador).digest('hex');
}

/** Cria a sessão e devolve o identificador que vai no cookie. Aceita uma transação no lugar do banco. */
export async function criarSessao(banco: Banco, idUsuario: number, agora: Date): Promise<string> {
  const identificador = randomBytes(32).toString('base64url');
  const sessao = novaSessao(agora);
  await banco
    .insertInto('web.Sessao')
    .values({
      IdSessao: hashDoIdentificador(identificador),
      IdUsuario: idUsuario,
      CriadaEm: sessao.criadaEm,
      UltimoUso: sessao.ultimoUso,
      ExpiraEm: sessao.expiraEm,
    })
    .execute();
  return identificador;
}

export interface SessaoEncontrada extends EstadoSessao {
  idSessao: string;
  usuario: EstadoUsuario & { id: number; login: string; nome: string };
}

export async function buscarSessao(banco: Banco, identificador: string): Promise<SessaoEncontrada | undefined> {
  const linha = await banco
    .selectFrom('web.Sessao as s')
    .innerJoin('web.Usuario as u', 'u.IdUsuario', 's.IdUsuario')
    .select([
      's.IdSessao',
      's.CriadaEm',
      's.UltimoUso',
      's.ExpiraEm',
      'u.IdUsuario',
      'u.Login',
      'u.Nome',
      'u.Ativo',
      'u.TentativasFalhas',
      'u.BloqueadoAte',
    ])
    .where('s.IdSessao', '=', hashDoIdentificador(identificador))
    .executeTakeFirst();
  if (!linha) return undefined;
  return {
    idSessao: linha.IdSessao,
    criadaEm: linha.CriadaEm,
    ultimoUso: linha.UltimoUso,
    expiraEm: linha.ExpiraEm,
    usuario: {
      id: linha.IdUsuario,
      login: linha.Login,
      nome: linha.Nome,
      ativo: Boolean(linha.Ativo),
      tentativasFalhas: linha.TentativasFalhas,
      bloqueadoAte: linha.BloqueadoAte,
    },
  };
}

export async function tocarSessao(banco: Banco, idSessao: string, agora: Date): Promise<void> {
  await banco.updateTable('web.Sessao').set({ UltimoUso: agora }).where('IdSessao', '=', idSessao).execute();
}

export async function apagarSessao(banco: Banco, idSessao: string): Promise<void> {
  await banco.deleteFrom('web.Sessao').where('IdSessao', '=', idSessao).execute();
}

export async function apagarSessoesDoUsuario(banco: Banco, idUsuario: number): Promise<void> {
  await banco.deleteFrom('web.Sessao').where('IdUsuario', '=', idUsuario).execute();
}

/** Apaga as sessões vencidas (todas, ou só as de um usuário). */
export async function limparSessoesVencidas(banco: Banco, agora: Date, idUsuario?: number): Promise<void> {
  const limiteDeInatividade = new Date(agora.getTime() - INATIVIDADE_MAXIMA_MS);
  let consulta = banco
    .deleteFrom('web.Sessao')
    .where((eb) => eb.or([eb('ExpiraEm', '<=', agora), eb('UltimoUso', '<=', limiteDeInatividade)]));
  if (idUsuario !== undefined) consulta = consulta.where('IdUsuario', '=', idUsuario);
  await consulta.execute();
}
