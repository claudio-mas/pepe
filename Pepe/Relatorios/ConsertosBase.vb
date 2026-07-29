Imports DevExpress.CodeParser
Imports DevExpress.XtraEditors.Controls

Public Class ConsertosBase

    Private Sub btnOk2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnOk2.ButtonClick

        Dim report As New Consertos

        Dim formattedDt1 As Date = Me.txtData1.EditValue
        Dim formattedDt2 As Date = Me.txtData2.EditValue

        Dim dt1 As String = formattedDt1.ToString("yyyy/MM/dd")
        Dim dt2 As String = formattedDt2.ToString("yyyy/MM/dd")

        Dim rs As New ADODB.Recordset()
        Dim cnStr1 As String = strAdoConnection()
        Dim strSQL As String = ""

        strSQL = "select count(Id) as qt, SUM(VVALOR) AS vval from CONSERTOS where (DT between '" & dt1 & "' And '" & dt2 & "')"
        rs.Open(strSQL, cnStr1, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            Dim x
            x = rs("vval").Value
            If ConvertToDouble(x) > 0 Then report.txtConsertos.Text = rs("Qt").Value : report.txtTicket.Text = FormatNumber(rs("vval").Value / rs("Qt").Value, 2)
        End If
        rs.Close()

        Try
            report.SqlDataSource.Queries(0).Parameters(0).Value = Me.txtData1.EditValue 'CInt(Nz(cboAno.Text, System.DateTime.Today.ToString("yyyy")))
            report.SqlDataSource.Queries(0).Parameters(1).Value = Me.txtData2.EditValue
            report.SqlDataSource.Fill()
            report.Período.Text = txtData1.Text & " a " & txtData2.Text

            Me.DocumentViewer1.DocumentSource = report
            Me.DocumentViewer1.Visible = True

            report.CreateDocument(False)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub CartãoBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmDevPrincipal.Visible = False
        Me.txtData1.EditValue = New DateTime(Today.Year, Today.Month, 1)
        'Me.txtData2.EditValue = New DateTime(Today.Year, Today.Month + 1, 1).AddDays(-1)
        If Today.Month < 12 Then
            Me.txtData2.EditValue = New DateTime(Today.Year, Today.Month + 1, 1).AddDays(-1)
        Else
            Me.txtData2.EditValue = New DateTime(Today.Year, 12, 31)
        End If

        Dim report As New Consertos

        Dim formattedDt1 As Date = Me.txtData1.EditValue
        Dim formattedDt2 As Date = Me.txtData2.EditValue

        Dim dt1 As String = formattedDt1.ToString("yyyy/MM/dd")
        Dim dt2 As String = formattedDt2.ToString("yyyy/MM/dd")

        Dim rs As New ADODB.Recordset()
        Dim cnStr1 As String = strAdoConnection()
        Dim strSQL As String = ""

        strSQL = "select count(Id) as qt, SUM(VVALOR) AS vval from CONSERTOS where (DT between '" & dt1 & "' And '" & dt2 & "')"
        rs.Open(strSQL, cnStr1, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            Dim x
            x = rs("vval").Value
            If ConvertToDouble(x) > 0 Then report.txtConsertos.Text = rs("Qt").Value : report.txtTicket.Text = FormatNumber(rs("vval").Value / rs("Qt").Value, 2)
        End If
        rs.Close()

        Try

            report.SqlDataSource.Queries(0).Parameters(0).Value = Me.txtData1.EditValue 'CInt(Nz(cboAno.Text, System.DateTime.Today.ToString("yyyy")))
            report.SqlDataSource.Queries(0).Parameters(1).Value = Me.txtData2.EditValue
            report.SqlDataSource.Fill()
            report.Período.Text = txtData1.Text & " a " & txtData2.Text

            Me.DocumentViewer1.DocumentSource = report
            Me.DocumentViewer1.Visible = True

            report.CreateDocument(False)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub CartãoBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmDevPrincipal.Visible = True

    End Sub

    Private Sub ticket(report)

        Dim formattedDt1 As Date = Me.txtData1.EditValue
        Dim formattedDt2 As Date = Me.txtData2.EditValue

        Dim dt1 As String = formattedDt1.ToString("yyyy/MM/dd")
        Dim dt2 As String = formattedDt2.ToString("yyyy/MM/dd")

        Dim rs As New ADODB.Recordset()
        Dim cnStr1 As String = strAdoConnection()
        Dim strSQL As String = ""

        strSQL = "select count(Id) as qt from CONSERTOS where (DT between '" & dt1 & "' And '" & dt2 & "')"
        rs.Open(strSQL, cnStr1, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            Dim x
            x = rs("qt").Value
            If ConvertToDouble(x) > 0 Then report.txtConsertos.Text = rs("Qt").Value
        End If
        rs.Close()

    End Sub


End Class