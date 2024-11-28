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
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
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
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.DsPrincipal = New Pepe.dsPrincipal()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Pepe.dsPrincipalTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Pepe.dsPrincipalTableAdapters.TableAdapterManager()
        Me.ClientesGridControl = New DevExpress.XtraGrid.GridControl()
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
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnNovo, Me.btnEtiqMalaDireta, Me.btnEtiqAniv, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 10
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowToolbarCustomizeItem = False
        Me.ribbonControl1.Size = New System.Drawing.Size(1006, 142)
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
        'btnNovo
        '
        Me.btnNovo.Caption = "Novo cliente"
        Me.btnNovo.Glyph = CType(resources.GetObject("btnNovo.Glyph"), System.Drawing.Image)
        Me.btnNovo.Id = 4
        Me.btnNovo.LargeGlyph = CType(resources.GetObject("btnNovo.LargeGlyph"), System.Drawing.Image)
        Me.btnNovo.Name = "btnNovo"
        '
        'btnEtiqMalaDireta
        '
        Me.btnEtiqMalaDireta.Caption = "Etiquetas mala direta"
        Me.btnEtiqMalaDireta.Glyph = CType(resources.GetObject("btnEtiqMalaDireta.Glyph"), System.Drawing.Image)
        Me.btnEtiqMalaDireta.Id = 5
        Me.btnEtiqMalaDireta.LargeGlyph = CType(resources.GetObject("btnEtiqMalaDireta.LargeGlyph"), System.Drawing.Image)
        Me.btnEtiqMalaDireta.Name = "btnEtiqMalaDireta"
        '
        'btnEtiqAniv
        '
        Me.btnEtiqAniv.Caption = "Etiquetas aniversário"
        Me.btnEtiqAniv.Glyph = CType(resources.GetObject("btnEtiqAniv.Glyph"), System.Drawing.Image)
        Me.btnEtiqAniv.Id = 6
        Me.btnEtiqAniv.LargeGlyph = CType(resources.GetObject("btnEtiqAniv.LargeGlyph"), System.Drawing.Image)
        Me.btnEtiqAniv.Name = "btnEtiqAniv"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Lançamento C/C"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 7
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Compras"
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Id = 8
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Peças compradas"
        Me.BarButtonItem3.Id = 9
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "CADASTRO DE CLIENTES"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnFechar)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnNovo)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.ShowCaptionButton = False
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEtiqMalaDireta)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEtiqAniv)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelControl1.Appearance.Image = CType(resources.GetObject("LabelControl1.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseImage = True
        Me.LabelControl1.Appearance.Options.UseImageAlign = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(622, 70)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(227, 39)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Cadastro de Clientes"
        Me.LabelControl1.Visible = False
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "Pepe.My.MySettings.Pepe_ConnString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "IDCliente"
        Table1.Name = "Clientes"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "Título"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "Nome"
        ColumnExpression3.Table = Table1
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "Endereço"
        ColumnExpression4.Table = Table1
        Column4.Expression = ColumnExpression4
        ColumnExpression5.ColumnName = "Bairro"
        ColumnExpression5.Table = Table1
        Column5.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "Cidade"
        ColumnExpression6.Table = Table1
        Column6.Expression = ColumnExpression6
        ColumnExpression7.ColumnName = "Estado"
        ColumnExpression7.Table = Table1
        Column7.Expression = ColumnExpression7
        ColumnExpression8.ColumnName = "CEP"
        ColumnExpression8.Table = Table1
        Column8.Expression = ColumnExpression8
        ColumnExpression9.ColumnName = "Telefone"
        ColumnExpression9.Table = Table1
        Column9.Expression = ColumnExpression9
        ColumnExpression10.ColumnName = "Cliente"
        ColumnExpression10.Table = Table1
        Column10.Expression = ColumnExpression10
        ColumnExpression11.ColumnName = "Aniv"
        ColumnExpression11.Table = Table1
        Column11.Expression = ColumnExpression11
        ColumnExpression12.ColumnName = "Indicaçao"
        ColumnExpression12.Table = Table1
        Column12.Expression = ColumnExpression12
        ColumnExpression13.ColumnName = "Medidas"
        ColumnExpression13.Table = Table1
        Column13.Expression = ColumnExpression13
        ColumnExpression14.ColumnName = "Email"
        ColumnExpression14.Table = Table1
        Column14.Expression = ColumnExpression14
        ColumnExpression15.ColumnName = "CPF"
        ColumnExpression15.Table = Table1
        Column15.Expression = ColumnExpression15
        ColumnExpression16.ColumnName = "CPF_MD"
        ColumnExpression16.Table = Table1
        Column16.Expression = ColumnExpression16
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.Columns.Add(Column5)
        SelectQuery1.Columns.Add(Column6)
        SelectQuery1.Columns.Add(Column7)
        SelectQuery1.Columns.Add(Column8)
        SelectQuery1.Columns.Add(Column9)
        SelectQuery1.Columns.Add(Column10)
        SelectQuery1.Columns.Add(Column11)
        SelectQuery1.Columns.Add(Column12)
        SelectQuery1.Columns.Add(Column13)
        SelectQuery1.Columns.Add(Column14)
        SelectQuery1.Columns.Add(Column15)
        SelectQuery1.Columns.Add(Column16)
        SelectQuery1.FilterString = "[Clientes.Nome] <> 'null' Or [Clientes.Cliente] <> 'null'"
        SelectQuery1.Name = "Clientes"
        SelectQuery1.Tables.Add(Table1)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
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
        Me.ClientesBindingSource.Sort = "Cliente"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._1TabPeçasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cboVendedorasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Pepe.dsPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager.Vencto_ChequesTableAdapter = Nothing
        Me.TableAdapterManager.VENDAS_DETTableAdapter = Nothing
        Me.TableAdapterManager.VendasDetTableAdapter = Nothing
        Me.TableAdapterManager.VENDASTableAdapter = Nothing
        '
        'ClientesGridControl
        '
        Me.ClientesGridControl.DataSource = Me.ClientesBindingSource
        Me.ClientesGridControl.Location = New System.Drawing.Point(4, 145)
        Me.ClientesGridControl.MainView = Me.GridView1
        Me.ClientesGridControl.MenuManager = Me.ribbonControl1
        Me.ClientesGridControl.Name = "ClientesGridControl"
        Me.ClientesGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnAbrir, Me.RepositoryItemCheckEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoEdit3, Me.RepositoryItemMemoEdit4, Me.btnAbrirVenda})
        Me.ClientesGridControl.Size = New System.Drawing.Size(994, 543)
        Me.ClientesGridControl.TabIndex = 6
        Me.ClientesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.ColumnEdit = Me.btnAbrir
        Me.GridColumn1.FieldName = "GridColumn1"
        Me.GridColumn1.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ShowCaption = False
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
        SuperToolTip1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem1.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipItem1.Appearance.Options.UseImage = True
        ToolTipItem1.Image = CType(resources.GetObject("ToolTipItem1.Image"), System.Drawing.Image)
        ToolTipItem1.Text = "Abre o cadastro do cliente"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnAbrir.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("btnAbrir.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, SuperToolTip1, True)})
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btnVenda
        '
        Me.btnVenda.Caption = " "
        Me.btnVenda.ColumnEdit = Me.btnAbrirVenda
        Me.btnVenda.FieldName = "btnVenda"
        Me.btnVenda.Name = "btnVenda"
        Me.btnVenda.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.btnVenda.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.btnVenda.Visible = True
        Me.btnVenda.VisibleIndex = 1
        Me.btnVenda.Width = 25
        '
        'btnAbrirVenda
        '
        Me.btnAbrirVenda.AutoHeight = False
        ToolTipItem2.Appearance.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ToolTipItem2.Appearance.Options.UseImage = True
        ToolTipItem2.Image = CType(resources.GetObject("ToolTipItem2.Image"), System.Drawing.Image)
        ToolTipItem2.Text = "Registra venda para o cliente"
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btnAbrirVenda.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("btnAbrirVenda.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, SuperToolTip2, True)})
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
        Me.colTítulo.Width = 60
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
        Me.colCliente.VisibleIndex = 3
        Me.colCliente.Width = 142
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
        Me.colNome.VisibleIndex = 4
        Me.colNome.Width = 139
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
        Me.colEndereço.Width = 193
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
        Me.colBairro.Width = 89
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
        Me.colTelefone.Width = 118
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
        Me.colAniv.Width = 69
        '
        'colImp
        '
        Me.colImp.Caption = "Etiquetas"
        Me.colImp.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colImp.FieldName = "Imp"
        Me.colImp.Name = "colImp"
        Me.colImp.Visible = True
        Me.colImp.VisibleIndex = 9
        Me.colImp.Width = 52
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'ckTodas
        '
        Me.ckTodas.Location = New System.Drawing.Point(851, 159)
        Me.ckTodas.MenuManager = Me.ribbonControl1
        Me.ckTodas.Name = "ckTodas"
        Me.ckTodas.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.ckTodas.Properties.Appearance.Options.UseForeColor = True
        Me.ckTodas.Properties.Caption = "Marcar todas"
        Me.ckTodas.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckTodas.Size = New System.Drawing.Size(106, 19)
        Me.ckTodas.TabIndex = 8
        '
        'frmClientesDG
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1006, 694)
        Me.Controls.Add(Me.ckTodas)
        Me.Controls.Add(Me.ClientesGridControl)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmClientesDG"
        Me.Ribbon = Me.ribbonControl1
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnNovo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents DsPrincipal As Pepe.dsPrincipal
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Pepe.dsPrincipalTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As Pepe.dsPrincipalTableAdapters.TableAdapterManager
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
End Class
