Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmChequeAvulso
    Private Sub frmChequeAvulso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CboClientesTableAdapter.Fill(Me.DsGeral.cboClientes)

        Me.VENDAS1TableAdapter.Fill(Me.DsCheques.VENDAS1)
        Me.VENDAS1BindingSource.AddNew()
        Me.Vencto_Cheques1TableAdapter.Fill(Me.DsCheques.Vencto_Cheques1)
        Me.Vencto_Cheques1BindingSource.Filter = "Venda = -100"

        Me.btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing

        Me.Tag = "1"

        frmChequesDG.Visible = False

    End Sub

    Private Sub frmChequeAvulso_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        fExecutarSP("USP_Cheques")

        frmChequesDG.ChequesRecTableAdapter.Fill(frmChequesDG.DsCheques1.ChequesRec)
        frmChequesDG.ChequesAbertoTableAdapter.Fill(frmChequesDG.DsCheques1.ChequesAberto)
        frmChequesDG.ChequesTodosTableAdapter.Fill(frmChequesDG.DsCheques.ChequesTodos)
        frmChequesDG.Visible = True
        'frmChequesDG.UltraOptionSet1.Value = "Em Aberto"

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub VENDASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VENDASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPrincipal)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        'Try
        '    Me.VENDASTableAdapter.Fill(Me.DsPrincipal.VENDAS, CType(IdVToolStripTextBox.Text, Integer))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub FormaChequeComboBoxEdit_Validated(sender As Object, e As EventArgs) Handles FormaChequeComboBoxEdit.Validated
        Call parcelamento()

    End Sub

    Private Sub parcelamento()
        Try

            'Dim rs As New ADODB.Recordset()
            'Dim cnStr As String = strAdoConnection()
            'rs.Open("SELECT * From [Vencto Cheques]", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

            If Me.Tag <> "1" Then Exit Sub

            If FormaChequeComboBoxEdit.Text = "" Or ChequeSpinEdit.Text = "" Or ChequeSpinEdit.Text = "0,00" Then
                fExecutarText("Delete From [Vencto Cheques] Where Venda = " & Me.IdTextEdit.Text)
                Me.Vencto_ChequesTableAdapter1.Fill(Me.DsCheques.Vencto_Cheques)
                Call botoes()
                Exit Sub

                'If FormaChequeComboBoxEdit.Text = "À vista" Then
                'fExecutarText("Delete From [Vencto Cheques] Where Venda = " & Me.IdTextEdit.Text)
                'Me.Vencto_ChequesTableAdapter.Fill(Me.DsPrincipal.Vencto_Cheques)
                'Exit Sub
            End If

            Me.Tag = "0"

            Me.Validate()
            Me.VENDAS1BindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(DsCheques)
            varIdVenda = Me.IdTextEdit.Text

            fExecutarText("Delete From [Vencto Cheques] Where Venda = " & Me.IdTextEdit.Text)

            Dim dia As Integer
            Dim mes As Integer
            Dim ano As Integer
            Dim data As String
            Dim i As Integer, j As Integer
            Dim dia1 As Integer
            Dim parcela As Double

            If IsDBNull(Me.DataVendaDateEdit.EditValue) Then Me.DataVendaDateEdit.EditValue = Date.Today

            mes = Format(Me.DataVendaDateEdit.EditValue, "MM")
            ano = Format(Me.DataVendaDateEdit.EditValue, "yy")

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
                dia1 = Format(Me.DataVendaDateEdit.EditValue, "dd")
                dia = Verifica_dia(dia1, mes)
                data = dia & "/" & Format(mes, "00") & "/" & Format(ano, "00")
                If Not IsDate(data) Then
                    data = (dia - 1) & "/" & Format(mes, "00") & "/" & Format(ano, "00")
                End If

                parcela = CDbl(ChequeSpinEdit.Text) / j

                fExecutarText("INSERT INTO [dbo].[Vencto Cheques] ([Parcela], [Vencto], [VValor], [Venda], [Banco]) VALUES ('" & CStr(i) & "/" & j & "', '" & data & "', " & Replace(parcela, ",", ".") & ", " & Me.IdTextEdit.Text & ", '" & Me.BancoTextEdit.Text & "');")

                'mes = mes + 1

            Next i

            'Me.VENDASTableAdapter.Fill(Me.DsPrincipal.VENDAS, varIdVenda)
            'Me.Conta_CorrenteBindingSource.Filter = "Id=" & varIdCC
            Me.Vencto_Cheques1TableAdapter.Fill(Me.DsCheques.Vencto_Cheques1)
            Me.Vencto_Cheques1BindingSource.Filter = "Venda = " & varIdVenda

            Me.Tag = "1"

            Me.RibbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.ControlBox = True

            Me.btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            'rs.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmAvulso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        On Error Resume Next

        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.Send("{Tab}")
        End Select

    End Sub

    Private Sub botoes()
        If Me.Tag = "1" Then
            Me.RibbonPageGroup1.Visible = False
            Me.RibbonPageGroup2.Visible = True
            Me.ControlBox = False
        End If

    End Sub

    Private Sub IDClienteTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles IDClienteTextEdit.EditValueChanged
        Call botoes()
        If Me.Tag = "1" Then Me.SEMCADASTROTextEdit.EditValue = DBNull.Value

    End Sub

    Private Sub DataVendaDateEdit_EditValueChanged(sender As Object, e As EventArgs) Handles DataVendaDateEdit.EditValueChanged
        Call parcelamento()

    End Sub

    Private Sub SEMCADASTROTextEdit_TextChanged(sender As Object, e As EventArgs) Handles SEMCADASTROTextEdit.TextChanged
        Call botoes()

        If Me.Tag = "1" And Me.SEMCADASTROTextEdit.Text <> "" Then
            Me.IDClienteTextEdit.EditValue = DBNull.Value
        End If

    End Sub

    Private Sub BancoTextEdit_TextChanged(sender As Object, e As EventArgs) Handles BancoTextEdit.TextChanged
        If FormaChequeComboBoxEdit.Text = "" Or ChequeSpinEdit.Text = "" Or ChequeSpinEdit.Text = "0,00" Then
            Call botoes()
        Else
            Me.RibbonPageGroup1.Visible = True
            Me.RibbonPageGroup2.Visible = False
            Me.ControlBox = True
        End If

    End Sub

    Private Sub FormaChequeComboBoxEdit_SelectedValueChanged(sender As Object, e As EventArgs) Handles FormaChequeComboBoxEdit.SelectedValueChanged
        'Call botoes()
        Call parcelamento()

    End Sub

    Private Sub btnUndo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick

        Dim x As MsgBoxResult = MsgBox("As alterações serão canceladas; Confirma?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
        If x = vbYes Then
            Try

                If Val(Me.IdTextEdit.Text) < 0 Then
                    'Me.VENDAS1TableAdapter.ClearBeforeFill = True
                    'Me.VENDAS1TableAdapter.Fill(Me.DsCheques.VENDAS1)
                    Me.VENDAS1BindingSource.ResetCurrentItem()
                    Me.VENDAS1BindingSource.AddNew()
                    Me.Vencto_Cheques1TableAdapter.Fill(Me.DsCheques.Vencto_Cheques1)
                    Me.Vencto_Cheques1BindingSource.Filter = "Venda = -100"
                Else
                    Me.VENDAS1BindingSource.ResetCurrentItem()
                    Me.VENDAS1BindingSource.Filter = "Id = " & varIdVenda
                    Me.Vencto_Cheques1TableAdapter.Fill(Me.DsCheques.Vencto_Cheques1)
                    Me.Vencto_Cheques1BindingSource.Filter = "Venda = " & varIdVenda
                End If


            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                'Me.Vencto_ChequesTableAdapter.Fill(Me.DsPrincipal.Vencto_Cheques)
                Me.IDClienteTextEdit.Focus()

                Me.RibbonPageGroup1.Visible = True
                Me.RibbonPageGroup2.Visible = False
                Me.ControlBox = True
                If Val(Me.IdTextEdit.Text) < 0 Then
                    Me.btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
                Else
                    Me.btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                End If

            End Try

        End If

    End Sub

    Private Sub btnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        Me.Validate()
        Me.VENDAS1BindingSource.EndEdit()
        Me.Vencto_Cheques1BindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.DsCheques)
        varIdVenda = Val(Me.IdTextEdit.Text)

        Me.btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        Me.RibbonPageGroup1.Visible = True
        Me.RibbonPageGroup2.Visible = False
        Me.ControlBox = True

    End Sub

    Private Sub btnDel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDel.ItemClick

        Dim x As MsgBoxResult = MsgBox("O lançamento integral será excluído; Confirma?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
        If x = vbYes Then
            fExecutarText("Delete From [Vencto Cheques] Where Venda = " & Me.IdTextEdit.Text)
            fExecutarText("Delete From VENDAS Where Id = " & Me.IdTextEdit.Text)
            Me.Close()
        End If
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        Call botoes()

    End Sub

    Private Sub BancoTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles BancoTextEdit.EditValueChanged
        Call parcelamento()

    End Sub

    Private Sub ChequeSpinEdit_EditValueChanged(sender As Object, e As EventArgs) Handles ChequeSpinEdit.EditValueChanged
        Call parcelamento()

    End Sub
End Class