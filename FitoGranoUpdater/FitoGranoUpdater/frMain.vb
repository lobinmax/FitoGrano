Imports System.IO
Imports DevExpress.XtraBars.Alerter

Public Class frMain
    Sub New()
        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()
        DevExpress.UserSkins.BonusSkins.Register()
        ' Добавьте все инициализирующие действия после вызова InitializeComponent().
        iLookAndFeel.EnableBonusSkins = True           ' Включаем бонусные скины
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = RegistryRead(pref_ComplexSettings, "SkinName", "Dark Side")
        ' Добавьте все инициализирующие действия после вызова InitializeComponent().
    End Sub
    Private Sub frMain_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        Me.Visible = False
    End Sub

    Private Sub TimerCheckUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCheckUpdate.Tick
        UpdatePath = RegistryRead(pref_RegistryPath & "Update\Complex", "UpdatePath")                       ' Чтение из настроек пути обновления
        Dim LastUpdatePack As String = RegistryRead(pref_RegistryPath & "Update", "LastUpdatePack")         ' Чтение из реестра дата и времени последнего обновления
        If UpdatePath = "" Then Exit Sub
        Dim _UpdatePath As New DirectoryInfo(UpdatePath)                                                    ' Объкт для чтения информации о каталоге
        ' Проверка существования пути обновления
        If File.Exists(UpdatePath).ToString() Then
            Disconnect = True
            If _UpdatePath.LastWriteTime.ToString <> LastUpdatePack Then
                ' Если даты НЕ совпали то,
                RegistryWrite(pref_RegistryPath & "Update", "LastUpdatePack", _UpdatePath.LastWriteTime.ToString)
                acUpdate.Show(Me, Application.ProductName, "Доступна новая версия приложения" & Chr(10) &
                                "Дата публикации: <u><b>" & Mid(_UpdatePath.LastWriteTime.ToString, 1, 16) & "</u></b>", False, My.Resources.forNotify)
            End If
        Else ' Отсутствует подключение
            If Disconnect Then
                acUpdate.Show(Me, Application.ProductName, "<backcolor=yellow><color=red>Недоступен католог с обновлениями</backcolor></color>" & Chr(10) &
                             "" & Mid(UpdatePath, 1, 40) & " ...", False, My.Resources.forNotify_Disconnect)
                Disconnect = False
            End If
        End If
    End Sub
    ' Обновление скинов в режиме реального времени
    Private Sub tmSinhronScin_Tick(sender As System.Object, e As System.EventArgs) Handles tmSinhronScin.Tick
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = RegistryRead(pref_ComplexSettings, "SkinName", "Dark Side")
    End Sub
    ' размер алерта до его загрузки
    Private Sub acUpdate_BeforeFormShow(sender As Object, e As DevExpress.XtraBars.Alerter.AlertFormEventArgs) Handles acUpdate.BeforeFormShow
        e.AlertForm.Size = New Size(370, 100)
    End Sub
End Class