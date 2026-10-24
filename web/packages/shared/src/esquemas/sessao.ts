// Esquemas da sessão (entrada e saída), iguais a specs/001-consulta-clientes/contracts/openapi.yaml.
import { z } from 'zod';

/** Erro devolvido pela API: só um texto para o usuário, em português, sem detalhe técnico. */
export const esquemaErro = z.object({
  mensagem: z.string(),
});
export type Erro = z.infer<typeof esquemaErro>;

/** Corpo de POST /api/sessao (FR-001). */
export const esquemaCredenciais = z.object({
  login: z.string().min(1).max(50),
  senha: z.string().min(1).max(200),
});
export type Credenciais = z.infer<typeof esquemaCredenciais>;

/** Usuário da sessão atual (FR-006). */
export const esquemaUsuarioConectado = z.object({
  login: z.string(),
  nome: z.string(),
});
export type UsuarioConectado = z.infer<typeof esquemaUsuarioConectado>;
