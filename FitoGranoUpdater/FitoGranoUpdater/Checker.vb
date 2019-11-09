Imports Microsoft.Win32                 ' Для работы с реестром 
Imports DevExpress.LookAndFeel

Module Checker
    'Friend UpgradeStarterPath As String                                 ' Путь откуда копируются обновления
    ' Friend LastUpgrade As String                                        ' Дата и время последнего обновления Стартера (берется из БД настроек)
    'Friend UpgradeEvent As Boolean = True                               ' Состоялось или нет обновление стартера 
    'Friend IsFirstLoad As Boolean = False                               ' Первый запуск приложения
    Friend UpdatePath As String                                         ' Путь к каталогу с обновлениями
    'Friend FormsCount As Integer = 0                                    ' Кол-во запущенных форм с сообщениями
    Friend Disconnect As Integer = True                                 ' False - отсутствует подключение к каталогу
    Friend iLookAndFeel As New DefaultLookAndFeel

    Friend pref_RegistryPath As String = "Software\Microsoft\FitoGrano\"            ' Префикс пути в реестре к настройкам
    Friend pref_ComplexSettings As String = pref_RegistryPath & "ComplexSettings\"  ' Префикс пути в реестре к настройкам комплекса
    Friend pref_UserSettings As String = pref_RegistryPath & "UserSettings\"        ' Префикс пути в реестре к настройкам пользователя
#Region "Работа с реестром"
    ' Чтение из реестра
    Public Function RegistryRead(ByVal SectionName As String,
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
    Public Sub RegistryWrite(ByVal SectionName As String,
                             ByVal KeyName As String,
                             ByVal Value As String,
                             Optional ByVal DataType As RegistryValueKind = RegistryValueKind.String)
        ' Если ни раздела, ни ключа не существует, он будет создан
        My.Computer.Registry.CurrentUser.CreateSubKey(SectionName, False).SetValue(KeyName, Value, DataType) ' Записываем текст в раздел Test
    End Sub
    ' Создание раздела
    Public Sub RegistryCreateSection(ByVal SectionName As String)
        My.Computer.Registry.CurrentUser.CreateSubKey(SectionName, RegistryKeyPermissionCheck.ReadWriteSubTree) ' Создаем новый раздел в реестре с доступом на запись
    End Sub
    ' Удаление раздела
    Public Sub RegistryDeleteSection(ByVal SectionName As String)
        Try
            My.Computer.Registry.CurrentUser.DeleteSubKeyTree(SectionName) ' Удаляем раздел из реестра
        Catch e As Exception
            MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Удаление ключа из ветки реестра
    Public Function RegistryDeleteKey(ByVal SectionName As String, ByVal KeyName As String)
        Try
            My.Computer.Registry.CurrentUser.OpenSubKey(SectionName, True).DeleteValue(KeyName, True)
        Catch eX As Exception
            MessageBox.Show(eX.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#End Region
End Module
