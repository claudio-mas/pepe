Partial Public Class frmInconsist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInconsist))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim EditorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLancaCC = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCompras = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPeçasCompradas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo2 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.lblCliente = New DevExpress.XtraEditors.LabelControl()
        Me.dt1 = New DevExpress.XtraEditors.DateEdit()
        Me.XtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Inconsist1GridControl = New DevExpress.XtraGrid.GridControl()
        Me.Inconsist1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsInconsist = New Pepe.dsInconsist()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDPeça = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAbrir = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colClasse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModêlo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataReg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFamília = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.Inconsist2GridControl = New DevExpress.XtraGrid.GridControl()
        Me.Inconsist2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAbrir2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.Inconsist4GridControl = New DevExpress.XtraGrid.GridControl()
        Me.Inconsist4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAbrir4 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVenda1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataVenda1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.Inconsist5GridControl = New DevExpress.XtraGrid.GridControl()
        Me.Inconsist5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAbrir5 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVenda2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataVenda2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCli1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorFinal1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Inconsist1TableAdapter = New Pepe.dsInconsistTableAdapters.Inconsist1TableAdapter()
        Me.TableAdapterManager1 = New Pepe.dsInconsistTableAdapters.TableAdapterManager()
        Me.Inconsist4TableAdapter = New Pepe.dsInconsistTableAdapters.Inconsist4TableAdapter()
        Me.Inconsist2TableAdapter = New Pepe.dsInconsistTableAdapters.Inconsist2TableAdapter()
        Me.Inconsist5TableAdapter = New Pepe.dsInconsistTableAdapters.Inconsist5TableAdapter()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Inconsist1GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inconsist1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInconsist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.Inconsist2GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inconsist2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrir2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.Inconsist4GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inconsist4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrir4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.Inconsist5GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inconsist5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrir5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnSalvar, Me.btnUndo, Me.btnLancaCC, Me.btnCompras, Me.btnPeçasCompradas, Me.btnSalvar2, Me.btnUndo2})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 12
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
        'btnSalvar2
        '
        Me.btnSalvar2.Caption = "Salvar"
        Me.btnSalvar2.Id = 10
        Me.btnSalvar2.ImageOptions.Image = CType(resources.GetObject("btnSalvar2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalvar2.ImageOptions.LargeImage = CType(resources.GetObject("btnSalvar2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSalvar2.Name = "btnSalvar2"
        '
        'btnUndo2
        '
        Me.btnUndo2.Caption = "Desfazer"
        Me.btnUndo2.Id = 11
        Me.btnUndo2.ImageOptions.Image = CType(resources.GetObject("btnUndo2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUndo2.ImageOptions.LargeImage = CType(resources.GetObject("btnUndo2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnUndo2.Name = "btnUndo2"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "INCONSISTÊNCIAS"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnFechar)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSalvar2)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnUndo2)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Visible = False
        '
        'lblCliente
        '
        Me.lblCliente.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Appearance.ForeColor = System.Drawing.Color.DarkRed
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
        Me.lblCliente.Location = New System.Drawing.Point(356, 89)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(432, 24)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Conta corrente"
        Me.lblCliente.Visible = False
        '
        'dt1
        '
        Me.dt1.EditValue = Nothing
        Me.dt1.Location = New System.Drawing.Point(708, 119)
        Me.dt1.MenuManager = Me.ribbonControl1
        Me.dt1.Name = "dt1"
        Me.dt1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dt1.Properties.Appearance.Options.UseTextOptions = True
        Me.dt1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dt1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.dt1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt1.Size = New System.Drawing.Size(100, 22)
        Me.dt1.TabIndex = 0
        Me.dt1.Visible = False
        '
        'XtraTabControl
        '
        Me.XtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl.Location = New System.Drawing.Point(0, 147)
        Me.XtraTabControl.Name = "XtraTabControl"
        Me.XtraTabControl.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl.Size = New System.Drawing.Size(1338, 575)
        Me.XtraTabControl.TabIndex = 19
        Me.XtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Controls.Add(Me.Inconsist1GridControl)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1333, 547)
        ToolTipItem1.ImageOptions.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipItem1.Text = "Peças que constam como vendidas, porém as vendas correspondentes não são localiza" &
    "das no sistema"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.XtraTabPage1.SuperTip = SuperToolTip1
        Me.XtraTabPage1.Text = "PEÇAS VENDIDAS SEM VENDAS"
        Me.XtraTabPage1.TooltipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'Inconsist1GridControl
        '
        Me.Inconsist1GridControl.DataSource = Me.Inconsist1BindingSource
        Me.Inconsist1GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Inconsist1GridControl.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.Inconsist1GridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.Inconsist1GridControl.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.Inconsist1GridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.Inconsist1GridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.Inconsist1GridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.Inconsist1GridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.Inconsist1GridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.Inconsist1GridControl.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.Inconsist1GridControl.EmbeddedNavigator.TextStringFormat = "{0} / {1}"
        Me.Inconsist1GridControl.Location = New System.Drawing.Point(0, 0)
        Me.Inconsist1GridControl.MainView = Me.GridView1
        Me.Inconsist1GridControl.MenuManager = Me.ribbonControl1
        Me.Inconsist1GridControl.Name = "Inconsist1GridControl"
        Me.Inconsist1GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnAbrir, Me.RepositoryItemCheckEdit1})
        Me.Inconsist1GridControl.Size = New System.Drawing.Size(1333, 547)
        Me.Inconsist1GridControl.TabIndex = 0
        Me.Inconsist1GridControl.UseEmbeddedNavigator = True
        Me.Inconsist1GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'Inconsist1BindingSource
        '
        Me.Inconsist1BindingSource.DataMember = "Inconsist1"
        Me.Inconsist1BindingSource.DataSource = Me.DsInconsist
        '
        'DsInconsist
        '
        Me.DsInconsist.DataSetName = "dsInconsist"
        Me.DsInconsist.EnforceConstraints = False
        Me.DsInconsist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDPeça, Me.GridColumn1, Me.colClasse, Me.colModêlo, Me.colDescr, Me.colDataReg, Me.colFamília, Me.colCusto, Me.colPrVenda, Me.colVendida, Me.GridColumn2})
        Me.GridView1.GridControl = Me.Inconsist1GridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindNullPrompt = "Pesquisar..."
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDataReg, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colIDPeça
        '
        Me.colIDPeça.FieldName = "IDPeça"
        Me.colIDPeça.Name = "colIDPeça"
        '
        'GridColumn1
        '
        Me.GridColumn1.ColumnEdit = Me.btnAbrir
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 28
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
        Me.colClasse.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colClasse.AppearanceCell.Options.UseFont = True
        Me.colClasse.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colClasse.AppearanceHeader.Options.UseFont = True
        Me.colClasse.AppearanceHeader.Options.UseTextOptions = True
        Me.colClasse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClasse.Caption = "Peça"
        Me.colClasse.FieldName = "Classe"
        Me.colClasse.Name = "colClasse"
        Me.colClasse.OptionsColumn.AllowEdit = False
        Me.colClasse.OptionsColumn.ReadOnly = True
        Me.colClasse.Visible = True
        Me.colClasse.VisibleIndex = 1
        Me.colClasse.Width = 85
        '
        'colModêlo
        '
        Me.colModêlo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colModêlo.AppearanceCell.Options.UseFont = True
        Me.colModêlo.AppearanceCell.Options.UseTextOptions = True
        Me.colModêlo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModêlo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colModêlo.AppearanceHeader.Options.UseFont = True
        Me.colModêlo.AppearanceHeader.Options.UseTextOptions = True
        Me.colModêlo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModêlo.Caption = "Ficha"
        Me.colModêlo.FieldName = "Modêlo"
        Me.colModêlo.Name = "colModêlo"
        Me.colModêlo.OptionsColumn.AllowEdit = False
        Me.colModêlo.OptionsColumn.ReadOnly = True
        Me.colModêlo.Visible = True
        Me.colModêlo.VisibleIndex = 2
        Me.colModêlo.Width = 146
        '
        'colDescr
        '
        Me.colDescr.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colDescr.AppearanceCell.Options.UseFont = True
        Me.colDescr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colDescr.AppearanceHeader.Options.UseFont = True
        Me.colDescr.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescr.Caption = "Observações"
        Me.colDescr.FieldName = "Descr"
        Me.colDescr.Name = "colDescr"
        Me.colDescr.OptionsColumn.AllowEdit = False
        Me.colDescr.OptionsColumn.ReadOnly = True
        Me.colDescr.Visible = True
        Me.colDescr.VisibleIndex = 7
        Me.colDescr.Width = 358
        '
        'colDataReg
        '
        Me.colDataReg.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colDataReg.AppearanceCell.Options.UseFont = True
        Me.colDataReg.AppearanceCell.Options.UseTextOptions = True
        Me.colDataReg.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataReg.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colDataReg.AppearanceHeader.Options.UseFont = True
        Me.colDataReg.AppearanceHeader.Options.UseTextOptions = True
        Me.colDataReg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataReg.Caption = "Data Reg."
        Me.colDataReg.FieldName = "DataReg"
        Me.colDataReg.Name = "colDataReg"
        Me.colDataReg.OptionsColumn.AllowEdit = False
        Me.colDataReg.OptionsColumn.ReadOnly = True
        Me.colDataReg.Visible = True
        Me.colDataReg.VisibleIndex = 4
        Me.colDataReg.Width = 122
        '
        'colFamília
        '
        Me.colFamília.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colFamília.AppearanceCell.Options.UseFont = True
        Me.colFamília.AppearanceCell.Options.UseTextOptions = True
        Me.colFamília.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFamília.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colFamília.AppearanceHeader.Options.UseFont = True
        Me.colFamília.AppearanceHeader.Options.UseTextOptions = True
        Me.colFamília.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFamília.Caption = " "
        Me.colFamília.FieldName = "Família"
        Me.colFamília.Name = "colFamília"
        Me.colFamília.OptionsColumn.AllowEdit = False
        Me.colFamília.OptionsColumn.ReadOnly = True
        Me.colFamília.Visible = True
        Me.colFamília.VisibleIndex = 3
        Me.colFamília.Width = 82
        '
        'colCusto
        '
        Me.colCusto.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colCusto.AppearanceCell.Options.UseFont = True
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
        Me.colCusto.VisibleIndex = 5
        Me.colCusto.Width = 107
        '
        'colPrVenda
        '
        Me.colPrVenda.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colPrVenda.AppearanceCell.Options.UseFont = True
        Me.colPrVenda.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colPrVenda.AppearanceHeader.Options.UseFont = True
        Me.colPrVenda.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrVenda.Caption = "Pr. Venda"
        Me.colPrVenda.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colPrVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrVenda.FieldName = "PrVenda"
        Me.colPrVenda.Name = "colPrVenda"
        Me.colPrVenda.OptionsColumn.AllowEdit = False
        Me.colPrVenda.OptionsColumn.ReadOnly = True
        Me.colPrVenda.Visible = True
        Me.colPrVenda.VisibleIndex = 6
        Me.colPrVenda.Width = 111
        '
        'colVendida
        '
        Me.colVendida.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colVendida.AppearanceCell.Options.UseFont = True
        Me.colVendida.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colVendida.AppearanceHeader.Options.UseFont = True
        Me.colVendida.AppearanceHeader.Options.UseTextOptions = True
        Me.colVendida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVendida.FieldName = "Vendida"
        Me.colVendida.Name = "colVendida"
        Me.colVendida.Visible = True
        Me.colVendida.VisibleIndex = 8
        Me.colVendida.Width = 86
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Excluir"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn2.FieldName = "Excluir"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 9
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage3.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage3.Controls.Add(Me.Inconsist2GridControl)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1333, 547)
        ToolTipItem2.ImageOptions.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ToolTipItem2.Text = "Aparentemente, as peças que estavam registradas nessas vendas foram excluídas do " &
    "sistema"
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.XtraTabPage3.SuperTip = SuperToolTip2
        Me.XtraTabPage3.Text = "VENDAS SEM PEÇAS"
        '
        'Inconsist2GridControl
        '
        Me.Inconsist2GridControl.DataSource = Me.Inconsist2BindingSource
        Me.Inconsist2GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Inconsist2GridControl.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.Inconsist2GridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.Inconsist2GridControl.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.Inconsist2GridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.Inconsist2GridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.Inconsist2GridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.Inconsist2GridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.Inconsist2GridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.Inconsist2GridControl.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.Inconsist2GridControl.EmbeddedNavigator.TextStringFormat = "{0} / {1}"
        Me.Inconsist2GridControl.Location = New System.Drawing.Point(0, 0)
        Me.Inconsist2GridControl.MainView = Me.GridView2
        Me.Inconsist2GridControl.MenuManager = Me.ribbonControl1
        Me.Inconsist2GridControl.Name = "Inconsist2GridControl"
        Me.Inconsist2GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnAbrir2})
        Me.Inconsist2GridControl.Size = New System.Drawing.Size(1333, 547)
        Me.Inconsist2GridControl.TabIndex = 0
        Me.Inconsist2GridControl.UseEmbeddedNavigator = True
        Me.Inconsist2GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'Inconsist2BindingSource
        '
        Me.Inconsist2BindingSource.DataMember = "Inconsist2"
        Me.Inconsist2BindingSource.DataSource = Me.DsInconsist
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.colId, Me.colVenda, Me.colNome, Me.colDataVenda, Me.colValorVenda})
        Me.GridView2.GridControl = Me.Inconsist2GridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsFind.AlwaysVisible = True
        Me.GridView2.OptionsFind.FindNullPrompt = "Pesquisar..."
        Me.GridView2.OptionsFind.ShowFindButton = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDataVenda, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = " "
        Me.GridColumn3.ColumnEdit = Me.btnAbrir2
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 30
        '
        'btnAbrir2
        '
        Me.btnAbrir2.AutoHeight = False
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.btnAbrir2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnAbrir2.Name = "btnAbrir2"
        Me.btnAbrir2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colVenda
        '
        Me.colVenda.AppearanceCell.Options.UseTextOptions = True
        Me.colVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVenda.AppearanceHeader.Options.UseTextOptions = True
        Me.colVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVenda.Caption = "Nº Venda"
        Me.colVenda.FieldName = "Venda"
        Me.colVenda.Name = "colVenda"
        Me.colVenda.OptionsColumn.AllowEdit = False
        Me.colVenda.Visible = True
        Me.colVenda.VisibleIndex = 1
        Me.colVenda.Width = 110
        '
        'colNome
        '
        Me.colNome.Caption = "Cliente"
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsColumn.AllowEdit = False
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 2
        Me.colNome.Width = 377
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
        Me.colDataVenda.Visible = True
        Me.colDataVenda.VisibleIndex = 3
        Me.colDataVenda.Width = 140
        '
        'colValorVenda
        '
        Me.colValorVenda.AppearanceHeader.Options.UseTextOptions = True
        Me.colValorVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colValorVenda.Caption = "Valor"
        Me.colValorVenda.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colValorVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorVenda.FieldName = "ValorVenda"
        Me.colValorVenda.Name = "colValorVenda"
        Me.colValorVenda.OptionsColumn.AllowEdit = False
        Me.colValorVenda.Visible = True
        Me.colValorVenda.VisibleIndex = 4
        Me.colValorVenda.Width = 116
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage4.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage4.Controls.Add(Me.Inconsist4GridControl)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1333, 547)
        ToolTipItem3.ImageOptions.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        ToolTipItem3.Text = "Vendas que não tiveram nenhuma peça registrada"
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.XtraTabPage4.SuperTip = SuperToolTip3
        Me.XtraTabPage4.Text = "VENDAS 'VAZIAS'"
        '
        'Inconsist4GridControl
        '
        Me.Inconsist4GridControl.DataSource = Me.Inconsist4BindingSource
        Me.Inconsist4GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Inconsist4GridControl.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.Inconsist4GridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.Inconsist4GridControl.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.Inconsist4GridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.Inconsist4GridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.Inconsist4GridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.Inconsist4GridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.Inconsist4GridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.Inconsist4GridControl.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.Inconsist4GridControl.EmbeddedNavigator.TextStringFormat = "{0} / {1}"
        Me.Inconsist4GridControl.Location = New System.Drawing.Point(0, 0)
        Me.Inconsist4GridControl.MainView = Me.GridView3
        Me.Inconsist4GridControl.MenuManager = Me.ribbonControl1
        Me.Inconsist4GridControl.Name = "Inconsist4GridControl"
        Me.Inconsist4GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnAbrir4, Me.RepositoryItemCheckEdit2})
        Me.Inconsist4GridControl.Size = New System.Drawing.Size(1333, 547)
        Me.Inconsist4GridControl.TabIndex = 0
        Me.Inconsist4GridControl.UseEmbeddedNavigator = True
        Me.Inconsist4GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'Inconsist4BindingSource
        '
        Me.Inconsist4BindingSource.DataMember = "Inconsist4"
        Me.Inconsist4BindingSource.DataSource = Me.DsInconsist
        '
        'GridView3
        '
        Me.GridView3.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridView3.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView3.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridView3.Appearance.Row.Options.UseFont = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.colId1, Me.colVenda1, Me.colCli, Me.colDataVenda1, Me.colValorFinal, Me.GridColumn5})
        Me.GridView3.GridControl = Me.Inconsist4GridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsFind.AlwaysVisible = True
        Me.GridView3.OptionsFind.FindNullPrompt = "Pesquisar..."
        Me.GridView3.OptionsFind.ShowFindButton = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDataVenda1, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = " "
        Me.GridColumn4.ColumnEdit = Me.btnAbrir4
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 29
        '
        'btnAbrir4
        '
        Me.btnAbrir4.AutoHeight = False
        EditorButtonImageOptions3.Image = CType(resources.GetObject("EditorButtonImageOptions3.Image"), System.Drawing.Image)
        Me.btnAbrir4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnAbrir4.Name = "btnAbrir4"
        Me.btnAbrir4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colId1
        '
        Me.colId1.FieldName = "Id"
        Me.colId1.Name = "colId1"
        '
        'colVenda1
        '
        Me.colVenda1.AppearanceCell.Options.UseTextOptions = True
        Me.colVenda1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVenda1.AppearanceHeader.Options.UseTextOptions = True
        Me.colVenda1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVenda1.Caption = "Nº Venda"
        Me.colVenda1.FieldName = "Venda"
        Me.colVenda1.Name = "colVenda1"
        Me.colVenda1.OptionsColumn.AllowEdit = False
        Me.colVenda1.Visible = True
        Me.colVenda1.VisibleIndex = 1
        Me.colVenda1.Width = 102
        '
        'colCli
        '
        Me.colCli.AppearanceHeader.Options.UseTextOptions = True
        Me.colCli.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCli.Caption = "Cliente"
        Me.colCli.FieldName = "Cli"
        Me.colCli.Name = "colCli"
        Me.colCli.OptionsColumn.AllowEdit = False
        Me.colCli.Visible = True
        Me.colCli.VisibleIndex = 2
        Me.colCli.Width = 336
        '
        'colDataVenda1
        '
        Me.colDataVenda1.AppearanceCell.Options.UseTextOptions = True
        Me.colDataVenda1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataVenda1.AppearanceHeader.Options.UseTextOptions = True
        Me.colDataVenda1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataVenda1.Caption = "Data"
        Me.colDataVenda1.FieldName = "DataVenda"
        Me.colDataVenda1.Name = "colDataVenda1"
        Me.colDataVenda1.OptionsColumn.AllowEdit = False
        Me.colDataVenda1.Visible = True
        Me.colDataVenda1.VisibleIndex = 3
        Me.colDataVenda1.Width = 116
        '
        'colValorFinal
        '
        Me.colValorFinal.AppearanceHeader.Options.UseTextOptions = True
        Me.colValorFinal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colValorFinal.Caption = "Valor"
        Me.colValorFinal.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colValorFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorFinal.FieldName = "ValorFinal"
        Me.colValorFinal.Name = "colValorFinal"
        Me.colValorFinal.OptionsColumn.AllowEdit = False
        Me.colValorFinal.Visible = True
        Me.colValorFinal.VisibleIndex = 4
        Me.colValorFinal.Width = 100
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Excluir"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.GridColumn5.FieldName = "Excluir"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage5.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage5.Controls.Add(Me.Inconsist5GridControl)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.PageVisible = False
        Me.XtraTabPage5.Size = New System.Drawing.Size(1333, 547)
        ToolTipItem4.ImageOptions.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        ToolTipItem4.Text = "Vendas sem número, sem data ou sem cliente"
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.XtraTabPage5.SuperTip = SuperToolTip4
        Me.XtraTabPage5.Text = "VENDAS INCOMPLETAS"
        '
        'Inconsist5GridControl
        '
        Me.Inconsist5GridControl.DataSource = Me.Inconsist5BindingSource
        Me.Inconsist5GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Inconsist5GridControl.EmbeddedNavigator.TextStringFormat = "{0} / {1}"
        Me.Inconsist5GridControl.Location = New System.Drawing.Point(0, 0)
        Me.Inconsist5GridControl.MainView = Me.GridView4
        Me.Inconsist5GridControl.MenuManager = Me.ribbonControl1
        Me.Inconsist5GridControl.Name = "Inconsist5GridControl"
        Me.Inconsist5GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3, Me.btnAbrir5})
        Me.Inconsist5GridControl.Size = New System.Drawing.Size(1333, 547)
        Me.Inconsist5GridControl.TabIndex = 0
        Me.Inconsist5GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'Inconsist5BindingSource
        '
        Me.Inconsist5BindingSource.DataMember = "Inconsist5"
        Me.Inconsist5BindingSource.DataSource = Me.DsInconsist
        '
        'GridView4
        '
        Me.GridView4.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView4.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView4.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView4.Appearance.Row.Options.UseFont = True
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.colId2, Me.colVenda2, Me.colDataVenda2, Me.colCli1, Me.colValorFinal1, Me.GridColumn6})
        Me.GridView4.GridControl = Me.Inconsist5GridControl
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView4.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView4.OptionsBehavior.ReadOnly = True
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        Me.GridView4.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDataVenda2, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = " "
        Me.GridColumn7.ColumnEdit = Me.btnAbrir5
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 29
        '
        'btnAbrir5
        '
        Me.btnAbrir5.AutoHeight = False
        EditorButtonImageOptions4.Image = CType(resources.GetObject("EditorButtonImageOptions4.Image"), System.Drawing.Image)
        Me.btnAbrir5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnAbrir5.Name = "btnAbrir5"
        Me.btnAbrir5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colId2
        '
        Me.colId2.FieldName = "Id"
        Me.colId2.Name = "colId2"
        '
        'colVenda2
        '
        Me.colVenda2.AppearanceCell.Options.UseTextOptions = True
        Me.colVenda2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVenda2.AppearanceHeader.Options.UseTextOptions = True
        Me.colVenda2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVenda2.Caption = "Nº Venda"
        Me.colVenda2.FieldName = "Venda"
        Me.colVenda2.Name = "colVenda2"
        Me.colVenda2.OptionsColumn.AllowEdit = False
        Me.colVenda2.OptionsColumn.ReadOnly = True
        Me.colVenda2.Visible = True
        Me.colVenda2.VisibleIndex = 1
        Me.colVenda2.Width = 110
        '
        'colDataVenda2
        '
        Me.colDataVenda2.AppearanceCell.Options.UseTextOptions = True
        Me.colDataVenda2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataVenda2.AppearanceHeader.Options.UseTextOptions = True
        Me.colDataVenda2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataVenda2.Caption = "Data"
        Me.colDataVenda2.FieldName = "DataVenda"
        Me.colDataVenda2.Name = "colDataVenda2"
        Me.colDataVenda2.OptionsColumn.AllowEdit = False
        Me.colDataVenda2.OptionsColumn.ReadOnly = True
        Me.colDataVenda2.Visible = True
        Me.colDataVenda2.VisibleIndex = 2
        Me.colDataVenda2.Width = 99
        '
        'colCli1
        '
        Me.colCli1.Caption = "Cliente"
        Me.colCli1.FieldName = "Cli"
        Me.colCli1.Name = "colCli1"
        Me.colCli1.OptionsColumn.AllowEdit = False
        Me.colCli1.OptionsColumn.ReadOnly = True
        Me.colCli1.Visible = True
        Me.colCli1.VisibleIndex = 3
        Me.colCli1.Width = 345
        '
        'colValorFinal1
        '
        Me.colValorFinal1.AppearanceHeader.Options.UseTextOptions = True
        Me.colValorFinal1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colValorFinal1.Caption = "Valor"
        Me.colValorFinal1.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colValorFinal1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorFinal1.FieldName = "ValorFinal"
        Me.colValorFinal1.Name = "colValorFinal1"
        Me.colValorFinal1.OptionsColumn.AllowEdit = False
        Me.colValorFinal1.OptionsColumn.ReadOnly = True
        Me.colValorFinal1.Visible = True
        Me.colValorFinal1.VisibleIndex = 4
        Me.colValorFinal1.Width = 89
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Excluir"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'Inconsist1TableAdapter
        '
        Me.Inconsist1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Inconsist1TableAdapter = Me.Inconsist1TableAdapter
        Me.TableAdapterManager1.Inconsist4TableAdapter = Me.Inconsist4TableAdapter
        Me.TableAdapterManager1.UpdateOrder = Pepe.dsInconsistTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Inconsist4TableAdapter
        '
        Me.Inconsist4TableAdapter.ClearBeforeFill = True
        '
        'Inconsist2TableAdapter
        '
        Me.Inconsist2TableAdapter.ClearBeforeFill = True
        '
        'Inconsist5TableAdapter
        '
        Me.Inconsist5TableAdapter.ClearBeforeFill = True
        '
        'frmInconsist
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1338, 722)
        Me.Controls.Add(Me.XtraTabControl)
        Me.Controls.Add(Me.dt1)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IconOptions.Icon = CType(resources.GetObject("frmInconsist.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmInconsist"
        Me.Ribbon = Me.ribbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Inconsist1GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inconsist1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInconsist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.Inconsist2GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inconsist2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrir2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.Inconsist4GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inconsist4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrir4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.Inconsist5GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inconsist5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrir5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnLancaCC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCompras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPeçasCompradas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dt1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents XtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents DsInconsist As dsInconsist
    Friend WithEvents Inconsist1BindingSource As BindingSource
    Friend WithEvents Inconsist1TableAdapter As dsInconsistTableAdapters.Inconsist1TableAdapter
    Friend WithEvents TableAdapterManager1 As dsInconsistTableAdapters.TableAdapterManager
    Friend WithEvents Inconsist1GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDPeça As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAbrir As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colClasse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModêlo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataReg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFamília As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Inconsist2BindingSource As BindingSource
    Friend WithEvents Inconsist2TableAdapter As dsInconsistTableAdapters.Inconsist2TableAdapter
    Friend WithEvents Inconsist2GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAbrir2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Inconsist4BindingSource As BindingSource
    Friend WithEvents Inconsist4TableAdapter As dsInconsistTableAdapters.Inconsist4TableAdapter
    Friend WithEvents Inconsist4GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAbrir4 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVenda1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataVenda1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Inconsist5BindingSource As BindingSource
    Friend WithEvents Inconsist5TableAdapter As dsInconsistTableAdapters.Inconsist5TableAdapter
    Friend WithEvents Inconsist5GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVenda2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataVenda2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCli1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAbrir5 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colValorFinal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnSalvar2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
