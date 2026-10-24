import { defineConfig, devices } from '@playwright/test';

// E2E das histórias da spec 001, contra a API de teste (banco sintético).
// PEPE_WEB_URL aponta para a API que serve a SPA compilada; o certificado local é aceito.
export default defineConfig({
  testDir: './tests/e2e',
  fullyParallel: false,
  retries: 0,
  reporter: [['list'], ['html', { open: 'never' }]],
  use: {
    baseURL: process.env.PEPE_WEB_URL ?? 'https://localhost:3000',
    ignoreHTTPSErrors: true,
    locale: 'pt-BR',
    timezoneId: 'America/Sao_Paulo',
    trace: 'retain-on-failure',
  },
  projects: [{ name: 'chromium', use: { ...devices['Desktop Chrome'] } }],
});
