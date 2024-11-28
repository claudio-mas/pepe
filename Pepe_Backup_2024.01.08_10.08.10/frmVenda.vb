Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab

Partial Public Class frmVenda
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DsCliente.Cartões'. Você pode movê-la ou removê-la conforme necessário.
        Me.CartõesTableAdapter.Fill(Me.DsCliente.Cartões)
        'TODO: esta linha de código carrega dados na tabela 'DsCliente.Vencto_Cartão'. Você pode movê-la ou removê-la conforme necessário.

        Me._1TabPeçasTableAdapter.Fill(Me.DsPrincipal._1TabPeças)
        Me.CboVendedorasTableAdapter.Fill(Me.DsPrincipal.cboVendedoras)
        Me.ClientesTableAdapter.Fill(Me.DsPrincipal.Clientes)
        Me.VENDASTableAdapter.Fill(Me.DsPrincipal.VENDAS, varIdVenda)
        Me.Vencto_CartãoTableAdapter.Fill(Me.DsCliente.Vencto_Cartão)

        If varIdVenda = 0 Then
            Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
            Me.ComboBoxEdit1.Focus()
            Me.Validate()
            Me.VENDASBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPrincipal)
            varIdVenda = CInt(Me.IdTextEdit.Text)
            Me.VenctoCartãoBindingSource.Filter = "Venda = 99999"
        Else
            Me.VenctoCartãoBindingSource.Filter = "Venda = " & varIdVenda
            Me.txtTransf.Text = FormatNumber(ConvertToDouble(DLookUp("ValorTransf", "Vendas", "Id = " & varIdVenda, 0)), 2)
            Me.txtBancoTransf.Text = DLookUp("BancoTransf", "Vendas", "Id = " & varIdVenda, 0)
            Me.txtDeb.Text = FormatNumber(ConvertToDouble(DLookUp("Deb", "Vendas", "Id = " & varIdVenda, 0)), 2)
            Dim x As String = DLookUp("NomeCDeb", "Vendas", "Id = " & varIdVenda, 0)
            Me.txtNomeCDeb.EditValue = x 'DLookUp("NomeCDeb", "Vendas", "Id = " & varIdVenda, 0)
            '    If LookUpEdit1.Properties.GetDisplayText(LookUpEdit1.EditValue) = "" And varNomeCli <> "" Then LookUpEdit1.SelectedText = varNomeCli
            '    If LookUpEdit2.Properties.GetDisplayText(LookUpEdit2.EditValue) = "" And varNomeMD <> "" Then LookUpEdit2.SelectedText = varNomeMD
        End If

        Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, varIdVenda)
        'Me.Vencto_CartãoTableAdapter.Fill(Me.DsPrincipal.Vencto_Cartão)
        Me.Vencto_ChequesTableAdapter.Fill(Me.DsPrincipal.Vencto_Cheques)


        Me.Tag = "1"

        If frmVendasDG.IsHandleCreated Then frmVendasDG.Visible = False
        If frmClientesDG.IsHandleCreated Then frmClientesDG.Visible = False
        If frmInconsist.IsHandleCreated Then frmInconsist.Visible = False

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        'Call btnSalvar_ItemClick(Nothing, Nothing)

        If frmVendasDG.IsHandleCreated Then frmVendasDG.VENDASdgTableAdapter.Fill(frmVendasDG.DsPrincipal.VENDASdg) : frmVendasDG.Visible = True
        If frmClientesDG.IsHandleCreated Then frmClientesDG.Visible = True
        If frmInconsist.IsHandleCreated Then
            frmInconsist.Inconsist4TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist4)
            frmInconsist.Inconsist5TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist5)
            frmInconsist.Inconsist2TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist2)
            frmInconsist.Inconsist1TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist1)
            frmInconsist.Visible = True
        End If

        varNomeCli = ""
        varNomeMD = ""

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovo.ItemClick
        'varIdCliente = 0
        'frmClientes.Show()
        Try
            'Dim varTot As Double = 0
            'For i As Integer = 0 To GridView1.DataRowCount - 1
            '    varTot = varTot + GridView1.GetRowCellValue(i, "ValorVenda")
            'Next i
            'Me.txtValorFinal.Text = FormatNumber(varTot - CDbl(TextEdit1.Text) - CDbl(txtTroca.Text) - CDbl(txtDesconto.Text), 2)

            'Me.Validate()
            'Me.VENDASBindingSource.EndEdit()
            'Me.TableAdapterManager.UpdateAll(Me.DsPrincipal)
            'Me.VendasDetBindingSource.EndEdit()
            'Me.FKVENDASVendasDetBindingSource.EndEdit()
            'Me.TableAdapterManager1.UpdateAll(Me.DsPrincipal)

            'fExecutarText("update [1TabPeças] set vendida=1, Comissão = b.Comissão FROM dbo.[1TabPeças] a INNER JOIN  dbo.[VENDAS DET] b ON a.IDPeça = b.Peça WHERE b.Venda = " & CInt(Me.IdTextEdit.Text))

            'frmVendasDG.VENDASdgTableAdapter.Fill(frmVendasDG.DsPrincipal.VENDASdg)

            Dim rs As New ADODB.Recordset()
            Dim cnStr As String = strAdoConnection()
            rs.Open("SELECT Max(Venda) AS V FROM VENDAS WHERE Venda Is Not Null GROUP BY Year([DataVenda]) HAVING Year([DataVenda])=Year(GetDate())", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            varNovaVenda = String.Format("{0,4:D4}", CInt(Microsoft.VisualBasic.Left(rs("V").Value, 4)) + 1) & "/" & Format(Date.Today, "yy")
            rs.Close()

            fExecutarText("Insert into VENDAS (DataVenda, Venda, Tipo) Values ('" & Format(Date.Today, "yyyy-MM-dd") & "', '" & varNovaVenda & "', 'Interna')")
            varIdVenda = DLookUp("Id", "SELECT TOP 1 Id FROM VENDAS ORDER BY Id DESC", "", 1)

            Me.VENDASTableAdapter.Fill(Me.DsPrincipal.VENDAS, varIdVenda)
            Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, varIdVenda)
            Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.Tag = "1"

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub VENDASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VENDASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPrincipal)

    End Sub

    Private Sub btnAbrirItem_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnAbrirItem.ButtonClick
        'varIdDet = GridView1.GetFocusedRowCellValue("Id")
        'varNomePeça = GridView1.GetFocusedRowCellValue("Modêlo")
        'frmVendaPeça.Show()
        Try
            If Not IsNothing(GridView1.GetFocusedRowCellValue("Peça")) Then
                Dim peça As String = DLookUp("Modêlo", "[1TabPeças]", "IDPeça = " & GridView1.GetFocusedRowCellValue("Peça"), 0)
                'If MsgBox("Confirma exclusão da peça " & peça, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!") = MsgBoxResult.Yes Then
                If XtraMessageBox.Show("Confirma exclusão da peça " & peça & " ?", "Atenção!", MessageBoxButtons.YesNo) = vbYes Then
                    fExecutarText("update [1TabPeças] set Vendida = 0, Comissão = 0 WHERE IDPeça = " & GridView1.GetFocusedRowCellValue("Peça"))
                    fExecutarText("delete from [VENDAS DET] WHERE Id = " & GridView1.GetFocusedRowCellValue("Id"))
                    Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, varIdVenda)
                    Me._1TabPeçasTableAdapter.Fill(Me.DsPrincipal._1TabPeças)
                End If
                Dim varTot As Double = 0
                For i As Integer = 0 To GridView1.DataRowCount - 1
                    varTot = varTot + GridView1.GetRowCellValue(i, "ValorVenda")
                Next i
                'Me.txtValorFinal.Text = FormatNumber(varTot - CDbl(TextEdit1.Text) - CDbl(txtTroca.Text) - CDbl(txtDesconto.Text), 2)
                Me.txtValorFinal.Text = FormatNumber(ConvertToDouble(varTot) - ConvertToDouble(TextEdit1.Text) - ConvertToDouble(txtTroca.Text) - ConvertToDouble(txtDesconto.Text), 2)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        'If GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns("Modêlo")).ToString() = "" Then
        'MsgBox(cboRef.GetDataSourceValue("Modêlo", 0).ToString)
        'End If
        'Dim varTot As Double = 0
        'For i As Integer = 0 To GridView1.DataRowCount - 1
        '    varTot = varTot + IIf(IsDBNull(GridView1.GetRowCellValue(i, "ValorVenda")), 0, GridView1.GetRowCellValue(i, "ValorVenda"))
        'Next i

        'Me.txtValorFinal.Text = FormatNumber(varTot - CDbl(TextEdit1.Text) - CDbl(txtTroca.Text) - CDbl(txtDesconto.Text), 2)
        Call botoes()

    End Sub
    Private Sub GridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated

        'Dim varTot As Double = 0
        ''For i As Integer = 0 To GridView1.DataRowCount - 1
        ''    varTot = varTot + GridView1.GetRowCellValue(i, "ValorVenda")
        ''Next i
        'varTot = IIf(DLookUp("Tot", "SELECT Sum(ValorVenda) AS Tot FROM [VENDAS DET] WHERE Venda=" & CInt(Me.IdTextEdit.Text), "", 1) = "", 0, DLookUp("Tot", "SELECT Sum(ValorVenda) AS Tot FROM [VENDAS DET] WHERE Venda=" & CInt(Me.IdTextEdit.Text), "", 1))

        'Me.txtValorFinal.Text = varTot - Val(TextEdit1.Text) - Val(txtTroca.Text) - Val(txtDesconto.Text)

        Call botoes()

    End Sub
    Private Sub cboRef_CVC(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles cboRef.EditValueChanging
        'MsgBox(cboRef.GetDataSourceRowByKeyValue(1).ToString)
        'If e.NewValue = "" Then Exit Sub

        Me.cboRef.Tag = e.NewValue

        'Call botoes()
        'Dim peça As String = DLookUp("Modêlo", "[1TabPeças]", "IDPeça = " & e.NewValue, 0)
        'If peça = "" Then Exit Sub

        'If (cboRef.GetDataSourceValue("Vendida", cboRef.GetDataSourceRowIndex("Modêlo", peça))) Then
        '    MsgBox("Peça já vendida, a venda será cancelada", MsgBoxStyle.Critical, "Pepe Torras")
        '    e.Cancel = True
        'Else
        '    Call botoes()
        'End If

    End Sub
    Private Sub cboRef_CVC2(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboRef.Validating

        'Dim peça As String = DLookUp("Modêlo", "[1TabPeças]", "IDPeça = " & CInt(Me.cboRef.Tag), 0)
        'If peça = "" Then Exit Sub

        Try
            Me.GridView1.SetFocusedRowCellValue("txtValorVenda", cboRef.GetDataSourceValue("Vendida", cboRef.GetDataSourceRowIndex("IDPeça", CInt(Me.cboRef.Tag))))

        Catch ex As Exception

        Finally
            Me.TabPeçasBindingSource.RemoveFilter()

        End Try



        'Me.TabPeçasBindingSource.MoveFirst()

        'Call botoes()

        'If (cboRef.GetDataSourceValue("Vendida", cboRef.GetDataSourceRowIndex("IDPeça", CInt(Me.cboRef.Tag)))) Then
        '    MsgBox("Peça já vendida, por favor verifique", MsgBoxStyle.Critical, "Pepe Torras Design")
        '    e.Cancel = True
        '    'GridView1.CancelUpdateCurrentRow()
        '    SendKeys.Send("{ESC}")
        '    SendKeys.Send("{ESC}")
        '    'Me.ribbonPageGroup1.Visible = True
        '    'Me.RibbonPageGroup2.Visible = False
        '    'Me.ControlBox = True
        'Else
        '    Call botoes()
        '    'fExecutarText("update [1TabPeças] set Vendida = 1 WHERE IDPeça = " & GridView1.GetFocusedRowCellValue("Peça"))
        'End If

    End Sub
    Private Sub botoes()
        If Me.Tag = "1" Then
            Me.ribbonPageGroup1.Visible = False
            Me.RibbonPageGroup2.Visible = True
            Me.RibbonPageGroup4.Visible = False
            Me.ribAtual.Visible = False
            Me.ControlBox = False
            Me.Timer.Enabled = True
        End If

    End Sub

    Private Sub DataVendaDateEdit_TextChanged(sender As Object, e As EventArgs) Handles txtDataVenda.TextChanged
        Call botoes()

    End Sub

    Private Sub ComboBoxEdit1_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.TextChanged
        Call botoes()

    End Sub

    Private Sub LookUpEdit1_TextChanged(sender As Object, e As EventArgs) Handles LookUpEdit1.TextChanged
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

        If Me.Tag = "1" Then
            Try
                Dim varTot As Double = 0
                For i As Integer = 0 To GridView1.DataRowCount - 1
                    varTot = varTot + GridView1.GetRowCellValue(i, "ValorVenda")
                Next i

                'Me.txtValorFinal.Text = FormatNumber(varTot - CDbl(TextEdit1.Text) - CDbl(txtTroca.Text) - CDbl(txtDesconto.Text), 2)
                Me.txtValorFinal.Text = FormatNumber(ConvertToDouble(varTot) - ConvertToDouble(TextEdit1.Text) - ConvertToDouble(txtTroca.Text) - ConvertToDouble(txtDesconto.Text), 2)

                Call botoes()

            Catch ex As Exception
                XtraMessageBox.Show(ex.Message)

            End Try

        End If

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
            calcula_total()
            Call botoes()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtDesconto_TextChanged(sender As Object, e As EventArgs) Handles txtDesconto.TextChanged
        Try
            calcula_total()

            Call botoes()

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

        'Try
        'calcula_total()
        Me.txtBancoTransf.Focus()

            'If Not Me.DestinoTextEdit.EditValue Is DBNull.Value Then
            '    If Me.DestinoTextEdit.EditValue = "" Then Me.DestinoTextEdit.EditValue = DBNull.Value
            'End If

            Me.Validate()
            Me.VENDASBindingSource.EndEdit()
            'Me.VendasDetBindingSource.EndEdit()
            'Me.FKVENDASVendasDetBindingSource.EndEdit()
            Me.Vencto_ChequesBindingSource.EndEdit()
            Me.VenctoCartãoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPrincipal)

            'Call btnAtual_Click(Nothing, Nothing)

            varIdVenda = CInt(Me.IdTextEdit.Text)

            fExecutarText("Update Vendas set ValorTransf = " & Replace(Replace(ConvertToDouble(Me.txtTransf.Text), ".", ""), ",", ".") & " Where Id = " & varIdVenda & "; Update Vendas set BancoTransf = '" & Me.txtBancoTransf.Text & "' Where Id = " & varIdVenda & "; Update Vendas set Deb = " & Replace(Replace(ConvertToDouble(Me.txtDeb.Text), ".", ""), ",", ".") & " Where Id = " & varIdVenda & "; Update Vendas set NomeCDeb = '" & Me.txtNomeCDeb.Text & "' Where Id = " & varIdVenda)

            fExecutarText("update [1TabPeças] set vendida=1, Comissão = b.Comissão FROM dbo.[1TabPeças] a INNER JOIN  dbo.[VENDAS DET] b ON a.IDPeça = b.Peça WHERE b.Venda = " & CInt(Me.IdTextEdit.Text))
            Me._1TabPeçasTableAdapter.Fill(Me.DsPrincipal._1TabPeças)

            fExecutarText("update vendas SET peças=dbo.fPeças(Id) where Id = " & CInt(Me.IdTextEdit.Text))
            If frmVendasDG.IsHandleCreated Then
                frmVendasDG.VENDASdgTableAdapter.Fill(frmVendasDG.DsPrincipal.VENDASdg)
            End If
            If frmInconsist.IsHandleCreated Then
                frmInconsist.Inconsist2TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist2)
            End If

            Me.VENDASTableAdapter.Fill(Me.DsPrincipal.VENDAS, varIdVenda)
            Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, varIdVenda)

        'Catch ex As Exception
        '    MsgBox(ex.Message)

        'Finally
        Me.ribbonPageGroup1.Visible = True
        Me.RibbonPageGroup2.Visible = False
        Me.RibbonPageGroup4.Visible = True
        Me.ribAtual.Visible = True
        Me.ControlBox = True
        Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.Timer.Enabled = False
        Me.btnAtual.ForeColor = Color.Red

        'End Try

    End Sub

    'Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, New System.Nullable(Of Integer)(CType(IdVToolStripTextBox.Text, Integer)))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub btnCancelarVenda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelarVenda.ItemClick

        Try
            If XtraMessageBox.Show("Confirma cancelamento da venda " & Me.txtVenda.Text & " ?", "Atenção!", MessageBoxButtons.YesNo) = vbYes Then
                'If MsgBox("Confirma cancelamento da venda " & Me.VendaTextEdit.Text & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!") = vbYes Then
                fExecutarText("update [1TabPeças] set vendida=0, Comissão=0 FROM dbo.[1TabPeças] a INNER JOIN  dbo.[VENDAS DET] b ON a.IDPeça = b.Peça WHERE b.Venda = " & CInt(Me.IdTextEdit.Text))
                fExecutarText("delete from VENDAS WHERE Id = " & CInt(Me.IdTextEdit.Text))
                'frmVendasDG.VENDASdgTableAdapter.Fill(frmVendasDG.DsPrincipal.VENDASdg)
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

        Me.Timer.Enabled = False
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
                Me.VENDASTableAdapter.Fill(Me.DsPrincipal.VENDAS, varIdVenda)
                Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, varIdVenda)
                Me.txtTransf.Text = FormatNumber(ConvertToDouble(DLookUp("ValorTransf", "Vendas", "Id = " & varIdVenda, 0)), 2)
                Me.txtBancoTransf.Text = DLookUp("BancoTransf", "Vendas", "Id = " & varIdVenda, 0)
                Me.txtDeb.Text = DLookUp("Deb", "Vendas", "Id = " & varIdVenda, 0)
                Me.txtNomeCDeb.Text = DLookUp("NomeCDeb", "Vendas", "Id = " & varIdVenda, 0)
            End If

            'frmVendasDG.VENDASdgTableAdapter.Fill(frmVendasDG.DsPrincipal.VENDASdg)
            If frmVendasDG.IsHandleCreated Then
                frmVendasDG.VENDASdgTableAdapter.Fill(frmVendasDG.DsPrincipal.VENDASdg)
            End If
            If frmInconsist.IsHandleCreated Then
                frmInconsist.Inconsist2TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist2)
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)

        Finally
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.RibbonPageGroup4.Visible = True
            Me.ribAtual.Visible = True
            Me.ControlBox = True
            Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.Timer.Enabled = False
            Me.btnAtual.ForeColor = Color.Red
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(LookUpEdit1.EditValue.ToString)
        MsgBox(LookUpEdit1.Properties.GetDisplayText(LookUpEdit1.EditValue))

    End Sub

    Private Sub MDCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles MDCheckEdit.CheckedChanged
        Call botoes()

    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        On Error Resume Next

        Me.RibbonPageGroup3.Visible = (XtraTabControl1.SelectedTabPage.Text = "FORMA DE PAGAMENTO")
        Me.Tag = "1"
        Me.txtCliente.Text = LookUpEdit1.Text
        Me.TextEdit3.Text = Me.txtVenda.Text & "   (R$ " & Me.txtValorFinal.Text & ")"
        If IdTextEdit.Text = "-1" Then
            Me.Validate()
            Me.VENDASBindingSource.EndEdit()
            Me.VendasDetBindingSource.EndEdit()
            Me.FKVENDASVendasDetBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPrincipal)
        End If

    End Sub

    Private Sub ckDolarCC_CheckedChanged(sender As Object, e As EventArgs) Handles ckDolarCC.CheckedChanged

        Try
            'fExecutarText("DELETE FROM [Conta Corrente] WHERE Venda=123")
            'call AtualizaCC2
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

            'If Me!CartãoCC Then
            '    tb.AddNew()
            '    tb!Venda = Me!Venda
            '    tb!Cliente = Me!IDCliente
            '    tb!Data = Me!DataVenda
            '    tb!Valor = Me!Cartão * -1
            '    tb.Update()
            'End If

            'If Me!DolarCC Then
            '    tb.AddNew()
            '    tb!Venda = Me!Venda
            '    tb!Cliente = Me!IDCliente
            '    tb!Data = Me!DataVenda
            '    tb!Valor = Me!Dolar * -1
            '    tb.Update()
            'End If

            'If Me!CashCC Then
            '    tb.AddNew()
            '    tb!Venda = Me!Venda
            '    tb!Cliente = Me!IDCliente
            '    tb!Data = Me!DataVenda
            '    tb!Valor = Me!Real * -1
            '    tb!Real = Me!Real * -1
            '    tb.Update()
            'End If

            'If Me!OuroCC Then
            '    tb.AddNew()
            '    tb!Venda = Me!Venda
            '    tb!Cliente = Me!IDCliente
            '    tb!Data = Me!DataVenda
            '    tb!Valor = Me!Ouro * -1
            '    tb!Ouro = Me!Ouro * -1
            '    tb.Update()
            'End If

            'If Me!CCDeb <> 0 And Not IsNull(Me!CCDeb) Then
            '    tb.AddNew()
            '    tb!Venda = Me!Venda
            '    tb!Cliente = Me!IDCliente
            '    tb!Data = Me!DataVenda
            '    tb!Valor = Me!CCDeb
            '    tb!CCDeb = Me!CCDeb
            '    tb.Update()
            'End If

            'tb.Close()
            'db = Nothing

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        'MsgBox(GridView1.GetFocusedRowCellValue("Id"))
        'If GridView1.GetFocusedRowCellValue("Id") Is Nothing Then
        '    Me.TabPeçasBindingSource.Filter = "Vendida=0"
        'Else
        '    Me.TabPeçasBindingSource.RemoveFilter()
        'End If
    End Sub

    Private Sub cboRef_Popup(sender As Object, e As EventArgs) Handles cboRef.PopupFilter
        'If GridView1.GetFocusedRowCellValue("Id") Is Nothing Then
        Me.TabPeçasBindingSource.Filter = "(Vendida = 0 Or Vendida Is Null) And Modêlo IS NOT NULL"
        'Else
        '    Me.TabPeçasBindingSource.RemoveFilter()
        '    Me.TabPeçasBindingSource.Filter = "Modêlo IS NOT NULL"
        'End If
        'Me.TabPeçasBindingSource.MoveFirst()

    End Sub

    Private Sub GridView1_EditFormPrepared(sender As Object, e As EditFormPreparedEventArgs) Handles GridView1.EditFormPrepared

        TryCast(e.Panel.Parent, Form).StartPosition = FormStartPosition.CenterScreen
        'Me.TabPeçasBindingSource.Filter = "Vendida=0 And Modêlo IS NOT NULL"
        'SendKeys.Send(Keys.Tab)
        'SendKeys.Send(Keys.Escape)
        'SendKeys.Send(Keys.F5)

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
                    varTot += ConvertToDouble(GridView1.GetRowCellValue(i, "ValorVenda"))
                    varCom += ConvertToDouble(GridView1.GetRowCellValue(i, "Comissão"))
                Next i
                'Me.TextEdit2.Text = FormatNumber(varCom, 2)
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

        For Each control As Control In e.EditForm.Controls
            SetFont(control)
        Next control

    End Sub

    Private Sub parcelamento()
        On Error Resume Next

        If Me.Tag <> "1" Then Exit Sub
        If IsDBNull(Me.ChequeSpinEdit.EditValue) Or Me.FormaChequeComboBoxEdit.Text = "" Then Exit Sub


        'Me.Validate()
        'Me.VENDASBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.DsPrincipal)

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

        Me.Vencto_ChequesTableAdapter.Fill(Me.DsPrincipal.Vencto_Cheques)
        'Me.ribDel.Visible = True

        Call conta_corrente()

    End Sub

    Private Sub conta_corrente()

        'If Me.ChequeSpinEdit.EditValue Is DBNull.Value Then Exit Sub

        fExecutarText("Delete From [Conta Corrente] Where Venda = '" & Me.txtVenda.Text & "'")

        Dim x As Integer = LookUpEdit1.GetColumnValue("IDCliente")

        If Me.ckChequeCC.Checked And ConvertToDouble(Me.ChequeSpinEdit.EditValue) > 0 Then
            'fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [IdConserto], [Cheque], [ChequeCC], [Valor]) VALUES ('" & x & "', '" & DataDateEdit.Text & "', " & IDTextEdit.Text & ", " & Me.ChequeSpinEdit.EditValue & ", " & 1 & ", " & Me.ChequeSpinEdit.EditValue * -1 & ");")
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [Venda], [ChequeCC], [Valor]) VALUES ('" & x & "', '" & txtDataVenda.Text & "', '" & txtVenda.Text & "', " & 1 & ", " & Me.ChequeSpinEdit.EditValue * -1 & ");")
        End If

        If Me.txtCCCartao.Checked And Me.txtValorCartao.Text <> "" Then
            fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [Venda], [CartãoCC], [Valor]) VALUES ('" & x & "', '" & txtDataVenda.Text & "', '" & txtVenda.Text & "', " & 1 & ", " & Me.txtValorCartao.EditValue * -1 & ");")
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

        'If Me.txtDebCC.Text <> "" Then
        '    fExecutarText("INSERT INTO [dbo].[Conta Corrente] ([Cliente], [Data], [IdConserto], [CCDeb], [Valor]) VALUES ('" & x & "', '" & DataDateEdit.Text & "', " & IdTextEdit.Text & ", " & Me.txtDebCC.EditValue & ", " & Me.txtDebCC.EditValue & ");")
        'End If

    End Sub

    Private Sub txtValorCartao_EditValueChanged(sender As Object, e As EventArgs) Handles txtValorCartao.EditValueChanged
        On Error Resume Next

        'If txtValorCartao.OldEditValue <> txtValorCartao.OldEditValue Then
        '    RemoveHandler txtValorCartao.EditValueChanged, AddressOf txtValorCartao_EditValueChanged
        '    Call parcela_cartao()
        '    'calcula_total()
        '    AddHandler txtValorCartao.EditValueChanged, AddressOf txtValorCartao_EditValueChanged
        'End If
        botoes()

    End Sub

    Private Sub parcela_cartao()
        On Error Resume Next

        If Me.Tag <> "1" Then Exit Sub
        If IsDBNull(Me.txtValorCartao.EditValue) Or Me.txtFormaCartao.Text = "" Or Me.txtNomeCartao.Text = "" Then
            Exit Sub
        End If

        Me.Tag = "0"
        Me.Validate()
        Me.VENDASBindingSource.EndEdit()
        Me.VendasDetBindingSource.EndEdit()
        Me.FKVENDASVendasDetBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPrincipal)
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


            'parcela = (Val(txtValorCartao.Text) - (Val(txtValorCartao.Text) * Val(txtNomeCartao.GetColumnValue("Perc")) / 100)) / j
            parcela = (CDbl(txtValorCartao.Text) - (CDbl(txtValorCartao.Text)) * txtNomeCartao.GetColumnValue("Perc") / 100) / j

            If IsDBNull(Me.txtValorCartao.EditValue) Or Me.txtFormaCartao.Text = "" Or Me.txtNomeCartao.Text = "" Then
                Exit Sub
            End If

            fExecutarText("INSERT INTO [dbo].[Vencto Cartão] ([Parcela], [Vencto], [VValor], [Venda], [NomeCartão]) VALUES ('" & CStr(i) & "/" & j & "', '" & data & "', " & Replace(parcela, ",", ".") & ", " & Me.IdTextEdit.Text & ", '" & Me.txtNomeCartao.Text & "');")

        Next i

        'Me.Vencto_CartãoTableAdapter.Fill(Me.DsPrincipal.Vencto_Cartão)
        Me.Vencto_CartãoTableAdapter.Fill(Me.DsCliente.Vencto_Cartão)
        Me.VenctoCartãoBindingSource.Filter = "Venda = " & varIdVenda

        Call conta_corrente()

    End Sub

    Private Sub calcula_total()
        If Me.Tag = "1" Then

            Dim varTot As Double = 0
            For i As Integer = 0 To GridView1.DataRowCount - 1
                varTot = varTot + GridView1.GetRowCellValue(i, "ValorVenda")
            Next i

            Me.txtValorFinal.Text = FormatNumber(ConvertToDouble(varTot) - ConvertToDouble(TextEdit1.Text) - ConvertToDouble(txtTroca.Text) - ConvertToDouble(txtDesconto.Text), 2)

        End If

    End Sub

    Private Sub ChequeSpinEdit_EditValueChanged(sender As Object, e As EventArgs) Handles ChequeSpinEdit.EditValueChanged
        On Error Resume Next

        'If ChequeSpinEdit.EditValue <> ChequeSpinEdit.OldEditValue Then
        '    RemoveHandler ChequeSpinEdit.EditValueChanged, AddressOf ChequeSpinEdit_EditValueChanged
        '    Call parcelamento()
        '    AddHandler ChequeSpinEdit.EditValueChanged, AddressOf ChequeSpinEdit_EditValueChanged
        'End If

        botoes()

    End Sub

    Private Sub FormaChequeComboBoxEdit_SelectedValueChanged(sender As Object, e As EventArgs) Handles FormaChequeComboBoxEdit.SelectedValueChanged
        On Error Resume Next

        'If FormaChequeComboBoxEdit.EditValue <> FormaChequeComboBoxEdit.OldEditValue Then
        '    RemoveHandler FormaChequeComboBoxEdit.SelectedValueChanged, AddressOf FormaChequeComboBoxEdit_SelectedValueChanged
        '    Call parcelamento()
        '    AddHandler FormaChequeComboBoxEdit.SelectedValueChanged, AddressOf FormaChequeComboBoxEdit_SelectedValueChanged
        'End If
        botoes()

    End Sub

    Private Sub BancoTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles BancoTextEdit.EditValueChanged
        On Error Resume Next

        'If BancoTextEdit.EditValue <> BancoTextEdit.OldEditValue Then
        '    RemoveHandler BancoTextEdit.EditValueChanged, AddressOf BancoTextEdit_EditValueChanged
        '    Call parcelamento()
        '    AddHandler BancoTextEdit.EditValueChanged, AddressOf BancoTextEdit_EditValueChanged
        'End If
        botoes()

    End Sub

    Private Sub txtFormaCartao_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtFormaCartao.SelectedValueChanged
        On Error Resume Next

        'If txtFormaCartao.OldEditValue <> txtFormaCartao.EditValue Then
        '    RemoveHandler txtFormaCartao.SelectedValueChanged, AddressOf txtFormaCartao_SelectedValueChanged
        '    Call parcela_cartao()
        '    AddHandler txtFormaCartao.SelectedValueChanged, AddressOf txtFormaCartao_SelectedValueChanged
        'End If
        botoes()

    End Sub

    Private Sub txtNomeCartao_EditValueChanged(sender As Object, e As EventArgs) Handles txtNomeCartao.EditValueChanged
        'On Error Resume Next

        'If txtNomeCartao.EditValue <> txtNomeCartao.OldEditValue Then
        '    RemoveHandler txtNomeCartao.EditValueChanged, AddressOf txtNomeCartao_EditValueChanged
        'Call parcela_cartao()
        '    AddHandler txtNomeCartao.EditValueChanged, AddressOf txtNomeCartao_EditValueChanged
        'botoes()
        'End If

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
            fExecutarText("Delete From [Vencto Cartão] Where Venda =" & varIdVenda)
            Me.Vencto_CartãoTableAdapter.Fill(Me.DsCliente.Vencto_Cartão)
        End If

    End Sub

    Private Sub GroupControlCHEQUES_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles GroupControlCHEQUES.CustomButtonClick

        If XtraMessageBox.Show("Confirma exclusão dos dados de pagamento com cheque(s)?", "Atenção!", MessageBoxButtons.YesNo) = vbYes Then
            Me.ChequeSpinEdit.EditValue = 0
            Me.FormaChequeComboBoxEdit.EditValue = DBNull.Value
            Me.BancoTextEdit.Text = ""
            fExecutarText("Delete From [Vencto Cheques] Where Venda =" & varIdVenda)
            Me.Vencto_ChequesTableAdapter.Fill(Me.DsPrincipal.Vencto_Cheques)
        End If

    End Sub

    Private Sub txtNomeCartao_TextChanged(sender As Object, e As EventArgs) Handles txtNomeCartao.TextChanged

        'If Me.Tag = "1" Then Call parcela_cartao()
        'CartõesBindingSource.RemoveFilter()
        botoes()

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        'Try
        '    Me.VENDASTableAdapter1.Fill(Me.DsNovo.VENDAS, CType(IdVToolStripTextBox.Text, Integer))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub btnAtual_Click(sender As Object, e As EventArgs) Handles btnAtual.Click
        On Error Resume Next

        'Try
        'Call calcula_total()

        Me.Validate()
            Me.VENDASBindingSource.EndEdit()
            Me.Vencto_ChequesBindingSource.EndEdit()
            Me.VenctoCartãoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPrincipal)
            'Me.TableAdapterManager1.UpdateAll(Me.DsPrincipal)

            fExecutarText("Update Vendas set ValorTransf = " & Replace(Replace(ConvertToDouble(Me.txtTransf.Text), ".", ""), ",", ".") & " Where Id = " & varIdVenda & "; Update Vendas set BancoTransf = '" & Me.txtBancoTransf.Text & "' Where Id = " & varIdVenda & "; Update Vendas set Deb = " & Replace(Replace(ConvertToDouble(Me.txtDeb.Text), ".", ""), ",", ".") & " Where Id = " & varIdVenda & "; Update Vendas set NomeCDeb = '" & Me.txtNomeCDeb.Text & "' Where Id = " & varIdVenda)

            Call parcela_cartao()

            If txtNomeCDeb.Text <> "" And ConvertToDouble(txtDeb.Text) > 0 Then
                fExecutarText("Delete From [Vencto Cartão] Where Venda = " & Me.IdTextEdit.Text & " And Deb = 1")
                Dim parcela As Double = (ConvertToDouble(txtDeb.Text) - (ConvertToDouble(txtDeb.Text)) * txtNomeCDeb.GetColumnValue("Perc") / 100)
                fExecutarText("Insert Into [Vencto Cartão] (Venda, Vencto, VValor, Pagto, Parcela, NomeCartão, Deb) Values (" & Me.IdTextEdit.Text & ", '" & Me.txtDataVenda.Text & "', " & Replace(Replace(parcela, ".", ""), ",", ".") & ", '" & Me.txtDataVenda.Text & "', '1/1', '" & Me.txtNomeCDeb.Text & "', 1)")
                Me.Vencto_CartãoTableAdapter.Fill(Me.DsCliente.Vencto_Cartão)
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
        Me.Timer.Enabled = False
            Me.btnAtual.ForeColor = Color.Red
            txtValorCartao.Focus()
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.RibbonPageGroup4.Visible = True
            Me.ControlBox = True
            Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        'End Try


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

    Private Sub txtNomeCDeb_PopupFilter(sender As Object, e As PopupFilterEventArgs) Handles txtNomeCDeb.PopupFilter
        'CartõesBindingSource.Filter = "Ncartao Like '%Débito'"

    End Sub

    Private Sub txtNomeCDeb_TextChanged(sender As Object, e As EventArgs) Handles txtNomeCDeb.TextChanged
        botoes()
        'CartõesBindingSource.RemoveFilter()

    End Sub

    Private Sub GridView2_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanging
        Call botoes()
        Me.ribAtual.Visible = False

    End Sub

    Private Sub btnAtual2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAtual2.ItemClick

        Me.txtBancoTransf.Focus()

        For i As Integer = 0 To GridView2.DataRowCount - 1
            fExecutarText("Update [Vencto Cheques] Set Cheque = '" & GridView2.GetRowCellValue(i, "Cheque") & "' Where Id = " & GridView2.GetRowCellValue(i, "Id"))
        Next

        Call btnAtual_Click(Nothing, Nothing)

    End Sub

    Private Sub ckNavegar_CheckedChanged(sender As Object, e As EventArgs) Handles ckNavegar.CheckedChanged

        If Me.btnEsq.Tag <> "1" Then
            Me.btnEsq.Tag = varIdVenda
        End If

        'Me.dnConsertos.Visible = ckNavegar.Checked

        If ckNavegar.Checked Then
            'Me.VENDASBindingSource.RemoveFilter()
            'Me.VENDASBindingSource.Position = Me.VENDASBindingSource.Find("Id", varIdVenda)
            Me.btnEsq.Visible = True
            Me.btnDir.Visible = True
        Else
            Me.VENDASTableAdapter.Fill(Me.DsPrincipal.VENDAS, CInt(Me.btnEsq.Tag))
            Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, CInt(Me.btnEsq.Tag))
            Me.Vencto_ChequesTableAdapter.Fill(Me.DsPrincipal.Vencto_Cheques)
            Me.VenctoCartãoBindingSource.Filter = "Venda = " & CInt(Me.btnEsq.Tag)
            varIdVenda = CInt(Me.btnEsq.Tag)
            Me.btnEsq.Visible = False
            Me.btnDir.Visible = False
        End If

        Me.ribbonPageGroup1.Visible = True
        Me.RibbonPageGroup2.Visible = False
        Me.RibbonPageGroup4.Visible = True
        Me.ribAtual.Visible = True
        Me.ControlBox = True
        Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

    End Sub

    Private Sub btnEsq_Click(sender As Object, e As EventArgs) Handles btnEsq.Click

        varIdVenda -= 1
        Me.VENDASTableAdapter.Fill(Me.DsPrincipal.VENDAS, varIdVenda)
        Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, varIdVenda)
        Me.Vencto_ChequesTableAdapter.Fill(Me.DsPrincipal.Vencto_Cheques)
        Me.VenctoCartãoBindingSource.Filter = "Venda = " & varIdVenda

        Me.ribbonPageGroup1.Visible = True
        Me.RibbonPageGroup2.Visible = False
        Me.RibbonPageGroup4.Visible = True
        Me.ribAtual.Visible = True
        Me.ControlBox = True
        Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        Me.txtCliente.Text = LookUpEdit1.Text
        Me.TextEdit3.Text = Me.txtVenda.Text & "   (R$ " & Me.txtValorFinal.Text & ")"

    End Sub

    Private Sub btnDir_Click(sender As Object, e As EventArgs) Handles btnDir.Click

        varIdVenda += 1
        Me.VENDASTableAdapter.Fill(Me.DsPrincipal.VENDAS, varIdVenda)
        Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, varIdVenda)
        Me.Vencto_ChequesTableAdapter.Fill(Me.DsPrincipal.Vencto_Cheques)
        Me.VenctoCartãoBindingSource.Filter = "Venda = " & varIdVenda

        Me.ribbonPageGroup1.Visible = True
        Me.RibbonPageGroup2.Visible = False
        Me.RibbonPageGroup4.Visible = True
        Me.ribAtual.Visible = True
        Me.ControlBox = True
        Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        Me.txtCliente.Text = LookUpEdit1.Text
        Me.TextEdit3.Text = Me.txtVenda.Text & "   (R$ " & Me.txtValorFinal.Text & ")"

    End Sub
End Class
