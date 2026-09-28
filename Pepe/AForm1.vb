Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraEditors

Public Class AForm1
    Private Sub AForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DsInconsist.Inconsist4'. Você pode movê-la ou removê-la conforme necessário.
        Me.Inconsist4TableAdapter.Fill(Me.DsInconsist.Inconsist4)
        'TODO: esta linha de código carrega dados na tabela 'DsInconsist.Inconsist1'. Você pode movê-la ou removê-la conforme necessário.
        'Me.Inconsist1TableAdapter.Fill(Me.DsInconsist.Inconsist1)
        'TODO: esta linha de código carrega dados na tabela 'DsInconsist.Inconsist1'. Você pode movê-la ou removê-la conforme necessário.
        'Me.Inconsist1TableAdapter.Fill(Me.DsInconsist.Inconsist1)

    End Sub

    Private Sub Inconsist1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Me.Validate()
        'Me.Inconsist1BindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.DsInconsist)

    End Sub

    Private Sub Inconsist4BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Inconsist4BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Inconsist4BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsInconsist)

    End Sub

    Private Sub NativeMdiView1_QueryControl(sender As Object, e As QueryControlEventArgs) Handles NativeMdiView1.QueryControl

        e.Control = New XtraUserControl

    End Sub
End Class