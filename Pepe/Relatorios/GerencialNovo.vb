Imports DevExpress.Drawing
Imports DevExpress.Drawing.Printing
Imports DevExpress.Utils
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

''' <summary>
''' Relatório Gerencial (novo layout, A4 retrato).
'''
''' O layout é montado programaticamente por <see cref="MontarLayout"/>, e não por
''' um arquivo .Designer.vb: são ~95 rótulos numa grade regular de 9 colunas, e a
''' construção em código deixa o espaçamento governado por um punhado de constantes
''' em vez de por centenas de coordenadas literais.
'''
''' Quem preenche os rótulos é <c>GerencialNovoBase</c>. Este arquivo não acessa dados.
'''
''' Unidade: décimos de milímetro (mesmo Dpi 254 de GerencialSubFormas1/2, para que os
''' subrelatórios embutam 1:1, sem conversão de coordenadas).
''' </summary>
Public Class GerencialNovo
    Inherits XtraReport

#Region "Grade e métricas do layout"

    ' Página A4 retrato: 2100 x 2970 (0,1 mm). Margens 10 mm nas laterais, 8 mm em cima/baixo.
    Private Const MARGEM_LAT As Single = 100.0F
    Private Const MARGEM_VER As Single = 80.0F
    Friend Const LARGURA_UTIL As Single = 2100.0F - 2.0F * MARGEM_LAT   ' 1900
    Friend Const ALTURA_UTIL As Single = 2970.0F - 2.0F * MARGEM_VER    ' 2810

    ' Grade principal de 9 colunas — soma exatamente LARGURA_UTIL.
    ' As colunas de dinheiro foram alargadas à custa da coluna A depois que valores
    ' reais truncaram: "2.628.496,24" precisa de ~216 e não cabia nos 180 originais.
    Private Const COL_A As Single = 0.0F : Private Const LAR_A As Single = 420.0F   ' rótulo da linha
    Private Const COL_B As Single = 420.0F : Private Const LAR_B As Single = 130.0F   ' Qtd. / Oper.
    Private Const COL_C As Single = 550.0F : Private Const LAR_C As Single = 210.0F   ' Valor / Custo
    Private Const COL_D As Single = 760.0F : Private Const LAR_D As Single = 190.0F   ' % Part. / Metal (g)
    Private Const COL_E As Single = 950.0F : Private Const LAR_E As Single = 200.0F   ' Tkt Médio / valor metal
    Private Const COL_F As Single = 1150.0F : Private Const LAR_F As Single = 190.0F  ' M.O. / Valor
    Private Const COL_G As Single = 1340.0F : Private Const LAR_G As Single = 180.0F  ' Outros / M.O.
    Private Const COL_H As Single = 1520.0F : Private Const LAR_H As Single = 210.0F  ' Preço Venda / Custo-M.O.
    Private Const COL_I As Single = 1730.0F : Private Const LAR_I As Single = 170.0F  ' Markup

    ' Seção 10 tem só 5 colunas e valores grandes (estoque consolidado), então usa
    ' larguras próprias em vez da grade de 9.
    Private Const S10_QTD As Single = 420.0F : Private Const S10_LAR_QTD As Single = 130.0F
    Private Const S10_PESO As Single = 550.0F : Private Const S10_LAR_PESO As Single = 210.0F
    Private Const S10_CUSTO As Single = 760.0F : Private Const S10_LAR_CUSTO As Single = 230.0F
    Private Const S10_VENDA As Single = 990.0F : Private Const S10_LAR_VENDA As Single = 260.0F

    ' Seção 2 usa grade própria: três blocos lado a lado.
    Private Const S2A_ROT As Single = 0.0F : Private Const S2A_LAR_ROT As Single = 320.0F
    Private Const S2A_VAL As Single = 320.0F : Private Const S2A_LAR_VAL As Single = 180.0F
    Private Const S2A_PCT As Single = 500.0F : Private Const S2A_LAR_PCT As Single = 150.0F
    Private Const S2B_ROT As Single = 670.0F : Private Const S2B_LAR_ROT As Single = 260.0F
    Private Const S2B_VAL As Single = 930.0F : Private Const S2B_LAR_VAL As Single = 190.0F
    ' Bloco C: tabela de formas de pagamento, nos 769 restantes (1131 a 1900).
    Private Const S2C_ROT As Single = 1131.0F : Private Const S2C_LAR_ROT As Single = 300.0F
    Private Const S2C_VEN As Single = 1431.0F : Private Const S2C_LAR_VEN As Single = 235.0F
    Private Const S2C_CON As Single = 1666.0F : Private Const S2C_LAR_CON As Single = 234.0F

    ' Alturas. Com ALT_LINHA=45/GAP=30 o relatório soma 2780 e estoura os 2750
    ' disponíveis assim que a linha "Boutique" aparece; 42/25 deixava 146 de folga.
    ' Depois que a seção 5 passou de 3 para 5 linhas (+84), a folga caiu para 62 e o
    ' GAP foi de 25 para 20 — são 10 espaços entre seções, então recupera 50.
    Private Const ALT_TITULO As Single = 70.0F
    Private Const ALT_FAIXA As Single = 50.0F
    Private Const ALT_LINHA As Single = 42.0F
    Private Const GAP As Single = 20.0F
    Private Const GAP_CURTO As Single = 20.0F

    ' Fontes
    Private Shared ReadOnly FonteBase As New DXFont("Arial", 8.0F)
    Private Shared ReadOnly FonteTitulo As New DXFont("Arial", 14.0F, DXFontStyle.Bold)
    Private Shared ReadOnly FonteSubtitulo As New DXFont("Arial", 9.0F)
    Private Shared ReadOnly FonteFaixa As New DXFont("Arial", 9.0F, DXFontStyle.Bold)
    Private Shared ReadOnly FonteCabecalho As New DXFont("Arial", 8.0F, DXFontStyle.Bold)
    Private Shared ReadOnly FonteTotal As New DXFont("Arial", 8.0F, DXFontStyle.Bold)

    Private Shared ReadOnly CorFaixa As Color = Color.FromArgb(225, 225, 225)
    Private Shared ReadOnly CorLinhaTotal As Color = Color.FromArgb(245, 245, 245)

    ' Formatos
    Private Const FMT_N0 As String = "{0:n0}"
    Private Const FMT_N2 As String = "{0:n2}"
    ' Dinheiro sem centavos: num relatório de conferência os centavos só poluem. Só
    ' sobrou FMT_N2 onde o valor NÃO é dinheiro somado — as cotações da seção 1 (preço
    ' unitário) e a coluna Peso (g) da seção 10.
    ' "#,##0" e não "n0", que renderiza igual: Scripts\VerificaLayout.vb escolhe o valor
    ' de pior caso olhando o TextFormatString, e precisa distinguir dinheiro (milhões)
    ' de quantidade de peças (milhares).
    Private Const FMT_DIN As String = "{0:#,##0}"
    Private Const FMT_PCT As String = "{0:p2}"
    Private Const FMT_GR As String = "{0:n2} g"
    Private Const FMT_MULT As String = "{0:n2}x"

#End Region

#Region "Rótulos preenchidos em runtime por GerencialNovoBase"

    Friend lblPeriodo As XRLabel

    ' 1. Cotações
    Friend lblCotDolar, lblCotOuroFino, lblCotOuro18k, lblCotPrata As XRLabel

    ' 2. Entradas / C/C
    Friend lblEntCheques, lblEntCartDeb, lblEntCredVista, lblEntCredParc As XRLabel
    Friend lblEntCash, lblEntTransf, lblEntTotal As XRLabel
    Friend lblPctCheques, lblPctCartDeb, lblPctCredVista, lblPctCredParc As XRLabel
    Friend lblPctCash, lblPctTransf, lblPctTotal As XRLabel
    Friend lblCCDebitos, lblCCCreditos, lblCCSaldo As XRLabel
    ''' <summary>Uma entrada por forma de pagamento: rótulo, valor em vendas, valor em consertos.</summary>
    Friend FormasPagto As New List(Of XRLabel())()

    ' 3. Vendas
    Friend lblVdLojaOper, lblVdLojaVal, lblVdLojaPct, lblVdLojaTkt As XRLabel
    Friend lblVdLojaAuOper, lblVdLojaAuVal, lblVdLojaAuPct As XRLabel
    Friend lblVdLojaAgOper, lblVdLojaAgVal, lblVdLojaAgPct As XRLabel
    Friend lblVdEncOper, lblVdEncVal, lblVdEncPct, lblVdEncTkt As XRLabel
    Friend lblVdEncAuOper, lblVdEncAuVal, lblVdEncAuPct As XRLabel
    Friend lblVdEncAgOper, lblVdEncAgVal, lblVdEncAgPct As XRLabel
    Friend lblVdTotOper, lblVdTotVal, lblVdTotPct, lblVdTotTkt As XRLabel

    ' 4. Consertos
    Friend lblCsOper, lblCsVal, lblCsCusto, lblCsTkt As XRLabel
    Friend lblTotVendasConsertos As XRLabel

    ' 5. Comissões
    Friend lblComLojaAu, lblComLojaAg, lblComLojaBou, lblComLojaCons, lblComLojaTot As XRLabel
    Friend lblComOfiVenda, lblComOfiEnc, lblComOfiCons, lblComOfiTot As XRLabel
    Friend lblComTotal As XRLabel

    ' 6. Peças vendidas
    Friend lblPvAuQtd, lblPvAuCusto, lblPvAuGr, lblPvAuMetal, lblPvAuMO, lblPvAuOutros, lblPvAuVenda, lblPvAuMarkup As XRLabel
    Friend lblPvAgQtd, lblPvAgCusto, lblPvAgGr, lblPvAgMetal, lblPvAgMO, lblPvAgOutros, lblPvAgVenda, lblPvAgMarkup As XRLabel
    Friend lblPvBouQtd, lblPvBouCusto, lblPvBouGr, lblPvBouMetal, lblPvBouMO, lblPvBouOutros, lblPvBouVenda, lblPvBouMarkup As XRLabel
    Friend lblPvTotQtd, lblPvTotCusto, lblPvTotGr, lblPvTotMetal, lblPvTotMO, lblPvTotOutros, lblPvTotVenda, lblPvTotMarkup As XRLabel

    ' 7. Peças registradas
    Friend lblPrFpAuQtd, lblPrFpAuCusto, lblPrFpAuGr, lblPrFpAuMetal, lblPrFpAuValor, lblPrFpAuMO, lblPrFpAuLiq As XRLabel
    Friend lblPrFpAgQtd, lblPrFpAgCusto, lblPrFpAgGr, lblPrFpAgMetal, lblPrFpAgValor, lblPrFpAgMO, lblPrFpAgLiq As XRLabel
    Friend lblPrFfQtd, lblPrFfCusto, lblPrFfGr, lblPrFfMetal, lblPrFfValor, lblPrFfMO, lblPrFfLiq As XRLabel
    Friend lblPrTotQtd, lblPrTotCusto, lblPrTotGr, lblPrTotMetal, lblPrTotValor, lblPrTotMO, lblPrTotLiq As XRLabel

    ' 8. Saídas
    Friend lblSaiQtd, lblSaiCusto, lblSaiValor As XRLabel

    ' 9. Clientes
    Friend lblClientesCad As XRLabel

    ' 10. Estoque
    Friend lblEstTitulo As XRLabel
    Friend lblEstAuQtd, lblEstAuPeso, lblEstAuCusto, lblEstAuVenda As XRLabel
    Friend lblEstAgQtd, lblEstAgPeso, lblEstAgCusto, lblEstAgVenda As XRLabel
    Friend lblEstBouQtd, lblEstBouPeso, lblEstBouCusto, lblEstBouVenda As XRLabel
    Friend lblEstTotQtd, lblEstTotPeso, lblEstTotCusto, lblEstTotVenda As XRLabel

#End Region

    ''' <summary>Banda que está recebendo os controles no momento da montagem.</summary>
    Private _banda As Band
    Private _mostrarBoutique As Boolean
    Private _qtdFormasPagto As Integer

    Public Sub New()
        ConfigurarPagina()
    End Sub

    Private Sub ConfigurarPagina()
        Me.Dpi = 254.0F
        ' Qualificado: sem o nome completo, o VB resolve o lado direito como a própria
        ' propriedade Me.ReportUnit em vez do enum, e não compila.
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.PaperKind = DXPaperKind.A4
        Me.PageWidth = 2100
        Me.PageHeight = 2970
        Me.Landscape = False
        Me.Margins = New DXMargins(MARGEM_LAT, MARGEM_LAT, MARGEM_VER, MARGEM_VER)
        Me.Font = FonteBase
        Me.SnapGridSize = 25.0F
        ' Sem DataSource, sem ScriptsSource e sem bandas de grupo: todos os valores
        ' são atribuídos em código, o que evita o ExpressionBinding duplicado que o
        ' relatório antigo sofre a cada render (ver GroupFooterBand1_BeforePrint).
        Me.DataSource = Nothing
    End Sub

    ''' <summary>
    ''' Constrói as bandas e todos os controles. Chamar UMA vez, antes de preencher.
    ''' </summary>
    ''' <param name="mostrarBoutique">
    ''' Inclui a linha "Boutique" nas seções 6, 7 e 10. Peças com Família fora de
    ''' {Ou, Ag} caem nessa linha; sem ela, Au + Ag não fecha com o TOTAL.
    ''' </param>
    ''' <param name="qtdFormasPagto">
    ''' Quantas linhas reservar na tabela de formas de pagamento. As procs filtram
    ''' Total &gt; 0, então o número varia por período.
    ''' </param>
    Public Sub MontarLayout(mostrarBoutique As Boolean, qtdFormasPagto As Integer)
        _mostrarBoutique = mostrarBoutique
        _qtdFormasPagto = qtdFormasPagto

        Dim topo As New TopMarginBand() With {.Dpi = 254.0F, .HeightF = MARGEM_VER, .Name = "TopMargin"}
        Dim rodape As New BottomMarginBand() With {.Dpi = 254.0F, .HeightF = MARGEM_VER, .Name = "BottomMargin"}
        Dim rodapePagina As New PageFooterBand() With {.Dpi = 254.0F, .HeightF = 60.0F, .Name = "PageFooter"}

        ' Duas bandas de conteúdo, e não uma só: o XRSubreport da seção 2 tem altura
        ' variável, e controles que ficam ABAIXO dele na MESMA banda não descem quando
        ' ele cresce — sobreporiam a seção 3. Numa banda seguinte, descem.
        Dim cabecalho As New ReportHeaderBand() With {.Dpi = 254.0F, .Name = "ReportHeader"}
        Dim detalhe As New DetailBand() With {.Dpi = 254.0F, .Name = "Detail"}

        Bands.AddRange(New Band() {topo, cabecalho, detalhe, rodapePagina, rodape})

        _banda = cabecalho
        Dim y As Single = 0.0F
        y = MontarCabecalho(y)
        y = MontarSecao1Cotacoes(y)
        y = MontarSecao2Entradas(y)
        cabecalho.HeightF = y

        _banda = detalhe
        y = 0.0F
        y = MontarSecao3Vendas(y)
        y = MontarSecao4Consertos(y)
        y = MontarSecao5Comissoes(y)
        y = MontarSecao6PecasVendidas(y)
        y = MontarSecao7PecasRegistradas(y)
        y = MontarSecao8Saidas(y)
        y = MontarSecao9Clientes(y)
        y = MontarSecao10Estoque(y)
        detalhe.HeightF = y

        MontarRodapePagina(rodapePagina)
    End Sub

#Region "Helpers de construção"

    Private Function Novo(banda As Band, x As Single, y As Single, largura As Single,
                          altura As Single, texto As String, fonte As DXFont,
                          alinhamento As TextAlignment) As XRLabel
        Dim l As New XRLabel() With {
            .Dpi = 254.0F,
            .LocationFloat = New PointFloat(x, y),
            .SizeF = New SizeF(largura, altura),
            .Text = texto,
            .Font = fonte,
            .TextAlignment = alinhamento,
            .Padding = New PaddingInfo(15, 15, 0, 0, 254.0F),
            .BackColor = Color.Transparent,
            .Borders = BorderSide.None,
            .WordWrap = False,
            .CanGrow = False
        }
        ' WordWrap/CanGrow desligados de propósito: com eles, um rótulo de cabeçalho que
        ' não coubesse na coluna quebrava em duas linhas, crescia e EMPURRAVA para baixo
        ' os controles seguintes da banda, deslocando o resto do layout.
        l.StylePriority.UseFont = False
        l.StylePriority.UseTextAlignment = False
        l.StylePriority.UsePadding = False
        banda.Controls.Add(l)
        Return l
    End Function

    ''' <summary>Faixa cinza de título de seção, ocupando a largura útil.</summary>
    Private Function Faixa(y As Single, texto As String) As XRLabel
        Dim l = Novo(_banda, 0.0F, y, LARGURA_UTIL, ALT_FAIXA, texto, FonteFaixa, TextAlignment.MiddleLeft)
        l.BackColor = CorFaixa
        l.StylePriority.UseBackColor = False
        Return l
    End Function

    ''' <summary>Texto à esquerda (rótulo de linha).</summary>
    Private Function Rotulo(y As Single, x As Single, largura As Single, texto As String,
                            Optional negrito As Boolean = False,
                            Optional recuo As Single = 0.0F) As XRLabel
        Dim l = Novo(_banda, x + recuo, y, largura - recuo, ALT_LINHA, texto,
                     If(negrito, FonteTotal, FonteBase), TextAlignment.MiddleLeft)
        Return l
    End Function

    ''' <summary>Célula numérica alinhada à direita, sem valor inicial.</summary>
    Private Function Celula(y As Single, x As Single, largura As Single, formato As String,
                            Optional negrito As Boolean = False) As XRLabel
        Dim l = Novo(_banda, x, y, largura, ALT_LINHA, String.Empty,
                     If(negrito, FonteTotal, FonteBase), TextAlignment.MiddleRight)
        l.TextFormatString = formato
        Return l
    End Function

    ''' <summary>Cabeçalho de coluna: negrito, borda inferior.</summary>
    Private Function Cabecalho(y As Single, x As Single, largura As Single, texto As String,
                               Optional alinhamento As TextAlignment = TextAlignment.MiddleRight) As XRLabel
        Dim l = Novo(_banda, x, y, largura, ALT_LINHA, texto, FonteCabecalho, alinhamento)
        l.Borders = BorderSide.Bottom
        l.StylePriority.UseBorders = False
        Return l
    End Function

    ''' <summary>
    ''' Fundo cinza-claro atrás de uma linha de totais, na largura útil.
    ''' CHAMAR DEPOIS de criar os rótulos da linha: na coleção Controls o índice MENOR
    ''' é o que fica na frente, então esta faixa opaca precisa ser a última inserida,
    ''' senão cobre o texto do total.
    ''' </summary>
    Private Sub FundoTotal(y As Single)
        Dim l = Novo(_banda, 0.0F, y, LARGURA_UTIL, ALT_LINHA, String.Empty, FonteBase, TextAlignment.MiddleLeft)
        l.BackColor = CorLinhaTotal
        l.Borders = BorderSide.Top
        l.StylePriority.UseBackColor = False
        l.StylePriority.UseBorders = False
    End Sub

#End Region

#Region "Seções"

    Private Function MontarCabecalho(y As Single) As Single
        Novo(_banda, 0.0F, y, LARGURA_UTIL, ALT_TITULO, "RELATÓRIO GERENCIAL",
             FonteTitulo, TextAlignment.MiddleCenter)
        y += ALT_TITULO

        lblPeriodo = Novo(_banda, 0.0F, y, LARGURA_UTIL, ALT_LINHA, String.Empty,
                          FonteSubtitulo, TextAlignment.MiddleCenter)
        Return y + ALT_LINHA + GAP
    End Function

    Private Function MontarSecao1Cotacoes(y As Single) As Single
        Faixa(y, "1. COTAÇÕES DE REFERÊNCIA")
        y += ALT_FAIXA

        ' Quatro pares (rótulo, valor) distribuídos na largura útil.
        Const PAR As Single = LARGURA_UTIL / 4.0F      ' 475
        Const LAR_ROT As Single = 290.0F
        Const LAR_VAL As Single = PAR - LAR_ROT        ' 185

        Rotulo(y, PAR * 0.0F, LAR_ROT, "Dólar (USD):")
        lblCotDolar = Celula(y, PAR * 0.0F + LAR_ROT, LAR_VAL, FMT_N2)
        Rotulo(y, PAR * 1.0F, LAR_ROT, "Ouro fino (g):")
        lblCotOuroFino = Celula(y, PAR * 1.0F + LAR_ROT, LAR_VAL, FMT_N2)
        Rotulo(y, PAR * 2.0F, LAR_ROT, "Ouro 18K (g):")
        lblCotOuro18k = Celula(y, PAR * 2.0F + LAR_ROT, LAR_VAL, FMT_N2)
        Rotulo(y, PAR * 3.0F, LAR_ROT, "Prata 925 (g):")
        lblCotPrata = Celula(y, PAR * 3.0F + LAR_ROT, LAR_VAL, FMT_N2)

        Return y + ALT_LINHA + GAP
    End Function

    Private Function MontarSecao2Entradas(y As Single) As Single
        Faixa(y, "2. ENTRADAS FINANCEIRAS E CONTA CORRENTE")
        y += ALT_FAIXA

        Dim yTopo As Single = y

        ' --- Bloco A: formas de recebimento -------------------------------------
        Cabecalho(y, S2A_ROT, S2A_LAR_ROT, "Forma de receb.", TextAlignment.MiddleLeft)
        Cabecalho(y, S2A_VAL, S2A_LAR_VAL, "Valor")
        Cabecalho(y, S2A_PCT, S2A_LAR_PCT, "% Part.")
        y += ALT_LINHA

        Rotulo(y, S2A_ROT, S2A_LAR_ROT, "Cheques descontados")
        lblEntCheques = Celula(y, S2A_VAL, S2A_LAR_VAL, FMT_DIN)
        lblPctCheques = Celula(y, S2A_PCT, S2A_LAR_PCT, FMT_PCT)
        y += ALT_LINHA

        Rotulo(y, S2A_ROT, S2A_LAR_ROT, "Cartões débito")
        lblEntCartDeb = Celula(y, S2A_VAL, S2A_LAR_VAL, FMT_DIN)
        lblPctCartDeb = Celula(y, S2A_PCT, S2A_LAR_PCT, FMT_PCT)
        y += ALT_LINHA

        Rotulo(y, S2A_ROT, S2A_LAR_ROT, "Crédito à vista")
        lblEntCredVista = Celula(y, S2A_VAL, S2A_LAR_VAL, FMT_DIN)
        lblPctCredVista = Celula(y, S2A_PCT, S2A_LAR_PCT, FMT_PCT)
        y += ALT_LINHA

        Rotulo(y, S2A_ROT, S2A_LAR_ROT, "Crédito parcelado")
        lblEntCredParc = Celula(y, S2A_VAL, S2A_LAR_VAL, FMT_DIN)
        lblPctCredParc = Celula(y, S2A_PCT, S2A_LAR_PCT, FMT_PCT)
        y += ALT_LINHA

        Rotulo(y, S2A_ROT, S2A_LAR_ROT, "Dinheiro (cash)")
        lblEntCash = Celula(y, S2A_VAL, S2A_LAR_VAL, FMT_DIN)
        lblPctCash = Celula(y, S2A_PCT, S2A_LAR_PCT, FMT_PCT)
        y += ALT_LINHA

        ' Abreviado: "Transferências Bancárias" em Arial 8 mede ~37 mm e estoura os 36 mm da coluna.
        Rotulo(y, S2A_ROT, S2A_LAR_ROT, "Transferências banc.")
        lblEntTransf = Celula(y, S2A_VAL, S2A_LAR_VAL, FMT_DIN)
        lblPctTransf = Celula(y, S2A_PCT, S2A_LAR_PCT, FMT_PCT)
        y += ALT_LINHA

        Rotulo(y, S2A_ROT, S2A_LAR_ROT, "TOTAL ENTRADAS", negrito:=True)
        lblEntTotal = Celula(y, S2A_VAL, S2A_LAR_VAL, FMT_DIN, negrito:=True)
        lblPctTotal = Celula(y, S2A_PCT, S2A_LAR_PCT, FMT_PCT, negrito:=True)
        Dim yFimA As Single = y + ALT_LINHA

        ' --- Bloco B: movimentação de conta corrente ----------------------------
        Dim yB As Single = yTopo
        Cabecalho(yB, S2B_ROT, S2B_LAR_ROT, "Conta corrente", TextAlignment.MiddleLeft)
        Cabecalho(yB, S2B_VAL, S2B_LAR_VAL, "Valor")
        yB += ALT_LINHA

        Rotulo(yB, S2B_ROT, S2B_LAR_ROT, "Débitos C/C")
        lblCCDebitos = Celula(yB, S2B_VAL, S2B_LAR_VAL, FMT_DIN)
        yB += ALT_LINHA

        Rotulo(yB, S2B_ROT, S2B_LAR_ROT, "Créditos C/C")
        lblCCCreditos = Celula(yB, S2B_VAL, S2B_LAR_VAL, FMT_DIN)
        yB += ALT_LINHA

        ' "SALDO LÍQUIDO C/C" em negrito mede ~27,5 mm e não cabe nos 27 da coluna.
        Rotulo(yB, S2B_ROT, S2B_LAR_ROT, "SALDO LÍQUIDO", negrito:=True)
        lblCCSaldo = Celula(yB, S2B_VAL, S2B_LAR_VAL, FMT_DIN, negrito:=True)
        yB += ALT_LINHA

        ' --- Bloco C: formas de pagamento ---------------------------------------
        ' Tabela própria em vez dos subrelatórios GerencialSubFormas1/2: as duas
        ' stored procedures devolvem o MESMO conjunto de formas, então uma tabela com
        ' duas colunas de valor mostra a mesma informação em metade da altura.
        ' Empilhados, os dois subrelatórios somam 910 (2 cabeçalhos + 14 linhas de 50)
        ' contra os 336 disponíveis aqui — jogariam o relatório para uma segunda página.
        Dim yC As Single = yTopo
        ' Mesmo rótulo dos subrelatórios originais, e cabe nos 300 da coluna.
        Cabecalho(yC, S2C_ROT, S2C_LAR_ROT, "Forma de pagto.", TextAlignment.MiddleLeft)
        Cabecalho(yC, S2C_VEN, S2C_LAR_VEN, "Vendas")
        Cabecalho(yC, S2C_CON, S2C_LAR_CON, "Consertos")
        yC += ALT_LINHA

        For i = 1 To _qtdFormasPagto
            Dim rot = Rotulo(yC, S2C_ROT, S2C_LAR_ROT, String.Empty)
            Dim ven = Celula(yC, S2C_VEN, S2C_LAR_VEN, FMT_DIN)
            Dim con = Celula(yC, S2C_CON, S2C_LAR_CON, FMT_DIN)
            FormasPagto.Add(New XRLabel() {rot, ven, con})
            yC += ALT_LINHA
        Next

        Return Math.Max(Math.Max(yFimA, yB), yC) + GAP
    End Function

    Private Function MontarSecao3Vendas(y As Single) As Single
        Faixa(y, "3. DESEMPENHO DE VENDAS")
        y += ALT_FAIXA

        Cabecalho(y, COL_A, LAR_A, "Vendas líquidas", TextAlignment.MiddleLeft)
        Cabecalho(y, COL_B, LAR_B, "Oper.")
        Cabecalho(y, COL_C, LAR_C, "Valor")
        Cabecalho(y, COL_D, LAR_D, "% Part.")
        Cabecalho(y, COL_E, LAR_E, "Tkt médio")
        y += ALT_LINHA

        ' "Loja (não encomenda)" e não só "Loja": existe uma vendedora chamada "Loja"
        ' em VENDAS.Vendedora (é de lá que sai VI_VENDAS.V), e são coisas diferentes.
        ' Aqui o eixo é a peça ser encomenda (1TabPeças.Oficial) ou não.
        Rotulo(y, COL_A, LAR_A, "Loja (não encomenda)")
        lblVdLojaOper = Celula(y, COL_B, LAR_B, FMT_N0)
        lblVdLojaVal = Celula(y, COL_C, LAR_C, FMT_DIN)
        ' Negrito: este % é sobre o TOTAL, enquanto o das linhas-filhas logo abaixo é
        ' sobre o pai. Sem o destaque os quatro números parecem comparáveis e não são.
        lblVdLojaPct = Celula(y, COL_D, LAR_D, FMT_PCT, negrito:=True)
        lblVdLojaTkt = Celula(y, COL_E, LAR_E, FMT_DIN)
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "Ouro (Au)", recuo:=80.0F)
        lblVdLojaAuOper = Celula(y, COL_B, LAR_B, FMT_N0)
        lblVdLojaAuVal = Celula(y, COL_C, LAR_C, FMT_DIN)
        lblVdLojaAuPct = Celula(y, COL_D, LAR_D, FMT_PCT)
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "Prata (Ag)", recuo:=80.0F)
        lblVdLojaAgOper = Celula(y, COL_B, LAR_B, FMT_N0)
        lblVdLojaAgVal = Celula(y, COL_C, LAR_C, FMT_DIN)
        lblVdLojaAgPct = Celula(y, COL_D, LAR_D, FMT_PCT)
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "Encomendas")
        lblVdEncOper = Celula(y, COL_B, LAR_B, FMT_N0)
        lblVdEncVal = Celula(y, COL_C, LAR_C, FMT_DIN)
        lblVdEncPct = Celula(y, COL_D, LAR_D, FMT_PCT, negrito:=True)   ' idem lblVdLojaPct
        lblVdEncTkt = Celula(y, COL_E, LAR_E, FMT_DIN)
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "Ouro (Au)", recuo:=80.0F)
        lblVdEncAuOper = Celula(y, COL_B, LAR_B, FMT_N0)
        lblVdEncAuVal = Celula(y, COL_C, LAR_C, FMT_DIN)
        lblVdEncAuPct = Celula(y, COL_D, LAR_D, FMT_PCT)
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "Prata (Ag)", recuo:=80.0F)
        lblVdEncAgOper = Celula(y, COL_B, LAR_B, FMT_N0)
        lblVdEncAgVal = Celula(y, COL_C, LAR_C, FMT_DIN)
        lblVdEncAgPct = Celula(y, COL_D, LAR_D, FMT_PCT)
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "TOTAL", negrito:=True)
        lblVdTotOper = Celula(y, COL_B, LAR_B, FMT_N0, negrito:=True)
        lblVdTotVal = Celula(y, COL_C, LAR_C, FMT_DIN, negrito:=True)
        lblVdTotPct = Celula(y, COL_D, LAR_D, FMT_PCT, negrito:=True)
        lblVdTotTkt = Celula(y, COL_E, LAR_E, FMT_DIN, negrito:=True)
        FundoTotal(y)

        Return y + ALT_LINHA + GAP
    End Function

    Private Function MontarSecao4Consertos(y As Single) As Single
        Faixa(y, "4. CONSERTOS / SERVIÇOS")
        y += ALT_FAIXA

        Cabecalho(y, COL_A, LAR_A, String.Empty, TextAlignment.MiddleLeft)
        Cabecalho(y, COL_B, LAR_B, "Oper.")
        Cabecalho(y, COL_C, LAR_C, "Valor")
        Cabecalho(y, COL_D, LAR_D, "Custo")
        Cabecalho(y, COL_E, LAR_E, "Tkt médio")
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "Consertos")
        lblCsOper = Celula(y, COL_B, LAR_B, FMT_N0)
        lblCsVal = Celula(y, COL_C, LAR_C, FMT_DIN)
        lblCsCusto = Celula(y, COL_D, LAR_D, FMT_DIN)
        lblCsTkt = Celula(y, COL_E, LAR_E, FMT_DIN)
        y += ALT_LINHA + GAP_CURTO

        Rotulo(y, COL_A, LAR_A + LAR_B, "TOTAL VENDAS + CONSERTOS", negrito:=True)
        lblTotVendasConsertos = Celula(y, COL_C, LAR_C, FMT_DIN, negrito:=True)
        FundoTotal(y)

        Return y + ALT_LINHA + GAP
    End Function

    ''' <summary>
    ''' Dois blocos com cabeçalhos DIFERENTES: a comissão da loja se reparte por família
    ''' da peça, a da oficina por canal. Por isso há duas linhas de cabeçalho e não uma —
    ''' um cabeçalho comum teria de escrever "Au / Venda" em cima da mesma coluna.
    '''
    ''' Os três TOTAIS ficam todos em COL_G, um debaixo do outro, que é o que torna
    ''' visível que o de baixo é a soma dos dois de cima.
    ''' </summary>
    Private Function MontarSecao5Comissoes(y As Single) As Single
        Faixa(y, "5. COMISSÕES")
        y += ALT_FAIXA

        Cabecalho(y, COL_A, LAR_A, String.Empty, TextAlignment.MiddleLeft)
        Cabecalho(y, COL_C, LAR_C, "Ouro (Au)")
        Cabecalho(y, COL_D, LAR_D, "Prata (Ag)")
        If _mostrarBoutique Then Cabecalho(y, COL_E, LAR_E, "Boutique")
        Cabecalho(y, COL_F, LAR_F, "Consertos")
        Cabecalho(y, COL_G, LAR_G, "TOTAL")
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "Loja")
        lblComLojaAu = Celula(y, COL_C, LAR_C, FMT_DIN)
        lblComLojaAg = Celula(y, COL_D, LAR_D, FMT_DIN)
        If _mostrarBoutique Then lblComLojaBou = Celula(y, COL_E, LAR_E, FMT_DIN)
        lblComLojaCons = Celula(y, COL_F, LAR_F, FMT_DIN)
        lblComLojaTot = Celula(y, COL_G, LAR_G, FMT_DIN, negrito:=True)
        y += ALT_LINHA

        Cabecalho(y, COL_A, LAR_A, String.Empty, TextAlignment.MiddleLeft)
        Cabecalho(y, COL_C, LAR_C, "Venda")
        Cabecalho(y, COL_D, LAR_D, "Encomenda")
        Cabecalho(y, COL_F, LAR_F, "Consertos")
        Cabecalho(y, COL_G, LAR_G, "TOTAL")
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "Oficina")
        lblComOfiVenda = Celula(y, COL_C, LAR_C, FMT_DIN)
        lblComOfiEnc = Celula(y, COL_D, LAR_D, FMT_DIN)
        lblComOfiCons = Celula(y, COL_F, LAR_F, FMT_DIN)
        lblComOfiTot = Celula(y, COL_G, LAR_G, FMT_DIN, negrito:=True)
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "TOTAL COMISSÕES", negrito:=True)
        lblComTotal = Celula(y, COL_G, LAR_G, FMT_DIN, negrito:=True)
        FundoTotal(y)

        Return y + ALT_LINHA + GAP
    End Function

    Private Function MontarSecao6PecasVendidas(y As Single) As Single
        Faixa(y, "6. PEÇAS VENDIDAS NO PERÍODO")
        y += ALT_FAIXA

        Cabecalho(y, COL_A, LAR_A, "Metal / categoria", TextAlignment.MiddleLeft)
        Cabecalho(y, COL_B, LAR_B, "Qtd.")
        Cabecalho(y, COL_C, LAR_C, "Custo total")
        Cabecalho(y, COL_D, LAR_D + LAR_E, "Metal", TextAlignment.MiddleCenter)
        Cabecalho(y, COL_F, LAR_F, "M.O.")
        Cabecalho(y, COL_G, LAR_G, "Outros")
        Cabecalho(y, COL_H, LAR_H, "Pr. venda")
        ' "Markup" e não "Margem": a fórmula da planilha é Venda / Custo, que é múltiplo
        ' sobre o custo, não margem contábil.
        Cabecalho(y, COL_I, LAR_I, "Markup")
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "Ouro 18K (Au)")
        lblPvAuQtd = Celula(y, COL_B, LAR_B, FMT_N0)
        lblPvAuCusto = Celula(y, COL_C, LAR_C, FMT_DIN)
        lblPvAuGr = Celula(y, COL_D, LAR_D, FMT_GR)
        lblPvAuMetal = Celula(y, COL_E, LAR_E, FMT_DIN)
        lblPvAuMO = Celula(y, COL_F, LAR_F, FMT_DIN)
        lblPvAuOutros = Celula(y, COL_G, LAR_G, FMT_DIN)
        lblPvAuVenda = Celula(y, COL_H, LAR_H, FMT_DIN)
        lblPvAuMarkup = Celula(y, COL_I, LAR_I, FMT_MULT)
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "Prata 925 (Ag)")
        lblPvAgQtd = Celula(y, COL_B, LAR_B, FMT_N0)
        lblPvAgCusto = Celula(y, COL_C, LAR_C, FMT_DIN)
        lblPvAgGr = Celula(y, COL_D, LAR_D, FMT_GR)
        lblPvAgMetal = Celula(y, COL_E, LAR_E, FMT_DIN)
        lblPvAgMO = Celula(y, COL_F, LAR_F, FMT_DIN)
        lblPvAgOutros = Celula(y, COL_G, LAR_G, FMT_DIN)
        lblPvAgVenda = Celula(y, COL_H, LAR_H, FMT_DIN)
        lblPvAgMarkup = Celula(y, COL_I, LAR_I, FMT_MULT)
        y += ALT_LINHA

        If _mostrarBoutique Then
            Rotulo(y, COL_A, LAR_A, "Boutique")
            lblPvBouQtd = Celula(y, COL_B, LAR_B, FMT_N0)
            lblPvBouCusto = Celula(y, COL_C, LAR_C, FMT_DIN)
            lblPvBouGr = Celula(y, COL_D, LAR_D, FMT_GR)
            lblPvBouMetal = Celula(y, COL_E, LAR_E, FMT_DIN)
            lblPvBouMO = Celula(y, COL_F, LAR_F, FMT_DIN)
            lblPvBouOutros = Celula(y, COL_G, LAR_G, FMT_DIN)
            lblPvBouVenda = Celula(y, COL_H, LAR_H, FMT_DIN)
            lblPvBouMarkup = Celula(y, COL_I, LAR_I, FMT_MULT)
            y += ALT_LINHA
        End If

        Rotulo(y, COL_A, LAR_A, "TOTAL PEÇAS VENDIDAS", negrito:=True)
        lblPvTotQtd = Celula(y, COL_B, LAR_B, FMT_N0, negrito:=True)
        lblPvTotCusto = Celula(y, COL_C, LAR_C, FMT_DIN, negrito:=True)
        lblPvTotGr = Celula(y, COL_D, LAR_D, FMT_GR, negrito:=True)
        lblPvTotMetal = Celula(y, COL_E, LAR_E, FMT_DIN, negrito:=True)
        lblPvTotMO = Celula(y, COL_F, LAR_F, FMT_DIN, negrito:=True)
        lblPvTotOutros = Celula(y, COL_G, LAR_G, FMT_DIN, negrito:=True)
        lblPvTotVenda = Celula(y, COL_H, LAR_H, FMT_DIN, negrito:=True)
        lblPvTotMarkup = Celula(y, COL_I, LAR_I, FMT_MULT, negrito:=True)
        FundoTotal(y)

        Return y + ALT_LINHA + GAP
    End Function

    Private Function MontarSecao7PecasRegistradas(y As Single) As Single
        Faixa(y, "7. PEÇAS REGISTRADAS (ENTRADAS)")
        y += ALT_FAIXA

        Cabecalho(y, COL_A, LAR_A, "Origem / metal", TextAlignment.MiddleLeft)
        Cabecalho(y, COL_B, LAR_B, "Qtd.")
        Cabecalho(y, COL_C, LAR_C, "Custo")
        Cabecalho(y, COL_D, LAR_D + LAR_E, "Metal", TextAlignment.MiddleCenter)
        Cabecalho(y, COL_F, LAR_F, "Valor")
        Cabecalho(y, COL_G, LAR_G, "M.O.")
        Cabecalho(y, COL_H, LAR_H, "Custo - MO")
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "F.P. Ouro")
        lblPrFpAuQtd = Celula(y, COL_B, LAR_B, FMT_N0)
        lblPrFpAuCusto = Celula(y, COL_C, LAR_C, FMT_DIN)
        lblPrFpAuGr = Celula(y, COL_D, LAR_D, FMT_GR)
        lblPrFpAuMetal = Celula(y, COL_E, LAR_E, FMT_DIN)
        lblPrFpAuValor = Celula(y, COL_F, LAR_F, FMT_DIN)
        lblPrFpAuMO = Celula(y, COL_G, LAR_G, FMT_DIN)
        lblPrFpAuLiq = Celula(y, COL_H, LAR_H, FMT_DIN)
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "F.P. Prata")
        lblPrFpAgQtd = Celula(y, COL_B, LAR_B, FMT_N0)
        lblPrFpAgCusto = Celula(y, COL_C, LAR_C, FMT_DIN)
        lblPrFpAgGr = Celula(y, COL_D, LAR_D, FMT_GR)
        lblPrFpAgMetal = Celula(y, COL_E, LAR_E, FMT_DIN)
        lblPrFpAgValor = Celula(y, COL_F, LAR_F, FMT_DIN)
        lblPrFpAgMO = Celula(y, COL_G, LAR_G, FMT_DIN)
        lblPrFpAgLiq = Celula(y, COL_H, LAR_H, FMT_DIN)
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "F.F.")
        lblPrFfQtd = Celula(y, COL_B, LAR_B, FMT_N0)
        lblPrFfCusto = Celula(y, COL_C, LAR_C, FMT_DIN)
        lblPrFfGr = Celula(y, COL_D, LAR_D, FMT_GR)
        lblPrFfMetal = Celula(y, COL_E, LAR_E, FMT_DIN)
        lblPrFfValor = Celula(y, COL_F, LAR_F, FMT_DIN)
        lblPrFfMO = Celula(y, COL_G, LAR_G, FMT_DIN)
        lblPrFfLiq = Celula(y, COL_H, LAR_H, FMT_DIN)
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "TOTAL REGISTRADAS", negrito:=True)
        lblPrTotQtd = Celula(y, COL_B, LAR_B, FMT_N0, negrito:=True)
        lblPrTotCusto = Celula(y, COL_C, LAR_C, FMT_DIN, negrito:=True)
        lblPrTotGr = Celula(y, COL_D, LAR_D, FMT_GR, negrito:=True)
        lblPrTotMetal = Celula(y, COL_E, LAR_E, FMT_DIN, negrito:=True)
        lblPrTotValor = Celula(y, COL_F, LAR_F, FMT_DIN, negrito:=True)
        lblPrTotMO = Celula(y, COL_G, LAR_G, FMT_DIN, negrito:=True)
        lblPrTotLiq = Celula(y, COL_H, LAR_H, FMT_DIN, negrito:=True)
        FundoTotal(y)

        Return y + ALT_LINHA + GAP
    End Function

    Private Function MontarSecao8Saidas(y As Single) As Single
        Faixa(y, "8. SAÍDAS DO ESTOQUE")
        y += ALT_FAIXA

        Cabecalho(y, COL_A, LAR_A, String.Empty, TextAlignment.MiddleLeft)
        Cabecalho(y, COL_B, LAR_B, "Qtd.")
        Cabecalho(y, COL_C, LAR_C, "Custo")
        Cabecalho(y, COL_D, LAR_D, "Valor")
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "Saídas")
        lblSaiQtd = Celula(y, COL_B, LAR_B, FMT_N0)
        lblSaiCusto = Celula(y, COL_C, LAR_C, FMT_DIN)
        lblSaiValor = Celula(y, COL_D, LAR_D, FMT_DIN)

        Return y + ALT_LINHA + GAP
    End Function

    Private Function MontarSecao9Clientes(y As Single) As Single
        Faixa(y, "9. CLIENTES CADASTRADOS NO PERÍODO")
        y += ALT_FAIXA

        Rotulo(y, COL_A, LAR_A, "Clientes cadastrados")
        lblClientesCad = Celula(y, COL_B, LAR_B, FMT_N0)

        Return y + ALT_LINHA + GAP
    End Function

    Private Function MontarSecao10Estoque(y As Single) As Single
        ' O título recebe a data em runtime: o estoque é posição de HOJE e não respeita
        ' o período do filtro (mesma limitação do relatório antigo, que usa
        ' Resources\EmEstoque.txt, uma consulta sem parâmetro de data).
        lblEstTitulo = Faixa(y, "10. POSIÇÃO DE ESTOQUE")
        y += ALT_FAIXA

        Cabecalho(y, COL_A, LAR_A, "Metal", TextAlignment.MiddleLeft)
        Cabecalho(y, S10_QTD, S10_LAR_QTD, "Qtd.")
        Cabecalho(y, S10_PESO, S10_LAR_PESO, "Peso (g)")
        Cabecalho(y, S10_CUSTO, S10_LAR_CUSTO, "Custo")
        Cabecalho(y, S10_VENDA, S10_LAR_VENDA, "Venda")
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "Ouro (Au)")
        lblEstAuQtd = Celula(y, S10_QTD, S10_LAR_QTD, FMT_N0)
        lblEstAuPeso = Celula(y, S10_PESO, S10_LAR_PESO, FMT_N2)
        lblEstAuCusto = Celula(y, S10_CUSTO, S10_LAR_CUSTO, FMT_DIN)
        lblEstAuVenda = Celula(y, S10_VENDA, S10_LAR_VENDA, FMT_DIN)
        y += ALT_LINHA

        Rotulo(y, COL_A, LAR_A, "Prata (Ag)")
        lblEstAgQtd = Celula(y, S10_QTD, S10_LAR_QTD, FMT_N0)
        lblEstAgPeso = Celula(y, S10_PESO, S10_LAR_PESO, FMT_N2)
        lblEstAgCusto = Celula(y, S10_CUSTO, S10_LAR_CUSTO, FMT_DIN)
        lblEstAgVenda = Celula(y, S10_VENDA, S10_LAR_VENDA, FMT_DIN)
        y += ALT_LINHA

        If _mostrarBoutique Then
            Rotulo(y, COL_A, LAR_A, "Boutique")
            lblEstBouQtd = Celula(y, S10_QTD, S10_LAR_QTD, FMT_N0)
            lblEstBouPeso = Celula(y, S10_PESO, S10_LAR_PESO, FMT_N2)
            lblEstBouCusto = Celula(y, S10_CUSTO, S10_LAR_CUSTO, FMT_DIN)
            lblEstBouVenda = Celula(y, S10_VENDA, S10_LAR_VENDA, FMT_DIN)
            y += ALT_LINHA
        End If

        Rotulo(y, COL_A, LAR_A, "TOTAL", negrito:=True)
        lblEstTotQtd = Celula(y, S10_QTD, S10_LAR_QTD, FMT_N0, negrito:=True)
        lblEstTotPeso = Celula(y, S10_PESO, S10_LAR_PESO, FMT_N2, negrito:=True)
        lblEstTotCusto = Celula(y, S10_CUSTO, S10_LAR_CUSTO, FMT_DIN, negrito:=True)
        lblEstTotVenda = Celula(y, S10_VENDA, S10_LAR_VENDA, FMT_DIN, negrito:=True)
        FundoTotal(y)

        Return y + ALT_LINHA
    End Function

    Private Sub MontarRodapePagina(banda As PageFooterBand)
        Dim emissao = Novo(banda, 0.0F, 0.0F, LARGURA_UTIL / 2.0F, ALT_LINHA,
                           "Emitido em " & Now.ToString("dd/MM/yyyy HH:mm"),
                           New DXFont("Arial", 7.0F), TextAlignment.MiddleLeft)
        emissao.Borders = BorderSide.Top
        emissao.StylePriority.UseBorders = False

        ' Sem isto não se percebe quando o relatório estoura para a segunda página —
        ' risco real, porque o bloco de subrelatórios da seção 2 tem altura variável.
        Dim pagina As New XRPageInfo() With {
            .Dpi = 254.0F,
            .Name = "pageInfo",
            .PageInfo = DevExpress.XtraPrinting.PageInfo.NumberOfTotal,
            .TextFormatString = "Página {0} de {1}",
            .LocationFloat = New PointFloat(LARGURA_UTIL / 2.0F, 0.0F),
            .SizeF = New SizeF(LARGURA_UTIL / 2.0F, ALT_LINHA),
            .Font = New DXFont("Arial", 7.0F),
            .TextAlignment = TextAlignment.MiddleRight,
            .Borders = BorderSide.Top
        }
        banda.Controls.Add(pagina)
    End Sub

#End Region

End Class
