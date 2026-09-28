<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequeAvulso
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDClienteLabel As System.Windows.Forms.Label
        Dim SEMCADASTROLabel As System.Windows.Forms.Label
        Dim DataVendaLabel As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim ChequeLabel As System.Windows.Forms.Label
        Dim FormaChequeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequeAvulso))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
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
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DsPrincipal = New Pepe.DataSet1()
        Me.VENDASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENDASTableAdapter = New Pepe.DataSet1TableAdapters.VENDASTableAdapter()
        Me.TableAdapterManager = New Pepe.DataSet1TableAdapters.TableAdapterManager()
        Me.IdTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VENDAS1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCheques = New Pepe.dsCheques()
        Me.VENDASBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDClienteTextEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.CboClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsGeral = New Pepe.dsGeral()
        Me.SEMCADASTROTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DataVendaDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.BancoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ChequeSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.FormaChequeComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.CboClientesTableAdapter = New Pepe.dsGeralTableAdapters.cboClientesTableAdapter()
        Me.Vencto_ChequesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vencto_ChequesTableAdapter = New Pepe.DataSet1TableAdapters.Vencto_ChequesTableAdapter()
        Me.Vencto_ChequesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Vencto_Cheques1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParcela = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colPagto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdConserto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Vencto_ChequesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENDASTableAdapter1 = New Pepe.dsChequesTableAdapters.VENDASTableAdapter()
        Me.TableAdapterManager1 = New Pepe.dsChequesTableAdapters.TableAdapterManager()
        Me.Vencto_Cheques1TableAdapter = New Pepe.dsChequesTableAdapters.Vencto_Cheques1TableAdapter()
        Me.VENDAS1TableAdapter = New Pepe.dsChequesTableAdapters.VENDAS1TableAdapter()
        Me.Vencto_ChequesTableAdapter1 = New Pepe.dsChequesTableAdapters.Vencto_ChequesTableAdapter()
        IDClienteLabel = New System.Windows.Forms.Label()
        SEMCADASTROLabel = New System.Windows.Forms.Label()
        DataVendaLabel = New System.Windows.Forms.Label()
        BancoLabel = New System.Windows.Forms.Label()
        ChequeLabel = New System.Windows.Forms.Label()
        FormaChequeLabel = New System.Windows.Forms.Label()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDAS1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEMCADASTROTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataVendaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataVendaDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaChequeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl.SuspendLayout()
        CType(Me.Vencto_ChequesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vencto_ChequesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vencto_Cheques1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vencto_ChequesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDClienteLabel
        '
        IDClienteLabel.AutoSize = True
        IDClienteLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDClienteLabel.Location = New System.Drawing.Point(62, 18)
        IDClienteLabel.Name = "IDClienteLabel"
        IDClienteLabel.Size = New System.Drawing.Size(47, 17)
        IDClienteLabel.TabIndex = 9
        IDClienteLabel.Text = "Cliente"
        '
        'SEMCADASTROLabel
        '
        SEMCADASTROLabel.AutoSize = True
        SEMCADASTROLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SEMCADASTROLabel.Location = New System.Drawing.Point(18, 45)
        SEMCADASTROLabel.Name = "SEMCADASTROLabel"
        SEMCADASTROLabel.Size = New System.Drawing.Size(88, 17)
        SEMCADASTROLabel.TabIndex = 11
        SEMCADASTROLabel.Text = "Ñ cadastrado"
        '
        'DataVendaLabel
        '
        DataVendaLabel.AutoSize = True
        DataVendaLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataVendaLabel.Location = New System.Drawing.Point(74, 73)
        DataVendaLabel.Name = "DataVendaLabel"
        DataVendaLabel.Size = New System.Drawing.Size(35, 17)
        DataVendaLabel.TabIndex = 12
        DataVendaLabel.Text = "Data"
        '
        'BancoLabel
        '
        BancoLabel.AutoSize = True
        BancoLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BancoLabel.Location = New System.Drawing.Point(221, 73)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(43, 17)
        BancoLabel.TabIndex = 13
        BancoLabel.Text = "Banco"
        BancoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChequeLabel
        '
        ChequeLabel.AutoSize = True
        ChequeLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChequeLabel.Location = New System.Drawing.Point(43, 101)
        ChequeLabel.Name = "ChequeLabel"
        ChequeLabel.Size = New System.Drawing.Size(68, 17)
        ChequeLabel.TabIndex = 14
        ChequeLabel.Text = "Valor total"
        ChequeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormaChequeLabel
        '
        FormaChequeLabel.AutoSize = True
        FormaChequeLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormaChequeLabel.Location = New System.Drawing.Point(240, 102)
        FormaChequeLabel.Name = "FormaChequeLabel"
        FormaChequeLabel.Size = New System.Drawing.Size(87, 17)
        FormaChequeLabel.TabIndex = 15
        FormaChequeLabel.Text = "Parcelamento"
        FormaChequeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.RibbonControl.SearchEditItem, Me.btnFechar, Me.btnSalvar, Me.btnUndo, Me.btnDel})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 5
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(1338, 147)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'btnFechar
        '
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Id = 1
        Me.btnFechar.ImageOptions.Image = CType(resources.GetObject("btnFechar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFechar.ImageOptions.LargeImage = CType(resources.GetObject("btnFechar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnFechar.Name = "btnFechar"
        ToolTipItem1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem1.ImageOptions.ImageUri.Uri = "richedit/clearheaderandfooter;Size16x16"
        ToolTipItem1.Text = "<b>RETORNA PARA A LISTAGEM DE CHEQUES</b>"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnFechar.SuperTip = SuperToolTip1
        '
        'btnSalvar
        '
        Me.btnSalvar.Caption = "Salvar"
        Me.btnSalvar.Id = 2
        Me.btnSalvar.ImageOptions.Image = CType(resources.GetObject("btnSalvar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageOptions.LargeImage = CType(resources.GetObject("btnSalvar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSalvar.Name = "btnSalvar"
        ToolTipItem2.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem2.ImageOptions.ImageUri.Uri = "diagramicons/save%20as;Size16x16"
        ToolTipItem2.Text = "<b>SALVA O REGISTRO</b>"
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btnSalvar.SuperTip = SuperToolTip2
        '
        'btnUndo
        '
        Me.btnUndo.Caption = "Desfazer"
        Me.btnUndo.Id = 3
        Me.btnUndo.ImageOptions.Image = CType(resources.GetObject("btnUndo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUndo.ImageOptions.LargeImage = CType(resources.GetObject("btnUndo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnUndo.Name = "btnUndo"
        ToolTipItem3.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem3.ImageOptions.ImageUri.Uri = "Undo;Size16x16"
        ToolTipItem3.Text = "<b>DESFAZ A ÚLTIMA DIGITAÇÃO</b>"
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.btnUndo.SuperTip = SuperToolTip3
        '
        'btnDel
        '
        Me.btnDel.Caption = "Excluir"
        Me.btnDel.Id = 4
        Me.btnDel.ImageOptions.Image = CType(resources.GetObject("btnDel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDel.ImageOptions.LargeImage = CType(resources.GetObject("btnDel.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDel.Name = "btnDel"
        ToolTipItem4.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem4.ImageOptions.ImageUri.Uri = "snap/snapdeletelist;Size16x16"
        ToolTipItem4.Text = "<b>EXCLUSÃO DO LANÇAMENTO</b>"
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.btnDel.SuperTip = SuperToolTip4
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "FINANCEIRO"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDel)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnFechar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSalvar)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnUndo)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Visible = False
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 702)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1338, 23)
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
        Me.LabelControl1.Location = New System.Drawing.Point(528, 148)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(282, 39)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Cheque Avulso"
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
        Me.TableAdapterManager.UpdateOrder = Pepe.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager.Vencto_ChequesTableAdapter = Nothing
        Me.TableAdapterManager.VENDAS_DETTableAdapter = Nothing
        Me.TableAdapterManager.VendasDetTableAdapter = Nothing
        Me.TableAdapterManager.VENDASTableAdapter = Me.VENDASTableAdapter
        '
        'IdTextEdit
        '
        Me.IdTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDAS1BindingSource, "Id", True))
        Me.IdTextEdit.Location = New System.Drawing.Point(599, 467)
        Me.IdTextEdit.MenuManager = Me.RibbonControl
        Me.IdTextEdit.Name = "IdTextEdit"
        Me.IdTextEdit.Size = New System.Drawing.Size(30, 20)
        Me.IdTextEdit.TabIndex = 9
        Me.IdTextEdit.TabStop = False
        '
        'VENDAS1BindingSource
        '
        Me.VENDAS1BindingSource.DataMember = "VENDAS1"
        Me.VENDAS1BindingSource.DataSource = Me.DsCheques
        '
        'DsCheques
        '
        Me.DsCheques.DataSetName = "dsCheques"
        Me.DsCheques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VENDASBindingSource1
        '
        Me.VENDASBindingSource1.DataMember = "VENDAS"
        Me.VENDASBindingSource1.DataSource = Me.DsCheques
        '
        'IDClienteTextEdit
        '
        Me.IDClienteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDAS1BindingSource, "IDCliente", True))
        Me.IDClienteTextEdit.Location = New System.Drawing.Point(110, 15)
        Me.IDClienteTextEdit.MenuManager = Me.RibbonControl
        Me.IDClienteTextEdit.Name = "IDClienteTextEdit"
        Me.IDClienteTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDClienteTextEdit.Properties.Appearance.Options.UseFont = True
        Me.IDClienteTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.IDClienteTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IDClienteTextEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cli", "Clientes", 34, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCliente", "ID Cliente", 63, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.IDClienteTextEdit.Properties.DataSource = Me.CboClientesBindingSource
        Me.IDClienteTextEdit.Properties.DisplayMember = "Cli"
        Me.IDClienteTextEdit.Properties.DropDownRows = 16
        Me.IDClienteTextEdit.Properties.NullText = ""
        Me.IDClienteTextEdit.Properties.ValueMember = "IDCliente"
        Me.IDClienteTextEdit.Size = New System.Drawing.Size(306, 26)
        Me.IDClienteTextEdit.TabIndex = 10
        '
        'CboClientesBindingSource
        '
        Me.CboClientesBindingSource.DataMember = "cboClientes"
        Me.CboClientesBindingSource.DataSource = Me.DsGeral
        '
        'DsGeral
        '
        Me.DsGeral.DataSetName = "dsGeral"
        Me.DsGeral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SEMCADASTROTextEdit
        '
        Me.SEMCADASTROTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDAS1BindingSource, "SEMCADASTRO", True))
        Me.SEMCADASTROTextEdit.Location = New System.Drawing.Point(110, 42)
        Me.SEMCADASTROTextEdit.MenuManager = Me.RibbonControl
        Me.SEMCADASTROTextEdit.Name = "SEMCADASTROTextEdit"
        Me.SEMCADASTROTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEMCADASTROTextEdit.Properties.Appearance.Options.UseFont = True
        Me.SEMCADASTROTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SEMCADASTROTextEdit.Size = New System.Drawing.Size(306, 26)
        Me.SEMCADASTROTextEdit.TabIndex = 12
        '
        'DataVendaDateEdit
        '
        Me.DataVendaDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDAS1BindingSource, "DataVenda", True))
        Me.DataVendaDateEdit.EditValue = Nothing
        Me.DataVendaDateEdit.Location = New System.Drawing.Point(110, 70)
        Me.DataVendaDateEdit.MenuManager = Me.RibbonControl
        Me.DataVendaDateEdit.Name = "DataVendaDateEdit"
        Me.DataVendaDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataVendaDateEdit.Properties.Appearance.Options.UseFont = True
        Me.DataVendaDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DataVendaDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataVendaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataVendaDateEdit.Size = New System.Drawing.Size(94, 26)
        Me.DataVendaDateEdit.TabIndex = 13
        '
        'BancoTextEdit
        '
        Me.BancoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDAS1BindingSource, "Banco", True))
        Me.BancoTextEdit.Location = New System.Drawing.Point(265, 70)
        Me.BancoTextEdit.MenuManager = Me.RibbonControl
        Me.BancoTextEdit.Name = "BancoTextEdit"
        Me.BancoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BancoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.BancoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BancoTextEdit.Size = New System.Drawing.Size(151, 26)
        Me.BancoTextEdit.TabIndex = 14
        '
        'ChequeSpinEdit
        '
        Me.ChequeSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDAS1BindingSource, "Cheque", True))
        Me.ChequeSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ChequeSpinEdit.Location = New System.Drawing.Point(110, 98)
        Me.ChequeSpinEdit.MenuManager = Me.RibbonControl
        Me.ChequeSpinEdit.Name = "ChequeSpinEdit"
        Me.ChequeSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChequeSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.ChequeSpinEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ChequeSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.ChequeSpinEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.ChequeSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ChequeSpinEdit.Properties.Mask.EditMask = "n2"
        Me.ChequeSpinEdit.Size = New System.Drawing.Size(94, 26)
        Me.ChequeSpinEdit.TabIndex = 15
        '
        'FormaChequeComboBoxEdit
        '
        Me.FormaChequeComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDAS1BindingSource, "FormaCheque", True))
        Me.FormaChequeComboBoxEdit.Location = New System.Drawing.Point(331, 98)
        Me.FormaChequeComboBoxEdit.MenuManager = Me.RibbonControl
        Me.FormaChequeComboBoxEdit.Name = "FormaChequeComboBoxEdit"
        Me.FormaChequeComboBoxEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormaChequeComboBoxEdit.Properties.Appearance.Options.UseFont = True
        Me.FormaChequeComboBoxEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.FormaChequeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FormaChequeComboBoxEdit.Properties.Items.AddRange(New Object() {"A vista", "2x", "3x", "4x", "5x", "6x"})
        Me.FormaChequeComboBoxEdit.Size = New System.Drawing.Size(85, 26)
        Me.FormaChequeComboBoxEdit.TabIndex = 16
        '
        'GroupControl
        '
        Me.GroupControl.Controls.Add(Me.IDClienteTextEdit)
        Me.GroupControl.Controls.Add(FormaChequeLabel)
        Me.GroupControl.Controls.Add(BancoLabel)
        Me.GroupControl.Controls.Add(Me.DataVendaDateEdit)
        Me.GroupControl.Controls.Add(IDClienteLabel)
        Me.GroupControl.Controls.Add(DataVendaLabel)
        Me.GroupControl.Controls.Add(Me.ChequeSpinEdit)
        Me.GroupControl.Controls.Add(Me.FormaChequeComboBoxEdit)
        Me.GroupControl.Controls.Add(Me.BancoTextEdit)
        Me.GroupControl.Controls.Add(SEMCADASTROLabel)
        Me.GroupControl.Controls.Add(Me.SEMCADASTROTextEdit)
        Me.GroupControl.Controls.Add(ChequeLabel)
        Me.GroupControl.Location = New System.Drawing.Point(451, 210)
        Me.GroupControl.Name = "GroupControl"
        Me.GroupControl.ShowCaption = False
        Me.GroupControl.Size = New System.Drawing.Size(437, 140)
        Me.GroupControl.TabIndex = 19
        '
        'CboClientesTableAdapter
        '
        Me.CboClientesTableAdapter.ClearBeforeFill = True
        '
        'Vencto_ChequesBindingSource
        '
        Me.Vencto_ChequesBindingSource.DataMember = "FK_VENDAS_Vencto Cheques"
        Me.Vencto_ChequesBindingSource.DataSource = Me.VENDASBindingSource
        '
        'Vencto_ChequesTableAdapter
        '
        Me.Vencto_ChequesTableAdapter.ClearBeforeFill = True
        '
        'Vencto_ChequesGridControl
        '
        Me.Vencto_ChequesGridControl.DataSource = Me.Vencto_Cheques1BindingSource
        Me.Vencto_ChequesGridControl.Location = New System.Drawing.Point(308, 378)
        Me.Vencto_ChequesGridControl.MainView = Me.GridView1
        Me.Vencto_ChequesGridControl.MenuManager = Me.RibbonControl
        Me.Vencto_ChequesGridControl.Name = "Vencto_ChequesGridControl"
        Me.Vencto_ChequesGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1})
        Me.Vencto_ChequesGridControl.Size = New System.Drawing.Size(723, 148)
        Me.Vencto_ChequesGridControl.TabIndex = 21
        Me.Vencto_ChequesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'Vencto_Cheques1BindingSource
        '
        Me.Vencto_Cheques1BindingSource.DataMember = "Vencto Cheques1"
        Me.Vencto_Cheques1BindingSource.DataSource = Me.DsCheques
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colVenda, Me.colParcela, Me.colVencto, Me.colVValor, Me.colPagto, Me.colCheque, Me.colUso, Me.colDestino, Me.colObs, Me.colIdConserto, Me.colIdCC, Me.colBanco})
        Me.GridView1.GridControl = Me.Vencto_ChequesGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
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
        'colParcela
        '
        Me.colParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcela.AppearanceHeader.Options.UseTextOptions = True
        Me.colParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcela.FieldName = "Parcela"
        Me.colParcela.Name = "colParcela"
        Me.colParcela.OptionsColumn.AllowEdit = False
        Me.colParcela.OptionsColumn.ReadOnly = True
        Me.colParcela.Visible = True
        Me.colParcela.VisibleIndex = 0
        Me.colParcela.Width = 79
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
        Me.colVencto.Width = 102
        '
        'colVValor
        '
        Me.colVValor.AppearanceHeader.Options.UseTextOptions = True
        Me.colVValor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVValor.Caption = "Valor"
        Me.colVValor.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colVValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colVValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVValor.FieldName = "VValor"
        Me.colVValor.Name = "colVValor"
        Me.colVValor.Visible = True
        Me.colVValor.VisibleIndex = 2
        Me.colVValor.Width = 102
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "n2"
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'colPagto
        '
        Me.colPagto.AppearanceCell.Options.UseTextOptions = True
        Me.colPagto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPagto.AppearanceHeader.Options.UseTextOptions = True
        Me.colPagto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPagto.Caption = "Data Pagto."
        Me.colPagto.FieldName = "Pagto"
        Me.colPagto.Name = "colPagto"
        Me.colPagto.Visible = True
        Me.colPagto.VisibleIndex = 3
        Me.colPagto.Width = 103
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
        Me.colCheque.VisibleIndex = 4
        Me.colCheque.Width = 141
        '
        'colUso
        '
        Me.colUso.FieldName = "Uso"
        Me.colUso.Name = "colUso"
        '
        'colDestino
        '
        Me.colDestino.FieldName = "Destino"
        Me.colDestino.Name = "colDestino"
        '
        'colObs
        '
        Me.colObs.FieldName = "Obs"
        Me.colObs.Name = "colObs"
        '
        'colIdConserto
        '
        Me.colIdConserto.FieldName = "IdConserto"
        Me.colIdConserto.Name = "colIdConserto"
        '
        'colIdCC
        '
        Me.colIdCC.FieldName = "IdCC"
        Me.colIdCC.Name = "colIdCC"
        '
        'colBanco
        '
        Me.colBanco.AppearanceHeader.Options.UseTextOptions = True
        Me.colBanco.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBanco.FieldName = "Banco"
        Me.colBanco.Name = "colBanco"
        Me.colBanco.Visible = True
        Me.colBanco.VisibleIndex = 5
        Me.colBanco.Width = 175
        '
        'Vencto_ChequesBindingSource1
        '
        Me.Vencto_ChequesBindingSource1.DataMember = "VENDAS_Vencto Cheques"
        Me.Vencto_ChequesBindingSource1.DataSource = Me.VENDASBindingSource1
        '
        'VENDASTableAdapter1
        '
        Me.VENDASTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CartõesAbertoTableAdapter = Nothing
        Me.TableAdapterManager1.CartõesRecTableAdapter = Nothing
        Me.TableAdapterManager1.CartõesTodosTableAdapter = Nothing
        Me.TableAdapterManager1.cboPeçasTableAdapter = Nothing
        Me.TableAdapterManager1.ChequesAbertoTableAdapter = Nothing
        Me.TableAdapterManager1.ChequesRecTableAdapter = Nothing
        Me.TableAdapterManager1.ChequesTodosTableAdapter = Nothing
        Me.TableAdapterManager1.tabCartõesRptTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Pepe.dsChequesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.Vencto_Cheques1TableAdapter = Me.Vencto_Cheques1TableAdapter
        Me.TableAdapterManager1.Vencto_ChequesTableAdapter = Nothing
        Me.TableAdapterManager1.VENDAS_DETTableAdapter = Nothing
        Me.TableAdapterManager1.VENDAS1TableAdapter = Me.VENDAS1TableAdapter
        Me.TableAdapterManager1.VENDASTableAdapter = Nothing
        '
        'Vencto_Cheques1TableAdapter
        '
        Me.Vencto_Cheques1TableAdapter.ClearBeforeFill = True
        '
        'VENDAS1TableAdapter
        '
        Me.VENDAS1TableAdapter.ClearBeforeFill = True
        '
        'Vencto_ChequesTableAdapter1
        '
        Me.Vencto_ChequesTableAdapter1.ClearBeforeFill = True
        '
        'frmChequeAvulso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1338, 725)
        Me.Controls.Add(Me.Vencto_ChequesGridControl)
        Me.Controls.Add(Me.GroupControl)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.IdTextEdit)
        Me.Controls.Add(Me.RibbonControl)
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmChequeAvulso"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDAS1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDASBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEMCADASTROTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataVendaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataVendaDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaChequeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl.ResumeLayout(False)
        Me.GroupControl.PerformLayout()
        CType(Me.Vencto_ChequesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vencto_ChequesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vencto_Cheques1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vencto_ChequesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsPrincipal As DataSet1
    Friend WithEvents VENDASBindingSource As BindingSource
    Friend WithEvents VENDASTableAdapter As DataSet1TableAdapters.VENDASTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents IdTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDClienteTextEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SEMCADASTROTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataVendaDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BancoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChequeSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FormaChequeComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DsGeral As dsGeral
    Friend WithEvents CboClientesBindingSource As BindingSource
    Friend WithEvents CboClientesTableAdapter As dsGeralTableAdapters.cboClientesTableAdapter
    Friend WithEvents Vencto_ChequesBindingSource As BindingSource
    Friend WithEvents Vencto_ChequesTableAdapter As DataSet1TableAdapters.Vencto_ChequesTableAdapter
    Friend WithEvents Vencto_ChequesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdConserto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnDel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsCheques As dsCheques
    Friend WithEvents VENDASBindingSource1 As BindingSource
    Friend WithEvents VENDASTableAdapter1 As dsChequesTableAdapters.VENDASTableAdapter
    Friend WithEvents TableAdapterManager1 As dsChequesTableAdapters.TableAdapterManager
    Friend WithEvents Vencto_ChequesTableAdapter1 As dsChequesTableAdapters.Vencto_ChequesTableAdapter
    Friend WithEvents Vencto_ChequesBindingSource1 As BindingSource
    Friend WithEvents VENDAS1BindingSource As BindingSource
    Friend WithEvents VENDAS1TableAdapter As dsChequesTableAdapters.VENDAS1TableAdapter
    Friend WithEvents Vencto_Cheques1BindingSource As BindingSource
    Friend WithEvents Vencto_Cheques1TableAdapter As dsChequesTableAdapters.Vencto_Cheques1TableAdapter
End Class
