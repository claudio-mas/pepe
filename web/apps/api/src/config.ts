// Configuração do serviço, lida de um JSON FORA do repositório (research.md R14; constituição V.1).
// O caminho vem da variável de ambiente PEPE_WEB_CONFIG. Modelo: config.exemplo.json.
import { readFileSync } from 'node:fs';

import { z } from 'zod';

export const esquemaConfigBanco = z.object({
  /** Nome ou IP do servidor (ex.: PEPETORRAS-PC ou 127.0.0.1). */
  servidor: z.string().min(1),
  /** Instância nomeada (ex.: SQLEXPRESS). Sem instância, usa a porta. */
  instancia: z.string().min(1).optional(),
  porta: z.number().int().positive().optional(),
  banco: z.string().min(1),
  usuario: z.string().min(1),
  senha: z.string().min(1),
  criptografar: z.boolean().default(true),
  /** true só para servidor com certificado autoassinado (ex.: SQL Server Express da loja). */
  confiarCertificado: z.boolean().default(false),
});

export const esquemaConfig = z.object({
  porta: z.number().int().positive().default(3000),
  host: z.string().min(1).default('0.0.0.0'),
  /** Caminhos dos arquivos PEM do certificado e da chave (HTTPS obrigatório, constituição V.4). */
  https: z.object({
    certificado: z.string().min(1),
    chave: z.string().min(1),
  }),
  /** Pasta com a SPA compilada. Padrão: web/apps/spa/dist. */
  diretorioSpa: z.string().min(1).optional(),
  bancoDeDados: esquemaConfigBanco,
});

export type ConfigBanco = z.infer<typeof esquemaConfigBanco>;
export type Config = z.infer<typeof esquemaConfig>;

/**
 * Lê e valida a configuração. Em caso de erro, a mensagem cita só os campos com problema,
 * nunca os valores (que incluem a senha do banco).
 */
export function lerConfig(caminho = process.env.PEPE_WEB_CONFIG): Config {
  if (!caminho) {
    throw new Error('Defina PEPE_WEB_CONFIG com o caminho do arquivo de configuração (modelo: config.exemplo.json).');
  }
  let bruto: unknown;
  try {
    bruto = JSON.parse(readFileSync(caminho, 'utf8'));
  } catch (erro) {
    throw new Error(`Não foi possível ler a configuração em ${caminho}: ${(erro as Error).message}`, { cause: erro });
  }
  const resultado = esquemaConfig.safeParse(bruto);
  if (!resultado.success) {
    const campos = resultado.error.issues.map((i) => `${i.path.join('.') || '(raiz)'}: ${i.message}`);
    throw new Error(`Configuração inválida em ${caminho}:\n  ${campos.join('\n  ')}`);
  }
  return resultado.data;
}
