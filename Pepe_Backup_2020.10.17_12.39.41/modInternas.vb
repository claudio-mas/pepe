Module modInternas

    Public Function DLookUp(campo As String, tabela As String, filtro As String, sql As Integer) As String

        Dim rs As New ADODB.Recordset()
        Dim cnStr As String = strAdoConnection()
        Dim strSQL As String = "SELECT " & campo & " FROM " & tabela

        If sql = 1 Then strSQL = tabela

        If filtro <> "" Then strSQL = strSQL & " WHERE " & filtro

        rs.Open(strSQL, cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If rs.EOF Then
            DLookUp = ""
        Else
            If IsDBNull(rs(campo).Value) Then
                DLookUp = ""
            Else
                DLookUp = rs(campo).Value
            End If
        End If
        rs.Close()

    End Function

    Public Function Nz(ByVal Value As String) As Double
        If Value Is Nothing OrElse IsDBNull(Value) Or Value = "" Then
            Return 0.0
        Else
            Return CDbl(Value)
        End If
    End Function

End Module
