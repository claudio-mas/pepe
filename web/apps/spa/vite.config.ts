import { fileURLToPath } from 'node:url';
import { tanstackRouter } from '@tanstack/router-plugin/vite';
import react from '@vitejs/plugin-react';
import { defineConfig } from 'vite';

// Em desenvolvimento a SPA roda no Vite e encaminha /api para a API (HTTPS com certificado local).
// Em produção quem serve os arquivos de dist/ é a própria API (plan.md, R2).
export default defineConfig({
  plugins: [
    // O plugin do router precisa vir antes do plugin do React
    tanstackRouter({
      target: 'react',
      routesDirectory: './src/rotas',
      generatedRouteTree: './src/routeTree.gen.ts',
      autoCodeSplitting: true,
    }),
    react(),
  ],
  resolve: {
    alias: {
      // Usa o código-fonte dos esquemas, sem precisar compilar o pacote antes
      '@pepe/shared': fileURLToPath(new URL('../../packages/shared/src/index.ts', import.meta.url)),
    },
  },
  server: {
    proxy: {
      '/api': { target: process.env.PEPE_API_URL ?? 'https://localhost:3000', secure: false },
    },
  },
  build: {
    outDir: 'dist',
  },
});
