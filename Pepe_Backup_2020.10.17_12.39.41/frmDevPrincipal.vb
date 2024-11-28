
Imports System.ComponentModel
Imports System.Text

Partial Public Class frmDevPrincipal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

        DevExpress.LookAndFeel.UserLookAndFeel.Default.UseDefaultLookAndFeel = True
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Dark Side"

    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Application.Exit()

    End Sub

    Private Sub btnRpt4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRpt4.ItemClick
        'frmExcel.Show()

    End Sub

    Private Sub btnClientes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClientes.ItemClick
        frmClientesDG.Show()

    End Sub

    Private Sub btnCheques_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCheques.ItemClick
        Try
            fExecutarSP("USP_Cheques")
            frmChequesDG.Show()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub btnCartao_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCartao.ItemClick
        Try
            fExecutarSP("USP_Cartões")
            frmCartoesDG.Show()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnVendas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVendas.ItemClick
        frmVendasDG.Show()

    End Sub

    Private Sub frmDevPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmAcesso.Visible = False

    End Sub

    Private Sub btnEstoque_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstoque.ItemClick
        frmEstoqueDG.Show()

    End Sub
End Class
