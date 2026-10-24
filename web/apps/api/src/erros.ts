// Erro previsto, com mensagem para o usuário em português (contrato `Erro`).
// Fica num módulo próprio para as rotas não importarem server.ts (importação circular).
export class ErroHttp extends Error {
  constructor(
    readonly statusCode: number,
    mensagem: string,
  ) {
    super(mensagem);
    this.name = 'ErroHttp';
  }
}
