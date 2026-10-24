// Relatório "Clientes cadastrados" (FR-018 a FR-021), com a mesma lógica do desktop
// (Pepe/Relatorios/ClientesCadastradosRpt: RN-CLI-012). As duas consultas do desktop:
//   sem período: WHERE ISNULL(Nome, Cliente) IS NOT NULL
//   com período: ... AND DataCad BETWEEN @dt1 AND @dt2   (as duas datas inclusive; DataCad é `date`)
// Sem filtro de Oculto: os ocultos entram, para os números baterem com o desktop (FR-021). O desktop ordena na tela
// pelo nome; aqui a ordem é a mesma da lista de clientes (sem diferenciar acento).
import type { FiltroClientesCadastrados, LinhaClientesCadastrados, RelatorioClientesCadastrados } from '@pepe/shared';
import { sql } from 'kysely';

import { dataIso } from '../clientes/consultas.js';
import type { Banco } from '../db/kysely.js';

export async function linhasClientesCadastrados(
  banco: Banco,
  filtro: FiltroClientesCadastrados,
): Promise<LinhaClientesCadastrados[]> {
  let consulta = banco
    .selectFrom('Clientes')
    .select([
      sql<string>`ISNULL(Nome, Cliente)`.as('nomeExibicao'),
      'Aniv',
      'Endereço',
      'Bairro',
      'Telefone',
      'Email',
      'DataCad',
    ])
    .where(sql<boolean>`ISNULL(Nome, Cliente) IS NOT NULL`);
  if (filtro.de && filtro.ate) {
    consulta = consulta.where(sql<boolean>`DataCad BETWEEN CAST(${filtro.de} AS date) AND CAST(${filtro.ate} AS date)`);
  }
  const linhas = await consulta
    .orderBy(sql`ISNULL(Nome, Cliente) COLLATE Latin1_General_CI_AI`)
    .orderBy('IDCliente')
    .execute();
  return linhas.map((l) => ({
    nomeExibicao: l.nomeExibicao,
    aniversario: dataIso(l.Aniv),
    endereco: l.Endereço,
    bairro: l.Bairro,
    telefone: l.Telefone,
    email: l.Email,
    dataCadastro: dataIso(l.DataCad),
  }));
}

export async function relatorioClientesCadastrados(
  banco: Banco,
  filtro: FiltroClientesCadastrados,
): Promise<RelatorioClientesCadastrados> {
  const linhas = await linhasClientesCadastrados(banco, filtro);
  return {
    de: filtro.de ?? null,
    ate: filtro.ate ?? null,
    total: linhas.length,
    emitidoEm: new Date().toISOString(),
    linhas,
  };
}
