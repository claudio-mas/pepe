// Consultas de clientes (research.md R5 e R6). Só leitura de dbo.Clientes, com parâmetros ligados (constituição
// IV.2) e só recursos do nível de compatibilidade 120 (nada de OPENJSON).
import { clienteOculto, type FiltroClientes, type PaginaClientes } from '@pepe/shared';
import { sql } from 'kysely';

import type { Banco } from '../db/kysely.js';

/** Coluna `date`/`datetime2` lida em UTC (useUTC) → `YYYY-MM-DD`, sem deslocar o dia. */
export function dataIso(data: Date | null): string | null {
  return data ? data.toISOString().slice(0, 10) : null;
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
