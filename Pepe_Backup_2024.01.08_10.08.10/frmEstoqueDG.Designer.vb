Partial Public Class frmEstoqueDG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstoqueDG))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEtiqMalaDireta = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ClientesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.EstoqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEstoque = New Pepe.dsEstoque()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAbrir = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colClasse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModêlo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataReg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colFamília = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.EstoqueTableAdapter = New Pepe.dsEstoqueTableAdapters.EstoqueTableAdapter()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstoqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnNovo, Me.btnEtiqMalaDireta})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 6
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowToolbarCustomizeItem = False
        Me.ribbonControl1.Size = New System.Drawing.Size(1338, 158)
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
        'btnNovo
        '
        Me.btnNovo.Caption = "Entrada"
        Me.btnNovo.Id = 4
        Me.btnNovo.ImageOptions.Image = CType(resources.GetObject("btnNovo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNovo.ImageOptions.LargeImage = CType(resources.GetObject("btnNovo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        ToolTipItem1.ImageOptions.ImageUri.Uri = "chart/charttype_point;Size16x16"
        ToolTipItem1.Text = "Entrada de peças no estoque"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnNovo.SuperTip = SuperToolTip1
        '
        'btnEtiqMalaDireta
        '
        Me.btnEtiqMalaDireta.Caption = "Etiquetas mala direta"
        Me.btnEtiqMalaDireta.Id = 5
        Me.btnEtiqMalaDireta.ImageOptions.Image = CType(resources.GetObject("btnEtiqMalaDireta.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEtiqMalaDireta.ImageOptions.LargeImage = CType(resources.GetObject("btnEtiqMalaDireta.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEtiqMalaDireta.Name = "btnEtiqMalaDireta"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "ESTOQUE DE PEÇAS"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnNovo)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnFechar, True)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        '
        'ClientesGridControl
        '
        Me.ClientesGridControl.DataSource = Me.EstoqueBindingSource
        Me.ClientesGridControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.ClientesGridControl.EmbeddedNavigator.TextStringFormat = "{0} / {1}"
        Me.ClientesGridControl.Location = New System.Drawing.Point(0, 174)
        Me.ClientesGridControl.MainView = Me.GridView1
        Me.ClientesGridControl.MenuManager = Me.ribbonControl1
        Me.ClientesGridControl.Name = "ClientesGridControl"
        Me.ClientesGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnAbrir, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemTextEdit1})
        Me.ClientesGridControl.Size = New System.Drawing.Size(1338, 548)
        Me.ClientesGridControl.TabIndex = 6
        Me.ClientesGridControl.UseEmbeddedNavigator = True
        Me.ClientesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'EstoqueBindingSource
        '
        Me.EstoqueBindingSource.DataMember = "Estoque"
        Me.EstoqueBindingSource.DataSource = Me.DsEstoque
        Me.EstoqueBindingSource.Sort = "DataReg desc"
        '
        'DsEstoque
        '
        Me.DsEstoque.DataSetName = "dsEstoque"
        Me.DsEstoque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colClasse, Me.colModêlo, Me.colDataReg, Me.colOrigem, Me.colObs, Me.colW, Me.colFamília, Me.colCusto, Me.colPrVenda, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GridControl = Me.ClientesGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowRowSizing = True
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsDetail.SmartDetailExpand = False
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 2
        Me.GridView1.OptionsEditForm.FormCaptionFormat = "DADOS DO CLIENTE"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.GridView1.OptionsFind.FindNullPrompt = "Pesquisar..."
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.ColumnEdit = Me.btnAbrir
        Me.GridColumn1.FieldName = "GridColumn1"
        Me.GridColumn1.ImageOptions.Alignment = System.Drawing.StringAlignment.Center
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ShowCaption = False
        Me.GridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 29
        '
        'btnAbrir
        '
        Me.btnAbrir.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnAbrir.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colClasse
        '
        Me.colClasse.AppearanceCell.Options.UseTextOptions = True
        Me.colClasse.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClasse.AppearanceHeader.Options.UseTextOptions = True
        Me.colClasse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClasse.Caption = "Peça"
        Me.colClasse.FieldName = "Classe"
        Me.colClasse.Name = "colClasse"
        Me.colClasse.OptionsColumn.AllowEdit = False
        Me.colClasse.Visible = True
        Me.colClasse.VisibleIndex = 1
        Me.colClasse.Width = 87
        '
        'colModêlo
        '
        Me.colModêlo.AppearanceCell.Options.UseTextOptions = True
        Me.colModêlo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModêlo.AppearanceHeader.Options.UseTextOptions = True
        Me.colModêlo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModêlo.Caption = "Ficha"
        Me.colModêlo.FieldName = "Modêlo"
        Me.colModêlo.Name = "colModêlo"
        Me.colModêlo.OptionsColumn.AllowEdit = False
        Me.colModêlo.Visible = True
        Me.colModêlo.VisibleIndex = 2
        Me.colModêlo.Width = 121
        '
        'colDataReg
        '
        Me.colDataReg.AppearanceCell.Options.UseTextOptions = True
        Me.colDataReg.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataReg.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colDataReg.AppearanceHeader.Options.UseTextOptions = True
        Me.colDataReg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataReg.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colDataReg.Caption = "Data reg."
        Me.colDataReg.FieldName = "DataReg"
        Me.colDataReg.Name = "colDataReg"
        Me.colDataReg.OptionsColumn.AllowEdit = False
        Me.colDataReg.Visible = True
        Me.colDataReg.VisibleIndex = 3
        Me.colDataReg.Width = 98
        '
        'colOrigem
        '
        Me.colOrigem.AppearanceCell.Options.UseTextOptions = True
        Me.colOrigem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigem.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colOrigem.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigem.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colOrigem.Caption = "A/C"
        Me.colOrigem.FieldName = "Origem"
        Me.colOrigem.Name = "colOrigem"
        Me.colOrigem.OptionsColumn.AllowEdit = False
        Me.colOrigem.Visible = True
        Me.colOrigem.VisibleIndex = 4
        Me.colOrigem.Width = 88
        '
        'colObs
        '
        Me.colObs.Caption = "Observações"
        Me.colObs.FieldName = "Obs"
        Me.colObs.Name = "colObs"
        Me.colObs.OptionsColumn.AllowEdit = False
        Me.colObs.Visible = True
        Me.colObs.VisibleIndex = 5
        Me.colObs.Width = 520
        '
        'colW
        '
        Me.colW.AppearanceHeader.Options.UseTextOptions = True
        Me.colW.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colW.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colW.Caption = "W"
        Me.colW.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colW.FieldName = "Oficial"
        Me.colW.Name = "colW"
        Me.colW.OptionsColumn.AllowEdit = False
        Me.colW.Visible = True
        Me.colW.VisibleIndex = 6
        Me.colW.Width = 51
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'colFamília
        '
        Me.colFamília.AppearanceCell.Options.UseTextOptions = True
        Me.colFamília.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFamília.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colFamília.Caption = " "
        Me.colFamília.FieldName = "Fam"
        Me.colFamília.Name = "colFamília"
        Me.colFamília.OptionsColumn.AllowEdit = False
        Me.colFamília.UnboundExpression = "Iif([Vendida] = True, 'Sim', 'Não')"
        Me.colFamília.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colFamília.Visible = True
        Me.colFamília.VisibleIndex = 7
        Me.colFamília.Width = 64
        '
        'colCusto
        '
        Me.colCusto.AppearanceHeader.Options.UseTextOptions = True
        Me.colCusto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCusto.Caption = "Custo"
        Me.colCusto.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colCusto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCusto.FieldName = "Custo"
        Me.colCusto.Name = "colCusto"
        Me.colCusto.OptionsColumn.AllowEdit = False
        Me.colCusto.OptionsColumn.ReadOnly = True
        Me.colCusto.Visible = True
        Me.colCusto.VisibleIndex = 8
        '
        'colPrVenda
        '
        Me.colPrVenda.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrVenda.Caption = "Preço de Venda"
        Me.colPrVenda.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colPrVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrVenda.FieldName = "PrVenda"
        Me.colPrVenda.Name = "colPrVenda"
        Me.colPrVenda.OptionsColumn.AllowEdit = False
        Me.colPrVenda.OptionsColumn.ReadOnly = True
        Me.colPrVenda.Visible = True
        Me.colPrVenda.VisibleIndex = 9
        Me.colPrVenda.Width = 108
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "GridColumn3"
        Me.GridColumn3.FieldName = "IDPeça"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Vendida"
        Me.GridColumn4.FieldName = "GridColumn4"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.UnboundExpression = "Iif([Saida] = True, 'Saída', Iif([Vendida] = True, 'Sim', 'Não'))"
        Me.GridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 10
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'EstoqueTableAdapter
        '
        Me.EstoqueTableAdapter.ClearBeforeFill = True
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = 3
        Me.RadioGroup1.Location = New System.Drawing.Point(10, 149)
        Me.RadioGroup1.MenuManager = Me.ribbonControl1
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.Appearance.Options.UseForeColor = True
        Me.RadioGroup1.Properties.Appearance.Options.UseTextOptions = True
        Me.RadioGroup1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.RadioGroup1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RadioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioGroup1.Properties.ColumnIndent = 18
        Me.RadioGroup1.Properties.Columns = 3
        Me.RadioGroup1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RadioGroup1.Properties.ItemHorzAlignment = DevExpress.XtraEditors.RadioItemHorzAlignment.Near
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Em estoque"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Vendidas"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Todas")})
        Me.RadioGroup1.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Column
        Me.RadioGroup1.Size = New System.Drawing.Size(289, 22)
        Me.RadioGroup1.TabIndex = 8
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseBackColor = True
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl3.Location = New System.Drawing.Point(557, 148)
        Me.LabelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.LabelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(224, 22)
        Me.LabelControl3.TabIndex = 20
        Me.LabelControl3.Text = "Estoque Total"
        '
        'frmEstoqueDG
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1338, 722)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.RadioGroup1)
        Me.Controls.Add(Me.ClientesGridControl)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IconOptions.Icon = CType(resources.GetObject("frmEstoqueDG.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.MaximizeBox = False
        Me.Name = "frmEstoqueDG"
        Me.Ribbon = Me.ribbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstoqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnNovo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ClientesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAbrir As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnEtiqMalaDireta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsEstoque As Pepe.dsEstoque
    Friend WithEvents EstoqueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstoqueTableAdapter As Pepe.dsEstoqueTableAdapters.EstoqueTableAdapter
    Friend WithEvents colClasse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModêlo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataReg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colFamília As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrVenda As DevExpress.XtraGrid.Columns.GridColumn
End Class
