// T030: contrato de GET /api/clientes (contracts/openapi.yaml; FR-007 a FR-012; research.md R5).
// Dados em tests/banco-teste/dados.sql: 123 clientes visíveis (8 de casos + 115 de enchimento) e 1 oculto.
import { esquemaPaginaClientes } from '@pepe/shared';
import { afterAll, beforeAll, describe, expect, it } from 'vitest';

import { type AppDeTeste, montarAppDeTeste } from '../apoio/app.js';

const VISIVEIS = 123;

describe('GET /api/clientes', () => {
  let t: AppDeTeste;
  let cookie: string;

  beforeAll(async () => {
    t = await montarAppDeTeste();
    cookie = await t.entrarComo('clientes.lista');
  });

  afterAll(async () => {
    await t.fechar();
  });

  const listar = async (parametros: Record<string, string> = {}) => {
    const resposta = await t.app.inject({
      method: 'GET',
      url: '/api/clientes?' + new URLSearchParams(parametros).toString(),
      headers: { cookie },
    });
    expect(resposta.statusCode).toBe(200);
    return esquemaPaginaClientes.parse(resposta.json());
  };
  const ids = (pagina: { itens: { id: number }[] }) => pagina.itens.map((c) => c.id);

  it('pesquisa sem diferenciar acento nem maiúsculas: "jose araujo" acha "José Araújo"', async () => {
    const pagina = await listar({ busca: 'jose araujo' });
    expect(ids(pagina)).toEqual([1]);
    expect(pagina.itens[0]).toEqual({
      id: 1,
      nomeExibicao: 'José Araújo',
      titulo: 'Sr.',
      malaDireta: 'Sr. José Araújo',
      endereco: 'Rua das Acácias, 10',
      bairro: 'Jardim',
      telefone: '(11) 98888-0001',
      aniversario: '1980-05-17',
      oculto: false,
    });
  });

  it('pesquisa pelo telefone e pelo nome de mala direta', async () => {
    expect(ids(await listar({ busca: '98888-0001' }))).toEqual([1]);
    expect(ids(await listar({ busca: 'BEATRIZ' }))).toEqual([2]);
  });

  it('cliente só com mala direta aparece com o nome de mala direta', async () => {
    const [cliente] = (await listar({ busca: 'Beatriz' })).itens;
    expect(cliente).toMatchObject({ id: 2, nomeExibicao: 'Sra. Beatriz Lima', malaDireta: 'Sra. Beatriz Lima' });
  });

  it('cliente sem nome nem mala direta nunca aparece', async () => {
    expect(ids(await listar({ busca: '90000-0003', ocultos: 'true' }))).toEqual([]);
    const todos = await listar({ ocultos: 'true', porPagina: '100', pagina: '1' });
    expect(ids(todos)).not.toContain(3);
  });

  it('oculto só aparece com ocultos=true, marcado como oculto; Oculto nulo é visível', async () => {
    expect(ids(await listar({ busca: 'Carlos Oculto' }))).toEqual([]);
    const comOcultos = await listar({ busca: 'Carlos Oculto', ocultos: 'true' });
    expect(comOcultos.itens).toMatchObject([{ id: 4, oculto: true }]);
    expect((await listar({ busca: 'Daniela Nula' })).itens).toMatchObject([{ id: 5, oculto: false }]);
  });

  it('homônimos aparecem os dois, na ordem do id', async () => {
    expect(ids(await listar({ busca: 'ana souza' }))).toEqual([6, 7]);
  });

  it('ordena pelo nome de exibição, sem diferenciar acento', async () => {
    const { itens } = await listar({ porPagina: '100' });
    const nomes = itens.map((c) => c.nomeExibicao);
    const ordenados = [...nomes].sort(new Intl.Collator('pt-BR', { sensitivity: 'base' }).compare);
    expect(nomes).toEqual(ordenados);
  });

  it('pagina com total, pagina e porPagina', async () => {
    const primeira = await listar();
    expect(primeira).toMatchObject({ total: VISIVEIS, pagina: 1, porPagina: 50 });
    expect(primeira.itens).toHaveLength(50);
    const ultima = await listar({ pagina: '3' });
    expect(ultima.itens).toHaveLength(VISIVEIS - 100);
    const alem = await listar({ pagina: '4' });
    expect(alem).toMatchObject({ total: VISIVEIS, itens: [] });
    expect((await listar({ ocultos: 'true' })).total).toBe(VISIVEIS + 1);
    const vistos = new Set([...ids(primeira), ...ids(await listar({ pagina: '2' })), ...ids(ultima)]);
    expect(vistos.size).toBe(VISIVEIS);
  });

  it('caracteres curinga do LIKE são procurados ao pé da letra', async () => {
    for (const busca of ['%', '_', '[a-z]']) expect((await listar({ busca })).total).toBe(0);
  });

  it('parâmetros fora do contrato → 400', async () => {
    for (const query of ['porPagina=500', 'porPagina=5', 'pagina=0', 'pagina=x', `busca=${'a'.repeat(101)}`]) {
      const resposta = await t.app.inject({ method: 'GET', url: `/api/clientes?${query}`, headers: { cookie } });
      expect(resposta.statusCode, query).toBe(400);
      expect(resposta.json()).toEqual({ mensagem: 'Parâmetro inválido.' });
    }
  });

  it('sem sessão → 401', async () => {
    const resposta = await t.app.inject({ method: 'GET', url: '/api/clientes' });
    expect(resposta.statusCode).toBe(401);
  });
});
