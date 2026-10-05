# Sobe o container bdtorras_mssql (se preciso) e restaura o BDTorras a partir de um .bak.
# Idempotente: RESTORE ... WITH REPLACE sobrescreve o banco existente no container.
# Uso: .\restaurar-bdtorras.ps1 [-Bak C:\Sistema\Paco\BDTorras.bak]
param(
    [string]$Bak = 'C:\Sistema\Paco\BDTorras.bak'
)

$ErrorActionPreference = 'Stop'
$container = 'bdtorras_mssql'
$senha     = 'Torras#2026Dev'
$destino   = '/var/opt/mssql/backup/BDTorras.bak'

function Sql([string]$query) {
    # -C confia no certificado autoassinado do container; -b devolve exit code em erro de SQL
    $saida = docker exec $container /opt/mssql-tools18/bin/sqlcmd -C -S localhost -U sa -P $senha -b -W -h -1 -s '|' -Q $query
    if ($LASTEXITCODE -ne 0) { throw "sqlcmd falhou:`n$($saida -join "`n")" }
    $saida
}

if (-not (Test-Path $Bak)) { throw "Backup não encontrado: $Bak" }

docker compose -f (Join-Path $PSScriptRoot 'docker-compose.yml') up -d
if ($LASTEXITCODE -ne 0) { throw 'docker compose up falhou' }

# O SQL Server leva alguns segundos para aceitar login depois que o container sobe
Write-Host 'Aguardando o SQL Server...'
$pronto = $false
for ($i = 0; $i -lt 40; $i++) {
    docker exec $container /opt/mssql-tools18/bin/sqlcmd -C -S localhost -U sa -P $senha -b -Q 'SELECT 1' *> $null
    if ($LASTEXITCODE -eq 0) { $pronto = $true; break }
    Start-Sleep -Seconds 3
}
if (-not $pronto) { throw 'SQL Server não respondeu em 2 minutos (veja: docker logs bdtorras_mssql)' }

Write-Host "Copiando $Bak para o container..."
docker exec $container mkdir -p /var/opt/mssql/backup
docker cp $Bak "${container}:$destino"
if ($LASTEXITCODE -ne 0) { throw 'docker cp falhou' }
docker exec -u 0 $container chown mssql $destino

try {
    # Nomes lógicos dos arquivos (mdf/ldf) para o MOVE
    $arquivos = Sql "SET NOCOUNT ON; DECLARE @f TABLE(LogicalName nvarchar(128),PhysicalName nvarchar(260),Type char(1),FileGroupName nvarchar(128),Size numeric(20,0),MaxSize numeric(20,0),FileId bigint,CreateLSN numeric(25,0),DropLSN numeric(25,0),UniqueId uniqueidentifier,ReadOnlyLSN numeric(25,0),ReadWriteLSN numeric(25,0),BackupSizeInBytes bigint,SourceBlockSize int,FileGroupId int,LogGroupGUID uniqueidentifier,DifferentialBaseLSN numeric(25,0),DifferentialBaseGUID uniqueidentifier,IsReadOnly bit,IsPresent bit,TDEThumbprint varbinary(32),SnapshotUrl nvarchar(360)); INSERT @f EXEC('RESTORE FILELISTONLY FROM DISK=''$destino'''); SELECT LogicalName + '|' + Type FROM @f"

    $moves = foreach ($linha in $arquivos | Where-Object { $_ -match '\|' }) {
        $nome, $tipo = $linha.Trim() -split '\|'
        $fisico = if ($tipo -eq 'L') { 'BDTorras_log.ldf' } else { "$nome.mdf" }
        "MOVE N'$nome' TO N'/var/opt/mssql/data/$fisico'"
    }

    Write-Host 'Restaurando BDTorras...'
    Sql "IF DB_ID('BDTorras') IS NOT NULL ALTER DATABASE BDTorras SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE BDTorras FROM DISK=N'$destino' WITH $($moves -join ', '), REPLACE, STATS=10; ALTER DATABASE BDTorras SET MULTI_USER;"

    Sql "SET NOCOUNT ON; SELECT name, state_desc, collation_name, compatibility_level FROM sys.databases WHERE name = 'BDTorras'"
}
finally {
    # O .bak não precisa ficar ocupando espaço no volume
    docker exec $container rm -f $destino
}

Write-Host 'BDTorras restaurado em 127.0.0.1,14330'
