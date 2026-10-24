import { Text, Title } from '@mantine/core';
import { createFileRoute } from '@tanstack/react-router';

// Provisória: o relatório chega na US4 (tarefa T055)
export const Route = createFileRoute('/_autenticado/relatorios/clientes-cadastrados')({
  component: () => (
    <>
      <Title order={2}>Clientes cadastrados</Title>
      <Text c="dimmed">Em construção.</Text>
    </>
  ),
});
