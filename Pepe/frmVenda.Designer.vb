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
        Me.components = New System.ComponentModel.Container()
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
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim ChequeLabel As System.Windows.Forms.Label
        Dim FormaChequeLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim BancoTransfLabel As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenda))
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
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
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
        Me.btnNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEtiqMalaDireta = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelarVenda = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCartões = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAtual2 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribAtual = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DsPrincipal = New Pepe.DataSet1()
        Me.VENDASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENDASTableAdapter = New Pepe.DataSet1TableAdapters.VENDASTableAdapter()
        Me.TableAdapterManager = New Pepe.DataSet1TableAdapters.TableAdapterManager()
        Me.Vencto_ChequesTableAdapter = New Pepe.DataSet1TableAdapters.Vencto_ChequesTableAdapter()
        Me.VendasDetTableAdapter = New Pepe.DataSet1TableAdapters.VendasDetTableAdapter()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtValorFinal = New DevExpress.XtraEditors.TextEdit()
        Me.txtDesconto = New DevExpress.XtraEditors.TextEdit()
        Me.txtTroca = New DevExpress.XtraEditors.TextEdit()
        Me.VendasDetGridControl = New DevExpress.XtraGrid.GridControl()
        Me.FKVENDASVendasDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAbrirItem = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboRef = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TabPeçasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colValorVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtValorVenda = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colComissão = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboId = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpEdit3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.CboVendedorasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDataVenda = New DevExpress.XtraEditors.DateEdit()
        Me.txtVenda = New DevExpress.XtraEditors.TextEdit()
        Me.IdTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DestinoTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtCliente = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtBancoTransf = New DevExpress.XtraEditors.TextEdit()
        Me.txtCCDeb = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControlCARTAO = New DevExpress.XtraEditors.GroupControl()
        Me.txtNomeCDeb = New DevExpress.XtraEditors.LookUpEdit()
        Me.CartõesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCliente = New Pepe.dsCliente()
        Me.txtDeb = New DevExpress.XtraEditors.TextEdit()
        Me.Vencto_CartãoGridControl = New DevExpress.XtraGrid.GridControl()
        Me.VenctoCartãoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParcela1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencto1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVValor1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomeCartão = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colIdCC1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNomeCartao = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCCCartao = New DevExpress.XtraEditors.CheckEdit()
        Me.txtFormaCartao = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtValorCartao = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControlCHEQUES = New DevExpress.XtraEditors.GroupControl()
        Me.Vencto_ChequesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Vencto_ChequesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParcela = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVenda1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ckChequeCC = New DevExpress.XtraEditors.CheckEdit()
        Me.FormaChequeComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ChequeSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BancoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.btnAtual = New DevExpress.XtraEditors.SimpleButton()
        Me.ckOuroCC = New DevExpress.XtraEditors.CheckEdit()
        Me.txtOuro = New DevExpress.XtraEditors.TextEdit()
        Me.ckCashCC = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCash = New DevExpress.XtraEditors.TextEdit()
        Me.ckDolarCC = New DevExpress.XtraEditors.CheckEdit()
        Me.txtDolar = New DevExpress.XtraEditors.TextEdit()
        Me.txtTransf = New DevExpress.XtraEditors.TextEdit()
        Me.MDCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.ClientesTableAdapter = New Pepe.DataSet1TableAdapters.ClientesTableAdapter()
        Me.CboVendedorasTableAdapter = New Pepe.DataSet1TableAdapters.cboVendedorasTableAdapter()
        Me._1TabPeçasTableAdapter = New Pepe.DataSet1TableAdapters._1TabPeçasTableAdapter()
        Me.TableAdapterManager1 = New Pepe.DataSet1TableAdapters.TableAdapterManager()
        Me.VendasDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vencto_CartãoTableAdapter = New Pepe.dsClienteTableAdapters.Vencto_CartãoTableAdapter()
        Me.CartõesTableAdapter = New Pepe.dsClienteTableAdapters.CartõesTableAdapter()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ckNavegar = New DevExpress.XtraEditors.CheckEdit()
        Me.dnConsertos = New DevExpress.XtraEditors.DataNavigator()
        Me.btnEsq = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCC = New System.Windows.Forms.Button()
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
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        BancoLabel = New System.Windows.Forms.Label()
        ChequeLabel = New System.Windows.Forms.Label()
        FormaChequeLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        BancoTransfLabel = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtValorFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTroca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDetGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKVENDASVendasDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrirItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPeçasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboVendedorasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataVenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataVenda.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBancoTransf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCCDeb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControlCARTAO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControlCARTAO.SuspendLayout()
        CType(Me.txtNomeCDeb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartõesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vencto_CartãoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenctoCartãoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomeCartao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCCCartao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormaCartao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorCartao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControlCHEQUES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControlCHEQUES.SuspendLayout()
        CType(Me.Vencto_ChequesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vencto_ChequesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckChequeCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaChequeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckOuroCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOuro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckCashCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCash.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckDolarCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDolar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MDCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckNavegar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VendaLabel
        '
        VendaLabel.AutoSize = True
        VendaLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VendaLabel.Location = New System.Drawing.Point(381, 23)
        VendaLabel.Name = "VendaLabel"
        VendaLabel.Size = New System.Drawing.Size(56, 15)
        VendaLabel.TabIndex = 0
        VendaLabel.Text = "Venda Nº"
        '
        'DataVendaLabel
        '
        DataVendaLabel.AutoSize = True
        DataVendaLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataVendaLabel.Location = New System.Drawing.Point(595, 23)
        DataVendaLabel.Name = "DataVendaLabel"
        DataVendaLabel.Size = New System.Drawing.Size(31, 15)
        DataVendaLabel.TabIndex = 2
        DataVendaLabel.Text = "Data"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(733, 24)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(49, 15)
        TipoLabel.TabIndex = 5
        TipoLabel.Text = "Tipo Vd."
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(393, 49)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(44, 15)
        Label1.TabIndex = 6
        Label1.Text = "Cliente"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(737, 49)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(46, 15)
        Label2.TabIndex = 8
        Label2.Text = "Crédito"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(438, 150)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(66, 15)
        Label3.TabIndex = 10
        Label3.Text = "Mala direta"
        Label3.Visible = False
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(374, 75)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(63, 15)
        Label4.TabIndex = 12
        Label4.Text = "Vendedora"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(723, 75)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(59, 15)
        Label5.TabIndex = 14
        Label5.Text = "Comissão"
        '
        'DestinoLabel
        '
        DestinoLabel.AutoSize = True
        DestinoLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DestinoLabel.Location = New System.Drawing.Point(363, 101)
        DestinoLabel.Name = "DestinoLabel"
        DestinoLabel.Size = New System.Drawing.Size(74, 15)
        DestinoLabel.TabIndex = 16
        DestinoLabel.Text = "Observações"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(444, 436)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(35, 15)
        Label6.TabIndex = 22
        Label6.Text = "Troca"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(560, 436)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(57, 15)
        Label7.TabIndex = 23
        Label7.Text = "Desconto"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(558, 463)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(59, 15)
        Label8.TabIndex = 24
        Label8.Text = "Valor final"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(243, 412)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(40, 17)
        Label12.TabIndex = 17
        Label12.Text = "Dólar"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(247, 440)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(36, 17)
        Label13.TabIndex = 20
        Label13.Text = "Cash"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.Location = New System.Drawing.Point(245, 468)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(38, 17)
        Label14.TabIndex = 23
        Label14.Text = "Ouro"
        '
        'BancoLabel
        '
        BancoLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BancoLabel.Location = New System.Drawing.Point(404, 36)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(44, 17)
        BancoLabel.TabIndex = 21
        BancoLabel.Text = "Banco"
        BancoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChequeLabel
        '
        ChequeLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChequeLabel.Location = New System.Drawing.Point(5, 35)
        ChequeLabel.Name = "ChequeLabel"
        ChequeLabel.Size = New System.Drawing.Size(40, 17)
        ChequeLabel.TabIndex = 19
        ChequeLabel.Text = "Valor Total"
        ChequeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormaChequeLabel
        '
        FormaChequeLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormaChequeLabel.Location = New System.Drawing.Point(202, 35)
        FormaChequeLabel.Name = "FormaChequeLabel"
        FormaChequeLabel.Size = New System.Drawing.Size(88, 18)
        FormaChequeLabel.TabIndex = 1
        FormaChequeLabel.Text = "Parcelamento"
        FormaChequeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(464, 36)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(57, 17)
        Label9.TabIndex = 33
        Label9.Text = "Cartão"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(234, 35)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(88, 18)
        Label10.TabIndex = 30
        Label10.Text = "Parcelamento"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(8, 38)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(67, 18)
        Label11.TabIndex = 29
        Label11.Text = "Crédito"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.Location = New System.Drawing.Point(871, 414)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(72, 17)
        Label15.TabIndex = 28
        Label15.Text = "Débito C/C"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label17.Location = New System.Drawing.Point(807, 441)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(138, 17)
        Label17.TabIndex = 32
        Label17.Text = "Transferência Bancária"
        '
        'BancoTransfLabel
        '
        BancoTransfLabel.AutoSize = True
        BancoTransfLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BancoTransfLabel.Location = New System.Drawing.Point(902, 471)
        BancoTransfLabel.Name = "BancoTransfLabel"
        BancoTransfLabel.Size = New System.Drawing.Size(43, 17)
        BancoTransfLabel.TabIndex = 33
        BancoTransfLabel.Text = "Banco"
        '
        'Label16
        '
        Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.Location = New System.Drawing.Point(8, 81)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(67, 17)
        Label16.TabIndex = 35
        Label16.Text = "Débito"
        Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label18.Location = New System.Drawing.Point(19, 110)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(56, 17)
        Label18.TabIndex = 37
        Label18.Text = "Cartão"
        Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnNovo, Me.btnEtiqMalaDireta, Me.btnSalvar, Me.btnUndo, Me.btnCancelarVenda, Me.btnCartões, Me.btnAtual2})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 11
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
        'btnNovo
        '
        Me.btnNovo.Caption = "Incluir venda"
        Me.btnNovo.Id = 4
        Me.btnNovo.ImageOptions.Image = CType(resources.GetObject("btnNovo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNovo.ImageOptions.LargeImage = CType(resources.GetObject("btnNovo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        '
        'btnEtiqMalaDireta
        '
        Me.btnEtiqMalaDireta.Caption = "Etiquetas mala direta"
        Me.btnEtiqMalaDireta.Id = 5
        Me.btnEtiqMalaDireta.ImageOptions.Image = CType(resources.GetObject("btnEtiqMalaDireta.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEtiqMalaDireta.ImageOptions.LargeImage = CType(resources.GetObject("btnEtiqMalaDireta.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEtiqMalaDireta.Name = "btnEtiqMalaDireta"
        '
        'btnSalvar
        '
        Me.btnSalvar.Caption = "Salvar"
        Me.btnSalvar.Id = 6
        Me.btnSalvar.ImageOptions.Image = CType(resources.GetObject("btnSalvar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageOptions.LargeImage = CType(resources.GetObject("btnSalvar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnUndo
        '
        Me.btnUndo.Caption = "Desfazer"
        Me.btnUndo.Id = 7
        Me.btnUndo.ImageOptions.Image = CType(resources.GetObject("btnUndo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUndo.ImageOptions.LargeImage = CType(resources.GetObject("btnUndo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnUndo.Name = "btnUndo"
        '
        'btnCancelarVenda
        '
        Me.btnCancelarVenda.Caption = "Cancelar venda"
        Me.btnCancelarVenda.Id = 8
        Me.btnCancelarVenda.ImageOptions.Image = CType(resources.GetObject("btnCancelarVenda.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelarVenda.ImageOptions.LargeImage = CType(resources.GetObject("btnCancelarVenda.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCancelarVenda.Name = "btnCancelarVenda"
        '
        'btnCartões
        '
        Me.btnCartões.Caption = "Taxas Adm. Cartão"
        Me.btnCartões.Id = 9
        Me.btnCartões.ImageOptions.SvgImage = CType(resources.GetObject("btnCartões.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnCartões.Name = "btnCartões"
        '
        'btnAtual2
        '
        Me.btnAtual2.Caption = "Atualizar valores"
        Me.btnAtual2.Id = 10
        Me.btnAtual2.ImageOptions.Image = CType(resources.GetObject("btnAtual2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAtual2.ImageOptions.LargeImage = CType(resources.GetObject("btnAtual2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAtual2.Name = "btnAtual2"
        ToolTipItem1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem1.ImageOptions.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipItem1.Text = "Refaz os lançamentos das parcelas de cheques e cartão de crédito/débito"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnAtual2.SuperTip = SuperToolTip1
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribAtual, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "VENDAS"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnCancelarVenda)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnNovo)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        '
        'ribAtual
        '
        Me.ribAtual.ItemLinks.Add(Me.btnAtual2)
        Me.ribAtual.Name = "ribAtual"
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
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnCartões)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Visible = False
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnFechar)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(611, 147)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(117, 25)
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
        Me.TableAdapterManager.cboClientesTableAdapter = Nothing
        Me.TableAdapterManager.cboVendedorasTableAdapter = Nothing
        Me.TableAdapterManager.Clientes1TableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pepe.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager.Vencto_ChequesTableAdapter = Me.Vencto_ChequesTableAdapter
        Me.TableAdapterManager.VENDAS_DETTableAdapter = Nothing
        Me.TableAdapterManager.VendasDetTableAdapter = Me.VendasDetTableAdapter
        Me.TableAdapterManager.VENDASTableAdapter = Me.VENDASTableAdapter
        '
        'Vencto_ChequesTableAdapter
        '
        Me.Vencto_ChequesTableAdapter.ClearBeforeFill = True
        '
        'VendasDetTableAdapter
        '
        Me.VendasDetTableAdapter.ClearBeforeFill = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.Appearance.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(6, 168)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1326, 529)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(Me.Button1)
        Me.XtraTabPage1.Controls.Add(Label8)
        Me.XtraTabPage1.Controls.Add(Label7)
        Me.XtraTabPage1.Controls.Add(Label6)
        Me.XtraTabPage1.Controls.Add(Me.txtValorFinal)
        Me.XtraTabPage1.Controls.Add(Me.txtDesconto)
        Me.XtraTabPage1.Controls.Add(Me.txtTroca)
        Me.XtraTabPage1.Controls.Add(Me.VendasDetGridControl)
        Me.XtraTabPage1.Controls.Add(DestinoLabel)
        Me.XtraTabPage1.Controls.Add(Label5)
        Me.XtraTabPage1.Controls.Add(Me.TextEdit2)
        Me.XtraTabPage1.Controls.Add(Label4)
        Me.XtraTabPage1.Controls.Add(Me.LookUpEdit3)
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
        Me.XtraTabPage1.Controls.Add(Me.IdTextEdit)
        Me.XtraTabPage1.Controls.Add(Me.DestinoTextEdit)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1324, 503)
        Me.XtraTabPage1.Text = "DADOS DA VENDA"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(63, 15)
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
        Me.txtValorFinal.Location = New System.Drawing.Point(620, 460)
        Me.txtValorFinal.MenuManager = Me.ribbonControl1
        Me.txtValorFinal.Name = "txtValorFinal"
        Me.txtValorFinal.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorFinal.Properties.Appearance.Options.UseFont = True
        Me.txtValorFinal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorFinal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorFinal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtValorFinal.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtValorFinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorFinal.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtValorFinal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorFinal.Properties.Mask.EditMask = "n2"
        Me.txtValorFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorFinal.Size = New System.Drawing.Size(73, 24)
        Me.txtValorFinal.TabIndex = 10
        Me.txtValorFinal.TabStop = False
        '
        'txtDesconto
        '
        Me.txtDesconto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Desconto", True))
        Me.txtDesconto.Location = New System.Drawing.Point(620, 433)
        Me.txtDesconto.MenuManager = Me.ribbonControl1
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.Properties.Appearance.Options.UseFont = True
        Me.txtDesconto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDesconto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDesconto.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtDesconto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDesconto.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtDesconto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDesconto.Properties.Mask.EditMask = "n2"
        Me.txtDesconto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDesconto.Size = New System.Drawing.Size(73, 24)
        Me.txtDesconto.TabIndex = 9
        '
        'txtTroca
        '
        Me.txtTroca.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Credito", True))
        Me.txtTroca.Location = New System.Drawing.Point(484, 433)
        Me.txtTroca.MenuManager = Me.ribbonControl1
        Me.txtTroca.Name = "txtTroca"
        Me.txtTroca.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTroca.Properties.Appearance.Options.UseFont = True
        Me.txtTroca.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTroca.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTroca.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtTroca.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtTroca.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTroca.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtTroca.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTroca.Properties.Mask.EditMask = "n2"
        Me.txtTroca.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTroca.Size = New System.Drawing.Size(63, 24)
        Me.txtTroca.TabIndex = 8
        '
        'VendasDetGridControl
        '
        Me.VendasDetGridControl.DataSource = Me.FKVENDASVendasDetBindingSource
        Me.VendasDetGridControl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendasDetGridControl.Location = New System.Drawing.Point(484, 163)
        Me.VendasDetGridControl.MainView = Me.GridView1
        Me.VendasDetGridControl.MenuManager = Me.ribbonControl1
        Me.VendasDetGridControl.Name = "VendasDetGridControl"
        Me.VendasDetGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboId, Me.RepositoryItemLookUpEdit1, Me.btnAbrirItem, Me.cboRef, Me.txtValorVenda, Me.RepositoryItemSpinEdit1})
        Me.VendasDetGridControl.Size = New System.Drawing.Size(327, 264)
        Me.VendasDetGridControl.TabIndex = 18
        Me.VendasDetGridControl.TabStop = False
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
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 1
        Me.GridView1.OptionsEditForm.FormCaptionFormat = "PEÇA"
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 220
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'btnItem
        '
        Me.btnItem.Caption = " "
        Me.btnItem.ColumnEdit = Me.btnAbrirItem
        Me.btnItem.FieldName = "GridColumn2"
        Me.btnItem.Name = "btnItem"
        Me.btnItem.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnItem.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.btnItem.Visible = True
        Me.btnItem.VisibleIndex = 3
        Me.btnItem.Width = 26
        '
        'btnAbrirItem
        '
        Me.btnAbrirItem.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        SuperToolTip2.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem2.Appearance.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ToolTipItem2.Appearance.Options.UseImage = True
        ToolTipItem2.ImageOptions.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        ToolTipItem2.Text = "Excluir peça"
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btnAbrirItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, SuperToolTip2, DevExpress.Utils.ToolTipAnchor.[Default])})
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
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 133
        '
        'cboRef
        '
        Me.cboRef.AutoHeight = False
        Me.cboRef.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRef.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDPeça", "IDPeça", 60, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modêlo", "Ref.", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendida", "Vendida", 48, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Comissão", "Comissão", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboRef.DataSource = Me.TabPeçasBindingSource
        Me.cboRef.DisplayMember = "Modêlo"
        Me.cboRef.DropDownRows = 21
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
        Me.colValorVenda.ColumnEdit = Me.txtValorVenda
        Me.colValorVenda.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colValorVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorVenda.FieldName = "ValorVenda"
        Me.colValorVenda.Name = "colValorVenda"
        Me.colValorVenda.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorVenda", "{0:#,###0.00;-#,###0.00}")})
        Me.colValorVenda.Visible = True
        Me.colValorVenda.VisibleIndex = 1
        Me.colValorVenda.Width = 72
        '
        'txtValorVenda
        '
        Me.txtValorVenda.AutoHeight = False
        Me.txtValorVenda.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtValorVenda.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtValorVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorVenda.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtValorVenda.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorVenda.Mask.EditMask = "n"
        Me.txtValorVenda.Name = "txtValorVenda"
        '
        'colComissão
        '
        Me.colComissão.AppearanceCell.Options.UseTextOptions = True
        Me.colComissão.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colComissão.AppearanceHeader.Options.UseTextOptions = True
        Me.colComissão.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComissão.Caption = "Com."
        Me.colComissão.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colComissão.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colComissão.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colComissão.FieldName = "Comissão"
        Me.colComissão.Name = "colComissão"
        Me.colComissão.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.Near
        Me.colComissão.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Comissão", "{0:#,###0.00;-#,###0.00}")})
        Me.colComissão.Visible = True
        Me.colComissão.VisibleIndex = 2
        Me.colComissão.Width = 74
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.RepositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "n"
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
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
        Me.cboId.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDPeça", "ID Peça", 60, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modêlo", "Modêlo", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[True]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendida", "Vendida", 48, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Valor", "Valor", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Comissão", "Comissão", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Com2", "Com2", 37, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
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
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Comissão", True))
        Me.TextEdit2.Location = New System.Drawing.Point(786, 72)
        Me.TextEdit2.MenuManager = Me.ribbonControl1
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TextEdit2.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.TextEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.TextEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.Mask.EditMask = "n2"
        Me.TextEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit2.Size = New System.Drawing.Size(71, 24)
        Me.TextEdit2.TabIndex = 6
        '
        'LookUpEdit3
        '
        Me.LookUpEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Vendedora", True))
        Me.LookUpEdit3.Location = New System.Drawing.Point(441, 72)
        Me.LookUpEdit3.MenuManager = Me.ribbonControl1
        Me.LookUpEdit3.Name = "LookUpEdit3"
        Me.LookUpEdit3.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit3.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.LookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendedora", "Vendedora", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[True]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID Vendedora", "ID Vendedora", 76, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookUpEdit3.Properties.DataSource = Me.CboVendedorasBindingSource
        Me.LookUpEdit3.Properties.DisplayMember = "Vendedora"
        Me.LookUpEdit3.Properties.DropDownRows = 16
        Me.LookUpEdit3.Properties.NullText = ""
        Me.LookUpEdit3.Properties.ValueMember = "Vendedora"
        Me.LookUpEdit3.Size = New System.Drawing.Size(146, 24)
        Me.LookUpEdit3.TabIndex = 5
        '
        'CboVendedorasBindingSource
        '
        Me.CboVendedorasBindingSource.DataMember = "cboVendedoras"
        Me.CboVendedorasBindingSource.DataSource = Me.DsPrincipal
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Troca", True))
        Me.TextEdit1.Location = New System.Drawing.Point(786, 46)
        Me.TextEdit1.MenuManager = Me.ribbonControl1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.TextEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.Mask.EditMask = "n2"
        Me.TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit1.Size = New System.Drawing.Size(71, 24)
        Me.TextEdit1.TabIndex = 4
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Tipo", True))
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(786, 20)
        Me.ComboBoxEdit1.MenuManager = Me.ribbonControl1
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"Interna", "Externa"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(71, 24)
        Me.ComboBoxEdit1.TabIndex = 2
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "IDCliente", True))
        Me.LookUpEdit1.Location = New System.Drawing.Point(441, 46)
        Me.LookUpEdit1.MenuManager = Me.ribbonControl1
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit1.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCliente", "ID Cliente", 70, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookUpEdit1.Properties.DataSource = Me.ClientesBindingSource
        Me.LookUpEdit1.Properties.DisplayMember = "Nome"
        Me.LookUpEdit1.Properties.DropDownRows = 12
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.ValueMember = "IDCliente"
        Me.LookUpEdit1.Size = New System.Drawing.Size(282, 24)
        Me.LookUpEdit1.TabIndex = 3
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DsPrincipal
        Me.ClientesBindingSource.Filter = "Nome Is Not Null"
        Me.ClientesBindingSource.Sort = "Nome"
        '
        'txtDataVenda
        '
        Me.txtDataVenda.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "DataVenda", True))
        Me.txtDataVenda.EditValue = Nothing
        Me.txtDataVenda.Location = New System.Drawing.Point(630, 20)
        Me.txtDataVenda.MenuManager = Me.ribbonControl1
        Me.txtDataVenda.Name = "txtDataVenda"
        Me.txtDataVenda.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataVenda.Properties.Appearance.Options.UseFont = True
        Me.txtDataVenda.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDataVenda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDataVenda.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDataVenda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDataVenda.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDataVenda.Size = New System.Drawing.Size(93, 24)
        Me.txtDataVenda.TabIndex = 1
        '
        'txtVenda
        '
        Me.txtVenda.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Venda", True))
        Me.txtVenda.Location = New System.Drawing.Point(441, 20)
        Me.txtVenda.MenuManager = Me.ribbonControl1
        Me.txtVenda.Name = "txtVenda"
        Me.txtVenda.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVenda.Properties.Appearance.Options.UseFont = True
        Me.txtVenda.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVenda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtVenda.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtVenda.Size = New System.Drawing.Size(71, 24)
        Me.txtVenda.TabIndex = 0
        Me.txtVenda.TabStop = False
        '
        'IdTextEdit
        '
        Me.IdTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Id", True))
        Me.IdTextEdit.Location = New System.Drawing.Point(485, 319)
        Me.IdTextEdit.MenuManager = Me.ribbonControl1
        Me.IdTextEdit.Name = "IdTextEdit"
        Me.IdTextEdit.Size = New System.Drawing.Size(73, 20)
        Me.IdTextEdit.TabIndex = 26
        Me.IdTextEdit.TabStop = False
        '
        'DestinoTextEdit
        '
        Me.DestinoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Destino", True))
        Me.DestinoTextEdit.Location = New System.Drawing.Point(441, 98)
        Me.DestinoTextEdit.MenuManager = Me.ribbonControl1
        Me.DestinoTextEdit.Name = "DestinoTextEdit"
        Me.DestinoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestinoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DestinoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DestinoTextEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DestinoTextEdit.Size = New System.Drawing.Size(416, 48)
        Me.DestinoTextEdit.TabIndex = 7
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.AutoScroll = True
        Me.XtraTabPage2.Controls.Add(Me.btnCC)
        Me.XtraTabPage2.Controls.Add(Me.txtCliente)
        Me.XtraTabPage2.Controls.Add(Me.TextEdit3)
        Me.XtraTabPage2.Controls.Add(BancoTransfLabel)
        Me.XtraTabPage2.Controls.Add(Me.txtBancoTransf)
        Me.XtraTabPage2.Controls.Add(Label17)
        Me.XtraTabPage2.Controls.Add(Label15)
        Me.XtraTabPage2.Controls.Add(Me.txtCCDeb)
        Me.XtraTabPage2.Controls.Add(Me.GroupControlCARTAO)
        Me.XtraTabPage2.Controls.Add(Me.GroupControlCHEQUES)
        Me.XtraTabPage2.Controls.Add(Me.ckOuroCC)
        Me.XtraTabPage2.Controls.Add(Label14)
        Me.XtraTabPage2.Controls.Add(Me.txtOuro)
        Me.XtraTabPage2.Controls.Add(Me.ckCashCC)
        Me.XtraTabPage2.Controls.Add(Label13)
        Me.XtraTabPage2.Controls.Add(Me.txtCash)
        Me.XtraTabPage2.Controls.Add(Me.ckDolarCC)
        Me.XtraTabPage2.Controls.Add(Label12)
        Me.XtraTabPage2.Controls.Add(Me.txtDolar)
        Me.XtraTabPage2.Controls.Add(Me.txtTransf)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1324, 503)
        Me.XtraTabPage2.Text = "FORMA DE PAGAMENTO"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(397, 25)
        Me.txtCliente.MenuManager = Me.ribbonControl1
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.txtCliente.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Properties.Appearance.Options.UseBackColor = True
        Me.txtCliente.Properties.Appearance.Options.UseFont = True
        Me.txtCliente.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCliente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCliente.Properties.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(526, 24)
        Me.txtCliente.TabIndex = 35
        Me.txtCliente.TabStop = False
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(513, 2)
        Me.TextEdit3.MenuManager = Me.ribbonControl1
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(294, 24)
        Me.TextEdit3.TabIndex = 34
        Me.TextEdit3.TabStop = False
        '
        'txtBancoTransf
        '
        Me.txtBancoTransf.Location = New System.Drawing.Point(948, 466)
        Me.txtBancoTransf.MenuManager = Me.ribbonControl1
        Me.txtBancoTransf.Name = "txtBancoTransf"
        Me.txtBancoTransf.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBancoTransf.Properties.Appearance.Options.UseFont = True
        Me.txtBancoTransf.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBancoTransf.Size = New System.Drawing.Size(211, 26)
        Me.txtBancoTransf.TabIndex = 6
        '
        'txtCCDeb
        '
        Me.txtCCDeb.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "CCDeb", True))
        Me.txtCCDeb.Location = New System.Drawing.Point(948, 410)
        Me.txtCCDeb.MenuManager = Me.ribbonControl1
        Me.txtCCDeb.Name = "txtCCDeb"
        Me.txtCCDeb.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCCDeb.Properties.Appearance.Options.UseFont = True
        Me.txtCCDeb.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCCDeb.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCCDeb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCCDeb.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtCCDeb.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCCDeb.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtCCDeb.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCCDeb.Properties.Mask.EditMask = "n2"
        Me.txtCCDeb.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCCDeb.Size = New System.Drawing.Size(82, 26)
        Me.txtCCDeb.TabIndex = 4
        '
        'GroupControlCARTAO
        '
        Me.GroupControlCARTAO.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControlCARTAO.AppearanceCaption.ForeColor = System.Drawing.Color.Yellow
        Me.GroupControlCARTAO.AppearanceCaption.Options.UseFont = True
        Me.GroupControlCARTAO.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControlCARTAO.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControlCARTAO.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControlCARTAO.Controls.Add(Label18)
        Me.GroupControlCARTAO.Controls.Add(Me.txtNomeCDeb)
        Me.GroupControlCARTAO.Controls.Add(Me.txtDeb)
        Me.GroupControlCARTAO.Controls.Add(Label16)
        Me.GroupControlCARTAO.Controls.Add(Me.Vencto_CartãoGridControl)
        Me.GroupControlCARTAO.Controls.Add(Label9)
        Me.GroupControlCARTAO.Controls.Add(Me.txtNomeCartao)
        Me.GroupControlCARTAO.Controls.Add(Me.txtCCCartao)
        Me.GroupControlCARTAO.Controls.Add(Me.txtFormaCartao)
        Me.GroupControlCARTAO.Controls.Add(Label10)
        Me.GroupControlCARTAO.Controls.Add(Me.txtValorCartao)
        Me.GroupControlCARTAO.Controls.Add(Label11)
        ButtonImageOptions1.Image = CType(resources.GetObject("ButtonImageOptions1.Image"), System.Drawing.Image)
        ButtonImageOptions1.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.BeforeText
        ToolTipItem3.ImageOptions.ImageUri.Uri = "snap/snapdeletelist;Size16x16"
        ToolTipItem3.Text = "Exclui dados do cartão"
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.GroupControlCARTAO.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, SuperToolTip3, True, False, True, Nothing, -1)})
        Me.GroupControlCARTAO.Location = New System.Drawing.Point(659, 70)
        Me.GroupControlCARTAO.Name = "GroupControlCARTAO"
        Me.GroupControlCARTAO.Size = New System.Drawing.Size(653, 299)
        Me.GroupControlCARTAO.TabIndex = 26
        Me.GroupControlCARTAO.Text = "CARTÃO"
        '
        'txtNomeCDeb
        '
        Me.txtNomeCDeb.Location = New System.Drawing.Point(77, 104)
        Me.txtNomeCDeb.MenuManager = Me.ribbonControl1
        Me.txtNomeCDeb.Name = "txtNomeCDeb"
        Me.txtNomeCDeb.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCDeb.Properties.Appearance.Options.UseFont = True
        Me.txtNomeCDeb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtNomeCDeb.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.txtNomeCDeb.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ncartao", "Cartão", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Perc", "Perc", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.txtNomeCDeb.Properties.DataSource = Me.CartõesBindingSource
        Me.txtNomeCDeb.Properties.DisplayMember = "Ncartao"
        Me.txtNomeCDeb.Properties.DropDownRows = 21
        Me.txtNomeCDeb.Properties.NullText = ""
        Me.txtNomeCDeb.Properties.ValueMember = "Ncartao"
        Me.txtNomeCDeb.Size = New System.Drawing.Size(119, 26)
        Me.txtNomeCDeb.TabIndex = 4
        '
        'CartõesBindingSource
        '
        Me.CartõesBindingSource.DataMember = "Cartões"
        Me.CartõesBindingSource.DataSource = Me.DsCliente
        '
        'DsCliente
        '
        Me.DsCliente.DataSetName = "dsCliente"
        Me.DsCliente.EnforceConstraints = False
        Me.DsCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDeb
        '
        Me.txtDeb.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDeb.Location = New System.Drawing.Point(77, 76)
        Me.txtDeb.MenuManager = Me.ribbonControl1
        Me.txtDeb.Name = "txtDeb"
        Me.txtDeb.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeb.Properties.Appearance.Options.UseFont = True
        Me.txtDeb.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeb.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDeb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDeb.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtDeb.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDeb.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtDeb.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDeb.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtDeb.Properties.Mask.BeepOnError = True
        Me.txtDeb.Properties.Mask.EditMask = "n2"
        Me.txtDeb.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDeb.Size = New System.Drawing.Size(68, 26)
        Me.txtDeb.TabIndex = 3
        '
        'Vencto_CartãoGridControl
        '
        Me.Vencto_CartãoGridControl.DataSource = Me.VenctoCartãoBindingSource
        Me.Vencto_CartãoGridControl.Location = New System.Drawing.Point(244, 61)
        Me.Vencto_CartãoGridControl.MainView = Me.GridView3
        Me.Vencto_CartãoGridControl.MenuManager = Me.ribbonControl1
        Me.Vencto_CartãoGridControl.Name = "Vencto_CartãoGridControl"
        Me.Vencto_CartãoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2})
        Me.Vencto_CartãoGridControl.Size = New System.Drawing.Size(399, 233)
        Me.Vencto_CartãoGridControl.TabIndex = 3
        Me.Vencto_CartãoGridControl.TabStop = False
        Me.Vencto_CartãoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'VenctoCartãoBindingSource
        '
        Me.VenctoCartãoBindingSource.DataMember = "Vencto Cartão"
        Me.VenctoCartãoBindingSource.DataSource = Me.DsCliente
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1, Me.colParcela1, Me.colVencto1, Me.colVValor1, Me.colNomeCartão, Me.colIdCC1})
        Me.GridView3.GridControl = Me.Vencto_CartãoGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.ReadOnly = True
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
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
        Me.colParcela1.OptionsColumn.AllowEdit = False
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
        Me.colVencto1.OptionsColumn.AllowEdit = False
        Me.colVencto1.Visible = True
        Me.colVencto1.VisibleIndex = 1
        Me.colVencto1.Width = 80
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
        Me.colVValor1.OptionsColumn.AllowEdit = False
        Me.colVValor1.Visible = True
        Me.colVValor1.VisibleIndex = 2
        Me.colVValor1.Width = 94
        '
        'colNomeCartão
        '
        Me.colNomeCartão.AppearanceHeader.Options.UseTextOptions = True
        Me.colNomeCartão.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNomeCartão.Caption = "Cartão"
        Me.colNomeCartão.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colNomeCartão.FieldName = "NomeCartão"
        Me.colNomeCartão.Name = "colNomeCartão"
        Me.colNomeCartão.OptionsColumn.AllowEdit = False
        Me.colNomeCartão.Visible = True
        Me.colNomeCartão.VisibleIndex = 3
        Me.colNomeCartão.Width = 132
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ncartao", "Cartão", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.CartõesBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Ncartao"
        Me.RepositoryItemLookUpEdit2.DropDownRows = 21
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ValueMember = "Ncartao"
        '
        'colIdCC1
        '
        Me.colIdCC1.FieldName = "IdCC"
        Me.colIdCC1.Name = "colIdCC1"
        '
        'txtNomeCartao
        '
        Me.txtNomeCartao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "NomeCartão", True))
        Me.txtNomeCartao.Location = New System.Drawing.Point(523, 30)
        Me.txtNomeCartao.MenuManager = Me.ribbonControl1
        Me.txtNomeCartao.Name = "txtNomeCartao"
        Me.txtNomeCartao.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCartao.Properties.Appearance.Options.UseFont = True
        Me.txtNomeCartao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtNomeCartao.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNomeCartao.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ncartao", "Cartão", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Perc", "Perc", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.txtNomeCartao.Properties.DataSource = Me.CartõesBindingSource
        Me.txtNomeCartao.Properties.DisplayMember = "Ncartao"
        Me.txtNomeCartao.Properties.DropDownRows = 21
        Me.txtNomeCartao.Properties.NullText = ""
        Me.txtNomeCartao.Properties.ValueMember = "Ncartao"
        Me.txtNomeCartao.Size = New System.Drawing.Size(119, 26)
        Me.txtNomeCartao.TabIndex = 2
        '
        'txtCCCartao
        '
        Me.txtCCCartao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "CartãoCC", True))
        Me.txtCCCartao.Location = New System.Drawing.Point(151, 33)
        Me.txtCCCartao.MenuManager = Me.ribbonControl1
        Me.txtCCCartao.Name = "txtCCCartao"
        Me.txtCCCartao.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCCCartao.Properties.Appearance.Options.UseFont = True
        Me.txtCCCartao.Properties.Caption = "C.C."
        Me.txtCCCartao.Size = New System.Drawing.Size(46, 21)
        Me.txtCCCartao.TabIndex = 31
        Me.txtCCCartao.TabStop = False
        '
        'txtFormaCartao
        '
        Me.txtFormaCartao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "FormaCartão", True))
        Me.txtFormaCartao.Location = New System.Drawing.Point(325, 30)
        Me.txtFormaCartao.MenuManager = Me.ribbonControl1
        Me.txtFormaCartao.Name = "txtFormaCartao"
        Me.txtFormaCartao.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormaCartao.Properties.Appearance.Options.UseFont = True
        Me.txtFormaCartao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtFormaCartao.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFormaCartao.Properties.DropDownRows = 10
        Me.txtFormaCartao.Properties.Items.AddRange(New Object() {"A vista", "2x", "3x", "4x", "5x", "6x", "7x", "8x", "9x", "10x"})
        Me.txtFormaCartao.Size = New System.Drawing.Size(98, 26)
        Me.txtFormaCartao.TabIndex = 1
        '
        'txtValorCartao
        '
        Me.txtValorCartao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Cartão", True))
        Me.txtValorCartao.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorCartao.Location = New System.Drawing.Point(77, 31)
        Me.txtValorCartao.MenuManager = Me.ribbonControl1
        Me.txtValorCartao.Name = "txtValorCartao"
        Me.txtValorCartao.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorCartao.Properties.Appearance.Options.UseFont = True
        Me.txtValorCartao.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorCartao.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorCartao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtValorCartao.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtValorCartao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorCartao.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtValorCartao.Properties.Mask.EditMask = "n"
        Me.txtValorCartao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorCartao.Size = New System.Drawing.Size(68, 26)
        Me.txtValorCartao.TabIndex = 0
        '
        'GroupControlCHEQUES
        '
        Me.GroupControlCHEQUES.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControlCHEQUES.AppearanceCaption.ForeColor = System.Drawing.Color.Yellow
        Me.GroupControlCHEQUES.AppearanceCaption.Options.UseFont = True
        Me.GroupControlCHEQUES.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControlCHEQUES.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControlCHEQUES.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControlCHEQUES.Controls.Add(Me.Vencto_ChequesGridControl)
        Me.GroupControlCHEQUES.Controls.Add(Me.ckChequeCC)
        Me.GroupControlCHEQUES.Controls.Add(Me.FormaChequeComboBoxEdit)
        Me.GroupControlCHEQUES.Controls.Add(BancoLabel)
        Me.GroupControlCHEQUES.Controls.Add(Me.ChequeSpinEdit)
        Me.GroupControlCHEQUES.Controls.Add(Me.BancoTextEdit)
        Me.GroupControlCHEQUES.Controls.Add(ChequeLabel)
        Me.GroupControlCHEQUES.Controls.Add(FormaChequeLabel)
        Me.GroupControlCHEQUES.Controls.Add(Me.btnAtual)
        ButtonImageOptions2.Image = CType(resources.GetObject("ButtonImageOptions2.Image"), System.Drawing.Image)
        ToolTipItem4.ImageOptions.ImageUri.Uri = "snap/snapdeletelist;Size16x16"
        ToolTipItem4.Text = "Exclui dados do(s) cheque(s)"
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.GroupControlCHEQUES.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, SuperToolTip4, True, False, True, Nothing, -1)})
        Me.GroupControlCHEQUES.Location = New System.Drawing.Point(9, 70)
        Me.GroupControlCHEQUES.Name = "GroupControlCHEQUES"
        Me.GroupControlCHEQUES.Size = New System.Drawing.Size(620, 299)
        Me.GroupControlCHEQUES.TabIndex = 0
        Me.GroupControlCHEQUES.Text = "CHEQUE"
        '
        'Vencto_ChequesGridControl
        '
        Me.Vencto_ChequesGridControl.DataSource = Me.Vencto_ChequesBindingSource
        Me.Vencto_ChequesGridControl.Location = New System.Drawing.Point(6, 61)
        Me.Vencto_ChequesGridControl.MainView = Me.GridView2
        Me.Vencto_ChequesGridControl.MenuManager = Me.ribbonControl1
        Me.Vencto_ChequesGridControl.Name = "Vencto_ChequesGridControl"
        Me.Vencto_ChequesGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit2})
        Me.Vencto_ChequesGridControl.Size = New System.Drawing.Size(607, 233)
        Me.Vencto_ChequesGridControl.TabIndex = 3
        Me.Vencto_ChequesGridControl.TabStop = False
        Me.Vencto_ChequesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'Vencto_ChequesBindingSource
        '
        Me.Vencto_ChequesBindingSource.DataMember = "FK_VENDAS_Vencto Cheques"
        Me.Vencto_ChequesBindingSource.DataSource = Me.VENDASBindingSource
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.colParcela, Me.colVencto, Me.colVValor, Me.colCheque, Me.colBanco, Me.colIdCC, Me.colVenda1})
        Me.GridView2.GridControl = Me.Vencto_ChequesGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Id"
        Me.GridColumn2.Name = "GridColumn2"
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
        Me.colVValor.ColumnEdit = Me.RepositoryItemSpinEdit2
        Me.colVValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colVValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVValor.FieldName = "VValor"
        Me.colVValor.Name = "colVValor"
        Me.colVValor.Visible = True
        Me.colVValor.VisibleIndex = 2
        Me.colVValor.Width = 84
        '
        'RepositoryItemSpinEdit2
        '
        Me.RepositoryItemSpinEdit2.AutoHeight = False
        Me.RepositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemSpinEdit2.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.RepositoryItemSpinEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit2.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.RepositoryItemSpinEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit2.Mask.EditMask = "n2"
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
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
        'colVenda1
        '
        Me.colVenda1.FieldName = "Venda"
        Me.colVenda1.Name = "colVenda1"
        '
        'ckChequeCC
        '
        Me.ckChequeCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "ChequeCC", True))
        Me.ckChequeCC.Location = New System.Drawing.Point(121, 32)
        Me.ckChequeCC.MenuManager = Me.ribbonControl1
        Me.ckChequeCC.Name = "ckChequeCC"
        Me.ckChequeCC.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckChequeCC.Properties.Appearance.Options.UseFont = True
        Me.ckChequeCC.Properties.Caption = "C.C."
        Me.ckChequeCC.Size = New System.Drawing.Size(46, 21)
        Me.ckChequeCC.TabIndex = 23
        Me.ckChequeCC.TabStop = False
        '
        'FormaChequeComboBoxEdit
        '
        Me.FormaChequeComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "FormaCheque", True))
        Me.FormaChequeComboBoxEdit.Location = New System.Drawing.Point(293, 30)
        Me.FormaChequeComboBoxEdit.MenuManager = Me.ribbonControl1
        Me.FormaChequeComboBoxEdit.Name = "FormaChequeComboBoxEdit"
        Me.FormaChequeComboBoxEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormaChequeComboBoxEdit.Properties.Appearance.Options.UseFont = True
        Me.FormaChequeComboBoxEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.FormaChequeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FormaChequeComboBoxEdit.Properties.DropDownRows = 10
        Me.FormaChequeComboBoxEdit.Properties.Items.AddRange(New Object() {"A vista", "2x", "3x", "4x", "5x", "6x", "7x", "8x", "9x", "10x"})
        Me.FormaChequeComboBoxEdit.Size = New System.Drawing.Size(89, 26)
        Me.FormaChequeComboBoxEdit.TabIndex = 2
        '
        'ChequeSpinEdit
        '
        Me.ChequeSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Cheque", True))
        Me.ChequeSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ChequeSpinEdit.Location = New System.Drawing.Point(49, 30)
        Me.ChequeSpinEdit.MenuManager = Me.ribbonControl1
        Me.ChequeSpinEdit.Name = "ChequeSpinEdit"
        Me.ChequeSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChequeSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.ChequeSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.ChequeSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ChequeSpinEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ChequeSpinEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.ChequeSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ChequeSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.ChequeSpinEdit.Properties.Mask.EditMask = "n"
        Me.ChequeSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.ChequeSpinEdit.Size = New System.Drawing.Size(68, 26)
        Me.ChequeSpinEdit.TabIndex = 0
        '
        'BancoTextEdit
        '
        Me.BancoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Banco", True))
        Me.BancoTextEdit.Location = New System.Drawing.Point(451, 30)
        Me.BancoTextEdit.MenuManager = Me.ribbonControl1
        Me.BancoTextEdit.Name = "BancoTextEdit"
        Me.BancoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BancoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.BancoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BancoTextEdit.Size = New System.Drawing.Size(159, 26)
        Me.BancoTextEdit.TabIndex = 3
        '
        'btnAtual
        '
        Me.btnAtual.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtual.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnAtual.Appearance.Options.UseFont = True
        Me.btnAtual.Appearance.Options.UseForeColor = True
        Me.btnAtual.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAtual.Location = New System.Drawing.Point(158, 233)
        Me.btnAtual.Name = "btnAtual"
        Me.btnAtual.Size = New System.Drawing.Size(116, 31)
        Me.btnAtual.TabIndex = 41
        Me.btnAtual.TabStop = False
        Me.btnAtual.Text = "Atualizar valores"
        '
        'ckOuroCC
        '
        Me.ckOuroCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "OuroCC", True))
        Me.ckOuroCC.Location = New System.Drawing.Point(379, 467)
        Me.ckOuroCC.MenuManager = Me.ribbonControl1
        Me.ckOuroCC.Name = "ckOuroCC"
        Me.ckOuroCC.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckOuroCC.Properties.Appearance.Options.UseFont = True
        Me.ckOuroCC.Properties.Caption = "C/C"
        Me.ckOuroCC.Size = New System.Drawing.Size(44, 21)
        Me.ckOuroCC.TabIndex = 24
        '
        'txtOuro
        '
        Me.txtOuro.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Ouro", True))
        Me.txtOuro.Location = New System.Drawing.Point(288, 465)
        Me.txtOuro.MenuManager = Me.ribbonControl1
        Me.txtOuro.Name = "txtOuro"
        Me.txtOuro.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOuro.Properties.Appearance.Options.UseFont = True
        Me.txtOuro.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOuro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOuro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtOuro.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtOuro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOuro.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtOuro.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOuro.Properties.Mask.EditMask = "n2"
        Me.txtOuro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOuro.Size = New System.Drawing.Size(82, 26)
        Me.txtOuro.TabIndex = 3
        '
        'ckCashCC
        '
        Me.ckCashCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "CashCC", True))
        Me.ckCashCC.Location = New System.Drawing.Point(379, 439)
        Me.ckCashCC.MenuManager = Me.ribbonControl1
        Me.ckCashCC.Name = "ckCashCC"
        Me.ckCashCC.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckCashCC.Properties.Appearance.Options.UseFont = True
        Me.ckCashCC.Properties.Caption = "C/C"
        Me.ckCashCC.Size = New System.Drawing.Size(44, 21)
        Me.ckCashCC.TabIndex = 21
        '
        'txtCash
        '
        Me.txtCash.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Real", True))
        Me.txtCash.Location = New System.Drawing.Point(288, 437)
        Me.txtCash.MenuManager = Me.ribbonControl1
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Properties.Appearance.Options.UseFont = True
        Me.txtCash.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCash.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCash.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCash.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtCash.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCash.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtCash.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCash.Properties.Mask.EditMask = "n2"
        Me.txtCash.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCash.Size = New System.Drawing.Size(82, 26)
        Me.txtCash.TabIndex = 2
        '
        'ckDolarCC
        '
        Me.ckDolarCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "DolarCC", True))
        Me.ckDolarCC.Location = New System.Drawing.Point(379, 410)
        Me.ckDolarCC.MenuManager = Me.ribbonControl1
        Me.ckDolarCC.Name = "ckDolarCC"
        Me.ckDolarCC.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckDolarCC.Properties.Appearance.Options.UseFont = True
        Me.ckDolarCC.Properties.Caption = "C/C"
        Me.ckDolarCC.Size = New System.Drawing.Size(44, 21)
        Me.ckDolarCC.TabIndex = 18
        '
        'txtDolar
        '
        Me.txtDolar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Dolar", True))
        Me.txtDolar.Location = New System.Drawing.Point(288, 409)
        Me.txtDolar.MenuManager = Me.ribbonControl1
        Me.txtDolar.Name = "txtDolar"
        Me.txtDolar.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDolar.Properties.Appearance.Options.UseFont = True
        Me.txtDolar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDolar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDolar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDolar.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtDolar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDolar.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtDolar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDolar.Properties.Mask.EditMask = "n2"
        Me.txtDolar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDolar.Size = New System.Drawing.Size(82, 26)
        Me.txtDolar.TabIndex = 1
        '
        'txtTransf
        '
        Me.txtTransf.EditValue = ""
        Me.txtTransf.Location = New System.Drawing.Point(948, 438)
        Me.txtTransf.MenuManager = Me.ribbonControl1
        Me.txtTransf.Name = "txtTransf"
        Me.txtTransf.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtTransf.Size = New System.Drawing.Size(82, 26)
        Me.txtTransf.TabIndex = 5
        '
        'MDCheckEdit
        '
        Me.MDCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "MD", True))
        Me.MDCheckEdit.Location = New System.Drawing.Point(337, 149)
        Me.MDCheckEdit.MenuManager = Me.ribbonControl1
        Me.MDCheckEdit.Name = "MDCheckEdit"
        Me.MDCheckEdit.Properties.Caption = "Comprador"
        Me.MDCheckEdit.Size = New System.Drawing.Size(75, 20)
        Me.MDCheckEdit.TabIndex = 27
        Me.MDCheckEdit.TabStop = False
        Me.MDCheckEdit.Visible = False
        '
        'LookUpEdit2
        '
        Me.LookUpEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "IDCliente", True))
        Me.LookUpEdit2.Enabled = False
        Me.LookUpEdit2.Location = New System.Drawing.Point(508, 147)
        Me.LookUpEdit2.MenuManager = Me.ribbonControl1
        Me.LookUpEdit2.Name = "LookUpEdit2"
        Me.LookUpEdit2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit2.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.LookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCliente", "ID Cliente", 70, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cliente", "Mala direta", 43, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookUpEdit2.Properties.DataSource = Me.ClientesBindingSource
        Me.LookUpEdit2.Properties.DisplayMember = "Cliente"
        Me.LookUpEdit2.Properties.DropDownRows = 12
        Me.LookUpEdit2.Properties.NullText = ""
        Me.LookUpEdit2.Properties.ValueMember = "IDCliente"
        Me.LookUpEdit2.Size = New System.Drawing.Size(71, 24)
        Me.LookUpEdit2.TabIndex = 9
        Me.LookUpEdit2.Visible = False
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
        Me.TableAdapterManager1.cboClientesTableAdapter = Nothing
        Me.TableAdapterManager1.cboVendedorasTableAdapter = Nothing
        Me.TableAdapterManager1.Clientes1TableAdapter = Nothing
        Me.TableAdapterManager1.ClientesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Pepe.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager1.Vencto_ChequesTableAdapter = Me.Vencto_ChequesTableAdapter
        Me.TableAdapterManager1.VENDAS_DETTableAdapter = Nothing
        Me.TableAdapterManager1.VendasDetTableAdapter = Me.VendasDetTableAdapter
        Me.TableAdapterManager1.VENDASTableAdapter = Nothing
        '
        'VendasDetBindingSource
        '
        Me.VendasDetBindingSource.DataMember = "FK_VENDAS_VendasDet"
        Me.VendasDetBindingSource.DataSource = Me.VENDASBindingSource
        '
        'Vencto_CartãoTableAdapter
        '
        Me.Vencto_CartãoTableAdapter.ClearBeforeFill = True
        '
        'CartõesTableAdapter
        '
        Me.CartõesTableAdapter.ClearBeforeFill = True
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'ckNavegar
        '
        Me.ckNavegar.Location = New System.Drawing.Point(570, 699)
        Me.ckNavegar.MenuManager = Me.ribbonControl1
        Me.ckNavegar.Name = "ckNavegar"
        Me.ckNavegar.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.ckNavegar.Properties.Appearance.Options.UseForeColor = True
        Me.ckNavegar.Properties.Caption = "Navegar"
        Me.ckNavegar.Size = New System.Drawing.Size(66, 20)
        Me.ckNavegar.TabIndex = 42
        '
        'dnConsertos
        '
        Me.dnConsertos.Buttons.Append.Visible = False
        Me.dnConsertos.Buttons.CancelEdit.Visible = False
        Me.dnConsertos.Buttons.EndEdit.Visible = False
        Me.dnConsertos.Buttons.First.Visible = False
        Me.dnConsertos.Buttons.Last.Visible = False
        Me.dnConsertos.Buttons.NextPage.Visible = False
        Me.dnConsertos.Buttons.PrevPage.Visible = False
        Me.dnConsertos.Buttons.Remove.Visible = False
        Me.dnConsertos.DataSource = Me.VENDASBindingSource
        Me.dnConsertos.Location = New System.Drawing.Point(76, 147)
        Me.dnConsertos.Name = "dnConsertos"
        Me.dnConsertos.Size = New System.Drawing.Size(90, 20)
        Me.dnConsertos.TabIndex = 43
        Me.dnConsertos.TextStringFormat = "{0}/{1}"
        Me.dnConsertos.Visible = False
        '
        'btnEsq
        '
        Me.btnEsq.ImageOptions.Image = CType(resources.GetObject("btnEsq.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEsq.Location = New System.Drawing.Point(642, 697)
        Me.btnEsq.Name = "btnEsq"
        Me.btnEsq.Size = New System.Drawing.Size(35, 23)
        Me.btnEsq.TabIndex = 45
        Me.btnEsq.Visible = False
        '
        'btnDir
        '
        Me.btnDir.ImageOptions.Image = CType(resources.GetObject("btnDir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDir.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.btnDir.Location = New System.Drawing.Point(676, 697)
        Me.btnDir.Name = "btnDir"
        Me.btnDir.Size = New System.Drawing.Size(35, 23)
        Me.btnDir.TabIndex = 46
        Me.btnDir.Visible = False
        '
        'btnCC
        '
        Me.btnCC.Location = New System.Drawing.Point(1065, 415)
        Me.btnCC.Name = "btnCC"
        Me.btnCC.Size = New System.Drawing.Size(75, 23)
        Me.btnCC.TabIndex = 36
        Me.btnCC.Text = "Button2"
        Me.btnCC.UseVisualStyleBackColor = True
        '
        'frmVenda
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1338, 722)
        Me.Controls.Add(Me.btnDir)
        Me.Controls.Add(Me.btnEsq)
        Me.Controls.Add(Me.dnConsertos)
        Me.Controls.Add(Me.ckNavegar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.MDCheckEdit)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.LookUpEdit2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IconOptions.Icon = CType(resources.GetObject("frmVenda.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmVenda"
        Me.Ribbon = Me.ribbonControl1
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
        CType(Me.txtValorFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTroca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDetGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKVENDASVendasDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrirItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPeçasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboVendedorasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataVenda.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataVenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBancoTransf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCCDeb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControlCARTAO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControlCARTAO.ResumeLayout(False)
        CType(Me.txtNomeCDeb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartõesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vencto_CartãoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenctoCartãoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomeCartao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCCCartao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormaCartao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorCartao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControlCHEQUES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControlCHEQUES.ResumeLayout(False)
        CType(Me.Vencto_ChequesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vencto_ChequesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckChequeCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaChequeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckOuroCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOuro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckCashCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCash.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckDolarCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDolar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MDCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckNavegar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnEtiqMalaDireta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents VENDASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VENDASTableAdapter As Pepe.DataSet1TableAdapters.VENDASTableAdapter
    Friend WithEvents TableAdapterManager As Pepe.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtDataVenda As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtVenda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Pepe.DataSet1TableAdapters.ClientesTableAdapter
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEdit3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CboVendedorasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CboVendedorasTableAdapter As Pepe.DataSet1TableAdapters.cboVendedorasTableAdapter
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendasDetGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colValorVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComissão As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboId As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TabPeçasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _1TabPeçasTableAdapter As Pepe.DataSet1TableAdapters._1TabPeçasTableAdapter
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
    Friend WithEvents TableAdapterManager1 As Pepe.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents VendasDetTableAdapter As Pepe.DataSet1TableAdapters.VendasDetTableAdapter
    Friend WithEvents VendasDetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FKVENDASVendasDetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MDCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCartões As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Vencto_ChequesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vencto_ChequesTableAdapter As Pepe.DataSet1TableAdapters.Vencto_ChequesTableAdapter
    Friend WithEvents ckOuroCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtOuro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckCashCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCash As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckDolarCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtDolar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents txtValorVenda As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents DestinoTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupControlCHEQUES As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Vencto_ChequesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ckChequeCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FormaChequeComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ChequeSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BancoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControlCARTAO As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Vencto_CartãoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcela1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVValor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomeCartão As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIdCC1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNomeCartao As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCCCartao As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFormaCartao As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtValorCartao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DsCliente As dsCliente
    Friend WithEvents VenctoCartãoBindingSource As BindingSource
    Friend WithEvents Vencto_CartãoTableAdapter As dsClienteTableAdapters.Vencto_CartãoTableAdapter
    Friend WithEvents CartõesBindingSource As BindingSource
    Friend WithEvents CartõesTableAdapter As dsClienteTableAdapters.CartõesTableAdapter
    Friend WithEvents txtCCDeb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBancoTransf As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTransf As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAtual As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer As Timer
    Friend WithEvents txtNomeCDeb As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDeb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAtual2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ribAtual As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colVenda1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ckNavegar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dnConsertos As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents btnEsq As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCC As Button
End Class
