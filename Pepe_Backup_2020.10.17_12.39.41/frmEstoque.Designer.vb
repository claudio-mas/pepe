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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstoque))
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
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.grpEstornar = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me._1TabPeçasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNovoEstoque = New Pepe.dsNovoEstoque()
        Me.OficialCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ObsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OrigemComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.DataRegDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ModêloTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ClasseComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.IDPeçaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me._1TabPeçasTableAdapter = New Pepe.dsNovoEstoqueTableAdapters._1TabPeçasTableAdapter()
        Me.TableAdapterManager = New Pepe.dsNovoEstoqueTableAdapters.TableAdapterManager()
        Me.METAISTableAdapter = New Pepe.dsNovoEstoqueTableAdapters.METAISTableAdapter()
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
        Me.PEDRASTableAdapter = New Pepe.dsNovoEstoqueTableAdapters.PEDRASTableAdapter()
        Me.PEDRASGridControl = New DevExpress.XtraGrid.GridControl()
        Me.LayoutView2 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colDiamantesCT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colDiamantesQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colDiamantesValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colDiamantes2CT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colDiamantes2Qtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colDiamantes2Valor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colBrasCT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colPedrasBrasQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colPedrasBrasValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colPerolasCT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colPerolasQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colPerolasValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colRubisCT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colRubiQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colRubiValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colSafirasCT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colSafiraQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colSafiraValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colEsmeraldasCT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colEsmeraldaQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colEsmeraldaValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colPedrasCT = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colCitrinoQtde = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colCitrinoValor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.CravaçãoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MadeiraTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CouroTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OutrasTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OficinaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.VendidaCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutViewCard2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.layoutViewField_colDiamantesCT = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colDiamantes2CT = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colDiamantesQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colDiamantesValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colDiamantes2Qtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colDiamantes2Valor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colPedrasBrasQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colPedrasBrasValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colPerolasQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colPerolasValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colRubiQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colRubiValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colSafiraQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colSafiraValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colEsmeraldaQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colEsmeraldaValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colCitrinoQtde = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colCitrinoValor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
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
        Me.item26 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.item27 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.item28 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.item29 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.item30 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.item31 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.layoutViewField_colBrasCT = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colPerolasCT = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colRubisCT = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colSafirasCT = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colEsmeraldasCT = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colPedrasCT = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colId1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
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
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._1TabPeçasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNovoEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OficialCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrigemComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataRegDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataRegDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModêloTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClasseComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDPeçaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.CravaçãoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MadeiraTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CouroTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutrasTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OficinaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendidaCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colDiamantesCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colDiamantes2CT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colDiamantesQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colDiamantesValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colDiamantes2Qtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colDiamantes2Valor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPedrasBrasQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPedrasBrasValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPerolasQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPerolasValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colRubiQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colRubiValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colSafiraQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colSafiraValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colEsmeraldaQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colEsmeraldaValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colCitrinoQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colCitrinoValor, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.item26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colBrasCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPerolasCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colRubisCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colSafirasCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colEsmeraldasCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPedrasCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colId1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClasseLabel
        '
        ClasseLabel.AutoSize = True
        ClasseLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClasseLabel.Location = New System.Drawing.Point(33, 16)
        ClasseLabel.Name = "ClasseLabel"
        ClasseLabel.Size = New System.Drawing.Size(32, 15)
        ClasseLabel.TabIndex = 0
        ClasseLabel.Text = "Peça"
        '
        'ModêloLabel
        '
        ModêloLabel.AutoSize = True
        ModêloLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModêloLabel.Location = New System.Drawing.Point(187, 16)
        ModêloLabel.Name = "ModêloLabel"
        ModêloLabel.Size = New System.Drawing.Size(27, 15)
        ModêloLabel.TabIndex = 2
        ModêloLabel.Text = "Ref."
        '
        'DataRegLabel
        '
        DataRegLabel.AutoSize = True
        DataRegLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataRegLabel.Location = New System.Drawing.Point(8, 43)
        DataRegLabel.Name = "DataRegLabel"
        DataRegLabel.Size = New System.Drawing.Size(57, 15)
        DataRegLabel.TabIndex = 4
        DataRegLabel.Text = "Data Reg."
        '
        'OrigemLabel
        '
        OrigemLabel.AutoSize = True
        OrigemLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OrigemLabel.Location = New System.Drawing.Point(186, 43)
        OrigemLabel.Name = "OrigemLabel"
        OrigemLabel.Size = New System.Drawing.Size(28, 15)
        OrigemLabel.TabIndex = 6
        OrigemLabel.Text = "A/C"
        '
        'ObsLabel
        '
        ObsLabel.AutoSize = True
        ObsLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsLabel.Location = New System.Drawing.Point(34, 70)
        ObsLabel.Name = "ObsLabel"
        ObsLabel.Size = New System.Drawing.Size(31, 15)
        ObsLabel.TabIndex = 8
        ObsLabel.Text = "Obs."
        '
        'OficialLabel
        '
        OficialLabel.AutoSize = True
        OficialLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OficialLabel.Location = New System.Drawing.Point(46, 95)
        OficialLabel.Name = "OficialLabel"
        OficialLabel.Size = New System.Drawing.Size(18, 15)
        OficialLabel.TabIndex = 10
        OficialLabel.Text = "W"
        '
        'CustoLabel
        '
        CustoLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CustoLabel.ForeColor = System.Drawing.Color.Navy
        CustoLabel.Location = New System.Drawing.Point(5, 521)
        CustoLabel.Name = "CustoLabel"
        CustoLabel.Size = New System.Drawing.Size(59, 15)
        CustoLabel.TabIndex = 15
        CustoLabel.Text = "Custo"
        CustoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MOExtLabel
        '
        MOExtLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MOExtLabel.ForeColor = System.Drawing.Color.Navy
        MOExtLabel.Location = New System.Drawing.Point(5, 310)
        MOExtLabel.Name = "MOExtLabel"
        MOExtLabel.Size = New System.Drawing.Size(59, 15)
        MOExtLabel.TabIndex = 16
        MOExtLabel.Text = "M. O. Ext."
        MOExtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MOIntLabel
        '
        MOIntLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MOIntLabel.ForeColor = System.Drawing.Color.Navy
        MOIntLabel.Location = New System.Drawing.Point(5, 336)
        MOIntLabel.Name = "MOIntLabel"
        MOIntLabel.Size = New System.Drawing.Size(59, 15)
        MOIntLabel.TabIndex = 17
        MOIntLabel.Text = "M. O. Int."
        MOIntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CravaçãoLabel
        '
        CravaçãoLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CravaçãoLabel.ForeColor = System.Drawing.Color.Navy
        CravaçãoLabel.Location = New System.Drawing.Point(5, 362)
        CravaçãoLabel.Name = "CravaçãoLabel"
        CravaçãoLabel.Size = New System.Drawing.Size(59, 15)
        CravaçãoLabel.TabIndex = 19
        CravaçãoLabel.Text = "Cravação"
        CravaçãoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MadeiraLabel
        '
        MadeiraLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MadeiraLabel.ForeColor = System.Drawing.Color.Navy
        MadeiraLabel.Location = New System.Drawing.Point(5, 388)
        MadeiraLabel.Name = "MadeiraLabel"
        MadeiraLabel.Size = New System.Drawing.Size(59, 15)
        MadeiraLabel.TabIndex = 20
        MadeiraLabel.Text = "Madeira"
        MadeiraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CouroLabel
        '
        CouroLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CouroLabel.ForeColor = System.Drawing.Color.Navy
        CouroLabel.Location = New System.Drawing.Point(5, 414)
        CouroLabel.Name = "CouroLabel"
        CouroLabel.Size = New System.Drawing.Size(59, 15)
        CouroLabel.TabIndex = 21
        CouroLabel.Text = "Couro"
        CouroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OutrasLabel
        '
        OutrasLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OutrasLabel.ForeColor = System.Drawing.Color.Navy
        OutrasLabel.Location = New System.Drawing.Point(5, 440)
        OutrasLabel.Name = "OutrasLabel"
        OutrasLabel.Size = New System.Drawing.Size(59, 15)
        OutrasLabel.TabIndex = 22
        OutrasLabel.Text = "Outras"
        OutrasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OficinaLabel
        '
        OficinaLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OficinaLabel.ForeColor = System.Drawing.Color.Navy
        OficinaLabel.Location = New System.Drawing.Point(5, 495)
        OficinaLabel.Name = "OficinaLabel"
        OficinaLabel.Size = New System.Drawing.Size(59, 15)
        OficinaLabel.TabIndex = 23
        OficinaLabel.Text = "Oficina"
        OficinaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnNovo, Me.btnSalvar, Me.btnUndo, Me.BarButtonItem1, Me.btnCompras, Me.btnPeçasCompradas, Me.btnEstornar})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 11
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
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
        Me.btnNovo.Caption = "Entrada"
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
        'btnEstornar
        '
        Me.btnEstornar.Caption = "Estornar"
        Me.btnEstornar.Glyph = CType(resources.GetObject("btnEstornar.Glyph"), System.Drawing.Image)
        Me.btnEstornar.Id = 10
        Me.btnEstornar.Name = "btnEstornar"
        Me.btnEstornar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2, Me.grpEstornar})
        Me.ribbonPage1.Image = CType(resources.GetObject("ribbonPage1.Image"), System.Drawing.Image)
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "ESTOQUE"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnFechar)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnNovo, True)
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
        'grpEstornar
        '
        Me.grpEstornar.ItemLinks.Add(Me.btnEstornar)
        Me.grpEstornar.Name = "grpEstornar"
        Me.grpEstornar.ShowCaptionButton = False
        Me.grpEstornar.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(OficialLabel)
        Me.PanelControl1.Controls.Add(Me.RadioGroup1)
        Me.PanelControl1.Controls.Add(Me.OficialCheckEdit)
        Me.PanelControl1.Controls.Add(ObsLabel)
        Me.PanelControl1.Controls.Add(Me.ObsTextEdit)
        Me.PanelControl1.Controls.Add(OrigemLabel)
        Me.PanelControl1.Controls.Add(Me.OrigemComboBoxEdit)
        Me.PanelControl1.Controls.Add(DataRegLabel)
        Me.PanelControl1.Controls.Add(Me.DataRegDateEdit)
        Me.PanelControl1.Controls.Add(ModêloLabel)
        Me.PanelControl1.Controls.Add(Me.ModêloTextEdit)
        Me.PanelControl1.Controls.Add(ClasseLabel)
        Me.PanelControl1.Controls.Add(Me.ClasseComboBoxEdit)
        Me.PanelControl1.Location = New System.Drawing.Point(336, 152)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(333, 130)
        Me.PanelControl1.TabIndex = 8
        '
        'RadioGroup1
        '
        Me.RadioGroup1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Família", True))
        Me.RadioGroup1.Location = New System.Drawing.Point(158, 94)
        Me.RadioGroup1.MenuManager = Me.ribbonControl1
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.Appearance.Options.UseTextOptions = True
        Me.RadioGroup1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Ag", "Ag"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Ou", "Ou"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Boutique", "Bou")})
        Me.RadioGroup1.Size = New System.Drawing.Size(160, 23)
        Me.RadioGroup1.TabIndex = 26
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
        'OficialCheckEdit
        '
        Me.OficialCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Oficial", True))
        Me.OficialCheckEdit.Location = New System.Drawing.Point(68, 92)
        Me.OficialCheckEdit.MenuManager = Me.ribbonControl1
        Me.OficialCheckEdit.Name = "OficialCheckEdit"
        Me.OficialCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OficialCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.OficialCheckEdit.Properties.Caption = ""
        Me.OficialCheckEdit.Size = New System.Drawing.Size(18, 19)
        Me.OficialCheckEdit.TabIndex = 11
        '
        'ObsTextEdit
        '
        Me.ObsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Obs", True))
        Me.ObsTextEdit.Location = New System.Drawing.Point(69, 67)
        Me.ObsTextEdit.MenuManager = Me.ribbonControl1
        Me.ObsTextEdit.Name = "ObsTextEdit"
        Me.ObsTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObsTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ObsTextEdit.Size = New System.Drawing.Size(249, 22)
        Me.ObsTextEdit.TabIndex = 9
        '
        'OrigemComboBoxEdit
        '
        Me.OrigemComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Origem", True))
        Me.OrigemComboBoxEdit.Location = New System.Drawing.Point(218, 40)
        Me.OrigemComboBoxEdit.MenuManager = Me.ribbonControl1
        Me.OrigemComboBoxEdit.Name = "OrigemComboBoxEdit"
        Me.OrigemComboBoxEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrigemComboBoxEdit.Properties.Appearance.Options.UseFont = True
        Me.OrigemComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrigemComboBoxEdit.Properties.Items.AddRange(New Object() {"F.P.", "F.F."})
        Me.OrigemComboBoxEdit.Size = New System.Drawing.Size(100, 22)
        Me.OrigemComboBoxEdit.TabIndex = 7
        '
        'DataRegDateEdit
        '
        Me.DataRegDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "DataReg", True))
        Me.DataRegDateEdit.EditValue = Nothing
        Me.DataRegDateEdit.Location = New System.Drawing.Point(69, 40)
        Me.DataRegDateEdit.MenuManager = Me.ribbonControl1
        Me.DataRegDateEdit.Name = "DataRegDateEdit"
        Me.DataRegDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataRegDateEdit.Properties.Appearance.Options.UseFont = True
        Me.DataRegDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataRegDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataRegDateEdit.Size = New System.Drawing.Size(100, 22)
        Me.DataRegDateEdit.TabIndex = 5
        '
        'ModêloTextEdit
        '
        Me.ModêloTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Modêlo", True))
        Me.ModêloTextEdit.Location = New System.Drawing.Point(218, 13)
        Me.ModêloTextEdit.MenuManager = Me.ribbonControl1
        Me.ModêloTextEdit.Name = "ModêloTextEdit"
        Me.ModêloTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModêloTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ModêloTextEdit.Size = New System.Drawing.Size(100, 22)
        Me.ModêloTextEdit.TabIndex = 3
        '
        'ClasseComboBoxEdit
        '
        Me.ClasseComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Classe", True))
        Me.ClasseComboBoxEdit.Location = New System.Drawing.Point(69, 13)
        Me.ClasseComboBoxEdit.MenuManager = Me.ribbonControl1
        Me.ClasseComboBoxEdit.Name = "ClasseComboBoxEdit"
        Me.ClasseComboBoxEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClasseComboBoxEdit.Properties.Appearance.Options.UseFont = True
        Me.ClasseComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ClasseComboBoxEdit.Properties.Items.AddRange(New Object() {"An", "Br", "C / Gar", "Mad", "Pen", "Pul", "Bou", "DESCAN", "COU", "PERFIL"})
        Me.ClasseComboBoxEdit.Size = New System.Drawing.Size(100, 22)
        Me.ClasseComboBoxEdit.TabIndex = 1
        '
        'IDPeçaTextEdit
        '
        Me.IDPeçaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "IDPeça", True))
        Me.IDPeçaTextEdit.Location = New System.Drawing.Point(988, 150)
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
        '_1TabPeçasTableAdapter
        '
        Me._1TabPeçasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._1TabPeçasTableAdapter = Me._1TabPeçasTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.METAISTableAdapter = Me.METAISTableAdapter
        Me.TableAdapterManager.PEDRASTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pepe.dsNovoEstoqueTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'METAISTableAdapter
        '
        Me.METAISTableAdapter.ClearBeforeFill = True
        '
        'METAISBindingSource
        '
        Me.METAISBindingSource.DataMember = "1TabPeças_METAIS"
        Me.METAISBindingSource.DataSource = Me._1TabPeçasBindingSource
        '
        'METAISGridControl
        '
        Me.METAISGridControl.DataSource = Me.METAISBindingSource
        Me.METAISGridControl.Location = New System.Drawing.Point(647, 291)
        Me.METAISGridControl.MainView = Me.LayoutView1
        Me.METAISGridControl.MenuManager = Me.ribbonControl1
        Me.METAISGridControl.Name = "METAISGridControl"
        Me.METAISGridControl.Size = New System.Drawing.Size(352, 240)
        Me.METAISGridControl.TabIndex = 14
        Me.METAISGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.LayoutView1})
        '
        'LayoutView1
        '
        Me.LayoutView1.Appearance.Card.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LayoutView1.Appearance.Card.Options.UseFont = True
        Me.LayoutView1.Appearance.FieldEditingValue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LayoutView1.Appearance.FieldEditingValue.Options.UseFont = True
        Me.LayoutView1.Appearance.FieldEditingValue.Options.UseTextOptions = True
        Me.LayoutView1.Appearance.FieldEditingValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LayoutView1.Appearance.FieldValue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LayoutView1.Appearance.FieldValue.Options.UseFont = True
        Me.LayoutView1.Appearance.SeparatorLine.BorderColor = System.Drawing.Color.Black
        Me.LayoutView1.Appearance.SeparatorLine.Options.UseBorderColor = True
        Me.LayoutView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LayoutView1.CardMinSize = New System.Drawing.Size(326, 187)
        Me.LayoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colId, Me.colOuroQtde, Me.colOuroV, Me.colPaladiumQtde, Me.colPrataQtde, Me.colPlatinaQtde, Me.colPerdaPerc, Me.colPerdaQtde, Me.colSistemaQtde, Me.colTotalQtde, Me.colTotalValor, Me.colSistemaValor, Me.colPaladiumV, Me.colPrataV, Me.colPlatinaV})
        Me.LayoutView1.GridControl = Me.METAISGridControl
        Me.LayoutView1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colSistemaValor, Me.layoutViewField_colPerdaPerc, Me.layoutViewField_colId, Me.layoutViewField_colPlatinaV, Me.layoutViewField_colPaladiumV})
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.OptionsBehavior.AllowRuntimeCustomization = False
        Me.LayoutView1.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.LayoutView1.OptionsCustomization.AllowFilter = False
        Me.LayoutView1.OptionsCustomization.AllowSort = False
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
        Me.layoutViewField_colId.Size = New System.Drawing.Size(291, 185)
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
        Me.layoutViewField_colOuroQtde.EditorPreferredWidth = 104
        Me.layoutViewField_colOuroQtde.Location = New System.Drawing.Point(46, 17)
        Me.layoutViewField_colOuroQtde.Name = "layoutViewField_colOuroQtde"
        Me.layoutViewField_colOuroQtde.Size = New System.Drawing.Size(108, 24)
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
        Me.layoutViewField_colOuroV.EditorPreferredWidth = 117
        Me.layoutViewField_colOuroV.Location = New System.Drawing.Point(154, 17)
        Me.layoutViewField_colOuroV.Name = "layoutViewField_colOuroV"
        Me.layoutViewField_colOuroV.Size = New System.Drawing.Size(121, 24)
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
        Me.layoutViewField_colPaladiumQtde.EditorPreferredWidth = 104
        Me.layoutViewField_colPaladiumQtde.Location = New System.Drawing.Point(46, 137)
        Me.layoutViewField_colPaladiumQtde.Name = "layoutViewField_colPaladiumQtde"
        Me.layoutViewField_colPaladiumQtde.Size = New System.Drawing.Size(108, 24)
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
        Me.layoutViewField_colPrataQtde.EditorPreferredWidth = 104
        Me.layoutViewField_colPrataQtde.Location = New System.Drawing.Point(46, 89)
        Me.layoutViewField_colPrataQtde.Name = "layoutViewField_colPrataQtde"
        Me.layoutViewField_colPrataQtde.Size = New System.Drawing.Size(108, 24)
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
        Me.layoutViewField_colPlatinaQtde.EditorPreferredWidth = 104
        Me.layoutViewField_colPlatinaQtde.Location = New System.Drawing.Point(46, 113)
        Me.layoutViewField_colPlatinaQtde.Name = "layoutViewField_colPlatinaQtde"
        Me.layoutViewField_colPlatinaQtde.Size = New System.Drawing.Size(108, 24)
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
        Me.layoutViewField_colPerdaPerc.Size = New System.Drawing.Size(291, 185)
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
        Me.layoutViewField_colPerdaQtde.EditorPreferredWidth = 104
        Me.layoutViewField_colPerdaQtde.Location = New System.Drawing.Point(46, 41)
        Me.layoutViewField_colPerdaQtde.Name = "layoutViewField_colPerdaQtde"
        Me.layoutViewField_colPerdaQtde.Size = New System.Drawing.Size(108, 24)
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
        Me.layoutViewField_colSistemaQtde.EditorPreferredWidth = 104
        Me.layoutViewField_colSistemaQtde.Location = New System.Drawing.Point(46, 65)
        Me.layoutViewField_colSistemaQtde.Name = "layoutViewField_colSistemaQtde"
        Me.layoutViewField_colSistemaQtde.Size = New System.Drawing.Size(108, 24)
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
        Me.layoutViewField_colTotalQtde.EditorPreferredWidth = 104
        Me.layoutViewField_colTotalQtde.Location = New System.Drawing.Point(46, 161)
        Me.layoutViewField_colTotalQtde.Name = "layoutViewField_colTotalQtde"
        Me.layoutViewField_colTotalQtde.Size = New System.Drawing.Size(108, 24)
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
        Me.layoutViewField_colTotalValor.EditorPreferredWidth = 117
        Me.layoutViewField_colTotalValor.Location = New System.Drawing.Point(154, 161)
        Me.layoutViewField_colTotalValor.Name = "layoutViewField_colTotalValor"
        Me.layoutViewField_colTotalValor.Size = New System.Drawing.Size(121, 24)
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
        Me.layoutViewField_colSistemaValor.Size = New System.Drawing.Size(291, 185)
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
        Me.layoutViewField_colPaladiumV.Size = New System.Drawing.Size(291, 185)
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
        Me.layoutViewField_colPrataV.EditorPreferredWidth = 117
        Me.layoutViewField_colPrataV.Location = New System.Drawing.Point(154, 89)
        Me.layoutViewField_colPrataV.Name = "layoutViewField_colPrataV"
        Me.layoutViewField_colPrataV.Size = New System.Drawing.Size(121, 24)
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
        Me.layoutViewField_colPlatinaV.Size = New System.Drawing.Size(291, 185)
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
        Me.item4.Location = New System.Drawing.Point(154, 41)
        Me.item4.Name = "item4"
        Me.item4.Size = New System.Drawing.Size(121, 48)
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
        Me.item6.Size = New System.Drawing.Size(108, 17)
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
        Me.item8.Location = New System.Drawing.Point(154, 0)
        Me.item8.Name = "item8"
        Me.item8.Size = New System.Drawing.Size(121, 17)
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
        Me.item10.Location = New System.Drawing.Point(154, 113)
        Me.item10.MinSize = New System.Drawing.Size(104, 24)
        Me.item10.Name = "item10"
        Me.item10.Size = New System.Drawing.Size(121, 24)
        Me.item10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.item10.TextSize = New System.Drawing.Size(0, 0)
        '
        'item11
        '
        Me.item11.AllowHotTrack = False
        Me.item11.CustomizationFormText = "item11"
        Me.item11.Location = New System.Drawing.Point(154, 137)
        Me.item11.Name = "item11"
        Me.item11.Size = New System.Drawing.Size(121, 24)
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
        Me.txtCusto.Location = New System.Drawing.Point(68, 518)
        Me.txtCusto.MenuManager = Me.ribbonControl1
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusto.Properties.Appearance.Options.UseFont = True
        Me.txtCusto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCusto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCusto.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtCusto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCusto.Size = New System.Drawing.Size(79, 22)
        Me.txtCusto.TabIndex = 16
        '
        'MOExtTextEdit
        '
        Me.MOExtTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "MOExt", True))
        Me.MOExtTextEdit.Location = New System.Drawing.Point(68, 307)
        Me.MOExtTextEdit.MenuManager = Me.ribbonControl1
        Me.MOExtTextEdit.Name = "MOExtTextEdit"
        Me.MOExtTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOExtTextEdit.Properties.Appearance.Options.UseFont = True
        Me.MOExtTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.MOExtTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.MOExtTextEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.MOExtTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MOExtTextEdit.Size = New System.Drawing.Size(79, 22)
        Me.MOExtTextEdit.TabIndex = 17
        '
        'MOIntTextEdit
        '
        Me.MOIntTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "MOInt", True))
        Me.MOIntTextEdit.Location = New System.Drawing.Point(68, 333)
        Me.MOIntTextEdit.MenuManager = Me.ribbonControl1
        Me.MOIntTextEdit.Name = "MOIntTextEdit"
        Me.MOIntTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOIntTextEdit.Properties.Appearance.Options.UseFont = True
        Me.MOIntTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.MOIntTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.MOIntTextEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.MOIntTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MOIntTextEdit.Size = New System.Drawing.Size(79, 22)
        Me.MOIntTextEdit.TabIndex = 18
        '
        'PEDRASBindingSource
        '
        Me.PEDRASBindingSource.DataMember = "1TabPeças_PEDRAS"
        Me.PEDRASBindingSource.DataSource = Me._1TabPeçasBindingSource
        '
        'PEDRASTableAdapter
        '
        Me.PEDRASTableAdapter.ClearBeforeFill = True
        '
        'PEDRASGridControl
        '
        Me.PEDRASGridControl.DataSource = Me.PEDRASBindingSource
        Me.PEDRASGridControl.Location = New System.Drawing.Point(156, 302)
        Me.PEDRASGridControl.MainView = Me.LayoutView2
        Me.PEDRASGridControl.MenuManager = Me.ribbonControl1
        Me.PEDRASGridControl.Name = "PEDRASGridControl"
        Me.PEDRASGridControl.Size = New System.Drawing.Size(488, 240)
        Me.PEDRASGridControl.TabIndex = 19
        Me.PEDRASGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.LayoutView2})
        '
        'LayoutView2
        '
        Me.LayoutView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LayoutView2.CardMinSize = New System.Drawing.Size(352, 231)
        Me.LayoutView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colId1, Me.colDiamantesCT, Me.colDiamantesQtde, Me.colDiamantesValor, Me.colDiamantes2CT, Me.colDiamantes2Qtde, Me.colDiamantes2Valor, Me.colBrasCT, Me.colPedrasBrasQtde, Me.colPedrasBrasValor, Me.colPerolasCT, Me.colPerolasQtde, Me.colPerolasValor, Me.colRubisCT, Me.colRubiQtde, Me.colRubiValor, Me.colSafirasCT, Me.colSafiraQtde, Me.colSafiraValor, Me.colEsmeraldasCT, Me.colEsmeraldaQtde, Me.colEsmeraldaValor, Me.colPedrasCT, Me.colCitrinoQtde, Me.colCitrinoValor})
        Me.LayoutView2.GridControl = Me.PEDRASGridControl
        Me.LayoutView2.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colBrasCT, Me.layoutViewField_colPerolasCT, Me.layoutViewField_colRubisCT, Me.layoutViewField_colSafirasCT, Me.layoutViewField_colEsmeraldasCT, Me.layoutViewField_colPedrasCT, Me.layoutViewField_colId1})
        Me.LayoutView2.Name = "LayoutView2"
        Me.LayoutView2.OptionsBehavior.AllowRuntimeCustomization = False
        Me.LayoutView2.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.LayoutView2.OptionsCustomization.AllowFilter = False
        Me.LayoutView2.OptionsFilter.AllowFilterEditor = False
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
        'colDiamantesCT
        '
        Me.colDiamantesCT.AppearanceCell.Options.UseTextOptions = True
        Me.colDiamantesCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colDiamantesCT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colDiamantesCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiamantesCT.FieldName = "DiamantesCT"
        Me.colDiamantesCT.LayoutViewField = Me.layoutViewField_colDiamantesCT
        Me.colDiamantesCT.Name = "colDiamantesCT"
        '
        'colDiamantesQtde
        '
        Me.colDiamantesQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colDiamantesQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colDiamantesQtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colDiamantesQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiamantesQtde.FieldName = "DiamantesQtde"
        Me.colDiamantesQtde.LayoutViewField = Me.layoutViewField_colDiamantesQtde
        Me.colDiamantesQtde.Name = "colDiamantesQtde"
        '
        'colDiamantesValor
        '
        Me.colDiamantesValor.AppearanceCell.Options.UseTextOptions = True
        Me.colDiamantesValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colDiamantesValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colDiamantesValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiamantesValor.FieldName = "DiamantesValor"
        Me.colDiamantesValor.LayoutViewField = Me.layoutViewField_colDiamantesValor
        Me.colDiamantesValor.Name = "colDiamantesValor"
        '
        'colDiamantes2CT
        '
        Me.colDiamantes2CT.AppearanceCell.Options.UseTextOptions = True
        Me.colDiamantes2CT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colDiamantes2CT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colDiamantes2CT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiamantes2CT.FieldName = "Diamantes2CT"
        Me.colDiamantes2CT.LayoutViewField = Me.layoutViewField_colDiamantes2CT
        Me.colDiamantes2CT.Name = "colDiamantes2CT"
        '
        'colDiamantes2Qtde
        '
        Me.colDiamantes2Qtde.AppearanceCell.Options.UseTextOptions = True
        Me.colDiamantes2Qtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colDiamantes2Qtde.DisplayFormat.FormatString = "{0:#,###0.000;-#,###0.000}"
        Me.colDiamantes2Qtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiamantes2Qtde.FieldName = "Diamantes2Qtde"
        Me.colDiamantes2Qtde.LayoutViewField = Me.layoutViewField_colDiamantes2Qtde
        Me.colDiamantes2Qtde.Name = "colDiamantes2Qtde"
        '
        'colDiamantes2Valor
        '
        Me.colDiamantes2Valor.AppearanceCell.Options.UseTextOptions = True
        Me.colDiamantes2Valor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colDiamantes2Valor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colDiamantes2Valor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiamantes2Valor.FieldName = "Diamantes2Valor"
        Me.colDiamantes2Valor.LayoutViewField = Me.layoutViewField_colDiamantes2Valor
        Me.colDiamantes2Valor.Name = "colDiamantes2Valor"
        '
        'colBrasCT
        '
        Me.colBrasCT.AppearanceCell.Options.UseTextOptions = True
        Me.colBrasCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colBrasCT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colBrasCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBrasCT.FieldName = "BrasCT"
        Me.colBrasCT.LayoutViewField = Me.layoutViewField_colBrasCT
        Me.colBrasCT.Name = "colBrasCT"
        '
        'colPedrasBrasQtde
        '
        Me.colPedrasBrasQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colPedrasBrasQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colPedrasBrasQtde.FieldName = "PedrasBrasQtde"
        Me.colPedrasBrasQtde.LayoutViewField = Me.layoutViewField_colPedrasBrasQtde
        Me.colPedrasBrasQtde.Name = "colPedrasBrasQtde"
        '
        'colPedrasBrasValor
        '
        Me.colPedrasBrasValor.AppearanceCell.Options.UseTextOptions = True
        Me.colPedrasBrasValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colPedrasBrasValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colPedrasBrasValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPedrasBrasValor.FieldName = "PedrasBrasValor"
        Me.colPedrasBrasValor.LayoutViewField = Me.layoutViewField_colPedrasBrasValor
        Me.colPedrasBrasValor.Name = "colPedrasBrasValor"
        '
        'colPerolasCT
        '
        Me.colPerolasCT.AppearanceCell.Options.UseTextOptions = True
        Me.colPerolasCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colPerolasCT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colPerolasCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPerolasCT.FieldName = "PerolasCT"
        Me.colPerolasCT.LayoutViewField = Me.layoutViewField_colPerolasCT
        Me.colPerolasCT.Name = "colPerolasCT"
        '
        'colPerolasQtde
        '
        Me.colPerolasQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colPerolasQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colPerolasQtde.FieldName = "PerolasQtde"
        Me.colPerolasQtde.LayoutViewField = Me.layoutViewField_colPerolasQtde
        Me.colPerolasQtde.Name = "colPerolasQtde"
        '
        'colPerolasValor
        '
        Me.colPerolasValor.AppearanceCell.Options.UseTextOptions = True
        Me.colPerolasValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colPerolasValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colPerolasValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPerolasValor.FieldName = "PerolasValor"
        Me.colPerolasValor.LayoutViewField = Me.layoutViewField_colPerolasValor
        Me.colPerolasValor.Name = "colPerolasValor"
        '
        'colRubisCT
        '
        Me.colRubisCT.AppearanceCell.Options.UseTextOptions = True
        Me.colRubisCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colRubisCT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colRubisCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRubisCT.FieldName = "RubisCT"
        Me.colRubisCT.LayoutViewField = Me.layoutViewField_colRubisCT
        Me.colRubisCT.Name = "colRubisCT"
        '
        'colRubiQtde
        '
        Me.colRubiQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colRubiQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colRubiQtde.FieldName = "RubiQtde"
        Me.colRubiQtde.LayoutViewField = Me.layoutViewField_colRubiQtde
        Me.colRubiQtde.Name = "colRubiQtde"
        '
        'colRubiValor
        '
        Me.colRubiValor.AppearanceCell.Options.UseTextOptions = True
        Me.colRubiValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colRubiValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colRubiValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRubiValor.FieldName = "RubiValor"
        Me.colRubiValor.LayoutViewField = Me.layoutViewField_colRubiValor
        Me.colRubiValor.Name = "colRubiValor"
        '
        'colSafirasCT
        '
        Me.colSafirasCT.AppearanceCell.Options.UseTextOptions = True
        Me.colSafirasCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colSafirasCT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colSafirasCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSafirasCT.FieldName = "SafirasCT"
        Me.colSafirasCT.LayoutViewField = Me.layoutViewField_colSafirasCT
        Me.colSafirasCT.Name = "colSafirasCT"
        '
        'colSafiraQtde
        '
        Me.colSafiraQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colSafiraQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colSafiraQtde.FieldName = "SafiraQtde"
        Me.colSafiraQtde.LayoutViewField = Me.layoutViewField_colSafiraQtde
        Me.colSafiraQtde.Name = "colSafiraQtde"
        '
        'colSafiraValor
        '
        Me.colSafiraValor.AppearanceCell.Options.UseTextOptions = True
        Me.colSafiraValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colSafiraValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colSafiraValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSafiraValor.FieldName = "SafiraValor"
        Me.colSafiraValor.LayoutViewField = Me.layoutViewField_colSafiraValor
        Me.colSafiraValor.Name = "colSafiraValor"
        '
        'colEsmeraldasCT
        '
        Me.colEsmeraldasCT.AppearanceCell.Options.UseTextOptions = True
        Me.colEsmeraldasCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colEsmeraldasCT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colEsmeraldasCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEsmeraldasCT.FieldName = "EsmeraldasCT"
        Me.colEsmeraldasCT.LayoutViewField = Me.layoutViewField_colEsmeraldasCT
        Me.colEsmeraldasCT.Name = "colEsmeraldasCT"
        '
        'colEsmeraldaQtde
        '
        Me.colEsmeraldaQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colEsmeraldaQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colEsmeraldaQtde.FieldName = "EsmeraldaQtde"
        Me.colEsmeraldaQtde.LayoutViewField = Me.layoutViewField_colEsmeraldaQtde
        Me.colEsmeraldaQtde.Name = "colEsmeraldaQtde"
        '
        'colEsmeraldaValor
        '
        Me.colEsmeraldaValor.AppearanceCell.Options.UseTextOptions = True
        Me.colEsmeraldaValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colEsmeraldaValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colEsmeraldaValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEsmeraldaValor.FieldName = "EsmeraldaValor"
        Me.colEsmeraldaValor.LayoutViewField = Me.layoutViewField_colEsmeraldaValor
        Me.colEsmeraldaValor.Name = "colEsmeraldaValor"
        '
        'colPedrasCT
        '
        Me.colPedrasCT.AppearanceCell.Options.UseTextOptions = True
        Me.colPedrasCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colPedrasCT.DisplayFormat.FormatString = "{0:#,###0;-#,###0}"
        Me.colPedrasCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPedrasCT.FieldName = "PedrasCT"
        Me.colPedrasCT.LayoutViewField = Me.layoutViewField_colPedrasCT
        Me.colPedrasCT.Name = "colPedrasCT"
        '
        'colCitrinoQtde
        '
        Me.colCitrinoQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colCitrinoQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colCitrinoQtde.FieldName = "CitrinoQtde"
        Me.colCitrinoQtde.LayoutViewField = Me.layoutViewField_colCitrinoQtde
        Me.colCitrinoQtde.Name = "colCitrinoQtde"
        '
        'colCitrinoValor
        '
        Me.colCitrinoValor.AppearanceCell.Options.UseTextOptions = True
        Me.colCitrinoValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colCitrinoValor.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.colCitrinoValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCitrinoValor.FieldName = "CitrinoValor"
        Me.colCitrinoValor.LayoutViewField = Me.layoutViewField_colCitrinoValor
        Me.colCitrinoValor.Name = "colCitrinoValor"
        '
        'CravaçãoTextEdit
        '
        Me.CravaçãoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Cravação", True))
        Me.CravaçãoTextEdit.Location = New System.Drawing.Point(68, 359)
        Me.CravaçãoTextEdit.MenuManager = Me.ribbonControl1
        Me.CravaçãoTextEdit.Name = "CravaçãoTextEdit"
        Me.CravaçãoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CravaçãoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CravaçãoTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.CravaçãoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CravaçãoTextEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.CravaçãoTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CravaçãoTextEdit.Size = New System.Drawing.Size(79, 22)
        Me.CravaçãoTextEdit.TabIndex = 20
        '
        'MadeiraTextEdit
        '
        Me.MadeiraTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Madeira", True))
        Me.MadeiraTextEdit.Location = New System.Drawing.Point(68, 385)
        Me.MadeiraTextEdit.MenuManager = Me.ribbonControl1
        Me.MadeiraTextEdit.Name = "MadeiraTextEdit"
        Me.MadeiraTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MadeiraTextEdit.Properties.Appearance.Options.UseFont = True
        Me.MadeiraTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.MadeiraTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.MadeiraTextEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.MadeiraTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MadeiraTextEdit.Size = New System.Drawing.Size(79, 22)
        Me.MadeiraTextEdit.TabIndex = 21
        '
        'CouroTextEdit
        '
        Me.CouroTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Couro", True))
        Me.CouroTextEdit.Location = New System.Drawing.Point(68, 411)
        Me.CouroTextEdit.MenuManager = Me.ribbonControl1
        Me.CouroTextEdit.Name = "CouroTextEdit"
        Me.CouroTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CouroTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CouroTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.CouroTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CouroTextEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.CouroTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CouroTextEdit.Size = New System.Drawing.Size(79, 22)
        Me.CouroTextEdit.TabIndex = 22
        '
        'OutrasTextEdit
        '
        Me.OutrasTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Outras", True))
        Me.OutrasTextEdit.Location = New System.Drawing.Point(68, 437)
        Me.OutrasTextEdit.MenuManager = Me.ribbonControl1
        Me.OutrasTextEdit.Name = "OutrasTextEdit"
        Me.OutrasTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutrasTextEdit.Properties.Appearance.Options.UseFont = True
        Me.OutrasTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.OutrasTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.OutrasTextEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.OutrasTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OutrasTextEdit.Size = New System.Drawing.Size(79, 22)
        Me.OutrasTextEdit.TabIndex = 23
        '
        'OficinaTextEdit
        '
        Me.OficinaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Oficina", True))
        Me.OficinaTextEdit.Location = New System.Drawing.Point(68, 492)
        Me.OficinaTextEdit.MenuManager = Me.ribbonControl1
        Me.OficinaTextEdit.Name = "OficinaTextEdit"
        Me.OficinaTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OficinaTextEdit.Properties.Appearance.Options.UseFont = True
        Me.OficinaTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.OficinaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.OficinaTextEdit.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.OficinaTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OficinaTextEdit.Size = New System.Drawing.Size(79, 22)
        Me.OficinaTextEdit.TabIndex = 24
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(675, 168)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(74, 15)
        Me.LabelControl1.TabIndex = 26
        Me.LabelControl1.Text = "LabelControl1"
        '
        'VendidaCheckEdit
        '
        Me.VendidaCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me._1TabPeçasBindingSource, "Vendida", True))
        Me.VendidaCheckEdit.Location = New System.Drawing.Point(706, 167)
        Me.VendidaCheckEdit.MenuManager = Me.ribbonControl1
        Me.VendidaCheckEdit.Name = "VendidaCheckEdit"
        Me.VendidaCheckEdit.Properties.Caption = ""
        Me.VendidaCheckEdit.Size = New System.Drawing.Size(25, 19)
        Me.VendidaCheckEdit.TabIndex = 27
        '
        'LayoutViewCard2
        '
        Me.LayoutViewCard2.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard2.GroupBordersVisible = False
        Me.LayoutViewCard2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colDiamantesCT, Me.layoutViewField_colDiamantes2CT, Me.layoutViewField_colDiamantesQtde, Me.layoutViewField_colDiamantesValor, Me.layoutViewField_colDiamantes2Qtde, Me.layoutViewField_colDiamantes2Valor, Me.layoutViewField_colPedrasBrasQtde, Me.layoutViewField_colPedrasBrasValor, Me.layoutViewField_colPerolasQtde, Me.layoutViewField_colPerolasValor, Me.layoutViewField_colRubiQtde, Me.layoutViewField_colRubiValor, Me.layoutViewField_colSafiraQtde, Me.layoutViewField_colSafiraValor, Me.layoutViewField_colEsmeraldaQtde, Me.layoutViewField_colEsmeraldaValor, Me.layoutViewField_colCitrinoQtde, Me.layoutViewField_colCitrinoValor, Me.item12, Me.item13, Me.item14, Me.item17, Me.item18, Me.item19, Me.item20, Me.item21, Me.item22, Me.item23, Me.item25, Me.item24, Me.item26, Me.item27, Me.item28, Me.item29, Me.item30, Me.item31})
        Me.LayoutViewCard2.Name = "layoutViewTemplateCard"
        Me.LayoutViewCard2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard2.Text = "TemplateCard"
        '
        'layoutViewField_colDiamantesCT
        '
        Me.layoutViewField_colDiamantesCT.EditorPreferredWidth = 120
        Me.layoutViewField_colDiamantesCT.Location = New System.Drawing.Point(83, 19)
        Me.layoutViewField_colDiamantesCT.Name = "layoutViewField_colDiamantesCT"
        Me.layoutViewField_colDiamantesCT.Size = New System.Drawing.Size(124, 24)
        Me.layoutViewField_colDiamantesCT.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colDiamantesCT.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colDiamantesCT.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colDiamantesCT.TextToControlDistance = 0
        Me.layoutViewField_colDiamantesCT.TextVisible = False
        '
        'layoutViewField_colDiamantes2CT
        '
        Me.layoutViewField_colDiamantes2CT.EditorPreferredWidth = 120
        Me.layoutViewField_colDiamantes2CT.Location = New System.Drawing.Point(83, 43)
        Me.layoutViewField_colDiamantes2CT.Name = "layoutViewField_colDiamantes2CT"
        Me.layoutViewField_colDiamantes2CT.Size = New System.Drawing.Size(124, 24)
        Me.layoutViewField_colDiamantes2CT.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colDiamantes2CT.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colDiamantes2CT.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colDiamantes2CT.TextToControlDistance = 0
        Me.layoutViewField_colDiamantes2CT.TextVisible = False
        '
        'layoutViewField_colDiamantesQtde
        '
        Me.layoutViewField_colDiamantesQtde.EditorPreferredWidth = 119
        Me.layoutViewField_colDiamantesQtde.Location = New System.Drawing.Point(207, 19)
        Me.layoutViewField_colDiamantesQtde.Name = "layoutViewField_colDiamantesQtde"
        Me.layoutViewField_colDiamantesQtde.Size = New System.Drawing.Size(123, 24)
        Me.layoutViewField_colDiamantesQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colDiamantesQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colDiamantesQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colDiamantesQtde.TextToControlDistance = 0
        Me.layoutViewField_colDiamantesQtde.TextVisible = False
        '
        'layoutViewField_colDiamantesValor
        '
        Me.layoutViewField_colDiamantesValor.EditorPreferredWidth = 123
        Me.layoutViewField_colDiamantesValor.Location = New System.Drawing.Point(330, 19)
        Me.layoutViewField_colDiamantesValor.Name = "layoutViewField_colDiamantesValor"
        Me.layoutViewField_colDiamantesValor.Size = New System.Drawing.Size(127, 24)
        Me.layoutViewField_colDiamantesValor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colDiamantesValor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colDiamantesValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colDiamantesValor.TextToControlDistance = 0
        Me.layoutViewField_colDiamantesValor.TextVisible = False
        '
        'layoutViewField_colDiamantes2Qtde
        '
        Me.layoutViewField_colDiamantes2Qtde.EditorPreferredWidth = 119
        Me.layoutViewField_colDiamantes2Qtde.Location = New System.Drawing.Point(207, 43)
        Me.layoutViewField_colDiamantes2Qtde.Name = "layoutViewField_colDiamantes2Qtde"
        Me.layoutViewField_colDiamantes2Qtde.Size = New System.Drawing.Size(123, 24)
        Me.layoutViewField_colDiamantes2Qtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colDiamantes2Qtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colDiamantes2Qtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colDiamantes2Qtde.TextToControlDistance = 0
        Me.layoutViewField_colDiamantes2Qtde.TextVisible = False
        '
        'layoutViewField_colDiamantes2Valor
        '
        Me.layoutViewField_colDiamantes2Valor.EditorPreferredWidth = 123
        Me.layoutViewField_colDiamantes2Valor.Location = New System.Drawing.Point(330, 43)
        Me.layoutViewField_colDiamantes2Valor.Name = "layoutViewField_colDiamantes2Valor"
        Me.layoutViewField_colDiamantes2Valor.Size = New System.Drawing.Size(127, 24)
        Me.layoutViewField_colDiamantes2Valor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colDiamantes2Valor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colDiamantes2Valor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colDiamantes2Valor.TextToControlDistance = 0
        Me.layoutViewField_colDiamantes2Valor.TextVisible = False
        '
        'layoutViewField_colPedrasBrasQtde
        '
        Me.layoutViewField_colPedrasBrasQtde.EditorPreferredWidth = 120
        Me.layoutViewField_colPedrasBrasQtde.Location = New System.Drawing.Point(83, 67)
        Me.layoutViewField_colPedrasBrasQtde.Name = "layoutViewField_colPedrasBrasQtde"
        Me.layoutViewField_colPedrasBrasQtde.Size = New System.Drawing.Size(124, 24)
        Me.layoutViewField_colPedrasBrasQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colPedrasBrasQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colPedrasBrasQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPedrasBrasQtde.TextToControlDistance = 0
        Me.layoutViewField_colPedrasBrasQtde.TextVisible = False
        '
        'layoutViewField_colPedrasBrasValor
        '
        Me.layoutViewField_colPedrasBrasValor.EditorPreferredWidth = 123
        Me.layoutViewField_colPedrasBrasValor.Location = New System.Drawing.Point(330, 67)
        Me.layoutViewField_colPedrasBrasValor.Name = "layoutViewField_colPedrasBrasValor"
        Me.layoutViewField_colPedrasBrasValor.Size = New System.Drawing.Size(127, 24)
        Me.layoutViewField_colPedrasBrasValor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colPedrasBrasValor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colPedrasBrasValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPedrasBrasValor.TextToControlDistance = 0
        Me.layoutViewField_colPedrasBrasValor.TextVisible = False
        '
        'layoutViewField_colPerolasQtde
        '
        Me.layoutViewField_colPerolasQtde.EditorPreferredWidth = 120
        Me.layoutViewField_colPerolasQtde.Location = New System.Drawing.Point(83, 91)
        Me.layoutViewField_colPerolasQtde.Name = "layoutViewField_colPerolasQtde"
        Me.layoutViewField_colPerolasQtde.Size = New System.Drawing.Size(124, 24)
        Me.layoutViewField_colPerolasQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colPerolasQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colPerolasQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPerolasQtde.TextToControlDistance = 0
        Me.layoutViewField_colPerolasQtde.TextVisible = False
        '
        'layoutViewField_colPerolasValor
        '
        Me.layoutViewField_colPerolasValor.EditorPreferredWidth = 123
        Me.layoutViewField_colPerolasValor.Location = New System.Drawing.Point(330, 91)
        Me.layoutViewField_colPerolasValor.Name = "layoutViewField_colPerolasValor"
        Me.layoutViewField_colPerolasValor.Size = New System.Drawing.Size(127, 24)
        Me.layoutViewField_colPerolasValor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colPerolasValor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colPerolasValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPerolasValor.TextToControlDistance = 0
        Me.layoutViewField_colPerolasValor.TextVisible = False
        '
        'layoutViewField_colRubiQtde
        '
        Me.layoutViewField_colRubiQtde.EditorPreferredWidth = 120
        Me.layoutViewField_colRubiQtde.Location = New System.Drawing.Point(83, 115)
        Me.layoutViewField_colRubiQtde.Name = "layoutViewField_colRubiQtde"
        Me.layoutViewField_colRubiQtde.Size = New System.Drawing.Size(124, 24)
        Me.layoutViewField_colRubiQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colRubiQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colRubiQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colRubiQtde.TextToControlDistance = 0
        Me.layoutViewField_colRubiQtde.TextVisible = False
        '
        'layoutViewField_colRubiValor
        '
        Me.layoutViewField_colRubiValor.EditorPreferredWidth = 123
        Me.layoutViewField_colRubiValor.Location = New System.Drawing.Point(330, 115)
        Me.layoutViewField_colRubiValor.Name = "layoutViewField_colRubiValor"
        Me.layoutViewField_colRubiValor.Size = New System.Drawing.Size(127, 24)
        Me.layoutViewField_colRubiValor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colRubiValor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colRubiValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colRubiValor.TextToControlDistance = 0
        Me.layoutViewField_colRubiValor.TextVisible = False
        '
        'layoutViewField_colSafiraQtde
        '
        Me.layoutViewField_colSafiraQtde.EditorPreferredWidth = 120
        Me.layoutViewField_colSafiraQtde.Location = New System.Drawing.Point(83, 139)
        Me.layoutViewField_colSafiraQtde.Name = "layoutViewField_colSafiraQtde"
        Me.layoutViewField_colSafiraQtde.Size = New System.Drawing.Size(124, 24)
        Me.layoutViewField_colSafiraQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colSafiraQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colSafiraQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colSafiraQtde.TextToControlDistance = 0
        Me.layoutViewField_colSafiraQtde.TextVisible = False
        '
        'layoutViewField_colSafiraValor
        '
        Me.layoutViewField_colSafiraValor.EditorPreferredWidth = 123
        Me.layoutViewField_colSafiraValor.Location = New System.Drawing.Point(330, 139)
        Me.layoutViewField_colSafiraValor.Name = "layoutViewField_colSafiraValor"
        Me.layoutViewField_colSafiraValor.Size = New System.Drawing.Size(127, 24)
        Me.layoutViewField_colSafiraValor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colSafiraValor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colSafiraValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colSafiraValor.TextToControlDistance = 0
        Me.layoutViewField_colSafiraValor.TextVisible = False
        '
        'layoutViewField_colEsmeraldaQtde
        '
        Me.layoutViewField_colEsmeraldaQtde.EditorPreferredWidth = 120
        Me.layoutViewField_colEsmeraldaQtde.Location = New System.Drawing.Point(83, 163)
        Me.layoutViewField_colEsmeraldaQtde.Name = "layoutViewField_colEsmeraldaQtde"
        Me.layoutViewField_colEsmeraldaQtde.Size = New System.Drawing.Size(124, 24)
        Me.layoutViewField_colEsmeraldaQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colEsmeraldaQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colEsmeraldaQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colEsmeraldaQtde.TextToControlDistance = 0
        Me.layoutViewField_colEsmeraldaQtde.TextVisible = False
        '
        'layoutViewField_colEsmeraldaValor
        '
        Me.layoutViewField_colEsmeraldaValor.EditorPreferredWidth = 123
        Me.layoutViewField_colEsmeraldaValor.Location = New System.Drawing.Point(330, 163)
        Me.layoutViewField_colEsmeraldaValor.Name = "layoutViewField_colEsmeraldaValor"
        Me.layoutViewField_colEsmeraldaValor.Size = New System.Drawing.Size(127, 24)
        Me.layoutViewField_colEsmeraldaValor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colEsmeraldaValor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colEsmeraldaValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colEsmeraldaValor.TextToControlDistance = 0
        Me.layoutViewField_colEsmeraldaValor.TextVisible = False
        '
        'layoutViewField_colCitrinoQtde
        '
        Me.layoutViewField_colCitrinoQtde.EditorPreferredWidth = 120
        Me.layoutViewField_colCitrinoQtde.Location = New System.Drawing.Point(83, 187)
        Me.layoutViewField_colCitrinoQtde.Name = "layoutViewField_colCitrinoQtde"
        Me.layoutViewField_colCitrinoQtde.Size = New System.Drawing.Size(124, 24)
        Me.layoutViewField_colCitrinoQtde.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colCitrinoQtde.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colCitrinoQtde.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colCitrinoQtde.TextToControlDistance = 0
        Me.layoutViewField_colCitrinoQtde.TextVisible = False
        '
        'layoutViewField_colCitrinoValor
        '
        Me.layoutViewField_colCitrinoValor.EditorPreferredWidth = 123
        Me.layoutViewField_colCitrinoValor.Location = New System.Drawing.Point(330, 187)
        Me.layoutViewField_colCitrinoValor.Name = "layoutViewField_colCitrinoValor"
        Me.layoutViewField_colCitrinoValor.Size = New System.Drawing.Size(127, 24)
        Me.layoutViewField_colCitrinoValor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.layoutViewField_colCitrinoValor.TextLocation = DevExpress.Utils.Locations.Right
        Me.layoutViewField_colCitrinoValor.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colCitrinoValor.TextToControlDistance = 0
        Me.layoutViewField_colCitrinoValor.TextVisible = False
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
        Me.item22.Location = New System.Drawing.Point(330, 0)
        Me.item22.Name = "item22"
        Me.item22.Size = New System.Drawing.Size(127, 19)
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
        Me.item23.Location = New System.Drawing.Point(207, 0)
        Me.item23.Name = "item23"
        Me.item23.Size = New System.Drawing.Size(123, 19)
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
        Me.item24.Size = New System.Drawing.Size(124, 19)
        Me.item24.Text = "Quant."
        Me.item24.TextSize = New System.Drawing.Size(79, 15)
        '
        'item26
        '
        Me.item26.AllowHotTrack = False
        Me.item26.CustomizationFormText = "item26"
        Me.item26.Location = New System.Drawing.Point(207, 67)
        Me.item26.Name = "item26"
        Me.item26.Size = New System.Drawing.Size(123, 24)
        Me.item26.TextSize = New System.Drawing.Size(0, 0)
        '
        'item27
        '
        Me.item27.AllowHotTrack = False
        Me.item27.CustomizationFormText = "item27"
        Me.item27.Location = New System.Drawing.Point(207, 91)
        Me.item27.Name = "item27"
        Me.item27.Size = New System.Drawing.Size(123, 24)
        Me.item27.TextSize = New System.Drawing.Size(0, 0)
        '
        'item28
        '
        Me.item28.AllowHotTrack = False
        Me.item28.CustomizationFormText = "item28"
        Me.item28.Location = New System.Drawing.Point(207, 115)
        Me.item28.Name = "item28"
        Me.item28.Size = New System.Drawing.Size(123, 24)
        Me.item28.TextSize = New System.Drawing.Size(0, 0)
        '
        'item29
        '
        Me.item29.AllowHotTrack = False
        Me.item29.CustomizationFormText = "item29"
        Me.item29.Location = New System.Drawing.Point(207, 139)
        Me.item29.Name = "item29"
        Me.item29.Size = New System.Drawing.Size(123, 24)
        Me.item29.TextSize = New System.Drawing.Size(0, 0)
        '
        'item30
        '
        Me.item30.AllowHotTrack = False
        Me.item30.CustomizationFormText = "item30"
        Me.item30.Location = New System.Drawing.Point(207, 163)
        Me.item30.Name = "item30"
        Me.item30.Size = New System.Drawing.Size(123, 24)
        Me.item30.TextSize = New System.Drawing.Size(0, 0)
        '
        'item31
        '
        Me.item31.AllowHotTrack = False
        Me.item31.CustomizationFormText = "item31"
        Me.item31.Location = New System.Drawing.Point(207, 187)
        Me.item31.Name = "item31"
        Me.item31.Size = New System.Drawing.Size(123, 24)
        Me.item31.TextSize = New System.Drawing.Size(0, 0)
        '
        'layoutViewField_colBrasCT
        '
        Me.layoutViewField_colBrasCT.EditorPreferredWidth = 20
        Me.layoutViewField_colBrasCT.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colBrasCT.Name = "layoutViewField_colBrasCT"
        Me.layoutViewField_colBrasCT.Size = New System.Drawing.Size(457, 211)
        Me.layoutViewField_colBrasCT.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colBrasCT.TextVisible = False
        '
        'layoutViewField_colPerolasCT
        '
        Me.layoutViewField_colPerolasCT.EditorPreferredWidth = 20
        Me.layoutViewField_colPerolasCT.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colPerolasCT.Name = "layoutViewField_colPerolasCT"
        Me.layoutViewField_colPerolasCT.Size = New System.Drawing.Size(457, 211)
        Me.layoutViewField_colPerolasCT.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPerolasCT.TextVisible = False
        '
        'layoutViewField_colRubisCT
        '
        Me.layoutViewField_colRubisCT.EditorPreferredWidth = 20
        Me.layoutViewField_colRubisCT.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colRubisCT.Name = "layoutViewField_colRubisCT"
        Me.layoutViewField_colRubisCT.Size = New System.Drawing.Size(457, 211)
        Me.layoutViewField_colRubisCT.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colRubisCT.TextVisible = False
        '
        'layoutViewField_colSafirasCT
        '
        Me.layoutViewField_colSafirasCT.EditorPreferredWidth = 20
        Me.layoutViewField_colSafirasCT.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colSafirasCT.Name = "layoutViewField_colSafirasCT"
        Me.layoutViewField_colSafirasCT.Size = New System.Drawing.Size(457, 211)
        Me.layoutViewField_colSafirasCT.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colSafirasCT.TextVisible = False
        '
        'layoutViewField_colEsmeraldasCT
        '
        Me.layoutViewField_colEsmeraldasCT.EditorPreferredWidth = 20
        Me.layoutViewField_colEsmeraldasCT.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colEsmeraldasCT.Name = "layoutViewField_colEsmeraldasCT"
        Me.layoutViewField_colEsmeraldasCT.Size = New System.Drawing.Size(457, 211)
        Me.layoutViewField_colEsmeraldasCT.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colEsmeraldasCT.TextVisible = False
        '
        'layoutViewField_colPedrasCT
        '
        Me.layoutViewField_colPedrasCT.EditorPreferredWidth = 20
        Me.layoutViewField_colPedrasCT.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colPedrasCT.Name = "layoutViewField_colPedrasCT"
        Me.layoutViewField_colPedrasCT.Size = New System.Drawing.Size(457, 211)
        Me.layoutViewField_colPedrasCT.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colPedrasCT.TextVisible = False
        '
        'layoutViewField_colId1
        '
        Me.layoutViewField_colId1.EditorPreferredWidth = 20
        Me.layoutViewField_colId1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colId1.Name = "layoutViewField_colId1"
        Me.layoutViewField_colId1.Size = New System.Drawing.Size(457, 211)
        Me.layoutViewField_colId1.TextSize = New System.Drawing.Size(72, 13)
        '
        'frmEstoque
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1004, 692)
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
        Me.Controls.Add(Me.VendidaCheckEdit)
        Me.Controls.Add(MOIntLabel)
        Me.Controls.Add(Me.MOIntTextEdit)
        Me.Controls.Add(MOExtLabel)
        Me.Controls.Add(Me.MOExtTextEdit)
        Me.Controls.Add(CustoLabel)
        Me.Controls.Add(Me.txtCusto)
        Me.Controls.Add(Me.METAISGridControl)
        Me.Controls.Add(Me.IDPeçaTextEdit)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmEstoque"
        Me.Ribbon = Me.ribbonControl1
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._1TabPeçasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNovoEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OficialCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrigemComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataRegDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataRegDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModêloTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClasseComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDPeçaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.CravaçãoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MadeiraTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CouroTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutrasTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OficinaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendidaCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colDiamantesCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colDiamantes2CT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colDiamantesQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colDiamantesValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colDiamantes2Qtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colDiamantes2Valor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPedrasBrasQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPedrasBrasValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPerolasQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPerolasValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colRubiQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colRubiValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colSafiraQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colSafiraValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colEsmeraldaQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colEsmeraldaValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colCitrinoQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colCitrinoValor, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.item26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colBrasCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPerolasCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colRubisCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colSafirasCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colEsmeraldasCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPedrasCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colId1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ObsTextEdit As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents VendidaCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents layoutViewField_colId1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colDiamantesCT As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colDiamantesQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colDiamantesValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colDiamantes2CT As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colDiamantes2Qtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colDiamantes2Valor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colBrasCT As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPedrasBrasQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPedrasBrasValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPerolasCT As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPerolasQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPerolasValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colRubisCT As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colRubiQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colRubiValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colSafirasCT As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colSafiraQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colSafiraValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colEsmeraldasCT As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colEsmeraldaQtde As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colEsmeraldaValor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPedrasCT As DevExpress.XtraGrid.Views.Layout.LayoutViewField
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
    Friend WithEvents item26 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents item27 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents item28 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents item29 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents item30 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents item31 As DevExpress.XtraLayout.EmptySpaceItem
End Class
