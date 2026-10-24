// T025: formatação pt-BR (constituição VI.3).
import { describe, expect, it } from 'vitest';

import { formatarCpf, formatarData, formatarMoeda, formatarNumero, formatarTexto } from './formatacao';

const NBSP = ' ';

describe('formatarData', () => {
  it('formata texto ISO sem mudar o dia por causa do fuso', () => {
    expect(formatarData('2026-03-10')).toBe('10/03/2026');
    expect(formatarData('2026-03-10T00:00:00.000Z')).toBe('10/03/2026');
    expect(formatarData('1999-12-31T23:59:59Z')).toBe('31/12/1999');
  });

  it('formata Date pelo calendário local', () => {
    expect(formatarData(new Date(2026, 0, 5))).toBe('05/01/2026');
  });

  it('nulo, vazio e inválido viram texto vazio', () => {
    for (const valor of [null, undefined, '', 'ontem', new Date('x')]) expect(formatarData(valor)).toBe('');
  });
});

describe('formatarMoeda', () => {
  it('usa R$, ponto de milhar e vírgula decimal', () => {
    expect(formatarMoeda(1234.56)).toBe(`R$${NBSP}1.234,56`);
    expect(formatarMoeda(0)).toBe(`R$${NBSP}0,00`);
    expect(formatarMoeda(1_000_000)).toBe(`R$${NBSP}1.000.000,00`);
    expect(formatarMoeda(-200)).toBe(`-R$${NBSP}200,00`);
    expect(formatarMoeda(0.005)).toBe(`R$${NBSP}0,01`);
  });

  it('nulo e não numérico viram texto vazio', () => {
    for (const valor of [null, undefined, Number.NaN, Number.POSITIVE_INFINITY]) expect(formatarMoeda(valor)).toBe('');
  });
});

describe('formatarNumero', () => {
  it('duas casas com vírgula decimal', () => {
    expect(formatarNumero(1234.5)).toBe('1.234,50');
    expect(formatarNumero(null)).toBe('');
  });
});

describe('formatarCpf', () => {
  it('pontua 11 dígitos, venham ou não pontuados', () => {
    expect(formatarCpf('12345678909')).toBe('123.456.789-09');
    expect(formatarCpf(' 123.456.789-09 ')).toBe('123.456.789-09');
  });

  it('mantém como foi gravado o que não tem 11 dígitos', () => {
    expect(formatarCpf('1234567')).toBe('1234567');
    expect(formatarCpf(' não informado ')).toBe('não informado');
  });

  it('nulo vira texto vazio', () => {
    expect(formatarCpf(null)).toBe('');
    expect(formatarCpf(undefined)).toBe('');
  });
});

describe('formatarTexto', () => {
  it('nulo vira vazio e as pontas perdem os espaços', () => {
    expect(formatarTexto(null)).toBe('');
    expect(formatarTexto('  Maria  ')).toBe('Maria');
  });
});
