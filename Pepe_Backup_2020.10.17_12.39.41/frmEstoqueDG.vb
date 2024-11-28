Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors


Partial Public Class frmEstoqueDG
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmClientesDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.EstoqueTableAdapter.Fill(Me.DsEstoque.Estoque)
        EstoqueBindingSource.Filter = "Vendida = 0 Or Vendida Is Null"

        frmDevPrincipal.Visible = False

        ClientesGridControl.EmbeddedNavigator.TextStringFormat = "{0} / {1:##,##0}"

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnAbrir_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnAbrir.ButtonClick
        varIdPeça = GridView1.GetFocusedRowCellValue("IDPeça")
        frmEstoque.Show()

    End Sub

    Private Sub btnNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovo.ItemClick
        varIdPeça = 0
        frmEstoque.Show()

    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If RadioGroup1.EditValue = 1 Then
            EstoqueBindingSource.Filter = "(Vendida = 0 Or Vendida Is Null) And Modêlo IS NOT NULL"
        ElseIf RadioGroup1.EditValue = 2 Then
            EstoqueBindingSource.Filter = "Vendida = 1 And Modêlo IS NOT NULL"
        Else
            EstoqueBindingSource.RemoveFilter()
        End If

    End Sub
End Class
