// Usuário dos testes E2E. Só existe no banco de teste sintético, recriado a cada execução (nunca na loja).
export const USUARIO_E2E = { login: 'e2e.teste', nome: 'Teste E2E', senha: 'senha-de-teste-e2e' } as const;
export const PORTA_E2E = Number(process.env.PEPE_E2E_PORTA ?? 3999);
