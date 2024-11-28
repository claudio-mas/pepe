Partial Public Class frmClientes
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
        Dim TítuloLabel As System.Windows.Forms.Label
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ClienteLabel1 As System.Windows.Forms.Label
        Dim AnivLabel As System.Windows.Forms.Label
        Dim MedidasLabel As System.Windows.Forms.Label
        Dim IndicaçaoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCompras = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPeçasCompradas = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DsPrincipal = New Pepe.dsPrincipal()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Pepe.dsPrincipalTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Pepe.dsPrincipalTableAdapters.TableAdapterManager()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.IndicaçaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCliente = New Pepe.dsCliente()
        Me.MedidasTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AnivDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ClienteTextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelefoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CEPTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EstadoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BairroTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EndereçoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ClienteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TítuloComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.CCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPrincipal1 = New Pepe.dsPrincipal()
        Me.CcTableAdapter1 = New Pepe.dsPrincipalTableAdapters.CCTableAdapter()
        Me.ClientesTableAdapter1 = New Pepe.dsClienteTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager1 = New Pepe.dsClienteTableAdapters.TableAdapterManager()
        Me.IDClienteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CCTableAdapter = New Pepe.dsClienteTableAdapters.CCTableAdapter()
        TítuloLabel = New System.Windows.Forms.Label()
        ClienteLabel = New System.Windows.Forms.Label()
        EndereçoLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        ClienteLabel1 = New System.Windows.Forms.Label()
        AnivLabel = New System.Windows.Forms.Label()
        MedidasLabel = New System.Windows.Forms.Label()
        IndicaçaoLabel = New System.Windows.Forms.Label()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.IndicaçaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnivDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnivDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEPTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BairroTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndereçoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TítuloComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrincipal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TítuloLabel
        '
        TítuloLabel.AutoSize = True
        TítuloLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TítuloLabel.Location = New System.Drawing.Point(31, 23)
        TítuloLabel.Name = "TítuloLabel"
        TítuloLabel.Size = New System.Drawing.Size(38, 15)
        TítuloLabel.TabIndex = 0
        TítuloLabel.Text = "Título"
        TítuloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClienteLabel.Location = New System.Drawing.Point(163, 23)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(66, 15)
        ClienteLabel.TabIndex = 2
        ClienteLabel.Text = "Mala direta"
        ClienteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EndereçoLabel.Location = New System.Drawing.Point(13, 49)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(56, 15)
        EndereçoLabel.TabIndex = 4
        EndereçoLabel.Text = "Endereço"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BairroLabel.Location = New System.Drawing.Point(31, 75)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(38, 15)
        BairroLabel.TabIndex = 6
        BairroLabel.Text = "Bairro"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CidadeLabel.Location = New System.Drawing.Point(173, 75)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(44, 15)
        CidadeLabel.TabIndex = 8
        CidadeLabel.Text = "Cidade"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(316, 75)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(42, 15)
        EstadoLabel.TabIndex = 10
        EstadoLabel.Text = "Estado"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CEPLabel.Location = New System.Drawing.Point(393, 75)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(28, 15)
        CEPLabel.TabIndex = 12
        CEPLabel.Text = "CEP"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.Location = New System.Drawing.Point(17, 101)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 15)
        TelefoneLabel.TabIndex = 14
        TelefoneLabel.Text = "Telefone"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FaxLabel.Location = New System.Drawing.Point(294, 101)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(24, 15)
        FaxLabel.TabIndex = 16
        FaxLabel.Text = "Fax"
        FaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(28, 127)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(41, 15)
        EmailLabel.TabIndex = 18
        EmailLabel.Text = "E-mail"
        '
        'ClienteLabel1
        '
        ClienteLabel1.AutoSize = True
        ClienteLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClienteLabel1.Location = New System.Drawing.Point(25, 154)
        ClienteLabel1.Name = "ClienteLabel1"
        ClienteLabel1.Size = New System.Drawing.Size(44, 15)
        ClienteLabel1.TabIndex = 20
        ClienteLabel1.Text = "Cliente"
        '
        'AnivLabel
        '
        AnivLabel.AutoSize = True
        AnivLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AnivLabel.Location = New System.Drawing.Point(326, 154)
        AnivLabel.Name = "AnivLabel"
        AnivLabel.Size = New System.Drawing.Size(66, 15)
        AnivLabel.TabIndex = 22
        AnivLabel.Text = "Aniversário"
        AnivLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MedidasLabel
        '
        MedidasLabel.AutoSize = True
        MedidasLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MedidasLabel.Location = New System.Drawing.Point(17, 181)
        MedidasLabel.Name = "MedidasLabel"
        MedidasLabel.Size = New System.Drawing.Size(52, 15)
        MedidasLabel.TabIndex = 24
        MedidasLabel.Text = "Medidas"
        '
        'IndicaçaoLabel
        '
        IndicaçaoLabel.AutoSize = True
        IndicaçaoLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IndicaçaoLabel.Location = New System.Drawing.Point(334, 182)
        IndicaçaoLabel.Name = "IndicaçaoLabel"
        IndicaçaoLabel.Size = New System.Drawing.Size(58, 15)
        IndicaçaoLabel.TabIndex = 26
        IndicaçaoLabel.Text = "Indicação"
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnNovo, Me.btnSalvar, Me.btnUndo, Me.BarButtonItem1, Me.btnCompras, Me.btnPeçasCompradas})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 10
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowToolbarCustomizeItem = False
        Me.ribbonControl1.Size = New System.Drawing.Size(1004, 146)
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
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnCompras)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnPeçasCompradas)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(209, 429)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(119, 19)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Conta corrente"
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
        Me.ClientesBindingSource.Sort = ""
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(IndicaçaoLabel)
        Me.PanelControl1.Controls.Add(Me.IndicaçaoTextEdit)
        Me.PanelControl1.Controls.Add(MedidasLabel)
        Me.PanelControl1.Controls.Add(Me.MedidasTextEdit)
        Me.PanelControl1.Controls.Add(AnivLabel)
        Me.PanelControl1.Controls.Add(Me.AnivDateEdit)
        Me.PanelControl1.Controls.Add(ClienteLabel1)
        Me.PanelControl1.Controls.Add(Me.ClienteTextEdit1)
        Me.PanelControl1.Controls.Add(EmailLabel)
        Me.PanelControl1.Controls.Add(Me.EmailTextEdit)
        Me.PanelControl1.Controls.Add(FaxLabel)
        Me.PanelControl1.Controls.Add(Me.FaxTextEdit)
        Me.PanelControl1.Controls.Add(TelefoneLabel)
        Me.PanelControl1.Controls.Add(Me.TelefoneTextEdit)
        Me.PanelControl1.Controls.Add(CEPLabel)
        Me.PanelControl1.Controls.Add(Me.CEPTextEdit)
        Me.PanelControl1.Controls.Add(EstadoLabel)
        Me.PanelControl1.Controls.Add(Me.EstadoTextEdit)
        Me.PanelControl1.Controls.Add(CidadeLabel)
        Me.PanelControl1.Controls.Add(Me.CidadeTextEdit)
        Me.PanelControl1.Controls.Add(BairroLabel)
        Me.PanelControl1.Controls.Add(Me.BairroTextEdit)
        Me.PanelControl1.Controls.Add(EndereçoLabel)
        Me.PanelControl1.Controls.Add(Me.EndereçoTextEdit)
        Me.PanelControl1.Controls.Add(ClienteLabel)
        Me.PanelControl1.Controls.Add(Me.ClienteTextEdit)
        Me.PanelControl1.Controls.Add(TítuloLabel)
        Me.PanelControl1.Controls.Add(Me.TítuloComboBoxEdit)
        Me.PanelControl1.Location = New System.Drawing.Point(247, 179)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(511, 221)
        Me.PanelControl1.TabIndex = 8
        '
        'IndicaçaoTextEdit
        '
        Me.IndicaçaoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Indicaçao", True))
        Me.IndicaçaoTextEdit.Location = New System.Drawing.Point(396, 179)
        Me.IndicaçaoTextEdit.MenuManager = Me.ribbonControl1
        Me.IndicaçaoTextEdit.Name = "IndicaçaoTextEdit"
        Me.IndicaçaoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndicaçaoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.IndicaçaoTextEdit.Size = New System.Drawing.Size(92, 22)
        Me.IndicaçaoTextEdit.TabIndex = 27
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "Clientes"
        Me.ClientesBindingSource1.DataSource = Me.DsCliente
        '
        'DsCliente
        '
        Me.DsCliente.DataSetName = "dsCliente"
        Me.DsCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedidasTextEdit
        '
        Me.MedidasTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Medidas", True))
        Me.MedidasTextEdit.Location = New System.Drawing.Point(73, 178)
        Me.MedidasTextEdit.MenuManager = Me.ribbonControl1
        Me.MedidasTextEdit.Name = "MedidasTextEdit"
        Me.MedidasTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedidasTextEdit.Properties.Appearance.Options.UseFont = True
        Me.MedidasTextEdit.Size = New System.Drawing.Size(249, 22)
        Me.MedidasTextEdit.TabIndex = 25
        '
        'AnivDateEdit
        '
        Me.AnivDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Aniv", True))
        Me.AnivDateEdit.EditValue = Nothing
        Me.AnivDateEdit.Location = New System.Drawing.Point(396, 151)
        Me.AnivDateEdit.MenuManager = Me.ribbonControl1
        Me.AnivDateEdit.Name = "AnivDateEdit"
        Me.AnivDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnivDateEdit.Properties.Appearance.Options.UseFont = True
        Me.AnivDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AnivDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AnivDateEdit.Size = New System.Drawing.Size(92, 22)
        Me.AnivDateEdit.TabIndex = 23
        '
        'ClienteTextEdit1
        '
        Me.ClienteTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Nome", True))
        Me.ClienteTextEdit1.Location = New System.Drawing.Point(73, 151)
        Me.ClienteTextEdit1.MenuManager = Me.ribbonControl1
        Me.ClienteTextEdit1.Name = "ClienteTextEdit1"
        Me.ClienteTextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteTextEdit1.Properties.Appearance.Options.UseFont = True
        Me.ClienteTextEdit1.Size = New System.Drawing.Size(249, 22)
        Me.ClienteTextEdit1.TabIndex = 21
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(73, 124)
        Me.EmailTextEdit.MenuManager = Me.ribbonControl1
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextEdit.Properties.Appearance.Options.UseFont = True
        Me.EmailTextEdit.Size = New System.Drawing.Size(415, 22)
        Me.EmailTextEdit.TabIndex = 19
        '
        'FaxTextEdit
        '
        Me.FaxTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Fax", True))
        Me.FaxTextEdit.Location = New System.Drawing.Point(324, 98)
        Me.FaxTextEdit.MenuManager = Me.ribbonControl1
        Me.FaxTextEdit.Name = "FaxTextEdit"
        Me.FaxTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FaxTextEdit.Properties.Appearance.Options.UseFont = True
        Me.FaxTextEdit.Size = New System.Drawing.Size(164, 22)
        Me.FaxTextEdit.TabIndex = 17
        '
        'TelefoneTextEdit
        '
        Me.TelefoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Telefone", True))
        Me.TelefoneTextEdit.Location = New System.Drawing.Point(73, 98)
        Me.TelefoneTextEdit.MenuManager = Me.ribbonControl1
        Me.TelefoneTextEdit.Name = "TelefoneTextEdit"
        Me.TelefoneTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefoneTextEdit.Properties.Appearance.Options.UseFont = True
        Me.TelefoneTextEdit.Size = New System.Drawing.Size(212, 22)
        Me.TelefoneTextEdit.TabIndex = 15
        '
        'CEPTextEdit
        '
        Me.CEPTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "CEP", True))
        Me.CEPTextEdit.Location = New System.Drawing.Point(425, 72)
        Me.CEPTextEdit.MenuManager = Me.ribbonControl1
        Me.CEPTextEdit.Name = "CEPTextEdit"
        Me.CEPTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEPTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CEPTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.CEPTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CEPTextEdit.Properties.Mask.EditMask = "\d\d\d\d\d-\d\d\d"
        Me.CEPTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.CEPTextEdit.Size = New System.Drawing.Size(63, 22)
        Me.CEPTextEdit.TabIndex = 13
        '
        'EstadoTextEdit
        '
        Me.EstadoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Estado", True))
        Me.EstadoTextEdit.Location = New System.Drawing.Point(362, 72)
        Me.EstadoTextEdit.MenuManager = Me.ribbonControl1
        Me.EstadoTextEdit.Name = "EstadoTextEdit"
        Me.EstadoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.EstadoTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.EstadoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EstadoTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EstadoTextEdit.Size = New System.Drawing.Size(26, 22)
        Me.EstadoTextEdit.TabIndex = 11
        '
        'CidadeTextEdit
        '
        Me.CidadeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Cidade", True))
        Me.CidadeTextEdit.Location = New System.Drawing.Point(221, 72)
        Me.CidadeTextEdit.MenuManager = Me.ribbonControl1
        Me.CidadeTextEdit.Name = "CidadeTextEdit"
        Me.CidadeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CidadeTextEdit.Size = New System.Drawing.Size(91, 22)
        Me.CidadeTextEdit.TabIndex = 9
        '
        'BairroTextEdit
        '
        Me.BairroTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Bairro", True))
        Me.BairroTextEdit.Location = New System.Drawing.Point(73, 72)
        Me.BairroTextEdit.MenuManager = Me.ribbonControl1
        Me.BairroTextEdit.Name = "BairroTextEdit"
        Me.BairroTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BairroTextEdit.Properties.Appearance.Options.UseFont = True
        Me.BairroTextEdit.Size = New System.Drawing.Size(96, 22)
        Me.BairroTextEdit.TabIndex = 7
        '
        'EndereçoTextEdit
        '
        Me.EndereçoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Endereço", True))
        Me.EndereçoTextEdit.Location = New System.Drawing.Point(73, 46)
        Me.EndereçoTextEdit.MenuManager = Me.ribbonControl1
        Me.EndereçoTextEdit.Name = "EndereçoTextEdit"
        Me.EndereçoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndereçoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.EndereçoTextEdit.Size = New System.Drawing.Size(415, 22)
        Me.EndereçoTextEdit.TabIndex = 5
        '
        'ClienteTextEdit
        '
        Me.ClienteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Cliente", True))
        Me.ClienteTextEdit.Location = New System.Drawing.Point(233, 20)
        Me.ClienteTextEdit.MenuManager = Me.ribbonControl1
        Me.ClienteTextEdit.Name = "ClienteTextEdit"
        Me.ClienteTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ClienteTextEdit.Size = New System.Drawing.Size(255, 22)
        Me.ClienteTextEdit.TabIndex = 3
        '
        'TítuloComboBoxEdit
        '
        Me.TítuloComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Título", True))
        Me.TítuloComboBoxEdit.Location = New System.Drawing.Point(73, 20)
        Me.TítuloComboBoxEdit.MenuManager = Me.ribbonControl1
        Me.TítuloComboBoxEdit.Name = "TítuloComboBoxEdit"
        Me.TítuloComboBoxEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TítuloComboBoxEdit.Properties.Appearance.Options.UseFont = True
        Me.TítuloComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TítuloComboBoxEdit.Properties.Items.AddRange(New Object() {"Dr.", "Dra.", "Dr. e Sra.", "Dra. e Sr.", "Sr.", "Sra.", "Sr. e Sra."})
        Me.TítuloComboBoxEdit.Size = New System.Drawing.Size(77, 22)
        Me.TítuloComboBoxEdit.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.CCBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(334, 429)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.ribbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(337, 236)
        Me.GridControl1.TabIndex = 10
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CCBindingSource
        '
        Me.CCBindingSource.DataMember = "CC"
        Me.CCBindingSource.DataSource = Me.DsCliente
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOp, Me.colData, Me.colTp, Me.colVValor, Me.colCliente, Me.colIdent})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOp
        '
        Me.colOp.AppearanceCell.Options.UseTextOptions = True
        Me.colOp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOp.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colOp.AppearanceHeader.Options.UseTextOptions = True
        Me.colOp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOp.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colOp.Caption = "Operação"
        Me.colOp.FieldName = "Op"
        Me.colOp.Name = "colOp"
        Me.colOp.OptionsColumn.AllowEdit = False
        Me.colOp.OptionsColumn.AllowFocus = False
        Me.colOp.OptionsFilter.AllowFilter = False
        Me.colOp.Visible = True
        Me.colOp.VisibleIndex = 0
        Me.colOp.Width = 77
        '
        'colData
        '
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colData.AppearanceHeader.Options.UseTextOptions = True
        Me.colData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.AllowEdit = False
        Me.colData.OptionsColumn.AllowFocus = False
        Me.colData.OptionsFilter.AllowAutoFilter = False
        Me.colData.OptionsFilter.AllowFilter = False
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 1
        '
        'colTp
        '
        Me.colTp.AppearanceCell.Options.UseTextOptions = True
        Me.colTp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTp.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colTp.AppearanceHeader.Options.UseTextOptions = True
        Me.colTp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTp.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colTp.Caption = "Forma"
        Me.colTp.FieldName = "Tp"
        Me.colTp.Name = "colTp"
        Me.colTp.OptionsColumn.AllowEdit = False
        Me.colTp.OptionsColumn.AllowFocus = False
        Me.colTp.OptionsFilter.AllowAutoFilter = False
        Me.colTp.OptionsFilter.AllowFilter = False
        Me.colTp.Visible = True
        Me.colTp.VisibleIndex = 2
        Me.colTp.Width = 78
        '
        'colVValor
        '
        Me.colVValor.AppearanceHeader.Options.UseTextOptions = True
        Me.colVValor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVValor.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colVValor.Caption = "Valor"
        Me.colVValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colVValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVValor.FieldName = "VValor"
        Me.colVValor.Name = "colVValor"
        Me.colVValor.OptionsColumn.AllowEdit = False
        Me.colVValor.OptionsColumn.AllowFocus = False
        Me.colVValor.OptionsFilter.AllowAutoFilter = False
        Me.colVValor.OptionsFilter.AllowFilter = False
        Me.colVValor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VValor", "Saldo: {0:#,###0.00;-#,###0.00}")})
        Me.colVValor.Visible = True
        Me.colVValor.VisibleIndex = 3
        Me.colVValor.Width = 70
        '
        'colCliente
        '
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.AllowEdit = False
        Me.colCliente.OptionsColumn.AllowFocus = False
        '
        'colIdent
        '
        Me.colIdent.FieldName = "Ident"
        Me.colIdent.Name = "colIdent"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "CC"
        Me.BindingSource1.DataSource = Me.DsPrincipal1
        Me.BindingSource1.Sort = "Data"
        '
        'DsPrincipal1
        '
        Me.DsPrincipal1.DataSetName = "dsPrincipal"
        Me.DsPrincipal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CcTableAdapter1
        '
        Me.CcTableAdapter1.ClearBeforeFill = True
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ClientesTableAdapter = Me.ClientesTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = Pepe.dsClienteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDClienteTextEdit
        '
        Me.IDClienteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "IDCliente", True))
        Me.IDClienteTextEdit.Location = New System.Drawing.Point(337, 516)
        Me.IDClienteTextEdit.MenuManager = Me.ribbonControl1
        Me.IDClienteTextEdit.Name = "IDClienteTextEdit"
        Me.IDClienteTextEdit.Size = New System.Drawing.Size(33, 20)
        Me.IDClienteTextEdit.TabIndex = 13
        Me.IDClienteTextEdit.TabStop = False
        '
        'CCTableAdapter
        '
        Me.CCTableAdapter.ClearBeforeFill = True
        '
        'frmClientes
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1004, 693)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.IDClienteTextEdit)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmClientes"
        Me.Ribbon = Me.ribbonControl1
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.IndicaçaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnivDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnivDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEPTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BairroTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndereçoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TítuloComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrincipal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DsPrincipal As Pepe.dsPrincipal
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Pepe.dsPrincipalTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As Pepe.dsPrincipalTableAdapters.TableAdapterManager
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents EstadoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BairroTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EndereçoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ClienteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TítuloComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CEPTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelefoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AnivDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ClienteTextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IndicaçaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MedidasTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsPrincipal1 As Pepe.dsPrincipal
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CcTableAdapter1 As Pepe.dsPrincipalTableAdapters.CCTableAdapter
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCompras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPeçasCompradas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents DsCliente As dsCliente
    Friend WithEvents ClientesBindingSource1 As BindingSource
    Friend WithEvents ClientesTableAdapter1 As dsClienteTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager1 As dsClienteTableAdapters.TableAdapterManager
    Friend WithEvents IDClienteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CCBindingSource As BindingSource
    Friend WithEvents CCTableAdapter As dsClienteTableAdapters.CCTableAdapter
End Class
