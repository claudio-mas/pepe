Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors


Partial Public Class frmClientes
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
            'Me.ClientesTableAdapter.Fill(Me.DsPrincipal.Clientes)
            'CcTableAdapter1.Fill(DsPrincipal1.CC)

            Me.ClientesTableAdapter1.Fill(Me.DsCliente.Clientes, varIdCliente)
            Me.CCTableAdapter.Fill(Me.DsCliente.CC, varIdCliente)

            If varIdCliente <> 0 Then
                'Me.ClientesBindingSource.Filter = "IdCliente = " & varIdCliente
                'Me.BindingSource1.Filter = "Cliente = " & varIdCliente
            Else
                Me.ClientesBindingSource.AddNew()
                'Me.BindingSource1.Filter = "Cliente = 0"
                Me.RibbonPageGroup3.Visible = False
                Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If

            Me.Tag = "1"

            frmClientesDG.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmClientes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmClientesDG.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub botoes()
        If Me.Tag = "1" Then
            Me.ribbonPageGroup1.Visible = False
            Me.RibbonPageGroup2.Visible = True
            '    'If frmPedidosDG.RadGridView1.Tag <> "1" Then Me.ControlBox = False
            Me.RibbonPageGroup3.Visible = False : Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.ControlBox = False
        End If

    End Sub

    Private Sub btnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Try
            Me.Validate()
            Me.ClientesBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.DsCliente)
            frmClientesDG.ClientesTableAdapter.Fill(frmClientesDG.DsPrincipal.Clientes)
            If varIdCliente = 0 Then
                varIdCliente = DLookUp("I", "Select Max(IDCliente) As I From Clientes", "", 1)
                'Me.ClientesBindingSource.Filter = "IdCliente = " & varIdCliente
                'Me.BindingSource1.Filter = "Cliente = " & varIdCliente
                Me.ClientesTableAdapter1.Fill(Me.DsCliente.Clientes, varIdCliente)
                Me.CCTableAdapter.Fill(Me.DsCliente.CC, varIdCliente)
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
            'Me.ClientesTableAdapter.Fill(Me.DsPrincipal.Clientes)
            'CcTableAdapter1.Fill(DsPrincipal1.CC)
            'If varIdCliente <> 0 Then Me.ClientesBindingSource.Filter = "IdCliente = " & varIdCliente : Me.BindingSource1.Filter = "Cliente = " & varIdCliente Else Me.ClientesBindingSource.AddNew() : Me.BindingSource1.Filter = "Cliente = 0"
            Me.ClientesTableAdapter1.Fill(Me.DsCliente.Clientes, varIdCliente)
            Me.CCTableAdapter.Fill(Me.DsCliente.CC, varIdCliente)
            If varIdCliente = 0 Then
                Me.ClientesBindingSource.AddNew()
                Me.RibbonPageGroup3.Visible = False
                Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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

    Private Sub ClienteTextEdit_TextChanged(sender As Object, e As EventArgs) Handles ClienteTextEdit.TextChanged

        Call botoes()

    End Sub

    Private Sub TítuloComboBoxEdit_TextChanged(sender As Object, e As EventArgs) Handles TítuloComboBoxEdit.TextChanged

        Call botoes()

    End Sub

    Private Sub EndereçoTextEdit_TextChanged(sender As Object, e As EventArgs) Handles EndereçoTextEdit.TextChanged

        Call botoes()

    End Sub

    Private Sub BairroTextEdit_TextChanged(sender As Object, e As EventArgs) Handles BairroTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub CidadeTextEdit_TextChanged(sender As Object, e As EventArgs) Handles CidadeTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub EstadoTextEdit_TextChanged(sender As Object, e As EventArgs) Handles EstadoTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub CEPTextEdit_TextChanged(sender As Object, e As EventArgs) Handles CEPTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub TelefoneTextEdit_TextChanged(sender As Object, e As EventArgs) Handles TelefoneTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub FaxTextEdit_TextChanged(sender As Object, e As EventArgs) Handles FaxTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub EmailTextEdit_TextChanged(sender As Object, e As EventArgs) Handles EmailTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub ClienteTextEdit1_TextChanged(sender As Object, e As EventArgs) Handles ClienteTextEdit1.TextChanged
        Call botoes()

    End Sub

    Private Sub AnivDateEdit_TextChanged(sender As Object, e As EventArgs) Handles AnivDateEdit.TextChanged

        Call botoes()

    End Sub

    Private Sub MedidasTextEdit_TextChanged(sender As Object, e As EventArgs) Handles MedidasTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub IndicaçaoTextEdit_TextChanged(sender As Object, e As EventArgs) Handles IndicaçaoTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub frmClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        On Error Resume Next

        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.Send("{Tab}")
        End Select

    End Sub

    Private Sub btnCompras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCompras.ItemClick
        FrmComprasSub.ShowDialog()

    End Sub

    Private Sub btnPeçasCompradas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPeçasCompradas.ItemClick
        frmRptPecasCompradas.Show()

    End Sub

    Private Sub btnNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovo.ItemClick
        varIdCliente = 0
        Me.ClientesBindingSource.AddNew()
        Me.BindingSource1.Filter = "Cliente = 0"
        Me.RibbonPageGroup3.Visible = False
        Me.RibbonPageGroup2.Visible = False
        Me.ribbonPageGroup1.Visible = True
        Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

    End Sub

End Class
