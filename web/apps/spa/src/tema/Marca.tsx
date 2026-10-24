// Nome e logotipo da joalheria no cabeçalho e na entrada. Enquanto o arquivo do logotipo não chega, mostra o nome.
import { Text } from '@mantine/core';

export const NOME_DA_LOJA = 'Pepe Torras';

export function Marca({ tamanho = 'lg' }: { tamanho?: 'lg' | 'xl' }) {
  return (
    <Text component="span" fw={600} fz={tamanho === 'xl' ? 'var(--cs-font-heading)' : 'var(--cs-font-subtitle)'}>
      {NOME_DA_LOJA}
    </Text>
  );
}
