// T044: contrato de GET /api/clientes/{id}/pecas-compradas (FR-016, FR-017; data-model.md PecaComprada).
import { esquemaPecaComprada } from '@pepe/shared';
import { afterAll, beforeAll, describe, expect, it } from 'vitest';

import { type AppDeTeste, montarAppDeTeste } from '../apoio/app.js';

describe('GET /api/clientes/{id}/pecas-compradas', () => {
  let t: AppDeTeste;
  let cookie: string;

  beforeAll(async () => {
    t = await montarAppDeTeste();
    cookie = await t.entrarComo('clientes.pecas');
  });

  afterAll(async () => {
    await t.fechar();
  });

  const pedir = (id: string, comSessao = true) =>
    t.app.inject({
      method: 'GET',
      url: `/api/clientes/${id}/pecas-compradas`,
      headers: comSessao ? { cookie } : {},
    });

  it('as peças do cliente, da venda mais recente para a mais antiga, só com os campos do contrato', async () => {
    const resposta = await pedir('8');
    expect(resposta.statusCode).toBe(200);
    const corpo = resposta.json() as Record<string, unknown>[];
    expect(esquemaPecaComprada.array().parse(corpo)).toEqual([
      {
        dataVenda: '2026-02-20T00:00:00',
        numeroVenda: '0002/26',
        classe: 'BR',
        modelo: '2002',
        descricao: 'Brinco argola em prata',
        observacoes: null,
      },
      {
        dataVenda: '2026-02-20T00:00:00',
        numeroVenda: '0002/26',
        classe: 'PEN',
        modelo: '3003',
        descricao: 'Pingente gota com ametista',
        observacoes: 'Corrente 45 cm',
      },
      {
        dataVenda: '2026-01-10T00:00:00',
        numeroVenda: '0001/26',
        classe: 'AN',
        modelo: '1001',
        descricao: 'Anel solitário em ouro 18k',
        observacoes: 'Aro 22',
      },
    ]);
    // FR-017: nada de custo, preço nem comissão
    for (const peca of corpo) {
      expect(Object.keys(peca).sort()).toEqual(
        ['classe', 'dataVenda', 'descricao', 'modelo', 'numeroVenda', 'observacoes'].sort(),
      );
    }
    expect(JSON.stringify(corpo)).not.toMatch(/1500|400|500|custo|pre[cç]o|comiss/i);
  });

  it('cliente sem compras → lista vazia', async () => {
    const resposta = await pedir('9');
    expect(resposta.statusCode).toBe(200);
    expect(resposta.json()).toEqual([]);
  });

  it('inexistente (inclusive o da venda órfã) ou sem nome → 404; id inválido → 400; sem sessão → 401', async () => {
    for (const id of ['9999', '3']) {
      const resposta = await pedir(id);
      expect(resposta.statusCode, id).toBe(404);
      expect(resposta.json()).toEqual({ mensagem: 'Cliente não encontrado.' });
    }
    expect((await pedir('x')).statusCode).toBe(400);
    expect((await pedir('8', false)).statusCode).toBe(401);
  });
});
