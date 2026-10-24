import { defineConfig, devices } from '@playwright/test';

import { PORTA_E2E } from '../api/tests/e2e/credenciais';

// E2E das histórias da spec 001. Sem PEPE_WEB_URL, o Playwright compila a SPA e sobe o servidor de teste
// (apps/api/tests/e2e/servidor.ts), que recria o banco sintético. PEPE_E2E_CHROMIUM aponta para um Chromium já
// instalado, quando o do Playwright não estiver (ex.: /opt/pw-browsers/chromium).
const urlExterna = process.env.PEPE_WEB_URL;
const executavel = process.env.PEPE_E2E_CHROMIUM;

export default defineConfig({
  testDir: './tests/e2e',
  fullyParallel: false,
  workers: 1,
  retries: 0,
  reporter: [['list'], ['html', { open: 'never' }]],
  use: {
    baseURL: urlExterna ?? `http://localhost:${PORTA_E2E}`,
    ignoreHTTPSErrors: true,
    locale: 'pt-BR',
    timezoneId: 'America/Sao_Paulo',
    trace: 'retain-on-failure',
    ...(executavel ? { launchOptions: { executablePath: executavel } } : {}),
  },
  projects: [{ name: 'chromium', use: { ...devices['Desktop Chrome'] } }],
  ...(urlExterna
    ? {}
    : {
        webServer: {
          command: 'pnpm --filter @pepe/spa build && pnpm --filter @pepe/api exec tsx tests/e2e/servidor.ts',
          url: `http://localhost:${PORTA_E2E}/entrar`,
          timeout: 180_000,
          reuseExistingServer: false,
          stdout: 'pipe',
        },
      }),
});
