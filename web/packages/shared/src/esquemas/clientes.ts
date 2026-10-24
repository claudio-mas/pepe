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

/** Id de cliente na rota (`/clientes/{id}`): inteiro positivo que cabe num `int` do SQL Server. */
export const esquemaIdCliente = z.coerce.number().int().min(1).max(2_147_483_647);

/** Ficha (FR-013). Sem os campos sem uso: Fax, CPF_MD, Saldo, Imp, NaoZerarCC (RN-CLI-022). */
export const esquemaClienteFicha = esquemaClienteResumo.extend({
  /** O Nome como está gravado (o `nomeExibicao` cai para a mala direta quando ele é nulo). */
  nome: z.string().nullable(),
  cidade: z.string().nullable(),
  uf: z.string().nullable(),
  cep: z.string().nullable(),
  email: z.string().nullable(),
  /** 11 dígitos, sem formatação; a SPA formata. */
  cpf: z.string().nullable(),
  medidas: z.string().nullable(),
  indicacao: z.string().nullable(),
  dataCadastro: z.iso.date().nullable(),
  /** SSMA_TimeStamp em hexadecimal, para a edição futura. */
  versao: z.string(),
});
export type ClienteFicha = z.infer<typeof esquemaClienteFicha>;

/**
 * Lançamento de conta corrente (FR-014), da view dbo.CC. `data` é o relógio gravado, sem fuso
 * (`YYYY-MM-DDTHH:mm:ss`); débitos já vêm negativos da view.
 */
export const esquemaLancamentoCC = z.object({
  idOrigem: z.number().int(),
  data: z.iso.datetime({ local: true }).nullable(),
  operacao: z.string(),
  forma: z.string(),
  valor: z.number().nullable(),
});
export type LancamentoCC = z.infer<typeof esquemaLancamentoCC>;

/**
 * Peça comprada pelo cliente (FR-016). Sem custo, preço nem comissão (FR-017). `dataVenda` é o relógio gravado,
 * sem fuso; `observacoes` é o `Obs` da peça (o desktop rotula como "Medidas").
 */
export const esquemaPecaComprada = z.object({
  dataVenda: z.iso.datetime({ local: true }).nullable(),
  numeroVenda: z.string().nullable(),
  classe: z.string().nullable(),
  modelo: z.string().nullable(),
  descricao: z.string().nullable(),
  observacoes: z.string().nullable(),
});
export type PecaComprada = z.infer<typeof esquemaPecaComprada>;
