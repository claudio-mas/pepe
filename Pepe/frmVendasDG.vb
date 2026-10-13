Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors


Partial Public Class frmVendasDG
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmVendasDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.VENDASdgTableAdapter1.Fill(Me.DsVendas.VENDASdg)
            ConfigurarLinksPeças()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            frmDevPrincipal.Visible = False

        End Try

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'fExecutarText("Update Clientes Set Imp = 0 Where Imp = 1")
        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnAbrir_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnAbrirVenda.ButtonClick
        varIdVenda = GridView1.GetFocusedRowCellValue("Id")
        frmNewVenda.Show()

    End Sub

    Private Sub btnNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovo.ItemClick
        varIdVenda = 0
        frmNewVenda.Show()
        'Me.GridView1.OptionsView.ShowFooter = Not Me.GridView1.OptionsView.ShowFooter

    End Sub

    ' Coluna Peças: cada ficha da string "GAR11240 / PEN0730 / BR13118" vira um link para o cadastro da peça.
    Private Sub ConfigurarLinksPeças()
        Dim links As New DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel()
        links.ReadOnly = True
        AddHandler links.CustomDisplayText, AddressOf LinksPeças_CustomDisplayText
        AddHandler links.OpenHyperlink, AddressOf LinksPeças_OpenHyperlink
        Me.ClientesGridControl.RepositoryItems.Add(links)
        Me.colPeças.ColumnEdit = links

        ' O link só responde com o editor ativo: a coluna precisa aceitar foco e edição (somente leitura).
        Me.colPeças.OptionsColumn.AllowEdit = True
        Me.colPeças.OptionsColumn.AllowFocus = True
        Me.colPeças.OptionsColumn.ReadOnly = True

    End Sub

    Private Sub LinksPeças_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs)
        ' O DevExpress também chama este evento com valores que não são texto (DBNull e um Object genérico
        ' em passagens internas de medição); esses ficam com o texto padrão.
        Dim peças As String = TryCast(e.Value, String)
        If peças Is Nothing Then Exit Sub

        Dim fichas = peças.Split("/"c).Select(Function(f) f.Trim()).Where(Function(f) f <> "")
        e.DisplayText = String.Join(" / ", fichas.Select(Function(f) "<href=" & f & "><color=White>" & f & "</color></href>"))

    End Sub

    Private Sub LinksPeças_OpenHyperlink(sender As Object, e As DevExpress.Utils.OpenHyperlinkEventArgs)
        e.Handled = True    ' sem isso o DevExpress tenta abrir a ficha como endereço no navegador

        ' A ficha só identifica a peça dentro da venda. Com o editor ativo, a linha clicada é a focada.
        If Not GridView1.IsDataRow(GridView1.FocusedRowHandle) Then Exit Sub

        Dim idVenda As Integer = GridView1.GetFocusedRowCellValue("Id")
        AbrirCadastroPeça(IdPeçaDaVenda(idVenda, e.Link), Me)

    End Sub

    Private Sub frmClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        On Error Resume Next

        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.Send("{Tab}")
            Case Keys.F3
                Me.GridView1.OptionsView.ShowFooter = Not Me.GridView1.OptionsView.ShowFooter
        End Select

    End Sub

End Class
