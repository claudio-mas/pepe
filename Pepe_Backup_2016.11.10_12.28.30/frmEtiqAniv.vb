Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors


Partial Public Class frmEtiqAniv
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEtiquetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Visible = False

        frmClientesDG.Visible = False

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmClientesDG.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnOk_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        Try
            Dim strSql As String = "SELECT IDCliente, Nome AS NomeCli, Nome, Título, Nome AS NomeC, Endereço, Bairro, Cidade, Estado, CEP, Telefone, Fax, [Imp], Cliente, Indicaçao, Aniv, Medidas, Saldo, isnull([Nome],[Cliente]) AS M, Email FROM Clientes WHERE (Nome Is Not Null) AND (isnull([Nome],[Cliente]) Is Not Null)"
            If IsNumeric(Me.txtMAniv.EditValue) Then
                strSql = strSql & " And (case when Aniv is null then 0 else month([Aniv]) end = " & Me.txtMAniv.EditValue & ")"
            Else
                'MsgBox("Informe o mês de aniversário", MsgBoxStyle.Critical, "Atenção!")
                DevExpress.XtraEditors.XtraMessageBox.Show("Informe o mês de aniversário", "Atenção!")
                Exit Sub
            End If

            If IsNumeric(Me.txtAnos.EditValue) Then
                strSql = strSql & " AND IDCliente In (SELECT IDCliente FROM VENDAS WHERE (IDCliente Is Not Null) AND (DateDiff(year,[DataVenda],GETDATE()) <= " & Me.txtAnos.EditValue & "))"
            End If

            Me.C1Report1.DataSource.RecordSource = strSql
            Me.C1PrintPreviewControl1.Document = ""
            Me.C1PrintPreviewControl1.Document = C1Report1.C1Document
            Me.C1PrintPreviewControl1.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub txtAnos_EditValueChanged(sender As Object, e As System.EventArgs) Handles txtAnos.EditValueChanged
        If IsNumeric(txtAnos.EditValue) Then
            Me.ckTodos.Checked = False
        End If

    End Sub

    Private Sub ckTodos_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ckTodos.CheckedChanged
        If Me.ckTodos.Checked Then txtAnos.EditValue = ""

    End Sub
End Class
