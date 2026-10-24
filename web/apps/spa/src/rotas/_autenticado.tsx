// T028: layout das telas com sessão (FR-005, FR-006). Barra lateral no lugar das ribbons, com os grupos de
// docs/legado/01-modulos.md; nesta entrega só aparecem "Cadastros › Clientes" e "Relatórios › Clientes cadastrados".
import { AppShell, Avatar, Burger, Group, Menu, NavLink, Stack, Text, UnstyledButton } from '@mantine/core';
import { useDisclosure } from '@mantine/hooks';
import { createFileRoute, Link, Outlet, useRouterState } from '@tanstack/react-router';
import { Icon, type IconName } from 'cloudscape-ui';

import { consultaSessao, sair } from '../api/sessao';
import { EscolhaDeAparencia } from '../tema/esquema';
import { Marca } from '../tema/Marca';

export const Route = createFileRoute('/_autenticado')({
  // Sem sessão, o cliente HTTP guarda a rota e leva para a entrada
  beforeLoad: async ({ context }) => ({ usuario: await context.consultas.ensureQueryData(consultaSessao) }),
  component: Layout,
});

interface ItemDoMenu {
  rotulo: string;
  para: '/clientes' | '/relatorios/clientes-cadastrados';
  icone: IconName;
}

const GRUPOS: { titulo: string; itens: ItemDoMenu[] }[] = [
  { titulo: 'Cadastros', itens: [{ rotulo: 'Clientes', para: '/clientes', icone: 'people' }] },
  {
    titulo: 'Relatórios',
    itens: [{ rotulo: 'Clientes cadastrados', para: '/relatorios/clientes-cadastrados', icone: 'file' }],
  },
];

function iniciais(nome: string): string {
  const partes = nome.trim().split(/\s+/);
  return ((partes[0]?.[0] ?? '') + (partes.length > 1 ? (partes.at(-1)?.[0] ?? '') : '')).toUpperCase();
}

function Layout() {
  const { usuario } = Route.useRouteContext();
  const [aberta, { toggle, close }] = useDisclosure();
  const caminho = useRouterState({ select: (s) => s.location.pathname });

  return (
    <AppShell
      header={{ height: 64 }}
      navbar={{ width: 280, breakpoint: 'sm', collapsed: { mobile: !aberta } }}
      padding="md"
    >
      <AppShell.Header px="md">
        <Group h="100%" justify="space-between" wrap="nowrap">
          <Group gap="sm" wrap="nowrap">
            <Burger opened={aberta} onClick={toggle} hiddenFrom="sm" size="sm" aria-label="Abrir navegação" />
            <Marca />
          </Group>
          <Menu position="bottom-end" width={260} shadow="lg">
            <Menu.Target>
              <UnstyledButton aria-label={`Usuário: ${usuario.nome}`}>
                <Group gap="xs" wrap="nowrap">
                  <Text visibleFrom="sm" size="sm">
                    {usuario.nome}
                  </Text>
                  <Avatar radius="xl" size={32} variant="default">
                    {iniciais(usuario.nome)}
                  </Avatar>
                </Group>
              </UnstyledButton>
            </Menu.Target>
            <Menu.Dropdown>
              <Menu.Label>{usuario.login}</Menu.Label>
              <Stack px="sm" py="xs" gap={6}>
                <Text size="xs" c="dimmed">
                  Aparência
                </Text>
                <EscolhaDeAparencia />
              </Stack>
              <Menu.Divider />
              <Menu.Item onClick={() => void sair()}>Sair</Menu.Item>
            </Menu.Dropdown>
          </Menu>
        </Group>
      </AppShell.Header>

      <AppShell.Navbar p="md" pt="lg" component="nav" aria-label="Navegação principal">
        {GRUPOS.map((grupo) => (
          <Stack key={grupo.titulo} gap={2} mb="md">
            <Text fw={600} px="sm" mb={4}>
              {grupo.titulo}
            </Text>
            {grupo.itens.map((item) => (
              <NavLink
                key={item.para}
                component={Link}
                to={item.para}
                label={item.rotulo}
                leftSection={<Icon name={item.icone} width={16} height={16} />}
                active={caminho.startsWith(item.para)}
                onClick={close}
              />
            ))}
          </Stack>
        ))}
      </AppShell.Navbar>

      <AppShell.Main>
        <Outlet />
      </AppShell.Main>
    </AppShell>
  );
}
