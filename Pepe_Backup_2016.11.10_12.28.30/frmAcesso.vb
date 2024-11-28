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
                frmDevPrincipal.Show()
            End If
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()

    End Sub

End Class
