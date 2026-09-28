Partial Public Class frmConsertosfrm
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim FormaChequeLabel As System.Windows.Forms.Label
        Dim ChequeLabel As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim BancoTransfLabel As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsertosfrm))
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim EditorButtonImageOptions5 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject17 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject18 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject19 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject20 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim EditorButtonImageOptions6 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject21 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject22 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject23 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject24 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
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
        Me.btnAtual2 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribAtual = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.lblCliente = New DevExpress.XtraEditors.LabelControl()
        Me.TableAdapterManager = New Pepe.dsCCTableAdapters.TableAdapterManager()
        Me.DataDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CONSERTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsGeral = New Pepe.dsGeral()
        Me.GroupControlCARTAO = New DevExpress.XtraEditors.GroupControl()
        Me.txtNomeCartãoDébito = New DevExpress.XtraEditors.LookUpEdit()
        Me.CartõesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDebito = New DevExpress.XtraEditors.TextEdit()
        Me.Vencto_CartãoGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CONSERTOSVenctoCartãoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParcela1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencto1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVValor1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomeCartão = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colIdCC1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdConserto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNomeCartao = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCCCartao = New DevExpress.XtraEditors.CheckEdit()
        Me.txtFormaCartao = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtValorCartao = New DevExpress.XtraEditors.TextEdit()
        Me.btnAtual = New DevExpress.XtraEditors.SimpleButton()
        Me.IDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CartõesTableAdapter = New Pepe.dsCCTableAdapters.CartõesTableAdapter()
        Me.BancoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ChequeSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FormaChequeComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ChequeCCCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.Vencto_ChequesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CONSERTOSVenctoChequesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParcela = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControlCHEQUES = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.txtVendedor = New DevExpress.XtraEditors.LookUpEdit()
        Me.VendedorasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtObs = New DevExpress.XtraEditors.MemoEdit()
        Me.txtCom = New DevExpress.XtraEditors.SpinEdit()
        Me.txtValor = New DevExpress.XtraEditors.SpinEdit()
        Me.txtCusto = New DevExpress.XtraEditors.SpinEdit()
        Me.cboCliente = New DevExpress.XtraEditors.LookUpEdit()
        Me.CboClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSERTOSTableAdapter = New Pepe.dsGeralTableAdapters.CONSERTOSTableAdapter()
        Me.CboClientesTableAdapter = New Pepe.dsGeralTableAdapters.cboClientesTableAdapter()
        Me.VendedorasTableAdapter = New Pepe.dsGeralTableAdapters.VendedorasTableAdapter()
        Me.Vencto_ChequesTableAdapter1 = New Pepe.dsGeralTableAdapters.Vencto_ChequesTableAdapter()
        Me.CartõesTableAdapter1 = New Pepe.dsGeralTableAdapters.CartõesTableAdapter()
        Me.Vencto_CartãoTableAdapter1 = New Pepe.dsGeralTableAdapters.Vencto_CartãoTableAdapter()
        Me.TableAdapterManager1 = New Pepe.dsGeralTableAdapters.TableAdapterManager()
        Me.ckDolarCC = New DevExpress.XtraEditors.CheckEdit()
        Me.txtDolar = New DevExpress.XtraEditors.TextEdit()
        Me.ckCashCC = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCash = New DevExpress.XtraEditors.TextEdit()
        Me.ckOuroCC = New DevExpress.XtraEditors.CheckEdit()
        Me.txtOuro = New DevExpress.XtraEditors.TextEdit()
        Me.txtDebCC = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorFinal = New DevExpress.XtraEditors.TextEdit()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.dnConsertos = New DevExpress.XtraEditors.DataNavigator()
        Me.ckNavegar = New DevExpress.XtraEditors.CheckEdit()
        Me.txtBancoTransf = New DevExpress.XtraEditors.TextEdit()
        Me.txtTransf = New DevExpress.XtraEditors.TextEdit()
        Me.txtAUT = New DevExpress.XtraEditors.TextEdit()
        Me.txtAUTDeb = New DevExpress.XtraEditors.TextEdit()
        Me.btnCC2 = New DevExpress.XtraEditors.SimpleButton()
        DataLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        FormaChequeLabel = New System.Windows.Forms.Label()
        ChequeLabel = New System.Windows.Forms.Label()
        BancoLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        BancoTransfLabel = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSERTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControlCARTAO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControlCARTAO.SuspendLayout()
        CType(Me.txtNomeCartãoDébito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartõesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vencto_CartãoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSERTOSVenctoCartãoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomeCartao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCCCartao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormaCartao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorCartao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaChequeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeCCCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vencto_ChequesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSERTOSVenctoChequesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControlCHEQUES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControlCHEQUES.SuspendLayout()
        CType(Me.GroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl.SuspendLayout()
        CType(Me.txtVendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedorasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCusto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckDolarCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDolar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckCashCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCash.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckOuroCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOuro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckNavegar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBancoTransf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAUT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAUTDeb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataLabel
        '
        DataLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataLabel.Location = New System.Drawing.Point(30, 22)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(34, 13)
        DataLabel.TabIndex = 17
        DataLabel.Text = "Data"
        DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(22, 31)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 16)
        Label1.TabIndex = 29
        Label1.Text = "Crédito:"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(402, 32)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(81, 13)
        Label2.TabIndex = 30
        Label2.Text = "Parcelamento"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(220, 32)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(42, 13)
        Label3.TabIndex = 33
        Label3.Text = "Cartão"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormaChequeLabel
        '
        FormaChequeLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormaChequeLabel.Location = New System.Drawing.Point(213, 46)
        FormaChequeLabel.Name = "FormaChequeLabel"
        FormaChequeLabel.Size = New System.Drawing.Size(81, 13)
        FormaChequeLabel.TabIndex = 20
        FormaChequeLabel.Text = "Parcelamento"
        FormaChequeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChequeLabel
        '
        ChequeLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChequeLabel.Location = New System.Drawing.Point(10, 45)
        ChequeLabel.Name = "ChequeLabel"
        ChequeLabel.Size = New System.Drawing.Size(67, 13)
        ChequeLabel.TabIndex = 19
        ChequeLabel.Text = "Valor Total"
        ChequeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BancoLabel
        '
        BancoLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BancoLabel.Location = New System.Drawing.Point(407, 46)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(40, 13)
        BancoLabel.TabIndex = 21
        BancoLabel.Text = "Banco"
        BancoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(19, 45)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(45, 13)
        Label4.TabIndex = 21
        Label4.Text = "Cliente"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(17, 68)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(47, 17)
        Label5.TabIndex = 22
        Label5.Text = "Custo"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(150, 71)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(35, 13)
        Label6.TabIndex = 23
        Label6.Text = "Valor"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(265, 68)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(59, 18)
        Label7.TabIndex = 25
        Label7.Text = "Comissão"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(18, 92)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(47, 17)
        Label8.TabIndex = 27
        Label8.Text = "Obs."
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(186, 23)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(62, 13)
        Label9.TabIndex = 29
        Label9.Text = "Vendedor"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(204, 650)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(67, 13)
        Label10.TabIndex = 25
        Label10.Text = "Dólar"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(204, 674)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(67, 13)
        Label11.TabIndex = 30
        Label11.Text = "Cash"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(439, 650)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(67, 13)
        Label12.TabIndex = 33
        Label12.Text = "Ouro"
        Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(439, 674)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(67, 13)
        Label13.TabIndex = 36
        Label13.Text = "Débito C/C"
        Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.ForeColor = System.Drawing.Color.Black
        Label14.Location = New System.Drawing.Point(1121, 676)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(80, 18)
        Label14.TabIndex = 38
        Label14.Text = "Valor Final"
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.Location = New System.Drawing.Point(22, 55)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(58, 16)
        Label15.TabIndex = 35
        Label15.Text = "Débito:"
        Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.Location = New System.Drawing.Point(220, 56)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(42, 13)
        Label16.TabIndex = 37
        Label16.Text = "Cartão"
        Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BancoTransfLabel
        '
        BancoTransfLabel.AutoSize = True
        BancoTransfLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BancoTransfLabel.Location = New System.Drawing.Point(790, 675)
        BancoTransfLabel.Name = "BancoTransfLabel"
        BancoTransfLabel.Size = New System.Drawing.Size(43, 17)
        BancoTransfLabel.TabIndex = 46
        BancoTransfLabel.Text = "Banco"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label17.Location = New System.Drawing.Point(695, 645)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(138, 17)
        Label17.TabIndex = 45
        Label17.Text = "Transferência Bancária"
        '
        'Label22
        '
        Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label22.Location = New System.Drawing.Point(975, 345)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(71, 17)
        Label22.TabIndex = 49
        Label22.Text = "AUT. Créd."
        Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Label23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label23.Location = New System.Drawing.Point(1184, 345)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(71, 17)
        Label23.TabIndex = 51
        Label23.Text = "AUT. Déb."
        Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnSalvar, Me.btnUndo, Me.btnLancaCC, Me.btnCompras, Me.btnPeçasCompradas, Me.btnDel, Me.btnAtual2})
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
        ToolTipItem5.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem5.ImageOptions.ImageUri.Uri = "snap/snapdeletelist;Size16x16"
        ToolTipItem5.Text = "<b>EXCLUIR CONSERTO</b>"
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.btnDel.SuperTip = SuperToolTip5
        Me.btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        '
        'btnAtual2
        '
        Me.btnAtual2.Caption = "Atualizar valores"
        Me.btnAtual2.Id = 11
        Me.btnAtual2.ImageOptions.Image = CType(resources.GetObject("btnAtual2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAtual2.ImageOptions.LargeImage = CType(resources.GetObject("btnAtual2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAtual2.Name = "btnAtual2"
        ToolTipItem6.ImageOptions.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipItem6.Text = "Refaz os lançamentos das parcelas de cheques e cartão de crédito/débito e o cálcu" &
    "lo do valor final"
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.btnAtual2.SuperTip = SuperToolTip6
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2, Me.ribAtual})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "CONSERTOS"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnDel)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnFechar)
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
        'ribAtual
        '
        Me.ribAtual.ItemLinks.Add(Me.btnAtual2)
        Me.ribAtual.Name = "ribAtual"
        '
        'lblCliente
        '
        Me.lblCliente.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblCliente.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCliente.Appearance.Options.UseFont = True
        Me.lblCliente.Appearance.Options.UseForeColor = True
        Me.lblCliente.Appearance.Options.UseImageAlign = True
        Me.lblCliente.Appearance.Options.UseTextOptions = True
        Me.lblCliente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCliente.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCliente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCliente.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.lblCliente.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.lblCliente.Location = New System.Drawing.Point(453, 157)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(432, 23)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Consertos"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CartõesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Conta_CorrenteTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pepe.dsCCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager.Vencto_ChequesTableAdapter = Nothing
        '
        'DataDateEdit
        '
        Me.DataDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "DT", True))
        Me.DataDateEdit.EditValue = Nothing
        Me.DataDateEdit.Location = New System.Drawing.Point(67, 18)
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
        Me.DataDateEdit.Size = New System.Drawing.Size(94, 22)
        Me.DataDateEdit.TabIndex = 0
        '
        'CONSERTOSBindingSource
        '
        Me.CONSERTOSBindingSource.DataMember = "CONSERTOS"
        Me.CONSERTOSBindingSource.DataSource = Me.DsGeral
        Me.CONSERTOSBindingSource.Sort = "DT Desc, Cliente Asc"
        '
        'DsGeral
        '
        Me.DsGeral.DataSetName = "dsGeral"
        Me.DsGeral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupControlCARTAO
        '
        Me.GroupControlCARTAO.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControlCARTAO.AppearanceCaption.ForeColor = System.Drawing.Color.Yellow
        Me.GroupControlCARTAO.AppearanceCaption.Options.UseFont = True
        Me.GroupControlCARTAO.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControlCARTAO.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControlCARTAO.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControlCARTAO.Controls.Add(Label16)
        Me.GroupControlCARTAO.Controls.Add(Me.txtNomeCartãoDébito)
        Me.GroupControlCARTAO.Controls.Add(Me.txtDebito)
        Me.GroupControlCARTAO.Controls.Add(Label15)
        Me.GroupControlCARTAO.Controls.Add(Me.Vencto_CartãoGridControl)
        Me.GroupControlCARTAO.Controls.Add(Label3)
        Me.GroupControlCARTAO.Controls.Add(Me.txtNomeCartao)
        Me.GroupControlCARTAO.Controls.Add(Me.txtCCCartao)
        Me.GroupControlCARTAO.Controls.Add(Me.txtFormaCartao)
        Me.GroupControlCARTAO.Controls.Add(Label2)
        Me.GroupControlCARTAO.Controls.Add(Me.txtValorCartao)
        Me.GroupControlCARTAO.Controls.Add(Label1)
        Me.GroupControlCARTAO.Controls.Add(Me.btnAtual)
        ButtonImageOptions3.Image = CType(resources.GetObject("ButtonImageOptions3.Image"), System.Drawing.Image)
        ButtonImageOptions3.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.BeforeText
        ToolTipItem7.ImageOptions.ImageUri.Uri = "snap/snapdeletelist;Size16x16"
        ToolTipItem7.Text = "Exclui dados do cartão"
        SuperToolTip7.Items.Add(ToolTipItem7)
        Me.GroupControlCARTAO.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", True, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, SuperToolTip7, True, False, True, Nothing, -1)})
        Me.GroupControlCARTAO.Location = New System.Drawing.Point(696, 396)
        Me.GroupControlCARTAO.Name = "GroupControlCARTAO"
        Me.GroupControlCARTAO.Size = New System.Drawing.Size(593, 238)
        Me.GroupControlCARTAO.TabIndex = 2
        Me.GroupControlCARTAO.Text = "CARTÃO"
        '
        'txtNomeCartãoDébito
        '
        Me.txtNomeCartãoDébito.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "NomeCartãoDébito", True))
        Me.txtNomeCartãoDébito.Location = New System.Drawing.Point(264, 52)
        Me.txtNomeCartãoDébito.MenuManager = Me.ribbonControl1
        Me.txtNomeCartãoDébito.Name = "txtNomeCartãoDébito"
        Me.txtNomeCartãoDébito.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCartãoDébito.Properties.Appearance.Options.UseFont = True
        Me.txtNomeCartãoDébito.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtNomeCartãoDébito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNomeCartãoDébito.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ncartao", "Cartão", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Perc", "Perc", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.txtNomeCartãoDébito.Properties.DataSource = Me.CartõesBindingSource
        Me.txtNomeCartãoDébito.Properties.DisplayMember = "Ncartao"
        Me.txtNomeCartãoDébito.Properties.DropDownRows = 21
        Me.txtNomeCartãoDébito.Properties.NullText = ""
        Me.txtNomeCartãoDébito.Properties.ValueMember = "Ncartao"
        Me.txtNomeCartãoDébito.Size = New System.Drawing.Size(105, 22)
        Me.txtNomeCartãoDébito.TabIndex = 4
        '
        'CartõesBindingSource
        '
        Me.CartõesBindingSource.DataMember = "Cartões"
        Me.CartõesBindingSource.DataSource = Me.DsGeral
        '
        'txtDebito
        '
        Me.txtDebito.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "Debito", True))
        Me.txtDebito.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDebito.Location = New System.Drawing.Point(82, 51)
        Me.txtDebito.MenuManager = Me.ribbonControl1
        Me.txtDebito.Name = "txtDebito"
        Me.txtDebito.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebito.Properties.Appearance.Options.UseFont = True
        Me.txtDebito.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDebito.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDebito.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDebito.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtDebito.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebito.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtDebito.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebito.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtDebito.Properties.Mask.EditMask = "n"
        Me.txtDebito.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebito.Size = New System.Drawing.Size(68, 22)
        Me.txtDebito.TabIndex = 3
        '
        'Vencto_CartãoGridControl
        '
        Me.Vencto_CartãoGridControl.DataSource = Me.CONSERTOSVenctoCartãoBindingSource
        Me.Vencto_CartãoGridControl.Location = New System.Drawing.Point(83, 79)
        Me.Vencto_CartãoGridControl.MainView = Me.GridView2
        Me.Vencto_CartãoGridControl.MenuManager = Me.ribbonControl1
        Me.Vencto_CartãoGridControl.Name = "Vencto_CartãoGridControl"
        Me.Vencto_CartãoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.Vencto_CartãoGridControl.Size = New System.Drawing.Size(426, 154)
        Me.Vencto_CartãoGridControl.TabIndex = 3
        Me.Vencto_CartãoGridControl.TabStop = False
        Me.Vencto_CartãoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'CONSERTOSVenctoCartãoBindingSource
        '
        Me.CONSERTOSVenctoCartãoBindingSource.DataMember = "CONSERTOS_Vencto Cartão"
        Me.CONSERTOSVenctoCartãoBindingSource.DataSource = Me.CONSERTOSBindingSource
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1, Me.colParcela1, Me.colVencto1, Me.colVValor1, Me.colNomeCartão, Me.colIdCC1, Me.colIdConserto})
        Me.GridView2.GridControl = Me.Vencto_CartãoGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.NewItemRowText = "Clique para adicionar"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsEditForm.EditFormColumnCount = 1
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colId1
        '
        Me.colId1.FieldName = "Id"
        Me.colId1.Name = "colId1"
        Me.colId1.OptionsColumn.AllowEdit = False
        Me.colId1.OptionsColumn.ReadOnly = True
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
        Me.colParcela1.OptionsColumn.ReadOnly = True
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
        Me.colVencto1.OptionsColumn.ReadOnly = True
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
        Me.colVValor1.OptionsColumn.ReadOnly = True
        Me.colVValor1.Visible = True
        Me.colVValor1.VisibleIndex = 2
        Me.colVValor1.Width = 94
        '
        'colNomeCartão
        '
        Me.colNomeCartão.AppearanceHeader.Options.UseTextOptions = True
        Me.colNomeCartão.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNomeCartão.Caption = "Cartão"
        Me.colNomeCartão.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colNomeCartão.FieldName = "NomeCartão"
        Me.colNomeCartão.Name = "colNomeCartão"
        Me.colNomeCartão.OptionsColumn.AllowEdit = False
        Me.colNomeCartão.OptionsColumn.ReadOnly = True
        Me.colNomeCartão.Visible = True
        Me.colNomeCartão.VisibleIndex = 3
        Me.colNomeCartão.Width = 156
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ncartao", "Cartão", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Perc", "Name2", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.CartõesBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Ncartao"
        Me.RepositoryItemLookUpEdit1.DropDownRows = 21
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "Ncartao"
        '
        'colIdCC1
        '
        Me.colIdCC1.FieldName = "IdCC"
        Me.colIdCC1.Name = "colIdCC1"
        Me.colIdCC1.OptionsColumn.AllowEdit = False
        Me.colIdCC1.OptionsColumn.ReadOnly = True
        '
        'colIdConserto
        '
        Me.colIdConserto.FieldName = "IdConserto"
        Me.colIdConserto.Name = "colIdConserto"
        Me.colIdConserto.OptionsColumn.AllowEdit = False
        Me.colIdConserto.OptionsColumn.ReadOnly = True
        '
        'txtNomeCartao
        '
        Me.txtNomeCartao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "NomeCartão", True))
        Me.txtNomeCartao.Location = New System.Drawing.Point(264, 27)
        Me.txtNomeCartao.MenuManager = Me.ribbonControl1
        Me.txtNomeCartao.Name = "txtNomeCartao"
        Me.txtNomeCartao.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCartao.Properties.Appearance.Options.UseFont = True
        Me.txtNomeCartao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtNomeCartao.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNomeCartao.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ncartao", "Cartão", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Perc", "Perc", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.txtNomeCartao.Properties.DataSource = Me.CartõesBindingSource
        Me.txtNomeCartao.Properties.DisplayMember = "Ncartao"
        Me.txtNomeCartao.Properties.DropDownRows = 21
        Me.txtNomeCartao.Properties.NullText = ""
        Me.txtNomeCartao.Properties.ValueMember = "Ncartao"
        Me.txtNomeCartao.Size = New System.Drawing.Size(105, 22)
        Me.txtNomeCartao.TabIndex = 1
        '
        'txtCCCartao
        '
        Me.txtCCCartao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "CartãoCC", True))
        Me.txtCCCartao.Location = New System.Drawing.Point(158, 29)
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
        Me.txtFormaCartao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "FormaCartão", True))
        Me.txtFormaCartao.Location = New System.Drawing.Point(486, 27)
        Me.txtFormaCartao.MenuManager = Me.ribbonControl1
        Me.txtFormaCartao.Name = "txtFormaCartao"
        Me.txtFormaCartao.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormaCartao.Properties.Appearance.Options.UseFont = True
        Me.txtFormaCartao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtFormaCartao.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFormaCartao.Properties.Items.AddRange(New Object() {"A vista", "2x", "3x", "4x", "5x", "6x"})
        Me.txtFormaCartao.Size = New System.Drawing.Size(79, 22)
        Me.txtFormaCartao.TabIndex = 2
        '
        'txtValorCartao
        '
        Me.txtValorCartao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "Cartão", True))
        Me.txtValorCartao.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorCartao.Location = New System.Drawing.Point(82, 27)
        Me.txtValorCartao.MenuManager = Me.ribbonControl1
        Me.txtValorCartao.Name = "txtValorCartao"
        Me.txtValorCartao.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorCartao.Properties.Appearance.Options.UseFont = True
        Me.txtValorCartao.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorCartao.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorCartao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtValorCartao.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtValorCartao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorCartao.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtValorCartao.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorCartao.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtValorCartao.Properties.Mask.EditMask = "n"
        Me.txtValorCartao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorCartao.Size = New System.Drawing.Size(68, 22)
        Me.txtValorCartao.TabIndex = 0
        '
        'btnAtual
        '
        Me.btnAtual.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtual.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnAtual.Appearance.Options.UseFont = True
        Me.btnAtual.Appearance.Options.UseForeColor = True
        Me.btnAtual.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAtual.Location = New System.Drawing.Point(88, 184)
        Me.btnAtual.Name = "btnAtual"
        Me.btnAtual.Size = New System.Drawing.Size(116, 31)
        Me.btnAtual.TabIndex = 40
        Me.btnAtual.TabStop = False
        Me.btnAtual.Text = "Atualizar valores"
        '
        'IDTextEdit
        '
        Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "ID", True))
        Me.IDTextEdit.Location = New System.Drawing.Point(682, 159)
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
        'BancoTextEdit
        '
        Me.BancoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "Banco", True))
        Me.BancoTextEdit.Location = New System.Drawing.Point(451, 41)
        Me.BancoTextEdit.MenuManager = Me.ribbonControl1
        Me.BancoTextEdit.Name = "BancoTextEdit"
        Me.BancoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BancoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.BancoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BancoTextEdit.Size = New System.Drawing.Size(159, 22)
        Me.BancoTextEdit.TabIndex = 2
        '
        'ChequeSpinEdit
        '
        Me.ChequeSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "Cheque", True))
        Me.ChequeSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ChequeSpinEdit.Location = New System.Drawing.Point(81, 41)
        Me.ChequeSpinEdit.MenuManager = Me.ribbonControl1
        Me.ChequeSpinEdit.Name = "ChequeSpinEdit"
        Me.ChequeSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChequeSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.ChequeSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.ChequeSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ChequeSpinEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ChequeSpinEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.ChequeSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ChequeSpinEdit.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.ChequeSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ChequeSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.ChequeSpinEdit.Properties.Mask.EditMask = "n"
        Me.ChequeSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.ChequeSpinEdit.Size = New System.Drawing.Size(68, 22)
        Me.ChequeSpinEdit.TabIndex = 0
        '
        'FormaChequeComboBoxEdit
        '
        Me.FormaChequeComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "FormaCheque", True))
        Me.FormaChequeComboBoxEdit.Location = New System.Drawing.Point(297, 41)
        Me.FormaChequeComboBoxEdit.MenuManager = Me.ribbonControl1
        Me.FormaChequeComboBoxEdit.Name = "FormaChequeComboBoxEdit"
        Me.FormaChequeComboBoxEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormaChequeComboBoxEdit.Properties.Appearance.Options.UseFont = True
        Me.FormaChequeComboBoxEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.FormaChequeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FormaChequeComboBoxEdit.Properties.Items.AddRange(New Object() {"A vista", "2x", "3x", "4x", "5x", "6x"})
        Me.FormaChequeComboBoxEdit.Size = New System.Drawing.Size(89, 22)
        Me.FormaChequeComboBoxEdit.TabIndex = 1
        '
        'ChequeCCCheckEdit
        '
        Me.ChequeCCCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "ChequeCC", True))
        Me.ChequeCCCheckEdit.Location = New System.Drawing.Point(153, 43)
        Me.ChequeCCCheckEdit.MenuManager = Me.ribbonControl1
        Me.ChequeCCCheckEdit.Name = "ChequeCCCheckEdit"
        Me.ChequeCCCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChequeCCCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.ChequeCCCheckEdit.Properties.Caption = "C.C."
        Me.ChequeCCCheckEdit.Size = New System.Drawing.Size(46, 20)
        Me.ChequeCCCheckEdit.TabIndex = 23
        Me.ChequeCCCheckEdit.TabStop = False
        '
        'Vencto_ChequesGridControl
        '
        Me.Vencto_ChequesGridControl.DataSource = Me.CONSERTOSVenctoChequesBindingSource
        Me.Vencto_ChequesGridControl.Location = New System.Drawing.Point(6, 79)
        Me.Vencto_ChequesGridControl.MainView = Me.GridView1
        Me.Vencto_ChequesGridControl.MenuManager = Me.ribbonControl1
        Me.Vencto_ChequesGridControl.Name = "Vencto_ChequesGridControl"
        Me.Vencto_ChequesGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1})
        Me.Vencto_ChequesGridControl.Size = New System.Drawing.Size(607, 154)
        Me.Vencto_ChequesGridControl.TabIndex = 3
        Me.Vencto_ChequesGridControl.TabStop = False
        Me.Vencto_ChequesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CONSERTOSVenctoChequesBindingSource
        '
        Me.CONSERTOSVenctoChequesBindingSource.DataMember = "CONSERTOS_Vencto Cheques"
        Me.CONSERTOSVenctoChequesBindingSource.DataSource = Me.CONSERTOSBindingSource
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
        Me.colVValor.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colVValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colVValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVValor.FieldName = "VValor"
        Me.colVValor.Name = "colVValor"
        Me.colVValor.Visible = True
        Me.colVValor.VisibleIndex = 2
        Me.colVValor.Width = 84
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions5, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject17, SerializableAppearanceObject18, SerializableAppearanceObject19, SerializableAppearanceObject20, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.RepositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "n2"
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
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
        'GroupControlCHEQUES
        '
        Me.GroupControlCHEQUES.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControlCHEQUES.AppearanceCaption.ForeColor = System.Drawing.Color.Yellow
        Me.GroupControlCHEQUES.AppearanceCaption.Options.UseFont = True
        Me.GroupControlCHEQUES.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControlCHEQUES.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControlCHEQUES.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControlCHEQUES.Controls.Add(Me.Vencto_ChequesGridControl)
        Me.GroupControlCHEQUES.Controls.Add(Me.ChequeCCCheckEdit)
        Me.GroupControlCHEQUES.Controls.Add(Me.FormaChequeComboBoxEdit)
        Me.GroupControlCHEQUES.Controls.Add(BancoLabel)
        Me.GroupControlCHEQUES.Controls.Add(Me.ChequeSpinEdit)
        Me.GroupControlCHEQUES.Controls.Add(Me.BancoTextEdit)
        Me.GroupControlCHEQUES.Controls.Add(ChequeLabel)
        Me.GroupControlCHEQUES.Controls.Add(FormaChequeLabel)
        ButtonImageOptions1.Image = CType(resources.GetObject("ButtonImageOptions1.Image"), System.Drawing.Image)
        ToolTipItem3.ImageOptions.ImageUri.Uri = "snap/snapdeletelist;Size16x16"
        ToolTipItem3.Text = "Exclui dados do(s) cheque(s)"
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.GroupControlCHEQUES.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, SuperToolTip3, True, False, True, Nothing, -1)})
        Me.GroupControlCHEQUES.Location = New System.Drawing.Point(49, 396)
        Me.GroupControlCHEQUES.Name = "GroupControlCHEQUES"
        Me.GroupControlCHEQUES.Size = New System.Drawing.Size(620, 238)
        Me.GroupControlCHEQUES.TabIndex = 1
        Me.GroupControlCHEQUES.Text = "CHEQUES"
        '
        'GroupControl
        '
        Me.GroupControl.Controls.Add(Label9)
        Me.GroupControl.Controls.Add(Me.txtVendedor)
        Me.GroupControl.Controls.Add(Label8)
        Me.GroupControl.Controls.Add(Me.txtObs)
        Me.GroupControl.Controls.Add(Label7)
        Me.GroupControl.Controls.Add(Me.txtCom)
        Me.GroupControl.Controls.Add(Label6)
        Me.GroupControl.Controls.Add(Label5)
        Me.GroupControl.Controls.Add(Label4)
        Me.GroupControl.Controls.Add(Me.txtValor)
        Me.GroupControl.Controls.Add(Me.txtCusto)
        Me.GroupControl.Controls.Add(Me.cboCliente)
        Me.GroupControl.Controls.Add(Me.DataDateEdit)
        Me.GroupControl.Controls.Add(DataLabel)
        Me.GroupControl.Location = New System.Drawing.Point(464, 201)
        Me.GroupControl.Name = "GroupControl"
        Me.GroupControl.ShowCaption = False
        Me.GroupControl.Size = New System.Drawing.Size(411, 176)
        Me.GroupControl.TabIndex = 0
        '
        'txtVendedor
        '
        Me.txtVendedor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "VENDEDORA", True))
        Me.txtVendedor.Location = New System.Drawing.Point(252, 18)
        Me.txtVendedor.MenuManager = Me.ribbonControl1
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendedor.Properties.Appearance.Options.UseFont = True
        Me.txtVendedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtVendedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtVendedor.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID Vendedora", "ID Vendedora", 99, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendedora", "Vendedores", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.txtVendedor.Properties.DataSource = Me.VendedorasBindingSource
        Me.txtVendedor.Properties.DisplayMember = "Vendedora"
        Me.txtVendedor.Properties.DropDownRows = 16
        Me.txtVendedor.Properties.NullText = ""
        Me.txtVendedor.Properties.ValueMember = "ID Vendedora"
        Me.txtVendedor.Size = New System.Drawing.Size(132, 22)
        Me.txtVendedor.TabIndex = 1
        '
        'VendedorasBindingSource
        '
        Me.VendedorasBindingSource.DataMember = "Vendedoras"
        Me.VendedorasBindingSource.DataSource = Me.DsGeral
        '
        'txtObs
        '
        Me.txtObs.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "OBS", True))
        Me.txtObs.EditValue = ""
        Me.txtObs.Location = New System.Drawing.Point(67, 90)
        Me.txtObs.MenuManager = Me.ribbonControl1
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.Properties.Appearance.Options.UseFont = True
        Me.txtObs.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtObs.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtObs.Size = New System.Drawing.Size(317, 62)
        Me.txtObs.TabIndex = 6
        '
        'txtCom
        '
        Me.txtCom.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "COMISSÃO", True))
        Me.txtCom.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCom.Location = New System.Drawing.Point(326, 66)
        Me.txtCom.MenuManager = Me.ribbonControl1
        Me.txtCom.Name = "txtCom"
        Me.txtCom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCom.Properties.Appearance.Options.UseFont = True
        Me.txtCom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions6, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject21, SerializableAppearanceObject22, SerializableAppearanceObject23, SerializableAppearanceObject24, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtCom.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtCom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCom.Properties.Mask.EditMask = "n2"
        Me.txtCom.Size = New System.Drawing.Size(58, 22)
        Me.txtCom.TabIndex = 5
        '
        'txtValor
        '
        Me.txtValor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "VVALOR", True))
        Me.txtValor.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValor.Location = New System.Drawing.Point(186, 66)
        Me.txtValor.MenuManager = Me.ribbonControl1
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtValor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtValor.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValor.Properties.Mask.EditMask = "n2"
        Me.txtValor.Size = New System.Drawing.Size(68, 22)
        Me.txtValor.TabIndex = 4
        '
        'txtCusto
        '
        Me.txtCusto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "Custo", True))
        Me.txtCusto.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCusto.Location = New System.Drawing.Point(67, 66)
        Me.txtCusto.MenuManager = Me.ribbonControl1
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusto.Properties.Appearance.Options.UseFont = True
        Me.txtCusto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCusto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtCusto.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtCusto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCusto.Properties.Mask.EditMask = "n2"
        Me.txtCusto.Size = New System.Drawing.Size(66, 22)
        Me.txtCusto.TabIndex = 3
        '
        'cboCliente
        '
        Me.cboCliente.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "CLIENTE", True))
        Me.cboCliente.Location = New System.Drawing.Point(67, 42)
        Me.cboCliente.MenuManager = Me.ribbonControl1
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.Properties.Appearance.Options.UseFont = True
        Me.cboCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cboCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCliente.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cli", "Clientes", 34, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCliente", "ID Cliente", 57, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboCliente.Properties.DataSource = Me.CboClientesBindingSource
        Me.cboCliente.Properties.DisplayMember = "Cli"
        Me.cboCliente.Properties.DropDownRows = 16
        Me.cboCliente.Properties.NullText = ""
        Me.cboCliente.Properties.ValueMember = "IDCliente"
        Me.cboCliente.Size = New System.Drawing.Size(317, 22)
        Me.cboCliente.TabIndex = 2
        '
        'CboClientesBindingSource
        '
        Me.CboClientesBindingSource.DataMember = "cboClientes"
        Me.CboClientesBindingSource.DataSource = Me.DsGeral
        '
        'CONSERTOSTableAdapter
        '
        Me.CONSERTOSTableAdapter.ClearBeforeFill = True
        '
        'CboClientesTableAdapter
        '
        Me.CboClientesTableAdapter.ClearBeforeFill = True
        '
        'VendedorasTableAdapter
        '
        Me.VendedorasTableAdapter.ClearBeforeFill = True
        '
        'Vencto_ChequesTableAdapter1
        '
        Me.Vencto_ChequesTableAdapter1.ClearBeforeFill = True
        '
        'CartõesTableAdapter1
        '
        Me.CartõesTableAdapter1.ClearBeforeFill = True
        '
        'Vencto_CartãoTableAdapter1
        '
        Me.Vencto_CartãoTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CartõesTableAdapter = Me.CartõesTableAdapter1
        Me.TableAdapterManager1.cboClientesTableAdapter = Me.CboClientesTableAdapter
        Me.TableAdapterManager1.ClientesTableAdapter = Nothing
        Me.TableAdapterManager1.CONSERTOSTableAdapter = Me.CONSERTOSTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Pepe.dsGeralTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.Vencto_CartãoTableAdapter = Me.Vencto_CartãoTableAdapter1
        Me.TableAdapterManager1.Vencto_ChequesTableAdapter = Me.Vencto_ChequesTableAdapter1
        Me.TableAdapterManager1.VendedorasTableAdapter = Me.VendedorasTableAdapter
        '
        'ckDolarCC
        '
        Me.ckDolarCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "DolarCC", True))
        Me.ckDolarCC.Location = New System.Drawing.Point(347, 648)
        Me.ckDolarCC.MenuManager = Me.ribbonControl1
        Me.ckDolarCC.Name = "ckDolarCC"
        Me.ckDolarCC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckDolarCC.Properties.Appearance.Options.UseFont = True
        Me.ckDolarCC.Properties.Caption = "C.C."
        Me.ckDolarCC.Size = New System.Drawing.Size(46, 20)
        Me.ckDolarCC.TabIndex = 26
        Me.ckDolarCC.TabStop = False
        '
        'txtDolar
        '
        Me.txtDolar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "Dolar", True))
        Me.txtDolar.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDolar.Location = New System.Drawing.Point(275, 646)
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
        Me.txtDolar.TabIndex = 24
        '
        'ckCashCC
        '
        Me.ckCashCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "CashCC", True))
        Me.ckCashCC.Location = New System.Drawing.Point(347, 672)
        Me.ckCashCC.MenuManager = Me.ribbonControl1
        Me.ckCashCC.Name = "ckCashCC"
        Me.ckCashCC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckCashCC.Properties.Appearance.Options.UseFont = True
        Me.ckCashCC.Properties.Caption = "C.C."
        Me.ckCashCC.Size = New System.Drawing.Size(46, 20)
        Me.ckCashCC.TabIndex = 31
        Me.ckCashCC.TabStop = False
        '
        'txtCash
        '
        Me.txtCash.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "Real", True))
        Me.txtCash.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCash.Location = New System.Drawing.Point(275, 670)
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
        Me.txtCash.TabIndex = 29
        '
        'ckOuroCC
        '
        Me.ckOuroCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "OuroCC", True))
        Me.ckOuroCC.Location = New System.Drawing.Point(582, 648)
        Me.ckOuroCC.MenuManager = Me.ribbonControl1
        Me.ckOuroCC.Name = "ckOuroCC"
        Me.ckOuroCC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckOuroCC.Properties.Appearance.Options.UseFont = True
        Me.ckOuroCC.Properties.Caption = "C.C."
        Me.ckOuroCC.Size = New System.Drawing.Size(46, 20)
        Me.ckOuroCC.TabIndex = 34
        Me.ckOuroCC.TabStop = False
        '
        'txtOuro
        '
        Me.txtOuro.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "Ouro", True))
        Me.txtOuro.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOuro.Location = New System.Drawing.Point(510, 646)
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
        Me.txtOuro.TabIndex = 32
        '
        'txtDebCC
        '
        Me.txtDebCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "CCDeb", True))
        Me.txtDebCC.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDebCC.Location = New System.Drawing.Point(510, 670)
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
        Me.txtDebCC.TabIndex = 35
        '
        'txtValorFinal
        '
        Me.txtValorFinal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "ValorFinal", True))
        Me.txtValorFinal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorFinal.Location = New System.Drawing.Point(1205, 671)
        Me.txtValorFinal.MenuManager = Me.ribbonControl1
        Me.txtValorFinal.Name = "txtValorFinal"
        Me.txtValorFinal.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorFinal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtValorFinal.Properties.Appearance.Options.UseFont = True
        Me.txtValorFinal.Properties.Appearance.Options.UseForeColor = True
        Me.txtValorFinal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorFinal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorFinal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtValorFinal.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtValorFinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorFinal.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtValorFinal.Properties.Mask.EditMask = "n"
        Me.txtValorFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorFinal.Properties.ReadOnly = True
        Me.txtValorFinal.Size = New System.Drawing.Size(84, 26)
        Me.txtValorFinal.TabIndex = 37
        Me.txtValorFinal.TabStop = False
        '
        'Timer
        '
        Me.Timer.Interval = 1000
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
        Me.dnConsertos.DataSource = Me.CONSERTOSBindingSource
        Me.dnConsertos.Location = New System.Drawing.Point(2, 700)
        Me.dnConsertos.Name = "dnConsertos"
        Me.dnConsertos.Size = New System.Drawing.Size(190, 20)
        Me.dnConsertos.TabIndex = 40
        Me.dnConsertos.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.dnConsertos.TextStringFormat = "{0}/{1}"
        '
        'ckNavegar
        '
        Me.ckNavegar.Location = New System.Drawing.Point(1, 670)
        Me.ckNavegar.MenuManager = Me.ribbonControl1
        Me.ckNavegar.Name = "ckNavegar"
        Me.ckNavegar.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.ckNavegar.Properties.Appearance.Options.UseForeColor = True
        Me.ckNavegar.Properties.Caption = "Navegar"
        Me.ckNavegar.Size = New System.Drawing.Size(75, 20)
        Me.ckNavegar.TabIndex = 41
        Me.ckNavegar.Visible = False
        '
        'txtBancoTransf
        '
        Me.txtBancoTransf.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "BancoTransfC", True))
        Me.txtBancoTransf.Location = New System.Drawing.Point(837, 669)
        Me.txtBancoTransf.MenuManager = Me.ribbonControl1
        Me.txtBancoTransf.Name = "txtBancoTransf"
        Me.txtBancoTransf.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBancoTransf.Properties.Appearance.Options.UseFont = True
        Me.txtBancoTransf.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBancoTransf.Size = New System.Drawing.Size(211, 26)
        Me.txtBancoTransf.TabIndex = 44
        '
        'txtTransf
        '
        Me.txtTransf.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "ValorTransfC", True))
        Me.txtTransf.EditValue = "0,00"
        Me.txtTransf.Location = New System.Drawing.Point(837, 641)
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
        Me.txtTransf.TabIndex = 43
        '
        'txtAUT
        '
        Me.txtAUT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "Aut", True))
        Me.txtAUT.Location = New System.Drawing.Point(969, 366)
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
        Me.txtAUT.TabIndex = 48
        '
        'txtAUTDeb
        '
        Me.txtAUTDeb.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONSERTOSBindingSource, "AutDeb", True))
        Me.txtAUTDeb.Location = New System.Drawing.Point(1178, 366)
        Me.txtAUTDeb.MenuManager = Me.ribbonControl1
        Me.txtAUTDeb.Name = "txtAUTDeb"
        Me.txtAUTDeb.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAUTDeb.Properties.Appearance.Options.UseFont = True
        Me.txtAUTDeb.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAUTDeb.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtAUTDeb.Properties.BeepOnError = True
        Me.txtAUTDeb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtAUTDeb.Properties.UseMaskAsDisplayFormat = True
        Me.txtAUTDeb.Size = New System.Drawing.Size(85, 24)
        Me.txtAUTDeb.TabIndex = 50
        '
        'btnCC2
        '
        Me.btnCC2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCC2.Appearance.Options.UseFont = True
        Me.btnCC2.ImageOptions.Image = CType(resources.GetObject("btnCC2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCC2.Location = New System.Drawing.Point(583, 669)
        Me.btnCC2.Name = "btnCC2"
        Me.btnCC2.Size = New System.Drawing.Size(63, 23)
        Me.btnCC2.TabIndex = 53
        Me.btnCC2.TabStop = False
        Me.btnCC2.Text = "C. C."
        '
        'frmConsertosfrm
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1338, 722)
        Me.Controls.Add(Me.btnCC2)
        Me.Controls.Add(Label23)
        Me.Controls.Add(Me.txtAUTDeb)
        Me.Controls.Add(Label22)
        Me.Controls.Add(Me.txtAUT)
        Me.Controls.Add(BancoTransfLabel)
        Me.Controls.Add(Label17)
        Me.Controls.Add(Me.txtBancoTransf)
        Me.Controls.Add(Me.txtTransf)
        Me.Controls.Add(Me.ckNavegar)
        Me.Controls.Add(Me.dnConsertos)
        Me.Controls.Add(Me.txtValorFinal)
        Me.Controls.Add(Label14)
        Me.Controls.Add(Me.txtDebCC)
        Me.Controls.Add(Label13)
        Me.Controls.Add(Me.ckOuroCC)
        Me.Controls.Add(Me.txtOuro)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Me.ckCashCC)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.ckDolarCC)
        Me.Controls.Add(Me.GroupControl)
        Me.Controls.Add(Me.txtDolar)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.GroupControlCARTAO)
        Me.Controls.Add(Me.GroupControlCHEQUES)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.IDTextEdit)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IconOptions.Icon = CType(resources.GetObject("frmConsertosfrm.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmConsertosfrm"
        Me.Ribbon = Me.ribbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSERTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControlCARTAO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControlCARTAO.ResumeLayout(False)
        CType(Me.txtNomeCartãoDébito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartõesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vencto_CartãoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSERTOSVenctoCartãoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomeCartao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCCCartao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormaCartao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorCartao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaChequeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeCCCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vencto_ChequesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSERTOSVenctoChequesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControlCHEQUES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControlCHEQUES.ResumeLayout(False)
        CType(Me.GroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl.ResumeLayout(False)
        CType(Me.txtVendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedorasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCusto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckDolarCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDolar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckCashCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCash.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckOuroCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOuro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckNavegar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBancoTransf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAUT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAUTDeb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnLancaCC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCompras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPeçasCompradas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TableAdapterManager As dsCCTableAdapters.TableAdapterManager
    Friend WithEvents DataDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControlCARTAO As DevExpress.XtraEditors.GroupControl
    Friend WithEvents IDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomeCartao As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCCCartao As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFormaCartao As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtValorCartao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CartõesBindingSource As BindingSource
    Friend WithEvents CartõesTableAdapter As dsCCTableAdapters.CartõesTableAdapter
    Friend WithEvents Vencto_CartãoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcela1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVValor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomeCartão As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIdCC1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BancoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChequeSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FormaChequeComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ChequeCCCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Vencto_ChequesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControlCHEQUES As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DsGeral As dsGeral
    Friend WithEvents CONSERTOSBindingSource As BindingSource
    Friend WithEvents CONSERTOSTableAdapter As dsGeralTableAdapters.CONSERTOSTableAdapter
    Friend WithEvents cboCliente As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CboClientesBindingSource As BindingSource
    Friend WithEvents CboClientesTableAdapter As dsGeralTableAdapters.cboClientesTableAdapter
    Friend WithEvents txtValor As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtCusto As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtObs As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtCom As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtVendedor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents VendedorasBindingSource As BindingSource
    Friend WithEvents VendedorasTableAdapter As dsGeralTableAdapters.VendedorasTableAdapter
    Friend WithEvents CONSERTOSVenctoChequesBindingSource As BindingSource
    Friend WithEvents Vencto_ChequesTableAdapter1 As dsGeralTableAdapters.Vencto_ChequesTableAdapter
    Friend WithEvents CartõesTableAdapter1 As dsGeralTableAdapters.CartõesTableAdapter
    Friend WithEvents CONSERTOSVenctoCartãoBindingSource As BindingSource
    Friend WithEvents Vencto_CartãoTableAdapter1 As dsGeralTableAdapters.Vencto_CartãoTableAdapter
    Friend WithEvents TableAdapterManager1 As dsGeralTableAdapters.TableAdapterManager
    Friend WithEvents ckDolarCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtDolar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckCashCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCash As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckOuroCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtOuro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDebCC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValorFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnDel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colIdConserto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNomeCartãoDébito As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDebito As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAtual As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer As Timer
    Friend WithEvents btnAtual2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ribAtual As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents dnConsertos As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents ckNavegar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtBancoTransf As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTransf As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAUT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAUTDeb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCC2 As DevExpress.XtraEditors.SimpleButton
End Class
