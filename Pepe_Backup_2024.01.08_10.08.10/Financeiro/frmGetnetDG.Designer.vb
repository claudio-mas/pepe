Partial Public Class frmGetnetDG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGetnetDG))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ClientesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.VIGetnetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsComercial = New Pepe.dsComercial()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPagto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalGetnet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParcelas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorParcelaGetnet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UltraOptionSet1 = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.XtraFolderBrowserDialog = New DevExpress.XtraEditors.XtraFolderBrowserDialog(Me.components)
        Me.VI_GetnetTableAdapter = New Pepe.dsComercialTableAdapters.VI_GetnetTableAdapter()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VIGetnetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraOptionSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnSalvar, Me.btnUndo, Me.btnPrint, Me.btnExcel})
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
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "FINANCEIRO"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnPrint)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnExcel)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnFechar, True)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
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
        Me.LabelControl1.Location = New System.Drawing.Point(566, 151)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(206, 31)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Controle Getnet"
        '
        'ClientesGridControl
        '
        Me.ClientesGridControl.DataSource = Me.VIGetnetBindingSource
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
        Me.ClientesGridControl.Location = New System.Drawing.Point(0, 184)
        Me.ClientesGridControl.MainView = Me.GridView1
        Me.ClientesGridControl.MenuManager = Me.ribbonControl1
        Me.ClientesGridControl.Name = "ClientesGridControl"
        Me.ClientesGridControl.Size = New System.Drawing.Size(1338, 538)
        Me.ClientesGridControl.TabIndex = 6
        Me.ClientesGridControl.UseEmbeddedNavigator = True
        Me.ClientesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VIGetnetBindingSource
        '
        Me.VIGetnetBindingSource.DataMember = "VI_Getnet"
        Me.VIGetnetBindingSource.DataSource = Me.DsComercial
        Me.VIGetnetBindingSource.Sort = "Venda, DataVenda, Cliente, Parcelas, Parc"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCliente, Me.colVenda, Me.colDataVenda, Me.colValorFinal, Me.colVencto, Me.colVValor, Me.colPagto, Me.colAut, Me.colTotalGetnet, Me.colParc, Me.colParcelas, Me.colValorParcelaGetnet})
        GridFormatRule1.Column = Me.colValorFinal
        GridFormatRule1.ColumnApplyTo = Me.colTotalGetnet
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        FormatConditionRuleExpression1.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression1.Expression = "[Total Getnet] <> [ValorFinal]"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.GridControl = Me.ClientesGridControl
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VValor", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 2
        Me.GridView1.OptionsEditForm.FormCaptionFormat = "DADOS DO CLIENTE"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindNullPrompt = "Pesquisar..."
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colCliente
        '
        Me.colCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.AllowEdit = False
        Me.colCliente.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 0
        Me.colCliente.Width = 244
        '
        'colVenda
        '
        Me.colVenda.AppearanceCell.Options.UseTextOptions = True
        Me.colVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVenda.AppearanceHeader.Options.UseTextOptions = True
        Me.colVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVenda.Caption = "Operação"
        Me.colVenda.FieldName = "Venda"
        Me.colVenda.Name = "colVenda"
        Me.colVenda.OptionsColumn.AllowEdit = False
        Me.colVenda.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colVenda.Visible = True
        Me.colVenda.VisibleIndex = 1
        Me.colVenda.Width = 90
        '
        'colDataVenda
        '
        Me.colDataVenda.AppearanceCell.Options.UseTextOptions = True
        Me.colDataVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataVenda.AppearanceHeader.Options.UseTextOptions = True
        Me.colDataVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataVenda.Caption = "Data"
        Me.colDataVenda.FieldName = "DataVenda"
        Me.colDataVenda.Name = "colDataVenda"
        Me.colDataVenda.OptionsColumn.AllowEdit = False
        Me.colDataVenda.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDataVenda.Visible = True
        Me.colDataVenda.VisibleIndex = 2
        Me.colDataVenda.Width = 92
        '
        'colValorFinal
        '
        Me.colValorFinal.AppearanceHeader.Options.UseTextOptions = True
        Me.colValorFinal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colValorFinal.Caption = "Valor total"
        Me.colValorFinal.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colValorFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorFinal.FieldName = "ValorFinal"
        Me.colValorFinal.Name = "colValorFinal"
        Me.colValorFinal.OptionsColumn.AllowEdit = False
        Me.colValorFinal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colValorFinal.OptionsFilter.AllowAutoFilter = False
        Me.colValorFinal.OptionsFilter.AllowFilter = False
        Me.colValorFinal.Visible = True
        Me.colValorFinal.VisibleIndex = 3
        Me.colValorFinal.Width = 84
        '
        'colVencto
        '
        Me.colVencto.AppearanceCell.Options.UseTextOptions = True
        Me.colVencto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencto.AppearanceHeader.Options.UseTextOptions = True
        Me.colVencto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencto.Caption = "Vencimento"
        Me.colVencto.FieldName = "Vencto"
        Me.colVencto.Name = "colVencto"
        Me.colVencto.OptionsColumn.AllowEdit = False
        Me.colVencto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colVencto.Visible = True
        Me.colVencto.VisibleIndex = 7
        Me.colVencto.Width = 90
        '
        'colVValor
        '
        Me.colVValor.AppearanceHeader.Options.UseTextOptions = True
        Me.colVValor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVValor.Caption = "Valor"
        Me.colVValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colVValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVValor.FieldName = "VValor"
        Me.colVValor.Name = "colVValor"
        Me.colVValor.OptionsColumn.AllowEdit = False
        Me.colVValor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colVValor.OptionsFilter.AllowAutoFilter = False
        Me.colVValor.OptionsFilter.AllowFilter = False
        Me.colVValor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VValor", "{0:#,###0.00;-#,###0.00}")})
        Me.colVValor.Visible = True
        Me.colVValor.VisibleIndex = 6
        Me.colVValor.Width = 91
        '
        'colPagto
        '
        Me.colPagto.AppearanceCell.Options.UseTextOptions = True
        Me.colPagto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPagto.AppearanceHeader.Options.UseTextOptions = True
        Me.colPagto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPagto.Caption = "Data pagto."
        Me.colPagto.FieldName = "Pagto"
        Me.colPagto.Name = "colPagto"
        Me.colPagto.OptionsColumn.AllowEdit = False
        Me.colPagto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPagto.Visible = True
        Me.colPagto.VisibleIndex = 8
        Me.colPagto.Width = 102
        '
        'colAut
        '
        Me.colAut.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAut.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colAut.AppearanceCell.Options.UseBackColor = True
        Me.colAut.AppearanceCell.Options.UseForeColor = True
        Me.colAut.AppearanceCell.Options.UseTextOptions = True
        Me.colAut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAut.AppearanceHeader.Options.UseTextOptions = True
        Me.colAut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAut.Caption = "Cod. Aut."
        Me.colAut.FieldName = "Aut"
        Me.colAut.Name = "colAut"
        Me.colAut.OptionsColumn.AllowEdit = False
        Me.colAut.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colAut.Visible = True
        Me.colAut.VisibleIndex = 9
        Me.colAut.Width = 88
        '
        'colTotalGetnet
        '
        Me.colTotalGetnet.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colTotalGetnet.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colTotalGetnet.AppearanceCell.Options.UseBackColor = True
        Me.colTotalGetnet.AppearanceCell.Options.UseForeColor = True
        Me.colTotalGetnet.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalGetnet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalGetnet.Caption = "Total Getnet"
        Me.colTotalGetnet.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colTotalGetnet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalGetnet.FieldName = "Total Getnet"
        Me.colTotalGetnet.Name = "colTotalGetnet"
        Me.colTotalGetnet.OptionsColumn.AllowEdit = False
        Me.colTotalGetnet.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTotalGetnet.OptionsFilter.AllowAutoFilter = False
        Me.colTotalGetnet.OptionsFilter.AllowFilter = False
        Me.colTotalGetnet.Visible = True
        Me.colTotalGetnet.VisibleIndex = 10
        Me.colTotalGetnet.Width = 92
        '
        'colParc
        '
        Me.colParc.AppearanceCell.Options.UseTextOptions = True
        Me.colParc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParc.AppearanceHeader.Options.UseTextOptions = True
        Me.colParc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParc.Caption = "Nº parcela"
        Me.colParc.FieldName = "Parc"
        Me.colParc.Name = "colParc"
        Me.colParc.OptionsColumn.AllowEdit = False
        Me.colParc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colParc.OptionsColumn.ReadOnly = True
        Me.colParc.OptionsFilter.AllowAutoFilter = False
        Me.colParc.OptionsFilter.AllowFilter = False
        Me.colParc.Visible = True
        Me.colParc.VisibleIndex = 5
        '
        'colParcelas
        '
        Me.colParcelas.AppearanceCell.Options.UseTextOptions = True
        Me.colParcelas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcelas.AppearanceHeader.Options.UseTextOptions = True
        Me.colParcelas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcelas.Caption = "Total de parcelas"
        Me.colParcelas.FieldName = "Parcelas"
        Me.colParcelas.Name = "colParcelas"
        Me.colParcelas.OptionsColumn.AllowEdit = False
        Me.colParcelas.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colParcelas.OptionsColumn.ReadOnly = True
        Me.colParcelas.OptionsFilter.AllowAutoFilter = False
        Me.colParcelas.OptionsFilter.AllowFilter = False
        Me.colParcelas.Visible = True
        Me.colParcelas.VisibleIndex = 4
        Me.colParcelas.Width = 110
        '
        'colValorParcelaGetnet
        '
        Me.colValorParcelaGetnet.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValorParcelaGetnet.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colValorParcelaGetnet.AppearanceCell.Options.UseBackColor = True
        Me.colValorParcelaGetnet.AppearanceCell.Options.UseForeColor = True
        Me.colValorParcelaGetnet.AppearanceHeader.Options.UseTextOptions = True
        Me.colValorParcelaGetnet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colValorParcelaGetnet.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colValorParcelaGetnet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorParcelaGetnet.FieldName = "Valor Parcela Getnet"
        Me.colValorParcelaGetnet.Name = "colValorParcelaGetnet"
        Me.colValorParcelaGetnet.OptionsColumn.AllowEdit = False
        Me.colValorParcelaGetnet.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colValorParcelaGetnet.OptionsFilter.AllowAutoFilter = False
        Me.colValorParcelaGetnet.OptionsFilter.AllowFilter = False
        Me.colValorParcelaGetnet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Valor Parcela Getnet", "{0:#,###0.00;-#,###0.00}")})
        Me.colValorParcelaGetnet.Visible = True
        Me.colValorParcelaGetnet.VisibleIndex = 11
        Me.colValorParcelaGetnet.Width = 129
        '
        'UltraOptionSet1
        '
        Appearance1.ForeColor = System.Drawing.Color.White
        Me.UltraOptionSet1.ItemAppearance = Appearance1
        ValueListItem2.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem2.DataValue = "Em aberto"
        ValueListItem2.DisplayText = "Em aberto"
        ValueListItem3.DataValue = "Recebidos"
        ValueListItem3.DisplayText = "Recebidos"
        ValueListItem1.DataValue = "Todos"
        ValueListItem1.DisplayText = "Todos"
        Me.UltraOptionSet1.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3, ValueListItem1})
        Me.UltraOptionSet1.ItemSpacingHorizontal = 20
        Me.UltraOptionSet1.Location = New System.Drawing.Point(549, 199)
        Me.UltraOptionSet1.Name = "UltraOptionSet1"
        Me.UltraOptionSet1.Size = New System.Drawing.Size(240, 18)
        Me.UltraOptionSet1.TabIndex = 9
        Me.UltraOptionSet1.Visible = False
        '
        'XtraFolderBrowserDialog
        '
        Me.XtraFolderBrowserDialog.DialogStyle = DevExpress.Utils.CommonDialogs.FolderBrowserDialogStyle.Wide
        Me.XtraFolderBrowserDialog.SelectedPath = "XtraFolderBrowserDialog1"
        Me.XtraFolderBrowserDialog.Title = "SELECIONAR PASTA PARA SALVAR A PLANILHA EXCEL"
        '
        'VI_GetnetTableAdapter
        '
        Me.VI_GetnetTableAdapter.ClearBeforeFill = True
        '
        'frmGetnetDG
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.ClientSize = New System.Drawing.Size(1338, 722)
        Me.Controls.Add(Me.UltraOptionSet1)
        Me.Controls.Add(Me.ClientesGridControl)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IconOptions.Icon = CType(resources.GetObject("frmGetnetDG.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.MaximizeBox = False
        Me.Name = "frmGetnetDG"
        Me.Ribbon = Me.ribbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VIGetnetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraOptionSet1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ClientesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UltraOptionSet1 As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraFolderBrowserDialog As DevExpress.XtraEditors.XtraFolderBrowserDialog
    Friend WithEvents DsComercial As dsComercial
    Friend WithEvents VIGetnetBindingSource As BindingSource
    Friend WithEvents VI_GetnetTableAdapter As dsComercialTableAdapters.VI_GetnetTableAdapter
    Friend WithEvents colVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalGetnet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorParcelaGetnet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcelas As DevExpress.XtraGrid.Columns.GridColumn
End Class
