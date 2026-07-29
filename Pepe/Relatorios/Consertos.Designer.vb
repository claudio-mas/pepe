<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Consertos
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
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consertos))
        Dim XrWatermark1 As DevExpress.XtraReports.UI.XRWatermark = New DevExpress.XtraReports.UI.XRWatermark()
        Me.Detalhe = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Vencto = New DevExpress.XtraReports.UI.XRLabel()
        Me.VValor = New DevExpress.XtraReports.UI.XRLabel()
        Me.N = New DevExpress.XtraReports.UI.XRLabel()
        Me.COMISSÃO = New DevExpress.XtraReports.UI.XRLabel()
        Me.Texto29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CabeçalhoDoRelatório = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.RodapéDoRelatório = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.Texto20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Rótulo21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Texto26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Linha27 = New DevExpress.XtraReports.UI.XRLine()
        Me.Texto30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CabeçalhoDaPágina = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Linha13 = New DevExpress.XtraReports.UI.XRLine()
        Me.Linha15 = New DevExpress.XtraReports.UI.XRLine()
        Me.Rótulo6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Rótulo22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Período = New DevExpress.XtraReports.UI.XRLabel()
        Me.Rótulo24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Rótulo28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.RodapéDaPágina = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Linha18 = New DevExpress.XtraReports.UI.XRLine()
        Me.SqlDataSource = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtConsertos = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTicket = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detalhe
        '
        Me.Detalhe.BackColor = System.Drawing.Color.Transparent
        Me.Detalhe.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.Vencto, Me.VValor, Me.N, Me.COMISSÃO, Me.Texto29})
        Me.Detalhe.HeightF = 19.0!
        Me.Detalhe.Name = "Detalhe"
        Me.Detalhe.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("DT", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.BorderColor = System.Drawing.Color.Black
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.BorderWidth = 1.0!
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Forma]")})
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(644.4583!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(131.5416!, 19.0!)
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0}"
        Me.XrLabel4.Summary = XrSummary1
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrLabel4.TextFormatString = "{0}"
        '
        'Vencto
        '
        Me.Vencto.BackColor = System.Drawing.Color.Transparent
        Me.Vencto.BorderColor = System.Drawing.Color.Black
        Me.Vencto.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Vencto.BorderWidth = 1.0!
        Me.Vencto.CanGrow = False
        Me.Vencto.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT]")})
        Me.Vencto.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.Vencto.LocationFloat = New DevExpress.Utils.PointFloat(240.5!, 0!)
        Me.Vencto.Name = "Vencto"
        Me.Vencto.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Vencto.SizeF = New System.Drawing.SizeF(103.0!, 19.0!)
        Me.Vencto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.Vencto.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'VValor
        '
        Me.VValor.BackColor = System.Drawing.Color.Transparent
        Me.VValor.BorderColor = System.Drawing.Color.Black
        Me.VValor.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.VValor.BorderWidth = 1.0!
        Me.VValor.CanGrow = False
        Me.VValor.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VValor]")})
        Me.VValor.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.VValor.LocationFloat = New DevExpress.Utils.PointFloat(460.5!, 0!)
        Me.VValor.Name = "VValor"
        Me.VValor.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.VValor.SizeF = New System.Drawing.SizeF(82.0!, 19.0!)
        Me.VValor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.VValor.TextFormatString = "{0:n2}"
        '
        'N
        '
        Me.N.BackColor = System.Drawing.Color.Transparent
        Me.N.BorderColor = System.Drawing.Color.Black
        Me.N.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.N.BorderWidth = 1.0!
        Me.N.CanGrow = False
        Me.N.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[N]")})
        Me.N.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.N.LocationFloat = New DevExpress.Utils.PointFloat(5.000003!, 0!)
        Me.N.Name = "N"
        Me.N.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.N.SizeF = New System.Drawing.SizeF(235.5!, 19.0!)
        XrSummary2.FormatString = "{0}"
        Me.N.Summary = XrSummary2
        Me.N.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.N.TextFormatString = "{0}"
        '
        'COMISSÃO
        '
        Me.COMISSÃO.BackColor = System.Drawing.Color.Transparent
        Me.COMISSÃO.BorderColor = System.Drawing.Color.Black
        Me.COMISSÃO.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.COMISSÃO.BorderWidth = 1.0!
        Me.COMISSÃO.CanGrow = False
        Me.COMISSÃO.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[COMISSÃO]")})
        Me.COMISSÃO.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.COMISSÃO.LocationFloat = New DevExpress.Utils.PointFloat(548.5!, 0!)
        Me.COMISSÃO.Name = "COMISSÃO"
        Me.COMISSÃO.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.COMISSÃO.SizeF = New System.Drawing.SizeF(82.0!, 19.0!)
        Me.COMISSÃO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.COMISSÃO.TextFormatString = "{0:n2}"
        '
        'Texto29
        '
        Me.Texto29.BackColor = System.Drawing.Color.Transparent
        Me.Texto29.BorderColor = System.Drawing.Color.Black
        Me.Texto29.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Texto29.BorderWidth = 1.0!
        Me.Texto29.CanGrow = False
        Me.Texto29.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Custo]")})
        Me.Texto29.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.Texto29.LocationFloat = New DevExpress.Utils.PointFloat(366.5!, 0!)
        Me.Texto29.Name = "Texto29"
        Me.Texto29.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Texto29.SizeF = New System.Drawing.SizeF(82.0!, 19.0!)
        Me.Texto29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.Texto29.TextFormatString = "{0:n2}"
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
        Me.RodapéDoRelatório.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtTicket, Me.txtConsertos, Me.XrLabel6, Me.XrLabel5, Me.Texto20, Me.Rótulo21, Me.Texto26, Me.Linha27, Me.Texto30})
        Me.RodapéDoRelatório.HeightF = 104.5416!
        Me.RodapéDoRelatório.Name = "RodapéDoRelatório"
        '
        'Texto20
        '
        Me.Texto20.BackColor = System.Drawing.Color.Transparent
        Me.Texto20.BorderColor = System.Drawing.Color.Black
        Me.Texto20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Texto20.BorderWidth = 1.0!
        Me.Texto20.CanGrow = False
        Me.Texto20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([VVALOR])")})
        Me.Texto20.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Texto20.LocationFloat = New DevExpress.Utils.PointFloat(460.5!, 7.0!)
        Me.Texto20.Name = "Texto20"
        Me.Texto20.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Texto20.SizeF = New System.Drawing.SizeF(82.0!, 19.0!)
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.Texto20.Summary = XrSummary3
        Me.Texto20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.Texto20.TextFormatString = "{0:n2}"
        '
        'Rótulo21
        '
        Me.Rótulo21.BackColor = System.Drawing.Color.Transparent
        Me.Rótulo21.BorderColor = System.Drawing.Color.Black
        Me.Rótulo21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Rótulo21.BorderWidth = 1.0!
        Me.Rótulo21.CanGrow = False
        Me.Rótulo21.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Rótulo21.ForeColor = System.Drawing.Color.Black
        Me.Rótulo21.LocationFloat = New DevExpress.Utils.PointFloat(271.5!, 7.0!)
        Me.Rótulo21.Name = "Rótulo21"
        Me.Rótulo21.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Rótulo21.SizeF = New System.Drawing.SizeF(90.0!, 20.0!)
        Me.Rótulo21.Text = "Total:"
        Me.Rótulo21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Texto26
        '
        Me.Texto26.BackColor = System.Drawing.Color.Transparent
        Me.Texto26.BorderColor = System.Drawing.Color.Black
        Me.Texto26.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Texto26.BorderWidth = 1.0!
        Me.Texto26.CanGrow = False
        Me.Texto26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([COMISSÃO])")})
        Me.Texto26.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Texto26.LocationFloat = New DevExpress.Utils.PointFloat(548.5!, 7.0!)
        Me.Texto26.Name = "Texto26"
        Me.Texto26.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Texto26.SizeF = New System.Drawing.SizeF(82.0!, 19.0!)
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.Texto26.Summary = XrSummary4
        Me.Texto26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.Texto26.TextFormatString = "{0:n2}"
        '
        'Linha27
        '
        Me.Linha27.BorderColor = System.Drawing.Color.Black
        Me.Linha27.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Linha27.BorderWidth = 3.0!
        Me.Linha27.ForeColor = System.Drawing.Color.Black
        Me.Linha27.LineWidth = 3.0!
        Me.Linha27.LocationFloat = New DevExpress.Utils.PointFloat(5.000003!, 0.9999911!)
        Me.Linha27.Name = "Linha27"
        Me.Linha27.SizeF = New System.Drawing.SizeF(778.0!, 3.125!)
        '
        'Texto30
        '
        Me.Texto30.BackColor = System.Drawing.Color.Transparent
        Me.Texto30.BorderColor = System.Drawing.Color.Black
        Me.Texto30.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Texto30.BorderWidth = 1.0!
        Me.Texto30.CanGrow = False
        Me.Texto30.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Custo])")})
        Me.Texto30.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Texto30.LocationFloat = New DevExpress.Utils.PointFloat(366.5!, 6.0!)
        Me.Texto30.Name = "Texto30"
        Me.Texto30.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Texto30.SizeF = New System.Drawing.SizeF(82.0!, 19.0!)
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.Texto30.Summary = XrSummary5
        Me.Texto30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.Texto30.TextFormatString = "{0:n2}"
        '
        'CabeçalhoDaPágina
        '
        Me.CabeçalhoDaPágina.BackColor = System.Drawing.Color.Transparent
        Me.CabeçalhoDaPágina.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel1, Me.XrLabel2, Me.Linha13, Me.Linha15, Me.Rótulo6, Me.Rótulo22, Me.Período, Me.Rótulo24, Me.Rótulo28})
        Me.CabeçalhoDaPágina.HeightF = 92.125!
        Me.CabeçalhoDaPágina.Name = "CabeçalhoDaPágina"
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.BorderColor = System.Drawing.Color.Black
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.BorderWidth = 1.0!
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Black
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(644.4583!, 70.12501!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(131.5417!, 16.0!)
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Forma Pagto."
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.BorderColor = System.Drawing.Color.Black
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.BorderWidth = 1.0!
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Black
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(269.5!, 70.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(44.0!, 16.0!)
        Me.XrLabel1.Text = "Data"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.BorderColor = System.Drawing.Color.Black
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.BorderWidth = 1.0!
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel2.ForeColor = System.Drawing.Color.Black
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(455.5!, 70.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(87.0!, 16.0!)
        Me.XrLabel2.Text = "V."
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Linha13
        '
        Me.Linha13.BorderColor = System.Drawing.Color.Black
        Me.Linha13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Linha13.BorderWidth = 3.0!
        Me.Linha13.ForeColor = System.Drawing.Color.Black
        Me.Linha13.LineWidth = 3.0!
        Me.Linha13.LocationFloat = New DevExpress.Utils.PointFloat(5.000003!, 67.00001!)
        Me.Linha13.Name = "Linha13"
        Me.Linha13.SizeF = New System.Drawing.SizeF(778.0!, 3.125!)
        '
        'Linha15
        '
        Me.Linha15.BorderColor = System.Drawing.Color.Black
        Me.Linha15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Linha15.BorderWidth = 3.0!
        Me.Linha15.ForeColor = System.Drawing.Color.Black
        Me.Linha15.LineWidth = 3.0!
        Me.Linha15.LocationFloat = New DevExpress.Utils.PointFloat(5.000003!, 86.99998!)
        Me.Linha15.Name = "Linha15"
        Me.Linha15.SizeF = New System.Drawing.SizeF(778.0!, 3.125!)
        '
        'Rótulo6
        '
        Me.Rótulo6.BackColor = System.Drawing.Color.White
        Me.Rótulo6.BorderColor = System.Drawing.Color.Black
        Me.Rótulo6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Rótulo6.BorderWidth = 1.0!
        Me.Rótulo6.CanGrow = False
        Me.Rótulo6.Font = New DevExpress.Drawing.DXFont("Arial", 18.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Rótulo6.ForeColor = System.Drawing.Color.Black
        Me.Rótulo6.LocationFloat = New DevExpress.Utils.PointFloat(4.0!, 4.0!)
        Me.Rótulo6.Name = "Rótulo6"
        Me.Rótulo6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Rótulo6.SizeF = New System.Drawing.SizeF(170.0!, 34.0!)
        Me.Rótulo6.Text = "CONSERTOS "
        Me.Rótulo6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Rótulo22
        '
        Me.Rótulo22.BackColor = System.Drawing.Color.Transparent
        Me.Rótulo22.BorderColor = System.Drawing.Color.Black
        Me.Rótulo22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Rótulo22.BorderWidth = 1.0!
        Me.Rótulo22.CanGrow = False
        Me.Rótulo22.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Rótulo22.ForeColor = System.Drawing.Color.Black
        Me.Rótulo22.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 70.0!)
        Me.Rótulo22.Name = "Rótulo22"
        Me.Rótulo22.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Rótulo22.SizeF = New System.Drawing.SizeF(127.0!, 16.0!)
        Me.Rótulo22.Text = "Cliente"
        Me.Rótulo22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Período
        '
        Me.Período.BackColor = System.Drawing.Color.Transparent
        Me.Período.BorderColor = System.Drawing.Color.Black
        Me.Período.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Período.BorderWidth = 1.0!
        Me.Período.CanGrow = False
        Me.Período.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Período.LocationFloat = New DevExpress.Utils.PointFloat(215.0!, 11.0!)
        Me.Período.Name = "Período"
        Me.Período.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Período.SizeF = New System.Drawing.SizeF(570.9999!, 20.0!)
        XrSummary6.FormatString = "{0}"
        Me.Período.Summary = XrSummary6
        Me.Período.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Rótulo24
        '
        Me.Rótulo24.BackColor = System.Drawing.Color.Transparent
        Me.Rótulo24.BorderColor = System.Drawing.Color.Black
        Me.Rótulo24.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Rótulo24.BorderWidth = 1.0!
        Me.Rótulo24.CanGrow = False
        Me.Rótulo24.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Rótulo24.ForeColor = System.Drawing.Color.Black
        Me.Rótulo24.LocationFloat = New DevExpress.Utils.PointFloat(545.5!, 70.0!)
        Me.Rótulo24.Name = "Rótulo24"
        Me.Rótulo24.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Rótulo24.SizeF = New System.Drawing.SizeF(87.0!, 16.0!)
        Me.Rótulo24.Text = "Com."
        Me.Rótulo24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Rótulo28
        '
        Me.Rótulo28.BackColor = System.Drawing.Color.Transparent
        Me.Rótulo28.BorderColor = System.Drawing.Color.Black
        Me.Rótulo28.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Rótulo28.BorderWidth = 1.0!
        Me.Rótulo28.CanGrow = False
        Me.Rótulo28.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Rótulo28.ForeColor = System.Drawing.Color.Black
        Me.Rótulo28.LocationFloat = New DevExpress.Utils.PointFloat(361.5!, 70.0!)
        Me.Rótulo28.Name = "Rótulo28"
        Me.Rótulo28.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Rótulo28.SizeF = New System.Drawing.SizeF(87.0!, 16.0!)
        Me.Rótulo28.Text = "Custo"
        Me.Rótulo28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'RodapéDaPágina
        '
        Me.RodapéDaPágina.BackColor = System.Drawing.Color.Transparent
        Me.RodapéDaPágina.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo, Me.Linha18})
        Me.RodapéDaPágina.HeightF = 30.99998!
        Me.RodapéDaPágina.Name = "RodapéDaPágina"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(498.375!, 4.999987!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(285.6249!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPageInfo
        '
        Me.XrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 4.999987!)
        Me.XrPageInfo.Name = "XrPageInfo"
        Me.XrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo.SizeF = New System.Drawing.SizeF(208.625!, 23.0!)
        Me.XrPageInfo.TextFormatString = "{0:dddd, d' de 'MMMM' de 'yyyy}"
        '
        'Linha18
        '
        Me.Linha18.BorderColor = System.Drawing.Color.Black
        Me.Linha18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Linha18.BorderWidth = 3.0!
        Me.Linha18.ForeColor = System.Drawing.Color.Black
        Me.Linha18.LineWidth = 3.0!
        Me.Linha18.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2.000014!)
        Me.Linha18.Name = "Linha18"
        Me.Linha18.SizeF = New System.Drawing.SizeF(785.9999!, 3.125!)
        '
        'SqlDataSource
        '
        Me.SqlDataSource.ConnectionName = "Pepe.My.MySettings.Pepe_ConnString"
        Me.SqlDataSource.Name = "SqlDataSource"
        CustomSqlQuery1.Name = "Query"
        QueryParameter1.Name = "dt1"
        QueryParameter1.Type = GetType(Date)
        QueryParameter1.ValueInfo = "2023-12-01"
        QueryParameter2.Name = "dt2"
        QueryParameter2.Type = GetType(Date)
        QueryParameter2.ValueInfo = "2023-12-31"
        CustomSqlQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter1, QueryParameter2})
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.SqlDataSource.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource.ResultSchemaSerializable = resources.GetString("SqlDataSource.ResultSchemaSerializable")
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 29.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 7.708359!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.BorderColor = System.Drawing.Color.Black
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.BorderWidth = 1.0!
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Black
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(5.000003!, 66.70824!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(111.375!, 17.04169!)
        Me.XrLabel5.Text = "Op. Consertos:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.BorderColor = System.Drawing.Color.Black
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.BorderWidth = 1.0!
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(5.000003!, 84.74995!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(111.375!, 17.04168!)
        Me.XrLabel6.Text = "Ticket Médio:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtConsertos
        '
        Me.txtConsertos.BackColor = System.Drawing.Color.Transparent
        Me.txtConsertos.BorderColor = System.Drawing.Color.Black
        Me.txtConsertos.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.txtConsertos.BorderWidth = 1.0!
        Me.txtConsertos.CanGrow = False
        Me.txtConsertos.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.txtConsertos.ForeColor = System.Drawing.Color.Black
        Me.txtConsertos.LocationFloat = New DevExpress.Utils.PointFloat(116.375!, 66.70828!)
        Me.txtConsertos.Name = "txtConsertos"
        Me.txtConsertos.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtConsertos.SizeF = New System.Drawing.SizeF(127.0!, 17.04168!)
        Me.txtConsertos.Text = "0"
        Me.txtConsertos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtTicket
        '
        Me.txtTicket.BackColor = System.Drawing.Color.Transparent
        Me.txtTicket.BorderColor = System.Drawing.Color.Black
        Me.txtTicket.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.txtTicket.BorderWidth = 1.0!
        Me.txtTicket.CanGrow = False
        Me.txtTicket.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.txtTicket.ForeColor = System.Drawing.Color.Black
        Me.txtTicket.LocationFloat = New DevExpress.Utils.PointFloat(116.375!, 84.74996!)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtTicket.SizeF = New System.Drawing.SizeF(127.0!, 17.04168!)
        Me.txtTicket.Text = "0,00"
        Me.txtTicket.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Consertos
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detalhe, Me.CabeçalhoDoRelatório, Me.RodapéDoRelatório, Me.CabeçalhoDaPágina, Me.RodapéDaPágina, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource})
        Me.DataMember = "Query"
        Me.DataSource = Me.SqlDataSource
        Me.Margins = New DevExpress.Drawing.DXMargins(118.0!, 196.0!, 29.0!, 7.708359!)
        Me.PageWidth = 1100
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom
        Me.Version = "23.2"
        XrWatermark1.Id = "Watermark1"
        Me.Watermarks.Add(XrWatermark1)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detalhe As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Vencto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents VValor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents N As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents COMISSÃO As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Texto29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CabeçalhoDoRelatório As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents RodapéDoRelatório As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Texto20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Rótulo21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Texto26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Linha27 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Texto30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CabeçalhoDaPágina As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Linha13 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Linha15 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Rótulo6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Rótulo22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Período As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Rótulo24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Rótulo28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RodapéDaPágina As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents Linha18 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents SqlDataSource As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTicket As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtConsertos As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
End Class
