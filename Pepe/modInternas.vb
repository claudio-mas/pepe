Imports System.Globalization

Module modInternas
    Public var1 As Double = 0
    Public var2 As Double = 0
    Public varData As String = ""
    Public varData2 As String = ""
    Public varIdCon As Integer = 0
    Public NomeForm As String = ""
    Public varNew As Boolean = False
    Public valDolar As Double = 0
    Public valOuro As Double = 0
    ' R$ por grama de prata 925, valor final (sem fator de teor).
    Public valPrata As Double = 0

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

    Public Function ConvertToSafeDouble(valor As Object) As Double
        If valor Is Nothing Then Return 0

        Dim strValor As String = valor.ToString().Trim()

        ' Tenta converter usando a cultura padrão do sistema
        Dim resultado As Double
        If Double.TryParse(strValor, NumberStyles.Any, CultureInfo.CurrentCulture, resultado) Then
            Return resultado
        End If

        ' Tenta converter usando a cultura invariante (usa ponto como separador decimal)
        If Double.TryParse(strValor, NumberStyles.Any, CultureInfo.InvariantCulture, resultado) Then
            Return resultado
        End If

        ' Como último recurso, tenta converter substituindo vírgulas por pontos
        strValor = strValor.Replace(",", ".")
        If Double.TryParse(strValor, NumberStyles.Any, CultureInfo.InvariantCulture, resultado) Then
            Return resultado
        End If

        ' Valor inválido
        Return 0
    End Function

    Public Function FormatSafeNumber(valor As Double) As String
        Return valor.ToString("N2", CultureInfo.CreateSpecificCulture("pt-BR"))
    End Function

    Public Function ConvertToSafeDate(valor As Object, Optional dataPadrao As Date = Nothing) As Date
        If valor Is Nothing Then Return dataPadrao

        Dim strValor As String = valor.ToString().Trim()

        If strValor = "" Then Return dataPadrao

        Dim dataConvertida As Date

        ' 1. Tenta converter usando a cultura atual do sistema
        If Date.TryParse(strValor, CultureInfo.CurrentCulture, DateTimeStyles.None, dataConvertida) Then
            Return dataConvertida
        End If

        ' 2. Tenta converter usando a cultura invariante (en-US)
        If Date.TryParse(strValor, CultureInfo.InvariantCulture, DateTimeStyles.None, dataConvertida) Then
            Return dataConvertida
        End If

        ' 3. Tenta converter com formatos explícitos mais comuns (pt-BR e ISO)
        Dim formatos() As String = {
            "dd/MM/yyyy",
            "d/M/yyyy",
            "yyyy-MM-dd",
            "yyyy/MM/dd",
            "dd-MM-yyyy"
        }

        For Each formato In formatos
            If Date.TryParseExact(strValor, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, dataConvertida) Then
                Return dataConvertida
            End If
        Next

        ' 4. Falha na conversão: retorna data padrão
        Return dataPadrao
    End Function

End Module
