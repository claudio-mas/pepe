// T019: contrato de POST/GET/DELETE /api/sessao (contracts/openapi.yaml; FR-001, FR-002, FR-025; research.md R7).
import { createHash } from 'node:crypto';

import { afterAll, beforeAll, describe, expect, it } from 'vitest';

import { criarUsuario, desativarUsuario } from '../../src/auth/usuarios.js';
import { type AppDeTeste, cookieDaResposta, montarAppDeTeste, SENHA_DE_TESTE } from '../apoio/app.js';

const MENSAGEM_RECUSA = 'Usuário ou senha inválidos.';

describe('POST/GET/DELETE /api/sessao', () => {
  let t: AppDeTeste;

  beforeAll(async () => {
    t = await montarAppDeTeste();
    await criarUsuario(t.banco, { login: 'sessao.ok', nome: 'Sessão OK', senha: SENHA_DE_TESTE });
    await criarUsuario(t.banco, { login: 'sessao.inativo', nome: 'Inativo', senha: SENHA_DE_TESTE });
    await desativarUsuario(t.banco, 'sessao.inativo');
    await criarUsuario(t.banco, { login: 'sessao.bloqueio', nome: 'Bloqueio', senha: SENHA_DE_TESTE });
  });

  afterAll(async () => {
    await t.fechar();
  });

  const entrar = (login: string, senha: string) =>
    t.app.inject({ method: 'POST', url: '/api/sessao', payload: { login, senha } });

  const eventos = async (login: string) =>
    (
      await t.banco
        .selectFrom('web.RegistroAcesso')
        .select('Evento')
        .where('Login', '=', login)
        .orderBy('IdRegistro')
        .execute()
    ).map((r) => r.Evento);

  it('guarda a senha como hash argon2id', async () => {
    const usuario = await t.banco
      .selectFrom('web.Usuario')
      .select('HashSenha')
      .where('Login', '=', 'sessao.ok')
      .executeTakeFirstOrThrow();
    expect(usuario.HashSenha).toMatch(/^\$argon2id\$/);
    expect(usuario.HashSenha).not.toContain(SENHA_DE_TESTE);
  });

  it('entrada correta devolve o usuário e um cookie HttpOnly, Secure e SameSite=Strict', async () => {
    const resposta = await entrar('Sessao.OK', SENHA_DE_TESTE); // login sem diferenciar maiúsculas
    expect(resposta.statusCode).toBe(200);
    expect(resposta.json()).toEqual({ login: 'sessao.ok', nome: 'Sessão OK' });
    const setCookie = String(resposta.headers['set-cookie']);
    expect(setCookie).toMatch(/^pepe_sessao=/);
    expect(setCookie).toMatch(/HttpOnly/i);
    expect(setCookie).toMatch(/Secure/i);
    expect(setCookie).toMatch(/SameSite=Strict/i);
    expect(await eventos('sessao.ok')).toContain('ENTRADA');
  });

  it('grava só o hash do identificador da sessão', async () => {
    const cookie = cookieDaResposta((await entrar('sessao.ok', SENHA_DE_TESTE)).headers['set-cookie']);
    const identificador = cookie.slice('pepe_sessao='.length);
    const pelaChaveCrua = await t.banco
      .selectFrom('web.Sessao')
      .select('IdSessao')
      .where('IdSessao', '=', identificador)
      .execute();
    const hash = createHash('sha256').update(identificador).digest('hex');
    const peloHash = await t.banco.selectFrom('web.Sessao').select('IdSessao').where('IdSessao', '=', hash).execute();
    expect(pelaChaveCrua).toHaveLength(0);
    expect(peloHash).toHaveLength(1);
  });

  it('usuário inexistente, senha errada e usuário inativo recebem a mesma recusa', async () => {
    const inexistente = await entrar('nao.existe', SENHA_DE_TESTE);
    const senhaErrada = await entrar('sessao.ok', 'senha-errada-000');
    const inativo = await entrar('sessao.inativo', SENHA_DE_TESTE);
    for (const resposta of [inexistente, senhaErrada, inativo]) {
      expect(resposta.statusCode).toBe(401);
      expect(resposta.json()).toEqual({ mensagem: MENSAGEM_RECUSA });
      expect(resposta.headers['set-cookie']).toBeUndefined();
    }
    expect(await eventos('nao.existe')).toEqual(['ENTRADA_RECUSADA']);
    expect(await eventos('sessao.inativo')).toEqual(['ENTRADA_RECUSADA']);
  });

  it('a 5ª senha errada seguida bloqueia, e nem a senha certa entra depois', async () => {
    for (let i = 0; i < 5; i++) expect((await entrar('sessao.bloqueio', 'errada-' + i)).statusCode).toBe(401);
    const comSenhaCerta = await entrar('sessao.bloqueio', SENHA_DE_TESTE);
    expect(comSenhaCerta.statusCode).toBe(401);
    expect(comSenhaCerta.json()).toEqual({ mensagem: MENSAGEM_RECUSA });
    const registros = await eventos('sessao.bloqueio');
    expect(registros.filter((e) => e === 'BLOQUEIO')).toHaveLength(1);
  });

  it('dados de entrada inválidos → 400', async () => {
    const resposta = await t.app.inject({ method: 'POST', url: '/api/sessao', payload: { login: '' } });
    expect(resposta.statusCode).toBe(400);
    expect(resposta.json()).toEqual({ mensagem: 'Parâmetro inválido.' });
  });

  it('GET sem cookie → 401; com cookie → usuário da sessão', async () => {
    const semCookie = await t.app.inject({ method: 'GET', url: '/api/sessao' });
    expect(semCookie.statusCode).toBe(401);
    expect(semCookie.json()).toHaveProperty('mensagem');

    const cookie = await t.entrarComo('sessao.ok');
    const comCookie = await t.app.inject({ method: 'GET', url: '/api/sessao', headers: { cookie } });
    expect(comCookie.statusCode).toBe(200);
    expect(comCookie.json()).toEqual({ login: 'sessao.ok', nome: 'Sessão OK' });
  });

  it('DELETE encerra a sessão, apaga o cookie e registra a saída', async () => {
    const cookie = await t.entrarComo('sessao.ok');
    const saida = await t.app.inject({ method: 'DELETE', url: '/api/sessao', headers: { cookie } });
    expect(saida.statusCode).toBe(204);
    expect(String(saida.headers['set-cookie'])).toMatch(/pepe_sessao=;/);
    const depois = await t.app.inject({ method: 'GET', url: '/api/sessao', headers: { cookie } });
    expect(depois.statusCode).toBe(401);
    expect(await eventos('sessao.ok')).toContain('SAIDA');
  });

  it('sessão parada há 30 minutos expira e é registrada', async () => {
    await criarUsuario(t.banco, { login: 'sessao.expira', nome: 'Expira', senha: SENHA_DE_TESTE });
    const cookie = await t.entrarComo('sessao.expira');
    const hash = createHash('sha256').update(cookie.slice('pepe_sessao='.length)).digest('hex');
    await t.banco
      .updateTable('web.Sessao')
      .set({ UltimoUso: new Date(Date.now() - 31 * 60_000) })
      .where('IdSessao', '=', hash)
      .execute();
    const resposta = await t.app.inject({ method: 'GET', url: '/api/sessao', headers: { cookie } });
    expect(resposta.statusCode).toBe(401);
    expect(await eventos('sessao.expira')).toContain('SESSAO_EXPIRADA');
  });

  it('usuário desativado perde a sessão aberta na próxima ação', async () => {
    await criarUsuario(t.banco, { login: 'sessao.desativa', nome: 'Desativa', senha: SENHA_DE_TESTE });
    const cookie = await t.entrarComo('sessao.desativa');
    await desativarUsuario(t.banco, 'sessao.desativa');
    const resposta = await t.app.inject({ method: 'GET', url: '/api/sessao', headers: { cookie } });
    expect(resposta.statusCode).toBe(401);
  });

  it('mais de 30 entradas por minuto do mesmo endereço → 429', async () => {
    const outro = await montarAppDeTeste(); // contador de tentativas próprio
    try {
      const tentar = () =>
        outro.app.inject({ method: 'POST', url: '/api/sessao', payload: { login: 'limite.x', senha: 'qualquer' } });
      for (let i = 0; i < 30; i++) expect((await tentar()).statusCode).toBe(401);
      const excedente = await tentar();
      expect(excedente.statusCode).toBe(429);
      expect(excedente.json()).toEqual({
        mensagem: 'Muitas tentativas de entrada. Aguarde um minuto e tente de novo.',
      });
    } finally {
      await outro.fechar();
    }
  });
});
