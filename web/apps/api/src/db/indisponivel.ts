// Reconhece os erros de banco fora do ar ou lento demais (spec 001, casos de borda), para a API responder 503
// com uma mensagem clara em vez do erro interno genérico.
import * as Tarn from 'tarn';
import * as Tedious from 'tedious';

export const MENSAGEM_BANCO_INDISPONIVEL =
  'Não foi possível consultar o banco de dados agora. Tente de novo em instantes; se continuar, avise o responsável pelo sistema.';

export function bancoIndisponivel(erro: unknown): boolean {
  // Sem conexão livre no pool dentro do prazo (servidor desligado, rede fora, pool esgotado)
  if (erro instanceof Tarn.TimeoutError) return true;
  // Conexão recusada, perdida ou login negado
  if (erro instanceof Tedious.ConnectionError) return true;
  // Consulta que passou do requestTimeout (banco lento)
  return erro instanceof Tedious.RequestError && erro.code === 'ETIMEOUT';
}
