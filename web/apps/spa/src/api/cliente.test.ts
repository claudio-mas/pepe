// T026: cliente HTTP (fetch com cookie, respostas validadas, 401 leva à entrada) e política das consultas.
import { esquemaUsuarioConectado } from '@pepe/shared';
import { afterEach, beforeEach, describe, expect, it, vi } from 'vitest';

import { chamarApi, consumirRotaGuardada, ErroApi, MENSAGENS, ROTA_ENTRAR } from './cliente';
import { deveRepetir, mensagemDeErro } from './consulta';

const respostaJson = (status: number, corpo?: unknown) =>
  new Response(corpo === undefined ? null : JSON.stringify(corpo), {
    status,
    headers: { 'content-type': 'application/json' },
  });

let armazenado: Map<string, string>;
let fetchFalso: ReturnType<typeof vi.fn>;
let local: { pathname: string; search: string; hash: string; assign: ReturnType<typeof vi.fn> };

beforeEach(() => {
  armazenado = new Map();
  fetchFalso = vi.fn();
  local = { pathname: '/clientes/12', search: '?aba=cc', hash: '', assign: vi.fn() };
  vi.stubGlobal('fetch', fetchFalso);
  vi.stubGlobal('window', { location: local });
  vi.stubGlobal('sessionStorage', {
    getItem: (k: string) => armazenado.get(k) ?? null,
    setItem: (k: string, v: string) => void armazenado.set(k, v),
    removeItem: (k: string) => void armazenado.delete(k),
  });
});

afterEach(() => {
  vi.unstubAllGlobals();
});

const erroDe = (promessa: Promise<unknown>) =>
  promessa.then(() => expect.fail('deveria falhar')).catch((e) => e as ErroApi);

describe('chamarApi', () => {
  it('chama /api com o cookie e devolve a resposta validada', async () => {
    fetchFalso.mockResolvedValue(respostaJson(200, { login: 'ana', nome: 'Ana' }));
    const usuario = await chamarApi('/sessao', { esquema: esquemaUsuarioConectado });
    expect(usuario).toEqual({ login: 'ana', nome: 'Ana' });
    const [url, init] = fetchFalso.mock.calls[0] as [string, RequestInit];
    expect(url).toBe('/api/sessao');
    expect(init.credentials).toBe('include');
    expect(init.method).toBe('GET');
  });

  it('manda o corpo em JSON', async () => {
    fetchFalso.mockResolvedValue(respostaJson(204));
    await chamarApi('/sessao', { metodo: 'POST', corpo: { login: 'ana', senha: 'x' } });
    const init = fetchFalso.mock.calls[0]![1] as RequestInit;
    expect(init.body).toBe('{"login":"ana","senha":"x"}');
    expect((init.headers as Record<string, string>)['content-type']).toBe('application/json');
  });

  it('resposta fora do contrato vira erro, nunca dado errado na tela', async () => {
    fetchFalso.mockResolvedValue(respostaJson(200, { login: 'ana' }));
    const erro = await erroDe(chamarApi('/sessao', { esquema: esquemaUsuarioConectado }));
    expect(erro).toBeInstanceOf(ErroApi);
    expect(erro.message).toBe(MENSAGENS.respostaInesperada);
  });

  it('usa a mensagem da API no erro', async () => {
    fetchFalso.mockResolvedValue(respostaJson(404, { mensagem: 'Cliente não encontrado.' }));
    const erro = await erroDe(chamarApi('/clientes/9'));
    expect(erro.status).toBe(404);
    expect(erro.message).toBe('Cliente não encontrado.');
  });

  it('sem corpo de erro, usa a mensagem padrão do status (banco fora do ar)', async () => {
    fetchFalso.mockResolvedValue(new Response('<html>', { status: 503 }));
    const erro = await erroDe(chamarApi('/clientes'));
    expect(erro.status).toBe(503);
    expect(erro.message).toBe(MENSAGENS.bancoIndisponivel);
  });

  it('servidor que não responde → status 0 e mensagem de conexão', async () => {
    fetchFalso.mockRejectedValue(new TypeError('Failed to fetch'));
    const erro = await erroDe(chamarApi('/clientes'));
    expect(erro.status).toBe(0);
    expect(erro.message).toBe(MENSAGENS.semConexao);
  });

  it('consulta cancelada não vira erro de conexão', async () => {
    fetchFalso.mockRejectedValue(new DOMException('cancelada', 'AbortError'));
    await expect(chamarApi('/clientes')).rejects.toMatchObject({ name: 'AbortError' });
  });

  it('401 guarda a rota atual e vai para a entrada', async () => {
    fetchFalso.mockResolvedValue(respostaJson(401, { mensagem: 'Sua sessão expirou. Entre de novo.' }));
    const erro = await erroDe(chamarApi('/clientes/12'));
    expect(erro.status).toBe(401);
    expect(local.assign).toHaveBeenCalledWith(ROTA_ENTRAR);
    expect(consumirRotaGuardada()).toBe('/clientes/12?aba=cc');
    expect(consumirRotaGuardada()).toBe('/'); // só vale uma vez
  });

  it('401 na própria entrada não redireciona', async () => {
    fetchFalso.mockResolvedValue(respostaJson(401, { mensagem: 'Usuário ou senha inválidos.' }));
    const erro = await erroDe(
      chamarApi('/sessao', { metodo: 'POST', corpo: { login: 'a', senha: 'b' }, redirecionarSemSessao: false }),
    );
    expect(erro.message).toBe('Usuário ou senha inválidos.');
    expect(local.assign).not.toHaveBeenCalled();
  });

  it('já na entrada, 401 não guarda rota nem recarrega', async () => {
    local.pathname = ROTA_ENTRAR;
    fetchFalso.mockResolvedValue(respostaJson(401, { mensagem: 'Entre para continuar.' }));
    await erroDe(chamarApi('/sessao'));
    expect(local.assign).not.toHaveBeenCalled();
    expect(armazenado.size).toBe(0);
  });
});

describe('consumirRotaGuardada', () => {
  it('só aceita rota interna da SPA', () => {
    for (const rota of ['//outro.site/x', 'https://outro.site', '/\\outro.site', '/entrar']) {
      armazenado.set('pepe.rotaAposEntrar', rota);
      expect(consumirRotaGuardada()).toBe('/');
    }
  });
});

describe('consultas', () => {
  it('repete só falha de conexão ou do servidor, no máximo duas vezes', () => {
    expect(deveRepetir(0, new ErroApi(0, ''))).toBe(true);
    expect(deveRepetir(1, new ErroApi(503, ''))).toBe(true);
    expect(deveRepetir(2, new ErroApi(503, ''))).toBe(false);
    expect(deveRepetir(0, new ErroApi(401, ''))).toBe(false);
    expect(deveRepetir(0, new ErroApi(404, ''))).toBe(false);
    expect(deveRepetir(0, new Error('outro'))).toBe(false);
  });

  it('sempre tem uma mensagem em português para mostrar', () => {
    expect(mensagemDeErro(new ErroApi(503, MENSAGENS.bancoIndisponivel))).toBe(MENSAGENS.bancoIndisponivel);
    expect(mensagemDeErro(new Error('TypeError: x is undefined'))).toBe(MENSAGENS.erroInterno);
  });
});
