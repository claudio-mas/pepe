import { Container, Text, Title } from '@mantine/core';
import { createFileRoute } from '@tanstack/react-router';

// Página provisória da Fase 1; a entrada e a lista de clientes chegam nas tarefas T027 e T035.
export const Route = createFileRoute('/')({
  component: Inicio,
});

function Inicio() {
  return (
    <Container py="xl">
      <Title order={2}>Pepe Torras Design</Title>
      <Text c="dimmed">Versão web em construção.</Text>
    </Container>
  );
}
