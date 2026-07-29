Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmCota

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        'Atualiza a cotação do Dolar, do Ouro e da Prata
        valDolar = Me.txtDolar.EditValue
        valOuro = Me.txtOuro.EditValue
        valPrata = ConvertToDouble(Me.txtPrata.EditValue)

        'Atualizar a cotação no banco de dados
        'ATENÇÃO: exige a coluna ValPrata, criada por Scripts\RG2_v1_up.sql.
        'Sem ela este INSERT falha.
        Dim cnn As SqlConnection = fGetAdoConnection2()
        Dim cmd As SqlCommand
        Dim sql As String = "INSERT INTO Cotação (ValDolar, ValOuro, ValPrata, DataCot) VALUES (" &
                            Replace(valDolar, ",", ".") & ", " &
                            Replace(valOuro, ",", ".") & ", " &
                            Replace(valPrata, ",", ".") & ", '" &
                            Format(Now, "yyyy-MM-dd") & "')"

        cmd = New SqlCommand(sql, cnn)
        cmd.ExecuteNonQuery()

        'Dim cnn As New SqlClient.SqlConnection()
        'cnn = fGetAdoConnection()
        'Dim cmd As New SqlClient.SqlCommand(sql, cnn)
        'cmd.ExecuteNonQuery()

        Me.txtDolar.Text = ""
        Me.txtOuro.Text = ""
        Me.txtPrata.Text = ""
        Me.txtDolar.Focus()
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.txtDolar.Text = ""
        Me.txtOuro.Text = ""
        Me.txtPrata.Text = ""
        Me.txtDolar.Focus()
        Me.Close()
    End Sub

    Private Sub frmCota_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.txtDolar.EditValue = valDolar
        Me.txtOuro.EditValue = valOuro
        Me.txtPrata.EditValue = valPrata

    End Sub
End Class
