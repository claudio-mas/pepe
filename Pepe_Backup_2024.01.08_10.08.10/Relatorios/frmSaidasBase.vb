Imports DevExpress.XtraEditors.Controls

Public Class frmSaidasBase
    Private Sub btnOk2_ButtonClick(sender As Object, e As EventArgs) Handles btnOk2.ButtonClick

        Dim report As New rptSaidas

        Try
            report.SqlDataSource1.Queries(0).Parameters(0).Value = Me.txtData1.EditValue
            report.SqlDataSource1.Queries(0).Parameters(1).Value = Me.txtData2.EditValue
            report.periodo.Text = Me.txtData1.Text & " a " & Me.txtData2.Text
            report.SqlDataSource1.Fill()

            'report.Margins = New System.Drawing.Printing.Margins(3, 0, 3, 0)

            Me.DocumentViewer1.DocumentSource = report
            Me.DocumentViewer1.Visible = True

            report.CreateDocument(False)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmSaidasBase_Load(sender As Object, e As EventArgs) Handles Me.Load

        frmDevPrincipal.Visible = False

        Me.txtData1.EditValue = New DateTime(Today.Year, Today.Month, 1)

        If Today.Month < 12 Then
            Me.txtData2.EditValue = New DateTime(Today.Year, Today.Month + 1, 1).AddDays(-1)
        Else
            Me.txtData2.EditValue = New DateTime(Today.Year, 12, 31)
        End If

        btnOk2_ButtonClick(Nothing, Nothing)

    End Sub

    Private Sub VendasBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmDevPrincipal.Visible = True

    End Sub

End Class
