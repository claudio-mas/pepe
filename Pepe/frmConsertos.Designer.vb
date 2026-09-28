Partial Public Class frmConsertos
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsertos))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.colTotPag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLancaCC = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCompras = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPeçasCompradas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.lblCliente = New DevExpress.XtraEditors.LabelControl()
        Me.DsGeral = New Pepe.dsGeral()
        Me.CONSERTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSERTOSTableAdapter = New Pepe.dsGeralTableAdapters.CONSERTOSTableAdapter()
        Me.TableAdapterManager = New Pepe.dsGeralTableAdapters.TableAdapterManager()
        Me.CONSERTOSGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CboClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVVALOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCOMISSÃO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVENDEDORA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.VendedorasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colOBS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAbrir2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAbrir = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.CboClientesTableAdapter = New Pepe.dsGeralTableAdapters.cboClientesTableAdapter()
        Me.VendedorasTableAdapter = New Pepe.dsGeralTableAdapters.VendedorasTableAdapter()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSERTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSERTOSGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedorasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colTotPag
        '
        Me.colTotPag.FieldName = "TotPag"
        Me.colTotPag.Name = "colTotPag"
        '
        'colDT
        '
        Me.colDT.AppearanceCell.Options.UseTextOptions = True
        Me.colDT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDT.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colDT.AppearanceHeader.Options.UseFont = True
        Me.colDT.AppearanceHeader.Options.UseTextOptions = True
        Me.colDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDT.Caption = "Data"
        Me.colDT.FieldName = "DT"
        Me.colDT.Name = "colDT"
        Me.colDT.OptionsColumn.AllowEdit = False
        Me.colDT.OptionsColumn.ReadOnly = True
        Me.colDT.Visible = True
        Me.colDT.VisibleIndex = 1
        Me.colDT.Width = 102
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnSalvar, Me.btnUndo, Me.btnLancaCC, Me.btnCompras, Me.btnPeçasCompradas, Me.btnNovo})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 11
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowToolbarCustomizeItem = False
        Me.ribbonControl1.Size = New System.Drawing.Size(1338, 147)
        Me.ribbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 1
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'SkinRibbonGalleryBarItem2
        '
        Me.SkinRibbonGalleryBarItem2.Caption = "SkinRibbonGalleryBarItem2"
        Me.SkinRibbonGalleryBarItem2.Id = 2
        Me.SkinRibbonGalleryBarItem2.Name = "SkinRibbonGalleryBarItem2"
        '
        'btnFechar
        '
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Id = 3
        Me.btnFechar.ImageOptions.Image = CType(resources.GetObject("btnFechar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFechar.ImageOptions.LargeImage = CType(resources.GetObject("btnFechar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnFechar.Name = "btnFechar"
        '
        'btnSalvar
        '
        Me.btnSalvar.Caption = "Salvar"
        Me.btnSalvar.Id = 5
        Me.btnSalvar.ImageOptions.Image = CType(resources.GetObject("btnSalvar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageOptions.LargeImage = CType(resources.GetObject("btnSalvar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnUndo
        '
        Me.btnUndo.Caption = "Desfazer"
        Me.btnUndo.Id = 6
        Me.btnUndo.ImageOptions.Image = CType(resources.GetObject("btnUndo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUndo.ImageOptions.LargeImage = CType(resources.GetObject("btnUndo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnUndo.Name = "btnUndo"
        '
        'btnLancaCC
        '
        Me.btnLancaCC.Caption = "Lançamento C/C"
        Me.btnLancaCC.Id = 7
        Me.btnLancaCC.ImageOptions.Image = CType(resources.GetObject("btnLancaCC.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLancaCC.ImageOptions.LargeImage = CType(resources.GetObject("btnLancaCC.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnLancaCC.Name = "btnLancaCC"
        '
        'btnCompras
        '
        Me.btnCompras.Caption = "Compras"
        Me.btnCompras.Id = 8
        Me.btnCompras.ImageOptions.Image = CType(resources.GetObject("btnCompras.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCompras.ImageOptions.LargeImage = CType(resources.GetObject("btnCompras.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCompras.Name = "btnCompras"
        '
        'btnPeçasCompradas
        '
        Me.btnPeçasCompradas.Caption = "Peças compradas"
        Me.btnPeçasCompradas.Id = 9
        Me.btnPeçasCompradas.ImageOptions.Image = CType(resources.GetObject("btnPeçasCompradas.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPeçasCompradas.ImageOptions.LargeImage = CType(resources.GetObject("btnPeçasCompradas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPeçasCompradas.Name = "btnPeçasCompradas"
        '
        'btnNovo
        '
        Me.btnNovo.Caption = "Incluir"
        Me.btnNovo.Id = 10
        Me.btnNovo.ImageOptions.Image = CType(resources.GetObject("btnNovo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNovo.ImageOptions.LargeImage = CType(resources.GetObject("btnNovo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNovo.Name = "btnNovo"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "CONSERTOS"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnNovo)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnFechar, True)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSalvar)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnUndo)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Visible = False
        '
        'lblCliente
        '
        Me.lblCliente.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblCliente.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCliente.Appearance.Options.UseFont = True
        Me.lblCliente.Appearance.Options.UseForeColor = True
        Me.lblCliente.Appearance.Options.UseImageAlign = True
        Me.lblCliente.Appearance.Options.UseTextOptions = True
        Me.lblCliente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCliente.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCliente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCliente.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.lblCliente.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.lblCliente.Location = New System.Drawing.Point(453, 147)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(432, 24)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Consertos"
        '
        'DsGeral
        '
        Me.DsGeral.DataSetName = "dsGeral"
        Me.DsGeral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSERTOSBindingSource
        '
        Me.CONSERTOSBindingSource.DataMember = "CONSERTOS"
        Me.CONSERTOSBindingSource.DataSource = Me.DsGeral
        Me.CONSERTOSBindingSource.Sort = "DT Desc, Cliente Asc"
        '
        'CONSERTOSTableAdapter
        '
        Me.CONSERTOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CartõesTableAdapter = Nothing
        Me.TableAdapterManager.cboClientesTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CONSERTOSTableAdapter = Me.CONSERTOSTableAdapter
        Me.TableAdapterManager.UpdateOrder = Pepe.dsGeralTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager.Vencto_ChequesTableAdapter = Nothing
        Me.TableAdapterManager.VendedorasTableAdapter = Nothing
        '
        'CONSERTOSGridControl
        '
        Me.CONSERTOSGridControl.DataSource = Me.CONSERTOSBindingSource
        Me.CONSERTOSGridControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CONSERTOSGridControl.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.CONSERTOSGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.CONSERTOSGridControl.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.CONSERTOSGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.CONSERTOSGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.CONSERTOSGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.CONSERTOSGridControl.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.CONSERTOSGridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CONSERTOSGridControl.EmbeddedNavigator.TextStringFormat = "{0} / {1}"
        Me.CONSERTOSGridControl.Location = New System.Drawing.Point(0, 175)
        Me.CONSERTOSGridControl.MainView = Me.GridView1
        Me.CONSERTOSGridControl.MenuManager = Me.ribbonControl1
        Me.CONSERTOSGridControl.Name = "CONSERTOSGridControl"
        Me.CONSERTOSGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnAbrir, Me.RepositoryItemSpinEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.CONSERTOSGridControl.Size = New System.Drawing.Size(1338, 547)
        Me.CONSERTOSGridControl.TabIndex = 5
        Me.CONSERTOSGridControl.UseEmbeddedNavigator = True
        Me.CONSERTOSGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseTextOptions = True
        Me.GridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDT, Me.colCLIENTE, Me.colCusto, Me.colVVALOR, Me.colCOMISSÃO, Me.colVENDEDORA, Me.colOBS, Me.colID, Me.btnAbrir2, Me.colTotPag})
        GridFormatRule1.Column = Me.colTotPag
        GridFormatRule1.ColumnApplyTo = Me.colDT
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Expression = "[TotPag] <> [VVALOR]"
        FormatConditionRuleExpression1.PredefinedName = "Red Fill"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.GridControl = Me.CONSERTOSGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindNullPrompt = "Pequisar..."
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colCLIENTE
        '
        Me.colCLIENTE.AppearanceCell.Options.UseTextOptions = True
        Me.colCLIENTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colCLIENTE.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colCLIENTE.AppearanceHeader.Options.UseFont = True
        Me.colCLIENTE.AppearanceHeader.Options.UseTextOptions = True
        Me.colCLIENTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCLIENTE.Caption = "Cliente"
        Me.colCLIENTE.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colCLIENTE.FieldName = "CLIENTE"
        Me.colCLIENTE.Name = "colCLIENTE"
        Me.colCLIENTE.OptionsColumn.AllowEdit = False
        Me.colCLIENTE.OptionsColumn.ReadOnly = True
        Me.colCLIENTE.Visible = True
        Me.colCLIENTE.VisibleIndex = 2
        Me.colCLIENTE.Width = 315
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cli", "Clientes", 34, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCliente", "ID Cliente", 57, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.CboClientesBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Cli"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ReadOnly = True
        Me.RepositoryItemLookUpEdit1.ValueMember = "IDCliente"
        '
        'CboClientesBindingSource
        '
        Me.CboClientesBindingSource.DataMember = "cboClientes"
        Me.CboClientesBindingSource.DataSource = Me.DsGeral
        '
        'colCusto
        '
        Me.colCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCusto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colCusto.AppearanceHeader.Options.UseFont = True
        Me.colCusto.AppearanceHeader.Options.UseTextOptions = True
        Me.colCusto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCusto.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colCusto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCusto.FieldName = "Custo"
        Me.colCusto.Name = "colCusto"
        Me.colCusto.OptionsColumn.AllowEdit = False
        Me.colCusto.OptionsColumn.ReadOnly = True
        Me.colCusto.Visible = True
        Me.colCusto.VisibleIndex = 3
        Me.colCusto.Width = 84
        '
        'colVVALOR
        '
        Me.colVVALOR.AppearanceCell.Options.UseTextOptions = True
        Me.colVVALOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVVALOR.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colVVALOR.AppearanceHeader.Options.UseFont = True
        Me.colVVALOR.AppearanceHeader.Options.UseTextOptions = True
        Me.colVVALOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVVALOR.Caption = "Valor"
        Me.colVVALOR.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colVVALOR.FieldName = "VVALOR"
        Me.colVVALOR.Name = "colVVALOR"
        Me.colVVALOR.OptionsColumn.AllowEdit = False
        Me.colVVALOR.OptionsColumn.ReadOnly = True
        Me.colVVALOR.Visible = True
        Me.colVVALOR.VisibleIndex = 4
        Me.colVVALOR.Width = 83
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'colCOMISSÃO
        '
        Me.colCOMISSÃO.AppearanceCell.Options.UseTextOptions = True
        Me.colCOMISSÃO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCOMISSÃO.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colCOMISSÃO.AppearanceHeader.Options.UseFont = True
        Me.colCOMISSÃO.AppearanceHeader.Options.UseTextOptions = True
        Me.colCOMISSÃO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCOMISSÃO.Caption = "Comissão"
        Me.colCOMISSÃO.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colCOMISSÃO.FieldName = "COMISSÃO"
        Me.colCOMISSÃO.Name = "colCOMISSÃO"
        Me.colCOMISSÃO.OptionsColumn.AllowEdit = False
        Me.colCOMISSÃO.OptionsColumn.ReadOnly = True
        Me.colCOMISSÃO.Visible = True
        Me.colCOMISSÃO.VisibleIndex = 5
        Me.colCOMISSÃO.Width = 86
        '
        'colVENDEDORA
        '
        Me.colVENDEDORA.AppearanceCell.Options.UseTextOptions = True
        Me.colVENDEDORA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVENDEDORA.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colVENDEDORA.AppearanceHeader.Options.UseFont = True
        Me.colVENDEDORA.AppearanceHeader.Options.UseTextOptions = True
        Me.colVENDEDORA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVENDEDORA.Caption = "Vendedor"
        Me.colVENDEDORA.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colVENDEDORA.FieldName = "VENDEDORA"
        Me.colVENDEDORA.Name = "colVENDEDORA"
        Me.colVENDEDORA.OptionsColumn.AllowEdit = False
        Me.colVENDEDORA.OptionsColumn.ReadOnly = True
        Me.colVENDEDORA.Visible = True
        Me.colVENDEDORA.VisibleIndex = 6
        Me.colVENDEDORA.Width = 120
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID Vendedora", "ID Vendedora", 89, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendedora", "Vendedores", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.VendedorasBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Vendedora"
        Me.RepositoryItemLookUpEdit2.DropDownRows = 16
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ValueMember = "ID Vendedora"
        '
        'VendedorasBindingSource
        '
        Me.VendedorasBindingSource.DataMember = "Vendedoras"
        Me.VendedorasBindingSource.DataSource = Me.DsGeral
        '
        'colOBS
        '
        Me.colOBS.AppearanceCell.Options.UseTextOptions = True
        Me.colOBS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOBS.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colOBS.AppearanceHeader.Options.UseFont = True
        Me.colOBS.AppearanceHeader.Options.UseTextOptions = True
        Me.colOBS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOBS.Caption = "Observações"
        Me.colOBS.FieldName = "OBS"
        Me.colOBS.Name = "colOBS"
        Me.colOBS.OptionsColumn.AllowEdit = False
        Me.colOBS.OptionsColumn.ReadOnly = True
        Me.colOBS.Visible = True
        Me.colOBS.VisibleIndex = 7
        Me.colOBS.Width = 496
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'btnAbrir2
        '
        Me.btnAbrir2.Caption = " "
        Me.btnAbrir2.ColumnEdit = Me.btnAbrir
        Me.btnAbrir2.Name = "btnAbrir2"
        Me.btnAbrir2.Visible = True
        Me.btnAbrir2.VisibleIndex = 0
        Me.btnAbrir2.Width = 27
        '
        'btnAbrir
        '
        Me.btnAbrir.AutoHeight = False
        EditorButtonImageOptions2.ImageUri.Uri = "Zoom;Size16x16;Colored"
        Me.btnAbrir.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'CboClientesTableAdapter
        '
        Me.CboClientesTableAdapter.ClearBeforeFill = True
        '
        'VendedorasTableAdapter
        '
        Me.VendedorasTableAdapter.ClearBeforeFill = True
        '
        'frmConsertos
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1338, 722)
        Me.Controls.Add(Me.CONSERTOSGridControl)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IconOptions.Icon = CType(resources.GetObject("frmConsertos.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmConsertos"
        Me.Ribbon = Me.ribbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSERTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSERTOSGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedorasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents SkinRibbonGalleryBarItem2 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    'Friend WithEvents DsCadastros As Pepe.dsCadastros
    'Friend WithEvents ClienteNEWTableAdapter As Pepe.dsCadastrosTableAdapters.ClienteNEWTableAdapter
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnLancaCC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCompras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPeçasCompradas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsGeral As dsGeral
    Friend WithEvents CONSERTOSBindingSource As BindingSource
    Friend WithEvents CONSERTOSTableAdapter As dsGeralTableAdapters.CONSERTOSTableAdapter
    Friend WithEvents TableAdapterManager As dsGeralTableAdapters.TableAdapterManager
    Friend WithEvents CONSERTOSGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVVALOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOMISSÃO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVENDEDORA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOBS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAbrir2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAbrir As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CboClientesBindingSource As BindingSource
    Friend WithEvents CboClientesTableAdapter As dsGeralTableAdapters.cboClientesTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents VendedorasBindingSource As BindingSource
    Friend WithEvents VendedorasTableAdapter As dsGeralTableAdapters.VendedorasTableAdapter
    Friend WithEvents btnNovo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colTotPag As DevExpress.XtraGrid.Columns.GridColumn
End Class
