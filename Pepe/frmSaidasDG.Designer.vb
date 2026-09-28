Partial Public Class frmSaidasDG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaidasDG))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ClientesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.SaidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsComercial = New Pepe.dsComercial()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumSaida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colDataSaida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdPeça = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdPeça = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CboPeçasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsComercial1 = New Pepe.dsComercial()
        Me.colIdMotivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdMotivo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TiposSaidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colValorSaida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colObservações = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colPrVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.XtraFolderBrowserDialog = New DevExpress.XtraEditors.XtraFolderBrowserDialog(Me.components)
        Me.SaidasTableAdapter = New Pepe.dsComercialTableAdapters.SaidasTableAdapter()
        Me.TableAdapterManager = New Pepe.dsComercialTableAdapters.TableAdapterManager()
        Me.CboPeçasTableAdapter = New Pepe.dsComercialTableAdapters.cboPeçasTableAdapter()
        Me.TiposSaidasTableAdapter = New Pepe.dsComercialTableAdapters.TiposSaidasTableAdapter()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdPeça, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboPeçasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsComercial1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposSaidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnNovo, Me.btnSalvar, Me.btnUndo, Me.btnPrint, Me.btnExcel})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 10
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
        'btnNovo
        '
        Me.btnNovo.Caption = "Inclusão"
        Me.btnNovo.Id = 4
        Me.btnNovo.ImageOptions.Image = CType(resources.GetObject("btnNovo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNovo.ImageOptions.LargeImage = CType(resources.GetObject("btnNovo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
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
        'btnPrint
        '
        Me.btnPrint.Caption = "Relatório"
        Me.btnPrint.Id = 8
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.ImageOptions.LargeImage = CType(resources.GetObject("btnPrint.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        '
        'btnExcel
        '
        Me.btnExcel.Caption = "Exportar"
        Me.btnExcel.Id = 9
        Me.btnExcel.ImageOptions.Image = CType(resources.GetObject("btnExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExcel.ImageOptions.LargeImage = CType(resources.GetObject("btnExcel.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "FINANCEIRO"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnNovo)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnPrint)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnExcel)
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
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(566, 145)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(206, 31)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Saídas"
        '
        'ClientesGridControl
        '
        Me.ClientesGridControl.DataSource = Me.SaidasBindingSource
        Me.ClientesGridControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ClientesGridControl.EmbeddedNavigator.TextStringFormat = "{0} / {1}"
        Me.ClientesGridControl.Location = New System.Drawing.Point(0, 179)
        Me.ClientesGridControl.MainView = Me.GridView1
        Me.ClientesGridControl.MenuManager = Me.ribbonControl1
        Me.ClientesGridControl.Name = "ClientesGridControl"
        Me.ClientesGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.IdPeça, Me.IdMotivo, Me.btnDel, Me.RepositoryItemSpinEdit1, Me.RepositoryItemSpinEdit2, Me.RepositoryItemSpinEdit3})
        Me.ClientesGridControl.Size = New System.Drawing.Size(1338, 543)
        Me.ClientesGridControl.TabIndex = 6
        Me.ClientesGridControl.UseEmbeddedNavigator = True
        Me.ClientesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SaidasBindingSource
        '
        Me.SaidasBindingSource.DataMember = "Saidas"
        Me.SaidasBindingSource.DataSource = Me.DsComercial
        Me.SaidasBindingSource.Sort = "DataSaida desc, Id desc"
        '
        'DsComercial
        '
        Me.DsComercial.DataSetName = "dsComercial"
        Me.DsComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.FixedLine.Options.UseTextOptions = True
        Me.GridView1.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.GridView1.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.TopNewRow.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridView1.Appearance.TopNewRow.ForeColor = System.Drawing.Color.Yellow
        Me.GridView1.Appearance.TopNewRow.Options.UseFont = True
        Me.GridView1.Appearance.TopNewRow.Options.UseForeColor = True
        Me.GridView1.Appearance.TopNewRow.Options.UseTextOptions = True
        Me.GridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNumSaida, Me.colDataSaida, Me.colIdPeça, Me.colIdMotivo, Me.colValorSaida, Me.colObservações, Me.colCusto, Me.colPrVenda, Me.GridColumn1})
        Me.GridView1.GridControl = Me.ClientesGridControl
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VValor", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.NewItemRowText = "Clique aqui para incluir saída"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 2
        Me.GridView1.OptionsEditForm.FormCaptionFormat = "DADOS DO CLIENTE"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindNullPrompt = "Pesquisar..."
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colId
        '
        Me.colId.AppearanceHeader.Options.UseTextOptions = True
        Me.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colNumSaida
        '
        Me.colNumSaida.AppearanceCell.Options.UseTextOptions = True
        Me.colNumSaida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSaida.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumSaida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSaida.Caption = "Nº Saída"
        Me.colNumSaida.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colNumSaida.FieldName = "NumSaida"
        Me.colNumSaida.Name = "colNumSaida"
        Me.colNumSaida.OptionsColumn.AllowEdit = False
        Me.colNumSaida.Visible = True
        Me.colNumSaida.VisibleIndex = 0
        Me.colNumSaida.Width = 92
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.MaskSettings.Set("mask", "0000")
        Me.RepositoryItemSpinEdit1.MaskSettings.Set("hideInsignificantZeros", False)
        Me.RepositoryItemSpinEdit1.MaskSettings.Set("autoHideDecimalSeparator", True)
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        Me.RepositoryItemSpinEdit1.UseMaskAsDisplayFormat = True
        '
        'colDataSaida
        '
        Me.colDataSaida.AppearanceCell.Options.UseTextOptions = True
        Me.colDataSaida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataSaida.AppearanceHeader.Options.UseTextOptions = True
        Me.colDataSaida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataSaida.Caption = "Data"
        Me.colDataSaida.FieldName = "DataSaida"
        Me.colDataSaida.Name = "colDataSaida"
        Me.colDataSaida.Visible = True
        Me.colDataSaida.VisibleIndex = 1
        Me.colDataSaida.Width = 104
        '
        'colIdPeça
        '
        Me.colIdPeça.AppearanceCell.Options.UseTextOptions = True
        Me.colIdPeça.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIdPeça.AppearanceHeader.Options.UseTextOptions = True
        Me.colIdPeça.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIdPeça.Caption = "Peça"
        Me.colIdPeça.ColumnEdit = Me.IdPeça
        Me.colIdPeça.FieldName = "IdPeça"
        Me.colIdPeça.Name = "colIdPeça"
        Me.colIdPeça.Visible = True
        Me.colIdPeça.VisibleIndex = 2
        Me.colIdPeça.Width = 116
        '
        'IdPeça
        '
        Me.IdPeça.AutoHeight = False
        Me.IdPeça.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdPeça.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDPeça", "ID Peça", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Classe", "Classe", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modêlo", "Modêlo", 43, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendida", "Vendida", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("P", "Peça", 15, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.IdPeça.DataSource = Me.CboPeçasBindingSource
        Me.IdPeça.DisplayMember = "P"
        Me.IdPeça.DropDownRows = 16
        Me.IdPeça.Name = "IdPeça"
        Me.IdPeça.NullText = ""
        Me.IdPeça.ValueMember = "IDPeça"
        '
        'CboPeçasBindingSource
        '
        Me.CboPeçasBindingSource.DataMember = "cboPeças"
        Me.CboPeçasBindingSource.DataSource = Me.DsComercial1
        '
        'DsComercial1
        '
        Me.DsComercial1.DataSetName = "dsComercial"
        Me.DsComercial1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colIdMotivo
        '
        Me.colIdMotivo.AppearanceHeader.Options.UseTextOptions = True
        Me.colIdMotivo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIdMotivo.Caption = "Saída para"
        Me.colIdMotivo.ColumnEdit = Me.IdMotivo
        Me.colIdMotivo.FieldName = "IdMotivo"
        Me.colIdMotivo.Name = "colIdMotivo"
        Me.colIdMotivo.Visible = True
        Me.colIdMotivo.VisibleIndex = 5
        Me.colIdMotivo.Width = 238
        '
        'IdMotivo
        '
        Me.IdMotivo.AutoHeight = False
        Me.IdMotivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdMotivo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 19, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Motivo", "Motivo", 41, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.IdMotivo.DataSource = Me.TiposSaidasBindingSource
        Me.IdMotivo.DisplayMember = "Motivo"
        Me.IdMotivo.DropDownRows = 16
        Me.IdMotivo.Name = "IdMotivo"
        Me.IdMotivo.NullText = ""
        Me.IdMotivo.ValueMember = "Id"
        '
        'TiposSaidasBindingSource
        '
        Me.TiposSaidasBindingSource.DataMember = "TiposSaidas"
        Me.TiposSaidasBindingSource.DataSource = Me.DsComercial
        '
        'colValorSaida
        '
        Me.colValorSaida.AppearanceHeader.Options.UseTextOptions = True
        Me.colValorSaida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colValorSaida.Caption = "Valor"
        Me.colValorSaida.ColumnEdit = Me.RepositoryItemSpinEdit2
        Me.colValorSaida.FieldName = "ValorSaida"
        Me.colValorSaida.Name = "colValorSaida"
        Me.colValorSaida.Visible = True
        Me.colValorSaida.VisibleIndex = 4
        Me.colValorSaida.Width = 86
        '
        'RepositoryItemSpinEdit2
        '
        Me.RepositoryItemSpinEdit2.AutoHeight = False
        Me.RepositoryItemSpinEdit2.BeepOnError = True
        Me.RepositoryItemSpinEdit2.MaskSettings.Set("mask", "n")
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
        Me.RepositoryItemSpinEdit2.UseMaskAsDisplayFormat = True
        '
        'colObservações
        '
        Me.colObservações.AppearanceHeader.Options.UseTextOptions = True
        Me.colObservações.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colObservações.FieldName = "Observações"
        Me.colObservações.Name = "colObservações"
        Me.colObservações.Visible = True
        Me.colObservações.VisibleIndex = 6
        Me.colObservações.Width = 550
        '
        'colCusto
        '
        Me.colCusto.AppearanceHeader.Options.UseTextOptions = True
        Me.colCusto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCusto.ColumnEdit = Me.RepositoryItemSpinEdit3
        Me.colCusto.FieldName = "Custo"
        Me.colCusto.Name = "colCusto"
        Me.colCusto.OptionsColumn.AllowEdit = False
        Me.colCusto.Visible = True
        Me.colCusto.VisibleIndex = 3
        Me.colCusto.Width = 99
        '
        'RepositoryItemSpinEdit3
        '
        Me.RepositoryItemSpinEdit3.AutoHeight = False
        Me.RepositoryItemSpinEdit3.MaskSettings.Set("mask", "n")
        Me.RepositoryItemSpinEdit3.Name = "RepositoryItemSpinEdit3"
        Me.RepositoryItemSpinEdit3.UseMaskAsDisplayFormat = True
        '
        'colPrVenda
        '
        Me.colPrVenda.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrVenda.FieldName = "PrVenda"
        Me.colPrVenda.Name = "colPrVenda"
        '
        'GridColumn1
        '
        Me.GridColumn1.ColumnEdit = Me.btnDel
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn1.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn1.OptionsFilter.AllowFilter = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        Me.GridColumn1.Width = 22
        '
        'btnDel
        '
        Me.btnDel.AutoHeight = False
        Me.btnDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.btnDel.Name = "btnDel"
        Me.btnDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'XtraFolderBrowserDialog
        '
        Me.XtraFolderBrowserDialog.DialogStyle = DevExpress.Utils.CommonDialogs.FolderBrowserDialogStyle.Wide
        Me.XtraFolderBrowserDialog.Location = New System.Drawing.Point(0, -36)
        Me.XtraFolderBrowserDialog.SelectedPath = "XtraFolderBrowserDialog1"
        Me.XtraFolderBrowserDialog.Title = "SELECIONAR PASTA PARA SALVAR A PLANILHA EXCEL"
        '
        'SaidasTableAdapter
        '
        Me.SaidasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cboPeçasTableAdapter = Nothing
        Me.TableAdapterManager.SaidasTableAdapter = Me.SaidasTableAdapter
        Me.TableAdapterManager.TiposSaidasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pepe.dsComercialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CboPeçasTableAdapter
        '
        Me.CboPeçasTableAdapter.ClearBeforeFill = True
        '
        'TiposSaidasTableAdapter
        '
        Me.TiposSaidasTableAdapter.ClearBeforeFill = True
        '
        'frmSaidasDG
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.ClientSize = New System.Drawing.Size(1338, 722)
        Me.Controls.Add(Me.ClientesGridControl)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IconOptions.Icon = CType(resources.GetObject("frmSaidasDG.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.MaximizeBox = False
        Me.Name = "frmSaidasDG"
        Me.Ribbon = Me.ribbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdPeça, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboPeçasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsComercial1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposSaidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnNovo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ClientesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraFolderBrowserDialog As DevExpress.XtraEditors.XtraFolderBrowserDialog
    Friend WithEvents DsComercial As dsComercial
    Friend WithEvents SaidasBindingSource As BindingSource
    Friend WithEvents SaidasTableAdapter As dsComercialTableAdapters.SaidasTableAdapter
    Friend WithEvents TableAdapterManager As dsComercialTableAdapters.TableAdapterManager
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumSaida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataSaida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdPeça As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdMotivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorSaida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservações As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdPeça As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsComercial1 As dsComercial
    Friend WithEvents CboPeçasBindingSource As BindingSource
    Friend WithEvents CboPeçasTableAdapter As dsComercialTableAdapters.cboPeçasTableAdapter
    Friend WithEvents IdMotivo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TiposSaidasBindingSource As BindingSource
    Friend WithEvents TiposSaidasTableAdapter As dsComercialTableAdapters.TiposSaidasTableAdapter
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemSpinEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
