// Formatação pt-BR da interface (constituição VI.3). A API manda valores tipados; só a tela formata.
// Valor nulo, indefinido ou inválido vira texto vazio, nunca "null", "undefined" ou "NaN".

type Vazio = null | undefined;

const ISO_DATA = /^(\d{4})-(\d{2})-(\d{2})/;
const dois = (n: number) => String(n).padStart(2, '0');

/**
 * Data em `dd/MM/aaaa`. Texto ISO (`2026-03-10` ou `2026-03-10T00:00:00.000Z`) é lido pelos dígitos, sem converter
 * fuso: as datas do legado não têm fuso, e a API as manda como vieram do banco.
 */
export function formatarData(valor: string | Date | Vazio): string {
  if (valor == null || valor === '') return '';
  if (typeof valor === 'string') {
    const partes = ISO_DATA.exec(valor);
    return partes ? `${partes[3]}/${partes[2]}/${partes[1]}` : '';
  }
  if (Number.isNaN(valor.getTime())) return '';
  return `${dois(valor.getDate())}/${dois(valor.getMonth() + 1)}/${valor.getFullYear()}`;
}

/** Data e hora local em `dd/MM/aaaa HH:mm`, a partir de um instante ISO com fuso (ex.: `emitidoEm` da API). */
export function formatarDataHora(valor: string | Date | Vazio): string {
  if (valor == null || valor === '') return '';
  const data = typeof valor === 'string' ? new Date(valor) : valor;
  if (Number.isNaN(data.getTime())) return '';
  return `${formatarData(data)} ${dois(data.getHours())}:${dois(data.getMinutes())}`;
}

const moeda = new Intl.NumberFormat('pt-BR', { style: 'currency', currency: 'BRL' });
const numero = new Intl.NumberFormat('pt-BR', { minimumFractionDigits: 2, maximumFractionDigits: 2 });

/** Moeda em `R$ 1.234,56` (o espaço depois do R$ é não separável, para não quebrar a linha). */
export function formatarMoeda(valor: number | Vazio): string {
  if (valor == null || !Number.isFinite(valor)) return '';
  return moeda.format(valor);
}

/** Número com duas casas e vírgula decimal (`1.234,56`), para colunas em que o R$ fica no título. */
export function formatarNumero(valor: number | Vazio): string {
  if (valor == null || !Number.isFinite(valor)) return '';
  return numero.format(valor);
}

/**
 * CPF em `000.000.000-00` quando o texto tem 11 dígitos. O CPF do legado é texto livre: o que não tiver
 * 11 dígitos aparece como foi gravado, sem os espaços das pontas.
 */
export function formatarCpf(valor: string | Vazio): string {
  if (valor == null) return '';
  const digitos = valor.replace(/\D/g, '');
  if (digitos.length !== 11) return valor.trim();
  return `${digitos.slice(0, 3)}.${digitos.slice(3, 6)}.${digitos.slice(6, 9)}-${digitos.slice(9)}`;
}

/** Texto livre: vazio no lugar de nulo, sem os espaços das pontas. */
export function formatarTexto(valor: string | Vazio): string {
  return valor == null ? '' : valor.trim();
}
