// T057: o log do serviço nunca registra dado pessoal de cliente (SC-006; constituição V.3; research.md R9).
// Captura o log real (pino, nível info) durante pesquisas, aberturas de ficha, conta corrente, peças compradas e o
// relatório, e falha se aparecer o texto pesquisado, um nome, um telefone, um CPF, um endereço ou um e-mail do banco
// de teste (dados.sql).
import { Writable } from 'node:stream';

import { afterAll, beforeAll, describe, expect, it } from 'vitest';

import { type AppDeTeste, montarAppDeTeste } from '../apoio/app.js';

const PROIBIDOS = [
  // texto pesquisado (cru e codificado na URL)
  'jose araujo',
  'jose%20araujo',
  'jose+araujo',
  'beatriz',
  'carlos',
  '988880001',
  // dados do banco de teste
  'José Araújo',
  'Jos%C3%A9',
  'Araújo',
  'Beatriz Lima',
  'Carlos Oculto',
  'Gabriel Conta',
  'Eduardo Compras',
  '98888-0001',
  '(11)',
  '12345678909',
  '123.456.789-09',
  'Rua das Acácias',
  'jose@exemplo.test',
  'Anel solitário',
  '1980-05-17',
];

describe('log sem dado pessoal', () => {
  const linhas: string[] = [];
  let t: AppDeTeste;
  let cookie: string;

  beforeAll(async () => {
    const destino = new Writable({
      write(pedaco, _codificacao, pronto) {
        linhas.push(String(pedaco));
        pronto();
      },
    });
    t = await montarAppDeTeste({ logger: { level: 'info', stream: destino } });
    cookie = await t.entrarComo('log.privacidade');
  });

  afterAll(async () => {
    await t.fechar();
  });

  it('nenhuma pesquisa, ficha, conta corrente, peça ou relatório deixa dado de cliente no log', async () => {
    const urls = [
      '/api/clientes?busca=jose%20araujo',
      '/api/clientes?busca=jose+araujo&ocultos=true',
      '/api/clientes?busca=Beatriz',
      '/api/clientes?busca=carlos&ocultos=true',
      '/api/clientes?busca=988880001',
      '/api/clientes?busca=' + 'x'.repeat(101), // 400: a mensagem de validação também não pode vazar o texto
      '/api/clientes/1',
      '/api/clientes/2',
      '/api/clientes/4',
      '/api/clientes/10/conta-corrente',
      '/api/clientes/8/pecas-compradas',
      '/api/clientes/9999',
      '/api/relatorios/clientes-cadastrados?de=2026-03-01&ate=2026-03-31',
      '/api/relatorios/clientes-cadastrados',
    ];
    for (const url of urls) {
      const resposta = await t.app.inject({ method: 'GET', url, headers: { cookie } });
      expect(resposta.statusCode, url).toBeLessThan(500);
    }
    // Pesquisa sem sessão (401) também passa pelo log
    await t.app.inject({ method: 'GET', url: '/api/clientes?busca=jose%20araujo' });

    const log = linhas.join('');
    // O log existe e registra as requisições pelo padrão da rota
    expect(log).toContain('"rota":"/api/clientes"');
    expect(log).toContain('"rota":"/api/clientes/:id"');
    expect(log).toContain('"rota":"/api/clientes/:id/conta-corrente"');
    expect(log).toContain('"rota":"/api/relatorios/clientes-cadastrados"');
    for (const proibido of PROIBIDOS) {
      expect(log.toLowerCase(), `o log contém "${proibido}"`).not.toContain(proibido.toLowerCase());
    }
    // Nem a query string nem o id do cliente na URL
    expect(log).not.toMatch(/busca=|\/api\/clientes\/\d/);
  });
});
