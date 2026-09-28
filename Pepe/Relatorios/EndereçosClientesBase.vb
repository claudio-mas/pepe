Public Class EndereçosClientesBase
    Private Sub EndereçosClientesBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmClientesDG.Visible = False

        Dim report As New EndereçosClientes

        Me.DocumentViewer1.DocumentSource = report
        report.CreateDocument(False)

    End Sub

    Private Sub EndereçosClientesBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        frmClientesDG.Visible = True

    End Sub
End Class
