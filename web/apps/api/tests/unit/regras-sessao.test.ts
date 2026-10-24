// T018: regras puras de sessão e bloqueio (research.md R7; data-model.md, web.Usuario e web.Sessao).
import { describe, expect, it } from 'vitest';

import {
  aposAcerto,
  aposFalha,
  BLOQUEIO_MS,
  estaBloqueado,
  INATIVIDADE_MAXIMA_MS,
  novaSessao,
  precisaTocar,
  situacaoDaSessao,
  TENTATIVAS_ATE_BLOQUEIO,
  TETO_DA_SESSAO_MS,
} from '../../src/auth/regras.js';

const MINUTO = 60_000;
const inicio = new Date('2026-10-24T13:00:00Z');
const depois = (ms: number) => new Date(inicio.getTime() + ms);
const usuarioAtivo = { ativo: true, tentativasFalhas: 0, bloqueadoAte: null };

describe('sessão', () => {
  it('nova sessão expira 12 h depois da entrada', () => {
    const sessao = novaSessao(inicio);
    expect(sessao.criadaEm).toEqual(inicio);
    expect(sessao.ultimoUso).toEqual(inicio);
    expect(sessao.expiraEm.getTime() - inicio.getTime()).toBe(TETO_DA_SESSAO_MS);
    expect(TETO_DA_SESSAO_MS).toBe(12 * 60 * MINUTO);
  });

  it('vale enquanto houver uso há menos de 30 minutos', () => {
    const sessao = novaSessao(inicio);
    expect(INATIVIDADE_MAXIMA_MS).toBe(30 * MINUTO);
    expect(situacaoDaSessao(sessao, usuarioAtivo, depois(29 * MINUTO))).toBe('valida');
    expect(situacaoDaSessao(sessao, usuarioAtivo, depois(30 * MINUTO))).toBe('expirada');
  });

  it('expira no teto de 12 h mesmo com uso contínuo', () => {
    const sessao = { ...novaSessao(inicio), ultimoUso: depois(12 * 60 * MINUTO - MINUTO) };
    expect(situacaoDaSessao(sessao, usuarioAtivo, depois(12 * 60 * MINUTO - 1))).toBe('valida');
    expect(situacaoDaSessao(sessao, usuarioAtivo, depois(12 * 60 * MINUTO))).toBe('expirada');
  });

  it('cai quando o usuário é desativado ou bloqueado', () => {
    const sessao = novaSessao(inicio);
    expect(situacaoDaSessao(sessao, { ...usuarioAtivo, ativo: false }, depois(MINUTO))).toBe('usuario-indisponivel');
    expect(situacaoDaSessao(sessao, { ...usuarioAtivo, bloqueadoAte: depois(10 * MINUTO) }, depois(MINUTO))).toBe(
      'usuario-indisponivel',
    );
  });

  it('atualiza o último uso no máximo uma vez por minuto', () => {
    const sessao = novaSessao(inicio);
    expect(precisaTocar(sessao, depois(59_000))).toBe(false);
    expect(precisaTocar(sessao, depois(MINUTO))).toBe(true);
  });
});

describe('bloqueio por senha errada', () => {
  it('bloqueia por 15 minutos na 5ª falha seguida', () => {
    expect(TENTATIVAS_ATE_BLOQUEIO).toBe(5);
    expect(BLOQUEIO_MS).toBe(15 * MINUTO);
    let estado = { ...usuarioAtivo };
    for (let i = 1; i <= 4; i++) {
      const r = aposFalha(estado, inicio);
      expect(r.bloqueou).toBe(false);
      expect(r.tentativasFalhas).toBe(i);
      estado = { ...estado, ...r };
    }
    const quinta = aposFalha(estado, inicio);
    expect(quinta.bloqueou).toBe(true);
    expect(quinta.bloqueadoAte).toEqual(depois(15 * MINUTO));
    expect(estaBloqueado({ ...estado, ...quinta }, depois(14 * MINUTO))).toBe(true);
    expect(estaBloqueado({ ...estado, ...quinta }, depois(15 * MINUTO))).toBe(false);
  });

  it('acerto zera o contador', () => {
    expect(aposAcerto()).toEqual({ tentativasFalhas: 0, bloqueadoAte: null });
  });

  it('depois que o bloqueio vence, a contagem recomeça do zero', () => {
    const vencido = { ativo: true, tentativasFalhas: 0, bloqueadoAte: depois(-MINUTO) };
    const r = aposFalha(vencido, inicio);
    expect(r).toEqual({ tentativasFalhas: 1, bloqueadoAte: null, bloqueou: false });
  });
});
