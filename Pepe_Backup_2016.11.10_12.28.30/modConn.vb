Imports System.Configuration
Imports System
Imports System.IO
Imports System.Text

Module modConn

    Public varMatric As Integer = 0
    Public varIdCliente As Integer = 0
    Public varIdVenda As Integer = 0
    Public varNovaVenda As String = ""
    Public varNomePeça As String = ""
    Public varIdDet As Integer = 0
    Public varNomeCli As String = ""
    Public varNomeMD As String = ""



    Public Function strAdoConnection() As String
        Dim settings As New ConnectionStringSettings    'Projeto/Adicionar Referência/System.Configuration
        Dim info As String, serv As String, db As String, us As String, pw As String

        settings = ConfigurationManager.ConnectionStrings("Pepe.My.MySettings.Pepe_ConnString")
        info = settings.ConnectionString.ToString
        serv = Mid$(info, 13, InStr(info, ";") - 13)
        db = Mid$(info, InStr(info, "Initial Catalog=") + 16, InStr(info, ";Persist") - InStr(info, "Initial Catalog=") - 16)
        us = Mid$(info, InStr(info, "User ID=") + 8, InStr(info, ";Password") - InStr(info, "User ID=") - 8)
        pw = Microsoft.VisualBasic.Right(info, Len(info) - InStr(info, ";Password") - 9)

        strAdoConnection = "Provider=sqloledb;Data Source=" & serv & ";Initial Catalog=" & db _
                   & ";User ID=" & us & ";Password=" & pw & ";"

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
        ConnectionStringSettingsCollection = _
        ConfigurationManager.ConnectionStrings

        ' Get the collection enumerator.
        Dim connectionStringsEnum As IEnumerator = _
        connectionStrings.GetEnumerator()

        ' Loop through the collection and 
        ' display the connectionStrings key, value pairs.
        Dim i As Integer = 0
        While connectionStringsEnum.MoveNext()
            Dim name As String = connectionStrings(i).Name
            Console.WriteLine("Name: {0 Value: {1", _
            name, connectionStrings(name))
            i += 1
        End While
    End Sub 'GetConnectionStrings

    Public Function Nz(ByVal Value As String, ByVal Defaultt As String) As String
        If Value Is Nothing OrElse IsDBNull(Value) Or Value = "" Then
            Return Defaultt
        Else
            Return Value
        End If
    End Function

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

        cmd.ActiveConnection = cnn
        cmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        cmd.CommandText = txtSP
        cmd.CommandTimeout = 0
        cmd.Execute()
        cnn.Close()

    End Sub

End Module