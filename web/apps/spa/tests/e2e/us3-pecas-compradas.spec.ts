// T045: US3, peças compradas pelo cliente (spec 001, cenários 3.1 e 3.2). Dados: apps/api/tests/banco-teste/dados.sql.
import { expect, test } from '@playwright/test';

import { entrarNaLista } from './apoio';

test('3.1 mostra as peças da compra mais recente para a mais antiga, sem custo nem preço', async ({ page }) => {
  await entrarNaLista(page);
  await page.goto('/clientes/8');
  await page.getByRole('tab', { name: 'Peças compradas' }).click();
  const tabela = page.getByRole('table', { name: 'Peças compradas' });
  await expect(tabela.getByRole('row')).toHaveCount(4); // cabeçalho + 3 peças
  const cabecalho = (await tabela.getByRole('columnheader').allInnerTexts()).map((t) => t.trim());
  expect(cabecalho).toEqual(['Data', 'Venda', 'Peça', 'Descrição', 'Observações']);
  const linhas = (await tabela.getByRole('row').allInnerTexts()).slice(1).map((t) => t.replace(/\s+/g, ' ').trim());
  expect(linhas).toEqual([
    '20/02/2026 0002/26 BR 2002 Brinco argola em prata',
    '20/02/2026 0002/26 PEN 3003 Pingente gota com ametista Corrente 45 cm',
    '10/01/2026 0001/26 AN 1001 Anel solitário em ouro 18k Aro 22',
  ]);
  await expect(tabela).not.toContainText('R$');
  await expect(page).toHaveURL(/aba=pecas-compradas/);
});

test('3.2 cliente sem compras mostra o aviso', async ({ page }) => {
  await entrarNaLista(page);
  await page.goto('/clientes/9?aba=pecas-compradas');
  await expect(page.getByText('Não há compras registradas.')).toBeVisible();
});
