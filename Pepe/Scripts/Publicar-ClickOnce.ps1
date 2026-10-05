<#
.SYNOPSIS
    Publica o Pepe via ClickOnce em https://informas.com.br/pepe/ (VPS "informas", OpenResty).

.DESCRIPTION
    1. Compila e publica (Release x86) em <raiz>\publish\ com um app.config SEM SENHA
       (a conexão completa fica em cada computador, criptografada; ver modConexao.vb).
    2. Envia para a VPS: primeiro a pasta da versão, setup.exe e publish.htm; por último o
       Pepe.application (trocado de uma vez, para ninguém ver um manifesto apontando para arquivos
       que ainda não chegaram).
    3. Mantém no servidor só as últimas versões (-ManterVersoes) e confere tudo por HTTPS.
    4. Avança o ApplicationRevision no Pepe.vbproj (como o Visual Studio faz ao publicar).

    As atualizações são obrigatórias: cada publicação define MinimumRequiredVersion = versão publicada.

.EXAMPLE
    powershell -ExecutionPolicy Bypass -File Scripts\Publicar-ClickOnce.ps1
.EXAMPLE
    powershell -ExecutionPolicy Bypass -File Scripts\Publicar-ClickOnce.ps1 -SemEnvio   # só gera em publish\
#>
param(
    [string]$ServidorBanco = 'PEPETORRAS-PC\SQLEXPRESS',   # servidor SQL da loja (sem senha!)
    [string]$Ssh = 'informas',                               # host do ~/.ssh/config
    [string]$PastaRemota = '/etc/icontainer/apps/openresty/openresty/www/pepe',
    [string]$UrlPublica = 'https://informas.com.br/pepe/',
    [int]$ManterVersoes = 2,
    [switch]$SemEnvio
)
$ErrorActionPreference = 'Stop'
Add-Type -AssemblyName System.Data

$Raiz   = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$Proj   = Join-Path $Raiz 'Pepe\Pepe.vbproj'
$Pub    = Join-Path $Raiz 'publish'
$Tmp    = Join-Path $env:TEMP 'PepePublicar'
$Utf8   = New-Object System.Text.UTF8Encoding $false
function Passo($t) { Write-Host "`n==> $t" -ForegroundColor Cyan }
function RodarRemoto([string]$bash) {
    $f = Join-Path $Tmp 'remoto.sh'
    [IO.File]::WriteAllText($f, $bash.Replace("`r`n", "`n"), $Utf8)
    $saida = cmd /c "ssh -o BatchMode=yes $Ssh bash -s < `"$f`" 2>&1"
    if ($LASTEXITCODE -ne 0) { throw "Falha no comando remoto:`n$($saida -join "`n")" }
    return $saida
}

Remove-Item -Recurse -Force $Tmp -ErrorAction SilentlyContinue
New-Item -ItemType Directory -Force $Tmp | Out-Null

# ---------------------------------------------------------------- ferramentas
Passo 'Localizando ferramentas'
$vswhere = "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe"
$vsPath  = & $vswhere -latest -products * -requires Microsoft.Component.MSBuild -property installationPath
$vsVer   = [version](& $vswhere -latest -products * -requires Microsoft.Component.MSBuild -property installationVersion)
$msbuild = Join-Path $vsPath 'MSBuild\Current\Bin\MSBuild.exe'
if (-not (Test-Path $msbuild)) { throw "MSBuild não encontrado ($msbuild)." }
Write-Host "MSBuild: $msbuild (VS $($vsVer.Major))"

$extra = @()
if ($vsVer.Major -lt 17) {
    # O vbc do VS2019 é 32 bits e fica sem memória neste projeto: usa o Roslyn 64 bits do .NET SDK.
    $vbcDll = Get-ChildItem "$env:ProgramFiles\dotnet\sdk\*\Roslyn\bincore\vbc.dll" -ErrorAction SilentlyContinue |
              Sort-Object { [version]($_.FullName -replace '.*\\sdk\\([\d.]+).*', '$1') } -Descending | Select-Object -First 1
    if ($vbcDll) {
        $wrap = Join-Path $Tmp 'vbc'
        New-Item -ItemType Directory -Force $wrap | Out-Null
        [IO.File]::WriteAllText("$wrap\vbc.cmd", "@`"$env:ProgramFiles\dotnet\dotnet.exe`" `"$($vbcDll.FullName)`" %*", [Text.Encoding]::ASCII)
        $extra += "/p:VbcToolPath=$wrap", '/p:VbcToolExe=vbc.cmd', '/p:UseSharedCompilation=false'
        Write-Host "Compilador: Roslyn 64 bits ($($vbcDll.FullName))"
    } else { Write-Warning 'VS2019 sem .NET SDK: o compilador pode ficar sem memória.' }
}
if (-not (Test-Path "${env:ProgramFiles(x86)}\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\mscorlib.dll")) {
    $ref = Get-ChildItem (Join-Path $Raiz 'packages') -Directory -Filter 'Microsoft.NETFramework.ReferenceAssemblies.net48.*' -ErrorAction SilentlyContinue | Select-Object -First 1
    if (-not $ref) {
        $ref = Join-Path $Raiz 'packages\Microsoft.NETFramework.ReferenceAssemblies.net48.1.0.3'
        $zip = Join-Path $Tmp 'refasm48.zip'
        Invoke-WebRequest -UseBasicParsing 'https://api.nuget.org/v3-flatcontainer/microsoft.netframework.referenceassemblies.net48/1.0.3/microsoft.netframework.referenceassemblies.net48.1.0.3.nupkg' -OutFile $zip
        Expand-Archive $zip -DestinationPath $ref -Force
        $ref = Get-Item $ref
    }
    $extra += "/p:TargetFrameworkRootPath=$($ref.FullName)\build"
    Write-Host "Referências .NET 4.8: pacote NuGet ($($ref.Name))"
}
# DLLs de terceiros (DevExpress 25.2) versionadas em Pepe\bin\Debug: o build em Release
# as acha por aqui, sem depender do produto instalado.
$extra += "/p:ReferencePath=$Raiz\Pepe\bin\Debug\"

# ---------------------------------------------------------------- versão
Passo 'Definindo a versão'
$projTxt = [IO.File]::ReadAllText($Proj)
$base = [regex]::Match($projTxt, '<ApplicationVersion>(\d+\.\d+\.\d+)\.').Groups[1].Value
$rev  = [int][regex]::Match($projTxt, '<ApplicationRevision>(\d+)</ApplicationRevision>').Groups[1].Value
if (-not $SemEnvio) {
    $remotas = RodarRemoto "ls -1 '$PastaRemota/Application Files' 2>/dev/null || true"
    $prefixo = 'Pepe_' + $base.Replace('.', '_') + '_'
    $usadas = @($remotas | Where-Object { $_ -like "$prefixo*" } | ForEach-Object { [int]$_.Substring($prefixo.Length) })
    if ($usadas.Count -gt 0) { $rev = [Math]::Max($rev, ($usadas | Measure-Object -Maximum).Maximum + 1) }
}
$versao = "$base.$rev"
Write-Host "Versão a publicar: $versao"

# ---------------------------------------------------------------- config sem senha
Passo 'Gerando o app.config da publicação (sem senha)'
[xml]$cfg = [IO.File]::ReadAllText((Join-Path $Raiz 'Pepe\app.config'))
foreach ($add in $cfg.configuration.connectionStrings.add) {
    $b = New-Object System.Data.SqlClient.SqlConnectionStringBuilder $add.connectionString
    [void]$b.Remove('Password')
    if ($add.name -eq 'Pepe.My.MySettings.Pepe_ConnString') { $b['Data Source'] = $ServidorBanco }
    $add.connectionString = $b.PSBase.ConnectionString   # PSBase: no PowerShell o builder se comporta como dicionário
}
$cfgPub = Join-Path $Tmp 'app.config'
$cfg.Save($cfgPub)
if (Select-String -Path $cfgPub -Pattern '(?i)(password|pwd)\s*=\s*[^;"\s]' -Quiet) { throw 'O config da publicação ainda tem senha. Abortado.' }
Write-Host "Servidor do banco na publicação: $ServidorBanco (a senha é pedida em cada computador)"

# ---------------------------------------------------------------- publicação
Passo 'Compilando e publicando (Release x86)'
$log = Join-Path $Tmp 'msbuild.log'
& $msbuild $Proj /restore /p:RestorePackagesConfig=true "/p:SolutionDir=$Raiz\" /t:Publish /p:Configuration=Release /p:Platform=x86 "/p:AppConfig=$cfgPub" `
    "/p:OutDir=$Tmp\bin\" "/p:IntermediateOutputPath=$Tmp\obj\" "/p:PublishDir=$Pub\" `
    "/p:ApplicationRevision=$rev" "/p:MinimumRequiredVersion=$versao" @extra /v:minimal /nologo 2>&1 | Tee-Object -FilePath $log | Out-Null
if ($LASTEXITCODE -ne 0) { Select-String -Path $log -Pattern ' error ' | ForEach-Object { Write-Host $_.Line -ForegroundColor Red }; throw "Falha na publicação (log: $log)" }

$pasta = 'Pepe_' + $versao.Replace('.', '_')
$dirVersao = Join-Path $Pub "Application Files\$pasta"
if (-not (Test-Path "$dirVersao\Pepe.exe.config.deploy")) { throw "Publicação incompleta: $dirVersao" }
if (Select-String -Path "$dirVersao\Pepe.exe.config.deploy" -Pattern '(?i)(password|pwd)\s*=\s*[^;"\s]' -Quiet) { throw 'O config publicado contém senha. Abortado.' }
[xml]$dep = Get-Content "$Pub\Pepe.application"
Write-Host ("Gerado: {0} ({1:N0} MB)" -f $pasta, ((Get-ChildItem $dirVersao -Recurse -File | Measure-Object Length -Sum).Sum / 1MB))

# página de instalação (o MSBuild não gera o publish.htm; só o Visual Studio)
$htm = @"
<!DOCTYPE html>
<html lang="pt-BR"><head><meta charset="utf-8"><title>Pepe Torras Design - Instalação</title>
<style>body{font-family:Segoe UI,Arial,sans-serif;max-width:640px;margin:48px auto;padding:0 16px;color:#222}
a.b{display:inline-block;background:#1f5fa8;color:#fff;padding:12px 22px;border-radius:6px;text-decoration:none;font-weight:600}
li{margin:6px 0}small{color:#666}</style></head><body>
<h1>Pepe Torras Design</h1>
<p>Versão $versao</p>
<p><a class="b" href="setup.exe">Baixar o instalador</a></p>
<ol>
<li>Se o sistema antigo ("Novo Sistema") estiver instalado, desinstale-o antes em Configurações &gt; Aplicativos.</li>
<li>Execute o <b>setup.exe</b> baixado. Se o Windows avisar sobre editor desconhecido, clique em <i>Mais informações &gt; Executar assim mesmo</i> e depois em <i>Instalar</i>.</li>
<li>Na primeira abertura, informe a senha do banco de dados (ela fica guardada, criptografada, só neste computador).</li>
</ol>
<p><small>As atualizações são instaladas automaticamente ao abrir o sistema.</small></p>
</body></html>
"@
[IO.File]::WriteAllText("$Pub\publish.htm", $htm, $Utf8)

if ($SemEnvio) { Passo "Pronto (sem envio). Arquivos em $Pub"; exit 0 }

# ---------------------------------------------------------------- envio
Passo "Enviando para $Ssh ($PastaRemota)"
$tar = Join-Path $Tmp 'pepe.tar'
& tar.exe -cf $tar -C $Pub "Application Files/$pasta" setup.exe publish.htm Pepe.application
if ($LASTEXITCODE -ne 0) { throw 'Falha ao empacotar.' }
cmd /c "scp -q -o BatchMode=yes `"$tar`" ${Ssh}:/tmp/pepe_publicacao.tar"
if ($LASTEXITCODE -ne 0) { throw 'Falha no envio (scp).' }
RodarRemoto @"
set -e
R='$PastaRemota'
T=`$(mktemp -d)
tar -xf /tmp/pepe_publicacao.tar -C "`$T"
mkdir -p "`$R/Application Files"
rm -rf "`$R/Application Files/$pasta"
mv "`$T/Application Files/$pasta" "`$R/Application Files/"
cp -f "`$T/setup.exe" "`$T/publish.htm" "`$R/"
cp -f "`$T/Pepe.application" "`$R/Pepe.application.novo" && mv -f "`$R/Pepe.application.novo" "`$R/Pepe.application"
chmod -R a+rX "`$R"
rm -rf "`$T" /tmp/pepe_publicacao.tar
cd "`$R/Application Files" && ls -1d Pepe_* | sort -t_ -k2,2n -k3,3n -k4,4n -k5,5n | head -n -$ManterVersoes | xargs -r rm -rf
echo "Versoes no servidor:"; ls -1 "`$R/Application Files"
df -h "`$R" | tail -1 | awk '{print "Disco livre no servidor: " `$4}'
"@ | ForEach-Object { Write-Host $_ }

# ---------------------------------------------------------------- conferência
Passo 'Conferindo pela internet'
$r = Invoke-WebRequest -UseBasicParsing ($UrlPublica + 'Pepe.application') -Headers @{ 'Cache-Control' = 'no-cache' }
$txt = if ($r.Content -is [byte[]]) { [Text.Encoding]::UTF8.GetString($r.Content) } else { [string]$r.Content }   # PS 5: tipo não-texto chega como bytes
[xml]$online = $txt.TrimStart([char]0xFEFF)
$vOnline = $online.assembly.assemblyIdentity.version
Write-Host "Pepe.application: $($r.Headers['Content-Type']) | versão $vOnline"
if ($vOnline -ne $versao) { throw "O servidor responde a versão $vOnline, esperado $versao." }
$s = Invoke-WebRequest -UseBasicParsing ($UrlPublica + 'setup.exe') -Method Head
Write-Host "setup.exe: $($s.Headers['Content-Type']) | $($s.Headers['Content-Length']) bytes"

# ---------------------------------------------------------------- próxima revisão
$novo = $projTxt -replace '<ApplicationRevision>\d+</ApplicationRevision>', "<ApplicationRevision>$($rev + 1)</ApplicationRevision>"
[IO.File]::WriteAllText($Proj, $novo, (New-Object System.Text.UTF8Encoding $true))
Remove-Item -Recurse -Force $Tmp -ErrorAction SilentlyContinue
Passo "Publicado: versão $versao em $UrlPublica (instalação: ${UrlPublica}setup.exe)"
