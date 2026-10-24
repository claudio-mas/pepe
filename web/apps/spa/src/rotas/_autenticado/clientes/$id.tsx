// T043: ficha do cliente, só de leitura (US2; FR-013 a FR-015). Abas "Cadastro" e "Conta corrente"; a aba fica na
// URL. Nenhum campo é editável nesta entrega: os dados aparecem como texto, não como campos de formulário.
import {
  Alert,
  Anchor,
  Badge,
  Box,
  Button,
  Group,
  Paper,
  SimpleGrid,
  Skeleton,
  Stack,
  Table,
  Tabs,
  Text,
  Title,
} from '@mantine/core';
import type { ClienteFicha } from '@pepe/shared';
import { useQuery } from '@tanstack/react-query';
import { createFileRoute, Link, useNavigate } from '@tanstack/react-router';
import { Icon } from 'cloudscape-ui';

import { ErroApi } from '../../../api/cliente';
import { consultaContaCorrente, consultaFicha } from '../../../api/clientes';
import { mensagemDeErro } from '../../../api/consulta';
import { buscaDaLista } from '../../../estado/lista-de-clientes';
import { formatarCpf, formatarData, formatarMoeda, formatarTexto } from '../../../formatacao';

type Aba = 'cadastro' | 'conta-corrente';

export const Route = createFileRoute('/_autenticado/clientes/$id')({
  validateSearch: (s: Record<string, unknown>): { aba?: Aba } => ({
    aba: s.aba === 'conta-corrente' ? 'conta-corrente' : undefined,
  }),
  component: Ficha,
});

function Ficha() {
  const { id } = Route.useParams();
  const { aba = 'cadastro' } = Route.useSearch();
  const navigate = useNavigate({ from: Route.fullPath });
  const idNumerico = Number(id);
  const valido = Number.isInteger(idNumerico) && idNumerico > 0;
  const ficha = useQuery({ ...consultaFicha(idNumerico), enabled: valido });

  const voltar = (
    <Anchor renderRoot={(props) => <Link {...props} to="/clientes" search={buscaDaLista()} />} size="sm">
      ← Voltar para a lista
    </Anchor>
  );

  if (!valido || (ficha.isError && ficha.error instanceof ErroApi && ficha.error.status === 404)) {
    return (
      <Stack gap="md" align="flex-start">
        {voltar}
        <Alert color="gray" title="Cliente não encontrado.">
          Ele pode ter sido excluído no sistema da loja, ou o endereço está errado.
        </Alert>
      </Stack>
    );
  }

  return (
    <Stack gap="md">
      {voltar}
      {ficha.isPending && <Skeleton h={48} w={320} radius="md" />}
      {ficha.isError && (
        <Alert color="red" title="Não foi possível abrir a ficha">
          <Stack gap="sm" align="flex-start">
            {mensagemDeErro(ficha.error)}
            <Button variant="default" onClick={() => void ficha.refetch()}>
              Tentar de novo
            </Button>
          </Stack>
        </Alert>
      )}
      {ficha.data && (
        <>
          <Stack gap={2}>
            <Group gap="sm">
              <Title order={2}>{ficha.data.nomeExibicao}</Title>
              {ficha.data.oculto && (
                <Badge variant="light" color="gray" radius="sm">
                  Oculto
                </Badge>
              )}
            </Group>
            <Text c="dimmed" size="sm">
              Cliente nº {ficha.data.id}
            </Text>
          </Stack>
          {ficha.data.oculto && (
            <Alert color="gray" icon={<Icon name="info" width={16} height={16} />}>
              Cliente oculto: não aparece na lista de clientes, a não ser com &quot;Mostrar ocultos&quot;.
            </Alert>
          )}
          <Tabs
            value={aba}
            onChange={(valor) =>
              void navigate({
                search: { aba: valor === 'conta-corrente' ? 'conta-corrente' : undefined },
                replace: true,
              })
            }
          >
            <Tabs.List>
              <Tabs.Tab value="cadastro">Cadastro</Tabs.Tab>
              <Tabs.Tab value="conta-corrente">Conta corrente</Tabs.Tab>
            </Tabs.List>
            <Tabs.Panel value="cadastro" pt="md">
              <Cadastro ficha={ficha.data} />
            </Tabs.Panel>
            <Tabs.Panel value="conta-corrente" pt="md">
              {aba === 'conta-corrente' && <ContaCorrente id={ficha.data.id} />}
            </Tabs.Panel>
          </Tabs>
        </>
      )}
    </Stack>
  );
}

function Cadastro({ ficha }: { ficha: ClienteFicha }) {
  const campos: [string, string][] = [
    ['Título', formatarTexto(ficha.titulo)],
    ['Nome', formatarTexto(ficha.nome)],
    ['Mala direta', formatarTexto(ficha.malaDireta)],
    ['Endereço', formatarTexto(ficha.endereco)],
    ['Bairro', formatarTexto(ficha.bairro)],
    ['Cidade', formatarTexto(ficha.cidade)],
    ['UF', formatarTexto(ficha.uf)],
    ['CEP', formatarTexto(ficha.cep)],
    ['Telefone', formatarTexto(ficha.telefone)],
    ['E-mail', formatarTexto(ficha.email)],
    ['CPF', formatarCpf(ficha.cpf)],
    ['Aniversário', formatarData(ficha.aniversario)],
    ['Medidas', formatarTexto(ficha.medidas)],
    ['Indicação', formatarTexto(ficha.indicacao)],
    ['Data de cadastro', formatarData(ficha.dataCadastro)],
  ];
  return (
    <Paper withBorder radius="lg" p="lg">
      <SimpleGrid component="dl" cols={{ base: 1, sm: 2, lg: 3 }} spacing="lg" verticalSpacing="md" m={0}>
        {campos.map(([rotulo, valor]) => (
          <Box key={rotulo}>
            <Text component="dt" size="xs" c="dimmed">
              {rotulo}
            </Text>
            {/* Campo vazio fica vazio (spec 2.4); o espaço não separável mantém a altura da linha */}
            <Text component="dd" m={0} style={{ overflowWrap: 'anywhere' }}>
              {valor || ' '}
            </Text>
          </Box>
        ))}
      </SimpleGrid>
    </Paper>
  );
}

function ContaCorrente({ id }: { id: number }) {
  const consulta = useQuery(consultaContaCorrente(id));
  if (consulta.isPending) return <Skeleton h={160} radius="lg" aria-label="Carregando a conta corrente" />;
  if (consulta.isError) {
    return (
      <Alert color="red" title="Não foi possível consultar a conta corrente">
        <Stack gap="sm" align="flex-start">
          {mensagemDeErro(consulta.error)}
          <Button variant="default" onClick={() => void consulta.refetch()}>
            Tentar de novo
          </Button>
        </Stack>
      </Alert>
    );
  }
  if (consulta.data.length === 0) {
    return (
      <Text c="dimmed" role="status">
        Nenhum lançamento de conta corrente.
      </Text>
    );
  }
  return (
    <Table.ScrollContainer minWidth={520}>
      <Table aria-label="Conta corrente" verticalSpacing="sm">
        <Table.Thead>
          <Table.Tr>
            <Table.Th>Data</Table.Th>
            <Table.Th>Operação</Table.Th>
            <Table.Th>Forma</Table.Th>
            <Table.Th ta="right">Valor</Table.Th>
          </Table.Tr>
        </Table.Thead>
        <Table.Tbody>
          {consulta.data.map((l) => (
            <Table.Tr key={`${l.operacao}-${l.idOrigem}-${l.forma}`}>
              <Table.Td>{formatarData(l.data)}</Table.Td>
              <Table.Td>{l.operacao}</Table.Td>
              <Table.Td>{l.forma}</Table.Td>
              <Table.Td
                ta="right"
                style={{
                  whiteSpace: 'nowrap',
                  color: l.valor !== null && l.valor < 0 ? 'var(--cs-color-danger)' : undefined,
                }}
              >
                {formatarMoeda(l.valor)}
              </Table.Td>
            </Table.Tr>
          ))}
        </Table.Tbody>
      </Table>
    </Table.ScrollContainer>
  );
}
