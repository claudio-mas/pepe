Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Partial Public Class frmReajuste
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DsNovoEstoque.Reajustes'. Você pode movê-la ou removê-la conforme necessário.


        Try
            Me.Tag = "1"
            Me.DataReaj.EditValue = Date.Today
            Me.ReajustesTableAdapter.Fill(Me.DsNovoEstoque.Reajustes)

            frmDevPrincipal.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmClientes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub frmClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        On Error Resume Next

        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.Send("{Tab}")
        End Select

    End Sub

    Private Sub btnAplicarReajuste_Click(sender As Object, e As EventArgs) Handles btnAplicarReajuste.Click
        If Me.Tag = "1" Then
            var1 = Me.FatorCusto.EditValue
            var2 = Me.FatorVenda.EditValue
            varData = Me.DataReaj.Text

            If (var1 = 0) And (var2 = 0) Then
                MsgBox("Informe o fator de reajuste", vbCritical, "Atenção!")
                Me.FatorCusto.Focus()
            Else
                varBtn = 1
                frmSenha.ShowDialog()
            End If
        End If

    End Sub

    Private Sub ReajustesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ReajustesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsNovoEstoque)

    End Sub

    Private Sub btnDesfazer_Click(sender As Object, e As EventArgs) Handles btnDesfazer.Click
        varBtn = 2
        frmSenha.ShowDialog()

    End Sub
End Class
