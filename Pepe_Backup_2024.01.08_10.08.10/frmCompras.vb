Public Class frmCompras
    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        'Try
        '    Me.ComprasTableAdapter.Fill(Me.DsCliente.Compras, New System.Nullable(Of Integer)(CType(IdClienteToolStripTextBox.Text, Integer)))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.ComprasTableAdapter.Fill(Me.DsCliente.Compras, varIdCliente)

    End Sub
End Class