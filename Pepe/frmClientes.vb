Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

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

            If varIdCliente = 0 Then
                Me.ClientesBindingSource1.AddNew()
                Me.DateEdit1.EditValue = Date.Today
                Me.RibbonPageGroup3.Visible = False
                Me.ribbonPageGroup1.Visible = False
                'Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If

            Me.Tag = "1"

            If Application.OpenForms().OfType(Of frmClientesDG).Any Then
                frmClientesDG.Visible = False
            Else
                frmCCdg.Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmClientes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If Application.OpenForms().OfType(Of frmClientesDG).Any Then
            frmClientesDG.Visible = True
        Else
            frmCCdg.Visible = True
        End If

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub botoes()
        If Me.Tag = "1" Then
            Me.ribbonPageGroup1.Visible = False
            Me.RibbonPageGroup2.Visible = True
            '    'If frmPedidosDG.RadGridView1.Tag <> "1" Then Me.ControlBox = False
            Me.RibbonPageGroup3.Visible = False ': Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.RibbonPageGroup4.Visible = False
            Me.ControlBox = False
        End If

    End Sub

    Private Sub btnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Try
            Me.Validate()
            Me.ClientesBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.DsCliente)

            frmClientesDG.ClientesTableAdapter.Fill(frmClientesDG.DsPrincipal.Clientes)

            'If varIdCliente = 0 Then
            '    varIdCliente = DLookUp("I", "Select Max(IDCliente) As I From Clientes", "", 1)
            '    'Me.ClientesBindingSource.Filter = "IdCliente = " & varIdCliente
            '    'Me.BindingSource1.Filter = "Cliente = " & varIdCliente
            '    Me.ClientesTableAdapter1.Fill(Me.DsCliente.Clientes, varIdCliente)
            '    Me.CCTableAdapter.Fill(Me.DsCliente.CC, varIdCliente)
            'End If

        Catch ex As Exception
            ' MsgBox(ex.Message)

        Finally
            Me.ControlBox = True
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.RibbonPageGroup3.Visible = True ': Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.RibbonPageGroup4.Visible = True
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
                Me.ClientesBindingSource1.AddNew()
                Me.RibbonPageGroup3.Visible = False
                Me.ribbonPageGroup1.Visible = False
            Else
                Me.ribbonPageGroup1.Visible = True
                Me.RibbonPageGroup3.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Me.ControlBox = True
            'Me.ribbonPageGroup1.Visible = False
            Me.RibbonPageGroup2.Visible = False
            'Me.RibbonPageGroup3.Visible = True ': Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.RibbonPageGroup4.Visible = True
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

    Private Sub CPFTextEdit_TextChanged(sender As Object, e As EventArgs) Handles CPFTextEdit.TextChanged
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
        frmCompras.ShowDialog()

    End Sub

    Private Sub btnPeçasCompradas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPeçasCompradas.ItemClick
        frmVendasClienteBase.Show()

    End Sub

    Private Sub btnNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovo.ItemClick
        varIdCliente = 0
        Me.Tag = "0"

        Me.ClientesTableAdapter1.Fill(Me.DsCliente.Clientes, varIdCliente)
        Me.CCTableAdapter.Fill(Me.DsCliente.CC, varIdCliente)

        Me.ClientesBindingSource.AddNew()
        Me.BindingSource1.Filter = "Cliente = 0"
        Me.RibbonPageGroup3.Visible = False
        Me.RibbonPageGroup2.Visible = False
        Me.ribbonPageGroup1.Visible = False
        Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        Me.Tag = "1"

    End Sub

    Private Sub btnAbrirCC_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnAbrirCC.ButtonClick

        If GridView1.GetFocusedRowCellValue("Op") = "Conserto" Then
            varIdCon = GridView1.GetFocusedRowCellValue("Id")
            'varIdCon = CType(DLookUp("IdConserto", "[Conta Corrente]", "[Id] = " & varIdCon, 0), Integer)
            NomeForm = "frmClientes"
            frmConsertosfrm.Show()
        ElseIf GridView1.GetFocusedRowCellValue("Op") = "Venda" Then
            varIdVenda = GridView1.GetFocusedRowCellValue("Id")
            'varIdVenda = DLookUp("IdConserto", "[Conta Corrente]", "[Id] = " & varIdCon, 0)
            'Dim x As String = DLookUp("Venda", "[Conta Corrente]", "[Id] = " & varIdVenda, 0)
            'varIdVenda = DLookUp("Id", "[VENDAS]", "[Venda] = '" & x & "'", 0)
            'varIdVenda = DLookUp("VENDA", "[Conta Corrente]", "[Id] = " & varIdCon, 0)
            NomeForm = "frmClientes"
            frmNewVenda.Show()
        Else
            varIdCC = GridView1.GetFocusedRowCellValue("Id")
            frmCC.Show()
        End If

    End Sub

    Private Sub btnLancaCC_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLancaCC.ItemClick
        fExecutarText("delete from [Vencto Cartão] where idcc = -1; delete from [Vencto Cheques] where idcc = -1")
        varIdCC = 0
        frmCC.Show()

    End Sub

    Private Sub btnDel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDel.ItemClick
        If XtraMessageBox.Show("Confirma exclusão?", "Atenção!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.ClientesBindingSource1.RemoveCurrent()
            Me.Validate()
            Me.ClientesBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.DsCliente)
            frmClientesDG.ClientesTableAdapter.Fill(frmClientesDG.DsPrincipal.Clientes)
            Me.Close()
        End If
    End Sub

    Private Sub btnCEP_Click(sender As Object, e As EventArgs) Handles btnCEP.Click

        If Me.CEPTextEdit.Text = "" Then
            Me.EndereçoTextEdit.Text = ""
            Me.BairroTextEdit.Text = ""
            Me.CidadeTextEdit.Text = ""
            Me.EstadoTextEdit.Text = ""
        Else
            Dim rs As New ADODB.Recordset()
            Dim cnStr As String = strAdoConnection()
            Dim strSQL As String = "Select * From tabcep Where cep = '" & Replace(Me.CEPTextEdit.Text, "-", "") & "'"
            rs.Open(strSQL, cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            If Not rs.EOF Then
                Me.EndereçoTextEdit.Text = rs("logradouro").Value
                Me.BairroTextEdit.Text = rs("bairro").Value
                Me.CidadeTextEdit.Text = rs("cidade").Value
                Me.EstadoTextEdit.Text = rs("uf").Value
                rs.Close()
                Me.EndereçoTextEdit.Focus()
                Me.EndereçoTextEdit.SelectionStart = Me.EndereçoTextEdit.Text.Length
            End If
        End If

    End Sub

    Private Sub DateEdit1_TextChanged(sender As Object, e As EventArgs) Handles DateEdit1.TextChanged

        Call botoes()

    End Sub

End Class
