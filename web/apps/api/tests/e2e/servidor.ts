// Servidor dos testes E2E (Playwright, webServer): recria o banco de teste sintético, cria o usuário E2E e serve a
// API e a SPA compilada (apps/spa/dist) por HTTP em localhost. O Chromium aceita cookie Secure em localhost.
// Uso: pnpm --filter @pepe/api exec tsx tests/e2e/servidor.ts (o Playwright faz isso sozinho).
import { fileURLToPath } from 'node:url';

import { criarUsuario } from '../../src/auth/usuarios.js';
import { criarBanco } from '../../src/db/kysely.js';
import { construirApp } from '../../src/server.js';
import { prepararBancoTeste } from '../banco-teste/preparar.js';
import { PORTA_E2E, USUARIO_E2E } from './credenciais.js';

const banco = criarBanco(await prepararBancoTeste());
await criarUsuario(banco, USUARIO_E2E);
const app = await construirApp({
  banco,
  diretorioSpa: fileURLToPath(new URL('../../../spa/dist/', import.meta.url)),
  logger: false,
});
app.addHook('onClose', async () => {
  await banco.destroy();
});
for (const sinal of ['SIGINT', 'SIGTERM'] as const) {
  process.once(sinal, () => void app.close().then(() => process.exit(0)));
}
await app.listen({ port: PORTA_E2E, host: '127.0.0.1' });
console.log(`Servidor E2E em http://localhost:${PORTA_E2E}`);
