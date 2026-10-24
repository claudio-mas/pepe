// Apoio dos scripts de golden master e paridade (research.md R13; quickstart.md §3): comparação de linhas por
// SHA-256 e gravação do resultado FORA do repositório, só com contagens, ids e hashes (constituição V.3).
import { createHash } from 'node:crypto';
import { mkdirSync, writeFileSync } from 'node:fs';
import { tmpdir } from 'node:os';
import { join } from 'node:path';

/** Hash de uma linha normalizada: os campos na mesma ordem, nulo como um símbolo próprio. */
export function hashDaLinha(campos: (string | number | boolean | null)[]): string {
  return createHash('sha256')
    .update(campos.map((c) => (c === null ? '␀' : String(c))).join('\u001f'))
    .digest('hex');
}

/** Diferença entre dois multiconjuntos de hashes: o que sobra em cada lado. */
export function diferenca(a: string[], b: string[]): { soNoPrimeiro: string[]; soNoSegundo: string[] } {
  const contagem = new Map<string, number>();
  for (const h of a) contagem.set(h, (contagem.get(h) ?? 0) + 1);
  const soNoSegundo: string[] = [];
  for (const h of b) {
    const n = contagem.get(h) ?? 0;
    if (n > 0) contagem.set(h, n - 1);
    else soNoSegundo.push(h);
  }
  const soNoPrimeiro = [...contagem].flatMap(([h, n]) => Array<string>(n).fill(h));
  return { soNoPrimeiro, soNoSegundo };
}

/** `--saida <pasta>`; padrão: a pasta temporária do usuário (fora do repositório). */
export function pastaDeSaida(argumentos = process.argv): string {
  const indice = argumentos.indexOf('--saida');
  if (indice < 0) return join(tmpdir(), 'pepe-golden-master');
  const pasta = argumentos[indice + 1];
  if (!pasta) throw new Error('Informe a pasta depois de --saida.');
  return pasta;
}

/** Grava o resultado em `<pasta>/<nome>-<data e hora>.json` e devolve o caminho. */
export function gravarResultado(pasta: string, nome: string, conteudo: unknown): string {
  mkdirSync(pasta, { recursive: true });
  const arquivo = join(pasta, `${nome}-${new Date().toISOString().replace(/[:.]/g, '-')}.json`);
  writeFileSync(arquivo, JSON.stringify(conteudo, null, 2));
  return arquivo;
}
