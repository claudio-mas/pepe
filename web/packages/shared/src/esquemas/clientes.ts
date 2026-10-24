// Esquemas da lista de clientes, iguais a specs/001-consulta-clientes/contracts/openapi.yaml, e as regras de
// exibição do legado (docs/legado/10-clientes.md).
import { z } from 'zod';

/** Nome mostrado na web: o Nome e, sem ele, o nome de mala direta (RN-CLI-002). Sem os dois, o cliente fica fora (RN-CLI-001). */
export function nomeExibicao(nome: string | null, malaDireta: string | null): string | null {
  return nome ?? malaDireta;
}

/** Só `Oculto = 1` esconde o cliente; nulo conta como visível, porque o padrão da coluna é 0 (RN-CLI-018). */
export function clienteOculto(oculto: boolean | null): boolean {
  return oculto === true;
}

/** Parâmetros de GET /api/clientes, vindos da query string. */
export const esquemaFiltroClientes = z.object({
  busca: z.string().trim().max(100).default(''),
  ocultos: z.stringbool().default(false),
  pagina: z.coerce.number().int().min(1).default(1),
  porPagina: z.coerce.number().int().min(10).max(100).default(50),
});
export type FiltroClientes = z.infer<typeof esquemaFiltroClientes>;

/** Item da lista (FR-009). Datas em `YYYY-MM-DD`. */
export const esquemaClienteResumo = z.object({
  id: z.number().int(),
  nomeExibicao: z.string(),
  titulo: z.string().nullable(),
  malaDireta: z.string().nullable(),
  endereco: z.string().nullable(),
  bairro: z.string().nullable(),
  telefone: z.string().nullable(),
  aniversario: z.iso.date().nullable(),
  oculto: z.boolean(),
});
export type ClienteResumo = z.infer<typeof esquemaClienteResumo>;

export const esquemaPaginaClientes = z.object({
  itens: z.array(esquemaClienteResumo),
  total: z.number().int(),
  pagina: z.number().int(),
  porPagina: z.number().int(),
});
export type PaginaClientes = z.infer<typeof esquemaPaginaClientes>;
