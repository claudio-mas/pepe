Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base

Partial Public Class frmConsertosfrm
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IsFormLoaded("frmVendaCC") Then Me.btnCC2.Visible = False : Me.TopMost = True

        Try

            Me.CONSERTOSTableAdapter.Fill(Me.DsGeral.CONSERTOS)
            Me.VendedorasTableAdapter.Fill(Me.DsGeral.Vendedoras)
            Me.VendedorasBindingSource.Filter = "Vendedora = 'Loja' Or Vendedora = 'Loja / Troca' Or Vendedora = 'Loja Virtual' Or Vendedora = 'P.T.'"
            Me.CboClientesTableAdapter.Fill(Me.DsGeral.cboClientes)
            Me.CartõesTableAdapter1.Fill(Me.DsGeral.Cartões)

            If varIdCon = 0 Then
                Me.CONSERTOSBindingSource.AddNew()
                Me.DataDateEdit.EditValue = Date.Today
            Else
                'Me.CONSERTOSBindingSource.Filter = "Id=" & varIdCon
                Me.CONSERTOSBindingSource.Position = Me.CONSERTOSBindingSource.Find("Id", varIdCon)
                Me.btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If

            Me.Vencto_ChequesTableAdapter1.Fill(Me.DsGeral.Vencto_Cheques)
            Me.Vencto_CartãoTableAdapter1.Fill(Me.DsGeral.Vencto_Cartão)

            'Me.Vencto_ChequesTableAdapter.Fill(Me.DsCC.Vencto_Cheques)
            'Me.Vencto_CartãoTableAdapter.Fill(Me.DsCC.Vencto_Cartão)

            Me.Tag = "1"

            If NomeForm = "frmClientes" Then
                frmClientes.Visible = False
            Else
                frmConsertos.Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmClientes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'frmClientes.CCTableAdapter.Fill(frmClientes.DsCliente.CC, varIdCliente)

        'Call btnAtual_Click(Nothing, Nothing)

        If IsFormLoaded("frmVendaCC") Then frmVendaCC.CCTableAdapter.Fill(frmVendaCC.DsCliente.CC, varIdCliente) : Exit Sub

        If NomeForm = "frmClientes" Then
            frmClientes.Visible = True
            frmClientes.CCTableAdapter.Fill(frmClientes.DsCliente.CC, varIdCliente)
        Else
            frmConsertos.CONSERTOSTableAdapter.Fill(frmConsertos.DsGeral.CONSERTOS)
            frmConsertos.CONSERTOSBindingSource.Position = frmConsertos.CONSERTOSBindingSource.Find("Id", varIdCon)
            frmConsertos.Visible = True
        End If
        NomeForm = ""

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub botoes()
        If Me.Tag = "1" Then
            Me.ribbonPageGroup1.Visible = False
            Me.RibbonPageGroup2.Visible = True
            Me.ribAtual.Visible = False
            '    'If frmPedidosDG.RadGridView1.Tag <> "1" Then Me.ControlBox = False
            'Me.RibbonPageGroup3.Visible = False : Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.ControlBox = False
            Me.Timer.Enabled = True
        End If

    End Sub

    Private Sub btnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        'RemoveHandler txtDebito.EditValueChanged, AddressOf txtDebito_EditValueChanged
        'RemoveHandler txtNomeCartãoDébito.TextChanged, AddressOf txtNomeCartãoDébito_TextChanged

        Me.txtValorFinal.EditValue = ConvertToDouble(Me.ChequeSpinEdit.Text) + ConvertToDouble(Me.txtValorCartao.Text) + ConvertToDouble(txtDolar.Text) + ConvertToDouble(Me.txtCash.Text) + ConvertToDouble(Me.txtOuro.Text) + ConvertToDouble(Me.txtDebito.Text) + ConvertToDouble(Me.txtTransf.Text)

        Try
            Me.Validate()
            Me.CONSERTOSBindingSource.EndEdit()
            Me.CONSERTOSVenctoChequesBindingSource.EndEdit()

            Me.CONSERTOSVenctoCartãoBindingSource.EndEdit()

            Me.TableAdapterManager1.UpdateAll(Me.DsGeral)

            If ConvertToDouble(Me.txtAUT.Text) > 0 Then
                fExecutarText("update [Vencto Cartão] set AUT = '" & Me.txtAUT.Text & "' Where IdConserto = " & Me.IDTextEdit.EditValue)
            End If

            If ConvertToDouble(Me.txtAUTDeb.Text) > 0 Then
                fExecutarText("update [Vencto Cartão] set AUTDeb = '" & Me.txtAUTDeb.Text & "' Where IdConserto = " & Me.IDTextEdit.EditValue)
            End If

            frmConsertos.CONSERTOSTableAdapter.Fill(frmConsertos.DsGeral.CONSERTOS)

            'Call btnAtual_Click(Nothing, Nothing)

            Me.btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            Call conta_corrente()

            varIdCon = Val(Me.IDTextEdit.Text)

        Catch ex As Exception
            'MsgBox(ex.Message)

        Finally
            Me.ControlBox = True
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.ribAtual.Visible = True
            Me.Timer.Enabled = False
            Me.btnAtual.ForeColor = Color.Red
            'Me.RibbonPageGroup3.Visible = True : Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            'AddHandler txtDebito.EditValueChanged, AddressOf txtDebito_EditValueChanged
            'AddHandler txtNomeCartãoDébito.TextChanged, AddressOf txtNomeCartãoDébito_TextChanged

        End Try

    End Sub

    Private Sub btnUndo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick

        Me.Timer.Enabled = False
        Me.btnAtual.ForeColor = Color.Red

        Try
            Me.Tag = "0"

            Me.CONSERTOSTableAdapter.Fill(Me.DsGeral.CONSERTOS)
            If varIdCon = 0 Then
                Me.CONSERTOSBindingSource.AddNew()
                Me.DataDateEdit.EditValue = Date.Today
            Else
                'Me.CONSERTOSBindingSource.Filter = "Id=" & varIdCon
                Me.CONSERTOSBindingSource.Position = Me.CONSERTOSBindingSource.Find("Id", varIdCon)
            End If

            Me.Vencto_ChequesTableAdapter1.Fill(Me.DsGeral.Vencto_Cheques)
            Me.Vencto_CartãoTableAdapter1.Fill(Me.DsGeral.Vencto_Cartão)

            Me.Tag = "1"

            Me.btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Me.ControlBox = True
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.ribAtual.Visible = True

        End Try

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

        'Me.ClientesTableAdapter1.Fill(Me.DsCliente.Clientes, varIdCliente)
        'Me.CCTableAdapter.Fill(Me.DsCliente.CC, varIdCliente)

        'Me.ClientesBindingSource.AddNew()
        'Me.BindingSource1.Filter = "Cliente = 0"
        ' Me.RibbonPageGroup3.Visible = False
        Me.RibbonPageGroup2.Visible = False
        Me.ribbonPageGroup1.Visible = True
        'Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

    End Sub

    Private Sub parcelamento()

        If Me.Tag <> "1" Then Exit Sub
        If IsDBNull(Me.ChequeSpinEdit.EditValue) Or Me.FormaChequeComboBoxEdit.Text = "" Then Exit Sub

        Try

            'Me.Validate()
            'Me.CONSERTOSBindingSource.EndEdit()
            'Me.TableAdapterManager1.UpdateAll(Me.DsGeral)

            fExecutarText("Delete From [Vencto Cheques] Where IdConserto = " & Me.IDTextEdit.Text)

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

            If FormaChequeComboBoxEdit.Text = "A vista" Then
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

                fExecutarText("INSERT INTO [dbo].[Vencto Cheques] ([Parcela], [Vencto], [VValor], [IdConserto], [Banco]) VALUES ('" & CStr(i) & "/" & j & "', '" & data & "', " & Replace(parcela, ",", ".") & ", " & Me.IDTextEdit.Text & ", '" & BancoTextEdit.Text & "' " & ");")

            Next i

            Me.Vencto_ChequesTableAdapter1.Fill(Me.DsGeral.Vencto_Cheques)
            'Me.ribDel.Visible = True

            Call conta_corrente()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub ChequeSpinEdit_Validated(sender As Object, e As EventArgs) Handles ChequeSpinEdit.EditValueChanged
        ''On Error Resume Next

        'If Me.Tag <> "1" Then Exit Sub

        'RemoveHandler ChequeSpinEdit.EditValueChanged, AddressOf ChequeSpinEdit_Validated

        'Call parcelamento()
        'Me.txtValorFinal.EditValue = ConvertToDouble(Me.ChequeSpinEdit.Text) + ConvertToDouble(Me.txtValorCartao.Text) + ConvertToDouble(txtDolar.Text) + ConvertToDouble(Me.txtCash.Text) + ConvertToDouble(Me.txtOuro.Text) + ConvertToDouble(Me.txtDebito.Text)

        'AddHandler ChequeSpinEdit.EditValueChanged, AddressOf ChequeSpinEdit_Validated

        Call botoes()

    End Sub

    Private Sub FormaChequeComboBoxEdit_Validated(sender As Object, e As EventArgs) Handles FormaChequeComboBoxEdit.EditValueChanged
        'Call parcelamento()
        Call botoes()

    End Sub

    Private Sub parcela_cartao()

        If Me.Tag <> "1" Then Exit Sub
        If IsDBNull(Me.txtValorCartao.EditValue) Or Me.txtFormaCartao.Text = "" Or Me.txtNomeCartao.Text = "" Then
            Exit Sub
        End If

        'Me.Tag = "0"
        'Me.Validate()
        'Me.CONSERTOSBindingSource.EndEdit()
        'Me.TableAdapterManager1.UpdateAll(Me.DsGeral)
        'Me.Tag = "1"

        fExecutarText("Delete From [Vencto Cartão] Where IsNull(Deb, 0) = 0 And IdConserto = " & Me.IDTextEdit.Text)

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

        If txtFormaCartao.Text = "A vista" Then
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

            parcela = (ConvertToDouble(txtValorCartao.Text) - (ConvertToDouble(txtValorCartao.Text)) * txtNomeCartao.GetColumnValue("Perc") / 100) / j

            If IsDBNull(Me.txtValorCartao.EditValue) Or Me.txtFormaCartao.Text = "" Or Me.txtNomeCartao.Text = "" Then
                Exit Sub
            End If

            fExecutarText("INSERT INTO [dbo].[Vencto Cartão] ([Parcela], [Vencto], [VValor], [IdConserto], [NomeCartão]) VALUES ('" & CStr(i) & "/" & j & "', '" & data & "', " & Replace(parcela, ",", ".") & ", " & Me.IDTextEdit.Text & ", '" & Me.txtNomeCartao.Text & "');")

        Next i

        Me.Vencto_CartãoTableAdapter1.Fill(Me.DsGeral.Vencto_Cartão)

        Call conta_corrente()

    End Sub

    Private Sub txtFormaCartao_Validated(sender As Object, e As EventArgs) Handles txtFormaCartao.EditValueChanged
        'Call parcela_cartao()

    End Sub

    Private Sub DataDateEdit_Validated(sender As Object, e As EventArgs) Handles DataDateEdit.EditValueChanged
        'Call parcela_cartao()
        'Call parcelamento()

    End Sub

    Private Sub GroupControlCHEQUES_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles GroupControlCHEQUES.CustomButtonClick

        If MsgBox("Confirma exclusão?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Atenção!") = vbOK Then
            Me.ChequeSpinEdit.EditValue = 0
            Me.FormaChequeComboBoxEdit.EditValue = DBNull.Value
            Me.BancoTextEdit.Text = ""
            fExecutarText("Delete From [Vencto Cheques] Where IdConserto =" & varIdCon)
            'Me.Vencto_ChequesTableAdapter.Fill(Me.DsCC.Vencto_Cheques)
            Me.Validate()
            Me.CONSERTOSBindingSource.EndEdit()
            Me.CONSERTOSVenctoChequesBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.DsGeral)
            Me.Vencto_ChequesTableAdapter1.Fill(Me.DsGeral.Vencto_Cheques)

            Me.txtValorFinal.EditValue = ConvertToDouble(Me.ChequeSpinEdit.Text) + ConvertToDouble(Me.txtValorCartao.Text) + ConvertToDouble(txtDolar.Text) + ConvertToDouble(Me.txtCash.Text) + ConvertToDouble(Me.txtOuro.Text) + ConvertToDouble(Me.txtDebito.Text) + ConvertToDouble(Me.txtTransf.Text)

            Me.ControlBox = True
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
        End If

    End Sub

    Private Sub GroupControlCARTAO_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles GroupControlCARTAO.CustomButtonClick
        If MsgBox("Confirma exclusão?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Atenção!") = vbOK Then
            Me.txtValorCartao.EditValue = 0
            Me.txtFormaCartao.EditValue = DBNull.Value
            Me.txtNomeCartao.EditValue = DBNull.Value
            fExecutarText("Delete From [Vencto Cartão] Where IdConserto =" & varIdCon)
            Me.Validate()
            Me.CONSERTOSBindingSource.EndEdit()
            Me.CONSERTOSVenctoCartãoBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.DsGeral)
            Me.Vencto_CartãoTableAdapter1.Fill(Me.DsGeral.Vencto_Cartão)
            'Me.Vencto_CartãoTableAdapter.Fill(Me.DsCC.Vencto_Cartão)

            Me.txtValorFinal.EditValue = ConvertToDouble(Me.ChequeSpinEdit.Text) + ConvertToDouble(Me.txtValorCartao.Text) + ConvertToDouble(txtDolar.Text) + ConvertToDouble(Me.txtCash.Text) + ConvertToDouble(Me.txtOuro.Text) + ConvertToDouble(Me.txtDebito.Text)

            Me.ControlBox = True
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False

        End If

    End Sub

    Private Sub DataDateEdit_EditValueChanged(sender As Object, e As EventArgs) Handles DataDateEdit.EditValueChanged
        Call botoes()

    End Sub

    Private Sub txtVendedor_EditValueChanged(sender As Object, e As EventArgs) Handles txtVendedor.EditValueChanged
        Call botoes()

    End Sub
    Private Sub cboCliente_Validated(sender As Object, e As EventArgs) Handles cboCliente.EditValueChanged
        Call botoes()

    End Sub

    Private Sub txtCusto_Validated(sender As Object, e As EventArgs) Handles txtCusto.Validated
        Call botoes()

    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        'Call botoes()

    End Sub

    Private Sub txtValor_Validated(sender As Object, e As EventArgs) Handles txtValor.Validated
        Call botoes()

    End Sub

    Private Sub txtCom_TextChanged(sender As Object, e As EventArgs) Handles txtCom.TextChanged
        'Call botoes()

    End Sub

    Private Sub txtCom_Validated(sender As Object, e As EventArgs) Handles txtCom.Validated
        Call botoes()

    End Sub

    Private Sub txtObs_TextChanged(sender As Object, e As EventArgs) Handles txtObs.TextChanged
        'Call botoes()

    End Sub

    Private Sub BancoTextEdit_Validated(sender As Object, e As EventArgs) Handles BancoTextEdit.EditValueChanged
        'Call parcelamento()
        Call botoes()

    End Sub

    Private Sub ChequeCCCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles ChequeCCCheckEdit.CheckedChanged
        'Call botoes()

    End Sub

    Private Sub conta_corrente()

        fExecutarText("Delete From [Conta Corrente] Where IdConserto = " & Me.IDTextEdit.Text)
        'fExecutarText("Delete From [Vencto Cheques] Where IdConserto = " & Me.IDTextEdit.Text)

        Dim x As Integer = cboCliente.GetColumnValue("IDCliente")

        If Me.ChequeCCCheckEdit.Checked And Me.ChequeSpinEdit.EditValue > 0 Then
            'fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [IdConserto], [Cheque], [ChequeCC], [Valor]) VALUES ('" & x & "', '" & DataDateEdit.Text & "', " & IDTextEdit.Text & ", " & Me.ChequeSpinEdit.EditValue & ", " & 1 & ", " & Me.ChequeSpinEdit.EditValue * -1 & ");")
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [IdConserto], [ChequeCC], [Valor]) VALUES ('" & x & "', '" & DataDateEdit.Text & "', " & IDTextEdit.Text & ", " & 1 & ", " & Me.ChequeSpinEdit.EditValue * -1 & ");")
        End If

        If Me.txtCCCartao.Checked And Me.txtValorCartao.Text <> "" Then
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [IdConserto], [CartãoCC], [Valor]) VALUES ('" & x & "', '" & DataDateEdit.Text & "', " & IDTextEdit.Text & ", " & 1 & ", " & Me.txtValorCartao.EditValue * -1 & ");")
        End If

        If Me.ckDolarCC.Checked And Me.txtDolar.Text <> "" Then
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [IdConserto], [DolarCC], [Valor]) VALUES ('" & x & "', '" & DataDateEdit.Text & "', " & IDTextEdit.Text & ", " & 1 & ", " & Me.txtDolar.EditValue * -1 & ");")
        End If

        If Me.ckCashCC.Checked And Me.txtCash.Text <> "" Then
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [IdConserto], [CashCC], [Valor]) VALUES ('" & x & "', '" & DataDateEdit.Text & "', " & IDTextEdit.Text & ", " & 1 & ", " & Me.txtCash.EditValue * -1 & ");")
        End If

        If Me.ckOuroCC.Checked And Me.txtOuro.Text <> "" Then
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [IdConserto], [OuroCC], [Valor]) VALUES ('" & x & "', '" & DataDateEdit.Text & "', " & IDTextEdit.Text & ", " & 1 & ", " & Me.txtOuro.EditValue * -1 & ");")
        End If

        If Me.txtDebCC.Text <> "" Then
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [IdConserto], [CCDeb], [Valor]) VALUES ('" & x & "', '" & DataDateEdit.Text & "', " & IDTextEdit.Text & ", " & Me.txtDebCC.EditValue & ", " & Me.txtDebCC.EditValue & ");")
        End If

    End Sub

    Private Sub txtCCCartao_CheckedChanged(sender As Object, e As EventArgs) Handles txtCCCartao.CheckedChanged
        'Call botoes()

    End Sub

    Private Sub txtDolar_EditValueChanged(sender As Object, e As EventArgs) Handles txtDolar.EditValueChanged
        ''On Error Resume Next

        'If Me.Tag <> "1" Then Exit Sub

        'RemoveHandler txtDolar.EditValueChanged, AddressOf txtDolar_EditValueChanged
        'Call botoes()
        ''If Val(txtDolar.Text) > 0 Then Me.ckDolarCC.Checked = True Else Me.ckDolarCC.Checked = False
        'Me.txtValorFinal.EditValue = ConvertToDouble(Me.ChequeSpinEdit.Text) + ConvertToDouble(Me.txtValorCartao.Text) + ConvertToDouble(txtDolar.Text) + ConvertToDouble(Me.txtCash.Text) + ConvertToDouble(Me.txtOuro.Text) + ConvertToDouble(Me.txtDebito.Text)
        'AddHandler txtDolar.EditValueChanged, AddressOf txtDolar_EditValueChanged

        Call botoes()

    End Sub

    Private Sub txtCash_EditValueChanged(sender As Object, e As EventArgs) Handles txtCash.EditValueChanged
        'On Error Resume Next

        'If Me.Tag <> "1" Then Exit Sub

        'RemoveHandler txtCash.EditValueChanged, AddressOf txtCash_EditValueChanged
        'Call botoes()
        ''If Val(txtCash.Text) > 0 Then Me.ckCashCC.Checked = True Else Me.ckCashCC.Checked = False
        'Me.txtValorFinal.EditValue = ConvertToDouble(Me.ChequeSpinEdit.Text) + ConvertToDouble(Me.txtValorCartao.Text) + ConvertToDouble(txtDolar.Text) + ConvertToDouble(Me.txtCash.Text) + ConvertToDouble(Me.txtOuro.Text) + ConvertToDouble(Me.txtDebito.Text)
        'AddHandler txtCash.EditValueChanged, AddressOf txtCash_EditValueChanged

        Call botoes()

    End Sub

    Private Sub txtOuro_EditValueChanged(sender As Object, e As EventArgs) Handles txtOuro.EditValueChanged
        'On Error Resume Next

        'If Me.Tag <> "1" Then Exit Sub

        'RemoveHandler txtOuro.EditValueChanged, AddressOf txtOuro_EditValueChanged
        'Call botoes()
        ''If Val(txtOuro.Text) > 0 Then Me.ckOuroCC.Checked = True Else Me.ckOuroCC.Checked = False
        'Me.txtValorFinal.EditValue = ConvertToDouble(Me.ChequeSpinEdit.Text) + ConvertToDouble(Me.txtValorCartao.Text) + ConvertToDouble(txtDolar.Text) + ConvertToDouble(Me.txtCash.Text) + ConvertToDouble(Me.txtOuro.Text) + ConvertToDouble(Me.txtDebito.Text)
        'AddHandler txtOuro.EditValueChanged, AddressOf txtOuro_EditValueChanged

        Call botoes()

    End Sub

    Private Sub ckDolarCC_CheckedChanged(sender As Object, e As EventArgs) Handles ckDolarCC.CheckedChanged
        'Call botoes()

    End Sub

    Private Sub ckCashCC_CheckedChanged(sender As Object, e As EventArgs) Handles ckCashCC.CheckedChanged
        'Call botoes()

    End Sub

    Private Sub ckOuroCC_CheckedChanged(sender As Object, e As EventArgs) Handles ckOuroCC.CheckedChanged
        'Call botoes()

    End Sub

    Private Sub txtDebCC_EditValueChanged(sender As Object, e As EventArgs) Handles txtDebCC.EditValueChanged
        Call botoes()

    End Sub

    Private Sub btnDel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDel.ItemClick
        Dim x As MsgBoxResult = MsgBox("Confirma exclusão do conserto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
        If x = vbYes Then
            Me.Validate()
            Me.CONSERTOSBindingSource.EndEdit()
            Me.CONSERTOSVenctoChequesBindingSource.EndEdit()
            Me.CONSERTOSVenctoCartãoBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.DsGeral)

            fExecutarText("Delete From [Conta Corrente] Where IdConserto = " & Me.IDTextEdit.Text)
            fExecutarText("Delete From [Vencto Cartão] Where IdConserto =" & Me.IDTextEdit.Text)
            fExecutarText("Delete From [Vencto Cheques] Where IdConserto =" & Me.IDTextEdit.Text)
            fExecutarText("Delete From [Consertos] Where Id =" & Me.IDTextEdit.Text)

            frmConsertos.CONSERTOSTableAdapter.Fill(frmConsertos.DsGeral.CONSERTOS)

            Me.Close()
        End If
    End Sub

    Private Sub FormaChequeComboBoxEdit_SelectedValueChanged(sender As Object, e As EventArgs) Handles FormaChequeComboBoxEdit.SelectedValueChanged
        'Call parcelamento()

        Call botoes()

    End Sub

    Private Sub txtFormaCartao_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtFormaCartao.SelectedValueChanged
        'Call parcela_cartao()

        Call botoes()

    End Sub

    Private Sub txtObs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObs.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True
        End If

    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        Call botoes()

    End Sub

    Private Sub txtNomeCartao_TextChanged(sender As Object, e As EventArgs) Handles txtNomeCartao.TextChanged


        'Call botoes()
        'CartõesBindingSource.RemoveFilter()

    End Sub

    Private Sub RepositoryItemLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit1.EditValueChanged

        RemoveHandler GridView2.CellValueChanged, AddressOf GridView2_CellValueChanged
        RemoveHandler RepositoryItemLookUpEdit1.EditValueChanged, AddressOf RepositoryItemLookUpEdit1_EditValueChanged

        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Dim value As Object = editor.GetColumnValue("Perc")
        Dim x

        x = ConvertToDouble(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "VValor"))
        If x > 0 Then
            Me.GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "VValor", x - (x * value / 100))
        End If

        'SendKeys.Send("{LEFT}")
        'Me.GridView2.UpdateCurrentRow()

        AddHandler GridView2.CellValueChanged, AddressOf GridView2_CellValueChanged
        AddHandler RepositoryItemLookUpEdit1.EditValueChanged, AddressOf RepositoryItemLookUpEdit1_EditValueChanged

    End Sub

    Private Sub GridView2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanged

        RemoveHandler GridView2.CellValueChanged, AddressOf GridView2_CellValueChanged
        RemoveHandler RepositoryItemLookUpEdit1.EditValueChanged, AddressOf RepositoryItemLookUpEdit1_EditValueChanged

        Dim x
        x = ConvertToDouble(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "IdConserto"))
        If x = 0 Then
            Me.GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "IdConserto", Me.IDTextEdit.Text)
            'Me.GridView2.UpdateCurrentRow()
        End If

        'Me.GridView2.UpdateCurrentRow()
        botoes()

        AddHandler GridView2.CellValueChanged, AddressOf GridView2_CellValueChanged
        AddHandler RepositoryItemLookUpEdit1.EditValueChanged, AddressOf RepositoryItemLookUpEdit1_EditValueChanged

    End Sub

    Private Sub txtDebito_EditValueChanged(sender As Object, e As EventArgs) Handles txtDebito.EditValueChanged

        'If Me.Tag <> "1" Then Exit Sub

        'RemoveHandler txtDebito.EditValueChanged, AddressOf txtDebito_EditValueChanged

        'Me.txtValorFinal.EditValue = ConvertToDouble(Me.ChequeSpinEdit.Text) + ConvertToDouble(Me.txtValorCartao.Text) + ConvertToDouble(txtDolar.Text) + ConvertToDouble(Me.txtCash.Text) + ConvertToDouble(Me.txtOuro.Text) + ConvertToDouble(Me.txtDebito.Text)

        'If txtNomeCartãoDébito.Text <> "" And ConvertToDouble(txtDebito.Text) > 0 Then
        '    fExecutarText("Delete From [Vencto Cartão] Where IdConserto = " & Me.IDTextEdit.Text & " And Deb = 1")
        '    Dim parcela As Double = (ConvertToDouble(txtDebito.Text) - (ConvertToDouble(txtDebito.Text)) * txtNomeCartãoDébito.GetColumnValue("Perc") / 100)
        '    fExecutarText("Insert Into [Vencto Cartão] (IdConserto, Vencto, VValor, Parcela, NomeCartão, Deb) Values (" & Me.IDTextEdit.Text & ", '" & Me.DataDateEdit.Text & "', " & Replace(Replace(parcela, ".", ""), ",", ".") & ", '1/1', '" & Me.txtNomeCartãoDébito.Text & "', 1)")
        '    Me.Vencto_CartãoTableAdapter1.Fill(Me.DsGeral.Vencto_Cartão)
        '    Me.Tag = "0"
        '    Me.Validate()
        '    Me.CONSERTOSBindingSource.EndEdit()
        '    Me.TableAdapterManager1.UpdateAll(Me.DsGeral)
        '    Me.Tag = "1"
        '    frmConsertos.CONSERTOSTableAdapter.Fill(frmConsertos.DsGeral.CONSERTOS)
        'End If

        'AddHandler txtDebito.EditValueChanged, AddressOf txtDebito_EditValueChanged

        Call botoes()

    End Sub

    Private Sub txtNomeCartãoDébito_TextChanged(sender As Object, e As EventArgs) Handles txtNomeCartãoDébito.TextChanged

        'RemoveHandler txtNomeCartãoDébito.TextChanged, AddressOf txtNomeCartãoDébito_TextChanged
        'Call txtDebito_EditValueChanged(Nothing, Nothing)
        'AddHandler txtNomeCartãoDébito.TextChanged, AddressOf txtNomeCartãoDébito_TextChanged

        'Call botoes()
        'CartõesBindingSource.RemoveFilter()

    End Sub

    Private Sub txtValorCartao_TextChanged(sender As Object, e As EventArgs) Handles txtValorCartao.TextChanged

        'RemoveHandler txtValorCartao.TextChanged, AddressOf txtValorCartao_TextChanged

        'Call parcela_cartao()
        'Me.txtValorFinal.EditValue = ConvertToDouble(Me.ChequeSpinEdit.Text) + ConvertToDouble(Me.txtValorCartao.Text) + ConvertToDouble(txtDolar.Text) + ConvertToDouble(Me.txtCash.Text) + ConvertToDouble(Me.txtOuro.Text) + ConvertToDouble(Me.txtDebito.Text)

        'AddHandler txtValorCartao.TextChanged, AddressOf txtValorCartao_TextChanged

        'Call botoes()

    End Sub

    Private Sub btnAtual_Click(sender As Object, e As EventArgs) Handles btnAtual.Click

        Try
            Me.txtValorFinal.EditValue = ConvertToDouble(Me.ChequeSpinEdit.Text) + ConvertToDouble(Me.txtValorCartao.Text) + ConvertToDouble(txtDolar.Text) + ConvertToDouble(Me.txtCash.Text) + ConvertToDouble(Me.txtOuro.Text) + ConvertToDouble(Me.txtDebito.Text) + ConvertToDouble(Me.txtTransf.Text)

            'Call btnSalvar_ItemClick(Nothing, Nothing)
            Me.Validate()
            Me.CONSERTOSBindingSource.EndEdit()
            Me.CONSERTOSVenctoChequesBindingSource.EndEdit()
            Me.CONSERTOSVenctoCartãoBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.DsGeral)

            Call parcelamento()

            If txtNomeCartãoDébito.Text <> "" And ConvertToDouble(txtDebito.Text) > 0 Then
                fExecutarText("Delete From [Vencto Cartão] Where IdConserto = " & Me.IDTextEdit.Text & " And Deb = 1")
                Dim parcela As Double = (ConvertToDouble(txtDebito.Text) - (ConvertToDouble(txtDebito.Text)) * txtNomeCartãoDébito.GetColumnValue("Perc") / 100)
                fExecutarText("Insert Into [Vencto Cartão] (IdConserto, Vencto, VValor, Pagto, Parcela, NomeCartão, Deb) Values (" & Me.IDTextEdit.Text & ", '" & Me.DataDateEdit.Text & "', " & Replace(Replace(parcela, ".", ""), ",", ".") & ", '" & Me.DataDateEdit.Text & "', '1/1', '" & Me.txtNomeCartãoDébito.Text & "', 1)")
                Me.Vencto_CartãoTableAdapter1.Fill(Me.DsGeral.Vencto_Cartão)
            End If

            Call parcela_cartao()

            frmConsertos.CONSERTOSTableAdapter.Fill(frmConsertos.DsGeral.CONSERTOS)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)

        Finally
            Me.ControlBox = True
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.Timer.Enabled = False
            Me.btnAtual.ForeColor = Color.Red
            Me.txtObs.Focus()
        End Try


    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        If Me.btnAtual.ForeColor = Color.Red Then
            Me.btnAtual.ForeColor = Color.Black
        Else
            Me.btnAtual.ForeColor = Color.Red
        End If

    End Sub

    Private Sub txtNomeCartao_PopupFilter(sender As Object, e As PopupFilterEventArgs) Handles txtNomeCartao.PopupFilter
        'CartõesBindingSource.Filter = "Not (Ncartao Like '%Débito')"
    End Sub

    Private Sub txtNomeCartãoDébito_PopupFilter(sender As Object, e As PopupFilterEventArgs) Handles txtNomeCartãoDébito.PopupFilter
        'CartõesBindingSource.Filter = "Ncartao LIKE '%Débito'"
    End Sub

    Private Sub btnAtual2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAtual2.ItemClick
        Call btnAtual_Click(Nothing, Nothing)

    End Sub

    Private Sub ckNavegar_CheckedChanged(sender As Object, e As EventArgs) Handles ckNavegar.CheckedChanged

        'Me.dnConsertos.Visible = ckNavegar.Checked

        'If ckNavegar.Checked Then
        '    Me.CONSERTOSBindingSource.RemoveFilter()
        '    Me.CONSERTOSBindingSource.Position = Me.CONSERTOSBindingSource.Find("Id", varIdCon)
        'Else
        '    Me.CONSERTOSBindingSource.Filter = "Id=" & varIdCon
        'End If

        'Me.ControlBox = True
        'Me.ribbonPageGroup1.Visible = True
        'Me.RibbonPageGroup2.Visible = False
        'Me.ribAtual.Visible = True
        'Me.Timer.Enabled = False

    End Sub

    Private Sub txtValorCartao_Validated(sender As Object, e As EventArgs) Handles txtValorCartao.Validated

        Call botoes()

    End Sub

    Private Sub txtNomeCartãoDébito_Validated(sender As Object, e As EventArgs) Handles txtNomeCartãoDébito.Validated

        Call botoes()
        CartõesBindingSource.RemoveFilter()

    End Sub

    Private Sub txtNomeCartao_Validated(sender As Object, e As EventArgs) Handles txtNomeCartao.Validated
        Call botoes()
        CartõesBindingSource.RemoveFilter()

    End Sub

    Private Sub ckOuroCC_Validated(sender As Object, e As EventArgs) Handles ckOuroCC.Validated
        Call botoes()

    End Sub

    Private Sub ckCashCC_Validated(sender As Object, e As EventArgs) Handles ckCashCC.Validated
        Call botoes()

    End Sub

    Private Sub ckDolarCC_Validated(sender As Object, e As EventArgs) Handles ckDolarCC.Validated
        Call botoes()

    End Sub

    Private Sub txtCCCartao_Validated(sender As Object, e As EventArgs) Handles txtCCCartao.Validated
        Call botoes()

    End Sub

    Private Sub ChequeCCCheckEdit_Validated(sender As Object, e As EventArgs) Handles ChequeCCCheckEdit.Validated
        Call botoes()

    End Sub

    Private Sub txtObs_Validated(sender As Object, e As EventArgs) Handles txtObs.Validated
        Call botoes()

    End Sub

    Private Sub CONSERTOSBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles CONSERTOSBindingSource.CurrentChanged
        On Error Resume Next

        If Me.Tag <> "1" Then Exit Sub

        'varFlag = True

        Me.ribbonPageGroup1.Visible = True
        Me.RibbonPageGroup2.Visible = False
        Me.ControlBox = True
        varIdCon = CLng(Me.IDTextEdit.Text)

    End Sub

    Private Sub txtTransf_EditValueChanged(sender As Object, e As EventArgs) Handles txtTransf.EditValueChanged
        Call botoes()

    End Sub

    Private Sub txtBancoTransf_EditValueChanged(sender As Object, e As EventArgs) Handles txtBancoTransf.EditValueChanged
        Call botoes()

    End Sub

    Private Sub txtAUT_EditValueChanged(sender As Object, e As EventArgs) Handles txtAUT.EditValueChanged
        Call botoes()

    End Sub

    Private Sub txtAUTDeb_EditValueChanged(sender As Object, e As EventArgs) Handles txtAUTDeb.EditValueChanged
        Call botoes()

    End Sub

    Private Sub btnCC2_Click(sender As Object, e As EventArgs) Handles btnCC2.Click
        varIdCliente = Me.cboCliente.GetColumnValue("IDCliente")
        frmVendaCC.ShowDialog()

    End Sub

    'Private Sub txtNomeCartãoDébito_GotFocus(sender As Object, e As EventArgs) Handles txtNomeCartãoDébito.GotFocus
    '    CartõesBindingSource.Filter = "Ncartao LIKE '%Débito'"

    'End Sub

    'Private Sub txtNomeCartao_GotFocus(sender As Object, e As EventArgs) Handles txtNomeCartao.GotFocus
    '    CartõesBindingSource.Filter = "Not (Ncartao Like '%Débito')"
    'End Sub

    'Private Sub txtValorCartao_Validated(sender As Object, e As EventArgs) Handles txtValorCartao.EditValueChanged
    '    RemoveHandler txtValorCartao.EditValueChanged, AddressOf txtValorCartao_Validated

    '    Call parcela_cartao()
    '    Me.txtValorFinal.EditValue = ConvertToDouble(Me.ChequeSpinEdit.Text) + ConvertToDouble(Me.txtValorCartao.Text) + ConvertToDouble(txtDolar.Text) + ConvertToDouble(Me.txtCash.Text) + ConvertToDouble(Me.txtOuro.Text) + ConvertToDouble(Me.txtDebito.Text)

    '    AddHandler txtValorCartao.EditValueChanged, AddressOf txtValorCartao_Validated

    'End Sub

End Class
