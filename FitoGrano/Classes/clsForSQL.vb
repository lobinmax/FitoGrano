Public Class clsForSQL
    ' проверка передаваемых значений в базу
    Public Shared Function InDataBase(ByVal iValue As Object, Optional ByVal iDataType As String = "varchar") As String
        ' If IsNumeric(iValue) = False Then
        If iValue Is Nothing Then Return "NULL"
        If IsDBNull(iValue) Then Return "NULL"
        If iValue.ToString = "NULL" Then Return "NULL"
        If Trim(iValue) = "" Then Return "NULL"
        'End If
        If iDataType = "varchar" Then
            iValue = Replace(iValue, "'", "''")
            Return "'" & Trim(iValue) & "'"
        End If
        If iDataType = "int" Then Return Trim(iValue)
        If iDataType = "DateTime" Then
            Dim d As Date = iValue
            Return "'" & d.ToShortDateString & "'"
        End If
    End Function
    ' проверка значений из бызы
    Public Shared Function OutDataBase(ByVal iValue As Object)
        If IsDBNull(iValue) Then
            Return Nothing
        Else
            Return iValue
        End If
    End Function
    ' замена аппострофов
    Private Function CheckingApostrophe(ByVal iString As String) As String
        Dim iChar As String ' проверяемый символ
        Dim iText As String  ' проверяемый текст
        For i = 1 To iString.Length
            iChar = Microsoft.VisualBasic.Mid(iString, i, 1)
            If iChar = "'" Then
                iChar = "'''"
            End If
            iText &= iChar
        Next
        Return iText
    End Function



End Class
