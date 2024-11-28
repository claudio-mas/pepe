Partial Public Class frmContaCorrente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContaCorrente))
        Dim ClienteLabel As System.Windows.Forms.Label
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCompras = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPeçasCompradas = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.DsCC = New Pepe.dsCC()
        Me.Conta_CorrenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Conta_CorrenteTableAdapter = New Pepe.dsCCTableAdapters.Conta_CorrenteTableAdapter()
        Me.TableAdapterManager = New Pepe.dsCCTableAdapters.TableAdapterManager()
        Me.Conta_CorrenteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Conta_CorrenteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClienteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ContaCorrenteVenctoChequesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vencto_ChequesTableAdapter = New Pepe.dsCCTableAdapters.Vencto_ChequesTableAdapter()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParcela = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btnNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.DataDateEdit = New DevExpress.XtraEditors.DateEdit()
        ClienteLabel = New System.Windows.Forms.Label()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Conta_CorrenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Conta_CorrenteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Conta_CorrenteBindingNavigator.SuspendLayout()
        CType(Me.ClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaCorrenteVenctoChequesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnSalvar, Me.btnUndo, Me.BarButtonItem1, Me.btnCompras, Me.btnPeçasCompradas, Me.btnNovo, Me.BarButtonItem3})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 12
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowToolbarCustomizeItem = False
        Me.ribbonControl1.Size = New System.Drawing.Size(1006, 146)
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
        Me.btnFechar.Caption = "Retornar"
        Me.btnFechar.Glyph = CType(resources.GetObject("btnFechar.Glyph"), System.Drawing.Image)
        Me.btnFechar.Id = 3
        Me.btnFechar.LargeGlyph = CType(resources.GetObject("btnFechar.LargeGlyph"), System.Drawing.Image)
        Me.btnFechar.Name = "btnFechar"
        '
        'btnSalvar
        '
        Me.btnSalvar.Caption = "Salvar"
        Me.btnSalvar.Glyph = CType(resources.GetObject("btnSalvar.Glyph"), System.Drawing.Image)
        Me.btnSalvar.Id = 5
        Me.btnSalvar.LargeGlyph = CType(resources.GetObject("btnSalvar.LargeGlyph"), System.Drawing.Image)
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnUndo
        '
        Me.btnUndo.Caption = "Desfazer"
        Me.btnUndo.Glyph = CType(resources.GetObject("btnUndo.Glyph"), System.Drawing.Image)
        Me.btnUndo.Id = 6
        Me.btnUndo.LargeGlyph = CType(resources.GetObject("btnUndo.LargeGlyph"), System.Drawing.Image)
        Me.btnUndo.Name = "btnUndo"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Lançamento C/C"
        Me.BarButtonItem1.Enabled = False
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 7
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnCompras
        '
        Me.btnCompras.Caption = "Compras"
        Me.btnCompras.Glyph = CType(resources.GetObject("btnCompras.Glyph"), System.Drawing.Image)
        Me.btnCompras.Id = 8
        Me.btnCompras.LargeGlyph = CType(resources.GetObject("btnCompras.LargeGlyph"), System.Drawing.Image)
        Me.btnCompras.Name = "btnCompras"
        '
        'btnPeçasCompradas
        '
        Me.btnPeçasCompradas.Caption = "Peças compradas"
        Me.btnPeçasCompradas.Glyph = CType(resources.GetObject("btnPeçasCompradas.Glyph"), System.Drawing.Image)
        Me.btnPeçasCompradas.Id = 9
        Me.btnPeçasCompradas.LargeGlyph = CType(resources.GetObject("btnPeçasCompradas.LargeGlyph"), System.Drawing.Image)
        Me.btnPeçasCompradas.Name = "btnPeçasCompradas"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.ribbonPage1.Image = CType(resources.GetObject("ribbonPage1.Image"), System.Drawing.Image)
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "CADASTRO DE CLIENTES"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnFechar)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.ShowCaptionButton = False
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSalvar)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnUndo)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.DarkRed
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
        Me.LabelControl1.Location = New System.Drawing.Point(444, 148)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(119, 19)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Conta Corrente"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(ClienteLabel)
        Me.PanelControl1.Controls.Add(Me.ClienteTextEdit)
        Me.PanelControl1.Location = New System.Drawing.Point(58, 250)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(511, 221)
        Me.PanelControl1.TabIndex = 8
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ContaCorrenteVenctoChequesBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(21, 494)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.ribbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(816, 171)
        Me.GridControl1.TabIndex = 10
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colIdCC, Me.colParcela, Me.colVencto, Me.colVValor, Me.colCheque, Me.colBanco})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.DarkRed
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
        Me.LabelControl2.Location = New System.Drawing.Point(444, 173)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(119, 19)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "Conta Corrente"
        '
        'DsCC
        '
        Me.DsCC.DataSetName = "dsCC"
        Me.DsCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Conta_CorrenteBindingSource
        '
        Me.Conta_CorrenteBindingSource.DataMember = "Conta Corrente"
        Me.Conta_CorrenteBindingSource.DataSource = Me.DsCC
        '
        'Conta_CorrenteTableAdapter
        '
        Me.Conta_CorrenteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CartõesTableAdapter = Nothing
        Me.TableAdapterManager.Conta_CorrenteTableAdapter = Me.Conta_CorrenteTableAdapter
        Me.TableAdapterManager.UpdateOrder = Pepe.dsCCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager.Vencto_ChequesTableAdapter = Me.Vencto_ChequesTableAdapter
        '
        'Conta_CorrenteBindingNavigator
        '
        Me.Conta_CorrenteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Conta_CorrenteBindingNavigator.BindingSource = Me.Conta_CorrenteBindingSource
        Me.Conta_CorrenteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Conta_CorrenteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Conta_CorrenteBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Conta_CorrenteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Conta_CorrenteBindingNavigatorSaveItem})
        Me.Conta_CorrenteBindingNavigator.Location = New System.Drawing.Point(644, 167)
        Me.Conta_CorrenteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Conta_CorrenteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Conta_CorrenteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Conta_CorrenteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Conta_CorrenteBindingNavigator.Name = "Conta_CorrenteBindingNavigator"
        Me.Conta_CorrenteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Conta_CorrenteBindingNavigator.Size = New System.Drawing.Size(280, 25)
        Me.Conta_CorrenteBindingNavigator.TabIndex = 23
        Me.Conta_CorrenteBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'Conta_CorrenteBindingNavigatorSaveItem
        '
        Me.Conta_CorrenteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Conta_CorrenteBindingNavigatorSaveItem.Image = CType(resources.GetObject("Conta_CorrenteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Conta_CorrenteBindingNavigatorSaveItem.Name = "Conta_CorrenteBindingNavigatorSaveItem"
        Me.Conta_CorrenteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Conta_CorrenteBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClienteLabel.Location = New System.Drawing.Point(34, 27)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(44, 15)
        ClienteLabel.TabIndex = 23
        ClienteLabel.Text = "Cliente"
        '
        'ClienteTextEdit
        '
        Me.ClienteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "Cliente", True))
        Me.ClienteTextEdit.Location = New System.Drawing.Point(82, 24)
        Me.ClienteTextEdit.MenuManager = Me.ribbonControl1
        Me.ClienteTextEdit.Name = "ClienteTextEdit"
        Me.ClienteTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ClienteTextEdit.Size = New System.Drawing.Size(100, 22)
        Me.ClienteTextEdit.TabIndex = 24
        '
        'ContaCorrenteVenctoChequesBindingSource
        '
        Me.ContaCorrenteVenctoChequesBindingSource.DataMember = "Conta Corrente_Vencto Cheques"
        Me.ContaCorrenteVenctoChequesBindingSource.DataSource = Me.Conta_CorrenteBindingSource
        '
        'Vencto_ChequesTableAdapter
        '
        Me.Vencto_ChequesTableAdapter.ClearBeforeFill = True
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colParcela
        '
        Me.colParcela.FieldName = "Parcela"
        Me.colParcela.Name = "colParcela"
        Me.colParcela.Visible = True
        Me.colParcela.VisibleIndex = 2
        '
        'colVencto
        '
        Me.colVencto.FieldName = "Vencto"
        Me.colVencto.Name = "colVencto"
        Me.colVencto.Visible = True
        Me.colVencto.VisibleIndex = 3
        Me.colVencto.Width = 116
        '
        'colVValor
        '
        Me.colVValor.FieldName = "VValor"
        Me.colVValor.Name = "colVValor"
        Me.colVValor.Visible = True
        Me.colVValor.VisibleIndex = 4
        Me.colVValor.Width = 101
        '
        'colCheque
        '
        Me.colCheque.FieldName = "Cheque"
        Me.colCheque.Name = "colCheque"
        Me.colCheque.Visible = True
        Me.colCheque.VisibleIndex = 5
        Me.colCheque.Width = 119
        '
        'colIdCC
        '
        Me.colIdCC.FieldName = "IdCC"
        Me.colIdCC.Name = "colIdCC"
        Me.colIdCC.Visible = True
        Me.colIdCC.VisibleIndex = 1
        '
        'colBanco
        '
        Me.colBanco.FieldName = "Banco"
        Me.colBanco.Name = "colBanco"
        Me.colBanco.Visible = True
        Me.colBanco.VisibleIndex = 6
        Me.colBanco.Width = 235
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnNovo)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        '
        'btnNovo
        '
        Me.btnNovo.Caption = "Inclusão"
        Me.btnNovo.Glyph = CType(resources.GetObject("btnNovo.Glyph"), System.Drawing.Image)
        Me.btnNovo.Id = 10
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Exclusão"
        Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
        Me.BarButtonItem3.Id = 11
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'DataDateEdit
        '
        Me.DataDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "Data", True))
        Me.DataDateEdit.EditValue = Nothing
        Me.DataDateEdit.Location = New System.Drawing.Point(453, 201)
        Me.DataDateEdit.MenuManager = Me.ribbonControl1
        Me.DataDateEdit.Name = "DataDateEdit"
        Me.DataDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataDateEdit.Properties.Appearance.Options.UseFont = True
        Me.DataDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataDateEdit.Size = New System.Drawing.Size(100, 22)
        Me.DataDateEdit.TabIndex = 24
        '
        'frmContaCorrente
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1006, 694)
        Me.Controls.Add(Me.DataDateEdit)
        Me.Controls.Add(Me.Conta_CorrenteBindingNavigator)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmContaCorrente"
        Me.Ribbon = Me.ribbonControl1
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Conta_CorrenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Conta_CorrenteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Conta_CorrenteBindingNavigator.ResumeLayout(False)
        Me.Conta_CorrenteBindingNavigator.PerformLayout()
        CType(Me.ClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContaCorrenteVenctoChequesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCompras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPeçasCompradas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsCC As dsCC
    Friend WithEvents Conta_CorrenteBindingSource As BindingSource
    Friend WithEvents Conta_CorrenteTableAdapter As dsCCTableAdapters.Conta_CorrenteTableAdapter
    Friend WithEvents TableAdapterManager As dsCCTableAdapters.TableAdapterManager
    Friend WithEvents Conta_CorrenteBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Conta_CorrenteBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ClienteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Vencto_ChequesTableAdapter As dsCCTableAdapters.Vencto_ChequesTableAdapter
    Friend WithEvents ContaCorrenteVenctoChequesBindingSource As BindingSource
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnNovo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents DataDateEdit As DevExpress.XtraEditors.DateEdit
End Class
