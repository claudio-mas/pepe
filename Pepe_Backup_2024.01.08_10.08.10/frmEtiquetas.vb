Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors


Partial Public Class frmEtiquetas
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEtiquetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Visible = False

        frmClientesDG.Visible = False

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmClientesDG.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

End Class
