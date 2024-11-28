Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Partial Public Class frmGetnetDG
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmClientesDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DsComercial.VI_Getnet'. Você pode movê-la ou removê-la conforme necessário.
        Me.VI_GetnetTableAdapter.Fill(Me.DsComercial.VI_Getnet)
        'Me.CartõesRecTableAdapter.Fill(Me.DsCheques2.CartõesRec)
        'Me.CartõesAbertoTableAdapter.Fill(Me.DsCheques1.CartõesAberto)
        'Me.CartõesTodosTableAdapter.Fill(Me.DsCheques.CartõesTodos)

        'Me.UltraOptionSet1.Value = "Em aberto"
        'Me.LabelControl1.Text = "Cartões - " & Me.UltraOptionSet1.Value.ToString

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

    '    Private Sub gridview1_CellBeginEdit() Handles GridView1.edit
    Private Sub UltraOptionSet1_ValueChanged(sender As Object, e As EventArgs) Handles UltraOptionSet1.ValueChanged

        'Select Case UltraOptionSet1.Value
        '    Case "Todos"
        '        'Me.CartõesTodosBindingSource.RemoveFilter()
        '        Me.ClientesGridControl.DataSource = Me.CartõesTodosBindingSource
        '    Case "Em aberto"
        '        'Me.CartõesTodosBindingSource.Filter = "Pagto is null"
        '        Me.ClientesGridControl.DataSource = Me.CartõesAbertoBindingSource
        '    Case "Recebidos"
        '        'Me.CartõesTodosBindingSource.Filter = "Pagto is not Null"
        '        Me.ClientesGridControl.DataSource = Me.CartõesRecBindingSource
        'End Select

        'Me.LabelControl1.Text = "Cartões - " & Me.UltraOptionSet1.Value.ToString

    End Sub

    Private Sub btnExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcel.ItemClick

        Dim path As String = ""

        If XtraFolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            path = XtraFolderBrowserDialog.SelectedPath
            ClientesGridControl.ExportToXlsx(path & "\getnet.xlsx")
            Process.Start(path & "\getnet.xlsx")
        End If

    End Sub
End Class
