Partial Public Class frmClientesDG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientesDG))
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
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipSeparatorItem2 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEtiqMalaDireta = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEtiqAniv = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEmails = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DsPrincipal = New Pepe.DataSet1()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Pepe.DataSet1TableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Pepe.DataSet1TableAdapters.TableAdapterManager()
        Me.ClientesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNovo = New Pepe.dsNovo()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAbrir = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btnVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAbrirVenda = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colIDCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTítulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colEndereço = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colBairro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colAniv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ckTodas = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControlAjuda = New DevExpress.XtraEditors.LabelControl()
        Me.ClientesTableAdapter1 = New Pepe.dsNovoTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager1 = New Pepe.dsNovoTableAdapters.TableAdapterManager()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNovo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrirVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckTodas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnNovo, Me.btnEtiqMalaDireta, Me.btnEtiqAniv, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.btnEmails, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 13
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
        Me.btnNovo.Caption = "Novo cliente"
        Me.btnNovo.Id = 4
        Me.btnNovo.ImageOptions.Image = CType(resources.GetObject("btnNovo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNovo.ImageOptions.LargeImage = CType(resources.GetObject("btnNovo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNovo.Name = "btnNovo"
        '
        'btnEtiqMalaDireta
        '
        Me.btnEtiqMalaDireta.Caption = "Etiquetas mala direta"
        Me.btnEtiqMalaDireta.Id = 5
        Me.btnEtiqMalaDireta.ImageOptions.Image = CType(resources.GetObject("btnEtiqMalaDireta.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEtiqMalaDireta.ImageOptions.LargeImage = CType(resources.GetObject("btnEtiqMalaDireta.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEtiqMalaDireta.Name = "btnEtiqMalaDireta"
        '
        'btnEtiqAniv
        '
        Me.btnEtiqAniv.Caption = "Etiquetas aniversário"
        Me.btnEtiqAniv.Id = 6
        Me.btnEtiqAniv.ImageOptions.Image = CType(resources.GetObject("btnEtiqAniv.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEtiqAniv.ImageOptions.LargeImage = CType(resources.GetObject("btnEtiqAniv.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEtiqAniv.Name = "btnEtiqAniv"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Lançamento C/C"
        Me.BarButtonItem1.Id = 7
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Compras"
        Me.BarButtonItem2.Id = 8
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Peças compradas"
        Me.BarButtonItem3.Id = 9
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'btnEmails
        '
        Me.btnEmails.Caption = "Lista de E-mails"
        Me.btnEmails.Id = 10
        Me.btnEmails.ImageOptions.Image = CType(resources.GetObject("btnEmails.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEmails.ImageOptions.LargeImage = CType(resources.GetObject("btnEmails.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEmails.Name = "btnEmails"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "CADASTRO DE CLIENTES"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnNovo)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEtiqMalaDireta)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEtiqAniv)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEmails)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnFechar)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
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
        Me.LabelControl1.Location = New System.Drawing.Point(557, 149)
        Me.LabelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(224, 21)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Cadastro de Clientes"
        '
        'DsPrincipal
        '
        Me.DsPrincipal.DataSetName = "dsPrincipal"
        Me.DsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DsPrincipal
        Me.ClientesBindingSource.Sort = "Nome, Cliente"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._1TabPeçasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cboClientesTableAdapter = Nothing
        Me.TableAdapterManager.cboVendedorasTableAdapter = Nothing
        Me.TableAdapterManager.Clientes1TableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Pepe.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager.Vencto_ChequesTableAdapter = Nothing
        Me.TableAdapterManager.VENDAS_DETTableAdapter = Nothing
        Me.TableAdapterManager.VendasDetTableAdapter = Nothing
        Me.TableAdapterManager.VENDASTableAdapter = Nothing
        '
        'ClientesGridControl
        '
        Me.ClientesGridControl.DataSource = Me.ClientesBindingSource1
        Me.ClientesGridControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.ClientesGridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ClientesGridControl.EmbeddedNavigator.TextStringFormat = "{0} / {1}"
        Me.ClientesGridControl.Location = New System.Drawing.Point(0, 175)
        Me.ClientesGridControl.MainView = Me.GridView1
        Me.ClientesGridControl.MenuManager = Me.ribbonControl1
        Me.ClientesGridControl.Name = "ClientesGridControl"
        Me.ClientesGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnAbrir, Me.RepositoryItemCheckEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoEdit3, Me.RepositoryItemMemoEdit4, Me.btnAbrirVenda})
        Me.ClientesGridControl.Size = New System.Drawing.Size(1338, 547)
        Me.ClientesGridControl.TabIndex = 6
        Me.ClientesGridControl.UseEmbeddedNavigator = True
        Me.ClientesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "Clientes"
        Me.ClientesBindingSource1.DataSource = Me.DsNovo
        Me.ClientesBindingSource1.Sort = "Nome, Cliente"
        '
        'DsNovo
        '
        Me.DsNovo.DataSetName = "dsNovo"
        Me.DsNovo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.btnVenda, Me.colIDCliente, Me.colTítulo, Me.colCliente, Me.colNome, Me.colEndereço, Me.colBairro, Me.colTelefone, Me.colAniv, Me.colImp})
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
        Me.GridView1.OptionsFind.FindNullPrompt = "Pesquisar..."
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
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
        Me.GridColumn1.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn1.OptionsFilter.AllowFilter = False
        Me.GridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridColumn1.ToolTip = "Abrir cadastro do cliente"
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 28
        '
        'btnAbrir
        '
        Me.btnAbrir.AutoHeight = False
        EditorButtonImageOptions3.Image = CType(resources.GetObject("EditorButtonImageOptions3.Image"), System.Drawing.Image)
        SuperToolTip4.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem4.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipItem4.Appearance.Options.UseImage = True
        ToolTipItem4.ImageOptions.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ToolTipItem4.Text = "Abre o cadastro do cliente"
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.btnAbrir.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, SuperToolTip4, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btnVenda
        '
        Me.btnVenda.Caption = " "
        Me.btnVenda.ColumnEdit = Me.btnAbrirVenda
        Me.btnVenda.FieldName = "btnVenda"
        Me.btnVenda.Name = "btnVenda"
        Me.btnVenda.OptionsFilter.AllowAutoFilter = False
        Me.btnVenda.OptionsFilter.AllowFilter = False
        Me.btnVenda.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.btnVenda.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.btnVenda.Visible = True
        Me.btnVenda.VisibleIndex = 1
        Me.btnVenda.Width = 29
        '
        'btnAbrirVenda
        '
        Me.btnAbrirVenda.AutoHeight = False
        EditorButtonImageOptions4.Image = CType(resources.GetObject("EditorButtonImageOptions4.Image"), System.Drawing.Image)
        ToolTipItem5.Appearance.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        ToolTipItem5.Appearance.Options.UseImage = True
        ToolTipItem5.ImageOptions.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        ToolTipItem5.Text = "Registra venda para o cliente"
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.btnAbrirVenda.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, SuperToolTip5, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnAbrirVenda.Name = "btnAbrirVenda"
        Me.btnAbrirVenda.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colIDCliente
        '
        Me.colIDCliente.Caption = "Id"
        Me.colIDCliente.FieldName = "IDCliente"
        Me.colIDCliente.Name = "colIDCliente"
        '
        'colTítulo
        '
        Me.colTítulo.FieldName = "Título"
        Me.colTítulo.Name = "colTítulo"
        Me.colTítulo.OptionsColumn.AllowEdit = False
        Me.colTítulo.Visible = True
        Me.colTítulo.VisibleIndex = 2
        Me.colTítulo.Width = 66
        '
        'colCliente
        '
        Me.colCliente.AppearanceCell.Options.UseTextOptions = True
        Me.colCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colCliente.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCliente.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCliente.Caption = "Mala direta"
        Me.colCliente.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.AllowEdit = False
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 4
        Me.colCliente.Width = 235
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colNome
        '
        Me.colNome.AppearanceCell.Options.UseTextOptions = True
        Me.colNome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNome.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colNome.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNome.Caption = "Cliente"
        Me.colNome.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsColumn.AllowEdit = False
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 3
        Me.colNome.Width = 234
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'colEndereço
        '
        Me.colEndereço.AppearanceCell.Options.UseTextOptions = True
        Me.colEndereço.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colEndereço.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colEndereço.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEndereço.ColumnEdit = Me.RepositoryItemMemoEdit3
        Me.colEndereço.FieldName = "Endereço"
        Me.colEndereço.Name = "colEndereço"
        Me.colEndereço.OptionsColumn.AllowEdit = False
        Me.colEndereço.Visible = True
        Me.colEndereço.VisibleIndex = 5
        Me.colEndereço.Width = 274
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
        '
        'colBairro
        '
        Me.colBairro.FieldName = "Bairro"
        Me.colBairro.Name = "colBairro"
        Me.colBairro.OptionsColumn.AllowEdit = False
        Me.colBairro.Visible = True
        Me.colBairro.VisibleIndex = 6
        Me.colBairro.Width = 115
        '
        'colTelefone
        '
        Me.colTelefone.AppearanceCell.Options.UseTextOptions = True
        Me.colTelefone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colTelefone.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colTelefone.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTelefone.ColumnEdit = Me.RepositoryItemMemoEdit4
        Me.colTelefone.FieldName = "Telefone"
        Me.colTelefone.Name = "colTelefone"
        Me.colTelefone.OptionsColumn.AllowEdit = False
        Me.colTelefone.Visible = True
        Me.colTelefone.VisibleIndex = 7
        Me.colTelefone.Width = 192
        '
        'RepositoryItemMemoEdit4
        '
        Me.RepositoryItemMemoEdit4.Name = "RepositoryItemMemoEdit4"
        '
        'colAniv
        '
        Me.colAniv.AppearanceCell.Options.UseTextOptions = True
        Me.colAniv.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAniv.Caption = "Aniversário"
        Me.colAniv.FieldName = "Aniv"
        Me.colAniv.Name = "colAniv"
        Me.colAniv.OptionsColumn.AllowEdit = False
        Me.colAniv.Visible = True
        Me.colAniv.VisibleIndex = 8
        '
        'colImp
        '
        Me.colImp.Caption = "Etiquetas"
        Me.colImp.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colImp.FieldName = "Imp"
        Me.colImp.Name = "colImp"
        Me.colImp.Visible = True
        Me.colImp.VisibleIndex = 9
        Me.colImp.Width = 64
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'ckTodas
        '
        Me.ckTodas.Location = New System.Drawing.Point(630, 151)
        Me.ckTodas.MenuManager = Me.ribbonControl1
        Me.ckTodas.Name = "ckTodas"
        Me.ckTodas.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.ckTodas.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.ckTodas.Properties.Appearance.Options.UseBackColor = True
        Me.ckTodas.Properties.Appearance.Options.UseForeColor = True
        Me.ckTodas.Properties.Caption = "Marcar todas"
        Me.ckTodas.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckTodas.Size = New System.Drawing.Size(96, 19)
        Me.ckTodas.TabIndex = 8
        '
        'LabelControlAjuda
        '
        Me.LabelControlAjuda.Appearance.BackColor = System.Drawing.Color.Black
        Me.LabelControlAjuda.Appearance.Options.UseBackColor = True
        Me.LabelControlAjuda.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControlAjuda.ImageOptions.Image = CType(resources.GetObject("LabelControlAjuda.ImageOptions.Image"), System.Drawing.Image)
        Me.LabelControlAjuda.Location = New System.Drawing.Point(607, 152)
        Me.LabelControlAjuda.Name = "LabelControlAjuda"
        Me.LabelControlAjuda.Size = New System.Drawing.Size(17, 16)
        ToolTipTitleItem2.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipTitleItem2.ImageOptions.ImageUri.Uri = "icon%20builder/security_warningcircled2;Size16x16"
        ToolTipTitleItem2.Text = "<b>ATENÇÃO</b>"
        ToolTipItem6.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem6.ImageOptions.ImageUri.Uri = "outlook%20inspired/deferred"
        ToolTipItem6.Text = "Marcar <b>todo</b> o cadastro pode levar algum tempo;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Este recurso deve ser ut" &
    "ilizado para marcar somente um grupo selecionado de clientes para gerar as etiqu" &
    "etas."
        SuperToolTip6.Items.Add(ToolTipTitleItem2)
        SuperToolTip6.Items.Add(ToolTipSeparatorItem2)
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.LabelControlAjuda.SuperTip = SuperToolTip6
        Me.LabelControlAjuda.TabIndex = 10
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1._1TabPeçasTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.cboClientesTableAdapter = Nothing
        Me.TableAdapterManager1.cboVendedorasTableAdapter = Nothing
        Me.TableAdapterManager1.Clientes1TableAdapter = Nothing
        Me.TableAdapterManager1.ClientesTableAdapter = Me.ClientesTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = Pepe.dsNovoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager1.Vencto_ChequesTableAdapter = Nothing
        Me.TableAdapterManager1.VENDAS_DETTableAdapter = Nothing
        Me.TableAdapterManager1.VendasDetTableAdapter = Nothing
        Me.TableAdapterManager1.VENDASTableAdapter = Nothing
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Endereços de Clientes"
        Me.BarButtonItem4.Id = 11
        Me.BarButtonItem4.ImageOptions.Image = Global.Pepe.My.Resources.Resources.print_32x32
        Me.BarButtonItem4.Name = "BarButtonItem4"
        Me.BarButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Telefones de Clientes"
        Me.BarButtonItem5.Id = 12
        Me.BarButtonItem5.ImageOptions.Image = Global.Pepe.My.Resources.Resources.print_32x32
        Me.BarButtonItem5.Name = "BarButtonItem5"
        Me.BarButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'frmClientesDG
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Appearance.Options.UseBackColor = True
        Me.ClientSize = New System.Drawing.Size(1338, 722)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ckTodas)
        Me.Controls.Add(Me.ClientesGridControl)
        Me.Controls.Add(Me.LabelControlAjuda)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IconOptions.Icon = CType(resources.GetObject("frmClientesDG.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.MaximizeBox = False
        Me.Name = "frmClientesDG"
        Me.Ribbon = Me.ribbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNovo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrirVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckTodas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DsPrincipal As Pepe.DataSet1
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Pepe.DataSet1TableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As Pepe.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ClientesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTítulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndereço As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBairro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAniv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAbrir As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colImp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ckTodas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnEtiqMalaDireta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents btnVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAbrirVenda As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnEtiqAniv As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEmails As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LabelControlAjuda As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsNovo As dsNovo
    Friend WithEvents ClientesBindingSource1 As BindingSource
    Friend WithEvents ClientesTableAdapter1 As dsNovoTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager1 As dsNovoTableAdapters.TableAdapterManager
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
End Class
