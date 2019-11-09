Imports System.Data
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ButtonsPanelControl
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frBooks_ResearchDirection
    Dim PreferenceForms As String                           ' Ветка в реестре для хранения настроек формы 
    Dim NewId_Direction As String                           ' Новая запись в классификациях
    Dim EventChangedControl_Direction As Boolean = False    ' вкл обработки событий классификаций
    Dim EventChangedControl_Method As Boolean = False       ' вкл обработка событий продукций
    Friend NewId_Method As String                           ' Новая запись в продукциях

    ' закрытие формы
    Private Sub frBooks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        clsMyUserFunction.RemoveTableDataSet(Me)
        clsMyUserFunction.SaveViewForm(Me)
        RegistryWrite(PreferenceForms, "SplitterPosition", Me.SplitContainerControl1.SplitterPosition)
        RegistryWrite(PreferenceForms, "gvDirection.ShowFilterRow", Me.gvDirection.OptionsView.ShowAutoFilterRow.ToString)
        RegistryWrite(PreferenceForms, "gvDirection.ShowFindPanel", Me.gvDirection.OptionsFind.AlwaysVisible.ToString)
        RegistryWrite(PreferenceForms, "gvMethod.ShowFilterRow", Me.gvMethod.OptionsView.ShowAutoFilterRow.ToString)
        RegistryWrite(PreferenceForms, "gvMethod.ShowFindPanel", Me.gvMethod.OptionsFind.AlwaysVisible.ToString)
    End Sub
    ' загрузка формы
    Private Sub frBooks_ResearchDirection_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' настройка элементов
        PreferenceForms = pref_UserSettings & Me.Name & "\"
        clsMyUserFunction.LoadViewForm(Me)
        Me.SplitContainerControl1.SplitterPosition = RegistryRead(PreferenceForms, "SplitterPosition", 301)
        Me.gcnDirection.CustomHeaderButtons.Item(4).Properties.Checked = RegistryRead(PreferenceForms, "gvDirection.ShowFindPanel", False)
        Me.gcnDirection.CustomHeaderButtons.Item(5).Properties.Checked = RegistryRead(PreferenceForms, "gvDirection.ShowFilterRow", False)
        Me.gcnMethods.CustomHeaderButtons.Item(4).Properties.Checked = RegistryRead(PreferenceForms, "gvMethod.ShowFindPanel", False)
        Me.gcnMethods.CustomHeaderButtons.Item(5).Properties.Checked = RegistryRead(PreferenceForms, "gvMethod.ShowFilterRow", False)
        Me.lbServerName.Caption = pref_ServerIP
        Me.lbDB_name.Caption = pref_DataBaseName
        Designer_Direction() ' загрузка направлений
    End Sub

#Region "Направления"
    ' настройка таблицы классификаций
    Private Sub Designer_Direction()
        EventChangedControl_Direction = False
        SelectQueryData(
                        "Books_Direction." & Me.Name,
                        "EXEC Books_ResearchDirectionMethod @Parameter = 1, @Function = 1",
                        "GetBooks_ResearchDirection"
                        )
        If Me.gcDirection.DataSource Is Nothing Then
            Me.gcDirection.DataSource = iDataSet.Tables("Books_Direction." & Me.Name)
            HidenAllColumns_Grid(Me.gvDirection, iDataSet.Tables("Books_Direction." & Me.Name))
            Me.gvDirection.Columns("Name").Visible = True
            Me.gvDirection.Columns("Name").Caption = "Направление"
        End If
        EventChangedControl_Direction = True
        ' активная строка из памяти
        Me.gvDirection.FocusedRowHandle = Me.gvDirection.LocateByValue("Id", CType(NewId_Direction, Integer))
    End Sub
    ' группа кнопок направлений
    Private Sub gcnDirection_CustomButtonClick(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles gcnDirection.CustomButtonClick
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.Caption
            Case "btnAddDirection" : btnAddDirections(2)
            Case "btnEditDirection" : If Me.gvDirection.RowCount <> 0 Then btnAddDirections(3)
            Case "btnDeleteDirection" : If Me.gvDirection.RowCount <> 0 Then btnDeleteDirections()
            Case "btnClearSort_Direction" : Me.gvDirection.ClearSorting()
        End Select
    End Sub
    ' группа чеков направлений
    Private Sub gcnDirection_CustomButtonChecked(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles gcnDirection.CustomButtonChecked, gcnDirection.CustomButtonUnchecked
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.Caption
            Case "btnSearch_Direction"
                Me.gvDirection.OptionsFind.AlwaysVisible = btn.Checked
                ' при отключении очищаем фильтрацию
                If btn.Checked = False Then Me.gvDirection.FindFilterText = Nothing
            Case "btnAutoFilter_Direction"
                Me.gvDirection.OptionsView.ShowAutoFilterRow = btn.Checked
                ' при отключении очищаем фильтрацию
                If btn.Checked = False Then Me.gvDirection.ClearColumnsFilter()
        End Select
    End Sub
    ' фокус на направление
    Private Sub gvDirection_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvDirection.FocusedRowChanged
        If e.FocusedRowHandle < 0 Then Exit Sub
        Dim iRow As DataRow = sender.GetFocusedDataRow
        Dim ParentId As String = iRow("Id")
        Designer_Method(ParentId) ' получаем список методов по направлению
        If EventChangedControl_Direction Then NewId_Direction = iRow("Id").ToString
    End Sub
    ' добавить/редактировать направление
    Private Sub btnAddDirections(ByVal AddEdit As Integer)
        Dim ib As New XtraInputBoxArgs ' окно ввода значения
        Dim result As String
        Dim NewId As String
        Dim IdClassifications As String = "NULL" ' запролняется при изменении записи
        Dim editor As New TextEdit                              ' тип редактора в диалоге
        editor.Properties.MaxLength = 200                       ' макс кол-во знаков редакторе 
        editor.Properties.NullValuePromptShowForEmptyValue = True
        editor.Properties.ShowNullValuePromptWhenFocused = True
        editor.Properties.NullValuePrompt = "Введите наименование направления (до " & editor.Properties.MaxLength & " символов)"
        ib.Editor = editor
        ib.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True
        ib.Prompt = "<b><u>Наименование направления</b></u>"
        ib.DefaultButtonIndex = 0
        ib.Caption = If(AddEdit = 2, "Добавить направление", "Редактировать направление")
        ' при редактировании записи
        If AddEdit = 3 Then
            IdClassifications = Me.gvDirection.GetFocusedRowCellDisplayText("Id")
            ib.DefaultResponse = Me.gvDirection.GetFocusedRowCellDisplayText("Name") ' значение в поле ввода по умолчанию
        End If

        result = clsForSQL.InDataBase(XtraInputBox.Show(ib))
        If result <> "NULL" Then
            NewId = ExecuteScalar(
                                  "EXEC Books_ResearchDirectionMethod " &
                                        "@IdDirection = " & IdClassifications & ", " &
                                        "@NameDirection = " & result & ", " &
                                        "@Parameter = 1, " &
                                        "@Function = " & AddEdit,
                                  "Books_ResearchDirectionMethod.Function = " & AddEdit
                                  )
            If NewId IsNot Nothing And AddEdit = 2 And NewId <> "err" Then
                NewId_Direction = NewId
            End If
        End If
        Designer_Direction()
    End Sub
    ' удалить направление
    Private Sub btnDeleteDirections()
        Dim RowNumber As Integer = Me.gvDirection.FocusedRowHandle
        If XtraMessageBox.Show("Исследование по направлению <b>" & Me.gvDirection.GetFocusedRowCellDisplayText("Name") & "</b> " & Chr(10) &
                               "и принадлежащие ему методы будут удалены из справочника!" & Chr(10) &
                               "Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) = DialogResult.Yes Then
            ExecuteScalar(
                          "EXEC Books_ResearchDirectionMethod " &
                                "@IdDirection = " & Me.gvDirection.GetFocusedRowCellDisplayText("Id") & ", " &
                                "@NameDirection = " & Me.gvDirection.GetFocusedRowCellDisplayText("Name") & ", " &
                                "@Parameter = 1, " &
                                "@Function = 4",
                          "Books_ResearchDirectionMethod.Function = 4"
                          )
            Designer_Direction()
            If iDataSet.Tables("Books_Direction." & Me.Name).Rows.Count = 0 Then
                iDataSet.Tables("Books_Method." & Me.Name).Rows.Clear()
            End If
            Me.gvDirection.FocusedRowHandle = (RowNumber - 1)
        End If
    End Sub
    ' вызов контекстного меню на направлении
    Private Sub gvDirection_MouseDown(sender As Object, e As MouseEventArgs) Handles gvDirection.MouseDown
        Dim view As GridView = CType(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If e.Button = MouseButtons.Right Then
            Me.btnEditDirection.Enabled = info.InRow
            Me.btnDeleteDirection.Enabled = info.InRow
            Me.pmMenuDirection.ShowPopup(MousePosition)
        End If
        If info.InRow And e.Button = MouseButtons.Left And e.Clicks = 2 Then
            btnEditDirection_ItemClick(e, Nothing)
        End If
    End Sub
#Region "Контекстное меню"
    ' добавить направление
    Private Sub btnAddDirection_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAddDirection.ItemClick
        gcnDirection_CustomButtonClick(Me.gcnDirection, New Docking2010.BaseButtonEventArgs(Me.gcnDirection.CustomHeaderButtons.Item(0)))
    End Sub
    ' редактировать направление
    Private Sub btnEditDirection_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEditDirection.ItemClick
        gcnDirection_CustomButtonClick(Me.gcnDirection, New Docking2010.BaseButtonEventArgs(Me.gcnDirection.CustomHeaderButtons.Item(1)))
    End Sub
    ' удалить направление
    Private Sub btnDeleteDirection_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnDeleteDirection.ItemClick
        gcnDirection_CustomButtonClick(Me.gcnDirection, New Docking2010.BaseButtonEventArgs(Me.gcnDirection.CustomHeaderButtons.Item(2)))
    End Sub
#End Region
    ' удалить или редактировать направление клавишей
    Private Sub gvDirection_KeyDown(sender As Object, e As KeyEventArgs) Handles gvDirection.KeyDown
        If sender.FocusedRowHandle < 0 Then Exit Sub
        If e.KeyCode = Keys.Delete Then
            btnDeleteDirection_ItemClick(e, Nothing)
        End If
        If e.KeyCode = Keys.Enter Then
            btnEditDirection_ItemClick(e, Nothing)
        End If
    End Sub
#End Region

#Region "Методы"
    ' настройка таблицы с методами
    Private Sub Designer_Method(ByVal ParentId As String)
        EventChangedControl_Method = False
        SelectQueryData(
                        "Books_Method." & Me.Name,
                        "EXEC Books_ResearchDirectionMethod @IdDirection = " & ParentId & ", @Parameter = 2, @Function = 1",
                        "GetMethods"
                        )
        If Me.gcMethod.DataSource Is Nothing Then
            Me.gcMethod.DataSource = iDataSet.Tables("Books_Method." & Me.Name)
            HidenAllColumns_Grid(Me.gvMethod, iDataSet.Tables("Books_Method." & Me.Name))
            Me.gvMethod.Columns("LongDay").Visible = True
            Me.gvMethod.Columns("LongDay").Caption = "Продолжительность, дней"
            Me.gvMethod.Columns("IsPriority").Visible = True
            Me.gvMethod.Columns("IsPriority").Caption = "Метод приоритетный"
            Me.gvMethod.Columns("Name").Visible = True
            Me.gvMethod.Columns("Name").Caption = "Наименование метода"
            Me.gvMethod.BestFitColumns()
        End If
        EventChangedControl_Method = True
        ' активная строка из памяти
        Me.gvMethod.FocusedRowHandle = Me.gvMethod.LocateByValue("Id", CType(NewId_Method, Integer))
    End Sub
    ' группа кнопок методов
    Private Sub gcnProducts_CustomButtonClick(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles gcnMethods.CustomButtonClick
        Dim btnAddEdit As Boolean = False
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.Caption
            Case "btnAddMethod" : frAddEditResearchMethod.AddEdit = 2 : btnAddEdit = True
            Case "btnEditMethod" : If Me.gvMethod.RowCount <> 0 Then frAddEditResearchMethod.AddEdit = 3 : btnAddEdit = True
            Case "btnDeleteMethod" : If Me.gvMethod.RowCount <> 0 Then btnDeleteMethods()
            Case "btnClearSort_Method" : Me.gvMethod.ClearSorting()
        End Select
        ' если добавление или редактирование
        If btnAddEdit Then
            NewId_Method = Me.gvMethod.GetFocusedRowCellDisplayText("Id")
            If frAddEditResearchMethod.ShowDialog() = DialogResult.OK Then
                Designer_Method(Me.gvDirection.GetFocusedRowCellDisplayText("Id"))
            End If
        End If
    End Sub
    ' группа чеков методов
    Private Sub gcnMethods_CustomButtonChecked(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles gcnMethods.CustomButtonChecked, gcnMethods.CustomButtonUnchecked
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.Caption
            Case "btnSearch_Method"
                Me.gvMethod.OptionsFind.AlwaysVisible = btn.Checked
                ' при отключении очищаем фильтрацию
                If btn.Checked = False Then Me.gvMethod.FindFilterText = Nothing
            Case "btnAutoFilter_Method"
                Me.gvMethod.OptionsView.ShowAutoFilterRow = btn.Checked
                ' при отключении очищаем фильтрацию
                If btn.Checked = False Then Me.gvMethod.ClearColumnsFilter()
        End Select
    End Sub
    ' фокус на методах
    Private Sub gvMethod_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvMethod.FocusedRowChanged
        gvMethod_RowChanged(e.FocusedRowHandle)
    End Sub
    ' Клмк на методах
    Private Sub gvMethod_FocusedRowChanged(sender As Object, e As RowCellClickEventArgs) Handles gvMethod.RowCellClick
        gvMethod_RowChanged(e.RowHandle)
    End Sub
    ' событие строк
    Private Sub gvMethod_RowChanged(ByVal RowHandle As Integer)
        If RowHandle < 0 Then Exit Sub
        Dim iRow As DataRow = Me.gvMethod.GetFocusedDataRow
        If RowHandle < 0 Then Exit Sub
        If EventChangedControl_Method Then NewId_Method = iRow("Id").ToString
    End Sub
    ' удалить метод
    Private Sub btnDeleteMethods()
        Dim RowNumber As Integer = Me.gvMethod.FocusedRowHandle
        If XtraMessageBox.Show("Метод исследования <b>" & Me.gvMethod.GetFocusedRowCellDisplayText("Name") & "</b> будет удален!" & Chr(10) &
                               "Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) = DialogResult.Yes Then
            ExecuteScalar(
                          "EXEC Books_ResearchDirectionMethod " &
                                "@IdMethod = " & Me.gvMethod.GetFocusedRowCellDisplayText("Id") & ", " &
                                "@NameMethod = " & clsForSQL.InDataBase(Me.gvMethod.GetFocusedRowCellDisplayText("Name")) & ", " &
                                "@Parameter = 2, " &
                                "@Function = 4",
                          "Books_ResearchDirectionMethod.Function = 4"
                          )
            Designer_Method(Me.gvDirection.GetFocusedRowCellDisplayText("Id"))
            Me.gvMethod.FocusedRowHandle = RowNumber - 1
        End If
    End Sub
    ' вызов контекстного меню на методах
    Private Sub gvMethod_MouseDown(sender As Object, e As MouseEventArgs) Handles gvMethod.MouseDown
        Dim view As GridView = CType(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If e.Button = MouseButtons.Right Then
            Me.btnEditMethod.Enabled = info.InRow
            Me.btnDeleteMethod.Enabled = info.InRow
            Me.pmMenuMethods.ShowPopup(MousePosition)
        End If
        If info.InRow And e.Button = MouseButtons.Left And e.Clicks = 2 Then
            btnEditMethod_ItemClick(e, Nothing)
        End If
    End Sub
#Region "Контекстное меню"
    ' добавить метод
    Private Sub btnAddMethod_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAddMethod.ItemClick
        gcnProducts_CustomButtonClick(Me.gcnDirection, New Docking2010.BaseButtonEventArgs(Me.gcnMethods.CustomHeaderButtons.Item(0)))
    End Sub
    ' редактировать метод
    Private Sub btnEditMethod_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEditMethod.ItemClick
        gcnProducts_CustomButtonClick(Me.gcnDirection, New Docking2010.BaseButtonEventArgs(Me.gcnMethods.CustomHeaderButtons.Item(1)))
    End Sub
    ' удалить метод
    Private Sub btnDeleteMethod_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnDeleteMethod.ItemClick
        gcnProducts_CustomButtonClick(Me.gcnDirection, New Docking2010.BaseButtonEventArgs(Me.gcnMethods.CustomHeaderButtons.Item(2)))
    End Sub
#End Region
    ' удалить или редактировать метод клавишей
    Private Sub gvMethod_KeyDown(sender As Object, e As KeyEventArgs) Handles gvMethod.KeyDown
        If sender.FocusedRowHandle < 0 Then Exit Sub
        If e.KeyCode = Keys.Delete And sender.FocusedRowHandle >= 0 Then
            btnDeleteMethod_ItemClick(e, Nothing)
        End If
        If e.KeyCode = Keys.Enter And sender.FocusedRowHandle >= 0 Then
            btnEditMethod_ItemClick(e, Nothing)
        End If
    End Sub
#End Region

    ' проверка полей по таймеру
    Private Sub tmChecked_Tick(sender As Object, e As EventArgs) Handles tmChecked.Tick
        Dim gvDirectionRowCount As Integer = Me.gvDirection.RowCount  ' кол-во направлений
        Dim gvMethodRowCount As Integer = Me.gvMethod.RowCount        ' кол-во методов
        ' направления
        Me.gcnDirection.CustomHeaderButtons.Item(1).Properties.Enabled = (gvDirectionRowCount <> 0)   ' редактировать
        Me.gcnDirection.CustomHeaderButtons.Item(2).Properties.Enabled = (gvDirectionRowCount <> 0)   ' удалить
        ' методы
        Me.btnAddMethod.Enabled = (gvDirectionRowCount <> 0)                                          ' добавить в меню
        Me.gcnMethods.CustomHeaderButtons.Item(0).Properties.Enabled = (gvDirectionRowCount <> 0)     ' добавить
        Me.gcnMethods.CustomHeaderButtons.Item(1).Properties.Enabled = (gvMethodRowCount <> 0)        ' редактировать
        Me.gcnMethods.CustomHeaderButtons.Item(2).Properties.Enabled = (gvMethodRowCount <> 0)        ' удалить
        ' подсчет столбцов с примененной сортировкой
        Dim ColCount As Integer = 0
        For Each c As GridColumn In Me.gvDirection.SortedColumns
            ColCount += 1
        Next
        Me.gcnDirection.CustomHeaderButtons.Item(6).Properties.Enabled = (ColCount <> 0)
        ' подсчет столбцов с примененной сортировкой
        ColCount = 0
        For Each c As GridColumn In Me.gvMethod.SortedColumns
            ColCount += 1
        Next
        Me.gcnMethods.CustomHeaderButtons.Item(6).Properties.Enabled = (ColCount <> 0)
    End Sub
    ' обновление формы
    Private Sub btnUpdate_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnUpdate.ItemClick
        Designer_Direction()
    End Sub
End Class