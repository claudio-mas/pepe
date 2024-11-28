Partial Public Class frmMatPrimaDG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatPrimaDG))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
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
        Me.colQtSai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLancaCC = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCompras = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPeçasCompradas = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.lblCliente = New DevExpress.XtraEditors.LabelControl()
        Me.CONSERTOSGridControl = New DevExpress.XtraGrid.GridControl()
        Me.TabMatPrimaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMatPrima = New Pepe.dsMatPrima()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmMes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colaAno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdMatPrima = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TabMateriaPrimaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colQtEnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colQtSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnAbrir = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TabMatPrimaTableAdapter = New Pepe.dsMatPrimaTableAdapters.tabMatPrimaTableAdapter()
        Me.cboMes = New DevExpress.XtraEditors.LookUpEdit()
        Me.MesesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MesesTableAdapter = New Pepe.dsMatPrimaTableAdapters.MesesTableAdapter()
        Me.cboAno = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TabMateriaPrimaTableAdapter = New Pepe.dsMatPrimaTableAdapters.tabMateriaPrimaTableAdapter()
        Me.TableAdapterManager = New Pepe.dsMatPrimaTableAdapters.TableAdapterManager()
        Me.GroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.btnImp = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cboAno2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboMes2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboAno1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboMes1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupBoxW = New System.Windows.Forms.GroupBox()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSERTOSGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabMatPrimaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMatPrima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabMateriaPrimaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl.SuspendLayout()
        CType(Me.cboAno2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMes2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAno1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMes1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colQtSai
        '
        Me.colQtSai.AppearanceCell.Options.UseTextOptions = True
        Me.colQtSai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtSai.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtSai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtSai.Caption = "Qtde. Saída"
        Me.colQtSai.FieldName = "QtSai"
        Me.colQtSai.Name = "colQtSai"
        Me.colQtSai.OptionsColumn.AllowEdit = False
        Me.colQtSai.OptionsColumn.AllowFocus = False
        Me.colQtSai.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colQtSai.OptionsColumn.ReadOnly = True
        Me.colQtSai.OptionsFilter.AllowAutoFilter = False
        Me.colQtSai.OptionsFilter.AllowFilter = False
        Me.colQtSai.Visible = True
        Me.colQtSai.VisibleIndex = 5
        Me.colQtSai.Width = 96
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnSalvar, Me.btnUndo, Me.btnLancaCC, Me.btnCompras, Me.btnPeçasCompradas})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 11
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl1.ShowToolbarCustomizeItem = False
        Me.ribbonControl1.Size = New System.Drawing.Size(1338, 132)
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
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "CONSERTOS"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnFechar)
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
        Me.lblCliente.Location = New System.Drawing.Point(453, 127)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(432, 24)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Matéria Prima"
        '
        'CONSERTOSGridControl
        '
        Me.CONSERTOSGridControl.DataSource = Me.TabMatPrimaBindingSource
        Me.CONSERTOSGridControl.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.CONSERTOSGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.CONSERTOSGridControl.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.CONSERTOSGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.CONSERTOSGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.CONSERTOSGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.CONSERTOSGridControl.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.CONSERTOSGridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CONSERTOSGridControl.EmbeddedNavigator.TextStringFormat = "{0} / {1}"
        Me.CONSERTOSGridControl.Location = New System.Drawing.Point(280, 225)
        Me.CONSERTOSGridControl.MainView = Me.GridView1
        Me.CONSERTOSGridControl.MenuManager = Me.ribbonControl1
        Me.CONSERTOSGridControl.Name = "CONSERTOSGridControl"
        Me.CONSERTOSGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnAbrir, Me.RepositoryItemSpinEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4, Me.RepositoryItemSpinEdit2, Me.RepositoryItemSpinEdit3, Me.RepositoryItemSpinEdit4})
        Me.CONSERTOSGridControl.Size = New System.Drawing.Size(778, 232)
        Me.CONSERTOSGridControl.TabIndex = 2
        Me.CONSERTOSGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'TabMatPrimaBindingSource
        '
        Me.TabMatPrimaBindingSource.DataMember = "tabMatPrima"
        Me.TabMatPrimaBindingSource.DataSource = Me.DsMatPrima
        '
        'DsMatPrima
        '
        Me.DsMatPrima.DataSetName = "dsMatPrima"
        Me.DsMatPrima.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.Options.UseTextOptions = True
        Me.GridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colmMes, Me.colaAno, Me.colIdMatPrima, Me.colQtEnt, Me.colPrUnit, Me.colTotal, Me.colQtSai, Me.colQtSaldo, Me.colValSaldo, Me.GridColumn1})
        GridFormatRule1.Column = Me.colQtSai
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = 0
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.GridControl = Me.CONSERTOSGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsFind.FindNullPrompt = "Pequisar..."
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colmMes
        '
        Me.colmMes.FieldName = "mMes"
        Me.colmMes.Name = "colmMes"
        '
        'colaAno
        '
        Me.colaAno.FieldName = "aAno"
        Me.colaAno.Name = "colaAno"
        '
        'colIdMatPrima
        '
        Me.colIdMatPrima.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIdMatPrima.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colIdMatPrima.AppearanceCell.Options.UseBackColor = True
        Me.colIdMatPrima.AppearanceCell.Options.UseFont = True
        Me.colIdMatPrima.AppearanceCell.Options.UseTextOptions = True
        Me.colIdMatPrima.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIdMatPrima.AppearanceHeader.Options.UseTextOptions = True
        Me.colIdMatPrima.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIdMatPrima.Caption = "Matéria Prima"
        Me.colIdMatPrima.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colIdMatPrima.FieldName = "IdMatPrima"
        Me.colIdMatPrima.Name = "colIdMatPrima"
        Me.colIdMatPrima.OptionsColumn.AllowEdit = False
        Me.colIdMatPrima.OptionsColumn.AllowFocus = False
        Me.colIdMatPrima.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colIdMatPrima.OptionsColumn.ReadOnly = True
        Me.colIdMatPrima.OptionsFilter.AllowAutoFilter = False
        Me.colIdMatPrima.OptionsFilter.AllowFilter = False
        Me.colIdMatPrima.Visible = True
        Me.colIdMatPrima.VisibleIndex = 0
        Me.colIdMatPrima.Width = 153
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 19, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Unidade", "Unidade", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.TabMateriaPrimaBindingSource
        Me.RepositoryItemLookUpEdit3.DisplayMember = "MatPrima"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.ValueMember = "Id"
        '
        'TabMateriaPrimaBindingSource
        '
        Me.TabMateriaPrimaBindingSource.DataMember = "tabMateriaPrima"
        Me.TabMateriaPrimaBindingSource.DataSource = Me.DsMatPrima
        '
        'colQtEnt
        '
        Me.colQtEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colQtEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtEnt.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtEnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtEnt.Caption = "Qtde. Entrada"
        Me.colQtEnt.FieldName = "QtEnt"
        Me.colQtEnt.Name = "colQtEnt"
        Me.colQtEnt.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colQtEnt.OptionsFilter.AllowAutoFilter = False
        Me.colQtEnt.OptionsFilter.AllowFilter = False
        Me.colQtEnt.Visible = True
        Me.colQtEnt.VisibleIndex = 2
        Me.colQtEnt.Width = 104
        '
        'colPrUnit
        '
        Me.colPrUnit.AppearanceCell.Options.UseTextOptions = True
        Me.colPrUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPrUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrUnit.Caption = "Preço Unitário"
        Me.colPrUnit.ColumnEdit = Me.RepositoryItemSpinEdit2
        Me.colPrUnit.FieldName = "PrUnit"
        Me.colPrUnit.Name = "colPrUnit"
        Me.colPrUnit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPrUnit.OptionsFilter.AllowAutoFilter = False
        Me.colPrUnit.OptionsFilter.AllowFilter = False
        Me.colPrUnit.Visible = True
        Me.colPrUnit.VisibleIndex = 3
        Me.colPrUnit.Width = 91
        '
        'RepositoryItemSpinEdit2
        '
        Me.RepositoryItemSpinEdit2.AutoHeight = False
        Me.RepositoryItemSpinEdit2.BeepOnError = True
        Me.RepositoryItemSpinEdit2.MaskSettings.Set("mask", "n")
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
        Me.RepositoryItemSpinEdit2.UseMaskAsDisplayFormat = True
        '
        'colTotal
        '
        Me.colTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotal.Caption = "Total (R$)"
        Me.colTotal.ColumnEdit = Me.RepositoryItemSpinEdit3
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTotal.OptionsFilter.AllowAutoFilter = False
        Me.colTotal.OptionsFilter.AllowFilter = False
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 4
        Me.colTotal.Width = 91
        '
        'RepositoryItemSpinEdit3
        '
        Me.RepositoryItemSpinEdit3.AutoHeight = False
        Me.RepositoryItemSpinEdit3.BeepOnError = True
        Me.RepositoryItemSpinEdit3.MaskSettings.Set("mask", "n")
        Me.RepositoryItemSpinEdit3.MaskSettings.Set("autoHideDecimalSeparator", Nothing)
        Me.RepositoryItemSpinEdit3.Name = "RepositoryItemSpinEdit3"
        Me.RepositoryItemSpinEdit3.UseMaskAsDisplayFormat = True
        '
        'colQtSaldo
        '
        Me.colQtSaldo.AppearanceCell.Options.UseTextOptions = True
        Me.colQtSaldo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtSaldo.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtSaldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtSaldo.Caption = "Saldo Qtde."
        Me.colQtSaldo.FieldName = "QtSaldo"
        Me.colQtSaldo.Name = "colQtSaldo"
        Me.colQtSaldo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colQtSaldo.OptionsFilter.AllowAutoFilter = False
        Me.colQtSaldo.OptionsFilter.AllowFilter = False
        Me.colQtSaldo.Visible = True
        Me.colQtSaldo.VisibleIndex = 6
        Me.colQtSaldo.Width = 85
        '
        'colValSaldo
        '
        Me.colValSaldo.AppearanceCell.Options.UseTextOptions = True
        Me.colValSaldo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValSaldo.AppearanceHeader.Options.UseTextOptions = True
        Me.colValSaldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colValSaldo.Caption = "Saldo R$"
        Me.colValSaldo.ColumnEdit = Me.RepositoryItemSpinEdit4
        Me.colValSaldo.FieldName = "ValSaldo"
        Me.colValSaldo.Name = "colValSaldo"
        Me.colValSaldo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colValSaldo.OptionsFilter.AllowAutoFilter = False
        Me.colValSaldo.OptionsFilter.AllowFilter = False
        Me.colValSaldo.Visible = True
        Me.colValSaldo.VisibleIndex = 7
        Me.colValSaldo.Width = 87
        '
        'RepositoryItemSpinEdit4
        '
        Me.RepositoryItemSpinEdit4.AutoHeight = False
        Me.RepositoryItemSpinEdit4.BeepOnError = True
        Me.RepositoryItemSpinEdit4.MaskSettings.Set("mask", "n")
        Me.RepositoryItemSpinEdit4.Name = "RepositoryItemSpinEdit4"
        Me.RepositoryItemSpinEdit4.UseMaskAsDisplayFormat = True
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Unidade"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.GridColumn1.FieldName = "IdMatPrima"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn1.OptionsFilter.AllowFilter = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 66
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 19, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Unidade", "Unidade", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit4.DataSource = Me.TabMateriaPrimaBindingSource
        Me.RepositoryItemLookUpEdit4.DisplayMember = "Unidade"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.ValueMember = "Id"
        '
        'btnAbrir
        '
        Me.btnAbrir.AutoHeight = False
        EditorButtonImageOptions1.ImageUri.Uri = "Zoom;Size16x16;Colored"
        Me.btnAbrir.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cli", "Clientes", 34, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCliente", "ID Cliente", 57, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Cli"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ReadOnly = True
        Me.RepositoryItemLookUpEdit1.ValueMember = "IDCliente"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID Vendedora", "ID Vendedora", 89, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendedora", "Vendedores", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Vendedora"
        Me.RepositoryItemLookUpEdit2.DropDownRows = 16
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ValueMember = "ID Vendedora"
        '
        'TabMatPrimaTableAdapter
        '
        Me.TabMatPrimaTableAdapter.ClearBeforeFill = True
        '
        'cboMes
        '
        Me.cboMes.Location = New System.Drawing.Point(582, 172)
        Me.cboMes.MenuManager = Me.ribbonControl1
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.Properties.Appearance.Options.UseFont = True
        Me.cboMes.Properties.Appearance.Options.UseTextOptions = True
        Me.cboMes.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboMes.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMes.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mMes", "Mês", 39, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mCod", "m Cod", 39, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboMes.Properties.DataSource = Me.MesesBindingSource
        Me.cboMes.Properties.DisplayMember = "mMes"
        Me.cboMes.Properties.DropDownRows = 12
        Me.cboMes.Properties.ValueMember = "mCod"
        Me.cboMes.Size = New System.Drawing.Size(108, 24)
        Me.cboMes.TabIndex = 0
        '
        'MesesBindingSource
        '
        Me.MesesBindingSource.DataMember = "Meses"
        Me.MesesBindingSource.DataSource = Me.DsMatPrima
        '
        'MesesTableAdapter
        '
        Me.MesesTableAdapter.ClearBeforeFill = True
        '
        'cboAno
        '
        Me.cboAno.EditValue = ""
        Me.cboAno.Location = New System.Drawing.Point(693, 172)
        Me.cboAno.MenuManager = Me.ribbonControl1
        Me.cboAno.Name = "cboAno"
        Me.cboAno.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAno.Properties.Appearance.Options.UseFont = True
        Me.cboAno.Properties.Appearance.Options.UseTextOptions = True
        Me.cboAno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboAno.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAno.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAno.Properties.DropDownRows = 11
        Me.cboAno.Properties.Items.AddRange(New Object() {"2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cboAno.Size = New System.Drawing.Size(63, 24)
        Me.cboAno.TabIndex = 1
        '
        'TabMateriaPrimaTableAdapter
        '
        Me.TabMateriaPrimaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._1TabPeçasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tabMateriaPrimaTableAdapter = Me.TabMateriaPrimaTableAdapter
        Me.TableAdapterManager.tabMatPrimaTableAdapter = Me.TabMatPrimaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Pepe.dsMatPrimaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupControl
        '
        Me.GroupControl.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl.AppearanceCaption.Options.UseFont = True
        Me.GroupControl.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl.Controls.Add(Me.btnImp)
        Me.GroupControl.Controls.Add(Me.LabelControl2)
        Me.GroupControl.Controls.Add(Me.LabelControl1)
        Me.GroupControl.Controls.Add(Me.cboAno2)
        Me.GroupControl.Controls.Add(Me.cboMes2)
        Me.GroupControl.Controls.Add(Me.cboAno1)
        Me.GroupControl.Controls.Add(Me.cboMes1)
        Me.GroupControl.Location = New System.Drawing.Point(528, 580)
        Me.GroupControl.Name = "GroupControl"
        Me.GroupControl.Size = New System.Drawing.Size(283, 117)
        Me.GroupControl.TabIndex = 5
        Me.GroupControl.Text = "RELATÓRIO"
        '
        'btnImp
        '
        Me.btnImp.AutoSize = True
        Me.btnImp.ImageOptions.Image = Global.Pepe.My.Resources.Resources.print_32x321
        Me.btnImp.Location = New System.Drawing.Point(234, 53)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btnImp.Size = New System.Drawing.Size(38, 36)
        Me.btnImp.TabIndex = 8
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseImageAlign = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl2.Location = New System.Drawing.Point(10, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(25, 24)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "até"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseImageAlign = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(10, 44)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 24)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "De"
        '
        'cboAno2
        '
        Me.cboAno2.EditValue = ""
        Me.cboAno2.Location = New System.Drawing.Point(149, 74)
        Me.cboAno2.MenuManager = Me.ribbonControl1
        Me.cboAno2.Name = "cboAno2"
        Me.cboAno2.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAno2.Properties.Appearance.Options.UseFont = True
        Me.cboAno2.Properties.Appearance.Options.UseTextOptions = True
        Me.cboAno2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboAno2.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAno2.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboAno2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAno2.Properties.DropDownRows = 11
        Me.cboAno2.Properties.Items.AddRange(New Object() {"2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cboAno2.Size = New System.Drawing.Size(63, 24)
        Me.cboAno2.TabIndex = 5
        '
        'cboMes2
        '
        Me.cboMes2.Location = New System.Drawing.Point(39, 74)
        Me.cboMes2.MenuManager = Me.ribbonControl1
        Me.cboMes2.Name = "cboMes2"
        Me.cboMes2.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes2.Properties.Appearance.Options.UseFont = True
        Me.cboMes2.Properties.Appearance.Options.UseTextOptions = True
        Me.cboMes2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboMes2.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes2.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboMes2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMes2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mMes", "Mês", 39, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mCod", "m Cod", 39, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboMes2.Properties.DataSource = Me.MesesBindingSource
        Me.cboMes2.Properties.DisplayMember = "mMes"
        Me.cboMes2.Properties.DropDownRows = 12
        Me.cboMes2.Properties.ValueMember = "mCod"
        Me.cboMes2.Size = New System.Drawing.Size(108, 24)
        Me.cboMes2.TabIndex = 4
        '
        'cboAno1
        '
        Me.cboAno1.EditValue = ""
        Me.cboAno1.Location = New System.Drawing.Point(149, 44)
        Me.cboAno1.MenuManager = Me.ribbonControl1
        Me.cboAno1.Name = "cboAno1"
        Me.cboAno1.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAno1.Properties.Appearance.Options.UseFont = True
        Me.cboAno1.Properties.Appearance.Options.UseTextOptions = True
        Me.cboAno1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboAno1.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAno1.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboAno1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAno1.Properties.DropDownRows = 11
        Me.cboAno1.Properties.Items.AddRange(New Object() {"2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cboAno1.Size = New System.Drawing.Size(63, 24)
        Me.cboAno1.TabIndex = 3
        '
        'cboMes1
        '
        Me.cboMes1.Location = New System.Drawing.Point(39, 44)
        Me.cboMes1.MenuManager = Me.ribbonControl1
        Me.cboMes1.Name = "cboMes1"
        Me.cboMes1.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes1.Properties.Appearance.Options.UseFont = True
        Me.cboMes1.Properties.Appearance.Options.UseTextOptions = True
        Me.cboMes1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboMes1.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes1.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboMes1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMes1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mMes", "Mês", 39, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mCod", "m Cod", 39, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboMes1.Properties.DataSource = Me.MesesBindingSource
        Me.cboMes1.Properties.DisplayMember = "mMes"
        Me.cboMes1.Properties.DropDownRows = 12
        Me.cboMes1.Properties.ValueMember = "mCod"
        Me.cboMes1.Size = New System.Drawing.Size(108, 24)
        Me.cboMes1.TabIndex = 2
        '
        'GroupBoxW
        '
        Me.GroupBoxW.BackColor = System.Drawing.Color.DarkRed
        Me.GroupBoxW.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxW.Location = New System.Drawing.Point(784, 226)
        Me.GroupBoxW.Name = "GroupBoxW"
        Me.GroupBoxW.Size = New System.Drawing.Size(4, 231)
        Me.GroupBoxW.TabIndex = 9
        Me.GroupBoxW.TabStop = False
        '
        'frmMatPrimaDG
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1338, 722)
        Me.Controls.Add(Me.GroupBoxW)
        Me.Controls.Add(Me.GroupControl)
        Me.Controls.Add(Me.cboAno)
        Me.Controls.Add(Me.cboMes)
        Me.Controls.Add(Me.CONSERTOSGridControl)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IconOptions.Icon = CType(resources.GetObject("frmMatPrimaDG.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmMatPrimaDG"
        Me.Ribbon = Me.ribbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSERTOSGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabMatPrimaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMatPrima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabMateriaPrimaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl.ResumeLayout(False)
        Me.GroupControl.PerformLayout()
        CType(Me.cboAno2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMes2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAno1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMes1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CONSERTOSGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAbrir As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsMatPrima As dsMatPrima
    Friend WithEvents TabMatPrimaBindingSource As BindingSource
    Friend WithEvents TabMatPrimaTableAdapter As dsMatPrimaTableAdapters.tabMatPrimaTableAdapter
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmMes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaAno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdMatPrima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtSai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboMes As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MesesBindingSource As BindingSource
    Friend WithEvents MesesTableAdapter As dsMatPrimaTableAdapters.MesesTableAdapter
    Friend WithEvents cboAno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TabMateriaPrimaBindingSource As BindingSource
    Friend WithEvents TabMateriaPrimaTableAdapter As dsMatPrimaTableAdapters.tabMateriaPrimaTableAdapter
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TableAdapterManager As dsMatPrimaTableAdapters.TableAdapterManager
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemSpinEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemSpinEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnImp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboAno2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboMes2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboAno1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboMes1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupBoxW As GroupBox
End Class
