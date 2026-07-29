Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmCota

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        'Atualiza a cotação do Dolar e do Ouro
        valDolar = Me.txtDolar.EditValue
        valOuro = Me.txtOuro.EditValue

        'Atualizar a cotação do Dolar e do Ouro no banco de dados
        Dim cnn As SqlConnection = fGetAdoConnection2()
        Dim cmd As SqlCommand
        Dim sql As String = "UPDATE Cotação SET ValDolar = " & Replace(valDolar, ",", ".") & ", ValOuro = " & Replace(valOuro, ",", ".") & ", DataCot = '" & Format(Now, "yyyy-MM-dd") & "'"
        sql = "INSERT INTO Cotação (ValDolar, ValOuro, DataCot) VALUES (" & Replace(valDolar, ",", ".") & ", " & Replace(valOuro, ",", ".") & ", '" & Format(Now, "yyyy-MM-dd") & "')"

        cmd = New SqlCommand(sql, cnn)
        cmd.ExecuteNonQuery()

        'Dim cnn As New SqlClient.SqlConnection()
        'cnn = fGetAdoConnection()
        'Dim cmd As New SqlClient.SqlCommand(sql, cnn)
        'cmd.ExecuteNonQuery()

        Me.txtDolar.Text = ""
        Me.txtOuro.Text = ""
        Me.txtDolar.Focus()
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.txtDolar.Text = ""
        Me.txtOuro.Text = ""
        Me.txtDolar.Focus()
        Me.Close()
    End Sub

    Private Sub frmCota_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.txtDolar.EditValue = valDolar
        Me.txtOuro.EditValue = valOuro

    End Sub
End Class
