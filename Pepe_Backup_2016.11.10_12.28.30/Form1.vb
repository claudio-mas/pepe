Public Class Form1

    Private Sub VENDASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VENDASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VENDASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPrincipal)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.VENDASTableAdapter.Fill(Me.DsPrincipal.VENDAS, CType(IdVToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton1_Click(sender As Object, e As EventArgs) Handles FillToolStripButton1.Click
        Try
            Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, New System.Nullable(Of Integer)(CType(IdVToolStripTextBox1.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class