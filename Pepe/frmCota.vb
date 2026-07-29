Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmCota

    Private cnnCotacao As SqlConnection
    Private daCotacao As SqlDataAdapter
    Private cbCotacao As SqlCommandBuilder
    Private dtCotacao As New DataTable("Cotacao")

    Private Sub CarregarCotacoes()
        If cnnCotacao Is Nothing Then
            cnnCotacao = fGetAdoConnection2()
            If cnnCotacao Is Nothing Then Exit Sub

            Dim sql As String = "SELECT Id, ValDolar, ValOuro, ValPrata, DataCot " &
                                 "FROM dbo.[Cotação] ORDER BY DataCot DESC, Id DESC"
            daCotacao = New SqlDataAdapter(sql, cnnCotacao)
            cbCotacao = New SqlCommandBuilder(daCotacao)
        End If

        dtCotacao.Rows.Clear()
        daCotacao.Fill(dtCotacao)

        If bsCotacao.DataSource Is Nothing Then
            bsCotacao.DataSource = dtCotacao
        End If
    End Sub

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

        'Garante que qualquer edição pendente na grid seja commitada, então recarrega o histórico
        Me.Validate()
        bsCotacao.EndEdit()
        CarregarCotacoes()

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
        CarregarCotacoes()

        If dtCotacao.Rows.Count > 0 Then
            'Linha 0 é a mais recente por causa do ORDER BY DataCot DESC, Id DESC
            Dim rUltima As DataRow = dtCotacao.Rows(0)
            Me.txtDolar.EditValue = rUltima("ValDolar")
            Me.txtOuro.EditValue = If(IsDBNull(rUltima("ValOuro")), CDec(0), rUltima("ValOuro"))
            Me.txtPrata.EditValue = If(IsDBNull(rUltima("ValPrata")), CDec(0), rUltima("ValPrata"))
        End If

    End Sub

    Private Sub gvCotacoes_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvCotacoes.RowUpdated
        If daCotacao Is Nothing Then Exit Sub
        Try
            daCotacao.Update(dtCotacao)
        Catch ex As Exception
            dtCotacao.RejectChanges()
            DevExpress.XtraEditors.XtraMessageBox.Show("Não foi possível salvar a alteração na cotação: " & ex.Message, "Cotação", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCota_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.Validate()
            bsCotacao.EndEdit()
            If daCotacao IsNot Nothing Then daCotacao.Update(dtCotacao)
        Catch
            'já reportado por gvCotacoes_RowUpdated
        Finally
            If cnnCotacao IsNot Nothing Then
                cnnCotacao.Close()
                cnnCotacao.Dispose()
            End If
        End Try
    End Sub
End Class
