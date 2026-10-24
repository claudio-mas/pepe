// Estilos em camadas: Mantine, tokens do Cloudscape UI, cores da joalheria e a ponte entre os dois (src/tema).
import '@mantine/core/styles.css';
import '@mantine/dates/styles.css';
import 'cloudscape-ui/tokens.css';
import './tema/marca.css';
import './tema/tema.css';
import 'dayjs/locale/pt-br';

import { MantineProvider } from '@mantine/core';
import { DatesProvider } from '@mantine/dates';
import { QueryClientProvider } from '@tanstack/react-query';
import { createRouter, RouterProvider } from '@tanstack/react-router';
import { StrictMode } from 'react';
import { createRoot } from 'react-dom/client';

import { criarClienteDeConsultas } from './api/consulta';
import { routeTree } from './routeTree.gen';
import { SincronizarEsquema } from './tema/esquema';
import { tema, variaveisDoTema } from './tema/tema';

const consultas = criarClienteDeConsultas();
const router = createRouter({ routeTree, context: { consultas }, defaultPreload: 'intent' });

declare module '@tanstack/react-router' {
  interface Register {
    router: typeof router;
  }
}

const raiz = document.getElementById('raiz');
if (!raiz) throw new Error('Elemento #raiz não encontrado em index.html');

createRoot(raiz).render(
  <StrictMode>
    <MantineProvider theme={tema} cssVariablesResolver={variaveisDoTema} defaultColorScheme="auto">
      <SincronizarEsquema />
      <DatesProvider settings={{ locale: 'pt-br', firstDayOfWeek: 0 }}>
        <QueryClientProvider client={consultas}>
          <RouterProvider router={router} />
        </QueryClientProvider>
      </DatesProvider>
    </MantineProvider>
  </StrictMode>,
);
