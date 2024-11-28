Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Partial Public Class frmCartoesDG
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmClientesDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CartõesRecTableAdapter.Fill(Me.DsCheques2.CartõesRec)
        Me.CartõesAbertoTableAdapter.Fill(Me.DsCheques1.CartõesAberto)
        Me.CartõesTodosTableAdapter.Fill(Me.DsCheques.CartõesTodos)

        Me.UltraOptionSet1.Value = "Em aberto"
        Me.LabelControl1.Text = "Cartões - " & Me.UltraOptionSet1.Value.ToString

        frmDevPrincipal.Visible = False

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnAbrir_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        MsgBox(GridView1.GetFocusedRowCellValue("IDCliente"))

    End Sub

    Private Sub gridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        'MsgBox(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "N")).ToString()
        RibbonPageGroup2.Visible = True
        ribbonPageGroup1.Visible = False
        Me.ControlBox = False

        RemoveHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged
        GridView1.SetFocusedRowCellValue("Baixar", True)
        AddHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged

    End Sub
    '    Private Sub gridview1_CellBeginEdit() Handles GridView1.edit
    Private Sub UltraOptionSet1_ValueChanged(sender As Object, e As EventArgs) Handles UltraOptionSet1.ValueChanged
        'MsgBox(UltraOptionSet1.Value.ToString)

        Select Case UltraOptionSet1.Value
            Case "Todos"
                'Me.CartõesTodosBindingSource.RemoveFilter()
                Me.ClientesGridControl.DataSource = Me.CartõesTodosBindingSource
            Case "Em aberto"
                'Me.CartõesTodosBindingSource.Filter = "Pagto is null"
                Me.ClientesGridControl.DataSource = Me.CartõesAbertoBindingSource
            Case "Recebidos"
                'Me.CartõesTodosBindingSource.Filter = "Pagto is not Null"
                Me.ClientesGridControl.DataSource = Me.CartõesRecBindingSource
        End Select

        Me.LabelControl1.Text = "Cartões - " & Me.UltraOptionSet1.Value.ToString

        'Me.Text = Me.GridView1.ActiveFilterString
        'Me.Text = Nz(Me.Text, "") & " And " & Nz(Me.GridView1.FindFilterText, "")

    End Sub

    Private Sub btnUndo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick
        Try
            RemoveHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged

            fExecutarSP("USP_Cartões")

            Me.CartõesTodosTableAdapter.Fill(Me.DsCheques.CartõesTodos)
            Me.CartõesAbertoTableAdapter.Fill(Me.DsCheques1.CartõesAberto)
            Me.CartõesRecTableAdapter.Fill(Me.DsCheques2.CartõesRec)

            Dim x As String = Me.UltraOptionSet1.Value
            Me.UltraOptionSet1.Value = "Todos"
            Me.UltraOptionSet1.Value = x

            RibbonPageGroup2.Visible = False
            ribbonPageGroup1.Visible = True
            Me.ControlBox = True

            AddHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Try
            RemoveHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged

            Me.Validate()
            Me.CartõesTodosBindingSource.EndEdit()
            Me.CartõesAbertoBindingSource.EndEdit()
            Me.CartõesRecBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(DsCheques)
            Me.TableAdapterManager1.UpdateAll(DsCheques1)
            Me.TableAdapterManager1.UpdateAll(DsCheques2)

            fExecutarText("UPDATE a SET [VValor] = b.VValor, [NomeCartão] = b.NomeCartão, [Parcela] = b.Parcela, [Pagto] = b.Pagto FROM [Vencto Cartão] a INNER JOIN dbo.tabCartões b ON a.Id = b.IDC WHERE (b.Baixar = 1)")

            fExecutarSP("USP_Cartões")
            Me.CartõesRecTableAdapter.Fill(Me.DsCheques2.CartõesRec)
            Me.CartõesAbertoTableAdapter.Fill(Me.DsCheques1.CartõesAberto)
            Me.CartõesTodosTableAdapter.Fill(Me.DsCheques.CartõesTodos)

            Dim x As String = Me.UltraOptionSet1.Value
            Me.UltraOptionSet1.Value = "Todos"
            Me.UltraOptionSet1.Value = x

            RibbonPageGroup2.Visible = False
            ribbonPageGroup1.Visible = True
            Me.ControlBox = True

            AddHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub GridView1_InitNewRow(ByVal sender As Object, ByVal e As InitNewRowEventArgs) Handles GridView1.InitNewRow

        Dim view As GridView = CType(sender, GridView)
        view.SetRowCellValue(e.RowHandle, view.Columns("colBaixar"), True)

    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick

        fExecutarText("Delete From tabCartõesRpt")

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

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        'RibbonPageGroup2.Visible = True
        'ribbonPageGroup1.Visible = False
        'Me.ControlBox = False

        'RemoveHandler GridView1.CellValueChanging, AddressOf GridView1_CellValueChanging
        'GridView1.SetFocusedRowCellValue("Baixar", True)
        'AddHandler GridView1.CellValueChanging, AddressOf GridView1_CellValueChanging

    End Sub

    Private Sub btnExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcel.ItemClick

        Dim path As String = ""

        If XtraFolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            path = XtraFolderBrowserDialog.SelectedPath
            ClientesGridControl.ExportToXlsx(path & "\Cartões.xlsx")
            Process.Start(path & "\Cartões.xlsx")
        End If

    End Sub
End Class
