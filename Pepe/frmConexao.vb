Imports System.Data.SqlClient

''' <summary>
''' Pede servidor, banco, usuário e senha; testa a conexão e, se der certo, guarda criptografada
''' neste computador (modConexao.SalvarConexaoLocal) e aplica ao sistema.
''' </summary>
Public Class frmConexao

    Public Sub New(sugestao As String, mensagem As String)
        InitializeComponent()
        lblMensagem.Text = mensagem
        Try
            Dim b As New SqlConnectionStringBuilder(If(sugestao, ""))
            txtServidor.Text = b.DataSource
            txtBanco.Text = If(b.InitialCatalog = "", "BDTorras", b.InitialCatalog)
            txtUsuario.Text = b.UserID
        Catch
            txtBanco.Text = "BDTorras"
        End Try
    End Sub

    Private Sub frmConexao_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If txtServidor.Text = "" Then txtServidor.Focus() Else txtSenha.Focus()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtServidor.Text.Trim() = "" OrElse txtBanco.Text.Trim() = "" OrElse txtUsuario.Text.Trim() = "" Then
            lblMensagem.Text = "Preencha servidor, banco e usuário."
            Return
        End If

        Dim b As New SqlConnectionStringBuilder With {
            .DataSource = txtServidor.Text.Trim(),
            .InitialCatalog = txtBanco.Text.Trim(),
            .PersistSecurityInfo = True,
            .UserID = txtUsuario.Text.Trim(),
            .Password = txtSenha.Text,
            .Encrypt = False
        }

        Me.Cursor = Cursors.WaitCursor
        btnSalvar.Enabled = False
        lblMensagem.Text = "Testando a conexão..."
        Application.DoEvents()

        Dim erro As String = ""
        Dim ok = TestarConexao(b.ConnectionString, erro)

        Me.Cursor = Cursors.Default
        btnSalvar.Enabled = True

        If Not ok Then
            lblMensagem.Text = "Não foi possível conectar: " & erro
            Return
        End If

        Try
            SalvarConexaoLocal(b.ConnectionString)
        Catch ex As Exception
            MessageBox.Show("A conexão funcionou, mas não foi possível salvá-la neste computador:" & vbCrLf & ex.Message &
                            vbCrLf & vbCrLf & "O sistema vai abrir, mas pedirá os dados de novo na próxima vez.",
                            "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        AplicarConexao(b.ConnectionString)
        Me.DialogResult = DialogResult.OK
    End Sub

End Class
