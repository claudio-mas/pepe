Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Text

''' <summary>
''' Fonte única da conexão com o banco.
'''
''' A publicação ClickOnce NÃO leva senha: o Pepe.exe.config publicado tem a conexão sem "Password".
''' Cada computador guarda a conexão completa num arquivo local criptografado pelo Windows (DPAPI,
''' escopo da máquina) em %ProgramData%\PepeTorrasDesign\conexao.dat, criado pela tela frmConexao
''' na primeira execução.
'''
''' No início do programa (ApplicationEvents), PrepararConexao aplica essa conexão a todo o sistema:
''' ConfigurationManager (DevExpress, strAdoConnection) e My.Settings (TableAdapters, LINQ).
''' Na máquina de desenvolvimento, se o app.config já tiver senha, ele continua sendo usado como antes.
''' </summary>
Public Module modConexao

    Public Const NOME_CONEXAO As String = "Pepe.My.MySettings.Pepe_ConnString"

    ' Complemento da criptografia: sem ele o arquivo não é aberto por outro programa que use DPAPI.
    Private ReadOnly Complemento As Byte() = Encoding.UTF8.GetBytes("PepeTorrasDesign.Conexao.v1")

    Public ReadOnly Property ArquivoConexaoLocal As String
        Get
            Return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                                "PepeTorrasDesign", "conexao.dat")
        End Get
    End Property

    ''' <summary>Conexão configurada no Pepe.exe.config (na publicação, sem senha).</summary>
    Public Function ConexaoDoConfig() As String
        Dim cs = ConfigurationManager.ConnectionStrings(NOME_CONEXAO)
        Return If(cs Is Nothing, "", cs.ConnectionString)
    End Function

    Public Function TemSenha(connectionString As String) As Boolean
        Try
            Return New SqlConnectionStringBuilder(connectionString).Password <> ""
        Catch
            Return False
        End Try
    End Function

    Public Function LerConexaoLocal() As String
        Try
            If Not File.Exists(ArquivoConexaoLocal) Then Return Nothing
            Dim dados = ProtectedData.Unprotect(File.ReadAllBytes(ArquivoConexaoLocal), Complemento, DataProtectionScope.LocalMachine)
            Return Encoding.UTF8.GetString(dados)
        Catch
            Return Nothing   ' arquivo corrompido ou de outro computador: pede de novo
        End Try
    End Function

    Public Sub SalvarConexaoLocal(connectionString As String)
        Directory.CreateDirectory(Path.GetDirectoryName(ArquivoConexaoLocal))
        Dim dados = ProtectedData.Protect(Encoding.UTF8.GetBytes(connectionString), Complemento, DataProtectionScope.LocalMachine)
        File.WriteAllBytes(ArquivoConexaoLocal, dados)
    End Sub

    Public Function TestarConexao(connectionString As String, ByRef erro As String) As Boolean
        Try
            Dim b As New SqlConnectionStringBuilder(connectionString) With {.ConnectTimeout = 8}
            Using cn As New SqlConnection(b.ConnectionString)
                cn.Open()
            End Using
            erro = ""
            Return True
        Catch ex As Exception
            erro = ex.Message
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Faz o sistema inteiro usar esta conexão: altera, em memória, a entrada do app.config
    ''' (lida pelo DevExpress e por strAdoConnection) e o My.Settings (TableAdapters e LINQ).
    ''' </summary>
    Public Sub AplicarConexao(connectionString As String)
        Dim cs = ConfigurationManager.ConnectionStrings(NOME_CONEXAO)
        If cs IsNot Nothing Then
            ' A seção do config é somente leitura; esta é a forma usual de trocá-la em memória.
            Dim somenteLeitura = GetType(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance Or BindingFlags.NonPublic)
            somenteLeitura.SetValue(cs, False)
            cs.ConnectionString = connectionString
        End If
        My.Settings.Item("Pepe_ConnString") = connectionString
    End Sub

    ''' <summary>
    ''' Chamado no início do programa. Retorna False se o usuário desistir de configurar a conexão.
    ''' </summary>
    Public Function PrepararConexao() As Boolean
        Dim local = LerConexaoLocal()
        If local IsNot Nothing Then
            Dim erro As String = ""
            If TestarConexao(local, erro) Then
                AplicarConexao(local)
                Return True
            End If
            Return PedirConexao(local, "Não foi possível conectar ao banco de dados com a configuração salva neste computador:" &
                                vbCrLf & erro)
        End If

        ' Máquina de desenvolvimento: app.config com senha continua funcionando como sempre.
        If TemSenha(ConexaoDoConfig()) Then Return True

        ' Instalação nova (ClickOnce): a publicação não tem senha, então pede neste computador.
        Return PedirConexao(ConexaoDoConfig(), "Primeira execução neste computador: informe os dados de acesso ao banco de dados.")
    End Function

    ''' <summary>Abre a tela de conexão (também pode ser chamada depois, para trocar de servidor/senha).</summary>
    Public Function PedirConexao(sugestao As String, mensagem As String) As Boolean
        Using f As New frmConexao(sugestao, mensagem)
            Return f.ShowDialog() = DialogResult.OK
        End Using
    End Function

End Module
