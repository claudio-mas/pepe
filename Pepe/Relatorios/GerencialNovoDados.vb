Imports System.Data.Linq.Mapping

''' <summary>
''' Acesso a dados do Relatório Gerencial novo.
'''
''' Estratégia: reusa o <c>lqGerencialDataContext</c> que já existe, SEM alterar o
''' lqGerencial.dbml — as métricas que o relatório antigo já calcula vêm das mesmas
''' entidades e das mesmas queries LINQ; as métricas novas (quebra por metal) vêm
''' das views VW_RG2_* via <c>ExecuteQuery(Of T)</c>, que parametriza de verdade
''' ({0} vira SqlParameter) em vez de concatenar datas em string.
'''
''' Critério de período: replica o do relatório antigo, <c>&gt;= dt1 And &lt;= dt2</c>.
''' Se algum dia as colunas de data passarem a ter hora, isso perde o último dia —
''' o BLOCO 5 de Scripts\RG2_v0_investigacao.sql mede se já é o caso.
''' </summary>
Public Class GerencialNovoDados

#Region "Estruturas de resultado"

    Public Class Cotacao
        Public Dolar As Double
        Public OuroFino As Double
        Public Ouro18k As Double
        Public Prata As Double
    End Class

    Public Class Entradas
        Public Cheques, CartaoDebito, CreditoVista, CreditoParcelado As Double
        Public Cash, Transferencias As Double
        Public ReadOnly Property Total As Double
            Get
                Return Cheques + CartaoDebito + CreditoVista + CreditoParcelado + Cash + Transferencias
            End Get
        End Property
    End Class

    Public Class MovimentoCC
        Public Debitos, Creditos As Double
        ' Debitos ja vem negativo (CCNovoGer.Saldo < 0), entao aqui e soma.
        Public ReadOnly Property Saldo As Double
            Get
                Return Creditos + Debitos
            End Get
        End Property
    End Class

    Public Class LinhaVenda
        Public Oper As Integer
        Public Valor As Double
    End Class

    Public Class Vendas
        Public Loja, LojaAu, LojaAg As New LinhaVenda()
        Public Enc, EncAu, EncAg As New LinhaVenda()
        Public Total As New LinhaVenda()
    End Class

    Public Class Consertos
        Public Oper As Integer
        Public Valor, Custo As Double
    End Class

    Public Class Comissoes
        Public Loja, Oficina As Double
        Public ReadOnly Property Total As Double
            Get
                Return Loja + Oficina
            End Get
        End Property
    End Class

    ''' <summary>Uma linha das seções 6, 7 e 10, por família de metal.</summary>
    Public Class LinhaMetal
        Public Familia As String
        Public Qtd As Integer
        Public Gramas As Double          ' peso do metal da propria familia
        Public GramasOuro As Double
        Public GramasPrata As Double
        Public Custo As Double           ' 1TabPecas.Custo (historico)
        Public ValorMetal As Double      ' METAIS.TotalValor (historico)
        Public MO As Double
        Public Outras As Double
        Public PrecoVenda As Double
    End Class

    Public Class Saidas
        Public Qtd As Integer
        Public Custo, Valor As Double
    End Class

    Public Class Dados
        Public Cot As New Cotacao()
        Public Ent As New Entradas()
        Public CC As New MovimentoCC()
        Public Vend As New Vendas()
        Public Cons As New Consertos()
        Public Com As New Comissoes()
        Public PecasVendidas As New List(Of LinhaMetal)()
        Public PecasRegFpAu As New LinhaMetal()
        Public PecasRegFpAg As New LinhaMetal()
        Public PecasRegFf As New LinhaMetal()
        Public Estoque As New List(Of LinhaMetal)()
        Public Sai As New Saidas()
        Public ClientesCadastrados As Integer
        Public TemBoutique As Boolean
    End Class

#End Region

#Region "POCOs de ExecuteQuery"

    Private Class RowCotacao
        Public Property ValDolar As Decimal?
        Public Property ValOuro As Decimal?
        Public Property ValPrata As Decimal?
    End Class

    Private Class RowVenda
        Public Property Linha As String
        Public Property Oper As Integer
        Public Property Valor As Double?
    End Class

    Private Class RowMetal
        Public Property Familia As String
        Public Property Qtd As Integer
        Public Property GramasOuro As Double?
        Public Property GramasPrata As Double?
        Public Property Custo As Double?
        Public Property ValorMetal As Double?
        Public Property MO As Double?
        Public Property Outras As Double?
        Public Property PrecoVenda As Double?
    End Class

    Private Class RowContagem
        Public Property Qt As Integer
    End Class

    Private Class RowSaidas
        Public Property Qt As Integer
        Public Property TotCusto As Double?
        Public Property TotValor As Double?
    End Class

#End Region

    Private Shared Function D(v As Double?) As Double
        Return If(v.HasValue, v.Value, 0.0R)
    End Function

    Private Shared Function D(v As Decimal?) As Double
        Return If(v.HasValue, CDbl(v.Value), 0.0R)
    End Function

    ''' <summary>Carrega tudo o que o relatório precisa para o período informado.</summary>
    Public Shared Function Carregar(dt1 As Date, dt2 As Date) As Dados
        Dim r As New Dados()
        Dim dc As New lqGerencialDataContext()

        CarregarCotacao(dc, dt2, r)
        CarregarEntradas(dc, dt1, dt2, r)
        CarregarContaCorrente(dc, r)
        CarregarVendas(dc, dt1, dt2, r)
        CarregarConsertos(dc, dt1, dt2, r)
        CarregarComissoes(dc, dt1, dt2, r)
        CarregarPecasVendidas(dc, dt1, dt2, r)
        CarregarPecasRegistradas(dc, dt1, dt2, r)
        CarregarSaidas(dc, dt1, dt2, r)
        CarregarClientes(dc, dt1, dt2, r)
        CarregarEstoque(dc, r)

        Return r
    End Function

#Region "Seção 1 - cotações"

    ''' <summary>
    ''' Lida por ExecuteQuery e não pelo dbml porque a entidade Cotação mapeada em
    ''' lqGerencial.dbml não tem ValPrata — e o dbml não pode ser alterado, já que é
    ''' compartilhado com o relatório antigo.
    ''' Critério idêntico ao de GerencialBase.vb:51, inclusive o desempate por Id.
    ''' </summary>
    Private Shared Sub CarregarCotacao(dc As lqGerencialDataContext, dt2 As Date, r As Dados)
        Const SQL As String =
            "SELECT TOP 1 ValDolar, ValOuro, ValPrata FROM dbo.[Cotação] " &
            "WHERE DataCot <= {0} ORDER BY DataCot DESC, Id DESC"

        Dim linha = dc.ExecuteQuery(Of RowCotacao)(SQL, dt2).FirstOrDefault()
        If linha Is Nothing Then
            ' Mesma degradação do relatório antigo, que assume 1 quando não há cotação.
            r.Cot.Dolar = 1 : r.Cot.OuroFino = 1 : r.Cot.Ouro18k = 1 : r.Cot.Prata = 1
            Return
        End If

        r.Cot.Dolar = D(linha.ValDolar)
        r.Cot.OuroFino = D(linha.ValOuro)
        r.Cot.Ouro18k = r.Cot.OuroFino * 0.75R      ' igual a GerencialBase.vb:253
        r.Cot.Prata = D(linha.ValPrata)
    End Sub

#End Region

#Region "Seção 2 - entradas e conta corrente"

    Private Shared Sub CarregarEntradas(dc As lqGerencialDataContext, dt1 As Date, dt2 As Date, r As Dados)
        ' Cheques: GerencialBase.vb:607
        r.Ent.Cheques = D((From t In dc.GetTable(Of Vencto_Cheques)()
                           Where t.Uso >= dt1 AndAlso t.Uso <= dt2 AndAlso t.Destino <> "Cancelado"
                           Select t.VValor).Sum())

        ' Cartões débito: GerencialBase.vb:143
        r.Ent.CartaoDebito = D((From t In dc.GetTable(Of VI_GER_DEB)()
                                Where t.Pagto >= dt1 AndAlso t.Pagto <= dt2
                                Select t.VValor).Sum())

        ' Crédito à vista / parcelado: GerencialBase.vb:149 e :169
        r.Ent.CreditoVista = D((From t In dc.GetTable(Of VI_GER_CRED)()
                                Where t.Pagto >= dt1 AndAlso t.Pagto <= dt2 AndAlso t.CondPag = "A vista"
                                Select t.VValor).Sum())

        r.Ent.CreditoParcelado = D((From t In dc.GetTable(Of VI_GER_CRED)()
                                    Where t.Pagto >= dt1 AndAlso t.Pagto <= dt2 AndAlso t.CondPag = "Parcelado"
                                    Select t.VValor).Sum())

        ' Cash e transferências somam três origens: vendas, consertos e lançamentos
        ' avulsos de conta corrente. O filtro do VI_CC (Venda nula e sem conserto)
        ' evita contar duas vezes o que já veio pelas outras duas.
        ' GerencialBase.vb:192-208 (cash) e :447-463 (transferências).
        r.Ent.Cash =
            D((From t In dc.GetTable(Of VI_VENDAS)()
               Where t.DataVenda >= dt1 AndAlso t.DataVenda <= dt2 Select t.Real).Sum()) +
            D((From t In dc.GetTable(Of VI_CONSERTOS)()
               Where t.DT >= dt1 AndAlso t.DT <= dt2 Select t.Real).Sum()) +
            D((From t In dc.GetTable(Of VI_CC)()
               Where t.Data >= dt1 AndAlso t.Data <= dt2 AndAlso t.Venda Is Nothing _
                     AndAlso (t.IdConserto Is Nothing OrElse t.IdConserto = 0)
               Select t.Real).Sum())

        r.Ent.Transferencias =
            D((From t In dc.GetTable(Of VI_VENDAS)()
               Where t.DataVenda >= dt1 AndAlso t.DataVenda <= dt2 Select t.ValorTransf).Sum()) +
            D((From t In dc.GetTable(Of VI_CONSERTOS)()
               Where t.DT >= dt1 AndAlso t.DT <= dt2 Select t.ValorTransfC).Sum()) +
            D((From t In dc.GetTable(Of VI_CC)()
               Where t.Data >= dt1 AndAlso t.Data <= dt2 AndAlso t.Venda Is Nothing _
                     AndAlso (t.IdConserto Is Nothing OrElse t.IdConserto = 0)
               Select t.ValorTransf).Sum())
    End Sub

    ''' <summary>
    ''' ATENÇÃO: CCNovoGer NÃO é filtrada por período, nem aqui nem no relatório antigo
    ''' (GerencialBase.vb:474 e :495). É o saldo consolidado ATUAL de conta corrente,
    ''' não a movimentação do período.
    ''' </summary>
    Private Shared Sub CarregarContaCorrente(dc As lqGerencialDataContext, r As Dados)
        r.CC.Debitos = D((From t In dc.GetTable(Of CCNovoGer)() Where t.Saldo < 0 Select t.Saldo).Sum())
        r.CC.Creditos = D((From t In dc.GetTable(Of CCNovoGer)() Where t.Saldo > 0 Select t.Saldo).Sum())
    End Sub

#End Region

#Region "Seção 3 - vendas por canal e metal"

    ''' <summary>
    ''' Canal = encomenda (1TabPeças.Oficial = 1, mesmo critério da view VI_W) contra o
    ''' complemento. NÃO é VI_VENDAS.V, que sai de VENDAS.Vendedora e é outro eixo.
    ''' Oper = COUNT(DISTINCT venda) em cada nível, então uma venda com peça de ouro e
    ''' de prata conta nas duas linhas e Au + Ag pode passar do pai.
    ''' </summary>
    Private Shared Sub CarregarVendas(dc As lqGerencialDataContext, dt1 As Date, dt2 As Date, r As Dados)
        Const SQL As String =
            "WITH b AS (SELECT * FROM dbo.VW_RG2_VENDAS_ITENS WHERE DataVenda >= {0} AND DataVenda <= {1}) " &
            "          SELECT 'LOJA'    AS Linha, COUNT(DISTINCT IdVenda) AS Oper, SUM(ValorItemLiquido) AS Valor FROM b WHERE Canal='LOJA' " &
            "UNION ALL SELECT 'LOJA_OU', COUNT(DISTINCT IdVenda), SUM(ValorItemLiquido) FROM b WHERE Canal='LOJA' AND Familia='Ou' " &
            "UNION ALL SELECT 'LOJA_AG', COUNT(DISTINCT IdVenda), SUM(ValorItemLiquido) FROM b WHERE Canal='LOJA' AND Familia='Ag' " &
            "UNION ALL SELECT 'ENC',     COUNT(DISTINCT IdVenda), SUM(ValorItemLiquido) FROM b WHERE Canal='ENC' " &
            "UNION ALL SELECT 'ENC_OU',  COUNT(DISTINCT IdVenda), SUM(ValorItemLiquido) FROM b WHERE Canal='ENC'  AND Familia='Ou' " &
            "UNION ALL SELECT 'ENC_AG',  COUNT(DISTINCT IdVenda), SUM(ValorItemLiquido) FROM b WHERE Canal='ENC'  AND Familia='Ag' " &
            "UNION ALL SELECT 'TOTAL',   COUNT(DISTINCT IdVenda), SUM(ValorItemLiquido) FROM b"

        For Each linha In dc.ExecuteQuery(Of RowVenda)(SQL, dt1, dt2)
            Dim alvo As LinhaVenda
            Select Case linha.Linha
                Case "LOJA" : alvo = r.Vend.Loja
                Case "LOJA_OU" : alvo = r.Vend.LojaAu
                Case "LOJA_AG" : alvo = r.Vend.LojaAg
                Case "ENC" : alvo = r.Vend.Enc
                Case "ENC_OU" : alvo = r.Vend.EncAu
                Case "ENC_AG" : alvo = r.Vend.EncAg
                Case "TOTAL" : alvo = r.Vend.Total
                Case Else : Continue For
            End Select
            alvo.Oper = linha.Oper
            alvo.Valor = D(linha.Valor)
        Next
    End Sub

#End Region

#Region "Seções 4 e 5 - consertos e comissões"

    Private Shared Sub CarregarConsertos(dc As lqGerencialDataContext, dt1 As Date, dt2 As Date, r As Dados)
        r.Cons.Valor = D((From t In dc.GetTable(Of VI_CONSERTOS)()
                          Where t.DT >= dt1 AndAlso t.DT <= dt2 Select t.Tot).Sum())
        r.Cons.Custo = D((From t In dc.GetTable(Of VI_CONSERTOS)()
                          Where t.DT >= dt1 AndAlso t.DT <= dt2 Select t.Custo).Sum())

        ' O relatório antigo conta direto na tabela CONSERTOS (GerencialBase.vb:315).
        Dim c = dc.ExecuteQuery(Of RowContagem)(
            "SELECT COUNT(ID) AS Qt FROM dbo.CONSERTOS WHERE DT >= {0} AND DT <= {1}", dt1, dt2).FirstOrDefault()
        r.Cons.Oper = If(c Is Nothing, 0, c.Qt)
    End Sub

    ''' <summary>
    ''' O relatório antigo soma as duas num rótulo só (txtCom, GerencialBase.vb:362-372).
    ''' Aqui ficam separadas: oficina = consertos, loja = vendas.
    ''' </summary>
    Private Shared Sub CarregarComissoes(dc As lqGerencialDataContext, dt1 As Date, dt2 As Date, r As Dados)
        r.Com.Oficina = D((From t In dc.GetTable(Of VI_CONSERTOS)()
                           Where t.DT >= dt1 AndAlso t.DT <= dt2 Select t.Comis).Sum())
        r.Com.Loja = D((From t In dc.GetTable(Of VI_VENDAS)()
                        Where t.DataVenda >= dt1 AndAlso t.DataVenda <= dt2 Select t.Comissão).Sum())
    End Sub

#End Region

#Region "Seções 6, 7 e 10 - quebra por metal"

    Private Shared Function Agrega(linha As RowMetal) As LinhaMetal
        Dim m As New LinhaMetal() With {
            .Familia = linha.Familia,
            .Qtd = linha.Qtd,
            .GramasOuro = D(linha.GramasOuro),
            .GramasPrata = D(linha.GramasPrata),
            .Custo = D(linha.Custo),
            .ValorMetal = D(linha.ValorMetal),
            .MO = D(linha.MO),
            .Outras = D(linha.Outras),
            .PrecoVenda = D(linha.PrecoVenda)
        }
        ' "Gramas" e o peso do metal da propria familia; para Bou nao ha metal proprio,
        ' entao mostra a soma dos dois.
        Select Case m.Familia
            Case "Ou" : m.Gramas = m.GramasOuro
            Case "Ag" : m.Gramas = m.GramasPrata
            Case Else : m.Gramas = m.GramasOuro + m.GramasPrata
        End Select
        Return m
    End Function

    Private Shared Sub CarregarPecasVendidas(dc As lqGerencialDataContext, dt1 As Date, dt2 As Date, r As Dados)
        Const SQL As String =
            "SELECT Familia, COUNT(*) AS Qtd, SUM(GramasOuro) AS GramasOuro, SUM(GramasPrata) AS GramasPrata, " &
            "       SUM(Custo) AS Custo, SUM(ValorMetal) AS ValorMetal, SUM(MO) AS MO, " &
            "       SUM(Outras) AS Outras, SUM(PrecoVenda) AS PrecoVenda " &
            "FROM   dbo.VW_RG2_PECAS_VENDIDAS WHERE DataVenda >= {0} AND DataVenda <= {1} " &
            "GROUP BY Familia"

        For Each linha In dc.ExecuteQuery(Of RowMetal)(SQL, dt1, dt2)
            r.PecasVendidas.Add(Agrega(linha))
        Next
        If r.PecasVendidas.Any(Function(x) x.Familia = "Bou") Then r.TemBoutique = True
    End Sub

    Private Shared Sub CarregarPecasRegistradas(dc As lqGerencialDataContext, dt1 As Date, dt2 As Date, r As Dados)
        ' Chave: 'FP_OU', 'FP_AG', 'FF'. F.F. junta todas as famílias.
        Const SQL As String =
            "SELECT CASE WHEN Origem = 'F.P.' THEN 'FP_' + Familia ELSE 'FF' END AS Familia, " &
            "       COUNT(*) AS Qtd, SUM(GramasOuro) AS GramasOuro, SUM(GramasPrata) AS GramasPrata, " &
            "       SUM(Custo) AS Custo, SUM(ValorMetal) AS ValorMetal, SUM(MO) AS MO, " &
            "       0 AS Outras, 0 AS PrecoVenda " &
            "FROM   dbo.VW_RG2_PECAS_REG WHERE DataReg >= {0} AND DataReg <= {1} " &
            "GROUP BY CASE WHEN Origem = 'F.P.' THEN 'FP_' + Familia ELSE 'FF' END"

        For Each linha In dc.ExecuteQuery(Of RowMetal)(SQL, dt1, dt2)
            Select Case linha.Familia
                Case "FP_Ou"
                    r.PecasRegFpAu = Agrega(linha) : r.PecasRegFpAu.Gramas = D(linha.GramasOuro)
                Case "FP_Ag"
                    r.PecasRegFpAg = Agrega(linha) : r.PecasRegFpAg.Gramas = D(linha.GramasPrata)
                Case "FF"
                    r.PecasRegFf = Agrega(linha)
                    r.PecasRegFf.Gramas = D(linha.GramasOuro) + D(linha.GramasPrata)
            End Select
        Next
    End Sub

    ''' <summary>
    ''' Posição de estoque de HOJE — a view não tem filtro de data, igual ao
    ''' Resources\EmEstoque.txt que o relatório antigo usa. Não respeita dt1/dt2.
    ''' </summary>
    Private Shared Sub CarregarEstoque(dc As lqGerencialDataContext, r As Dados)
        Const SQL As String =
            "SELECT Familia, COUNT(*) AS Qtd, SUM(GramasOuro) AS GramasOuro, SUM(GramasPrata) AS GramasPrata, " &
            "       SUM(Custo) AS Custo, 0 AS ValorMetal, 0 AS MO, 0 AS Outras, SUM(PrVenda) AS PrecoVenda " &
            "FROM   dbo.VW_RG2_ESTOQUE GROUP BY Familia"

        For Each linha In dc.ExecuteQuery(Of RowMetal)(SQL)
            r.Estoque.Add(Agrega(linha))
        Next
        If r.Estoque.Any(Function(x) x.Familia = "Bou") Then r.TemBoutique = True
    End Sub

#End Region

#Region "Seções 8 e 9 - saídas e clientes"

    Private Shared Sub CarregarSaidas(dc As lqGerencialDataContext, dt1 As Date, dt2 As Date, r As Dados)
        ' Mesma consulta de GerencialBase.vb:293, mas parametrizada em vez de
        ' concatenada, e sem passar por ADODB.
        Const SQL As String =
            "SELECT COUNT(Id) AS Qt, SUM(Custo) AS TotCusto, SUM(ValorSaida) AS TotValor " &
            "FROM dbo.Saidas WHERE DataSaida >= {0} AND DataSaida <= {1}"

        Dim linha = dc.ExecuteQuery(Of RowSaidas)(SQL, dt1, dt2).FirstOrDefault()
        If linha Is Nothing Then Return
        r.Sai.Qtd = linha.Qt
        r.Sai.Custo = D(linha.TotCusto)
        r.Sai.Valor = D(linha.TotValor)
    End Sub

    Private Shared Sub CarregarClientes(dc As lqGerencialDataContext, dt1 As Date, dt2 As Date, r As Dados)
        r.ClientesCadastrados = (From t In dc.GetTable(Of Clientes)()
                                 Where t.DataCad >= dt1 AndAlso t.DataCad <= dt2
                                 Select t.IDCliente).Count()
    End Sub

#End Region

End Class
