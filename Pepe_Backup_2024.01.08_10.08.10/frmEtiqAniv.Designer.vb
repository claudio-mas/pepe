Partial Public Class frmEtiqAniv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtiqAniv))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.txtAnos = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtMAniv = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ckTodos = New DevExpress.XtraBars.BarCheckItem()
        Me.btnOk = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.C1Report1 = New C1.C1Report.C1Report()
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl()
        Me.SpinEdit = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        CType(Me.SpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AllowMinimizeRibbon = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.SkinRibbonGalleryBarItem1, Me.SkinRibbonGalleryBarItem2, Me.btnFechar, Me.btnNovo, Me.txtAnos, Me.txtMAniv, Me.ckTodos, Me.btnOk})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 10
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
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
        Me.btnFechar.Caption = "Retornar"
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
        'txtAnos
        '
        Me.txtAnos.Caption = "Clientes que compraram nos últimos 'x' anos (informe a quantidade)"
        Me.txtAnos.Edit = Me.RepositoryItemTextEdit1
        Me.txtAnos.EditWidth = 30
        Me.txtAnos.Id = 5
        Me.txtAnos.Name = "txtAnos"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'txtMAniv
        '
        Me.txtMAniv.Caption = "Mês de aniversário"
        Me.txtMAniv.Edit = Me.RepositoryItemTextEdit2
        Me.txtMAniv.EditWidth = 30
        Me.txtMAniv.Id = 6
        Me.txtMAniv.Name = "txtMAniv"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'ckTodos
        '
        Me.ckTodos.BindableChecked = True
        Me.ckTodos.Caption = "Todos"
        Me.ckTodos.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText
        Me.ckTodos.Checked = True
        Me.ckTodos.Id = 8
        Me.ckTodos.Name = "ckTodos"
        '
        'btnOk
        '
        Me.btnOk.Caption = "Atualizar"
        Me.btnOk.Id = 9
        Me.btnOk.ImageOptions.Image = CType(resources.GetObject("btnOk.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOk.ImageOptions.LargeImage = CType(resources.GetObject("btnOk.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnOk.Name = "btnOk"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup3, Me.RibbonPageGroup2})
        Me.ribbonPage1.ImageOptions.Image = CType(resources.GetObject("ribbonPage1.ImageOptions.Image"), System.Drawing.Image)
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "ETIQUETAS ANIVERSÁRIO"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnFechar)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup3.ItemLinks.Add(Me.txtAnos)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.ckTodos)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.txtMAniv)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnOk)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelControl1.Appearance.Image = CType(resources.GetObject("LabelControl1.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseImage = True
        Me.LabelControl1.Appearance.Options.UseImageAlign = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(843, 76)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(147, 39)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Etiquetas"
        Me.LabelControl1.Visible = False
        '
        'C1Report1
        '
        Me.C1Report1.ReportDefinition = resources.GetString("C1Report1.ReportDefinition")
        Me.C1Report1.ReportName = "Aniversariantes"
        '
        'C1PrintPreviewControl1
        '
        Me.C1PrintPreviewControl1.AvailablePreviewActions = CType(((((((((((((((((((((((((((((((C1.Win.C1Preview.C1PreviewActionFlags.FileSave Or C1.Win.C1Preview.C1PreviewActionFlags.PrintLayout) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.PageSetup) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.Print) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.PageSingle) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.PageContinuous) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.PageFacing) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.PageFacingContinuous) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.GoFirst) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.GoPrev) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.GoNext) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.GoLast) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.GoPage) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.HistoryNext) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.HistoryPrev) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.NavigationPane) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomIn) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomOut) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomFactor) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomInTool) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomOutTool) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.HandTool) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.SelectTextTool) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.Find) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.SearchText) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.StartSearch) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.SearchPrevious) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.SearchNext) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.MatchCase) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.MatchWholeWord) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.CloseSearch), C1.Win.C1Preview.C1PreviewActionFlags)
        Me.C1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.Location = New System.Drawing.Point(0, 150)
        Me.C1PrintPreviewControl1.Name = "C1PrintPreviewControl1"
        Me.C1PrintPreviewControl1.NavigationPanelVisible = False
        '
        'C1PrintPreviewControl1.PreviewPane
        '
        Me.C1PrintPreviewControl1.PreviewPane.Document = Me.C1Report1
        Me.C1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = True
        Me.C1PrintPreviewControl1.PreviewPane.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewPane.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.ActualSize
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(1338, 572)
        Me.C1PrintPreviewControl1.StatusBarVisible = False
        Me.C1PrintPreviewControl1.TabIndex = 5
        Me.C1PrintPreviewControl1.Text = "C1PrintPreviewControl1"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Open.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Name = "btnFileOpen"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Tag = "C1PreviewActionEnum.FileOpen"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.ToolTipText = "Open File"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.PageSetup.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Name = "btnPageSetup"
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Tag = "C1PreviewActionEnum.PageSetup"
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.ToolTipText = "Page Setup"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Parameters.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Parameters.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Parameters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Parameters.Name = "btnParameters"
        Me.C1PrintPreviewControl1.ToolBars.File.Parameters.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Parameters.Tag = "C1PreviewActionEnum.Parameters"
        Me.C1PrintPreviewControl1.ToolBars.File.Parameters.ToolTipText = "Report Parameters"
        Me.C1PrintPreviewControl1.ToolBars.File.Parameters.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Print.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Name = "btnPrint"
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Tag = "C1PreviewActionEnum.Print"
        Me.C1PrintPreviewControl1.ToolBars.File.Print.ToolTipText = "Print"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.PrintLayout.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.PrintLayout.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.PrintLayout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.PrintLayout.Name = "btnPrintLayout"
        Me.C1PrintPreviewControl1.ToolBars.File.PrintLayout.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.PrintLayout.Tag = "C1PreviewActionEnum.PrintLayout"
        Me.C1PrintPreviewControl1.ToolBars.File.PrintLayout.ToolTipText = "Print Layout"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Reflow.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Name = "btnReflow"
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Tag = "C1PreviewActionEnum.Reflow"
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.ToolTipText = "Reflow"
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Save.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Name = "btnFileSave"
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Tag = "C1PreviewActionEnum.FileSave"
        Me.C1PrintPreviewControl1.ToolBars.File.Save.ToolTipText = "Save File"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Stop.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Stop.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Stop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Stop.Name = "btnStop"
        Me.C1PrintPreviewControl1.ToolBars.File.Stop.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Stop.Tag = "C1PreviewActionEnum.Stop"
        Me.C1PrintPreviewControl1.ToolBars.File.Stop.ToolTipText = "Stop"
        Me.C1PrintPreviewControl1.ToolBars.File.Stop.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Name = "btnGoFirst"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Tag = "C1PreviewActionEnum.GoFirst"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.ToolTipText = "Go To First Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Name = "btnGoLast"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Tag = "C1PreviewActionEnum.GoLast"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.ToolTipText = "Go To Last Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Name = "btnGoNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Tag = "C1PreviewActionEnum.GoNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.ToolTipText = "Go To Next Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Name = "btnGoPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Tag = "C1PreviewActionEnum.GoPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.ToolTipText = "Go To Previous Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Tag = "C1PreviewActionEnum.HistoryNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.ToolTipText = "Next View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Name = "btnHistoryPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Tag = "C1PreviewActionEnum.HistoryPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ToolTipText = "Previous View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages.Name = "lblOfPages"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages.Size = New System.Drawing.Size(27, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages.Tag = "C1PreviewActionEnum.GoPageCount"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages.Text = "of 0"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage.Name = "lblPage"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage.Size = New System.Drawing.Size(33, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage.Tag = "C1PreviewActionEnum.GoPageLabel"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage.Text = "Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.Name = "btnNavigationPane"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.Tag = "C1PreviewActionEnum.NavigationPane"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.ToolTipText = "Navigation Pane"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolTipPageNo = Nothing
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Continuous.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Name = "btnPageContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Tag = "C1PreviewActionEnum.PageContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.ToolTipText = "Continuous View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Facing.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Name = "btnPageFacing"
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Tag = "C1PreviewActionEnum.PageFacing"
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.ToolTipText = "Pages Facing View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Name = "btnPageFacingContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Tag = "C1PreviewActionEnum.PageFacingContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.ToolTipText = "Pages Facing Continuous View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Single.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Name = "btnPageSingle"
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Tag = "C1PreviewActionEnum.PageSingle"
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.ToolTipText = "Single Page View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.CloseSearch.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Search.CloseSearch.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Search.CloseSearch.Name = "btnCloseSearch"
        Me.C1PrintPreviewControl1.ToolBars.Search.CloseSearch.Size = New System.Drawing.Size(23, 20)
        Me.C1PrintPreviewControl1.ToolBars.Search.CloseSearch.Tag = "C1PreviewActionEnum.CloseSearch"
        Me.C1PrintPreviewControl1.ToolBars.Search.CloseSearch.ToolTipText = "Close"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.Name = "btnMatchCase"
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.Size = New System.Drawing.Size(73, 22)
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.Tag = "C1PreviewActionEnum.MatchCase"
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.Text = "Match Case"
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.ToolTipText = "Search with case sensitivity"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchLabel.Name = "lblSearch"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchLabel.Size = New System.Drawing.Size(33, 22)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchLabel.Tag = "C1PreviewActionEnum.SearchLabel"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchLabel.Text = "Find:"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Search.SearchNext.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.Name = "btnSearchNext"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.Tag = "C1PreviewActionEnum.SearchNext"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.ToolTipText = "Search Next"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Name = "btnSearchPrevious"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Tag = "C1PreviewActionEnum.SearchPrevious"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.ToolTipText = "Search Previous"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.Find.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Name = "btnFind"
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Tag = "C1PreviewActionEnum.Find"
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.ToolTipText = "Find Text"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.Hand.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Name = "btnHandTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Tag = "C1PreviewActionEnum.HandTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.ToolTipText = "Hand Tool"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.SelectText.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Name = "btnSelectTextTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Tag = "C1PreviewActionEnum.SelectTextTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.ToolTipText = "Text Select Tool"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.DropZoomFactor.Name = "dropZoomFactor"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.DropZoomFactor.Size = New System.Drawing.Size(13, 22)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.DropZoomFactor.Tag = "C1PreviewActionEnum.ZoomFactor"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ToolTipZoomFactor = Nothing
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Name = "btnZoomIn"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Tag = "C1PreviewActionEnum.ZoomIn"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.ToolTipText = "Zoom In"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Name = "btnZoomOut"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Tag = "C1PreviewActionEnum.ZoomOut"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.ToolTipText = "Zoom Out"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool, Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool})
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Name = "btnZoomTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Tag = "C1PreviewActionEnum.ZoomInTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.ToolTipText = "Zoom In Tool"
        '
        'SpinEdit
        '
        Me.SpinEdit.EditValue = New Decimal(New Integer() {1440, 0, 0, 0})
        Me.SpinEdit.Location = New System.Drawing.Point(680, 102)
        Me.SpinEdit.MenuManager = Me.ribbonControl1
        Me.SpinEdit.Name = "SpinEdit"
        Me.SpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpinEdit.Properties.Appearance.Options.UseFont = True
        Me.SpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit.Properties.Increment = New Decimal(New Integer() {3, 0, 0, 0})
        Me.SpinEdit.Properties.IsFloatValue = False
        Me.SpinEdit.Properties.MaskSettings.Set("mask", "N00")
        Me.SpinEdit.Size = New System.Drawing.Size(76, 22)
        Me.SpinEdit.TabIndex = 7
        Me.SpinEdit.Visible = False
        '
        'frmEtiqAniv
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.ClientSize = New System.Drawing.Size(1338, 722)
        Me.Controls.Add(Me.SpinEdit)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IconOptions.Icon = CType(resources.GetObject("frmEtiqAniv.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.MaximizeBox = False
        Me.Name = "frmEtiqAniv"
        Me.Ribbon = Me.ribbonControl1
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        CType(Me.SpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents C1Report1 As C1.C1Report.C1Report
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
    Friend WithEvents txtAnos As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtMAniv As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ckTodos As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btnOk As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SpinEdit As DevExpress.XtraEditors.SpinEdit
End Class
