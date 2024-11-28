Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors

Public Class frmVendaPeça

    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.Validate()
        Me.VENDASDETBindingSource.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Me.DsCheques)
        frmVenda.VendasDetTableAdapter.Fill(frmVenda.DsPrincipal.VendasDet, varIdVenda)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmVendaPeça_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DsCheques.cboPeças'. Você pode movê-la ou removê-la conforme necessário.
        Me.CboPeçasTableAdapter.Fill(Me.DsCheques.cboPeças)
        Me.VENDAS_DETTableAdapter.Fill(Me.DsCheques.VENDAS_DET, varIdDet)
        'Me.cboPeça.Text = varNomePeça

    End Sub


End Class
