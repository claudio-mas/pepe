Partial Public Class frmVenda
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
        Dim VendaLabel As System.Windows.Forms.Label
        Dim DataVendaLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim DestinoLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenda))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEtiqMalaDireta = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelarVenda = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCartões = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DsPrincipal = New Pepe.dsPrincipal()
        Me.VENDASBindingSource = New System.Windows.Forms.BindingSource()
        Me.VENDASTableAdapter = New Pepe.dsPrincipalTableAdapters.VENDASTableAdapter()
        Me.TableAdapterManager = New Pepe.dsPrincipalTableAdapters.TableAdapterManager()
        Me.VendasDetTableAdapter = New Pepe.dsPrincipalTableAdapters.VendasDetTableAdapter()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.MDCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtValorFinal = New DevExpress.XtraEditors.TextEdit()
        Me.txtDesconto = New DevExpress.XtraEditors.TextEdit()
        Me.txtTroca = New DevExpress.XtraEditors.TextEdit()
        Me.VendasDetGridControl = New DevExpress.XtraGrid.GridControl()
        Me.FKVENDASVendasDetBindingSource = New System.Windows.Forms.BindingSource()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAbrirItem = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboRef = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TabPeçasBindingSource = New System.Windows.Forms.BindingSource()
        Me.colValorVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComissão = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboId = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DestinoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpEdit3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.CboVendedorasBindingSource = New System.Windows.Forms.BindingSource()
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDataVenda = New DevExpress.XtraEditors.DateEdit()
        Me.txtVenda = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.ckOuroCC = New DevExpress.XtraEditors.CheckEdit()
        Me.txtOuro = New DevExpress.XtraEditors.TextEdit()
        Me.ckCashCC = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCash = New DevExpress.XtraEditors.TextEdit()
        Me.ckDolarCC = New DevExpress.XtraEditors.CheckEdit()
        Me.txtDolar = New DevExpress.XtraEditors.TextEdit()
        Me.Vencto_ChequesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Vencto_ChequesBindingSource = New System.Windows.Forms.BindingSource()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colParcela = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BancoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.cboParcelas = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ckChequeCC = New DevExpress.XtraEditors.CheckEdit()
        Me.txtTotalCheque = New DevExpress.XtraEditors.TextEdit()
        Me.IdTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ClientesTableAdapter = New Pepe.dsPrincipalTableAdapters.ClientesTableAdapter()
        Me.CboVendedorasTableAdapter = New Pepe.dsPrincipalTableAdapters.cboVendedorasTableAdapter()
        Me._1TabPeçasTableAdapter = New Pepe.dsPrincipalTableAdapters._1TabPeçasTableAdapter()
        Me.TableAdapterManager1 = New Pepe.dsPrincipalTableAdapters.TableAdapterManager()
        Me.VendasDetBindingSource = New System.Windows.Forms.BindingSource()
        Me.Vencto_ChequesTableAdapter = New Pepe.dsPrincipalTableAdapters.Vencto_ChequesTableAdapter()
        VendaLabel = New System.Windows.Forms.Label()
        DataVendaLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        DestinoLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        BancoLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.MDCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTroca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDetGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKVENDASVendasDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrirItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPeçasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboVendedorasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataVenda.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataVenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.ckOuroCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOuro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckCashCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCash.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckDolarCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDolar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vencto_ChequesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vencto_ChequesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboParcelas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckChequeCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VendaLabel
        '
        VendaLabel.AutoSize = True
        VendaLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VendaLabel.Location = New System.Drawing.Point(193, 23)
        VendaLabel.Name = "VendaLabel"
        VendaLabel.Size = New System.Drawing.Size(56, 15)
        VendaLabel.TabIndex = 0
        VendaLabel.Text = "Venda Nº"
        '
        'DataVendaLabel
        '
        DataVendaLabel.AutoSize = True
        DataVendaLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataVendaLabel.Location = New System.Drawing.Point(429, 23)
        DataVendaLabel.Name = "DataVendaLabel"
        DataVendaLabel.Size = New System.Drawing.Size(31, 15)
        DataVendaLabel.TabIndex = 2
        DataVendaLabel.Text = "Data"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(674, 23)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(50, 15)
        TipoLabel.TabIndex = 5
        TipoLabel.Text = "Tipo Vd."
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(205, 49)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(44, 15)
        Label1.TabIndex = 6
        Label1.Text = "Cliente"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(678, 49)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(46, 15)
        Label2.TabIndex = 8
        Label2.Text = "Crédito"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(183, 75)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(66, 15)
        Label3.TabIndex = 10
        Label3.Text = "Mala direta"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(186, 102)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(63, 15)
        Label4.TabIndex = 12
        Label4.Text = "Vendedora"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(665, 102)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(59, 15)
        Label5.TabIndex = 14
        Label5.Text = "Comissão"
        '
        'DestinoLabel
        '
        DestinoLabel.AutoSize = True
        DestinoLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DestinoLabel.Location = New System.Drawing.Point(175, 129)
        DestinoLabel.Name = "DestinoLabel"
        DestinoLabel.Size = New System.Drawing.Size(74, 15)
        DestinoLabel.TabIndex = 16
        DestinoLabel.Text = "Observações"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(326, 450)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(36, 15)
        Label6.TabIndex = 22
        Label6.Text = "Troca"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(443, 450)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(57, 15)
        Label7.TabIndex = 23
        Label7.Text = "Desconto"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(441, 478)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(59, 15)
        Label8.TabIndex = 24
        Label8.Text = "Valor final"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(128, 92)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(60, 15)
        Label9.TabIndex = 10
        Label9.Text = "Valor total"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(138, 119)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(50, 15)
        Label10.TabIndex = 13
        Label10.Text = "Parcelas"
        '
        'BancoLabel
        '
        BancoLabel.AutoSize = True
        BancoLabel.Location = New System.Drawing.Point(146, 147)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(40, 13)
        BancoLabel.TabIndex = 13
        BancoLabel.Text = "Banco:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.Color.Blue
        Label11.Location = New System.Drawing.Point(128, 65)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(59, 15)
        Label11.TabIndex = 15
        Label11.Text = "CHEQUES"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(153, 423)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(35, 15)
        Label12.TabIndex = 17
        Label12.Text = "Dólar"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(155, 450)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(33, 15)
        Label13.TabIndex = 20
        Label13.Text = "Cash"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.Location = New System.Drawing.Point(153, 476)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(34, 15)
        Label14.TabIndex = 23
        Label14.Text = "Ouro"
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnNovo, Me.btnEtiqMalaDireta, Me.btnSalvar, Me.btnUndo, Me.btnCancelarVenda, Me.btnCartões})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 10
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowToolbarCustomizeItem = False
        Me.ribbonControl1.Size = New System.Drawing.Size(1008, 147)
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
        Me.btnNovo.Caption = "Nova venda"
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
        'btnSalvar
        '
        Me.btnSalvar.Caption = "Salvar"
        Me.btnSalvar.Glyph = CType(resources.GetObject("btnSalvar.Glyph"), System.Drawing.Image)
        Me.btnSalvar.Id = 6
        Me.btnSalvar.LargeGlyph = CType(resources.GetObject("btnSalvar.LargeGlyph"), System.Drawing.Image)
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnUndo
        '
        Me.btnUndo.Caption = "Desfazer"
        Me.btnUndo.Glyph = CType(resources.GetObject("btnUndo.Glyph"), System.Drawing.Image)
        Me.btnUndo.Id = 7
        Me.btnUndo.LargeGlyph = CType(resources.GetObject("btnUndo.LargeGlyph"), System.Drawing.Image)
        Me.btnUndo.Name = "btnUndo"
        '
        'btnCancelarVenda
        '
        Me.btnCancelarVenda.Caption = "Cancelar venda"
        Me.btnCancelarVenda.Glyph = CType(resources.GetObject("btnCancelarVenda.Glyph"), System.Drawing.Image)
        Me.btnCancelarVenda.Id = 8
        Me.btnCancelarVenda.LargeGlyph = CType(resources.GetObject("btnCancelarVenda.LargeGlyph"), System.Drawing.Image)
        Me.btnCancelarVenda.Name = "btnCancelarVenda"
        '
        'btnCartões
        '
        Me.btnCartões.Caption = "Cartões"
        Me.btnCartões.Glyph = CType(resources.GetObject("btnCartões.Glyph"), System.Drawing.Image)
        Me.btnCartões.Id = 9
        Me.btnCartões.LargeGlyph = CType(resources.GetObject("btnCartões.LargeGlyph"), System.Drawing.Image)
        Me.btnCartões.Name = "btnCartões"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.ribbonPage1.Image = CType(resources.GetObject("ribbonPage1.Image"), System.Drawing.Image)
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "VENDAS"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnFechar)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnCancelarVenda)
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
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnCartões)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelControl1.Appearance.Image = CType(resources.GetObject("LabelControl1.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(388, 73)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(117, 39)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Venda"
        Me.LabelControl1.Visible = False
        '
        'DsPrincipal
        '
        Me.DsPrincipal.DataSetName = "dsPrincipal"
        Me.DsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VENDASBindingSource
        '
        Me.VENDASBindingSource.DataMember = "VENDAS"
        Me.VENDASBindingSource.DataSource = Me.DsPrincipal
        '
        'VENDASTableAdapter
        '
        Me.VENDASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._1TabPeçasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cboVendedorasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pepe.dsPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager.Vencto_ChequesTableAdapter = Nothing
        Me.TableAdapterManager.VENDAS_DETTableAdapter = Nothing
        Me.TableAdapterManager.VendasDetTableAdapter = Me.VendasDetTableAdapter
        Me.TableAdapterManager.VENDASTableAdapter = Me.VENDASTableAdapter
        '
        'VendasDetTableAdapter
        '
        Me.VendasDetTableAdapter.ClearBeforeFill = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(7, 150)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(993, 539)
        Me.XtraTabControl1.TabIndex = 5
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(Me.MDCheckEdit)
        Me.XtraTabPage1.Controls.Add(Me.Button1)
        Me.XtraTabPage1.Controls.Add(Label8)
        Me.XtraTabPage1.Controls.Add(Label7)
        Me.XtraTabPage1.Controls.Add(Label6)
        Me.XtraTabPage1.Controls.Add(Me.txtValorFinal)
        Me.XtraTabPage1.Controls.Add(Me.txtDesconto)
        Me.XtraTabPage1.Controls.Add(Me.txtTroca)
        Me.XtraTabPage1.Controls.Add(Me.VendasDetGridControl)
        Me.XtraTabPage1.Controls.Add(DestinoLabel)
        Me.XtraTabPage1.Controls.Add(Me.DestinoTextEdit)
        Me.XtraTabPage1.Controls.Add(Label5)
        Me.XtraTabPage1.Controls.Add(Me.TextEdit2)
        Me.XtraTabPage1.Controls.Add(Label4)
        Me.XtraTabPage1.Controls.Add(Me.LookUpEdit3)
        Me.XtraTabPage1.Controls.Add(Label3)
        Me.XtraTabPage1.Controls.Add(Me.LookUpEdit2)
        Me.XtraTabPage1.Controls.Add(Label2)
        Me.XtraTabPage1.Controls.Add(Me.TextEdit1)
        Me.XtraTabPage1.Controls.Add(Me.ComboBoxEdit1)
        Me.XtraTabPage1.Controls.Add(Label1)
        Me.XtraTabPage1.Controls.Add(TipoLabel)
        Me.XtraTabPage1.Controls.Add(Me.LookUpEdit1)
        Me.XtraTabPage1.Controls.Add(DataVendaLabel)
        Me.XtraTabPage1.Controls.Add(Me.txtDataVenda)
        Me.XtraTabPage1.Controls.Add(VendaLabel)
        Me.XtraTabPage1.Controls.Add(Me.txtVenda)
        Me.XtraTabPage1.Image = CType(resources.GetObject("XtraTabPage1.Image"), System.Drawing.Image)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(987, 508)
        Me.XtraTabPage1.Text = "DADOS DA VENDA"
        '
        'MDCheckEdit
        '
        Me.MDCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "MD", True))
        Me.MDCheckEdit.Location = New System.Drawing.Point(570, 74)
        Me.MDCheckEdit.MenuManager = Me.ribbonControl1
        Me.MDCheckEdit.Name = "MDCheckEdit"
        Me.MDCheckEdit.Properties.Caption = "Comprador"
        Me.MDCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.MDCheckEdit.TabIndex = 27
        Me.MDCheckEdit.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(723, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'txtValorFinal
        '
        Me.txtValorFinal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "ValorFinal", True))
        Me.txtValorFinal.Location = New System.Drawing.Point(504, 475)
        Me.txtValorFinal.MenuManager = Me.ribbonControl1
        Me.txtValorFinal.Name = "txtValorFinal"
        Me.txtValorFinal.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorFinal.Properties.Appearance.Options.UseFont = True
        Me.txtValorFinal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorFinal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorFinal.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtValorFinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorFinal.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtValorFinal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorFinal.Properties.Mask.EditMask = "n2"
        Me.txtValorFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorFinal.Size = New System.Drawing.Size(75, 22)
        Me.txtValorFinal.TabIndex = 21
        Me.txtValorFinal.TabStop = False
        '
        'txtDesconto
        '
        Me.txtDesconto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Desconto", True))
        Me.txtDesconto.Location = New System.Drawing.Point(504, 447)
        Me.txtDesconto.MenuManager = Me.ribbonControl1
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.Properties.Appearance.Options.UseFont = True
        Me.txtDesconto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDesconto.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtDesconto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDesconto.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtDesconto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDesconto.Properties.Mask.EditMask = "n2"
        Me.txtDesconto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDesconto.Size = New System.Drawing.Size(75, 22)
        Me.txtDesconto.TabIndex = 20
        '
        'txtTroca
        '
        Me.txtTroca.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Credito", True))
        Me.txtTroca.Location = New System.Drawing.Point(366, 447)
        Me.txtTroca.MenuManager = Me.ribbonControl1
        Me.txtTroca.Name = "txtTroca"
        Me.txtTroca.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTroca.Properties.Appearance.Options.UseFont = True
        Me.txtTroca.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTroca.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTroca.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtTroca.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTroca.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtTroca.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTroca.Properties.Mask.EditMask = "n2"
        Me.txtTroca.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTroca.Size = New System.Drawing.Size(63, 22)
        Me.txtTroca.TabIndex = 19
        '
        'VendasDetGridControl
        '
        Me.VendasDetGridControl.DataSource = Me.FKVENDASVendasDetBindingSource
        Me.VendasDetGridControl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendasDetGridControl.Location = New System.Drawing.Point(333, 162)
        Me.VendasDetGridControl.MainView = Me.GridView1
        Me.VendasDetGridControl.MenuManager = Me.ribbonControl1
        Me.VendasDetGridControl.Name = "VendasDetGridControl"
        Me.VendasDetGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboId, Me.RepositoryItemLookUpEdit1, Me.btnAbrirItem, Me.cboRef})
        Me.VendasDetGridControl.Size = New System.Drawing.Size(323, 273)
        Me.VendasDetGridControl.TabIndex = 18
        Me.VendasDetGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'FKVENDASVendasDetBindingSource
        '
        Me.FKVENDASVendasDetBindingSource.DataMember = "FK_VENDAS_VendasDet"
        Me.FKVENDASVendasDetBindingSource.DataSource = Me.VENDASBindingSource
        '
        'GridView1
        '
        Me.GridView1.ActiveFilterEnabled = False
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.btnItem, Me.GridColumn1, Me.colValorVenda, Me.colComissão, Me.colId, Me.colVenda})
        Me.GridView1.GridControl = Me.VendasDetGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'btnItem
        '
        Me.btnItem.Caption = " "
        Me.btnItem.ColumnEdit = Me.btnAbrirItem
        Me.btnItem.FieldName = "GridColumn2"
        Me.btnItem.Name = "btnItem"
        Me.btnItem.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.btnItem.Visible = True
        Me.btnItem.VisibleIndex = 0
        Me.btnItem.Width = 26
        '
        'btnAbrirItem
        '
        Me.btnAbrirItem.AutoHeight = False
        SuperToolTip1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem1.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipItem1.Appearance.Options.UseImage = True
        ToolTipItem1.Image = CType(resources.GetObject("ToolTipItem1.Image"), System.Drawing.Image)
        ToolTipItem1.Text = "Excluir peça"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnAbrirItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("btnAbrirItem.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, SuperToolTip1, True)})
        Me.btnAbrirItem.Name = "btnAbrirItem"
        Me.btnAbrirItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Ref."
        Me.GridColumn1.ColumnEdit = Me.cboRef
        Me.GridColumn1.FieldName = "Peça"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 133
        '
        'cboRef
        '
        Me.cboRef.AutoHeight = False
        Me.cboRef.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRef.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDPeça", "IDPeça", 60, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modêlo", "Modêlo", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendida", "Vendida", 48, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Comissão", "Comissão", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.cboRef.DataSource = Me.TabPeçasBindingSource
        Me.cboRef.DisplayMember = "Modêlo"
        Me.cboRef.Name = "cboRef"
        Me.cboRef.NullText = ""
        Me.cboRef.ValueMember = "IDPeça"
        '
        'TabPeçasBindingSource
        '
        Me.TabPeçasBindingSource.DataMember = "1TabPeças"
        Me.TabPeçasBindingSource.DataSource = Me.DsPrincipal
        Me.TabPeçasBindingSource.Filter = "Modêlo IS NOT NULL"
        Me.TabPeçasBindingSource.Sort = "Modêlo"
        '
        'colValorVenda
        '
        Me.colValorVenda.AppearanceCell.Options.UseTextOptions = True
        Me.colValorVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorVenda.AppearanceHeader.Options.UseTextOptions = True
        Me.colValorVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colValorVenda.Caption = "Valor"
        Me.colValorVenda.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colValorVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorVenda.FieldName = "ValorVenda"
        Me.colValorVenda.Name = "colValorVenda"
        Me.colValorVenda.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorVenda", "{0:#,###0.00;-#,###0.00}")})
        Me.colValorVenda.Visible = True
        Me.colValorVenda.VisibleIndex = 2
        Me.colValorVenda.Width = 72
        '
        'colComissão
        '
        Me.colComissão.AppearanceCell.Options.UseTextOptions = True
        Me.colComissão.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colComissão.AppearanceHeader.Options.UseTextOptions = True
        Me.colComissão.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComissão.Caption = "Com."
        Me.colComissão.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colComissão.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colComissão.FieldName = "Comissão"
        Me.colComissão.Name = "colComissão"
        Me.colComissão.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Comissão", "{0:#,###0.00;-#,###0.00}")})
        Me.colComissão.Visible = True
        Me.colComissão.VisibleIndex = 3
        Me.colComissão.Width = 74
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colVenda
        '
        Me.colVenda.FieldName = "Venda"
        Me.colVenda.Name = "colVenda"
        '
        'cboId
        '
        Me.cboId.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboId.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDPeça", "ID Peça", 60, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modêlo", "Modêlo", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[True]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendida", "Vendida", 48, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Valor", "Valor", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Comissão", "Comissão", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Com2", "Com2", 37, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.cboId.DataSource = Me.TabPeçasBindingSource
        Me.cboId.DisplayMember = "Modêlo"
        Me.cboId.DropDownItemHeight = 20
        Me.cboId.DropDownRows = 12
        Me.cboId.Name = "cboId"
        Me.cboId.NullText = ""
        Me.cboId.ValueMember = "IDPeça"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.TabPeçasBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Modêlo"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "IDPeça"
        '
        'DestinoTextEdit
        '
        Me.DestinoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Destino", True))
        Me.DestinoTextEdit.Location = New System.Drawing.Point(253, 126)
        Me.DestinoTextEdit.MenuManager = Me.ribbonControl1
        Me.DestinoTextEdit.Name = "DestinoTextEdit"
        Me.DestinoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestinoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DestinoTextEdit.Size = New System.Drawing.Size(557, 22)
        Me.DestinoTextEdit.TabIndex = 17
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Comissão", True))
        Me.TextEdit2.Location = New System.Drawing.Point(728, 99)
        Me.TextEdit2.MenuManager = Me.ribbonControl1
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit2.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.TextEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.TextEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.Mask.EditMask = "n2"
        Me.TextEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit2.Size = New System.Drawing.Size(82, 22)
        Me.TextEdit2.TabIndex = 13
        '
        'LookUpEdit3
        '
        Me.LookUpEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Vendedora", True))
        Me.LookUpEdit3.Location = New System.Drawing.Point(253, 99)
        Me.LookUpEdit3.MenuManager = Me.ribbonControl1
        Me.LookUpEdit3.Name = "LookUpEdit3"
        Me.LookUpEdit3.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit3.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendedora", "Vendedora", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[True]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID Vendedora", "ID Vendedora", 76, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit3.Properties.DataSource = Me.CboVendedorasBindingSource
        Me.LookUpEdit3.Properties.DisplayMember = "Vendedora"
        Me.LookUpEdit3.Properties.DropDownRows = 12
        Me.LookUpEdit3.Properties.NullText = ""
        Me.LookUpEdit3.Properties.ValueMember = "Vendedora"
        Me.LookUpEdit3.Size = New System.Drawing.Size(311, 22)
        Me.LookUpEdit3.TabIndex = 11
        '
        'CboVendedorasBindingSource
        '
        Me.CboVendedorasBindingSource.DataMember = "cboVendedoras"
        Me.CboVendedorasBindingSource.DataSource = Me.DsPrincipal
        '
        'LookUpEdit2
        '
        Me.LookUpEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "IDCliente", True))
        Me.LookUpEdit2.Enabled = False
        Me.LookUpEdit2.Location = New System.Drawing.Point(253, 72)
        Me.LookUpEdit2.MenuManager = Me.ribbonControl1
        Me.LookUpEdit2.Name = "LookUpEdit2"
        Me.LookUpEdit2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit2.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCliente", "ID Cliente", 70, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cliente", "Mala direta", 43, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.LookUpEdit2.Properties.DataSource = Me.ClientesBindingSource
        Me.LookUpEdit2.Properties.DisplayMember = "Cliente"
        Me.LookUpEdit2.Properties.DropDownRows = 12
        Me.LookUpEdit2.Properties.NullText = ""
        Me.LookUpEdit2.Properties.ValueMember = "IDCliente"
        Me.LookUpEdit2.Size = New System.Drawing.Size(311, 22)
        Me.LookUpEdit2.TabIndex = 9
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DsPrincipal
        Me.ClientesBindingSource.Filter = ""
        Me.ClientesBindingSource.Sort = "Nome"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Troca", True))
        Me.TextEdit1.Location = New System.Drawing.Point(728, 46)
        Me.TextEdit1.MenuManager = Me.ribbonControl1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.TextEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.Mask.EditMask = "n2"
        Me.TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit1.Size = New System.Drawing.Size(82, 22)
        Me.TextEdit1.TabIndex = 7
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Tipo", True))
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(728, 20)
        Me.ComboBoxEdit1.MenuManager = Me.ribbonControl1
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"Interna", "Externa"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(82, 22)
        Me.ComboBoxEdit1.TabIndex = 2
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "IDCliente", True))
        Me.LookUpEdit1.Location = New System.Drawing.Point(253, 46)
        Me.LookUpEdit1.MenuManager = Me.ribbonControl1
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit1.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCliente", "ID Cliente", 70, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.LookUpEdit1.Properties.DataSource = Me.ClientesBindingSource
        Me.LookUpEdit1.Properties.DisplayMember = "Nome"
        Me.LookUpEdit1.Properties.DropDownRows = 12
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.ValueMember = "IDCliente"
        Me.LookUpEdit1.Size = New System.Drawing.Size(311, 22)
        Me.LookUpEdit1.TabIndex = 3
        '
        'txtDataVenda
        '
        Me.txtDataVenda.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "DataVenda", True))
        Me.txtDataVenda.EditValue = Nothing
        Me.txtDataVenda.Location = New System.Drawing.Point(464, 20)
        Me.txtDataVenda.MenuManager = Me.ribbonControl1
        Me.txtDataVenda.Name = "txtDataVenda"
        Me.txtDataVenda.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataVenda.Properties.Appearance.Options.UseFont = True
        Me.txtDataVenda.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDataVenda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDataVenda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDataVenda.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDataVenda.Size = New System.Drawing.Size(100, 22)
        Me.txtDataVenda.TabIndex = 1
        '
        'txtVenda
        '
        Me.txtVenda.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Venda", True))
        Me.txtVenda.Location = New System.Drawing.Point(253, 20)
        Me.txtVenda.MenuManager = Me.ribbonControl1
        Me.txtVenda.Name = "txtVenda"
        Me.txtVenda.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVenda.Properties.Appearance.Options.UseFont = True
        Me.txtVenda.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVenda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtVenda.Size = New System.Drawing.Size(71, 22)
        Me.txtVenda.TabIndex = 0
        Me.txtVenda.TabStop = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.ckOuroCC)
        Me.XtraTabPage2.Controls.Add(Label14)
        Me.XtraTabPage2.Controls.Add(Me.txtOuro)
        Me.XtraTabPage2.Controls.Add(Me.ckCashCC)
        Me.XtraTabPage2.Controls.Add(Label13)
        Me.XtraTabPage2.Controls.Add(Me.txtCash)
        Me.XtraTabPage2.Controls.Add(Me.ckDolarCC)
        Me.XtraTabPage2.Controls.Add(Label12)
        Me.XtraTabPage2.Controls.Add(Me.txtDolar)
        Me.XtraTabPage2.Controls.Add(Me.Vencto_ChequesGridControl)
        Me.XtraTabPage2.Controls.Add(Label11)
        Me.XtraTabPage2.Controls.Add(BancoLabel)
        Me.XtraTabPage2.Controls.Add(Me.BancoTextEdit)
        Me.XtraTabPage2.Controls.Add(Me.cboParcelas)
        Me.XtraTabPage2.Controls.Add(Label10)
        Me.XtraTabPage2.Controls.Add(Me.ckChequeCC)
        Me.XtraTabPage2.Controls.Add(Label9)
        Me.XtraTabPage2.Controls.Add(Me.txtTotalCheque)
        Me.XtraTabPage2.Image = CType(resources.GetObject("XtraTabPage2.Image"), System.Drawing.Image)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(987, 508)
        Me.XtraTabPage2.Text = "FORMA DE PAGAMENTO"
        '
        'ckOuroCC
        '
        Me.ckOuroCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "OuroCC", True))
        Me.ckOuroCC.Location = New System.Drawing.Point(283, 475)
        Me.ckOuroCC.MenuManager = Me.ribbonControl1
        Me.ckOuroCC.Name = "ckOuroCC"
        Me.ckOuroCC.Properties.Caption = "C/C"
        Me.ckOuroCC.Size = New System.Drawing.Size(44, 19)
        Me.ckOuroCC.TabIndex = 24
        '
        'txtOuro
        '
        Me.txtOuro.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Ouro", True))
        Me.txtOuro.Location = New System.Drawing.Point(192, 473)
        Me.txtOuro.MenuManager = Me.ribbonControl1
        Me.txtOuro.Name = "txtOuro"
        Me.txtOuro.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOuro.Properties.Appearance.Options.UseFont = True
        Me.txtOuro.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOuro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOuro.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtOuro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOuro.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtOuro.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOuro.Properties.Mask.EditMask = "n2"
        Me.txtOuro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOuro.Size = New System.Drawing.Size(82, 22)
        Me.txtOuro.TabIndex = 22
        '
        'ckCashCC
        '
        Me.ckCashCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "CashCC", True))
        Me.ckCashCC.Location = New System.Drawing.Point(283, 449)
        Me.ckCashCC.MenuManager = Me.ribbonControl1
        Me.ckCashCC.Name = "ckCashCC"
        Me.ckCashCC.Properties.Caption = "C/C"
        Me.ckCashCC.Size = New System.Drawing.Size(44, 19)
        Me.ckCashCC.TabIndex = 21
        '
        'txtCash
        '
        Me.txtCash.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Real", True))
        Me.txtCash.Location = New System.Drawing.Point(192, 447)
        Me.txtCash.MenuManager = Me.ribbonControl1
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Properties.Appearance.Options.UseFont = True
        Me.txtCash.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCash.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCash.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtCash.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCash.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtCash.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCash.Properties.Mask.EditMask = "n2"
        Me.txtCash.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCash.Size = New System.Drawing.Size(82, 22)
        Me.txtCash.TabIndex = 19
        '
        'ckDolarCC
        '
        Me.ckDolarCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "DolarCC", True))
        Me.ckDolarCC.Location = New System.Drawing.Point(283, 422)
        Me.ckDolarCC.MenuManager = Me.ribbonControl1
        Me.ckDolarCC.Name = "ckDolarCC"
        Me.ckDolarCC.Properties.Caption = "C/C"
        Me.ckDolarCC.Size = New System.Drawing.Size(44, 19)
        Me.ckDolarCC.TabIndex = 18
        '
        'txtDolar
        '
        Me.txtDolar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Dolar", True))
        Me.txtDolar.Location = New System.Drawing.Point(192, 420)
        Me.txtDolar.MenuManager = Me.ribbonControl1
        Me.txtDolar.Name = "txtDolar"
        Me.txtDolar.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDolar.Properties.Appearance.Options.UseFont = True
        Me.txtDolar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDolar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDolar.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtDolar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDolar.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtDolar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDolar.Properties.Mask.EditMask = "n2"
        Me.txtDolar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDolar.Size = New System.Drawing.Size(82, 22)
        Me.txtDolar.TabIndex = 16
        '
        'Vencto_ChequesGridControl
        '
        Me.Vencto_ChequesGridControl.DataSource = Me.Vencto_ChequesBindingSource
        Me.Vencto_ChequesGridControl.Location = New System.Drawing.Point(21, 177)
        Me.Vencto_ChequesGridControl.MainView = Me.GridView2
        Me.Vencto_ChequesGridControl.MenuManager = Me.ribbonControl1
        Me.Vencto_ChequesGridControl.Name = "Vencto_ChequesGridControl"
        Me.Vencto_ChequesGridControl.Size = New System.Drawing.Size(458, 235)
        Me.Vencto_ChequesGridControl.TabIndex = 15
        Me.Vencto_ChequesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'Vencto_ChequesBindingSource
        '
        Me.Vencto_ChequesBindingSource.DataMember = "FK_VENDAS_Vencto Cheques"
        Me.Vencto_ChequesBindingSource.DataSource = Me.VENDASBindingSource
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colParcela, Me.colVencto, Me.colVValor, Me.colCheque, Me.colBanco})
        Me.GridView2.GridControl = Me.Vencto_ChequesGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colParcela
        '
        Me.colParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcela.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colParcela.AppearanceHeader.Options.UseTextOptions = True
        Me.colParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcela.FieldName = "Parcela"
        Me.colParcela.Name = "colParcela"
        Me.colParcela.Visible = True
        Me.colParcela.VisibleIndex = 0
        Me.colParcela.Width = 63
        '
        'colVencto
        '
        Me.colVencto.AppearanceCell.Options.UseTextOptions = True
        Me.colVencto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencto.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colVencto.AppearanceHeader.Options.UseTextOptions = True
        Me.colVencto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencto.Caption = "Vencto."
        Me.colVencto.FieldName = "Vencto"
        Me.colVencto.Name = "colVencto"
        Me.colVencto.Visible = True
        Me.colVencto.VisibleIndex = 1
        Me.colVencto.Width = 92
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
        Me.colVValor.Visible = True
        Me.colVValor.VisibleIndex = 2
        Me.colVValor.Width = 81
        '
        'colCheque
        '
        Me.colCheque.AppearanceCell.Options.UseTextOptions = True
        Me.colCheque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCheque.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCheque.AppearanceHeader.Options.UseTextOptions = True
        Me.colCheque.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCheque.Caption = "Nº Cheque"
        Me.colCheque.FieldName = "Cheque"
        Me.colCheque.Name = "colCheque"
        Me.colCheque.Visible = True
        Me.colCheque.VisibleIndex = 3
        Me.colCheque.Width = 110
        '
        'colBanco
        '
        Me.colBanco.Caption = "Banco"
        Me.colBanco.FieldName = "Banco"
        Me.colBanco.Name = "colBanco"
        Me.colBanco.Visible = True
        Me.colBanco.VisibleIndex = 4
        Me.colBanco.Width = 176
        '
        'BancoTextEdit
        '
        Me.BancoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Banco", True))
        Me.BancoTextEdit.Location = New System.Drawing.Point(192, 144)
        Me.BancoTextEdit.MenuManager = Me.ribbonControl1
        Me.BancoTextEdit.Name = "BancoTextEdit"
        Me.BancoTextEdit.Size = New System.Drawing.Size(126, 20)
        Me.BancoTextEdit.TabIndex = 14
        '
        'cboParcelas
        '
        Me.cboParcelas.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "FormaCheque", True))
        Me.cboParcelas.Location = New System.Drawing.Point(192, 116)
        Me.cboParcelas.MenuManager = Me.ribbonControl1
        Me.cboParcelas.Name = "cboParcelas"
        Me.cboParcelas.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboParcelas.Properties.Appearance.Options.UseFont = True
        Me.cboParcelas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboParcelas.Properties.Items.AddRange(New Object() {"À vista", "2x", "3x", "4x", "5x", "6x", "7x", "8x", "9x", "10x"})
        Me.cboParcelas.Size = New System.Drawing.Size(82, 22)
        Me.cboParcelas.TabIndex = 12
        '
        'ckChequeCC
        '
        Me.ckChequeCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "ChequeCC", True))
        Me.ckChequeCC.Location = New System.Drawing.Point(283, 91)
        Me.ckChequeCC.MenuManager = Me.ribbonControl1
        Me.ckChequeCC.Name = "ckChequeCC"
        Me.ckChequeCC.Properties.Caption = "C/C"
        Me.ckChequeCC.Size = New System.Drawing.Size(44, 19)
        Me.ckChequeCC.TabIndex = 11
        '
        'txtTotalCheque
        '
        Me.txtTotalCheque.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Cheque", True))
        Me.txtTotalCheque.Location = New System.Drawing.Point(192, 89)
        Me.txtTotalCheque.MenuManager = Me.ribbonControl1
        Me.txtTotalCheque.Name = "txtTotalCheque"
        Me.txtTotalCheque.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCheque.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCheque.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalCheque.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalCheque.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtTotalCheque.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalCheque.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtTotalCheque.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalCheque.Properties.Mask.EditMask = "n2"
        Me.txtTotalCheque.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalCheque.Size = New System.Drawing.Size(82, 22)
        Me.txtTotalCheque.TabIndex = 9
        '
        'IdTextEdit
        '
        Me.IdTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Id", True))
        Me.IdTextEdit.Location = New System.Drawing.Point(532, 152)
        Me.IdTextEdit.MenuManager = Me.ribbonControl1
        Me.IdTextEdit.Name = "IdTextEdit"
        Me.IdTextEdit.Size = New System.Drawing.Size(73, 20)
        Me.IdTextEdit.TabIndex = 26
        Me.IdTextEdit.TabStop = False
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'CboVendedorasTableAdapter
        '
        Me.CboVendedorasTableAdapter.ClearBeforeFill = True
        '
        '_1TabPeçasTableAdapter
        '
        Me._1TabPeçasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1._1TabPeçasTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.cboVendedorasTableAdapter = Nothing
        Me.TableAdapterManager1.ClientesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Pepe.dsPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager1.Vencto_ChequesTableAdapter = Nothing
        Me.TableAdapterManager1.VENDAS_DETTableAdapter = Nothing
        Me.TableAdapterManager1.VendasDetTableAdapter = Me.VendasDetTableAdapter
        Me.TableAdapterManager1.VENDASTableAdapter = Nothing
        '
        'VendasDetBindingSource
        '
        Me.VendasDetBindingSource.DataMember = "FK_VENDAS_VendasDet"
        Me.VendasDetBindingSource.DataSource = Me.VENDASBindingSource
        '
        'Vencto_ChequesTableAdapter
        '
        Me.Vencto_ChequesTableAdapter.ClearBeforeFill = True
        '
        'frmVenda
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1008, 695)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.IdTextEdit)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmVenda"
        Me.Ribbon = Me.ribbonControl1
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.MDCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTroca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDetGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKVENDASVendasDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrirItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPeçasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboVendedorasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataVenda.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataVenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.ckOuroCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOuro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckCashCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCash.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckDolarCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDolar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vencto_ChequesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vencto_ChequesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboParcelas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckChequeCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnEtiqMalaDireta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents VENDASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VENDASTableAdapter As Pepe.dsPrincipalTableAdapters.VENDASTableAdapter
    Friend WithEvents TableAdapterManager As Pepe.dsPrincipalTableAdapters.TableAdapterManager
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtDataVenda As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtVenda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Pepe.dsPrincipalTableAdapters.ClientesTableAdapter
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEdit3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CboVendedorasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CboVendedorasTableAdapter As Pepe.dsPrincipalTableAdapters.cboVendedorasTableAdapter
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DestinoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendasDetGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colValorVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComissão As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboId As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TabPeçasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _1TabPeçasTableAdapter As Pepe.dsPrincipalTableAdapters._1TabPeçasTableAdapter
    Friend WithEvents btnItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAbrirItem As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboRef As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelarVenda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents txtValorFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDesconto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTroca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IdTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TableAdapterManager1 As Pepe.dsPrincipalTableAdapters.TableAdapterManager
    Friend WithEvents VendasDetTableAdapter As Pepe.dsPrincipalTableAdapters.VendasDetTableAdapter
    Friend WithEvents VendasDetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FKVENDASVendasDetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MDCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCartões As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BancoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboParcelas As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ckChequeCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTotalCheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Vencto_ChequesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vencto_ChequesTableAdapter As Pepe.dsPrincipalTableAdapters.Vencto_ChequesTableAdapter
    Friend WithEvents Vencto_ChequesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ckOuroCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtOuro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckCashCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCash As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckDolarCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtDolar As DevExpress.XtraEditors.TextEdit
End Class
