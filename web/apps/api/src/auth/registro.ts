// Trilha de acesso em web.RegistroAcesso (data-model.md). Sem senha e sem dado de cliente (constituição V.3).
import type { Banco } from '../db/kysely.js';

export type EventoDeAcesso = 'ENTRADA' | 'ENTRADA_RECUSADA' | 'BLOQUEIO' | 'SAIDA' | 'SESSAO_EXPIRADA';

/** Aceita uma transação no lugar do banco. */
export async function registrarAcesso(
  banco: Banco,
  dados: { evento: EventoDeAcesso; login: string; idUsuario: number | null; ip: string | undefined; agora: Date },
): Promise<void> {
  await banco
    .insertInto('web.RegistroAcesso')
    .values({
      Evento: dados.evento,
      Login: dados.login.slice(0, 50),
      IdUsuario: dados.idUsuario,
      Ip: dados.ip ? dados.ip.slice(0, 45) : null,
      Momento: dados.agora,
    })
    .execute();
}
