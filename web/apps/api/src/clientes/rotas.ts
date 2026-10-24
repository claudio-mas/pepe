// GET /api/clientes (contracts/openapi.yaml; FR-007 a FR-012). A sessão é exigida pelo hook exigir-sessao.
import { esquemaFiltroClientes, type PaginaClientes } from '@pepe/shared';
import type { FastifyInstance } from 'fastify';

import { ErroHttp } from '../erros.js';
import { listarClientes } from './consultas.js';

export async function rotasClientes(app: FastifyInstance): Promise<void> {
  app.get('/clientes', async (request): Promise<PaginaClientes> => {
    const filtro = esquemaFiltroClientes.safeParse(request.query);
    if (!filtro.success) throw new ErroHttp(400, 'Parâmetro inválido.');
    return listarClientes(app.banco, filtro.data);
  });
}
