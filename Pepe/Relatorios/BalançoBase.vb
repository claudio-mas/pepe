Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.Drawing
Imports DevExpress.XtraReports.UI

Public Class BalançoBase

    Private Sub EndereçosClientesBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmDevPrincipal.Visible = False

        Dim report As New Balanço0

        'report.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.HundredthsOfAnInch
        'report.PaperKind = Printing.PaperKind.A4
        'report.Landscape = True
        ''report.Margins.Left = 0
        ''report.Margins.Top = 0
        ''report.Margins.Right = 0
        ''report.Margins.Bottom = 0
        'report.Margins = New Margins(100, 100, 100, 100)
        'report.Name = "Balanço"
        'report.DisplayName = "Balanço"

        Me.DocumentViewer1.DocumentSource = report
        report.CreateDocument(False)

    End Sub

    Private Sub EndereçosClientesBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        frmDevPrincipal.Visible = True

    End Sub

End Class
