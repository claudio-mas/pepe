Imports DevExpress.XtraEditors.Controls

Public Class PeçasRegBase

    Private Sub VendasBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmDevPrincipal.Visible = False
        Me.txtData1.EditValue = New DateTime(Today.Year, Today.Month, 1)
        'Me.txtData2.EditValue = New DateTime(Today.Year, Today.Month + 1, 1).AddDays(-1)
        If Today.Month < 12 Then
            Me.txtData2.EditValue = New DateTime(Today.Year, Today.Month + 1, 1).AddDays(-1)
        Else
            Me.txtData2.EditValue = New DateTime(Today.Year, 12, 31)
        End If

        btnOk2_ButtonClick(Nothing, Nothing)

    End Sub

    Private Sub btnOk2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnOk2.ButtonClick

        Dim report As New PeçasReg

        Try
            report.SqlDataSource1.Queries(0).Parameters(0).Value = Me.txtData1.EditValue 'CInt(Nz(cboAno.Text, System.DateTime.Today.ToString("yyyy")))
            report.SqlDataSource1.Queries(0).Parameters(1).Value = Me.txtData2.EditValue
            report.txtPeriodo.Text = Me.txtData1.Text & " a " & Me.txtData2.Text
            report.SqlDataSource1.Fill()

            Dim subreport As New PeçasRegSub()
            subreport.SqlDataSource2.Queries(0).Parameters(1).Value = Me.txtData2.EditValue
            subreport.SqlDataSource2.Queries(0).Parameters(0).Value = Me.txtData1.EditValue
            subreport.SqlDataSource2.Fill()
            report.XrSubreport.ReportSource = subreport

            Dim subreport2 As New PeçasRegSub2()
            subreport2.SqlDataSource1.Queries(0).Parameters(1).Value = Me.txtData2.EditValue
            subreport2.SqlDataSource1.Queries(0).Parameters(0).Value = Me.txtData1.EditValue
            subreport2.SqlDataSource1.Fill()
            report.XrSubreport1.ReportSource = subreport2

            Dim subreport3 As New PegasRegSubAg
            subreport3.SqlDataSource1.Queries(0).Parameters(1).Value = Me.txtData2.EditValue
            subreport3.SqlDataSource1.Queries(0).Parameters(0).Value = Me.txtData1.EditValue
            subreport3.SqlDataSource1.Fill()
            report.XrSubreport2.ReportSource = subreport3

            report.Margins = New System.Drawing.Printing.Margins(3, 0, 3, 0)

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
