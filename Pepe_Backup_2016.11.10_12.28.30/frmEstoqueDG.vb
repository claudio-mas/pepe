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
        'TODO: esta linha de código carrega dados na tabela 'DsEstoque.Estoque'. Você pode movê-la ou removê-la conforme necessário.
        Me.EstoqueTableAdapter.Fill(Me.DsEstoque.Estoque)
        'TODO: esta linha de código carrega dados na tabela 'DsPrincipal.Clientes'. Você pode movê-la ou removê-la conforme necessário.
        'Me.ClientesTableAdapter.Fill(Me.DsPrincipal.Clientes)
        'TODO: esta linha de código carrega dados na tabela 'DsCadastros.ClienteNEW'. Você pode movê-la ou removê-la conforme necessário.
        'Me.ClienteNEWTableAdapter.Fill(Me.DsCadastros.ClienteNEW)

        frmDevPrincipal.Visible = False

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnAbrir_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnAbrir.ButtonClick
        'varIdCliente = GridView1.GetFocusedRowCellValue("IDCliente")
        'frmClientes.Show()

    End Sub

    Private Sub btnNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovo.ItemClick
        'varIdCliente = 0
        'frmClientes.Show()

    End Sub

End Class
