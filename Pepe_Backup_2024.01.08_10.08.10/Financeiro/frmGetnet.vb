Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors

Public Class frmGetnet
    Private Sub btnImp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImp.ItemClick

        fExecutarText("delete from getnet_temp")

        Try
            Dim workbook As IWorkbook = Me.SpreadsheetControl.Document
            Dim ws As DevExpress.Spreadsheet.Worksheet = workbook.Worksheets("Analitico")

            Dim x As Integer = 0
            Do While True
                If ws.Cells(x, 10).Value.TextValue = "AUTORIZAÇÃO" Then
                    x += 1
                    Exit Do
                End If
                x += 1
            Loop

            Dim rs As New ADODB.Recordset()
            Dim cnStr As String = strAdoConnection()
            rs.Open("Select * From getnet_temp", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            For i As Integer = 1 To 910
                If IsNumeric(ws.Cells(x, 10).Value.TextValue) Then
                    'If ws.Cells(x, 10).Value.TextValue = "066993" Then Stop
                    rs.AddNew()
                    rs("Aut").Value = ws.Cells(x, 10).Value.TextValue
                    rs("Produto").Value = ws.Cells(x, 4).Value.TextValue
                    rs("DataVenda").Value = ws.Cells(x, 13).Value.TextValue
                    rs("Vencto").Value = ws.Cells(x, 2).Value.TextValue
                    rs("Parcela").Value = ws.Cells(x, 7).Value.TextValue
                    rs("Parcelas").Value = ws.Cells(x, 8).Value.TextValue
                    rs("Total").Value = ws.Cells(x, 14).Value
                    rs("Liquido").Value = ws.Cells(x, 17).Value
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
            XtraMessageBox.Show("Primeiro selecione a planilha Getnet", "Getnet", MessageBoxButtons.OK)
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
End Class