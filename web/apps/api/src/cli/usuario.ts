// Procedimento técnico de manutenção dos usuários da web (research.md R8; FR-004). Não há tela para isso.
// Uso (em web/): pnpm --filter @pepe/api usuario <comando>, com PEPE_WEB_CONFIG apontando para a configuração.
//   criar <login> <nome>   cria o usuário (a senha é pedida em seguida)
//   senha <login>          troca a senha, desbloqueia e encerra as sessões abertas
//   desativar <login>      desativa e encerra as sessões abertas
//   reativar <login>       reativa e desbloqueia
//   listar                 lista os usuários
// A senha é digitada sem eco, duas vezes, e nunca vem por argumento, arquivo ou log.
import {
  criarUsuario,
  desativarUsuario,
  listarUsuarios,
  normalizarLogin,
  reativarUsuario,
  redefinirSenha,
  validarLogin,
  validarSenhaNova,
} from '../auth/usuarios.js';
import { lerConfig } from '../config.js';
import { type Banco, criarBanco } from '../db/kysely.js';

const AJUDA = `Uso: pnpm --filter @pepe/api usuario <comando>
  criar <login> <nome>   cria o usuário (a senha é pedida em seguida)
  senha <login>          troca a senha, desbloqueia e encerra as sessões abertas
  desativar <login>      desativa e encerra as sessões abertas
  reativar <login>       reativa e desbloqueia
  listar                 lista os usuários`;

/** Lê uma linha do terminal sem mostrar o que é digitado. */
function lerSemEco(pergunta: string): Promise<string> {
  const entrada = process.stdin;
  if (!entrada.isTTY) {
    return Promise.reject(new Error('A senha precisa ser digitada num terminal (não aceita entrada redirecionada).'));
  }
  process.stdout.write(pergunta);
  entrada.setRawMode(true);
  entrada.setEncoding('utf8');
  entrada.resume();
  return new Promise((resolve, reject) => {
    let texto = '';
    const terminar = () => {
      entrada.off('data', aoDigitar);
      entrada.setRawMode(false);
      entrada.pause();
      process.stdout.write('\n');
    };
    function aoDigitar(dados: string) {
      for (const c of dados) {
        if (c === '\r' || c === '\n') {
          terminar();
          resolve(texto);
          return;
        }
        if (c === '\u0003' || c === '\u0004') {
          terminar();
          reject(new Error('Cancelado.'));
          return;
        }
        if (c === '\u007f' || c === '\b') texto = texto.slice(0, -1);
        else texto += c;
      }
    }
    entrada.on('data', aoDigitar);
  });
}

async function pedirSenhaNova(): Promise<string> {
  const senha = await lerSemEco('Senha nova: ');
  validarSenhaNova(senha);
  const confirmacao = await lerSemEco('Repita a senha: ');
  if (senha !== confirmacao) throw new Error('As duas senhas não conferem. Nada foi alterado.');
  return senha;
}

const formatarData = (data: Date | null) => (data ? data.toLocaleString('pt-BR') : '');

async function executar(banco: Banco, comando: string | undefined, argumentos: string[]): Promise<void> {
  const [login, ...resto] = argumentos;
  const exigirLogin = () => {
    if (!login) throw new Error(`Informe o login.\n\n${AJUDA}`);
    return validarLogin(login);
  };
  switch (comando) {
    case 'criar': {
      const loginNovo = exigirLogin();
      const nome = resto.join(' ').trim();
      if (!nome) throw new Error(`Informe o nome.\n\n${AJUDA}`);
      const senha = await pedirSenhaNova();
      await criarUsuario(banco, { login: loginNovo, nome, senha });
      console.log(`Usuário "${loginNovo}" criado.`);
      return;
    }
    case 'senha': {
      const alvo = exigirLogin();
      const senha = await pedirSenhaNova();
      await redefinirSenha(banco, alvo, senha);
      console.log(`Senha de "${alvo}" trocada; as sessões abertas foram encerradas.`);
      return;
    }
    case 'desativar': {
      const alvo = exigirLogin();
      await desativarUsuario(banco, alvo);
      console.log(`Usuário "${alvo}" desativado; as sessões abertas foram encerradas.`);
      return;
    }
    case 'reativar': {
      const alvo = exigirLogin();
      await reativarUsuario(banco, alvo);
      console.log(`Usuário "${normalizarLogin(alvo)}" reativado.`);
      return;
    }
    case 'listar': {
      const usuarios = await listarUsuarios(banco);
      if (!usuarios.length) {
        console.log('Nenhum usuário cadastrado.');
        return;
      }
      console.table(
        usuarios.map((u) => ({
          Login: u.Login,
          Nome: u.Nome,
          Ativo: u.Ativo ? 'sim' : 'não',
          'Bloqueado até': formatarData(u.BloqueadoAte),
          'Último acesso': formatarData(u.UltimoAcesso),
        })),
      );
      return;
    }
    default:
      throw new Error(AJUDA);
  }
}

async function principal(): Promise<void> {
  const [comando, ...argumentos] = process.argv.slice(2);
  if (!comando || comando === 'ajuda' || comando === '--help') {
    console.log(AJUDA);
    return;
  }
  const config = lerConfig();
  const banco = criarBanco(config.bancoDeDados);
  try {
    await executar(banco, comando, argumentos);
  } finally {
    await banco.destroy();
  }
}

principal().catch((erro: unknown) => {
  console.error(erro instanceof Error ? erro.message : erro);
  process.exitCode = 1;
});
