Imports System.Threading
Imports System.IO
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.Compression

Public Class frFitoGranoLoad
    Friend otkuda As String                                                                 ' Путь откуда загружаются обновления
    Friend LastUpgrade As String                                                            ' Переменная для хранения даты и времени последнего обновления
    Friend kuda As String = Application.StartupPath                                         ' Обновление загружается в папку откуда запушена программа
    Friend AppDir As New IO.DirectoryInfo(kuda)                                             ' Пространство для чтения атрибутов католога
    Sub New()
        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()
        ' Добавьте все инициализирующие действия после вызова InitializeComponent().
        DevExpress.UserSkins.BonusSkins.Register()
        ' Добавьте все инициализирующие действия после вызова InitializeComponent().
        iLookAndFeel.EnableBonusSkins = True           ' Включаем бонусные скины
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = RegistryRead(pref_ComplexSettings, "SkinName", "Dark Side")
    End Sub

    Private Sub frPripyatLoad_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ' Снимаем статус Только чтение для папки с программой и ее родительского каталога
        If AppDir.Parent.Exists Then AppDir.Parent.Attributes = IO.FileAttributes.Directory
        If AppDir.Exists Then AppDir.Attributes = IO.FileAttributes.Directory
        ' Запуск обновления в отдельном процессе
        Dim Th As New Thread(AddressOf Upgrade)                                    ' Создание дилигата процесса обновления
        Th.Start()                                                                 ' Запуск обновления в отдельном потоке
    End Sub

    Private Sub Upgrade()
        Dim _lookAndFeel As New DefaultLookAndFeel ' Оформление для MSGBOX
        _lookAndFeel.EnableBonusSkins = True
        ' используем текущюю тему
        _lookAndFeel.LookAndFeel.SkinName = RegistryRead(pref_ComplexSettings, "SkinName", "Dark Side")
        ' Чтоб отладка не возвращала ошибку из разных потоков
        Control.CheckForIllegalCrossThreadCalls = False
        Thread.Sleep(1000)
        otkuda = RegistryRead(pref_RegistryPath & "Update\Complex", "UpdatePath")           ' Чтение из настроек пути обновления
        LastUpgrade = RegistryRead(pref_RegistryPath & "Update\Complex", "LastUpdate", "01.01.1900")      ' Чтение из реестра дата и времени последнего обновления

        ' Проверка совпадения даты последнего обновления и его публикации
        ' только если указан путь для загрузки
        If otkuda IsNot Nothing Then
            Dim fi As New FileInfo(otkuda)
            If CDate(fi.LastWriteTime).ToString = LastUpgrade.ToString Then
                ' Если даты совпали то,
                Me.VisualControl.Description = "Обновление отсутствует ..."
                Thread.Sleep(1000)
                RegistryWrite(pref_RegistryPath & "Update\Complex", "UpdateValidate", 1)   ' обновление для прогрммы отсутствует
                GoTo m ' запуск Припять
            End If
        End If
        ' Проверка существования архива обновления
        If File.Exists(otkuda) Then
            Me.VisualControl.Description = "Обнаружено обновление ..."
            Thread.Sleep(1000)
            If FitoGranoIsWork("Pripyat") Then
                If XtraMessageBox.Show(_lookAndFeel.LookAndFeel, Me, "Обнаружен запущенный экземпляр <b>" & Application.ProductName & "</b>!" & Chr(10) &
                                      "Для продолжения обновления Вам необходимо закрыть все экземляры!",
                                      Application.ProductName, MessageBoxButtons.RetryCancel,
                                      MessageBoxIcon.Information, DevExpress.Utils.DefaultBoolean.True) = Windows.Forms.DialogResult.Retry Then
                    Upgrade()   ' пробуем еще раз
                    Exit Sub
                Else
                    GoTo m ' запуск Припять
                End If
            End If
            UnzipArchive() ' Запуск копирования
        Else
            ' Сообщаем об ошибке
            Select Case XtraMessageBox.Show(
                            _lookAndFeel.LookAndFeel, Me,
                            "По указанному пути отсутствует архив с обновлениями!" & Chr(10) & _
                            "Путь к архиву: <b>" & otkuda & "</b>" & Chr(10) & _
                             "<u>Да</u> - продолжить без обновления" & Chr(10) & _
                             "<u>Нет</u> - изменить путь к каталогу обновлений",
                             Application.ProductName,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Information,
                             DevExpress.Utils.DefaultBoolean.True
                                            )
                Case Windows.Forms.DialogResult.Yes     ' Да - продолжить без обновления
                    GoTo m
                Case Windows.Forms.DialogResult.No      ' Нет - изменить путь к каталогу обновлений
                    PathUpdate()
                    Exit Sub
            End Select
        End If

m: ' Запуск ПК FitoGrano если есть что запускать
        If File.Exists(kuda & "/FitoGrano.exe") Then
            Process.Start(kuda & "/FitoGrano.exe")
        Else
            XtraMessageBox.Show(_lookAndFeel.LookAndFeel, Me,
                                "Неудается найти исполняющий компонент " & Application.ProductName & "!" & Chr(10) &
                                "Проверьте правильность установки программного комплекса!",
                                Application.ProductName,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1)
            GoTo m1
        End If
        ' запускаем модуль обновления
        If File.Exists(kuda & "/FitoGranoUpdater.exe") Then
            Process.Start(kuda & "/FitoGranoUpdater.exe")
        Else
            XtraMessageBox.Show(_lookAndFeel.LookAndFeel, Me,
                                "Неудается найти модуль обновления " & Application.ProductName & "!" & Chr(10) &
                                "Проверьте правильность установки программного комплекса!",
                                Application.ProductName,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1)
            GoTo m1
        End If
m1:     ' Только чтение для папки с программой и ее родительского каталога
        If AppDir.Parent.Exists Then AppDir.Parent.Attributes = IO.FileAttributes.ReadOnly
        If AppDir.Exists Then AppDir.Attributes = IO.FileAttributes.ReadOnly
        Me.Close()
    End Sub

    ' распаковка обновлений
    Public Sub UnzipArchive()
        Dim pathToZipArchive As String = otkuda
        Dim pathToExtract As String = kuda
        Dim total As Long = 0
        Dim archive As ZipArchive = ZipArchive.Read(pathToZipArchive)
        ' позволяем перезаписывать файлы в целевом пути без запроса
        archive.OptionsBehavior.AllowFileOverwrite = AllowFileOverwriteMode.Allow
        ' перебираем все файлы в архиве и счтаем их размер
        Me.VisualControl.Description = "Анализ размера ..."
        Thread.Sleep(1500)
        For Each f As UnzipItem In archive
            total += f.CompressedSize
        Next
        Me.VisualControl.Description = "Подготовка каталога ..."
        Thread.Sleep(2000)
        ClearForderPripyat() ' чистка каталога
        Me.VisualControl.Description = "Загрузка обновления ..."
        ' максимальное значение прогрессбара
        Me.ProgressControl.Properties.Maximum = total
        FormMaximization() ' разворачиваем форму
        ' распаковываем файлы в каталог с программой
        For Each f As UnzipItem In archive
            Me.lbFileName.Text = f.Name
            Try
                f.Extract(pathToExtract)
            Catch ex As Exception
                XtraMessageBox.Show(iLookAndFeel.LookAndFeel, Me,
                                    ex.Message & Chr(10) & "Ошибка распаковки файла: <b>" & f.Name & "</b>",
                                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop, DevExpress.Utils.DefaultBoolean.True)
                RegistryWrite(pref_RegistryPath & "Update\Complex", "UpdateValidate", 0)    ' обновление неудалось
                archive.Dispose()
                End
            End Try
            Me.ProgressControl.EditValue += f.CompressedSize
            Application.DoEvents()
        Next
        ' После удачного обновления запись в настройки отметку об обновлении и даты последнего обновления каталога Upgrade
        Dim fi As New FileInfo(otkuda)
        RegistryWrite(pref_RegistryPath & "Update\Complex", "UpdateValidate", 1)
        RegistryWrite(pref_RegistryPath & "Update\Complex", "LastUpdate", fi.LastWriteTime)
        RegistryWrite(pref_RegistryPath & "Update", "LastUpdatePack", fi.LastWriteTime)
        FormMinimization()
    End Sub

    ' читка каталога с программой перед загрузкой обновления
    Private Sub ClearForderPripyat()
        Dim dir As New DirectoryInfo(kuda)
        If FitoGranoIsWork("FitoGranoUpdater") Then Process.GetProcessesByName("FitoGranoUpdater")(0).Kill()
        If FitoGranoIsWork("FitoGranoUpdater") Then Process.GetProcessesByName("FitoGranoUpdater")(0).WaitForExit()

        ' удаляем все каталоги
        For Each d As DirectoryInfo In dir.GetDirectories
            Try
                d.Delete(True)
            Catch ex As Exception
                XtraMessageBox.Show(iLookAndFeel.LookAndFeel, Me, ex.Message & Chr(10) & "Ошибка при подготовки каталога ...",
                                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End
            End Try
        Next
        ' удаляем все файлы
        For Each f As FileInfo In dir.GetFiles
            Try
                If f.Name <> "FitoGranoStarter.exe" Then f.Delete()
            Catch ex As Exception
                XtraMessageBox.Show(iLookAndFeel.LookAndFeel, Me, ex.Message & Chr(10) & "Ошибка при подготовки каталога ...",
                                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End
            End Try
        Next
        dir = Nothing
    End Sub

    ' проверка запущенных экземпляров Припять
    Private Function FitoGranoIsWork(ByVal ProcessName As String) As Boolean
        Dim Proc() As Process
        Proc = Process.GetProcessesByName(ProcessName)
        If Proc.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ' изменение пути к каталогу с обновлениями
    Private Sub PathUpdate()
        Dim p As New OpenFileDialog
        p.CheckFileExists = True
        p.AutoUpgradeEnabled = True
        p.Filter = "Архив обновлений|*.zip"
        p.DefaultExt = "*.zip"
        p.Multiselect = False
        p.Title = "Выберите ZIP-архив с обновлениями для " & Application.ProductName
        If p.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            ' Запись выбранного пути в настройки
            RegistryWrite(pref_RegistryPath & "Update\Complex", "UpdatePath", p.FileName)
            ' Запуск обновления в отдельном процессе
            Dim Th As New Thread(AddressOf Upgrade)     ' Создание дилигата процесса обновления
            Th.Start()                                  ' Запуск обновления в отдельном потоке
        Else
            XtraMessageBox.Show(iLookAndFeel.LookAndFeel, Me,
                                "Путь к архиву с обновлением для " & Application.ProductName & " не выбран!" & Chr(10) &
                                "Приложение завершает свою работу!",
                                Application.ProductName,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End
        End If
    End Sub
    ' уменьшение формы
    Private Sub FormMinimization()
        Dim h As Integer = Me.Size.Height
        Dim w As Integer = Me.Size.Width
        Me.ProgressViewPanel.Visible = False
        Me.VisualControl.Description = "Запуск " & Application.ProductName & " ..."
        For i = 1 To 37
            Me.Size = New Point(w, h - i)
        Next
    End Sub
    ' увеличение формы
    Private Sub FormMaximization()
        Dim h As Integer = Me.Size.Height
        Dim w As Integer = Me.Size.Width
        For i = 1 To 37
            Me.Size = New Point(w, h + i)
            Application.DoEvents()
        Next
        Me.ProgressViewPanel.Visible = True
    End Sub

    ' Обновление скинов в режиме реального времени
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = RegistryRead(pref_ComplexSettings, "SkinName", "Dark Side")
    End Sub
End Class