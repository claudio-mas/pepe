Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Imports DevExpress.DataAccess
Imports DevExpress.XtraEditors
Imports Microsoft.Office.Interop

Partial Public Class frmClientesDG
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmClientesDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter1.Fill(Me.DsNovo.Clientes)
        'Me.ClientesTableAdapter.Fill(Me.DsPrincipal.Clientes)

        frmDevPrincipal.Visible = False

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'fExecutarText("Update Clientes Set Imp = 0 where Imp = 1 Or Imp is NULL")

        Me.Validate()
        ClientesBindingSource1.EndEdit()
        ClientesTableAdapter1.Update(DsNovo)

        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnAbrir_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnAbrir.ButtonClick
        varIdCliente = GridView1.GetFocusedRowCellValue("IDCliente")
        frmClientes.Show()

    End Sub

    Private Sub btnNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovo.ItemClick
        varIdCliente = 0
        frmClientes.Show()

    End Sub

    Private Sub ckTodas_CheckedChanged(sender As Object, e As EventArgs) Handles ckTodas.CheckedChanged

        Me.Cursor = Cursors.AppStarting
        For i As Integer = 0 To GridView1.DataRowCount - 1
            If ckTodas.Checked Then
                ckTodas.Text = "Desmarcar todas"
                GridView1.SetRowCellValue(i, "Imp", 1)
            Else
                ckTodas.Text = "Marcar todas"
                GridView1.SetRowCellValue(i, "Imp", 0)
            End If
        Next i

        Me.Validate()
        ClientesBindingSource1.EndEdit()
        ClientesTableAdapter1.Update(DsNovo)

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub btnEtiqMalaDireta_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEtiqMalaDireta.ItemClick
        Me.Validate()
        ClientesBindingSource1.EndEdit()
        ClientesTableAdapter1.Update(DsNovo)

        Dim x As String = DLookUp("Imp", "Clientes", "Imp = 1", 0)
        If x = "" Then
            'MsgBox("Nenhum cliente selecionado para impressão de etiquetas", MsgBoxStyle.Critical, "Atenção!")
            DevExpress.XtraEditors.XtraMessageBox.Show("Nenhum cliente selecionado para impressão de etiquetas", "Atenção!")
        Else
            frmEtiquetas.Show()
        End If

    End Sub

    Private Sub btnAbrirVenda_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnAbrirVenda.ButtonClick
        Try
            varIdCliente = GridView1.GetFocusedRowCellValue("IDCliente")
            If Not IsDBNull(GridView1.GetFocusedRowCellValue("Nome")) Then varNomeCli = GridView1.GetFocusedRowCellValue("Nome")
            If Not IsDBNull(GridView1.GetFocusedRowCellValue("Cliente")) Then varNomeMD = GridView1.GetFocusedRowCellValue("Cliente")

            Dim rs As New ADODB.Recordset()
            Dim cnStr As String = strAdoConnection()
            rs.Open("SELECT Max(Venda) AS V FROM VENDAS WHERE Venda Is Not Null GROUP BY Year([DataVenda]) HAVING Year([DataVenda])=Year(GetDate())", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            If rs.EOF Then
                varNovaVenda = "0001" & "/" & Format(Date.Today, "yy")
            Else
                varNovaVenda = String.Format("{0,4:D4}", CInt(Microsoft.VisualBasic.Left(rs("V").Value, 4)) + 1) & "/" & Format(Date.Today, "yy")
            End If
            rs.Close()

            fExecutarText("Insert into VENDAS (IdCliente, DataVenda, Venda, Tipo) Values (" & varIdCliente & ", '" & Format(Date.Today, "yyyy-MM-dd") & "', '" & varNovaVenda & "', 'Interna')")

            varIdVenda = DLookUp("Id", "SELECT TOP 1 Id FROM VENDAS ORDER BY Id DESC", "", 1)

            frmNewVenda.Show()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnEtiqAniv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEtiqAniv.ItemClick
        frmEtiqAniv.Show()

    End Sub

    Private Sub btnEmails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmails.ItemClick

        Dim conn As New SqlConnection("Server=CLINICAMENTA\SQLEXPRESS; uid=sa; pwd=oowa2015; Initial Catalog=BDTorras")   'Dim conn As New SqlConnection("Server=MARCELO\SQLEXPRESS; uid=sa; pwd=123456")
        conn.Open()
        Dim ds As DataSet
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "SELECT Email FROM Clientes WHERE (((Clientes.Nome) Is Not Null) AND (([Email]) Is Not Null) AND ((CHARINDEX('@',[Email]))>0)) ORDER BY Clientes.Email"
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds)
        dt = ds.Tables(0)
        cmd.Dispose()
        da.Dispose()
        conn.Dispose()

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim Pasta1 As Microsoft.Office.Interop.Excel.Workbook
        Dim Plan1 As Microsoft.Office.Interop.Excel.Worksheet

        objExcel = New Microsoft.Office.Interop.Excel.Application()
        Pasta1 = objExcel.Workbooks.Add()
        Plan1 = objExcel.Worksheets.Add()
        Plan1.Name = "E-mails do Sistema"
        Plan1.Activate()

        Dim i As Integer
        Dim linha As Integer = 1

        'objExcel.ActiveSheet.Range("A1:D1").merge()
        objExcel.ActiveSheet.Cells(1, 1).Font.Bold = True
        objExcel.ActiveSheet.Cells(1, 1).Value = "E-mail"
        objExcel.ActiveSheet.cells(1, 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

        For i = 0 To dt.Rows.Count - 1
            linha += 1
            objExcel.ActiveSheet.Cells(linha, 1).Value = dt.Rows(i).Item("Email")
        Next

        objExcel.ActiveSheet.Columns(1).EntireColumn.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        'objExcel.ActiveSheet.Cells(3, 1).Font.Bold = True
        objExcel.ActiveSheet.Columns(1).EntireColumn.AutoFit()

        With objExcel.ActiveSheet.Cells.Font
            .Name = "Arial"
            .Size = 10
        End With

        objExcel.Application.Visible = True
        objExcel = Nothing
        Pasta1 = Nothing
        Plan1 = Nothing

    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        EndereçosClientesBase.Show()

    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        TelefonesClientesBase.Show()

    End Sub
End Class
