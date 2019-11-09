'Imports System.Data.OleDb
'Imports System.Data.SqlClient
'Imports System.Data
Imports Microsoft.Win32                 ' Для работы с реестром
Imports DevExpress.LookAndFeel

Public Module clsINI
    Friend pref_RegistryPath As String = "Software\Microsoft\FitoGrano\"                 ' Префикс пути в реестре к настройкам
    Friend pref_ComplexSettings As String = pref_RegistryPath & "ComplexSettings\"  ' Префикс пути в реестре к настройкам комплекса
    Friend iLookAndFeel As New DefaultLookAndFeel
#Region "Обработка файлов INI"
    ' Диклорирование API функций для чтения ini - файлов
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, _
                                                                                                          ByVal lpKeyName As String, _
                                                                                                          ByVal lpString As String, _
                                                                                                          ByVal lpFileName As String) As Integer
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, _
                                                                                                      ByVal lpKeyName As String, _
                                                                                                      ByVal lpDefault As String, _
                                                                                                      ByVal lpReturnedString As String, _
                                                                                                      ByVal nSize As Integer, _
                                                                                                      ByVal lpFileName As String) As Integer
    ' Чтение ini
    Public Function ReedIni(ByVal Section As String, ByVal Param As String, ByVal PathIni As String) As String
        Dim rc As String = Strings.StrDup(255, vbNullChar)
        Dim x As Integer = GetPrivateProfileString(Section, Param, "", rc, 255, PathIni)
        If x <> 0 Then rc = Strings.Left(rc, x)
        Return rc
    End Function
    ' Запись ini
    Public Function WriteIni(ByVal Section As String, ByVal Param As String, ByVal Obj As String, ByVal PathIni As String)
        Call WritePrivateProfileString(Section, Param, Obj, PathIni)
        Return 0
    End Function
#End Region

#Region "Резервный код для работы с Access"
    ' Переменные для локальной базы данных с настройками
    ' Public Conn_Ce As New OleDbConnection                   ' Подключение к локальной БД с настройками
    ' Public SqlCom_Ce As New OleDbCommand                    ' Переменная для Sql запросов локальной БД с настройками
    ' Public iDataAdapter_Ce As New OleDbDataAdapter          ' Адаптер БД с настройками для заполнения таблицы после запроса
    ' Public iDataSet_Ce As New DataSet                       ' Таблица для хранения результатов запроса из БД с настройками

    ' Универсальная процедура с входными параметрами для выборки из локальной базы настроек
    ' iTableName_Ce - Имя создаваемой таблицы в iDataSet
    ' iCommandText_Ce - Текст команды
    ' iName_Ce - Имя дочерней процедуры
    ' Public Sub SelectQueryData_Ce(ByVal iTableName_Ce As String, ByVal iCommandText_Ce As String, Optional ByVal iName_Ce As String = "")
    ' Путь к базе данных настроек программы
    '  Conn_Ce.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
    ' "Data Source=" & Application.StartupPath & "\UserSettings_BD.accdb;" & _
    ' "Jet OLEDB:Database Password=mysterious;"

    ' If Conn_Ce.State = ConnectionState.Closed Then Conn_Ce.Open() ' Открываем соединение

    ' Try ' Настраиваем команду SQL
    ' With SqlCom_Ce
    ' Если таблица iTableName существует то, очищае ее
    ' If iDataSet_Ce.Tables.Contains(iTableName_Ce) Then iDataSet_Ce.Tables(iTableName_Ce).Clear()
    ' SqlCom_Ce.Connection = Conn_Ce                    ' Указываем подключение                                
    ' SqlCom_Ce.CommandText = iCommandText_Ce           ' Указываем текст запроса
    ' End With

    ' Настраиваем Адаптер
    ' With iDataAdapter_Ce
    ' .SelectCommand = SqlCom_Ce              ' Указываем команду на выгрузку данных из базы
    ' .Fill(iDataSet_Ce, iTableName_Ce)       ' Выгруженные данные заливаем в DateSet и именуем 
    ' End With
    ' ======================================================================================================

    ' iDataAdapter_Ce.Dispose()      ' Освобождаем ресурсы от DataAdapter
    ' iDataSet_Ce.Dispose()          ' Освобождаем ресурсы от DataSet
    ' Conn_Ce.Close()                ' Закрываем соединение

    ' Если ошибка #5, значит привязка к DateSet_Ce уже определена
    ' Catch When Err.Number = 5
    ' iDataAdapter_Ce.Update(iDataSet_Ce, iTableName_Ce)       ' Значит просто обновляем таблицу

    ' Сообщение при неудачном подключении к базе данных настроек
    ' Catch ex As Exception
    ' MsgBox(ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical & Chr(10) & _
    ' "Ошибка вызова прощедуры: " & iName_Ce, Application.ProductName)
    ' Conn_Ce.Close()
    ' End Try
    ' End Sub

    ' Универсальная процедура с входными параметрами для выборки из бызы
    ' iCommandText - текст команды
    ' iName - Имя дочерней процедуры
    ' Public Function InsertUpdateDeleteQueryData_Ce(ByVal iCommandText_Ce As String, Optional ByVal iName_Ce As String = "")
    ' Try ' Попытка обновления данных
    ' Conn_Ce.Open()                                     ' Открываем соединение
    ' SqlCom_Ce.CommandText = iCommandText_Ce            ' Запись текста команды
    ' SqlCom_Ce.ExecuteNonQuery()                        ' Выполнение команды на сервер
    ' Conn_Ce.Close()                                    ' Закрываем соединение
    ' Return True
    ' Сообщение при неудачном подключении к базе данных
    ' Catch ex As Exception
    ' Сообщение при неудачном подключении к базе данных
    ' MsgBox(ex.Message & Chr(10) & _
    ' "Ошибка вызова прощедуры: " & iName_Ce, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, Application.ProductName)
    ' Conn_Ce.Close()
    ' Return False
    ' End Try
    ' End Function
#End Region

#Region "Работа с реестром"
    ' Чтение из реестра
    Friend Function RegistryRead(ByVal SectionName As String,
                                 ByVal KeyName As String,
                                 Optional ByVal NothingValue As String = "",
                                 Optional ByVal NothingDataType As RegistryValueKind = RegistryValueKind.String)
        ' если раздела не существует, но нет ключа вернется значение по-умолчанию
        ' Проверка существования раздела
        Dim iSec As String = Registry.CurrentUser.CreateSubKey(SectionName).GetValue(KeyName, NothingValue) ' Возвращаем значение из реестра
        If iSec = Nothing Then ' Если раздела и ключа не существует
            ' они будут созданы автоматически
            RegistryWrite(SectionName, KeyName, NothingValue, NothingDataType)
        Else
            ' если существуют, вернуться значения из реестра
            Return Registry.CurrentUser.CreateSubKey(SectionName).GetValue(KeyName, NothingValue)
        End If
    End Function
    ' Запись в реестр
    Friend Sub RegistryWrite(ByVal SectionName As String,
                             ByVal KeyName As String,
                             ByVal Value As String,
                             Optional ByVal DataType As RegistryValueKind = RegistryValueKind.String)
        ' Если ни раздела, ни ключа не существует, он будет создан
        My.Computer.Registry.CurrentUser.CreateSubKey(SectionName, False).SetValue(KeyName, Value, DataType) ' Записываем текст в раздел Test
    End Sub
    ' Создание раздела
    Friend Sub RegistryCreateSection(ByVal SectionName As String)
        My.Computer.Registry.CurrentUser.CreateSubKey(SectionName, RegistryKeyPermissionCheck.ReadWriteSubTree) ' Создаем новый раздел в реестре с доступом на запись
    End Sub
    ' Удаление раздела
    Friend Sub RegistryDeleteSection(ByVal SectionName As String)
        Try
            My.Computer.Registry.CurrentUser.DeleteSubKeyTree(SectionName, True) ' Удаляем раздел из реестра
        Catch e As Exception
            MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Удаление ключа из ветки реестра
    Friend Function RegistryDaleteKey(ByVal SectionName As String, ByVal KeyName As String)
        Try
            My.Computer.Registry.CurrentUser.OpenSubKey(SectionName, True).DeleteValue(KeyName, True)
        Catch eX As Exception
            MessageBox.Show(eX.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#End Region
End Module
