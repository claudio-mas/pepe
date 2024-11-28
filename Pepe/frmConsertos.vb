Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Partial Public Class frmConsertos
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.VendedorasTableAdapter.Fill(Me.DsGeral.Vendedoras)
            Me.CboClientesTableAdapter.Fill(Me.DsGeral.cboClientes)

            Me.CONSERTOSTableAdapter.Fill(Me.DsGeral.CONSERTOS)

            Me.Tag = "1"

            frmDevPrincipal.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmClientes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub botoes()
        If Me.Tag = "1" Then
            Me.ribbonPageGroup1.Visible = False
            Me.RibbonPageGroup2.Visible = True
            '    'If frmPedidosDG.RadGridView1.Tag <> "1" Then Me.ControlBox = False
            'Me.RibbonPageGroup3.Visible = False : Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.ControlBox = False
        End If

    End Sub

    Private Sub btnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick


    End Sub

    Private Sub btnUndo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick


    End Sub

    Private Sub frmClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        On Error Resume Next

        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.Send("{Tab}")
        End Select

    End Sub

    Private Sub btnNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        varIdCon = 0

        'Me.ClientesTableAdapter1.Fill(Me.DsCliente.Clientes, varIdCliente)
        'Me.CCTableAdapter.Fill(Me.DsCliente.CC, varIdCliente)

        'Me.ClientesBindingSource.AddNew()
        'Me.BindingSource1.Filter = "Cliente = 0"
        ' Me.RibbonPageGroup3.Visible = False
        Me.RibbonPageGroup2.Visible = False
        Me.ribbonPageGroup1.Visible = True
        'Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

    End Sub

    Private Sub CONSERTOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CONSERTOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsGeral)

    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        varIdCon = GridView1.GetFocusedRowCellValue("ID")
        frmConsertosfrm.Show()

    End Sub

    Private Sub btnNovo_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovo.ItemClick
        varIdCon = 0
        frmConsertosfrm.Show()

    End Sub
End Class
