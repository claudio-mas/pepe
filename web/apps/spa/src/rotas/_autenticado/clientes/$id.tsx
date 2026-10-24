import { Anchor, Stack, Text, Title } from '@mantine/core';
import { createFileRoute, Link } from '@tanstack/react-router';

// Provisória: a ficha do cliente chega na US2 (tarefa T043)
export const Route = createFileRoute('/_autenticado/clientes/$id')({
  component: Ficha,
});

function Ficha() {
  const { id } = Route.useParams();
  return (
    <Stack gap="xs" align="flex-start">
      <Title order={2}>Cliente nº {id}</Title>
      <Text c="dimmed">A ficha do cliente está em construção.</Text>
      <Anchor component={Link} to="/clientes">
        Voltar para a lista
      </Anchor>
    </Stack>
  );
}
