Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors


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
        'TODO: esta linha de código carrega dados na tabela 'DsPrincipal.Clientes'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClientesTableAdapter.Fill(Me.DsPrincipal.Clientes)
        'TODO: esta linha de código carrega dados na tabela 'DsCadastros.ClienteNEW'. Você pode movê-la ou removê-la conforme necessário.
        'Me.ClienteNEWTableAdapter.Fill(Me.DsCadastros.ClienteNEW)

        frmDevPrincipal.Visible = False

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        fExecutarText("Update Clientes Set Imp = 0 where Imp = 1 Or Imp is NULL")
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
        ClientesBindingSource.EndEdit()
        ClientesTableAdapter.Update(DsPrincipal)

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub btnEtiqMalaDireta_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEtiqMalaDireta.ItemClick
        Me.Validate()
        ClientesBindingSource.EndEdit()
        ClientesTableAdapter.Update(DsPrincipal)

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
            varNovaVenda = String.Format("{0,4:D4}", CInt(Microsoft.VisualBasic.Left(rs("V").Value, 4)) + 1) & "/" & Format(Date.Today, "yy")
            rs.Close()

            fExecutarText("Insert into VENDAS (IdCliente, DataVenda, Venda, Tipo) Values (" & varIdCliente & ", '" & Format(Date.Today, "yyyy-MM-dd") & "', '" & varNovaVenda & "', 'Interna')")

            varIdVenda = DLookUp("Id", "SELECT TOP 1 Id FROM VENDAS ORDER BY Id DESC", "", 1)

            frmVenda.Show()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnEtiqAniv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEtiqAniv.ItemClick
        frmEtiqAniv.Show()

    End Sub

End Class
