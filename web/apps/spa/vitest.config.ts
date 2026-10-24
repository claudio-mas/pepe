import { defineConfig, mergeConfig } from 'vitest/config';

import viteConfig from './vite.config';

// Unitários da SPA só em src/; os E2E (tests/e2e) são do Playwright.
export default mergeConfig(viteConfig, defineConfig({ test: { include: ['src/**/*.test.ts'] } }));
