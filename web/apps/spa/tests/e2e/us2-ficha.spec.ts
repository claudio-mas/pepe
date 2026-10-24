// T038: US2, consultar a ficha do cliente (spec 001, cenários de aceite 2.1 a 2.4). Dados: apps/api/tests/banco-teste/dados.sql.
import { expect, type Page, test } from '@playwright/test';

import { entrarNaLista } from './apoio';

/** Valor de um campo da ficha (lista de definições: rótulo em <dt>, valor em <dd>). */
const campo = (pagina: Page, rotulo: string) =>
  pagina.locator('dl > div', { has: pagina.locator('dt', { hasText: new RegExp(`^${rotulo}$`) }) }).locator('dd');

async function abrirFicha(pagina: Page, busca: string, nome: string) {
  await entrarNaLista(pagina);
  await pagina.getByRole('searchbox', { name: 'Pesquisar clientes' }).fill(busca);
  await expect(pagina).toHaveURL(/busca=/);
  await pagina.getByRole('table', { name: 'Clientes' }).getByRole('link', { name: nome }).click();
  await expect(pagina.getByRole('heading', { level: 2, name: nome })).toBeVisible();
}

test('2.1 a ficha mostra o cadastro completo, com o CPF formatado', async ({ page }) => {
  await abrirFicha(page, 'jose araujo', 'José Araújo');
  const esperado: Record<string, string> = {
    Título: 'Sr.',
    Nome: 'José Araújo',
    'Mala direta': 'Sr. José Araújo',
    Endereço: 'Rua das Acácias, 10',
    Bairro: 'Jardim',
    Cidade: 'São Paulo',
    UF: 'SP',
    CEP: '01001-000',
    Telefone: '(11) 98888-0001',
    'E-mail': 'jose@exemplo.test',
    CPF: '123.456.789-09',
    Aniversário: '17/05/1980',
    Medidas: 'Aro 22',
    Indicação: 'Maria',
    'Data de cadastro': '10/03/2026',
  };
  for (const [rotulo, valor] of Object.entries(esperado)) await expect(campo(page, rotulo), rotulo).toHaveText(valor);
});

test('2.2 a conta corrente mostra os lançamentos das três origens, débito em vermelho', async ({ page }) => {
  await abrirFicha(page, 'gabriel conta', 'Gabriel Conta');
  await page.getByRole('tab', { name: 'Conta corrente' }).click();
  const linhas = page.getByRole('table', { name: 'Conta corrente' }).getByRole('row');
  await expect(linhas).toHaveCount(5); // cabeçalho + 4
  const textos = (await linhas.allInnerTexts()).slice(1).map((t) => t.replace(/\s+/g, ' ').trim());
  expect(textos).toEqual([
    '05/01/2026 Conserto Cash R$ 150,00',
    '01/02/2026 Venda Cartão R$ 500,00',
    '15/02/2026 Venda Débito -R$ 200,00',
    '01/03/2026 C/C Cash R$ 300,00',
  ]);
  const debito = linhas.nth(3).getByRole('cell').last();
  await expect(debito).toHaveCSS('color', 'rgb(177, 14, 28)'); // --cs-color-danger do kit
  await expect(page).toHaveURL(/aba=conta-corrente/);
});

test('2.3 nada é editável na ficha', async ({ page }) => {
  await abrirFicha(page, 'jose araujo', 'José Araújo');
  const principal = page.getByRole('main');
  await expect(principal.locator('input, textarea, select, [contenteditable="true"]')).toHaveCount(0);
  await page.getByRole('tab', { name: 'Conta corrente' }).click();
  await expect(principal.locator('input, textarea, select, [contenteditable="true"]')).toHaveCount(0);
  await expect(principal.getByRole('button', { name: /editar|salvar|gravar|excluir/i })).toHaveCount(0);
});

test('2.4 sem data de cadastro, o campo fica vazio, sem erro', async ({ page }) => {
  await abrirFicha(page, 'beatriz', 'Sra. Beatriz Lima');
  await expect(campo(page, 'Data de cadastro')).toHaveText(' ');
  await expect(campo(page, 'Nome')).toHaveText(' '); // só mala direta: o Nome não existe
  await expect(campo(page, 'Mala direta')).toHaveText('Sra. Beatriz Lima');
  await page.getByRole('tab', { name: 'Conta corrente' }).click();
  await expect(page.getByText('Nenhum lançamento de conta corrente.')).toBeVisible();
});

test('cliente oculto abre com o aviso, e "Voltar" devolve a mesma pesquisa', async ({ page }) => {
  await entrarNaLista(page);
  await page.getByRole('switch', { name: 'Mostrar ocultos' }).check();
  await page.getByRole('searchbox', { name: 'Pesquisar clientes' }).fill('carlos');
  await expect(page).toHaveURL(/busca=carlos/); // a pesquisa espera 300 ms antes de ir para a URL
  await page.getByRole('table', { name: 'Clientes' }).getByRole('link', { name: 'Carlos Oculto' }).click();
  await expect(page.getByText(/Cliente oculto: não aparece na lista/)).toBeVisible();
  await page.getByRole('link', { name: '← Voltar para a lista' }).click();
  await expect(page).toHaveURL(/busca=carlos/);
  await expect(page).toHaveURL(/ocultos=true/);
  await expect(page.getByRole('searchbox', { name: 'Pesquisar clientes' })).toHaveValue('carlos');
});

test('cliente inexistente ou sem nome mostra "Cliente não encontrado."', async ({ page }) => {
  await entrarNaLista(page);
  for (const id of ['9999', '3']) {
    await page.goto(`/clientes/${id}`);
    await expect(page.getByText('Cliente não encontrado.')).toBeVisible();
  }
});
