// T051: US4, relatório "Clientes cadastrados" (spec 001, cenários 4.1 a 4.4). Dados: apps/api/tests/banco-teste/dados.sql
// (124 clientes com nome de exibição; com DataCad: 10/03/2026, 15/03/2026 (oculto) e 23 em abril/2026).
import { expect, type Page, test } from '@playwright/test';

import { entrarNaLista } from './apoio';

async function abrirRelatorio(pagina: Page) {
  await entrarNaLista(pagina);
  await pagina
    .getByRole('navigation', { name: 'Navegação principal' })
    .getByRole('link', { name: 'Clientes cadastrados' })
    .click();
  await expect(pagina.getByRole('heading', { level: 2, name: 'Clientes cadastrados' })).toBeVisible();
}

const campoDe = (pagina: Page) => pagina.getByRole('textbox', { name: 'De' });
const campoAte = (pagina: Page) => pagina.getByRole('textbox', { name: 'Até' });

async function escolherPeriodo(pagina: Page, de: string, ate: string) {
  await campoDe(pagina).fill(de);
  await campoDe(pagina).press('Tab');
  await campoAte(pagina).fill(ate);
  await campoAte(pagina).press('Tab');
}

test('4.1 abre no mês corrente', async ({ page }) => {
  await abrirRelatorio(page);
  // Primeiro e último dia do mês no calendário do navegador
  const [primeiro, ultimo] = await page.evaluate(() => {
    const hoje = new Date();
    const f = (d: Date) => d.toLocaleDateString('pt-BR', { day: '2-digit', month: '2-digit', year: 'numeric' });
    return [
      f(new Date(hoje.getFullYear(), hoje.getMonth(), 1)),
      f(new Date(hoje.getFullYear(), hoje.getMonth() + 1, 0)),
    ];
  });
  await expect(campoDe(page)).toHaveValue(primeiro);
  await expect(campoAte(page)).toHaveValue(ultimo);
  await expect(page.getByTestId('cabecalho-do-relatorio')).toContainText(`Período: ${primeiro} a ${ultimo}`);
});

test('4.2 com período: os cadastrados entre as datas, inclusive, e os ocultos', async ({ page }) => {
  await abrirRelatorio(page);
  await escolherPeriodo(page, '10/03/2026', '15/03/2026');
  await expect(page).toHaveURL(/de=2026-03-10/);
  await expect(page).toHaveURL(/ate=2026-03-15/);
  await expect(page.getByText('2 clientes', { exact: true })).toBeVisible();
  const tabela = page.getByRole('table', { name: 'Clientes cadastrados' });
  const linhas = (await tabela.getByRole('row').allInnerTexts()).map((t) => t.replace(/\s+/g, ' ').trim());
  expect(linhas).toEqual([
    'Nome Aniversário Endereço Bairro Telefone E-mail Data de cadastro',
    'Carlos Oculto Rua Escondida, 4 Vila (13) 96666-0004 15/03/2026',
    'José Araújo 17/05/1980 Rua das Acácias, 10 Jardim (11) 98888-0001 jose@exemplo.test 10/03/2026',
  ]);
});

test('4.3 sem período: todos com nome de exibição', async ({ page }) => {
  await abrirRelatorio(page);
  await page.getByRole('switch', { name: 'Sem período' }).check();
  await expect(page.getByText('124 clientes', { exact: true })).toBeVisible();
  await expect(page.getByRole('table', { name: 'Clientes cadastrados' }).getByRole('row')).toHaveCount(125);
  await expect(page.getByTestId('cabecalho-do-relatorio')).toContainText('Sem período');
});

test('4.4 a versão de impressão tem título, período e emissão, sem a barra lateral nem os controles', async ({
  page,
}) => {
  await abrirRelatorio(page);
  await escolherPeriodo(page, '01/04/2026', '30/04/2026');
  await expect(page.getByText('23 clientes', { exact: true })).toBeVisible();
  await page.emulateMedia({ media: 'print' });
  await expect(page.getByRole('navigation', { name: 'Navegação principal' })).toBeHidden();
  await expect(page.getByRole('button', { name: 'Imprimir' })).toBeHidden();
  await expect(campoDe(page)).toBeHidden();
  await expect(page.getByText('Pepe Torras', { exact: true })).toBeVisible();
  await expect(page.getByRole('heading', { level: 2, name: 'Clientes cadastrados' })).toBeVisible();
  await expect(page.getByTestId('cabecalho-do-relatorio')).toContainText('Período: 01/04/2026 a 30/04/2026');
  await expect(page.getByTestId('cabecalho-do-relatorio')).toContainText(/Emitido em \d{2}\/\d{2}\/\d{4} \d{2}:\d{2}/);
  const pdf = await page.pdf({ format: 'A4', preferCSSPageSize: true });
  expect(pdf.byteLength).toBeGreaterThan(1000);
});

test('data final anterior à inicial: avisa e não emite', async ({ page }) => {
  await abrirRelatorio(page);
  await escolherPeriodo(page, '31/03/2026', '01/03/2026');
  await expect(page.getByText('A data final não pode ser anterior à inicial.')).toBeVisible();
  await expect(page.getByRole('table', { name: 'Clientes cadastrados' })).toHaveCount(0);
});
