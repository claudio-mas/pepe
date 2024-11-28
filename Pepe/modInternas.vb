Module modInternas
    Public var1 As Double = 0
    Public var2 As Double = 0
    Public varData As String = ""
    Public varData2 As String = ""
    Public varIdCon As Integer = 0
    Public NomeForm As String = ""
    Public varNew As Boolean = False

    Public Function ConvertToDouble(ByRef value) As Double

        If Not IsNumeric(value) Then
            value = 0
        End If
        Return Convert.ToDouble(value)

    End Function

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

    'Public Function Nz(ByVal Value As String) As Double
    '    If Value Is Nothing OrElse IsDBNull(Value) Or Value = "" Then
    '        Return 0.0
    '    Else
    '        Return CDbl(Value)
    '    End If
    'End Function
    Public Function Nz(ByVal Value As String, ByVal Defaultt As String) As String
        If Value Is Nothing OrElse IsDBNull(Value) Or Value = "" Then
            Return Defaultt
        Else
            Return Value
        End If
    End Function

    Public Function Verifica_dia(dia, mes)
        Dim diasDoMes As Object

        dia = Val(dia)

        diasDoMes = {31, 28, 30, 30, 31, 30, 31, 30, 30, 31, 30, 31}

        If dia = 31 Then
            Verifica_dia = diasDoMes(mes - 1)
        Else
            Verifica_dia = dia
        End If

    End Function

    Public Function IsFormLoaded(formName As String) As Boolean
        For Each frm As Form In Application.OpenForms
            If frm.Name = formName Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function IsFormOpen(formName As String) As Boolean
        For Each frm As Form In Application.OpenForms
            If frm.Name = formName Then
                Return True
            End If
        Next
        Return False
    End Function

End Module
