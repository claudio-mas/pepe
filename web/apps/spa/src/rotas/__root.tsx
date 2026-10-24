// Raiz das rotas: só o contexto (cliente de consultas) e as telas de erro e de rota inexistente.
// Nenhum erro deixa a tela em branco: sempre aparece uma mensagem em português com "Tentar de novo".
import { Alert, Button, Center, Stack } from '@mantine/core';
import type { QueryClient } from '@tanstack/react-query';
import { createRootRouteWithContext, type ErrorComponentProps, Link, Outlet, useRouter } from '@tanstack/react-router';

import { ErroApi } from '../api/cliente';
import { mensagemDeErro } from '../api/consulta';

export interface ContextoDasRotas {
  consultas: QueryClient;
}

export const Route = createRootRouteWithContext<ContextoDasRotas>()({
  component: Outlet,
  errorComponent: ErroGeral,
  notFoundComponent: NaoEncontrada,
});

function ErroGeral({ error, reset }: ErrorComponentProps) {
  const router = useRouter();
  // Sem sessão, o cliente HTTP já está levando para a entrada
  if (error instanceof ErroApi && error.status === 401) return null;
  return (
    <Center mih="60vh" p="md">
      <Alert color="red" title="Não foi possível abrir esta tela" maw={520}>
        <Stack gap="sm" align="flex-start">
          {mensagemDeErro(error)}
          <Button
            variant="default"
            onClick={() => {
              reset();
              void router.invalidate();
            }}
          >
            Tentar de novo
          </Button>
        </Stack>
      </Alert>
    </Center>
  );
}

function NaoEncontrada() {
  return (
    <Center mih="60vh" p="md">
      <Stack align="center" gap="sm">
        Página não encontrada.
        <Button component={Link} to="/" variant="default">
          Voltar ao início
        </Button>
      </Stack>
    </Center>
  );
}
