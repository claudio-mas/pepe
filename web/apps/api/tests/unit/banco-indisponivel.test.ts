// Classificação dos erros de banco fora do ar ou lento (resposta 503 da API).
import * as Tarn from 'tarn';
import * as Tedious from 'tedious';
import { describe, expect, it } from 'vitest';

import { bancoIndisponivel } from '../../src/db/indisponivel.js';

describe('bancoIndisponivel', () => {
  it('reconhece pool sem conexão, conexão perdida e consulta que passou do prazo', () => {
    expect(bancoIndisponivel(new Tarn.TimeoutError('sem conexão'))).toBe(true);
    expect(bancoIndisponivel(new Tedious.ConnectionError('recusada', 'ESOCKET'))).toBe(true);
    expect(bancoIndisponivel(new Tedious.RequestError('lenta', 'ETIMEOUT'))).toBe(true);
  });

  it('não confunde com erro de consulta nem com erro comum', () => {
    expect(bancoIndisponivel(new Tedious.RequestError('sintaxe', 'EREQUEST'))).toBe(false);
    expect(bancoIndisponivel(new Error('qualquer'))).toBe(false);
    expect(bancoIndisponivel(undefined)).toBe(false);
  });
});
