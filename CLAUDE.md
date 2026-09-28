# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## O que é

Sistema desktop de gestão para joalheria (clientes, vendas, consertos, estoque, conta corrente,
cheques/cartões, relatórios). VB.NET / WinForms sobre .NET Framework 4.8, UI DevExpress v23.2,
banco SQL Server (`BDTorras`). Aplicação single-tenant, distribuída por ClickOnce em
https://informas.com.br/pepe/ (ver "Publicação").

## Layout do repositório (importante)

Há **dois repositórios git aninhados**:

- `C:\Sistema\Paco\Pepe\.git` — raiz; versiona só `Pepe.sln`, `Setup*`, `.gitignore`.
- `C:\Sistema\Paco\Pepe\Pepe\.git` — **onde vive o histórico do código**. Todo commit de código vai aqui.

Dentro do repo interno, `bin/` e `obj/` **são versionados**. Qualquer build suja dezenas de arquivos
no working tree — isso é esperado, não é regressão. Ao commitar, selecione os arquivos-fonte
explicitamente em vez de `git add -A`.

Pastas a ignorar: `Pepe_Backup_*`, `Rubbish`, `Setup`/`Setup1` (VS Installer legado),
e os inúmeros `*.bak` / `*.Designer.vb.bak` espalhados pelo projeto.

## Build

Não há suíte de testes. O ciclo de verificação é compilar e, para relatórios, rodar o harness abaixo.

```powershell
& "C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe" `
  "C:\Sistema\Paco\Pepe\Pepe\Pepe.vbproj" /p:Configuration=Debug /p:Platform=x86 /v:minimal /nologo
```

**Tem que ser o MSBuild do VS2022 (Roslyn).** O MSBuild do .NET Framework
(`C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe`) usa o compilador VB antigo, que não
conhece interpolated strings (`$"..."`) — `frmCota.vb`, `Financeiro\frmGetnet.vb` e outros usam, e o
build morre com `BC30037: Caractere inválido` mais um `BC30009` de referência C1.Win.BarCode.
Esses erros não têm nada a ver com o código: são o compilador errado.

A plataforma é **x86 obrigatoriamente** (`Pepe.exe` é x86).
`OptionStrict Off`, `OptionInfer On`, `OptionExplicit On` — conversões implícitas são a norma no código.

### Harness de layout de relatório

`Pepe\Scripts\VerificaLayout.vb` monta o `GerencialNovo` **sem banco**, exporta PDF e confere papel,
orientação, nº de páginas, overflow horizontal e texto cortado (preenche cada rótulo com o pior caso
antes de medir). Não faz parte do `.vbproj` — compila à parte, **dentro de `bin\Debug`**, senão o
probing do CLR não acha o DevExpress:

```powershell
cd C:\Sistema\Paco\Pepe\Pepe\bin\Debug
& "C:\Windows\Microsoft.NET\Framework\v4.0.30319\vbc.exe" -out:VerificaLayout.exe -platform:x86 `
  -r:Pepe.exe -r:DevExpress.XtraReports.v23.2.dll -r:DevExpress.Data.v23.2.dll `
  -r:DevExpress.Printing.v23.2.Core.dll -r:DevExpress.Drawing.v23.2.dll `
  -r:System.Drawing.dll -r:System.Windows.Forms.dll `
  -imports:Microsoft.VisualBasic,System,System.Linq -nologo ..\..\Scripts\VerificaLayout.vb
.\VerificaLayout.exe        # sem argumento = sem linha Boutique; "bou" = com
```

`-platform:x86` é obrigatório; sem ele dá `BadImageFormatException`. Apague o `.exe`/`.pdb`/`.pdf`
gerados depois — `bin\Debug` é versionado. Aqui o `vbc` antigo serve porque o harness não usa
interpolated strings; para o projeto inteiro, use o MSBuild do VS2022 (ver acima).

## Publicação (ClickOnce)

```powershell
powershell -ExecutionPolicy Bypass -File Pepe\Scripts\Publicar-ClickOnce.ps1   # -SemEnvio só gera em publish\
```

O script compila Release x86 com um `app.config` **sem senha** (servidor `PEPETORRAS-PC\SQLEXPRESS`), publica em
`publish\` (ignorado pelo git), envia via SSH (host `informas` no `~/.ssh/config`) para
`/etc/icontainer/apps/openresty/openresty/www/pepe` (OpenResty em contêiner; location em
`conf.d/users/locations/pepe.conf`, incluída no `main.conf`), mantém 2 versões no servidor, confere por HTTPS e avança
o `ApplicationRevision`. Atualizações são obrigatórias (`MinimumRequiredVersion` = versão publicada).
O target `BloquearSenhaNaPublicacao` do `.vbproj` barra qualquer publicação (inclusive pelo Visual Studio) cujo config
tenha senha. Manifestos não são assinados (de propósito). O disco da VPS está apertado (~5 GB livres; ~250 MB por versão).

O script se adapta à máquina: sem VS2022, usa o MSBuild do VS2019 com o Roslyn 64 bits do .NET SDK (o `vbc` 32 bits do
VS2019 estoura memória); sem os assemblies de referência do .NET 4.8, usa o pacote NuGet
`Microsoft.NETFramework.ReferenceAssemblies.net48` em `packages\`; sem DevExpress 23.2 instalado, usa `Pepe\bin\Debug`.

## Arquitetura

### Fluxo de inicialização

`My Project\Application.myapp` → `MainForm = frmAcesso` (senha comparada em texto no
`frmAcesso.vb`; a validação remota contra `tab_controle` está comentada) → `frmDevPrincipal.Show()`.

`frmDevPrincipal` (em `Datasets\`, apesar do nome da pasta) é a shell: `DevExpress.XtraBars.Ribbon.RibbonForm`.
Cada botão da ribbon faz `frmX.Show()` usando a **instância padrão do VB** — os formulários são
singletons de fato, referenciados por nome de classe em todo o código. Não instancie com `New` sem
verificar quem mais depende da instância padrão. Vários botões rodam SQL de limpeza / stored procs
antes de abrir o form (ex.: `fExecutarSP("USP_Cheques")`).

### Acesso a dados — três camadas coexistem

1. **Typed DataSets + TableAdapters** — `DataSet1.xsd` (338 KB) e `Datasets\ds*.xsd`. É o grosso dos
   formulários (~1300 referências a `TableAdapter`).
2. **ADODB clássico (COM)** via `modConn.vb` — `fExecutarText`, `fExecutarSP`, e `DLookUp` em
   `modInternas.vb` (~250 usos). `strAdoConnection()` lê a connection string do `app.config`, quebra
   ela em pedaços com `Mid$`/`InStr` e remonta uma string OLEDB — **escolhendo o provider pelo serial
   da placa-mãe** (`MSOLEDBSQL` na máquina de desenvolvimento, `SQLOLEDB.1` na do cliente).
3. **LINQ to SQL** — `Relatorios\lqGerencial.dbml` → `lqGerencialDataContext`. Usado por
   `GerencialBase` e por `GerencialNovoDados`.

Fonte única da conexão: `Pepe.My.MySettings.Pepe_ConnString`. **Nunca** escreva string de conexão com senha
no código. `modConexao.vb` decide a conexão no `Startup` (`ApplicationEvents.vb`): se existir
`%ProgramData%\PepeTorrasDesign\conexao.dat` (criptografado com DPAPI, criado pela `frmConexao` na 1ª execução),
aplica-o em memória ao `ConfigurationManager` e ao `My.Settings`; senão, usa o `app.config` se ele tiver senha
(máquina de desenvolvimento); senão, abre a `frmConexao`. O `app.config` local tem senha e **não pode ser publicado**.
Convenção do projeto: `CommandTimeout = 0` nas consultas de relatório.

### Relatórios (`Pepe\Relatorios\`)

Convenção de nomes, em pares:

- `XxxBase.vb` — o **formulário de filtro** (herda `BaseRpts`, que já traz `txtData1`, `txtData2`,
  `btnOk2` e `DocumentViewer1`). Esconde `frmDevPrincipal` no `Load` e o restaura no `FormClosing`.
- `Xxx.vb` — o **XtraReport** propriamente dito; quase sempre vazio, com o layout todo no
  `Xxx.Designer.vb`.

`BaseRpts` registra os skins DevExpress e fixa o skin `"Dark Side"` no `Shared New` — mesmo padrão
de `frmDevPrincipal`.

**Exceção `GerencialNovo*`** (relatório gerencial novo, montado em código):
- `GerencialNovo.vb` — layout construído por `MontarLayout()`, sem `.Designer.vb`. Grade de 9 colunas,
  `ReportUnit` em décimos de milímetro (Dpi 254, para os subrelatórios embutirem 1:1), A4 retrato.
- `GerencialNovoBase.vb` — sem `.Designer.vb`, então precisa do `Inherits Pepe.BaseRpts` **explícito**
  e **não** chama `InitializeComponent` (quem monta os controles é o construtor de `BaseRpts`).
- `GerencialNovoDados.vb` — toda a carga: reusa o `lqGerencialDataContext` sem alterar o `.dbml`;
  métricas novas vêm das views `VW_RG2_*` via `ExecuteQuery(Of T)` (parametriza de verdade, `{0}` vira
  `SqlParameter`).

Armadilhas de layout já pagas caro, documentadas no harness e nos commits: na coleção `Controls` o
**índice menor fica na frente** (crie o fundo depois dos rótulos); `WordWrap`/`CanGrow` ligados
empurram os controles seguintes da banda e deslocam o layout inteiro; com `WordWrap` desligado, texto
que não cabe é **cortado em silêncio**.

### Banco de dados

Objetos legados: views `VI_*`, procs `USP_*`. Trabalho novo usa o prefixo `VW_RG2_*` de propósito,
para ficar óbvio no SSMS o que é novo.

`Pepe\Scripts\` guarda migrações em pares aditivos `_up.sql` / `_down.sql` (+ um `_v0_investigacao.sql`
read-only). **Rodar sempre primeiro numa cópia de `BDTorras`.** Nenhum script altera ou remove objeto
existente — mantenha isso.

## Convenções

- **Identificadores e nomes de arquivo em português com acento**: `frmTaxasCartão.vb`, `Balanço41BR.vb`,
  `PeçasVendidas.vb`. Objetos de banco também: `[Cotação]`, `[Vencto Cartão]`. Preserve os acentos.
- Comentários em português.
- Commits em português, Conventional Commits com escopo: `feat(gerencial):`, `fix(cotacao):`,
  `perf(gerencial):`, `chore(scripts):`. Corpo explica o *porquê* e o que foi verificado.
- Cultura pt-BR: use os helpers de `modInternas.vb` (`ConvertToSafeDouble`, `ConvertToSafeDate`,
  `FormatSafeNumber`) em vez de `CDbl`/`CDate` direto — eles tentam cultura atual, invariante e
  formatos explícitos antes de desistir.
- Estado global mora em `Public` de módulo (`modConn.vb`: `varIdCliente`, `varIdVenda`…;
  `modInternas.vb`: `valDolar`, `valOuro`, `valPrata`). É assim que os formulários conversam entre si.
