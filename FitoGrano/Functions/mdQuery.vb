Imports System.Data.SqlClient
Imports System.Data
Imports DevExpress.XtraEditors

Module mdQuery
    ' Переменные для клиентской базы данных
    Friend Conn As New SqlConnection                                                ' Подключение к БД
    'Friend SqlCom As New SqlCommand                                                 ' Переменная для Sql запросов
    'Friend iDataAdapter As New SqlDataAdapter                                       ' Адаптер для заполнения таблицы после запроса
    Friend iDataSet As New DataSet                                                  ' Таблица для хранения результатов запроса
    ' Переменные для универсального Селекта
    'Friend iTableName As String                                                     ' Имя будущей таблицы
    'Friend iCommandText As String                                                   ' Текст SQL запроса
    Friend CompliteLoad As Boolean                                                  ' Если False, запрос к базе еще выполняется

    ' Подключение к клиентской базе данных
    Friend Sub ConnectionToBase(ByVal server As String, ByVal user As String, ByVal pass As String, ByVal bd As String)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        ' Строка подключения с переменными из входных параметров процедуры
        Conn.ConnectionString = "Persist Security Info = False;" &
                                "Connect Timeout = 360;" &
                                "User ID =" & user & ";" &
                                "Password =" & pass & ";" &
                                "Initial Catalog =" & bd & ";" &
                                "Server =" & server & ";" &
                                "MultipleActiveResultSets = True"
        pref_ConnectionString = Conn.ConnectionString
        If Conn.State = ConnectionState.Closed Then Conn.Open() ' Открываем соединение 
    End Sub
    ' Универсальная процедура с входными параметрами для выборки из бызы
    ' iTableName - Имя создаваемой таблицы в iDataSet
    ' iCommandText - Текст команды
    ' iName - Имя дочерней процедуры 
    Friend Function SelectQueryData(ByVal iTableName As String, ByVal iCommandText As String, Optional ByVal iName As String = "") As Boolean
        Dim iDataAdapter As New SqlDataAdapter
        Dim SqlCom As New SqlCommand
        CompliteLoad = False    ' Запрос выполняется
        Try
            ' Если таблица iTableName существует то, очищае ее' Если таблица iTableName существует то, очищае ее
            If iDataSet.Tables.Contains(iTableName) Then iDataSet.Tables(iTableName).Clear()
            If Conn.State = ConnectionState.Closed Then Conn.Open() ' Открываем соединение
            With SqlCom ' Настраиваем команду SQL
                SqlCom.Connection = Conn                    ' Указываем подключение                                
                SqlCom.CommandText = iCommandText           ' Указываем текст запроса
                SqlCom.CommandTimeout = 600
            End With

            ' Настраиваем Адаптер
            With iDataAdapter
                .SelectCommand = SqlCom             ' Указываем команду на выгрузку данных из базы
                .Fill(iDataSet, iTableName)         ' Выгруженные данные заливаем в DateSet и именуем 
            End With
            CompliteLoad = True     ' Запрос выполнен
            Return True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message & Chr(10) &
                   "Ошибка вызова процедуры: <b>" & iName & "</b>",
                   Application.ProductName,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   DevExpress.Utils.DefaultBoolean.True)
            CompliteLoad = True     ' Запрос выполнен
            Return False
        End Try
        Conn.Close()
    End Function
    ' +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    ' Универсальная процедура с входными параметрами для выполнения процедур в базе без возврата значений
    ' iCommandText - текст команды
    ' iName - Имя дочерней процедуры 
    Friend Function ExecuteQuery(ByVal iCommandText As String, Optional ByVal iName As String = "")
        Dim SqlCom As New SqlCommand
        CompliteLoad = False    ' Запрос выполняется
        Try ' Попытка обновления данных
            If Conn.State = ConnectionState.Closed Then Conn.Open() ' Открываем соединение
            SqlCom.Connection = Conn
            SqlCom.CommandText = iCommandText                       ' Запись текста команды
            SqlCom.ExecuteNonQuery()                                ' Выполнение команды на сервер
            SqlCom.CommandTimeout = 600
            CompliteLoad = True                                     ' Запрос выполнен
            Return True
            ' Сообщение при неудачном подключении к базе данных
        Catch ex As Exception
            ' Сообщение при неудачном подключении к базе данных
            XtraMessageBox.Show(ex.Message & Chr(10) &
                   "Ошибка вызова процедуры: <b>" & iName & "</b>",
                   Application.ProductName,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   DevExpress.Utils.DefaultBoolean.True)
            CompliteLoad = True     ' Запрос выполнен
            Return False
        End Try
        Conn.Close()            ' Закрываем соединение
    End Function

    ' +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    ' Универсальная процедура с входными параметрами для выполнения скалярных функций в базе
    ' iCommandText - текст команды
    ' iName - Имя дочерней процедуры 
    Friend Function ExecuteScalar(ByVal iCommandText As String, Optional ByVal iName As String = "")
        Dim SqlCom As New SqlCommand
        CompliteLoad = False    ' Запрос выполняется
        Try ' Попытка обновления данных
            If Conn.State = ConnectionState.Closed Then Conn.Open() ' Открываем соединение
            SqlCom.Connection = Conn
            SqlCom.CommandText = iCommandText                       ' Запись текста команды
            SqlCom.CommandTimeout = 600                             ' Таймаут запроса

            CompliteLoad = True                                     ' Запрос выполнен
            Return SqlCom.ExecuteScalar()                           ' Выполнение команды на сервер
            ' Сообщение при неудачном подключении к базе данных
        Catch ex As Exception
            ' Сообщение при неудачном подключении к базе данных
            XtraMessageBox.Show(ex.Message & Chr(10) &
                   "Ошибка вызова процедуры: <b>" & iName & "</b>",
                   Application.ProductName,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   DevExpress.Utils.DefaultBoolean.True)
            CompliteLoad = True     ' Запрос выполнен
            Return "err"
        End Try
        Conn.Close()            ' Закрываем соединение
    End Function
End Module
