// T029: nome de exibição e filtro de oculto (docs/legado/10-clientes.md, RN-CLI-001, RN-CLI-002 e RN-CLI-018).
import { describe, expect, it } from 'vitest';

import { clienteOculto, nomeExibicao } from '../src/esquemas/clientes.js';

describe('nomeExibicao (RN-CLI-002)', () => {
  it('usa o Nome quando existe', () => {
    expect(nomeExibicao('José Araújo', 'Sr. José Araújo')).toBe('José Araújo');
  });

  it('sem Nome, usa o nome de mala direta', () => {
    expect(nomeExibicao(null, 'Sra. Beatriz Lima')).toBe('Sra. Beatriz Lima');
  });

  it('sem os dois, não tem nome de exibição e o cliente fica fora (RN-CLI-001)', () => {
    expect(nomeExibicao(null, null)).toBeNull();
  });
});

describe('clienteOculto (RN-CLI-018)', () => {
  it('só Oculto = 1 esconde o cliente; nulo conta como visível', () => {
    expect(clienteOculto(true)).toBe(true);
    expect(clienteOculto(false)).toBe(false);
    expect(clienteOculto(null)).toBe(false);
  });
});
