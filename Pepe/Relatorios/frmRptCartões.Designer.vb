<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmRptCartões
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
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptCartões))
        Me.Detalhe = New DevExpress.XtraReports.UI.DetailBand()
        Me.VValor = New DevExpress.XtraReports.UI.XRLabel()
        Me.DataVenda = New DevExpress.XtraReports.UI.XRLabel()
        Me.Venda = New DevExpress.XtraReports.UI.XRLabel()
        Me.N = New DevExpress.XtraReports.UI.XRLabel()
        Me.Vencto = New DevExpress.XtraReports.UI.XRLabel()
        Me.Uso = New DevExpress.XtraReports.UI.XRLabel()
        Me.Parcela = New DevExpress.XtraReports.UI.XRLabel()
        Me.Banco = New DevExpress.XtraReports.UI.XRLabel()
        Me.CabeçalhoDoRelatório = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.RodapéDoRelatório = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Rótulo34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeaderSection = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.DataVenda_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Venda_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.N_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Parcela_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Vencto_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.VValor_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Uso_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Linha26 = New DevExpress.XtraReports.UI.XRLine()
        Me.Linha25 = New DevExpress.XtraReports.UI.XRLine()
        Me.Rótulo22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtData = New DevExpress.XtraReports.UI.XRLabel()
        Me.Banco_Rótulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooterSection = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Texto23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Linha27 = New DevExpress.XtraReports.UI.XRLine()
        Me.RodapéDoGrupo2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.AccessTotalsVValor = New DevExpress.XtraReports.UI.XRLabel()
        Me.Linha33 = New DevExpress.XtraReports.UI.XRLine()
        Me.Texto31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DsCheques1 = New Pepe.dsCheques()
        Me.ChequesTodosOkTableAdapter = New Pepe.dsChequesTableAdapters.ChequesTodosOkTableAdapter()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GroupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        CType(Me.DsCheques1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detalhe
        '
        Me.Detalhe.BackColor = System.Drawing.Color.Transparent
        Me.Detalhe.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.VValor, Me.DataVenda, Me.Venda, Me.N, Me.Vencto, Me.Uso, Me.Parcela})
        Me.Detalhe.HeightF = 23.0!
        Me.Detalhe.Name = "Detalhe"
        Me.Detalhe.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Venda", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("Parcela", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'VValor
        '
        Me.VValor.BackColor = System.Drawing.Color.White
        Me.VValor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.VValor.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.VValor.BorderWidth = 1.0!
        Me.VValor.CanGrow = False
        Me.VValor.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VValor]")})
        Me.VValor.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.VValor.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 2.0!)
        Me.VValor.Name = "VValor"
        Me.VValor.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.VValor.SizeF = New System.Drawing.SizeF(79.0!, 20.0!)
        Me.VValor.StylePriority.UseFont = False
        Me.VValor.StylePriority.UseTextAlignment = False
        Me.VValor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.VValor.TextFormatString = "{0:n2}"
        '
        'DataVenda
        '
        Me.DataVenda.BackColor = System.Drawing.Color.White
        Me.DataVenda.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.DataVenda.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataVenda.BorderWidth = 1.0!
        Me.DataVenda.CanGrow = False
        Me.DataVenda.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataVenda]")})
        Me.DataVenda.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.DataVenda.LocationFloat = New DevExpress.Utils.PointFloat(139.0!, 2.0!)
        Me.DataVenda.Name = "DataVenda"
        Me.DataVenda.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.DataVenda.SizeF = New System.Drawing.SizeF(82.0!, 20.0!)
        Me.DataVenda.StylePriority.UseFont = False
        Me.DataVenda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.DataVenda.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'Venda
        '
        Me.Venda.BackColor = System.Drawing.Color.White
        Me.Venda.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Venda.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Venda.BorderWidth = 1.0!
        Me.Venda.CanGrow = False
        Me.Venda.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Venda]")})
        Me.Venda.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Venda.LocationFloat = New DevExpress.Utils.PointFloat(70.0!, 2.0!)
        Me.Venda.Name = "Venda"
        Me.Venda.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Venda.SizeF = New System.Drawing.SizeF(68.0!, 20.0!)
        Me.Venda.StylePriority.UseFont = False
        XrSummary1.FormatString = "{0}"
        Me.Venda.Summary = XrSummary1
        Me.Venda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.Venda.TextFormatString = "{0}"
        '
        'N
        '
        Me.N.BackColor = System.Drawing.Color.White
        Me.N.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.N.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.N.BorderWidth = 1.0!
        Me.N.CanGrow = False
        Me.N.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[N]")})
        Me.N.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.N.LocationFloat = New DevExpress.Utils.PointFloat(225.0!, 2.0!)
        Me.N.Name = "N"
        Me.N.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.N.SizeF = New System.Drawing.SizeF(186.0!, 20.0!)
        Me.N.StylePriority.UseFont = False
        XrSummary2.FormatString = "{0}"
        Me.N.Summary = XrSummary2
        Me.N.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.N.TextFormatString = "{0}"
        '
        'Vencto
        '
        Me.Vencto.BackColor = System.Drawing.Color.White
        Me.Vencto.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Vencto.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Vencto.BorderWidth = 1.0!
        Me.Vencto.CanGrow = False
        Me.Vencto.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Vencto]")})
        Me.Vencto.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Vencto.LocationFloat = New DevExpress.Utils.PointFloat(541.0!, 2.0!)
        Me.Vencto.Name = "Vencto"
        Me.Vencto.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Vencto.SizeF = New System.Drawing.SizeF(88.0!, 20.0!)
        Me.Vencto.StylePriority.UseFont = False
        Me.Vencto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.Vencto.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'Uso
        '
        Me.Uso.BackColor = System.Drawing.Color.White
        Me.Uso.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Uso.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Uso.BorderWidth = 1.0!
        Me.Uso.CanGrow = False
        Me.Uso.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Pagto]")})
        Me.Uso.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Uso.LocationFloat = New DevExpress.Utils.PointFloat(630.0!, 2.0!)
        Me.Uso.Name = "Uso"
        Me.Uso.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Uso.SizeF = New System.Drawing.SizeF(80.0!, 20.0!)
        Me.Uso.StylePriority.UseFont = False
        Me.Uso.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.Uso.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'Parcela
        '
        Me.Parcela.BackColor = System.Drawing.Color.White
        Me.Parcela.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Parcela.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Parcela.BorderWidth = 1.0!
        Me.Parcela.CanGrow = False
        Me.Parcela.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parcela]")})
        Me.Parcela.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Parcela.LocationFloat = New DevExpress.Utils.PointFloat(413.0!, 2.0!)
        Me.Parcela.Name = "Parcela"
        Me.Parcela.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Parcela.SizeF = New System.Drawing.SizeF(49.0!, 20.0!)
        Me.Parcela.StylePriority.UseFont = False
        XrSummary3.FormatString = "{0}"
        Me.Parcela.Summary = XrSummary3
        Me.Parcela.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.Parcela.TextFormatString = "{0}"
        '
        'Banco
        '
        Me.Banco.BackColor = System.Drawing.Color.White
        Me.Banco.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Banco.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Banco.BorderWidth = 1.0!
        Me.Banco.CanGrow = False
        Me.Banco.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NomeCartão]")})
        Me.Banco.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Banco.LocationFloat = New DevExpress.Utils.PointFloat(11.0!, 0!)
        Me.Banco.Name = "Banco"
        Me.Banco.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Banco.SizeF = New System.Drawing.SizeF(100.0!, 20.0!)
        Me.Banco.StylePriority.UseFont = False
        XrSummary4.FormatString = "{0}"
        Me.Banco.Summary = XrSummary4
        Me.Banco.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.Banco.TextFormatString = "{0}"
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
        Me.RodapéDoRelatório.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.Rótulo34})
        Me.RodapéDoRelatório.HeightF = 32.0!
        Me.RodapéDoRelatório.Name = "RodapéDoRelatório"
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.White
        Me.XrLabel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.BorderWidth = 1.0!
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([VValor])")})
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 1.999982!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(79.0!, 22.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel1.Summary = XrSummary5
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel1.TextFormatString = "{0:n2}"
        '
        'Rótulo34
        '
        Me.Rótulo34.BackColor = System.Drawing.Color.White
        Me.Rótulo34.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Rótulo34.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Rótulo34.BorderWidth = 1.0!
        Me.Rótulo34.CanGrow = False
        Me.Rótulo34.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Rótulo34.ForeColor = System.Drawing.Color.Black
        Me.Rótulo34.LocationFloat = New DevExpress.Utils.PointFloat(220.0!, 4.0!)
        Me.Rótulo34.Name = "Rótulo34"
        Me.Rótulo34.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Rótulo34.SizeF = New System.Drawing.SizeF(227.0!, 20.0!)
        Me.Rótulo34.StylePriority.UseFont = False
        Me.Rótulo34.Text = "Total:"
        Me.Rótulo34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'PageHeaderSection
        '
        Me.PageHeaderSection.BackColor = System.Drawing.Color.Transparent
        Me.PageHeaderSection.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.DataVenda_Rótulo, Me.Venda_Rótulo, Me.N_Rótulo, Me.Parcela_Rótulo, Me.Vencto_Rótulo, Me.VValor_Rótulo, Me.Uso_Rótulo, Me.Linha26, Me.Linha25, Me.Rótulo22, Me.txtData, Me.Banco_Rótulo})
        Me.PageHeaderSection.HeightF = 72.0!
        Me.PageHeaderSection.Name = "PageHeaderSection"
        '
        'DataVenda_Rótulo
        '
        Me.DataVenda_Rótulo.BackColor = System.Drawing.Color.White
        Me.DataVenda_Rótulo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.DataVenda_Rótulo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataVenda_Rótulo.BorderWidth = 1.0!
        Me.DataVenda_Rótulo.CanGrow = False
        Me.DataVenda_Rótulo.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.DataVenda_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.DataVenda_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(139.0!, 49.0!)
        Me.DataVenda_Rótulo.Name = "DataVenda_Rótulo"
        Me.DataVenda_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.DataVenda_Rótulo.SizeF = New System.Drawing.SizeF(82.0!, 20.0!)
        Me.DataVenda_Rótulo.StylePriority.UseFont = False
        Me.DataVenda_Rótulo.Text = "Data Venda"
        Me.DataVenda_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Venda_Rótulo
        '
        Me.Venda_Rótulo.BackColor = System.Drawing.Color.White
        Me.Venda_Rótulo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Venda_Rótulo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Venda_Rótulo.BorderWidth = 1.0!
        Me.Venda_Rótulo.CanGrow = False
        Me.Venda_Rótulo.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Venda_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.Venda_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(69.0!, 49.0!)
        Me.Venda_Rótulo.Name = "Venda_Rótulo"
        Me.Venda_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Venda_Rótulo.SizeF = New System.Drawing.SizeF(68.0!, 20.0!)
        Me.Venda_Rótulo.StylePriority.UseFont = False
        Me.Venda_Rótulo.Text = "Nº Venda"
        Me.Venda_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'N_Rótulo
        '
        Me.N_Rótulo.BackColor = System.Drawing.Color.White
        Me.N_Rótulo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.N_Rótulo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.N_Rótulo.BorderWidth = 1.0!
        Me.N_Rótulo.CanGrow = False
        Me.N_Rótulo.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.N_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.N_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(224.0!, 49.0!)
        Me.N_Rótulo.Name = "N_Rótulo"
        Me.N_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.N_Rótulo.SizeF = New System.Drawing.SizeF(187.0!, 20.0!)
        Me.N_Rótulo.StylePriority.UseFont = False
        Me.N_Rótulo.Text = "Cliente"
        Me.N_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Parcela_Rótulo
        '
        Me.Parcela_Rótulo.BackColor = System.Drawing.Color.White
        Me.Parcela_Rótulo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Parcela_Rótulo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Parcela_Rótulo.BorderWidth = 1.0!
        Me.Parcela_Rótulo.CanGrow = False
        Me.Parcela_Rótulo.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Parcela_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.Parcela_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(413.0!, 49.0!)
        Me.Parcela_Rótulo.Name = "Parcela_Rótulo"
        Me.Parcela_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Parcela_Rótulo.SizeF = New System.Drawing.SizeF(49.0!, 20.0!)
        Me.Parcela_Rótulo.StylePriority.UseFont = False
        Me.Parcela_Rótulo.Text = "Parcela"
        Me.Parcela_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Vencto_Rótulo
        '
        Me.Vencto_Rótulo.BackColor = System.Drawing.Color.White
        Me.Vencto_Rótulo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Vencto_Rótulo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Vencto_Rótulo.BorderWidth = 1.0!
        Me.Vencto_Rótulo.CanGrow = False
        Me.Vencto_Rótulo.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Vencto_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.Vencto_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(541.0!, 49.0!)
        Me.Vencto_Rótulo.Name = "Vencto_Rótulo"
        Me.Vencto_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Vencto_Rótulo.SizeF = New System.Drawing.SizeF(88.0!, 20.0!)
        Me.Vencto_Rótulo.StylePriority.UseFont = False
        Me.Vencto_Rótulo.Text = "Vencto."
        Me.Vencto_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'VValor_Rótulo
        '
        Me.VValor_Rótulo.BackColor = System.Drawing.Color.White
        Me.VValor_Rótulo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.VValor_Rótulo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.VValor_Rótulo.BorderWidth = 1.0!
        Me.VValor_Rótulo.CanGrow = False
        Me.VValor_Rótulo.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.VValor_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.VValor_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(480.0!, 49.0!)
        Me.VValor_Rótulo.Name = "VValor_Rótulo"
        Me.VValor_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.VValor_Rótulo.SizeF = New System.Drawing.SizeF(49.0!, 20.0!)
        Me.VValor_Rótulo.StylePriority.UseFont = False
        Me.VValor_Rótulo.Text = "Valor"
        Me.VValor_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Uso_Rótulo
        '
        Me.Uso_Rótulo.BackColor = System.Drawing.Color.White
        Me.Uso_Rótulo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Uso_Rótulo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Uso_Rótulo.BorderWidth = 1.0!
        Me.Uso_Rótulo.CanGrow = False
        Me.Uso_Rótulo.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Uso_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.Uso_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(631.0!, 49.0!)
        Me.Uso_Rótulo.Name = "Uso_Rótulo"
        Me.Uso_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Uso_Rótulo.SizeF = New System.Drawing.SizeF(79.0!, 20.0!)
        Me.Uso_Rótulo.StylePriority.UseFont = False
        Me.Uso_Rótulo.Text = "Data Rec."
        Me.Uso_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Linha26
        '
        Me.Linha26.BorderColor = System.Drawing.Color.Black
        Me.Linha26.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Linha26.BorderWidth = 1.0!
        Me.Linha26.ForeColor = System.Drawing.Color.Black
        Me.Linha26.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 70.0!)
        Me.Linha26.Name = "Linha26"
        Me.Linha26.SizeF = New System.Drawing.SizeF(701.0!, 2.0!)
        '
        'Linha25
        '
        Me.Linha25.BorderColor = System.Drawing.Color.Black
        Me.Linha25.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Linha25.BorderWidth = 1.0!
        Me.Linha25.ForeColor = System.Drawing.Color.Black
        Me.Linha25.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 45.0!)
        Me.Linha25.Name = "Linha25"
        Me.Linha25.SizeF = New System.Drawing.SizeF(701.0!, 2.0!)
        '
        'Rótulo22
        '
        Me.Rótulo22.BackColor = System.Drawing.Color.White
        Me.Rótulo22.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Rótulo22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Rótulo22.BorderWidth = 1.0!
        Me.Rótulo22.CanGrow = False
        Me.Rótulo22.Font = New DevExpress.Drawing.DXFont("Segoe UI", 18.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Rótulo22.ForeColor = System.Drawing.Color.Black
        Me.Rótulo22.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 0!)
        Me.Rótulo22.Name = "Rótulo22"
        Me.Rótulo22.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Rótulo22.SizeF = New System.Drawing.SizeF(360.0!, 38.0!)
        Me.Rótulo22.StylePriority.UseFont = False
        Me.Rótulo22.Text = "Relatório de Cartões de Crédito"
        Me.Rótulo22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtData
        '
        Me.txtData.BackColor = System.Drawing.Color.White
        Me.txtData.BorderColor = System.Drawing.Color.White
        Me.txtData.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtData.BorderWidth = 1.0!
        Me.txtData.CanGrow = False
        Me.txtData.Font = New DevExpress.Drawing.DXFont("Calibri", 14.0!)
        Me.txtData.LocationFloat = New DevExpress.Utils.PointFloat(380.0!, 8.0!)
        Me.txtData.Name = "txtData"
        Me.txtData.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtData.SizeF = New System.Drawing.SizeF(331.0!, 27.0!)
        XrSummary6.FormatString = "{0}"
        Me.txtData.Summary = XrSummary6
        Me.txtData.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Banco_Rótulo
        '
        Me.Banco_Rótulo.BackColor = System.Drawing.Color.White
        Me.Banco_Rótulo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Banco_Rótulo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Banco_Rótulo.BorderWidth = 1.0!
        Me.Banco_Rótulo.CanGrow = False
        Me.Banco_Rótulo.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Banco_Rótulo.ForeColor = System.Drawing.Color.Black
        Me.Banco_Rótulo.LocationFloat = New DevExpress.Utils.PointFloat(11.0!, 49.0!)
        Me.Banco_Rótulo.Name = "Banco_Rótulo"
        Me.Banco_Rótulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Banco_Rótulo.SizeF = New System.Drawing.SizeF(58.0!, 20.0!)
        Me.Banco_Rótulo.StylePriority.UseFont = False
        Me.Banco_Rótulo.Text = "Cartão"
        Me.Banco_Rótulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooterSection
        '
        Me.PageFooterSection.BackColor = System.Drawing.Color.Transparent
        Me.PageFooterSection.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo, Me.Texto23, Me.Linha27})
        Me.PageFooterSection.HeightF = 39.0!
        Me.PageFooterSection.Name = "PageFooterSection"
        '
        'XrPageInfo
        '
        Me.XrPageInfo.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(610.0!, 16.0!)
        Me.XrPageInfo.Name = "XrPageInfo"
        Me.XrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrPageInfo.StylePriority.UseFont = False
        Me.XrPageInfo.StylePriority.UseTextAlignment = False
        Me.XrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Texto23
        '
        Me.Texto23.BackColor = System.Drawing.Color.White
        Me.Texto23.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Texto23.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Texto23.BorderWidth = 1.0!
        Me.Texto23.CanGrow = False
        Me.Texto23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Today()")})
        Me.Texto23.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Texto23.LocationFloat = New DevExpress.Utils.PointFloat(14.0!, 16.0!)
        Me.Texto23.Name = "Texto23"
        Me.Texto23.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Texto23.SizeF = New System.Drawing.SizeF(350.0!, 23.0!)
        Me.Texto23.StylePriority.UseFont = False
        Me.Texto23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.Texto23.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'Linha27
        '
        Me.Linha27.BorderColor = System.Drawing.Color.Black
        Me.Linha27.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Linha27.BorderWidth = 1.0!
        Me.Linha27.ForeColor = System.Drawing.Color.Black
        Me.Linha27.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 14.0!)
        Me.Linha27.Name = "Linha27"
        Me.Linha27.SizeF = New System.Drawing.SizeF(701.0!, 2.0!)
        '
        'RodapéDoGrupo2
        '
        Me.RodapéDoGrupo2.BackColor = System.Drawing.Color.Transparent
        Me.RodapéDoGrupo2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.AccessTotalsVValor, Me.Linha33, Me.Texto31})
        Me.RodapéDoGrupo2.HeightF = 24.0!
        Me.RodapéDoGrupo2.Name = "RodapéDoGrupo2"
        '
        'AccessTotalsVValor
        '
        Me.AccessTotalsVValor.BackColor = System.Drawing.Color.White
        Me.AccessTotalsVValor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.AccessTotalsVValor.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.AccessTotalsVValor.BorderWidth = 1.0!
        Me.AccessTotalsVValor.CanGrow = False
        Me.AccessTotalsVValor.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([VValor])")})
        Me.AccessTotalsVValor.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.AccessTotalsVValor.LocationFloat = New DevExpress.Utils.PointFloat(448.0!, 0!)
        Me.AccessTotalsVValor.Name = "AccessTotalsVValor"
        Me.AccessTotalsVValor.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.AccessTotalsVValor.SizeF = New System.Drawing.SizeF(81.0!, 22.0!)
        Me.AccessTotalsVValor.StylePriority.UseFont = False
        Me.AccessTotalsVValor.StylePriority.UseTextAlignment = False
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.AccessTotalsVValor.Summary = XrSummary7
        Me.AccessTotalsVValor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.AccessTotalsVValor.TextFormatString = "{0:n2}"
        '
        'Linha33
        '
        Me.Linha33.BorderColor = System.Drawing.Color.Black
        Me.Linha33.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Linha33.BorderWidth = 1.0!
        Me.Linha33.ForeColor = System.Drawing.Color.Black
        Me.Linha33.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 22.0!)
        Me.Linha33.Name = "Linha33"
        Me.Linha33.SizeF = New System.Drawing.SizeF(701.0!, 2.0!)
        '
        'Texto31
        '
        Me.Texto31.BackColor = System.Drawing.Color.White
        Me.Texto31.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Texto31.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Texto31.BorderWidth = 1.0!
        Me.Texto31.CanGrow = False
        Me.Texto31.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Texto31.ForeColor = System.Drawing.Color.Black
        Me.Texto31.LocationFloat = New DevExpress.Utils.PointFloat(218.0!, 2.0!)
        Me.Texto31.Name = "Texto31"
        Me.Texto31.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Texto31.SizeF = New System.Drawing.SizeF(227.0!, 20.0!)
        Me.Texto31.StylePriority.UseFont = False
        Me.Texto31.Text = "Sub-total:"
        Me.Texto31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.Texto31.Visible = False
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tabCartões", New System.Data.Common.DataColumnMapping(-1) {})})
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 17.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 28.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'DsCheques1
        '
        Me.DsCheques1.DataSetName = "dsCheques"
        Me.DsCheques1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChequesTodosOkTableAdapter
        '
        Me.ChequesTodosOkTableAdapter.ClearBeforeFill = True
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "Pepe.My.MySettings.Pepe_ConnString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "N"
        Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""303"" />"
        Table1.Name = "tabCartõesRpt"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "Venda"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "DataVenda"
        ColumnExpression3.Table = Table1
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "NomeCartão"
        ColumnExpression4.Table = Table1
        Column4.Expression = ColumnExpression4
        ColumnExpression5.ColumnName = "Parcela"
        ColumnExpression5.Table = Table1
        Column5.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "VValor"
        ColumnExpression6.Table = Table1
        Column6.Expression = ColumnExpression6
        ColumnExpression7.ColumnName = "Pagto"
        ColumnExpression7.Table = Table1
        Column7.Expression = ColumnExpression7
        ColumnExpression8.ColumnName = "Vencto"
        ColumnExpression8.Table = Table1
        Column8.Expression = ColumnExpression8
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.Columns.Add(Column5)
        SelectQuery1.Columns.Add(Column6)
        SelectQuery1.Columns.Add(Column7)
        SelectQuery1.Columns.Add(Column8)
        SelectQuery1.Name = "tabCartõesRpt"
        SelectQuery1.Tables.Add(Table1)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GroupHeaderBand1
        '
        Me.GroupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Banco})
        Me.GroupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("NomeCartão", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeaderBand1.HeightF = 21.75001!
        Me.GroupHeaderBand1.KeepTogether = True
        Me.GroupHeaderBand1.Name = "GroupHeaderBand1"
        Me.GroupHeaderBand1.RepeatEveryPage = True
        '
        'frmRptCartões
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detalhe, Me.CabeçalhoDoRelatório, Me.RodapéDoRelatório, Me.PageHeaderSection, Me.PageFooterSection, Me.RodapéDoGrupo2, Me.TopMarginBand1, Me.BottomMarginBand1, Me.GroupHeaderBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DsCheques1, Me.SqlDataSource1})
        Me.DataAdapter = Me.OleDbDataAdapter1
        Me.DataMember = "tabCartõesRpt"
        Me.DataSource = Me.SqlDataSource1
        Me.Margins = New DevExpress.Drawing.DXMargins(31, 70, 17, 28)
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom
        Me.Version = "20.1"
        CType(Me.DsCheques1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detalhe As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents DataVenda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Venda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents N As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Parcela As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents VValor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Vencto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Uso As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Banco As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CabeçalhoDoRelatório As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents RodapéDoRelatório As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Rótulo34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeaderSection As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents DataVenda_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Venda_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents N_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Parcela_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Vencto_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents VValor_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Uso_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Linha26 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Linha25 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Rótulo22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtData As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Banco_Rótulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooterSection As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents Texto23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Linha27 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents RodapéDoGrupo2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents AccessTotalsVValor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Linha33 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Texto31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DsCheques1 As dsCheques
    Friend WithEvents ChequesTodosOkTableAdapter As dsChequesTableAdapters.ChequesTodosOkTableAdapter
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents GroupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
End Class
