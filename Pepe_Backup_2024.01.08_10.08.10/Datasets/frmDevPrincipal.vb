
Imports System.ComponentModel
Imports System.Text
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraReports.UI

Partial Public Class frmDevPrincipal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

        DevExpress.LookAndFeel.UserLookAndFeel.Default.UseDefaultLookAndFeel = True
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Dark Side"

    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSair.ItemClick
        Application.Exit()

    End Sub

    Private Sub btnRpt4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRpt4.ItemClick
        EndereçosClientesBase.Show()

    End Sub

    Private Sub btnClientes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClientes.ItemClick
        frmClientesDG.Show()

    End Sub

    Private Sub btnCheques_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCheques.ItemClick
        Try
            fExecutarText("delete from [Vencto Cartão] where idcc = -1; delete from [Vencto Cheques] where idcc = -1")
            fExecutarSP("USP_Cheques")
            frmChequesDG.Show()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnCartao_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCartao.ItemClick
        Try
            fExecutarText("delete from [Vencto Cartão] where idcc = -1; delete from [Vencto Cheques] where idcc = -1")
            fExecutarSP("USP_Cartões")
            frmCartoesDG.Show()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnVendas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVendas.ItemClick
        fExecutarText("delete from [Vencto Cartão] where idcc = -1; delete from [Vencto Cheques] where idcc = -1")
        fExecutarText("update vendas set peças=dbo.fPeças(Vendas.Id) where vendas.DataVenda>='01-01-2020'") ' and Peças = null")
        frmVendasDG.Show()

    End Sub

    Private Sub frmDevPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmAcesso.Visible = False

        Dim bkp As Integer = My.Settings.BackupSQL

        'Dim dc As New lqGerencialDataContext
        'Dim query = (From tb In dc.GetTable(Of VI_VENDAS)() Select tb)

        Try
            'If Not System.IO.Directory.Exists("C:\Sistema\Backup\BDados") Then
            '    System.IO.Directory.CreateDirectory("C:\Sistema\Backup\BDados")
            'End If

            If Date.Today.DayOfWeek = DayOfWeek.Wednesday Then
                If bkp = 0 Then
                    If System.IO.File.Exists("G:\Meu Drive\Backup Sistema\Backup1.bak") Then
                        If System.IO.File.Exists("G:\Meu Drive\Backup Sistema\Backup2.bak") Then
                            System.IO.File.Delete("G:\Meu Drive\Backup Sistema\Backup1.bak")
                            System.IO.File.Copy("G:\Meu Drive\Backup Sistema\Backup2.bak", "G:\Meu Drive\Backup Sistema\Backup1.bak")
                            System.IO.File.Delete("G:\Meu Drive\Backup Sistema\Backup2.bak")
                        End If
                        fExecutarText("BACKUP DATABASE BDTorras TO DISK = 'G:\Meu Drive\Backup Sistema\Backup2.bak' WITH FORMAT;")
                    Else
                        fExecutarText("BACKUP DATABASE BDTorras TO DISK = 'G:\Meu Drive\Backup Sistema\Backup1.bak' WITH FORMAT;")
                    End If

                    'Try
                    '    If System.IO.File.Exists("C:\Meu Drive\Backup Sistema\Backup1.bak") Then
                    '        If System.IO.File.Exists("C:\Meu Drive\Backup Sistema\Backup2.bak") Then
                    '            System.IO.File.Delete("C:\Meu Drive\Backup Sistema\Backup1.bak")
                    '            System.IO.File.Copy("C:\Meu Drive\Backup Sistema\Backup2.bak", "C:\Meu Drive\Backup Sistema\Backup1.bak")
                    '            System.IO.File.Delete("C:\Meu Drive\Backup Sistema\Backup2.bak")
                    '        End If
                    '        fExecutarText("BACKUP DATABASE BDTorras TO DISK = 'C:\Meu Drive\Backup Sistema\Backup2.bak' WITH FORMAT;")
                    '    Else
                    '        fExecutarText("BACKUP DATABASE BDTorras TO DISK = 'C:\Meu Drive\Backup Sistema\Backup1.bak' WITH FORMAT;")
                    '    End If

                    'Catch ex As Exception

                    'Finally
                    '    My.Settings.BackupSQL = 1
                    '    My.Settings.Save()

                    'End Try

                    My.Settings.BackupSQL = 1
                    My.Settings.Save()
                End If
            Else
                My.Settings.BackupSQL = 0
                My.Settings.Save()
            End If

        Catch ex As Exception
            My.Settings.BackupSQL = 0
            My.Settings.Save()

        End Try


        'Dim ent As Double = 0
        'If query.Count > 0 Then
        '    ent = (From c In query Select c.Id).Count
        '    If ent <> bkp Then
        '        'fExecutarText("BACKUP DATABASE BDTorras TO DISK = 'C:\Sistema\Pepe\BDTorras.bak' WITH FORMAT;")
        '        'fExecutarText("BACKUP DATABASE BDTorras TO DISK = 'C:\Sistema\Pepe\Backup\BDTorras.bak' WITH DIFFERENTIAL;")
        '        My.Settings.BackupSQL = ent
        '        My.Settings.Save()
        '    End If
        'End If


    End Sub

    Private Sub btnEstoque_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstoque.ItemClick
        frmEstoqueDG.Show()

    End Sub

    Private Sub btnReajuste_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReajuste.ItemClick
        frmReajuste.Show()

    End Sub

    Private Sub btnConsertos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsertos.ItemClick
        frmConsertos.Show()

    End Sub

    Private Sub btnRptVendas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptVendas.ItemClick
        VendasBase.Show()

    End Sub

    Private Sub btnTelefones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTelefones.ItemClick
        TelefonesClientesBase.Show()

    End Sub

    Private Sub frmDevPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()

    End Sub

    Private Sub btnRptCartão_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptCartão.ItemClick
        CartãoBase.Show()

    End Sub

    Private Sub btnRptConsertos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptConsertos.ItemClick
        ConsertosBase.Show()

    End Sub

    Private Sub btnRptCC_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptCC.ItemClick
        CCNovoBase.Show()

    End Sub

    Private Sub btnRptVendidas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptVendidas.ItemClick
        fExecutarText("update [1TabPeças] Set Vendida = 0 where Vendida is null")
        PeçasVendidasBase.Show()

    End Sub

    Private Sub btnRptReg_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptReg.ItemClick
        PeçasRegBase.Show()

    End Sub

    Private Sub btnRptCusto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptCusto.ItemClick
        CustoPeçasVendidasBase.Show()

    End Sub

    Private Sub btnRptCliSCompras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptCliSCompras.ItemClick
        ClientesSemComprasBase.Show()

    End Sub

    Private Sub btnRptComprasPorCliente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptComprasPorCliente.ItemClick
        ComprasPorClienteBase.Show()

    End Sub

    Private Sub btnPeçasEmEstoque_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPeçasEmEstoque.ItemClick
        fExecutarText("update [1TabPeças] Set Vendida = 0 where Vendida is null")
        PeçasEmEstoqueBase.Show()

    End Sub

    Private Sub btnPeçasEmEstoqueNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPeçasEmEstoqueNovo.ItemClick
        fExecutarText("update [1TabPeças] Set Vendida = 0 where Vendida is null")
        PeçasEmEstoqueNovoBase.Show()

    End Sub

    Private Sub btnRptBalanço_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptBalanço.ItemClick
        fExecutarText("update [1TabPeças] Set Vendida = 0 where Vendida is null")
        'BalançoBase.Show()

        Dim report As New Balanço0
        'Dim report As New Balanço5
        Try
            'report.SqlDataSource.Fill()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowPreview()

            'Dim report4 As New Balanço4
            'Dim printTool4 As New ReportPrintTool(report4)
            'printTool4.ShowPreview()

            'Dim report3 As New Balanço3
            'Dim printTool3 As New ReportPrintTool(report3)
            'printTool3.ShowPreview()

            'Dim report2 As New Balanço2
            'Dim printTool2 As New ReportPrintTool(report2)
            'printTool2.ShowPreview()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnRptChequesPre_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptChequesPre.ItemClick
        ChequesPreBase.Show()

    End Sub

    Private Sub btnRptCartoesAReceber_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptCartoesAReceber.ItemClick
        CartoesAReceberBase.Show()

    End Sub

    Private Sub btnRptGeralClientes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptGeralClientes.ItemClick
        GeralClientesBase.Show()

    End Sub

    Private Sub btnRptTabPreços_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptTabPreços.ItemClick
        Tabela_de_Preços_Base.Show()

    End Sub

    Private Sub btnTrocarUsu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTrocarUsu.ItemClick
        Me.RibbonControl.SelectedPage = RibbonPage2
        frmAcesso.Show()

        Me.Visible = False

    End Sub

    Private Sub frmDevPrincipal_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        frmAcesso.Visible = False

        Dim dt1 As Date = Date.Today
        Dim dt2 As Date = Date.Today

        Do While dt1.DayOfWeek <> 1 'DayOfWeek.Monday
            dt1 = dt1.AddDays(-1)
        Loop

        Do While dt2.DayOfWeek <> 0 'DayOfWeek.Sunday
            dt2 = dt2.AddDays(1)
        Loop

        'Dim dc As New lqGerencialDataContext

        'Dim query = (From tb In dc.GetTable(Of Vencto_Cartão)() Where ((tb.Vencto >= dt1) And (tb.Vencto <= dt2)) And (tb.Pagto <> tb.Vencto) Select tb)
        'If query.Count > 0 Then
        '    Dim info As AlertInfo = New AlertInfo("ATENÇÃO!", "Existem parcelas de cartões de crédito a vencer nesta semana", "Clique no botão abaixo para acessar o controle de cartão de crédito")
        '    AlertControl.Show(Me, info)
        'End If

        'Dim query2 = (From tb In dc.GetTable(Of Vencto_Cheques)() Where (tb.Vencto >= dt1 And tb.Vencto <= dt2 And Not tb.Uso.HasValue) Select tb)
        'If query2.Count > 0 Then
        '    Dim info2 As AlertInfo = New AlertInfo("ATENÇÃO!", "Existem cheques a vencer nesta semana", "Clique no botão abaixo para acessar o controle de cheques")
        '    AlertControl1.Show(Me, info2)
        'End If


        Dim rs As New ADODB.Recordset()
        Dim cnStr As String = strAdoConnection()

        Dim strSQL As String = "Select * From [Vencto Cartão] Where (Venda > 0 Or IdConserto > 0 Or IdCC > 0) And Vencto Between '" & FormatDateTime(dt1, DateFormat.ShortDate) & "' And '" & FormatDateTime(dt2, DateFormat.ShortDate) & "' And Pagto Is Null"
        rs.Open(strSQL, cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            ckAvisos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            If Not ckAvisos.Checked Then
                Dim info As AlertInfo = New AlertInfo("ATENÇÃO!", "Existem parcelas de cartões de crédito a vencer nesta semana", "Clique no botão abaixo para acessar o controle de cartão de crédito")
                AlertControl.Show(Me, info)
            End If
        Else
            ckAvisos.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        End If

        rs.Close()

        strSQL = "Select * From [Vencto Cheques] Where Vencto Between '" & FormatDateTime(dt1, DateFormat.ShortDate) & "' And '" & FormatDateTime(dt2, DateFormat.ShortDate) & "' And Uso Is Null"
        rs.Open(strSQL, cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            ckAvisos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            If Not ckAvisos.Checked Then
                Dim info2 As AlertInfo = New AlertInfo("ATENÇÃO!", "Existem cheques a vencer nesta semana", "Clique no botão abaixo para acessar o controle de cheques")
                AlertControl1.Show(Me, info2)
            End If
        End If
        rs.Close()

    End Sub

    Private Sub btnRptGerencial_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptGerencial.ItemClick
        GerencialBase.Show()

    End Sub

    Private Sub btnInconsist_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInconsist.ItemClick
        frmInconsist.Show()

    End Sub

    Private Sub AlertControl_ButtonClick(sender As Object, e As AlertButtonClickEventArgs) Handles AlertControl.ButtonClick
        'If e.ButtonName = "buttonOpen" Then
        Call btnCartao_ItemClick(Nothing, Nothing)

        'End If

    End Sub

    Private Sub AlertControl1_ButtonClick(sender As Object, e As AlertButtonClickEventArgs) Handles AlertControl1.ButtonClick
        Call btnCheques_ItemClick(Nothing, Nothing)

    End Sub

    Private Sub btnClientesCad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClientesCad.ItemClick
        ClientesCadastrados.Show()

    End Sub

    Private Sub btnMP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMP.ItemClick

        'Dim report As New rptMateriaPrima()

        'Dim printTool As New ReportPrintTool(report)
        'printTool.ShowRibbonPreview()

        frmMatPrimaDG.Show()

    End Sub

    Private Sub btnCC_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCC.ItemClick
        frmCCdg.Show()

    End Sub

    Private Sub btnSai_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSai.ItemClick
        frmSaidasDG.Show()

    End Sub

    Private Sub btnSaidas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaidas.ItemClick
        frmSaidasBase.Show()

    End Sub

    Private Sub btnGetnet_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGetnet.ItemClick
        frmGetnet.Show()

    End Sub

    Private Sub btnRec_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRec.ItemClick
        fExecutarText("UPDATE vc SET vc.AutDeb = Null from Vendas as v INNER JOIN [Vencto Cartão] as vc ON (v.NomeCartão = vc.NomeCartão) AND (v.Id = vc.Venda)")
        fExecutarText("UPDATE vc SET vc.Aut = Null from Vendas as v INNER JOIN [Vencto Cartão] as vc ON (v.NomeCDeb = vc.NomeCartão) AND (v.Id = vc.Venda)")
        fExecutarText("UPDATE vc SET vc.AutDeb = v.AutDeb FROM dbo.VENDAS v INNER JOIN dbo.[Vencto Cartão] vc ON v.Id = vc.Venda WHERE (vc.Vencto >= CONVERT(DATETIME, '2022-12-01 00:00:00', 102)) AND (v.AutDeb IS NOT NULL) AND (vc.AutDeb IS NULL)")
        fExecutarText("UPDATE vc SET vc.Aut = v.Aut FROM dbo.VENDAS v INNER JOIN dbo.[Vencto Cartão] vc ON v.Id = vc.Venda WHERE (vc.Vencto >= CONVERT(DATETIME, '2022-12-01 00:00:00', 102)) AND (v.Aut IS NOT NULL) AND (vc.Aut IS NULL)")
        frmGetnetDG.Show()

    End Sub
End Class
