Imports System.Management
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI

Public Class frmAcesso

    ' TODO: Inserir código para realizar autenticação personalizada utilizando o nome de usuário e senha fornecidos 
    ' (Veja http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de segurança personalizada pode ser anexada à entidade de segurança da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal é a implementação de IPrincipal usada para realizar a autenticação. 
    ' Subsequentemente, My.User irá retornar informações de identificação encapsuladas num objeto CustomPrincipal
    ' como nome de usuário, nome para exibição etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Me.PasswordTextBox.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Informe a senha", "Atenção!")
        Else
            If UCase(Me.PasswordTextBox.Text) <> "GOLFE" And UCase(Me.PasswordTextBox.Text) <> "CANON" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Senha incorreta!", "Atenção!")
                Me.PasswordTextBox.Text = ""
                Me.PasswordTextBox.Focus()
            Else
                Dim rs As New ADODB.Recordset()

                '     'Dim serv As String = "den1.mssql7.gear.host"
                '     'Dim db As String = "acesso"
                '     'Dim us As String = "acesso"
                '     'Dim pw As String = "Id5n~z-oT2cX"
                '     Dim serv As String = "sql.bsite.net\MSSQL2016"
                '     Dim db As String = "cmas_controle"
                '     Dim us As String = "cmas_controle"
                '     Dim pw As String = "oowa2015"
                Dim cnStr As String = ""
                '     Dim mboard As New ManagementObjectSearcher("select * from Win32_BaseBoard")
                '     Dim MB_serial As String = ""

                '     For Each mb In mboard.Get
                '         MB_serial = mb("SerialNumber")
                '     Next

                'desabilitar abaixo:
                '         Dim cnStr As String = "Provider=MSOLEDBSQL;Data Source=" & serv & ";Initial Catalog=" & db _
                '& ";User ID=" & us & ";Password=" & pw & ";"
                '     If MB_serial = "BSN12345678901234567" Then  'eu
                '         cnStr = "Provider=MSOLEDBSQL;Data Source=" & serv & ";Initial Catalog=" & db _
                '& ";User ID=" & us & ";Password=" & pw & ";"
                '     Else
                'cnStr = strAdoConnection()
                ''     End If

                'Dim strSQL As String = "Select ok from tab_controle Where cliente = 'paco'"

                'Try
                '    rs.Open(strSQL, cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

                '    If rs("ok").Value = "n" Then
                '        rs.Close()
                '        Application.Exit()
                '    Else
                '        rs.Close()
                '        Me.Visible = False
                '        frmDevPrincipal.Show()
                '    End If


                'Catch ex As Exception
                '    Application.Exit()

                'End Try
                'desabilitar acima

                frmDevPrincipal.Show()
            End If

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        Application.Exit()

    End Sub

    Private Sub frmAcesso_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.PasswordTextBox.Text = ""

    End Sub

End Class
