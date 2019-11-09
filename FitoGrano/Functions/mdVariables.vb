Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Animation

Module mdVariables
    ' модуль для складирования переменных
    Friend iLookAndFeel As New DefaultLookAndFeel                                   ' Стили оформления для программы
    Friend pref_RegistryPath As String = "Software\Microsoft\FitoGrano\"            ' Префикс пути в реестре к настройкам
    Friend pref_ComplexSettings As String = pref_RegistryPath & "ComplexSettings\"  ' Префикс пути в реестре к настройкам комплекса
    Friend pref_UserSettings As String = pref_RegistryPath & "UserSettings\"        ' Префикс пути в реестре к настройкам пользователя
    Friend tmWaitAnimation As New TransitionManager                                 ' Анимация при ожидании
    Friend DecSeporator As String                                                   ' Разделитель десятичной доли заданный в системе пользователя
    ' Friend AddEdit As Integer = 2                                                   ' 2 - Добавить; 3 - Изменить
    Friend EventChangedControl As Boolean = False                                   ' Разрешение на обработку событий элементов управления
    Friend glNewId As String                                                        ' Ид новой записи в базе (глобальная переменная)

    ' Переменные для хранения параметров
    Friend pref_PerformerId As String                                               ' id текущего пользователя
    Friend pref_PerformerName As String                                             ' Полное имя текущего пользователя
    Friend pref_PerformerNameShort As String                                        ' ФИО текущего пользователя
    Friend pref_PerformerLogin As String                                            ' Логин текущего пользователя
    Friend pref_ServerIP As String                                                  ' ip текущего сервера
    Friend pref_DataBaseName As String                                              ' Имя текущей базы данных  
    Friend pref_OrganizationFilial As String                                        ' Текущий филиал  
    Friend pref_ConnectionString As String                                          ' Строка подключения текущего пользователя

    ' Пол
    Public Enum SexType
        Женский = 0
        Мужской = 1
    End Enum
End Module
