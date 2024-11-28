Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Partial Public Class frmSaidasDG
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmClientesDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DsComercial.TiposSaidas'. Você pode movê-la ou removê-la conforme necessário.
        Me.TiposSaidasTableAdapter.Fill(Me.DsComercial.TiposSaidas)

        Me.CboPeçasTableAdapter.Fill(Me.DsComercial1.cboPeças)
        Me.SaidasTableAdapter.Fill(Me.DsComercial.Saidas)

        Me.Tag = "1"
        frmDevPrincipal.Visible = False

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub gridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        'MsgBox(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "N")).ToString()

        'RibbonPageGroup2.Visible = True
        'ribbonPageGroup1.Visible = False
        'Me.ControlBox = False

        'RemoveHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged
        ''GridView1.SetFocusedRowCellValue("Baixar", True)
        'AddHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged

        Dim p As Integer = CInt(ConvertToDouble(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdPeça")))
        If p > 0 Then
            Dim x As Double = ConvertToDouble(DLookUp("Custo", "[1TabPeças]", "IdPeça = " & p, 0))
            RemoveHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged
            RemoveHandler GridView1.CellValueChanging, AddressOf GridView1_CellValueChanging
            GridView1.SetFocusedRowCellValue("Custo", x)
            AddHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged
            AddHandler GridView1.CellValueChanging, AddressOf GridView1_CellValueChanging
        End If

    End Sub
    Private Sub btnUndo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick
        Try
            RemoveHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged

            'Me.CartõesTodosTableAdapter.Fill(Me.DsCheques.CartõesTodos)
            'Me.CartõesAbertoTableAdapter.Fill(Me.DsCheques1.CartõesAberto)
            'Me.CartõesRecTableAdapter.Fill(Me.DsCheques2.CartõesRec)

            If GridView1.IsNewItemRow(GridView1.FocusedRowHandle) Then
                GridView1.CancelUpdateCurrentRow()
            Else
                Me.SaidasTableAdapter.Fill(Me.DsComercial.Saidas)
            End If

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
            'RemoveHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged

            Me.Validate()
            Me.SaidasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(DsComercial)

            'Me.CartõesTodosBindingSource.EndEdit()
            'Me.CartõesAbertoBindingSource.EndEdit()
            'Me.CartõesRecBindingSource.EndEdit()
            'Me.TableAdapterManager1.UpdateAll(DsCheques)
            'Me.TableAdapterManager1.UpdateAll(DsCheques1)
            'Me.TableAdapterManager1.UpdateAll(DsCheques2)

            RibbonPageGroup2.Visible = False
            ribbonPageGroup1.Visible = True
            Me.ControlBox = True

            fExecutarText("update p1 set p1.Vendida = 1, p1.Saida = 1 From (SELECT p.IDPeça, p.Saida, p.Vendida FROM [1TabPeças] p) as p1 INNER JOIN Saidas s ON p1.IDPeça = s.IdPeça")
            Me.CboPeçasTableAdapter.Fill(Me.DsComercial1.cboPeças)

            'AddHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub GridView1_InitNewRow(ByVal sender As Object, ByVal e As InitNewRowEventArgs) Handles GridView1.InitNewRow

        Dim x As Integer = 0
        x = ConvertToDouble(DLookUp("Sai", "Select Max(NumSaida) as Sai From Saidas", "", 1)) + 1

        Dim view As GridView = CType(sender, GridView)
        view.SetRowCellValue(e.RowHandle, view.Columns("NumSaida"), x)

    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick

        'fExecutarText("Delete From tabCartõesRpt")

        'Dim rs As New ADODB.Recordset()
        'Dim cnStr As String = strAdoConnection()
        'rs.Open("SELECT N, NomeCartão, Venda, DataVenda, Parcela, VValor, Vencto, Pagto From tabCartõesRpt", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        'For i As Integer = 0 To GridView1.DataRowCount - 1
        '    rs.AddNew()
        '    If Not IsDBNull(GridView1.GetRowCellValue(i, "N")) Then rs("N").Value = Nz(GridView1.GetRowCellValue(i, "N"), "")
        '    If Not IsDBNull(GridView1.GetRowCellValue(i, "NomeCartão")) Then rs("NomeCartão").Value = Nz(GridView1.GetRowCellValue(i, "NomeCartão"), "")
        '    If Not IsDBNull(GridView1.GetRowCellValue(i, "Venda")) Then rs("Venda").Value = Nz(GridView1.GetRowCellValue(i, "Venda"), "")
        '    If Not IsDBNull(GridView1.GetRowCellValue(i, "DataVenda")) Then rs("DataVenda").Value = Nz(GridView1.GetRowCellValue(i, "DataVenda"), "")
        '    If Not IsDBNull(GridView1.GetRowCellValue(i, "Parcela")) Then rs("Parcela").Value = Nz(GridView1.GetRowCellValue(i, "Parcela"), "")
        '    If Not IsDBNull(GridView1.GetRowCellValue(i, "VValor")) Then rs("VValor").Value = Nz(GridView1.GetRowCellValue(i, "VValor"), "")
        '    If Not IsDBNull(GridView1.GetRowCellValue(i, "Vencto")) Then rs("Vencto").Value = Nz(GridView1.GetRowCellValue(i, "Vencto"), "")
        '    If Not IsDBNull(GridView1.GetRowCellValue(i, "Pagto")) Then rs("Pagto").Value = Nz(GridView1.GetRowCellValue(i, "Pagto"), "")
        '    rs.Update()
        'Next i

        'rs.Close()

        'Dim x As String = Me.GridView1.ActiveFilterString
        'Dim n As Integer = InStr(x, "Between")
        'If n > 0 Then
        '    varData = Mid(x, n + 9, 10)
        '    varData = Microsoft.VisualBasic.Right(varData, 2) & "/" & Microsoft.VisualBasic.Mid(varData, 6, 2) & "/" & Microsoft.VisualBasic.Left(varData, 4)
        '    varData2 = Mid(x, n + 23, 10)
        '    varData2 = Microsoft.VisualBasic.Right(varData2, 2) & "/" & Microsoft.VisualBasic.Mid(varData2, 6, 2) & "/" & Microsoft.VisualBasic.Left(varData2, 4)
        'End If

        'frmRptCartõesBase.Show()

    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        'RibbonPageGroup2.Visible = True
        'ribbonPageGroup1.Visible = False
        'Me.ControlBox = False

        RibbonPageGroup2.Visible = True
        ribbonPageGroup1.Visible = False
        Me.ControlBox = False

    End Sub

    Private Sub btnExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcel.ItemClick

        'Dim path As String = ""

        'If XtraFolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    path = XtraFolderBrowserDialog.SelectedPath
        '    ClientesGridControl.ExportToXlsx(path & "\Cartões.xlsx")
        '    Process.Start(path & "\Cartões.xlsx")
        'End If

    End Sub

    Private Sub SaidasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SaidasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsComercial)

    End Sub



    Private Sub btnDel_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnDel.ButtonClick

        If Not GridView1.IsNewItemRow(GridView1.FocusedRowHandle) Then
            If XtraMessageBox.Show("Confirma exclusão?", "Atenção!", MessageBoxButtons.YesNo) <> DialogResult.No Then
                fExecutarText("Update [1TabPeças] Set Saida = 0, Vendida = 0 Where IdPeça = " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdPeça"))
                SaidasBindingSource.RemoveCurrent()
                RibbonPageGroup2.Visible = True
                ribbonPageGroup1.Visible = False
                Me.ControlBox = False
            End If
        End If
    End Sub

    Private Sub IdPeça_BeforePopup(sender As Object, e As EventArgs) Handles IdPeça.BeforePopup
        CboPeçasBindingSource.Filter = "Vendida = 0 Or Vendida Is Null"

    End Sub

    Private Sub IdPeça_Closed(sender As Object, e As ClosedEventArgs) Handles IdPeça.Closed
        CboPeçasBindingSource.RemoveFilter()

    End Sub

End Class
