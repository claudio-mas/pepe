// Senhas com argon2id (research.md R7; constituição V.2). Os padrões do @node-rs/argon2 já são os da OWASP:
// argon2id, 19 MiB de memória, 2 passadas, 1 thread. O hash sai no formato PHC ($argon2id$...).
import { hash, verify } from '@node-rs/argon2';

export const TAMANHO_MINIMO_SENHA = 10;

export function gerarHashDeSenha(senha: string): Promise<string> {
  return hash(senha);
}

let hashFalso: Promise<string> | undefined;

/**
 * Confere a senha. Sem hash (login inexistente), compara contra um hash fixo mesmo assim, para a resposta
 * levar o mesmo tempo e não revelar quais logins existem.
 */
export async function verificarSenha(hashArmazenado: string | null | undefined, senha: string): Promise<boolean> {
  if (!hashArmazenado) {
    hashFalso ??= hash('senha-que-nao-existe-' + Math.random());
    await verify(await hashFalso, senha).catch(() => false);
    return false;
  }
  try {
    return await verify(hashArmazenado, senha);
  } catch {
    return false;
  }
}
