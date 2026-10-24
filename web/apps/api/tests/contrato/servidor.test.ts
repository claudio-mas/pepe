// Base do servidor (T016): formato de erro do contrato e log sem URL nem query string (research.md R9).
import { Writable } from 'node:stream';

import { afterAll, beforeAll, describe, expect, inject, it } from 'vitest';

import { criarBanco } from '../../src/db/kysely.js';
import { construirApp } from '../../src/server.js';

describe('servidor', () => {
  const linhasDeLog: string[] = [];
  const banco = criarBanco(inject('bancoTeste'));
  let app: Awaited<ReturnType<typeof construirApp>>;

  beforeAll(async () => {
    const destino = new Writable({
      write(pedaco, _codificacao, pronto) {
        linhasDeLog.push(String(pedaco));
        pronto();
      },
    });
    app = await construirApp({ banco, diretorioSpa: '/nao/existe', logger: { level: 'info', stream: destino } });
  });

  afterAll(async () => {
    await app.close();
    await banco.destroy();
  });

  it('responde 404 com mensagem em português para rota inexistente da API', async () => {
    const resposta = await app.inject({ method: 'GET', url: '/api/nao-existe' });
    expect(resposta.statusCode).toBe(404);
    expect(resposta.json()).toEqual({ mensagem: 'Recurso não encontrado.' });
  });

  it('não registra a URL nem a query string no log', async () => {
    await app.inject({ method: 'GET', url: '/api/nao-existe?busca=Jos%C3%A9%20Ara%C3%BAjo' });
    const log = linhasDeLog.join('');
    expect(log).toContain('"metodo":"GET"');
    expect(log).not.toMatch(/busca|Jos|Ara%C3%BAjo|Araújo|nao-existe/);
  });

  it('conecta ao banco de teste como pepe_web', async () => {
    const { total } = await banco
      .selectFrom('Clientes')
      .select((eb) => eb.fn.countAll<number>().as('total'))
      .executeTakeFirstOrThrow();
    expect(total).toBeGreaterThan(120);
  });
});
