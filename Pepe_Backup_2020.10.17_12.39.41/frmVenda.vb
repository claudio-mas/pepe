Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base


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

        'TODO: esta linha de código carrega dados na tabela 'DsPrincipal._1TabPeças'. Você pode movê-la ou removê-la conforme necessário.
        Me._1TabPeçasTableAdapter.Fill(Me.DsPrincipal._1TabPeças)

        'TODO: esta linha de código carrega dados na tabela 'DsPrincipal.cboVendedoras'. Você pode movê-la ou removê-la conforme necessário.
        Me.CboVendedorasTableAdapter.Fill(Me.DsPrincipal.cboVendedoras)

        'TODO: esta linha de código carrega dados na tabela 'DsPrincipal.Clientes'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClientesTableAdapter.Fill(Me.DsPrincipal.Clientes)

        'TODO: esta linha de código carrega dados na tabela 'DsPrincipal.VENDAS'. Você pode movê-la ou removê-la conforme necessário.
        Me.VENDASTableAdapter.Fill(Me.DsPrincipal.VENDAS, varIdVenda)

        'TODO: esta linha de código carrega dados na tabela 'DsPrincipal.VendasDet'. Você pode movê-la ou removê-la conforme necessário.
        Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, varIdVenda)

        'TODO: esta linha de código carrega dados na tabela 'DsPrincipal.Vencto_Cheques'. Você pode movê-la ou removê-la conforme necessário.
        Me.Vencto_ChequesTableAdapter.Fill(Me.DsPrincipal.Vencto_Cheques)

        If varIdVenda = 0 Then
            Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'Else
            '    If LookUpEdit1.Properties.GetDisplayText(LookUpEdit1.EditValue) = "" And varNomeCli <> "" Then LookUpEdit1.SelectedText = varNomeCli
            '    If LookUpEdit2.Properties.GetDisplayText(LookUpEdit2.EditValue) = "" And varNomeMD <> "" Then LookUpEdit2.SelectedText = varNomeMD
        End If

        Me.Tag = "1"

        If frmVendasDG.IsHandleCreated Then frmVendasDG.Visible = False
        If frmClientesDG.IsHandleCreated Then frmClientesDG.Visible = False

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If frmVendasDG.IsHandleCreated Then frmVendasDG.Visible = True
        If frmClientesDG.IsHandleCreated Then frmClientesDG.Visible = True
        varNomeCli = ""
        varNomeMD = ""

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnAbrir_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        'varIdCliente = GridView1.GetFocusedRowCellValue("IDCliente")
        frmClientes.Show()

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
                If MsgBox("Confirma exclusão da peça " & peça, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!") = MsgBoxResult.Yes Then
                    fExecutarText("update [1TabPeças] set Vendida = 0, Comissão = 0 WHERE IDPeça = " & GridView1.GetFocusedRowCellValue("Peça"))
                    fExecutarText("delete from [VENDAS DET] WHERE Id = " & GridView1.GetFocusedRowCellValue("Id"))
                    Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, varIdVenda)
                    Me._1TabPeçasTableAdapter.Fill(Me.DsPrincipal._1TabPeças)
                End If
                Dim varTot As Double = 0
                For i As Integer = 0 To GridView1.DataRowCount - 1
                    varTot = varTot + GridView1.GetRowCellValue(i, "ValorVenda")
                Next i
                Me.txtValorFinal.Text = FormatNumber(varTot - CDbl(TextEdit1.Text) - CDbl(txtTroca.Text) - CDbl(txtDesconto.Text), 2)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        'If GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns("Modêlo")).ToString() = "" Then
        'MsgBox(cboRef.GetDataSourceValue("Modêlo", 0).ToString)
        'End If
        Dim varTot As Double = 0
        For i As Integer = 0 To GridView1.DataRowCount - 1
            varTot = varTot + GridView1.GetRowCellValue(i, "ValorVenda")
        Next i

        Me.txtValorFinal.Text = FormatNumber(varTot - CDbl(TextEdit1.Text) - CDbl(txtTroca.Text) - CDbl(txtDesconto.Text), 2)
        Call botoes()

    End Sub
    Private Sub GridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated

        Dim varTot As Double = 0
        For i As Integer = 0 To GridView1.DataRowCount - 1
            varTot = varTot + GridView1.GetRowCellValue(i, "ValorVenda")
        Next i

        Me.txtValorFinal.Text = FormatNumber(varTot - CDbl(TextEdit1.Text) - CDbl(txtTroca.Text) - CDbl(txtDesconto.Text), 2)
        Call botoes()

    End Sub
    Private Sub cboRef_CVC(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles cboRef.EditValueChanging
        'MsgBox(cboRef.GetDataSourceRowByKeyValue(1).ToString)
        'If e.NewValue = "" Then Exit Sub

        Me.cboRef.Tag = e.NewValue
        Call botoes()
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

        If (cboRef.GetDataSourceValue("Vendida", cboRef.GetDataSourceRowIndex("IDPeça", CInt(Me.cboRef.Tag)))) Then
            MsgBox("Peça já vendida, a venda será cancelada", MsgBoxStyle.Critical, "Pepe Torras")
            e.Cancel = True
            'GridView1.CancelUpdateCurrentRow()
            SendKeys.Send("{ESC}")
            SendKeys.Send("{ESC}")
            'Me.ribbonPageGroup1.Visible = True
            'Me.RibbonPageGroup2.Visible = False
            'Me.ControlBox = True
        Else
            Call botoes()
            'fExecutarText("update [1TabPeças] set Vendida = 1 WHERE IDPeça = " & GridView1.GetFocusedRowCellValue("Peça"))
        End If

    End Sub
    Private Sub botoes()
        If Me.Tag = "1" Then
            Me.ribbonPageGroup1.Visible = False
            Me.RibbonPageGroup2.Visible = True
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
        Try
            Dim varTot As Double = 0
            For i As Integer = 0 To GridView1.DataRowCount - 1
                varTot = varTot + GridView1.GetRowCellValue(i, "ValorVenda")
            Next i

            Me.txtValorFinal.Text = FormatNumber(varTot - CDbl(TextEdit1.Text) - CDbl(txtTroca.Text) - CDbl(txtDesconto.Text), 2)

            Call botoes()

        Catch ex As Exception

        End Try

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
            Dim varTot As Double = 0
            For i As Integer = 0 To GridView1.DataRowCount - 1
                varTot = varTot + GridView1.GetRowCellValue(i, "ValorVenda")
            Next i

            Me.txtValorFinal.Text = FormatNumber(varTot - CDbl(TextEdit1.Text) - CDbl(txtTroca.Text) - CDbl(txtDesconto.Text), 2)

            Call botoes()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtDesconto_TextChanged(sender As Object, e As EventArgs) Handles txtDesconto.TextChanged
        Try
            Dim varTot As Double = 0
            For i As Integer = 0 To GridView1.DataRowCount - 1
                varTot = varTot + GridView1.GetRowCellValue(i, "ValorVenda")
            Next i

            Me.txtValorFinal.Text = FormatNumber(varTot - CDbl(TextEdit1.Text) - CDbl(txtTroca.Text) - CDbl(txtDesconto.Text), 2)

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
        Try
            Dim varTot As Double = 0
            For i As Integer = 0 To GridView1.DataRowCount - 1
                varTot = varTot + GridView1.GetRowCellValue(i, "ValorVenda")
            Next i
            Me.txtValorFinal.Text = FormatNumber(varTot - CDbl(TextEdit1.Text) - CDbl(txtTroca.Text) - CDbl(txtDesconto.Text), 2)

            Me.Validate()
            Me.VENDASBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPrincipal)
            Me.VendasDetBindingSource.EndEdit()
            Me.FKVENDASVendasDetBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.DsPrincipal)

            varIdVenda = CInt(Me.IdTextEdit.Text)

            fExecutarText("update [1TabPeças] set vendida=1, Comissão = b.Comissão FROM dbo.[1TabPeças] a INNER JOIN  dbo.[VENDAS DET] b ON a.IDPeça = b.Peça WHERE b.Venda = " & CInt(Me.IdTextEdit.Text))
            Me._1TabPeçasTableAdapter.Fill(Me.DsPrincipal._1TabPeças)

            fExecutarText("update vendas SET peças=dbo.fPeças(Id) where Id = " & CInt(Me.IdTextEdit.Text))
            frmVendasDG.VENDASdgTableAdapter.Fill(frmVendasDG.DsPrincipal.VENDASdg)


            Me.VENDASTableAdapter.Fill(Me.DsPrincipal.VENDAS, varIdVenda)
            Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, varIdVenda)

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.ControlBox = True
            Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        End Try

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
                frmVendasDG.VENDASdgTableAdapter.Fill(frmVendasDG.DsPrincipal.VENDASdg)
                Me.Close()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUndo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick

        Try
            Me.VendasDetTableAdapter.Fill(Me.DsPrincipal.VendasDet, varIdVenda)
            Me.VENDASTableAdapter.Fill(Me.DsPrincipal.VENDAS, varIdVenda)
            frmVendasDG.VENDASdgTableAdapter.Fill(frmVendasDG.DsPrincipal.VENDASdg)

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Me.ribbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.ControlBox = True
            Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

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

        Me.RibbonPageGroup3.Visible = (XtraTabControl1.SelectedTabPage.Text = "FORMA DE PAGAMENTO")

    End Sub

    Private Sub ckDolarCC_CheckedChanged(sender As Object, e As EventArgs) Handles ckDolarCC.CheckedChanged

        Try
            'fExecutarText("DELETE FROM [Conta Corrente] WHERE Venda=123")
            'call AtualizaCC2

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
                rs("Valor").Value = Me.txtTotalCheque.EditValue * -1
                rs("Cheque").Value = Me.txtTotalCheque.EditValue * -1
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

End Class
