Imports System.Configuration
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports Microsoft.Win32

Module modConn
    Public varBtn As Integer = 0
    Public varMatric As Integer = 0
    Public varIdCliente As Integer = 0
    Public varIdVenda As Integer = 0
    Public varNovaVenda As String = ""
    Public varNomePeça As String = ""
    Public varIdDet As Integer = 0
    Public varNomeCli As String = ""
    Public varNomeMD As String = ""
    Public varIdCC As Integer = 0
    Public varIdPeça As Integer = 0
    Public varFlag As Boolean = False
    ' Formulário que abriu o frmEstoque por AbrirCadastroPeça e volta a aparecer quando ele fecha.
    Public frmOrigemPeça As Form = Nothing


    Private provedorOleDb As String = Nothing

    Public Function strAdoConnection() As String
        ' Conexão central (ver modConexao): lida do config, já com a conexão da máquina aplicada no início do programa.
        Dim info As New SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings(NOME_CONEXAO).ConnectionString)

        ' MSOLEDBSQL quando instalado; senão o SQLOLEDB.1 legado, que vem com o Windows.
        ' O processo é x86, então o ClassesRoot já é a visão de 32 bits do registro.
        If provedorOleDb Is Nothing Then
            Using chave As RegistryKey = Registry.ClassesRoot.OpenSubKey("MSOLEDBSQL")
                provedorOleDb = If(chave IsNot Nothing, "MSOLEDBSQL", "SQLOLEDB.1")
            End Using
        End If

        strAdoConnection = "Provider=" & provedorOleDb & ";Data Source=" & info.DataSource & ";Initial Catalog=" & info.InitialCatalog _
           & ";User ID=" & info.UserID & ";Password=" & info.Password & ";"

    End Function

    Public Function fGetAdoConnection() As ADODB.Connection
        Dim cnn As ADODB.Connection
        On Error GoTo ErrHandler

        cnn = New ADODB.Connection
        cnn.Open(strAdoConnection)

        fGetAdoConnection = cnn

ExitHere:
        Exit Function

ErrHandler:
        MsgBox(Err.Description & vbCrLf & Err.Number & vbCrLf & Err.Source, vbCritical, "Sql_Bas_Connection-fGetAdoConnection")
        Resume ExitHere

    End Function
    Public Function fGetAdoConnection2() As SqlConnection
        Dim cnn As SqlConnection

        Try
            cnn = New SqlConnection(My.Settings.Pepe_ConnString)
            cnn.Open()
            Return cnn
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Sql_Bas_Connection-fGetAdoConnection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function
    Private Sub teste()
        Dim oConf As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        'Dim conn As System.Configuration.ConfigurationSection
        'conn.SectionInformation.Name = ""
        oConf.Sections.Remove("connectionStrings")
        'oConf.Sections.Add("connectionStrings", conn)
        oConf.Save(ConfigurationSaveMode.Full)
    End Sub

    Sub GetConnectionStrings()
        ' Get the connectionStrings.
        Dim connectionStrings As _
        ConnectionStringSettingsCollection =
        ConfigurationManager.ConnectionStrings

        ' Get the collection enumerator.
        Dim connectionStringsEnum As IEnumerator =
        connectionStrings.GetEnumerator()

        ' Loop through the collection and 
        ' display the connectionStrings key, value pairs.
        Dim i As Integer = 0
        While connectionStringsEnum.MoveNext()
            Dim name As String = connectionStrings(i).Name
            Console.WriteLine("Name: {0 Value: {1",
            name, connectionStrings(name))
            i += 1
        End While
    End Sub 'GetConnectionStrings

    Sub teste2()
        Dim settings As New ConnectionStringSettings    'Projeto/Adicionar Referência/System.Configuration
        Dim info As String, serv As String, db As String, us As String, pw As String

        settings = ConfigurationManager.ConnectionStrings("Pepe.My.MySettings.Pepe_ConnString")
        info = settings.ConnectionString.ToString
        serv = Mid$(info, 13, InStr(info, ";") - 13)
        db = Mid$(info, InStr(info, "Initial Catalog=") + 16, InStr(info, ";Persist") - InStr(info, "Initial Catalog=") - 16)
        us = Mid$(info, InStr(info, "User ID=") + 8, InStr(info, ";Password") - InStr(info, "User ID=") - 8)
        pw = Microsoft.VisualBasic.Right(info, Len(info) - InStr(info, ";Password") - 9)

        Debug.Print("Provider=sqloledb;Data Source=" & serv & ";Initial Catalog=" & db _
                   & ";User ID=" & us & ";Password=" & pw & ";")

    End Sub

    Public Sub fExecutarText(txtSql As String)
        Dim cnn As ADODB.Connection = fGetAdoConnection()
        Dim cmd As ADODB.Command = New ADODB.Command

        cmd.ActiveConnection = cnn
        cmd.CommandType = ADODB.CommandTypeEnum.adCmdText  'adCmdText
        cmd.CommandText = txtSql
        cmd.CommandTimeout = 0
        cmd.Execute()
        cnn.Close()

    End Sub

    Public Sub fExecutarSP(txtSP As String)

        Dim cnn As ADODB.Connection = fGetAdoConnection()
        Dim cmd As ADODB.Command = New ADODB.Command

        Try
            cmd.ActiveConnection = cnn
            cmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            cmd.CommandText = txtSP
            cmd.CommandTimeout = 0
            cmd.Execute()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)

        Finally
            cnn.Close()

        End Try


    End Sub

    ' Abre o cadastro da peça escondendo quem chamou; o frmEstoque devolve o foco a ela ao fechar.
    Public Sub AbrirCadastroPeça(idPeça As Integer, origem As Form)
        If idPeça = 0 Then
            MsgBox("Peça não encontrada.", MsgBoxStyle.Information, "Atenção!")
            Exit Sub
        End If

        varIdPeça = idPeça
        varNew = False
        frmOrigemPeça = origem
        frmEstoque.Show()

    End Sub

    ' A ficha (Classe + Modêlo) não é única no estoque: só identifica a peça dentro da venda ou da saída.
    Public Function IdPeçaDaVenda(idVenda As Integer, ficha As String) As Integer
        Return IdPeçaPorFicha("SELECT TOP 1 d.Peça FROM [VENDAS DET] d INNER JOIN [1TabPeças] p ON p.IDPeça = d.Peça " &
                              "WHERE d.Venda = @id AND p.Classe + p.Modêlo = @ficha", idVenda, ficha)
    End Function

    Public Function IdPeçaDaSaída(numSaida As Integer, ficha As String) As Integer
        Return IdPeçaPorFicha("SELECT TOP 1 s.IdPeça FROM Saidas s INNER JOIN [1TabPeças] p ON p.IDPeça = s.IdPeça " &
                              "WHERE s.NumSaida = @id AND p.Classe + p.Modêlo = @ficha", numSaida, ficha)
    End Function

    Private Function IdPeçaPorFicha(sql As String, id As Integer, ficha As String) As Integer
        Using cnn As New SqlConnection(ConfigurationManager.ConnectionStrings(NOME_CONEXAO).ConnectionString)
            Using cmd As New SqlCommand(sql, cnn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@ficha", ficha.Trim())
                cnn.Open()
                Dim r As Object = cmd.ExecuteScalar()
                If r Is Nothing OrElse IsDBNull(r) Then Return 0
                Return CInt(r)
            End Using
        End Using
    End Function

End Module