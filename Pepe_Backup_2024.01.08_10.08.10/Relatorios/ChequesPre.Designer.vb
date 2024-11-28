<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ChequesPre
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
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChequesPre))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GrandTotalCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GrandTotalData1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GrandTotalBackground1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.panel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "Pepe.My.MySettings.Pepe_ConnString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "Query"
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New DevExpress.Drawing.DXFont("Arial", 14.25!)
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Title.Name = "Title"
        '
        'DetailCaption1
        '
        Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.DetailCaption1.BorderColor = System.Drawing.Color.White
        Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.DetailCaption1.BorderWidth = 2.0!
        Me.DetailCaption1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.DetailCaption1.ForeColor = System.Drawing.Color.White
        Me.DetailCaption1.Name = "DetailCaption1"
        Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData1
        '
        Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
        Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.DetailData1.BorderWidth = 2.0!
        Me.DetailData1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!)
        Me.DetailData1.ForeColor = System.Drawing.Color.Black
        Me.DetailData1.Name = "DetailData1"
        Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData3_Odd
        '
        Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
        Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailData3_Odd.BorderWidth = 1.0!
        Me.DetailData3_Odd.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!)
        Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
        Me.DetailData3_Odd.Name = "DetailData3_Odd"
        Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GrandTotalCaption1
        '
        Me.GrandTotalCaption1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.GrandTotalCaption1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.GrandTotalCaption1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.GrandTotalCaption1.Name = "GrandTotalCaption1"
        Me.GrandTotalCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254.0!)
        Me.GrandTotalCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GrandTotalData1
        '
        Me.GrandTotalData1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.GrandTotalData1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.GrandTotalData1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.GrandTotalData1.Name = "GrandTotalData1"
        Me.GrandTotalData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 15, 0, 0, 254.0!)
        Me.GrandTotalData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GrandTotalBackground1
        '
        Me.GrandTotalBackground1.BackColor = System.Drawing.Color.White
        Me.GrandTotalBackground1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.GrandTotalBackground1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.GrandTotalBackground1.BorderWidth = 2.0!
        Me.GrandTotalBackground1.Name = "GrandTotalBackground1"
        '
        'PageInfo
        '
        Me.PageInfo.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PageInfo.Name = "PageInfo"
        Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 50.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo1, Me.pageInfo2})
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 74.42!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'pageInfo1
        '
        Me.pageInfo1.Dpi = 254.0!
        Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(16.0!, 16.0!)
        Me.pageInfo1.Name = "pageInfo1"
        Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.pageInfo1.SizeF = New System.Drawing.SizeF(968.0!, 58.0!)
        Me.pageInfo1.StyleName = "PageInfo"
        '
        'pageInfo2
        '
        Me.pageInfo2.Dpi = 254.0!
        Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(1016.0!, 16.0!)
        Me.pageInfo2.Name = "pageInfo2"
        Me.pageInfo2.SizeF = New System.Drawing.SizeF(968.0!, 58.0!)
        Me.pageInfo2.StyleName = "PageInfo"
        Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.pageInfo2.TextFormatString = "Page {0} of {1}"
        '
        'ReportHeader
        '
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Dpi = 254.0!
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader1.HeightF = 0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6, Me.XrLabel7, Me.XrLabel8})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 50.0!
        Me.Detail.HierarchyPrintOptions.Indent = 50.8!
        Me.Detail.Name = "Detail"
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Vencto", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("N", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.BorderWidth = 2.0!
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[N]")})
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Black
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(439.8!, 50.0!)
        Me.XrLabel1.StyleName = "DetailData1"
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseBorderDashStyle = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseBorderWidth = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel2.BorderWidth = 2.0!
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataVenda]")})
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!)
        Me.XrLabel2.ForeColor = System.Drawing.Color.Black
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(439.8018!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(208.08!, 50.0!)
        Me.XrLabel2.StyleName = "DetailData1"
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseBorderColor = False
        Me.XrLabel2.StylePriority.UseBorderDashStyle = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseBorderWidth = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel2.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel3.BorderWidth = 2.0!
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Vencto]")})
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Black
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(650.8787!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(211.87!, 50.0!)
        Me.XrLabel3.StyleName = "DetailData1"
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseBorderDashStyle = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseBorderWidth = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel3.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel4.BorderWidth = 2.0!
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Total]")})
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!)
        Me.XrLabel4.ForeColor = System.Drawing.Color.Black
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(863.7499!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(205.54!, 50.0!)
        Me.XrLabel4.StyleName = "DetailData1"
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseBorderDashStyle = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel4.TextFormatString = "{0:n2}"
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel5.BorderWidth = 2.0!
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parcela]")})
        Me.XrLabel5.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Black
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(1069.292!, 0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(158.545!, 50.0!)
        Me.XrLabel5.StyleName = "DetailData1"
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorderDashStyle = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseBorderWidth = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel6.BorderWidth = 2.0!
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VValor]")})
        Me.XrLabel6.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(1227.838!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(223.56!, 50.0!)
        Me.XrLabel6.StyleName = "DetailData1"
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseBorderDashStyle = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseBorderWidth = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel6.TextFormatString = "{0:n2}"
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel7.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel7.BorderWidth = 2.0!
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Banco]")})
        Me.XrLabel7.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!)
        Me.XrLabel7.ForeColor = System.Drawing.Color.Black
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(1451.4!, 0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(312.43!, 50.0!)
        Me.XrLabel7.StyleName = "DetailData1"
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseBorderColor = False
        Me.XrLabel7.StylePriority.UseBorderDashStyle = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseBorderWidth = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel8.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel8.BorderWidth = 2.0!
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cheque]")})
        Me.XrLabel8.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!)
        Me.XrLabel8.ForeColor = System.Drawing.Color.Black
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(1763.831!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(236.17!, 50.0!)
        Me.XrLabel8.StyleName = "DetailData1"
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseBorderColor = False
        Me.XrLabel8.StylePriority.UseBorderDashStyle = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseBorderWidth = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UsePadding = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel1})
        Me.ReportFooter.Dpi = 254.0!
        Me.ReportFooter.HeightF = 125.4365!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'panel1
        '
        Me.panel1.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.panel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label2, Me.label3})
        Me.panel1.Dpi = 254.0!
        Me.panel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.panel1.Name = "panel1"
        Me.panel1.SizeF = New System.Drawing.SizeF(2000.0!, 88.3948!)
        Me.panel1.StyleName = "GrandTotalBackground1"
        Me.panel1.StylePriority.UseBorders = False
        '
        'label2
        '
        Me.label2.Dpi = 254.0!
        Me.label2.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(1026.752!, 24.99993!)
        Me.label2.Name = "label2"
        Me.label2.SizeF = New System.Drawing.SizeF(206.3826!, 37.80647!)
        Me.label2.StyleName = "GrandTotalCaption1"
        Me.label2.StylePriority.UseFont = False
        Me.label2.StylePriority.UseForeColor = False
        Me.label2.StylePriority.UseTextAlignment = False
        Me.label2.Text = "Total:"
        Me.label2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label3
        '
        Me.label3.CanGrow = False
        Me.label3.Dpi = 254.0!
        Me.label3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([VValor])")})
        Me.label3.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(1233.134!, 25.00001!)
        Me.label3.Name = "label3"
        Me.label3.SizeF = New System.Drawing.SizeF(218.2634!, 37.80647!)
        Me.label3.StyleName = "GrandTotalData1"
        Me.label3.StylePriority.UseFont = False
        Me.label3.StylePriority.UseForeColor = False
        Me.label3.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.label3.Summary = XrSummary1
        Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.label3.TextFormatString = "{0:n2}"
        Me.label3.WordWrap = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 194.5736!
        Me.PageHeader.Name = "PageHeader"
        '
        'label1
        '
        Me.label1.Dpi = 254.0!
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(16.0!, 16.0!)
        Me.label1.Name = "label1"
        Me.label1.SizeF = New System.Drawing.SizeF(1968.0!, 61.45361!)
        Me.label1.StyleName = "Title"
        Me.label1.StylePriority.UseForeColor = False
        Me.label1.StylePriority.UseTextAlignment = False
        Me.label1.Text = "Cheques Pré"
        Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel16.BorderColor = System.Drawing.Color.White
        Me.XrLabel16.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel16.BorderWidth = 2.0!
        Me.XrLabel16.Dpi = 254.0!
        Me.XrLabel16.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel16.ForeColor = System.Drawing.Color.White
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(1763.831!, 123.4536!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(236.1693!, 71.12!)
        Me.XrLabel16.StyleName = "DetailCaption1"
        Me.XrLabel16.StylePriority.UseBackColor = False
        Me.XrLabel16.StylePriority.UseBorderColor = False
        Me.XrLabel16.StylePriority.UseBorderDashStyle = False
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseBorderWidth = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.StylePriority.UsePadding = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Nº Cheque"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel15.BorderColor = System.Drawing.Color.White
        Me.XrLabel15.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel15.BorderWidth = 2.0!
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel15.ForeColor = System.Drawing.Color.White
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(1451.4!, 123.4536!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(312.4305!, 71.12!)
        Me.XrLabel15.StyleName = "DetailCaption1"
        Me.XrLabel15.StylePriority.UseBackColor = False
        Me.XrLabel15.StylePriority.UseBorderColor = False
        Me.XrLabel15.StylePriority.UseBorderDashStyle = False
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseBorderWidth = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UsePadding = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Banco"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel14.BorderColor = System.Drawing.Color.White
        Me.XrLabel14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel14.BorderWidth = 2.0!
        Me.XrLabel14.Dpi = 254.0!
        Me.XrLabel14.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel14.ForeColor = System.Drawing.Color.White
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(1227.838!, 123.4536!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(223.5626!, 71.12!)
        Me.XrLabel14.StyleName = "DetailCaption1"
        Me.XrLabel14.StylePriority.UseBackColor = False
        Me.XrLabel14.StylePriority.UseBorderColor = False
        Me.XrLabel14.StylePriority.UseBorderDashStyle = False
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseBorderWidth = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UsePadding = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Valor Cheque"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel13
        '
        Me.XrLabel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel13.BorderColor = System.Drawing.Color.White
        Me.XrLabel13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel13.BorderWidth = 2.0!
        Me.XrLabel13.Dpi = 254.0!
        Me.XrLabel13.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel13.ForeColor = System.Drawing.Color.White
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(1069.292!, 123.4536!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(158.545!, 71.12!)
        Me.XrLabel13.StyleName = "DetailCaption1"
        Me.XrLabel13.StylePriority.UseBackColor = False
        Me.XrLabel13.StylePriority.UseBorderColor = False
        Me.XrLabel13.StylePriority.UseBorderDashStyle = False
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseBorderWidth = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.StylePriority.UsePadding = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Parcela"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel12.BorderColor = System.Drawing.Color.White
        Me.XrLabel12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel12.BorderWidth = 2.0!
        Me.XrLabel12.Dpi = 254.0!
        Me.XrLabel12.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel12.ForeColor = System.Drawing.Color.White
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(863.7499!, 123.4536!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(205.5425!, 71.12!)
        Me.XrLabel12.StyleName = "DetailCaption1"
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseBorderColor = False
        Me.XrLabel12.StylePriority.UseBorderDashStyle = False
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseBorderWidth = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UsePadding = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Valor Total"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel11.BorderColor = System.Drawing.Color.White
        Me.XrLabel11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel11.BorderWidth = 2.0!
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel11.ForeColor = System.Drawing.Color.White
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(650.8787!, 123.4536!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(211.8712!, 71.12!)
        Me.XrLabel11.StyleName = "DetailCaption1"
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseBorderColor = False
        Me.XrLabel11.StylePriority.UseBorderDashStyle = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseBorderWidth = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UsePadding = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Bom Para"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel10.BorderColor = System.Drawing.Color.White
        Me.XrLabel10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel10.BorderWidth = 2.0!
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel10.ForeColor = System.Drawing.Color.White
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(439.8018!, 123.4536!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(208.0769!, 71.12!)
        Me.XrLabel10.StyleName = "DetailCaption1"
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseBorderColor = False
        Me.XrLabel10.StylePriority.UseBorderDashStyle = False
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseBorderWidth = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UsePadding = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Data Venda"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel9.BorderColor = System.Drawing.Color.White
        Me.XrLabel9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.BorderWidth = 2.0!
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel9.ForeColor = System.Drawing.Color.White
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 123.4536!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(439.8018!, 71.12!)
        Me.XrLabel9.StyleName = "DetailCaption1"
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorderColor = False
        Me.XrLabel9.StylePriority.UseBorderDashStyle = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseBorderWidth = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UsePadding = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Cliente"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ChequesPre
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.Detail, Me.ReportFooter, Me.PageHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "Query"
        Me.DataSource = Me.SqlDataSource1
        Me.Dpi = 254.0!
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(50, 50, 50, 74)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 25.0!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.DetailCaption1, Me.DetailData1, Me.DetailData3_Odd, Me.GrandTotalCaption1, Me.GrandTotalData1, Me.GrandTotalBackground1, Me.PageInfo})
        Me.Version = "20.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailCaption1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GrandTotalCaption1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GrandTotalData1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GrandTotalBackground1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents panel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
End Class
