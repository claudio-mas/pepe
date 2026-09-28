Partial Public Class frmEstoque
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
        Dim ClasseLabel As System.Windows.Forms.Label
        Dim ModêloLabel As System.Windows.Forms.Label
        Dim DataRegLabel As System.Windows.Forms.Label
        Dim OrigemLabel As System.Windows.Forms.Label
        Dim ObsLabel As System.Windows.Forms.Label
        Dim OficialLabel As System.Windows.Forms.Label
        Dim CustoLabel As System.Windows.Forms.Label
        Dim MOExtLabel As System.Windows.Forms.Label
        Dim MOIntLabel As System.Windows.Forms.Label
        Dim CravaçãoLabel As System.Windows.Forms.Label
        Dim MadeiraLabel As System.Windows.Forms.Label
        Dim CouroLabel As System.Windows.Forms.Label
        Dim OutrasLabel As System.Windows.Forms.Label
        Dim OficinaLabel As System.Windows.Forms.Label
        Dim DataFabricLabel As System.Windows.Forms.Label
        Dim PrVendaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim LocalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstoque))
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
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCompras = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPeçasCompradas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEstornar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDel = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnComprador = New DevExpress.XtraBars.BarButtonItem()
        Me.btnVoltar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFoto = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSelFoto = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelFoto = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvarComo = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.grpEstornar = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.grpFoto = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.grpFechar = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cbLocal = New DevExpress.XtraEditors.ComboBoxEdit()
        Me._1TabPeçasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNovoEstoque = New Pepe.dsNovoEstoque()
        Me.VoltaCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.DataFabricDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.OficialCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.OrigemComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.DataRegDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ModêloTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ClasseComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ObsTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.IDPeçaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendidaCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me._1TabPeçasTableAdapter = New Pepe.dsNovoEstoqueTableAdapters._1TabPeçasTableAdapter()
        Me.TableAdapterManager = New Pepe.dsNovoEstoqueTableAdapters.TableAdapterManager()
        Me.METAISTableAdapter = New Pepe.dsNovoEstoqueTableAdapters.METAISTableAdapter()
        Me.PEDRASTableAdapter = New Pepe.dsNovoEstoqueTableAdapters.PEDRASTableAdapter()
        Me.METAISBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.METAISGridControl = New DevExpress.XtraGrid.GridControl()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colId = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colId = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colOuroQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colOuroQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colOuroV = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colOuroV = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPaladiumQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colPaladiumQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPrataQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colPrataQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPlatinaQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colPlatinaQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPerdaPerc = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colPerdaPerc = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPerdaQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colPerdaQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colSistemaQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colSistemaQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colTotalQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colTotalQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colTotalValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colTotalValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colSistemaValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colSistemaValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPaladiumV = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colPaladiumV = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPrataV = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colPrataV = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPlatinaV = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colPlatinaV = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.item1 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item2 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item3 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.item5 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item6 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.item8 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item9 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item10 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.item11 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.item15 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item16 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.txtCusto = New DevExpress.XtraEditors.TextEdit()
        Me.MOExtTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MOIntTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PEDRASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PEDRASGridControl = New DevExpress.XtraGrid.GridControl()
        Me.LayoutView2 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colId1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colDiamantesCT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colDiamantesCT = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colDiamantesQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colDiamantesQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colDiamantesValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colDiamantesValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colDiamantes2CT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colDiamantes2CT = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colDiamantes2Qtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colDiamantes2Qtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colDiamantes2Valor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colDiamantes2Valor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colBrasCT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewField1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPedrasBrasQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colPedrasBrasQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPedrasBrasValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colPedrasBrasValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPerolasCT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewField2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPerolasQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colPerolasQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPerolasValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colPerolasValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colRubisCT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewField3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colRubiQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colRubiQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colRubiValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colRubiValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colSafirasCT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewField4 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colSafiraQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colSafiraQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colSafiraValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colSafiraValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colEsmeraldasCT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewField5 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colEsmeraldaQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colEsmeraldaQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colEsmeraldaValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colEsmeraldaValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colPedrasCT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewField6 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colCitrinoQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colCitrinoQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colCitrinoValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colCitrinoValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.item12 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item13 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item14 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item17 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item18 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item19 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item20 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item21 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item22 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item23 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item25 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.item24 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.item27 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.CravaçãoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MadeiraTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CouroTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OutrasTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OficinaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PrVendaSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.btnCalc = New DevExpress.XtraEditors.SimpleButton()
        Me._1TabPeçasHistóricoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._1TabPeçasHistóricoTableAdapter = New Pepe.dsNovoEstoqueTableAdapters._1TabPeçasHistóricoTableAdapter()
        Me._1TabPeçasHistóricoGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdPeça = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataReajuste = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustoAnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colFatorC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrVendaAnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFatorV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEditPeça = New DevExpress.XtraEditors.PictureEdit()
        Me.XtraOpenFileDialogFoto = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.SizeModeSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_pFund = New DevExpress.XtraEditors.TextEdit()
        ClasseLabel = New System.Windows.Forms.Label()
        ModêloLabel = New System.Windows.Forms.Label()
        DataRegLabel = New System.Windows.Forms.Label()
        OrigemLabel = New System.Windows.Forms.Label()
        ObsLabel = New System.Windows.Forms.Label()
        OficialLabel = New System.Windows.Forms.Label()
        CustoLabel = New System.Windows.Forms.Label()
        MOExtLabel = New System.Windows.Forms.Label()
        MOIntLabel = New System.Windows.Forms.Label()
        CravaçãoLabel = New System.Windows.Forms.Label()
        MadeiraLabel = New System.Windows.Forms.Label()
        CouroLabel = New System.Windows.Forms.Label()
        OutrasLabel = New System.Windows.Forms.Label()
        OficinaLabel = New System.Windows.Forms.Label()
        DataFabricLabel = New System.Windows.Forms.Label()
        PrVendaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        LocalLabel = New System.Windows.Forms.Label()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cbLocal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._1TabPeçasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNovoEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoltaCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataFabricDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataFabricDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OficialCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrigemComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataRegDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataRegDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModêloTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClasseComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDPeçaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendidaCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.METAISBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.METAISGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colOuroQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colOuroV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPaladiumQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPrataQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPlatinaQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPerdaPerc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPerdaQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colSistemaQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colTotalQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colTotalValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colSistemaValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPaladiumV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPrataV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPlatinaV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCusto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOExtTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOIntTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEDRASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEDRASGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colId1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colDiamantesCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colDiamantesQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colDiamantesValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colDiamantes2CT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colDiamantes2Qtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colDiamantes2Valor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewField1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPedrasBrasQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPedrasBrasValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewField2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPerolasQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPerolasValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewField3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colRubiQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colRubiValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewField4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colSafiraQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colSafiraValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewField5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colEsmeraldaQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colEsmeraldaValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewField6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colCitrinoQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colCitrinoValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CravaçãoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MadeiraTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CouroTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutrasTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OficinaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrVendaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._1TabPeçasHistóricoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._1TabPeçasHistóricoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEditPeça.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeModeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClasseLabel
        '
        ClasseLabel.AutoSize = True
        ClasseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClasseLabel.Location = New System.Drawing.Point(33, 16)
        ClasseLabel.Name = "ClasseLabel"
        ClasseLabel.Size = New System.Drawing.Size(35, 15)
        ClasseLabel.TabIndex = 0
        ClasseLabel.Text = "Peça"
        '
        'ModêloLabel
        '
        ModêloLabel.AutoSize = True
        ModêloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModêloLabel.Location = New System.Drawing.Point(221, 16)
        ModêloLabel.Name = "ModêloLabel"
        ModêloLabel.Size = New System.Drawing.Size(37, 15)
        ModêloLabel.TabIndex = 2
        ModêloLabel.Text = "Ficha"
        '
        'DataRegLabel
        '
        DataRegLabel.AutoSize = True
        DataRegLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataRegLabel.Location = New System.Drawing.Point(4, 44)
        DataRegLabel.Name = "DataRegLabel"
        DataRegLabel.Size = New System.Drawing.Size(62, 15)
        DataRegLabel.TabIndex = 4
        DataRegLabel.Text = "Data Reg."
        '
        'OrigemLabel
        '
        OrigemLabel.AutoSize = True
        OrigemLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OrigemLabel.Location = New System.Drawing.Point(37, 68)
        OrigemLabel.Name = "OrigemLabel"
        OrigemLabel.Size = New System.Drawing.Size(28, 15)
        OrigemLabel.TabIndex = 6
        OrigemLabel.Text = "A/C"
        '
        'ObsLabel
        '
        ObsLabel.AutoSize = True
        ObsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsLabel.Location = New System.Drawing.Point(34, 92)
        ObsLabel.Name = "ObsLabel"
        ObsLabel.Size = New System.Drawing.Size(32, 15)
        ObsLabel.TabIndex = 8
        ObsLabel.Text = "Obs."
        '
        'OficialLabel
        '
        OficialLabel.AutoSize = True
        OficialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OficialLabel.Location = New System.Drawing.Point(138, 69)
        OficialLabel.Name = "OficialLabel"
        OficialLabel.Size = New System.Drawing.Size(18, 15)
        OficialLabel.TabIndex = 10
        OficialLabel.Text = "W"
        OficialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustoLabel
        '
        CustoLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CustoLabel.ForeColor = System.Drawing.Color.Black
        CustoLabel.Location = New System.Drawing.Point(15, 572)
        CustoLabel.Name = "CustoLabel"
        CustoLabel.Size = New System.Drawing.Size(94, 15)
        CustoLabel.TabIndex = 15
        CustoLabel.Text = "Custo"
        CustoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MOExtLabel
        '
        MOExtLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MOExtLabel.ForeColor = System.Drawing.Color.Black
        MOExtLabel.Location = New System.Drawing.Point(15, 361)
        MOExtLabel.Name = "MOExtLabel"
        MOExtLabel.Size = New System.Drawing.Size(94, 15)
        MOExtLabel.TabIndex = 16
        MOExtLabel.Text = "M. O. Ext."
        MOExtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MOIntLabel
        '
        MOIntLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MOIntLabel.ForeColor = System.Drawing.Color.Black
        MOIntLabel.Location = New System.Drawing.Point(15, 387)
        MOIntLabel.Name = "MOIntLabel"
        MOIntLabel.Size = New System.Drawing.Size(94, 15)
        MOIntLabel.TabIndex = 17
        MOIntLabel.Text = "M. O. Int."
        MOIntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CravaçãoLabel
        '
        CravaçãoLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CravaçãoLabel.ForeColor = System.Drawing.Color.Black
        CravaçãoLabel.Location = New System.Drawing.Point(15, 413)
        CravaçãoLabel.Name = "CravaçãoLabel"
        CravaçãoLabel.Size = New System.Drawing.Size(94, 15)
        CravaçãoLabel.TabIndex = 19
        CravaçãoLabel.Text = "Cravação"
        CravaçãoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MadeiraLabel
        '
        MadeiraLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MadeiraLabel.ForeColor = System.Drawing.Color.Black
        MadeiraLabel.Location = New System.Drawing.Point(15, 439)
        MadeiraLabel.Name = "MadeiraLabel"
        MadeiraLabel.Size = New System.Drawing.Size(94, 15)
        MadeiraLabel.TabIndex = 20
        MadeiraLabel.Text = "Fundição"
        MadeiraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CouroLabel
        '
        CouroLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CouroLabel.ForeColor = System.Drawing.Color.Black
        CouroLabel.Location = New System.Drawing.Point(15, 465)
        CouroLabel.Name = "CouroLabel"
        CouroLabel.Size = New System.Drawing.Size(94, 15)
        CouroLabel.TabIndex = 21
        CouroLabel.Text = "Couro"
        CouroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OutrasLabel
        '
        OutrasLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OutrasLabel.ForeColor = System.Drawing.Color.Black
        OutrasLabel.Location = New System.Drawing.Point(15, 491)
        OutrasLabel.Name = "OutrasLabel"
        OutrasLabel.Size = New System.Drawing.Size(94, 15)
        OutrasLabel.TabIndex = 22
        OutrasLabel.Text = "Outras"
        OutrasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OficinaLabel
        '
        OficinaLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OficinaLabel.ForeColor = System.Drawing.Color.Black
        OficinaLabel.Location = New System.Drawing.Point(15, 546)
        OficinaLabel.Name = "OficinaLabel"
        OficinaLabel.Size = New System.Drawing.Size(94, 15)
        OficinaLabel.TabIndex = 23
        OficinaLabel.Text = "Oficina"
        OficinaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataFabricLabel
        '
        DataFabricLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataFabricLabel.Location = New System.Drawing.Point(181, 44)
        DataFabricLabel.Name = "DataFabricLabel"
        DataFabricLabel.Size = New System.Drawing.Size(77, 13)
        DataFabricLabel.TabIndex = 28
        DataFabricLabel.Text = "Data Fabric."
        DataFabricLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrVendaLabel
        '
        PrVendaLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrVendaLabel.Location = New System.Drawing.Point(8, 600)
        PrVendaLabel.Name = "PrVendaLabel"
        PrVendaLabel.Size = New System.Drawing.Size(101, 17)
        PrVendaLabel.TabIndex = 28
        PrVendaLabel.Text = "Preço de Venda"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(180, 69)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(14, 15)
        Label1.TabIndex = 29
        Label1.Text = "V"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Black
        Label2.Location = New System.Drawing.Point(205, 417)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(42, 18)
        Label2.TabIndex = 42
        Label2.Text = "Peso"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LocalLabel
        '
        LocalLabel.AutoSize = True
        LocalLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocalLabel.Location = New System.Drawing.Point(2, 161)
        LocalLabel.Name = "LocalLabel"
        LocalLabel.Size = New System.Drawing.Size(68, 15)
        LocalLabel.TabIndex = 30
        LocalLabel.Text = "Localização"
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnNovo, Me.btnSalvar, Me.btnUndo, Me.BarButtonItem1, Me.btnCompras, Me.btnPeçasCompradas, Me.btnEstornar, Me.btnDel, Me.BarButtonItem2, Me.btnComprador, Me.btnVoltar, Me.btnFoto, Me.btnSelFoto, Me.btnDelFoto, Me.btnSalvarComo})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 19
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowToolbarCustomizeItem = False
        Me.ribbonControl1.Size = New System.Drawing.Size(1352, 158)
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
        Me.btnNovo.Caption = "Entrada"
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
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Lançamento C/C"
        Me.BarButtonItem1.Enabled = False
        Me.BarButtonItem1.Id = 7
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
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
        'btnEstornar
        '
        Me.btnEstornar.Caption = "Estornar"
        Me.btnEstornar.Id = 10
        Me.btnEstornar.ImageOptions.Image = CType(resources.GetObject("btnEstornar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEstornar.Name = "btnEstornar"
        Me.btnEstornar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnDel
        '
        Me.btnDel.Caption = "Excluir peça"
        Me.btnDel.Id = 11
        Me.btnDel.ImageOptions.Image = CType(resources.GetObject("btnDel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDel.ImageOptions.LargeImage = CType(resources.GetObject("btnDel.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDel.Name = "btnDel"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 12
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'btnComprador
        '
        Me.btnComprador.Caption = "Comprador"
        Me.btnComprador.Id = 13
        Me.btnComprador.ImageOptions.Image = Global.Pepe.My.Resources.Resources.contact_16x16
        Me.btnComprador.ImageOptions.LargeImage = Global.Pepe.My.Resources.Resources.contact_32x32
        Me.btnComprador.Name = "btnComprador"
        '
        'btnVoltar
        '
        Me.btnVoltar.Caption = "Voltar"
        Me.btnVoltar.Id = 14
        Me.btnVoltar.ImageOptions.Image = CType(resources.GetObject("btnVoltar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnVoltar.ImageOptions.LargeImage = CType(resources.GetObject("btnVoltar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnFoto
        '
        Me.btnFoto.Caption = "Capturar da webcam"
        Me.btnFoto.Id = 15
        Me.btnFoto.ImageOptions.Image = CType(resources.GetObject("btnFoto.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFoto.ImageOptions.LargeImage = CType(resources.GetObject("btnFoto.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnFoto.Name = "btnFoto"
        '
        'btnSelFoto
        '
        Me.btnSelFoto.Caption = "Selecionar do PC"
        Me.btnSelFoto.Id = 16
        Me.btnSelFoto.ImageOptions.Image = CType(resources.GetObject("btnSelFoto.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSelFoto.ImageOptions.LargeImage = CType(resources.GetObject("btnSelFoto.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSelFoto.Name = "btnSelFoto"
        '
        'btnDelFoto
        '
        Me.btnDelFoto.Caption = "Excluir foto"
        Me.btnDelFoto.Id = 17
        Me.btnDelFoto.ImageOptions.Image = CType(resources.GetObject("btnDelFoto.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelFoto.ImageOptions.LargeImage = CType(resources.GetObject("btnDelFoto.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDelFoto.Name = "btnDelFoto"
        '
        'btnSalvarComo
        '
        Me.btnSalvarComo.Caption = "Salvar como..."
        Me.btnSalvarComo.Id = 18
        Me.btnSalvarComo.ImageOptions.Image = Global.Pepe.My.Resources.Resources.saveandnew_16x16
        Me.btnSalvarComo.ImageOptions.LargeImage = Global.Pepe.My.Resources.Resources.saveandnew_32x32
        Me.btnSalvarComo.Name = "btnSalvarComo"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.grpEstornar, Me.grpFoto, Me.RibbonPageGroup2, Me.grpFechar})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "ESTOQUE"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnNovo)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnDel, True)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnSalvarComo)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnComprador, True)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        '
        'grpEstornar
        '
        Me.grpEstornar.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.grpEstornar.ItemLinks.Add(Me.btnEstornar)
        Me.grpEstornar.ItemLinks.Add(Me.btnVoltar)
        Me.grpEstornar.Name = "grpEstornar"
        Me.grpEstornar.Visible = False
        '
        'grpFoto
        '
        Me.grpFoto.ItemLinks.Add(Me.btnFoto)
        Me.grpFoto.ItemLinks.Add(Me.btnSelFoto)
        Me.grpFoto.ItemLinks.Add(Me.btnDelFoto, True)
        Me.grpFoto.Name = "grpFoto"
        Me.grpFoto.Text = "FOTO"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSalvar)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnUndo)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Visible = False
        '
        'grpFechar
        '
        Me.grpFechar.ItemLinks.Add(Me.btnFechar)
        Me.grpFechar.Name = "grpFechar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cbLocal)
        Me.PanelControl1.Controls.Add(LocalLabel)
        Me.PanelControl1.Controls.Add(Label1)
        Me.PanelControl1.Controls.Add(Me.VoltaCheckEdit)
        Me.PanelControl1.Controls.Add(DataFabricLabel)
        Me.PanelControl1.Controls.Add(OficialLabel)
        Me.PanelControl1.Controls.Add(Me.DataFabricDateEdit)
        Me.PanelControl1.Controls.Add(Me.RadioGroup1)
        Me.PanelControl1.Controls.Add(Me.OficialCheckEdit)
        Me.PanelControl1.Controls.Add(ObsLabel)
        Me.PanelControl1.Controls.Add(OrigemLabel)
        Me.PanelControl1.Controls.Add(Me.OrigemComboBoxEdit)
        Me.PanelControl1.Controls.Add(DataRegLabel)
        Me.PanelControl1.Controls.Add(Me.DataRegDateEdit)
        Me.PanelControl1.Controls.Add(ModêloLabel)
        Me.PanelControl1.Controls.Add(Me.ModêloTextEdit)
        Me.PanelControl1.Controls.Add(ClasseLabel)
        Me.PanelControl1.Controls.Add(Me.ClasseComboBoxEdit)
        Me.PanelControl1.Controls.Add(Me.ObsTextEdit)
        Me.PanelControl1.Controls.Add(Me.IDPeçaTextEdit)
        Me.PanelControl1.Controls.Add(Me.VendidaCheckEdit)
        Me.PanelControl1.Location = New System.Drawing.Point(482, 161)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(375, 190)
        Me.PanelControl1.TabIndex = 0
        '
        'cbLocal
        '
        Me.cbLocal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Local", True))
        Me.cbLocal.Location = New System.Drawing.Point(69, 156)
        Me.cbLocal.MenuManager = Me.ribbonControl1
        Me.cbLocal.Name = "cbLocal"
        Me.cbLocal.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLocal.Properties.Appearance.Options.UseFont = True
        Me.cbLocal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbLocal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLocal.Properties.DropDownRows = 3
        Me.cbLocal.Properties.Items.AddRange(New Object() {"", "Ext", "Int"})
        Me.cbLocal.Size = New System.Drawing.Size(61, 24)
        Me.cbLocal.TabIndex = 6
        '
        '_1TabPeçasBindingSource
        '
        Me._1TabPeçasBindingSource.DataMember = "1TabPeças"
        Me._1TabPeçasBindingSource.DataSource = Me.DsNovoEstoque
        '
        'DsNovoEstoque
        '
        Me.DsNovoEstoque.DataSetName = "dsNovoEstoque"
        Me.DsNovoEstoque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VoltaCheckEdit
        '
        Me.VoltaCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Volta", True))
        Me.VoltaCheckEdit.Location = New System.Drawing.Point(197, 67)
        Me.VoltaCheckEdit.MenuManager = Me.ribbonControl1
        Me.VoltaCheckEdit.Name = "VoltaCheckEdit"
        Me.VoltaCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoltaCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.VoltaCheckEdit.Properties.Caption = ""
        Me.VoltaCheckEdit.Size = New System.Drawing.Size(18, 20)
        Me.VoltaCheckEdit.TabIndex = 30
        '
        'DataFabricDateEdit
        '
        Me.DataFabricDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "DataFabric", True))
        Me.DataFabricDateEdit.EditValue = Nothing
        Me.DataFabricDateEdit.Location = New System.Drawing.Point(261, 39)
        Me.DataFabricDateEdit.MenuManager = Me.ribbonControl1
        Me.DataFabricDateEdit.Name = "DataFabricDateEdit"
        Me.DataFabricDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataFabricDateEdit.Properties.Appearance.Options.UseFont = True
        Me.DataFabricDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DataFabricDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataFabricDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataFabricDateEdit.Size = New System.Drawing.Size(101, 24)
        Me.DataFabricDateEdit.TabIndex = 3
        '
        'RadioGroup1
        '
        Me.RadioGroup1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Família", True))
        Me.RadioGroup1.Location = New System.Drawing.Point(234, 66)
        Me.RadioGroup1.MenuManager = Me.ribbonControl1
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.Appearance.Options.UseTextOptions = True
        Me.RadioGroup1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.RadioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Ag", "Ag"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Ou", "Ou"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Boutique", "Bou")})
        Me.RadioGroup1.Properties.Padding = New System.Windows.Forms.Padding(6)
        Me.RadioGroup1.Size = New System.Drawing.Size(140, 22)
        Me.RadioGroup1.TabIndex = 26
        '
        'OficialCheckEdit
        '
        Me.OficialCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Oficial", True))
        Me.OficialCheckEdit.Location = New System.Drawing.Point(158, 67)
        Me.OficialCheckEdit.MenuManager = Me.ribbonControl1
        Me.OficialCheckEdit.Name = "OficialCheckEdit"
        Me.OficialCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OficialCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.OficialCheckEdit.Properties.Caption = ""
        Me.OficialCheckEdit.Size = New System.Drawing.Size(18, 20)
        Me.OficialCheckEdit.TabIndex = 11
        '
        'OrigemComboBoxEdit
        '
        Me.OrigemComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Origem", True))
        Me.OrigemComboBoxEdit.Location = New System.Drawing.Point(69, 65)
        Me.OrigemComboBoxEdit.MenuManager = Me.ribbonControl1
        Me.OrigemComboBoxEdit.Name = "OrigemComboBoxEdit"
        Me.OrigemComboBoxEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrigemComboBoxEdit.Properties.Appearance.Options.UseFont = True
        Me.OrigemComboBoxEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.OrigemComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrigemComboBoxEdit.Properties.Items.AddRange(New Object() {"F.P.", "F.F."})
        Me.OrigemComboBoxEdit.Size = New System.Drawing.Size(61, 24)
        Me.OrigemComboBoxEdit.TabIndex = 4
        '
        'DataRegDateEdit
        '
        Me.DataRegDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "DataReg", True))
        Me.DataRegDateEdit.EditValue = Nothing
        Me.DataRegDateEdit.Location = New System.Drawing.Point(69, 39)
        Me.DataRegDateEdit.MenuManager = Me.ribbonControl1
        Me.DataRegDateEdit.Name = "DataRegDateEdit"
        Me.DataRegDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataRegDateEdit.Properties.Appearance.Options.UseFont = True
        Me.DataRegDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DataRegDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataRegDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataRegDateEdit.Size = New System.Drawing.Size(101, 24)
        Me.DataRegDateEdit.TabIndex = 2
        '
        'ModêloTextEdit
        '
        Me.ModêloTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Modêlo", True))
        Me.ModêloTextEdit.Location = New System.Drawing.Point(262, 13)
        Me.ModêloTextEdit.MenuManager = Me.ribbonControl1
        Me.ModêloTextEdit.Name = "ModêloTextEdit"
        Me.ModêloTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModêloTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ModêloTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.ModêloTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ModêloTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ModêloTextEdit.Size = New System.Drawing.Size(100, 24)
        Me.ModêloTextEdit.TabIndex = 1
        '
        'ClasseComboBoxEdit
        '
        Me.ClasseComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Classe", True))
        Me.ClasseComboBoxEdit.Location = New System.Drawing.Point(69, 13)
        Me.ClasseComboBoxEdit.MenuManager = Me.ribbonControl1
        Me.ClasseComboBoxEdit.Name = "ClasseComboBoxEdit"
        Me.ClasseComboBoxEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClasseComboBoxEdit.Properties.Appearance.Options.UseFont = True
        Me.ClasseComboBoxEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.ClasseComboBoxEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ClasseComboBoxEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ClasseComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ClasseComboBoxEdit.Properties.DropDownRows = 12
        Me.ClasseComboBoxEdit.Properties.Items.AddRange(New Object() {"AN", "BR", "GAR", "PEN", "PUL", "ALI", "OUT"})
        Me.ClasseComboBoxEdit.Size = New System.Drawing.Size(101, 24)
        Me.ClasseComboBoxEdit.TabIndex = 0
        '
        'ObsTextEdit
        '
        Me.ObsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Obs", True))
        Me.ObsTextEdit.EditValue = ""
        Me.ObsTextEdit.Location = New System.Drawing.Point(69, 91)
        Me.ObsTextEdit.MenuManager = Me.ribbonControl1
        Me.ObsTextEdit.Name = "ObsTextEdit"
        Me.ObsTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObsTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ObsTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ObsTextEdit.Properties.LinesCount = 2
        Me.ObsTextEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ObsTextEdit.Size = New System.Drawing.Size(293, 61)
        Me.ObsTextEdit.TabIndex = 5
        '
        'IDPeçaTextEdit
        '
        Me.IDPeçaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "IDPeça", True))
        Me.IDPeçaTextEdit.Location = New System.Drawing.Point(321, 95)
        Me.IDPeçaTextEdit.MenuManager = Me.ribbonControl1
        Me.IDPeçaTextEdit.Name = "IDPeçaTextEdit"
        Me.IDPeçaTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.IDPeçaTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.IDPeçaTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.IDPeçaTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.IDPeçaTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.IDPeçaTextEdit.Size = New System.Drawing.Size(22, 18)
        Me.IDPeçaTextEdit.TabIndex = 13
        Me.IDPeçaTextEdit.TabStop = False
        '
        'VendidaCheckEdit
        '
        Me.VendidaCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Vendida", True))
        Me.VendidaCheckEdit.Location = New System.Drawing.Point(141, 103)
        Me.VendidaCheckEdit.MenuManager = Me.ribbonControl1
        Me.VendidaCheckEdit.Name = "VendidaCheckEdit"
        Me.VendidaCheckEdit.Properties.Caption = ""
        Me.VendidaCheckEdit.Size = New System.Drawing.Size(25, 20)
        Me.VendidaCheckEdit.TabIndex = 27
        Me.VendidaCheckEdit.TabStop = False
        '
        '_1TabPeçasTableAdapter
        '
        Me._1TabPeçasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._1TabPeçasHistóricoTableAdapter = Nothing
        Me.TableAdapterManager._1TabPeçasTableAdapter = Me._1TabPeçasTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.METAISTableAdapter = Me.METAISTableAdapter
        Me.TableAdapterManager.PEDRASTableAdapter = Me.PEDRASTableAdapter
        Me.TableAdapterManager.ReajustesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pepe.dsNovoEstoqueTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'METAISTableAdapter
        '
        Me.METAISTableAdapter.ClearBeforeFill = True
        '
        'PEDRASTableAdapter
        '
        Me.PEDRASTableAdapter.ClearBeforeFill = True
        '
        'METAISBindingSource
        '
        Me.METAISBindingSource.DataMember = "1TabPeças_METAIS"
        Me.METAISBindingSource.DataSource = Me._1TabPeçasBindingSource
        '
        'METAISGridControl
        '
        Me.METAISGridControl.DataSource = Me.METAISBindingSource
        Me.METAISGridControl.Location = New System.Drawing.Point(827, 393)
        Me.METAISGridControl.MainView = Me.LayoutView1
        Me.METAISGridControl.MenuManager = Me.ribbonControl1
        Me.METAISGridControl.Name = "METAISGridControl"
        Me.METAISGridControl.Size = New System.Drawing.Size(427, 185)
        Me.METAISGridControl.TabIndex = 10
        Me.METAISGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.LayoutView1})
        '
        'LayoutView1
        '
        Me.LayoutView1.Appearance.Card.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LayoutView1.Appearance.Card.Options.UseFont = True
        Me.LayoutView1.Appearance.Card.Options.UseTextOptions = True
        Me.LayoutView1.Appearance.Card.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutView1.Appearance.FieldCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutView1.Appearance.FieldCaption.Options.UseFont = True
        Me.LayoutView1.Appearance.FieldEditingValue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LayoutView1.Appearance.FieldEditingValue.Options.UseFont = True
        Me.LayoutView1.Appearance.FieldEditingValue.Options.UseTextOptions = True
        Me.LayoutView1.Appearance.FieldEditingValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutView1.Appearance.FieldValue.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutView1.Appearance.FieldValue.ForeColor = System.Drawing.Color.White
        Me.LayoutView1.Appearance.FieldValue.Options.UseFont = True
        Me.LayoutView1.Appearance.FieldValue.Options.UseForeColor = True
        Me.LayoutView1.Appearance.SeparatorLine.BorderColor = System.Drawing.Color.Black
        Me.LayoutView1.Appearance.SeparatorLine.Options.UseBorderColor = True
        Me.LayoutView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LayoutView1.CardMinSize = New System.Drawing.Size(304, 185)
        Me.LayoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colId, Me.colOuroQtde, Me.colOuroV, Me.colPaladiumQtde, Me.colPrataQtde, Me.colPlatinaQtde, Me.colPerdaPerc, Me.colPerdaQtde, Me.colSistemaQtde, Me.colTotalQtde, Me.colTotalValor, Me.colSistemaValor, Me.colPaladiumV, Me.colPrataV, Me.colPlatinaV})
        Me.LayoutView1.DetailAutoHeight = False
        Me.LayoutView1.DetailHeight = 187
        Me.LayoutView1.GridControl = Me.METAISGridControl
        Me.LayoutView1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colSistemaValor, Me.layoutViewField_colPerdaPerc, Me.layoutViewField_colId, Me.layoutViewField_colPlatinaV, Me.layoutViewField_colPaladiumV})
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.OptionsBehavior.AllowRuntimeCustomization = False
        Me.LayoutView1.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.LayoutView1.OptionsCustomization.AllowFilter = False
        Me.LayoutView1.OptionsCustomization.AllowSort = False
        Me.LayoutView1.OptionsFilter.AllowFilterEditor = False
        Me.LayoutView1.OptionsSingleRecordMode.StretchCardToViewHeight = True
        Me.LayoutView1.OptionsSingleRecordMode.StretchCardToViewWidth = True
        Me.LayoutView1.OptionsView.CardArrangeRule = DevExpress.XtraGrid.Views.Layout.LayoutCardArrangeRule.AllowPartialCards
        Me.LayoutView1.OptionsView.CardsAlignment = DevExpress.XtraGrid.Views.Layout.CardsAlignment.Near
        Me.LayoutView1.OptionsView.ShowCardCaption = False
        Me.LayoutView1.OptionsView.ShowCardExpandButton = False
        Me.LayoutView1.OptionsView.ShowCardFieldBorders = True
        Me.LayoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.LayoutView1.OptionsView.ShowHeaderPanel = False
        Me.LayoutView1.TemplateCard = Me.LayoutViewCard1
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.LayoutViewField = Me.layoutViewField_colId
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colId
        '
        Me.layoutViewField_colId.EditorPreferredWidth = 20
        Me.layoutViewField_colId.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colId.Name = "layoutViewField_colId"
        Me.layoutViewField_colId.Size = New System.Drawing.Size(304, 185)
        Me.layoutViewField_colId.TextSize = New System.Drawing.Size(73, 13)
        '
        'colOuroQtde
        '
        Me.colOuroQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colOuroQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colOuroQtde.AppearanceHeader.Options.UseTextOptions = True
        Me.colOuroQtde.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOuroQtde.Caption = "Peso"
        Me.colOuroQtde.CustomizationCaption = "Peso"
        Me.colOuroQtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colOuroQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOuroQtde.FieldName = "OuroQtde"
        Me.colOuroQtde.LayoutViewField = Me.layoutViewField_colOuroQtde
        Me.colOuroQtde.Name = "colOuroQtde"
        Me.colOuroQtde.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colOuroQtde
        '
        Me.layoutViewField_colOuroQtde.EditorPreferredWidth = 106
        Me.layoutViewField_colOuroQtde.Location = New System.Drawing.Point(46, 17)
        Me.layoutViewField_colOuroQtde.Name = "layoutViewField_colOuroQtde"
        Me.layoutViewField_colOuroQtde.Size = New System.Drawing.Size(110, 24)
        Me.layoutViewField_colOuroQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colOuroQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colOuroQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colOuroQtde.TextToControlDistance = 0
        Me.layoutViewField_colOuroQtde.TextVisible = False
        '
        'colOuroV
        '
        Me.colOuroV.AppearanceCell.Options.UseTextOptions = True
        Me.colOuroV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colOuroV.AppearanceHeader.Options.UseTextOptions = True
        Me.colOuroV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOuroV.Caption = "P/C"
        Me.colOuroV.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colOuroV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOuroV.FieldName = "OuroV"
        Me.colOuroV.LayoutViewField = Me.layoutViewField_colOuroV
        Me.colOuroV.Name = "colOuroV"
        Me.colOuroV.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colOuroV
        '
        Me.layoutViewField_colOuroV.EditorPreferredWidth = 118
        Me.layoutViewField_colOuroV.Location = New System.Drawing.Point(156, 17)
        Me.layoutViewField_colOuroV.Name = "layoutViewField_colOuroV"
        Me.layoutViewField_colOuroV.Size = New System.Drawing.Size(122, 24)
        Me.layoutViewField_colOuroV.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colOuroV.TextLocation = DevExpress.Utils.Locations.Top
        Me.layoutViewField_colOuroV.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colOuroV.TextToControlDistance = 0
        Me.layoutViewField_colOuroV.TextVisible = False
        '
        'colPaladiumQtde
        '
        Me.colPaladiumQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colPaladiumQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPaladiumQtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colPaladiumQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPaladiumQtde.FieldName = "PaladiumQtde"
        Me.colPaladiumQtde.LayoutViewField = Me.layoutViewField_colPaladiumQtde
        Me.colPaladiumQtde.Name = "colPaladiumQtde"
        Me.colPaladiumQtde.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colPaladiumQtde
        '
        Me.layoutViewField_colPaladiumQtde.EditorPreferredWidth = 106
        Me.layoutViewField_colPaladiumQtde.Location = New System.Drawing.Point(46, 137)
        Me.layoutViewField_colPaladiumQtde.Name = "layoutViewField_colPaladiumQtde"
        Me.layoutViewField_colPaladiumQtde.Size = New System.Drawing.Size(110, 24)
        Me.layoutViewField_colPaladiumQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colPaladiumQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPaladiumQtde.TextVisible = False
        '
        'colPrataQtde
        '
        Me.colPrataQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colPrataQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPrataQtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colPrataQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrataQtde.FieldName = "PrataQtde"
        Me.colPrataQtde.LayoutViewField = Me.layoutViewField_colPrataQtde
        Me.colPrataQtde.Name = "colPrataQtde"
        Me.colPrataQtde.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colPrataQtde
        '
        Me.layoutViewField_colPrataQtde.EditorPreferredWidth = 106
        Me.layoutViewField_colPrataQtde.Location = New System.Drawing.Point(46, 89)
        Me.layoutViewField_colPrataQtde.Name = "layoutViewField_colPrataQtde"
        Me.layoutViewField_colPrataQtde.Size = New System.Drawing.Size(110, 24)
        Me.layoutViewField_colPrataQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colPrataQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPrataQtde.TextVisible = False
        '
        'colPlatinaQtde
        '
        Me.colPlatinaQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colPlatinaQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPlatinaQtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colPlatinaQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPlatinaQtde.FieldName = "PlatinaQtde"
        Me.colPlatinaQtde.LayoutViewField = Me.layoutViewField_colPlatinaQtde
        Me.colPlatinaQtde.Name = "colPlatinaQtde"
        Me.colPlatinaQtde.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colPlatinaQtde
        '
        Me.layoutViewField_colPlatinaQtde.EditorPreferredWidth = 106
        Me.layoutViewField_colPlatinaQtde.Location = New System.Drawing.Point(46, 113)
        Me.layoutViewField_colPlatinaQtde.Name = "layoutViewField_colPlatinaQtde"
        Me.layoutViewField_colPlatinaQtde.Size = New System.Drawing.Size(110, 24)
        Me.layoutViewField_colPlatinaQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colPlatinaQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPlatinaQtde.TextVisible = False
        '
        'colPerdaPerc
        '
        Me.colPerdaPerc.AppearanceCell.Options.UseTextOptions = True
        Me.colPerdaPerc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colPerdaPerc.FieldName = "PerdaPerc"
        Me.colPerdaPerc.LayoutViewField = Me.layoutViewField_colPerdaPerc
        Me.colPerdaPerc.Name = "colPerdaPerc"
        Me.colPerdaPerc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colPerdaPerc
        '
        Me.layoutViewField_colPerdaPerc.EditorPreferredWidth = 20
        Me.layoutViewField_colPerdaPerc.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colPerdaPerc.Name = "layoutViewField_colPerdaPerc"
        Me.layoutViewField_colPerdaPerc.Size = New System.Drawing.Size(304, 185)
        Me.layoutViewField_colPerdaPerc.TextSize = New System.Drawing.Size(73, 13)
        '
        'colPerdaQtde
        '
        Me.colPerdaQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colPerdaQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPerdaQtde.Caption = "Peso"
        Me.colPerdaQtde.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colPerdaQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPerdaQtde.FieldName = "PerdaQtde"
        Me.colPerdaQtde.LayoutViewField = Me.layoutViewField_colPerdaQtde
        Me.colPerdaQtde.Name = "colPerdaQtde"
        Me.colPerdaQtde.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colPerdaQtde
        '
        Me.layoutViewField_colPerdaQtde.EditorPreferredWidth = 106
        Me.layoutViewField_colPerdaQtde.Location = New System.Drawing.Point(46, 41)
        Me.layoutViewField_colPerdaQtde.Name = "layoutViewField_colPerdaQtde"
        Me.layoutViewField_colPerdaQtde.Size = New System.Drawing.Size(110, 24)
        Me.layoutViewField_colPerdaQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colPerdaQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colPerdaQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPerdaQtde.TextToControlDistance = 0
        Me.layoutViewField_colPerdaQtde.TextVisible = False
        '
        'colSistemaQtde
        '
        Me.colSistemaQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colSistemaQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSistemaQtde.Caption = "Peso"
        Me.colSistemaQtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colSistemaQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSistemaQtde.FieldName = "SistemaQtde"
        Me.colSistemaQtde.LayoutViewField = Me.layoutViewField_colSistemaQtde
        Me.colSistemaQtde.Name = "colSistemaQtde"
        Me.colSistemaQtde.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colSistemaQtde
        '
        Me.layoutViewField_colSistemaQtde.EditorPreferredWidth = 106
        Me.layoutViewField_colSistemaQtde.Location = New System.Drawing.Point(46, 65)
        Me.layoutViewField_colSistemaQtde.Name = "layoutViewField_colSistemaQtde"
        Me.layoutViewField_colSistemaQtde.Size = New System.Drawing.Size(110, 24)
        Me.layoutViewField_colSistemaQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colSistemaQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colSistemaQtde.TextVisible = False
        '
        'colTotalQtde
        '
        Me.colTotalQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colTotalQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalQtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colTotalQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalQtde.FieldName = "TotalQtde"
        Me.colTotalQtde.LayoutViewField = Me.layoutViewField_colTotalQtde
        Me.colTotalQtde.Name = "colTotalQtde"
        Me.colTotalQtde.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colTotalQtde
        '
        Me.layoutViewField_colTotalQtde.EditorPreferredWidth = 106
        Me.layoutViewField_colTotalQtde.Location = New System.Drawing.Point(46, 161)
        Me.layoutViewField_colTotalQtde.Name = "layoutViewField_colTotalQtde"
        Me.layoutViewField_colTotalQtde.Size = New System.Drawing.Size(110, 24)
        Me.layoutViewField_colTotalQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colTotalQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colTotalQtde.TextVisible = False
        '
        'colTotalValor
        '
        Me.colTotalValor.AppearanceCell.Options.UseTextOptions = True
        Me.colTotalValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colTotalValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalValor.FieldName = "TotalValor"
        Me.colTotalValor.LayoutViewField = Me.layoutViewField_colTotalValor
        Me.colTotalValor.Name = "colTotalValor"
        Me.colTotalValor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colTotalValor
        '
        Me.layoutViewField_colTotalValor.EditorPreferredWidth = 118
        Me.layoutViewField_colTotalValor.Location = New System.Drawing.Point(156, 161)
        Me.layoutViewField_colTotalValor.Name = "layoutViewField_colTotalValor"
        Me.layoutViewField_colTotalValor.Size = New System.Drawing.Size(122, 24)
        Me.layoutViewField_colTotalValor.TextLocation = DevExpress.Utils.Locations.Top
        Me.layoutViewField_colTotalValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colTotalValor.TextVisible = False
        '
        'colSistemaValor
        '
        Me.colSistemaValor.AppearanceCell.Options.UseTextOptions = True
        Me.colSistemaValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colSistemaValor.FieldName = "SistemaValor"
        Me.colSistemaValor.LayoutViewField = Me.layoutViewField_colSistemaValor
        Me.colSistemaValor.Name = "colSistemaValor"
        Me.colSistemaValor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colSistemaValor
        '
        Me.layoutViewField_colSistemaValor.EditorPreferredWidth = 20
        Me.layoutViewField_colSistemaValor.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colSistemaValor.Name = "layoutViewField_colSistemaValor"
        Me.layoutViewField_colSistemaValor.Size = New System.Drawing.Size(304, 185)
        Me.layoutViewField_colSistemaValor.TextSize = New System.Drawing.Size(73, 13)
        '
        'colPaladiumV
        '
        Me.colPaladiumV.AppearanceCell.Options.UseTextOptions = True
        Me.colPaladiumV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colPaladiumV.FieldName = "PaladiumV"
        Me.colPaladiumV.LayoutViewField = Me.layoutViewField_colPaladiumV
        Me.colPaladiumV.Name = "colPaladiumV"
        Me.colPaladiumV.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colPaladiumV
        '
        Me.layoutViewField_colPaladiumV.EditorPreferredWidth = 20
        Me.layoutViewField_colPaladiumV.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colPaladiumV.Name = "layoutViewField_colPaladiumV"
        Me.layoutViewField_colPaladiumV.Size = New System.Drawing.Size(304, 185)
        Me.layoutViewField_colPaladiumV.TextSize = New System.Drawing.Size(73, 13)
        '
        'colPrataV
        '
        Me.colPrataV.AppearanceCell.Options.UseTextOptions = True
        Me.colPrataV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPrataV.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colPrataV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrataV.FieldName = "PrataV"
        Me.colPrataV.LayoutViewField = Me.layoutViewField_colPrataV
        Me.colPrataV.Name = "colPrataV"
        Me.colPrataV.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colPrataV
        '
        Me.layoutViewField_colPrataV.EditorPreferredWidth = 118
        Me.layoutViewField_colPrataV.Location = New System.Drawing.Point(156, 89)
        Me.layoutViewField_colPrataV.Name = "layoutViewField_colPrataV"
        Me.layoutViewField_colPrataV.Size = New System.Drawing.Size(122, 24)
        Me.layoutViewField_colPrataV.TextLocation = DevExpress.Utils.Locations.Top
        Me.layoutViewField_colPrataV.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPrataV.TextVisible = False
        '
        'colPlatinaV
        '
        Me.colPlatinaV.AppearanceCell.Options.UseTextOptions = True
        Me.colPlatinaV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colPlatinaV.FieldName = "PlatinaV"
        Me.colPlatinaV.LayoutViewField = Me.layoutViewField_colPlatinaV
        Me.colPlatinaV.Name = "colPlatinaV"
        Me.colPlatinaV.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'layoutViewField_colPlatinaV
        '
        Me.layoutViewField_colPlatinaV.EditorPreferredWidth = 20
        Me.layoutViewField_colPlatinaV.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colPlatinaV.Name = "layoutViewField_colPlatinaV"
        Me.layoutViewField_colPlatinaV.Size = New System.Drawing.Size(304, 185)
        Me.layoutViewField_colPlatinaV.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
        Me.LayoutViewCard1.GroupBordersVisible = False
        Me.LayoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colOuroQtde, Me.layoutViewField_colOuroV, Me.item1, Me.layoutViewField_colPerdaQtde, Me.item2, Me.layoutViewField_colSistemaQtde, Me.item3, Me.layoutViewField_colPrataQtde, Me.item4, Me.layoutViewField_colPrataV, Me.item5, Me.item6, Me.item7, Me.item8, Me.layoutViewField_colPlatinaQtde, Me.item9, Me.item10, Me.layoutViewField_colPaladiumQtde, Me.layoutViewField_colTotalQtde, Me.layoutViewField_colTotalValor, Me.item11, Me.item15, Me.item16})
        Me.LayoutViewCard1.Name = "layoutViewTemplateCard"
        Me.LayoutViewCard1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.CustomSize
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'item1
        '
        Me.item1.AllowHotTrack = False
        Me.item1.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.item1.AppearanceItemCaption.Options.UseFont = True
        Me.item1.AppearanceItemCaption.Options.UseForeColor = True
        Me.item1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item1.CustomizationFormText = "Ouro"
        Me.item1.Location = New System.Drawing.Point(0, 17)
        Me.item1.Name = "item1"
        Me.item1.Size = New System.Drawing.Size(46, 24)
        Me.item1.Text = "Ouro"
        Me.item1.TextSize = New System.Drawing.Size(42, 13)
        '
        'item2
        '
        Me.item2.AllowHotTrack = False
        Me.item2.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.item2.AppearanceItemCaption.Options.UseFont = True
        Me.item2.AppearanceItemCaption.Options.UseForeColor = True
        Me.item2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item2.CustomizationFormText = "Perda"
        Me.item2.Location = New System.Drawing.Point(0, 41)
        Me.item2.Name = "item2"
        Me.item2.Size = New System.Drawing.Size(46, 24)
        Me.item2.Text = "Perda"
        Me.item2.TextSize = New System.Drawing.Size(42, 13)
        '
        'item3
        '
        Me.item3.AllowHotTrack = False
        Me.item3.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.item3.AppearanceItemCaption.Options.UseFont = True
        Me.item3.AppearanceItemCaption.Options.UseForeColor = True
        Me.item3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item3.CustomizationFormText = "Sistema"
        Me.item3.Location = New System.Drawing.Point(0, 65)
        Me.item3.Name = "item3"
        Me.item3.Size = New System.Drawing.Size(46, 24)
        Me.item3.Text = "Sistema"
        Me.item3.TextSize = New System.Drawing.Size(42, 13)
        '
        'item4
        '
        Me.item4.AllowHotTrack = False
        Me.item4.CustomizationFormText = "item4"
        Me.item4.Location = New System.Drawing.Point(156, 41)
        Me.item4.Name = "item4"
        Me.item4.Size = New System.Drawing.Size(122, 48)
        Me.item4.TextSize = New System.Drawing.Size(0, 0)
        '
        'item5
        '
        Me.item5.AllowHotTrack = False
        Me.item5.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.item5.AppearanceItemCaption.Options.UseFont = True
        Me.item5.AppearanceItemCaption.Options.UseForeColor = True
        Me.item5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item5.CustomizationFormText = "Prata"
        Me.item5.Location = New System.Drawing.Point(0, 89)
        Me.item5.Name = "item5"
        Me.item5.Size = New System.Drawing.Size(46, 24)
        Me.item5.Text = "Prata"
        Me.item5.TextSize = New System.Drawing.Size(42, 13)
        '
        'item6
        '
        Me.item6.AllowHotTrack = False
        Me.item6.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon
        Me.item6.AppearanceItemCaption.Options.UseFont = True
        Me.item6.AppearanceItemCaption.Options.UseForeColor = True
        Me.item6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item6.CustomizationFormText = "Peso"
        Me.item6.Location = New System.Drawing.Point(46, 0)
        Me.item6.Name = "item6"
        Me.item6.Size = New System.Drawing.Size(110, 17)
        Me.item6.Text = "Peso"
        Me.item6.TextSize = New System.Drawing.Size(42, 13)
        '
        'item7
        '
        Me.item7.AllowHotTrack = False
        Me.item7.CustomizationFormText = "item7"
        Me.item7.Location = New System.Drawing.Point(0, 0)
        Me.item7.Name = "item7"
        Me.item7.Size = New System.Drawing.Size(46, 17)
        Me.item7.TextSize = New System.Drawing.Size(0, 0)
        '
        'item8
        '
        Me.item8.AllowHotTrack = False
        Me.item8.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item8.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon
        Me.item8.AppearanceItemCaption.Options.UseFont = True
        Me.item8.AppearanceItemCaption.Options.UseForeColor = True
        Me.item8.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item8.CustomizationFormText = "P/C"
        Me.item8.Location = New System.Drawing.Point(156, 0)
        Me.item8.Name = "item8"
        Me.item8.Size = New System.Drawing.Size(122, 17)
        Me.item8.Text = "P/C"
        Me.item8.TextSize = New System.Drawing.Size(42, 13)
        '
        'item9
        '
        Me.item9.AllowHotTrack = False
        Me.item9.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item9.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.item9.AppearanceItemCaption.Options.UseFont = True
        Me.item9.AppearanceItemCaption.Options.UseForeColor = True
        Me.item9.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item9.CustomizationFormText = "Platina"
        Me.item9.Location = New System.Drawing.Point(0, 113)
        Me.item9.Name = "item9"
        Me.item9.Size = New System.Drawing.Size(46, 24)
        Me.item9.Text = "Platina"
        Me.item9.TextSize = New System.Drawing.Size(42, 13)
        '
        'item10
        '
        Me.item10.AllowHotTrack = False
        Me.item10.CustomizationFormText = "item10"
        Me.item10.Location = New System.Drawing.Point(156, 113)
        Me.item10.MinSize = New System.Drawing.Size(104, 24)
        Me.item10.Name = "item10"
        Me.item10.Size = New System.Drawing.Size(122, 24)
        Me.item10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.item10.TextSize = New System.Drawing.Size(0, 0)
        '
        'item11
        '
        Me.item11.AllowHotTrack = False
        Me.item11.CustomizationFormText = "item11"
        Me.item11.Location = New System.Drawing.Point(156, 137)
        Me.item11.Name = "item11"
        Me.item11.Size = New System.Drawing.Size(122, 24)
        Me.item11.TextSize = New System.Drawing.Size(0, 0)
        '
        'item15
        '
        Me.item15.AllowHotTrack = False
        Me.item15.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item15.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.item15.AppearanceItemCaption.Options.UseFont = True
        Me.item15.AppearanceItemCaption.Options.UseForeColor = True
        Me.item15.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item15.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item15.CustomizationFormText = "Total"
        Me.item15.Location = New System.Drawing.Point(0, 161)
        Me.item15.Name = "item15"
        Me.item15.Size = New System.Drawing.Size(46, 24)
        Me.item15.Text = "Total"
        Me.item15.TextSize = New System.Drawing.Size(42, 13)
        '
        'item16
        '
        Me.item16.AllowHotTrack = False
        Me.item16.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item16.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.item16.AppearanceItemCaption.Options.UseFont = True
        Me.item16.AppearanceItemCaption.Options.UseForeColor = True
        Me.item16.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item16.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item16.CustomizationFormText = "Paladium"
        Me.item16.Location = New System.Drawing.Point(0, 137)
        Me.item16.Name = "item16"
        Me.item16.Size = New System.Drawing.Size(46, 24)
        Me.item16.Text = "Paladium"
        Me.item16.TextSize = New System.Drawing.Size(42, 13)
        '
        'txtCusto
        '
        Me.txtCusto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Custo", True))
        Me.txtCusto.Location = New System.Drawing.Point(112, 569)
        Me.txtCusto.MenuManager = Me.ribbonControl1
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusto.Properties.Appearance.Options.UseFont = True
        Me.txtCusto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCusto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCusto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCusto.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtCusto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCusto.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtCusto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCusto.Properties.Mask.EditMask = "n2"
        Me.txtCusto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCusto.Size = New System.Drawing.Size(79, 26)
        Me.txtCusto.TabIndex = 7
        '
        'MOExtTextEdit
        '
        Me.MOExtTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "MOExt", True))
        Me.MOExtTextEdit.Location = New System.Drawing.Point(112, 358)
        Me.MOExtTextEdit.MenuManager = Me.ribbonControl1
        Me.MOExtTextEdit.Name = "MOExtTextEdit"
        Me.MOExtTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOExtTextEdit.Properties.Appearance.Options.UseFont = True
        Me.MOExtTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.MOExtTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.MOExtTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MOExtTextEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.MOExtTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MOExtTextEdit.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.MOExtTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MOExtTextEdit.Properties.Mask.BeepOnError = True
        Me.MOExtTextEdit.Properties.Mask.EditMask = "n2"
        Me.MOExtTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.MOExtTextEdit.Size = New System.Drawing.Size(79, 26)
        Me.MOExtTextEdit.TabIndex = 1
        '
        'MOIntTextEdit
        '
        Me.MOIntTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "MOInt", True))
        Me.MOIntTextEdit.Location = New System.Drawing.Point(112, 384)
        Me.MOIntTextEdit.MenuManager = Me.ribbonControl1
        Me.MOIntTextEdit.Name = "MOIntTextEdit"
        Me.MOIntTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOIntTextEdit.Properties.Appearance.Options.UseFont = True
        Me.MOIntTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.MOIntTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.MOIntTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MOIntTextEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.MOIntTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MOIntTextEdit.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.MOIntTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MOIntTextEdit.Properties.Mask.EditMask = "n2"
        Me.MOIntTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.MOIntTextEdit.Size = New System.Drawing.Size(79, 26)
        Me.MOIntTextEdit.TabIndex = 2
        '
        'PEDRASBindingSource
        '
        Me.PEDRASBindingSource.DataMember = "1TabPeças_PEDRAS"
        Me.PEDRASBindingSource.DataSource = Me._1TabPeçasBindingSource
        '
        'PEDRASGridControl
        '
        Me.PEDRASGridControl.DataSource = Me.PEDRASBindingSource
        Me.PEDRASGridControl.Location = New System.Drawing.Point(252, 357)
        Me.PEDRASGridControl.MainView = Me.LayoutView2
        Me.PEDRASGridControl.MenuManager = Me.ribbonControl1
        Me.PEDRASGridControl.Name = "PEDRASGridControl"
        Me.PEDRASGridControl.Size = New System.Drawing.Size(500, 231)
        Me.PEDRASGridControl.TabIndex = 9
        Me.PEDRASGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.LayoutView2})
        '
        'LayoutView2
        '
        Me.LayoutView2.Appearance.Card.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LayoutView2.Appearance.Card.ForeColor = System.Drawing.Color.White
        Me.LayoutView2.Appearance.Card.Options.UseFont = True
        Me.LayoutView2.Appearance.Card.Options.UseForeColor = True
        Me.LayoutView2.Appearance.Card.Options.UseTextOptions = True
        Me.LayoutView2.Appearance.Card.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutView2.Appearance.CardCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LayoutView2.Appearance.CardCaption.Options.UseFont = True
        Me.LayoutView2.Appearance.FieldCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LayoutView2.Appearance.FieldCaption.Options.UseFont = True
        Me.LayoutView2.Appearance.FieldValue.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LayoutView2.Appearance.FieldValue.ForeColor = System.Drawing.Color.White
        Me.LayoutView2.Appearance.FieldValue.Options.UseFont = True
        Me.LayoutView2.Appearance.FieldValue.Options.UseForeColor = True
        Me.LayoutView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LayoutView2.CardMinSize = New System.Drawing.Size(500, 231)
        Me.LayoutView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colId1, Me.colDiamantesCT, Me.colDiamantesQtde, Me.colDiamantesValor, Me.colDiamantes2CT, Me.colDiamantes2Qtde, Me.colDiamantes2Valor, Me.colBrasCT, Me.colPedrasBrasQtde, Me.colPedrasBrasValor, Me.colPerolasCT, Me.colPerolasQtde, Me.colPerolasValor, Me.colRubisCT, Me.colRubiQtde, Me.colRubiValor, Me.colSafirasCT, Me.colSafiraQtde, Me.colSafiraValor, Me.colEsmeraldasCT, Me.colEsmeraldaQtde, Me.colEsmeraldaValor, Me.colPedrasCT, Me.colCitrinoQtde, Me.colCitrinoValor})
        Me.LayoutView2.DetailAutoHeight = False
        Me.LayoutView2.DetailHeight = 233
        Me.LayoutView2.GridControl = Me.PEDRASGridControl
        Me.LayoutView2.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colId1, Me.layoutViewField_colPerolasQtde})
        Me.LayoutView2.Name = "LayoutView2"
        Me.LayoutView2.OptionsBehavior.AllowRuntimeCustomization = False
        Me.LayoutView2.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.LayoutView2.OptionsCustomization.AllowFilter = False
        Me.LayoutView2.OptionsCustomization.AllowSort = False
        Me.LayoutView2.OptionsFilter.AllowFilterEditor = False
        Me.LayoutView2.OptionsSingleRecordMode.StretchCardToViewHeight = True
        Me.LayoutView2.OptionsSingleRecordMode.StretchCardToViewWidth = True
        Me.LayoutView2.OptionsView.CardArrangeRule = DevExpress.XtraGrid.Views.Layout.LayoutCardArrangeRule.AllowPartialCards
        Me.LayoutView2.OptionsView.CardsAlignment = DevExpress.XtraGrid.Views.Layout.CardsAlignment.Near
        Me.LayoutView2.OptionsView.ShowCardCaption = False
        Me.LayoutView2.OptionsView.ShowCardExpandButton = False
        Me.LayoutView2.OptionsView.ShowCardFieldBorders = True
        Me.LayoutView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.LayoutView2.OptionsView.ShowHeaderPanel = False
        Me.LayoutView2.TemplateCard = Me.LayoutViewCard2
        '
        'colId1
        '
        Me.colId1.FieldName = "Id"
        Me.colId1.LayoutViewField = Me.layoutViewField_colId1
        Me.colId1.Name = "colId1"
        '
        'layoutViewField_colId1
        '
        Me.layoutViewField_colId1.EditorPreferredWidth = 20
        Me.layoutViewField_colId1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colId1.Name = "layoutViewField_colId1"
        Me.layoutViewField_colId1.Size = New System.Drawing.Size(480, 211)
        Me.layoutViewField_colId1.TextSize = New System.Drawing.Size(72, 13)
        '
        'colDiamantesCT
        '
        Me.colDiamantesCT.AppearanceCell.Options.UseTextOptions = True
        Me.colDiamantesCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDiamantesCT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colDiamantesCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiamantesCT.FieldName = "DiamantesCT"
        Me.colDiamantesCT.LayoutViewField = Me.layoutViewField_colDiamantesCT
        Me.colDiamantesCT.Name = "colDiamantesCT"
        '
        'layoutViewField_colDiamantesCT
        '
        Me.layoutViewField_colDiamantesCT.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.layoutViewField_colDiamantesCT.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
        Me.layoutViewField_colDiamantesCT.EditorPreferredWidth = 128
        Me.layoutViewField_colDiamantesCT.Location = New System.Drawing.Point(83, 19)
        Me.layoutViewField_colDiamantesCT.Name = "layoutViewField_colDiamantesCT"
        Me.layoutViewField_colDiamantesCT.Size = New System.Drawing.Size(132, 24)
        Me.layoutViewField_colDiamantesCT.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colDiamantesCT.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colDiamantesCT.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colDiamantesCT.TextToControlDistance = 0
        Me.layoutViewField_colDiamantesCT.TextVisible = False
        '
        'colDiamantesQtde
        '
        Me.colDiamantesQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colDiamantesQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDiamantesQtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colDiamantesQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiamantesQtde.FieldName = "DiamantesQtde"
        Me.colDiamantesQtde.LayoutViewField = Me.layoutViewField_colDiamantesQtde
        Me.colDiamantesQtde.Name = "colDiamantesQtde"
        '
        'layoutViewField_colDiamantesQtde
        '
        Me.layoutViewField_colDiamantesQtde.EditorPreferredWidth = 125
        Me.layoutViewField_colDiamantesQtde.Location = New System.Drawing.Point(215, 19)
        Me.layoutViewField_colDiamantesQtde.Name = "layoutViewField_colDiamantesQtde"
        Me.layoutViewField_colDiamantesQtde.Size = New System.Drawing.Size(129, 24)
        Me.layoutViewField_colDiamantesQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colDiamantesQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colDiamantesQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colDiamantesQtde.TextToControlDistance = 0
        Me.layoutViewField_colDiamantesQtde.TextVisible = False
        '
        'colDiamantesValor
        '
        Me.colDiamantesValor.AppearanceCell.Options.UseTextOptions = True
        Me.colDiamantesValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDiamantesValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colDiamantesValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiamantesValor.FieldName = "DiamantesValor"
        Me.colDiamantesValor.LayoutViewField = Me.layoutViewField_colDiamantesValor
        Me.colDiamantesValor.Name = "colDiamantesValor"
        '
        'layoutViewField_colDiamantesValor
        '
        Me.layoutViewField_colDiamantesValor.EditorPreferredWidth = 132
        Me.layoutViewField_colDiamantesValor.Location = New System.Drawing.Point(344, 19)
        Me.layoutViewField_colDiamantesValor.Name = "layoutViewField_colDiamantesValor"
        Me.layoutViewField_colDiamantesValor.Size = New System.Drawing.Size(136, 24)
        Me.layoutViewField_colDiamantesValor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colDiamantesValor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colDiamantesValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colDiamantesValor.TextToControlDistance = 0
        Me.layoutViewField_colDiamantesValor.TextVisible = False
        '
        'colDiamantes2CT
        '
        Me.colDiamantes2CT.AppearanceCell.Options.UseTextOptions = True
        Me.colDiamantes2CT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDiamantes2CT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colDiamantes2CT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiamantes2CT.FieldName = "Diamantes2CT"
        Me.colDiamantes2CT.LayoutViewField = Me.layoutViewField_colDiamantes2CT
        Me.colDiamantes2CT.Name = "colDiamantes2CT"
        '
        'layoutViewField_colDiamantes2CT
        '
        Me.layoutViewField_colDiamantes2CT.EditorPreferredWidth = 128
        Me.layoutViewField_colDiamantes2CT.Location = New System.Drawing.Point(83, 43)
        Me.layoutViewField_colDiamantes2CT.Name = "layoutViewField_colDiamantes2CT"
        Me.layoutViewField_colDiamantes2CT.Size = New System.Drawing.Size(132, 24)
        Me.layoutViewField_colDiamantes2CT.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colDiamantes2CT.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colDiamantes2CT.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colDiamantes2CT.TextToControlDistance = 0
        Me.layoutViewField_colDiamantes2CT.TextVisible = False
        '
        'colDiamantes2Qtde
        '
        Me.colDiamantes2Qtde.AppearanceCell.Options.UseTextOptions = True
        Me.colDiamantes2Qtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDiamantes2Qtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colDiamantes2Qtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiamantes2Qtde.FieldName = "Diamantes2Qtde"
        Me.colDiamantes2Qtde.LayoutViewField = Me.layoutViewField_colDiamantes2Qtde
        Me.colDiamantes2Qtde.Name = "colDiamantes2Qtde"
        '
        'layoutViewField_colDiamantes2Qtde
        '
        Me.layoutViewField_colDiamantes2Qtde.EditorPreferredWidth = 125
        Me.layoutViewField_colDiamantes2Qtde.Location = New System.Drawing.Point(215, 43)
        Me.layoutViewField_colDiamantes2Qtde.Name = "layoutViewField_colDiamantes2Qtde"
        Me.layoutViewField_colDiamantes2Qtde.Size = New System.Drawing.Size(129, 24)
        Me.layoutViewField_colDiamantes2Qtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colDiamantes2Qtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colDiamantes2Qtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colDiamantes2Qtde.TextToControlDistance = 0
        Me.layoutViewField_colDiamantes2Qtde.TextVisible = False
        '
        'colDiamantes2Valor
        '
        Me.colDiamantes2Valor.AppearanceCell.Options.UseTextOptions = True
        Me.colDiamantes2Valor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDiamantes2Valor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colDiamantes2Valor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiamantes2Valor.FieldName = "Diamantes2Valor"
        Me.colDiamantes2Valor.LayoutViewField = Me.layoutViewField_colDiamantes2Valor
        Me.colDiamantes2Valor.Name = "colDiamantes2Valor"
        '
        'layoutViewField_colDiamantes2Valor
        '
        Me.layoutViewField_colDiamantes2Valor.EditorPreferredWidth = 132
        Me.layoutViewField_colDiamantes2Valor.Location = New System.Drawing.Point(344, 43)
        Me.layoutViewField_colDiamantes2Valor.Name = "layoutViewField_colDiamantes2Valor"
        Me.layoutViewField_colDiamantes2Valor.Size = New System.Drawing.Size(136, 24)
        Me.layoutViewField_colDiamantes2Valor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colDiamantes2Valor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colDiamantes2Valor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colDiamantes2Valor.TextToControlDistance = 0
        Me.layoutViewField_colDiamantes2Valor.TextVisible = False
        '
        'colBrasCT
        '
        Me.colBrasCT.AppearanceCell.Options.UseTextOptions = True
        Me.colBrasCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colBrasCT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colBrasCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBrasCT.FieldName = "BrasCT"
        Me.colBrasCT.LayoutViewField = Me.LayoutViewField1
        Me.colBrasCT.Name = "colBrasCT"
        '
        'LayoutViewField1
        '
        Me.LayoutViewField1.EditorPreferredWidth = 128
        Me.LayoutViewField1.Location = New System.Drawing.Point(83, 67)
        Me.LayoutViewField1.Name = "LayoutViewField1"
        Me.LayoutViewField1.Size = New System.Drawing.Size(132, 24)
        Me.LayoutViewField1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutViewField1.TextVisible = False
        '
        'colPedrasBrasQtde
        '
        Me.colPedrasBrasQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colPedrasBrasQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPedrasBrasQtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colPedrasBrasQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPedrasBrasQtde.FieldName = "PedrasBrasQtde"
        Me.colPedrasBrasQtde.LayoutViewField = Me.layoutViewField_colPedrasBrasQtde
        Me.colPedrasBrasQtde.Name = "colPedrasBrasQtde"
        '
        'layoutViewField_colPedrasBrasQtde
        '
        Me.layoutViewField_colPedrasBrasQtde.EditorPreferredWidth = 125
        Me.layoutViewField_colPedrasBrasQtde.Location = New System.Drawing.Point(215, 67)
        Me.layoutViewField_colPedrasBrasQtde.Name = "layoutViewField_colPedrasBrasQtde"
        Me.layoutViewField_colPedrasBrasQtde.Size = New System.Drawing.Size(129, 24)
        Me.layoutViewField_colPedrasBrasQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colPedrasBrasQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colPedrasBrasQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPedrasBrasQtde.TextToControlDistance = 0
        Me.layoutViewField_colPedrasBrasQtde.TextVisible = False
        '
        'colPedrasBrasValor
        '
        Me.colPedrasBrasValor.AppearanceCell.Options.UseTextOptions = True
        Me.colPedrasBrasValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPedrasBrasValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colPedrasBrasValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPedrasBrasValor.FieldName = "PedrasBrasValor"
        Me.colPedrasBrasValor.LayoutViewField = Me.layoutViewField_colPedrasBrasValor
        Me.colPedrasBrasValor.Name = "colPedrasBrasValor"
        '
        'layoutViewField_colPedrasBrasValor
        '
        Me.layoutViewField_colPedrasBrasValor.EditorPreferredWidth = 132
        Me.layoutViewField_colPedrasBrasValor.Location = New System.Drawing.Point(344, 67)
        Me.layoutViewField_colPedrasBrasValor.Name = "layoutViewField_colPedrasBrasValor"
        Me.layoutViewField_colPedrasBrasValor.Size = New System.Drawing.Size(136, 24)
        Me.layoutViewField_colPedrasBrasValor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colPedrasBrasValor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colPedrasBrasValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPedrasBrasValor.TextToControlDistance = 0
        Me.layoutViewField_colPedrasBrasValor.TextVisible = False
        '
        'colPerolasCT
        '
        Me.colPerolasCT.AppearanceCell.Options.UseTextOptions = True
        Me.colPerolasCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPerolasCT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colPerolasCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPerolasCT.FieldName = "PerolasCT"
        Me.colPerolasCT.LayoutViewField = Me.LayoutViewField2
        Me.colPerolasCT.Name = "colPerolasCT"
        '
        'LayoutViewField2
        '
        Me.LayoutViewField2.EditorPreferredWidth = 128
        Me.LayoutViewField2.Location = New System.Drawing.Point(83, 91)
        Me.LayoutViewField2.Name = "LayoutViewField2"
        Me.LayoutViewField2.Size = New System.Drawing.Size(132, 24)
        Me.LayoutViewField2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutViewField2.TextVisible = False
        '
        'colPerolasQtde
        '
        Me.colPerolasQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colPerolasQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPerolasQtde.FieldName = "PerolasQtde"
        Me.colPerolasQtde.LayoutViewField = Me.layoutViewField_colPerolasQtde
        Me.colPerolasQtde.Name = "colPerolasQtde"
        '
        'layoutViewField_colPerolasQtde
        '
        Me.layoutViewField_colPerolasQtde.EditorPreferredWidth = 20
        Me.layoutViewField_colPerolasQtde.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colPerolasQtde.Name = "layoutViewField_colPerolasQtde"
        Me.layoutViewField_colPerolasQtde.Size = New System.Drawing.Size(480, 211)
        Me.layoutViewField_colPerolasQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colPerolasQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colPerolasQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPerolasQtde.TextToControlDistance = 0
        Me.layoutViewField_colPerolasQtde.TextVisible = False
        '
        'colPerolasValor
        '
        Me.colPerolasValor.AppearanceCell.Options.UseTextOptions = True
        Me.colPerolasValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPerolasValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colPerolasValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPerolasValor.FieldName = "PerolasValor"
        Me.colPerolasValor.LayoutViewField = Me.layoutViewField_colPerolasValor
        Me.colPerolasValor.Name = "colPerolasValor"
        '
        'layoutViewField_colPerolasValor
        '
        Me.layoutViewField_colPerolasValor.EditorPreferredWidth = 132
        Me.layoutViewField_colPerolasValor.Location = New System.Drawing.Point(344, 91)
        Me.layoutViewField_colPerolasValor.Name = "layoutViewField_colPerolasValor"
        Me.layoutViewField_colPerolasValor.Size = New System.Drawing.Size(136, 24)
        Me.layoutViewField_colPerolasValor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colPerolasValor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colPerolasValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPerolasValor.TextToControlDistance = 0
        Me.layoutViewField_colPerolasValor.TextVisible = False
        '
        'colRubisCT
        '
        Me.colRubisCT.AppearanceCell.Options.UseTextOptions = True
        Me.colRubisCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colRubisCT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colRubisCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRubisCT.FieldName = "RubisCT"
        Me.colRubisCT.LayoutViewField = Me.LayoutViewField3
        Me.colRubisCT.Name = "colRubisCT"
        '
        'LayoutViewField3
        '
        Me.LayoutViewField3.EditorPreferredWidth = 128
        Me.LayoutViewField3.Location = New System.Drawing.Point(83, 115)
        Me.LayoutViewField3.Name = "LayoutViewField3"
        Me.LayoutViewField3.Size = New System.Drawing.Size(132, 24)
        Me.LayoutViewField3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutViewField3.TextVisible = False
        '
        'colRubiQtde
        '
        Me.colRubiQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colRubiQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colRubiQtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colRubiQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRubiQtde.FieldName = "RubiQtde"
        Me.colRubiQtde.LayoutViewField = Me.layoutViewField_colRubiQtde
        Me.colRubiQtde.Name = "colRubiQtde"
        '
        'layoutViewField_colRubiQtde
        '
        Me.layoutViewField_colRubiQtde.EditorPreferredWidth = 125
        Me.layoutViewField_colRubiQtde.Location = New System.Drawing.Point(215, 115)
        Me.layoutViewField_colRubiQtde.Name = "layoutViewField_colRubiQtde"
        Me.layoutViewField_colRubiQtde.Size = New System.Drawing.Size(129, 24)
        Me.layoutViewField_colRubiQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colRubiQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colRubiQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colRubiQtde.TextToControlDistance = 0
        Me.layoutViewField_colRubiQtde.TextVisible = False
        '
        'colRubiValor
        '
        Me.colRubiValor.AppearanceCell.Options.UseTextOptions = True
        Me.colRubiValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colRubiValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colRubiValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRubiValor.FieldName = "RubiValor"
        Me.colRubiValor.LayoutViewField = Me.layoutViewField_colRubiValor
        Me.colRubiValor.Name = "colRubiValor"
        '
        'layoutViewField_colRubiValor
        '
        Me.layoutViewField_colRubiValor.EditorPreferredWidth = 132
        Me.layoutViewField_colRubiValor.Location = New System.Drawing.Point(344, 115)
        Me.layoutViewField_colRubiValor.Name = "layoutViewField_colRubiValor"
        Me.layoutViewField_colRubiValor.Size = New System.Drawing.Size(136, 24)
        Me.layoutViewField_colRubiValor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colRubiValor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colRubiValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colRubiValor.TextToControlDistance = 0
        Me.layoutViewField_colRubiValor.TextVisible = False
        '
        'colSafirasCT
        '
        Me.colSafirasCT.AppearanceCell.Options.UseTextOptions = True
        Me.colSafirasCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSafirasCT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colSafirasCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSafirasCT.FieldName = "SafirasCT"
        Me.colSafirasCT.LayoutViewField = Me.LayoutViewField4
        Me.colSafirasCT.Name = "colSafirasCT"
        '
        'LayoutViewField4
        '
        Me.LayoutViewField4.EditorPreferredWidth = 128
        Me.LayoutViewField4.Location = New System.Drawing.Point(83, 139)
        Me.LayoutViewField4.Name = "LayoutViewField4"
        Me.LayoutViewField4.Size = New System.Drawing.Size(132, 24)
        Me.LayoutViewField4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutViewField4.TextVisible = False
        '
        'colSafiraQtde
        '
        Me.colSafiraQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colSafiraQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSafiraQtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colSafiraQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSafiraQtde.FieldName = "SafiraQtde"
        Me.colSafiraQtde.LayoutViewField = Me.layoutViewField_colSafiraQtde
        Me.colSafiraQtde.Name = "colSafiraQtde"
        '
        'layoutViewField_colSafiraQtde
        '
        Me.layoutViewField_colSafiraQtde.EditorPreferredWidth = 125
        Me.layoutViewField_colSafiraQtde.Location = New System.Drawing.Point(215, 139)
        Me.layoutViewField_colSafiraQtde.Name = "layoutViewField_colSafiraQtde"
        Me.layoutViewField_colSafiraQtde.Size = New System.Drawing.Size(129, 24)
        Me.layoutViewField_colSafiraQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colSafiraQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colSafiraQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colSafiraQtde.TextToControlDistance = 0
        Me.layoutViewField_colSafiraQtde.TextVisible = False
        '
        'colSafiraValor
        '
        Me.colSafiraValor.AppearanceCell.Options.UseTextOptions = True
        Me.colSafiraValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSafiraValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colSafiraValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSafiraValor.FieldName = "SafiraValor"
        Me.colSafiraValor.LayoutViewField = Me.layoutViewField_colSafiraValor
        Me.colSafiraValor.Name = "colSafiraValor"
        '
        'layoutViewField_colSafiraValor
        '
        Me.layoutViewField_colSafiraValor.EditorPreferredWidth = 132
        Me.layoutViewField_colSafiraValor.Location = New System.Drawing.Point(344, 139)
        Me.layoutViewField_colSafiraValor.Name = "layoutViewField_colSafiraValor"
        Me.layoutViewField_colSafiraValor.Size = New System.Drawing.Size(136, 24)
        Me.layoutViewField_colSafiraValor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colSafiraValor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colSafiraValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colSafiraValor.TextToControlDistance = 0
        Me.layoutViewField_colSafiraValor.TextVisible = False
        '
        'colEsmeraldasCT
        '
        Me.colEsmeraldasCT.AppearanceCell.Options.UseTextOptions = True
        Me.colEsmeraldasCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colEsmeraldasCT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colEsmeraldasCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEsmeraldasCT.FieldName = "EsmeraldasCT"
        Me.colEsmeraldasCT.LayoutViewField = Me.LayoutViewField5
        Me.colEsmeraldasCT.Name = "colEsmeraldasCT"
        '
        'LayoutViewField5
        '
        Me.LayoutViewField5.EditorPreferredWidth = 128
        Me.LayoutViewField5.Location = New System.Drawing.Point(83, 163)
        Me.LayoutViewField5.Name = "LayoutViewField5"
        Me.LayoutViewField5.Size = New System.Drawing.Size(132, 24)
        Me.LayoutViewField5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutViewField5.TextVisible = False
        '
        'colEsmeraldaQtde
        '
        Me.colEsmeraldaQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colEsmeraldaQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colEsmeraldaQtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colEsmeraldaQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEsmeraldaQtde.FieldName = "EsmeraldaQtde"
        Me.colEsmeraldaQtde.LayoutViewField = Me.layoutViewField_colEsmeraldaQtde
        Me.colEsmeraldaQtde.Name = "colEsmeraldaQtde"
        '
        'layoutViewField_colEsmeraldaQtde
        '
        Me.layoutViewField_colEsmeraldaQtde.EditorPreferredWidth = 125
        Me.layoutViewField_colEsmeraldaQtde.Location = New System.Drawing.Point(215, 163)
        Me.layoutViewField_colEsmeraldaQtde.Name = "layoutViewField_colEsmeraldaQtde"
        Me.layoutViewField_colEsmeraldaQtde.Size = New System.Drawing.Size(129, 24)
        Me.layoutViewField_colEsmeraldaQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colEsmeraldaQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colEsmeraldaQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colEsmeraldaQtde.TextToControlDistance = 0
        Me.layoutViewField_colEsmeraldaQtde.TextVisible = False
        '
        'colEsmeraldaValor
        '
        Me.colEsmeraldaValor.AppearanceCell.Options.UseTextOptions = True
        Me.colEsmeraldaValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colEsmeraldaValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colEsmeraldaValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEsmeraldaValor.FieldName = "EsmeraldaValor"
        Me.colEsmeraldaValor.LayoutViewField = Me.layoutViewField_colEsmeraldaValor
        Me.colEsmeraldaValor.Name = "colEsmeraldaValor"
        '
        'layoutViewField_colEsmeraldaValor
        '
        Me.layoutViewField_colEsmeraldaValor.EditorPreferredWidth = 132
        Me.layoutViewField_colEsmeraldaValor.Location = New System.Drawing.Point(344, 163)
        Me.layoutViewField_colEsmeraldaValor.Name = "layoutViewField_colEsmeraldaValor"
        Me.layoutViewField_colEsmeraldaValor.Size = New System.Drawing.Size(136, 24)
        Me.layoutViewField_colEsmeraldaValor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colEsmeraldaValor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colEsmeraldaValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colEsmeraldaValor.TextToControlDistance = 0
        Me.layoutViewField_colEsmeraldaValor.TextVisible = False
        '
        'colPedrasCT
        '
        Me.colPedrasCT.AppearanceCell.Options.UseTextOptions = True
        Me.colPedrasCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPedrasCT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colPedrasCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPedrasCT.FieldName = "PedrasCT"
        Me.colPedrasCT.LayoutViewField = Me.LayoutViewField6
        Me.colPedrasCT.Name = "colPedrasCT"
        '
        'LayoutViewField6
        '
        Me.LayoutViewField6.EditorPreferredWidth = 128
        Me.LayoutViewField6.Location = New System.Drawing.Point(83, 187)
        Me.LayoutViewField6.Name = "LayoutViewField6"
        Me.LayoutViewField6.Size = New System.Drawing.Size(132, 24)
        Me.LayoutViewField6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutViewField6.TextVisible = False
        '
        'colCitrinoQtde
        '
        Me.colCitrinoQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colCitrinoQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCitrinoQtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colCitrinoQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCitrinoQtde.FieldName = "CitrinoQtde"
        Me.colCitrinoQtde.LayoutViewField = Me.layoutViewField_colCitrinoQtde
        Me.colCitrinoQtde.Name = "colCitrinoQtde"
        '
        'layoutViewField_colCitrinoQtde
        '
        Me.layoutViewField_colCitrinoQtde.EditorPreferredWidth = 125
        Me.layoutViewField_colCitrinoQtde.Location = New System.Drawing.Point(215, 187)
        Me.layoutViewField_colCitrinoQtde.Name = "layoutViewField_colCitrinoQtde"
        Me.layoutViewField_colCitrinoQtde.Size = New System.Drawing.Size(129, 24)
        Me.layoutViewField_colCitrinoQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colCitrinoQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colCitrinoQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colCitrinoQtde.TextToControlDistance = 0
        Me.layoutViewField_colCitrinoQtde.TextVisible = False
        '
        'colCitrinoValor
        '
        Me.colCitrinoValor.AppearanceCell.Options.UseTextOptions = True
        Me.colCitrinoValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCitrinoValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colCitrinoValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCitrinoValor.FieldName = "CitrinoValor"
        Me.colCitrinoValor.LayoutViewField = Me.layoutViewField_colCitrinoValor
        Me.colCitrinoValor.Name = "colCitrinoValor"
        '
        'layoutViewField_colCitrinoValor
        '
        Me.layoutViewField_colCitrinoValor.EditorPreferredWidth = 132
        Me.layoutViewField_colCitrinoValor.Location = New System.Drawing.Point(344, 187)
        Me.layoutViewField_colCitrinoValor.Name = "layoutViewField_colCitrinoValor"
        Me.layoutViewField_colCitrinoValor.Size = New System.Drawing.Size(136, 24)
        Me.layoutViewField_colCitrinoValor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colCitrinoValor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colCitrinoValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colCitrinoValor.TextToControlDistance = 0
        Me.layoutViewField_colCitrinoValor.TextVisible = False
        '
        'LayoutViewCard2
        '
        Me.LayoutViewCard2.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard2.GroupBordersVisible = False
        Me.LayoutViewCard2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colDiamantesCT, Me.layoutViewField_colDiamantes2CT, Me.layoutViewField_colDiamantesQtde, Me.layoutViewField_colDiamantesValor, Me.layoutViewField_colDiamantes2Qtde, Me.layoutViewField_colDiamantes2Valor, Me.layoutViewField_colPedrasBrasValor, Me.layoutViewField_colPerolasValor, Me.layoutViewField_colRubiValor, Me.layoutViewField_colSafiraValor, Me.layoutViewField_colEsmeraldaValor, Me.layoutViewField_colCitrinoValor, Me.item12, Me.item13, Me.item14, Me.item17, Me.item18, Me.item19, Me.item20, Me.item21, Me.item22, Me.item23, Me.item25, Me.item24, Me.item27, Me.LayoutViewField1, Me.LayoutViewField2, Me.LayoutViewField3, Me.LayoutViewField4, Me.LayoutViewField5, Me.LayoutViewField6, Me.layoutViewField_colPedrasBrasQtde, Me.layoutViewField_colRubiQtde, Me.layoutViewField_colSafiraQtde, Me.layoutViewField_colEsmeraldaQtde, Me.layoutViewField_colCitrinoQtde})
        Me.LayoutViewCard2.Name = "layoutViewTemplateCard"
        Me.LayoutViewCard2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard2.Text = "TemplateCard"
        '
        'item12
        '
        Me.item12.AllowHotTrack = False
        Me.item12.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item12.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.item12.AppearanceItemCaption.Options.UseFont = True
        Me.item12.AppearanceItemCaption.Options.UseForeColor = True
        Me.item12.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item12.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item12.CustomizationFormText = "Diamantes"
        Me.item12.Location = New System.Drawing.Point(0, 19)
        Me.item12.Name = "item12"
        Me.item12.Size = New System.Drawing.Size(83, 24)
        Me.item12.Text = "Diamantes"
        Me.item12.TextSize = New System.Drawing.Size(79, 15)
        '
        'item13
        '
        Me.item13.AllowHotTrack = False
        Me.item13.CustomizationFormText = " "
        Me.item13.Location = New System.Drawing.Point(0, 43)
        Me.item13.Name = "item13"
        Me.item13.Size = New System.Drawing.Size(83, 24)
        Me.item13.Text = " "
        Me.item13.TextSize = New System.Drawing.Size(79, 13)
        '
        'item14
        '
        Me.item14.AllowHotTrack = False
        Me.item14.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item14.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.item14.AppearanceItemCaption.Options.UseFont = True
        Me.item14.AppearanceItemCaption.Options.UseForeColor = True
        Me.item14.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item14.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item14.CustomizationFormText = "Pedras Bras."
        Me.item14.Location = New System.Drawing.Point(0, 67)
        Me.item14.Name = "item14"
        Me.item14.Size = New System.Drawing.Size(83, 24)
        Me.item14.Text = "Pedras Bras."
        Me.item14.TextSize = New System.Drawing.Size(79, 15)
        '
        'item17
        '
        Me.item17.AllowHotTrack = False
        Me.item17.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item17.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.item17.AppearanceItemCaption.Options.UseFont = True
        Me.item17.AppearanceItemCaption.Options.UseForeColor = True
        Me.item17.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item17.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item17.CustomizationFormText = "Pérolas"
        Me.item17.Location = New System.Drawing.Point(0, 91)
        Me.item17.Name = "item17"
        Me.item17.Size = New System.Drawing.Size(83, 24)
        Me.item17.Text = "Pérolas"
        Me.item17.TextSize = New System.Drawing.Size(79, 15)
        '
        'item18
        '
        Me.item18.AllowHotTrack = False
        Me.item18.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item18.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.item18.AppearanceItemCaption.Options.UseFont = True
        Me.item18.AppearanceItemCaption.Options.UseForeColor = True
        Me.item18.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item18.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item18.CustomizationFormText = "Rubis"
        Me.item18.Location = New System.Drawing.Point(0, 115)
        Me.item18.Name = "item18"
        Me.item18.Size = New System.Drawing.Size(83, 24)
        Me.item18.Text = "Rubis"
        Me.item18.TextSize = New System.Drawing.Size(79, 15)
        '
        'item19
        '
        Me.item19.AllowHotTrack = False
        Me.item19.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item19.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.item19.AppearanceItemCaption.Options.UseFont = True
        Me.item19.AppearanceItemCaption.Options.UseForeColor = True
        Me.item19.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item19.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item19.CustomizationFormText = "Safiras"
        Me.item19.Location = New System.Drawing.Point(0, 139)
        Me.item19.Name = "item19"
        Me.item19.Size = New System.Drawing.Size(83, 24)
        Me.item19.Text = "Safiras"
        Me.item19.TextSize = New System.Drawing.Size(79, 15)
        '
        'item20
        '
        Me.item20.AllowHotTrack = False
        Me.item20.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item20.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.item20.AppearanceItemCaption.Options.UseFont = True
        Me.item20.AppearanceItemCaption.Options.UseForeColor = True
        Me.item20.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item20.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item20.CustomizationFormText = "Esmeraldas"
        Me.item20.Location = New System.Drawing.Point(0, 163)
        Me.item20.Name = "item20"
        Me.item20.Size = New System.Drawing.Size(83, 24)
        Me.item20.Text = "Esmeraldas"
        Me.item20.TextSize = New System.Drawing.Size(79, 15)
        '
        'item21
        '
        Me.item21.AllowHotTrack = False
        Me.item21.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item21.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.item21.AppearanceItemCaption.Options.UseFont = True
        Me.item21.AppearanceItemCaption.Options.UseForeColor = True
        Me.item21.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item21.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item21.CustomizationFormText = "Pedras Opacas"
        Me.item21.Location = New System.Drawing.Point(0, 187)
        Me.item21.Name = "item21"
        Me.item21.Size = New System.Drawing.Size(83, 24)
        Me.item21.Text = "Pedras Opacas"
        Me.item21.TextSize = New System.Drawing.Size(79, 15)
        '
        'item22
        '
        Me.item22.AllowHotTrack = False
        Me.item22.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item22.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon
        Me.item22.AppearanceItemCaption.Options.UseFont = True
        Me.item22.AppearanceItemCaption.Options.UseForeColor = True
        Me.item22.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item22.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item22.CustomizationFormText = "Valor"
        Me.item22.Location = New System.Drawing.Point(344, 0)
        Me.item22.Name = "item22"
        Me.item22.Size = New System.Drawing.Size(136, 19)
        Me.item22.Text = "Valor"
        Me.item22.TextSize = New System.Drawing.Size(79, 15)
        '
        'item23
        '
        Me.item23.AllowHotTrack = False
        Me.item23.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item23.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon
        Me.item23.AppearanceItemCaption.Options.UseFont = True
        Me.item23.AppearanceItemCaption.Options.UseForeColor = True
        Me.item23.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item23.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item23.CustomizationFormText = "CT"
        Me.item23.Location = New System.Drawing.Point(215, 0)
        Me.item23.Name = "item23"
        Me.item23.Size = New System.Drawing.Size(129, 19)
        Me.item23.Text = "CT"
        Me.item23.TextSize = New System.Drawing.Size(79, 15)
        '
        'item25
        '
        Me.item25.AllowHotTrack = False
        Me.item25.CustomizationFormText = "item25"
        Me.item25.Location = New System.Drawing.Point(0, 0)
        Me.item25.Name = "item25"
        Me.item25.Size = New System.Drawing.Size(83, 19)
        Me.item25.TextSize = New System.Drawing.Size(0, 0)
        '
        'item24
        '
        Me.item24.AllowHotTrack = False
        Me.item24.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.item24.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon
        Me.item24.AppearanceItemCaption.Options.UseFont = True
        Me.item24.AppearanceItemCaption.Options.UseForeColor = True
        Me.item24.AppearanceItemCaption.Options.UseTextOptions = True
        Me.item24.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.item24.CustomizationFormText = "Quant."
        Me.item24.Location = New System.Drawing.Point(83, 0)
        Me.item24.Name = "item24"
        Me.item24.Size = New System.Drawing.Size(132, 19)
        Me.item24.Text = "Quant."
        Me.item24.TextSize = New System.Drawing.Size(79, 15)
        '
        'item27
        '
        Me.item27.AllowHotTrack = False
        Me.item27.CustomizationFormText = "item27"
        Me.item27.Location = New System.Drawing.Point(215, 91)
        Me.item27.Name = "item27"
        Me.item27.Size = New System.Drawing.Size(129, 24)
        Me.item27.TextSize = New System.Drawing.Size(0, 0)
        '
        'CravaçãoTextEdit
        '
        Me.CravaçãoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Cravação", True))
        Me.CravaçãoTextEdit.Location = New System.Drawing.Point(112, 410)
        Me.CravaçãoTextEdit.MenuManager = Me.ribbonControl1
        Me.CravaçãoTextEdit.Name = "CravaçãoTextEdit"
        Me.CravaçãoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CravaçãoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CravaçãoTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.CravaçãoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CravaçãoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CravaçãoTextEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.CravaçãoTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CravaçãoTextEdit.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.CravaçãoTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CravaçãoTextEdit.Properties.Mask.EditMask = "n2"
        Me.CravaçãoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.CravaçãoTextEdit.Size = New System.Drawing.Size(79, 26)
        Me.CravaçãoTextEdit.TabIndex = 3
        '
        'MadeiraTextEdit
        '
        Me.MadeiraTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "vFund", True))
        Me.MadeiraTextEdit.Location = New System.Drawing.Point(112, 436)
        Me.MadeiraTextEdit.MenuManager = Me.ribbonControl1
        Me.MadeiraTextEdit.Name = "MadeiraTextEdit"
        Me.MadeiraTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MadeiraTextEdit.Properties.Appearance.Options.UseFont = True
        Me.MadeiraTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.MadeiraTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.MadeiraTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MadeiraTextEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.MadeiraTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MadeiraTextEdit.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.MadeiraTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MadeiraTextEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.MadeiraTextEdit.Properties.MaskSettings.Set("mask", "n2")
        Me.MadeiraTextEdit.Size = New System.Drawing.Size(79, 26)
        Me.MadeiraTextEdit.TabIndex = 4
        '
        'CouroTextEdit
        '
        Me.CouroTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Couro", True))
        Me.CouroTextEdit.Location = New System.Drawing.Point(112, 462)
        Me.CouroTextEdit.MenuManager = Me.ribbonControl1
        Me.CouroTextEdit.Name = "CouroTextEdit"
        Me.CouroTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CouroTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CouroTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.CouroTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CouroTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CouroTextEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.CouroTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CouroTextEdit.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.CouroTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CouroTextEdit.Properties.Mask.EditMask = "n2"
        Me.CouroTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.CouroTextEdit.Size = New System.Drawing.Size(79, 26)
        Me.CouroTextEdit.TabIndex = 5
        '
        'OutrasTextEdit
        '
        Me.OutrasTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Outras", True))
        Me.OutrasTextEdit.Location = New System.Drawing.Point(112, 488)
        Me.OutrasTextEdit.MenuManager = Me.ribbonControl1
        Me.OutrasTextEdit.Name = "OutrasTextEdit"
        Me.OutrasTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutrasTextEdit.Properties.Appearance.Options.UseFont = True
        Me.OutrasTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.OutrasTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.OutrasTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.OutrasTextEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.OutrasTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OutrasTextEdit.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.OutrasTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OutrasTextEdit.Properties.Mask.EditMask = "n2"
        Me.OutrasTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.OutrasTextEdit.Size = New System.Drawing.Size(79, 26)
        Me.OutrasTextEdit.TabIndex = 6
        '
        'OficinaTextEdit
        '
        Me.OficinaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Oficina", True))
        Me.OficinaTextEdit.Location = New System.Drawing.Point(112, 543)
        Me.OficinaTextEdit.MenuManager = Me.ribbonControl1
        Me.OficinaTextEdit.Name = "OficinaTextEdit"
        Me.OficinaTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OficinaTextEdit.Properties.Appearance.Options.UseFont = True
        Me.OficinaTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.OficinaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.OficinaTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.OficinaTextEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.OficinaTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OficinaTextEdit.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.OficinaTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OficinaTextEdit.Properties.Mask.EditMask = "n2"
        Me.OficinaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.OficinaTextEdit.Size = New System.Drawing.Size(79, 26)
        Me.OficinaTextEdit.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(863, 179)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(74, 15)
        Me.LabelControl1.TabIndex = 26
        Me.LabelControl1.Text = "LabelControl1"
        '
        'PrVendaSpinEdit
        '
        Me.PrVendaSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "PrVenda", True))
        Me.PrVendaSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PrVendaSpinEdit.Location = New System.Drawing.Point(112, 596)
        Me.PrVendaSpinEdit.MenuManager = Me.ribbonControl1
        Me.PrVendaSpinEdit.Name = "PrVendaSpinEdit"
        Me.PrVendaSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrVendaSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.PrVendaSpinEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PrVendaSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.PrVendaSpinEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.PrVendaSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PrVendaSpinEdit.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.PrVendaSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PrVendaSpinEdit.Properties.Mask.EditMask = "n2"
        Me.PrVendaSpinEdit.Size = New System.Drawing.Size(79, 26)
        Me.PrVendaSpinEdit.TabIndex = 8
        '
        'btnCalc
        '
        Me.btnCalc.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCalc.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalc.Appearance.Options.UseFont = True
        Me.btnCalc.Appearance.Options.UseForeColor = True
        Me.btnCalc.Location = New System.Drawing.Point(116, 280)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 31
        Me.btnCalc.Text = "Atualizar"
        Me.btnCalc.Visible = False
        '
        '_1TabPeçasHistóricoBindingSource
        '
        Me._1TabPeçasHistóricoBindingSource.DataMember = "1TabPeçasHistórico"
        Me._1TabPeçasHistóricoBindingSource.DataSource = Me.DsNovoEstoque
        '
        '_1TabPeçasHistóricoTableAdapter
        '
        Me._1TabPeçasHistóricoTableAdapter.ClearBeforeFill = True
        '
        '_1TabPeçasHistóricoGridControl
        '
        Me._1TabPeçasHistóricoGridControl.DataSource = Me._1TabPeçasHistóricoBindingSource
        Me._1TabPeçasHistóricoGridControl.Location = New System.Drawing.Point(2, 2)
        Me._1TabPeçasHistóricoGridControl.MainView = Me.GridView1
        Me._1TabPeçasHistóricoGridControl.MenuManager = Me.ribbonControl1
        Me._1TabPeçasHistóricoGridControl.Name = "_1TabPeçasHistóricoGridControl"
        Me._1TabPeçasHistóricoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1})
        Me._1TabPeçasHistóricoGridControl.Size = New System.Drawing.Size(587, 74)
        Me._1TabPeçasHistóricoGridControl.TabIndex = 32
        Me._1TabPeçasHistóricoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId2, Me.colIdPeça, Me.colDataReajuste, Me.colCustoAnt, Me.colFatorC, Me.colCusto, Me.colPrVendaAnt, Me.colFatorV, Me.colPrVenda})
        Me.GridView1.GridControl = Me._1TabPeçasHistóricoGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colId2
        '
        Me.colId2.FieldName = "Id"
        Me.colId2.Name = "colId2"
        '
        'colIdPeça
        '
        Me.colIdPeça.FieldName = "IdPeça"
        Me.colIdPeça.Name = "colIdPeça"
        '
        'colDataReajuste
        '
        Me.colDataReajuste.AppearanceCell.Options.UseTextOptions = True
        Me.colDataReajuste.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataReajuste.AppearanceHeader.Options.UseTextOptions = True
        Me.colDataReajuste.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataReajuste.Caption = "Data"
        Me.colDataReajuste.FieldName = "DataReajuste"
        Me.colDataReajuste.Name = "colDataReajuste"
        Me.colDataReajuste.OptionsColumn.AllowEdit = False
        Me.colDataReajuste.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDataReajuste.OptionsColumn.ReadOnly = True
        Me.colDataReajuste.OptionsFilter.AllowAutoFilter = False
        Me.colDataReajuste.OptionsFilter.AllowFilter = False
        Me.colDataReajuste.Visible = True
        Me.colDataReajuste.VisibleIndex = 0
        Me.colDataReajuste.Width = 84
        '
        'colCustoAnt
        '
        Me.colCustoAnt.AppearanceCell.Options.UseTextOptions = True
        Me.colCustoAnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCustoAnt.AppearanceHeader.Options.UseTextOptions = True
        Me.colCustoAnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCustoAnt.Caption = "Custo Ant."
        Me.colCustoAnt.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colCustoAnt.FieldName = "CustoAnt"
        Me.colCustoAnt.Name = "colCustoAnt"
        Me.colCustoAnt.OptionsColumn.AllowEdit = False
        Me.colCustoAnt.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCustoAnt.OptionsColumn.ReadOnly = True
        Me.colCustoAnt.OptionsFilter.AllowAutoFilter = False
        Me.colCustoAnt.OptionsFilter.AllowFilter = False
        Me.colCustoAnt.Visible = True
        Me.colCustoAnt.VisibleIndex = 1
        Me.colCustoAnt.Width = 76
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.MaskSettings.Set("mask", "n")
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        Me.RepositoryItemSpinEdit1.UseMaskAsDisplayFormat = True
        '
        'colFatorC
        '
        Me.colFatorC.AppearanceCell.Options.UseTextOptions = True
        Me.colFatorC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFatorC.AppearanceHeader.Options.UseTextOptions = True
        Me.colFatorC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFatorC.Caption = "Reajuste"
        Me.colFatorC.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colFatorC.FieldName = "FatorC"
        Me.colFatorC.Name = "colFatorC"
        Me.colFatorC.OptionsColumn.AllowEdit = False
        Me.colFatorC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colFatorC.OptionsColumn.ReadOnly = True
        Me.colFatorC.OptionsFilter.AllowAutoFilter = False
        Me.colFatorC.OptionsFilter.AllowFilter = False
        Me.colFatorC.Visible = True
        Me.colFatorC.VisibleIndex = 2
        '
        'colCusto
        '
        Me.colCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCusto.AppearanceHeader.Options.UseTextOptions = True
        Me.colCusto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCusto.Caption = "Novo Custo"
        Me.colCusto.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colCusto.FieldName = "Custo"
        Me.colCusto.Name = "colCusto"
        Me.colCusto.OptionsColumn.AllowEdit = False
        Me.colCusto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCusto.OptionsColumn.ReadOnly = True
        Me.colCusto.OptionsFilter.AllowAutoFilter = False
        Me.colCusto.OptionsFilter.AllowFilter = False
        Me.colCusto.Visible = True
        Me.colCusto.VisibleIndex = 3
        '
        'colPrVendaAnt
        '
        Me.colPrVendaAnt.AppearanceCell.Options.UseTextOptions = True
        Me.colPrVendaAnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrVendaAnt.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrVendaAnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrVendaAnt.Caption = "Pr. Venda Ant."
        Me.colPrVendaAnt.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colPrVendaAnt.FieldName = "PrVendaAnt"
        Me.colPrVendaAnt.Name = "colPrVendaAnt"
        Me.colPrVendaAnt.OptionsColumn.AllowEdit = False
        Me.colPrVendaAnt.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPrVendaAnt.OptionsColumn.ReadOnly = True
        Me.colPrVendaAnt.OptionsFilter.AllowAutoFilter = False
        Me.colPrVendaAnt.OptionsFilter.AllowFilter = False
        Me.colPrVendaAnt.Visible = True
        Me.colPrVendaAnt.VisibleIndex = 4
        Me.colPrVendaAnt.Width = 94
        '
        'colFatorV
        '
        Me.colFatorV.AppearanceCell.Options.UseTextOptions = True
        Me.colFatorV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFatorV.AppearanceHeader.Options.UseTextOptions = True
        Me.colFatorV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFatorV.Caption = "Reajuste"
        Me.colFatorV.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colFatorV.FieldName = "FatorV"
        Me.colFatorV.Name = "colFatorV"
        Me.colFatorV.OptionsColumn.AllowEdit = False
        Me.colFatorV.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colFatorV.OptionsColumn.ReadOnly = True
        Me.colFatorV.OptionsFilter.AllowAutoFilter = False
        Me.colFatorV.OptionsFilter.AllowFilter = False
        Me.colFatorV.Visible = True
        Me.colFatorV.VisibleIndex = 5
        Me.colFatorV.Width = 66
        '
        'colPrVenda
        '
        Me.colPrVenda.AppearanceCell.Options.UseTextOptions = True
        Me.colPrVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrVenda.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrVenda.Caption = "Novo Pr. Venda"
        Me.colPrVenda.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colPrVenda.FieldName = "PrVenda"
        Me.colPrVenda.Name = "colPrVenda"
        Me.colPrVenda.OptionsColumn.AllowEdit = False
        Me.colPrVenda.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPrVenda.OptionsColumn.ReadOnly = True
        Me.colPrVenda.OptionsFilter.AllowAutoFilter = False
        Me.colPrVenda.OptionsFilter.AllowFilter = False
        Me.colPrVenda.Visible = True
        Me.colPrVenda.VisibleIndex = 6
        Me.colPrVenda.Width = 96
        '
        'LayoutControl
        '
        Me.LayoutControl.Controls.Add(Me._1TabPeçasHistóricoGridControl)
        Me.LayoutControl.Location = New System.Drawing.Point(252, 594)
        Me.LayoutControl.Name = "LayoutControl"
        Me.LayoutControl.OptionsCustomizationForm.DefaultPage = DevExpress.XtraLayout.CustomizationPage.LayoutTreeView
        Me.LayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(700, 200, 650, 400)
        Me.LayoutControl.Root = Me.Root
        Me.LayoutControl.Size = New System.Drawing.Size(611, 28)
        Me.LayoutControl.TabIndex = 33
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.ExpandButtonVisible = True
        Me.Root.Expanded = False
        Me.Root.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1})
        Me.Root.Name = "Root"
        Me.Root.ShowTabPageCloseButton = True
        Me.Root.Size = New System.Drawing.Size(611, 28)
        Me.Root.Text = "HISTÓRICO DE REAJUSTES"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(591, 78)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._1TabPeçasHistóricoGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(104, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(591, 78)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'SimpleButton
        '
        Me.SimpleButton.Location = New System.Drawing.Point(297, 211)
        Me.SimpleButton.Name = "SimpleButton"
        Me.SimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton.TabIndex = 35
        Me.SimpleButton.Visible = False
        '
        'PictureEditPeça
        '
        Me.PictureEditPeça.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Foto", True))
        Me.PictureEditPeça.Location = New System.Drawing.Point(978, 57)
        Me.PictureEditPeça.MenuManager = Me.ribbonControl1
        Me.PictureEditPeça.Name = "PictureEditPeça"
        Me.PictureEditPeça.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEditPeça.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEditPeça.Size = New System.Drawing.Size(354, 330)
        Me.PictureEditPeça.TabIndex = 37
        '
        'XtraOpenFileDialogFoto
        '
        Me.XtraOpenFileDialogFoto.FileName = "XtraOpenFileDialog1"
        '
        'SizeModeSpinEdit
        '
        Me.SizeModeSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "SizeMode", True))
        Me.SizeModeSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SizeModeSpinEdit.Location = New System.Drawing.Point(31, 153)
        Me.SizeModeSpinEdit.MenuManager = Me.ribbonControl1
        Me.SizeModeSpinEdit.Name = "SizeModeSpinEdit"
        Me.SizeModeSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.SizeModeSpinEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.SizeModeSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.SizeModeSpinEdit.Properties.Appearance.Options.UseForeColor = True
        Me.SizeModeSpinEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SizeModeSpinEdit.Size = New System.Drawing.Size(19, 18)
        Me.SizeModeSpinEdit.TabIndex = 39
        Me.SizeModeSpinEdit.TabStop = False
        '
        'txt_pFund
        '
        Me.txt_pFund.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "pFund", True))
        Me.txt_pFund.Location = New System.Drawing.Point(191, 436)
        Me.txt_pFund.MenuManager = Me.ribbonControl1
        Me.txt_pFund.Name = "txt_pFund"
        Me.txt_pFund.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pFund.Properties.Appearance.Options.UseFont = True
        Me.txt_pFund.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_pFund.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_pFund.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_pFund.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txt_pFund.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_pFund.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txt_pFund.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_pFund.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_pFund.Properties.MaskSettings.Set("mask", "n2")
        Me.txt_pFund.Size = New System.Drawing.Size(51, 26)
        Me.txt_pFund.TabIndex = 5
        '
        'frmEstoque
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1352, 722)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txt_pFund)
        Me.Controls.Add(Me.SizeModeSpinEdit)
        Me.Controls.Add(Me.PictureEditPeça)
        Me.Controls.Add(Me.SimpleButton)
        Me.Controls.Add(Me.LayoutControl)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(PrVendaLabel)
        Me.Controls.Add(Me.PrVendaSpinEdit)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(OficinaLabel)
        Me.Controls.Add(Me.OficinaTextEdit)
        Me.Controls.Add(OutrasLabel)
        Me.Controls.Add(Me.OutrasTextEdit)
        Me.Controls.Add(CouroLabel)
        Me.Controls.Add(Me.CouroTextEdit)
        Me.Controls.Add(MadeiraLabel)
        Me.Controls.Add(Me.MadeiraTextEdit)
        Me.Controls.Add(CravaçãoLabel)
        Me.Controls.Add(Me.CravaçãoTextEdit)
        Me.Controls.Add(Me.PEDRASGridControl)
        Me.Controls.Add(MOIntLabel)
        Me.Controls.Add(Me.MOIntTextEdit)
        Me.Controls.Add(MOExtLabel)
        Me.Controls.Add(Me.MOExtTextEdit)
        Me.Controls.Add(CustoLabel)
        Me.Controls.Add(Me.txtCusto)
        Me.Controls.Add(Me.METAISGridControl)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IconOptions.Icon = CType(resources.GetObject("frmEstoque.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmEstoque"
        Me.Ribbon = Me.ribbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cbLocal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._1TabPeçasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNovoEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoltaCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataFabricDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataFabricDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OficialCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrigemComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataRegDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataRegDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModêloTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClasseComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDPeçaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendidaCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.METAISBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.METAISGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colOuroQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colOuroV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPaladiumQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPrataQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPlatinaQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPerdaPerc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPerdaQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colSistemaQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colTotalQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colTotalValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colSistemaValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPaladiumV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPrataV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPlatinaV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCusto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOExtTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOIntTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEDRASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEDRASGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colId1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colDiamantesCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colDiamantesQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colDiamantesValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colDiamantes2CT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colDiamantes2Qtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colDiamantes2Valor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewField1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPedrasBrasQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPedrasBrasValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewField2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPerolasQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPerolasValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewField3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colRubiQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colRubiValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewField4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colSafiraQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colSafiraValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewField5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colEsmeraldaQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colEsmeraldaValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewField6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colCitrinoQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colCitrinoValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CravaçãoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MadeiraTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CouroTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutrasTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OficinaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrVendaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._1TabPeçasHistóricoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._1TabPeçasHistóricoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEditPeça.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeModeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCompras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPeçasCompradas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents IDPeçaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DsNovoEstoque As dsNovoEstoque
    Friend WithEvents _1TabPeçasBindingSource As BindingSource
    Friend WithEvents _1TabPeçasTableAdapter As dsNovoEstoqueTableAdapters._1TabPeçasTableAdapter
    Friend WithEvents TableAdapterManager As dsNovoEstoqueTableAdapters.TableAdapterManager
    Friend WithEvents OficialCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents OrigemComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DataRegDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ModêloTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ClasseComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents METAISTableAdapter As dsNovoEstoqueTableAdapters.METAISTableAdapter
    Friend WithEvents METAISBindingSource As BindingSource
    Friend WithEvents METAISGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colOuroQtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colOuroV As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPaladiumQtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPrataQtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPlatinaQtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPerdaPerc As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPerdaQtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colSistemaQtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colTotalQtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colTotalValor As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colSistemaValor As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPaladiumV As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPrataV As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPlatinaV As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents txtCusto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MOExtTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MOIntTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PEDRASBindingSource As BindingSource
    Friend WithEvents PEDRASTableAdapter As dsNovoEstoqueTableAdapters.PEDRASTableAdapter
    Friend WithEvents PEDRASGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents CravaçãoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MadeiraTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CouroTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OutrasTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OficinaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnEstornar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grpEstornar As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LayoutView2 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colDiamantesCT As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colDiamantesQtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colDiamantesValor As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colDiamantes2CT As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colDiamantes2Qtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colDiamantes2Valor As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colBrasCT As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPedrasBrasQtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPedrasBrasValor As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPerolasCT As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPerolasQtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPerolasValor As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colRubisCT As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colRubiQtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colRubiValor As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colSafirasCT As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colSafiraQtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colSafiraValor As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colEsmeraldasCT As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colEsmeraldaQtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colEsmeraldaValor As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPedrasCT As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colCitrinoQtde As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colCitrinoValor As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents VendidaCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ObsTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DataFabricDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PrVendaSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnCalc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents layoutViewField_colId As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colOuroQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colOuroV As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPaladiumQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPrataQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPlatinaQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPerdaPerc As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPerdaQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colSistemaQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colTotalQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colTotalValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colSistemaValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPaladiumV As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPrataV As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPlatinaV As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents item1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item2 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item3 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents item5 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item6 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents item8 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item9 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item10 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents item11 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents item15 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item16 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents _1TabPeçasHistóricoBindingSource As BindingSource
    Friend WithEvents _1TabPeçasHistóricoTableAdapter As dsNovoEstoqueTableAdapters._1TabPeçasHistóricoTableAdapter
    Friend WithEvents _1TabPeçasHistóricoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdPeça As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataReajuste As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustoAnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFatorC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrVendaAnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFatorV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnDel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnComprador As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents SimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents layoutViewField_colId1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colDiamantesCT As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colDiamantesQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colDiamantesValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colDiamantes2CT As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colDiamantes2Qtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colDiamantes2Valor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewField1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPedrasBrasQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPedrasBrasValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewField2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPerolasQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPerolasValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewField3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colRubiQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colRubiValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewField4 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colSafiraQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colSafiraValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewField5 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colEsmeraldaQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colEsmeraldaValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewField6 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colCitrinoQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colCitrinoValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard2 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents item12 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item13 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item14 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item17 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item18 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item19 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item20 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item21 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item22 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item23 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item25 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents item24 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents item27 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnVoltar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents VoltaCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnFoto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PictureEditPeça As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnSelFoto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelFoto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grpFoto As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents grpFechar As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents XtraOpenFileDialogFoto As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents SizeModeSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnSalvarComo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txt_pFund As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbLocal As DevExpress.XtraEditors.ComboBoxEdit
End Class
