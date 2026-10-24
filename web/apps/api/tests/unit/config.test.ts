// Configuração do serviço (research.md R14): o bloco https só é exigido pelo servidor; nenhuma mensagem de erro
// mostra os valores (a senha do banco).
import { mkdtempSync, writeFileSync } from 'node:fs';
import { tmpdir } from 'node:os';
import { join } from 'node:path';

import { describe, expect, it } from 'vitest';

import { exigirHttps, lerConfig } from '../../src/config.js';

const SENHA = 'senha-que-nao-pode-vazar';
const banco = { servidor: '127.0.0.1', porta: 14330, banco: 'BDTorras', usuario: 'pepe_web', senha: SENHA };

function arquivo(conteudo: unknown): string {
  const caminho = join(mkdtempSync(join(tmpdir(), 'pepe-config-')), 'config.json');
  writeFileSync(caminho, JSON.stringify(conteudo));
  return caminho;
}

describe('lerConfig', () => {
  it('aceita configuração sem https (scripts que só leem o banco)', () => {
    const config = lerConfig(arquivo({ bancoDeDados: banco }));
    expect(config.https).toBeUndefined();
    expect(config.bancoDeDados.porta).toBe(14330);
  });

  it('o servidor exige o https, com mensagem clara', () => {
    const config = lerConfig(arquivo({ bancoDeDados: banco }));
    expect(() => exigirHttps(config)).toThrow(/só sobe com HTTPS/);
    const comHttps = lerConfig(arquivo({ bancoDeDados: banco, https: { certificado: 'c.pem', chave: 'k.pem' } }));
    expect(exigirHttps(comHttps)).toEqual({ certificado: 'c.pem', chave: 'k.pem' });
  });

  it('configuração inválida cita só os campos, nunca os valores', () => {
    const caminho = arquivo({ bancoDeDados: { ...banco, porta: 'x' } });
    expect(() => lerConfig(caminho)).toThrow(/bancoDeDados\.porta/);
    try {
      lerConfig(caminho);
    } catch (erro) {
      expect((erro as Error).message).not.toContain(SENHA);
    }
  });
});
