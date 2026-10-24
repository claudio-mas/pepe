import { Text, Title } from '@mantine/core';
import { createFileRoute } from '@tanstack/react-router';

// Provisória: a lista de clientes chega na US1 (tarefa T035)
export const Route = createFileRoute('/_autenticado/clientes/')({
  component: () => (
    <>
      <Title order={2}>Clientes</Title>
      <Text c="dimmed">Em construção.</Text>
    </>
  ),
});
