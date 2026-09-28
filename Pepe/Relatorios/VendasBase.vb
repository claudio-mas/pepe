Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

''' <summary>
''' Relatório de Vendas (Relatorios\Vendas.rdlc). As Saídas do período, que eram o
''' subreport VendasSaidas, agora são a tabela tbSaidas do próprio .rdlc.
''' </summary>
Public Class VendasBase

    ' Consulta que era do subreport VendasSaidas (CustomSqlQuery1).
    Private Const SQL_SAIDAS As String =
        "select Saidas.NumSaida, Saidas.DataSaida, [1TabPeças].Classe + [1TabPeças].Modêlo AS Ficha, " &
        "       TiposSaidas.Motivo, Saidas.Observações, Saidas.Custo, Saidas.ValorSaida " &
        "  from dbo.Saidas Saidas " &
        "  left join dbo.TiposSaidas TiposSaidas on TiposSaidas.Id = Saidas.IdMotivo " &
        " inner join dbo.[1TabPeças] [1TabPeças] on [1TabPeças].IDPeça = Saidas.IdPeça " &
        " where Saidas.DataSaida Between @dt1 And @dt2 " &
        " order by Saidas.NumSaida"

    Private Sub VendasBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmDevPrincipal.Visible = False
        Me.txtData1.Value = New DateTime(Today.Year, Today.Month, 1)
        If Today.Month < 12 Then
            Me.txtData2.Value = New DateTime(Today.Year, Today.Month + 1, 1).AddDays(-1)
        Else
            Me.txtData2.Value = New DateTime(Today.Year, 12, 31)
        End If

        btnOk2_Click(Nothing, Nothing)

    End Sub

    Private Sub btnOk2_Click(sender As Object, e As EventArgs) Handles btnOk2.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            PrepararRelatorio(Me.ReportViewer1.LocalReport, Me.txtData1.Value.Date, Me.txtData2.Value.Date)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    ''' <summary>
    ''' Carrega a definição, os dados e os parâmetros do relatório de vendas do período.
    ''' Fica separado da tela para poder ser usado também para exportar (ex.: PDF) sem abrir o formulário.
    ''' </summary>
    Public Shared Sub PrepararRelatorio(relatorio As LocalReport, dt1 As Date, dt2 As Date)

        Dim connectionString As String = My.Settings.Pepe_ConnString
        Dim vendas As New DataTable("Vendas")
        Dim saidas As New DataTable("Saidas")
        Dim opVendas As String = "0"
        Dim ticketMedio As String = "0,00"
        Dim totalCustos As String = Nothing
        Dim consertos As String = Nothing
        Dim consertosValor As Double = 0

        Using cn As New SqlConnection(connectionString)
            cn.Open()

            ' Linhas do relatório (antes: SqlDataSource1 do XtraReport Vendas)
            Using cmd As New SqlCommand("USP_RPT_VENDAS", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 0
                cmd.Parameters.Add("@dt1", SqlDbType.DateTime).Value = dt1
                cmd.Parameters.Add("@dt2", SqlDbType.DateTime).Value = dt2
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(vendas)
                End Using
            End Using

            ' Saídas do período (antes: subreport VendasSaidas)
            Using cmd As New SqlCommand(SQL_SAIDAS, cn)
                cmd.CommandTimeout = 0
                cmd.Parameters.Add("@dt1", SqlDbType.DateTime).Value = dt1
                cmd.Parameters.Add("@dt2", SqlDbType.DateTime).Value = dt2
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(saidas)
                End Using
            End Using

            ' Op. Vendas / Ticket Médio
            Using cmd As New SqlCommand("select count(Id) as qt, SUM(ValorFinal) AS vval from Vendas where (DataVenda between @dt1 And @dt2)", cn)
                cmd.CommandTimeout = 0
                cmd.Parameters.Add("@dt1", SqlDbType.DateTime).Value = dt1
                cmd.Parameters.Add("@dt2", SqlDbType.DateTime).Value = dt2
                Using rd = cmd.ExecuteReader()
                    If rd.Read() Then
                        Dim vval = rd("vval")
                        If ConvertToDouble(vval) > 0 Then
                            opVendas = CStr(rd("qt"))
                            ticketMedio = FormatNumber(vval / rd("qt"), 2)
                        End If
                    End If
                End Using
            End Using
        End Using

        Dim dc As New lqGerencialDataContext

        ' Comissão de consertos (aparece no bloco "Int. Loja" e entra no Total)
        Dim query9 = From tb In dc.GetTable(Of VI_CONSERTOS)() Where tb.DT >= dt1 And tb.DT <= dt2 Select tb
        If query9.Count > 0 Then
            Dim ent As Double = ConvertToDouble((From c In query9 Select c.Comis).Sum)
            consertos = FormatNumber(ent, 2)
            consertosValor = Math.Round(ent, 2)
        End If

        ' Total Geral Custos = custo das saídas (VI_SAIDAS) + custo das peças vendidas (USP_VENDAS_SAIDAS)
        Dim sai As Double = 0
        Dim query10 = From tb In dc.GetTable(Of VI_SAIDAS)() Where tb.DataSaida >= dt1 And tb.DataSaida <= dt2 Select tb
        If query10.Count > 0 Then
            sai = ConvertToDouble((From d In query10 Select d.Custo).Sum)
            totalCustos = FormatNumber(sai, 2)
        End If

        Using connection As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("USP_VENDAS_SAIDAS", connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 0
                cmd.Parameters.AddWithValue("@dt1", dt1)
                cmd.Parameters.AddWithValue("@dt2", dt2)
                Try
                    connection.Open()
                    Dim resultado As Object = cmd.ExecuteScalar()
                    If resultado IsNot Nothing AndAlso Not DBNull.Value.Equals(resultado) Then
                        totalCustos = Convert.ToDecimal(resultado + sai).ToString("N2")
                    End If

                Catch ex As Exception
                    MessageBox.Show("Ocorreu um erro: " & ex.Message)
                End Try
            End Using
        End Using

        BaseRelatorio.CarregarDefinicao(relatorio, "Vendas.rdlc")
        relatorio.DataSources.Clear()
        relatorio.DataSources.Add(New ReportDataSource("Vendas", vendas))
        relatorio.DataSources.Add(New ReportDataSource("Saidas", saidas))
        relatorio.SetParameters({
            New ReportParameter("Periodo", dt1.ToString("dd/MM/yyyy") & " a " & dt2.ToString("dd/MM/yyyy")),
            New ReportParameter("Consertos", consertos),
            New ReportParameter("ConsertosValor", consertosValor.ToString(Globalization.CultureInfo.InvariantCulture)),
            New ReportParameter("OpVendas", opVendas),
            New ReportParameter("TicketMedio", ticketMedio),
            New ReportParameter("TotalCustos", totalCustos)
        })

    End Sub

    Private Sub VendasBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmDevPrincipal.Visible = True

    End Sub
End Class
