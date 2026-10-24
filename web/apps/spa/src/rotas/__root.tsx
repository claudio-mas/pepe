import { createRootRoute, Outlet } from '@tanstack/react-router';

// Raiz provisória: o layout com a barra lateral (AppShell) entra na tarefa T028.
export const Route = createRootRoute({
  component: () => <Outlet />,
});
