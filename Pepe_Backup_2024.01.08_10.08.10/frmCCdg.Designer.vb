Partial Public Class frmCCdg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCCdg))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule5 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue5 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule6 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue6 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.colReal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOuro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDolar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCartão = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCCDeb = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaldos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExtratos = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ClientesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CC2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCC = New Pepe.dsCC()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorTransf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAbrir = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCC = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Saldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UltraOptionSet1 = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.XtraFolderBrowserDialog = New DevExpress.XtraEditors.XtraFolderBrowserDialog(Me.components)
        Me.CC2TableAdapter = New Pepe.dsCCTableAdapters.CC2TableAdapter()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CC2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraOptionSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colReal
        '
        Me.colReal.AppearanceHeader.Options.UseTextOptions = True
        Me.colReal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReal.Caption = "Cash"
        Me.colReal.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colReal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colReal.FieldName = "Real"
        Me.colReal.Name = "colReal"
        Me.colReal.OptionsColumn.AllowEdit = False
        Me.colReal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colReal.Visible = True
        Me.colReal.VisibleIndex = 4
        Me.colReal.Width = 94
        '
        'colOuro
        '
        Me.colOuro.AppearanceHeader.Options.UseTextOptions = True
        Me.colOuro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOuro.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colOuro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOuro.FieldName = "Ouro"
        Me.colOuro.Name = "colOuro"
        Me.colOuro.OptionsColumn.AllowEdit = False
        Me.colOuro.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colOuro.Visible = True
        Me.colOuro.VisibleIndex = 6
        Me.colOuro.Width = 87
        '
        'colDolar
        '
        Me.colDolar.AppearanceHeader.Options.UseTextOptions = True
        Me.colDolar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDolar.Caption = "Dólar"
        Me.colDolar.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colDolar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDolar.FieldName = "Dolar"
        Me.colDolar.Name = "colDolar"
        Me.colDolar.OptionsColumn.AllowEdit = False
        Me.colDolar.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDolar.Visible = True
        Me.colDolar.VisibleIndex = 5
        Me.colDolar.Width = 83
        '
        'colCheque
        '
        Me.colCheque.AppearanceHeader.Options.UseTextOptions = True
        Me.colCheque.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCheque.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colCheque.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCheque.FieldName = "Cheque"
        Me.colCheque.Name = "colCheque"
        Me.colCheque.OptionsColumn.AllowEdit = False
        Me.colCheque.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCheque.Visible = True
        Me.colCheque.VisibleIndex = 7
        Me.colCheque.Width = 88
        '
        'colCartão
        '
        Me.colCartão.AppearanceHeader.Options.UseTextOptions = True
        Me.colCartão.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCartão.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colCartão.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCartão.FieldName = "Cartão"
        Me.colCartão.Name = "colCartão"
        Me.colCartão.OptionsColumn.AllowEdit = False
        Me.colCartão.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCartão.Visible = True
        Me.colCartão.VisibleIndex = 8
        Me.colCartão.Width = 97
        '
        'colCCDeb
        '
        Me.colCCDeb.AppearanceHeader.Options.UseTextOptions = True
        Me.colCCDeb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCCDeb.Caption = "Débito C.C."
        Me.colCCDeb.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colCCDeb.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCCDeb.FieldName = "CCDeb"
        Me.colCCDeb.Name = "colCCDeb"
        Me.colCCDeb.OptionsColumn.AllowEdit = False
        Me.colCCDeb.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCCDeb.Visible = True
        Me.colCCDeb.VisibleIndex = 9
        Me.colCCDeb.Width = 97
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnNovo, Me.btnSalvar, Me.btnUndo, Me.btnPrint, Me.btnExcel, Me.btnSaldos, Me.btnExtratos})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 12
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
        '
        'btnSaldos
        '
        Me.btnSaldos.Caption = "Saldos"
        Me.btnSaldos.Id = 10
        Me.btnSaldos.ImageOptions.Image = CType(resources.GetObject("btnSaldos.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSaldos.ImageOptions.LargeImage = CType(resources.GetObject("btnSaldos.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSaldos.Name = "btnSaldos"
        Me.btnSaldos.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        '
        'btnExtratos
        '
        Me.btnExtratos.Caption = "Extratos"
        Me.btnExtratos.Id = 11
        Me.btnExtratos.ImageOptions.Image = CType(resources.GetObject("btnExtratos.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExtratos.ImageOptions.LargeImage = CType(resources.GetObject("btnExtratos.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnExtratos.Name = "btnExtratos"
        Me.btnExtratos.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
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
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnExtratos)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnSaldos)
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
        Me.LabelControl1.Location = New System.Drawing.Point(566, 151)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(206, 31)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Conta Corrente"
        '
        'ClientesGridControl
        '
        Me.ClientesGridControl.DataSource = Me.CC2BindingSource
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
        Me.ClientesGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnAbrir, Me.btnCC})
        Me.ClientesGridControl.Size = New System.Drawing.Size(1338, 538)
        Me.ClientesGridControl.TabIndex = 6
        Me.ClientesGridControl.UseEmbeddedNavigator = True
        Me.ClientesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CC2BindingSource
        '
        Me.CC2BindingSource.DataMember = "CC2"
        Me.CC2BindingSource.DataSource = Me.DsCC
        Me.CC2BindingSource.Sort = "Cliente asc, DT desc"
        '
        'DsCC
        '
        Me.DsCC.DataSetName = "dsCC"
        Me.DsCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDCliente, Me.colCliente, Me.colDT, Me.colReal, Me.colOuro, Me.colDolar, Me.colCheque, Me.colCartão, Me.colCCDeb, Me.GridColumn1, Me.colValorTransf, Me.GridColumn2, Me.GridColumn3, Me.Saldo})
        GridFormatRule1.Column = Me.colReal
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.DimGray
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = New Decimal(New Integer() {0, 0, 0, 131072})
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.colOuro
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.DimGray
        FormatConditionRuleValue2.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = New Decimal(New Integer() {0, 0, 0, 131072})
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.Column = Me.colDolar
        GridFormatRule3.Name = "Format2"
        FormatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.DimGray
        FormatConditionRuleValue3.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue3.Value1 = New Decimal(New Integer() {0, 0, 0, 131072})
        GridFormatRule3.Rule = FormatConditionRuleValue3
        GridFormatRule4.Column = Me.colCheque
        GridFormatRule4.Name = "Format3"
        FormatConditionRuleValue4.Appearance.ForeColor = System.Drawing.Color.DimGray
        FormatConditionRuleValue4.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue4.Value1 = New Decimal(New Integer() {0, 0, 0, 131072})
        GridFormatRule4.Rule = FormatConditionRuleValue4
        GridFormatRule5.Column = Me.colCartão
        GridFormatRule5.Name = "Format4"
        FormatConditionRuleValue5.Appearance.ForeColor = System.Drawing.Color.DimGray
        FormatConditionRuleValue5.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue5.Value1 = New Decimal(New Integer() {0, 0, 0, 131072})
        GridFormatRule5.Rule = FormatConditionRuleValue5
        GridFormatRule6.Column = Me.colCCDeb
        GridFormatRule6.Name = "Format5"
        FormatConditionRuleValue6.Appearance.ForeColor = System.Drawing.Color.DimGray
        FormatConditionRuleValue6.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue6.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue6.Value1 = New Decimal(New Integer() {0, 0, 0, 131072})
        GridFormatRule6.Rule = FormatConditionRuleValue6
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.FormatRules.Add(GridFormatRule2)
        Me.GridView1.FormatRules.Add(GridFormatRule3)
        Me.GridView1.FormatRules.Add(GridFormatRule4)
        Me.GridView1.FormatRules.Add(GridFormatRule5)
        Me.GridView1.FormatRules.Add(GridFormatRule6)
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
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCliente, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDT, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID
        '
        Me.colID.AppearanceHeader.Options.UseTextOptions = True
        Me.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'colIDCliente
        '
        Me.colIDCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colIDCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIDCliente.FieldName = "IDCliente"
        Me.colIDCliente.Name = "colIDCliente"
        Me.colIDCliente.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
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
        Me.colCliente.VisibleIndex = 1
        Me.colCliente.Width = 258
        '
        'colDT
        '
        Me.colDT.AppearanceCell.Options.UseTextOptions = True
        Me.colDT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDT.AppearanceHeader.Options.UseTextOptions = True
        Me.colDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDT.Caption = "Data"
        Me.colDT.FieldName = "DT"
        Me.colDT.Name = "colDT"
        Me.colDT.OptionsColumn.AllowEdit = False
        Me.colDT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDT.Visible = True
        Me.colDT.VisibleIndex = 2
        Me.colDT.Width = 121
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Operação"
        Me.GridColumn1.FieldName = "tp"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        Me.GridColumn1.Width = 86
        '
        'colValorTransf
        '
        Me.colValorTransf.AppearanceHeader.Options.UseTextOptions = True
        Me.colValorTransf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colValorTransf.Caption = "Transferência"
        Me.colValorTransf.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colValorTransf.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorTransf.FieldName = "ValorTransf"
        Me.colValorTransf.Name = "colValorTransf"
        Me.colValorTransf.OptionsColumn.AllowEdit = False
        Me.colValorTransf.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colValorTransf.Visible = True
        Me.colValorTransf.VisibleIndex = 10
        Me.colValorTransf.Width = 113
        '
        'GridColumn2
        '
        Me.GridColumn2.ColumnEdit = Me.btnAbrir
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn2.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn2.OptionsFilter.AllowFilter = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 24
        '
        'btnAbrir
        '
        Me.btnAbrir.AutoHeight = False
        Me.btnAbrir.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Extrato"
        Me.GridColumn3.ColumnEdit = Me.btnCC
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn3.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn3.OptionsFilter.AllowFilter = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 12
        Me.GridColumn3.Width = 54
        '
        'btnCC
        '
        Me.btnCC.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnCC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnCC.Name = "btnCC"
        Me.btnCC.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Saldo
        '
        Me.Saldo.AppearanceHeader.Options.UseTextOptions = True
        Me.Saldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Saldo.Caption = "Saldo"
        Me.Saldo.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.Saldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Saldo.FieldName = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Saldo.Visible = True
        Me.Saldo.VisibleIndex = 11
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
        'CC2TableAdapter
        '
        Me.CC2TableAdapter.ClearBeforeFill = True
        '
        'Timer
        '
        Me.Timer.Interval = 3000
        '
        'frmCCdg
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
        Me.IconOptions.Icon = CType(resources.GetObject("frmCCdg.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.MaximizeBox = False
        Me.Name = "frmCCdg"
        Me.Ribbon = Me.ribbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CC2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCC, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnNovo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ClientesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UltraOptionSet1 As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraFolderBrowserDialog As DevExpress.XtraEditors.XtraFolderBrowserDialog
    Friend WithEvents DsCC As dsCC
    Friend WithEvents CC2BindingSource As BindingSource
    Friend WithEvents CC2TableAdapter As dsCCTableAdapters.CC2TableAdapter
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOuro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDolar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCartão As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCCDeb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTransf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAbrir As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCC As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnSaldos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExtratos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Saldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer As Timer
End Class
