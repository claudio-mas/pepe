Partial Public Class frmChequesDG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequesDG))
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
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
        Me.ChequesTodosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCheques = New Pepe.dsCheques()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdCC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParcela = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPagto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkOk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.btnAbrir = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ChequesTodosTableAdapter = New Pepe.dsChequesTableAdapters.ChequesTodosTableAdapter()
        Me.UltraOptionSet1 = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.TableAdapterManager1 = New Pepe.dsChequesTableAdapters.TableAdapterManager()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequesTodosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraOptionSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnNovo, Me.btnSalvar, Me.btnUndo})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 8
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowToolbarCustomizeItem = False
        Me.ribbonControl1.Size = New System.Drawing.Size(1008, 142)
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
        Me.btnFechar.Glyph = CType(resources.GetObject("btnFechar.Glyph"), System.Drawing.Image)
        Me.btnFechar.Id = 3
        Me.btnFechar.LargeGlyph = CType(resources.GetObject("btnFechar.LargeGlyph"), System.Drawing.Image)
        Me.btnFechar.Name = "btnFechar"
        '
        'btnNovo
        '
        Me.btnNovo.Caption = "Inclusão"
        Me.btnNovo.Enabled = False
        Me.btnNovo.Glyph = CType(resources.GetObject("btnNovo.Glyph"), System.Drawing.Image)
        Me.btnNovo.Id = 4
        Me.btnNovo.LargeGlyph = CType(resources.GetObject("btnNovo.LargeGlyph"), System.Drawing.Image)
        Me.btnNovo.Name = "btnNovo"
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
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "CONTROLE DE CHEQUES"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSalvar)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnUndo)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelControl1.Appearance.Image = CType(resources.GetObject("LabelControl1.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseBackColor = True
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
        Me.LabelControl1.Location = New System.Drawing.Point(388, 93)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(227, 39)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Controle de Cheques"
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
        Me.ClientesGridControl.DataSource = Me.ChequesTodosBindingSource
        Me.ClientesGridControl.Location = New System.Drawing.Point(4, 145)
        Me.ClientesGridControl.MainView = Me.GridView1
        Me.ClientesGridControl.MenuManager = Me.ribbonControl1
        Me.ClientesGridControl.Name = "ClientesGridControl"
        Me.ClientesGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnAbrir, Me.RepositoryItemCheckEdit1})
        Me.ClientesGridControl.Size = New System.Drawing.Size(994, 544)
        Me.ClientesGridControl.TabIndex = 6
        Me.ClientesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ChequesTodosBindingSource
        '
        Me.ChequesTodosBindingSource.DataMember = "ChequesTodos"
        Me.ChequesTodosBindingSource.DataSource = Me.DsCheques
        Me.ChequesTodosBindingSource.Filter = "Uso Is Null"
        '
        'DsCheques
        '
        Me.DsCheques.DataSetName = "dsCheques"
        Me.DsCheques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.FixedLine.Options.UseTextOptions = True
        Me.GridView1.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.GridView1.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdCC, Me.colN1, Me.colVenda, Me.colDataVenda, Me.colN, Me.colBanco, Me.colParcela, Me.colDestino, Me.colVValor, Me.colPagto, Me.colCheque, Me.colUso, Me.colObs, Me.colVencto, Me.chkOk})
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
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colVencto, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colIdCC
        '
        Me.colIdCC.FieldName = "IdCC"
        Me.colIdCC.Name = "colIdCC"
        Me.colIdCC.OptionsColumn.AllowEdit = False
        Me.colIdCC.Width = 35
        '
        'colN1
        '
        Me.colN1.FieldName = "N1"
        Me.colN1.Name = "colN1"
        Me.colN1.OptionsColumn.AllowEdit = False
        '
        'colVenda
        '
        Me.colVenda.AppearanceCell.Options.UseTextOptions = True
        Me.colVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVenda.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colVenda.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colVenda.AppearanceHeader.Options.UseTextOptions = True
        Me.colVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVenda.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colVenda.Caption = "Nº da Venda"
        Me.colVenda.FieldName = "Venda"
        Me.colVenda.Name = "colVenda"
        Me.colVenda.OptionsColumn.AllowEdit = False
        Me.colVenda.Visible = True
        Me.colVenda.VisibleIndex = 0
        Me.colVenda.Width = 68
        '
        'colDataVenda
        '
        Me.colDataVenda.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.colDataVenda.AppearanceCell.Options.UseFont = True
        Me.colDataVenda.AppearanceCell.Options.UseTextOptions = True
        Me.colDataVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataVenda.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colDataVenda.AppearanceHeader.Options.UseTextOptions = True
        Me.colDataVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataVenda.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colDataVenda.Caption = "Data"
        Me.colDataVenda.FieldName = "DataVenda"
        Me.colDataVenda.Name = "colDataVenda"
        Me.colDataVenda.OptionsColumn.AllowEdit = False
        Me.colDataVenda.Visible = True
        Me.colDataVenda.VisibleIndex = 1
        Me.colDataVenda.Width = 67
        '
        'colN
        '
        Me.colN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.colN.AppearanceCell.Options.UseFont = True
        Me.colN.AppearanceCell.Options.UseTextOptions = True
        Me.colN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colN.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.colN.AppearanceHeader.Options.UseFont = True
        Me.colN.AppearanceHeader.Options.UseTextOptions = True
        Me.colN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colN.Caption = "Cliente"
        Me.colN.FieldName = "N"
        Me.colN.Name = "colN"
        Me.colN.OptionsColumn.AllowEdit = False
        Me.colN.Visible = True
        Me.colN.VisibleIndex = 2
        Me.colN.Width = 140
        '
        'colBanco
        '
        Me.colBanco.FieldName = "Banco"
        Me.colBanco.Name = "colBanco"
        Me.colBanco.OptionsColumn.AllowEdit = False
        Me.colBanco.Visible = True
        Me.colBanco.VisibleIndex = 3
        Me.colBanco.Width = 95
        '
        'colParcela
        '
        Me.colParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcela.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colParcela.AppearanceHeader.Options.UseTextOptions = True
        Me.colParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcela.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colParcela.Caption = "Parcela"
        Me.colParcela.FieldName = "Parcela"
        Me.colParcela.Name = "colParcela"
        Me.colParcela.OptionsColumn.AllowEdit = False
        Me.colParcela.Visible = True
        Me.colParcela.VisibleIndex = 4
        Me.colParcela.Width = 47
        '
        'colDestino
        '
        Me.colDestino.Caption = "Destino"
        Me.colDestino.FieldName = "Destino"
        Me.colDestino.Name = "colDestino"
        Me.colDestino.Visible = True
        Me.colDestino.VisibleIndex = 9
        '
        'colVValor
        '
        Me.colVValor.Caption = "Valor"
        Me.colVValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colVValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVValor.FieldName = "VValor"
        Me.colVValor.Name = "colVValor"
        Me.colVValor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VValor", "{0:#,###0.00;-#,###0.00}")})
        Me.colVValor.Visible = True
        Me.colVValor.VisibleIndex = 6
        Me.colVValor.Width = 79
        '
        'colPagto
        '
        Me.colPagto.FieldName = "Pagto"
        Me.colPagto.Name = "colPagto"
        Me.colPagto.OptionsColumn.AllowEdit = False
        '
        'colCheque
        '
        Me.colCheque.Caption = "Nº Cheque"
        Me.colCheque.FieldName = "Cheque"
        Me.colCheque.Name = "colCheque"
        Me.colCheque.OptionsColumn.AllowEdit = False
        Me.colCheque.Visible = True
        Me.colCheque.VisibleIndex = 5
        Me.colCheque.Width = 71
        '
        'colUso
        '
        Me.colUso.AppearanceCell.Options.UseTextOptions = True
        Me.colUso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUso.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colUso.AppearanceHeader.Options.UseTextOptions = True
        Me.colUso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUso.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colUso.Caption = "Data uso"
        Me.colUso.FieldName = "Uso"
        Me.colUso.Name = "colUso"
        Me.colUso.Visible = True
        Me.colUso.VisibleIndex = 8
        Me.colUso.Width = 67
        '
        'colObs
        '
        Me.colObs.Caption = "Obs."
        Me.colObs.FieldName = "Obs"
        Me.colObs.Name = "colObs"
        Me.colObs.Visible = True
        Me.colObs.VisibleIndex = 10
        Me.colObs.Width = 162
        '
        'colVencto
        '
        Me.colVencto.Caption = "Bom para"
        Me.colVencto.FieldName = "Vencto"
        Me.colVencto.Name = "colVencto"
        Me.colVencto.OptionsColumn.AllowEdit = False
        Me.colVencto.Visible = True
        Me.colVencto.VisibleIndex = 7
        Me.colVencto.Width = 68
        '
        'chkOk
        '
        Me.chkOk.Caption = "ok"
        Me.chkOk.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.chkOk.FieldName = "Baixar"
        Me.chkOk.Name = "chkOk"
        Me.chkOk.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.chkOk.Width = 25
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'btnAbrir
        '
        Me.btnAbrir.AutoHeight = False
        Me.btnAbrir.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("btnAbrir.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ChequesTodosTableAdapter
        '
        Me.ChequesTodosTableAdapter.ClearBeforeFill = True
        '
        'UltraOptionSet1
        '
        ValueListItem1.DataValue = "Todos"
        ValueListItem1.DisplayText = "Todos"
        ValueListItem2.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem2.DataValue = "Em aberto"
        ValueListItem2.DisplayText = "Em aberto"
        ValueListItem3.DataValue = "Recebidos"
        ValueListItem3.DisplayText = "Recebidos"
        Me.UltraOptionSet1.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.UltraOptionSet1.ItemSpacingHorizontal = 20
        Me.UltraOptionSet1.Location = New System.Drawing.Point(625, 160)
        Me.UltraOptionSet1.Name = "UltraOptionSet1"
        Me.UltraOptionSet1.Size = New System.Drawing.Size(240, 18)
        Me.UltraOptionSet1.TabIndex = 9
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CartõesTodosTableAdapter = Nothing
        Me.TableAdapterManager1.cboPeçasTableAdapter = Nothing
        Me.TableAdapterManager1.ChequesTodosTableAdapter = Me.ChequesTodosTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Pepe.dsChequesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.VENDAS_DETTableAdapter = Nothing
        '
        'frmChequesDG
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1008, 695)
        Me.Controls.Add(Me.UltraOptionSet1)
        Me.Controls.Add(Me.ClientesGridControl)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChequesDG"
        Me.Ribbon = Me.ribbonControl1
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequesTodosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrir, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnAbrir As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents DsCheques As Pepe.dsCheques
    Friend WithEvents ChequesTodosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChequesTodosTableAdapter As Pepe.dsChequesTableAdapters.ChequesTodosTableAdapter
    Friend WithEvents colIdCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UltraOptionSet1 As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents chkOk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents TableAdapterManager1 As Pepe.dsChequesTableAdapters.TableAdapterManager
End Class
