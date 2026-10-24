// Consultas com TanStack Query (research.md R4): cache, carga e erro em um lugar só.
// Uma falha nunca deixa a tela em branco: a tela mostra mensagemDeErro(erro) com a opção de tentar de novo.
import { QueryClient } from '@tanstack/react-query';

import { ErroApi, MENSAGENS } from './cliente';

/** Tenta de novo, no máximo duas vezes, só quando o servidor ou o banco não responderam. */
export function deveRepetir(falhas: number, erro: unknown): boolean {
  if (falhas >= 2 || !(erro instanceof ErroApi)) return false;
  return erro.status === 0 || erro.status >= 500;
}

/** Texto para o usuário, em português, de qualquer erro de consulta. */
export function mensagemDeErro(erro: unknown): string {
  return erro instanceof ErroApi ? erro.message : MENSAGENS.erroInterno;
}

export function criarClienteDeConsultas(): QueryClient {
  return new QueryClient({
    defaultOptions: {
      // Sem staleTime: ao reabrir uma tela, a consulta é refeita e mostra o que o desktop alterou (spec 001)
      queries: { retry: deveRepetir },
      // Gravação nunca é repetida sozinha (constituição IV)
      mutations: { retry: false },
    },
  });
}
