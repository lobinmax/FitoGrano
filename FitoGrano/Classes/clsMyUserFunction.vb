Imports System.Data

Public Class clsMyUserFunction
    ' Инвертация логических значений
    Shared Function InvertBoolean(ByVal _value As Boolean) As Boolean
        If _value = False Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Очистка содержимого не нужных таблиц в DataSet принадлежащих указанной форме
    ' _Me - форма в которой были созданы таблицы
    Shared Sub RemoveTableDataSet(ByVal _Me As Object)
        ' Края вхождения строки
        Dim lStrNum As Integer = 0
        Dim rStrNum As Integer = _Me.Name.Length
        Dim s As String
        Dim iName As New List(Of String)

        EventChangedControl = False
        iDataSet.Relations.Clear()      ' удаление отношений
        For t = 0 To iDataSet.Tables.Count - 1
            If iDataSet.Tables.Contains(iDataSet.Tables(t).TableName) Then
                lStrNum = InStr(iDataSet.Tables(t).TableName.ToString, _Me.Name)
                If lStrNum <> 0 Then
                    s = Mid(iDataSet.Tables(t).TableName.ToString, lStrNum, rStrNum)
                    If s = _Me.Name.ToString Then
                        ' запись в коллекцию имени таблиц к удалени
                        iName.Add(iDataSet.Tables(t).TableName.ToString)
                        Console.WriteLine(iDataSet.Tables(t).TableName.ToString & " -к удалению")
                    End If
                End If
            End If
        Next
        ' удаление таблиц по коллекции
        For Each n As String In iName
            iDataSet.Tables.Remove(n)
        Next
        Console.WriteLine(iDataSet.Tables.Count)
        For Each t As DataTable In iDataSet.Tables
            Console.WriteLine("Осталась - " & t.TableName)
        Next
        _Me.Dispose()
        EventChangedControl = True
    End Sub

    ' Сортировка таблица в Dataset
    Shared Function SortDataTable(ByRef _DataTable As DataTable, ByVal _ColumnName As String, Optional _Sorting As String = "ASC") As DataTable
        Dim tablecopy As New DataTable
        tablecopy = _DataTable.Copy
        _DataTable.Clear()
        Dim foundRows() As DataRow
        foundRows = tablecopy.Select("", _ColumnName & " " & _Sorting)

        For Each dbrow As DataRow In foundRows
            _DataTable.ImportRow(dbrow)
        Next
        tablecopy.Clear()
        Return _DataTable
    End Function

#Region "Получение сохранение параметров форм (размер и положение)"
    Shared Sub LoadViewForm(ByVal _Me As Object)
        Dim PreferenceForms As String = pref_UserSettings & "\" & _Me.Name & "\"
        ' Размер
        Dim SizeHeight As Integer = RegistryRead(PreferenceForms, "Size.Height", 0)
        Dim SizeWidth As Integer = RegistryRead(PreferenceForms, "Size.Width", 0)
        ' Положение
        Dim LocationX As Integer = RegistryRead(PreferenceForms, "Location.X", 0)
        Dim LocationY As Integer = RegistryRead(PreferenceForms, "Location.Y", 0)

        If SizeHeight <> 0 Or SizeWidth <> 0 Then _Me.Size = New System.Drawing.Point(SizeWidth, SizeHeight)
        If LocationX <> 0 Or LocationY <> 0 Then _Me.StartPosition = FormStartPosition.Manual : _Me.Location = New System.Drawing.Point(LocationX, LocationY)
    End Sub
    Shared Sub SaveViewForm(ByVal _Me As Object)
        Dim PreferenceForms As String = pref_UserSettings & "\" & _Me.Name & "\"
        ' Размер
        RegistryWrite(PreferenceForms, "Size.Height", _Me.Size.Height)
        RegistryWrite(PreferenceForms, "Size.Width", _Me.Size.Width)
        ' Положение
        RegistryWrite(PreferenceForms, "Location.X", _Me.Location.X)
        RegistryWrite(PreferenceForms, "Location.Y", _Me.Location.Y)
        _Me.Dispose()
    End Sub
#End Region
End Class
