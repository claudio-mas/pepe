Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Partial Public Class frmEtiqAniv
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEtiquetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmClientesDG.Visible = False

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmClientesDG.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnOk_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        If Not IsNumeric(Me.txtMAniv.EditValue) Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Informe o mês de aniversário", "Atenção!")
            Exit Sub
        End If

        Dim report As New rptEtiquetasAniv

        Try
            report.SqlDataSource1.Queries(0).Parameters(0).Value = Me.txtMAniv.EditValue
            ' Com "Todos" marcado (ou sem número no campo), não filtra pela última compra:
            ' a consulta trata @meses nulo como "todos os clientes"
            If Me.ckTodos.Checked OrElse Not IsNumeric(Me.txtAnos.EditValue) Then
                report.SqlDataSource1.Queries(0).Parameters(1).Value = Nothing
            Else
                report.SqlDataSource1.Queries(0).Parameters(1).Value = Me.txtAnos.EditValue
            End If
            report.SqlDataSource1.Fill()

            Dim printTool As New ReportPrintTool(report)
            'printTool.ShowRibbonPreview()
            'printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
            printTool.ShowPreview()
            'Me.DocumentViewer1.DocumentSource = report
            'Me.DocumentViewer1.Visible = True

            'report.CreateDocument(False)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub txtAnos_EditValueChanged(sender As Object, e As System.EventArgs) Handles txtAnos.EditValueChanged
        If IsNumeric(txtAnos.EditValue) Then
            Me.ckTodos.Checked = False
        End If

    End Sub

    Private Sub ckTodos_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ckTodos.CheckedChanged
        If Me.ckTodos.Checked Then txtAnos.EditValue = ""

    End Sub
End Class
