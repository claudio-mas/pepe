// Claro, escuro ou "Sistema": o Mantine guarda a escolha (padrão: Sistema) e este componente repassa o esquema
// resolvido para o atributo data-cs-theme do <html>, que liga o tema escuro dos tokens do Cloudscape UI.
import { SegmentedControl, useComputedColorScheme, useMantineColorScheme } from '@mantine/core';
import { useLayoutEffect } from 'react';

export function SincronizarEsquema(): null {
  const resolvido = useComputedColorScheme('light');
  // useLayoutEffect: aplica antes de pintar, sem piscar o tema errado
  useLayoutEffect(() => {
    document.documentElement.dataset.csTheme = resolvido;
    document.documentElement.style.colorScheme = resolvido;
  }, [resolvido]);
  return null;
}

const OPCOES = [
  { value: 'light', label: 'Claro' },
  { value: 'dark', label: 'Escuro' },
  { value: 'auto', label: 'Sistema' },
];

export function EscolhaDeAparencia() {
  const { colorScheme, setColorScheme } = useMantineColorScheme();
  return (
    <SegmentedControl
      aria-label="Aparência"
      size="xs"
      radius="xl"
      fullWidth
      data={OPCOES}
      value={colorScheme}
      onChange={(valor) => setColorScheme(valor as 'light' | 'dark' | 'auto')}
    />
  );
}
