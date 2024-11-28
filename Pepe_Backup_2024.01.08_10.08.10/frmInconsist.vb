Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base

Partial Public Class frmInconsist
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NomeForm = "frmInconsist"

        'TODO: esta linha de código carrega dados na tabela 'DsInconsist.Inconsist4'. Você pode movê-la ou removê-la conforme necessário.
        Try
            Me.Inconsist4TableAdapter.Fill(Me.DsInconsist.Inconsist4)
            Me.Inconsist5TableAdapter.Fill(Me.DsInconsist.Inconsist5)
            Me.Inconsist2TableAdapter.Fill(Me.DsInconsist.Inconsist2)
            Me.Inconsist1TableAdapter.Fill(Me.DsInconsist.Inconsist1)
            frmDevPrincipal.Visible = False

            Me.Tag = "1"

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmClientes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        fExecutarText("Delete From VENDAS Where Excluir = 1")
        fExecutarText("Delete From [1TabPeças] Where Excluir = 1")

        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnAbrir_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnAbrir.ButtonClick
        varIdPeça = GridView1.GetFocusedRowCellValue("IDPeça")
        frmEstoque.Show()

    End Sub

    Private Sub btnAbrir2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnAbrir2.ButtonClick

        varIdVenda = GridView2.GetFocusedRowCellValue("Id")
        frmNewVenda.Show()

    End Sub

    Private Sub btnAbrir4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnAbrir4.ButtonClick

        varIdVenda = GridView3.GetFocusedRowCellValue("Id")
        frmNewVenda.Show()

    End Sub

    Private Sub btnAbrir5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnAbrir5.ButtonClick

        varIdVenda = GridView4.GetFocusedRowCellValue("Id")
        frmNewVenda.Show()

    End Sub

    Private Sub edição()
        If Me.Tag = "1" Then
            ribbonPageGroup1.Visible = False
            RibbonPageGroup2.Visible = True
            Me.ControlBox = False

            If Me.XtraTabControl.SelectedTabPage Is XtraTabPage1 Then
                Me.XtraTabPage3.PageVisible = False
                Me.XtraTabPage4.PageVisible = False
            ElseIf Me.XtraTabControl.SelectedTabPage Is XtraTabPage4 Then
                Me.XtraTabPage1.PageVisible = False
                Me.XtraTabPage3.PageVisible = False
            End If

        End If
    End Sub

    Private Sub btnSalvar2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar2.ItemClick

        Me.Validate()

        If Me.XtraTabControl.SelectedTabPage Is XtraTabPage1 Then
            Me.Inconsist1BindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.DsInconsist)
            Me.Inconsist1TableAdapter.Fill(Me.DsInconsist.Inconsist1)
        ElseIf Me.XtraTabControl.SelectedTabPage Is XtraTabPage3 Then
            Me.Inconsist2BindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.DsInconsist)
        Else
            Me.Inconsist4BindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.DsInconsist)
            Me.Inconsist4TableAdapter.Fill(Me.DsInconsist.Inconsist4)
        End If

        ribbonPageGroup1.Visible = True
        RibbonPageGroup2.Visible = False
        Me.ControlBox = True

        Me.XtraTabPage1.PageVisible = True
        Me.XtraTabPage3.PageVisible = True
        Me.XtraTabPage4.PageVisible = True

    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging

        Call edição()

    End Sub

    Private Sub btnUndo2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo2.ItemClick

        If Me.XtraTabControl.SelectedTabPage Is XtraTabPage1 Then
            Me.Inconsist1TableAdapter.Fill(Me.DsInconsist.Inconsist1)
        ElseIf Me.XtraTabControl.SelectedTabPage Is XtraTabPage4 Then
            Me.Inconsist4TableAdapter.Fill(Me.DsInconsist.Inconsist4)
        End If

        ribbonPageGroup1.Visible = True
        RibbonPageGroup2.Visible = False
        Me.ControlBox = True

        Me.XtraTabPage1.PageVisible = True
        Me.XtraTabPage3.PageVisible = True
        Me.XtraTabPage4.PageVisible = True

    End Sub

    Private Sub GridView3_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView3.CellValueChanging

        Call edição()

    End Sub
End Class
