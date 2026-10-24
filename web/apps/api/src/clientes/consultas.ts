// Consultas de clientes (research.md R5 e R6). Só leitura de dbo.Clientes, com parâmetros ligados (constituição
// IV.2) e só recursos do nível de compatibilidade 120 (nada de OPENJSON).
import {
  type ClienteFicha,
  clienteOculto,
  type FiltroClientes,
  type LancamentoCC,
  nomeExibicao,
  type PaginaClientes,
} from '@pepe/shared';
import { sql } from 'kysely';

import type { Banco } from '../db/kysely.js';

/** Coluna `date`/`datetime2` lida em UTC (useUTC) → `YYYY-MM-DD`, sem deslocar o dia. */
export function dataIso(data: Date | null): string | null {
  return data ? data.toISOString().slice(0, 10) : null;
}

/** Coluna `datetime`/`datetime2` sem fuso (lida em UTC) → `YYYY-MM-DDTHH:mm:ss`, o relógio gravado. */
export function dataHoraLocal(data: Date | null): string | null {
  return data ? data.toISOString().slice(0, 19) : null;
}

/** Escapa os curingas do LIKE (`%`, `_` e `[`), para o texto digitado ser procurado ao pé da letra. */
export function escaparLike(texto: string): string {
  return texto.replace(/[[%_]/g, '[$&]');
}

/** O telefone é comparado sem parênteses, espaços e hífen: "988880001" acha "(11) 98888-0001". */
export function semPontuacaoDeTelefone(texto: string): string {
  return texto.replace(/[() -]/g, '');
}

const telefoneSemPontuacao = sql`REPLACE(REPLACE(REPLACE(REPLACE(Telefone, '(', ''), ')', ''), ' ', ''), '-', '')`;

const nomeDeExibicao = sql<string>`ISNULL(Nome, Cliente)`;

export async function listarClientes(banco: Banco, filtro: FiltroClientes): Promise<PaginaClientes> {
  // RN-CLI-001: sem Nome e sem mala direta, o cliente não aparece em lugar nenhum
  let consulta = banco.selectFrom('Clientes').where(sql<boolean>`ISNULL(Nome, Cliente) IS NOT NULL`);
  // RN-CLI-018: Oculto nulo conta como visível
  if (!filtro.ocultos) consulta = consulta.where(sql<boolean>`ISNULL(Oculto, 0) = 0`);
  if (filtro.busca) {
    // R5: a collation do banco diferencia acento; CI_AI só na expressão, sem alterar objeto nenhum
    const padrao = `%${escaparLike(filtro.busca)}%`;
    const telefone = semPontuacaoDeTelefone(filtro.busca);
    const padraoTelefone = telefone ? `%${escaparLike(telefone)}%` : padrao;
    consulta = consulta.where(
      sql<boolean>`(Nome COLLATE Latin1_General_CI_AI LIKE ${padrao}
        OR Cliente COLLATE Latin1_General_CI_AI LIKE ${padrao}
        OR ${telefoneSemPontuacao} COLLATE Latin1_General_CI_AI LIKE ${padraoTelefone})`,
    );
  }

  const [contagem, linhas] = await Promise.all([
    consulta.select(sql<number>`COUNT(*)`.as('total')).executeTakeFirstOrThrow(),
    consulta
      .select([
        'IDCliente',
        nomeDeExibicao.as('nomeExibicao'),
        'Título',
        'Cliente',
        'Endereço',
        'Bairro',
        'Telefone',
        'Aniv',
        'Oculto',
      ])
      .orderBy(sql`ISNULL(Nome, Cliente) COLLATE Latin1_General_CI_AI`)
      .orderBy('IDCliente')
      .offset((filtro.pagina - 1) * filtro.porPagina)
      .fetch(filtro.porPagina)
      .execute(),
  ]);

  return {
    itens: linhas.map((c) => ({
      id: c.IDCliente,
      nomeExibicao: c.nomeExibicao,
      titulo: c.Título,
      malaDireta: c.Cliente,
      endereco: c.Endereço,
      bairro: c.Bairro,
      telefone: c.Telefone,
      aniversario: dataIso(c.Aniv),
      oculto: clienteOculto(c.Oculto),
    })),
    total: contagem.total,
    pagina: filtro.pagina,
    porPagina: filtro.porPagina,
  };
}

/** Ficha do cliente (FR-013). `null` quando ele não existe ou não tem nome de exibição (RN-CLI-001). */
export async function obterFicha(banco: Banco, id: number): Promise<ClienteFicha | null> {
  const c = await banco
    .selectFrom('Clientes')
    .select([
      'IDCliente',
      'Nome',
      'Título',
      'Cliente',
      'Endereço',
      'Bairro',
      'Cidade',
      'Estado',
      'CEP',
      'Telefone',
      'Email',
      'CPF',
      'Aniv',
      'Medidas',
      'Indicaçao',
      'DataCad',
      'Oculto',
      'SSMA_TimeStamp',
    ])
    .where('IDCliente', '=', id)
    .executeTakeFirst();
  if (!c) return null;
  const nome = nomeExibicao(c.Nome, c.Cliente);
  if (nome === null) return null;
  return {
    id: c.IDCliente,
    nomeExibicao: nome,
    nome: c.Nome,
    titulo: c.Título,
    malaDireta: c.Cliente,
    endereco: c.Endereço,
    bairro: c.Bairro,
    cidade: c.Cidade,
    uf: c.Estado,
    cep: c.CEP,
    telefone: c.Telefone,
    email: c.Email,
    cpf: c.CPF,
    aniversario: dataIso(c.Aniv),
    medidas: c.Medidas,
    indicacao: c.Indicaçao,
    dataCadastro: dataIso(c.DataCad),
    oculto: clienteOculto(c.Oculto),
    // rowversion: 8 bytes, chegam como Buffer
    versao: Buffer.isBuffer(c.SSMA_TimeStamp) ? c.SSMA_TimeStamp.toString('hex') : '',
  };
}

/** O cliente aparece na web: existe e tem nome de exibição (RN-CLI-001). */
export async function clienteExiste(banco: Banco, id: number): Promise<boolean> {
  const linha = await banco
    .selectFrom('Clientes')
    .select('IDCliente')
    .where('IDCliente', '=', id)
    .where(sql<boolean>`ISNULL(Nome, Cliente) IS NOT NULL`)
    .executeTakeFirst();
  return linha !== undefined;
}

/**
 * Conta corrente do cliente (FR-014): a view dbo.CC, a mesma fonte da grade do desktop (dsCliente.CC), na ordem de
 * data e depois Ident (a ordem da forma dentro da origem).
 */
export async function listarContaCorrente(banco: Banco, id: number): Promise<LancamentoCC[]> {
  const linhas = await banco
    .selectFrom('CC')
    .select(['ID', 'Data', 'Op', 'Tp', 'VValor', 'Ident'])
    .where('CLIENTE', '=', id)
    .orderBy('Data')
    .orderBy('Ident')
    .execute();
  return linhas.map((l) => ({
    idOrigem: l.ID,
    data: dataHoraLocal(l.Data),
    operacao: l.Op,
    forma: l.Tp,
    valor: l.VValor,
  }));
}
