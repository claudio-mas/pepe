// Regras puras de sessão e bloqueio (research.md R7; FR-002). Sem banco: recebem o estado e o "agora".
// As datas do schema web são gravadas pela aplicação, em UTC (data-model.md).

export const INATIVIDADE_MAXIMA_MS = 30 * 60_000;
export const TETO_DA_SESSAO_MS = 12 * 60 * 60_000;
export const TENTATIVAS_ATE_BLOQUEIO = 5;
export const BLOQUEIO_MS = 15 * 60_000;
/** Intervalo mínimo entre duas gravações de UltimoUso (poupa o SQL Server Express). */
export const INTERVALO_TOQUE_MS = 60_000;

export interface EstadoUsuario {
  ativo: boolean;
  tentativasFalhas: number;
  bloqueadoAte: Date | null;
}

export interface EstadoSessao {
  criadaEm: Date;
  ultimoUso: Date;
  expiraEm: Date;
}

export type SituacaoSessao = 'valida' | 'expirada' | 'usuario-indisponivel';

export function estaBloqueado(usuario: EstadoUsuario, agora: Date): boolean {
  return usuario.bloqueadoAte !== null && agora < usuario.bloqueadoAte;
}

export function podeEntrar(usuario: EstadoUsuario, agora: Date): boolean {
  return usuario.ativo && !estaBloqueado(usuario, agora);
}

export function novaSessao(agora: Date): EstadoSessao {
  return { criadaEm: agora, ultimoUso: agora, expiraEm: new Date(agora.getTime() + TETO_DA_SESSAO_MS) };
}

export function situacaoDaSessao(sessao: EstadoSessao, usuario: EstadoUsuario, agora: Date): SituacaoSessao {
  if (agora >= sessao.expiraEm) return 'expirada';
  if (agora.getTime() - sessao.ultimoUso.getTime() >= INATIVIDADE_MAXIMA_MS) return 'expirada';
  if (!podeEntrar(usuario, agora)) return 'usuario-indisponivel';
  return 'valida';
}

export function precisaTocar(sessao: EstadoSessao, agora: Date): boolean {
  return agora.getTime() - sessao.ultimoUso.getTime() >= INTERVALO_TOQUE_MS;
}

/** Novo estado depois de uma senha errada. Um bloqueio vencido zera a contagem. */
export function aposFalha(
  usuario: EstadoUsuario,
  agora: Date,
): { tentativasFalhas: number; bloqueadoAte: Date | null; bloqueou: boolean } {
  const bloqueioVencido = usuario.bloqueadoAte !== null && agora >= usuario.bloqueadoAte;
  const tentativas = (bloqueioVencido ? 0 : usuario.tentativasFalhas) + 1;
  if (tentativas >= TENTATIVAS_ATE_BLOQUEIO) {
    return { tentativasFalhas: 0, bloqueadoAte: new Date(agora.getTime() + BLOQUEIO_MS), bloqueou: true };
  }
  return { tentativasFalhas: tentativas, bloqueadoAte: null, bloqueou: false };
}

export function aposAcerto(): { tentativasFalhas: number; bloqueadoAte: Date | null } {
  return { tentativasFalhas: 0, bloqueadoAte: null };
}
