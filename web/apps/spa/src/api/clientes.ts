// Lista de clientes (contracts/openapi.yaml, GET /api/clientes).
import { esquemaPaginaClientes } from '@pepe/shared';
import { keepPreviousData, queryOptions } from '@tanstack/react-query';

import { chamarApi } from './cliente';

export const POR_PAGINA = 50;

export interface FiltroDaLista {
  busca: string;
  ocultos: boolean;
  pagina: number;
}

export function consultaClientes(filtro: FiltroDaLista) {
  const parametros = new URLSearchParams({ pagina: String(filtro.pagina), porPagina: String(POR_PAGINA) });
  if (filtro.busca) parametros.set('busca', filtro.busca);
  if (filtro.ocultos) parametros.set('ocultos', 'true');
  return queryOptions({
    queryKey: ['clientes', filtro],
    queryFn: ({ signal }) =>
      chamarApi(`/clientes?${parametros.toString()}`, { esquema: esquemaPaginaClientes, sinal: signal }),
    // Mantém a página anterior na tela enquanto a próxima pesquisa chega (sem piscar a tabela)
    placeholderData: keepPreviousData,
  });
}
