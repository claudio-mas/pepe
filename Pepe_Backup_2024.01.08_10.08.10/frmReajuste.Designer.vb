Partial Public Class frmReajuste
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReajuste))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLancaCC = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCompras = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPeçasCompradas = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.DataReaj = New DevExpress.XtraEditors.DateEdit()
        Me.FatorCusto = New DevExpress.XtraEditors.TextEdit()
        Me.FatorVenda = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.btnAplicarReajuste = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDesfazer = New DevExpress.XtraEditors.SimpleButton()
        Me.ReajustesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ReajustesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNovoEstoque = New Pepe.dsNovoEstoque()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataReaj = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFatorCusto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFatorVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ReajustesTableAdapter = New Pepe.dsNovoEstoqueTableAdapters.ReajustesTableAdapter()
        Me.TableAdapterManager = New Pepe.dsNovoEstoqueTableAdapters.TableAdapterManager()
        Me.GroupControlHistoricoDeReajustes = New DevExpress.XtraEditors.GroupControl()
        DataLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataReaj.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataReaj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatorCusto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatorVenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl.SuspendLayout()
        CType(Me.ReajustesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReajustesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNovoEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControlHistoricoDeReajustes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControlHistoricoDeReajustes.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataLabel
        '
        DataLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataLabel.Location = New System.Drawing.Point(102, 56)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(34, 13)
        DataLabel.TabIndex = 17
        DataLabel.Text = "Data"
        DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(19, 109)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(111, 16)
        Label1.TabIndex = 32
        Label1.Text = "Fator de Reajuste:"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(88, 134)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(48, 13)
        Label2.TabIndex = 33
        Label2.Text = "Custo"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(28, 160)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(109, 15)
        Label3.TabIndex = 34
        Label3.Text = "Preço de Venda"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnSalvar, Me.btnUndo, Me.btnLancaCC, Me.btnCompras, Me.btnPeçasCompradas})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 10
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowToolbarCustomizeItem = False
        Me.ribbonControl1.Size = New System.Drawing.Size(1338, 150)
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
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
        Me.ribbonPage1.ImageOptions.Image = CType(resources.GetObject("ribbonPage1.ImageOptions.Image"), System.Drawing.Image)
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "REAJUSTE"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnFechar)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        '
        'DataReaj
        '
        Me.DataReaj.EditValue = Nothing
        Me.DataReaj.Location = New System.Drawing.Point(139, 52)
        Me.DataReaj.MenuManager = Me.ribbonControl1
        Me.DataReaj.Name = "DataReaj"
        Me.DataReaj.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DataReaj.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataReaj.Properties.Appearance.Options.UseFont = True
        Me.DataReaj.Properties.Appearance.Options.UseTextOptions = True
        Me.DataReaj.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DataReaj.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DataReaj.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataReaj.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataReaj.Size = New System.Drawing.Size(100, 22)
        Me.DataReaj.TabIndex = 0
        Me.DataReaj.TabStop = False
        '
        'FatorCusto
        '
        Me.FatorCusto.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FatorCusto.Location = New System.Drawing.Point(139, 129)
        Me.FatorCusto.MenuManager = Me.ribbonControl1
        Me.FatorCusto.Name = "FatorCusto"
        Me.FatorCusto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FatorCusto.Properties.Appearance.Options.UseFont = True
        Me.FatorCusto.Properties.Appearance.Options.UseTextOptions = True
        Me.FatorCusto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.FatorCusto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.FatorCusto.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.FatorCusto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FatorCusto.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.FatorCusto.Properties.Mask.EditMask = "n"
        Me.FatorCusto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.FatorCusto.Size = New System.Drawing.Size(101, 22)
        Me.FatorCusto.TabIndex = 1
        '
        'FatorVenda
        '
        Me.FatorVenda.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FatorVenda.Location = New System.Drawing.Point(139, 155)
        Me.FatorVenda.MenuManager = Me.ribbonControl1
        Me.FatorVenda.Name = "FatorVenda"
        Me.FatorVenda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FatorVenda.Properties.Appearance.Options.UseFont = True
        Me.FatorVenda.Properties.Appearance.Options.UseTextOptions = True
        Me.FatorVenda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.FatorVenda.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.FatorVenda.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.FatorVenda.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FatorVenda.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.FatorVenda.Properties.Mask.EditMask = "n"
        Me.FatorVenda.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.FatorVenda.Size = New System.Drawing.Size(101, 22)
        Me.FatorVenda.TabIndex = 2
        '
        'GroupControl
        '
        Me.GroupControl.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl.AppearanceCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning
        Me.GroupControl.AppearanceCaption.Options.UseFont = True
        Me.GroupControl.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl.Controls.Add(Label3)
        Me.GroupControl.Controls.Add(Me.DataReaj)
        Me.GroupControl.Controls.Add(Me.btnAplicarReajuste)
        Me.GroupControl.Controls.Add(Me.FatorVenda)
        Me.GroupControl.Controls.Add(Me.FatorCusto)
        Me.GroupControl.Controls.Add(DataLabel)
        Me.GroupControl.Controls.Add(Label2)
        Me.GroupControl.Controls.Add(Label1)
        Me.GroupControl.Location = New System.Drawing.Point(282, 268)
        Me.GroupControl.Name = "GroupControl"
        Me.GroupControl.Size = New System.Drawing.Size(336, 263)
        Me.GroupControl.TabIndex = 0
        Me.GroupControl.Text = "Reajuste de Peças em Estoque"
        '
        'btnAplicarReajuste
        '
        Me.btnAplicarReajuste.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicarReajuste.Appearance.Options.UseFont = True
        Me.btnAplicarReajuste.ImageOptions.Image = CType(resources.GetObject("btnAplicarReajuste.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAplicarReajuste.Location = New System.Drawing.Point(87, 218)
        Me.btnAplicarReajuste.Name = "btnAplicarReajuste"
        Me.btnAplicarReajuste.Size = New System.Drawing.Size(167, 38)
        Me.btnAplicarReajuste.TabIndex = 0
        Me.btnAplicarReajuste.TabStop = False
        Me.btnAplicarReajuste.Text = "Aplicar Reajuste"
        '
        'btnDesfazer
        '
        Me.btnDesfazer.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesfazer.Appearance.Options.UseFont = True
        Me.btnDesfazer.ImageOptions.Image = CType(resources.GetObject("btnDesfazer.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDesfazer.Location = New System.Drawing.Point(96, 218)
        Me.btnDesfazer.Name = "btnDesfazer"
        Me.btnDesfazer.Size = New System.Drawing.Size(167, 38)
        Me.btnDesfazer.TabIndex = 1
        Me.btnDesfazer.TabStop = False
        Me.btnDesfazer.Text = "Desfazer último reajuste"
        '
        'ReajustesGridControl
        '
        Me.ReajustesGridControl.DataSource = Me.ReajustesBindingSource
        Me.ReajustesGridControl.Location = New System.Drawing.Point(16, 40)
        Me.ReajustesGridControl.MainView = Me.GridView1
        Me.ReajustesGridControl.MenuManager = Me.ribbonControl1
        Me.ReajustesGridControl.Name = "ReajustesGridControl"
        Me.ReajustesGridControl.Size = New System.Drawing.Size(326, 164)
        Me.ReajustesGridControl.TabIndex = 38
        Me.ReajustesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ReajustesBindingSource
        '
        Me.ReajustesBindingSource.DataMember = "Reajustes"
        Me.ReajustesBindingSource.DataSource = Me.DsNovoEstoque
        Me.ReajustesBindingSource.Sort = "DataReaj, Id"
        '
        'DsNovoEstoque
        '
        Me.DsNovoEstoque.DataSetName = "dsNovoEstoque"
        Me.DsNovoEstoque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colDataReaj, Me.colFatorCusto, Me.colFatorVenda, Me.colU})
        Me.GridView1.GridControl = Me.ReajustesGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Width = 40
        '
        'colDataReaj
        '
        Me.colDataReaj.AppearanceCell.Options.UseTextOptions = True
        Me.colDataReaj.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataReaj.AppearanceHeader.Options.UseTextOptions = True
        Me.colDataReaj.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataReaj.Caption = "Data"
        Me.colDataReaj.FieldName = "DataReaj"
        Me.colDataReaj.Name = "colDataReaj"
        Me.colDataReaj.OptionsColumn.AllowEdit = False
        Me.colDataReaj.OptionsColumn.ReadOnly = True
        Me.colDataReaj.Visible = True
        Me.colDataReaj.VisibleIndex = 0
        Me.colDataReaj.Width = 90
        '
        'colFatorCusto
        '
        Me.colFatorCusto.Caption = "Fator: Custo"
        Me.colFatorCusto.FieldName = "FatorCusto"
        Me.colFatorCusto.Name = "colFatorCusto"
        Me.colFatorCusto.OptionsColumn.AllowEdit = False
        Me.colFatorCusto.OptionsColumn.ReadOnly = True
        Me.colFatorCusto.Visible = True
        Me.colFatorCusto.VisibleIndex = 1
        Me.colFatorCusto.Width = 100
        '
        'colFatorVenda
        '
        Me.colFatorVenda.Caption = "Fator: Preço de Venda"
        Me.colFatorVenda.FieldName = "FatorVenda"
        Me.colFatorVenda.Name = "colFatorVenda"
        Me.colFatorVenda.OptionsColumn.AllowEdit = False
        Me.colFatorVenda.OptionsColumn.ReadOnly = True
        Me.colFatorVenda.Visible = True
        Me.colFatorVenda.VisibleIndex = 2
        Me.colFatorVenda.Width = 100
        '
        'colU
        '
        Me.colU.FieldName = "U"
        Me.colU.Name = "colU"
        '
        'ReajustesTableAdapter
        '
        Me.ReajustesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._1TabPeçasHistóricoTableAdapter = Nothing
        Me.TableAdapterManager._1TabPeçasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.METAISTableAdapter = Nothing
        Me.TableAdapterManager.PEDRASTableAdapter = Nothing
        Me.TableAdapterManager.ReajustesTableAdapter = Me.ReajustesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Pepe.dsNovoEstoqueTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupControlHistoricoDeReajustes
        '
        Me.GroupControlHistoricoDeReajustes.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControlHistoricoDeReajustes.AppearanceCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning
        Me.GroupControlHistoricoDeReajustes.AppearanceCaption.Options.UseFont = True
        Me.GroupControlHistoricoDeReajustes.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControlHistoricoDeReajustes.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControlHistoricoDeReajustes.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControlHistoricoDeReajustes.Controls.Add(Me.ReajustesGridControl)
        Me.GroupControlHistoricoDeReajustes.Controls.Add(Me.btnDesfazer)
        Me.GroupControlHistoricoDeReajustes.Location = New System.Drawing.Point(697, 268)
        Me.GroupControlHistoricoDeReajustes.Name = "GroupControlHistoricoDeReajustes"
        Me.GroupControlHistoricoDeReajustes.Size = New System.Drawing.Size(359, 263)
        Me.GroupControlHistoricoDeReajustes.TabIndex = 39
        Me.GroupControlHistoricoDeReajustes.Text = "Histórico de Reajustes"
        '
        'frmReajuste
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1338, 725)
        Me.Controls.Add(Me.GroupControlHistoricoDeReajustes)
        Me.Controls.Add(Me.GroupControl)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IconOptions.Icon = CType(resources.GetObject("frmReajuste.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmReajuste"
        Me.Ribbon = Me.ribbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataReaj.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataReaj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatorCusto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatorVenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl.ResumeLayout(False)
        CType(Me.ReajustesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReajustesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNovoEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControlHistoricoDeReajustes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControlHistoricoDeReajustes.ResumeLayout(False)
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
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLancaCC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCompras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPeçasCompradas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataReaj As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FatorCusto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FatorVenda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnAplicarReajuste As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DsNovoEstoque As dsNovoEstoque
    Friend WithEvents ReajustesBindingSource As BindingSource
    Friend WithEvents ReajustesTableAdapter As dsNovoEstoqueTableAdapters.ReajustesTableAdapter
    Friend WithEvents TableAdapterManager As dsNovoEstoqueTableAdapters.TableAdapterManager
    Friend WithEvents ReajustesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataReaj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFatorCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFatorVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDesfazer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControlHistoricoDeReajustes As DevExpress.XtraEditors.GroupControl
End Class
