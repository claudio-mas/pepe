Imports System.Data.SqlClient
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit.Model
Imports DevExpress.XtraSpreadsheet

Public Class frmGetnet
    Private Sub btnImp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImp.ItemClick

        Dim connStr As String = My.Settings.Pepe_ConnString   ' conexão central (ver modConexao)

        ImportarPlanilhaGetNet(SpreadsheetControl, connStr)

        fExecutarText("INSERT INTO getnet ([Aut],[Produto],[DataVenda],[Vencto],[Parcela],[Parcelas],[Total],[Liquido]) SELECT getnet_temp.Aut, getnet_temp.Produto, getnet_temp.DataVenda, getnet_temp.Vencto, getnet_temp.Parcela, getnet_temp.Parcelas, getnet_temp.Total, getnet_temp.Liquido FROM getnet RIGHT OUTER JOIN getnet_temp ON getnet.Aut = getnet_temp.Aut AND getnet.Parcela = getnet_temp.Parcela WHERE (getnet.Aut IS NULL) AND (getnet.Parcela IS NULL)")
        Dim workbook As IWorkbook = Me.SpreadsheetControl.Document
        workbook.CreateNewDocument()

        Exit Sub

        fExecutarText("delete from getnet_temp")

        Try
            'Dim workbook As IWorkbook = Me.SpreadsheetControl.Document
            'Dim ws As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("Analitico")
            Dim ws As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("CARTÕES")

            Dim x As Integer = 0
            'Do While True
            '    'If ws.Cells(x, 10).Value.TextValue = "AUTORIZAÇÃO" Then
            '    If ws.Cells(x, 12).Value.TextValue <> "000000" Then
            '        x += 1
            '        Exit Do
            '    End If
            '    x += 1
            'Loop          

            Dim rs As New ADODB.Recordset()
            Dim cnStr As String = strAdoConnection()
            rs.Open("Select * From getnet_temp", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            For i As Integer = 8 To 910
                Me.Tag = i

                'If i = 14 Then Stop
                'If IsNumeric(ws.Cells(x, 10).Value.TextValue) Then
                Dim cel11 As String = ws.Cells(i, 11).Value.TextValue
                Dim cel3 As String = ws.Cells(i, 3).Value.TextValue
                Dim cel6 As String = ws.Cells(i, 6).Value.TextValue
                Dim cel9 As String = ws.Cells(i, 9).Value.TextValue
                Dim cel8 As String = ws.Cells(i, 8).Value.TextValue
                Dim cel15 As Double = ws.Cells(i, 15).Value.TextValue
                Dim cel17 As Double = ws.Cells(i, 17).Value.TextValue

                If ws.Cells(i, 11).Value.TextValue = "" Then Exit For
                If ws.Cells(i, 11).Value.TextValue <> "000000" Then
                    'If ws.Cells(x, 10).Value.TextValue = "066993" Then Stop
                    rs.AddNew()
                    rs("Aut").Value = ws.Cells(i, 11).Value.TextValue
                    rs("Produto").Value = ws.Cells(i, 3).Value.TextValue
                    If IsDate(ws.Cells(i, 6).Value.TextValue) Then rs("DataVenda").Value = Format(Convert.ToDateTime(ws.Cells(i, 6).Value.TextValue), "dd/MM/yyyy") 'Microsoft.VisualBasic.Left(ws.Cells(i, 6).Value.TextValue, 10)
                    If IsDate(ws.Cells(i, 9).Value.TextValue) Then rs("Vencto").Value = Format(Convert.ToDateTime(ws.Cells(i, 9).Value.TextValue), "dd/MM/yyyy") 'Convert.ToDateTime(Microsoft.VisualBasic.Left(ws.Cells(i, 9).Value.TextValue, 10))
                    'rs("Parcela").Value = ws.Cells(i, 7).Value.TextValue
                    rs("Parcelas").Value = ws.Cells(i, 8).Value.TextValue
                    If IsNumeric(ws.Cells(i, 15).Value) Then rs("Total").Value = ws.Cells(i, 15).Value
                    If IsNumeric(ws.Cells(i, 17).Value) Then rs("Liquido").Value = ws.Cells(i, 17).Value
                    rs.Update()
                    'Else
                    'Debug.Print(ws.Cells(x, 10).Value.ToString)
                End If
                x += 1
            Next
            rs.Close()


            XtraMessageBox.Show("Dados importados com sucesso!", "Getnet", MessageBoxButtons.OK)

            fExecutarText("INSERT INTO getnet ([Aut],[Produto],[DataVenda],[Vencto],[Parcela],[Parcelas],[Total],[Liquido]) SELECT getnet_temp.Aut, getnet_temp.Produto, getnet_temp.DataVenda, getnet_temp.Vencto, getnet_temp.Parcela, getnet_temp.Parcelas, getnet_temp.Total, getnet_temp.Liquido FROM getnet RIGHT OUTER JOIN getnet_temp ON getnet.Aut = getnet_temp.Aut AND getnet.Parcela = getnet_temp.Parcela WHERE (getnet.Aut IS NULL) AND (getnet.Parcela IS NULL)")

            workbook.CreateNewDocument()

            'Me.Close()

        Catch ex As Exception
            XtraMessageBox.Show("Primeiro selecione a planilha Getnet " & vbNewLine & Me.Tag.ToString(), "Erro", MessageBoxButtons.OK)
            'XtraMessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub frmGetnet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmDevPrincipal.Visible = True

    End Sub

    Private Sub frmGetnet_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmDevPrincipal.Visible = False

    End Sub

    Public Sub ImportarPlanilhaGetNet(spreadsheet As SpreadsheetControl, connectionString As String)

        Dim document As IWorkbook = spreadsheet.Document

        ' -------------------------------------------------------
        ' Localiza a aba CARTÕES
        ' -------------------------------------------------------
        Dim ws As Worksheet = Nothing
        For Each sheet As Worksheet In document.Worksheets
            If sheet.Name.Trim().ToUpper() = "DETALHADO" Then
                ws = sheet
                Exit For
            End If
        Next

        If ws Is Nothing Then
            MessageBox.Show("Aba 'Detalhado' não encontrada na planilha.", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' -------------------------------------------------------
        ' Conexão com o SQL Server
        ' -------------------------------------------------------
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Limpa a tabela antes de importar (opcional)
            Using cmdDel As New SqlCommand("DELETE FROM getnet_temp", conn)
                cmdDel.ExecuteNonQuery()
            End Using

            ' Monta o INSERT com os 23 campos
            Dim sql As String =
                "INSERT INTO getnet_temp " &
                "(Aut,Produto,DataVenda,Vencto,Parcela,Parcelas,Total,Liquido) VALUES (@cp11,@cp5,@cp14,@cp4,@parcela,@parcelas,@cp16/100,@cp9/100)"

            Using cmd As New SqlCommand(sql, conn)

                ' Adiciona o parâmetro para Parcela calculada
                cmd.Parameters.Add(New SqlParameter("@parcela", SqlDbType.Int))
                cmd.Parameters.Add(New SqlParameter("@parcelas", SqlDbType.Int))

                ' Pré-cria os parâmetros com os tipos corretos
                For i As Integer = 1 To 17
                    Dim paramType As SqlDbType = SqlDbType.NVarChar
                    Dim paramSize As Integer = 500

                    ' Colunas 14 e 4 são datas (DataVenda e Vencto)
                    If i = 4 OrElse i = 14 Then
                        paramType = SqlDbType.Date
                        paramSize = 0
                        ' Colunas 16 e 18 são money (Total e Liquidado)
                    ElseIf i = 16 Or i = 9 Then
                        paramType = SqlDbType.Money
                        paramSize = 0
                        ' Coluna 17 (Parcelas) é int
                        'ElseIf i = 17 Then
                        '    paramType = SqlDbType.NVarChar
                        '    paramSize = 0
                    End If

                    If paramSize > 0 Then
                        cmd.Parameters.Add(New SqlParameter("@cp" & i, paramType, paramSize))
                    Else
                        cmd.Parameters.Add(New SqlParameter("@cp" & i, paramType))
                    End If
                Next

                ' -------------------------------------------------------
                ' Percorre as linhas — dados começam na linha 8 (índice 7)
                ' Colunas A(0) até W(22) = 23 colunas
                ' -------------------------------------------------------
                Dim rowIndex As Integer = 8   ' linha 9, base-0

                Do While True
                    ' Verifica se a linha está vazia pela primeira coluna
                    Dim primeiraColuna As String =
                        ws.Cells(rowIndex, 0).DisplayText.Trim()

                    If String.IsNullOrEmpty(primeiraColuna) Then Exit Do

                    ' Preenche cada parâmetro com o valor da célula correspondente
                    For col As Integer = 0 To 16
                        Dim cell As Cell = ws.Cells(rowIndex, col)
                        Dim valor As String = cell.DisplayText.Trim()

                        ' Colunas 15 (cp16) e 8 (cp9) são valores monetários
                        If col = 15 OrElse col = 8 Then
                            ' Remove "R$", espaços e converte para formato SQL
                            Dim valorLimpo As String = valor.Replace("R$", "").Replace(" ", "").Replace(".", "").Replace(",", ".")
                            Dim valorDecimal As Decimal
                            If Decimal.TryParse(valorLimpo, valorDecimal) Then
                                cmd.Parameters("@cp" & (col + 1)).Value = valorDecimal
                            Else
                                cmd.Parameters("@cp" & (col + 1)).Value = DBNull.Value
                            End If
                            ' Para as colunas de data (4 e 14)
                        ElseIf col = 3 OrElse col = 13 Then
                            Dim valorData As DateTime
                            ' col 3 = cp4 (DataVenda), col 13 = cp14 (Vencto)
                            If col = 3 Then
                                ' cp4 é data
                                If DateTime.TryParse(valor, valorData) Then
                                    cmd.Parameters("@cp" & (col + 1)).Value = valorData
                                Else
                                    cmd.Parameters("@cp" & (col + 1)).Value = DBNull.Value
                                End If
                            ElseIf col = 13 Then
                                ' cp14 é data (Vencto)
                                If DateTime.TryParse(valor, valorData) Then
                                    cmd.Parameters("@cp" & (col + 1)).Value = valorData
                                Else
                                    cmd.Parameters("@cp" & (col + 1)).Value = DBNull.Value
                                End If
                            End If
                        Else
                            ' Outras colunas
                            If String.IsNullOrEmpty(valor) Then
                                cmd.Parameters("@cp" & (col + 1)).Value = DBNull.Value
                            Else
                                cmd.Parameters("@cp" & (col + 1)).Value = valor
                            End If
                        End If
                    Next col

                    ' -------------------------------------------------------
                    ' Calcula o número da Parcela a partir de DataVenda, Vencto e Parcelas
                    ' -------------------------------------------------------
                    Dim datVenda As DateTime = Nothing
                    Dim datVencto As DateTime = Nothing
                    Dim numParcelas As Integer = 0


                    ' Valida Aut
                    If cmd.Parameters("@cp11").Value IsNot DBNull.Value Then
                        If cmd.Parameters("@cp11").Value = "-" Then
                            rowIndex += 1
                            Continue Do
                        End If
                    Else
                        rowIndex += 1
                        Continue Do
                    End If
                    ' Valida DataVenda
                    If cmd.Parameters("@cp4").Value IsNot DBNull.Value Then
                        datVenda = CDate(cmd.Parameters("@cp4").Value)
                    Else
                        ' Pula para próxima linha se DataVenda está vazia
                        rowIndex += 1
                        Continue Do
                    End If

                    ' Valida Vencto
                    If cmd.Parameters("@cp14").Value IsNot DBNull.Value Then
                        datVencto = CDate(cmd.Parameters("@cp14").Value)
                    Else
                        ' Pula para próxima linha se Vencto está vazia
                        rowIndex += 1
                        Continue Do
                    End If

                    ' Valida Parcelas
                    If cmd.Parameters("@cp17").Value IsNot DBNull.Value Then
                        numParcelas = CInt(Microsoft.VisualBasic.Strings.Right$(cmd.Parameters("@cp17").Value, 2))
                    Else
                        rowIndex += 1
                        Continue Do
                    End If

                    ' Agora calcula com segurança
                    Dim diffMeses As Integer = ((datVencto.Year - datVenda.Year) * 12) + (datVencto.Month - datVenda.Month) + 1
                    Dim numParcela As Integer = CInt(Microsoft.VisualBasic.Strings.Left$(cmd.Parameters("@cp17").Value, 2)) 'Math.Min(Math.Max(diffMeses, 1), numParcelas)

                    cmd.Parameters("@parcela").Value = numParcela
                    cmd.Parameters("@parcelas").Value = numParcelas
                    cmd.ExecuteNonQuery()
                    rowIndex += 1
                Loop

            End Using

            'MessageBox.Show($"Importação concluída! {rowIndex - 7} registro(s) inserido(s).",
            '                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show($"Importação concluída!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Using

    End Sub

End Class