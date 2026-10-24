# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## O que é

Sistema desktop de gestão para joalheria (clientes, vendas, consertos, estoque, conta corrente,
cheques/cartões, relatórios). VB.NET / WinForms sobre .NET Framework 4.8, UI DevExpress v25.2 (em remoção —
ver "Saída do DevExpress"), banco SQL Server (`BDTorras`). Aplicação single-tenant, distribuída por ClickOnce em
https://informas.com.br/pepe/ (ver "Publicação").

## Layout do repositório (importante)

**Um único repositório git**, na raiz `C:\Sistema\Paco\Pepe\` (em 09/2026 os antigos repositórios aninhados —
raiz e `Pepe\.git` — foram unidos; o histórico do código foi preservado sob o prefixo `Pepe/`).
O código fica em `Pepe\`; na raiz ficam `Pepe.sln`, `Setup*`, `docs\` e este arquivo.
Remoto: repositório **privado** no GitHub (o histórico antigo contém senhas de desenvolvimento — nunca torne público).

`Pepe/bin/` e `Pepe/obj/` **são versionados** — e `Pepe/bin/Debug` guarda as DLLs de terceiros (DevExpress 25.2 e
as dependências NuGet dele) das quais o build depende quando o produto não está instalado. O `.gitignore` da raiz
ignora `bin/`: DLL nova ali só entra com `git add -f`. Qualquer build suja
dezenas de arquivos no working tree — isso é esperado, não é regressão. Ao commitar, selecione os arquivos-fonte
explicitamente em vez de `git add -A`. `packages\` (NuGet) e `publish\` são ignorados.

Pastas a ignorar: `Pepe_Backup_*`, `Rubbish`, `Setup`/`Setup1` (VS Installer legado),
e os inúmeros `*.bak` / `*.Designer.vb.bak` espalhados pelo projeto.

## Ambiente de desenvolvimento

- Windows 11, **Visual Studio 2026** (workload ".NET desktop development" + targeting pack do .NET Framework 4.8).
- Banco em **contêiner Docker** (SQL Server 2022 Linux). Roteiro de instalação e restauração em
  `docs\Configurar-maquina-nova.md`. Na `DESKTOP-SKILL` o contêiner é o `bdtorras_mssql` de `Pepe\Docker`
  (`docker compose -f Pepe\Docker\docker-compose.yml up -d`; `Pepe\Docker\restaurar-bdtorras.ps1 [-Bak <arquivo>]`
  restaura sobrescrevendo), em **`127.0.0.1,14330`** (a 1433 dela é de outro projeto), collation
  `Latin1_General_CI_AS` (a de produção; só se aplica na criação do volume). O SqlClient resolve `localhost` para
  IPv6 e esse contêiner só publica em `127.0.0.1`: use `127.0.0.1,14330`, nunca `localhost,14330`.
- **Conexão por máquina** (`modConexao.PrepararConexao`, no `Startup`): nas máquinas listadas na chave
  `MaquinasDesenvolvimento` do `appSettings` (nomes separados por `;`), o `app.config` com senha (o contêiner de dev)
  abre direto. Em qualquer outra, a senha do `app.config` é ignorada: vale
  `%ProgramData%\PepeTorrasDesign\conexao.dat` (DPAPI, escopo da máquina) ou, sem ele, a `frmConexao` pede
  servidor/usuário/senha na 1ª execução, testa e grava o arquivo. Para trocar de banco numa estação, apague o arquivo.
- `strAdoConnection()` (ADODB) usa o provider OLE DB `MSOLEDBSQL` se ele estiver registrado na máquina e o
  `SQLOLEDB.1` (vem com o Windows) caso contrário; a detecção é feita uma vez e fica em cache.

## Build

Não há suíte de testes. O ciclo de verificação é compilar e, para relatórios, rodar o harness abaixo.

```powershell
$msb = & "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe" -latest -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe | Select-Object -First 1
& $msb "C:\Sistema\Paco\Pepe\Pepe\Pepe.vbproj" /restore /p:RestorePackagesConfig=true /p:SolutionDir=C:\Sistema\Paco\Pepe\ /p:Configuration=Debug /p:Platform=x86 /v:minimal /nologo
```

O `/p:SolutionDir` é necessário porque o build é feito no `.vbproj`, não na `.sln`: sem ele, a restauração do
`packages.config` falha com `NuGet.targets: error : Não foi encontrada nenhuma solução`.

**Use o MSBuild do Visual Studio (2022 ou posterior; Roslyn).** O MSBuild do .NET Framework
(`C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe`) usa o compilador VB antigo, que não
conhece interpolated strings (`$"..."`) — `frmCota.vb`, `Financeiro\frmGetnet.vb` e outros usam, e o
build morre com `BC30037: Caractere inválido`.
Esses erros não têm nada a ver com o código: são o compilador errado.

A plataforma é **x86 obrigatoriamente** (`Pepe.exe` é x86).
`OptionStrict Off`, `OptionInfer On`, `OptionExplicit On` — conversões implícitas são a norma no código.

Referências de terceiros: sem o DevExpress instalado, o build em **Debug** acha as DLLs em `bin\Debug` (é o
`OutputPath`). Em **Release** é preciso
`/p:ReferencePath=<caminho>\Pepe\bin\Debug\` — o script de publicação já faz isso. `licenses.licx` lista controles
licenciados: se o executável gerado exibir aviso de versão *trial*, instale o produto correspondente com a licença.

### Harness de layout de relatório

`Pepe\Scripts\VerificaLayout.vb` monta o `GerencialNovo` **sem banco**, exporta PDF e confere papel,
orientação, nº de páginas, overflow horizontal e texto cortado (preenche cada rótulo com o pior caso
antes de medir). Não faz parte do `.vbproj` — compila à parte, **dentro de `bin\Debug`**, senão o
probing do CLR não acha o DevExpress:

```powershell
cd C:\Sistema\Paco\Pepe\Pepe\bin\Debug
& "C:\Windows\Microsoft.NET\Framework\v4.0.30319\vbc.exe" -out:VerificaLayout.exe -platform:x86 `
  -r:Pepe.exe -r:DevExpress.XtraReports.v25.2.dll -r:DevExpress.Data.v25.2.dll `
  -r:DevExpress.Printing.v25.2.Core.dll -r:DevExpress.Drawing.v25.2.dll `
  -r:System.Drawing.dll -r:System.Windows.Forms.dll `
  -imports:Microsoft.VisualBasic,System,System.Linq -nologo ..\..\Scripts\VerificaLayout.vb
.\VerificaLayout.exe        # sem argumento = sem linha Boutique; "bou" = com
```

`-platform:x86` é obrigatório; sem ele dá `BadImageFormatException`. Apague o `.exe`/`.pdb`/`.pdf`
gerados depois — `bin\Debug` é versionado. Aqui o `vbc` antigo serve porque o harness não usa
interpolated strings; para o projeto inteiro, use o MSBuild do Visual Studio (ver acima).

## Publicação (ClickOnce)

```powershell
powershell -ExecutionPolicy Bypass -File Pepe\Scripts\Publicar-ClickOnce.ps1   # -SemEnvio só gera em publish\
```

O script compila Release x86 com um `app.config` **sem senha** (servidor `PEPETORRAS-PC\SQLEXPRESS`, o da loja),
publica em `publish\` (ignorado pelo git), envia via SSH (host `informas` no `~/.ssh/config`) para
`/etc/icontainer/apps/openresty/openresty/www/pepe` (OpenResty em contêiner; location em
`conf.d/users/locations/pepe.conf`, incluída no `main.conf`), mantém 2 versões no servidor, confere por HTTPS e avança
o `ApplicationRevision`. Atualizações são obrigatórias (`MinimumRequiredVersion` = versão publicada).
O target `BloquearSenhaNaPublicacao` do `.vbproj` barra qualquer publicação (inclusive pelo Visual Studio) cujo config
tenha senha. Manifestos não são assinados (de propósito). O disco da VPS está apertado (~5 GB livres; ~250 MB por versão).
**Publique sempre pelo script**, não pelo assistente do Visual Studio (ele não sabe o `ReferencePath` nem a revisão do servidor).

O script localiza o MSBuild com `vswhere` e se adapta à máquina: com VS 2022 ou posterior usa o MSBuild dele; só no
VS2019 recorre ao Roslyn 64 bits do .NET SDK (o `vbc` 32 bits do VS2019 estoura memória); sem os assemblies de
referência do .NET 4.8, usa o pacote NuGet `Microsoft.NETFramework.ReferenceAssemblies.net48` em `packages\`; sem
DevExpress 25.2 instalado, usa `Pepe\bin\Debug`.

## Saída do DevExpress

Objetivo do dono: remover o DevExpress **por completo** (fim da licença), trocando por controles WinForms nativos e
relatórios RDLC (`Microsoft.ReportingServices.ReportViewerControl.Winforms` via NuGet). Nada convertido em uso
no momento: o relatório `Vendas` + subrelatório `VendasSaidas` chegou a ir para RDLC (commit `21e8840`,
`Relatorios\Vendas.rdlc` com `VendasBase` herdando `BaseRelatorio`) e o `frmClientesDG` para DataGridView (commit
`d9763a9`), mas ambos voltaram à versão DevExpress a pedido do dono; as versões nativas ficam nesses commits para
quando forem retomadas. `BaseRelatorio` e o ReportViewer continuam no projeto, sem uso, à espera da próxima conversão. ComponentOne, Infragistics e Telerik já saíram do projeto; o
DevExpress foi atualizado para 25.2 enquanto a remoção não termina. Se um designer DevExpress não abrir no VS, edite
o `.Designer.vb` à mão ou converta o formulário.
Para editar `.rdlc` no VS 2026, instale a extensão "Microsoft RDLC Report Designer" (versão 2022+).

## Versão web (em planejamento)

Há uma versão web em planejamento: SPA com sidebar, Node/TypeScript, mesmo `BDTorras`, convivência módulo a módulo com o
desktop, desenvolvida com Spec-Driven Development (GitHub Spec Kit). Roteiro, constituição e glossário em `docs/web/`;
o inventário do legado (mapa de navegação, módulos, regras de negócio) em `docs/legado/`. Para trabalho na web, a
constituição (`docs/web/constituicao-rascunho.md`, depois `.specify/memory/constitution.md`) prevalece.

## Arquitetura

### Fluxo de inicialização

`ApplicationEvents.vb` (`Startup`) → `PrepararConexao()` (ver "Acesso a dados"; se o usuário cancelar a
`frmConexao`, o app fecha) e `SqlDataSource.DisableCustomQueryValidation = True` (o validador do DevExpress 25.2
confunde `REPLACE(` com `REPLACE INTO` e recusava queries fixas dos relatórios) → `My Project\Application.myapp` → `MainForm = frmAcesso` (senha comparada em texto no
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
   `modInternas.vb` (~250 usos). `strAdoConnection()` lê a connection string do `ConfigurationManager`, decompõe
   com `SqlConnectionStringBuilder` e remonta uma string OLEDB, com o provider detectado no registro (ver
   "Ambiente de desenvolvimento").
3. **LINQ to SQL** — `Relatorios\lqGerencial.dbml` → `lqGerencialDataContext`. Usado por
   `GerencialBase`, `GerencialNovoDados` e `VendasBase`.

Fonte única da conexão: `Pepe.My.MySettings.Pepe_ConnString`. **Nunca** escreva string de conexão com senha
no código. No `app.config` só entra a senha do contêiner de dev, que a publicação remove. `modConexao.vb` decide a
conexão no `Startup` (ver "Conexão por máquina" acima) e aplica a escolhida em memória ao `ConfigurationManager`
e ao `My.Settings`. Um config com senha **não pode ser publicado** (o `.vbproj` barra; o script de publicação gera
um sem senha, com o servidor da loja).
Convenção do projeto: `CommandTimeout = 0` nas consultas de relatório.

### Relatórios (`Pepe\Relatorios\`)

**Novos (RDLC):** `BaseRelatorio` é o formulário-base WinForms (painel de filtro com `txtData1`/`txtData2`,
`btnOk2`, `btnFechar` e `ReportViewer1` em `DisplayMode.Normal` — em `PrintLayout` a caixa "Localizar" fica
desabilitada). O `.rdlc` é recurso embutido, carregado por `BaseRelatorio.CarregarDefinicao`. Em RDLC, somas de
campos que podem vir nulos: `Sum(CDbl(...))`. Para esconder um valor sem deslocar vizinhos, deixe o texto em branco
em vez de `Hidden`.

**Legados (DevExpress)** — convenção de nomes, em pares:

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

Ao converter um relatório DevExpress para RDLC, confira valor a valor contra o original no mesmo período
(foi assim com `Vendas`: 07/2026 e 02/2021, todos os valores batendo — conversão depois revertida, ver
"Saída do DevExpress").

### Banco de dados

Objetos legados: views `VI_*`, procs `USP_*`. Trabalho novo usa o prefixo `VW_RG2_*` de propósito,
para ficar óbvio no SSMS o que é novo.

`Pepe\Scripts\` guarda migrações em pares aditivos `_up.sql` / `_down.sql` (+ um `_v0_investigacao.sql`
read-only). **Rodar sempre primeiro numa cópia de `BDTorras`** (o contêiner Docker local serve para isso).
Nenhum script altera ou remove objeto existente — mantenha isso.

## Convenções

- **Identificadores e nomes de arquivo em português com acento**: `frmTaxasCartão.vb`, `Balanço41BR.vb`,
  `PeçasVendidas.vb`. Objetos de banco também: `[Cotação]`, `[Vencto Cartão]`. Preserve os acentos.
- Comentários em português.
- Commits em português, Conventional Commits com escopo: `feat(gerencial):`, `fix(cotacao):`,
  `perf(gerencial):`, `chore(scripts):`. Corpo explica o *porquê* e o que foi verificado.
  Mensagens com acento: grave em arquivo UTF-8 e use `git commit -F arquivo.txt` (passar pelo PowerShell 5 corrompe).
- Cultura pt-BR: use os helpers de `modInternas.vb` (`ConvertToSafeDouble`, `ConvertToSafeDate`,
  `FormatSafeNumber`) em vez de `CDbl`/`CDate` direto — eles tentam cultura atual, invariante e
  formatos explícitos antes de desistir.
- Estado global mora em `Public` de módulo (`modConn.vb`: `varIdCliente`, `varIdVenda`…;
  `modInternas.vb`: `valDolar`, `valOuro`, `valPrata`). É assim que os formulários conversam entre si.
