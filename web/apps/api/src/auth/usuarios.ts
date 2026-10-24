// Manutenção de usuários da web, usada pelo procedimento técnico (cli/usuario.ts, research.md R8) e pelos testes.
// Não há tela de administração nesta entrega (FR-004).
import type { Banco } from '../db/kysely.js';
import { gerarHashDeSenha, TAMANHO_MINIMO_SENHA } from './senha.js';
import { apagarSessoesDoUsuario } from './sessao.js';

const FORMATO_LOGIN = /^[a-z0-9.-]{1,50}$/;

export function normalizarLogin(login: string): string {
  return login.trim().toLowerCase();
}

export function validarLogin(login: string): string {
  const normalizado = normalizarLogin(login);
  if (!FORMATO_LOGIN.test(normalizado)) {
    throw new Error('Login inválido: use até 50 caracteres entre letras minúsculas, dígitos, "." e "-".');
  }
  return normalizado;
}

export function validarSenhaNova(senha: string): void {
  if (senha.length < TAMANHO_MINIMO_SENHA) {
    throw new Error(`A senha precisa ter pelo menos ${TAMANHO_MINIMO_SENHA} caracteres.`);
  }
}

async function idDoUsuario(banco: Banco, login: string): Promise<number> {
  const linha = await banco
    .selectFrom('web.Usuario')
    .select('IdUsuario')
    .where('Login', '=', validarLogin(login))
    .executeTakeFirst();
  if (!linha) throw new Error(`Usuário "${normalizarLogin(login)}" não encontrado.`);
  return linha.IdUsuario;
}

export async function criarUsuario(banco: Banco, dados: { login: string; nome: string; senha: string }): Promise<void> {
  const login = validarLogin(dados.login);
  const nome = dados.nome.trim();
  if (!nome || nome.length > 100) throw new Error('Informe um nome com até 100 caracteres.');
  validarSenhaNova(dados.senha);
  const existe = await banco
    .selectFrom('web.Usuario')
    .select('IdUsuario')
    .where('Login', '=', login)
    .executeTakeFirst();
  if (existe) throw new Error(`Já existe o usuário "${login}".`);
  await banco
    .insertInto('web.Usuario')
    .values({ Login: login, Nome: nome, HashSenha: await gerarHashDeSenha(dados.senha), CriadoEm: new Date() })
    .execute();
}

/** Desativa e encerra as sessões abertas (a próxima ação do usuário volta para a entrada). */
export async function desativarUsuario(banco: Banco, login: string): Promise<void> {
  const id = await idDoUsuario(banco, login);
  await banco.transaction().execute(async (trx) => {
    await trx.updateTable('web.Usuario').set({ Ativo: false }).where('IdUsuario', '=', id).execute();
    await apagarSessoesDoUsuario(trx, id);
  });
}

export async function reativarUsuario(banco: Banco, login: string): Promise<void> {
  const id = await idDoUsuario(banco, login);
  await banco
    .updateTable('web.Usuario')
    .set({ Ativo: true, TentativasFalhas: 0, BloqueadoAte: null })
    .where('IdUsuario', '=', id)
    .execute();
}

/** Troca a senha, desbloqueia e encerra as sessões abertas. */
export async function redefinirSenha(banco: Banco, login: string, senha: string): Promise<void> {
  validarSenhaNova(senha);
  const id = await idDoUsuario(banco, login);
  const hashNovo = await gerarHashDeSenha(senha);
  await banco.transaction().execute(async (trx) => {
    await trx
      .updateTable('web.Usuario')
      .set({ HashSenha: hashNovo, TentativasFalhas: 0, BloqueadoAte: null })
      .where('IdUsuario', '=', id)
      .execute();
    await apagarSessoesDoUsuario(trx, id);
  });
}

export function listarUsuarios(banco: Banco) {
  return banco
    .selectFrom('web.Usuario')
    .select(['Login', 'Nome', 'Ativo', 'BloqueadoAte', 'UltimoAcesso'])
    .orderBy('Login')
    .execute();
}
