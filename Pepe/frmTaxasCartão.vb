Public Class frmTaxasCartão
    Private Sub CartõesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.CartõesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsGeral)

    End Sub

    Private Sub frmTaxasCartão_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DsGeral.Cartões'. Você pode movê-la ou removê-la conforme necessário.
        Me.CartõesTableAdapter.Fill(Me.DsGeral.Cartões)

    End Sub

    Private Sub frmTaxasCartão_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Validate()
        Me.CartõesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsGeral)

    End Sub
End Class