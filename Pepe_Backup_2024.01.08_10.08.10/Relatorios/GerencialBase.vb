Imports DevExpress.XtraEditors.Controls

Public Class GerencialBase
    Private Sub GerencialBase_Load(sender As Object, e As EventArgs) Handles Me.Load

        frmDevPrincipal.Visible = False

        Me.txtData1.EditValue = New DateTime(Today.Year, Today.Month, 1)
        If Today.Month < 12 Then
            Me.txtData2.EditValue = New DateTime(Today.Year, Today.Month + 1, 1).AddDays(-1)
        Else
            Me.txtData2.EditValue = New DateTime(Today.Year, 12, 31)
        End If

        btnOk2_ButtonClick(Nothing, Nothing)

    End Sub

    Private Sub VendasBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmDevPrincipal.Visible = True

    End Sub

    Private Sub btnOk2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnOk2.ButtonClick

        Dim report As New Gerencial

        report.SqlDataSource.Queries(0).Parameters(0).Value = Me.txtData1.EditValue
        report.SqlDataSource.Queries(0).Parameters(1).Value = Me.txtData2.EditValue
        'report.SqlDataSource.Fill()

        report.Período.Text = txtData1.Text & " a " & txtData2.Text

        Dim dt1 As Date = Me.txtData1.EditValue
        Dim dt2 As Date = Me.txtData2.EditValue

        Dim dc As New lqGerencialDataContext

        Dim query = (From tb In dc.GetTable(Of Vencto_Cartão)() Where (tb.Venda > 0 Or tb.IdConserto > 0 Or tb.IdCC > 0) And (tb.Pagto >= dt1 And tb.Pagto <= dt2) Select tb)
        Dim ent As Double = 0
        If query.Count > 0 Then
            ent = ConvertToDouble((From c In query Select c.VValor).Sum)
            report.txtEntCart.Text = FormatNumber(ent, 2)
        End If

        'ent = 0
        'Dim query1 = (From tb In dc.GetTable(Of VI_VENDAS)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 Select tb)
        'If query1.Count > 0 Then
        '    ent = ConvertToDouble((From c In query1 Select c.Deb).Sum)
        '    report.txtEntCart.Text = FormatNumber(ent + ConvertToDouble(report.txtEntCart.Text), 2)
        'End If

        'ent = 0
        'Dim query1 = (From tb In dc.GetTable(Of Vencto_Cartão)() Where tb.Pagto >= dt1 And tb.Pagto <= dt2 Select tb)
        'If query1.Count > 0 Then
        '    ent = ConvertToDouble((From c In query1 Select c.VValor).Sum)
        '    report.txtEntCart.Text = FormatNumber(ent + ConvertToDouble(report.txtEntCart.Text), 2)
        'End If

        ent = 0
        Dim query2 = (From tb In dc.GetTable(Of VI_VENDAS)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 Select tb)
        If query2.Count > 0 Then
            ent = ConvertToDouble((From c In query2 Select c.Real).Sum)
            report.txtEntCash.Text = FormatNumber(ent, 2)
        End If
        ent = 0
        Dim query2a = (From tb In dc.GetTable(Of VI_CONSERTOS)() Where tb.DT >= dt1 And tb.DT <= dt2 Select tb)
        If query2a.Count > 0 Then
            ent = ConvertToDouble((From c In query2a Select c.Real).Sum)
            report.txtEntCash.Text = FormatNumber(ent + ConvertToDouble(report.txtEntCash.Text), 2)
        End If
        ent = 0
        Dim query2aa = (From tb In dc.GetTable(Of VI_CC)() Where tb.Data >= dt1 And tb.Data <= dt2 And tb.Venda Is Nothing And (tb.IdConserto Is Nothing Or tb.IdConserto = 0) Select tb)
        If query2aa.Count > 0 Then
            ent = ConvertToDouble((From c In query2aa Select c.Real).Sum)
            report.txtEntCash.Text = FormatNumber(ent + ConvertToDouble(report.txtEntCash.Text), 2)
        End If

        ent = 0
        Dim query3 = (From tb In dc.GetTable(Of VI_VENDAS)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 Select tb)
        If query3.Count > 0 Then
            ent = ConvertToDouble((From c In query3 Select c.Dolar).Sum)
            report.txtEntDolar.Text = FormatNumber(ent, 2)
        End If
        ent = 0
        Dim query3a = (From tb In dc.GetTable(Of VI_CONSERTOS)() Where tb.DT >= dt1 And tb.DT <= dt2 Select tb)
        If query3a.Count > 0 Then
            ent = ConvertToDouble((From c In query3a Select c.Dolar).Sum)
            report.txtEntDolar.Text = FormatNumber(ent + ConvertToDouble(report.txtEntDolar.Text), 2)
        End If
        Dim query3aa = (From tb In dc.GetTable(Of VI_CC)() Where tb.Data >= dt1 And tb.Data <= dt2 And tb.Venda Is Nothing And (tb.IdConserto Is Nothing Or tb.IdConserto = 0) Select tb)
        If query3aa.Count > 0 Then
            ent = ConvertToDouble((From c In query3aa Select c.Dolar).Sum)
            report.txtEntDolar.Text = FormatNumber(ent + ConvertToDouble(report.txtEntDolar.Text), 2)
        End If

        ent = 0
        Dim query4 = (From tb In dc.GetTable(Of VI_VENDAS)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 Select tb)
        If query4.Count > 0 Then
            ent = ConvertToDouble((From c In query4 Select c.Ouro).Sum)
            report.txtEntOu.Text = FormatNumber(ent, 2)
        End If
        ent = 0
        Dim query4a = (From tb In dc.GetTable(Of VI_CONSERTOS)() Where tb.DT >= dt1 And tb.DT <= dt2 Select tb)
        If query4a.Count > 0 Then
            ent = ConvertToDouble((From c In query4a Select c.Ouro).Sum)
            report.txtEntOu.Text = FormatNumber(ent + ConvertToDouble(report.txtEntOu.Text), 2)
        End If
        Dim query4aa = (From tb In dc.GetTable(Of VI_CC)() Where tb.Data >= dt1 And tb.Data <= dt2 And tb.Venda Is Nothing And (tb.IdConserto Is Nothing Or tb.IdConserto = 0) Select tb)
        If query4aa.Count > 0 Then
            ent = ConvertToDouble((From c In query4aa Select c.Ouro).Sum)
            report.txtEntOu.Text = FormatNumber(ent + ConvertToDouble(report.txtEntOu.Text), 2)
        End If

        ent = 0
        Dim query6 = (From tb In dc.GetTable(Of VI_VENDAS)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 And tb.V = "Loja" Select tb)
        If query6.Count > 0 Then
            ent = ConvertToDouble((From c In query6 Select c.ValorFinal).Sum)
            report.T6.Text = FormatNumber(ent, 2)
        End If

        'ent = 0
        'Dim query7 = (From tb In dc.GetTable(Of VI_VENDAS)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 And tb.V = "P.T." Select tb)
        'If query7.Count > 0 Then
        '    ent = ConvertToDouble((From c In query7 Select c.ValorFinal).Sum)
        '    report.T7.Text = FormatNumber(ent, 2)
        'End If

        'ent = 0
        'Dim query8 = (From tb In dc.GetTable(Of VI_VENDAS)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 And tb.V = "Outros" Select tb)
        'If query8.Count > 0 Then
        '    ent = ConvertToDouble((From c In query8 Select c.ValorFinal).Sum)
        '    report.T8.Text = FormatNumber(ent, 2)
        'End If

        Dim rs As New ADODB.Recordset()
        Dim cnStr As String = strAdoConnection()
        Dim strSQL As String = "SELECT Sum([VENDAS DET].ValorVenda) AS W FROM [1TabPeças] INNER JOIN (VENDAS INNER JOIN [VENDAS DET] ON VENDAS.Id = [VENDAS DET].Venda) ON [1TabPeças].IDPeça = [VENDAS DET].Peça WHERE (((VENDAS.DataVenda) Between '" & dt1 & "' And '" & dt2 & "')) GROUP BY [1TabPeças].Oficial HAVING ((([1TabPeças].Oficial)=1))"
        rs.Open(strSQL, cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If rs.EOF Then
            report.txtW.Text = ""
        Else
            If rs("W").Value = 0 Then
                report.txtW.Text = ""
            Else
                report.txtW.Text = FormatNumber(rs("W").Value, 2)
            End If
        End If

        rs.Close()

        strSQL = "SELECT COUNT(Id) AS Qt, SUM(Custo) AS TotCusto, SUM(ValorSaida) AS TotValor FROM Saidas WHERE (DataSaida Between '" & dt1 & "' And '" & dt2 & "')"
        rs.Open(strSQL) ', cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            Dim x
            x = rs("Qt").Value
            If ConvertToDouble(x) > 0 Then report.saiQt.Text = rs("Qt").Value
            x = rs("TotCusto").Value
            If ConvertToDouble(x) > 0 Then report.saiCusto.Text = FormatNumber(rs("TotCusto").Value, 2)
            x = rs("TotValor").Value
            If ConvertToDouble(x) > 0 Then report.saiVal.Text = FormatNumber(rs("TotValor").Value, 2)
        End If
        rs.Close()

        report.TT2.Text = FormatNumber(ConvertToDouble(report.T6.Text) + ConvertToDouble(report.T7.Text) + ConvertToDouble(report.T8.Text), 2)

        If ConvertToDouble(report.TT2.Text) = 0 Then
            report.txtPercVendaLoja.Text = ""
            'report.txtPercVendaPT.Text = ""
            'report.txtPercVendaOutros.Text = ""
        Else
            report.txtPercVendaLoja.Text = FormatPercent(ConvertToDouble(report.T6.Text) / ConvertToDouble(report.TT2.Text))
            'report.txtPercVendaPT.Text = FormatPercent(ConvertToDouble(report.T7.Text) / ConvertToDouble(report.TT2.Text))
            'report.txtPercVendaOutros.Text = FormatPercent(ConvertToDouble(report.T8.Text) / ConvertToDouble(report.TT2.Text))
        End If
        'txtPercVendaW
        ent = 0
        Dim query35 = From tb In dc.GetTable(Of VI_W)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 Select tb
        If query35.Count > 0 Then
            ent = ConvertToDouble((From c In query35 Select c.ValorVenda).Sum)
            report.txtPercVendaW.Text = FormatPercent(ent / ConvertToDouble(report.TT2.Text))
        End If

        ent = 0
        Dim query9 = From tb In dc.GetTable(Of VI_CONSERTOS)() Where tb.DT >= dt1 And tb.DT <= dt2 Select tb
        If query9.Count > 0 Then
            ent = ConvertToDouble((From c In query9 Select c.Tot).Sum)
            report.txtConsertos.Text = FormatNumber(ent, 2)
        End If

        ent = 0
        Dim query10 = (From tb In dc.GetTable(Of VI_CONSERTOS)() Where tb.DT >= dt1 And tb.DT <= dt2 Select tb)
        If query10.Count > 0 Then
            ent = ConvertToDouble((From c In query10 Select c.Comis).Sum)
            report.txtCom.Text = FormatNumber(ent, 2)
        End If
        ent = 0
        Dim query11 = (From tb In dc.GetTable(Of VI_VENDAS)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 Select tb)
        If query11.Count > 0 Then
            ent = ConvertToDouble((From c In query11 Select c.Comissão).Sum)
            report.txtCom.Text = FormatNumber(ent + ConvertToDouble(report.txtCom.Text), 2)
        End If

        ent = 0
        Dim query12 = (From tb In dc.GetTable(Of VI_VENDIDAS)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 Select tb)
        If query12.Count > 0 Then
            ent = ConvertToDouble((From c In query12 Select c.Peça).Count)
            report.txtPV1.Text = FormatNumber(ent, 0)
        End If

        ent = 0
        Dim query13 = (From tb In dc.GetTable(Of VI_VENDIDAS)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 Select tb)
        If query13.Count > 0 Then
            ent = ConvertToDouble((From c In query13 Select c.Custo).Sum)
            report.txtPV2.Text = FormatNumber(ent, 2)
        End If

        ent = 0
        Dim query14 = (From tb In dc.GetTable(Of VI_PEÇAS)() Where tb.DataReg >= dt1 And tb.DataReg <= dt2 Select tb)
        If query14.Count > 0 Then
            ent = ConvertToDouble((From c In query14 Select c.IDPeça).Count)
            report.T9.Text = FormatNumber(ent, 0)
        End If

        ent = 0
        Dim query15 = (From tb In dc.GetTable(Of VI_PEÇAS)() Where tb.DataReg >= dt1 And tb.DataReg <= dt2 Select tb)
        If query15.Count > 0 Then
            ent = ConvertToDouble((From c In query15 Select c.Custo).Sum)
            report.T10.Text = FormatNumber(ent, 2)
        End If

        ent = 0
        Dim query16 = (From tb In dc.GetTable(Of VI_PEÇAS)() Where ((tb.DataReg >= dt1 And tb.DataReg <= dt2) And tb.Origem = "F.P.") Select tb)
        If query16.Count > 0 Then
            ent = ConvertToDouble((From c In query16 Select c.IDPeça).Count)
            report.T11.Text = FormatNumber(ent, 0)
        End If

        ent = 0
        Dim query17 = (From tb In dc.GetTable(Of VI_PEÇAS)() Where ((tb.DataReg >= dt1 And tb.DataReg <= dt2) And tb.Origem = "F.P.") Select tb)
        If query17.Count > 0 Then
            ent = ConvertToDouble((From c In query17 Select c.Custo).Sum)
            report.T12.Text = FormatNumber(ent, 2)
        End If

        ent = 0
        Dim query18 = (From tb In dc.GetTable(Of VI_PEÇAS)() Where ((tb.DataReg >= dt1 And tb.DataReg <= dt2) And tb.Origem <> "F.P.") Select tb)
        If query18.Count > 0 Then
            ent = ConvertToDouble((From c In query18 Select c.IDPeça).Count)
            report.T13.Text = FormatNumber(ent, 0)
        End If

        ent = 0
        Dim query19 = (From tb In dc.GetTable(Of VI_PEÇAS)() Where ((tb.DataReg >= dt1 And tb.DataReg <= dt2) And tb.Origem <> "F.P.") Select tb)
        If query19.Count > 0 Then
            ent = ConvertToDouble((From c In query19 Select c.Custo).Sum)
            report.T14.Text = FormatNumber(ent, 2)
        End If

        ent = 0
        Dim query20 = (From tb In dc.GetTable(Of VI_VENDIDAS)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 Select tb)
        If query20.Count > 0 Then
            ent = ConvertToDouble((From c In query20 Select c.ValorVenda).Sum)
            report.txtPV3.Text = FormatNumber(ent, 2)
        End If

        ent = 0
        Dim query21 = From tb In dc.GetTable(Of VI_CONSERTOS)() Where tb.DT >= dt1 And tb.DT <= dt2 Select tb
        If query21.Count > 0 Then
            ent = ConvertToDouble((From c In query21 Select c.Custo).Sum)
            report.txtConsertos2.Text = FormatNumber(ent, 2)
        End If

        report.txtPercConsertos.Text = FormatPercent(ConvertToDouble(report.txtConsertos2.Text) / ConvertToDouble(report.txtConsertos.Text))

        ent = 0
        Dim query22 = (From tb In dc.GetTable(Of VI_VENDAS)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 Select tb)
        If query22.Count > 0 Then
            ent = ConvertToDouble((From c In query22 Select c.ValorTransf).Sum)
            report.txtEntTransf.Text = FormatNumber(ent, 2)
        End If
        ent = 0
        Dim query22a = (From tb In dc.GetTable(Of VI_CONSERTOS)() Where tb.DT >= dt1 And tb.DT <= dt2 Select tb)
        If query22a.Count > 0 Then
            ent = ConvertToDouble((From c In query22a Select c.ValorTransfC).Sum)
            report.txtEntTransf.Text = FormatNumber(ent + ConvertToDouble(report.txtEntTransf.Text), 2)
        End If
        ent = 0
        Dim query22b = (From tb In dc.GetTable(Of VI_CC)() Where tb.Data >= dt1 And tb.Data <= dt2 And tb.Venda Is Nothing And (tb.IdConserto Is Nothing Or tb.IdConserto = 0) Select tb)
        If query22b.Count > 0 Then
            ent = ConvertToDouble((From c In query22b Select c.ValorTransf).Sum)
            report.txtEntTransf.Text = FormatNumber(ent + ConvertToDouble(report.txtEntTransf.Text), 2)
        End If

        'ent = 0
        'Dim query23 = (From tb In dc.GetTable(Of VI_VENDAS)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 Select tb)
        'If query23.Count > 0 Then
        '    ent = ConvertToDouble((From c In query23 Select c.valCC).Sum)
        '    report.txtEntDeb.Text = FormatNumber(ent, 2)
        'End If

        ent = 0
        Dim query23a = (From tb In dc.GetTable(Of VI_CONSERTOS)() Where tb.DT >= dt1 And tb.DT <= dt2 Select tb)
        If query23a.Count > 0 Then
            ent = ConvertToDouble((From c In query23a Select c.CCDeb).Sum)
            report.txtEntDeb.Text = FormatNumber(ent + ConvertToDouble(report.txtEntDeb.Text), 2)
        End If
        'ent = 0
        'Dim query23aa = (From tb In dc.GetTable(Of VI_CC)() Where tb.Data >= dt1 And tb.Data <= dt2 And tb.Venda Is Nothing And (tb.IdConserto Is Nothing Or tb.IdConserto = 0) Select tb)
        'If query23aa.Count > 0 Then
        '    ent = ConvertToDouble((From c In query23aa Select c.CCDeb).Sum)
        '    report.txtEntDeb.Text = FormatNumber(ent + ConvertToDouble(report.txtEntDeb.Text), 2)
        'End If
        ent = 0
        Dim query23aa = (From tb In dc.GetTable(Of VI_VENDAS)() Where tb.DataVenda >= dt1 And tb.DataVenda <= dt2 Select tb) 'And Not tb.Venda Is Nothing And (tb.IdConserto Is Nothing Or tb.IdConserto = 0) Select tb)
        If query23aa.Count > 0 Then
            ent = ConvertToDouble((From c In query23aa Select c.CCDeb).Sum)
            report.txtEntDeb.Text = FormatNumber(Math.Abs(ent) + ConvertToDouble(report.txtEntDeb.Text), 2)
        End If

        ent = 0
        Dim query24 = (From tb In dc.GetTable(Of VI_METAIS)() Where tb.DataReg >= dt1 And tb.DataReg <= dt2 Select tb)
        If query24.Count > 0 Then
            ent = ConvertToDouble((From c In query24 Select c.OT).Sum)
            report.T15.Text = FormatNumber(ent, 2)
        End If

        ent = 0
        Dim query25 = (From tb In dc.GetTable(Of VI_METAIS)() Where tb.DataReg >= dt1 And tb.DataReg <= dt2 Select tb)
        If query25.Count > 0 Then
            ent = ConvertToDouble((From c In query25 Select c.OV).Sum)
            report.T16.Text = FormatNumber(ent, 2)
        End If

        ent = 0
        Dim query26 = (From tb In dc.GetTable(Of VI_PEÇAS)() Where tb.DataReg >= dt1 And tb.DataReg <= dt2 Select tb)
        If query26.Count > 0 Then
            ent = ConvertToDouble((From c In query26 Select c.MO).Sum)
            report.T17.Text = FormatNumber(ent, 2)
        End If

        report.T18.Text = FormatNumber(ConvertToDouble(report.T10.Text) - (ConvertToDouble(report.T16.Text) + ConvertToDouble(report.T17.Text)), 2)

        ent = 0
        Dim query27 = (From tb In dc.GetTable(Of VI_METAIS)() Where ((tb.DataReg >= dt1 And tb.DataReg <= dt2) And tb.Origem = "F.P.") Select tb)
        If query27.Count > 0 Then
            ent = ConvertToDouble((From c In query27 Select c.OT).Sum)
            report.T19.Text = FormatNumber(ent, 2)
        End If

        ent = 0
        Dim query28 = (From tb In dc.GetTable(Of VI_METAIS)() Where ((tb.DataReg >= dt1 And tb.DataReg <= dt2) And tb.Origem = "F.P.") Select tb)
        If query28.Count > 0 Then
            ent = ConvertToDouble((From c In query28 Select c.OV).Sum)
            report.T20.Text = FormatNumber(ent, 2)
        End If

        ent = 0
        Dim query29 = (From tb In dc.GetTable(Of VI_PEÇAS)() Where ((tb.DataReg >= dt1 And tb.DataReg <= dt2) And tb.Origem = "F.P.") Select tb)
        If query29.Count > 0 Then
            ent = ConvertToDouble((From c In query29 Select c.MO).Sum)
            report.T21.Text = FormatNumber(ent, 2)
        End If

        report.T22.Text = FormatNumber(ConvertToDouble(report.T12.Text) - (ConvertToDouble(report.T20.Text) + ConvertToDouble(report.T21.Text)), 2)

        ent = 0
        Dim query30 = (From tb In dc.GetTable(Of VI_METAIS)() Where ((tb.DataReg >= dt1 And tb.DataReg <= dt2) And tb.Origem <> "F.P.") Select tb)
        If query30.Count > 0 Then
            ent = ConvertToDouble((From c In query30 Select c.OT).Sum)
            report.T23.Text = FormatNumber(ent, 2)
        End If

        ent = 0
        Dim query31 = (From tb In dc.GetTable(Of VI_METAIS)() Where ((tb.DataReg >= dt1 And tb.DataReg <= dt2) And tb.Origem <> "F.P.") Select tb)
        If query31.Count > 0 Then
            ent = ConvertToDouble((From c In query31 Select c.OV).Sum)
            report.T24.Text = FormatNumber(ent, 2)
        End If

        ent = 0
        Dim query32 = (From tb In dc.GetTable(Of VI_PEÇAS)() Where ((tb.DataReg >= dt1 And tb.DataReg <= dt2) And tb.Origem <> "F.P.") Select tb)
        If query32.Count > 0 Then
            ent = ConvertToDouble((From c In query32 Select c.MO).Sum)
            report.T25.Text = FormatNumber(ent, 2)
        End If

        report.T26.Text = FormatNumber(ConvertToDouble(report.T14.Text) - (ConvertToDouble(report.T24.Text) + ConvertToDouble(report.T25.Text)), 2)

        ent = 0
        Dim query5 = (From tb In dc.GetTable(Of Vencto_Cheques)() Where tb.Uso >= dt1 And tb.Uso <= dt2 And tb.Destino <> "Cancelado" Select tb)
        If query5.Count > 0 Then
            ent = ConvertToDouble((From c In query5 Select c.VValor).Sum)
        End If

        report.txtTT.Text = FormatNumber(ent + ConvertToDouble(report.txtEntCart.Text) + ConvertToDouble(report.txtEntCash.Text) + ConvertToDouble(report.txtEntDolar.Text) + ConvertToDouble(report.txtEntOu.Text) + ConvertToDouble(report.txtEntTransf.Text) + ConvertToDouble(report.txtEntDeb.Text), 2)
        report.GroupFooterBand1.Tag = ConvertToDouble(report.txtTT.Text)
        report.txtPercCheques.Text = FormatPercent(ent / ConvertToDouble(report.txtTT.Text))
        report.txtPercCart.Text = FormatPercent(ConvertToDouble(report.txtEntCart.Text) / ConvertToDouble(report.txtTT.Text))
        report.txtPercCash.Text = FormatPercent(ConvertToDouble(report.txtEntCash.Text) / ConvertToDouble(report.txtTT.Text))
        report.txtPercDolar.Text = FormatPercent(ConvertToDouble(report.txtEntDolar.Text) / ConvertToDouble(report.txtTT.Text))
        report.txtPercOu.Text = FormatPercent(ConvertToDouble(report.txtEntOu.Text) / ConvertToDouble(report.txtTT.Text))
        report.txtPercTransf.Text = FormatPercent(ConvertToDouble(report.txtEntTransf.Text) / ConvertToDouble(report.txtTT.Text))
        report.txtPercDeb.Text = FormatPercent(ConvertToDouble(report.txtEntDeb.Text) / ConvertToDouble(report.txtTT.Text))
        'End If

        If CDbl(report.T9.Text) > 0 Then report.txtPercFPQ.Text = FormatPercent(CDbl(report.T11.Text) / CDbl(report.T9.Text))
        If CDbl(report.T10.Text) > 0 Then report.txtPercFPC.Text = FormatPercent(CDbl(report.T12.Text) / CDbl(report.T10.Text))
        If CDbl(report.T9.Text) > 0 Then report.txtPercFFQ.Text = FormatPercent(CDbl(report.T13.Text) / CDbl(report.T9.Text))
        If CDbl(report.T10.Text) > 0 Then report.txtPercFFC.Text = FormatPercent(CDbl(report.T14.Text) / CDbl(report.T10.Text))

        If CDbl(report.T15.Text) > 0 Then report.txtPercFPOu1.Text = FormatPercent(CDbl(report.T19.Text) / CDbl(report.T15.Text))
        If CDbl(report.T16.Text) > 0 Then report.txtPercFPOu2.Text = FormatPercent(CDbl(report.T20.Text) / CDbl(report.T16.Text))
        If CDbl(report.T17.Text) > 0 Then report.txtPercFPMO.Text = FormatPercent(CDbl(report.T21.Text) / CDbl(report.T17.Text))
        If CDbl(report.T18.Text) > 0 Then report.txtPercFPOut.Text = FormatPercent(CDbl(report.T22.Text) / CDbl(report.T18.Text))

        If CDbl(report.T15.Text) > 0 Then report.txtPercFFOu1.Text = FormatPercent(CDbl(report.T23.Text) / CDbl(report.T15.Text))
        If CDbl(report.T16.Text) > 0 Then report.txtPercFFOu2.Text = FormatPercent(CDbl(report.T24.Text) / CDbl(report.T16.Text))
        If CDbl(report.T17.Text) > 0 Then report.txtPercFFMO.Text = FormatPercent(CDbl(report.T25.Text) / CDbl(report.T17.Text))
        If CDbl(report.T18.Text) > 0 Then report.txtPercFFOut.Text = FormatPercent(CDbl(report.T26.Text) / CDbl(report.T18.Text))

        ent = 0
        Dim query33 = (From tb In dc.GetTable(Of Clientes)() Where ((tb.DataCad >= dt1 And tb.DataCad <= dt2)) Select tb)
        If query33.Count > 0 Then
            ent = ConvertToDouble((From c In query33 Select c.IDCliente).Count)
            report.txtClientesCad.Text = FormatNumber(ent, 0)
        End If

        report.T26.Text = FormatNumber(ConvertToDouble(report.T14.Text) - (ConvertToDouble(report.T24.Text) + ConvertToDouble(report.T25.Text)), 2)

        report.XrLabel34.Text = report.txtEntTransf.Text
        report.XrLabel37.Text = report.txtPercTransf.Text

        Dim rs2 As New ADODB.Recordset()
        Dim strSQL2 As String = My.Resources.EmEstoque
        rs2.Open(strSQL2, cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs2.EOF Then
            report.txtEmEstoque.Text = rs2("Qtd").Value
            report.txtOuro.Text = FormatNumber(rs2("Au").Value, 2)
            report.txtCustoFinal.Text = FormatNumber(rs2("Custo").Value, 2)
            report.txtPrVenda.Text = FormatNumber(rs2("PrVenda").Value, 2)
        End If
        rs2.Close()

        Dim subreport As New GerencialSubFormas1
        subreport.SqlDataSource1.Queries(0).Parameters(0).Value = Me.txtData1.EditValue
        subreport.SqlDataSource1.Queries(0).Parameters(1).Value = Me.txtData2.EditValue
        subreport.SqlDataSource1.Fill()
        report.XrSubreport.ReportSource = subreport

        Dim subreport2 As New GerencialSubFormas2
        subreport2.SqlDataSource1.Queries(0).Parameters(0).Value = Me.txtData1.EditValue
        subreport2.SqlDataSource1.Queries(0).Parameters(1).Value = Me.txtData2.EditValue
        subreport2.SqlDataSource1.Fill()
        report.XrSubreport1.ReportSource = subreport2

        report.SqlDataSource.Fill()

        Me.DocumentViewer1.DocumentSource = report
        Me.DocumentViewer1.Visible = True
        report.CreateDocument(False)

    End Sub

End Class
