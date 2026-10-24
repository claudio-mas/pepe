// T036: contrato de GET /api/clientes/{id} (contracts/openapi.yaml; FR-013; data-model.md ClienteFicha).
import { esquemaClienteFicha } from '@pepe/shared';
import { afterAll, beforeAll, describe, expect, it } from 'vitest';

import { type AppDeTeste, montarAppDeTeste } from '../apoio/app.js';

describe('GET /api/clientes/{id}', () => {
  let t: AppDeTeste;
  let cookie: string;

  beforeAll(async () => {
    t = await montarAppDeTeste();
    cookie = await t.entrarComo('clientes.ficha');
  });

  afterAll(async () => {
    await t.fechar();
  });

  const pedir = (id: string, comSessao = true) =>
    t.app.inject({ method: 'GET', url: `/api/clientes/${id}`, headers: comSessao ? { cookie } : {} });
  const ficha = async (id: number) => {
    const resposta = await pedir(String(id));
    expect(resposta.statusCode).toBe(200);
    return { bruto: resposta.json() as Record<string, unknown>, ficha: esquemaClienteFicha.parse(resposta.json()) };
  };

  it('devolve todos os campos da ficha, com o CPF em 11 dígitos e a versão em hexadecimal', async () => {
    const { ficha: f } = await ficha(1);
    expect(f).toEqual({
      id: 1,
      nomeExibicao: 'José Araújo',
      nome: 'José Araújo',
      titulo: 'Sr.',
      malaDireta: 'Sr. José Araújo',
      endereco: 'Rua das Acácias, 10',
      bairro: 'Jardim',
      cidade: 'São Paulo',
      uf: 'SP',
      cep: '01001-000',
      telefone: '(11) 98888-0001',
      email: 'jose@exemplo.test',
      cpf: '12345678909',
      aniversario: '1980-05-17',
      medidas: 'Aro 22',
      indicacao: 'Maria',
      dataCadastro: '2026-03-10',
      oculto: false,
      versao: expect.stringMatching(/^[0-9a-f]{16}$/),
    });
  });

  it('não expõe os campos sem uso (RN-CLI-022)', async () => {
    const { bruto } = await ficha(1);
    for (const campo of ['Fax', 'fax', 'CPF_MD', 'cpfMd', 'Saldo', 'saldo', 'Imp', 'imp', 'NaoZerarCC', 'naoZerarCC']) {
      expect(bruto).not.toHaveProperty(campo);
    }
  });

  it('cliente só com mala direta: nome nulo e nome de exibição da mala direta; sem DataCad → null', async () => {
    const { ficha: f } = await ficha(2);
    expect(f).toMatchObject({ nome: null, nomeExibicao: 'Sra. Beatriz Lima', dataCadastro: null, cpf: null });
  });

  it('cliente oculto abre com oculto: true', async () => {
    const { ficha: f } = await ficha(4);
    expect(f).toMatchObject({ id: 4, oculto: true, dataCadastro: '2026-03-15' });
  });

  it('inexistente ou sem nome nem mala direta → 404', async () => {
    for (const id of ['9999', '3']) {
      const resposta = await pedir(id);
      expect(resposta.statusCode, id).toBe(404);
      expect(resposta.json()).toEqual({ mensagem: 'Cliente não encontrado.' });
    }
  });

  it('id inválido → 400; sem sessão → 401', async () => {
    for (const id of ['0', '-1', 'abc', '1.5', '99999999999']) expect((await pedir(id)).statusCode, id).toBe(400);
    expect((await pedir('1', false)).statusCode).toBe(401);
  });
});
