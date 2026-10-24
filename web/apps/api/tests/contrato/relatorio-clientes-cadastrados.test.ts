// T050: contrato de GET /api/relatorios/clientes-cadastrados (FR-018 a FR-021; RN-CLI-012).
// Dados (tests/banco-teste/dados.sql): 124 clientes com nome de exibição, 1 deles oculto; com DataCad, o 1
// (2026-03-10), o 4, oculto (2026-03-15), e 23 do enchimento em abril/2026.
import { esquemaRelatorioClientesCadastrados } from '@pepe/shared';
import { afterAll, beforeAll, describe, expect, it } from 'vitest';

import { type AppDeTeste, montarAppDeTeste } from '../apoio/app.js';

describe('GET /api/relatorios/clientes-cadastrados', () => {
  let t: AppDeTeste;
  let cookie: string;

  beforeAll(async () => {
    t = await montarAppDeTeste();
    cookie = await t.entrarComo('relatorio.clientes');
  });

  afterAll(async () => {
    await t.fechar();
  });

  const pedir = (query = '', comSessao = true) =>
    t.app.inject({
      method: 'GET',
      url: `/api/relatorios/clientes-cadastrados${query ? `?${query}` : ''}`,
      headers: comSessao ? { cookie } : {},
    });
  const relatorio = async (query = '') => {
    const resposta = await pedir(query);
    expect(resposta.statusCode, query).toBe(200);
    return esquemaRelatorioClientesCadastrados.parse(resposta.json());
  };

  it('sem período: todos com nome de exibição, inclusive os ocultos (FR-021)', async () => {
    const r = await relatorio();
    expect(r).toMatchObject({ de: null, ate: null, total: 124 });
    expect(r.linhas).toHaveLength(124);
    const nomes = r.linhas.map((l) => l.nomeExibicao);
    expect(nomes).toContain('Carlos Oculto');
    expect(nomes).toContain('Sra. Beatriz Lima'); // só mala direta
    expect(nomes).toEqual([...nomes].sort(new Intl.Collator('pt-BR', { sensitivity: 'base' }).compare));
  });

  it('com período: DataCad entre as datas, as duas inclusive, com as colunas do relatório', async () => {
    const r = await relatorio('de=2026-03-10&ate=2026-03-15');
    expect(r).toMatchObject({ de: '2026-03-10', ate: '2026-03-15', total: 2 });
    expect(r.linhas).toEqual([
      {
        nomeExibicao: 'Carlos Oculto',
        aniversario: null,
        endereco: 'Rua Escondida, 4',
        bairro: 'Vila',
        telefone: '(13) 96666-0004',
        email: null,
        dataCadastro: '2026-03-15',
      },
      {
        nomeExibicao: 'José Araújo',
        aniversario: '1980-05-17',
        endereco: 'Rua das Acácias, 10',
        bairro: 'Jardim',
        telefone: '(11) 98888-0001',
        email: 'jose@exemplo.test',
        dataCadastro: '2026-03-10',
      },
    ]);
    expect((await relatorio('de=2026-03-11&ate=2026-03-15')).total).toBe(1);
    expect((await relatorio('de=2026-03-10&ate=2026-03-10')).total).toBe(1);
    expect((await relatorio('de=2026-04-01&ate=2026-04-30')).total).toBe(23);
    expect((await relatorio('de=2025-01-01&ate=2025-12-31')).total).toBe(0);
  });

  it('total igual ao número de linhas e emitidoEm com a hora do servidor', async () => {
    const antes = Date.now();
    const r = await relatorio('de=2026-04-01&ate=2026-04-30');
    expect(r.total).toBe(r.linhas.length);
    const emitido = Date.parse(r.emitidoEm);
    expect(emitido).toBeGreaterThanOrEqual(antes - 1000);
    expect(emitido).toBeLessThanOrEqual(Date.now() + 1000);
  });

  it('período incompleto, invertido ou com data inválida → 400', async () => {
    for (const query of [
      'de=2026-03-01',
      'ate=2026-03-31',
      'de=2026-03-31&ate=2026-03-01',
      'de=2026-02-30&ate=2026-03-01',
      'de=01/03/2026&ate=31/03/2026',
    ]) {
      const resposta = await pedir(query);
      expect(resposta.statusCode, query).toBe(400);
      expect(resposta.json()).toEqual({ mensagem: 'Parâmetro inválido.' });
    }
  });

  it('sem sessão → 401', async () => {
    expect((await pedir('', false)).statusCode).toBe(401);
  });
});
