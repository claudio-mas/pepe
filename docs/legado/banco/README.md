# Catálogo do BDTorras

Saída do `Pepe/Scripts/Exportar-Catalogo.ps1`, que roda o `Pepe/Scripts/CAT_v0_investigacao.sql` (**somente leitura**)
e grava um CSV por bloco, mais o código de cada view, proc, função e gatilho em `modulos/<tipo>/<schema>.<nome>.sql`.

**Nenhum arquivo daqui tem dado pessoal**: só estrutura do banco e contagens. Pode ser commitado.

## Como gerar

Contra uma **cópia** do banco (o contêiner Docker de dev, ver `docs/Configurar-maquina-nova.md`):

```powershell
docker compose -f Pepe\Docker\docker-compose.yml up -d
powershell -ExecutionPolicy Bypass -File Pepe\Scripts\Exportar-Catalogo.ps1
```

Sem parâmetros, o script usa a conexão do `Pepe\app.config` (o contêiner em `127.0.0.1,14330`). Para outra cópia,
passe `-ConnectionString "..."`. Cada execução apaga e regenera os CSVs, os `.erro.txt` e a pasta `modulos/`. Este
README fica.

Um bloco que falha não interrompe os outros: o erro vai para `<bloco>.erro.txt`.

## Arquivos

| Arquivo | Conteúdo |
|---|---|
| `00_banco.csv` | versão do SQL Server, nível de compatibilidade, collation, data da captura |
| `01_tabelas.csv` | tabelas: nº de linhas, coluna identidade, coluna `rowversion` (`SSMA_TimeStamp`), PK |
| `02_colunas.csv` | colunas de tabelas e views: tipo, tamanho, nulo, identidade, padrão, fórmula |
| `03_chaves.csv` | PKs e restrições UNIQUE |
| `04_fks.csv` | FKs declaradas, com ação de exclusão e se estão ativas |
| `05_indices.csv` | índices fora das PKs |
| `06_modulos.csv` + `modulos/` | views, procs, funções e gatilhos (o código fica em `modulos/`) |
| `07_parametros.csv` | parâmetros de procs e funções |
| `08_gatilhos.csv` | gatilhos: eventos, ativo, INSTEAD OF |
| `09_dependencias.csv` | quem (view/proc/função/gatilho) usa qual objeto: base da matriz CRUD |
| `10_colunas_cliente.csv` | colunas que apontam para o cliente fora de `Clientes` (FKs implícitas) |
| `11_clientes_resumo.csv` | perfil de `Clientes` só com contagens (sem nome, ocultos, CPF, e-mail, nomes repetidos…) |
| `12_medidas.csv` | clientes com histórico (vendas, consertos, CC), registros órfãos, tamanho de `tabcep`/`NVendasBase`/`CC` |
| `13_objetos_citados.csv` | se cada objeto citado em `docs/legado/` é tabela, view, proc, função ou não existe |

## Perguntas que o catálogo responde

Do inventário de Clientes (`docs/legado/10-clientes.md`):
- `Clientes` tem `SSMA_TimeStamp`? → `01_tabelas.csv` (concorrência na web, §7).
- Há FK de `VENDAS`/`CONSERTOS`/`[Conta Corrente]` para `Clientes`? → `04_fks.csv` (RN-CLI-008/018).
- Quantos clientes têm histórico e não podem ser excluídos? → `12_medidas.csv` (RN-CLI-018).
- O que são `CC`, `NVendasBase` e `tabcep`? → `13_objetos_citados.csv` e `modulos/VIEW/`.
- Nomes repetidos (afetam o relatório "Compras por cliente", RN-CLI-014) → `11_clientes_resumo.csv`.
