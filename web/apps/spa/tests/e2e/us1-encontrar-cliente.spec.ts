// T031: US1, encontrar um cliente (spec 001, cenários de aceite 1.1 a 1.5). Dados: apps/api/tests/banco-teste/dados.sql.
import { expect, type Page, test } from '@playwright/test';

import { entrar, entrarNaLista } from './apoio';

const tabela = (pagina: Page) => pagina.getByRole('table', { name: 'Clientes' });
const campoDePesquisa = (pagina: Page) => pagina.getByRole('searchbox', { name: 'Pesquisar clientes' });
const pesquisar = (pagina: Page, texto: string) => campoDePesquisa(pagina).fill(texto);

test('1.5 usuário ou senha errados: recusa sem dizer qual dos dois', async ({ page }) => {
  await entrar(page, 'senha-errada-000');
  await expect(page.getByRole('alert')).toHaveText('Usuário ou senha inválidos.');
  await expect(page).toHaveURL(/\/entrar$/);
});

test('1.1 entra e vê a barra lateral com Cadastros › Clientes', async ({ page }) => {
  await entrarNaLista(page);
  const lateral = page.getByRole('navigation', { name: 'Navegação principal' });
  await expect(lateral.getByText('Cadastros')).toBeVisible();
  await expect(lateral.getByRole('link', { name: 'Clientes', exact: true })).toBeVisible();
  await expect(tabela(page).getByRole('row')).toHaveCount(51); // cabeçalho + 50 por página
  await expect(page.getByText('1–50 de 123 clientes')).toBeVisible();
});

test('1.2 pesquisa sem diferenciar maiúsculas e acentos, por nome e por telefone', async ({ page }) => {
  await entrarNaLista(page);
  await pesquisar(page, 'JOSE araujo');
  await expect(tabela(page).getByRole('row')).toHaveCount(2);
  await expect(tabela(page)).toContainText('José Araújo');
  await expect(tabela(page)).toContainText('17/05/1980');
  await expect(page).toHaveURL(/busca=JOSE/);

  await pesquisar(page, '93333-0007');
  await expect(tabela(page).getByRole('row')).toHaveCount(2);
  await expect(tabela(page)).toContainText('Rua Sete, 7');
});

test('1.3 oculto só aparece com "mostrar ocultos", identificado como oculto', async ({ page }) => {
  await entrarNaLista(page);
  await pesquisar(page, 'carlos oculto');
  await expect(page.getByText('Nenhum cliente encontrado.')).toBeVisible();
  await page.getByRole('switch', { name: 'Mostrar ocultos' }).check();
  await expect(tabela(page).getByRole('row', { name: /Carlos Oculto/ })).toContainText('Oculto');
});

test('1.4 cliente só com mala direta aparece pelo nome de mala direta', async ({ page }) => {
  await entrarNaLista(page);
  await pesquisar(page, 'beatriz');
  await expect(tabela(page).getByRole('link', { name: 'Sra. Beatriz Lima' })).toBeVisible();
});

test('a linha abre a ficha, e a página da lista fica na URL', async ({ page }) => {
  await entrarNaLista(page);
  await page.getByRole('button', { name: 'Página 3' }).click();
  await expect(page).toHaveURL(/pagina=3/);
  await expect(tabela(page).getByRole('row')).toHaveCount(24); // cabeçalho + 23
  await pesquisar(page, 'ana souza');
  await expect(tabela(page).getByRole('row')).toHaveCount(3); // homônimos: os dois aparecem
  await tabela(page).getByRole('row').nth(1).click();
  await expect(page).toHaveURL(/\/clientes\/6$/);
  await page.goBack();
  await expect(campoDePesquisa(page)).toHaveValue('ana souza');
});

test('o link "Clientes" da barra lateral limpa a pesquisa', async ({ page }) => {
  await entrarNaLista(page);
  await pesquisar(page, 'beatriz');
  await expect(page).toHaveURL(/busca=beatriz/);
  await page
    .getByRole('navigation', { name: 'Navegação principal' })
    .getByRole('link', { name: 'Clientes', exact: true })
    .click();
  await expect(campoDePesquisa(page)).toHaveValue('');
  await page.waitForTimeout(500); // passa a espera da pesquisa: o texto antigo não pode voltar
  await expect(page).toHaveURL(/\/clientes$/);
  await expect(page.getByText('1–50 de 123 clientes')).toBeVisible();
});
