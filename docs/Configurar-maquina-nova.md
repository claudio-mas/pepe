# Configurar uma máquina nova de desenvolvimento

Roteiro para levar o projeto Pepe para um computador novo com Windows 11, Visual Studio 2026 e o SQL Server
num contêiner Docker. Siga na ordem; cada etapa termina com uma conferência.

## 0. Na máquina antiga (antes de desligá-la)

1. **Criar o repositório no GitHub.** Em github.com → *New repository* → nome `pepe`, **Private**, sem README,
   sem .gitignore, sem licença. Tem de ser privado: o histórico antigo contém senhas de desenvolvimento.
2. **Enviar o código** (PowerShell, na raiz do projeto):

   ```powershell
   cd C:\Sistema\Paco\Pepe
   git remote add origin https://github.com/claudio-mas/pepe.git
   git push -u origin master
   ```

   São ~150 MB (as DLLs de terceiros em `Pepe\bin\Debug` vão junto, de propósito). O Git pede login no GitHub
   pelo navegador na primeira vez.
3. **Copiar as chaves SSH** (usadas para publicar na VPS) para um pendrive — **não** por e-mail nem nuvem:
   - `%USERPROFILE%\.ssh\nova_ed25519` e `nova_ed25519.pub`
   - as entradas `Host nova` e `Host informas` de `%USERPROFILE%\.ssh\config`
4. **Anotar o collation do servidor SQL atual** (vai ser usado no contêiner). No SSMS:
   `SELECT SERVERPROPERTY('Collation')`.
5. Conferência: `git status` limpo (fora de `bin`/`obj`) e o repositório aparece no GitHub com o último commit.

Não apague nada na máquina antiga até a nova estar validada (etapa 7). Os `.git` antigos, de antes da união dos
repositórios, estão em `C:\Sistema\Paco\_git_antigo_Pepe` e podem ser descartados depois disso.

## 1. Programas

| Programa | Observações |
|---|---|
| **Git for Windows** | Na instalação, mantenha "Checkout Windows-style, commit Unix-style line endings". |
| **Visual Studio 2026** | Workload **.NET desktop development**. Em *Individual components*, marque **.NET Framework 4.8 targeting pack**. |
| **Extensão Microsoft RDLC Report Designer 2022+** | *Extensions → Manage Extensions* → procure "RDLC". Necessária para abrir os `.rdlc` no designer. |
| **Docker Desktop** | Backend WSL 2 (o instalador ativa o WSL se precisar; reinicie quando pedir). |
| **SQL Server Management Studio** | Opcional, para administrar o banco. |

Componentes de terceiros: só resta o **DevExpress 25.2** (ComponentOne, Infragistics e Telerik já foram removidos
do projeto). **Não instale de início**: as DLLs estão versionadas em `Pepe\bin\Debug` e o projeto compila com elas.
Instale o DevExpress 25.2 só se:
- o executável gerado mostrar aviso de versão *trial* (os controles licenciados estão em `My Project\licenses.licx`;
  a licença vale para a máquina onde se compila) — nesse caso instale o produto com a sua licença; ou
- precisar do designer visual dos formulários DevExpress. Como o plano é removê-lo, também dá para editar o
  `.Designer.vb` à mão ou converter o formulário para WinForms.

Conferência: `git --version`, `docker version` (cliente e servidor respondem).

## 2. Código

```powershell
git config --global user.name  "Claudio Mas"
git config --global user.email "claudio.mas@gmail.com"
git config --global core.autocrlf true
git clone https://github.com/claudio-mas/pepe.git C:\Sistema\Paco\Pepe
```

Use o mesmo caminho da máquina antiga (`C:\Sistema\Paco\Pepe`): o `CLAUDE.md` e os exemplos de comando partem dele.

Conferência: `git -C C:\Sistema\Paco\Pepe log --oneline -1` mostra o último commit.

## 3. Banco de dados no Docker

Com o Docker Desktop aberto, no PowerShell. Troque o collation pelo anotado na etapa 0.4
(`Latin1_General_CI_AS` e `SQL_Latin1_General_CP1_CI_AS` são os mais comuns).

```powershell
$senha = Read-Host 'Senha do sa (8+ caracteres, com maiúscula, minúscula, número e símbolo)'
docker volume create pepe-sql-dados
docker run -d --name pepe-sql --restart unless-stopped `
  -e ACCEPT_EULA=Y -e "MSSQL_SA_PASSWORD=$senha" -e MSSQL_PID=Developer `
  -e MSSQL_COLLATION=Latin1_General_CI_AS `
  -p 1433:1433 -v pepe-sql-dados:/var/opt/mssql `
  mcr.microsoft.com/mssql/server:2022-latest
Remove-Variable senha
docker logs -f pepe-sql     # espere "SQL Server is now ready for client connections" e tecle Ctrl+C
```

- Os dados ficam no volume `pepe-sql-dados`: apagar ou recriar o contêiner não perde o banco (apagar o volume, sim).
- `--restart unless-stopped` faz o SQL subir junto com o Docker Desktop. Ative em Docker Desktop → *Settings →
  General → Start Docker Desktop when you sign in*.
- A senha do `sa` fica visível em `docker inspect pepe-sql`. Para uma máquina de desenvolvimento é aceitável;
  não reutilize a senha da loja.

**Restaurar o `BDTorras`** a partir de um `.bak` (troque o caminho do arquivo):

```powershell
docker exec pepe-sql mkdir -p /var/opt/mssql/backup
docker cp "C:\caminho\BDTorras.bak" pepe-sql:/var/opt/mssql/backup/BDTorras.bak
docker exec -u root pepe-sql chown mssql /var/opt/mssql/backup/BDTorras.bak
# lista os nomes lógicos dos arquivos (coluna LogicalName); o sqlcmd pede a senha do sa
docker exec -it pepe-sql /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -C `
  -Q "RESTORE FILELISTONLY FROM DISK='/var/opt/mssql/backup/BDTorras.bak'"
```

Com os nomes lógicos (aqui `BDTorras` e `BDTorras_log` como exemplo):

```powershell
docker exec -it pepe-sql /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -C -Q "RESTORE DATABASE BDTorras FROM DISK='/var/opt/mssql/backup/BDTorras.bak' WITH MOVE 'BDTorras' TO '/var/opt/mssql/data/BDTorras.mdf', MOVE 'BDTorras_log' TO '/var/opt/mssql/data/BDTorras_log.ldf', RECOVERY, STATS=10"
```

Se o sistema entrar com um login SQL que não seja o `sa`, o usuário dele no banco restaurado fica "órfão".
Recrie o login e religue-o (no SSMS, conectado em `localhost,1433`):
`CREATE LOGIN <login> WITH PASSWORD = '...'; USE BDTorras; ALTER USER <login> WITH LOGIN = <login>;`

Conferência: no SSMS (servidor `localhost,1433`, autenticação SQL Server, usuário `sa`; marque *Trust server
certificate*), o banco `BDTorras` aparece e `SELECT COUNT(*) FROM BDTorras.sys.tables` devolve as tabelas.

## 4. Compilar e rodar

1. Abra `C:\Sistema\Paco\Pepe\Pepe.sln` no Visual Studio 2026. Se ele oferecer atualizar o framework do projeto,
   **recuse** — o projeto fica em .NET Framework 4.8. Os projetos `Setup` e `Setup1` (instalador MSI legado)
   ficam como "não carregados" sem a extensão *Installer Projects*; pode ignorar, não são mais usados.
2. Barra de ferramentas: **Debug** e **x86**.
3. *Build → Build Solution*. Os pacotes NuGet (ReportViewer, SqlServer.Types) são restaurados na primeira
   compilação. Muitos arquivos de `Pepe\bin` e `Pepe\obj` aparecem como alterados no Git — é esperado.
4. **F5.** A conexão é escolhida por máquina (`modConexao.PrepararConexao`):
   - Se o nome da máquina (`hostname`) estiver na chave `MaquinasDesenvolvimento` do `Pepe\app.config`, o sistema
     usa direto a conexão de dev do `app.config` (hoje, o contêiner de `Pepe\Docker` em `127.0.0.1,14330`).
     Para usar assim, acrescente o nome da máquina à lista (separado por `;`) e ajuste a conexão ao seu contêiner.
   - Senão, na primeira execução abre a tela **Conexão com o banco de dados**:
     Servidor `localhost,1433` (ou o do seu contêiner) · Banco `BDTorras` · Usuário `sa` · Senha do contêiner.
     Ela testa a conexão e grava tudo criptografado em `%ProgramData%\PepeTorrasDesign\conexao.dat`
     (para trocar de banco depois, apague esse arquivo).
5. Faça o login do sistema normalmente.

Conferência: abra a lista de clientes e o relatório **Vendas** de um mês conhecido; os números devem bater com a
máquina antiga. Se aparecer aviso de versão *trial* de algum componente, veja a etapa 1.

Se as telas que usam ADODB (`fExecutarSP`, `DLookUp`) derem erro de conexão: `strAdoConnection` (`modConn.vb`)
usa o provider `MSOLEDBSQL` se ele estiver registrado na máquina e o `SQLOLEDB.1` (que vem com o Windows) caso
contrário. Normalmente o `SQLOLEDB.1` funciona com o SQL 2022 local; se não, instale o *Microsoft OLE DB Driver
for SQL Server*.

## 5. Chaves SSH (publicação)

Com o pendrive da etapa 0.3 (troque `E:` pela letra dele):

```powershell
New-Item -ItemType Directory -Force "$env:USERPROFILE\.ssh" | Out-Null
Copy-Item E:\nova_ed25519, E:\nova_ed25519.pub "$env:USERPROFILE\.ssh\"
icacls "$env:USERPROFILE\.ssh\nova_ed25519" /inheritance:r /grant:r "${env:USERNAME}:F"
notepad "$env:USERPROFILE\.ssh\config"    # cole as entradas "Host nova" e "Host informas"
ssh informas "echo ok"                     # na 1ª vez, confirme a impressão digital com "yes"
```

O `icacls` é necessário: o OpenSSH do Windows recusa chave privada que outros usuários possam ler.

Conferência: o `ssh` responde `ok` sem pedir senha.

## 6. Publicação de teste

```powershell
cd C:\Sistema\Paco\Pepe
powershell -ExecutionPolicy Bypass -File Pepe\Scripts\Publicar-ClickOnce.ps1 -SemEnvio
```

Gera a publicação só em `publish\`, sem enviar nada (restaura sozinho os pacotes NuGet que faltarem).
Conferência: termina com "Pronto (sem envio)".
A publicação de verdade (sem `-SemEnvio`) fica para quando houver versão nova para a loja.

## 7. Encerramento

- Crie um commit de teste pequeno e dê `git push` para confirmar que a máquina nova envia para o GitHub.
- Para o Claude continuar o trabalho: no aplicativo Claude para desktop, conecte a pasta `C:\Sistema\Paco\Pepe`.
  O `CLAUDE.md` da raiz orienta o trabalho no projeto.
- Validado tudo, a máquina antiga pode ser desativada. Antes, apague dela `%ProgramData%\PepeTorrasDesign\conexao.dat`
  e as chaves de `%USERPROFILE%\.ssh` se ela for sair das suas mãos.
