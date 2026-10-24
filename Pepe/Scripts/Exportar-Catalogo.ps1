# Roda o CAT_v0_investigacao.sql (somente leitura) e grava cada bloco num CSV em docs\legado\banco\.
# O código de views, procs, funções e gatilhos vai para docs\legado\banco\modulos\<tipo>\<schema>.<nome>.sql.
# Nenhum bloco devolve dado pessoal: só estrutura e contagens (LGPD). A saída pode ser commitada.
#
# Uso (na raiz do repositório ou em qualquer pasta):
#   powershell -ExecutionPolicy Bypass -File Pepe\Scripts\Exportar-Catalogo.ps1
#   powershell -ExecutionPolicy Bypass -File Pepe\Scripts\Exportar-Catalogo.ps1 -ConnectionString "Data Source=...;Initial Catalog=BDTorras;Integrated Security=True"
#
# Sem -ConnectionString, usa a Pepe.My.MySettings.Pepe_ConnString do Pepe\app.config (o contêiner de dev).
# Rode contra uma CÓPIA do BDTorras (o contêiner Docker), como manda o CLAUDE.md.
param(
    [string]$ConnectionString,
    [string]$Saida
)

$ErrorActionPreference = 'Stop'
$raiz = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
if (-not $Saida) { $Saida = Join-Path $raiz 'docs\legado\banco' }

if (-not $ConnectionString) {
    $config = Join-Path $raiz 'Pepe\app.config'
    [xml]$xml = Get-Content -Path $config -Encoding UTF8 -Raw
    $no = $xml.configuration.connectionStrings.add | Where-Object { $_.name -eq 'Pepe.My.MySettings.Pepe_ConnString' }
    if (-not $no) { throw "Pepe_ConnString não encontrada em $config" }
    $ConnectionString = $no.connectionString
}

$utf8 = New-Object System.Text.UTF8Encoding($false)
$inv = [System.Globalization.CultureInfo]::InvariantCulture

function Valor-Csv($v) {
    if ($v -is [System.DBNull] -or $null -eq $v) { return '' }
    if ($v -is [datetime]) { $t = $v.ToString('yyyy-MM-dd HH:mm:ss', $inv) }
    elseif ($v -is [bool]) { $t = if ($v) { '1' } else { '0' } }
    elseif ($v -is [System.IFormattable]) { $t = $v.ToString($null, $inv) }
    else { $t = [string]$v }
    if ($t -match '[",\r\n]') { $t = '"' + $t.Replace('"', '""') + '"' }
    return $t
}

function Gravar-Csv([System.Data.DataTable]$tabela, [string]$arquivo, [string[]]$ignorar) {
    $colunas = @($tabela.Columns | Where-Object { $ignorar -notcontains $_.ColumnName })
    $sb = New-Object System.Text.StringBuilder
    [void]$sb.AppendLine((($colunas | ForEach-Object { Valor-Csv $_.ColumnName }) -join ','))
    foreach ($linha in $tabela.Rows) {
        [void]$sb.AppendLine((($colunas | ForEach-Object { Valor-Csv $linha[$_.ColumnName] }) -join ','))
    }
    [System.IO.File]::WriteAllText($arquivo, $sb.ToString(), $utf8)
}

function Nome-Arquivo([string]$nome) {
    # Mantém acentos; troca só o que o Windows não aceita em nome de arquivo
    foreach ($c in [System.IO.Path]::GetInvalidFileNameChars()) { $nome = $nome.Replace([string]$c, '_') }
    return $nome
}

# Saída limpa a cada execução: só o que este script gera (CSV, .erro.txt e a pasta modulos)
New-Item -ItemType Directory -Force -Path $Saida | Out-Null
Get-ChildItem -Path $Saida -File | Where-Object { $_.Extension -in '.csv', '.txt' } | Remove-Item
$pastaModulos = Join-Path $Saida 'modulos'
if (Test-Path $pastaModulos) { Remove-Item -Recurse -Force $pastaModulos }

$sql = Get-Content -Path (Join-Path $PSScriptRoot 'CAT_v0_investigacao.sql') -Encoding UTF8 -Raw
$lotes = [regex]::Split($sql, '(?im)^\s*GO\s*$')

$conexao = New-Object System.Data.SqlClient.SqlConnection($ConnectionString)
$conexao.Open()
Write-Host "Conectado: $($conexao.DataSource) / $($conexao.Database)"
$falhas = 0
try {
    foreach ($lote in $lotes) {
        $m = [regex]::Match($lote, '(?m)^\s*--\s*@@\s*(\S+)\s*$')
        if (-not $m.Success) { continue }      # ex.: o lote do USE (a conexão já abre no BDTorras)
        $nome = $m.Groups[1].Value
        $cmd = $conexao.CreateCommand()
        $cmd.CommandText = $lote
        $cmd.CommandTimeout = 0
        $tabela = New-Object System.Data.DataTable
        try {
            $leitor = $cmd.ExecuteReader()
            $tabela.Load($leitor)
            $leitor.Close()
        }
        catch {
            $falhas++
            Write-Warning "$nome falhou: $($_.Exception.Message)"
            [System.IO.File]::WriteAllText((Join-Path $Saida "$nome.erro.txt"), $_.Exception.Message, $utf8)
            continue
        }

        if ($tabela.Columns.Contains('definicao')) {
            # Cada módulo vira um .sql, agrupado por tipo; o CSV fica sem o código-fonte
            foreach ($linha in $tabela.Rows) {
                $pasta = Join-Path $pastaModulos (Nome-Arquivo ([string]$linha['tipo']))
                New-Item -ItemType Directory -Force -Path $pasta | Out-Null
                $arquivo = Join-Path $pasta (Nome-Arquivo ("{0}.{1}.sql" -f $linha['schema'], $linha['nome']))
                [System.IO.File]::WriteAllText($arquivo, [string]$linha['definicao'], $utf8)
            }
            Gravar-Csv $tabela (Join-Path $Saida "$nome.csv") @('definicao')
        }
        else {
            Gravar-Csv $tabela (Join-Path $Saida "$nome.csv") @()
        }
        Write-Host ("{0,-22} {1,6} linha(s)" -f $nome, $tabela.Rows.Count)
    }
}
finally {
    $conexao.Close()
}

Write-Host "Saída em $Saida"
if ($falhas -gt 0) { Write-Warning "$falhas bloco(s) falharam; veja os arquivos .erro.txt" }
