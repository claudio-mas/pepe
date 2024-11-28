Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Partial Public Class frmCCdg
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmClientesDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CC2TableAdapter.Fill(Me.DsCC.CC2)

        frmDevPrincipal.Visible = False

        Me.Timer.Enabled = True

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnAbrir_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnAbrir.ButtonClick
        varIdCliente = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "IDCliente")
        frmClientes.Show()

    End Sub

    '    Private Sub gridview1_CellBeginEdit() Handles GridView1.edit
    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick

        'fExecutarText("Delete From tabCartõesRpt")

        Dim rs As New ADODB.Recordset()
        Dim cnStr As String = strAdoConnection()
        rs.Open("SELECT N, NomeCartão, Venda, DataVenda, Parcela, VValor, Vencto, Pagto From tabCartõesRpt", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        For i As Integer = 0 To GridView1.DataRowCount - 1
            rs.AddNew()
            If Not IsDBNull(GridView1.GetRowCellValue(i, "N")) Then rs("N").Value = Nz(GridView1.GetRowCellValue(i, "N"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "NomeCartão")) Then rs("NomeCartão").Value = Nz(GridView1.GetRowCellValue(i, "NomeCartão"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "Venda")) Then rs("Venda").Value = Nz(GridView1.GetRowCellValue(i, "Venda"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "DataVenda")) Then rs("DataVenda").Value = Nz(GridView1.GetRowCellValue(i, "DataVenda"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "Parcela")) Then rs("Parcela").Value = Nz(GridView1.GetRowCellValue(i, "Parcela"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "VValor")) Then rs("VValor").Value = Nz(GridView1.GetRowCellValue(i, "VValor"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "Vencto")) Then rs("Vencto").Value = Nz(GridView1.GetRowCellValue(i, "Vencto"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "Pagto")) Then rs("Pagto").Value = Nz(GridView1.GetRowCellValue(i, "Pagto"), "")
            rs.Update()
        Next i

        rs.Close()

        Dim x As String = Me.GridView1.ActiveFilterString
        Dim n As Integer = InStr(x, "Between")
        If n > 0 Then
            varData = Mid(x, n + 9, 10)
            varData = Microsoft.VisualBasic.Right(varData, 2) & "/" & Microsoft.VisualBasic.Mid(varData, 6, 2) & "/" & Microsoft.VisualBasic.Left(varData, 4)
            varData2 = Mid(x, n + 23, 10)
            varData2 = Microsoft.VisualBasic.Right(varData2, 2) & "/" & Microsoft.VisualBasic.Mid(varData2, 6, 2) & "/" & Microsoft.VisualBasic.Left(varData2, 4)
        End If

        frmRptCartõesBase.Show()

    End Sub
    Private Sub btnExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcel.ItemClick

        Dim path As String = ""

        If XtraFolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            path = XtraFolderBrowserDialog.SelectedPath
            ClientesGridControl.ExportToXlsx(path & "\ContaCorrente.xlsx")
            Process.Start(path & "\ContaCorrente.xlsx")
        End If

    End Sub

    Private Sub btnCC_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnCC.ButtonClick

        Dim report As New rptExtratoCC

        Try
            report.SqlDataSource1.Queries(0).Parameters(0).Value = Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Cliente")
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

    Private Sub btnSaldos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSaldos.ItemClick

        fExecutarText("exec USP_UPDATE_SALDO_CC 0, 0")
        fExecutarText("exec USP_UPDATE_SALDO_CC 98, 1")

        Dim report As New rpt_CC_Saldos

        Try
            'report.SqlDataSource1.Queries(0).Parameters(0).Value = Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Cliente")
            report.SqlDataSource1.Fill()

            Dim printTool As New ReportPrintTool(report)
            printTool.ShowPreview()
            'report.CreateDocument(False)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnExtratos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnExtratos.ItemClick

        For Each c As GridColumn In GridView1.Columns
            c.SortOrder = DevExpress.Data.ColumnSortOrder.None
        Next

        'For i As Integer = 0 To GridView1.Columns.Count
        '    GridView1.Columns(i).SortOrder = DevExpress.Data.ColumnSortOrder.None
        '    i += 1
        'Next

        Me.GridView1.Columns("IDCliente").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

        Dim flt As String = Me.GridView1.ActiveFilterString
        Debug.Print(flt)
        Debug.Print(InStr(flt, "Between") + 9)
        Dim dt As String = Microsoft.VisualBasic.Mid(flt, InStr(flt, "Between") + 9, 10)
        Debug.Print(dt)
        dt = Microsoft.VisualBasic.Right(dt, 2) & "/" & Microsoft.VisualBasic.Mid(dt, 6, 2) & "/" & Microsoft.VisualBasic.Left(dt, 4)

        fExecutarText("Delete from tabExtrato")
        Dim x As Integer = 0, xant As Integer = 0
        For i As Integer = 0 To GridView1.DataRowCount - 1
            x = GridView1.GetRowCellValue(i, "IDCliente")
            If x <> xant Then fExecutarText("Insert Into tabExtrato (IdCliente) Values (" & x & ")") : xant = x
        Next

        fExecutarText("exec USP_CC_SALDO_INICIAL '" & dt & "'")

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        'Me.Timer.Interval = 0

        Dim x As Integer = 0
        Dim s As Double = 0
        Dim i As Integer = 0

        Do While i <= GridView1.DataRowCount - 1
            x = CInt(GridView1.GetRowCellValue(i, "IDCliente"))
            s = 0
            Do While x = CInt(GridView1.GetRowCellValue(i, "IDCliente"))
                s = s + ConvertToDouble(GridView1.GetRowCellValue(i, "Real"))
                s = s + ConvertToDouble(GridView1.GetRowCellValue(i, "Ouro"))
                s = s + ConvertToDouble(GridView1.GetRowCellValue(i, "Dolar"))
                s = s + ConvertToDouble(GridView1.GetRowCellValue(i, "Cheque"))
                s = s + ConvertToDouble(GridView1.GetRowCellValue(i, "Cartão"))
                s = s - ConvertToDouble(GridView1.GetRowCellValue(i, "CCDeb"))
                s = s + ConvertToDouble(GridView1.GetRowCellValue(i, "ValorTransf"))
                GridView1.SetRowCellValue(i, "Saldo", s)
                i += 1
            Loop

        Loop

        Me.Timer.Enabled = False

    End Sub
End Class
