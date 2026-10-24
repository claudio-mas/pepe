# Catálogo do banco — análise

Análise da saída de `Pepe/Scripts/Exportar-Catalogo.ps1` em [`banco/`](banco/README.md), capturada em 24/10/2026
na cópia de desenvolvimento (contêiner Docker, restaurada de um backup da loja). Os números são da cópia: a produção
segue mudando, mas a estrutura é a mesma.

## 1. Visão geral

| Item | Valor | Fonte |
|---|---|---|
| Servidor da cópia | SQL Server 2022 (16.0), Developer | `00_banco.csv` |
| **Nível de compatibilidade** | **120** (SQL Server 2014), herdado do backup | `00_banco.csv` |
| Collation | `Latin1_General_CI_AS` | `00_banco.csv` |
| Tabelas | 44 | `01_tabelas.csv` |
| Views | 65 | `06_modulos.csv` |
| Procs | 19 | `06_modulos.csv` |
| Funções escalares | 3 (`fPeças`, `GetNumeric`, `TiraLetras`) | `06_modulos.csv` |
| **FKs declaradas** | **nenhuma** | `04_fks.csv` |
| **Gatilhos** | **nenhum** | `08_gatilhos.csv` |

Consequências para a web:
- **Integridade referencial só existe no código.** Nada impede registros órfãos, e eles existem (§3).
- **Sem gatilhos**: toda regra de gravação está no desktop ou nas procs. A web precisa reproduzi-las (constituição I.4).
- **Nível 120**: as consultas da web devem ser testadas com esse nível de compatibilidade.
- **Produção é SQL Server Express**, com cerca de 650 MB (informação do dono, 24/10/2026). O limite de 10 GB por banco
  está longe. Os limites de memória e de CPU do Express entram no ADR de implantação: a web vai dividir o mesmo
  servidor com o desktop e com o outro sistema (§6).

## 2. Concorrência: `SSMA_TimeStamp`

A coluna `rowversion` herdada da migração do Access existe em 19 tabelas:

`1TabPeças`, `1TabPeçasOld`, `Aniversariantes`, `Cartões`, **`Clientes`**, `CONSERTOS`, `Conta Corrente`,
`Contatos`, `Despesas`/`DespesasOld`, `GASTO OFICINA`, `METAIS`, `PEDRAS`, `Pres`, `Vencto Cartão`,
`Vencto Cheques`, `VENDAS`, `VENDAS DET`, `VENDAS1`.

Não têm: `1TabPeçasHistórico`, `Cotação`, `Reajustes`, `Saidas`, `TiposSaidas`, `Vendedoras`, `getnet`, as tabelas
`tab*` e `tabcep`.

Regra para o ADR de convivência: onde houver `SSMA_TimeStamp`, a web grava com
`WHERE <pk> = @id AND SSMA_TimeStamp = @versao` e trata 0 linhas como conflito. Onde não houver, compara os valores
originais das colunas editadas.

## 3. Integridade: registros órfãos

| Medida | Valor | Fonte |
|---|---|---|
| Vendas com cliente que não existe mais | **1.944** de 15.611 | `12_medidas.csv` |
| Vendas sem cliente (`IDCliente` nulo) | 514 | `12_medidas.csv` |
| Consertos com cliente que não existe mais | **688** de 4.848 | `12_medidas.csv` |
| Lançamentos de CC com cliente que não existe mais | **428** de 4.747 | `12_medidas.csv` |

Isso confirma RN-CLI-008: excluir cliente no desktop deixa o histórico órfão. A web precisa:
- mostrar vendas, consertos e CC de cliente inexistente sem quebrar (`LEFT JOIN`, nome "cliente excluído");
- nos golden masters, conferir que os relatórios contam os órfãos do mesmo jeito que o desktop;
- impedir novos órfãos (RN-CLI-018).

## 4. Tabelas por papel

| Papel | Tabelas |
|---|---|
| Núcleo | `Clientes` (5.279), `VENDAS` (15.611), `VENDAS DET` (20.713), `1TabPeças` (23.118), `METAIS` (21.936), `PEDRAS` (14.822), `CONSERTOS` (4.848), `Conta Corrente` (4.747), `Vencto Cartão` (18.806), `Vencto Cheques` (8.851) |
| Cadastros auxiliares | `Cartões` (24), `Vendedoras` (13), `TiposSaidas` (13), `Classes` (8), `FORMAS` (5), `Cotação` (25), `tabMatPrima` (108), `tabMateriaPrima` (9) |
| Movimento | `Saidas` (287), `Reajustes` (6), `1TabPeçasHistórico` (3.265), `getnet` (1.852) |
| Tabelas de trabalho (apagadas e refeitas pelo desktop) | `tabCartões`, `tabCartõesRpt`, `tabCheques`, `tabChequesRpt`, `tabExtrato`, `getnet_temp` |
| Referência externa | `tabcep` (909.585 CEPs, **sem PK nem índice**) |
| Legado / cópias | `1TabPeçasOld`, `CotaçãoOld`, `DespesasOld`, `SenhaOld`, `VendedorasOld`, `CCFIX_v1_Backup` (backup do script `CCFIX_v1`) |
| Vazias | `Despesas`, `Pres`, `VENDAS1` |
| Sem uso no código deste repositório (a confirmar) | `Aniversariantes` (275), `Contatos` (120), `Compras` (10.629, usada só pelo `ComprasSub` do `dsNovo`), `PeçasEstoque` (590), `GASTO OFICINA` (5), `Senha` (3) |

`Classes`, `PeçasEstoque` e `tabcep` não têm chave primária.

## 5. Índices e desempenho

Só 21 índices fora das PKs (`05_indices.csv`). Faltam índices nas colunas que a web vai consultar muito:
- `tabcep.cep`: a busca de CEP varre 909 mil linhas a cada consulta;
- `CONSERTOS.CLIENTE` e `[Conta Corrente].Cliente`: a ficha do cliente e a regra "tem histórico?" (RN-CLI-018) varrem as tabelas;
- `Clientes.Nome`: há índice só em `Cliente` (mala direta), mas a pesquisa da lista é por nome.

Criar índice é aditivo, mas mexe em tabela existente. A constituição (I.1) proíbe alterar objeto existente: decidir no
ADR de convivência se índices novos são permitidos (proposta: sim, com prefixo `IX_WEB_` e par `_up`/`_down`).

## 6. Views e procs

- **Família CC** (~30 views: `CC`, `CC2`, `CCCartãoCC`, `CCCashVenda`, `CCRpt1`, `CCRpt22`, `CCNovoGer`…): a conta
  corrente não é uma tabela, e sim uma **união de vendas, consertos e lançamentos** marcados como "na CC" (`CartãoCC`,
  `CashCC`, `ChequeCC`, `DolarCC`, `OuroCC`, `CCDeb`). A view `CC`, usada na ficha do cliente, faz isso com `UNION ALL`
  de `CONSERTOS`, `VENDAS` e `[Conta Corrente]`. O inventário do módulo CC parte daqui.
- **`NVendasBase`** (usada em "Clientes sem compras"): última compra por **nome** de cliente, sobre a view
  `NVendasBase0`. Clientes com o mesmo nome se misturam (há 36 nomes repetidos).
- **Getnet**: `getnet1` a `getnet5`, `VI_Getnet`, `VI_Getnet_Base`.
- **Relatórios**: `VI_*` (legado) e `VW_RG2_*` (novo).
- **`VI_Pecas_Web`** (criada em 08/2025, alterada em 05/2026): catálogo de peças com foto, pedras, ouro e última
  venda. Nenhum código deste repositório a usa. **O dono confirmou que há outro sistema usando o `BDTorras`, e ele
  precisa continuar funcionando.**
- Views `Beth` (02/2025) e `BasePrecos` (09/2025): também sem uso neste repositório; tratadas como do outro sistema.
- Objetos de que essas views dependem (`09_dependencias.csv`), que portanto **não podem mudar de forma nem de
  significado**: `1TabPeças`, `METAIS`, `PEDRAS`, `VENDAS`, `[VENDAS DET]`, `Clientes` e `PeçasEstoque`. Isso vale
  também para os dados: `VI_Pecas_Web` mostra o nome do cliente da última venda, então ocultar cliente não pode mexer
  em `Clientes.Nome`.
- Procs: as 19 citadas pelo desktop (`USP_*`). Parâmetros em `07_parametros.csv`; código em `banco/modulos/`.

## 7. Respostas para o inventário de Clientes

| Pergunta (`10-clientes.md`) | Resposta |
|---|---|
| `Clientes` tem `SSMA_TimeStamp`? | **Sim**. A web usa a coluna para detectar conflito de edição (§2). |
| Há FK para `Clientes`? | **Não**. Excluir não falha, e por isso há órfãos (§3). |
| Quantos clientes têm histórico? | **4.129** de 5.279 (3.630 com vendas, 1.408 com consertos, 503 com CC). Sem histórico: 1.150. |
| `CC` é view? | Sim: união de vendas, consertos e lançamentos marcados como CC (§6). |
| `NVendasBase`? | View de última compra por nome (§6). |
| `tabcep`? | Tabela com 909.585 CEPs, sem índice (§5). |
| CPF guarda só dígitos? | Sim: os 845 CPFs preenchidos têm 11 dígitos. A coluna tem 11 caracteres. |
| Clientes "existentes" (RN-CLI-001) | 5.168. Há 111 linhas sem `Nome` nem `Cliente`. |
| **`Oculto` sem uso?** | **Não**: **2.188 clientes já têm `Oculto = 1`** (2.714 com 0, 377 nulos), embora nenhum código deste repositório leia ou grave a coluna. Ver §8. |
| `DataCad` | `date`; **4.906 dos 5.279 clientes não têm data de cadastro**. Os preenchidos vão de 02/2000 a 09/2026. |
| Nomes repetidos (RN-CLI-014) | 36 nomes aparecem mais de uma vez. |
| Venda "Interna" é exceção? | Não: **15.268 de 15.611** vendas são `Tipo = 'Interna'`. É o tipo normal. |
| Marcados para etiqueta | 1. |

## 8. Decisões do dono (24/10/2026)

| # | Pergunta | Decisão |
|---|---|---|
| 1 | 2.188 clientes já têm `Oculto = 1`. O que fazer? | **Usar `Oculto` como está**, aceitando que esses clientes somem da lista e dos combos da web (RN-CLI-018). |
| 2 | Há outro sistema usando o `BDTorras`? | **Sim, e ele precisa continuar funcionando.** As views `VI_Pecas_Web`, `Beth`, `BasePrecos` e os objetos de que dependem ficam protegidos (§6; constituição I.6). |
| 3 | A web precisa de `Aniversariantes`, `Contatos`, `Compras`, `PeçasEstoque`, `GASTO OFICINA`, `Senha`? | **Não.** Ficam no banco intocadas (`PeçasEstoque` é usada pela `BasePrecos`, do outro sistema). |
| 4 | 93% dos clientes sem `DataCad`: o relatório por período só mostra os recentes. Esperado? | **Sim, é esperado.** Na web, `DataCad` passa a ser sempre gravada. |
| 5 | Versão do SQL Server da loja | **SQL Server Express, banco com cerca de 650 MB** (§1). |

Sobre o outro sistema (dono, 24/10/2026): ele **só lê** o banco e é mantido pelo próprio dono. Como não grava, não
disputa registros com a web nem com o desktop. O cuidado se resume a não mudar o que ele lê (constituição I.6).
Pendente: confirmar se ele lê algum objeto além das três views.
