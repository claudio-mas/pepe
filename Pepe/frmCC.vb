Imports System.ComponentModel
Imports System.Text
Imports DevExpress.CodeParser
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Partial Public Class frmCC
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IsFormLoaded("frmVendaCC") Then Me.TopMost = True Else Me.btnAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing

        Try

            Me.CartõesTableAdapter.Fill(Me.DsCC.Cartões)
            Me.Conta_CorrenteTableAdapter.Fill(Me.DsCC.Conta_Corrente, varIdCC)

            If varIdCC = 0 Then
                Me.Conta_CorrenteBindingSource.AddNew()
                Me.DataDateEdit.EditValue = Date.Today.AddDays(-1)
                Me.ClienteTextEdit.Text = frmClientes.IDClienteTextEdit.Text
                Me.ChequeCCCheckEdit.Checked = True
                Me.txtCCCartao.Checked = True
                Me.txtDolarCC.Checked = True
                Me.txtCashCC.Checked = True
                Me.txtOuroCC.Checked = True
                Me.ribDel.Visible = False
                'Else
                '    Me.Conta_CorrenteBindingSource.Filter = "Id=" & varIdCC
            End If

            If IsFormLoaded("frmNewVenda") Then
                Me.lblCliente.Text = frmNewVenda.txtCliente.Text
            ElseIf IsFormLoaded("frmConsertosfrm") Then
                Me.lblCliente.Text = frmConsertosfrm.cboCliente.Text
            Else
                Me.lblCliente.Text = frmClientes.ClienteTextEdit1.Text
                If Me.lblCliente.Text = "" Then Me.lblCliente.Text = frmClientes.ClienteTextEdit.Text
            End If

            Me.Vencto_ChequesTableAdapter.Fill(Me.DsCC.Vencto_Cheques)
            Me.Vencto_CartãoTableAdapter.Fill(Me.DsCC.Vencto_Cartão)

            'Me.ClienteTextEdit.Text = frmClientes.IDClienteTextEdit.Text
            Me.Tag = "1"

            frmClientes.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmClientes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Validate()
        Me.Conta_CorrenteBindingSource.EndEdit()
        Me.Vencto_CartãoBindingSource.EndEdit()
        Me.Vencto_ChequesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsCC)

        If ConvertToDouble(Me.txtAUT.Text) > 0 Then
            fExecutarText("update [Vencto Cartão] set AUT = '" & Me.txtAUT.Text & "' Where IdCC = " & Me.IDTextEdit.EditValue)
        End If


        If Not IsFormLoaded("frmVendaCC") Then
            frmClientes.Visible = True
        Else
            frmVendaCC.CCTableAdapter.Fill(frmVendaCC.DsCliente.CC, varIdCliente)
        End If

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        If IsFormLoaded("frmVendaCC") Then frmVendaCC.CCTableAdapter.Fill(frmVendaCC.DsCliente.CC, varIdCliente)

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
        Try
            Me.Validate()
            Me.Conta_CorrenteBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsCC)
            Me.ribDel.Visible = True
            'frmClientesDG.ClientesTableAdapter.Fill(frmClientesDG.DsPrincipal.Clientes)

            If ConvertToDouble(Me.txtAUT.Text) > 0 Then
                fExecutarText("update [Vencto Cartão] set AUT = '" & Me.txtAUT.Text & "' Where IdCC = " & Me.IDTextEdit.EditValue)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Me.ControlBox = True
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            'Me.RibbonPageGroup3.Visible = True : Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End Try

    End Sub

    Private Sub btnUndo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick
        Try
            'Me.Conta_CorrenteTableAdapter.Fill(Me.DsCC.Conta_Corrente, varIdCC)
            'If varIdCC = 0 Then
            '    Me.Conta_CorrenteBindingSource.AddNew()
            '    Me.DataDateEdit.EditValue = Date.Today
            '    Me.ClienteTextEdit.Text = frmClientes.IDClienteTextEdit.Text
            'End If
            'Me.Vencto_ChequesTableAdapter.Fill(Me.DsCC.Vencto_Cheques)
            'Me.ChequeCCCheckEdit.Checked = True

            '---
            Me.Tag = "0"

            Me.CartõesTableAdapter.Fill(Me.DsCC.Cartões)
            Me.Conta_CorrenteTableAdapter.Fill(Me.DsCC.Conta_Corrente, varIdCC)

            If varIdCC = 0 Then
                Me.Conta_CorrenteBindingSource.AddNew()
                Me.DataDateEdit.EditValue = Date.Today
                Me.ClienteTextEdit.Text = frmClientes.IDClienteTextEdit.Text
                Me.ribDel.Visible = False
            Else
                Me.ribDel.Visible = True
            End If

            Me.Vencto_ChequesTableAdapter.Fill(Me.DsCC.Vencto_Cheques)
            Me.Vencto_CartãoTableAdapter.Fill(Me.DsCC.Vencto_Cartão)
            Me.ChequeCCCheckEdit.Checked = True
            Me.txtCCCartao.Checked = True
            Me.txtDolarCC.Checked = True
            Me.txtCashCC.Checked = True
            Me.txtOuroCC.Checked = True

            Me.Tag = "1"
            '---

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Me.ControlBox = True
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            'Me.RibbonPageGroup3.Visible = True : Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End Try

    End Sub

    Private Sub frmClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        On Error Resume Next

        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.Send("{Tab}")
        End Select

    End Sub
    Private Sub ChequeSpinEdit_TextChanged(sender As Object, e As EventArgs) Handles ChequeSpinEdit.TextChanged
        'Call botoes()
        'Call parcelamento()

    End Sub

    Private Sub parcelamento()
        'Dim rs As New ADODB.Recordset()
        'Dim cnStr As String = strAdoConnection()
        'rs.Open("SELECT * From [Vencto Cheques]", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        If Me.Tag <> "1" Then Exit Sub
        If IsDBNull(Me.ChequeSpinEdit.EditValue) Or Me.FormaChequeComboBoxEdit.Text = "" Then Exit Sub

        'If FormaChequeComboBoxEdit.Text = "À vista" Or FormaChequeComboBoxEdit.Text = "A vista" Then
        '    fExecutarText("Delete From [Vencto Cheques] Where IdCC = " & Me.IDTextEdit.Text)
        '    Me.Vencto_ChequesTableAdapter.Fill(Me.DsCC.Vencto_Cheques)
        '    Exit Sub
        'End If

        'Me.Validate()
        'Me.Conta_CorrenteBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(DsCC)
        'varIdCC = Me.IDTextEdit.Text

        Me.Validate()
        Me.Conta_CorrenteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsCC)

        fExecutarText("Delete From [Vencto Cheques] Where IdCC = " & Me.IDTextEdit.Text)

        Dim dia As Integer
        Dim mes As Integer
        Dim ano As Integer
        Dim data As String
        Dim i As Integer, j As Integer
        Dim dia1 As Integer
        Dim parcela As Double

        If IsDBNull(Me.DataDateEdit.EditValue) Then Me.DataDateEdit.EditValue = Date.Today

        mes = Format(Me.DataDateEdit.EditValue, "MM")
        ano = Format(Me.DataDateEdit.EditValue, "yy")

        If FormaChequeComboBoxEdit.Text = "À vista" Then
            j = 1
        Else
            j = Val(FormaChequeComboBoxEdit.Text)
        End If

        For i = 1 To j
            mes = mes + 1
            If mes > 12 Then
                mes = 1
                ano = ano + 1
            End If
            dia1 = Format(Me.DataDateEdit.EditValue, "dd")
            dia = Verifica_dia(dia1, mes)
            data = dia & "/" & Format(mes, "00") & "/" & Format(ano, "00")
            Do While Not IsDate(data)
                dia -= 1
                data = (dia - 1) & "/" & Format(mes, "00") & "/" & Format(ano, "00")
            Loop
            dia = Verifica_dia(dia1, mes)

            parcela = CDbl(ChequeSpinEdit.Text) / j

            'Dim x As String = BancoTextEdit.Text
            fExecutarText("INSERT INTO [dbo].[Vencto Cheques] ([Parcela], [Vencto], [VValor], [IdCC], [Banco]) VALUES ('" & CStr(i) & "/" & j & "', '" & data & "', " & Replace(parcela, ",", ".") & ", " & Me.IDTextEdit.Text & ", '" & BancoTextEdit.Text & "');")

            'mes = mes + 1

        Next i

        'Me.Conta_CorrenteTableAdapter.Fill(Me.DsCC.Conta_Corrente, varIdCC)
        'Me.Conta_CorrenteBindingSource.Filter = "Id=" & varIdCC

        Me.Vencto_ChequesTableAdapter.Fill(Me.DsCC.Vencto_Cheques)
        Me.ribDel.Visible = True
        'rs.Close()

    End Sub

    Private Sub ChequeSpinEdit_Validated(sender As Object, e As EventArgs) Handles ChequeSpinEdit.Validated
        Call parcelamento()

    End Sub

    Private Sub FormaChequeComboBoxEdit_Validated(sender As Object, e As EventArgs) Handles FormaChequeComboBoxEdit.Validated
        Call parcelamento()

    End Sub

    Private Sub parcela_cartao()

        If Me.Tag <> "1" Then Exit Sub
        If IsDBNull(Me.txtValorCartao.EditValue) Or Me.txtFormaCartao.Text = "" Or Me.txtNomeCartao.Text = "" Then Exit Sub

        'If txtFormaCartao.Text = "À vista" Then
        '    fExecutarText("Delete From [Vencto Cartão] Where IdCC = " & Me.IDTextEdit.Text)
        '    Me.Vencto_CartãoTableAdapter.Fill(Me.DsCC.Vencto_Cartão)
        '    Exit Sub
        'End If

        'Me.Validate()
        'Me.Conta_CorrenteBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(DsCC)
        'varIdCC = Me.IDTextEdit.Text

        Me.Validate()
        Me.Conta_CorrenteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsCC)

        fExecutarText("Delete From [Vencto Cartão] Where IdCC = " & Me.IDTextEdit.Text)

        Dim dia As Integer
        Dim mes As Integer
        Dim ano As Integer
        Dim data As String
        Dim i As Integer, j As Integer
        Dim dia1 As Integer
        Dim parcela As Double

        If IsDBNull(Me.DataDateEdit.EditValue) Then Me.DataDateEdit.EditValue = Date.Today

        mes = Format(Me.DataDateEdit.EditValue, "MM")
        ano = Format(Me.DataDateEdit.EditValue, "yy")

        If txtFormaCartao.Text = "À vista" Then
            j = 1
        Else
            j = Val(txtFormaCartao.Text)
        End If

        For i = 1 To j
            mes = mes + 1
            If mes > 12 Then
                mes = 1
                ano = ano + 1
            End If
            dia1 = Format(Me.DataDateEdit.EditValue, "dd")
            dia = Verifica_dia(dia1, mes)
            data = dia & "/" & Format(mes, "00") & "/" & Format(ano, "00")
            Do While Not IsDate(data)
                dia -= 1
                data = dia & "/" & Format(mes, "00") & "/" & Format(ano, "00")
            Loop
            dia = Verifica_dia(dia1, mes)

            parcela = (CDbl(txtValorCartao.Text) - (CDbl(txtValorCartao.Text)) * txtNomeCartao.GetColumnValue("Perc") / 100) / j

            fExecutarText("INSERT INTO [dbo].[Vencto Cartão] ([Parcela], [Vencto], [VValor], [IdCC], [NomeCartão]) VALUES ('" & CStr(i) & "/" & j & "', '" & data & "', " & Replace(parcela, ",", ".") & ", " & Me.IDTextEdit.Text & ", '" & txtNomeCartao.Text & "');")

            'mes = mes + 1

        Next i

        'Me.Conta_CorrenteTableAdapter.Fill(Me.DsCC.Conta_Corrente, varIdCC)
        'Me.Conta_CorrenteBindingSource.Filter = "Id=" & varIdCC

        Me.Vencto_CartãoTableAdapter.Fill(Me.DsCC.Vencto_Cartão)
        Me.ribDel.Visible = True

    End Sub

    Private Sub txtValorCartao_Validated(sender As Object, e As EventArgs) Handles txtValorCartao.Validated
        Call parcela_cartao()

    End Sub

    Private Sub txtFormaCartao_Validated(sender As Object, e As EventArgs) Handles txtFormaCartao.Validated
        Call parcela_cartao()

    End Sub

    Private Sub DataDateEdit_Validated(sender As Object, e As EventArgs) Handles DataDateEdit.Validated
        'Call parcela_cartao()
        'Call parcelamento()

    End Sub

    Private Sub GroupControlCHEQUES_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles GroupControlCHEQUES.CustomButtonClick

        If XtraMessageBox.Show("Confirma exclusão dos cheques?", "Atenção!", MessageBoxButtons.YesNo) = vbYes Then
            Me.ChequeSpinEdit.EditValue = 0
            Me.FormaChequeComboBoxEdit.EditValue = DBNull.Value
            Me.BancoTextEdit.Text = ""
            fExecutarText("Delete From [Vencto Cheques] Where IdCC =" & varIdCC)
            Me.Vencto_ChequesTableAdapter.Fill(Me.DsCC.Vencto_Cheques)
        End If

    End Sub

    Private Sub GroupControlCARTAO_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles GroupControlCARTAO.CustomButtonClick
        If XtraMessageBox.Show("Confirma exclusão dos dados do pagamento em cartão?", "Atenção!", MessageBoxButtons.YesNo) = vbYes Then
            Me.txtValorCartao.EditValue = 0
            Me.txtFormaCartao.EditValue = DBNull.Value
            Me.txtNomeCartao.EditValue = DBNull.Value
            fExecutarText("Delete From [Vencto Cartão] Where IdCC =" & varIdCC)
            Me.Vencto_CartãoTableAdapter.Fill(Me.DsCC.Vencto_Cartão)
        End If

    End Sub

    Private Sub btnDel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDel.ItemClick

        'Dim x As MsgBoxResult = MsgBox("Confirma exclusão do lançamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
        'If x = vbYes Then
        If XtraMessageBox.Show("Confirma exclusão do lançamento?", "Atenção!", MessageBoxButtons.YesNo) = vbYes Then
            fExecutarText("Delete From [Conta Corrente] Where Id = " & Me.IDTextEdit.Text)
            Me.Close()
        End If

    End Sub

    Private Sub BancoTextEdit_Validated(sender As Object, e As EventArgs) Handles BancoTextEdit.Validated
        Call parcelamento()

    End Sub

    Private Sub txtNomeCartao_Validated(sender As Object, e As EventArgs) Handles txtNomeCartao.Validated
        'Call parcela_cartao()

    End Sub

    Private Sub txtNomeCartao_EditValueChanged(sender As Object, e As EventArgs) Handles txtNomeCartao.EditValueChanged
        Call parcela_cartao()

    End Sub

    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Me.Conta_CorrenteBindingSource.AddNew()
            Me.DataDateEdit.EditValue = Date.Today.AddDays(-1)
            Me.ChequeCCCheckEdit.Checked = True
            Me.txtCliente.Text = varIdCliente
            Me.txtCCCartao.Checked = True
            Me.txtDolarCC.Checked = True
            Me.txtCashCC.Checked = True
            Me.txtOuroCC.Checked = True
            Me.ribDel.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class
