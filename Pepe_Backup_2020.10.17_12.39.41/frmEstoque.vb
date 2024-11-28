Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Partial Public Class frmEstoque
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

            Me._1TabPeçasTableAdapter.Fill(Me.DsNovoEstoque._1TabPeças, varIdPeça)

            If varIdPeça = 0 Then
                Me._1TabPeçasBindingSource.AddNew()
                Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                LabelControl1.Text = "Em estoque"
            Else
                If DLookUp("Id", "METAIS", "Id = " & CInt(Me.IDPeçaTextEdit.Text), 0) = "" Then
                    fExecutarText("INSERT INTO METAIS ( Id ) SELECT " & CInt(Me.IDPeçaTextEdit.Text) & " AS I")
                End If
                If DLookUp("Id", "PEDRAS", "Id = " & CInt(Me.IDPeçaTextEdit.Text), 0) = "" Then
                    fExecutarText("INSERT INTO PEDRAS ( Id ) SELECT " & CInt(Me.IDPeçaTextEdit.Text) & " AS I")
                End If
                If Me.VendidaCheckEdit.Checked Then LabelControl1.Text = "Vendida" : grpEstornar.Visible = True Else LabelControl1.Text = "Em estoque"
            End If

            Me.PEDRASTableAdapter.Fill(Me.DsNovoEstoque.PEDRAS)
            Me.METAISTableAdapter.Fill(Me.DsNovoEstoque.METAIS)

            Me.Tag = "1"

            frmEstoqueDG.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmClientes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmEstoqueDG.Visible = True

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
            CalculaCusto()

        End If

    End Sub

    Private Sub btnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Try
            Me.Validate()
            Me._1TabPeçasBindingSource.EndEdit()
            Me.METAISBindingSource.EndEdit()
            Me.PEDRASBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(DsNovoEstoque)

            If varIdPeça = 0 Then
                'fExecutarText("INSERT INTO METAIS ( Id ) SELECT IDPeça FROM 1TabPeças LEFT JOIN METAIS ON [1TabPeças].[IDPeça] = METAIS.[Id] WHERE METAIS.Id Is Null")
                fExecutarText("INSERT INTO METAIS ( Id ) SELECT " & CInt(Me.IDPeçaTextEdit.Text) & " AS I")
                fExecutarText("INSERT INTO PEDRAS ( Id ) SELECT " & CInt(Me.IDPeçaTextEdit.Text) & " AS I")
                Me.METAISTableAdapter.Fill(Me.DsNovoEstoque.METAIS)
                Me.PEDRASTableAdapter.Fill(Me.DsNovoEstoque.PEDRAS)
                varIdPeça = CInt(Me.IDPeçaTextEdit.Text)
            End If

            'Me.TableAdapterManager1.UpdateAll(Me.DsCliente)
            'frmClientesDG.ClientesTableAdapter.Fill(frmClientesDG.DsPrincipal.Clientes)
            'If varIdCliente = 0 Then
            '    varIdCliente = DLookUp("I", "Select Max(IDCliente) As I From Clientes", "", 1)
            '    Me.ClientesTableAdapter1.Fill(Me.DsCliente.Clientes, varIdCliente)
            '    Me.CCTableAdapter.Fill(Me.DsCliente.CC, varIdCliente)
            'End If

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
            'Me.ClientesTableAdapter1.Fill(Me.DsCliente.Clientes, varIdCliente)
            'Me.CCTableAdapter.Fill(Me.DsCliente.CC, varIdCliente)
            'If varIdCliente = 0 Then
            '    Me.ClientesBindingSource.AddNew()
            '    Me.RibbonPageGroup3.Visible = False
            '    Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'End If

            Me.Tag = "0"

            Me._1TabPeçasTableAdapter.Fill(Me.DsNovoEstoque._1TabPeças, varIdPeça)
            Me.METAISTableAdapter.Fill(Me.DsNovoEstoque.METAIS)
            Me.PEDRASTableAdapter.Fill(Me.DsNovoEstoque.PEDRAS)

            If varIdPeça = 0 Then
                Me._1TabPeçasBindingSource.AddNew()
                Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If

            Me.Tag = "1"

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

    Private Sub btnNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovo.ItemClick
        varIdPeça = 0
        'Me.ClientesBindingSource.AddNew()
        'Me.BindingSource1.Filter = "Cliente = 0"
        'Me.RibbonPageGroup3.Visible = False
        Me.RibbonPageGroup2.Visible = False
        Me.ribbonPageGroup1.Visible = True
        Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

    End Sub

    Private Sub _1TabPeçasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me._1TabPeçasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsNovoEstoque)

    End Sub
    Private Sub ClasseComboBoxEdit_TextChanged(sender As Object, e As EventArgs) Handles ClasseComboBoxEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub ModêloTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles ModêloTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub DataRegDateEdit_EditValueChanged(sender As Object, e As EventArgs) Handles DataRegDateEdit.EditValueChanged
        Call botoes()

    End Sub

    Private Sub OrigemComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OrigemComboBoxEdit.SelectedIndexChanged
        Call botoes()

    End Sub

    Private Sub OficialCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles OficialCheckEdit.CheckedChanged
        Call botoes()

    End Sub

    Private Sub ObsTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles ObsTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub LayoutView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles LayoutView1.CellValueChanged

        'Me.txtCusto.EditValue = LayoutView1.GetRowCellValue(0, "TotalValor") + Me.MOExtTextEdit.EditValue + MOIntTextEdit.EditValue
        'Me.txtCusto.EditValue = Me.txtCusto.EditValue + LayoutView2.GetRowCellValue(0, "DiamantesValor") + LayoutView2.GetRowCellValue(0, "DiamantesValor") + LayoutView2.GetRowCellValue(0, "RubiValor") + LayoutView2.GetRowCellValue(0, "SafiraValor") + LayoutView2.GetRowCellValue(0, "EsmeraldaValor") + LayoutView2.GetRowCellValue(0, "CitrinoValor") + LayoutView2.GetRowCellValue(0, "PedrasBrasValor") + LayoutView2.GetRowCellValue(0, "PerolasValor")
        'Me.txtCusto.EditValue = Me.txtCusto.EditValue + OficinaTextEdit.EditValue + MadeiraTextEdit.EditValue + CouroTextEdit.EditValue + OutrasTextEdit.EditValue

        LayoutView1.SetRowCellValue(LayoutView1.FocusedRowHandle, "TotalValor", LayoutView1.GetRowCellValue(0, "OuroQtde") + LayoutView1.GetRowCellValue(0, "PerdaQtde") + LayoutView1.GetRowCellValue(0, "PrataQtde") + LayoutView1.GetRowCellValue(0, "PlatinaQtde") + LayoutView1.GetRowCellValue(0, "PaladiumQtde") + LayoutView1.GetRowCellValue(0, "SistemaQtde") - LayoutView1.GetRowCellValue(0, "OuroV") - LayoutView1.GetRowCellValue(0, "PrataV"))

        'Forms![1FormPeças]![Valor] = Nz(Forms![1FormPeças]![Metais sub].Form!TotalValor, 0) + Nz(Forms![1FormPeças]![MOExt], 0) + Nz(Forms![1FormPeças]![MOInt], 0)
        'Forms![1FormPeças]![Valor] = Forms![1FormPeças]![Valor] + Nz(Forms![1FormPeças]![Filho166].Form![DiamantesValor], 0) + Nz(Forms![1FormPeças]![Filho166].Form![RubiValor], 0) + Nz(Forms![1FormPeças]![Filho166].Form![SafiraValor], 0) + Nz(Forms![1FormPeças]![Filho166].Form![EsmeraldaValor], 0) + Nz(Forms![1FormPeças]![Filho166].Form![CitrinoValor], 0) + Nz(Forms![1FormPeças]![Filho166].Form![PedrasBrasValor], 0) + Nz(Forms![1FormPeças]![Filho166].Form![PerolasValor], 0)
        'Forms![1FormPeças]![Valor] = Forms![1FormPeças]![Valor] + Forms![1FormPeças]![Oficina] + Forms![1FormPeças]![Madeira] + Forms![1FormPeças]![Couro] + Nz(Forms![1FormPeças]![Outras], 0)

        'Me!TotalQtde = Me!OuroQtde + Me!PerdaQtde + Me!PrataQtde + Me!PlatinaQtde + Me!PaladiumQtde + Me!SistemaQtde - Me!OuroV - Me!PrataV

        Call botoes()

    End Sub

    Private Sub MOExtTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles MOExtTextEdit.TextChanged
        Call botoes()

        'If Me.Tag = "1" Then
        'Forms![1FormPeças]![Valor] = Nz(Forms![1FormPeças]![Metais sub].Form!TotalValor, 0) + Nz(Forms![1FormPeças]![MOExt], 0) + Nz(Forms![1FormPeças]![MOInt], 0) + Nz(Forms![1FormPeças]![Cravação], 0)
        'Forms![1FormPeças]![Valor] = Forms![1FormPeças]![Valor] + Nz(Forms![1FormPeças]![Filho166].Form![DiamantesValor], 0) + Nz(Forms![1FormPeças]![Filho166].Form![RubiValor], 0) + Nz(Forms![1FormPeças]![Filho166].Form![SafiraValor], 0) + Nz(Forms![1FormPeças]![Filho166].Form![EsmeraldaValor], 0) + Nz(Forms![1FormPeças]![Filho166].Form![CitrinoValor], 0) + Nz(Forms![1FormPeças]![Filho166].Form![PedrasBrasValor], 0) + Nz(Forms![1FormPeças]![Filho166].Form![PerolasValor], 0)
        'Forms![1FormPeças]![Valor] = Forms![1FormPeças]![Valor] + Forms![1FormPeças]![Oficina] + Nz(Forms![1FormPeças]![Madeira], 0) + Nz(Forms![1FormPeças]![Couro], 0) + Nz(Forms![1FormPeças]![Outras], 0)
        'End If
    End Sub

    Private Sub cboFamilia_SelectedIndexChanged(sender As Object, e As EventArgs)
        Call botoes()

    End Sub

    Private Sub MOExtTextEdit_EditValueChanged_1(sender As Object, e As EventArgs) Handles MOExtTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub MOIntTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles MOIntTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub CravaçãoTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles CravaçãoTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub MadeiraTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles MadeiraTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub CouroTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles CouroTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub OutrasTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles OutrasTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub OficinaTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles OficinaTextEdit.TextChanged
        Call botoes()

    End Sub

    Private Sub txtCusto_EditValueChanged(sender As Object, e As EventArgs) Handles txtCusto.TextChanged
        Call botoes()

    End Sub

    Private Sub LayoutView2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles LayoutView2.CellValueChanged

        'Me.txtCusto.EditValue = LayoutView1.GetRowCellValue(0, "TotalValor") + Me.MOExtTextEdit.EditValue + MOIntTextEdit.EditValue
        'Me.txtCusto.EditValue = Me.txtCusto.EditValue + LayoutView2.GetRowCellValue(0, "DiamantesValor") + LayoutView2.GetRowCellValue(0, "DiamantesValor") + LayoutView2.GetRowCellValue(0, "RubiValor") + LayoutView2.GetRowCellValue(0, "SafiraValor") + LayoutView2.GetRowCellValue(0, "EsmeraldaValor") + LayoutView2.GetRowCellValue(0, "CitrinoValor") + LayoutView2.GetRowCellValue(0, "PedrasBrasValor") + LayoutView2.GetRowCellValue(0, "PerolasValor")
        'Me.txtCusto.EditValue = Me.txtCusto.EditValue + OficinaTextEdit.EditValue + MadeiraTextEdit.EditValue + CouroTextEdit.EditValue + OutrasTextEdit.EditValue

        Call botoes()

    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Call botoes()

    End Sub

    Private Sub CalculaCusto()

        Me.txtCusto.EditValue = LayoutView1.GetRowCellValue(0, "TotalValor") + Me.MOExtTextEdit.EditValue + MOIntTextEdit.EditValue
        Me.txtCusto.EditValue = Me.txtCusto.EditValue + LayoutView2.GetRowCellValue(0, "DiamantesValor") + LayoutView2.GetRowCellValue(0, "DiamantesValor") + LayoutView2.GetRowCellValue(0, "RubiValor") + LayoutView2.GetRowCellValue(0, "SafiraValor") + LayoutView2.GetRowCellValue(0, "EsmeraldaValor") + LayoutView2.GetRowCellValue(0, "CitrinoValor") + LayoutView2.GetRowCellValue(0, "PedrasBrasValor") + LayoutView2.GetRowCellValue(0, "PerolasValor")
        Me.txtCusto.EditValue = Me.txtCusto.EditValue + OficinaTextEdit.EditValue + MadeiraTextEdit.EditValue + CouroTextEdit.EditValue + OutrasTextEdit.EditValue

    End Sub
End Class
