Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors


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
        'TODO: esta linha de código carrega dados na tabela 'DsCheques.CartõesTodos'. Você pode movê-la ou removê-la conforme necessário.
        Me.CartõesTodosTableAdapter.Fill(Me.DsCheques.CartõesTodos)
        'TODO: esta linha de código carrega dados na tabela 'DsCheques.ChequesTodos'. Você pode movê-la ou removê-la conforme necessário.
        'Me.ChequesTodosTableAdapter.Fill(Me.DsCheques.ChequesTodos)

        Me.UltraOptionSet1.Value = "Em aberto"
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

    End Sub
    '    Private Sub gridview1_CellBeginEdit() Handles GridView1.edit
    Private Sub UltraOptionSet1_ValueChanged(sender As Object, e As EventArgs) Handles UltraOptionSet1.ValueChanged
        'MsgBox(UltraOptionSet1.Value.ToString)
        Select Case UltraOptionSet1.Value.ToString
            Case "Todos"
                Me.CartõesTodosBindingSource.RemoveFilter()
            Case "Em aberto"
                Me.CartõesTodosBindingSource.Filter = "Pagto is null"
            Case "Recebidos"
                Me.CartõesTodosBindingSource.Filter = "Pagto is not Null"
        End Select

    End Sub

    Private Sub btnUndo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick
        Try
            Me.CartõesTodosTableAdapter.Fill(Me.DsCheques.CartõesTodos)
            Me.UltraOptionSet1.Value = "Em aberto"

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
            Me.Validate()
            Me.CartõesTodosBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(DsCheques)

            fExecutarText("UPDATE a SET [VValor] = b.VValor, [NomeCartão] = b.NomeCartão, [Parcela] = b.Parcela, [Pagto] = b.Pagto FROM [Vencto Cartão] a INNER JOIN dbo.tabCartões b ON a.Id = b.IDC WHERE (b.Baixar = 1)")

            RibbonPageGroup2.Visible = False
            ribbonPageGroup1.Visible = True
            Me.ControlBox = True

            AddHandler GridView1.CellValueChanged, AddressOf gridView1_CellValueChanged

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

End Class
