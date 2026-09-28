Imports DevExpress.XtraEditors.Controls

Public Class frmVendaCC
    Private Sub frmVendaCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CCTableAdapter.Fill(Me.DsCliente.CC, varIdCliente)

        If IsFormLoaded("frmNewVenda") Then
            NomeForm = "frmNewVenda"
        Else
            NomeForm = "frmConsertosfrm"
        End If

    End Sub

    Private Sub btnAbrirCC_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnAbrirCC.ButtonClick

        If GridView1.GetFocusedRowCellValue("Op") = "Conserto" Then
            varIdCon = GridView1.GetFocusedRowCellValue("Id")
            'varIdCon = CType(DLookUp("IdConserto", "[Conta Corrente]", "[Id] = " & varIdCon, 0), Integer)
            'NomeForm = "frmClientes"
            Dim x As New frmConsertosfrm
            x.Show()
        ElseIf GridView1.GetFocusedRowCellValue("Op") = "Venda" Then
            varIdVenda = GridView1.GetFocusedRowCellValue("Id")
            'varIdVenda = DLookUp("IdConserto", "[Conta Corrente]", "[Id] = " & varIdCon, 0)
            'Dim x As String = DLookUp("Venda", "[Conta Corrente]", "[Id] = " & varIdVenda, 0)
            'varIdVenda = DLookUp("Id", "[VENDAS]", "[Venda] = '" & x & "'", 0)
            'varIdVenda = DLookUp("VENDA", "[Conta Corrente]", "[Id] = " & varIdCon, 0)
            'NomeForm = "frmClientes"
            Dim x As New frmNewVenda
            x.Show()
        Else
            varIdCC = GridView1.GetFocusedRowCellValue("Id")
            frmCC.Show()
        End If

    End Sub
End Class