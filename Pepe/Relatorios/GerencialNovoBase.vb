Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI

''' <summary>
''' Tela de filtro e orquestração do Relatório Gerencial novo.
'''
''' Herda de <c>BaseRpts</c>, que já traz txtData1, txtData2, btnOk2 e DocumentViewer1 —
''' por isso não há .Designer.vb próprio, só o ajuste do título no construtor.
'''
''' Este arquivo não contém regra de cálculo nem SQL: os números vêm de
''' <c>GerencialNovoDados.Carregar</c> e aqui só são distribuídos nos rótulos.
''' </summary>
Public Class GerencialNovoBase
    ' No GerencialBase o Inherits fica no .Designer.vb (classe parcial). Como aqui não
    ' há Designer, precisa ser declarado explicitamente.
    Inherits Pepe.BaseRpts

    ''' <summary>
    ''' Sem chamada a InitializeComponent: não há .Designer.vb próprio, e quem monta os
    ''' controles é o construtor de BaseRpts, invocado por MyBase.New().
    ''' </summary>
    Public Sub New()
        MyBase.New()
        Me.Name = "GerencialNovoBase"
        Me.lblTitulo.Text = "RELATÓRIO GERENCIAL"
    End Sub

    Private Sub GerencialNovoBase_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmDevPrincipal.Visible = False
        Me.txtData1.EditValue = New DateTime(Today.Year, Today.Month, 1)
        Me.txtData2.EditValue = Date.Today
        btnOk2_ButtonClick(Nothing, Nothing)
    End Sub

    Private Sub GerencialNovoBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmDevPrincipal.Visible = True
    End Sub

    Private Sub btnOk2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnOk2.ButtonClick
        Dim dt1 As Date = ConvertToSafeDate(txtData1.Text, Date.MinValue)
        Dim dt2 As Date = ConvertToSafeDate(txtData2.Text, Date.MaxValue)

        ' A carga e a montagem rodam na thread da UI, então a janela fica sem repintar
        ' durante todo o processo. Sem o cursor de espera isso se lê como travamento,
        ' não como "aguarde" — e a carga já chegou a demorar dezenas de segundos.
        Dim cursorAnterior = Me.Cursor
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim d As GerencialNovoDados.Dados
            Try
                d = GerencialNovoDados.Carregar(dt1, dt2)
            Catch ex As Exception
                MsgBox("Erro ao carregar os dados do relatório:" & vbCrLf & vbCrLf & ex.Message,
                       MsgBoxStyle.Critical, "Relatório Gerencial")
                Exit Sub
            End Try

            Dim rpt As New GerencialNovo()
            rpt.MontarLayout(d.TemBoutique, d.FormasPagto.Count)

            rpt.lblPeriodo.Text = "Período: " & txtData1.Text & " a " & txtData2.Text

            PreencherCotacoes(rpt, d)
            PreencherEntradas(rpt, d)
            PreencherVendas(rpt, d)
            PreencherConsertos(rpt, d)
            PreencherComissoes(rpt, d)
            PreencherPecasVendidas(rpt, d)
            PreencherPecasRegistradas(rpt, d)
            PreencherSaidasEClientes(rpt, d)
            PreencherEstoque(rpt, d)

            ' Mesma sequência de GerencialBase.vb:691-693, que é a que funciona:
            ' DocumentSource antes de CreateDocument.
            Me.DocumentViewer1.DocumentSource = rpt
            Me.DocumentViewer1.Visible = True
            rpt.CreateDocument(False)
        Finally
            Me.Cursor = cursorAnterior
        End Try
    End Sub

#Region "Helpers de preenchimento"

    ''' <summary>
    ''' Formata usando o TextFormatString declarado no próprio rótulo, para o formato
    ''' de cada coluna ficar definido num lugar só (o layout).
    ''' </summary>
    Private Shared Sub V(lbl As XRLabel, valor As Double)
        If lbl Is Nothing Then Return
        lbl.Text = String.Format(lbl.TextFormatString, valor)
    End Sub

    Private Shared Sub V(lbl As XRLabel, valor As Integer)
        If lbl Is Nothing Then Return
        lbl.Text = String.Format(lbl.TextFormatString, valor)
    End Sub

    ''' <summary>Razão protegida: denominador zero vira vazio, não "NaN" nem exceção.</summary>
    Private Shared Sub Raz(lbl As XRLabel, numerador As Double, denominador As Double)
        If lbl Is Nothing Then Return
        If denominador = 0 Then
            lbl.Text = String.Empty
        Else
            lbl.Text = String.Format(lbl.TextFormatString, numerador / denominador)
        End If
    End Sub

    Private Shared Sub Raz(lbl As XRLabel, numerador As Double, denominador As Integer)
        Raz(lbl, numerador, CDbl(denominador))
    End Sub

    ''' <summary>
    ''' Valor do metal a preço de HOJE (gramas x cotação atual), que é o que a planilha
    ''' faz ("=36*G6"). Funciona para qualquer família porque soma as duas parcelas.
    ''' </summary>
    Private Shared Function ValorMetal(m As GerencialNovoDados.LinhaMetal,
                                       cot As GerencialNovoDados.Cotacao) As Double
        Return m.GramasOuro * cot.Ouro18k + m.GramasPrata * cot.Prata
    End Function

#End Region

#Region "Seções"

    Private Shared Sub PreencherCotacoes(rpt As GerencialNovo, d As GerencialNovoDados.Dados)
        V(rpt.lblCotDolar, d.Cot.Dolar)
        V(rpt.lblCotOuroFino, d.Cot.OuroFino)
        V(rpt.lblCotOuro18k, d.Cot.Ouro18k)
        V(rpt.lblCotPrata, d.Cot.Prata)
    End Sub

    Private Shared Sub PreencherEntradas(rpt As GerencialNovo, d As GerencialNovoDados.Dados)
        Dim tot = d.Ent.Total

        V(rpt.lblEntCheques, d.Ent.Cheques) : Raz(rpt.lblPctCheques, d.Ent.Cheques, tot)
        V(rpt.lblEntCartDeb, d.Ent.CartaoDebito) : Raz(rpt.lblPctCartDeb, d.Ent.CartaoDebito, tot)
        V(rpt.lblEntCredVista, d.Ent.CreditoVista) : Raz(rpt.lblPctCredVista, d.Ent.CreditoVista, tot)
        V(rpt.lblEntCredParc, d.Ent.CreditoParcelado) : Raz(rpt.lblPctCredParc, d.Ent.CreditoParcelado, tot)
        V(rpt.lblEntCash, d.Ent.Cash) : Raz(rpt.lblPctCash, d.Ent.Cash, tot)
        V(rpt.lblEntTransf, d.Ent.Transferencias) : Raz(rpt.lblPctTransf, d.Ent.Transferencias, tot)
        V(rpt.lblEntTotal, tot) : Raz(rpt.lblPctTotal, tot, tot)

        V(rpt.lblCCDebitos, d.CC.Debitos)
        V(rpt.lblCCCreditos, d.CC.Creditos)
        V(rpt.lblCCSaldo, d.CC.Saldo)

        ' A tabela foi montada com uma linha por forma, então os índices casam.
        For i = 0 To Math.Min(rpt.FormasPagto.Count, d.FormasPagto.Count) - 1
            Dim celulas = rpt.FormasPagto(i)
            Dim forma = d.FormasPagto(i)
            celulas(0).Text = forma.Forma
            V(celulas(1), forma.Vendas)
            V(celulas(2), forma.Consertos)
        Next
    End Sub

    Private Shared Sub PreencherVendas(rpt As GerencialNovo, d As GerencialNovoDados.Dados)
        Dim total = d.Vend.Total.Valor

        V(rpt.lblVdLojaOper, d.Vend.Loja.Oper)
        V(rpt.lblVdLojaVal, d.Vend.Loja.Valor)
        Raz(rpt.lblVdLojaPct, d.Vend.Loja.Valor, total)
        Raz(rpt.lblVdLojaTkt, d.Vend.Loja.Valor, d.Vend.Loja.Oper)

        V(rpt.lblVdLojaAuOper, d.Vend.LojaAu.Oper)
        V(rpt.lblVdLojaAuVal, d.Vend.LojaAu.Valor)
        Raz(rpt.lblVdLojaAuPct, d.Vend.LojaAu.Valor, d.Vend.Loja.Valor)

        V(rpt.lblVdLojaAgOper, d.Vend.LojaAg.Oper)
        V(rpt.lblVdLojaAgVal, d.Vend.LojaAg.Valor)
        Raz(rpt.lblVdLojaAgPct, d.Vend.LojaAg.Valor, d.Vend.Loja.Valor)

        V(rpt.lblVdEncOper, d.Vend.Enc.Oper)
        V(rpt.lblVdEncVal, d.Vend.Enc.Valor)
        Raz(rpt.lblVdEncPct, d.Vend.Enc.Valor, total)
        Raz(rpt.lblVdEncTkt, d.Vend.Enc.Valor, d.Vend.Enc.Oper)

        V(rpt.lblVdEncAuOper, d.Vend.EncAu.Oper)
        V(rpt.lblVdEncAuVal, d.Vend.EncAu.Valor)
        Raz(rpt.lblVdEncAuPct, d.Vend.EncAu.Valor, d.Vend.Enc.Valor)

        V(rpt.lblVdEncAgOper, d.Vend.EncAg.Oper)
        V(rpt.lblVdEncAgVal, d.Vend.EncAg.Valor)
        Raz(rpt.lblVdEncAgPct, d.Vend.EncAg.Valor, d.Vend.Enc.Valor)

        V(rpt.lblVdTotOper, d.Vend.Total.Oper)
        V(rpt.lblVdTotVal, total)
        Raz(rpt.lblVdTotPct, total, total)
        Raz(rpt.lblVdTotTkt, total, d.Vend.Total.Oper)
    End Sub

    Private Shared Sub PreencherConsertos(rpt As GerencialNovo, d As GerencialNovoDados.Dados)
        V(rpt.lblCsOper, d.Cons.Oper)
        V(rpt.lblCsVal, d.Cons.Valor)
        V(rpt.lblCsCusto, d.Cons.Custo)
        Raz(rpt.lblCsTkt, d.Cons.Valor, d.Cons.Oper)
        V(rpt.lblTotVendasConsertos, d.Vend.Total.Valor + d.Cons.Valor)
    End Sub

    ''' <summary>
    ''' lblComLojaBou só existe quando o layout foi montado com a coluna Boutique; o
    ''' helper V() aceita Nothing, então não precisa de If aqui.
    ''' </summary>
    Private Shared Sub PreencherComissoes(rpt As GerencialNovo, d As GerencialNovoDados.Dados)
        V(rpt.lblComLojaAu, d.Com.LojaAu)
        V(rpt.lblComLojaAg, d.Com.LojaAg)
        V(rpt.lblComLojaBou, d.Com.LojaBou)
        V(rpt.lblComLojaCons, d.Com.LojaConsertos)
        V(rpt.lblComLojaTot, d.Com.TotalLoja)

        V(rpt.lblComOfiVenda, d.Com.OficinaVenda)
        V(rpt.lblComOfiEnc, d.Com.OficinaEncomenda)
        V(rpt.lblComOfiCons, d.Com.OficinaConsertos)
        V(rpt.lblComOfiTot, d.Com.TotalOficina)

        V(rpt.lblComTotal, d.Com.Total)
    End Sub

    Private Shared Function Familia(lista As List(Of GerencialNovoDados.LinhaMetal),
                                    nome As String) As GerencialNovoDados.LinhaMetal
        Dim m = lista.FirstOrDefault(Function(x) x.Familia = nome)
        Return If(m, New GerencialNovoDados.LinhaMetal() With {.Familia = nome})
    End Function

    Private Shared Sub PreencherPecasVendidas(rpt As GerencialNovo, d As GerencialNovoDados.Dados)
        Dim au = Familia(d.PecasVendidas, "Ou")
        Dim ag = Familia(d.PecasVendidas, "Ag")
        Dim bou = Familia(d.PecasVendidas, "Bou")

        LinhaPecaVendida(rpt.lblPvAuQtd, rpt.lblPvAuCusto, rpt.lblPvAuGr, rpt.lblPvAuMetal,
                         rpt.lblPvAuMO, rpt.lblPvAuOutros, rpt.lblPvAuVenda, rpt.lblPvAuMarkup, au)
        LinhaPecaVendida(rpt.lblPvAgQtd, rpt.lblPvAgCusto, rpt.lblPvAgGr, rpt.lblPvAgMetal,
                         rpt.lblPvAgMO, rpt.lblPvAgOutros, rpt.lblPvAgVenda, rpt.lblPvAgMarkup, ag)
        If d.TemBoutique Then
            LinhaPecaVendida(rpt.lblPvBouQtd, rpt.lblPvBouCusto, rpt.lblPvBouGr, rpt.lblPvBouMetal,
                             rpt.lblPvBouMO, rpt.lblPvBouOutros, rpt.lblPvBouVenda, rpt.lblPvBouMarkup, bou)
        End If

        Dim tot As New GerencialNovoDados.LinhaMetal() With {
            .Qtd = au.Qtd + ag.Qtd + bou.Qtd,
            .GramasOuro = au.GramasOuro + ag.GramasOuro + bou.GramasOuro,
            .GramasPrata = au.GramasPrata + ag.GramasPrata + bou.GramasPrata,
            .Custo = au.Custo + ag.Custo + bou.Custo,
            .ValorMetal = au.ValorMetal + ag.ValorMetal + bou.ValorMetal,
            .MO = au.MO + ag.MO + bou.MO,
            .Outras = au.Outras + ag.Outras + bou.Outras,
            .PrecoVenda = au.PrecoVenda + ag.PrecoVenda + bou.PrecoVenda
        }
        tot.Gramas = tot.GramasOuro + tot.GramasPrata
        LinhaPecaVendida(rpt.lblPvTotQtd, rpt.lblPvTotCusto, rpt.lblPvTotGr, rpt.lblPvTotMetal,
                         rpt.lblPvTotMO, rpt.lblPvTotOutros, rpt.lblPvTotVenda, rpt.lblPvTotMarkup, tot)
    End Sub

    ''' <summary>
    ''' "Custo total" aqui é HISTÓRICO (decisão do usuário, 2026-08-06): 1TabPeças.Custo
    ''' e METAIS.TotalValor, os mesmos valores da ficha da peça — não mais o metal a
    ''' preço de hoje. Bate com o Relatório de Peças Vendidas, que soma o mesmo
    ''' 1TabPeças.Custo. Como Outras é derivada em VW_RG2_PECAS_VENDIDAS por
    ''' Custo - ValorMetal - MO, a linha Custo = Metal + M.O. + Outros sempre fecha,
    ''' mesmo em peça sem valor de metal cadastrado. O markup sai sobre esse custo.
    ''' </summary>
    Private Shared Sub LinhaPecaVendida(lQtd As XRLabel, lCusto As XRLabel, lGr As XRLabel,
                                        lMetal As XRLabel, lMO As XRLabel, lOutros As XRLabel,
                                        lVenda As XRLabel, lMarkup As XRLabel,
                                        m As GerencialNovoDados.LinhaMetal)
        V(lQtd, m.Qtd)
        V(lCusto, m.Custo)
        V(lGr, m.Gramas)
        V(lMetal, m.ValorMetal)
        V(lMO, m.MO)
        V(lOutros, m.Outras)
        V(lVenda, m.PrecoVenda)
        Raz(lMarkup, m.PrecoVenda, m.Custo)
    End Sub

    Private Shared Sub PreencherPecasRegistradas(rpt As GerencialNovo, d As GerencialNovoDados.Dados)
        LinhaPecaReg(rpt.lblPrFpAuQtd, rpt.lblPrFpAuCusto, rpt.lblPrFpAuGr, rpt.lblPrFpAuMetal,
                     rpt.lblPrFpAuValor, rpt.lblPrFpAuMO, rpt.lblPrFpAuLiq, d.PecasRegFpAu, d.Cot)
        LinhaPecaReg(rpt.lblPrFpAgQtd, rpt.lblPrFpAgCusto, rpt.lblPrFpAgGr, rpt.lblPrFpAgMetal,
                     rpt.lblPrFpAgValor, rpt.lblPrFpAgMO, rpt.lblPrFpAgLiq, d.PecasRegFpAg, d.Cot)
        LinhaPecaReg(rpt.lblPrFfQtd, rpt.lblPrFfCusto, rpt.lblPrFfGr, rpt.lblPrFfMetal,
                     rpt.lblPrFfValor, rpt.lblPrFfMO, rpt.lblPrFfLiq, d.PecasRegFf, d.Cot)

        Dim a = d.PecasRegFpAu, b = d.PecasRegFpAg, c = d.PecasRegFf
        Dim tot As New GerencialNovoDados.LinhaMetal() With {
            .Qtd = a.Qtd + b.Qtd + c.Qtd,
            .GramasOuro = a.GramasOuro + b.GramasOuro + c.GramasOuro,
            .GramasPrata = a.GramasPrata + b.GramasPrata + c.GramasPrata,
            .Custo = a.Custo + b.Custo + c.Custo,
            .ValorMetal = a.ValorMetal + b.ValorMetal + c.ValorMetal,
            .MO = a.MO + b.MO + c.MO
        }
        tot.Gramas = tot.GramasOuro + tot.GramasPrata
        LinhaPecaReg(rpt.lblPrTotQtd, rpt.lblPrTotCusto, rpt.lblPrTotGr, rpt.lblPrTotMetal,
                     rpt.lblPrTotValor, rpt.lblPrTotMO, rpt.lblPrTotLiq, tot, d.Cot)
    End Sub

    ''' <summary>
    ''' Aqui "Custo" é o custo real do cadastro (1TabPeças.Custo) e "Valor" é o metal ao
    ''' valor histórico (METAIS.TotalValor); a coluna "Metal" mostra o mesmo metal a preço
    ''' de hoje. Ter os dois lado a lado é o que permite ver a variação da cotação.
    ''' </summary>
    Private Shared Sub LinhaPecaReg(lQtd As XRLabel, lCusto As XRLabel, lGr As XRLabel,
                                    lMetal As XRLabel, lValor As XRLabel, lMO As XRLabel,
                                    lLiq As XRLabel, m As GerencialNovoDados.LinhaMetal,
                                    cot As GerencialNovoDados.Cotacao)
        V(lQtd, m.Qtd)
        V(lCusto, m.Custo)
        V(lGr, m.Gramas)
        V(lMetal, ValorMetal(m, cot))
        V(lValor, m.ValorMetal)
        V(lMO, m.MO)
        V(lLiq, m.Custo - m.MO)
    End Sub

    Private Shared Sub PreencherSaidasEClientes(rpt As GerencialNovo, d As GerencialNovoDados.Dados)
        V(rpt.lblSaiQtd, d.Sai.Qtd)
        V(rpt.lblSaiCusto, d.Sai.Custo)
        V(rpt.lblSaiValor, d.Sai.Valor)
        V(rpt.lblClientesCad, d.ClientesCadastrados)
    End Sub

    ''' <summary>
    ''' Aqui "Custo" é custo de REPOSIÇÃO (decisão do usuário, 2026-08-06): responde
    ''' "quanto vale o estoque hoje", ao contrário das seções 6 e 7, que são históricas.
    ''' "Venda" continua sendo PrVenda, o preço de tabela cadastrado — ver
    ''' GerencialNovoDados.CarregarEstoque para a fórmula peça a peça. Por isso este
    ''' TOTAL não bate mais com txtCustoFinal do relatório antigo (que é histórico).
    ''' </summary>
    Private Shared Sub PreencherEstoque(rpt As GerencialNovo, d As GerencialNovoDados.Dados)
        rpt.lblEstTitulo.Text = "10. POSIÇÃO DE ESTOQUE EM " & Date.Today.ToString("dd/MM/yyyy") &
            " — custo de reposição (cotação de " & d.CotHoje.DataCot.ToString("dd/MM/yyyy") & ")"

        Dim au = Familia(d.Estoque, "Ou")
        Dim ag = Familia(d.Estoque, "Ag")
        Dim bou = Familia(d.Estoque, "Bou")

        V(rpt.lblEstAuQtd, au.Qtd) : V(rpt.lblEstAuPeso, au.GramasOuro)
        V(rpt.lblEstAuCusto, au.Custo) : V(rpt.lblEstAuVenda, au.PrecoVenda)

        V(rpt.lblEstAgQtd, ag.Qtd) : V(rpt.lblEstAgPeso, ag.GramasPrata)
        V(rpt.lblEstAgCusto, ag.Custo) : V(rpt.lblEstAgVenda, ag.PrecoVenda)

        If d.TemBoutique Then
            V(rpt.lblEstBouQtd, bou.Qtd) : V(rpt.lblEstBouPeso, bou.Gramas)
            V(rpt.lblEstBouCusto, bou.Custo) : V(rpt.lblEstBouVenda, bou.PrecoVenda)
        End If

        V(rpt.lblEstTotQtd, au.Qtd + ag.Qtd + bou.Qtd)
        V(rpt.lblEstTotPeso, au.GramasOuro + ag.GramasPrata + bou.Gramas)
        V(rpt.lblEstTotCusto, au.Custo + ag.Custo + bou.Custo)
        V(rpt.lblEstTotVenda, au.PrecoVenda + ag.PrecoVenda + bou.PrecoVenda)
    End Sub

#End Region

End Class
