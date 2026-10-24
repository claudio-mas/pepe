// T035: lista e pesquisa de clientes (US1; FR-007 a FR-012). Pesquisa, "mostrar ocultos" e página ficam na URL,
// para o voltar do navegador e a volta depois da entrada trazerem a mesma lista.
import {
  Alert,
  Anchor,
  Badge,
  Button,
  Group,
  Pagination,
  Skeleton,
  Stack,
  Switch,
  Table,
  Text,
  TextInput,
  Title,
} from '@mantine/core';
import { useDebouncedValue } from '@mantine/hooks';
import type { ClienteResumo } from '@pepe/shared';
import { useQuery } from '@tanstack/react-query';
import { createFileRoute, Link, useNavigate } from '@tanstack/react-router';
import { Icon } from 'cloudscape-ui';
import { useEffect, useRef, useState } from 'react';

import { consultaClientes, POR_PAGINA } from '../../../api/clientes';
import { mensagemDeErro } from '../../../api/consulta';
import { formatarData, formatarTexto } from '../../../formatacao';

interface BuscaNaUrl {
  busca?: string;
  ocultos?: boolean;
  pagina?: number;
}

export const Route = createFileRoute('/_autenticado/clientes/')({
  validateSearch: (s: Record<string, unknown>): BuscaNaUrl => {
    const pagina = Number(s.pagina);
    return {
      busca: typeof s.busca === 'string' && s.busca.trim() ? s.busca.slice(0, 100) : undefined,
      ocultos: s.ocultos === true || s.ocultos === 'true' ? true : undefined,
      pagina: Number.isInteger(pagina) && pagina > 1 ? pagina : undefined,
    };
  },
  component: ListaDeClientes,
});

const COLUNAS = ['Nome', 'Título', 'Mala direta', 'Endereço', 'Bairro', 'Telefone', 'Aniversário'];

function ListaDeClientes() {
  const busca = Route.useSearch();
  const navigate = useNavigate({ from: Route.fullPath });
  const filtro = { busca: busca.busca ?? '', ocultos: busca.ocultos ?? false, pagina: busca.pagina ?? 1 };

  // Pesquisa com espera de 300 ms depois da última tecla. `naUrl` guarda o último texto que este campo pôs na URL,
  // para distinguir a mudança feita pelo próprio campo da que vem de fora (voltar, link da barra lateral).
  const [texto, setTexto] = useState(filtro.busca);
  const [textoEstavel] = useDebouncedValue(texto.trim(), 300);
  const naUrl = useRef(filtro.busca);
  useEffect(() => {
    if (filtro.busca === naUrl.current) return;
    naUrl.current = filtro.busca;
    setTexto(filtro.busca);
  }, [filtro.busca]);
  useEffect(() => {
    if (textoEstavel === naUrl.current) return;
    naUrl.current = textoEstavel;
    void navigate({
      search: (anterior) => ({ ...anterior, busca: textoEstavel || undefined, pagina: undefined }),
      replace: true,
    });
  }, [textoEstavel, navigate]);

  const consulta = useQuery(consultaClientes(filtro));
  const paginas = consulta.data ? Math.ceil(consulta.data.total / POR_PAGINA) : 0;

  return (
    <Stack gap="md">
      <Group justify="space-between" align="flex-end" wrap="wrap">
        <Title order={2}>Clientes</Title>
        {consulta.data && (
          <Text c="dimmed" size="sm" aria-live="polite">
            {resumo(consulta.data.total, filtro.pagina)}
          </Text>
        )}
      </Group>

      <Group gap="md" wrap="wrap">
        <TextInput
          aria-label="Pesquisar clientes"
          placeholder="Pesquisar por nome, mala direta ou telefone"
          leftSection={<Icon name="search" width={16} height={16} />}
          radius="xl"
          w={{ base: '100%', sm: 420 }}
          maxLength={100}
          value={texto}
          onChange={(e) => setTexto(e.currentTarget.value)}
          type="search"
        />
        <Switch
          label="Mostrar ocultos"
          checked={filtro.ocultos}
          onChange={(e) =>
            void navigate({
              search: (anterior) => ({ ...anterior, ocultos: e.currentTarget.checked || undefined, pagina: undefined }),
              replace: true,
            })
          }
        />
      </Group>

      {consulta.isError && (
        <Alert color="red" title="Não foi possível consultar os clientes">
          <Stack gap="sm" align="flex-start">
            {mensagemDeErro(consulta.error)}
            <Button variant="default" onClick={() => void consulta.refetch()}>
              Tentar de novo
            </Button>
          </Stack>
        </Alert>
      )}

      {consulta.isPending && <Skeleton h={320} radius="lg" aria-label="Carregando clientes" />}

      {consulta.data && consulta.data.itens.length === 0 && (
        <Stack align="center" gap={4} py="xl" role="status">
          <Text fw={600}>Nenhum cliente encontrado.</Text>
          <Text c="dimmed" size="sm">
            {filtro.busca
              ? `Confira o texto pesquisado${filtro.ocultos ? '' : ' ou ligue "Mostrar ocultos"'}.`
              : 'Não há clientes para mostrar.'}
          </Text>
        </Stack>
      )}

      {consulta.data && consulta.data.itens.length > 0 && (
        <Table.ScrollContainer minWidth={960}>
          <Table
            highlightOnHover
            verticalSpacing="sm"
            aria-label="Clientes"
            style={{ opacity: consulta.isPlaceholderData ? 0.6 : 1 }}
          >
            <Table.Thead>
              <Table.Tr>
                {COLUNAS.map((c) => (
                  <Table.Th key={c}>{c}</Table.Th>
                ))}
              </Table.Tr>
            </Table.Thead>
            <Table.Tbody>
              {consulta.data.itens.map((c) => (
                <LinhaDoCliente key={c.id} cliente={c} />
              ))}
            </Table.Tbody>
          </Table>
        </Table.ScrollContainer>
      )}

      {paginas > 1 && (
        <Pagination
          total={paginas}
          value={filtro.pagina}
          onChange={(pagina) =>
            void navigate({ search: (anterior) => ({ ...anterior, pagina: pagina > 1 ? pagina : undefined }) })
          }
          getItemProps={(pagina) => ({ 'aria-label': `Página ${pagina}` })}
          getControlProps={(controle) => ({
            'aria-label':
              controle === 'next' ? 'Próxima página' : controle === 'previous' ? 'Página anterior' : controle,
          })}
        />
      )}
    </Stack>
  );
}

function resumo(total: number, pagina: number): string {
  if (total === 0) return 'Nenhum cliente';
  const inicio = (pagina - 1) * POR_PAGINA + 1;
  const fim = Math.min(pagina * POR_PAGINA, total);
  const n = total.toLocaleString('pt-BR');
  return inicio > total ? `${n} clientes` : `${inicio}–${fim} de ${n} ${total === 1 ? 'cliente' : 'clientes'}`;
}

function LinhaDoCliente({ cliente }: { cliente: ClienteResumo }) {
  const navigate = useNavigate();
  const abrir = () => void navigate({ to: '/clientes/$id', params: { id: String(cliente.id) } });
  return (
    <Table.Tr onClick={abrir} style={{ cursor: 'pointer' }}>
      <Table.Td>
        <Group gap="xs" wrap="nowrap">
          {/* O link deixa a linha acessível pelo teclado; o clique na linha inteira é só atalho */}
          <Anchor
            renderRoot={(props) => <Link {...props} to="/clientes/$id" params={{ id: String(cliente.id) }} />}
            c="var(--cs-color-text)"
            fw={500}
            onClick={(e) => e.stopPropagation()}
          >
            {cliente.nomeExibicao}
          </Anchor>
          {cliente.oculto && (
            <Badge variant="light" color="gray" size="sm" radius="sm">
              Oculto
            </Badge>
          )}
        </Group>
      </Table.Td>
      <Table.Td>{formatarTexto(cliente.titulo)}</Table.Td>
      <Table.Td>{formatarTexto(cliente.malaDireta)}</Table.Td>
      <Table.Td>{formatarTexto(cliente.endereco)}</Table.Td>
      <Table.Td>{formatarTexto(cliente.bairro)}</Table.Td>
      <Table.Td style={{ whiteSpace: 'nowrap' }}>{formatarTexto(cliente.telefone)}</Table.Td>
      <Table.Td>{formatarData(cliente.aniversario)}</Table.Td>
    </Table.Tr>
  );
}
