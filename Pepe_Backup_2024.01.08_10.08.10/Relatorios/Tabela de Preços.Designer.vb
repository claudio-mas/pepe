<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Tabela_de_Preços
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tabela_de_Preços))
        Me.Detalhe = New DevExpress.XtraReports.UI.DetailBand()
        Me.Modêlo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Obs = New DevExpress.XtraReports.UI.XRLabel()
        Me.PrVenda = New DevExpress.XtraReports.UI.XRLabel()
        Me.Vista = New DevExpress.XtraReports.UI.XRLabel()
        Me.x2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.x3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.x4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.x5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.x6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CabeçalhoDoRelatório = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.RodapéDoRelatório = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageHeaderSection = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.Rótulo22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Texto23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooterSection = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.CabeçalhoDoGrupo0 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.TipoPeça = New DevExpress.XtraReports.UI.XRLabel()
        Me.CabeçalhoDoGrupo1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.Modêlo_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Obs_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.PrVenda_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Vista_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.x2_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.x3_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.x4_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.x5_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.x6_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Rótulo25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Descr = New DevExpress.XtraReports.UI.XRLabel()
        Me.Rótulo26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.RodapéDoGrupo0 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.SqlDataSource = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detalhe
        '
        Me.Detalhe.BackColor = System.Drawing.Color.Transparent
        Me.Detalhe.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Modêlo, Me.Obs, Me.PrVenda, Me.Vista, Me.x2, Me.x3, Me.x4, Me.x5, Me.x6})
        Me.Detalhe.HeightF = 19.0!
        Me.Detalhe.Name = "Detalhe"
        Me.Detalhe.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Modêlo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'Modêlo
        '
        Me.Modêlo.BackColor = System.Drawing.Color.White
        Me.Modêlo.BorderColor = System.Drawing.Color.Black
        Me.Modêlo.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Modêlo.BorderWidth = 1.0!
        Me.Modêlo.CanGrow = False
        Me.Modêlo.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Modêlo]")})
        Me.Modêlo.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.Modêlo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Modêlo.Name = "Modêlo"
        Me.Modêlo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Modêlo.SizeF = New System.Drawing.SizeF(71.0!, 19.0!)
        Me.Modêlo.StylePriority.UseBorders = False
        Me.Modêlo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Obs
        '
        Me.Obs.BackColor = System.Drawing.Color.White
        Me.Obs.BorderColor = System.Drawing.Color.Black
        Me.Obs.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Obs.BorderWidth = 1.0!
        Me.Obs.CanGrow = False
        Me.Obs.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Obs]")})
        Me.Obs.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.Obs.LocationFloat = New DevExpress.Utils.PointFloat(70.0!, 0!)
        Me.Obs.Name = "Obs"
        Me.Obs.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Obs.SizeF = New System.Drawing.SizeF(217.0!, 19.0!)
        Me.Obs.StylePriority.UseBorders = False
        Me.Obs.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PrVenda
        '
        Me.PrVenda.BackColor = System.Drawing.Color.White
        Me.PrVenda.BorderColor = System.Drawing.Color.Black
        Me.PrVenda.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.PrVenda.BorderWidth = 1.0!
        Me.PrVenda.CanGrow = False
        Me.PrVenda.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PrVenda]")})
        Me.PrVenda.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.PrVenda.LocationFloat = New DevExpress.Utils.PointFloat(288.0!, 0!)
        Me.PrVenda.Name = "PrVenda"
        Me.PrVenda.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PrVenda.SizeF = New System.Drawing.SizeF(55.0!, 19.0!)
        Me.PrVenda.StylePriority.UseBorders = False
        Me.PrVenda.StylePriority.UseTextAlignment = False
        Me.PrVenda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.PrVenda.TextFormatString = "{0:n2}"
        '
        'Vista
        '
        Me.Vista.BackColor = System.Drawing.Color.White
        Me.Vista.BorderColor = System.Drawing.Color.Black
        Me.Vista.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Vista.BorderWidth = 1.0!
        Me.Vista.CanGrow = False
        Me.Vista.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Vista]")})
        Me.Vista.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.Vista.LocationFloat = New DevExpress.Utils.PointFloat(342.0!, 0!)
        Me.Vista.Name = "Vista"
        Me.Vista.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Vista.SizeF = New System.Drawing.SizeF(82.0!, 19.0!)
        Me.Vista.StylePriority.UseBorders = False
        Me.Vista.StylePriority.UseTextAlignment = False
        Me.Vista.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.Vista.TextFormatString = "{0:n2}"
        '
        'x2
        '
        Me.x2.BackColor = System.Drawing.Color.White
        Me.x2.BorderColor = System.Drawing.Color.Black
        Me.x2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.x2.BorderWidth = 1.0!
        Me.x2.CanGrow = False
        Me.x2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[x2]")})
        Me.x2.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.x2.LocationFloat = New DevExpress.Utils.PointFloat(423.0!, 0!)
        Me.x2.Name = "x2"
        Me.x2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.x2.SizeF = New System.Drawing.SizeF(59.0!, 19.0!)
        Me.x2.StylePriority.UseBorders = False
        Me.x2.StylePriority.UseTextAlignment = False
        Me.x2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.x2.TextFormatString = "{0:n2}"
        '
        'x3
        '
        Me.x3.BackColor = System.Drawing.Color.White
        Me.x3.BorderColor = System.Drawing.Color.Black
        Me.x3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.x3.BorderWidth = 1.0!
        Me.x3.CanGrow = False
        Me.x3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[x3]")})
        Me.x3.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.x3.LocationFloat = New DevExpress.Utils.PointFloat(482.0!, 0!)
        Me.x3.Name = "x3"
        Me.x3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.x3.SizeF = New System.Drawing.SizeF(59.0!, 19.0!)
        Me.x3.StylePriority.UseBorders = False
        Me.x3.StylePriority.UseTextAlignment = False
        Me.x3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.x3.TextFormatString = "{0:n2}"
        '
        'x4
        '
        Me.x4.BackColor = System.Drawing.Color.White
        Me.x4.BorderColor = System.Drawing.Color.Black
        Me.x4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.x4.BorderWidth = 1.0!
        Me.x4.CanGrow = False
        Me.x4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[x4]")})
        Me.x4.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.x4.LocationFloat = New DevExpress.Utils.PointFloat(542.0!, 0!)
        Me.x4.Name = "x4"
        Me.x4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.x4.SizeF = New System.Drawing.SizeF(59.0!, 19.0!)
        Me.x4.StylePriority.UseBorders = False
        Me.x4.StylePriority.UseTextAlignment = False
        Me.x4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.x4.TextFormatString = "{0:n2}"
        '
        'x5
        '
        Me.x5.BackColor = System.Drawing.Color.White
        Me.x5.BorderColor = System.Drawing.Color.Black
        Me.x5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.x5.BorderWidth = 1.0!
        Me.x5.CanGrow = False
        Me.x5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[x5]")})
        Me.x5.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.x5.LocationFloat = New DevExpress.Utils.PointFloat(601.0!, 0!)
        Me.x5.Name = "x5"
        Me.x5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.x5.SizeF = New System.Drawing.SizeF(59.0!, 19.0!)
        Me.x5.StylePriority.UseBorders = False
        Me.x5.StylePriority.UseTextAlignment = False
        Me.x5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.x5.TextFormatString = "{0:n2}"
        '
        'x6
        '
        Me.x6.BackColor = System.Drawing.Color.White
        Me.x6.BorderColor = System.Drawing.Color.Black
        Me.x6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.x6.BorderWidth = 1.0!
        Me.x6.CanGrow = False
        Me.x6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[x6]")})
        Me.x6.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.x6.LocationFloat = New DevExpress.Utils.PointFloat(660.0!, 0!)
        Me.x6.Name = "x6"
        Me.x6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.x6.SizeF = New System.Drawing.SizeF(61.0!, 19.0!)
        Me.x6.StylePriority.UseBorders = False
        Me.x6.StylePriority.UseTextAlignment = False
        Me.x6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.x6.TextFormatString = "{0:n2}"
        '
        'CabeçalhoDoRelatório
        '
        Me.CabeçalhoDoRelatório.BackColor = System.Drawing.Color.Transparent
        Me.CabeçalhoDoRelatório.HeightF = 0!
        Me.CabeçalhoDoRelatório.Name = "CabeçalhoDoRelatório"
        '
        'RodapéDoRelatório
        '
        Me.RodapéDoRelatório.BackColor = System.Drawing.Color.Transparent
        Me.RodapéDoRelatório.HeightF = 0!
        Me.RodapéDoRelatório.Name = "RodapéDoRelatório"
        '
        'PageHeaderSection
        '
        Me.PageHeaderSection.BackColor = System.Drawing.Color.Transparent
        Me.PageHeaderSection.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Rótulo22, Me.Texto23})
        Me.PageHeaderSection.HeightF = 67.0!
        Me.PageHeaderSection.Name = "PageHeaderSection"
        '
        'Rótulo22
        '
        Me.Rótulo22.BackColor = System.Drawing.Color.Transparent
        Me.Rótulo22.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Rótulo22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Rótulo22.BorderWidth = 1.0!
        Me.Rótulo22.CanGrow = False
        Me.Rótulo22.Font = New DevExpress.Drawing.DXFont("Calibri", 16.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Rótulo22.ForeColor = System.Drawing.Color.Black
        Me.Rótulo22.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Rótulo22.Name = "Rótulo22"
        Me.Rótulo22.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Rótulo22.SizeF = New System.Drawing.SizeF(206.0!, 33.0!)
        Me.Rótulo22.Text = "TABELA DE PREÇOS"
        Me.Rótulo22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Texto23
        '
        Me.Texto23.BackColor = System.Drawing.Color.White
        Me.Texto23.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Texto23.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Texto23.BorderWidth = 1.0!
        Me.Texto23.CanGrow = False
        Me.Texto23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Today()")})
        Me.Texto23.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.Texto23.LocationFloat = New DevExpress.Utils.PointFloat(4.0!, 35.0!)
        Me.Texto23.Name = "Texto23"
        Me.Texto23.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Texto23.SizeF = New System.Drawing.SizeF(350.0!, 23.0!)
        Me.Texto23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.Texto23.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'PageFooterSection
        '
        Me.PageFooterSection.BackColor = System.Drawing.Color.Transparent
        Me.PageFooterSection.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo})
        Me.PageFooterSection.HeightF = 25.95838!
        Me.PageFooterSection.Name = "PageFooterSection"
        '
        'XrPageInfo
        '
        Me.XrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(316.0!, 10.62508!)
        Me.XrPageInfo.Name = "XrPageInfo"
        Me.XrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo.SizeF = New System.Drawing.SizeF(100.0!, 15.3333!)
        Me.XrPageInfo.StylePriority.UseTextAlignment = False
        Me.XrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'CabeçalhoDoGrupo0
        '
        Me.CabeçalhoDoGrupo0.BackColor = System.Drawing.Color.Transparent
        Me.CabeçalhoDoGrupo0.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.TipoPeça})
        Me.CabeçalhoDoGrupo0.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("TpPeça", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.CabeçalhoDoGrupo0.HeightF = 33.0!
        Me.CabeçalhoDoGrupo0.Level = 1
        Me.CabeçalhoDoGrupo0.Name = "CabeçalhoDoGrupo0"
        Me.CabeçalhoDoGrupo0.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBandExceptFirstEntry
        Me.CabeçalhoDoGrupo0.RepeatEveryPage = True
        '
        'TipoPeça
        '
        Me.TipoPeça.BackColor = System.Drawing.Color.White
        Me.TipoPeça.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.TipoPeça.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.TipoPeça.BorderWidth = 1.0!
        Me.TipoPeça.CanGrow = False
        Me.TipoPeça.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TipoPeça]")})
        Me.TipoPeça.Font = New DevExpress.Drawing.DXFont("Calibri", 16.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.TipoPeça.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.TipoPeça.Name = "TipoPeça"
        Me.TipoPeça.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TipoPeça.SizeF = New System.Drawing.SizeF(291.0!, 33.0!)
        Me.TipoPeça.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'CabeçalhoDoGrupo1
        '
        Me.CabeçalhoDoGrupo1.BackColor = System.Drawing.Color.Transparent
        Me.CabeçalhoDoGrupo1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Modêlo_Rótulo, Me.Obs_Rótulo, Me.PrVenda_Rótulo, Me.Vista_Rótulo, Me.x2_Rótulo, Me.x3_Rótulo, Me.x4_Rótulo, Me.x5_Rótulo, Me.x6_Rótulo, Me.Rótulo25, Me.Descr, Me.Rótulo26})
        Me.CabeçalhoDoGrupo1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("O", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.CabeçalhoDoGrupo1.HeightF = 83.0!
        Me.CabeçalhoDoGrupo1.KeepTogether = True
        Me.CabeçalhoDoGrupo1.Name = "CabeçalhoDoGrupo1"
        Me.CabeçalhoDoGrupo1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBandExceptFirstEntry
        Me.CabeçalhoDoGrupo1.RepeatEveryPage = True
        '
        'Modêlo_Rótulo
        '
        Me.Modêlo_Rótulo.BackColor = System.Drawing.Color.Transparent
        Me.Modêlo_Rótulo.BorderColor = System.Drawing.Color.Black
        Me.Modêlo_Rótulo.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Modêlo_Rótulo.BorderWidth = 1.0!
        Me.Modêlo_Rótulo.CanGrow = False
        Me.Modêlo_Rótulo.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Modêlo_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.Modêlo_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 39.99999!)
        Me.Modêlo_Rótulo.Name = "Modêlo_Rótulo"
        Me.Modêlo_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Modêlo_Rótulo.SizeF = New System.Drawing.SizeF(70.0!, 21.0!)
        Me.Modêlo_Rótulo.StylePriority.UseBorders = False
        Me.Modêlo_Rótulo.Text = "Nº Ficha"
        Me.Modêlo_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Obs_Rótulo
        '
        Me.Obs_Rótulo.BackColor = System.Drawing.Color.Transparent
        Me.Obs_Rótulo.BorderColor = System.Drawing.Color.Black
        Me.Obs_Rótulo.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Obs_Rótulo.BorderWidth = 1.0!
        Me.Obs_Rótulo.CanGrow = False
        Me.Obs_Rótulo.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Obs_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.Obs_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(70.0!, 40.0!)
        Me.Obs_Rótulo.Name = "Obs_Rótulo"
        Me.Obs_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Obs_Rótulo.SizeF = New System.Drawing.SizeF(218.0!, 21.0!)
        Me.Obs_Rótulo.StylePriority.UseBorders = False
        Me.Obs_Rótulo.Text = "Descrição"
        Me.Obs_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PrVenda_Rótulo
        '
        Me.PrVenda_Rótulo.BackColor = System.Drawing.Color.Transparent
        Me.PrVenda_Rótulo.BorderColor = System.Drawing.Color.Black
        Me.PrVenda_Rótulo.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.PrVenda_Rótulo.BorderWidth = 1.0!
        Me.PrVenda_Rótulo.CanGrow = False
        Me.PrVenda_Rótulo.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.PrVenda_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.PrVenda_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(288.0!, 40.0!)
        Me.PrVenda_Rótulo.Name = "PrVenda_Rótulo"
        Me.PrVenda_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PrVenda_Rótulo.SizeF = New System.Drawing.SizeF(55.0!, 43.0!)
        Me.PrVenda_Rótulo.Text = "Preço 1x" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cartão"
        Me.PrVenda_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Vista_Rótulo
        '
        Me.Vista_Rótulo.BackColor = System.Drawing.Color.Transparent
        Me.Vista_Rótulo.BorderColor = System.Drawing.Color.Black
        Me.Vista_Rótulo.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Vista_Rótulo.BorderWidth = 1.0!
        Me.Vista_Rótulo.CanGrow = False
        Me.Vista_Rótulo.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Vista_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.Vista_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(342.0!, 40.0!)
        Me.Vista_Rótulo.Name = "Vista_Rótulo"
        Me.Vista_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Vista_Rótulo.SizeF = New System.Drawing.SizeF(82.0!, 43.0!)
        Me.Vista_Rótulo.StylePriority.UseFont = False
        Me.Vista_Rótulo.Text = "Pr. à vista " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cash/cheque"
        Me.Vista_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'x2_Rótulo
        '
        Me.x2_Rótulo.BackColor = System.Drawing.Color.Transparent
        Me.x2_Rótulo.BorderColor = System.Drawing.Color.Black
        Me.x2_Rótulo.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.x2_Rótulo.BorderWidth = 1.0!
        Me.x2_Rótulo.CanGrow = False
        Me.x2_Rótulo.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.x2_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.x2_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(423.0!, 61.0!)
        Me.x2_Rótulo.Name = "x2_Rótulo"
        Me.x2_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.x2_Rótulo.SizeF = New System.Drawing.SizeF(59.0!, 22.0!)
        Me.x2_Rótulo.StylePriority.UseBorders = False
        Me.x2_Rótulo.Text = "2x"
        Me.x2_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'x3_Rótulo
        '
        Me.x3_Rótulo.BackColor = System.Drawing.Color.Transparent
        Me.x3_Rótulo.BorderColor = System.Drawing.Color.Black
        Me.x3_Rótulo.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.x3_Rótulo.BorderWidth = 1.0!
        Me.x3_Rótulo.CanGrow = False
        Me.x3_Rótulo.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.x3_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.x3_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(482.0!, 61.0!)
        Me.x3_Rótulo.Name = "x3_Rótulo"
        Me.x3_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.x3_Rótulo.SizeF = New System.Drawing.SizeF(59.0!, 22.0!)
        Me.x3_Rótulo.StylePriority.UseBorders = False
        Me.x3_Rótulo.Text = "3x"
        Me.x3_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'x4_Rótulo
        '
        Me.x4_Rótulo.BackColor = System.Drawing.Color.Transparent
        Me.x4_Rótulo.BorderColor = System.Drawing.Color.Black
        Me.x4_Rótulo.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.x4_Rótulo.BorderWidth = 1.0!
        Me.x4_Rótulo.CanGrow = False
        Me.x4_Rótulo.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.x4_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.x4_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(542.0!, 61.0!)
        Me.x4_Rótulo.Name = "x4_Rótulo"
        Me.x4_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.x4_Rótulo.SizeF = New System.Drawing.SizeF(59.0!, 22.0!)
        Me.x4_Rótulo.StylePriority.UseBorders = False
        Me.x4_Rótulo.Text = "4x"
        Me.x4_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'x5_Rótulo
        '
        Me.x5_Rótulo.BackColor = System.Drawing.Color.Transparent
        Me.x5_Rótulo.BorderColor = System.Drawing.Color.Black
        Me.x5_Rótulo.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.x5_Rótulo.BorderWidth = 1.0!
        Me.x5_Rótulo.CanGrow = False
        Me.x5_Rótulo.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.x5_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.x5_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(601.0!, 61.0!)
        Me.x5_Rótulo.Name = "x5_Rótulo"
        Me.x5_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.x5_Rótulo.SizeF = New System.Drawing.SizeF(59.0!, 22.0!)
        Me.x5_Rótulo.StylePriority.UseBorders = False
        Me.x5_Rótulo.Text = "5x"
        Me.x5_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'x6_Rótulo
        '
        Me.x6_Rótulo.BackColor = System.Drawing.Color.Transparent
        Me.x6_Rótulo.BorderColor = System.Drawing.Color.Black
        Me.x6_Rótulo.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.x6_Rótulo.BorderWidth = 1.0!
        Me.x6_Rótulo.CanGrow = False
        Me.x6_Rótulo.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.x6_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.x6_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(660.0!, 61.0!)
        Me.x6_Rótulo.Name = "x6_Rótulo"
        Me.x6_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.x6_Rótulo.SizeF = New System.Drawing.SizeF(61.0!, 22.0!)
        Me.x6_Rótulo.StylePriority.UseBorders = False
        Me.x6_Rótulo.Text = "6x"
        Me.x6_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Rótulo25
        '
        Me.Rótulo25.BackColor = System.Drawing.Color.Transparent
        Me.Rótulo25.BorderColor = System.Drawing.Color.Black
        Me.Rótulo25.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Rótulo25.BorderWidth = 1.0!
        Me.Rótulo25.CanGrow = False
        Me.Rótulo25.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Rótulo25.ForeColor = System.Drawing.Color.Black
        Me.Rótulo25.LocationFloat = New DevExpress.Utils.PointFloat(423.0!, 40.0!)
        Me.Rótulo25.Name = "Rótulo25"
        Me.Rótulo25.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Rótulo25.SizeF = New System.Drawing.SizeF(298.0!, 21.0!)
        Me.Rótulo25.Text = "Preço parcelado"
        Me.Rótulo25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Descr
        '
        Me.Descr.BackColor = System.Drawing.Color.White
        Me.Descr.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Descr.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Descr.BorderWidth = 1.0!
        Me.Descr.CanGrow = False
        Me.Descr.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Descr]")})
        Me.Descr.Font = New DevExpress.Drawing.DXFont("Calibri", 16.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Descr.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1.0!)
        Me.Descr.Name = "Descr"
        Me.Descr.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Descr.SizeF = New System.Drawing.SizeF(291.0!, 33.0!)
        XrSummary1.FormatString = "{0}"
        Me.Descr.Summary = XrSummary1
        Me.Descr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.Descr.TextFormatString = "{0}"
        '
        'Rótulo26
        '
        Me.Rótulo26.BackColor = System.Drawing.Color.Transparent
        Me.Rótulo26.BorderColor = System.Drawing.Color.Black
        Me.Rótulo26.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Rótulo26.BorderWidth = 1.0!
        Me.Rótulo26.CanGrow = False
        Me.Rótulo26.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Rótulo26.ForeColor = System.Drawing.Color.Black
        Me.Rótulo26.LocationFloat = New DevExpress.Utils.PointFloat(0!, 61.0!)
        Me.Rótulo26.Name = "Rótulo26"
        Me.Rótulo26.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Rótulo26.SizeF = New System.Drawing.SizeF(288.0!, 22.0!)
        Me.Rótulo26.StylePriority.UseBorders = False
        Me.Rótulo26.Text = " "
        Me.Rótulo26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'RodapéDoGrupo0
        '
        Me.RodapéDoGrupo0.BackColor = System.Drawing.Color.Transparent
        Me.RodapéDoGrupo0.HeightF = 0!
        Me.RodapéDoGrupo0.Name = "RodapéDoGrupo0"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "1TABPEÇAS", New System.Data.Common.DataColumnMapping(-1) {})})
        '
        'SqlDataSource
        '
        Me.SqlDataSource.ConnectionName = "Pepe.My.MySettings.Pepe_ConnString"
        Me.SqlDataSource.Name = "SqlDataSource"
        CustomSqlQuery1.Name = "Query"
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.SqlDataSource.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource.ResultSchemaSerializable = resources.GetString("SqlDataSource.ResultSchemaSerializable")
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 14.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 10.41667!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'Tabela_de_Preços
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detalhe, Me.CabeçalhoDoRelatório, Me.RodapéDoRelatório, Me.PageHeaderSection, Me.PageFooterSection, Me.CabeçalhoDoGrupo0, Me.CabeçalhoDoGrupo1, Me.RodapéDoGrupo0, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource})
        Me.DataAdapter = Me.OleDbDataAdapter1
        Me.DataMember = "Query"
        Me.DataSource = Me.SqlDataSource
        Me.Landscape = True
        Me.Margins = New DevExpress.Drawing.DXMargins(79, 16, 14, 10)
        Me.PageHeight = 583
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A5
        Me.Version = "20.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detalhe As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Modêlo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Obs As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PrVenda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Vista As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents x2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents x3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents x4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents x5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents x6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CabeçalhoDoRelatório As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents RodapéDoRelatório As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageHeaderSection As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Rótulo22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Texto23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooterSection As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents CabeçalhoDoGrupo0 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents TipoPeça As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CabeçalhoDoGrupo1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents Modêlo_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Obs_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PrVenda_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Vista_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents x2_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents x3_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents x4_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents x5_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents x6_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Rótulo25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Descr As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Rótulo26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RodapéDoGrupo0 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents SqlDataSource As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
End Class
