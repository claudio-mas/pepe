<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Balanço4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Balanço4))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
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
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TP = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooterBand2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine = New DevExpress.XtraReports.UI.XRLine()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "Pepe.My.MySettings.Pepe_ConnString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "1TabPeças"
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
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Title.Name = "Title"
        '
        'GroupCaption1
        '
        Me.GroupCaption1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
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
        Me.GroupData1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
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
        Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
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
        Me.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(131, Byte), Integer))
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
        Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
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
        Me.TotalCaption1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
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
        Me.TotalBackground1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
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
        Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.PageInfo.Name = "PageInfo"
        Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 9.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 8.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.XrLine1, Me.XrLabel10, Me.XrLabel9, Me.XrLabel5})
        Me.GroupHeader1.Dpi = 254.0!
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Classe", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader1.HeightF = 114.62!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.White
        Me.XrLabel12.BorderColor = System.Drawing.Color.White
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel12.BorderWidth = 2.0!
        Me.XrLabel12.Dpi = 254.0!
        Me.XrLabel12.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel12.ForeColor = System.Drawing.Color.Black
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(6.7005!, 63.50001!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(159.7171!, 51.12!)
        Me.XrLabel12.StyleName = "DetailCaption1"
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseBorderColor = False
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseBorderWidth = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UsePadding = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Ficha"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(478.0542!, 0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(6.0!, 114.62!)
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.White
        Me.XrLabel10.BorderColor = System.Drawing.Color.White
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel10.BorderWidth = 2.0!
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel10.ForeColor = System.Drawing.Color.Black
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(326.1348!, 63.49999!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(154.58!, 51.12!)
        Me.XrLabel10.StyleName = "DetailCaption1"
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseBorderColor = False
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseBorderWidth = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UsePadding = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Venda"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.White
        Me.XrLabel9.BorderColor = System.Drawing.Color.White
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel9.BorderWidth = 2.0!
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Black
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(166.4176!, 63.5!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(159.7171!, 51.12!)
        Me.XrLabel9.StyleName = "DetailCaption1"
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorderColor = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseBorderWidth = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UsePadding = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Custo"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.White
        Me.XrLabel5.BorderColor = System.Drawing.Color.White
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel5.BorderWidth = 2.0!
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([Família]) + ' - ' + Upper([Classe])")})
        Me.XrLabel5.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel5.ForeColor = System.Drawing.Color.DarkRed
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(52.91667!, 0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(431.1375!, 63.5!)
        Me.XrLabel5.StyleName = "GroupData1"
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseBorderWidth = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLabel3})
        Me.GroupHeader2.Dpi = 254.0!
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Família", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader2.HeightF = 53.5!
        Me.GroupHeader2.KeepTogether = True
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.RepeatEveryPage = True
        Me.GroupHeader2.Visible = False
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(478.0542!, 0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(6.0!, 53.5!)
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.White
        Me.XrLabel3.BorderColor = System.Drawing.Color.White
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel3.BorderWidth = 2.0!
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([Família])")})
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel3.ForeColor = System.Drawing.Color.DarkRed
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(52.91667!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(431.1375!, 53.5!)
        Me.XrLabel3.StyleName = "GroupData1"
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseBorderWidth = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrLabel6, Me.XrLabel7, Me.XrLabel8})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 50.0!
        Me.Detail.HierarchyPrintOptions.Indent = 50.8!
        Me.Detail.KeepTogether = True
        Me.Detail.MultiColumn.ColumnCount = 2
        Me.Detail.MultiColumn.ColumnWidth = 500.0!
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth
        Me.Detail.Name = "Detail"
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Modelo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'XrLine3
        '
        Me.XrLine3.Dpi = 254.0!
        Me.XrLine3.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(478.0542!, 0!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(6.0!, 50.0!)
        '
        'XrLabel6
        '
        Me.XrLabel6.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel6.BorderWidth = 2.0!
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Modêlo]")})
        Me.XrLabel6.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(6.700512!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(159.7171!, 50.0!)
        Me.XrLabel6.StyleName = "DetailData1"
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseBorderWidth = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel6.WordWrap = False
        '
        'XrLabel7
        '
        Me.XrLabel7.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel7.BorderWidth = 2.0!
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Custo]")})
        Me.XrLabel7.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!)
        Me.XrLabel7.ForeColor = System.Drawing.Color.Black
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(166.4176!, 0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(159.7171!, 50.0!)
        Me.XrLabel7.StyleName = "DetailData1"
        Me.XrLabel7.StylePriority.UseBorderColor = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseBorderWidth = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel7.TextFormatString = "{0:n2}"
        '
        'XrLabel8
        '
        Me.XrLabel8.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel8.BorderWidth = 2.0!
        Me.XrLabel8.CanGrow = False
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PrVenda]")})
        Me.XrLabel8.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!)
        Me.XrLabel8.ForeColor = System.Drawing.Color.Black
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(312.1348!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(162.8652!, 50.0!)
        Me.XrLabel8.StyleName = "DetailData1"
        Me.XrLabel8.StylePriority.UseBorderColor = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseBorderWidth = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UsePadding = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel8.TextFormatString = "{0:n2}"
        '
        'TP
        '
        Me.TP.DataMember = "1TabPeças"
        Me.TP.Expression = "Iif([Origem]=='F.P.','FP' ,'FF' )"
        Me.TP.Name = "TP"
        '
        'GroupHeaderBand1
        '
        Me.GroupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine5, Me.XrLabel1})
        Me.GroupHeaderBand1.Dpi = 254.0!
        Me.GroupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("TP", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)})
        Me.GroupHeaderBand1.HeightF = 53.5!
        Me.GroupHeaderBand1.Level = 2
        Me.GroupHeaderBand1.Name = "GroupHeaderBand1"
        Me.GroupHeaderBand1.RepeatEveryPage = True
        '
        'XrLine5
        '
        Me.XrLine5.Dpi = 254.0!
        Me.XrLine5.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(478.0542!, 0!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(6.0!, 53.5!)
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.White
        Me.XrLabel1.BorderColor = System.Drawing.Color.White
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel1.BorderWidth = 2.0!
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([TP])")})
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 11.25!, CType((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic), DevExpress.Drawing.DXFontStyle), DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(401.4919!, 53.5!)
        Me.XrLabel1.StyleName = "GroupData1"
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorderColor = False
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
        Me.XrLabel2.AutoWidth = True
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Classe] + ': ' + Char(10) + sumCount([IDPeça]) + ' peças'")})
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0001009305!, 2.999978!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(166.4175!, 37.80647!)
        Me.XrLabel2.StyleName = "TotalData1"
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel2.Summary = XrSummary1
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Custo])")})
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(148.5514!, 2.999978!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(172.0!, 37.81!)
        Me.XrLabel4.StyleName = "TotalData1"
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel4.Summary = XrSummary2
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel4.TextFormatString = "{0:n2}"
        Me.XrLabel4.WordWrap = False
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel11.CanGrow = False
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([PrVenda])")})
        Me.XrLabel11.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(315.5514!, 3.0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(165.1634!, 37.80647!)
        Me.XrLabel11.StyleName = "TotalData1"
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel11.Summary = XrSummary3
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel11.TextFormatString = "{0:n2}"
        Me.XrLabel11.WordWrap = False
        '
        'GroupFooterBand2
        '
        Me.GroupFooterBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine4, Me.XrLine, Me.XrLabel2, Me.XrLabel4, Me.XrLabel11})
        Me.GroupFooterBand2.Dpi = 254.0!
        Me.GroupFooterBand2.HeightF = 79.30717!
        Me.GroupFooterBand2.KeepTogether = True
        Me.GroupFooterBand2.Name = "GroupFooterBand2"
        Me.GroupFooterBand2.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
        '
        'XrLine4
        '
        Me.XrLine4.Dpi = 254.0!
        Me.XrLine4.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(478.0542!, 0!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(6.0!, 79.30717!)
        '
        'XrLine
        '
        Me.XrLine.Dpi = 254.0!
        Me.XrLine.LocationFloat = New DevExpress.Utils.PointFloat(0!, 71.30717!)
        Me.XrLine.Name = "XrLine"
        Me.XrLine.SizeF = New System.Drawing.SizeF(484.0542!, 8.0!)
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine6, Me.XrLabel17, Me.XrLabel15, Me.XrLabel16})
        Me.SubBand1.Dpi = 254.0!
        Me.SubBand1.HeightF = 53.5!
        Me.SubBand1.KeepTogether = True
        Me.SubBand1.Name = "SubBand1"
        Me.SubBand1.Scripts.OnBeforePrint = "SubBand1_BeforePrint"
        Me.SubBand1.Visible = False
        '
        'XrLine6
        '
        Me.XrLine6.Dpi = 254.0!
        Me.XrLine6.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine6.LocationFloat = New DevExpress.Utils.PointFloat(478.0542!, 0!)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.SizeF = New System.Drawing.SizeF(6.0!, 53.5!)
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel17.CanGrow = False
        Me.XrLabel17.Dpi = 254.0!
        Me.XrLabel17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([PrVenda])")})
        Me.XrLabel17.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(309.3134!, 4.71935!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(141.3508!, 37.81!)
        Me.XrLabel17.StyleName = "TotalData1"
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseForeColor = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel17.Summary = XrSummary4
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel17.TextFormatString = "{0:n2}"
        Me.XrLabel17.WordWrap = False
        '
        'XrLabel15
        '
        Me.XrLabel15.AutoWidth = True
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount([IDPeça]) + ' peças'")})
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0.0001009305!, 4.71935!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(166.4175!, 37.81!)
        Me.XrLabel15.StyleName = "TotalData1"
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel15.Summary = XrSummary5
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.Dpi = 254.0!
        Me.XrLabel16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Custo])")})
        Me.XrLabel16.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(151.3134!, 4.71935!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(172.0!, 37.81!)
        Me.XrLabel16.StyleName = "TotalData1"
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel16.Summary = XrSummary6
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel16.TextFormatString = "{0:n2}"
        Me.XrLabel16.WordWrap = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 71.38!
        Me.PageHeader.Name = "PageHeader"
        '
        'label1
        '
        Me.label1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label1.BorderWidth = 2.0!
        Me.label1.Dpi = 254.0!
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.label1.Name = "label1"
        Me.label1.SizeF = New System.Drawing.SizeF(1949.0!, 71.38!)
        Me.label1.StyleName = "Title"
        Me.label1.StylePriority.UseBorders = False
        Me.label1.StylePriority.UseBorderWidth = False
        Me.label1.StylePriority.UseForeColor = False
        Me.label1.StylePriority.UseTextAlignment = False
        Me.label1.Text = "Balanço"
        Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Balanço4
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupHeader2, Me.Detail, Me.GroupHeaderBand1, Me.GroupFooterBand2, Me.PageHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.TP})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "1TabPeças"
        Me.DataSource = Me.SqlDataSource1
        Me.Dpi = 254.0!
        Me.FilterString = "Not IsNullOrEmpty([Modêlo]) And [Vendida] = False"
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(8, 143, 9, 8)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnapGridSize = 25.0!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.GroupCaption1, Me.GroupData1, Me.DetailCaption1, Me.DetailData1, Me.GroupFooterBackground3, Me.DetailData3_Odd, Me.TotalCaption1, Me.TotalData1, Me.TotalBackground1, Me.GrandTotalCaption1, Me.GrandTotalData1, Me.GrandTotalBackground1, Me.PageInfo})
        Me.Version = "21.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
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
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TP As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents GroupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooterBand2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLine As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
End Class
