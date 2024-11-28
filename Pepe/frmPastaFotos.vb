Imports System
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.File
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Text
Imports ADODB

Public Class frmPastaFotos

    Private Sub btnPasta_Click(sender As System.Object, e As System.EventArgs) Handles btnPasta.Click
        Try
            Dim dr As DialogResult = Me.FolderBrowserDialog1.ShowDialog()

            If dr = System.Windows.Forms.DialogResult.OK Then
                Me.txtPasta.Text = FolderBrowserDialog1.SelectedPath
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnPDFs_Click(sender As System.Object, e As System.EventArgs) Handles btnPDFs.Click

        Dim cn As New ADODB.Connection()
        Dim rs As New ADODB.Recordset(), rs2 As New ADODB.Recordset(), rs3 As New ADODB.Recordset()
        Dim cnStr As String

        Me.Tag = ""
        cnStr = strAdoConnection()

        Try
            If Me.txtPasta.Text = "" Then
                MsgBox("Por favor, informe a pasta onde estão as fotos", MsgBoxStyle.Critical)
                Exit Sub
            End If

            'Dim strm As StreamWriter

            'Dim unidade As String = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.CurDir, 3)
            'If Microsoft.VisualBasic.Dir(unidade & "temp\") = "" Then
            '    Microsoft.VisualBasic.MkDir(unidade & "temp\")
            '    strm = New StreamWriter(unidade & "temp\logpdf.txt")
            '    strm.WriteLine("Início")
            '    strm.Close()
            'Else
            '    If Not File.Exists(unidade & "temp\logpdf.txt") Then
            '        strm = New StreamWriter(unidade & "temp\logpdf.txt")
            '        strm.WriteLine("Início")
            '        strm.Close()
            '    End If
            'End If

            Me.Cursor = Cursors.WaitCursor

            If ProgBar.Value = ProgBar.Maximum Then
                ProgBar.Value = ProgBar.Minimum
            End If

            Dim DirDiretorio As DirectoryInfo = New DirectoryInfo(Me.txtPasta.Text)
            Dim oFileInfoCollection() As FileInfo
            Dim oFileInfo As FileInfo
            Dim i As Integer
            Dim varNome As String

            If RadioGroup.EditValue = "jpg" Then
                oFileInfoCollection = DirDiretorio.GetFiles("*.jpg")
            Else
                oFileInfoCollection = DirDiretorio.GetFiles("*.bmp")
            End If

            ProgBar.Maximum = oFileInfoCollection.Length()
            For i = 0 To oFileInfoCollection.Length() - 1

                ProgBar.Value += 1
                oFileInfo = CType(oFileInfoCollection.GetValue(i), FileInfo)

                Me.Tag = ""
                varNome = Microsoft.VisualBasic.Left(oFileInfo.Name, Len(oFileInfo.Name) - 4)
                Me.Tag = varNome

                Dim FSO As New System.IO.FileStream(Me.txtPasta.Text & "\" & oFileInfo.Name, IO.FileMode.OpenOrCreate, IO.FileAccess.Read)
                Dim imgArrayByte(CType(FSO.Length() - 1, Integer)) As Byte

                rs.Open("Select REGISTR_PACIENTE, FotoDB from Pacientes Where FotoDB Is Null And REGISTR_PACIENTE = " & CType(varNome, Integer), cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
                If Not rs.EOF Then

                    Application.DoEvents()
                    Me.txtArqs.Text = "Arquivo " & CStr(i + 1) & "/" & CStr(oFileInfoCollection.Length()) & " : " & varNome
                    Application.DoEvents()

                    FSO.Read(imgArrayByte, 0, imgArrayByte.Length)
                    FSO.Close()

                    rs("FotoDB").Value = imgArrayByte
                    rs.Update()
                End If
                rs.Close()
            Next

            MsgBox("Importação concluída com sucesso!")
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Por favor, clique novamente no botão <Importar arquivos>", MsgBoxStyle.Information)

        End Try

    End Sub

    Private Sub btnTeste_Click(sender As System.Object, e As System.EventArgs) Handles btnTeste.Click
        Dim oConn As OleDb.OleDbConnection
        Dim oComm As OleDb.OleDbCommand
        Dim DirDiretorio As DirectoryInfo = New DirectoryInfo(Me.txtPasta.Text)
        Dim oFileInfoCollection() As FileInfo
        Dim oFileInfo As FileInfo
        Dim i As Integer

        oFileInfoCollection = DirDiretorio.GetFiles("*.pdf")

        Dim cn As New ADODB.Connection()
        Dim rs As New ADODB.Recordset()
        Dim cnStr As String

        cnStr = strAdoConnection()
        rs.Open("Select * from tb01_CadLeg", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        For i = 0 To oFileInfoCollection.Length() - 1
            ProgBar.Value += 1
            oFileInfo = oFileInfoCollection.GetValue(i)
            'Dim fs As New FileStream(Me.txtPasta.Text & "\" & oFileInfo.Name, FileMode.OpenOrCreate, FileAccess.Read)

            Dim FSO As New System.IO.FileStream(Me.txtPasta.Text & "\" & oFileInfo.Name, IO.FileMode.Open, IO.FileAccess.Read)
            Dim imgArrayByte(CType(FSO.Length() - 1, Integer)) As Byte
            FSO.Read(imgArrayByte, 0, imgArrayByte.Length)
            FSO.Close()

            rs.AddNew()
            rs("Integra").Value = imgArrayByte
            rs.Update()
        Next

        rs.Close()

        MsgBox("Image is saved successfully to the Database",
               MsgBoxStyle.OkOnly,
               "Successfully Saved")

        oConn = Nothing
        oComm = Nothing
    End Sub

    Private Sub frmPastaFotos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If Me.txtPasta.Text <> "" Then
            My.Settings.PastaFotos = Me.txtPasta.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub frmPastaFotos_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.txtPasta.Text = My.Settings.PastaFotos

    End Sub
End Class