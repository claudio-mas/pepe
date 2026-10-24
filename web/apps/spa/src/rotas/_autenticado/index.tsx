import { createFileRoute, redirect } from '@tanstack/react-router';

// O início da web é a lista de clientes (US1)
export const Route = createFileRoute('/_autenticado/')({
  beforeLoad: () => {
    throw redirect({ to: '/clientes' });
  },
});
