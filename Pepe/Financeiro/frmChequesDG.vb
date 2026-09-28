Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors


Partial Public Class frmChequesDG
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmClientesDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DsCheques1.ChequesRec'. Você pode movê-la ou removê-la conforme necessário.
        Me.ChequesRecTableAdapter.Fill(Me.DsCheques1.ChequesRec)
        Me.ChequesAbertoTableAdapter.Fill(Me.DsCheques1.ChequesAberto)
        Me.ChequesTodosTableAdapter.Fill(Me.DsCheques.ChequesTodos)

        Me.UltraOptionSet1.Value = "Em aberto"
        Me.LabelControl1.Text = "Cheques - " & Me.UltraOptionSet1.Value.ToString

        frmDevPrincipal.Visible = False

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnAbrir_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnAbrir.ButtonClick
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
        Select Case UltraOptionSet1.Value.ToString
            Case "Todos"
                'Me.ChequesTodosBindingSource.RemoveFilter()
                Me.ClientesGridControl.DataSource = Me.ChequesTodosBindingSource
            Case "Em aberto"
                'Me.ChequesTodosBindingSource.Filter = "Uso is null"
                Me.ClientesGridControl.DataSource = Me.ChequesAbertoBindingSource
            Case "Recebidos"
                'Me.ChequesTodosBindingSource.Filter = "Uso is not Null"
                Me.ClientesGridControl.DataSource = Me.ChequesRecBindingSource
        End Select

        Me.LabelControl1.Text = "Cheques - " & Me.UltraOptionSet1.Value.ToString

    End Sub

    Private Sub btnUndo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick
        Try
            RemoveHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged

            fExecutarSP("USP_Cheques")
            Me.ChequesRecTableAdapter.Fill(Me.DsCheques1.ChequesRec)
            Me.ChequesAbertoTableAdapter.Fill(Me.DsCheques1.ChequesAberto)
            Me.ChequesTodosTableAdapter.Fill(Me.DsCheques.ChequesTodos)

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
            Me.ChequesTodosBindingSource.EndEdit()
            Me.ChequesRecBindingSource.EndEdit()
            Me.ChequesAbertoBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(DsCheques)
            Me.TableAdapterManager1.UpdateAll(DsCheques1)

            fExecutarText("UPDATE a SET [VValor] = b.VValor, Cheque = b.Cheque, [Uso] = b.Uso, [Destino] = b.Destino, [Obs] = b.Obs FROM [Vencto Cheques] a INNER JOIN dbo.tabCheques b ON a.Id = b.IDV WHERE (b.Baixar = 1)")

            fExecutarSP("USP_Cheques")
            Me.ChequesTodosTableAdapter.Fill(Me.DsCheques.ChequesTodos)
            Me.ChequesRecTableAdapter.Fill(Me.DsCheques1.ChequesRec)
            Me.ChequesAbertoTableAdapter.Fill(Me.DsCheques1.ChequesAberto)

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

    Private Sub btnNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovo.ItemClick
        frmChequeAvulso.Show()

    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick

        fExecutarText("Delete From tabChequesRpt")

        Dim rs As New ADODB.Recordset()
        Dim cnStr As String = strAdoConnection()
        rs.Open("SELECT [N], [Venda], [DataVenda], [Destino], [Parcela], [VValor], [Cheque], [Banco], [Uso], [Obs], [Vencto] FROM tabChequesRpt", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        For i As Integer = 0 To GridView1.DataRowCount - 1
            rs.AddNew()
            If Not IsDBNull(GridView1.GetRowCellValue(i, "N")) Then rs("N").Value = Nz(GridView1.GetRowCellValue(i, "N"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "Destino")) Then rs("Destino").Value = Nz(GridView1.GetRowCellValue(i, "Destino"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "Venda")) Then rs("Venda").Value = Nz(GridView1.GetRowCellValue(i, "Venda"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "DataVenda")) Then rs("DataVenda").Value = Nz(GridView1.GetRowCellValue(i, "DataVenda"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "Parcela")) Then rs("Parcela").Value = Nz(GridView1.GetRowCellValue(i, "Parcela"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "VValor")) Then rs("VValor").Value = Nz(GridView1.GetRowCellValue(i, "VValor"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "Cheque")) Then rs("Cheque").Value = Nz(GridView1.GetRowCellValue(i, "Cheque"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "Banco")) Then rs("Banco").Value = Nz(GridView1.GetRowCellValue(i, "Banco"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "Uso")) Then rs("Uso").Value = Nz(GridView1.GetRowCellValue(i, "Uso"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "Obs")) Then rs("Obs").Value = Nz(GridView1.GetRowCellValue(i, "Obs"), "")
            If Not IsDBNull(GridView1.GetRowCellValue(i, "Vencto")) Then rs("Vencto").Value = Nz(GridView1.GetRowCellValue(i, "Vencto"), "")
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

        frmRptChequesBase.Show()

    End Sub

    Private Sub btnExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcel.ItemClick

        Dim path As String = ""

        If XtraFolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            path = XtraFolderBrowserDialog.SelectedPath
            ClientesGridControl.ExportToXlsx(path & "\Cheques.xlsx")
            Process.Start(path & "\Cheques.xlsx")
        End If

    End Sub
End Class
