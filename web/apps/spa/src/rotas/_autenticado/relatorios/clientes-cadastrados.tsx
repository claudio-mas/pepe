// T055: relatório "Clientes cadastrados" (US4; FR-018 a FR-021), com versão para impressão em A4 (impressao.css).
// Período padrão: o mês corrente, como no desktop. O período fica na URL.
import './impressao.css';

import { Alert, Box, Button, Group, Skeleton, Stack, Switch, Table, Text, Title } from '@mantine/core';
import { DateInput } from '@mantine/dates';
import { useQuery } from '@tanstack/react-query';
import { createFileRoute, useNavigate } from '@tanstack/react-router';

import { mensagemDeErro } from '../../../api/consulta';
import { consultaClientesCadastrados } from '../../../api/relatorios';
import { NOME_DA_LOJA } from '../../../tema/Marca';
import { formatarData, formatarDataHora, formatarTexto } from '../../../formatacao';

interface BuscaNaUrl {
  de?: string;
  ate?: string;
  /** "Sem período" */
  todos?: boolean;
}

const DATA_ISO = /^\d{4}-\d{2}-\d{2}$/;

export const Route = createFileRoute('/_autenticado/relatorios/clientes-cadastrados')({
  validateSearch: (s: Record<string, unknown>): BuscaNaUrl => ({
    de: typeof s.de === 'string' && DATA_ISO.test(s.de) ? s.de : undefined,
    ate: typeof s.ate === 'string' && DATA_ISO.test(s.ate) ? s.ate : undefined,
    todos: s.todos === true || s.todos === 'true' ? true : undefined,
  }),
  component: ClientesCadastrados,
});

const iso = (d: Date) =>
  `${d.getFullYear()}-${String(d.getMonth() + 1).padStart(2, '0')}-${String(d.getDate()).padStart(2, '0')}`;

/** Primeiro e último dia do mês corrente, no calendário local (cenário 4.1). */
function mesCorrente(hoje = new Date()): { de: string; ate: string } {
  return {
    de: iso(new Date(hoje.getFullYear(), hoje.getMonth(), 1)),
    ate: iso(new Date(hoje.getFullYear(), hoje.getMonth() + 1, 0)),
  };
}

/** Lê `dd/mm/aaaa` (o formato do campo) ou `aaaa-mm-dd`; devolve `aaaa-mm-dd` ou null. */
function lerData(texto: string): string | null {
  const t = texto.trim();
  const br = /^(\d{1,2})\/(\d{1,2})\/(\d{4})$/.exec(t);
  const [ano, mes, dia] = br ? [Number(br[3]), Number(br[2]), Number(br[1])] : t.split('-').map(Number);
  if (!ano || !mes || !dia) return null;
  const data = new Date(ano, mes - 1, dia);
  return data.getFullYear() === ano && data.getMonth() === mes - 1 && data.getDate() === dia ? iso(data) : null;
}

const COLUNAS = ['Nome', 'Aniversário', 'Endereço', 'Bairro', 'Telefone', 'E-mail', 'Data de cadastro'];

function ClientesCadastrados() {
  const busca = Route.useSearch();
  const navigate = useNavigate({ from: Route.fullPath });
  const padrao = mesCorrente();
  const de = busca.de ?? padrao.de;
  const ate = busca.ate ?? padrao.ate;
  const semPeriodo = busca.todos ?? false;
  const invertido = !semPeriodo && ate < de;

  const consulta = useQuery({
    ...consultaClientesCadastrados(semPeriodo ? null : { de, ate }),
    enabled: !invertido,
  });
  const relatorio = consulta.data;
  const periodoTexto = semPeriodo ? 'Sem período' : `Período: ${formatarData(de)} a ${formatarData(ate)}`;

  const mudar = (novo: BuscaNaUrl) =>
    void navigate({ search: (anterior) => ({ ...anterior, ...novo }), replace: true });

  return (
    <Stack gap="md" className="relatorio">
      <Stack gap={2}>
        <Text className="so-impressao" fw={600}>
          {NOME_DA_LOJA}
        </Text>
        <Title order={2}>Clientes cadastrados</Title>
        <Text c="dimmed" size="sm" data-testid="cabecalho-do-relatorio">
          {periodoTexto}
          {relatorio && ` · Emitido em ${formatarDataHora(relatorio.emitidoEm)}`}
        </Text>
      </Stack>

      <Group gap="md" align="flex-end" wrap="wrap" className="nao-imprimir">
        <DateInput
          label="De"
          value={de}
          onChange={(valor) => valor && mudar({ de: valor })}
          dateParser={lerData}
          valueFormat="DD/MM/YYYY"
          disabled={semPeriodo}
          w={150}
        />
        <DateInput
          label="Até"
          value={ate}
          onChange={(valor) => valor && mudar({ ate: valor })}
          dateParser={lerData}
          valueFormat="DD/MM/YYYY"
          disabled={semPeriodo}
          error={invertido ? 'A data final não pode ser anterior à inicial.' : undefined}
          w={150}
        />
        <Switch
          label="Sem período"
          checked={semPeriodo}
          onChange={(e) => mudar({ todos: e.currentTarget.checked || undefined })}
          mb={8}
        />
        <Button variant="default" onClick={() => window.print()} disabled={!relatorio} ml="auto">
          Imprimir
        </Button>
      </Group>

      {consulta.isError && (
        <Alert color="red" title="Não foi possível emitir o relatório" className="nao-imprimir">
          <Stack gap="sm" align="flex-start">
            {mensagemDeErro(consulta.error)}
            <Button variant="default" onClick={() => void consulta.refetch()}>
              Tentar de novo
            </Button>
          </Stack>
        </Alert>
      )}

      {consulta.isPending && !invertido && <Skeleton h={240} radius="lg" aria-label="Carregando o relatório" />}

      {relatorio && !invertido && (
        <>
          <Text fw={600} aria-live="polite">
            {relatorio.total.toLocaleString('pt-BR')} {relatorio.total === 1 ? 'cliente' : 'clientes'}
          </Text>
          {relatorio.total === 0 ? (
            <Text c="dimmed" role="status">
              Nenhum cliente cadastrado no período.
            </Text>
          ) : (
            <Box className="relatorio-tabela" style={{ overflowX: 'auto' }}>
              <Table
                aria-label="Clientes cadastrados"
                verticalSpacing="xs"
                miw={900}
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
                  {relatorio.linhas.map((l, i) => (
                    <Table.Tr key={i}>
                      <Table.Td>{l.nomeExibicao}</Table.Td>
                      <Table.Td>{formatarData(l.aniversario)}</Table.Td>
                      <Table.Td>{formatarTexto(l.endereco)}</Table.Td>
                      <Table.Td>{formatarTexto(l.bairro)}</Table.Td>
                      <Table.Td style={{ whiteSpace: 'nowrap' }}>{formatarTexto(l.telefone)}</Table.Td>
                      <Table.Td style={{ overflowWrap: 'anywhere' }}>{formatarTexto(l.email)}</Table.Td>
                      <Table.Td>{formatarData(l.dataCadastro)}</Table.Td>
                    </Table.Tr>
                  ))}
                </Table.Tbody>
              </Table>
            </Box>
          )}
        </>
      )}
    </Stack>
  );
}
