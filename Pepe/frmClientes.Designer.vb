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
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLancaCC = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCompras = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPeçasCompradas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDel = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.DsPrincipal = New Pepe.DataSet1()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Pepe.DataSet1TableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Pepe.DataSet1TableAdapters.TableAdapterManager()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCEP = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCliente = New Pepe.dsCliente()
        Me.CPFTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AnivDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ClienteTextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelefoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CEPTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EstadoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BairroTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EndereçoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ClienteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TítuloComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.MedidasTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.IndicaçaoTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.CCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAbrirCC = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPrincipal1 = New Pepe.DataSet1()
        Me.CcTableAdapter1 = New Pepe.DataSet1TableAdapters.CCTableAdapter()
        Me.ClientesTableAdapter1 = New Pepe.dsClienteTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager1 = New Pepe.dsClienteTableAdapters.TableAdapterManager()
        Me.IDClienteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CCTableAdapter = New Pepe.dsClienteTableAdapters.CCTableAdapter()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
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
        Label1 = New System.Windows.Forms.Label()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CPFTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnivDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnivDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEPTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BairroTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndereçoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TítuloComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndicaçaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrirCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrincipal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TítuloLabel
        '
        TítuloLabel.AutoSize = True
        TítuloLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TítuloLabel.Location = New System.Drawing.Point(31, 16)
        TítuloLabel.Name = "TítuloLabel"
        TítuloLabel.Size = New System.Drawing.Size(37, 15)
        TítuloLabel.TabIndex = 0
        TítuloLabel.Text = "Título"
        TítuloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClienteLabel
        '
        ClienteLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClienteLabel.Location = New System.Drawing.Point(164, 15)
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
        EndereçoLabel.Location = New System.Drawing.Point(173, 40)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(56, 15)
        EndereçoLabel.TabIndex = 4
        EndereçoLabel.Text = "Endereço"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BairroLabel.Location = New System.Drawing.Point(31, 65)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(38, 15)
        BairroLabel.TabIndex = 6
        BairroLabel.Text = "Bairro"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CidadeLabel.Location = New System.Drawing.Point(262, 67)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(44, 15)
        CidadeLabel.TabIndex = 8
        CidadeLabel.Text = "Cidade"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(416, 67)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(42, 15)
        EstadoLabel.TabIndex = 10
        EstadoLabel.Text = "Estado"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CEPLabel.Location = New System.Drawing.Point(41, 39)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(28, 15)
        CEPLabel.TabIndex = 12
        CEPLabel.Text = "CEP"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.Location = New System.Drawing.Point(17, 91)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(51, 15)
        TelefoneLabel.TabIndex = 14
        TelefoneLabel.Text = "Telefone"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FaxLabel.Location = New System.Drawing.Point(332, 91)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(28, 15)
        FaxLabel.TabIndex = 16
        FaxLabel.Text = "CPF"
        FaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(28, 117)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(41, 15)
        EmailLabel.TabIndex = 18
        EmailLabel.Text = "E-mail"
        '
        'ClienteLabel1
        '
        ClienteLabel1.AutoSize = True
        ClienteLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClienteLabel1.Location = New System.Drawing.Point(25, 143)
        ClienteLabel1.Name = "ClienteLabel1"
        ClienteLabel1.Size = New System.Drawing.Size(44, 15)
        ClienteLabel1.TabIndex = 20
        ClienteLabel1.Text = "Cliente"
        '
        'AnivLabel
        '
        AnivLabel.AutoSize = True
        AnivLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AnivLabel.Location = New System.Drawing.Point(335, 145)
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
        MedidasLabel.Location = New System.Drawing.Point(17, 170)
        MedidasLabel.Name = "MedidasLabel"
        MedidasLabel.Size = New System.Drawing.Size(52, 15)
        MedidasLabel.TabIndex = 24
        MedidasLabel.Text = "Medidas"
        '
        'IndicaçaoLabel
        '
        IndicaçaoLabel.AutoSize = True
        IndicaçaoLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IndicaçaoLabel.Location = New System.Drawing.Point(10, 220)
        IndicaçaoLabel.Name = "IndicaçaoLabel"
        IndicaçaoLabel.Size = New System.Drawing.Size(58, 15)
        IndicaçaoLabel.TabIndex = 26
        IndicaçaoLabel.Text = "Indicação"
        '
        'Label1
        '
        Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(318, 118)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(84, 15)
        Label1.TabIndex = 28
        Label1.Text = "Data Cadastro"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnNovo, Me.btnSalvar, Me.btnUndo, Me.btnLancaCC, Me.btnCompras, Me.btnPeçasCompradas, Me.btnDel})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 11
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
        'btnDel
        '
        Me.btnDel.Caption = "Excluir"
        Me.btnDel.Id = 10
        Me.btnDel.ImageOptions.Image = CType(resources.GetObject("btnDel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDel.ImageOptions.LargeImage = CType(resources.GetObject("btnDel.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDel.Name = "btnDel"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "CADASTRO DE CLIENTES"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnNovo)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnDel, True)
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
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnLancaCC)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnCompras, True)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnPeçasCompradas)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnFechar)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
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
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PanelControl1.Controls.Add(Me.btnCEP)
        Me.PanelControl1.Controls.Add(Label1)
        Me.PanelControl1.Controls.Add(Me.DateEdit1)
        Me.PanelControl1.Controls.Add(Me.CPFTextEdit)
        Me.PanelControl1.Controls.Add(IndicaçaoLabel)
        Me.PanelControl1.Controls.Add(MedidasLabel)
        Me.PanelControl1.Controls.Add(AnivLabel)
        Me.PanelControl1.Controls.Add(Me.AnivDateEdit)
        Me.PanelControl1.Controls.Add(ClienteLabel1)
        Me.PanelControl1.Controls.Add(Me.ClienteTextEdit1)
        Me.PanelControl1.Controls.Add(EmailLabel)
        Me.PanelControl1.Controls.Add(Me.EmailTextEdit)
        Me.PanelControl1.Controls.Add(FaxLabel)
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
        Me.PanelControl1.Controls.Add(Me.MedidasTextEdit)
        Me.PanelControl1.Controls.Add(Me.IndicaçaoTextEdit)
        Me.PanelControl1.Location = New System.Drawing.Point(415, 176)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(508, 276)
        Me.PanelControl1.TabIndex = 0
        '
        'btnCEP
        '
        Me.btnCEP.ImageOptions.Image = CType(resources.GetObject("btnCEP.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCEP.Location = New System.Drawing.Point(139, 37)
        Me.btnCEP.Name = "btnCEP"
        Me.btnCEP.Size = New System.Drawing.Size(22, 23)
        Me.btnCEP.TabIndex = 29
        Me.btnCEP.TabStop = False
        Me.btnCEP.Text = "x"
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "DataCad", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(405, 114)
        Me.DateEdit1.MenuManager = Me.ribbonControl1
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(83, 24)
        Me.DateEdit1.TabIndex = 10
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "Clientes"
        Me.ClientesBindingSource1.DataSource = Me.DsCliente
        '
        'DsCliente
        '
        Me.DsCliente.DataSetName = "dsCliente"
        Me.DsCliente.EnforceConstraints = False
        Me.DsCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CPFTextEdit
        '
        Me.CPFTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "CPF", True))
        Me.CPFTextEdit.Location = New System.Drawing.Point(362, 88)
        Me.CPFTextEdit.MenuManager = Me.ribbonControl1
        Me.CPFTextEdit.Name = "CPFTextEdit"
        Me.CPFTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.CPFTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CPFTextEdit.Properties.AutoHeight = False
        Me.CPFTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CPFTextEdit.Properties.Mask.BeepOnError = True
        Me.CPFTextEdit.Properties.Mask.EditMask = "\d\d\d\.\d\d\d\.\d\d\d\-\d\d"
        Me.CPFTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.CPFTextEdit.Properties.Mask.SaveLiteral = False
        Me.CPFTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.CPFTextEdit.Size = New System.Drawing.Size(126, 24)
        Me.CPFTextEdit.TabIndex = 8
        '
        'AnivDateEdit
        '
        Me.AnivDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Aniv", True))
        Me.AnivDateEdit.EditValue = Nothing
        Me.AnivDateEdit.Location = New System.Drawing.Point(405, 140)
        Me.AnivDateEdit.MenuManager = Me.ribbonControl1
        Me.AnivDateEdit.Name = "AnivDateEdit"
        Me.AnivDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnivDateEdit.Properties.Appearance.Options.UseFont = True
        Me.AnivDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.AnivDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AnivDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AnivDateEdit.Size = New System.Drawing.Size(83, 24)
        Me.AnivDateEdit.TabIndex = 12
        '
        'ClienteTextEdit1
        '
        Me.ClienteTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Nome", True))
        Me.ClienteTextEdit1.Location = New System.Drawing.Point(73, 140)
        Me.ClienteTextEdit1.MenuManager = Me.ribbonControl1
        Me.ClienteTextEdit1.Name = "ClienteTextEdit1"
        Me.ClienteTextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteTextEdit1.Properties.Appearance.Options.UseFont = True
        Me.ClienteTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ClienteTextEdit1.Size = New System.Drawing.Size(239, 24)
        Me.ClienteTextEdit1.TabIndex = 11
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(73, 114)
        Me.EmailTextEdit.MenuManager = Me.ribbonControl1
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextEdit.Properties.Appearance.Options.UseFont = True
        Me.EmailTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.EmailTextEdit.Size = New System.Drawing.Size(239, 24)
        Me.EmailTextEdit.TabIndex = 9
        '
        'TelefoneTextEdit
        '
        Me.TelefoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Telefone", True))
        Me.TelefoneTextEdit.Location = New System.Drawing.Point(73, 88)
        Me.TelefoneTextEdit.MenuManager = Me.ribbonControl1
        Me.TelefoneTextEdit.Name = "TelefoneTextEdit"
        Me.TelefoneTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefoneTextEdit.Properties.Appearance.Options.UseFont = True
        Me.TelefoneTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TelefoneTextEdit.Size = New System.Drawing.Size(239, 24)
        Me.TelefoneTextEdit.TabIndex = 7
        '
        'CEPTextEdit
        '
        Me.CEPTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "CEP", True))
        Me.CEPTextEdit.Location = New System.Drawing.Point(73, 36)
        Me.CEPTextEdit.MenuManager = Me.ribbonControl1
        Me.CEPTextEdit.Name = "CEPTextEdit"
        Me.CEPTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEPTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CEPTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.CEPTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CEPTextEdit.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Yellow
        Me.CEPTextEdit.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.CEPTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CEPTextEdit.Properties.Mask.EditMask = "\d\d\d\d\d-\d\d\d"
        Me.CEPTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.CEPTextEdit.Size = New System.Drawing.Size(63, 24)
        Me.CEPTextEdit.TabIndex = 2
        '
        'EstadoTextEdit
        '
        Me.EstadoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Estado", True))
        Me.EstadoTextEdit.Location = New System.Drawing.Point(462, 62)
        Me.EstadoTextEdit.MenuManager = Me.ribbonControl1
        Me.EstadoTextEdit.Name = "EstadoTextEdit"
        Me.EstadoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.EstadoTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.EstadoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EstadoTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EstadoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.EstadoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstadoTextEdit.Size = New System.Drawing.Size(26, 24)
        Me.EstadoTextEdit.TabIndex = 6
        '
        'CidadeTextEdit
        '
        Me.CidadeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Cidade", True))
        Me.CidadeTextEdit.Location = New System.Drawing.Point(310, 62)
        Me.CidadeTextEdit.MenuManager = Me.ribbonControl1
        Me.CidadeTextEdit.Name = "CidadeTextEdit"
        Me.CidadeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CidadeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CidadeTextEdit.Size = New System.Drawing.Size(100, 24)
        Me.CidadeTextEdit.TabIndex = 5
        '
        'BairroTextEdit
        '
        Me.BairroTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Bairro", True))
        Me.BairroTextEdit.Location = New System.Drawing.Point(73, 62)
        Me.BairroTextEdit.MenuManager = Me.ribbonControl1
        Me.BairroTextEdit.Name = "BairroTextEdit"
        Me.BairroTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BairroTextEdit.Properties.Appearance.Options.UseFont = True
        Me.BairroTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BairroTextEdit.Size = New System.Drawing.Size(162, 24)
        Me.BairroTextEdit.TabIndex = 4
        '
        'EndereçoTextEdit
        '
        Me.EndereçoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Endereço", True))
        Me.EndereçoTextEdit.Location = New System.Drawing.Point(233, 36)
        Me.EndereçoTextEdit.MenuManager = Me.ribbonControl1
        Me.EndereçoTextEdit.Name = "EndereçoTextEdit"
        Me.EndereçoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndereçoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.EndereçoTextEdit.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Yellow
        Me.EndereçoTextEdit.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.EndereçoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.EndereçoTextEdit.Size = New System.Drawing.Size(255, 24)
        Me.EndereçoTextEdit.TabIndex = 3
        '
        'ClienteTextEdit
        '
        Me.ClienteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Cliente", True))
        Me.ClienteTextEdit.Location = New System.Drawing.Point(233, 10)
        Me.ClienteTextEdit.MenuManager = Me.ribbonControl1
        Me.ClienteTextEdit.Name = "ClienteTextEdit"
        Me.ClienteTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ClienteTextEdit.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Yellow
        Me.ClienteTextEdit.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.ClienteTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ClienteTextEdit.Size = New System.Drawing.Size(255, 24)
        Me.ClienteTextEdit.TabIndex = 1
        '
        'TítuloComboBoxEdit
        '
        Me.TítuloComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Título", True))
        Me.TítuloComboBoxEdit.Location = New System.Drawing.Point(73, 10)
        Me.TítuloComboBoxEdit.MenuManager = Me.ribbonControl1
        Me.TítuloComboBoxEdit.Name = "TítuloComboBoxEdit"
        Me.TítuloComboBoxEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TítuloComboBoxEdit.Properties.Appearance.Options.UseFont = True
        Me.TítuloComboBoxEdit.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Yellow
        Me.TítuloComboBoxEdit.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.TítuloComboBoxEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TítuloComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TítuloComboBoxEdit.Properties.Items.AddRange(New Object() {"Dr.", "Dra.", "Dr. e Sra.", "Dra. e Sr.", "Sr.", "Sra.", "Sr. e Sra."})
        Me.TítuloComboBoxEdit.Size = New System.Drawing.Size(87, 24)
        Me.TítuloComboBoxEdit.TabIndex = 0
        '
        'MedidasTextEdit
        '
        Me.MedidasTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Medidas", True))
        Me.MedidasTextEdit.Location = New System.Drawing.Point(73, 166)
        Me.MedidasTextEdit.MenuManager = Me.ribbonControl1
        Me.MedidasTextEdit.Name = "MedidasTextEdit"
        Me.MedidasTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedidasTextEdit.Properties.Appearance.Options.UseFont = True
        Me.MedidasTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MedidasTextEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MedidasTextEdit.Size = New System.Drawing.Size(415, 48)
        Me.MedidasTextEdit.TabIndex = 13
        '
        'IndicaçaoTextEdit
        '
        Me.IndicaçaoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "Indicaçao", True))
        Me.IndicaçaoTextEdit.Location = New System.Drawing.Point(72, 216)
        Me.IndicaçaoTextEdit.MenuManager = Me.ribbonControl1
        Me.IndicaçaoTextEdit.Name = "IndicaçaoTextEdit"
        Me.IndicaçaoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndicaçaoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.IndicaçaoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.IndicaçaoTextEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.IndicaçaoTextEdit.Size = New System.Drawing.Size(416, 48)
        Me.IndicaçaoTextEdit.TabIndex = 14
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.CCBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(435, 485)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.ribbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnAbrirCC})
        Me.GridControl1.Size = New System.Drawing.Size(469, 234)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CCBindingSource
        '
        Me.CCBindingSource.DataMember = "CC"
        Me.CCBindingSource.DataSource = Me.DsCliente
        Me.CCBindingSource.Filter = "VValor <> 0"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colOp, Me.colData, Me.colTp, Me.colVValor, Me.colCliente, Me.colIdent, Me.GridColumn1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colData, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
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
        Me.colOp.VisibleIndex = 1
        Me.colOp.Width = 120
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
        Me.colData.VisibleIndex = 2
        Me.colData.Width = 93
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
        Me.colTp.VisibleIndex = 3
        Me.colTp.Width = 133
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
        Me.colVValor.VisibleIndex = 4
        Me.colVValor.Width = 91
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
        'GridColumn1
        '
        Me.GridColumn1.ColumnEdit = Me.btnAbrirCC
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 28
        '
        'btnAbrirCC
        '
        Me.btnAbrirCC.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnAbrirCC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnAbrirCC.Name = "btnAbrirCC"
        Me.btnAbrirCC.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
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
        Me.TableAdapterManager1.CartõesTableAdapter = Nothing
        Me.TableAdapterManager1.ClientesCadastradosTableAdapter = Nothing
        Me.TableAdapterManager1.ClientesTableAdapter = Me.ClientesTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = Pepe.dsClienteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.Vencto_CartãoTableAdapter = Nothing
        '
        'IDClienteTextEdit
        '
        Me.IDClienteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource1, "IDCliente", True))
        Me.IDClienteTextEdit.Location = New System.Drawing.Point(449, 611)
        Me.IDClienteTextEdit.MenuManager = Me.ribbonControl1
        Me.IDClienteTextEdit.Name = "IDClienteTextEdit"
        Me.IDClienteTextEdit.Size = New System.Drawing.Size(56, 20)
        Me.IDClienteTextEdit.TabIndex = 13
        Me.IDClienteTextEdit.TabStop = False
        '
        'CCTableAdapter
        '
        Me.CCTableAdapter.ClearBeforeFill = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseBackColor = True
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl3.Location = New System.Drawing.Point(557, 148)
        Me.LabelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.LabelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(224, 23)
        Me.LabelControl3.TabIndex = 19
        Me.LabelControl3.Text = "Cadastro"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseBackColor = True
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl4.Location = New System.Drawing.Point(557, 457)
        Me.LabelControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.LabelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(224, 22)
        Me.LabelControl4.TabIndex = 20
        Me.LabelControl4.Text = "Conta Corrente"
        '
        'frmClientes
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1338, 722)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.IDClienteTextEdit)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IconOptions.Icon = CType(resources.GetObject("frmClientes.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmClientes"
        Me.Ribbon = Me.ribbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CPFTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnivDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnivDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEPTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BairroTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndereçoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TítuloComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndicaçaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrirCC, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnNovo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsPrincipal As Pepe.DataSet1
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Pepe.DataSet1TableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As Pepe.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents EstadoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BairroTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EndereçoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ClienteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TítuloComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CEPTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelefoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AnivDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ClienteTextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsPrincipal1 As Pepe.DataSet1
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CcTableAdapter1 As Pepe.DataSet1TableAdapters.CCTableAdapter
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnLancaCC As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAbrirCC As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents CPFTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnCEP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MedidasTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents IndicaçaoTextEdit As DevExpress.XtraEditors.MemoEdit
End Class
