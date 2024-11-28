Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class ClientesCadastrados

    Private Sub CartãoBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmDevPrincipal.Visible = False

        Me.txtData1.EditValue = New DateTime(Today.Year, Today.Month, 1)
        If Today.Month < 12 Then
            Me.txtData2.EditValue = New DateTime(Today.Year, Today.Month + 1, 1).AddDays(-1)
        Else
            Me.txtData2.EditValue = New DateTime(Today.Year, 12, 31)
        End If

        Call btnOk2_ButtonClick(Nothing, Nothing)

    End Sub

    Private Sub CartãoBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnOk2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnOk2.ButtonClick

        Dim report As New ClientesCadastradosRpt

        Try
            If Me.chk1.Checked Then
                report.DataMember = "Query_1"
                report.Período.Text = ""
            Else
                report.SqlDataSource1.Queries(0).Parameters(0).Value = Me.txtData1.EditValue
                report.SqlDataSource1.Queries(0).Parameters(1).Value = Me.txtData2.EditValue
                report.SqlDataSource1.Fill()
                report.Período.Text = txtData1.Text & " a " & txtData2.Text
            End If

            Me.DocumentViewer1.DocumentSource = report
            Me.DocumentViewer1.Visible = True

            report.CreateDocument(False)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        Me.ClientesCadastradosTableAdapter.Fill(Me.DsCliente1.ClientesCadastrados)

        Dim path As String
        Try
            'If XtraFolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    path = XtraFolderBrowserDialog.SelectedPath
            path = My.Computer.FileSystem.SpecialDirectories.Desktop
            GridControl.ExportToXlsx(path & "\Clientes_Cadastrados.xlsx")
            '    Process.Start(path & "\Previsão de Produção.xlsx")
            'End If
            XtraMessageBox.Show("Planilha de clientes cadastrados gerada com sucesso na áera de trabalho", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub chk1_CheckedChanged(sender As Object, e As EventArgs) Handles chk1.CheckedChanged
        Me.btnExcel.Enabled = (Me.chk1.Checked)

    End Sub
End Class
