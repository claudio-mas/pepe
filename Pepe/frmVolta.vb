Imports DevExpress.XtraEditors

Public Class frmVolta
    Private Sub btnNOk_Click(sender As Object, e As EventArgs) Handles btnNOk.Click
        Me.Close()

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If Me.nFicha.Text = "" Then
            MsgBox("Por favor, informe o nº da ficha", MsgBoxStyle.Critical)
            Me.nFicha.Focus()
        Else
            Dim x As DialogResult = XtraMessageBox.Show("Confirma volta da peça " & frmEstoque.ModêloTextEdit.Text & " com o novo nº " & Me.nFicha.Text & " ?", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If x = DialogResult.OK Then
                fExecutarText("exec USP_VOLTA " & frmEstoque.IDPeçaTextEdit.EditValue & ", '" & Me.nFicha.Text & "'")
                varIdPeça = DLookUp("I", "SELECT Max(IDPeça) As I FROM [1TabPeças]", "", 1)
                frmEstoque.Tag = "0"
                frmEstoque._1TabPeçasTableAdapter.Fill(frmEstoque.DsNovoEstoque._1TabPeças, varIdPeça)
                frmEstoque.PEDRASTableAdapter.Fill(frmEstoque.DsNovoEstoque.PEDRAS)
                frmEstoque.METAISTableAdapter.Fill(frmEstoque.DsNovoEstoque.METAIS)
                'frmEstoque._1TabPeçasHistóricoTableAdapter.Fill(frmEstoque.DsNovoEstoque._1TabPeçasHistórico)
                'frmEstoque._1TabPeçasHistóricoBindingSource.Filter = "Modêlo = " & frmEstoque.ModêloTextEdit.EditValue
                'varIdPeça = frmEstoque.IDPeçaTextEdit.EditValue
                frmEstoqueDG.EstoqueTableAdapter.Fill(frmEstoqueDG.DsEstoque.Estoque)
                frmEstoqueDG.RadioGroup1.EditValue = 1
                frmEstoque.Tag = "1"
                frmEstoque.btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                frmEstoque.grpEstornar.Visible = False
                frmEstoque.LabelControl1.Text = "Em estoque"
                Me.nFicha.Text = ""
                Me.Close()
            End If
        End If

    End Sub

    Private Sub frmVolta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lbTexto.Text = "A ficha nº " & frmEstoque.ModêloTextEdit.Text & " será duplicada com o novo nº informado abaixo:"

    End Sub
End Class