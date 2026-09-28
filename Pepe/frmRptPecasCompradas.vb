Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors


Partial Public Class frmRptPecasCompradas
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmRptPecasCompradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Conexão central (ver modConexao); a definição do relatório não guarda mais senha.
        Me.C1Report1.DataSource.ConnectionString = strAdoConnection()
        Me.C1PrintPreviewControl1.PreviewPane.Document = Me.C1Report1

        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Visible = False
        frmClientes.Visible = False

        Try
            Dim strSql As String = "SELECT VENDAS.Venda, Clientes.IDCliente, isnull([Nome],'S/ Nome') AS N, case when [Vendas].[Tipo] is null then Null else [Vendas].[Tipo] + ' / ' + case when [Vendas].[Tipo]='Externa' then [Vendas].[Vendedora] else case when [Vendas].[Vendedora]='P.T.' then 'P.T.' else 'Loja' end end end AS TP, case when [Vendas].[Tipo] is null then Null else SUBSTRING([Vendas].[Tipo],1,3) + '. ' + case when [Vendas].[Tipo]='Externa' then [Vendas].[Vendedora] else case when [Vendas].[Vendedora]='P.T.' then 'P.T.' else 'Loja' end end end AS TPP, VENDAS.Vendedora, VENDAS.DataVenda, [1TabPeças].Custo, [1TabPeças].Modêlo, case when [Origem]='Outros' then 'Ou' else [Origem] end AS O, [1TabPeças].Oficial, VENDAS.ValorFinal, VENDAS.Real, VENDAS.Dolar, VENDAS.ContaCorrente, VENDAS.CCCheque, VENDAS.Comissão, VENDAS.Ouro, [VENDAS DET].ValorVenda, VENDAS.Desconto, VENDAS.CCDeb, VENDAS.Troca, VENDAS.Cartão, [Vendas Cartão].Parcelas, VENDAS.Cheque, [Vendas Cheque].Parcelas AS ParcelasCH FROM (((VENDAS LEFT JOIN Clientes ON VENDAS.IDCliente = Clientes.IDCliente) LEFT JOIN [Vendas Cartão] ON VENDAS.Id = [Vendas Cartão].Venda) LEFT JOIN [Vendas Cheque] ON VENDAS.Id = [Vendas Cheque].Venda) INNER JOIN ([1TabPeças] INNER JOIN [VENDAS DET] ON [1TabPeças].IDPeça = [VENDAS DET].Peça) ON VENDAS.Id = [VENDAS DET].Venda WHERE (((VENDAS.Venda) Is Not Null) AND ((Clientes.IDCliente)=" & varIdCliente & "))"

            Me.C1Report1.DataSource.RecordSource = strSql
            Me.C1PrintPreviewControl1.Document = ""
            Me.C1PrintPreviewControl1.Document = C1Report1.C1Document
            Me.C1PrintPreviewControl1.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmRptPecasCompradas_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmClientes.Visible = True

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub C1Report1_PrintSection(sender As System.Object, e As C1.C1Report.ReportEventArgs) Handles C1Report1.PrintSection

        'Dim f As C1.C1Report.Field

        'For Each f In C1Report1.Fields
        '    If f.Name = "F25" Then
        '        MsgBox(f.Index.ToString)
        '    End If
        '    If f.Name = "MinF25" Then
        '        MsgBox(f.Index.ToString)
        '    End If
        'Next

        'MsgBox(C1Report1.Fields(1).Name.ToString)

        If Me.C1Report1.Fields("Desconto").Value > 0 Then
            Me.C1Report1.Fields("Desconto").Visible = True
            Me.C1Report1.Fields("Rótulo65").Visible = True
        Else
            Me.C1Report1.Fields("Desconto").Visible = False
            Me.C1Report1.Fields("Rótulo65").Visible = False
        End If

        'If Me.C1Report1.Fields(22).Value <= Me.C1Report1.Fields(23).Value Then
        'Me.C1Report1.Fields(22).ForeColor = ColorTranslator.FromOle(RGB(255, 0, 0)) 'RGB(255, 0, 0)
        'Else
        'Me.C1Report1.Fields(22).ForeColor = ColorTranslator.FromOle(RGB(0, 0, 0))
        'End If

    End Sub
End Class
