Imports System.ComponentModel
Imports System.Text
Imports DevExpress.CodeParser
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraLayout.Utils

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
            Me._1TabPeçasHistóricoTableAdapter.Fill(Me.DsNovoEstoque._1TabPeçasHistórico)
            Me._1TabPeçasHistóricoBindingSource.Filter = "IDPeça = " & varIdPeça

            'Me.LayoutControl.Width = 206
            'Me.LayoutControl.Height = 31

            If varIdPeça = 0 Then
                Me._1TabPeçasBindingSource.AddNew()
                'Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
                Me.ribbonPageGroup1.Visible = False
                Me.grpFoto.Visible = False
                LabelControl1.Text = "Em estoque"
            Else
                If DLookUp("Id", "METAIS", "Id = " & CInt(Me.IDPeçaTextEdit.Text), 0) = "" Then
                    fExecutarText("INSERT INTO METAIS ( Id ) SELECT " & CInt(Me.IDPeçaTextEdit.Text) & " AS I")
                End If
                If DLookUp("Id", "PEDRAS", "Id = " & CInt(Me.IDPeçaTextEdit.Text), 0) = "" Then
                    fExecutarText("INSERT INTO PEDRAS ( Id ) SELECT " & CInt(Me.IDPeçaTextEdit.Text) & " AS I")
                End If
                If Me.VendidaCheckEdit.Checked Then LabelControl1.Text = "Vendida" : grpEstornar.Visible = True Else LabelControl1.Text = "Em estoque"
                Dim n As Integer = ConvertToDouble(DLookUp("Venda", "SELECT [VENDAS DET].Venda, [VENDAS DET].Peça FROM VENDAS INNER JOIN [VENDAS DET] ON VENDAS.Id = [VENDAS DET].Venda", "[Peça] = " & IDPeçaTextEdit.EditValue, 1))
                If n = 0 Then
                    Dim z As String = DLookUp("Observações", "Saidas", "IdPeça = " & varIdPeça, 0)
                    If z <> "" Then LabelControl1.Text = z : grpEstornar.Visible = False
                End If
            End If

            If Not Me.VendidaCheckEdit.Checked Or NomeForm = "frmInconsist" Then
                Me.btnComprador.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
            End If

            Me.PEDRASTableAdapter.Fill(Me.DsNovoEstoque.PEDRAS)
            Me.METAISTableAdapter.Fill(Me.DsNovoEstoque.METAIS)

            If Me.PictureEditPeça.EditValue Is DBNull.Value Then
                Me.PictureEditPeça.Visible = False
            End If

            Me.PictureEditPeça.Properties.SizeMode = Me.SizeModeSpinEdit.EditValue

            Me.Tag = "1"

            If frmEstoqueDG.IsHandleCreated Then
                frmEstoqueDG.Visible = False
            Else
                frmInconsist.Visible = False
            End If

            If Me.PictureEditPeça.Image Is Nothing Then
                Me.btnDelFoto.Enabled = False
                Me.btnFoto.Enabled = True
                Me.btnSelFoto.Enabled = True
            Else
                Me.btnDelFoto.Enabled = True
                Me.btnFoto.Enabled = False
                Me.btnSelFoto.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmClientes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        NomeForm = ""

        If frmEstoqueDG.IsHandleCreated Then
            frmEstoqueDG.Visible = True
        Else
            frmInconsist.Inconsist1TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist1)
            frmInconsist.Visible = True
        End If

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub botoes()
        If Me.Tag = "1" Then
            Me.ribbonPageGroup1.Visible = False
            Me.grpFechar.Visible = False
            Me.grpEstornar.Visible = False
            Me.grpFechar.Visible = False
            Me.grpFoto.Visible = False
            Me.RibbonPageGroup2.Visible = True
            '    'If frmPedidosDG.RadGridView1.Tag <> "1" Then Me.ControlBox = False
            'Me.RibbonPageGroup3.Visible = False : Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.ControlBox = False
            'CalculaCusto()

        End If

    End Sub

    Private Sub btnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Try
            If Me.ModêloTextEdit.Text = "" Then
                XtraMessageBox.Show("Por favor, informe o nº da ficha", "Atenção!")
                Me.ModêloTextEdit.Focus()
                Exit Sub
            End If

            If varNew Then
                Dim rs As New ADODB.Recordset()
                Dim cnStr As String = strAdoConnection()
                Dim strSQL As String = "Select * From [1TabPeças] Where IDPeça <> " & Me.IDPeçaTextEdit.EditValue & " And Modêlo = '" & Me.ModêloTextEdit.Text & "'"
                rs.Open(strSQL, cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
                If Not rs.EOF Then
                    XtraMessageBox.Show("Ficha já existente, por favor informe outro nº", "Atenção!")
                    Me.ModêloTextEdit.Focus()
                    rs.Close()
                    Me.btnFechar.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
                    Exit Try
                End If
                rs.Close()
            End If

            varNew = False
            'CalculaCusto()
            Me.Validate()
            Me._1TabPeçasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(DsNovoEstoque)
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
            'Me.btnFechar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.ribbonPageGroup1.Visible = True
            Me.grpFechar.Visible = True
            Me.grpEstornar.Visible = (LabelControl1.Text <> "Em estoque")
            Me.grpFoto.Visible = True
            Me.RibbonPageGroup2.Visible = False
            If frmEstoqueDG.IsHandleCreated Then
                frmEstoqueDG.EstoqueTableAdapter.Fill(frmEstoqueDG.DsEstoque.Estoque)
            Else
                frmInconsist.Inconsist1TableAdapter.Fill(frmInconsist.DsInconsist.Inconsist1)
            End If

            If Me.PictureEditPeça.Image Is Nothing Then
                Me.btnDelFoto.Enabled = False
                Me.btnFoto.Enabled = True
                Me.btnSelFoto.Enabled = True
            Else
                Me.btnDelFoto.Enabled = True
                Me.btnFoto.Enabled = False
                Me.btnSelFoto.Enabled = False
            End If

            fExecutarText("UPDATE [1TabPeças] SET Saida = 0 WHERE Saida = 1 AND IDPeça NOT IN (SELECT IdPeça FROM Saidas)")
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
            Me.grpFechar.Visible = True
            Me.grpEstornar.Visible = (LabelControl1.Text <> "Em estoque")
            Me.grpFoto.Visible = True
            Me.RibbonPageGroup2.Visible = False
            'Me.RibbonPageGroup3.Visible = True : Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            If Me.PictureEditPeça.Image Is Nothing Then
                Me.btnDelFoto.Enabled = False
                Me.btnFoto.Enabled = True
                Me.btnSelFoto.Enabled = True
            Else
                Me.btnDelFoto.Enabled = True
                Me.btnFoto.Enabled = False
                Me.btnSelFoto.Enabled = False
            End If
        End Try

    End Sub

    Private Sub frmClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        On Error Resume Next

        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.Send("{Tab}")
            Case Keys.F3
                Select Case Me.SizeModeSpinEdit.EditValue
                    Case 1
                        Me.PictureEditPeça.Properties.SizeMode = 2  'DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
                        Me.SizeModeSpinEdit.EditValue = 2
                    Case 3
                        Me.PictureEditPeça.Properties.SizeMode = 4  'DevExpress.XtraEditors.Controls.PictureSizeMode.StretchHorizontal
                        Me.SizeModeSpinEdit.EditValue = 4
                    Case 5
                        Me.PictureEditPeça.Properties.SizeMode = 0  'DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
                        Me.SizeModeSpinEdit.EditValue = 0
                    Case 0
                        Me.PictureEditPeça.Properties.SizeMode = 1  'DevExpress.XtraEditors.Controls.PictureSizeMode.Clip
                        Me.SizeModeSpinEdit.EditValue = 1
                    Case 4
                        Me.PictureEditPeça.Properties.SizeMode = 5  'DevExpress.XtraEditors.Controls.PictureSizeMode.StretchVertical
                        Me.SizeModeSpinEdit.EditValue = 5
                    Case 2
                        Me.PictureEditPeça.Properties.SizeMode = 3  'DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
                        Me.SizeModeSpinEdit.EditValue = 3
                End Select
                botoes()

            Case Keys.F4
                frmPastaFotos.ShowDialog()
        End Select

    End Sub

    Private Sub btnNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovo.ItemClick
        varIdPeça = 0
        varNew = True

        Me._1TabPeçasBindingSource.AddNew()
        LabelControl1.Text = "Em estoque"

        'Me.ClientesBindingSource.AddNew()
        'Me.BindingSource1.Filter = "Cliente = 0"
        'Me.RibbonPageGroup3.Visible = False

        Me.ControlBox = False
        Me.RibbonPageGroup2.Visible = False
        Me.ribbonPageGroup1.Visible = False
        Me.grpEstornar.Visible = False
        Me.grpFoto.Visible = False
        Me.grpFechar.Visible = True
        Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing

    End Sub

    Private Sub _1TabPeçasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me._1TabPeçasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsNovoEstoque)

    End Sub
    Private Sub ClasseComboBoxEdit_TextChanged(sender As Object, e As EventArgs) Handles ClasseComboBoxEdit.TextChanged
        'Call botoes()

    End Sub

    Private Sub ModêloTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles ModêloTextEdit.TextChanged
        Call botoes()
        'Me.ribbonPageGroup1.Visible = True
        'Me.RibbonPageGroup2.Visible = False

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

    'Private Sub LayoutView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles LayoutView1.CellValueChanged
    '    LayoutView1.SetRowCellValue(LayoutView1.FocusedRowHandle, "TotalValor", LayoutView1.GetRowCellValue(0, "OuroQtde") + LayoutView1.GetRowCellValue(0, "PerdaQtde") + LayoutView1.GetRowCellValue(0, "PrataQtde") + LayoutView1.GetRowCellValue(0, "PlatinaQtde") + LayoutView1.GetRowCellValue(0, "PaladiumQtde") + LayoutView1.GetRowCellValue(0, "SistemaQtde") - LayoutView1.GetRowCellValue(0, "OuroV") - LayoutView1.GetRowCellValue(0, "PrataV"))
    '    CalculaCusto()
    '    'Call botoes()
    'End Sub

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
        CalculaCusto()
        Call botoes()

    End Sub

    Private Sub MOIntTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles MOIntTextEdit.TextChanged
        CalculaCusto()
        Call botoes()

    End Sub

    Private Sub CravaçãoTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles CravaçãoTextEdit.TextChanged
        CalculaCusto()
        Call botoes()

    End Sub

    Private Sub MadeiraTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles MadeiraTextEdit.TextChanged
        CalculaCusto()
        Call botoes()

    End Sub

    Private Sub CouroTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles CouroTextEdit.TextChanged
        CalculaCusto()
        Call botoes()

    End Sub

    Private Sub OutrasTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles OutrasTextEdit.TextChanged
        CalculaCusto()
        Call botoes()

    End Sub

    Private Sub OficinaTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles OficinaTextEdit.TextChanged
        CalculaCusto()
        Call botoes()

    End Sub

    Private Sub txtCusto_TextChanged(sender As Object, e As EventArgs) Handles txtCusto.TextChanged
        Call botoes()

    End Sub

    Private Sub LayoutView2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles LayoutView2.CellValueChanged

        'Me.txtCusto.EditValue = LayoutView1.GetRowCellValue(0, "TotalValor") + Me.MOExtTextEdit.EditValue + MOIntTextEdit.EditValue
        'Me.txtCusto.EditValue = Me.txtCusto.EditValue + LayoutView2.GetRowCellValue(0, "DiamantesValor") + LayoutView2.GetRowCellValue(0, "DiamantesValor") + LayoutView2.GetRowCellValue(0, "RubiValor") + LayoutView2.GetRowCellValue(0, "SafiraValor") + LayoutView2.GetRowCellValue(0, "EsmeraldaValor") + LayoutView2.GetRowCellValue(0, "CitrinoValor") + LayoutView2.GetRowCellValue(0, "PedrasBrasValor") + LayoutView2.GetRowCellValue(0, "PerolasValor")
        'Me.txtCusto.EditValue = Me.txtCusto.EditValue + OficinaTextEdit.EditValue + MadeiraTextEdit.EditValue + CouroTextEdit.EditValue + OutrasTextEdit.EditValue
        CalculaCusto()
        Call botoes()

    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If RadioGroup1.SelectedIndex = 0 Then
            ' bloquer a coluna de ouro
            LayoutView1.Columns("OuroQtde").OptionsColumn.AllowEdit = False
            LayoutView1.Columns("OuroV").OptionsColumn.AllowEdit = False
            LayoutView1.Columns("OuroQtde").OptionsColumn.AllowFocus = False
            LayoutView1.Columns("OuroV").OptionsColumn.AllowFocus = False
            LayoutView1.Columns("OuroQtde").OptionsColumn.ReadOnly = True
            LayoutView1.Columns("OuroV").OptionsColumn.ReadOnly = True
            LayoutView1.Columns("OuroQtde").OptionsColumn.TabStop = False
            LayoutView1.Columns("OuroV").OptionsColumn.TabStop = False
            ' desbloquear a coluna de prata
            LayoutView1.Columns("PrataQtde").OptionsColumn.AllowEdit = True
            LayoutView1.Columns("PrataV").OptionsColumn.AllowEdit = True
            LayoutView1.Columns("PrataQtde").OptionsColumn.AllowFocus = True
            LayoutView1.Columns("PrataV").OptionsColumn.AllowFocus = True
            LayoutView1.Columns("PrataQtde").OptionsColumn.ReadOnly = False
            LayoutView1.Columns("PrataV").OptionsColumn.ReadOnly = False
            LayoutView1.Columns("PrataQtde").OptionsColumn.TabStop = True
            LayoutView1.Columns("PrataV").OptionsColumn.TabStop = True
        ElseIf RadioGroup1.SelectedIndex = 1 Then
            ' bloquer a coluna de prata
            LayoutView1.Columns("PrataQtde").OptionsColumn.AllowEdit = False
            LayoutView1.Columns("PrataV").OptionsColumn.AllowEdit = False
            LayoutView1.Columns("PrataQtde").OptionsColumn.AllowFocus = False
            LayoutView1.Columns("PrataV").OptionsColumn.AllowFocus = False
            LayoutView1.Columns("PrataQtde").OptionsColumn.ReadOnly = True
            LayoutView1.Columns("PrataV").OptionsColumn.ReadOnly = True
            LayoutView1.Columns("PrataQtde").OptionsColumn.TabStop = False
            LayoutView1.Columns("PrataV").OptionsColumn.TabStop = False
            ' desbloquear a coluna de ouro
            LayoutView1.Columns("OuroQtde").OptionsColumn.AllowEdit = True
            LayoutView1.Columns("OuroV").OptionsColumn.AllowEdit = True
            LayoutView1.Columns("OuroQtde").OptionsColumn.AllowFocus = True
            LayoutView1.Columns("OuroV").OptionsColumn.AllowFocus = True
            LayoutView1.Columns("OuroQtde").OptionsColumn.ReadOnly = False
            LayoutView1.Columns("OuroV").OptionsColumn.ReadOnly = False
            LayoutView1.Columns("OuroQtde").OptionsColumn.TabStop = True
            LayoutView1.Columns("OuroV").OptionsColumn.TabStop = True
        Else
            ' desbloquear a coluna de ouro e também a de prata
            LayoutView1.Columns("OuroQtde").OptionsColumn.AllowEdit = True
            LayoutView1.Columns("OuroV").OptionsColumn.AllowEdit = True
            LayoutView1.Columns("OuroQtde").OptionsColumn.AllowFocus = True
            LayoutView1.Columns("OuroV").OptionsColumn.AllowFocus = True
            LayoutView1.Columns("OuroQtde").OptionsColumn.ReadOnly = False
            LayoutView1.Columns("OuroV").OptionsColumn.ReadOnly = False
            LayoutView1.Columns("OuroQtde").OptionsColumn.TabStop = True
            LayoutView1.Columns("OuroV").OptionsColumn.TabStop = True
            LayoutView1.Columns("PrataQtde").OptionsColumn.AllowEdit = True
            LayoutView1.Columns("PrataV").OptionsColumn.AllowEdit = True
            LayoutView1.Columns("PrataQtde").OptionsColumn.AllowFocus = True
            LayoutView1.Columns("PrataV").OptionsColumn.AllowFocus = True
            LayoutView1.Columns("PrataQtde").OptionsColumn.ReadOnly = False
            LayoutView1.Columns("PrataV").OptionsColumn.ReadOnly = False
            LayoutView1.Columns("PrataQtde").OptionsColumn.TabStop = True
            LayoutView1.Columns("PrataV").OptionsColumn.TabStop = True
        End If

        Call botoes()

    End Sub

    Private Sub CalculaCusto()
        If Me.Tag = "1" Then
            Try
                Me.Tag = "0"
                RemoveHandler LayoutView1.CellValueChanged, AddressOf LayoutView1_CellValueChanged
                LayoutView1.SetRowCellValue(LayoutView1.FocusedRowHandle,
                "TotalQtde", LayoutView1.GetRowCellValue(0, "OuroQtde") +
                LayoutView1.GetRowCellValue(0, "PerdaQtde") +
                LayoutView1.GetRowCellValue(0, "PrataQtde") +
                LayoutView1.GetRowCellValue(0, "PlatinaQtde") +
                LayoutView1.GetRowCellValue(0, "PaladiumQtde") +
                LayoutView1.GetRowCellValue(0, "SistemaQtde") -
                LayoutView1.GetRowCellValue(0, "OuroV") -
                LayoutView1.GetRowCellValue(0, "PrataV"))
                AddHandler LayoutView1.CellValueChanged, AddressOf LayoutView1_CellValueChanged
                RemoveHandler txtCusto.TextChanged, AddressOf txtCusto_TextChanged
                Me.txtCusto.EditValue =
                ConvertToDouble(LayoutView1.GetRowCellValue(0, "TotalValor")) +
                ConvertToDouble(Me.MOExtTextEdit.EditValue) +
                ConvertToDouble(MOIntTextEdit.EditValue) +
                ConvertToDouble(CravaçãoTextEdit.EditValue)
                Me.txtCusto.EditValue = ConvertToDouble(Me.txtCusto.EditValue) _
                + ConvertToDouble(LayoutView2.GetRowCellValue(0,
                "DiamantesValor")) +
                +ConvertToDouble(LayoutView2.GetRowCellValue(0,
                "Diamantes2Valor")) +
                ConvertToDouble(LayoutView2.GetRowCellValue(0, "RubiValor")) +
                ConvertToDouble(LayoutView2.GetRowCellValue(0, "SafiraValor")) _
                + ConvertToDouble(LayoutView2.GetRowCellValue(0,
                "EsmeraldaValor")) +
                ConvertToDouble(LayoutView2.GetRowCellValue(0, "CitrinoValor")) _
                + ConvertToDouble(LayoutView2.GetRowCellValue(0,
                "PedrasBrasValor")) +
                ConvertToDouble(LayoutView2.GetRowCellValue(0, "PerolasValor"))
                Me.txtCusto.EditValue = ConvertToDouble(Me.txtCusto.EditValue) _
                + ConvertToDouble(OficinaTextEdit.EditValue) +
                ConvertToDouble(MadeiraTextEdit.EditValue) +
                ConvertToDouble(CouroTextEdit.EditValue) +
                ConvertToDouble(OutrasTextEdit.EditValue)
                AddHandler txtCusto.TextChanged, AddressOf txtCusto_TextChanged
                Me.Tag = "1"


            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If

    End Sub

    Private Sub MOExtTextEdit_Validated(sender As Object, e As EventArgs) Handles MOExtTextEdit.Validated
        'CalculaCusto()

    End Sub

    Private Sub LayoutView2_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles LayoutView2.ValidateRow
        'CalculaCusto()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        LayoutView1.SetRowCellValue(LayoutView1.FocusedRowHandle, "TotalQtde", LayoutView1.GetRowCellValue(0, "OuroQtde") + LayoutView1.GetRowCellValue(0, "PerdaQtde") + LayoutView1.GetRowCellValue(0, "PrataQtde") + LayoutView1.GetRowCellValue(0, "PlatinaQtde") + LayoutView1.GetRowCellValue(0, "PaladiumQtde") + LayoutView1.GetRowCellValue(0, "SistemaQtde") - LayoutView1.GetRowCellValue(0, "OuroV") - LayoutView1.GetRowCellValue(0, "PrataV"))
        CalculaCusto()
    End Sub

    Private Sub LayoutControl_GroupExpandChanged(sender As Object, e As LayoutGroupEventArgs) Handles LayoutControl.GroupExpandChanged
        If Me.Tag = "1" Then
            If e.Group.Expanded Then
                Me.LayoutControl.Height = 118
                'Me.LayoutControl.Width = 612
                Me._1TabPeçasHistóricoGridControl.Height = 118
                'Me._1TabPeçasHistóricoGridControl.Width = 500
            Else
                Me.LayoutControl.Height = 30
                'Me.LayoutControl.Width = 173
                'Me._1TabPeçasHistóricoGridControl.Height = 73
                'Me._1TabPeçasHistóricoGridControl.Width = 258
            End If
        End If

    End Sub

    Private Sub btnEstornar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstornar.ItemClick
        Dim x As MsgBoxResult = MsgBox("Confirma estorno?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
        If x = vbYes Then
            fExecutarText("Delete From [VENDAS DET] WHERE Peça = " & Val(Me.IDPeçaTextEdit.Text))
            Me.VendidaCheckEdit.EditValue = False
            Me.VendidaCheckEdit.Checked = False
            Me.Validate()
            Me._1TabPeçasBindingSource.EndEdit()
            Me.METAISBindingSource.EndEdit()
            Me.PEDRASBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(DsNovoEstoque)
            LabelControl1.Text = "Em estoque"
            grpEstornar.Visible = False
        End If

    End Sub

    Private Sub PanelControl1_LostFocus(sender As Object, e As EventArgs) Handles PanelControl1.LostFocus

        If DLookUp("Id", "METAIS", "Id = " & CInt(Me.IDPeçaTextEdit.Text), 0) = "" Then
            fExecutarText("INSERT INTO METAIS ( Id ) SELECT " & CInt(Me.IDPeçaTextEdit.Text) & " AS I")
            Me.METAISTableAdapter.Fill(Me.DsNovoEstoque.METAIS)
        End If
        If DLookUp("Id", "PEDRAS", "Id = " & CInt(Me.IDPeçaTextEdit.Text), 0) = "" Then
            fExecutarText("INSERT INTO PEDRAS ( Id ) SELECT " & CInt(Me.IDPeçaTextEdit.Text) & " AS I")
            Me.PEDRASTableAdapter.Fill(Me.DsNovoEstoque.PEDRAS)
        End If

    End Sub

    Private Sub ModêloTextEdit_Validated(sender As Object, e As EventArgs) Handles ModêloTextEdit.Validated

        'If Me.Tag = "1" And ModêloTextEdit.Text <> "" Then
        '    Me.Validate()
        '    Me._1TabPeçasBindingSource.EndEdit()
        '    Me.METAISBindingSource.EndEdit()
        '    Me.PEDRASBindingSource.EndEdit()
        '    Me.TableAdapterManager.UpdateAll(DsNovoEstoque)

        '    If varIdPeça = 0 Then
        '        fExecutarText("INSERT INTO METAIS ( Id ) SELECT " & CInt(Me.IDPeçaTextEdit.Text) & " AS I")
        '        fExecutarText("INSERT INTO PEDRAS ( Id ) SELECT " & CInt(Me.IDPeçaTextEdit.Text) & " AS I")
        '        Me.METAISTableAdapter.Fill(Me.DsNovoEstoque.METAIS)
        '        Me.PEDRASTableAdapter.Fill(Me.DsNovoEstoque.PEDRAS)
        '        varIdPeça = CInt(Me.IDPeçaTextEdit.Text)
        '    End If
        'End If

    End Sub

    Private Sub DataFabricDateEdit_EditValueChanged(sender As Object, e As EventArgs) Handles DataFabricDateEdit.EditValueChanged
        Call botoes()

    End Sub

    Private Sub MOIntTextEdit_Validated(sender As Object, e As EventArgs) Handles MOIntTextEdit.Validated
        'CalculaCusto()

    End Sub

    Private Sub CravaçãoTextEdit_Validated(sender As Object, e As EventArgs) Handles CravaçãoTextEdit.Validated
        'CalculaCusto()

    End Sub

    Private Sub MadeiraTextEdit_Validated(sender As Object, e As EventArgs) Handles MadeiraTextEdit.Validated
        'CalculaCusto()

    End Sub

    Private Sub CouroTextEdit_Validated(sender As Object, e As EventArgs) Handles CouroTextEdit.Validated
        'CalculaCusto()

    End Sub

    Private Sub OutrasTextEdit_Validated(sender As Object, e As EventArgs) Handles OutrasTextEdit.Validated
        'CalculaCusto()

    End Sub

    Private Sub OficinaTextEdit_Validated(sender As Object, e As EventArgs) Handles OficinaTextEdit.Validated
        'CalculaCusto()

    End Sub

    Private Sub LayoutView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles LayoutView1.ValidateRow
        'CalculaCusto()

    End Sub

    Private Sub LayoutView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles LayoutView1.CellValueChanged

        RemoveHandler LayoutView1.CellValueChanged, AddressOf LayoutView1_CellValueChanged
        'LayoutView1.SetRowCellValue(LayoutView1.FocusedRowHandle, "TotalQtde", LayoutView1.GetRowCellValue(0, "OuroQtde") + LayoutView1.GetRowCellValue(0, "PerdaQtde") + LayoutView1.GetRowCellValue(0, "PrataQtde") + LayoutView1.GetRowCellValue(0, "PlatinaQtde") + LayoutView1.GetRowCellValue(0, "PaladiumQtde") + LayoutView1.GetRowCellValue(0, "SistemaQtde") - LayoutView1.GetRowCellValue(0, "OuroV") - LayoutView1.GetRowCellValue(0, "PrataV"))
        CalculaCusto()
        AddHandler LayoutView1.CellValueChanged, AddressOf LayoutView1_CellValueChanged
        botoes()

    End Sub

    Private Sub ClasseComboBoxEdit_Validated(sender As Object, e As EventArgs) Handles ClasseComboBoxEdit.Validated

        'If Me.Tag = "1" And ModêloTextEdit.Text <> "" Then
        '    Me.Validate()
        '    Me._1TabPeçasBindingSource.EndEdit()
        '    Me.METAISBindingSource.EndEdit()
        '    Me.PEDRASBindingSource.EndEdit()
        '    Me.TableAdapterManager.UpdateAll(DsNovoEstoque)
        Try
            If varIdPeça = 0 Then
                ModêloTextEdit.Text = "."
                OrigemComboBoxEdit.Text = "F.P."
                Me.Validate()
                Me._1TabPeçasBindingSource.EndEdit()
                Me.METAISBindingSource.EndEdit()
                Me.PEDRASBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(DsNovoEstoque)
                fExecutarText("INSERT INTO METAIS ( Id ) SELECT " & CInt(Me.IDPeçaTextEdit.Text) & " AS I")
                fExecutarText("INSERT INTO PEDRAS ( Id ) SELECT " & CInt(Me.IDPeçaTextEdit.Text) & " AS I")
                Me.METAISTableAdapter.Fill(Me.DsNovoEstoque.METAIS)
                Me.PEDRASTableAdapter.Fill(Me.DsNovoEstoque.PEDRAS)
                varIdPeça = CInt(Me.IDPeçaTextEdit.Text)
                ModêloTextEdit.Text = ""
                OrigemComboBoxEdit.Text = ""
                'Else
                '    Call botoes()

            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)

        End Try

        'End If

    End Sub

    Private Sub PrVendaSpinEdit_TextChanged(sender As Object, e As EventArgs) Handles PrVendaSpinEdit.TextChanged
        botoes()

    End Sub

    Private Sub btnDel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDel.ItemClick

        If XtraMessageBox.Show("Confirma exclusão da peça?", Me.ClasseComboBoxEdit.Text + Me.ModêloTextEdit.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me._1TabPeçasBindingSource.RemoveCurrent()
            Me.Validate()
            Me._1TabPeçasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(DsNovoEstoque)
            frmEstoqueDG.EstoqueTableAdapter.Fill(frmEstoqueDG.DsEstoque.Estoque)
            Me.Close()
        End If


    End Sub

    Private Sub btnComprador_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnComprador.ItemClick

        'varIdVenda = GridView1.GetFocusedRowCellValue("Id")
        'varIdVenda = DLookUp("Venda", "[VENDAS DET]", "[Peça] = " & IDPeçaTextEdit.EditValue, 0)
        varIdVenda = ConvertToDouble(DLookUp("Venda", "SELECT [VENDAS DET].Venda, [VENDAS DET].Peça FROM VENDAS INNER JOIN [VENDAS DET] ON VENDAS.Id = [VENDAS DET].Venda", "[Peça] = " & IDPeçaTextEdit.EditValue, 1))
        If varIdVenda = 0 Then MsgBox("Saída sem lucro", MsgBoxStyle.Information, "Atenção!") : Exit Sub

        NomeForm = "frmEstoque"
        frmNewVenda.Show()

    End Sub

    Private Sub SimpleButton_Click(sender As Object, e As EventArgs) Handles SimpleButton.Click

        Me._1TabPeçasHistóricoGridControl.Height = 140
        Me._1TabPeçasHistóricoGridControl.Width = 500

        Me.Root.Height = 140
        Me.Root.Width = 500

    End Sub

    Private Sub btnVoltar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnVoltar.ItemClick
        frmVolta.ShowDialog()

    End Sub

    Private Sub VoltaCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles VoltaCheckEdit.CheckedChanged

        Call botoes()

    End Sub

    Private Sub btnFoto_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnFoto.ItemClick

        If ConvertToDouble(Me.IDPeçaTextEdit.EditValue) = 0 Then
            XtraMessageBox.Show("POR FAVOR, INFORME O Nº DA FICHA", "MastMed")
            ModêloTextEdit.Focus()
            Exit Sub
        End If

        If ConvertToDouble(IDPeçaTextEdit.EditValue) <= 0 Then
            Call btnSalvar_ItemClick(Nothing, Nothing)
        End If

        Me.PictureEditPeça.ShowTakePictureDialog()

    End Sub

    Private Sub PictureEditPeça_EditValueChanged(sender As Object, e As EventArgs) Handles PictureEditPeça.EditValueChanged

        Me.PictureEditPeça.Visible = Not Me.PictureEditPeça.EditValue Is DBNull.Value

        Call botoes()

    End Sub

    Private Sub btnSelFoto_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSelFoto.ItemClick

        XtraOpenFileDialogFoto.FileName = Me.ClasseComboBoxEdit.Text & Me.ModêloTextEdit.Text & ".jpg"
        XtraOpenFileDialogFoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        If XtraOpenFileDialogFoto.ShowDialog = DialogResult.OK Then
            Me.PictureEditPeça.Visible = True
            Me.PictureEditPeça.Image = Image.FromFile(Me.XtraOpenFileDialogFoto.FileName)
        End If

        Dim rs As New ADODB.Recordset()
        Dim cnStr As String = strAdoConnection()
        Dim strSQL As String = "Select IDPeça, Foto From [1TabPeças] Where IDPeça = " & Me.IDPeçaTextEdit.EditValue

        Dim FSO As New System.IO.FileStream(Me.XtraOpenFileDialogFoto.FileName, IO.FileMode.OpenOrCreate, IO.FileAccess.Read)
        Dim imgArrayByte(CType(FSO.Length() - 1, Integer)) As Byte

        rs.Open(strSQL, cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            FSO.Read(imgArrayByte, 0, imgArrayByte.Length)
            FSO.Close()
            rs("Foto").Value = imgArrayByte
            rs.Update()
        End If
        rs.Close()

        'Dim d As New TakePictureDialog()
        'If d.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    My.Computer.FileSystem.CreateDirectory("C:\Sistema\Fotos")
        '    Dim i As Image = d.Image
        '    i.Save("C:\Sistema\Fotos\" & Me.REGISTR_PACIENTESpinEdit.Text & ".jpg")
        '    Me.picPac.ImageLocation = "C:\Sistema\Fotos\" & Me.REGISTR_PACIENTESpinEdit.Text & ".jpg"
        'End If


    End Sub

    Private Sub btnDelFoto_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnDelFoto.ItemClick
        Me.PictureEditPeça.Image = Nothing
        Me.PictureEditPeça.Visible = False

    End Sub

    Private Sub btnSalvarComo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSalvarComo.ItemClick

        Dim x As MsgBoxResult = MsgBox("Confirma 'salvar peça como...' ?", MsgBoxStyle.OkCancel, "Atenção!")
        If x = MsgBoxResult.Ok Then
            fExecutarText("exec USP_CLONA_PECA " & CInt(Me.IDPeçaTextEdit.Text))
            varIdPeça = DLookUp("IdP", "SELECT MAX(IDPeça) AS IdP FROM [1TabPeças]", "", 1)
            Me._1TabPeçasTableAdapter.Fill(Me.DsNovoEstoque._1TabPeças, varIdPeça)
            Me._1TabPeçasHistóricoTableAdapter.Fill(Me.DsNovoEstoque._1TabPeçasHistórico)
            Me._1TabPeçasHistóricoBindingSource.Filter = "IDPeça = " & varIdPeça
            Me.PEDRASTableAdapter.Fill(Me.DsNovoEstoque.PEDRAS)
            Me.METAISTableAdapter.Fill(Me.DsNovoEstoque.METAIS)
            ModêloTextEdit.Focus()
            grpEstornar.Visible = False
            grpFoto.Visible = True
            LabelControl1.Text = "Em estoque"
        End If
    End Sub


    Private Sub txt_pFund_TextChanged(sender As Object, e As EventArgs) Handles txt_pFund.TextChanged
        Call botoes()

    End Sub

    Private Sub cbLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLocal.SelectedIndexChanged
        Call botoes()

    End Sub


    'Private Sub LayoutView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles LayoutView1.ValidateRow
    '    LayoutView1.SetRowCellValue(LayoutView1.FocusedRowHandle, "TotalValor", LayoutView1.GetRowCellValue(0, "OuroQtde") + LayoutView1.GetRowCellValue(0, "PerdaQtde") + LayoutView1.GetRowCellValue(0, "PrataQtde") + LayoutView1.GetRowCellValue(0, "PlatinaQtde") + LayoutView1.GetRowCellValue(0, "PaladiumQtde") + LayoutView1.GetRowCellValue(0, "SistemaQtde") - LayoutView1.GetRowCellValue(0, "OuroV") - LayoutView1.GetRowCellValue(0, "PrataV"))
    '    CalculaCusto()
    'End Sub
End Class
