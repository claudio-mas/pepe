// Rotas de clientes (contracts/openapi.yaml): lista (FR-007 a FR-012), ficha (FR-013), conta corrente (FR-014)
// e peças compradas (FR-016).
// A sessão é exigida pelo hook exigir-sessao.
import {
  type ClienteFicha,
  esquemaFiltroClientes,
  esquemaIdCliente,
  type LancamentoCC,
  type PaginaClientes,
  type PecaComprada,
} from '@pepe/shared';
import type { FastifyInstance } from 'fastify';

import { ErroHttp } from '../erros.js';
import { clienteExiste, listarClientes, listarContaCorrente, listarPecasCompradas, obterFicha } from './consultas.js';

const NAO_ENCONTRADO = 'Cliente não encontrado.';

function idDaRota(params: unknown): number {
  const id = esquemaIdCliente.safeParse((params as { id?: unknown }).id);
  if (!id.success) throw new ErroHttp(400, 'Parâmetro inválido.');
  return id.data;
}

export async function rotasClientes(app: FastifyInstance): Promise<void> {
  app.get('/clientes', async (request): Promise<PaginaClientes> => {
    const filtro = esquemaFiltroClientes.safeParse(request.query);
    if (!filtro.success) throw new ErroHttp(400, 'Parâmetro inválido.');
    return listarClientes(app.banco, filtro.data);
  });

  app.get('/clientes/:id', async (request): Promise<ClienteFicha> => {
    const ficha = await obterFicha(app.banco, idDaRota(request.params));
    if (!ficha) throw new ErroHttp(404, NAO_ENCONTRADO);
    return ficha;
  });

  app.get('/clientes/:id/conta-corrente', async (request): Promise<LancamentoCC[]> => {
    const id = idDaRota(request.params);
    if (!(await clienteExiste(app.banco, id))) throw new ErroHttp(404, NAO_ENCONTRADO);
    return listarContaCorrente(app.banco, id);
  });

  app.get('/clientes/:id/pecas-compradas', async (request): Promise<PecaComprada[]> => {
    const id = idDaRota(request.params);
    if (!(await clienteExiste(app.banco, id))) throw new ErroHttp(404, NAO_ENCONTRADO);
    return listarPecasCompradas(app.banco, id);
  });
}
