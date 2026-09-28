Imports System.IO
Imports System.Reflection
Imports Microsoft.Reporting.WinForms

''' <summary>
''' Tela-base dos relatórios RDLC (ReportViewer da Microsoft), substituta da BaseRpts (DevExpress).
''' Traz o filtro de período (txtData1, txtData2, btnOk2) e o ReportViewer1.
''' Cada relatório herda desta tela e trata o btnOk2.Click.
''' </summary>
Public Class BaseRelatorio

    Private Sub BaseRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.DesignMode Then Return
        ' Modo normal: é o único em que a caixa "Localizar" do ReportViewer funciona (no "Layout de
        ' Impressão" ela fica desabilitada). O botão "Layout de Impressão" da barra mostra as páginas como sairão.
        ReportViewer1.SetDisplayMode(DisplayMode.Normal)
        ReportViewer1.ZoomMode = ZoomMode.PageWidth
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Carrega a definição .rdlc embutida no Pepe.exe (Build Action = Embedded Resource).
    ''' </summary>
    ''' <param name="arquivo">Nome do arquivo, ex.: "Vendas.rdlc".</param>
    Public Shared Sub CarregarDefinicao(relatorio As LocalReport, arquivo As String)
        Dim asm = Assembly.GetExecutingAssembly()
        Dim nome = asm.GetManifestResourceNames().FirstOrDefault(Function(n) n.EndsWith("." & arquivo, StringComparison.OrdinalIgnoreCase))
        If nome Is Nothing Then Throw New FileNotFoundException("Relatório não encontrado nos recursos do sistema: " & arquivo)
        Using s As Stream = asm.GetManifestResourceStream(nome)
            relatorio.LoadReportDefinition(s)
        End Using
    End Sub

End Class
