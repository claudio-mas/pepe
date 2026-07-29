<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PeçasVendidas
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
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PeçasVendidas))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary10 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary11 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.SqlDataSource = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupData1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupFooterBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TotalCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TotalData1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TotalBackground1 = New DevExpress.XtraReports.UI.XRControlStyle()
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
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrSubreport = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPeriodo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource
        '
        Me.SqlDataSource.ConnectionName = "Pepe.My.MySettings.Pepe_ConnString"
        Me.SqlDataSource.Name = "SqlDataSource"
        CustomSqlQuery1.Name = "Query"
        QueryParameter1.Name = "dt1"
        QueryParameter1.Type = GetType(Date)
        QueryParameter1.ValueInfo = "2021-09-01"
        QueryParameter2.Name = "dt2"
        QueryParameter2.Type = GetType(Date)
        QueryParameter2.ValueInfo = "2021-09-30"
        CustomSqlQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter1, QueryParameter2})
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.SqlDataSource.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource.ResultSchemaSerializable = resources.GetString("SqlDataSource.ResultSchemaSerializable")
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
        'GroupCaption1
        '
        Me.GroupCaption1.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.GroupCaption1.BorderColor = System.Drawing.Color.White
        Me.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.GroupCaption1.BorderWidth = 2.0!
        Me.GroupCaption1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GroupCaption1.Name = "GroupCaption1"
        Me.GroupCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254.0!)
        Me.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupData1
        '
        Me.GroupData1.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.GroupData1.BorderColor = System.Drawing.Color.White
        Me.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.GroupData1.BorderWidth = 2.0!
        Me.GroupData1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.GroupData1.ForeColor = System.Drawing.Color.White
        Me.GroupData1.Name = "GroupData1"
        Me.GroupData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254.0!)
        Me.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailCaption1
        '
        Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
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
        'GroupFooterBackground3
        '
        Me.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.GroupFooterBackground3.BorderColor = System.Drawing.Color.White
        Me.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.GroupFooterBackground3.BorderWidth = 2.0!
        Me.GroupFooterBackground3.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GroupFooterBackground3.Name = "GroupFooterBackground3"
        Me.GroupFooterBackground3.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254.0!)
        Me.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        'TotalCaption1
        '
        Me.TotalCaption1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.TotalCaption1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.TotalCaption1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalCaption1.Name = "TotalCaption1"
        Me.TotalCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254.0!)
        Me.TotalCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TotalData1
        '
        Me.TotalData1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.TotalData1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.TotalData1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.TotalData1.Name = "TotalData1"
        Me.TotalData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 15, 0, 0, 254.0!)
        Me.TotalData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TotalBackground1
        '
        Me.TotalBackground1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TotalBackground1.BorderColor = System.Drawing.Color.White
        Me.TotalBackground1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.TotalBackground1.BorderWidth = 2.0!
        Me.TotalBackground1.Name = "TotalBackground1"
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
        Me.BottomMargin.HeightF = 74.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'pageInfo1
        '
        Me.pageInfo1.Dpi = 254.0!
        Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(16.00001!, 15.99999!)
        Me.pageInfo1.Name = "pageInfo1"
        Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.pageInfo1.SizeF = New System.Drawing.SizeF(916.3843!, 58.0!)
        Me.pageInfo1.StyleName = "PageInfo"
        '
        'pageInfo2
        '
        Me.pageInfo2.Dpi = 254.0!
        Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(1032.0!, 15.99999!)
        Me.pageInfo2.Name = "pageInfo2"
        Me.pageInfo2.SizeF = New System.Drawing.SizeF(916.3843!, 58.0!)
        Me.pageInfo2.StyleName = "PageInfo"
        Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.pageInfo2.TextFormatString = "{0} / {1}"
        '
        'ReportHeader
        '
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel17})
        Me.GroupHeader1.Dpi = 254.0!
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Origem", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)})
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader1.HeightF = 68.58!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Level = 1
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'XrLabel17
        '
        Me.XrLabel17.BackColor = System.Drawing.Color.White
        Me.XrLabel17.BorderColor = System.Drawing.Color.White
        Me.XrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel17.BorderWidth = 2.0!
        Me.XrLabel17.Dpi = 254.0!
        Me.XrLabel17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Origem]")})
        Me.XrLabel17.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, CType((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic), DevExpress.Drawing.DXFontStyle))
        Me.XrLabel17.ForeColor = System.Drawing.Color.MediumBlue
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(170.5446!, 5.079995!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(1667.418!, 63.5!)
        Me.XrLabel17.StyleName = "GroupData1"
        Me.XrLabel17.StylePriority.UseBackColor = False
        Me.XrLabel17.StylePriority.UseBorderColor = False
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseBorderWidth = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseForeColor = False
        Me.XrLabel17.StylePriority.UsePadding = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel27, Me.XrLabel26, Me.XrLabel9, Me.XrLabel11, Me.XrLabel12, Me.XrLabel10})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 53.42!
        Me.Detail.HierarchyPrintOptions.Indent = 50.8!
        Me.Detail.Name = "Detail"
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("DataVenda", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("Modêlo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'XrLabel27
        '
        Me.XrLabel27.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel27.BorderWidth = 2.0!
        Me.XrLabel27.Dpi = 254.0!
        Me.XrLabel27.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Classe]")})
        Me.XrLabel27.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.XrLabel27.ForeColor = System.Drawing.Color.Black
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(555.0921!, 0!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(158.7501!, 53.42!)
        Me.XrLabel27.StyleName = "DetailData1"
        Me.XrLabel27.StylePriority.UseBorderColor = False
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseBorderWidth = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseForeColor = False
        Me.XrLabel27.StylePriority.UsePadding = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel26
        '
        Me.XrLabel26.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel26.BorderWidth = 2.0!
        Me.XrLabel26.Dpi = 254.0!
        Me.XrLabel26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MO]")})
        Me.XrLabel26.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.XrLabel26.ForeColor = System.Drawing.Color.Black
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(1481.271!, 0!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(250.9958!, 53.42!)
        Me.XrLabel26.StyleName = "DetailData1"
        Me.XrLabel26.StylePriority.UseBorderColor = False
        Me.XrLabel26.StylePriority.UseBorders = False
        Me.XrLabel26.StylePriority.UseBorderWidth = False
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseForeColor = False
        Me.XrLabel26.StylePriority.UsePadding = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel26.TextFormatString = "{0:n2}"
        '
        'XrLabel9
        '
        Me.XrLabel9.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.BorderWidth = 2.0!
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataVenda]")})
        Me.XrLabel9.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Black
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(302.7664!, 0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel9.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.Suppress
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(246.3258!, 53.42!)
        Me.XrLabel9.StyleName = "DetailData1"
        Me.XrLabel9.StylePriority.UseBorderColor = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseBorderWidth = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UsePadding = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel9.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'XrLabel11
        '
        Me.XrLabel11.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel11.BorderWidth = 2.0!
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[w] + ' ' + [Modêlo]")})
        Me.XrLabel11.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.XrLabel11.ForeColor = System.Drawing.Color.Black
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(713.8423!, 0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(254.4943!, 53.42!)
        Me.XrLabel11.StyleName = "DetailData1"
        Me.XrLabel11.StylePriority.UseBorderColor = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseBorderWidth = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UsePadding = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel12.BorderWidth = 2.0!
        Me.XrLabel12.Dpi = 254.0!
        Me.XrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Custo]")})
        Me.XrLabel12.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.XrLabel12.ForeColor = System.Drawing.Color.Black
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(1234.945!, 0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(250.9958!, 53.42!)
        Me.XrLabel12.StyleName = "DetailData1"
        Me.XrLabel12.StylePriority.UseBorderColor = False
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseBorderWidth = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UsePadding = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel12.TextFormatString = "{0:n2}"
        '
        'XrLabel10
        '
        Me.XrLabel10.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel10.BorderWidth = 2.0!
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ValorVenda]")})
        Me.XrLabel10.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.XrLabel10.ForeColor = System.Drawing.Color.Black
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(968.3367!, 0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(266.6088!, 53.42!)
        Me.XrLabel10.StyleName = "DetailData1"
        Me.XrLabel10.StylePriority.UseBorderColor = False
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseBorderWidth = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UsePadding = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel10.TextFormatString = "{0:n2}"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label2})
        Me.GroupFooter1.Dpi = 254.0!
        Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.GroupFooter1.HeightF = 15.24!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'label2
        '
        Me.label2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label2.Dpi = 254.0!
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2.0!)
        Me.label2.Name = "label2"
        Me.label2.SizeF = New System.Drawing.SizeF(1948.384!, 5.2832!)
        Me.label2.StyleName = "GroupFooterBackground3"
        Me.label2.StylePriority.UseBorders = False
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel31, Me.XrLabel21, Me.XrLabel20, Me.XrLabel19, Me.XrLabel18})
        Me.GroupFooter2.Dpi = 254.0!
        Me.GroupFooter2.HeightF = 330.0!
        Me.GroupFooter2.KeepTogether = True
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'XrLabel31
        '
        Me.XrLabel31.CanGrow = False
        Me.XrLabel31.Dpi = 254.0!
        Me.XrLabel31.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "'M. O.: R$ ' + FormatString('{0:n2}', sumSum([MO]))")})
        Me.XrLabel31.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(741.4518!, 157.2714!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(458.0964!, 67.25405!)
        Me.XrLabel31.StyleName = "TotalData1"
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseForeColor = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel31.Summary = XrSummary1
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel31.WordWrap = False
        '
        'XrLabel21
        '
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel21.Dpi = 254.0!
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(0!, 324.7168!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(1948.384!, 5.2832!)
        Me.XrLabel21.StyleName = "GroupFooterBackground3"
        Me.XrLabel21.StylePriority.UseBorders = False
        '
        'XrLabel20
        '
        Me.XrLabel20.CanGrow = False
        Me.XrLabel20.Dpi = 254.0!
        Me.XrLabel20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "'OURO: ' + FormatString('{0:n3}', sumSum([OV]))")})
        Me.XrLabel20.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(741.4518!, 227.746!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(458.0964!, 67.25404!)
        Me.XrLabel20.StyleName = "TotalData1"
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseForeColor = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel20.Summary = XrSummary2
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel20.WordWrap = False
        '
        'XrLabel19
        '
        Me.XrLabel19.CanGrow = False
        Me.XrLabel19.Dpi = 254.0!
        Me.XrLabel19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "'CUSTO: R$ ' + FormatString('{0:n2}', sumSum([Custo]))")})
        Me.XrLabel19.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(741.4518!, 90.01736!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(458.0964!, 67.25405!)
        Me.XrLabel19.StyleName = "TotalData1"
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseForeColor = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel19.Summary = XrSummary3
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel19.WordWrap = False
        '
        'XrLabel18
        '
        Me.XrLabel18.CanGrow = False
        Me.XrLabel18.Dpi = 254.0!
        Me.XrLabel18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "'SUB-TOTAL: ' + sumCount([Modêlo]) + ' PEÇAS'")})
        Me.XrLabel18.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(741.4518!, 22.00003!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(458.0964!, 67.25405!)
        Me.XrLabel18.StyleName = "TotalData1"
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel18.Summary = XrSummary4
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel18.WordWrap = False
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel30, Me.XrLabel28, Me.XrLabel29, Me.XrLabel14, Me.XrLabel15, Me.XrLabel13, Me.XrLabel7, Me.XrLabel5, Me.XrLabel6, Me.XrSubreport, Me.XrLabel25, Me.XrLabel22, Me.XrLabel23, Me.XrLabel24})
        Me.ReportFooter.Dpi = 254.0!
        Me.ReportFooter.HeightF = 860.0!
        Me.ReportFooter.KeepTogether = True
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel30
        '
        Me.XrLabel30.CanGrow = False
        Me.XrLabel30.Dpi = 254.0!
        Me.XrLabel30.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "'M. O.: R$ ' + FormatString('{0:n2}', sumSum([MO]))")})
        Me.XrLabel30.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(741.4518!, 448.6932!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(458.0964!, 67.25404!)
        Me.XrLabel30.StyleName = "TotalData1"
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseForeColor = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel30.Summary = XrSummary5
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel30.WordWrap = False
        '
        'XrLabel28
        '
        Me.XrLabel28.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel28.BorderColor = System.Drawing.Color.White
        Me.XrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel28.BorderWidth = 2.0!
        Me.XrLabel28.Dpi = 254.0!
        Me.XrLabel28.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel28.ForeColor = System.Drawing.Color.White
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(1481.271!, 22.35418!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(250.9958!, 71.12!)
        Me.XrLabel28.StyleName = "DetailCaption1"
        Me.XrLabel28.StylePriority.UseBackColor = False
        Me.XrLabel28.StylePriority.UseBorderColor = False
        Me.XrLabel28.StylePriority.UseBorders = False
        Me.XrLabel28.StylePriority.UseBorderWidth = False
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseForeColor = False
        Me.XrLabel28.StylePriority.UsePadding = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "M. O."
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel29
        '
        Me.XrLabel29.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel29.BorderWidth = 2.0!
        Me.XrLabel29.Dpi = 254.0!
        Me.XrLabel29.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([MO])")})
        Me.XrLabel29.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel29.ForeColor = System.Drawing.Color.Black
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(1481.271!, 101.4742!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(250.9958!, 67.25405!)
        Me.XrLabel29.StyleName = "DetailData1"
        Me.XrLabel29.StylePriority.UseBorderColor = False
        Me.XrLabel29.StylePriority.UseBorders = False
        Me.XrLabel29.StylePriority.UseBorderWidth = False
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseForeColor = False
        Me.XrLabel29.StylePriority.UsePadding = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel29.Summary = XrSummary6
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel29.TextFormatString = "{0:n2}"
        '
        'XrLabel14
        '
        Me.XrLabel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel14.BorderColor = System.Drawing.Color.White
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel14.BorderWidth = 2.0!
        Me.XrLabel14.Dpi = 254.0!
        Me.XrLabel14.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel14.ForeColor = System.Drawing.Color.White
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(963.6664!, 22.35418!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(266.6088!, 71.12!)
        Me.XrLabel14.StyleName = "DetailCaption1"
        Me.XrLabel14.StylePriority.UseBackColor = False
        Me.XrLabel14.StylePriority.UseBorderColor = False
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseBorderWidth = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UsePadding = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Pr. Venda"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel15.BorderColor = System.Drawing.Color.White
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel15.BorderWidth = 2.0!
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel15.ForeColor = System.Drawing.Color.White
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(1230.275!, 22.35418!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(250.9958!, 71.12!)
        Me.XrLabel15.StyleName = "DetailCaption1"
        Me.XrLabel15.StylePriority.UseBackColor = False
        Me.XrLabel15.StylePriority.UseBorderColor = False
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseBorderWidth = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UsePadding = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Custo"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel13.Dpi = 254.0!
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(0!, 276.0881!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(1948.384!, 5.2832!)
        Me.XrLabel13.StyleName = "GroupFooterBackground3"
        Me.XrLabel13.StylePriority.UseBorders = False
        '
        'XrLabel7
        '
        Me.XrLabel7.CanGrow = False
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(640.5076!, 101.4742!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(323.1589!, 67.25406!)
        Me.XrLabel7.StyleName = "TotalData1"
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Total Geral:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel7.WordWrap = False
        '
        'XrLabel5
        '
        Me.XrLabel5.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel5.BorderWidth = 2.0!
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([ValorVenda])")})
        Me.XrLabel5.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Black
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(963.6664!, 101.4742!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(266.6088!, 67.25405!)
        Me.XrLabel5.StyleName = "DetailData1"
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseBorderWidth = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel5.Summary = XrSummary7
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel5.TextFormatString = "{0:n2}"
        '
        'XrLabel6
        '
        Me.XrLabel6.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel6.BorderWidth = 2.0!
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Custo])")})
        Me.XrLabel6.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(1230.275!, 101.4742!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(250.9958!, 67.25405!)
        Me.XrLabel6.StyleName = "DetailData1"
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseBorderWidth = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel6.Summary = XrSummary8
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel6.TextFormatString = "{0:n2}"
        '
        'XrSubreport
        '
        Me.XrSubreport.Dpi = 254.0!
        Me.XrSubreport.LocationFloat = New DevExpress.Utils.PointFloat(542.0922!, 702.7083!)
        Me.XrSubreport.Name = "XrSubreport"
        Me.XrSubreport.ReportSource = New Pepe.PeçasVendidasSub()
        Me.XrSubreport.SizeF = New System.Drawing.SizeF(830.8154!, 132.2917!)
        '
        'XrLabel25
        '
        Me.XrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel25.Dpi = 254.0!
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(0!, 613.8471!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(1948.384!, 5.2832!)
        Me.XrLabel25.StyleName = "GroupFooterBackground3"
        Me.XrLabel25.StylePriority.UseBorders = False
        '
        'XrLabel22
        '
        Me.XrLabel22.CanGrow = False
        Me.XrLabel22.Dpi = 254.0!
        Me.XrLabel22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "'TOTAL: ' + sumCount([Modêlo]) + ' PEÇAS'")})
        Me.XrLabel22.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(741.4517!, 313.4216!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(458.0964!, 67.25405!)
        Me.XrLabel22.StyleName = "TotalData1"
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseForeColor = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel22.Summary = XrSummary9
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel22.WordWrap = False
        '
        'XrLabel23
        '
        Me.XrLabel23.CanGrow = False
        Me.XrLabel23.Dpi = 254.0!
        Me.XrLabel23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "'CUSTO: R$ ' + FormatString('{0:n2}', sumSum([Custo]))")})
        Me.XrLabel23.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(741.4517!, 381.4391!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(458.0964!, 67.25404!)
        Me.XrLabel23.StyleName = "TotalData1"
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseForeColor = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel23.Summary = XrSummary10
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel23.WordWrap = False
        '
        'XrLabel24
        '
        Me.XrLabel24.CanGrow = False
        Me.XrLabel24.Dpi = 254.0!
        Me.XrLabel24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "'OURO: ' + FormatString('{0:n3}', sumSum([OV]))")})
        Me.XrLabel24.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(741.4517!, 515.9472!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(458.0964!, 67.25404!)
        Me.XrLabel24.StyleName = "TotalData1"
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseForeColor = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel24.Summary = XrSummary11
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel24.WordWrap = False
        '
        'label1
        '
        Me.label1.Dpi = 254.0!
        Me.label1.Font = New DevExpress.Drawing.DXFont("Arial", 14.25!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.label1.Name = "label1"
        Me.label1.SizeF = New System.Drawing.SizeF(1968.0!, 61.45361!)
        Me.label1.StyleName = "Title"
        Me.label1.StylePriority.UseFont = False
        Me.label1.StylePriority.UseForeColor = False
        Me.label1.StylePriority.UseTextAlignment = False
        Me.label1.Text = "PEÇAS VENDIDAS"
        Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Dpi = 254.0!
        Me.txtPeriodo.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.txtPeriodo.ForeColor = System.Drawing.Color.Black
        Me.txtPeriodo.LocationFloat = New DevExpress.Utils.PointFloat(0.7600069!, 76.44995!)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.SizeF = New System.Drawing.SizeF(1968.0!, 50.95!)
        Me.txtPeriodo.StyleName = "Title"
        Me.txtPeriodo.StylePriority.UseFont = False
        Me.txtPeriodo.StylePriority.UseForeColor = False
        Me.txtPeriodo.StylePriority.UseTextAlignment = False
        Me.txtPeriodo.Text = "PEÇAS VENDIDAS"
        Me.txtPeriodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel1.BorderColor = System.Drawing.Color.White
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.BorderWidth = 2.0!
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel1.ForeColor = System.Drawing.Color.White
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(302.7664!, 145.5209!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(246.3258!, 71.12!)
        Me.XrLabel1.StyleName = "DetailCaption1"
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseBorderWidth = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Data"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel2.BorderColor = System.Drawing.Color.White
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel2.BorderWidth = 2.0!
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel2.ForeColor = System.Drawing.Color.White
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(968.3367!, 145.5208!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(266.6088!, 71.12!)
        Me.XrLabel2.StyleName = "DetailCaption1"
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseBorderColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseBorderWidth = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Pr. Venda"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel3.BorderColor = System.Drawing.Color.White
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel3.BorderWidth = 2.0!
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel3.ForeColor = System.Drawing.Color.White
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(713.8423!, 145.5208!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(254.4943!, 71.12001!)
        Me.XrLabel3.StyleName = "DetailCaption1"
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseBorderWidth = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Ficha"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel4.BorderColor = System.Drawing.Color.White
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel4.BorderWidth = 2.0!
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel4.ForeColor = System.Drawing.Color.White
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(1234.945!, 145.5208!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(250.9958!, 71.12!)
        Me.XrLabel4.StyleName = "DetailCaption1"
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Custo"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel16, Me.txtPeriodo, Me.label1, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabel8, Me.XrLabel1})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 219.875!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel16
        '
        Me.XrLabel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel16.BorderColor = System.Drawing.Color.White
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.BorderWidth = 2.0!
        Me.XrLabel16.Dpi = 254.0!
        Me.XrLabel16.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel16.ForeColor = System.Drawing.Color.White
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(555.0922!, 145.5208!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(158.75!, 71.12001!)
        Me.XrLabel16.StyleName = "DetailCaption1"
        Me.XrLabel16.StylePriority.UseBackColor = False
        Me.XrLabel16.StylePriority.UseBorderColor = False
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseBorderWidth = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.StylePriority.UsePadding = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Tipo"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.XrLabel8.BorderColor = System.Drawing.Color.White
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel8.BorderWidth = 2.0!
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel8.ForeColor = System.Drawing.Color.White
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(1485.941!, 145.5208!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(246.3258!, 71.12!)
        Me.XrLabel8.StyleName = "DetailCaption1"
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseBorderColor = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseBorderWidth = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UsePadding = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "M. O."
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PeçasVendidas
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.Detail, Me.GroupFooter1, Me.GroupFooter2, Me.ReportFooter, Me.PageHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource})
        Me.DataMember = "Query"
        Me.DataSource = Me.SqlDataSource
        Me.Dpi = 254.0!
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(61.0!, 50.0!, 50.0!, 74.0!)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 25.0!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.GroupCaption1, Me.GroupData1, Me.DetailCaption1, Me.DetailData1, Me.GroupFooterBackground3, Me.DetailData3_Odd, Me.TotalCaption1, Me.TotalData1, Me.TotalBackground1, Me.GrandTotalCaption1, Me.GrandTotalData1, Me.GrandTotalBackground1, Me.PageInfo})
        Me.Version = "23.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupCaption1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupData1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailCaption1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupFooterBackground3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TotalCaption1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TotalData1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TotalBackground1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GrandTotalCaption1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GrandTotalData1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GrandTotalBackground1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents txtPeriodo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrSubreport As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
End Class
