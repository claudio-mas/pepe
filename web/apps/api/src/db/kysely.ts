// Conexão com o SQL Server (research.md R3): Kysely + tedious, pool pequeno porque o SQL Server Express
// da loja é dividido com o desktop e com o terceiro sistema (plan.md, Constraints).
import { Kysely, MssqlDialect } from 'kysely';
import * as Tarn from 'tarn';
import * as Tedious from 'tedious';

import type { ConfigBanco } from '../config.js';
import type { DB } from './tipos.js';

export type Banco = Kysely<DB>;

export const POOL_MAXIMO = 5;

export function opcoesTedious(config: ConfigBanco): Tedious.ConnectionConfiguration {
  return {
    server: config.servidor,
    authentication: { type: 'default', options: { userName: config.usuario, password: config.senha } },
    options: {
      database: config.banco,
      ...(config.instancia ? { instanceName: config.instancia } : { port: config.porta ?? 1433 }),
      encrypt: config.criptografar,
      trustServerCertificate: config.confiarCertificado,
      // Datas do legado não têm fuso: lidas como UTC, o "relógio" gravado chega igual (ex.: DataCad 2026-03-10).
      useUTC: true,
      connectTimeout: 15_000,
      requestTimeout: 30_000,
      appName: 'pepe-web',
    },
  };
}

export function criarBanco(config: ConfigBanco): Banco {
  return new Kysely<DB>({
    dialect: new MssqlDialect({
      tarn: { ...Tarn, options: { min: 0, max: POOL_MAXIMO } },
      tedious: {
        ...Tedious,
        connectionFactory: () => new Tedious.Connection(opcoesTedious(config)),
      },
    }),
  });
}
