Public Class CCNovoBase

    Private Sub EndereçosClientesBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmDevPrincipal.Visible = False

        Dim report As New CCNovo

        Me.DocumentViewer1.DocumentSource = report
        report.CreateDocument(False)

    End Sub

    Private Sub EndereçosClientesBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        frmDevPrincipal.Visible = True

    End Sub

End Class
