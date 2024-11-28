Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab

Partial Public Class frmNewVenda
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmVendasDG.IsHandleCreated Then frmVendasDG.Visible = False
        If frmClientesDG.IsHandleCreated Then frmClientesDG.Visible = False : Me.dnConsertos.Visible = False
        If frmInconsist.IsHandleCreated Then frmInconsist.Visible = False
        If frmClientes.IsHandleCreated Then frmClientes.Visible = False
        If NomeForm = "frmEstoque" Then frmEstoque.Visible = False

        Me.CartõesTableAdapter.Fill(Me.DsVendas.Cartões)
        Me.VENDASTableAdapter.Fill(Me.DsVendas.VENDAS)
        Me.CartõesDebTableAdapter.Fill(Me.DsVendas1.CartõesDeb)
        Me.CartõesCredTableAdapter.Fill(Me.DsVendas1.CartõesCred)
        Me._1TabPeçasTableAdapter.Fill(Me.DsVendas1._1TabPeças)
        Me.VendedorasTableAdapter.Fill(Me.DsVendas1.Vendedoras)
        Me.ClientesTableAdapter.Fill(Me.DsVendas1.Clientes)
        Me.VendedorasBindingSource.Filter = "Vendedora = 'Loja' Or Vendedora = 'Loja / Troca' Or Vendedora = 'Loja Virtual' Or Vendedora = 'P.T.'"

        If varIdVenda = 0 Then
            Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.RibbonPageGroup4.Visible = False

            VENDASBindingSource.AddNew()
            Dim rs As New ADODB.Recordset()
            Dim cnStr As String = strAdoConnection()
            rs.Open("SELECT Max(Venda) AS V FROM VENDAS WHERE Venda Is Not Null GROUP BY Year([DataVenda]) HAVING Year([DataVenda])=Year(GetDate())", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            If rs.EOF Then
                varNovaVenda = "0001" & "/" & Format(Date.Today, "yy")
            Else
                varNovaVenda = String.Format("{0,4:D4}", CInt(Microsoft.VisualBasic.Left(rs("V").Value, 4)) + 1) & "/" & Format(Date.Today, "yy")
            End If
            rs.Close()
            Me.txtVenda.Text = varNovaVenda
            Me.txtDataVenda.EditValue = Date.Today
            Me.LookUpEdit3.EditValue = "Loja"
            Me.ComboBoxEdit1.EditValue = "Interna"
            Me.ComboBoxEdit1.Focus()

            Me.Validate()
            Me.VENDASBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsVendas)

            rs.Open("Select Max(Id) As I From Vendas", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            varIdVenda = rs("I").Value    'varIdVenda = CInt(Me.IdTextEdit.Text)
            rs.Close()
            'Me.VenctoCartãoBindingSource.Filter = "Venda = 99999"
            'Else
            'Me.VENDASBindingSource.Filter = "Id = " & varIdVenda
            'Me.VENDASBindingSource.Position = Me.VENDASBindingSource.Find("Id", varIdVenda)
        End If

        Me.VENDASBindingSource.Position = Me.VENDASBindingSource.Find("Id", varIdVenda)

        'Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, varIdVenda)
        Me.VENDAS_DETTableAdapter.Fill(Me.DsVendas.VENDAS_DET)
        Me.Vencto_ChequesTableAdapter.Fill(Me.DsVendas.Vencto_Cheques)
        Me.Vencto_CartãoTableAdapter.Fill(Me.DsVendas.Vencto_Cartão)

        Me.Tag = "1"

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        'Call btnSalvar_ItemClick(Nothing, Nothing)
        If NomeForm = "frmEstoque" Then frmEstoque.Visible = True : NomeForm = "" : Exit Sub

        If frmVendasDG.IsHandleCreated Then
            frmVendasDG.VENDASdgTableAdapter1.Fill(frmVendasDG.DsVendas.VENDASdg)
            frmVendasDG.VENDASdgBindingSource1.Position = frmVendasDG.VENDASdgBindingSource1.Find("Id", varIdVenda)
            frmVendasDG.Visible = True
        End If

        If frmClientes.IsHandleCreated Then
            frmClientes.Visible = True
        Else
            If frmClientesDG.IsHandleCreated Then frmClientesDG.Visible = True
        End If

        If frmInconsist.IsHandleCreated Then
            frmInconsist.Inconsist4TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist4)
            frmInconsist.Inconsist5TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist5)
            frmInconsist.Inconsist2TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist2)
            frmInconsist.Inconsist1TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist1)
            frmInconsist.Visible = True
        End If

        varNomeCli = ""
        varNomeMD = ""
        NomeForm = ""

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick

        If Me.txtDataVenda.EditValue >= "20/10/2022" Then
            fExecutarText("Update VENDAS Set Comissão = (select Sum(Comissão) As Com From [VENDAS DET] Where Venda = " & varIdVenda & ") Where Id = " & varIdVenda)
        End If
        Me.Close()

    End Sub

    Private Sub btnNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovo.ItemClick

        Try
            Dim rs As New ADODB.Recordset()
            Dim cnStr As String = strAdoConnection()
            rs.Open("SELECT Max(Venda) AS V FROM VENDAS WHERE Venda Is Not Null GROUP BY Year([DataVenda]) HAVING Year([DataVenda])=Year(GetDate())", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            varNovaVenda = String.Format("{0,4:D4}", CInt(Microsoft.VisualBasic.Left(rs("V").Value, 4)) + 1) & "/" & Format(Date.Today, "yy")
            rs.Close()

            fExecutarText("Insert into VENDAS (DataVenda, Venda, Tipo) Values ('" & Format(Date.Today, "yyyy-MM-dd") & "', '" & varNovaVenda & "', 'Interna')")
            varIdVenda = DLookUp("Id", "SELECT TOP 1 Id FROM VENDAS ORDER BY Id DESC", "", 1)
            Me.VENDASBindingSource.Filter = "Id = " & varIdVenda
            Me.VENDAS_DETTableAdapter.Fill(Me.DsVendas.VENDAS_DET)
            Me.Vencto_ChequesTableAdapter.Fill(Me.DsVendas.Vencto_Cheques)
            Me.Vencto_CartãoTableAdapter.Fill(Me.DsVendas.Vencto_Cartão)

            Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.Tag = "1"

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAbrirItem_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnAbrirItem.ButtonClick
        Try
            If Not IsNothing(GridView1.GetFocusedRowCellValue("Peça")) Then
                Dim peça As String = DLookUp("Classe", "[1TabPeças]", "IDPeça = " & GridView1.GetFocusedRowCellValue("Peça"), 0) + DLookUp("Modêlo", "[1TabPeças]", "IDPeça = " & GridView1.GetFocusedRowCellValue("Peça"), 0)
                If XtraMessageBox.Show("Confirma exclusão da peça " & peça & " ?", "Atenção!", MessageBoxButtons.YesNo) = vbYes Then
                    fExecutarText("update [1TabPeças] set Vendida = 0, Comissão = 0 WHERE IDPeça = " & GridView1.GetFocusedRowCellValue("Peça"))
                    fExecutarText("delete from [VENDAS DET] WHERE Id = " & GridView1.GetFocusedRowCellValue("Id"))
                    Me.VENDAS_DETTableAdapter.Fill(Me.DsVendas.VENDAS_DET)
                    Me._1TabPeçasTableAdapter.Fill(Me.DsVendas._1TabPeças)
                End If

                Dim varTot As Double = 0, varCom As Double = 0
                For i As Integer = 0 To GridView1.DataRowCount - 1
                    varTot += ConvertToDouble(GridView1.GetRowCellValue(i, "PrVenda"))
                    varCom += ConvertToDouble(GridView1.GetRowCellValue(i, "Desconto"))
                Next i

                Me.txtDesconto.Text = FormatNumber(varCom, 2)
                Me.txtValorFinal.Text = FormatNumber(ConvertToDouble(varTot) - ConvertToDouble(TextEdit1.Text) - ConvertToDouble(txtTroca.Text) - ConvertToDouble(txtDesconto.Text), 2)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        RemoveHandler GridView1.CellValueChanged, AddressOf GridView1_CellValueChanged

        Call botoes()

        Dim x As Double = ConvertToDouble(cboRef.GetDataSourceValue("PrVenda", cboRef.GetDataSourceRowIndex("IDPeça", CInt(Me.cboRef.Tag))))
        Dim y As Double = ConvertToDouble(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "ValorVenda"))

        If y > 0 And (x - y) > 0 Then Me.GridView1.SetFocusedRowCellValue("Desconto", x - y)

        AddHandler GridView1.CellValueChanged, AddressOf GridView1_CellValueChanged

    End Sub
    Private Sub GridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Call botoes()

    End Sub
    Private Sub cboRef_CVC(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles cboRef.EditValueChanging

        Me.cboRef.Tag = e.NewValue

    End Sub
    Private Sub cboRef_CVC2(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboRef.Validating

        Try
            Me.GridView1.SetFocusedRowCellValue("txtValorVenda", cboRef.GetDataSourceValue("Vendida", cboRef.GetDataSourceRowIndex("IDPeça", CInt(Me.cboRef.Tag))))
            Me.GridView1.SetFocusedRowCellValue("PrVenda", cboRef.GetDataSourceValue("PrVenda", cboRef.GetDataSourceRowIndex("IDPeça", CInt(Me.cboRef.Tag))))

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Me.TabPeçasBindingSource.RemoveFilter()

        End Try

    End Sub
    Private Sub botoes()
        If Me.Tag = "1" Then
            Me.ribbonPageGroup1.Visible = False
            Me.RibbonPageGroup2.Visible = True
            Me.RibbonPageGroup4.Visible = False
            Me.ribAtual.Visible = False
            Me.ControlBox = False
        End If

    End Sub
    Private Sub botoes2()
        If Me.Tag = "1" Then
            Me.ribbonPageGroup1.Visible = False
            Me.RibbonPageGroup2.Visible = False
            Me.RibbonPageGroup3.Visible = False
            Me.RibbonPageGroup4.Visible = False
            Me.ribAtual.Visible = True
            Me.ControlBox = False
        End If

    End Sub

    Private Sub DataVendaDateEdit_TextChanged(sender As Object, e As EventArgs) Handles txtDataVenda.TextChanged
        Call botoes()

    End Sub

    Private Sub ComboBoxEdit1_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.TextChanged
        Call botoes()

    End Sub

    Private Sub LookUpEdit1_TextChanged(sender As Object, e As EventArgs) Handles LookUpEdit1.TextChanged
        On Error Resume Next

        Dim x As String = LookUpEdit1.Properties.GetDisplayText(LookUpEdit1.EditValue)
        If x = "" Then
            LookUpEdit2.EditValue = 0
        Else
            x = DLookUp("IDCliente", "Clientes", "[Nome] = '" & x & "'", 0)
            LookUpEdit2.EditValue = CInt(x)
        End If

        Call botoes()

    End Sub

    Private Sub TextEdit1_TextChanged(sender As Object, e As EventArgs) Handles TextEdit1.TextChanged

        'If Me.Tag = "1" Then
        '    Try
        '        Dim varTot As Double = 0
        '        For i As Integer = 0 To GridView1.DataRowCount - 1
        '            varTot = varTot + GridView1.GetRowCellValue(i, "ValorVenda")
        '        Next i

        '        Me.txtValorFinal.Text = FormatNumber(ConvertToDouble(varTot) - ConvertToDouble(TextEdit1.Text) - ConvertToDouble(txtTroca.Text) - ConvertToDouble(txtDesconto.Text), 2)
        '        'calcula_total()

        '        Call botoes()

        '    Catch ex As Exception
        '        XtraMessageBox.Show(ex.Message)

        '    End Try

        'End If

    End Sub

    Private Sub LookUpEdit2_TextChanged(sender As Object, e As EventArgs) Handles LookUpEdit2.TextChanged
        Call botoes()

    End Sub

    Private Sub LookUpEdit3_TextChanged(sender As Object, e As EventArgs) Handles LookUpEdit3.TextChanged
        Call botoes()

    End Sub

    Private Sub TextEdit2_TextChanged(sender As Object, e As EventArgs) Handles TextEdit2.TextChanged
        Call botoes()

    End Sub

    Private Sub DestinoTextEdit_TextChanged(sender As Object, e As EventArgs) Handles DestinoTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub txtTroca_TextChanged(sender As Object, e As EventArgs) Handles txtTroca.TextChanged
        Try
            'calcula_total()
            'Call botoes()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtDesconto_TextChanged(sender As Object, e As EventArgs) Handles txtDesconto.TextChanged
        Try
            'calcula_total()

            'Call botoes()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmVenda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        On Error Resume Next

        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.Send("{Tab}")
        End Select

    End Sub


    Private Sub btnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        On Error Resume Next

        'calcula_total()

        Me.txtBancoTransf.Focus()

        'If Not Me.DestinoTextEdit.EditValue Is DBNull.Value Then
        '    If Me.DestinoTextEdit.EditValue = "" Then Me.DestinoTextEdit.EditValue = DBNull.Value
        'End If

        Me.Validate()
        Me.VENDASBindingSource.EndEdit()
        Me.VENDASVenctoChequesBindingSource.EndEdit()
        Me.VENDASVenctoCartãoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsVendas)

        varIdVenda = CInt(Me.IdTextEdit.Text)
        'fExecutarText("Update Vendas set ValorTransf = " & Replace(Replace(ConvertToDouble(Me.txtTransf.Text), ".", ""), ",", ".") & " Where Id = " & varIdVenda & "; Update Vendas set BancoTransf = '" & Me.txtBancoTransf.Text & "' Where Id = " & varIdVenda & "; Update Vendas set Deb = " & Replace(Replace(ConvertToDouble(Me.txtDeb.Text), ".", ""), ",", ".") & " Where Id = " & varIdVenda & "; Update Vendas set NomeCDeb = '" & Me.txtNomeCDeb.Text & "' Where Id = " & varIdVenda)
        fExecutarText("update [1TabPeças] set vendida=1, Comissão = b.Comissão FROM dbo.[1TabPeças] a INNER JOIN  dbo.[VENDAS DET] b ON a.IDPeça = b.Peça WHERE b.Venda = " & CInt(Me.IdTextEdit.Text))
        Me._1TabPeçasTableAdapter.Fill(Me.DsVendas._1TabPeças)

        fExecutarText("update vendas SET peças=dbo.fPeças(Id) where Id = " & CInt(Me.IdTextEdit.Text))

        If ConvertToDouble(Me.txtAUT.Text) > 0 Then
            fExecutarText("update [Vencto Cartão] set AUT = '" & Me.txtAUT.Text & "' Where Venda = " & varIdVenda)
        End If

        If ConvertToDouble(Me.txtAUTDeb.Text) > 0 Then
            fExecutarText("update [Vencto Cartão] set AUTDeb = '" & Me.txtAUTDeb.Text & "' Where Venda = " & varIdVenda)
        End If

        'Dim x As Double
        'x = DLookUp("Com", "Select Sum(Comissão) as Com From [VENDAS DET] Where Venda =" & varIdVenda, "", 1)
        'Me.TextEdit2.Text = ConvertToDouble(x)

        Call conta_corrente()

        If frmVendasDG.IsHandleCreated Then
            frmVendasDG.VENDASdgTableAdapter.Fill(frmVendasDG.DsPrincipal.VENDASdg)
        End If
        If frmInconsist.IsHandleCreated Then
            frmInconsist.Inconsist2TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist2)
        End If

        Me.VENDASTableAdapter.Fill(Me.DsVendas.VENDAS)
        Me.VENDASBindingSource.Position = Me.VENDASBindingSource.Find("Id", varIdVenda)

        'Catch ex As Exception
        '    MsgBox(ex.Message)

        'Finally
        Me.ribbonPageGroup1.Visible = True
        Me.RibbonPageGroup2.Visible = False
        Me.RibbonPageGroup4.Visible = True
        Me.ribAtual.Visible = True
        Me.ControlBox = True
        Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.btnAtual.ForeColor = Color.Red
        Me.txtCliente.Text = LookUpEdit1.Text
        Me.TextEdit3.Text = Me.txtVenda.Text & "   (R$ " & Me.txtValorFinal.Text & ")"

        'End Try

    End Sub

    Private Sub btnCancelarVenda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelarVenda.ItemClick

        Try
            If XtraMessageBox.Show("Confirma cancelamento da venda " & Me.txtVenda.Text & " ?", "Atenção!", MessageBoxButtons.YesNo) = vbYes Then
                fExecutarText("update [1TabPeças] set vendida=0, Comissão=0 FROM dbo.[1TabPeças] a INNER JOIN  dbo.[VENDAS DET] b ON a.IDPeça = b.Peça WHERE b.Venda = " & CInt(Me.IdTextEdit.Text))
                fExecutarText("delete from VENDAS WHERE Id = " & CInt(Me.IdTextEdit.Text))
                If frmVendasDG.IsHandleCreated Then
                    frmVendasDG.VENDASdgTableAdapter.Fill(frmVendasDG.DsPrincipal.VENDASdg)
                End If
                If frmInconsist.IsHandleCreated Then
                    frmInconsist.Inconsist2TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist2)
                End If
                Me.Close()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUndo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick

        Me.btnAtual.ForeColor = Color.Red

        Try
            If varIdVenda = 0 Then
                Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                VENDASBindingSource.AddNew()
                Me.txtVenda.Text = varNovaVenda
                Me.txtDataVenda.EditValue = Date.Today
                Me.txtTransf.Text = "0,00"
                Me.ComboBoxEdit1.Focus()
            Else
                'Me.VENDASTableAdapter.Fill(Me.DsPrincipal.VENDAS, varIdVenda)
                'Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, varIdVenda)
                Me.VENDASTableAdapter.Fill(Me.DsVendas.VENDAS)
                'Me.VENDASBindingSource.Filter = "Id = " & varIdVenda
                Me.VENDASBindingSource.Position = Me.VENDASBindingSource.Find("Id", varIdVenda)
            End If

            If frmVendasDG.IsHandleCreated Then
                frmVendasDG.VENDASdgTableAdapter.Fill(frmVendasDG.DsPrincipal.VENDASdg)
            End If
            If frmInconsist.IsHandleCreated Then
                frmInconsist.Inconsist2TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist2)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.RibbonPageGroup4.Visible = True
            Me.ribAtual.Visible = True
            Me.ControlBox = True
            Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnAtual.ForeColor = Color.Red
        End Try

    End Sub

    Private Sub MDCheckEdit_CheckedChanged(sender As Object, e As EventArgs)
        Call botoes()

    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        On Error Resume Next

        Me.RibbonPageGroup3.Visible = (XtraTabControl1.SelectedTabPage.Text = "FORMA DE PAGAMENTO")
        Me.ribAtual.Visible = (XtraTabControl1.SelectedTabPage.Text = "FORMA DE PAGAMENTO")
        Me.Tag = "1"
        Me.txtCliente.Text = LookUpEdit1.Text
        Me.TextEdit3.Text = Me.txtVenda.Text & "   (R$ " & Me.txtValorFinal.Text & ")"

        If IdTextEdit.Text = "-1" Then
            Me.Validate()
            Me.VENDASBindingSource.EndEdit()
            Me.VENDASVenctoChequesBindingSource.EndEdit()
            Me.VENDASVenctoCartãoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsVendas)
        End If

    End Sub

    Private Sub ckDolarCC_CheckedChanged(sender As Object, e As EventArgs) Handles ckDolarCC.CheckedChanged

        Try
            Call botoes()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)

        End Try

    End Sub

    Sub AtualizaCC2()
        Try

            Dim rs As New ADODB.Recordset()
            Dim cnStr As String = strAdoConnection()
            rs.Open("SELECT * From [Conta Corrente]", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

            If Me.ckChequeCC.EditValue Then
                rs.AddNew()
                rs("Venda").Value = Me.txtVenda.EditValue
                rs("Cliente").Value = LookUpEdit1.EditValue
                rs("Data").Value = Me.txtDataVenda.EditValue
                rs("Valor").Value = Me.ChequeSpinEdit.EditValue * -1
                rs("Cheque").Value = Me.ChequeSpinEdit.EditValue * -1
                rs.Update()
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

    End Sub

    Private Sub cboRef_Popup(sender As Object, e As EventArgs) Handles cboRef.PopupFilter
        Me.TabPeçasBindingSource.Filter = "(Vendida = 0 Or Vendida Is Null) And Modêlo IS NOT NULL"

    End Sub

    Private Sub GridView1_EditFormPrepared(sender As Object, e As EditFormPreparedEventArgs) Handles GridView1.EditFormPrepared

        TryCast(e.Panel.Parent, Form).StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub GridView1_EditFormHidden(sender As Object, e As EditFormHiddenEventArgs) Handles GridView1.EditFormHidden

        Try
            Me.TabPeçasBindingSource.RemoveFilter()
            Me.TabPeçasBindingSource.Filter = "Modêlo IS NOT NULL"

            If e.Result.ToString = "Cancel" Then
                Me.ribbonPageGroup1.Visible = True
                Me.RibbonPageGroup2.Visible = False
                Me.RibbonPageGroup4.Visible = True
                Me.ControlBox = True
            Else
                Dim varTot As Double = 0, varCom As Double = 0
                For i As Integer = 0 To GridView1.DataRowCount - 1
                    varTot += ConvertToDouble(GridView1.GetRowCellValue(i, "PrVenda"))
                    varCom += ConvertToDouble(GridView1.GetRowCellValue(i, "Desconto"))
                Next i

                Me.txtDesconto.Text = FormatNumber(varCom, 2)
                Me.txtValorFinal.Text = FormatNumber(ConvertToDouble(varTot) - ConvertToDouble(TextEdit1.Text) - ConvertToDouble(txtTroca.Text) - ConvertToDouble(txtDesconto.Text), 2)

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnCartões_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCartões.ItemClick
        frmTaxasCartão.ShowDialog()

    End Sub

    Private Shared Sub SetFont(ByVal control As Control)

        For Each childControl As Control In control.Controls
            childControl.Font = New Font("Segoe UI", 9)
            If childControl.Controls.Count > 0 Then
                SetFont(childControl)
            End If
        Next childControl

    End Sub
    Private Sub gridView1_ShowingPopupEditForm(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs) Handles GridView1.ShowingPopupEditForm

        e.EditForm.Width = 427
        e.EditForm.Height = 200

        For Each control As Control In e.EditForm.Controls
            SetFont(control)
        Next control

    End Sub

    Private Sub parcelamento()
        On Error Resume Next

        If Me.Tag <> "1" Then Exit Sub
        If IsDBNull(Me.ChequeSpinEdit.EditValue) Or Me.FormaChequeComboBoxEdit.Text = "" Then Exit Sub

        If Me.IdTextEdit.Text = "-1" Then
            Me.Validate()
            Me.VENDASBindingSource.EndEdit()
            Me.VENDASVenctoChequesBindingSource.EndEdit()
            Me.VENDASVenctoCartãoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsVendas)
        End If

        fExecutarText("Delete From [Vencto Cheques] Where Venda = " & Me.IdTextEdit.Text)

        Dim dia As Integer
        Dim mes As Integer
        Dim ano As Integer
        Dim data As String
        Dim i As Integer, j As Integer
        Dim dia1 As Integer
        Dim parcela As Double

        If IsDBNull(Me.txtDataVenda.EditValue) Then Me.txtDataVenda.EditValue = Date.Today

        mes = Format(Me.txtDataVenda.EditValue, "MM")
        ano = Format(Me.txtDataVenda.EditValue, "yy")

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
            dia1 = Format(Me.txtDataVenda.EditValue, "dd")
            dia = Verifica_dia(dia1, mes)
            data = dia & "/" & Format(mes, "00") & "/" & Format(ano, "00")
            Do While Not IsDate(data)
                dia -= 1
                data = (dia - 1) & "/" & Format(mes, "00") & "/" & Format(ano, "00")
            Loop
            dia = Verifica_dia(dia1, mes)

            parcela = CDbl(ChequeSpinEdit.Text) / j

            fExecutarText("INSERT INTO [dbo].[Vencto Cheques] ([Parcela], [Vencto], [VValor], [Venda], [Banco]) VALUES ('" & CStr(i) & "/" & j & "', '" & data & "', " & Replace(parcela, ",", ".") & ", " & Me.IdTextEdit.Text & ", '" & BancoTextEdit.Text & "' " & ");")

        Next i

        Me.Vencto_ChequesTableAdapter.Fill(Me.DsVendas.Vencto_Cheques)

        Call conta_corrente()

    End Sub

    Private Sub conta_corrente()

        fExecutarText("Delete From [Conta Corrente] Where Venda = '" & Me.txtVenda.Text & "'")

        Dim x As Integer = LookUpEdit1.GetColumnValue("IDCliente")

        If Me.ckChequeCC.Checked And ConvertToDouble(Me.ChequeSpinEdit.EditValue) > 0 Then
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [Venda], [ChequeCC], [Valor]) VALUES ('" & x & "', '" & txtDataVenda.Text & "', '" & txtVenda.Text & "', " & 1 & ", " & Me.ChequeSpinEdit.EditValue * -1 & ");")
        End If

        If Me.txtCCCartao.Checked And Me.txtValorCartao.Text <> "" Then
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [Venda], [CartãoCC], [Valor]) VALUES ('" & x & "', '" & txtDataVenda.Text & "', '" & txtVenda.Text & "', " & 1 & ", " & Me.txtValorCartao.EditValue * -1 & ");")
        End If

        If Me.txtCCCartao2.Checked And Me.txtValorCartao2.Text <> "" Then
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [Venda], [CartãoCC], [Valor]) VALUES ('" & x & "', '" & txtDataVenda.Text & "', '" & txtVenda.Text & "', " & 1 & ", " & Me.txtValorCartao2.EditValue * -1 & ");")
        End If

        If Me.ckDolarCC.Checked And Me.txtDolar.Text <> "" Then
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [Venda], [DolarCC], [Valor]) VALUES ('" & x & "', '" & txtDataVenda.Text & "', '" & txtVenda.Text & "', " & 1 & ", " & Me.txtDolar.EditValue * -1 & ");")
        End If

        If Me.ckCashCC.Checked And Me.txtCash.Text <> "" Then
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [Venda], [CashCC], [Valor]) VALUES ('" & x & "', '" & txtDataVenda.Text & "', '" & txtVenda.Text & "', " & 1 & ", " & Me.txtCash.EditValue * -1 & ");")
        End If

        If Me.ckOuroCC.Checked And Me.txtOuro.Text <> "" Then
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [Venda], [OuroCC], [Valor]) VALUES ('" & x & "', '" & txtDataVenda.Text & "', '" & txtVenda.Text & "', " & 1 & ", " & Me.txtOuro.EditValue * -1 & ");")
        End If

        If ConvertToDouble(txtCCDeb.Text) > 0 Then
            'fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [Venda], [CCDeb], [Valor]) VALUES ('" & x & "', '" & txtDataVenda.Text & "', '" & txtVenda.Text & "', " & Me.txtCCDeb.EditValue * -1 & ", " & Me.txtCCDeb.EditValue * -1 & ");")
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [Venda], [CCDeb], [Valor]) VALUES ('" & x & "', '" & txtDataVenda.Text & "', '" & txtVenda.Text & "', " & Me.txtCCDeb.EditValue * -1 & ", " & 0 & ");")
        End If

    End Sub

    Private Sub txtValorCartao_EditValueChanged(sender As Object, e As EventArgs) Handles txtValorCartao.EditValueChanged
        On Error Resume Next

        botoes2()

    End Sub

    Private Sub parcela_cartao()
        On Error Resume Next

        If Me.Tag <> "1" Then Exit Sub

        If IsDBNull(Me.txtValorCartao.EditValue) Or Me.txtFormaCartao.Text = "" Or Me.txtNomeCartao.Text = "" Then
            Exit Sub
        End If

        Me.Tag = "0"
        If Me.IdTextEdit.Text = "-1" Then
            Me.Validate()
            Me.VENDASBindingSource.EndEdit()
            Me.VENDASVenctoChequesBindingSource.EndEdit()
            Me.VENDASVenctoCartãoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsVendas)
        End If

        Me.Tag = "1"

        fExecutarText("Delete From [Vencto Cartão] Where Venda = " & Me.IdTextEdit.Text)

        Dim dia As Integer
        Dim mes As Integer
        Dim ano As Integer
        Dim data As String
        Dim i As Integer, j As Integer
        Dim dia1 As Integer
        Dim parcela As Double

        If IsDBNull(Me.txtDataVenda.EditValue) Then Me.txtDataVenda.EditValue = Date.Today

        mes = Format(Me.txtDataVenda.EditValue, "MM")
        ano = Format(Me.txtDataVenda.EditValue, "yy")

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
            dia1 = Format(Me.txtDataVenda.EditValue, "dd")
            dia = Verifica_dia(dia1, mes)
            data = dia & "/" & Format(mes, "00") & "/" & Format(ano, "00")
            Do While Not IsDate(data)
                dia -= 1
                data = dia & "/" & Format(mes, "00") & "/" & Format(ano, "00")
            Loop
            dia = Verifica_dia(dia1, mes)

            parcela = (CDbl(txtValorCartao.Text) - (CDbl(txtValorCartao.Text)) * txtNomeCartao.GetColumnValue("Perc") / 100) / j

            If IsDBNull(Me.txtValorCartao.EditValue) Or Me.txtFormaCartao.Text = "" Or Me.txtNomeCartao.Text = "" Then
                Exit Sub
            End If

            fExecutarText("INSERT INTO [dbo].[Vencto Cartão] ([Parcela], [Vencto], [VValor], [Venda], [NomeCartão]) VALUES ('" & CStr(i) & "/" & j & "', '" & data & "', " & Replace(parcela, ",", ".") & ", " & Me.IdTextEdit.Text & ", '" & Me.txtNomeCartao.Text & "');")

        Next i

        If IsDBNull(Me.txtValorCartao2.EditValue) Or Me.txtFormaCartao2.Text = "" Or Me.txtNomeCartao2.Text = "" Then
            'Exit Sub
        Else
            mes = Format(Me.txtDataVenda.EditValue, "MM")
            ano = Format(Me.txtDataVenda.EditValue, "yy")

            If txtFormaCartao2.Text = "A vista" Then
                j = 1
            Else
                j = Val(txtFormaCartao2.Text)
            End If

            For i = 1 To j
                mes = mes + 1
                If mes > 12 Then
                    mes = 1
                    ano = ano + 1
                End If
                dia1 = Format(Me.txtDataVenda.EditValue, "dd")
                dia = Verifica_dia(dia1, mes)
                data = dia & "/" & Format(mes, "00") & "/" & Format(ano, "00")
                Do While Not IsDate(data)
                    dia -= 1
                    data = dia & "/" & Format(mes, "00") & "/" & Format(ano, "00")
                Loop
                dia = Verifica_dia(dia1, mes)

                parcela = (CDbl(txtValorCartao2.Text) - (CDbl(txtValorCartao2.Text)) * txtNomeCartao2.GetColumnValue("Perc") / 100) / j

                If IsDBNull(Me.txtValorCartao2.EditValue) Or Me.txtFormaCartao2.Text = "" Or Me.txtNomeCartao2.Text = "" Then
                    Exit Sub
                End If

                fExecutarText("INSERT INTO [dbo].[Vencto Cartão] ([Parcela], [Vencto], [VValor], [Venda], [NomeCartão]) VALUES ('" & CStr(i) & "/" & j & "', '" & data & "', " & Replace(parcela, ",", ".") & ", " & Me.IdTextEdit.Text & ", '" & Me.txtNomeCartao2.Text & "');")

            Next i
        End If

        'Me.Vencto_CartãoTableAdapter.Fill(Me.DsCliente.Vencto_Cartão)
        'Me.VenctoCartãoBindingSource.Filter = "Venda = " & varIdVenda
        Me.Vencto_CartãoTableAdapter.Fill(Me.DsVendas.Vencto_Cartão)

        Call conta_corrente()

    End Sub

    Private Sub calcula_total()
        If Me.Tag = "1" Then
            Me.Tag = "0"

            Dim varTot As Double = 0
            Dim varCom As Double = 0

            For i As Integer = 0 To GridView1.DataRowCount - 1
                varTot = varTot + ConvertToDouble(GridView1.GetRowCellValue(i, "PrVenda"))
                varCom = varCom + ConvertToDouble(GridView1.GetRowCellValue(i, "Comissão"))
            Next i

            Me.txtValorFinal.Text = FormatNumber(ConvertToDouble(varTot) - ConvertToDouble(TextEdit1.Text) - ConvertToDouble(txtTroca.Text) - ConvertToDouble(txtDesconto.Text), 2)
            Me.TextEdit2.Text = FormatNumber(ConvertToDouble(varCom), 2)

            Me.Tag = "1"
        End If

        'Me.Timer.Enabled = True

    End Sub

    Private Sub ChequeSpinEdit_EditValueChanged(sender As Object, e As EventArgs) Handles ChequeSpinEdit.EditValueChanged
        On Error Resume Next

        botoes2()

    End Sub

    Private Sub FormaChequeComboBoxEdit_SelectedValueChanged(sender As Object, e As EventArgs) Handles FormaChequeComboBoxEdit.SelectedValueChanged
        On Error Resume Next

        botoes2()

    End Sub

    Private Sub BancoTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles BancoTextEdit.EditValueChanged
        On Error Resume Next

        botoes2()

    End Sub

    Private Sub txtFormaCartao_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtFormaCartao.SelectedValueChanged
        On Error Resume Next

        botoes2()

    End Sub

    Private Sub txtNomeCartao_EditValueChanged(sender As Object, e As EventArgs) Handles txtNomeCartao.EditValueChanged

    End Sub

    Private Sub txtDolar_TextChanged(sender As Object, e As EventArgs) Handles txtDolar.TextChanged
        Call botoes()

    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Call botoes()

    End Sub

    Private Sub txtOuro_TextChanged(sender As Object, e As EventArgs) Handles txtOuro.TextChanged
        Call botoes()

    End Sub

    Private Sub txtCCDeb_TextChanged(sender As Object, e As EventArgs) Handles txtCCDeb.TextChanged
        Call botoes()

    End Sub

    Private Sub txtBancoTransf_TextChanged(sender As Object, e As EventArgs) Handles txtBancoTransf.TextChanged
        Call botoes()

    End Sub

    Private Sub txtTransf_TextChanged(sender As Object, e As EventArgs) Handles txtTransf.TextChanged
        Call botoes()

    End Sub

    Private Sub ckCashCC_CheckedChanged(sender As Object, e As EventArgs) Handles ckCashCC.CheckedChanged
        Call botoes()

    End Sub

    Private Sub ckOuroCC_CheckedChanged(sender As Object, e As EventArgs) Handles ckOuroCC.CheckedChanged

        Call botoes()

    End Sub

    Private Sub ckChequeCC_CheckedChanged(sender As Object, e As EventArgs) Handles ckChequeCC.CheckedChanged
        Call botoes()

    End Sub

    Private Sub txtCCCartao_CheckedChanged(sender As Object, e As EventArgs) Handles txtCCCartao.CheckedChanged
        Call botoes()

    End Sub

    Private Sub XtraTabControl1_SelectedPageChanging(sender As Object, e As TabPageChangingEventArgs) Handles XtraTabControl1.SelectedPageChanging
        Me.Tag = "0"

    End Sub

    Private Sub GroupControlCARTAO_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles GroupControlCARTAO.CustomButtonClick

        If XtraMessageBox.Show("Confirma exclusão dos dados de pagamento por cartão de crédito?", "Atenção!", MessageBoxButtons.YesNo) = vbYes Then
            Me.txtValorCartao.EditValue = 0
            Me.txtFormaCartao.EditValue = DBNull.Value
            Me.txtNomeCartao.EditValue = DBNull.Value
            Me.txtDeb.EditValue = 0
            Me.txtNomeCDeb.EditValue = DBNull.Value
            fExecutarText("Delete From [Vencto Cartão] Where Venda =" & varIdVenda)
            Me.Vencto_CartãoTableAdapter.Fill(Me.DsVendas.Vencto_Cartão)
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.RibbonPageGroup4.Visible = True
            Me.ribAtual.Visible = True
            Me.ControlBox = True
            Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

    End Sub

    Private Sub GroupControlCHEQUES_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles GroupControlCHEQUES.CustomButtonClick

        If XtraMessageBox.Show("Confirma exclusão dos dados de pagamento com cheque(s)?", "Atenção!", MessageBoxButtons.YesNo) = vbYes Then
            Me.ChequeSpinEdit.EditValue = 0
            Me.FormaChequeComboBoxEdit.EditValue = DBNull.Value
            Me.BancoTextEdit.Text = ""
            fExecutarText("Delete From [Vencto Cheques] Where Venda =" & varIdVenda)
            Me.Vencto_ChequesTableAdapter.Fill(Me.DsVendas.Vencto_Cheques)
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.RibbonPageGroup4.Visible = True
            Me.ribAtual.Visible = True
            Me.ControlBox = True
            Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

    End Sub

    Private Sub txtNomeCartao_TextChanged(sender As Object, e As EventArgs) Handles txtNomeCartao.TextChanged

        botoes2()

    End Sub

    Private Sub btnAtual_Click(sender As Object, e As EventArgs) Handles btnAtual.Click
        On Error Resume Next

        'Call calcula_total()

        'If Me.IdTextEdit.Text = "-1" Then
        Me.Validate()
            Me.VENDASBindingSource.EndEdit()
            Me.VENDASVenctoChequesBindingSource.EndEdit()
            Me.VENDASVenctoCartãoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsVendas)
        'End If

        'fExecutarText("Update Vendas set ValorTransf = " & Replace(Replace(ConvertToDouble(Me.txtTransf.Text), ".", ""), ",", ".") & " Where Id = " & varIdVenda & "; Update Vendas set BancoTransf = '" & Me.txtBancoTransf.Text & "' Where Id = " & varIdVenda & "; Update Vendas set Deb = " & Replace(Replace(ConvertToDouble(Me.txtDeb.Text), ".", ""), ",", ".") & " Where Id = " & varIdVenda & "; Update Vendas set NomeCDeb = '" & Me.txtNomeCDeb.Text & "' Where Id = " & varIdVenda)

        Call parcela_cartao()

        If txtNomeCDeb.Text <> "" And ConvertToDouble(txtDeb.Text) > 0 Then
            fExecutarText("Delete From [Vencto Cartão] Where Venda = " & Me.IdTextEdit.Text & " And Deb = 1")
            Dim parcela As Double = (ConvertToDouble(txtDeb.Text) - (ConvertToDouble(txtDeb.Text)) * txtNomeCDeb.GetColumnValue("Perc") / 100)
            fExecutarText("Insert Into [Vencto Cartão] (Venda, Vencto, VValor, Pagto, Parcela, NomeCartão, Deb) Values (" & Me.IdTextEdit.Text & ", '" & Me.txtDataVenda.Text & "', " & Replace(Replace(parcela, ".", ""), ",", ".") & ", '" & Me.txtDataVenda.Text & "', '1/1', '" & Me.txtNomeCDeb.Text & "', 1)")
            Me.Vencto_CartãoTableAdapter.Fill(Me.DsVendas.Vencto_Cartão)
        End If

        Call parcelamento()

        If frmVendasDG.IsHandleCreated Then
            frmVendasDG.VENDASdgTableAdapter.Fill(frmVendasDG.DsPrincipal.VENDASdg)
        End If
        If frmInconsist.IsHandleCreated Then
            frmInconsist.Inconsist2TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist2)
        End If

        'Catch ex As Exception
        '    XtraMessageBox.Show(ex.Message)

        'Finally


        Me.Validate()
        Me.VENDASBindingSource.EndEdit()
        Me.VENDASVenctoChequesBindingSource.EndEdit()
        Me.VENDASVenctoCartãoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsVendas)
        'End Try

        Me.btnAtual.ForeColor = Color.Red
        txtValorCartao.Focus()
        Me.ribbonPageGroup1.Visible = True
        Me.RibbonPageGroup2.Visible = False
        Me.RibbonPageGroup4.Visible = True
        Me.ControlBox = True
        Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)

        If Me.btnAtual.ForeColor = Color.Red Then
            Me.btnAtual.ForeColor = Color.Black
        Else
            Me.btnAtual.ForeColor = Color.Red
        End If

    End Sub

    Private Sub txtNomeCDeb_TextChanged(sender As Object, e As EventArgs) Handles txtNomeCDeb.TextChanged
        botoes2()

    End Sub

    Private Sub GridView2_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanging
        Call botoes()
        Me.ribAtual.Visible = False

    End Sub

    Private Sub btnAtual2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAtual2.ItemClick

        Me.txtBancoTransf.Focus()

        'For i As Integer = 0 To GridView2.DataRowCount - 1
        '    fExecutarText("Update [Vencto Cheques] Set Cheque = '" & GridView2.GetRowCellValue(i, "Cheque") & "' Where Id = " & GridView2.GetRowCellValue(i, "Id"))
        'Next

        Call btnAtual_Click(Nothing, Nothing)

    End Sub

    Private Sub ckNavegar_CheckedChanged(sender As Object, e As EventArgs) Handles ckNavegar.CheckedChanged

        Me.dnConsertos.Visible = ckNavegar.Checked

        If ckNavegar.Checked Then
            Me.VENDASBindingSource.RemoveFilter()
            Me.VENDASBindingSource.Position = Me.VENDASBindingSource.Find("Id", varIdVenda)
        Else
            Me.VENDASBindingSource.Filter = "Id = " & varIdVenda
        End If

        Me.ribbonPageGroup1.Visible = True
        Me.RibbonPageGroup2.Visible = False
        Me.RibbonPageGroup4.Visible = True
        Me.ribAtual.Visible = True
        Me.ControlBox = True
        Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

    End Sub

    Private Sub txtDeb_TextChanged(sender As Object, e As EventArgs) Handles txtDeb.TextChanged
        Call botoes2()

    End Sub

    Private Sub VENDASBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles VENDASBindingSource.CurrentChanged
        On Error Resume Next

        If Me.Tag <> "1" Then Exit Sub

        'varFlag = True

        Me.ribbonPageGroup1.Visible = True
        Me.RibbonPageGroup2.Visible = False
        Me.RibbonPageGroup4.Visible = True
        Me.ControlBox = True
        Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.RibbonPageGroup3.Visible = (XtraTabControl1.SelectedTabPage.Text = "FORMA DE PAGAMENTO")
        Me.ribAtual.Visible = (XtraTabControl1.SelectedTabPage.Text = "FORMA DE PAGAMENTO")
        Me.txtCliente.Text = LookUpEdit1.Text
        Me.TextEdit3.Text = Me.txtVenda.Text & "   (R$ " & Me.txtValorFinal.Text & ")"
        varIdVenda = CLng(Me.IdTextEdit.Text)

    End Sub

    Private Sub TextEdit1_Validated(sender As Object, e As EventArgs) Handles TextEdit1.Validated

    End Sub

    Private Sub TextEdit1_Validating(sender As Object, e As CancelEventArgs) Handles TextEdit1.Validating

        If Me.Tag = "1" Then
            Try
                Dim varTot As Double = 0
                For i As Integer = 0 To GridView1.DataRowCount - 1
                    varTot = varTot + GridView1.GetRowCellValue(i, "PrVenda")
                Next i

                Me.txtValorFinal.Text = FormatNumber(ConvertToDouble(varTot) - ConvertToDouble(TextEdit1.Text) - ConvertToDouble(txtTroca.Text) - ConvertToDouble(txtDesconto.Text), 2)
                'calcula_total()

                Call botoes()

            Catch ex As Exception
                XtraMessageBox.Show(ex.Message)

            End Try

        End If

    End Sub

    Private Sub txtTroca_Validated(sender As Object, e As EventArgs) Handles txtTroca.Validated

    End Sub

    Private Sub txtTroca_Validating(sender As Object, e As CancelEventArgs) Handles txtTroca.Validating
        calcula_total()

        Call botoes()
    End Sub

    Private Sub txtDesconto_Validated(sender As Object, e As EventArgs) Handles txtDesconto.Validated

    End Sub

    Private Sub txtDesconto_Validating(sender As Object, e As CancelEventArgs) Handles txtDesconto.Validating
        calcula_total()

        Call botoes()
    End Sub

    Private Sub txtValorFinal_EditValueChanged(sender As Object, e As EventArgs) Handles txtValorFinal.EditValueChanged
        Call botoes()

    End Sub

    Private Sub txtData1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtNomeCDeb.ButtonClick
        If e.Button.Kind.ToString = "Delete" Then
            txtNomeCDeb.EditValue = DBNull.Value
        End If
    End Sub

    Private Sub txtNomeCartao2_TextChanged(sender As Object, e As EventArgs) Handles txtNomeCartao2.TextChanged
        botoes2()

    End Sub

    Private Sub txtFormaCartao2_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtFormaCartao2.SelectedValueChanged
        On Error Resume Next

        botoes2()

    End Sub

    Private Sub txtCCCartao2_CheckedChanged(sender As Object, e As EventArgs) Handles txtCCCartao2.CheckedChanged
        Call botoes()

    End Sub

    Private Sub txtAUT_EditValueChanged(sender As Object, e As EventArgs) Handles txtAUT.EditValueChanged
        Call botoes()

    End Sub

    Private Sub txtAut2_EditValueChanged(sender As Object, e As EventArgs) Handles txtAut2.EditValueChanged
        Call botoes()

    End Sub

    Private Sub txtAUTDeb_EditValueChanged(sender As Object, e As EventArgs) Handles txtAUTDeb.EditValueChanged
        Call botoes()

    End Sub
End Class
