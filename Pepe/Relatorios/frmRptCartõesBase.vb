Imports DevExpress.DataAccess
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraReports.UI

Public Class frmRptCartõesBase

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

        DevExpress.LookAndFeel.UserLookAndFeel.Default.UseDefaultLookAndFeel = True
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Dark Side"

    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmRptSociosContribAlfa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmCartoesDG.Visible = True

    End Sub

    Private Sub frmRptSociosContribAlfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmCartoesDG.Visible = False
        Dim report As New frmRptCartões

        'report.SqlDataSource1.Queries(0).Parameters(1).Value = CInt(Nz(cboAno.Text, System.DateTime.Today.ToString("yyyy")))
        'report.SqlDataSource1.Queries(0).Parameters(0).Value = varMes
        report.SqlDataSource1.Fill()

        If varData <> "" Then
            report.txtData.Text = "De " & varData & " a " & varData2
        End If
        varData = ""
        varData2 = ""

        'Me.DocumentViewer1.Refresh()
        'Me.DocumentViewer1.Show()

        'Dim subreport As New frmRptTortasSaidasSub()

        'Subreport.SqlDataSource1.Queries(0).Parameters(1).Value = CInt(Nz(cboAno.Text, System.DateTime.Today.ToString("yyyy")))
        'Subreport.SqlDataSource1.Queries(0).Parameters(0).Value = varMes
        'Subreport.SqlDataSource1.Fill()

        'report.XrSubreport1.ReportSource = Subreport

        Me.DocumentViewer1.DocumentSource = report
        report.CreateDocument(False)

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim report As New frmRptCartões
        'report.SqlDataSource1.Queries(0).Parameters(0).Value = 6

        'report.SqlDataSource1.Queries(0).Parameters(0).Value = 8
        'report.SqlDataSource1.Fill()

        Me.DocumentViewer1.DocumentSource = report
        Me.DocumentViewer1.Refresh()
        Me.DocumentViewer1.Show()

    End Sub

    Private Sub BarButtonItem2_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim report As New frmRptCartões()
        'report.SqlDataSource1.Queries(0).Parameters(0).Value = 6

        'report.SqlDataSource1.Queries(0).Parameters(0).Value = 8
        'report.SqlDataSource1.Fill()
        'report.txtMes.Text = Me.BarEditItem1.EditValue

        Me.DocumentViewer1.DocumentSource = report

        'Me.DocumentViewer1.Refresh()
        'Me.DocumentViewer1.Show()
        report.CreateDocument(False)
        'rptAniversariantes.SqlDataSource1.Queries(0).parameters(0).value = 8

    End Sub

End Class