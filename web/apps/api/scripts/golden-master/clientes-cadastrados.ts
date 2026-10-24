// T056: golden master do relatório "Clientes cadastrados" (research.md R13; constituição III). Roda na CÓPIA REAL
// do BDTorras (contêiner Docker de desenvolvimento), com a conexão da configuração (PEPE_WEB_CONFIG).
//
// Para cada período ("sem período" e os dois meses de 2026 com mais cadastros, descobertos aqui), executa:
//   - a consulta do desktop, copiada literalmente de Pepe/Relatorios/ClientesCadastradosRpt (as duas: com e sem
//     período), com os parâmetros @dt1 e @dt2 do tipo do desktop (DateTime);
//   - a função da web (src/relatorios/clientes-cadastrados.ts);
// e compara a contagem e o conjunto de linhas, pelo SHA-256 de cada linha normalizada.
//
// O resultado (só contagens e hashes, nenhum dado de cliente: constituição V.3) vai para FORA do repositório:
//   pnpm --filter @pepe/api golden-master [--saida <pasta>]     (padrão: a pasta temporária do usuário)
// Termina com código 1 se houver qualquer diferença.
import { type LinhaClientesCadastrados } from '@pepe/shared';
import { sql } from 'kysely';

import { dataIso } from '../../src/clientes/consultas.js';
import { lerConfig } from '../../src/config.js';
import { type Banco, criarBanco } from '../../src/db/kysely.js';
import { linhasClientesCadastrados } from '../../src/relatorios/clientes-cadastrados.js';
import { diferenca, gravarResultado, hashDaLinha, pastaDeSaida } from './comum.js';

// Consultas do desktop, literais (ClientesCadastradosRpt.resx "CustomSqlQuery1.Sql" e Designer.vb "Query_1")
const DESKTOP_COM_PERIODO = `SELECT        ISNULL(Nome, Cliente) AS NomeCliente, Aniv, Endereço, Bairro, Telefone, Email, DataCad AS Data1Cad
FROM            dbo.Clientes
WHERE        (ISNULL(Nome, Cliente) IS NOT NULL) AND (DataCad BETWEEN @dt1 AND @dt2)`;
const DESKTOP_SEM_PERIODO = `SELECT        ISNULL(Nome, Cliente) AS NomeCliente, Aniv, Endereço, Bairro, Telefone, Email, DataCad AS Data1Cad
FROM            dbo.Clientes
WHERE        (ISNULL(Nome, Cliente) IS NOT NULL)`;

interface LinhaDesktop {
  NomeCliente: string;
  Aniv: Date | null;
  Endereço: string | null;
  Bairro: string | null;
  Telefone: string | null;
  Email: string | null;
  Data1Cad: Date | null;
}

interface Periodo {
  nome: string;
  de?: string;
  ate?: string;
}

// Linha normalizada: os mesmos campos, na mesma ordem, datas só com o dia (como os dois relatórios mostram)
const hashWeb = (l: LinhaClientesCadastrados) =>
  hashDaLinha([l.nomeExibicao, l.aniversario, l.endereco, l.bairro, l.telefone, l.email, l.dataCadastro]);
const hashDesktop = (l: LinhaDesktop) =>
  hashDaLinha([l.NomeCliente, dataIso(l.Aniv), l.Endereço, l.Bairro, l.Telefone, l.Email, dataIso(l.Data1Cad)]);

async function linhasDoDesktop(banco: Banco, periodo: Periodo): Promise<LinhaDesktop[]> {
  if (!periodo.de || !periodo.ate) {
    return (await sql<LinhaDesktop>`${sql.raw(DESKTOP_SEM_PERIODO)}`.execute(banco)).rows;
  }
  // O desktop passa DateTime (txtData1/txtData2.EditValue) nos parâmetros dt1 e dt2
  const consulta = sql<LinhaDesktop>`DECLARE @dt1 datetime = CAST(${periodo.de} AS date), @dt2 datetime = CAST(${periodo.ate} AS date);
${sql.raw(DESKTOP_COM_PERIODO)}`;
  return (await consulta.execute(banco)).rows;
}

/** Os dois meses de 2026 com mais cadastros (R13). */
async function mesesDeReferencia(banco: Banco): Promise<Periodo[]> {
  const meses = await sql<{ mes: number; total: number }>`
    SELECT TOP 2 MONTH(DataCad) AS mes, COUNT(*) AS total
    FROM dbo.Clientes
    WHERE YEAR(DataCad) = 2026 AND ISNULL(Nome, Cliente) IS NOT NULL
    GROUP BY MONTH(DataCad)
    ORDER BY COUNT(*) DESC, MONTH(DataCad)`.execute(banco);
  return meses.rows.map(({ mes }) => {
    const m = String(mes).padStart(2, '0');
    const ultimo = new Date(Date.UTC(2026, mes, 0)).getUTCDate();
    return { nome: `2026-${m}`, de: `2026-${m}-01`, ate: `2026-${m}-${ultimo}` };
  });
}

async function principal(): Promise<number> {
  const pastaSaida = pastaDeSaida();

  const banco = criarBanco(lerConfig().bancoDeDados);
  try {
    const periodos: Periodo[] = [{ nome: 'sem período' }, ...(await mesesDeReferencia(banco))];
    const resultados = [];
    for (const periodo of periodos) {
      const desktop = (await linhasDoDesktop(banco, periodo)).map(hashDesktop);
      const web = (await linhasClientesCadastrados(banco, { de: periodo.de, ate: periodo.ate })).map(hashWeb);
      const { soNoPrimeiro, soNoSegundo } = diferenca(desktop, web);
      const igual = desktop.length === web.length && soNoPrimeiro.length === 0 && soNoSegundo.length === 0;
      resultados.push({
        periodo: periodo.nome,
        de: periodo.de ?? null,
        ate: periodo.ate ?? null,
        totalDesktop: desktop.length,
        totalWeb: web.length,
        igual,
        soNoDesktop: soNoPrimeiro,
        soNaWeb: soNoSegundo,
      });
      console.log(
        `${igual ? 'OK     ' : 'DIFERE '} ${periodo.nome.padEnd(12)} desktop ${desktop.length}, web ${web.length}` +
          (igual ? '' : ` (só no desktop: ${soNoPrimeiro.length}, só na web: ${soNoSegundo.length})`),
      );
    }
    if (periodos.length < 3) console.log('Atenção: menos de dois meses de 2026 com cadastros na cópia.');

    const arquivo = gravarResultado(pastaSaida, 'clientes-cadastrados', {
      relatorio: 'clientes-cadastrados',
      emitidoEm: new Date(),
      resultados,
    });
    console.log(`Resultado em ${arquivo}`);
    return resultados.every((r) => r.igual) ? 0 : 1;
  } finally {
    await banco.destroy();
  }
}

principal()
  .then((codigo) => {
    process.exitCode = codigo;
  })
  .catch((erro: unknown) => {
    console.error(erro instanceof Error ? erro.message : erro);
    process.exitCode = 1;
  });
