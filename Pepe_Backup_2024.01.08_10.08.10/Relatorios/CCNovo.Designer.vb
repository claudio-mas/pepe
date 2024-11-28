<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CCNovo
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
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CCNovo))
        Me.Detalhe = New DevExpress.XtraReports.UI.DetailBand()
        Me.Dt = New DevExpress.XtraReports.UI.XRLabel()
        Me.VValor = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nome = New DevExpress.XtraReports.UI.XRLabel()
        Me.Texto46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CabeçalhoDoRelatório = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.RodapéDoRelatório = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.A = New DevExpress.XtraReports.UI.XRLabel()
        Me.Linha39 = New DevExpress.XtraReports.UI.XRLine()
        Me.CabeçalhoDaPágina = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Linha13 = New DevExpress.XtraReports.UI.XRLine()
        Me.Linha15 = New DevExpress.XtraReports.UI.XRLine()
        Me.Rótulo6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Linha9 = New DevExpress.XtraReports.UI.XRLine()
        Me.Rótulo22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Texto45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Rótulo45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.RodapéDaPágina = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Linha17 = New DevExpress.XtraReports.UI.XRLine()
        Me.Linha18 = New DevExpress.XtraReports.UI.XRLine()
        Me.SqlDataSource = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detalhe
        '
        Me.Detalhe.BackColor = System.Drawing.Color.Transparent
        Me.Detalhe.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Dt, Me.VValor, Me.Nome, Me.Texto46})
        Me.Detalhe.HeightF = 23.0!
        Me.Detalhe.Name = "Detalhe"
        Me.Detalhe.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Saldo", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)})
        '
        'Dt
        '
        Me.Dt.BackColor = System.Drawing.Color.Transparent
        Me.Dt.BorderColor = System.Drawing.Color.Black
        Me.Dt.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Dt.BorderWidth = 1.0!
        Me.Dt.CanGrow = False
        Me.Dt.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[D]")})
        Me.Dt.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.Dt.LocationFloat = New DevExpress.Utils.PointFloat(394.0!, 1.0!)
        Me.Dt.Name = "Dt"
        Me.Dt.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Dt.SizeF = New System.Drawing.SizeF(88.0!, 19.0!)
        Me.Dt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.Dt.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'VValor
        '
        Me.VValor.BackColor = System.Drawing.Color.Transparent
        Me.VValor.BorderColor = System.Drawing.Color.Black
        Me.VValor.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.VValor.BorderWidth = 1.0!
        Me.VValor.CanGrow = False
        Me.VValor.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Anterior]")})
        Me.VValor.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.VValor.LocationFloat = New DevExpress.Utils.PointFloat(566.0!, 1.0!)
        Me.VValor.Name = "VValor"
        Me.VValor.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.VValor.SizeF = New System.Drawing.SizeF(78.0!, 19.0!)
        Me.VValor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.VValor.TextFormatString = "{0:n2}"
        '
        'Nome
        '
        Me.Nome.BackColor = System.Drawing.Color.Transparent
        Me.Nome.BorderColor = System.Drawing.Color.Black
        Me.Nome.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Nome.BorderWidth = 1.0!
        Me.Nome.CanGrow = False
        Me.Nome.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Nome]")})
        Me.Nome.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.Nome.LocationFloat = New DevExpress.Utils.PointFloat(7.0!, 1.0!)
        Me.Nome.Name = "Nome"
        Me.Nome.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Nome.SizeF = New System.Drawing.SizeF(350.0!, 19.0!)
        XrSummary1.FormatString = "{0}"
        Me.Nome.Summary = XrSummary1
        Me.Nome.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.Nome.TextFormatString = "{0}"
        '
        'Texto46
        '
        Me.Texto46.BackColor = System.Drawing.Color.Transparent
        Me.Texto46.BorderColor = System.Drawing.Color.Black
        Me.Texto46.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Texto46.BorderWidth = 1.0!
        Me.Texto46.CanGrow = False
        Me.Texto46.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Saldo]")})
        Me.Texto46.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.Texto46.LocationFloat = New DevExpress.Utils.PointFloat(662.0!, 1.0!)
        Me.Texto46.Name = "Texto46"
        Me.Texto46.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Texto46.SizeF = New System.Drawing.SizeF(79.0!, 19.0!)
        Me.Texto46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.Texto46.TextFormatString = "{0:n2}"
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
        Me.RodapéDoRelatório.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.A, Me.Linha39})
        Me.RodapéDoRelatório.HeightF = 23.0!
        Me.RodapéDoRelatório.Name = "RodapéDoRelatório"
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.BorderColor = System.Drawing.Color.Black
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.BorderWidth = 1.0!
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Anterior])")})
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(571.0!, 4.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(73.0!, 19.0!)
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel3.Summary = XrSummary2
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel3.TextFormatString = "{0:n2}"
        '
        'A
        '
        Me.A.BackColor = System.Drawing.Color.Transparent
        Me.A.BorderColor = System.Drawing.Color.Black
        Me.A.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.A.BorderWidth = 1.0!
        Me.A.CanGrow = False
        Me.A.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Saldo])")})
        Me.A.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.A.LocationFloat = New DevExpress.Utils.PointFloat(667.0!, 3.0!)
        Me.A.Name = "A"
        Me.A.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.A.SizeF = New System.Drawing.SizeF(73.0!, 19.0!)
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.A.Summary = XrSummary3
        Me.A.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.A.TextFormatString = "{0:n2}"
        '
        'Linha39
        '
        Me.Linha39.BorderColor = System.Drawing.Color.Black
        Me.Linha39.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Linha39.BorderWidth = 3.0!
        Me.Linha39.ForeColor = System.Drawing.Color.Black
        Me.Linha39.LineWidth = 3.0!
        Me.Linha39.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1.0!)
        Me.Linha39.Name = "Linha39"
        Me.Linha39.SizeF = New System.Drawing.SizeF(743.0!, 3.125!)
        '
        'CabeçalhoDaPágina
        '
        Me.CabeçalhoDaPágina.BackColor = System.Drawing.Color.Transparent
        Me.CabeçalhoDaPágina.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrLabel1, Me.XrLabel2, Me.Linha13, Me.Linha15, Me.Rótulo6, Me.Linha9, Me.Rótulo22, Me.Texto45, Me.Rótulo45})
        Me.CabeçalhoDaPágina.HeightF = 92.125!
        Me.CabeçalhoDaPágina.Name = "CabeçalhoDaPágina"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New DevExpress.Drawing.DXFont("Segoe UI Semibold", 14.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 40.0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(319.7917!, 23.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrPageInfo2.TextFormatString = "{0:dd/MM/yyyy}"
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
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(362.0!, 71.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(152.0!, 18.0!)
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Data Última Operação"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(543.0!, 71.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(101.0!, 18.0!)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Saldo Anterior"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Linha13
        '
        Me.Linha13.BorderColor = System.Drawing.Color.Black
        Me.Linha13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Linha13.BorderWidth = 3.0!
        Me.Linha13.ForeColor = System.Drawing.Color.Black
        Me.Linha13.LineWidth = 3.0!
        Me.Linha13.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 69.0!)
        Me.Linha13.Name = "Linha13"
        Me.Linha13.SizeF = New System.Drawing.SizeF(736.0!, 3.125!)
        '
        'Linha15
        '
        Me.Linha15.BorderColor = System.Drawing.Color.Black
        Me.Linha15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Linha15.BorderWidth = 3.0!
        Me.Linha15.ForeColor = System.Drawing.Color.Black
        Me.Linha15.LineWidth = 3.0!
        Me.Linha15.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 89.0!)
        Me.Linha15.Name = "Linha15"
        Me.Linha15.SizeF = New System.Drawing.SizeF(736.0!, 3.125!)
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
        Me.Rótulo6.LocationFloat = New DevExpress.Utils.PointFloat(4.0!, 5.0!)
        Me.Rótulo6.Name = "Rótulo6"
        Me.Rótulo6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Rótulo6.SizeF = New System.Drawing.SizeF(338.0!, 34.0!)
        Me.Rótulo6.Text = "CONTAS CORRENTES"
        Me.Rótulo6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Linha9
        '
        Me.Linha9.BorderColor = System.Drawing.Color.Black
        Me.Linha9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Linha9.BorderWidth = 3.0!
        Me.Linha9.ForeColor = System.Drawing.Color.Black
        Me.Linha9.LineWidth = 3.0!
        Me.Linha9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2.0!)
        Me.Linha9.Name = "Linha9"
        Me.Linha9.SizeF = New System.Drawing.SizeF(743.0!, 3.125!)
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
        Me.Rótulo22.LocationFloat = New DevExpress.Utils.PointFloat(7.0!, 71.0!)
        Me.Rótulo22.Name = "Rótulo22"
        Me.Rótulo22.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Rótulo22.SizeF = New System.Drawing.SizeF(335.0!, 18.0!)
        Me.Rótulo22.StylePriority.UseTextAlignment = False
        Me.Rótulo22.Text = "Cliente"
        Me.Rótulo22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Texto45
        '
        Me.Texto45.BackColor = System.Drawing.Color.Transparent
        Me.Texto45.BorderColor = System.Drawing.Color.Black
        Me.Texto45.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Texto45.BorderWidth = 1.0!
        Me.Texto45.CanGrow = False
        Me.Texto45.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Texto45.LocationFloat = New DevExpress.Utils.PointFloat(421.0!, 11.0!)
        Me.Texto45.Name = "Texto45"
        Me.Texto45.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Texto45.SizeF = New System.Drawing.SizeF(235.0!, 20.0!)
        XrSummary4.FormatString = "{0}"
        Me.Texto45.Summary = XrSummary4
        Me.Texto45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.Texto45.Visible = False
        '
        'Rótulo45
        '
        Me.Rótulo45.BackColor = System.Drawing.Color.Transparent
        Me.Rótulo45.BorderColor = System.Drawing.Color.Black
        Me.Rótulo45.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Rótulo45.BorderWidth = 1.0!
        Me.Rótulo45.CanGrow = False
        Me.Rótulo45.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Rótulo45.ForeColor = System.Drawing.Color.Black
        Me.Rótulo45.LocationFloat = New DevExpress.Utils.PointFloat(655.0!, 71.0!)
        Me.Rótulo45.Name = "Rótulo45"
        Me.Rótulo45.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Rótulo45.SizeF = New System.Drawing.SizeF(86.0!, 18.0!)
        Me.Rótulo45.StylePriority.UseTextAlignment = False
        Me.Rótulo45.Text = "Saldo Atual"
        Me.Rótulo45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'RodapéDaPágina
        '
        Me.RodapéDaPágina.BackColor = System.Drawing.Color.Transparent
        Me.RodapéDaPágina.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo, Me.Linha17, Me.Linha18})
        Me.RodapéDaPágina.HeightF = 28.0!
        Me.RodapéDaPágina.Name = "RodapéDaPágina"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 4.999987!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(319.7917!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo
        '
        Me.XrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(640.0!, 5.0!)
        Me.XrPageInfo.Name = "XrPageInfo"
        Me.XrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrPageInfo.StylePriority.UseTextAlignment = False
        Me.XrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Linha17
        '
        Me.Linha17.BorderColor = System.Drawing.Color.Black
        Me.Linha17.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Linha17.BorderWidth = 1.0!
        Me.Linha17.ForeColor = System.Drawing.Color.Black
        Me.Linha17.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Linha17.Name = "Linha17"
        Me.Linha17.SizeF = New System.Drawing.SizeF(743.0!, 2.0!)
        '
        'Linha18
        '
        Me.Linha18.BorderColor = System.Drawing.Color.Black
        Me.Linha18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Linha18.BorderWidth = 3.0!
        Me.Linha18.ForeColor = System.Drawing.Color.Black
        Me.Linha18.LineWidth = 3.0!
        Me.Linha18.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2.0!)
        Me.Linha18.Name = "Linha18"
        Me.Linha18.SizeF = New System.Drawing.SizeF(743.0!, 3.125!)
        '
        'SqlDataSource
        '
        Me.SqlDataSource.ConnectionName = "Pepe.My.MySettings.Pepe_ConnString"
        Me.SqlDataSource.Name = "SqlDataSource"
        CustomSqlQuery1.Name = "Query"
        CustomSqlQuery1.Sql = "SELECT * From CCNovo"
        Me.SqlDataSource.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource.ResultSchemaSerializable = resources.GetString("SqlDataSource.ResultSchemaSerializable")
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 19.45833!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 13.33332!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'CCNovo
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detalhe, Me.CabeçalhoDoRelatório, Me.RodapéDoRelatório, Me.CabeçalhoDaPágina, Me.RodapéDaPágina, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource})
        Me.DataMember = "Query"
        Me.DataSource = Me.SqlDataSource
        Me.Margins = New DevExpress.Drawing.DXMargins(49, 31, 19, 13)
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom
        Me.Version = "21.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detalhe As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Dt As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents VValor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nome As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Texto46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CabeçalhoDoRelatório As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents RodapéDoRelatório As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents A As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Linha39 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents CabeçalhoDaPágina As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Linha13 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Linha15 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Rótulo6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Linha9 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Rótulo22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Texto45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Rótulo45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RodapéDaPágina As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents Linha17 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Linha18 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents SqlDataSource As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
End Class
