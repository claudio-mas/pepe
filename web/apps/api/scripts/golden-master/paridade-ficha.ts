// T058: paridade da ficha do cliente (SC-003; quickstart.md §3). Roda na CÓPIA REAL do BDTorras, com a conexão da
// configuração (PEPE_WEB_CONFIG).
//
// Sorteia 20 clientes com nome de exibição (7 com conta corrente, 7 com compras e o resto ao acaso, para cobrir as
// três partes) e compara, para cada um, o que o desktop lê com o que a API devolve:
//   - cadastro: a tabela dbo.Clientes (o TableAdapter do dsCliente lê a tabela inteira) × obterFicha;
//   - conta corrente: a consulta do dsCliente.CC, literal × listarContaCorrente;
//   - peças compradas: a consulta do dsCliente.Compras, literal (data, modelo e observação da peça) ×
//     listarPecasCompradas.
// A comparação é por SHA-256 de cada linha normalizada, como conjunto.
//
// O resultado (só ids, contagens e hashes, nenhum dado de cliente: constituição V.3) vai para FORA do repositório:
//   pnpm --filter @pepe/api paridade-ficha [--clientes 12,345] [--saida <pasta>]
// Termina com código 1 se houver qualquer diferença.
import { sql } from 'kysely';

import {
  dataHoraLocal,
  dataIso,
  listarContaCorrente,
  listarPecasCompradas,
  obterFicha,
} from '../../src/clientes/consultas.js';
import { lerConfig } from '../../src/config.js';
import { type Banco, criarBanco } from '../../src/db/kysely.js';
import { diferenca, gravarResultado, hashDaLinha, pastaDeSaida } from './comum.js';

// Consultas do desktop, literais (Pepe/Datasets/dsCliente.xsd: CCTableAdapter e ComprasTableAdapter)
const DESKTOP_CC = `SELECT        Id, Cliente, Data, VValor, Tp, Op, Ident
FROM            CC
WHERE        (Cliente = @IdCli)`;
const DESKTOP_COMPRAS = `SELECT        VENDAS.Id, VENDAS.IDCliente AS [ID Cliente], VENDAS.DataVenda AS Data, [1TabPeças].Modêlo AS Peça, [1TabPeças].Obs AS Medidas
FROM            Clientes INNER JOIN
                         VENDAS ON Clientes.IDCliente = VENDAS.IDCliente INNER JOIN
                         [VENDAS DET] ON VENDAS.Id = [VENDAS DET].Venda INNER JOIN
                         [1TabPeças] ON [VENDAS DET].Peça = [1TabPeças].IDPeça
WHERE        (VENDAS.IDCliente = @IdCliente);`;

interface ClienteDesktop {
  Nome: string | null;
  Título: string | null;
  Cliente: string | null;
  Endereço: string | null;
  Bairro: string | null;
  Cidade: string | null;
  Estado: string | null;
  CEP: string | null;
  Telefone: string | null;
  Email: string | null;
  CPF: string | null;
  Aniv: Date | null;
  Medidas: string | null;
  Indicaçao: string | null;
  DataCad: Date | null;
  Oculto: boolean | null;
}

interface Comparacao {
  desktop: number;
  web: number;
  igual: boolean;
  soNoDesktop: string[];
  soNaWeb: string[];
}

function comparar(desktop: string[], web: string[]): Comparacao {
  const { soNoPrimeiro, soNoSegundo } = diferenca(desktop, web);
  return {
    desktop: desktop.length,
    web: web.length,
    igual: desktop.length === web.length && soNoPrimeiro.length === 0 && soNoSegundo.length === 0,
    soNoDesktop: soNoPrimeiro,
    soNaWeb: soNoSegundo,
  };
}

/** 7 com conta corrente, 7 com compras e o resto ao acaso, até 20, sem repetir. */
async function sortearClientes(banco: Banco): Promise<number[]> {
  const sorteio = async (condicao: ReturnType<typeof sql>, quantos: number) =>
    (
      await sql<{ id: number }>`
        SELECT TOP (${quantos}) c.IDCliente AS id FROM dbo.Clientes c
        WHERE ISNULL(c.Nome, c.Cliente) IS NOT NULL AND ${condicao}
        ORDER BY NEWID()`.execute(banco)
    ).rows.map((r) => r.id);
  const ids = new Set<number>([
    ...(await sorteio(sql`EXISTS (SELECT 1 FROM dbo.CC WHERE CC.Cliente = c.IDCliente)`, 7)),
    ...(await sorteio(sql`EXISTS (SELECT 1 FROM dbo.VENDAS v WHERE v.IDCliente = c.IDCliente)`, 7)),
  ]);
  for (const id of await sorteio(sql`1 = 1`, 40)) {
    if (ids.size >= 20) break;
    ids.add(id);
  }
  return [...ids];
}

async function compararCliente(banco: Banco, id: number) {
  // Cadastro
  const linha = (
    await sql<ClienteDesktop>`DECLARE @IdCli int = ${id}; SELECT * FROM dbo.Clientes WHERE IDCliente = @IdCli`.execute(
      banco,
    )
  ).rows[0];
  const ficha = await obterFicha(banco, id);
  const cadastroDesktop = linha
    ? [
        hashDaLinha([
          linha.Nome ?? linha.Cliente,
          linha.Nome,
          linha.Título,
          linha.Cliente,
          linha.Endereço,
          linha.Bairro,
          linha.Cidade,
          linha.Estado,
          linha.CEP,
          linha.Telefone,
          linha.Email,
          linha.CPF,
          dataIso(linha.Aniv),
          linha.Medidas,
          linha.Indicaçao,
          dataIso(linha.DataCad),
          linha.Oculto === true,
        ]),
      ]
    : [];
  const cadastroWeb = ficha
    ? [
        hashDaLinha([
          ficha.nomeExibicao,
          ficha.nome,
          ficha.titulo,
          ficha.malaDireta,
          ficha.endereco,
          ficha.bairro,
          ficha.cidade,
          ficha.uf,
          ficha.cep,
          ficha.telefone,
          ficha.email,
          ficha.cpf,
          ficha.aniversario,
          ficha.medidas,
          ficha.indicacao,
          ficha.dataCadastro,
          ficha.oculto,
        ]),
      ]
    : [];

  // Conta corrente
  const ccDesktop = (
    await sql<{ Id: number; Data: Date | null; VValor: number | null; Tp: string; Op: string }>`
      DECLARE @IdCli int = ${id};
      ${sql.raw(DESKTOP_CC)}`.execute(banco)
  ).rows.map((l) => hashDaLinha([l.Id, dataHoraLocal(l.Data), l.Op, l.Tp, l.VValor]));
  const ccWeb = (await listarContaCorrente(banco, id)).map((l) =>
    hashDaLinha([l.idOrigem, l.data, l.operacao, l.forma, l.valor]),
  );

  // Peças compradas
  const pecasDesktop = (
    await sql<{ Data: Date | null; Peça: string | null; Medidas: string | null }>`
      DECLARE @IdCliente int = ${id};
      ${sql.raw(DESKTOP_COMPRAS)}`.execute(banco)
  ).rows.map((l) => hashDaLinha([dataHoraLocal(l.Data), l.Peça, l.Medidas]));
  const pecasWeb = (await listarPecasCompradas(banco, id)).map((p) =>
    hashDaLinha([p.dataVenda, p.modelo, p.observacoes]),
  );

  return {
    id,
    cadastro: comparar(cadastroDesktop, cadastroWeb),
    contaCorrente: comparar(ccDesktop, ccWeb),
    pecasCompradas: comparar(pecasDesktop, pecasWeb),
  };
}

async function principal(): Promise<number> {
  const pastaSaida = pastaDeSaida();
  const indice = process.argv.indexOf('--clientes');
  const escolhidos = indice > 0 ? (process.argv[indice + 1] ?? '').split(',').map(Number).filter(Number.isInteger) : [];

  const banco = criarBanco(lerConfig().bancoDeDados);
  try {
    const ids = escolhidos.length ? escolhidos : await sortearClientes(banco);
    const resultados = [];
    for (const id of ids) {
      const r = await compararCliente(banco, id);
      const partes = [r.cadastro, r.contaCorrente, r.pecasCompradas];
      const igual = partes.every((p) => p.igual);
      resultados.push({ ...r, igual });
      const parte = (nome: string, c: Comparacao) => `${nome} ${c.igual ? 'ok' : 'difere'} (${c.desktop}/${c.web})`;
      console.log(
        `${igual ? 'OK     ' : 'DIFERE '} cliente ${String(id).padStart(6)}  ` +
          [parte('cadastro', r.cadastro), parte('CC', r.contaCorrente), parte('peças', r.pecasCompradas)].join(', '),
      );
    }
    const arquivo = gravarResultado(pastaSaida, 'paridade-ficha', {
      verificacao: 'paridade-ficha',
      emitidoEm: new Date(),
      resultados,
    });
    const iguais = resultados.filter((r) => r.igual).length;
    console.log(`${iguais} de ${resultados.length} clientes sem diferença. Resultado em ${arquivo}`);
    return iguais === resultados.length ? 0 : 1;
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
