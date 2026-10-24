// Tema do Mantine montado sobre os tokens do Cloudscape UI (research.md R4a). Toda cor, fonte, espaço e canto
// aponta para uma variável --cs-* do kit; por isso o claro e o escuro vêm do próprio tokens.css.
import {
  AppShell,
  Button,
  Card,
  type CSSVariablesResolver,
  createTheme,
  type MantineColorsTuple,
  NavLink,
  Paper,
  PasswordInput,
  TextInput,
} from '@mantine/core';

import classes from './componentes.module.css';

const marca = Array.from({ length: 10 }, (_, i) => `var(--pepe-marca-${i})`) as unknown as MantineColorsTuple;

// Cinzas do escuro do Mantine (texto, bordas, superfícies) ligados às cores do kit no tema escuro
const escuro: MantineColorsTuple = [
  'var(--cs-color-text)',
  'var(--cs-color-text-secondary)',
  'var(--cs-color-text-secondary)',
  'var(--cs-color-text-disabled)',
  'var(--cs-color-border)',
  'var(--cs-color-surface-hover)',
  'var(--cs-color-surface)',
  'var(--cs-color-canvas)',
  '#0f0f0f',
  '#0a0a0a',
];

export const tema = createTheme({
  primaryColor: 'marca',
  primaryShade: 6,
  colors: { marca, dark: escuro },
  fontFamily: 'var(--cs-font-family)',
  fontFamilyMonospace: 'Consolas, ui-monospace, monospace',
  fontSizes: {
    xs: 'var(--cs-font-caption)',
    sm: 'var(--cs-font-body)',
    md: 'var(--cs-font-body)',
    lg: 'var(--cs-font-subtitle)',
    xl: '20px',
  },
  lineHeights: {
    xs: '1.33',
    sm: '1.43',
    md: '1.43',
    lg: '1.375',
    xl: '1.4',
  },
  headings: {
    fontFamily: 'var(--cs-font-family)',
    fontWeight: '600',
    sizes: {
      h1: { fontSize: 'var(--cs-font-display)', lineHeight: 'var(--cs-font-line-display)' },
      h2: { fontSize: 'var(--cs-font-heading)', lineHeight: 'var(--cs-font-line-heading)' },
      h3: { fontSize: '20px', lineHeight: '28px' },
      h4: { fontSize: 'var(--cs-font-subtitle)', lineHeight: 'var(--cs-font-line-subtitle)' },
    },
  },
  spacing: {
    xs: 'var(--cs-space-2)',
    sm: 'var(--cs-space-3)',
    md: 'var(--cs-space-4)',
    lg: 'var(--cs-space-6)',
    xl: 'var(--cs-space-8)',
  },
  radius: {
    xs: 'var(--cs-radius-small)',
    sm: 'var(--cs-radius-small)',
    md: 'var(--cs-radius-medium)',
    lg: 'var(--cs-radius-large)',
    xl: 'var(--cs-radius-pill)',
  },
  defaultRadius: 'sm',
  shadows: {
    xs: 'var(--cs-shadow-rest)',
    sm: 'var(--cs-shadow-rest)',
    md: 'var(--cs-shadow-hover)',
    lg: 'var(--cs-shadow-overlay)',
    xl: 'var(--cs-shadow-overlay)',
  },
  focusRing: 'never', // o foco visível vem do kit (tema.css)
  components: {
    // variant explícito: sem ele o Mantine não marca data-variant e o estilo do botão principal não se aplica
    Button: Button.extend({ defaultProps: { variant: 'filled' }, classNames: { root: classes.botao } }),
    NavLink: NavLink.extend({
      classNames: { root: classes.linkLateral, section: classes.iconeLateral, label: classes.rotuloLateral },
    }),
    AppShell: AppShell.extend({
      classNames: { header: classes.cabecalho, navbar: classes.lateral, main: classes.principal },
    }),
    TextInput: TextInput.extend({ classNames: { input: classes.campo } }),
    PasswordInput: PasswordInput.extend({ classNames: { input: classes.campo } }),
    Paper: Paper.extend({ classNames: { root: classes.cartao } }),
    Card: Card.extend({ classNames: { root: classes.cartao } }),
  },
});

// Cores de base do Mantine trocadas pelas do kit, nos dois esquemas (as --cs-* já mudam com o tema)
const basicas = {
  '--mantine-color-body': 'var(--cs-color-canvas)',
  '--mantine-color-text': 'var(--cs-color-text)',
  '--mantine-color-dimmed': 'var(--cs-color-text-secondary)',
  '--mantine-color-placeholder': 'var(--cs-color-text-secondary)',
  '--mantine-color-anchor': 'var(--cs-color-brand-foreground)',
  '--mantine-color-default': 'var(--cs-color-surface)',
  '--mantine-color-default-hover': 'var(--cs-color-surface-hover)',
  '--mantine-color-default-color': 'var(--cs-color-text)',
  '--mantine-color-default-border': 'var(--cs-color-border)',
  '--mantine-color-error': 'var(--cs-color-danger)',
};

export const variaveisDoTema: CSSVariablesResolver = () => ({
  variables: {},
  light: basicas,
  dark: basicas,
});
