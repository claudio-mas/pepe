# Data Model: Consulta de clientes na web (001)

Duas partes: as **tabelas novas** da web, no schema `web`, criadas por script `_up`/`_down` (constituição I.2, I.3), e
os **modelos de leitura** sobre o legado, que só leem e nunca gravam (FR-015, R10). Tipos SQL das tabelas legadas
conferidos em `docs/legado/banco/02_colunas.csv`.

## 1. Tabelas novas (schema `web`)

As datas destas tabelas são gravadas pela aplicação, em **UTC** (o tedious usa `useUTC: true`). Os padrões
`SYSDATETIME()` só valem para linhas inseridas à mão no SSMS, que ficam no horário local do servidor.

### `web.Usuario`

| Coluna | Tipo | Regra |
|---|---|---|
| `IdUsuario` | `int IDENTITY` PK | |
| `Login` | `nvarchar(50)` | obrigatório, único, guardado em minúsculas, só letras, dígitos, `.` e `-` |
| `Nome` | `nvarchar(100)` | obrigatório (nome exibido no topo, FR-006) |
| `HashSenha` | `nvarchar(255)` | obrigatório; formato PHC do argon2id (R7). Nunca a senha |
| `Ativo` | `bit` | obrigatório, padrão 1 |
| `TentativasFalhas` | `int` | obrigatório, padrão 0; zera no acerto |
| `BloqueadoAte` | `datetime2(0)` | nulo = não bloqueado |
| `CriadoEm` | `datetime2(0)` | obrigatório, padrão `SYSDATETIME()` |
| `UltimoAcesso` | `datetime2(0)` | atualizado a cada entrada bem-sucedida |

Sem coluna de perfil nesta entrega (R15: um perfil só). A coluna `Perfil` entra junto com os perfis, numa entrega
futura, por um novo par de scripts.

**Estados do usuário**:

```text
          criar                  5 senhas erradas
 (nenhum) ──────▶ ATIVO ──────────────────────────▶ BLOQUEADO
                  ▲  │ ◀───────── 15 min depois ────────┘
        reativar  │  │ desativar
                  │  ▼
                 INATIVO   (sessões abertas são encerradas na próxima ação)
```

Validação: `Login` único (índice único). Senha nova com no mínimo 10 caracteres, checada pelo procedimento técnico
(R8) antes de gerar o hash.

### `web.Sessao`

| Coluna | Tipo | Regra |
|---|---|---|
| `IdSessao` | `char(64)` PK | hash SHA-256 (hex) do identificador do cookie; o identificador em si nunca é gravado |
| `IdUsuario` | `int` | FK → `web.Usuario` (FK só entre tabelas novas; nenhuma FK para o legado) |
| `CriadaEm` | `datetime2(0)` | obrigatório |
| `UltimoUso` | `datetime2(0)` | atualizado a cada requisição (no máximo uma vez por minuto, para não gravar demais no Express) |
| `ExpiraEm` | `datetime2(0)` | `CriadaEm` + 12 h (teto absoluto) |

Uma sessão é **válida** quando: existe, `SYSDATETIME() < ExpiraEm`, `UltimoUso` foi há menos de 30 minutos e o usuário
está `Ativo` e não bloqueado (R7). Sair apaga a linha. Sessões vencidas são apagadas na entrada seguinte do mesmo
usuário e por uma limpeza na inicialização do serviço.

### `web.RegistroAcesso` (FR-025)

| Coluna | Tipo | Regra |
|---|---|---|
| `IdRegistro` | `bigint IDENTITY` PK | |
| `Momento` | `datetime2(0)` | obrigatório, padrão `SYSDATETIME()` |
| `Login` | `nvarchar(50)` | o login digitado (pode não existir) |
| `IdUsuario` | `int` | nulo quando o login não existe |
| `Evento` | `varchar(20)` | `ENTRADA`, `ENTRADA_RECUSADA`, `BLOQUEIO`, `SAIDA`, `SESSAO_EXPIRADA` |
| `Ip` | `varchar(45)` | endereço de origem |

Nenhuma coluna guarda dado de cliente (constituição V.3).

## 2. Modelos de leitura (legado, só `SELECT`)

### `ClienteResumo`: item da lista (FR-007 a FR-012)

Fonte: `dbo.Clientes`.

| Campo | Origem | Regra |
|---|---|---|
| `id` | `IDCliente` | |
| `nomeExibicao` | `ISNULL(Nome, Cliente)` | RN-CLI-002 |
| `titulo` | `Título` | |
| `malaDireta` | `Cliente` | rótulo "Mala direta" |
| `endereco`, `bairro`, `telefone` | `Endereço`, `Bairro`, `Telefone` | |
| `aniversario` | `Aniv` (`datetime2`) | só a data |
| `oculto` | `ISNULL(Oculto, 0)` | `true` só aparece com "mostrar ocultos" |

Filtro fixo: `ISNULL(Nome, Cliente) IS NOT NULL` (RN-CLI-001). Sem "mostrar ocultos": `ISNULL(Oculto, 0) = 0`
(RN-CLI-018; os 377 nulos contam como visíveis, porque o padrão da coluna é 0). Pesquisa e ordenação: R5.

### `ClienteFicha`: ficha (FR-013)

Fonte: `dbo.Clientes` pelo `IDCliente`. Campos do resumo mais `nome` (`Nome` como está gravado: a ficha mostra
"Nome" e "Mala direta" separados, e o `nomeExibicao` cai para a mala direta quando o Nome é nulo), `cidade` (`Cidade`), `uf` (`Estado`), `cep` (`CEP`),
`email` (`Email`), `cpf` (`CPF`: 11 dígitos no banco; a SPA formata `000.000.000-00`), `medidas` (`Medidas`),
`indicacao` (`Indicaçao`), `dataCadastro` (`DataCad`, `date`, quase sempre nulo) e `versao` (`SSMA_TimeStamp` em
hex, para a edição futura; só leitura agora).

Fora da ficha (RN-CLI-022): `Fax`, `CPF_MD`, `Saldo`, `Imp`, `NaoZerarCC`.

Cliente inexistente → 404. Cliente oculto → a ficha abre normalmente, com o aviso "oculto" (para abrir, a pessoa já
ligou "mostrar ocultos").

### `LancamentoCC`: grade da conta corrente (FR-014)

Fonte: view `dbo.CC` (união de `CONSERTOS`, `VENDAS` e `[Conta Corrente]` marcados como "na CC"; 18 `UNION ALL`).
Mesma consulta do desktop (`dsCliente.CC`: `WHERE Cliente = @IdCli`).

| Campo | Origem | Observação |
|---|---|---|
| `idOrigem` | `ID` | id da venda, do conserto ou do lançamento, conforme `operacao` |
| `data` | `Data` (`datetime2`) | o relógio gravado, sem fuso: `YYYY-MM-DDTHH:mm:ss` |
| `operacao` | `Op` (`varchar(8)`) | `Venda`, `Conserto` ou lançamento de CC |
| `forma` | `Tp` (`varchar(7)`) | `Cartão`, `Cash`, `Cheque`, `Débito`, `Dólar`, `Ouro`… |
| `valor` | `VValor` (`float`) | débitos vêm negativos da própria view (`Abs(CCDeb) * -1`) |
| `ident` | `Ident` | ordem da forma dentro da origem; usada só para ordenar |

Ordem: `Data`, depois `Ident`. Sem totais nesta entrega: o saldo da CC é de outro módulo (procs `USP_*SALDO*`).

### `PecaComprada` (FR-016, FR-017)

Fonte: `dbo.VENDAS` ⨝ `dbo.[VENDAS DET]` (`Venda` = `VENDAS.Id`) ⨝ `dbo.[1TabPeças]` (`Peça` = `IDPeça`), filtrado
por `VENDAS.IDCliente`. É a mesma junção do `dsCliente.Compras` (tela "Compras" do desktop).

| Campo | Origem |
|---|---|
| `dataVenda` | `VENDAS.DataVenda` |
| `numeroVenda` | `VENDAS.Venda` (`nvarchar(8)`, ex.: `0123/26`) |
| `classe` | `[1TabPeças].Classe` |
| `modelo` | `[1TabPeças].Modêlo` |
| `descricao` | `[1TabPeças].Descrição` |
| `observacoes` | `[1TabPeças].Obs` (o desktop rotula como "Medidas") |

Ordem: `DataVenda` decrescente, depois `VENDAS.Id` decrescente; as peças da mesma venda, na ordem do item
(`[VENDAS DET].Id`). `dataVenda` sai como o relógio gravado, sem fuso. Sem custo, preço nem comissão (FR-017).
Venda sem item (sem linha em `[VENDAS DET]`) não aparece, como no desktop.

### `LinhaClientesCadastrados` (FR-018 a FR-021)

Fonte: `dbo.Clientes`, com a mesma consulta de `Relatorios/ClientesCadastradosRpt.resx`.

| Campo | Origem |
|---|---|
| `nomeExibicao` | `ISNULL(Nome, Cliente)` |
| `aniversario` | `Aniv` |
| `endereco`, `bairro`, `telefone`, `email` | colunas homônimas |
| `dataCadastro` | `DataCad` |

Filtro: `ISNULL(Nome, Cliente) IS NOT NULL` e, com período, `DataCad BETWEEN @dt1 AND @dt2` (as duas datas
inclusive). **Inclui os ocultos** (FR-021). Ordem: nome de exibição (o desktop ordena na tela; o golden master compara
como conjunto).

## 3. Regras de exibição (SPA)

- Datas `dd/MM/aaaa`; valores `R$ 1.234,56`, com vírgula decimal (constituição VI.3). A API devolve tipos (ISO 8601,
  número), nunca texto formatado.
- Campo vazio aparece vazio, nunca como "null" ou "undefined".
