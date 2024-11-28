Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors


Partial Public Class frmVendasDG
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmVendasDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.VENDASdgTableAdapter1.Fill(Me.DsVendas.VENDASdg)

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            frmDevPrincipal.Visible = False

        End Try

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'fExecutarText("Update Clientes Set Imp = 0 Where Imp = 1")
        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnAbrir_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnAbrirVenda.ButtonClick
        varIdVenda = GridView1.GetFocusedRowCellValue("Id")
        frmNewVenda.Show()

    End Sub

    Private Sub btnNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovo.ItemClick
        varIdVenda = 0
        frmNewVenda.Show()
        'Me.GridView1.OptionsView.ShowFooter = Not Me.GridView1.OptionsView.ShowFooter

    End Sub

    Private Sub frmClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        On Error Resume Next

        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.Send("{Tab}")
            Case Keys.F3
                Me.GridView1.OptionsView.ShowFooter = Not Me.GridView1.OptionsView.ShowFooter
        End Select

    End Sub

End Class
