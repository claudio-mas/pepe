Imports DevExpress.XtraEditors.Controls

Public Class PeçasEmEstoqueNovoBase

    Private Sub EndereçosClientesBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmDevPrincipal.Visible = False

        Me.txtData2.EditValue = Date.Today

        Dim report As New PeçasEmEstoqueNovo

        report.SqlDataSource1.Queries(0).Parameters(0).Value = Me.txtData2.EditValue
        report.SqlDataSource1.Fill()
        Me.DocumentViewer1.DocumentSource = report
        report.CreateDocument(False)

    End Sub

    Private Sub EndereçosClientesBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnOk2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnOk2.ButtonClick

        Dim report As New PeçasEmEstoqueNovo

        report.SqlDataSource1.Queries(0).Parameters(0).Value = Me.txtData2.EditValue
        report.SqlDataSource1.Fill()
        Me.DocumentViewer1.DocumentSource = report
        report.CreateDocument(False)

    End Sub
End Class
