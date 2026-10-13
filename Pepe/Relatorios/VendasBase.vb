Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.Configuration
Imports DevExpress.XtraReports.UI

Public Class VendasBase

    Private Sub VendasBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmDevPrincipal.Visible = False
        Me.txtData1.EditValue = New DateTime(Today.Year, Today.Month, 1)
        'Me.txtData2.EditValue = New DateTime(Today.Year, Today.Month + 1, 1).AddDays(-1)
        If Today.Month < 12 Then
            Me.txtData2.EditValue = New DateTime(Today.Year, Today.Month + 1, 1).AddDays(-1)
        Else
            Me.txtData2.EditValue = New DateTime(Today.Year, 12, 31)
        End If

        'Me.btnOk2.PerformClick()
        btnOk2_ButtonClick(Nothing, Nothing)

    End Sub

    Private Sub btnOk2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnOk2.ButtonClick

        Dim report As New Vendas
        Dim rptSai As New VendasSaidas

        Dim dt1 As Date = Me.txtData1.EditValue
        Dim dt2 As Date = Me.txtData2.EditValue

        report.txtPeriodo.Tag = "0"

        ' Fichas clicáveis: o Tag leva "venda|ficha" (ou "lote da saída|ficha"), porque a ficha sozinha não é única.
        report.mModêlo.ExpressionBindings.Add(New ExpressionBinding("BeforePrint", "Tag", "ToStr([Id]) + '|' + [Classe] + [Modêlo]"))
        AddHandler report.mModêlo.PreviewClick, AddressOf FichaVenda_PreviewClick
        AddHandler report.mModêlo.PreviewMouseMove, AddressOf Ficha_PreviewMouseMove
        rptSai.XrLabel3.ExpressionBindings.Add(New ExpressionBinding("BeforePrint", "Tag", "ToStr([NumSaida]) + '|' + [Ficha]"))
        AddHandler rptSai.XrLabel3.PreviewClick, AddressOf FichaSaída_PreviewClick
        AddHandler rptSai.XrLabel3.PreviewMouseMove, AddressOf Ficha_PreviewMouseMove

        '---
        Dim formattedDt1 As Date = Me.txtData1.EditValue
        Dim formattedDt2 As Date = Me.txtData2.EditValue

        Dim d1 As String = formattedDt1.ToString("yyyy/MM/dd")
        Dim d2 As String = formattedDt2.ToString("yyyy/MM/dd")

        Dim rs As New ADODB.Recordset()
        Dim cnStr1 As String = strAdoConnection()
        Dim strSQL As String = ""

        strSQL = "select count(Id) as qt, SUM(ValorFinal) AS vval from Vendas where (DataVenda between '" & d1 & "' And '" & d2 & "')"
        rs.Open(strSQL, cnStr1, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            Dim x
            x = rs("vval").Value
            If ConvertToDouble(x) > 0 Then report.txtVendas.Text = rs("Qt").Value : report.txtTicket.Text = FormatNumber(rs("vval").Value / rs("Qt").Value, 2)
        End If
        rs.Close()
        '---

        Try
            Dim dc As New lqGerencialDataContext

            Dim ent As Double = 0
            Dim query9 = From tb In dc.GetTable(Of VI_CONSERTOS)() Where tb.DT >= dt1 And tb.DT <= dt2 Select tb
            If query9.Count > 0 Then
                ent = ConvertToDouble((From c In query9 Select c.Comis).Sum)
                report.D.Text = FormatNumber(ent, 2)
                report.txtPeriodo.Tag = report.D.Text
            End If

            report.SqlDataSource1.Queries(0).Parameters(0).Value = Me.txtData1.EditValue 'CInt(Nz(cboAno.Text, System.DateTime.Today.ToString("yyyy")))
            report.SqlDataSource1.Queries(0).Parameters(1).Value = Me.txtData2.EditValue
            report.txtPeriodo.Text = Me.txtData1.Text + " a " + Me.txtData2.Text
            report.SqlDataSource1.Fill()

            rptSai.SqlDataSource1.Queries(0).Parameters(0).Value = Me.txtData1.EditValue
            rptSai.SqlDataSource1.Queries(0).Parameters(1).Value = Me.txtData2.EditValue
            rptSai.SqlDataSource1.Fill()
            report.XrSubreport2.ReportSource = rptSai

            Dim sai As Double = 0
            Dim query10 = From tb In dc.GetTable(Of VI_SAIDAS)() Where tb.DataSaida >= dt1 And tb.DataSaida <= dt2 Select tb
            If query10.Count > 0 Then
                sai = ConvertToDouble((From d In query10 Select d.Custo).Sum)
                report.txtTC.Text = FormatNumber(sai, 2)
            End If

            Dim connectionString As String = ConfigurationManager.ConnectionStrings("Pepe.My.MySettings.Pepe_ConnString").ConnectionString
            Using connection As New SqlConnection(connectionString)
                ' Cria um comando para chamar a stored procedure
                Using cmd As New SqlCommand("USP_VENDAS_SAIDAS", connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@dt1", dt1)
                    cmd.Parameters.AddWithValue("@dt2", dt2)
                    Try
                        connection.Open()
                        Dim resultado As Object = cmd.ExecuteScalar()
                        If resultado IsNot Nothing AndAlso Not DBNull.Value.Equals(resultado) Then
                            report.txtTC.Text = Convert.ToDecimal(resultado + sai).ToString("N2")
                        End If

                    Catch ex As Exception
                        MessageBox.Show("Ocorreu um erro: " & ex.Message)
                    End Try
                End Using
            End Using

            Me.DocumentViewer1.DocumentSource = report
            Me.DocumentViewer1.Visible = True

            report.CreateDocument(False)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub FichaVenda_PreviewClick(sender As Object, e As PreviewMouseEventArgs)
        Dim id As Integer, ficha As String = ""
        If LerTagFicha(e.Brick.Value, id, ficha) Then AbrirCadastroPeça(IdPeçaDaVenda(id, ficha), Me)

    End Sub

    Private Sub FichaSaída_PreviewClick(sender As Object, e As PreviewMouseEventArgs)
        Dim id As Integer, ficha As String = ""
        If LerTagFicha(e.Brick.Value, id, ficha) Then AbrirCadastroPeça(IdPeçaDaSaída(id, ficha), Me)

    End Sub

    Private Sub Ficha_PreviewMouseMove(sender As Object, e As PreviewMouseEventArgs)
        e.PreviewControl.Cursor = Cursors.Hand

    End Sub

    Private Function LerTagFicha(tag As Object, ByRef id As Integer, ByRef ficha As String) As Boolean
        Dim partes = CStr(If(tag, "")).Split("|"c)
        If partes.Length <> 2 OrElse Not Integer.TryParse(partes(0), id) OrElse partes(1).Trim() = "" Then Return False
        ficha = partes(1)
        Return True

    End Function

    Private Sub VendasBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmDevPrincipal.Visible = True

    End Sub
End Class
