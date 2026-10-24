// Esquemas dos relatórios, iguais a specs/001-consulta-clientes/contracts/openapi.yaml.
import { z } from 'zod';

/** Parâmetros do relatório "Clientes cadastrados": as duas datas, ou nenhuma ("sem período"). */
export const esquemaFiltroClientesCadastrados = z
  .object({
    de: z.iso.date().optional(),
    ate: z.iso.date().optional(),
  })
  .refine((f) => (f.de === undefined) === (f.ate === undefined), { message: 'Informe as duas datas ou nenhuma.' })
  .refine((f) => !f.de || !f.ate || f.ate >= f.de, { message: 'A data final não pode ser anterior à inicial.' });
export type FiltroClientesCadastrados = z.infer<typeof esquemaFiltroClientesCadastrados>;

/** Linha do relatório (FR-019). Datas em `YYYY-MM-DD`. */
export const esquemaLinhaClientesCadastrados = z.object({
  nomeExibicao: z.string(),
  aniversario: z.iso.date().nullable(),
  endereco: z.string().nullable(),
  bairro: z.string().nullable(),
  telefone: z.string().nullable(),
  email: z.string().nullable(),
  dataCadastro: z.iso.date().nullable(),
});
export type LinhaClientesCadastrados = z.infer<typeof esquemaLinhaClientesCadastrados>;

export const esquemaRelatorioClientesCadastrados = z.object({
  de: z.iso.date().nullable(),
  ate: z.iso.date().nullable(),
  total: z.number().int(),
  /** Hora do servidor na emissão (ISO 8601, UTC). */
  emitidoEm: z.iso.datetime(),
  linhas: z.array(esquemaLinhaClientesCadastrados),
});
export type RelatorioClientesCadastrados = z.infer<typeof esquemaRelatorioClientesCadastrados>;
