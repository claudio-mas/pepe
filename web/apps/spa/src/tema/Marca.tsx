// Logotipo da joalheria (pepetorras.com.br). Na entrada, o completo, com o lema "identidade e tradição"; no
// cabeçalho, só o nome, porque o lema fica ilegível na altura da barra. O mesmo arquivo serve ao claro e ao escuro.
import { Image } from '@mantine/core';

import logotipo from './imagens/logotipo.png';
import logotipoNome from './imagens/logotipo-nome.png';

export const NOME_DA_LOJA = 'Pepe Torras';

export function Marca({ tamanho = 'cabecalho' }: { tamanho?: 'cabecalho' | 'entrada' }) {
  return tamanho === 'entrada' ? (
    <Image src={logotipo} alt={NOME_DA_LOJA} h={64} w="auto" fit="contain" />
  ) : (
    <Image src={logotipoNome} alt={NOME_DA_LOJA} h={28} w="auto" fit="contain" />
  );
}
