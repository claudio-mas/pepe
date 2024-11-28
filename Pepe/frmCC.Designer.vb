Partial Public Class frmCC
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
        Dim DataLabel As System.Windows.Forms.Label
        Dim ChequeLabel As System.Windows.Forms.Label
        Dim FormaChequeLabel As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim BancoTransfLabel As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCC))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CartõesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCC = New Pepe.dsCC()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLancaCC = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCompras = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPeçasCompradas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribDel = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.DsPrincipal = New Pepe.DataSet1()
        Me.Conta_CorrenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Conta_CorrenteTableAdapter = New Pepe.dsCCTableAdapters.Conta_CorrenteTableAdapter()
        Me.TableAdapterManager = New Pepe.dsCCTableAdapters.TableAdapterManager()
        Me.Vencto_CartãoTableAdapter = New Pepe.dsCCTableAdapters.Vencto_CartãoTableAdapter()
        Me.Vencto_ChequesTableAdapter = New Pepe.dsCCTableAdapters.Vencto_ChequesTableAdapter()
        Me.DataDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ClienteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ChequeSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FormaChequeComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.BancoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControlCHEQUES = New DevExpress.XtraEditors.GroupControl()
        Me.Vencto_ChequesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Vencto_ChequesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParcela = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChequeCCCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControlCARTAO = New DevExpress.XtraEditors.GroupControl()
        Me.Vencto_CartãoGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Vencto_CartãoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParcela1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencto1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVValor1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomeCartão = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCC1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNomeCartao = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCCCartao = New DevExpress.XtraEditors.CheckEdit()
        Me.txtFormaCartao = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtValorCartao = New DevExpress.XtraEditors.TextEdit()
        Me.IDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CartõesTableAdapter = New Pepe.dsCCTableAdapters.CartõesTableAdapter()
        Me.lblCliente = New DevExpress.XtraEditors.LabelControl()
        Me.txtDolar = New DevExpress.XtraEditors.TextEdit()
        Me.txtCash = New DevExpress.XtraEditors.TextEdit()
        Me.txtOuro = New DevExpress.XtraEditors.TextEdit()
        Me.txtDolarCC = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCashCC = New DevExpress.XtraEditors.CheckEdit()
        Me.txtOuroCC = New DevExpress.XtraEditors.CheckEdit()
        Me.txtDebCC = New DevExpress.XtraEditors.TextEdit()
        Me.txtBancoTransf = New DevExpress.XtraEditors.TextEdit()
        Me.txtTransf = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.txtAUT = New DevExpress.XtraEditors.TextEdit()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        DataLabel = New System.Windows.Forms.Label()
        ChequeLabel = New System.Windows.Forms.Label()
        FormaChequeLabel = New System.Windows.Forms.Label()
        BancoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        BancoTransfLabel = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartõesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Conta_CorrenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaChequeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControlCHEQUES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControlCHEQUES.SuspendLayout()
        CType(Me.Vencto_ChequesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vencto_ChequesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeCCCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControlCARTAO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControlCARTAO.SuspendLayout()
        CType(Me.Vencto_CartãoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vencto_CartãoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomeCartao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCCCartao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormaCartao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorCartao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDolar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCash.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOuro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDolarCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOuroCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBancoTransf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAUT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataLabel
        '
        DataLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataLabel.Location = New System.Drawing.Point(601, 192)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(34, 13)
        DataLabel.TabIndex = 17
        DataLabel.Text = "Data"
        DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChequeLabel
        '
        ChequeLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChequeLabel.Location = New System.Drawing.Point(5, 42)
        ChequeLabel.Name = "ChequeLabel"
        ChequeLabel.Size = New System.Drawing.Size(67, 13)
        ChequeLabel.TabIndex = 19
        ChequeLabel.Text = "Valor Total"
        ChequeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormaChequeLabel
        '
        FormaChequeLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormaChequeLabel.Location = New System.Drawing.Point(213, 43)
        FormaChequeLabel.Name = "FormaChequeLabel"
        FormaChequeLabel.Size = New System.Drawing.Size(81, 13)
        FormaChequeLabel.TabIndex = 20
        FormaChequeLabel.Text = "Parcelamento"
        FormaChequeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BancoLabel
        '
        BancoLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BancoLabel.Location = New System.Drawing.Point(407, 44)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(40, 13)
        BancoLabel.TabIndex = 21
        BancoLabel.Text = "Banco"
        BancoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(9, 40)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(68, 13)
        Label1.TabIndex = 29
        Label1.Text = "Valor Total"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(225, 41)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(81, 13)
        Label2.TabIndex = 30
        Label2.Text = "Parcelamento"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(413, 42)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(56, 13)
        Label3.TabIndex = 33
        Label3.Text = "Cartão"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(439, 602)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(58, 13)
        Label4.TabIndex = 32
        Label4.Text = "Dólar"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(439, 629)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(58, 13)
        Label5.TabIndex = 34
        Label5.Text = "Cash"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(439, 657)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(58, 13)
        Label6.TabIndex = 36
        Label6.Text = "Ouro"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(787, 604)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(60, 13)
        Label7.TabIndex = 40
        Label7.Text = "Débito C/C"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BancoTransfLabel
        '
        BancoTransfLabel.AutoSize = True
        BancoTransfLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BancoTransfLabel.Location = New System.Drawing.Point(805, 658)
        BancoTransfLabel.Name = "BancoTransfLabel"
        BancoTransfLabel.Size = New System.Drawing.Size(40, 14)
        BancoTransfLabel.TabIndex = 45
        BancoTransfLabel.Text = "Banco"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label17.Location = New System.Drawing.Point(717, 630)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(128, 14)
        Label17.TabIndex = 44
        Label17.Text = "Transferência Bancária"
        Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(54, 597)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(76, 14)
        Label8.TabIndex = 48
        Label8.Text = "Observações"
        '
        'Label22
        '
        Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label22.Location = New System.Drawing.Point(1201, 207)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(71, 17)
        Label22.TabIndex = 53
        Label22.Text = "AUT."
        Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ncartao", "Cartão", 61, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.CartõesBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Ncartao"
        Me.RepositoryItemLookUpEdit1.DropDownRows = 21
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "Ncartao"
        '
        'CartõesBindingSource
        '
        Me.CartõesBindingSource.DataMember = "Cartões"
        Me.CartõesBindingSource.DataSource = Me.DsCC
        '
        'DsCC
        '
        Me.DsCC.DataSetName = "dsCC"
        Me.DsCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnSalvar, Me.btnUndo, Me.btnLancaCC, Me.btnCompras, Me.btnPeçasCompradas, Me.btnDel, Me.btnAdd})
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
        ToolTipItem1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem1.ImageOptions.ImageUri.Uri = "diagramicons/del;Size16x16"
        ToolTipItem1.Text = "<color=white><backcolor=red><b>Exclui o lançamento integral</b></backcolor></colo" &
    "r>"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnDel.SuperTip = SuperToolTip1
        '
        'btnAdd
        '
        Me.btnAdd.Caption = "Incluir"
        Me.btnAdd.Id = 11
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.LargeImage = CType(resources.GetObject("btnAdd.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.ribDel, Me.ribbonPageGroup1})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "LANÇAMENTO C/C"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSalvar)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnUndo)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Visible = False
        '
        'ribDel
        '
        Me.ribDel.ItemLinks.Add(Me.btnDel)
        Me.ribDel.ItemLinks.Add(Me.btnAdd)
        Me.ribDel.Name = "ribDel"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnFechar)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        '
        'DsPrincipal
        '
        Me.DsPrincipal.DataSetName = "dsPrincipal"
        Me.DsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.Vencto_CartãoTableAdapter = Me.Vencto_CartãoTableAdapter
        Me.TableAdapterManager.Vencto_ChequesTableAdapter = Me.Vencto_ChequesTableAdapter
        '
        'Vencto_CartãoTableAdapter
        '
        Me.Vencto_CartãoTableAdapter.ClearBeforeFill = True
        '
        'Vencto_ChequesTableAdapter
        '
        Me.Vencto_ChequesTableAdapter.ClearBeforeFill = True
        '
        'DataDateEdit
        '
        Me.DataDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "Data", True))
        Me.DataDateEdit.EditValue = Nothing
        Me.DataDateEdit.Location = New System.Drawing.Point(638, 188)
        Me.DataDateEdit.MenuManager = Me.ribbonControl1
        Me.DataDateEdit.Name = "DataDateEdit"
        Me.DataDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DataDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataDateEdit.Properties.Appearance.Options.UseFont = True
        Me.DataDateEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.DataDateEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DataDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DataDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataDateEdit.Size = New System.Drawing.Size(100, 22)
        Me.DataDateEdit.TabIndex = 0
        '
        'ClienteTextEdit
        '
        Me.ClienteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "Cliente", True))
        Me.ClienteTextEdit.Location = New System.Drawing.Point(635, 148)
        Me.ClienteTextEdit.MenuManager = Me.ribbonControl1
        Me.ClienteTextEdit.Name = "ClienteTextEdit"
        Me.ClienteTextEdit.Size = New System.Drawing.Size(53, 20)
        Me.ClienteTextEdit.TabIndex = 19
        Me.ClienteTextEdit.TabStop = False
        '
        'ChequeSpinEdit
        '
        Me.ChequeSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "Cheque", True))
        Me.ChequeSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ChequeSpinEdit.Location = New System.Drawing.Point(75, 37)
        Me.ChequeSpinEdit.MenuManager = Me.ribbonControl1
        Me.ChequeSpinEdit.Name = "ChequeSpinEdit"
        Me.ChequeSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChequeSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.ChequeSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.ChequeSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ChequeSpinEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ChequeSpinEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.ChequeSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ChequeSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.ChequeSpinEdit.Properties.Mask.EditMask = "n"
        Me.ChequeSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.ChequeSpinEdit.Size = New System.Drawing.Size(68, 22)
        Me.ChequeSpinEdit.TabIndex = 0
        '
        'FormaChequeComboBoxEdit
        '
        Me.FormaChequeComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "FormaCheque", True))
        Me.FormaChequeComboBoxEdit.Location = New System.Drawing.Point(297, 38)
        Me.FormaChequeComboBoxEdit.MenuManager = Me.ribbonControl1
        Me.FormaChequeComboBoxEdit.Name = "FormaChequeComboBoxEdit"
        Me.FormaChequeComboBoxEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormaChequeComboBoxEdit.Properties.Appearance.Options.UseFont = True
        Me.FormaChequeComboBoxEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.FormaChequeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FormaChequeComboBoxEdit.Properties.DropDownRows = 12
        Me.FormaChequeComboBoxEdit.Properties.Items.AddRange(New Object() {"À vista", "2x", "3x", "4x", "5x", "6x", "7x", "8x", "9x", "10x"})
        Me.FormaChequeComboBoxEdit.Size = New System.Drawing.Size(79, 22)
        Me.FormaChequeComboBoxEdit.TabIndex = 1
        '
        'BancoTextEdit
        '
        Me.BancoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "Banco", True))
        Me.BancoTextEdit.Location = New System.Drawing.Point(451, 39)
        Me.BancoTextEdit.MenuManager = Me.ribbonControl1
        Me.BancoTextEdit.Name = "BancoTextEdit"
        Me.BancoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BancoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.BancoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BancoTextEdit.Size = New System.Drawing.Size(159, 22)
        Me.BancoTextEdit.TabIndex = 2
        '
        'GroupControlCHEQUES
        '
        Me.GroupControlCHEQUES.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControlCHEQUES.AppearanceCaption.ForeColor = System.Drawing.Color.Yellow
        Me.GroupControlCHEQUES.AppearanceCaption.Options.UseFont = True
        Me.GroupControlCHEQUES.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControlCHEQUES.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControlCHEQUES.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControlCHEQUES.Controls.Add(Me.txtCliente)
        Me.GroupControlCHEQUES.Controls.Add(Me.Vencto_ChequesGridControl)
        Me.GroupControlCHEQUES.Controls.Add(Me.ChequeCCCheckEdit)
        Me.GroupControlCHEQUES.Controls.Add(Me.FormaChequeComboBoxEdit)
        Me.GroupControlCHEQUES.Controls.Add(BancoLabel)
        Me.GroupControlCHEQUES.Controls.Add(Me.ChequeSpinEdit)
        Me.GroupControlCHEQUES.Controls.Add(Me.BancoTextEdit)
        Me.GroupControlCHEQUES.Controls.Add(ChequeLabel)
        Me.GroupControlCHEQUES.Controls.Add(FormaChequeLabel)
        ButtonImageOptions1.Image = CType(resources.GetObject("ButtonImageOptions1.Image"), System.Drawing.Image)
        ToolTipItem2.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem2.ImageOptions.ImageUri.Uri = "snap/snapdeletelist;Size16x16"
        ToolTipItem2.Text = "<b>Exclui todos os dados referentes a cheque(s)</b>"
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.GroupControlCHEQUES.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, SuperToolTip2, True, False, True, Nothing, -1)})
        Me.GroupControlCHEQUES.Location = New System.Drawing.Point(49, 258)
        Me.GroupControlCHEQUES.Name = "GroupControlCHEQUES"
        Me.GroupControlCHEQUES.Size = New System.Drawing.Size(620, 321)
        Me.GroupControlCHEQUES.TabIndex = 24
        Me.GroupControlCHEQUES.Text = "CHEQUE"
        '
        'Vencto_ChequesGridControl
        '
        Me.Vencto_ChequesGridControl.DataSource = Me.Vencto_ChequesBindingSource
        Me.Vencto_ChequesGridControl.Location = New System.Drawing.Point(6, 71)
        Me.Vencto_ChequesGridControl.MainView = Me.GridView1
        Me.Vencto_ChequesGridControl.MenuManager = Me.ribbonControl1
        Me.Vencto_ChequesGridControl.Name = "Vencto_ChequesGridControl"
        Me.Vencto_ChequesGridControl.Size = New System.Drawing.Size(607, 245)
        Me.Vencto_ChequesGridControl.TabIndex = 26
        Me.Vencto_ChequesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'Vencto_ChequesBindingSource
        '
        Me.Vencto_ChequesBindingSource.DataMember = "Conta Corrente_Vencto Cheques"
        Me.Vencto_ChequesBindingSource.DataSource = Me.Conta_CorrenteBindingSource
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colParcela, Me.colVencto, Me.colVValor, Me.colCheque, Me.colBanco, Me.colIdCC})
        Me.GridView1.GridControl = Me.Vencto_ChequesGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colParcela
        '
        Me.colParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcela.AppearanceHeader.Options.UseTextOptions = True
        Me.colParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcela.FieldName = "Parcela"
        Me.colParcela.Name = "colParcela"
        Me.colParcela.OptionsColumn.AllowEdit = False
        Me.colParcela.Visible = True
        Me.colParcela.VisibleIndex = 0
        Me.colParcela.Width = 53
        '
        'colVencto
        '
        Me.colVencto.AppearanceCell.Options.UseTextOptions = True
        Me.colVencto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencto.AppearanceHeader.Options.UseTextOptions = True
        Me.colVencto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencto.Caption = "Vencto."
        Me.colVencto.FieldName = "Vencto"
        Me.colVencto.Name = "colVencto"
        Me.colVencto.Visible = True
        Me.colVencto.VisibleIndex = 1
        Me.colVencto.Width = 93
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
        Me.colVValor.Width = 84
        '
        'colCheque
        '
        Me.colCheque.AppearanceCell.Options.UseTextOptions = True
        Me.colCheque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCheque.AppearanceHeader.Options.UseTextOptions = True
        Me.colCheque.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCheque.Caption = "Nº Cheque"
        Me.colCheque.FieldName = "Cheque"
        Me.colCheque.Name = "colCheque"
        Me.colCheque.Visible = True
        Me.colCheque.VisibleIndex = 3
        Me.colCheque.Width = 122
        '
        'colBanco
        '
        Me.colBanco.AppearanceHeader.Options.UseTextOptions = True
        Me.colBanco.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBanco.FieldName = "Banco"
        Me.colBanco.Name = "colBanco"
        Me.colBanco.Visible = True
        Me.colBanco.VisibleIndex = 4
        Me.colBanco.Width = 236
        '
        'colIdCC
        '
        Me.colIdCC.FieldName = "IdCC"
        Me.colIdCC.Name = "colIdCC"
        '
        'ChequeCCCheckEdit
        '
        Me.ChequeCCCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "ChequeCC", True))
        Me.ChequeCCCheckEdit.EditValue = True
        Me.ChequeCCCheckEdit.Location = New System.Drawing.Point(149, 39)
        Me.ChequeCCCheckEdit.MenuManager = Me.ribbonControl1
        Me.ChequeCCCheckEdit.Name = "ChequeCCCheckEdit"
        Me.ChequeCCCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChequeCCCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.ChequeCCCheckEdit.Properties.Caption = "C.C."
        Me.ChequeCCCheckEdit.Size = New System.Drawing.Size(46, 20)
        Me.ChequeCCCheckEdit.TabIndex = 23
        Me.ChequeCCCheckEdit.TabStop = False
        '
        'GroupControlCARTAO
        '
        Me.GroupControlCARTAO.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControlCARTAO.AppearanceCaption.ForeColor = System.Drawing.Color.Yellow
        Me.GroupControlCARTAO.AppearanceCaption.Options.UseFont = True
        Me.GroupControlCARTAO.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControlCARTAO.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControlCARTAO.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControlCARTAO.Controls.Add(Me.Vencto_CartãoGridControl)
        Me.GroupControlCARTAO.Controls.Add(Label3)
        Me.GroupControlCARTAO.Controls.Add(Me.txtNomeCartao)
        Me.GroupControlCARTAO.Controls.Add(Me.txtCCCartao)
        Me.GroupControlCARTAO.Controls.Add(Me.txtFormaCartao)
        Me.GroupControlCARTAO.Controls.Add(Label2)
        Me.GroupControlCARTAO.Controls.Add(Me.txtValorCartao)
        Me.GroupControlCARTAO.Controls.Add(Label1)
        ButtonImageOptions2.Image = CType(resources.GetObject("ButtonImageOptions2.Image"), System.Drawing.Image)
        ButtonImageOptions2.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.BeforeText
        ToolTipItem3.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem3.ImageOptions.ImageUri.Uri = "snap/snapdeletelist;Size16x16"
        ToolTipItem3.Text = "<b>Exclui todos os dados referentes a cartão de crédito/débito</b>"
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.GroupControlCARTAO.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, SuperToolTip3, True, False, True, Nothing, -1)})
        Me.GroupControlCARTAO.Location = New System.Drawing.Point(696, 258)
        Me.GroupControlCARTAO.Name = "GroupControlCARTAO"
        Me.GroupControlCARTAO.Size = New System.Drawing.Size(593, 321)
        Me.GroupControlCARTAO.TabIndex = 25
        Me.GroupControlCARTAO.Text = "CARTÃO"
        '
        'Vencto_CartãoGridControl
        '
        Me.Vencto_CartãoGridControl.DataSource = Me.Vencto_CartãoBindingSource
        Me.Vencto_CartãoGridControl.Location = New System.Drawing.Point(8, 71)
        Me.Vencto_CartãoGridControl.MainView = Me.GridView2
        Me.Vencto_CartãoGridControl.MenuManager = Me.ribbonControl1
        Me.Vencto_CartãoGridControl.Name = "Vencto_CartãoGridControl"
        Me.Vencto_CartãoGridControl.Size = New System.Drawing.Size(577, 245)
        Me.Vencto_CartãoGridControl.TabIndex = 26
        Me.Vencto_CartãoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'Vencto_CartãoBindingSource
        '
        Me.Vencto_CartãoBindingSource.DataMember = "Conta Corrente_Vencto Cartão"
        Me.Vencto_CartãoBindingSource.DataSource = Me.Conta_CorrenteBindingSource
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1, Me.colParcela1, Me.colVencto1, Me.colVValor1, Me.colNomeCartão, Me.colIdCC1})
        Me.GridView2.GridControl = Me.Vencto_CartãoGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colId1
        '
        Me.colId1.FieldName = "Id"
        Me.colId1.Name = "colId1"
        '
        'colParcela1
        '
        Me.colParcela1.AppearanceCell.Options.UseTextOptions = True
        Me.colParcela1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcela1.AppearanceHeader.Options.UseTextOptions = True
        Me.colParcela1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcela1.FieldName = "Parcela"
        Me.colParcela1.Name = "colParcela1"
        Me.colParcela1.Visible = True
        Me.colParcela1.VisibleIndex = 0
        Me.colParcela1.Width = 70
        '
        'colVencto1
        '
        Me.colVencto1.AppearanceCell.Options.UseTextOptions = True
        Me.colVencto1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencto1.AppearanceHeader.Options.UseTextOptions = True
        Me.colVencto1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencto1.Caption = "Vencto."
        Me.colVencto1.FieldName = "Vencto"
        Me.colVencto1.Name = "colVencto1"
        Me.colVencto1.Visible = True
        Me.colVencto1.VisibleIndex = 1
        Me.colVencto1.Width = 94
        '
        'colVValor1
        '
        Me.colVValor1.AppearanceHeader.Options.UseTextOptions = True
        Me.colVValor1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVValor1.Caption = "Valor"
        Me.colVValor1.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colVValor1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVValor1.FieldName = "VValor"
        Me.colVValor1.Name = "colVValor1"
        Me.colVValor1.Visible = True
        Me.colVValor1.VisibleIndex = 2
        Me.colVValor1.Width = 106
        '
        'colNomeCartão
        '
        Me.colNomeCartão.AppearanceCell.Options.UseTextOptions = True
        Me.colNomeCartão.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNomeCartão.AppearanceHeader.Options.UseTextOptions = True
        Me.colNomeCartão.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNomeCartão.Caption = "Cartão"
        Me.colNomeCartão.FieldName = "NomeCartão"
        Me.colNomeCartão.Name = "colNomeCartão"
        Me.colNomeCartão.OptionsColumn.AllowEdit = False
        Me.colNomeCartão.OptionsColumn.ReadOnly = True
        Me.colNomeCartão.Visible = True
        Me.colNomeCartão.VisibleIndex = 3
        Me.colNomeCartão.Width = 267
        '
        'colIdCC1
        '
        Me.colIdCC1.FieldName = "IdCC"
        Me.colIdCC1.Name = "colIdCC1"
        '
        'txtNomeCartao
        '
        Me.txtNomeCartao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "NomeCartão", True))
        Me.txtNomeCartao.Location = New System.Drawing.Point(472, 37)
        Me.txtNomeCartao.MenuManager = Me.ribbonControl1
        Me.txtNomeCartao.Name = "txtNomeCartao"
        Me.txtNomeCartao.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCartao.Properties.Appearance.Options.UseFont = True
        Me.txtNomeCartao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtNomeCartao.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNomeCartao.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ncartao", "Cartão", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Perc", "Perc", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.txtNomeCartao.Properties.DataSource = Me.CartõesBindingSource
        Me.txtNomeCartao.Properties.DisplayMember = "Ncartao"
        Me.txtNomeCartao.Properties.DropDownRows = 26
        Me.txtNomeCartao.Properties.NullText = ""
        Me.txtNomeCartao.Properties.ValueMember = "Ncartao"
        Me.txtNomeCartao.Size = New System.Drawing.Size(112, 22)
        Me.txtNomeCartao.TabIndex = 32
        '
        'txtCCCartao
        '
        Me.txtCCCartao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "CartãoCC", True))
        Me.txtCCCartao.EditValue = True
        Me.txtCCCartao.Location = New System.Drawing.Point(154, 37)
        Me.txtCCCartao.MenuManager = Me.ribbonControl1
        Me.txtCCCartao.Name = "txtCCCartao"
        Me.txtCCCartao.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCCCartao.Properties.Appearance.Options.UseFont = True
        Me.txtCCCartao.Properties.Caption = "C.C."
        Me.txtCCCartao.Size = New System.Drawing.Size(46, 20)
        Me.txtCCCartao.TabIndex = 31
        Me.txtCCCartao.TabStop = False
        '
        'txtFormaCartao
        '
        Me.txtFormaCartao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "FormaCartão", True))
        Me.txtFormaCartao.Location = New System.Drawing.Point(309, 36)
        Me.txtFormaCartao.MenuManager = Me.ribbonControl1
        Me.txtFormaCartao.Name = "txtFormaCartao"
        Me.txtFormaCartao.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormaCartao.Properties.Appearance.Options.UseFont = True
        Me.txtFormaCartao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtFormaCartao.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFormaCartao.Properties.DropDownRows = 12
        Me.txtFormaCartao.Properties.Items.AddRange(New Object() {"À vista", "2x", "3x", "4x", "5x", "6x", "7x", "8x", "9x", "10x"})
        Me.txtFormaCartao.Size = New System.Drawing.Size(79, 22)
        Me.txtFormaCartao.TabIndex = 28
        '
        'txtValorCartao
        '
        Me.txtValorCartao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "Cartão", True))
        Me.txtValorCartao.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorCartao.Location = New System.Drawing.Point(80, 35)
        Me.txtValorCartao.MenuManager = Me.ribbonControl1
        Me.txtValorCartao.Name = "txtValorCartao"
        Me.txtValorCartao.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorCartao.Properties.Appearance.Options.UseFont = True
        Me.txtValorCartao.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorCartao.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorCartao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtValorCartao.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtValorCartao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorCartao.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtValorCartao.Properties.Mask.EditMask = "n"
        Me.txtValorCartao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorCartao.Size = New System.Drawing.Size(68, 22)
        Me.txtValorCartao.TabIndex = 27
        '
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "ID", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(682, 148)
        Me.IDTextEdit.MenuManager = Me.ribbonControl1
        Me.IDTextEdit.Name = "IDTextEdit"
        Me.IDTextEdit.Size = New System.Drawing.Size(53, 20)
        Me.IDTextEdit.TabIndex = 27
        Me.IDTextEdit.TabStop = False
        '
        'CartõesTableAdapter
        '
        Me.CartõesTableAdapter.ClearBeforeFill = True
        '
        'lblCliente
        '
        Me.lblCliente.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblCliente.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblCliente.Appearance.Options.UseBackColor = True
        Me.lblCliente.Appearance.Options.UseFont = True
        Me.lblCliente.Appearance.Options.UseForeColor = True
        Me.lblCliente.Appearance.Options.UseTextOptions = True
        Me.lblCliente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCliente.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCliente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCliente.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCliente.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.lblCliente.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.lblCliente.Location = New System.Drawing.Point(353, 148)
        Me.lblCliente.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.lblCliente.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(633, 22)
        Me.lblCliente.TabIndex = 29
        Me.lblCliente.Text = "Conta Corrente"
        '
        'txtDolar
        '
        Me.txtDolar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "Dolar", True))
        Me.txtDolar.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDolar.Location = New System.Drawing.Point(500, 597)
        Me.txtDolar.MenuManager = Me.ribbonControl1
        Me.txtDolar.Name = "txtDolar"
        Me.txtDolar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDolar.Properties.Appearance.Options.UseFont = True
        Me.txtDolar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDolar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDolar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDolar.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtDolar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDolar.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtDolar.Properties.Mask.EditMask = "n"
        Me.txtDolar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDolar.Size = New System.Drawing.Size(68, 22)
        Me.txtDolar.TabIndex = 31
        '
        'txtCash
        '
        Me.txtCash.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "Real", True))
        Me.txtCash.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCash.Location = New System.Drawing.Point(500, 625)
        Me.txtCash.MenuManager = Me.ribbonControl1
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Properties.Appearance.Options.UseFont = True
        Me.txtCash.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCash.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCash.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCash.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtCash.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCash.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtCash.Properties.Mask.EditMask = "n"
        Me.txtCash.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCash.Size = New System.Drawing.Size(68, 22)
        Me.txtCash.TabIndex = 33
        '
        'txtOuro
        '
        Me.txtOuro.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "Ouro", True))
        Me.txtOuro.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOuro.Location = New System.Drawing.Point(500, 653)
        Me.txtOuro.MenuManager = Me.ribbonControl1
        Me.txtOuro.Name = "txtOuro"
        Me.txtOuro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOuro.Properties.Appearance.Options.UseFont = True
        Me.txtOuro.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOuro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOuro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtOuro.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtOuro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOuro.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtOuro.Properties.Mask.EditMask = "n"
        Me.txtOuro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOuro.Size = New System.Drawing.Size(68, 22)
        Me.txtOuro.TabIndex = 35
        '
        'txtDolarCC
        '
        Me.txtDolarCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "DolarCC", True))
        Me.txtDolarCC.EditValue = True
        Me.txtDolarCC.Location = New System.Drawing.Point(579, 599)
        Me.txtDolarCC.MenuManager = Me.ribbonControl1
        Me.txtDolarCC.Name = "txtDolarCC"
        Me.txtDolarCC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDolarCC.Properties.Appearance.Options.UseFont = True
        Me.txtDolarCC.Properties.Caption = "C.C."
        Me.txtDolarCC.Size = New System.Drawing.Size(46, 20)
        Me.txtDolarCC.TabIndex = 34
        Me.txtDolarCC.TabStop = False
        '
        'txtCashCC
        '
        Me.txtCashCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "CashCC", True))
        Me.txtCashCC.EditValue = True
        Me.txtCashCC.Location = New System.Drawing.Point(579, 627)
        Me.txtCashCC.MenuManager = Me.ribbonControl1
        Me.txtCashCC.Name = "txtCashCC"
        Me.txtCashCC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashCC.Properties.Appearance.Options.UseFont = True
        Me.txtCashCC.Properties.Caption = "C.C."
        Me.txtCashCC.Size = New System.Drawing.Size(46, 20)
        Me.txtCashCC.TabIndex = 37
        Me.txtCashCC.TabStop = False
        '
        'txtOuroCC
        '
        Me.txtOuroCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "OuroCC", True))
        Me.txtOuroCC.EditValue = True
        Me.txtOuroCC.Location = New System.Drawing.Point(579, 654)
        Me.txtOuroCC.MenuManager = Me.ribbonControl1
        Me.txtOuroCC.Name = "txtOuroCC"
        Me.txtOuroCC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOuroCC.Properties.Appearance.Options.UseFont = True
        Me.txtOuroCC.Properties.Caption = "C.C."
        Me.txtOuroCC.Size = New System.Drawing.Size(46, 20)
        Me.txtOuroCC.TabIndex = 38
        Me.txtOuroCC.TabStop = False
        '
        'txtDebCC
        '
        Me.txtDebCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "CCDeb", True))
        Me.txtDebCC.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDebCC.Location = New System.Drawing.Point(850, 599)
        Me.txtDebCC.MenuManager = Me.ribbonControl1
        Me.txtDebCC.Name = "txtDebCC"
        Me.txtDebCC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebCC.Properties.Appearance.Options.UseFont = True
        Me.txtDebCC.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDebCC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDebCC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDebCC.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtDebCC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebCC.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtDebCC.Properties.Mask.EditMask = "n"
        Me.txtDebCC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebCC.Size = New System.Drawing.Size(68, 22)
        Me.txtDebCC.TabIndex = 39
        '
        'txtBancoTransf
        '
        Me.txtBancoTransf.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "BancoTransf", True))
        Me.txtBancoTransf.Location = New System.Drawing.Point(849, 654)
        Me.txtBancoTransf.MenuManager = Me.ribbonControl1
        Me.txtBancoTransf.Name = "txtBancoTransf"
        Me.txtBancoTransf.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBancoTransf.Properties.Appearance.Options.UseFont = True
        Me.txtBancoTransf.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBancoTransf.Size = New System.Drawing.Size(211, 22)
        Me.txtBancoTransf.TabIndex = 43
        '
        'txtTransf
        '
        Me.txtTransf.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "ValorTransf", True))
        Me.txtTransf.EditValue = "0,00"
        Me.txtTransf.Location = New System.Drawing.Point(849, 626)
        Me.txtTransf.MenuManager = Me.ribbonControl1
        Me.txtTransf.Name = "txtTransf"
        Me.txtTransf.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransf.Properties.Appearance.Options.UseFont = True
        Me.txtTransf.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTransf.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTransf.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtTransf.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtTransf.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTransf.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtTransf.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTransf.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtTransf.Properties.Mask.EditMask = "n2"
        Me.txtTransf.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTransf.Size = New System.Drawing.Size(69, 22)
        Me.txtTransf.TabIndex = 42
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "Obs", True))
        Me.TextEdit1.Location = New System.Drawing.Point(55, 614)
        Me.TextEdit1.MenuManager = Me.ribbonControl1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TextEdit1.Size = New System.Drawing.Size(350, 96)
        Me.TextEdit1.TabIndex = 47
        '
        'txtAUT
        '
        Me.txtAUT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Conta_CorrenteBindingSource, "Aut", True))
        Me.txtAUT.Location = New System.Drawing.Point(1195, 228)
        Me.txtAUT.MenuManager = Me.ribbonControl1
        Me.txtAUT.Name = "txtAUT"
        Me.txtAUT.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAUT.Properties.Appearance.Options.UseFont = True
        Me.txtAUT.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAUT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtAUT.Properties.BeepOnError = True
        Me.txtAUT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtAUT.Properties.UseMaskAsDisplayFormat = True
        Me.txtAUT.Size = New System.Drawing.Size(85, 24)
        Me.txtAUT.TabIndex = 52
        '
        'txtCliente
        '
        Me.txtCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Conta_CorrenteBindingSource, "Cliente", True))
        Me.txtCliente.Location = New System.Drawing.Point(620, -31)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(19, 21)
        Me.txtCliente.TabIndex = 55
        Me.txtCliente.TabStop = False
        '
        'frmCC
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1338, 722)
        Me.Controls.Add(Label22)
        Me.Controls.Add(Me.txtAUT)
        Me.Controls.Add(Label8)
        Me.Controls.Add(BancoTransfLabel)
        Me.Controls.Add(Me.txtBancoTransf)
        Me.Controls.Add(Label17)
        Me.Controls.Add(Me.txtTransf)
        Me.Controls.Add(Me.txtDebCC)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.txtOuroCC)
        Me.Controls.Add(Me.txtCashCC)
        Me.Controls.Add(Me.txtDolarCC)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.txtOuro)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.txtDolar)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.GroupControlCARTAO)
        Me.Controls.Add(Me.GroupControlCHEQUES)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataDateEdit)
        Me.Controls.Add(Me.ClienteTextEdit)
        Me.Controls.Add(Me.IDTextEdit)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IconOptions.Icon = CType(resources.GetObject("frmCC.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmCC"
        Me.Ribbon = Me.ribbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartõesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Conta_CorrenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaChequeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControlCHEQUES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControlCHEQUES.ResumeLayout(False)
        Me.GroupControlCHEQUES.PerformLayout()
        CType(Me.Vencto_ChequesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vencto_ChequesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeCCCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControlCARTAO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControlCARTAO.ResumeLayout(False)
        CType(Me.Vencto_CartãoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vencto_CartãoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomeCartao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCCCartao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormaCartao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorCartao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDolar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCash.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOuro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDolarCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOuroCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBancoTransf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAUT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DsPrincipal As Pepe.DataSet1
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnLancaCC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCompras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPeçasCompradas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsCC As dsCC
    Friend WithEvents Conta_CorrenteBindingSource As BindingSource
    Friend WithEvents Conta_CorrenteTableAdapter As dsCCTableAdapters.Conta_CorrenteTableAdapter
    Friend WithEvents TableAdapterManager As dsCCTableAdapters.TableAdapterManager
    Friend WithEvents DataDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ClienteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChequeSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FormaChequeComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BancoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControlCHEQUES As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControlCARTAO As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ChequeCCCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Vencto_ChequesBindingSource As BindingSource
    Friend WithEvents Vencto_ChequesTableAdapter As dsCCTableAdapters.Vencto_ChequesTableAdapter
    Friend WithEvents Vencto_ChequesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomeCartao As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCCCartao As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFormaCartao As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtValorCartao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CartõesBindingSource As BindingSource
    Friend WithEvents CartõesTableAdapter As dsCCTableAdapters.CartõesTableAdapter
    Friend WithEvents Vencto_CartãoBindingSource As BindingSource
    Friend WithEvents Vencto_CartãoTableAdapter As dsCCTableAdapters.Vencto_CartãoTableAdapter
    Friend WithEvents Vencto_CartãoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcela1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVValor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCC1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDolar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCash As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOuro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDolarCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCashCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtOuroCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtDebCC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnDel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ribDel As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colNomeCartão As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtBancoTransf As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTransf As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtAUT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtCliente As TextBox
End Class
