// Entrada, sessão atual e saída (contracts/openapi.yaml, /api/sessao).
import { type Credenciais, esquemaUsuarioConectado, type UsuarioConectado } from '@pepe/shared';
import { queryOptions } from '@tanstack/react-query';

import { chamarApi, ROTA_ENTRAR } from './cliente';

export const consultaSessao = queryOptions({
  queryKey: ['sessao'],
  queryFn: ({ signal }) => chamarApi('/sessao', { esquema: esquemaUsuarioConectado, sinal: signal }),
  staleTime: 5 * 60_000,
});

export function entrar(credenciais: Credenciais): Promise<UsuarioConectado> {
  return chamarApi('/sessao', {
    metodo: 'POST',
    corpo: credenciais,
    esquema: esquemaUsuarioConectado,
    redirecionarSemSessao: false,
  });
}

/** Encerra a sessão e recarrega na entrada (a recarga descarta o cache das consultas). */
export async function sair(): Promise<void> {
  try {
    await chamarApi('/sessao', { metodo: 'DELETE', redirecionarSemSessao: false });
  } finally {
    window.location.assign(ROTA_ENTRAR);
  }
}
