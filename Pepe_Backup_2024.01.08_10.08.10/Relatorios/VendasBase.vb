Imports DevExpress.XtraEditors.Controls

Public Class VendasBase

    Private Sub VendasBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmDevPrincipal.Visible = False
        Me.txtData1.EditValue = New DateTime(Today.Year, Today.Month, 1)
        'Me.txtData2.EditValue = New DateTime(Today.Year, Today.Month + 1, 1).AddDays(-1)
        If Today.Month < 12 Then
            Me.txtData2.EditValue = New DateTime(Today.Year, Today.Month + 1, 1).AddDays(-1)
        Else
            Me.txtData2.EditValue = New DateTime(Today.Year, 12, 31)
        End If

        'Me.btnOk2.PerformClick()
        btnOk2_ButtonClick(Nothing, Nothing)

    End Sub

    Private Sub btnOk2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnOk2.ButtonClick

        Dim report As New Vendas

        Dim dt1 As Date = Me.txtData1.EditValue
        Dim dt2 As Date = Me.txtData2.EditValue

        report.txtPeriodo.Tag = "0"

        Try
            Dim dc As New lqGerencialDataContext

            Dim ent As Double = 0
            Dim query9 = From tb In dc.GetTable(Of VI_CONSERTOS)() Where tb.DT >= dt1 And tb.DT <= dt2 Select tb
            If query9.Count > 0 Then
                ent = ConvertToDouble((From c In query9 Select c.Comis).Sum)
                report.D.Text = FormatNumber(ent, 2)
                report.txtPeriodo.Tag = report.D.Text
            End If

            report.SqlDataSource1.Queries(0).Parameters(0).Value = Me.txtData1.EditValue 'CInt(Nz(cboAno.Text, System.DateTime.Today.ToString("yyyy")))
            report.SqlDataSource1.Queries(0).Parameters(1).Value = Me.txtData2.EditValue
            report.txtPeriodo.Text = Me.txtData1.Text + " a " + Me.txtData2.Text
            report.SqlDataSource1.Fill()
            Me.DocumentViewer1.DocumentSource = report
            Me.DocumentViewer1.Visible = True

            report.CreateDocument(False)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub VendasBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmDevPrincipal.Visible = True

    End Sub
End Class
