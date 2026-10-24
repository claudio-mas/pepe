// Rotas de relatórios (contracts/openapi.yaml). A sessão é exigida pelo hook exigir-sessao.
import { esquemaFiltroClientesCadastrados, type RelatorioClientesCadastrados } from '@pepe/shared';
import type { FastifyInstance } from 'fastify';

import { ErroHttp } from '../erros.js';
import { relatorioClientesCadastrados } from './clientes-cadastrados.js';

export async function rotasRelatorios(app: FastifyInstance): Promise<void> {
  app.get('/relatorios/clientes-cadastrados', async (request): Promise<RelatorioClientesCadastrados> => {
    const filtro = esquemaFiltroClientesCadastrados.safeParse(request.query);
    if (!filtro.success) throw new ErroHttp(400, 'Parâmetro inválido.');
    return relatorioClientesCadastrados(app.banco, filtro.data);
  });
}
