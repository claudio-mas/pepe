import { fileURLToPath } from 'node:url';
import { defineConfig } from 'vitest/config';

// Os testes de contrato (tests/contrato) rodam contra o banco de teste sintético (tarefas T009 a T012),
// que entra como globalSetup quando existir. Nada de banco real nos testes (constituição V.3).
export default defineConfig({
  resolve: {
    alias: {
      '@pepe/shared': fileURLToPath(new URL('../../packages/shared/src/index.ts', import.meta.url)),
    },
  },
  test: {
    environment: 'node',
    include: ['tests/**/*.test.ts'],
    passWithNoTests: true,
    testTimeout: 30_000,
    hookTimeout: 120_000,
  },
});
