Imports DevExpress.Drawing
Imports DevExpress.Drawing.Printing
Imports DevExpress.Utils
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

''' <summary>
''' Empilha os dois subrelatórios de formas de pagamento que já existem
''' (<c>GerencialSubFormas1</c> = cartões, <c>GerencialSubFormas2</c> = consertos)
''' para serem embutidos como um bloco único na seção 2 do <c>GerencialNovo</c>.
'''
''' Por que um wrapper e não dois XRSubreport soltos: um <c>XRSubreport</c> cresce
''' conforme o número de linhas, mas NÃO empurra os controles irmãos da mesma banda —
''' o segundo ficaria em Y fixo e os dois se sobreporiam. Em bandas distintas, a
''' seguinte desce naturalmente.
'''
''' Este relatório não abre nenhum arquivo existente no designer: os dois
''' subrelatórios continuam sendo instanciados só em código, por GerencialNovoBase.
''' </summary>
Public Class GerencialNovoSubFormas
    Inherits XtraReport

    ' 2100 - 0 (margem esq.) - 1331 (margem dir.) = 769, que é exatamente a largura
    ' interna de GerencialSubFormas1/2 (346,63 + 216,69 + 205,69).
    Friend Const LARGURA As Single = 769.0F
    Private Const MARGEM_DIR As Single = 2100.0F - LARGURA

    Private Const ALT_TITULO As Single = 45.0F
    Private Const ALT_SUB As Single = 100.0F
    Private Const GAP As Single = 20.0F

    Friend subCartoes As XRSubreport
    Friend subConsertos As XRSubreport

    Public Sub New()
        Me.Dpi = 254.0F
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.PaperKind = DXPaperKind.A4
        Me.PageWidth = 2100
        Me.PageHeight = 2970
        Me.Landscape = False
        Me.Margins = New DXMargins(0.0F, MARGEM_DIR, 0.0F, 0.0F)
        Me.Font = New DXFont("Arial", 8.0F)
        Me.SnapGridSize = 25.0F
        Me.DataSource = Nothing

        MontarLayout()
    End Sub

    Private Sub MontarLayout()
        Dim topo As New TopMarginBand() With {.Dpi = 254.0F, .HeightF = 0.0F, .Name = "TopMargin"}
        Dim rodape As New BottomMarginBand() With {.Dpi = 254.0F, .HeightF = 0.0F, .Name = "BottomMargin"}
        Dim detalhe As New DetailBand() With {.Dpi = 254.0F, .Name = "Detail"}
        Dim rodapeRel As New ReportFooterBand() With {.Dpi = 254.0F, .Name = "ReportFooter"}

        Bands.AddRange(New Band() {topo, detalhe, rodapeRel, rodape})

        ' --- Cartões (banda Detail) ---
        Titulo(detalhe, 0.0F, "Formas de pagamento - vendas")
        subCartoes = New XRSubreport() With {
            .Dpi = 254.0F,
            .Name = "subCartoes",
            .LocationFloat = New PointFloat(0.0F, ALT_TITULO),
            .SizeF = New SizeF(LARGURA, ALT_SUB)
        }
        detalhe.Controls.Add(subCartoes)
        detalhe.HeightF = ALT_TITULO + ALT_SUB

        ' --- Consertos (banda ReportFooter, para descer se o de cima crescer) ---
        Titulo(rodapeRel, GAP, "Formas de pagamento - consertos")
        subConsertos = New XRSubreport() With {
            .Dpi = 254.0F,
            .Name = "subConsertos",
            .LocationFloat = New PointFloat(0.0F, GAP + ALT_TITULO),
            .SizeF = New SizeF(LARGURA, ALT_SUB)
        }
        rodapeRel.Controls.Add(subConsertos)
        rodapeRel.HeightF = GAP + ALT_TITULO + ALT_SUB
    End Sub

    Private Shared Sub Titulo(banda As Band, y As Single, texto As String)
        Dim l As New XRLabel() With {
            .Dpi = 254.0F,
            .Name = "lblTitulo" & banda.Name,
            .LocationFloat = New PointFloat(0.0F, y),
            .SizeF = New SizeF(LARGURA, ALT_TITULO),
            .Text = texto,
            .Font = New DXFont("Arial", 8.0F, DXFontStyle.Bold),
            .TextAlignment = TextAlignment.MiddleLeft,
            .Padding = New PaddingInfo(15, 15, 0, 0, 254.0F),
            .BackColor = Color.Transparent,
            .Borders = BorderSide.None
        }
        l.StylePriority.UseFont = False
        l.StylePriority.UseTextAlignment = False
        l.StylePriority.UsePadding = False
        banda.Controls.Add(l)
    End Sub

    ''' <summary>
    ''' Instancia os dois subrelatórios existentes, injeta o período e faz o Fill.
    ''' Segue o mesmo padrão de GerencialBase.vb:674-684, que é o que funciona hoje.
    ''' </summary>
    Public Sub Preencher(dt1 As Date, dt2 As Date)
        Dim cartoes As New GerencialSubFormas1()
        cartoes.SqlDataSource1.Queries(0).Parameters(0).Value = dt1
        cartoes.SqlDataSource1.Queries(0).Parameters(1).Value = dt2
        cartoes.SqlDataSource1.Fill()
        subCartoes.ReportSource = cartoes

        Dim consertos As New GerencialSubFormas2()
        consertos.SqlDataSource1.Queries(0).Parameters(0).Value = dt1
        consertos.SqlDataSource1.Queries(0).Parameters(1).Value = dt2
        consertos.SqlDataSource1.Fill()
        subConsertos.ReportSource = consertos
    End Sub

End Class
