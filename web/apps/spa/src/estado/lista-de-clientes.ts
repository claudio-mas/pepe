// Última pesquisa da lista de clientes, para o "Voltar" da ficha devolver a mesma lista (T043). Só na memória da
// página: uma recarga volta à lista sem filtro.
export interface BuscaDaLista {
  busca?: string;
  ocultos?: boolean;
  pagina?: number;
}

let ultima: BuscaDaLista = {};

export function lembrarBuscaDaLista(busca: BuscaDaLista): void {
  ultima = { ...busca };
}

export function buscaDaLista(): BuscaDaLista {
  return ultima;
}
