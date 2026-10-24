# Feature Specification: Consulta de clientes na web (primeira entrega)

**Feature Branch**: `claude/tender-archimedes-nhe0fh` (spec `001-consulta-clientes`)

**Created**: 2026-10-24

**Status**: Draft

**Input**: User description: "Primeira entrega da versão web, só de leitura: entrar com usuário próprio, navegar por uma
barra lateral, pesquisar clientes, ver a ficha do cliente com a conta corrente e as peças compradas, e emitir o
relatório de clientes cadastrados, convivendo com o sistema desktop no mesmo banco." Fonte das regras:
`docs/legado/10-clientes.md` (RN-CLI-001 a 022), `docs/legado/90-banco.md` e a constituição.

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Encontrar um cliente (Priority: P1)

Na loja, a pessoa entra na web com o próprio usuário, abre "Clientes" na barra lateral e encontra um cliente digitando
parte do nome, do nome de mala direta ou do telefone. A lista mostra os dados que ela usa para reconhecer o cliente
sem abrir a ficha.

**Why this priority**: é o uso mais frequente do cadastro e prova, de ponta a ponta, que a web lê o mesmo banco do
desktop: entrada, navegação e consulta.

**Independent Test**: com um usuário cadastrado, entrar, abrir Clientes, pesquisar um cliente conhecido e conferir que
ele aparece com os mesmos dados que o desktop mostra.

**Acceptance Scenarios**:

1. **Given** um usuário cadastrado e ativo, **When** ele informa usuário e senha corretos, **Then** entra na web e vê
   a barra lateral com o grupo "Cadastros › Clientes".
2. **Given** a tela de clientes aberta, **When** a pessoa digita parte de um nome, **Then** a lista mostra só os
   clientes cujo nome, nome de mala direta ou telefone contém o texto, sem diferenciar maiúsculas, minúsculas e
   acentos.
3. **Given** um cliente marcado como oculto, **When** a pessoa pesquisa por ele, **Then** ele não aparece; **When**
   ela liga "mostrar ocultos", **Then** ele aparece, identificado como oculto.
4. **Given** um cliente cadastrado só com o nome de mala direta, **When** ele aparece na lista, **Then** o nome
   exibido é o de mala direta.
5. **Given** usuário ou senha errados, **When** a pessoa tenta entrar, **Then** a entrada é recusada com uma mensagem
   que não revela qual dos dois está errado.

---

### User Story 2 - Consultar a ficha do cliente (Priority: P2)

A partir da lista, a pessoa abre a ficha do cliente e vê o cadastro completo e a conta corrente do cliente
(lançamentos de vendas, consertos e da própria conta corrente), sem poder alterar nada.

**Why this priority**: é o segundo uso mais comum (conferir endereço, telefone, medidas, situação da conta) e exercita
a leitura das tabelas mais compartilhadas com o desktop.

**Independent Test**: abrir a ficha de clientes escolhidos (com e sem conta corrente) e conferir campo a campo e
lançamento a lançamento com a ficha do desktop.

**Acceptance Scenarios**:

1. **Given** um cliente na lista, **When** a pessoa abre a ficha, **Then** vê título, nome, nome de mala direta,
   endereço, bairro, cidade, UF, CEP, telefone, e-mail, CPF, aniversário, medidas, indicação e data de cadastro.
2. **Given** a ficha aberta, **When** o cliente tem lançamentos de conta corrente, **Then** eles aparecem com data,
   operação (venda, conserto ou lançamento), forma de pagamento e valor, iguais aos do desktop.
3. **Given** a ficha aberta, **When** a pessoa procura um jeito de editar, **Then** não encontra: todos os campos são
   só leitura nesta entrega.
4. **Given** um cliente sem data de cadastro (a maioria), **When** a ficha abre, **Then** o campo aparece vazio, sem
   erro.

---

### User Story 3 - Ver as peças compradas pelo cliente (Priority: P3)

Na ficha, a pessoa vê a lista de peças que o cliente comprou, da mais recente para a mais antiga.

**Why this priority**: responde à pergunta comum "o que essa cliente já comprou?" (presentes, medidas, conjuntos),
mas depende da ficha (P2).

**Independent Test**: para clientes escolhidos (muitas compras, nenhuma compra, venda sem peça), comparar a lista com a
tela "Compras" do desktop.

**Acceptance Scenarios**:

1. **Given** um cliente com compras, **When** a pessoa abre "Peças compradas", **Then** vê, para cada peça, a data da
   venda, o número da venda, o modelo da peça com a classe, a descrição e as observações da peça, da mais recente
   para a mais antiga.
2. **Given** um cliente sem compras, **When** a pessoa abre "Peças compradas", **Then** vê um aviso de que não há
   compras registradas.

---

### User Story 4 - Emitir o relatório de clientes cadastrados (Priority: P4)

A pessoa abre "Relatórios › Clientes cadastrados", escolhe um período (ou "sem período") e vê a lista de clientes
cadastrados, que pode imprimir.

**Why this priority**: é o primeiro relatório da web e serve para validar o método de conferência contra o desktop
(golden master), mas tem uso menos frequente.

**Independent Test**: emitir o relatório nos períodos de referência e em "sem período" e comparar contagem e linhas com
o relatório do desktop.

**Acceptance Scenarios**:

1. **Given** a tela do relatório, **When** ela abre, **Then** o período padrão é o mês corrente.
2. **Given** um período escolhido, **When** a pessoa emite o relatório, **Then** vê os clientes com data de cadastro
   no período, com nome de exibição, aniversário, endereço, bairro, telefone, e-mail e data de cadastro, e a contagem
   bate com a do desktop.
3. **Given** "sem período" marcado, **When** a pessoa emite o relatório, **Then** vê todos os clientes com nome de
   exibição, e a contagem bate com a do desktop.
4. **Given** o relatório na tela, **When** a pessoa manda imprimir, **Then** sai uma versão própria para papel A4, com
   título, período e data de emissão.

---

### Edge Cases

- Cliente sem nome e sem nome de mala direta (111 no banco): não aparece em lista nem em relatório (RN-CLI-001).
- Nomes repetidos (36): a lista mostra os dois, e a pessoa distingue pelos outros dados (telefone, endereço).
- Venda, conserto ou lançamento de conta corrente de cliente que não existe mais (órfãos: 1.944 vendas, 688 consertos,
  428 lançamentos): não aparecem na ficha de nenhum cliente e não causam erro em nenhuma tela.
- Registro alterado pelo desktop enquanto a ficha está aberta na web: ao reabrir ou atualizar, a ficha mostra o dado
  novo.
- Banco indisponível ou lento: a pessoa vê uma mensagem clara de que o sistema não conseguiu consultar, e não uma tela
  em branco.
- Sessão expirada: a pessoa volta para a tela de entrada e, depois de entrar, retorna à tela onde estava.
- Usuário desativado com sessão aberta: perde o acesso na próxima ação.
- Pesquisa que retorna milhares de clientes (texto muito curto): o resultado chega paginado, sem travar a tela.

## Requirements *(mandatory)*

### Functional Requirements

**Acesso**

- **FR-001**: O sistema DEVE exigir usuário e senha individuais para qualquer tela. A senha compartilhada do desktop não
  vale na web (constituição V.2).
- **FR-002**: O sistema DEVE guardar senhas de forma irreversível, bloquear temporariamente o usuário após tentativas
  seguidas de senha errada e encerrar a sessão após um período sem uso.
- **FR-003**: O sistema DEVE ter perfis de acesso. Nesta entrega: [NEEDS CLARIFICATION: quais perfis existem e o que
  cada um vê nesta entrega, em especial CPF e valores da conta corrente?]
- **FR-004**: O sistema DEVE permitir criar, desativar e redefinir a senha de usuários por meio de [NEEDS CLARIFICATION:
  uma tela de administração para o dono, ou um procedimento técnico executado pelo responsável pelo sistema?]

**Navegação**

- **FR-005**: O sistema DEVE ter uma barra lateral com os grupos da proposta de navegação (`docs/legado/01-modulos.md`).
  Nesta entrega só aparecem os itens disponíveis: "Cadastros › Clientes" e "Relatórios › Clientes cadastrados".
- **FR-006**: O sistema DEVE mostrar o nome do usuário conectado e permitir sair.

**Lista de clientes**

- **FR-007**: A lista DEVE considerar como cliente só quem tem nome ou nome de mala direta (RN-CLI-001).
- **FR-008**: O nome de exibição DEVE ser o nome e, na falta dele, o nome de mala direta (RN-CLI-002).
- **FR-009**: A lista DEVE mostrar, por cliente: nome de exibição, título, nome de mala direta, endereço, bairro,
  telefone e aniversário.
- **FR-010**: A pesquisa DEVE procurar o texto digitado no nome, no nome de mala direta e no telefone, sem diferenciar
  maiúsculas, minúsculas e acentos.
- **FR-011**: Clientes ocultos (`Oculto = 1`, inclusive os 2.188 já marcados) NÃO PODEM aparecer na lista, a menos que a
  pessoa ligue "mostrar ocultos"; nesse caso aparecem identificados (RN-CLI-018, decisão do dono).
- **FR-012**: A lista DEVE ser paginada e ordenada pelo nome de exibição.

**Ficha do cliente**

- **FR-013**: A ficha DEVE mostrar todos os campos de cadastro listados no cenário 2.1 e nenhum dos campos sem uso
  (`Fax`, `CPF_MD`, `Saldo`; RN-CLI-022). O CPF aparece formatado (`000.000.000-00`).
- **FR-014**: A ficha DEVE mostrar os lançamentos de conta corrente do cliente como o desktop mostra (data, operação,
  forma, valor), a partir da mesma fonte de dados do desktop (view `CC`; RN-CLI-017).
- **FR-015**: Nesta entrega, nenhuma tela pode gravar dados de clientes, vendas, consertos ou conta corrente.

**Peças compradas**

- **FR-016**: A ficha DEVE oferecer a lista de peças compradas pelo cliente: data da venda, número da venda, classe e
  modelo da peça, descrição e observações, da mais recente para a mais antiga.
- **FR-017**: A lista de peças compradas NÃO PODE mostrar custo nem margem das peças.

**Relatório "Clientes cadastrados"**

- **FR-018**: O relatório DEVE filtrar por data de cadastro entre duas datas (padrão: mês corrente) ou "sem período"
  (todos), considerando só clientes com nome de exibição (RN-CLI-012).
- **FR-019**: O relatório DEVE mostrar nome de exibição, aniversário, endereço, bairro, telefone, e-mail e data de
  cadastro, com a contagem de clientes.
- **FR-020**: O relatório DEVE ter versão para impressão em A4, com título, período e data de emissão.
- **FR-021**: O relatório DEVE incluir os clientes ocultos, como o desktop faz, para os números baterem.

**Convivência e dados pessoais**

- **FR-022**: A web NÃO PODE alterar nenhum objeto existente do banco nem depender do SQL de manutenção que o desktop
  roda (constituição I.1, I.5). Tabelas novas da web (usuários, sessões) ficam no schema `web`.
- **FR-023**: A web NÃO PODE alterar o que a view `VI_Pecas_Web` devolve ao terceiro sistema (constituição I.6).
- **FR-024**: Dados pessoais de clientes NÃO PODEM aparecer em registros de log (constituição V.3).
- **FR-025**: O sistema DEVE registrar entradas, saídas e tentativas de entrada recusadas, com usuário, data e hora.

### Key Entities *(include if feature involves data)*

- **Usuário da web**: pessoa que entra na web. Nome, login, perfil, situação (ativo/inativo), último acesso. Novo, no
  schema `web`.
- **Cliente**: cadastro existente em `Clientes`, lido como está. Atributos em `docs/legado/10-clientes.md` §2.
- **Lançamento de conta corrente**: linha da view `CC` (venda, conserto ou lançamento marcado como "na CC"): data,
  operação, forma, valor, cliente.
- **Peça comprada**: item de uma venda do cliente (`VENDAS` → `[VENDAS DET]` → `[1TabPeças]`): data e número da
  venda, classe, modelo, descrição, observações.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: A pessoa encontra um cliente conhecido e abre a ficha em menos de 15 segundos a partir da tela inicial.
- **SC-002**: A pesquisa responde em até 1 segundo em 95% das buscas, com o cadastro atual (cerca de 5.300 clientes),
  no servidor da loja e com o desktop em uso.
- **SC-003**: Em 20 clientes sorteados, a lista e a ficha da web mostram exatamente os mesmos dados que o desktop
  (cadastro, lançamentos de conta corrente e peças compradas).
- **SC-004**: O relatório "Clientes cadastrados" bate com o desktop em contagem e conteúdo nos dois períodos de
  referência e em "sem período" (golden master; constituição III).
- **SC-005**: Durante um dia de uso em paralelo, o desktop e o terceiro sistema continuam funcionando sem nenhuma
  diferença percebida pelos usuários.
- **SC-006**: Nenhum dado de cliente aparece nos registros de log da web.

## Assumptions

- Quem usa: o dono e as vendedoras da loja, na rede da loja (intranet), em computadores com navegador atualizado.
  Uso em celular fica fora desta entrega.
- [NEEDS CLARIFICATION: esta entrega vai para uso diário na loja, junto com o desktop, ou só para validação pelo dono
  antes de ser liberada para as vendedoras?]
- A edição de clientes (criar, editar, ocultar, busca de CEP, validação de CPF), as etiquetas, a lista de e-mails e a
  venda aberta a partir do cliente ficam para a próxima entrega (`docs/legado/10-clientes.md` §9).
- O relatório completo de peças compradas com valores, custo e margem (`VendasCliente` no desktop) fica fora desta
  entrega; aqui a lista mostra só as peças.
- A grade de conta corrente mostra os lançamentos como estão. Abrir a venda, o conserto ou o lançamento de origem a
  partir dela (RN-CLI-017) fica para quando esses módulos existirem na web.
- Os clientes ocultos continuam aparecendo no desktop até ele ser ajustado (pendência registrada em
  `docs/legado/10-clientes.md` §7).
- O golden master é capturado no contêiner Docker, com o roteiro no repositório e os dados fora dele.
- Escolha de tecnologia, estrutura do código e implantação são decididas no plano (`/speckit-plan`) e nos ADRs.
