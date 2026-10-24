// T027: entrada (FR-001, FR-002). Mostra a mensagem da API e, depois de entrar, volta à rota guardada.
import { Alert, Button, Center, Paper, PasswordInput, Stack, TextInput, Title } from '@mantine/core';
import { useMutation, useQueryClient } from '@tanstack/react-query';
import { createFileRoute, useRouter } from '@tanstack/react-router';
import { type FormEvent, useState } from 'react';

import { consumirRotaGuardada } from '../api/cliente';
import { mensagemDeErro } from '../api/consulta';
import { consultaSessao, entrar } from '../api/sessao';
import { Marca } from '../tema/Marca';

export const Route = createFileRoute('/entrar')({
  component: Entrar,
});

function Entrar() {
  const router = useRouter();
  const consultas = useQueryClient();
  const [login, setLogin] = useState('');
  const [senha, setSenha] = useState('');
  // Campo vazio só é apontado depois da primeira tentativa (botão sempre habilitado: melhor para leitores de tela)
  const [tentou, setTentou] = useState(false);

  const entrada = useMutation({
    mutationFn: entrar,
    onSuccess: (usuario) => {
      consultas.setQueryData(consultaSessao.queryKey, usuario);
      router.history.push(consumirRotaGuardada());
    },
    onError: () => setSenha(''),
  });

  const enviar = (evento: FormEvent) => {
    evento.preventDefault();
    setTentou(true);
    if (!login.trim() || !senha) return;
    entrada.mutate({ login: login.trim(), senha });
  };

  return (
    <Center mih="100vh" p="md">
      <Paper withBorder radius="lg" p="xl" w="100%" maw={400} component="main">
        <form onSubmit={enviar} noValidate>
          <Stack gap="md">
            <Marca tamanho="xl" />
            <Title order={2} fz="var(--cs-font-subtitle)">
              Entrar
            </Title>
            {entrada.isError && (
              <Alert color="red" role="alert">
                {mensagemDeErro(entrada.error)}
              </Alert>
            )}
            <TextInput
              label="Usuário"
              name="login"
              autoComplete="username"
              autoCapitalize="none"
              spellCheck={false}
              required
              data-autofocus
              autoFocus
              value={login}
              onChange={(e) => setLogin(e.currentTarget.value)}
              error={tentou && !login.trim() ? 'Informe o usuário.' : undefined}
            />
            <PasswordInput
              label="Senha"
              name="senha"
              autoComplete="current-password"
              required
              value={senha}
              onChange={(e) => setSenha(e.currentTarget.value)}
              error={tentou && !senha && !entrada.isError ? 'Informe a senha.' : undefined}
            />
            <Button type="submit" fullWidth loading={entrada.isPending}>
              Entrar
            </Button>
          </Stack>
        </form>
      </Paper>
    </Center>
  );
}
