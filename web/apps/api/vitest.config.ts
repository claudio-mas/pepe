import { fileURLToPath } from 'node:url';
import { defineConfig } from 'vitest/config';

// Os testes de contrato (tests/contrato) rodam contra o banco de teste sintético (tarefas T009 a T012).
// Nada de banco real nos testes (constituição V.3).
export default defineConfig({
  resolve: {
    alias: {
      '@pepe/shared': fileURLToPath(new URL('../../packages/shared/src/index.ts', import.meta.url)),
    },
  },
  test: {
    environment: 'node',
    include: ['tests/**/*.test.ts'],
    // Sobe e prepara o banco de teste sintético uma vez por execução (tests/banco-teste/preparar.ts)
    globalSetup: ['tests/banco-teste/preparar.ts'],
    passWithNoTests: true,
    testTimeout: 30_000,
    hookTimeout: 120_000,
  },
});
