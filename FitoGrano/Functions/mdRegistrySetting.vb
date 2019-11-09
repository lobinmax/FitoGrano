Imports DevExpress.XtraEditors
Imports Microsoft.Win32
' класс для работы с реестром (для настроек приложения)
Friend Module mdRegistrySetting
#Region "Работа с реестром"
    ' Чтение из реестра
    Public Function RegistryRead(ByVal SectionName As String,
                                 ByVal KeyName As String,
                                 Optional ByVal NothingValue As String = "",
                                 Optional ByVal NothingDataType As RegistryValueKind = RegistryValueKind.String)
        ' если раздела не существует, но нет ключа вернется значение по-умолчанию
        ' Проверка существования раздела
        Dim iSec As String = Registry.CurrentUser.CreateSubKey(SectionName).GetValue(KeyName, Nothing) ' Возвращаем значение из реестра
        If iSec = Nothing Then ' Если раздела и ключа не существует
            ' они будут созданы автоматически
            RegistryWrite(SectionName, KeyName, NothingValue, NothingDataType)
        End If
        ' если существуют, вернуться значения из реестра
        Return Registry.CurrentUser.CreateSubKey(SectionName).GetValue(KeyName, NothingValue)
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
            My.Computer.Registry.CurrentUser.DeleteSubKeyTree(SectionName, True) ' Удаляем раздел из реестра
        Catch e As Exception
            XtraMessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Удаление ключа из ветки реестра
    Public Function RegistryDeleteKey(ByVal SectionName As String, ByVal KeyName As String)
        Try
            My.Computer.Registry.CurrentUser.OpenSubKey(SectionName, True).DeleteValue(KeyName, True)
        Catch eX As Exception
            XtraMessageBox.Show(eX.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#End Region
End Module
