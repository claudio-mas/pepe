// T037: contrato de GET /api/clientes/{id}/conta-corrente (FR-014; data-model.md LancamentoCC; view dbo.CC).
import { esquemaLancamentoCC } from '@pepe/shared';
import { afterAll, beforeAll, describe, expect, it } from 'vitest';

import { type AppDeTeste, montarAppDeTeste } from '../apoio/app.js';

describe('GET /api/clientes/{id}/conta-corrente', () => {
  let t: AppDeTeste;
  let cookie: string;

  beforeAll(async () => {
    t = await montarAppDeTeste();
    cookie = await t.entrarComo('clientes.cc');
  });

  afterAll(async () => {
    await t.fechar();
  });

  const pedir = (id: string, comSessao = true) =>
    t.app.inject({
      method: 'GET',
      url: `/api/clientes/${id}/conta-corrente`,
      headers: comSessao ? { cookie } : {},
    });

  it('lançamentos das três origens, com forma e valor, débito negativo, na ordem de data e Ident', async () => {
    const resposta = await pedir('10');
    expect(resposta.statusCode).toBe(200);
    const lancamentos = esquemaLancamentoCC.array().parse(resposta.json());
    expect(lancamentos).toEqual([
      { idOrigem: 1, data: '2026-01-05T00:00:00', operacao: 'Conserto', forma: 'Cash', valor: 150 },
      { idOrigem: 4, data: '2026-02-01T00:00:00', operacao: 'Venda', forma: 'Cartão', valor: 500 },
      { idOrigem: 5, data: '2026-02-15T00:00:00', operacao: 'Venda', forma: 'Débito', valor: -200 },
      { idOrigem: 1, data: '2026-03-01T00:00:00', operacao: 'C/C', forma: 'Cash', valor: 300 },
    ]);
  });

  it('cliente sem lançamentos → lista vazia', async () => {
    const resposta = await pedir('9');
    expect(resposta.statusCode).toBe(200);
    expect(resposta.json()).toEqual([]);
  });

  it('lançamentos órfãos não pertencem a cliente nenhum: o id deles não existe → 404', async () => {
    for (const id of ['9999', '9998', '9997', '3']) {
      const resposta = await pedir(id);
      expect(resposta.statusCode, id).toBe(404);
      expect(resposta.json()).toEqual({ mensagem: 'Cliente não encontrado.' });
    }
  });

  it('id inválido → 400; sem sessão → 401', async () => {
    expect((await pedir('abc')).statusCode).toBe(400);
    expect((await pedir('10', false)).statusCode).toBe(401);
  });
});
