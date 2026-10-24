# Inventário — CLI (Clientes)

Módulo escolhido para a **fatia vertical de validação** da web (ver `docs/web/README.md`, Fase 4). Caminhos relativos
a `Pepe/`. Convenções: `RN-CLI-nnn` = regra de negócio; **Confiança**: alta (lida no código), média (inferida do
código), "a confirmar" (precisa do dono).

## 1. Telas e relatórios do módulo

| Tela / relatório | Papel | Fonte de dados |
|---|---|---|
| `frmClientesDG` | Lista de clientes com pesquisa; marca clientes para etiqueta; abre ficha, nova venda, etiquetas, listas | `dsNovo.Clientes` (`Datasets/dsNovo.xsd`) |
| `frmClientes` | Ficha do cliente (cadastro) + grade da conta corrente do cliente | `dsCliente.Clientes` (por `IDCliente`) + `dsCliente.CC` (por cliente) |
| `frmCompras` (modal) | Peças compradas pelo cliente | `dsCliente.Compras` (`VENDAS` × `[VENDAS DET]` × `[1TabPeças]`) |
| `frmVendasClienteBase` + `VendasCliente` | Relatório de peças compradas, com ficha clicável | proc `USP_RPT_VENDA_CLIENTE` (`@IdCliente`) |
| `frmEtiquetas` + `rptEtiquetas` | Etiquetas de mala direta dos clientes marcados | SQL em `Relatorios/rptEtiquetas.resx` |
| `frmEtiqAniv` + `rptEtiquetasAniv` | Etiquetas de aniversariantes do mês | SQL em `Relatorios/rptEtiquetasAniv.resx` |
| `ClientesCadastrados` + `ClientesCadastradosRpt` | Clientes cadastrados no período (ou todos) + exportação Excel | SQL em `.resx` / `.Designer.vb` |
| `ClientesSemComprasBase` + `ClientesSemCompras` | Clientes cuja última compra está fora do período | view/tabela `NVendasBase` |
| `ComprasPorClienteBase` + `ComprasPorCliente` | Compras por cliente no período | SQL em `.resx` |
| `GeralClientesBase` + `GeralClientes` | Clientes que compraram nos últimos N meses | SQL em `.resx` |
| `EndereçosClientesBase` + `EndereçosClientes` | Lista de endereços | SQL em `.resx` |
| `TelefonesClientesBase` + `TelefonesClientes` | Lista de telefones | `SelectQuery` no `.Designer.vb` |

## 2. Campos — tabela `Clientes`

Tipos e tamanhos tirados do `Datasets/dsCliente.xsd`. O tipo SQL exato fica para o catálogo do banco (`90-banco.md`).

| Coluna | Tipo (DataSet) | Tam. | Rótulo na tela | Onde aparece | Observação |
|---|---|---|---|---|---|
| `IDCliente` | int, identidade | — | Id | lista, ficha | chave |
| `Título` | string | 10 | Título | lista, ficha, etiquetas | combo fixo: `Dr.`, `Dra.`, `Dr. e Sra.`, `Dra. e Sr.`, `Sr.`, `Sra.`, `Sr. e Sra.` (`frmClientes.Designer.vb:707`) |
| `Nome` | string | 75 | **Cliente** | lista, ficha, todos os relatórios | nome do cliente |
| `Cliente` | string | 50 | **Mala direta** | lista, ficha, etiquetas | nome como sai no envelope/etiqueta (ex.: "Sr. e Sra. Fulano"); **continua na web** (dono). Atenção: a coluna se chama `Cliente`, mas o rótulo é "Mala direta" |
| `Endereço` | string | 80 | Endereço | ficha, relatórios | |
| `Bairro` | string | 20 | Bairro | ficha, relatórios | |
| `Cidade` | string | 20 | Cidade | ficha, relatórios | |
| `Estado` | string | 2 | Estado | ficha, relatórios | UF |
| `CEP` | string | 9 | CEP | ficha, etiquetas | máscara `00000-000` |
| `Telefone` | string | 30 | Telefone | lista, ficha, relatórios | texto livre (pode ter mais de um número) |
| `Fax` | string | 15 | — | só em relatórios antigos | **sem uso**: a web ignora (dono) |
| `Email` | string | 200 | E-mail | ficha, lista de e-mails | sem validação na ficha |
| `CPF` | string | 11 | CPF | ficha | máscara `000.000.000-00`; guarda só dígitos (a confirmar); o desktop não valida. Na web: dígito verificador validado **só em cadastro novo** (RN-CLI-020) |
| `CPF_MD` | string | 11 | — | nenhuma tela | **sem uso**: a web ignora (dono) |
| `Aniv` | dateTime | — | Aniversário | lista, ficha, etiquetas de aniversário | |
| `Indicaçao` | string | 250 | Indicação | ficha | texto livre, também na web (dono) |
| `Medidas` | string | 250 | Medidas | ficha | texto livre, também na web (dono) |
| `Imp` | boolean | — | Etiquetas | lista (checkbox editável) | marcação "imprimir etiqueta", **gravada no banco** |
| `Saldo` | float | — | — | nenhuma tela do módulo | **sem uso** no módulo: a web ignora (dono). O saldo da CC vem das procs do módulo CC |
| `Oculto` | boolean | — | — | nenhuma tela | sem uso no desktop; **passa a ser usado pela web** para ocultar o cliente que não pode ser excluído (RN-CLI-018) |
| `DataCad` | dateTime | — | Data Cadastro | ficha, relatório de cadastrados | preenchida com a data do dia ao criar (`frmClientes.vb:27`) |

Nenhuma coluna é obrigatória no DataSet (todas `minOccurs=0`, menos `IDCliente`).

## 3. Fluxos

### 3.1 Lista (`frmClientesDG`)
1. Ao abrir: carrega `SELECT … FROM Clientes WHERE Nome IS NOT NULL OR Cliente IS NOT NULL` (todos, sem paginação).
2. Painel de pesquisa sempre visível ("Pesquisar...") sobre as colunas da grade; grade só leitura, exceto a coluna `Imp`.
3. Colunas: Id, Título, Mala direta, Cliente, Endereço, Bairro, Telefone, Aniversário, Etiquetas (+ botões "abrir
   ficha" e "nova venda").
4. **Marcar todas / Desmarcar todas** (`ckTodas`): grava `Imp = 1/0` linha a linha em todas as linhas visíveis e salva
   (`frmClientesDG.vb:59-78`). A dica avisa para usar só num grupo filtrado.
5. **Etiquetas mala direta**: salva as marcações; se nenhum cliente tem `Imp = 1`, avisa; senão abre `frmEtiquetas`.
6. **Etiquetas aniversário**: abre `frmEtiqAniv`.
7. **Lista de e-mails**: gera uma planilha no Excel do usuário (automação COM `Microsoft.Office.Interop.Excel`) com os
   e-mails que contêm `@`, de clientes com nome, em ordem alfabética (`frmClientesDG.vb:129-185`).
8. **Endereços / Telefones de clientes**: abrem os relatórios.
9. **Nova venda para o cliente** (botão na linha): cria uma venda "Interna" (ver RN-CLI-010) e abre `frmNewVenda`.
10. Ao fechar: salva o DataSet inteiro (as marcações de `Imp`); erro de gravação é **ignorado em silêncio**
    (`frmClientesDG.vb:29-38`).

### 3.2 Ficha (`frmClientes`)
1. Abre pelo `varIdCliente` global (0 = novo). Carrega o cliente e a grade de CC do cliente (`SELECT Id, Cliente,
   Data, VValor, Tp, Op, Ident FROM CC WHERE Cliente = @IdCli`).
2. Novo cliente: linha nova com `DataCad = hoje`.
3. Qualquer digitação entra em "modo edição": esconde os outros botões e o "X" da janela, mostra Salvar/Desfazer.
4. **Salvar**: `UpdateAll` no DataSet; erro de gravação **ignorado em silêncio** (`frmClientes.vb:91-93`).
5. **Desfazer**: recarrega do banco.
6. **Busca de CEP** (botão "x" ao lado do CEP): procura o CEP sem hífen na tabela local `tabcep` e preenche endereço,
   bairro, cidade e UF; CEP vazio limpa os quatro campos (`frmClientes.vb:286-309`).
7. **Excluir**: pede confirmação e apaga a linha (ver RN-CLI-008).
8. **Compras**: abre `frmCompras` (modal). **Peças compradas**: abre o relatório `VendasCliente`.
9. **Lançamento C/C**: apaga parcelas órfãs (`idcc = -1`) e abre `frmCC` para um lançamento novo.
10. Grade da CC: o botão da linha abre o documento de origem conforme `Op`: `Conserto` → `frmConsertosfrm`,
    `Venda` → `frmNewVenda`, outro → `frmCC` (`frmClientes.vb:246-266`).
11. Enter funciona como Tab entre os campos.

### 3.3 Etiquetas de aniversário (`frmEtiqAniv`)
Filtros: mês de aniversário (obrigatório) e "clientes que compraram nos últimos 'x' **anos**", ou "Todos". O valor
digitado vai para o parâmetro `@meses`, comparado com `DATEDIFF(month, DataVenda, GETDATE())`: na prática o filtro é
em **meses**, não em anos. O dono decidiu que o filtro é em **anos** (RN-CLI-021): a web corrige, e o desktop
continua com o defeito até ser ajustado.

## 4. Regras de negócio

| ID | Regra | Origem | Confiança |
|---|---|---|---|
| RN-CLI-001 | Um cliente "existe" para listas e combos quando tem `Nome` ou `Cliente` (mala direta) preenchido; linhas com os dois nulos são ignoradas. | `dsNovo.xsd` (Clientes Select); `cboClientes` em `dsNovo.xsd`/`dsCliente.xsd` | alta |
| RN-CLI-002 | Nome de exibição do cliente em combos e relatórios = `ISNULL(Nome, Cliente)`. | `cboClientesTableAdapter`; `ClientesCadastradosRpt` | alta |
| RN-CLI-003 | Nome nas etiquetas e na lista de endereços = `ISNULL(Cliente, Nome)` (prefere o nome de mala direta). | `rptEtiquetas.resx`, `rptEtiquetasAniv.resx`, `EndereçosClientes.resx`, `GeralClientes.resx` | alta |
| RN-CLI-004 | `DataCad` recebe a data do dia na criação do cliente. | `frmClientes.vb:27` | alta |
| RN-CLI-005 | Título do cliente vem de uma lista fixa de 7 opções. | `frmClientes.Designer.vb:707` | alta |
| RN-CLI-006 | Endereço pode ser preenchido a partir do CEP pela tabela local `tabcep` (`cep` sem hífen → `logradouro`, `bairro`, `cidade`, `uf`). | `frmClientes.vb:286-309` | alta |
| RN-CLI-007 | Etiqueta de mala direta sai para os clientes com `Imp = 1` e nome de exibição não nulo. A marcação fica gravada no banco até alguém desmarcar. | `frmClientesDG.vb:80-93`; `rptEtiquetas.resx` | alta |
| RN-CLI-008 | Exclusão de cliente apaga só a linha de `Clientes`, sem verificar vendas, consertos ou CC ligados. Se houver FK, o banco recusa e o erro some (salvar ignora erro). | `frmClientes.vb:275-284` | média (FK a confirmar no catálogo). Na web: substituída por RN-CLI-018 |
| RN-CLI-009 | Etiqueta de aniversário: clientes com `Nome` não nulo cujo mês de `Aniv` = mês informado; opcionalmente só os que compraram nos últimos N meses (`@meses` nulo = todos). | `rptEtiquetasAniv.resx`; `frmEtiqAniv.vb` | alta. Na web: filtro em anos (RN-CLI-021) |
| RN-CLI-010 | "Nova venda" a partir do cliente cria em `VENDAS` uma linha `Tipo = 'Interna'` com `DataVenda = hoje` e número `NNNN/aa`: o maior `Venda` do ano corrente + 1 (4 primeiros caracteres), ou `0001/aa` se for a primeira do ano. **Regra do módulo VEN** disparada daqui. | `frmClientesDG.vb:95-122` | alta |
| RN-CLI-011 | Lista de e-mails: e-mails que contêm `@`, de clientes com `Nome` não nulo, ordenados por e-mail. | `frmClientesDG.vb:139` | alta |
| RN-CLI-012 | Clientes cadastrados: filtro por `DataCad` entre as datas (padrão: mês corrente) ou "Sem período" (todos); exportação para Excel só no modo "Sem período". | `Relatorios/ClientesCadastrados.vb` | alta |
| RN-CLI-013 | Clientes sem compras: clientes cuja `Última` compra (em `NVendasBase`) **não** está entre as datas. | `ClientesSemCompras.resx` | alta (definição de `NVendasBase` a levantar) |
| RN-CLI-014 | Compras por cliente no período: nº de vendas e total (`SUM(ValorFinal)`) por nome de cliente, nº de peças e data da última compra no período; vendas sem cliente aparecem como `'S/ Nome'` e somem do resultado final (o JOIN externo é por `Clientes.Nome`). | `ComprasPorCliente.resx` | alta (o comportamento com "S/ Nome" e nomes repetidos merece golden master) |
| RN-CLI-015 | Geral de clientes: clientes que compraram nos últimos N meses (`DATEDIFF(month, DataVenda, GETDATE()) <= N`). | `GeralClientes.resx` | alta |
| RN-CLI-016 | Telefones de clientes: só clientes com `Telefone` não nulo. Endereços de clientes: só com `Endereço` não nulo. | `TelefonesClientes.Designer.vb:76`; `EndereçosClientes.resx` | alta |
| RN-CLI-017 | A grade de CC da ficha abre o documento de origem pelo tipo de operação `Op` (`Conserto`, `Venda` ou outro = lançamento de CC). | `frmClientes.vb:246-266` | alta |

### Regras decididas para a web (dono, 24/10/2026)

Estas regras **mudam** o comportamento do legado. Valem para a web. O desktop só muda se for ajustado à parte (ver §7).

| ID | Regra | Origem | Confiança |
|---|---|---|---|
| RN-CLI-018 | É **proibido excluir** cliente que tenha vendas, consertos ou lançamentos de CC. Nesse caso o cliente é **ocultado** (`Oculto = 1`). Cliente sem histórico pode ser excluído. Substitui RN-CLI-008. | decisão do dono | alta (o que "ocultar" esconde está em §7, como proposta) |
| RN-CLI-019 | A seleção de etiquetas de mala direta é **compartilhada entre os usuários**, como hoje: a web lê e grava `Clientes.Imp`. Confirma RN-CLI-007. | decisão do dono | alta |
| RN-CLI-020 | CPF: o dígito verificador é validado **só em cadastro novo**. CPFs já gravados (válidos ou não) continuam aceitos ao editar. | decisão do dono | alta |
| RN-CLI-021 | Etiquetas de aniversário: o filtro opcional é "compraram nos últimos N **anos**" (`DataVenda >= hoje − N anos`). Substitui a parte "N meses" de RN-CLI-009. | decisão do dono | alta |
| RN-CLI-022 | Campos `Fax`, `CPF_MD` e `Saldo` não aparecem na web. Nada é apagado do banco. `Medidas` e `Indicação` continuam texto livre. O nome de "Mala direta" (`Cliente`) continua. | decisão do dono | alta |

## 5. Matriz CRUD

| Tabela / objeto | C | R | U | D | Quem |
|---|---|---|---|---|---|
| `Clientes` | ficha | todos | ficha; lista (`Imp`) | ficha | `frmClientes`, `frmClientesDG` |
| `CC` (provavelmente view: só `SELECT` nos DataSets) | | ficha | | | `frmClientes` |
| `tabcep` | | ficha | | | `frmClientes` (CEP) |
| `VENDAS` | lista (venda Interna) | relatórios, compras | | | `frmClientesDG`, relatórios |
| `[VENDAS DET]`, `[1TabPeças]` | | compras, relatórios | | | `frmCompras`, `ComprasPorCliente` |
| `[Vencto Cartão]`, `[Vencto Cheques]` | | | | `idcc = -1` | `frmClientes` (Lançamento C/C) |
| `NVendasBase` (view?) | | relatório | | | `ClientesSemCompras` |
| `USP_RPT_VENDA_CLIENTE` | | relatório | | | `VendasCliente` |

## 6. Defeitos e comportamentos do legado que a web não deve copiar

1. **Erros de gravação engolidos**: salvar e fechar ignoram exceções (`frmClientes.vb:91-93`, `frmClientesDG.vb:33-35`).
   O usuário acha que salvou.
2. **Lista não atualiza depois de salvar**: a ficha recarrega `frmClientesDG.ClientesTableAdapter` (`DsPrincipal`),
   mas a grade mostra `DsNovo` via `ClientesTableAdapter1` (`frmClientes.vb:81,281`; `frmClientesDG.Designer.vb:283-307`).
3. **Título errado no relatório de peças compradas**: o cabeçalho usa `frmClientes.ClienteTextEdit`, que é o campo
   "Mala direta", não o nome (`Relatorios/frmVendasClienteBase.vb`). Se a mala direta estiver vazia, sai sem título.
4. **"anos" × meses** nas etiquetas de aniversário (ver 3.3). A web filtra em anos (RN-CLI-021).
5. **"Marcar todas" grava linha a linha**: a marcação compartilhada é intencional (RN-CLI-019), mas a web marca e
   desmarca o conjunto filtrado com um único `UPDATE`, em vez de gravar linha a linha.
6. **SQL concatenado** na busca de CEP e na venda Interna.
7. Botões sem ação na ribbon da lista: `BarButtonItem1` "Lançamento C/C", `BarButtonItem2` "Compras",
   `BarButtonItem3` "Peças compradas" (sem handler em `frmClientesDG.vb`).

## 7. Convivência (desktop + web no mesmo banco)

- Concorrência: os DataSets em uso na lista e na ficha (`dsNovo`, `dsCliente`) **não** leem `SSMA_TimeStamp`. Eles
  detectam conflito comparando os valores originais de todas as colunas no `UPDATE`/`DELETE` (TableAdapter com
  concorrência otimista). Já os DataSets mais antigos `dsGeral` e `dsVendas` leem `Clientes.SSMA_TimeStamp`, então a
  coluna `rowversion` provavelmente existe (confirmar no catálogo do banco). Se existir, a web usa
  `UPDATE … WHERE IDCliente = @id AND SSMA_TimeStamp = @versao`. Senão, compara os valores originais das colunas
  editadas. Nos dois casos, 0 linhas afetadas = conflito com outra edição.
- Etiquetas: a web lê e grava `Clientes.Imp` (RN-CLI-019), então desktop e web enxergam a mesma seleção.
- **Oculto** (RN-CLI-018), proposta a validar na spec:
  - Cliente oculto **some** da lista de clientes e dos combos de escolha de cliente (nova venda, conserto, CC) e não
    recebe etiquetas.
  - **Continua** em relatórios históricos (vendas, consertos, CC, compras por cliente), para os números não mudarem.
  - Pode ser reexibido. A web oferece um filtro "mostrar ocultos" na lista.
  - **O desktop não conhece `Oculto`**: enquanto não for ajustado, ele continua mostrando os ocultos. Pela
    constituição (I.4), a diferença precisa de ADR e, de preferência, de um ajuste no desktop que filtre `Oculto`
    em `frmClientesDG` e nos `cboClientes`. É uma alteração pequena, mas é código do desktop: fica como pendência à parte.
- A lista de e-mails na web vira download de arquivo (CSV/XLSX gerado no servidor). Não depende do Excel instalado.

## 8. Decisões do dono (24/10/2026) e pendências

| # | Pergunta | Resposta |
|---|---|---|
| 1 | O nome de "Mala direta" (`Cliente`) continua? | Sim, continua (RN-CLI-022). |
| 2 | `Medidas` e `Indicação`: estruturar? | Não, continuam texto livre (RN-CLI-022). |
| 3 | Filtro das etiquetas de aniversário: anos ou meses? | Anos (RN-CLI-021). |
| 4 | Seleção de etiquetas compartilhada ou por usuário? | Compartilhada (RN-CLI-019). |
| 5 | Excluir cliente com histórico? | Proibido; nesses casos, ocultar (RN-CLI-018). |
| 6 | Validar CPF? | Dígito verificador, só em cadastro novo (RN-CLI-020). |
| 7 | `Fax`, `CPF_MD`, `Saldo`, `Oculto` têm uso? | Só `Oculto` passa a ter (RN-CLI-018, 022). |
| 8 | Impressora e formato de folha das etiquetas | **Pendente**: o dono vai verificar com a loja. Bloqueia só a spec de etiquetas, não a fatia de validação. |

Pendência derivada: o que exatamente o "ocultar" esconde (proposta em §7) e se o desktop será ajustado para respeitar
`Oculto`.

## 9. Proposta para a fatia de validação (só leitura)

Entra:
- Login (usuários novos, schema `web`) e a sidebar com o grupo "Cadastros › Clientes".
- **Lista de clientes** com pesquisa (RN-CLI-001, 002), paginada no servidor.
- **Ficha do cliente somente leitura**, com a grade de CC do cliente (RN-CLI-017 só como link desabilitado ou para
  telas futuras).
- **Peças compradas** pelo cliente (equivalente ao `frmCompras`/`VendasCliente`).
- Relatório **Clientes cadastrados** no período, com golden master (RN-CLI-012).

A lista da fatia já respeita `Oculto` (RN-CLI-018): os ocultos ficam fora, a não ser com o filtro "mostrar ocultos".

Fica para a etapa seguinte (edição de clientes): criar, editar, excluir e ocultar (concorrência, RN-CLI-004 a 008,
018, 020, 022), busca de CEP, etiquetas (RN-CLI-019, 021; depende da pendência 8), lista de e-mails, venda Interna
(depende do módulo VEN).

### Golden master sugerido para a fatia
- `ClientesCadastradosRpt` em 2 períodos (um mês recente e 02/2021) + modo "Sem período": contagem de linhas e
  conferência de 10 linhas sorteadas.
- Lista de clientes: contagem total com RN-CLI-001 e 20 clientes sorteados (nome de exibição, telefone, aniversário).
- Peças compradas de 5 clientes escolhidos (com muitas compras, com nenhuma, com venda sem peça).
