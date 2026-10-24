// Cliente HTTP da SPA (research.md R4 e R7). Toda chamada vai para /api com o cookie de sessão, e a resposta é
// conferida com os esquemas de @pepe/shared: a tela nunca recebe um formato diferente do contrato.
// Sem sessão (401), guarda a rota atual e manda para a entrada; depois de entrar, a SPA volta para ela.
import { esquemaErro } from '@pepe/shared';

export const ROTA_ENTRAR = '/entrar';
const CHAVE_ROTA_GUARDADA = 'pepe.rotaAposEntrar';

export const MENSAGENS = {
  semConexao: 'Não foi possível falar com o servidor. Confira a rede da loja e tente de novo.',
  respostaInesperada:
    'O servidor mandou uma resposta inesperada. Tente de novo; se continuar, avise o responsável pelo sistema.',
  bancoIndisponivel: 'Não foi possível consultar o banco de dados agora. Tente de novo em instantes.',
  erroInterno: 'Erro interno. Tente de novo; se continuar, avise o responsável pelo sistema.',
} as const;

/** Erro de uma chamada à API, com a mensagem para o usuário. `status` 0 = o servidor não respondeu. */
export class ErroApi extends Error {
  constructor(
    readonly status: number,
    mensagem: string,
  ) {
    super(mensagem);
    this.name = 'ErroApi';
  }
}

/** O que a SPA usa de um esquema Zod (evita depender do zod direto). */
export interface Esquema<T> {
  safeParse(dado: unknown): { success: true; data: T } | { success: false };
}

export interface OpcoesChamada<T> {
  metodo?: 'GET' | 'POST' | 'DELETE';
  corpo?: unknown;
  /** Esquema da resposta de sucesso. Sem ele, o corpo é ignorado (ex.: 204). */
  esquema?: Esquema<T>;
  sinal?: AbortSignal;
  /** false na própria entrada, em que 401 quer dizer "usuário ou senha inválidos", não "sessão perdida". */
  redirecionarSemSessao?: boolean;
}

function mensagemPadrao(status: number): string {
  if (status === 401) return 'Entre para continuar.';
  if (status === 404) return 'Recurso não encontrado.';
  if (status === 429) return 'Muitas tentativas. Aguarde um minuto e tente de novo.';
  if (status === 503 || status === 504) return MENSAGENS.bancoIndisponivel;
  if (status >= 500) return MENSAGENS.erroInterno;
  return 'Requisição inválida.';
}

export async function chamarApi<T = void>(caminho: string, opcoes: OpcoesChamada<T> = {}): Promise<T> {
  let resposta: Response;
  try {
    resposta = await fetch(`/api${caminho}`, {
      method: opcoes.metodo ?? 'GET',
      credentials: 'include',
      headers: {
        accept: 'application/json',
        ...(opcoes.corpo !== undefined ? { 'content-type': 'application/json' } : {}),
      },
      ...(opcoes.corpo !== undefined ? { body: JSON.stringify(opcoes.corpo) } : {}),
      ...(opcoes.sinal ? { signal: opcoes.sinal } : {}),
    });
  } catch (erro) {
    // Consulta cancelada pelo TanStack Query: não é falha de rede
    if (erro instanceof DOMException && erro.name === 'AbortError') throw erro;
    throw new ErroApi(0, MENSAGENS.semConexao);
  }

  const dado: unknown = resposta.status === 204 ? undefined : await resposta.json().catch(() => undefined);

  if (!resposta.ok) {
    const erro = esquemaErro.safeParse(dado);
    const mensagem = erro.success ? erro.data.mensagem : mensagemPadrao(resposta.status);
    if (resposta.status === 401 && opcoes.redirecionarSemSessao !== false) irParaEntrada();
    throw new ErroApi(resposta.status, mensagem);
  }

  if (!opcoes.esquema) return undefined as T;
  const resultado = opcoes.esquema.safeParse(dado);
  if (!resultado.success) throw new ErroApi(resposta.status, MENSAGENS.respostaInesperada);
  return resultado.data;
}

/**
 * Guarda a rota atual e recarrega a SPA na entrada. A recarga é de propósito: descarta o cache das consultas,
 * para nenhum dado de cliente da sessão anterior ficar na memória da página.
 */
export function irParaEntrada(): void {
  const { pathname, search, hash } = window.location;
  if (pathname === ROTA_ENTRAR) return;
  try {
    sessionStorage.setItem(CHAVE_ROTA_GUARDADA, pathname + search + hash);
  } catch {
    // Sem armazenamento (navegação privada restrita): depois de entrar, vai para o início
  }
  window.location.assign(ROTA_ENTRAR);
}

/** Rota guardada antes da entrada (e a apaga). Só aceita caminho interno da SPA; o padrão é o início. */
export function consumirRotaGuardada(): string {
  let rota: string | null;
  try {
    rota = sessionStorage.getItem(CHAVE_ROTA_GUARDADA);
    sessionStorage.removeItem(CHAVE_ROTA_GUARDADA);
  } catch {
    return '/';
  }
  return rota !== null && rotaInterna(rota) && !rota.startsWith(ROTA_ENTRAR) ? rota : '/';
}

/** "/clientes/12" sim; "//outro.site" e "https://..." não (evita redirecionar para fora da SPA). */
function rotaInterna(rota: string): boolean {
  return rota.startsWith('/') && !rota.startsWith('//') && !rota.startsWith('/\\');
}
