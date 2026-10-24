// Relatórios (contracts/openapi.yaml, /api/relatorios/...).
import { esquemaRelatorioClientesCadastrados } from '@pepe/shared';
import { keepPreviousData, queryOptions } from '@tanstack/react-query';

import { chamarApi } from './cliente';

/** Sem `de`/`ate` = "sem período". */
export function consultaClientesCadastrados(periodo: { de: string; ate: string } | null) {
  const parametros = periodo ? `?${new URLSearchParams(periodo).toString()}` : '';
  return queryOptions({
    queryKey: ['relatorios', 'clientes-cadastrados', periodo],
    queryFn: ({ signal }) =>
      chamarApi(`/relatorios/clientes-cadastrados${parametros}`, {
        esquema: esquemaRelatorioClientesCadastrados,
        sinal: signal,
      }),
    placeholderData: keepPreviousData,
  });
}
