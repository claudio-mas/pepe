// Apoio dos testes E2E: entrada com o usuário do banco de teste sintético.
import { expect, type Page } from '@playwright/test';

import { USUARIO_E2E } from '../../../api/tests/e2e/credenciais';

export { USUARIO_E2E };

export async function entrar(pagina: Page, senha: string = USUARIO_E2E.senha): Promise<void> {
  await pagina.goto('/entrar');
  await pagina.getByRole('textbox', { name: 'Usuário' }).fill(USUARIO_E2E.login);
  await pagina.locator('input[name=senha]').fill(senha);
  await pagina.getByRole('button', { name: 'Entrar' }).click();
}

export async function entrarNaLista(pagina: Page): Promise<void> {
  await entrar(pagina);
  await expect(pagina).toHaveURL(/\/clientes$/);
}
