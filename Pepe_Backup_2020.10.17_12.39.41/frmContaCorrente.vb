Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors


Partial Public Class frmContaCorrente
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmClientesDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Me.Conta_CorrenteTableAdapter.Fill(Me.DsCC.Conta_Corrente, varIdCliente)
            Me.Vencto_ChequesTableAdapter.Fill(Me.DsCC.Vencto_Cheques)


            'If varIdCliente <> 0 Then
            '    'Me.ClientesBindingSource.Filter = "IdCliente = " & varIdCliente
            '    'Me.BindingSource1.Filter = "Cliente = " & varIdCliente
            'Else
            '    Me.Conta_CorrenteBindingSource.AddNew()
            '    Me.RibbonPageGroup3.Visible = False
            '    Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'End If

            Me.Tag = "1"

            frmClientes.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmClientes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmClientes.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub botoes()
        If Me.Tag = "1" Then
            Me.ribbonPageGroup1.Visible = False
            Me.RibbonPageGroup2.Visible = True
            Me.RibbonPageGroup3.Visible = False : Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.ControlBox = False
        End If

    End Sub

    Private Sub btnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Try
            Me.Validate()
            'Me.ClientesBindingSource1.EndEdit()
            'Me.TableAdapterManager1.UpdateAll(Me.DsCliente)
            frmClientesDG.ClientesTableAdapter.Fill(frmClientesDG.DsPrincipal.Clientes)
            If varIdCliente = 0 Then
                varIdCliente = DLookUp("I", "Select Max(IDCliente) As I From Clientes", "", 1)
                'Me.ClientesTableAdapter1.Fill(Me.DsCliente.Clientes, varIdCliente)
                'Me.CCTableAdapter.Fill(Me.DsCliente.CC, varIdCliente)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Me.ControlBox = True
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.RibbonPageGroup3.Visible = True : Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End Try

    End Sub

    Private Sub btnUndo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick
        Try
            'Me.ClientesTableAdapter1.Fill(Me.DsCliente.Clientes, varIdCliente)
            'Me.CCTableAdapter.Fill(Me.DsCliente.CC, varIdCliente)
            'If varIdCliente = 0 Then
            '    Me.ClientesBindingSource.AddNew()
            '    Me.RibbonPageGroup3.Visible = False
            '    Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Me.ControlBox = True
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.RibbonPageGroup3.Visible = True : Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End Try

    End Sub

    Private Sub AnivDateEdit_TextChanged(sender As Object, e As EventArgs)

        Call botoes()

    End Sub

    Private Sub frmClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        On Error Resume Next

        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.Send("{Tab}")
        End Select

    End Sub

    Private Sub btnNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        varIdCliente = 0
        '        Me.ClientesBindingSource.AddNew()
        '        Me.BindingSource1.Filter = "Cliente = 0"
        '        Me.RibbonPageGroup3.Visible = False
        Me.RibbonPageGroup2.Visible = False
        Me.ribbonPageGroup1.Visible = True
        '       Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

    End Sub

    Private Sub Conta_CorrenteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Conta_CorrenteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Conta_CorrenteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsCC)

    End Sub
End Class
