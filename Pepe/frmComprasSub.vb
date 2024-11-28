Public Class FrmComprasSub

    Private Sub FrmComprasSub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComprasSubTableAdapter.Fill(Me.DsPrincipal.ComprasSub, varIdCliente)

    End Sub

End Class
