Imports System.Data
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ButtonsPanelControl
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frBooks_ClassificationProducts
    Dim PreferenceForms As String                               ' Ветка в реестре для хранения настроек формы 
    Dim NewId_Classification As String                          ' Новая запись в классификациях
    Dim EventChangedControl_Classification As Boolean = False   ' вкл обработки событий классификаций
    Dim EventChangedControl_Products As Boolean = False         ' вкл обработка событий продукций
    Friend NewId_Products As String                             ' Новая запись в продукциях

    ' закрытие формы
    Private Sub frBooks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        clsMyUserFunction.RemoveTableDataSet(Me)
        clsMyUserFunction.SaveViewForm(Me)
        RegistryWrite(PreferenceForms, "SplitterPosition", Me.SplitContainerControl1.SplitterPosition)
        RegistryWrite(PreferenceForms, "gvClassification.ShowFilterRow", Me.gvClassification.OptionsView.ShowAutoFilterRow.ToString)
        RegistryWrite(PreferenceForms, "gvClassification.ShowFindPanel", Me.gvClassification.OptionsFind.AlwaysVisible.ToString)
        RegistryWrite(PreferenceForms, "gvProducts.ShowFilterRow", Me.gvProducts.OptionsView.ShowAutoFilterRow.ToString)
        RegistryWrite(PreferenceForms, "gvProducts.ShowFindPanel", Me.gvProducts.OptionsFind.AlwaysVisible.ToString)
    End Sub
    ' загрузка формы
    Private Sub frBooks_ClassificationProducts_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' настройка элементов
        PreferenceForms = pref_UserSettings & Me.Name & "\"
        clsMyUserFunction.LoadViewForm(Me)
        Me.SplitContainerControl1.SplitterPosition = RegistryRead(PreferenceForms, "SplitterPosition", 301)
        Me.gcnClassification.CustomHeaderButtons.Item(4).Properties.Checked = RegistryRead(PreferenceForms, "gvClassification.ShowFindPanel", False)
        Me.gcnClassification.CustomHeaderButtons.Item(5).Properties.Checked = RegistryRead(PreferenceForms, "gvClassification.ShowFilterRow", False)
        Me.gcnProducts.CustomHeaderButtons.Item(4).Properties.Checked = RegistryRead(PreferenceForms, "gvProducts.ShowFindPanel", False)
        Me.gcnProducts.CustomHeaderButtons.Item(5).Properties.Checked = RegistryRead(PreferenceForms, "gvProducts.ShowFilterRow", False)
        Me.lbServerName.Caption = pref_ServerIP
        Me.lbDB_name.Caption = pref_DataBaseName
        Designer_Classification() ' загрузка классификаций
    End Sub

#Region "Классификации"
    ' настройка таблицы классификаций
    Private Sub Designer_Classification()
        EventChangedControl_Classification = False
        SelectQueryData(
                        "Books_Classification." & Me.Name,
                        "EXEC Books_ClassificationsProducts @Parameter = 1, @Function = 1",
                        "GetClassifications"
                        )
        If Me.gcClassification.DataSource Is Nothing Then
            Me.gcClassification.DataSource = iDataSet.Tables("Books_Classification." & Me.Name)
            HidenAllColumns_Grid(Me.gvClassification, iDataSet.Tables("Books_Classification." & Me.Name))
            Me.gvClassification.Columns("Name").Visible = True
            Me.gvClassification.Columns("Name").Caption = "Наименование"
        End If
        EventChangedControl_Classification = True
        ' активная строка из памяти
        Me.gvClassification.FocusedRowHandle = Me.gvClassification.LocateByValue("Id", CType(NewId_Classification, Integer))
    End Sub
    ' группа кнопок классификаций
    Private Sub gcnClassification_CustomButtonClick(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles gcnClassification.CustomButtonClick
        Dim btn As GroupBoxButton = e.Button
        ' Console.WriteLine(e.Button.Properties.Caption)
        Select Case btn.Caption
            Case "btnAddClassification" : btnAddClassification(2)
            Case "btnEditClassfication" : If Me.gvClassification.RowCount <> 0 Then btnAddClassification(3)
            Case "btnDeleteClassfication" : If Me.gvClassification.RowCount <> 0 Then btnDeleteClassfication()
            Case "btnClearSort_Classfication" : Me.gvClassification.ClearSorting()
        End Select
    End Sub
    ' группа чеков классификаций
    Private Sub gcnClassification_CustomButtonChecked(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles gcnClassification.CustomButtonChecked, gcnClassification.CustomButtonUnchecked
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.Caption
            Case "btnSearch_Classifications"
                Me.gvClassification.OptionsFind.AlwaysVisible = btn.Checked
                ' при отключении очищаем фильтрацию
                If btn.Checked = False Then Me.gvClassification.FindFilterText = Nothing
            Case "btnAutoFilter_Classifications"
                Me.gvClassification.OptionsView.ShowAutoFilterRow = btn.Checked
                ' при отключении очищаем фильтрацию
                If btn.Checked = False Then Me.gvClassification.ClearColumnsFilter()
        End Select
    End Sub
    ' фокус на классификацию
    Private Sub gvClassification_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvClassification.FocusedRowChanged
        If e.FocusedRowHandle < 0 Then Exit Sub
        Dim iRow As DataRow = sender.GetFocusedDataRow
        Dim ParentId As String = iRow("Id")
        Designer_Products(ParentId) ' получаем список продукций по классификации
        If EventChangedControl_Classification Then NewId_Classification = iRow("Id").ToString
    End Sub
    ' добавить/редактировать классификацию
    Private Sub btnAddClassification(ByVal AddEdit As Integer)
        Dim ib As New XtraInputBoxArgs ' окно ввода значения
        Dim result As String
        Dim NewId As String
        Dim IdClassifications As String = "NULL" ' запролняется при изменении записи
        Dim editor As New TextEdit                              ' тип редактора в диалоге
        editor.Properties.MaxLength = 200                       ' макс кол-во знаков редакторе 
        editor.Properties.NullValuePromptShowForEmptyValue = True
        editor.Properties.ShowNullValuePromptWhenFocused = True
        editor.Properties.NullValuePrompt = "Введите наименование классификации (до " & editor.Properties.MaxLength & " символов)"
        ib.Editor = editor
        ib.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True
        ib.Prompt = "<b><u>Наименование классификации</b></u>"
        ib.DefaultButtonIndex = 0
        ib.Caption = If(AddEdit = 2, "Добавить классификацию", "Редактировать классификацию")
        ' при редактировании записи
        If AddEdit = 3 Then
            IdClassifications = Me.gvClassification.GetFocusedRowCellDisplayText("Id")
            ib.DefaultResponse = Me.gvClassification.GetFocusedRowCellDisplayText("Name") ' значение в поле ввода по умолчанию
        End If

        result = clsForSQL.InDataBase(XtraInputBox.Show(ib))
        If result <> "NULL" Then
            NewId = ExecuteScalar(
                                  "EXEC Books_ClassificationsProducts " &
                                        "@IdClassifications = " & IdClassifications & ", " &
                                        "@NameClassifications = " & result & ", " &
                                        "@Parameter = 1, " &
                                        "@Function = " & AddEdit,
                                  "Books_ClassificationsProducts.Function = " & AddEdit
                                  )
            If NewId IsNot Nothing And AddEdit = 2 And NewId <> "err" Then
                NewId_Classification = NewId
            End If
            Designer_Classification()
        End If
    End Sub
    ' удалить классификацию
    Private Sub btnDeleteClassfication()
        Dim RowNumber As Integer = Me.gvClassification.FocusedRowHandle
        If XtraMessageBox.Show("Классификация <b>" & Me.gvClassification.GetFocusedRowCellDisplayText("Name") & "</b> " & Chr(10) &
                               "и принадлежащая ей продукция будет удалена из справочника!" & Chr(10) &
                               "Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) = DialogResult.Yes Then
            ExecuteScalar(
                          "EXEC Books_ClassificationsProducts " &
                                "@IdClassifications = " & Me.gvClassification.GetFocusedRowCellDisplayText("Id") & ", " &
                                "@Parameter = 1, " &
                                "@Function = 4",
                          "Books_ClassificationsProducts.Function = 4"
                          )
            Designer_Classification()
            If iDataSet.Tables("Books_Classification." & Me.Name).Rows.Count = 0 Then
                iDataSet.Tables("Books_Products." & Me.Name).Rows.Clear()
            End If
            Me.gvClassification.FocusedRowHandle = (RowNumber - 1)
        End If
    End Sub
    ' вызов контекстного меню на классификациях
    Private Sub gvPerformers_MouseDown(sender As Object, e As MouseEventArgs) Handles gvClassification.MouseDown
        Dim view As GridView = CType(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If e.Button = MouseButtons.Right Then
            Me.btnEditClassifications.Enabled = info.InRow
            Me.btnDeleteClassifications.Enabled = info.InRow
            Me.pmMenuClassifications.ShowPopup(MousePosition)
        End If
        If info.InRow And e.Button = MouseButtons.Left And e.Clicks = 2 Then
            btnEditClassifications_ItemClick(e, Nothing)
        End If
    End Sub
#Region "Контекстное меню"
    ' добавить классификацию
    Private Sub btnAddClassifications_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAddClassifications.ItemClick
        gcnClassification_CustomButtonClick(Me.gcnClassification, New Docking2010.BaseButtonEventArgs(Me.gcnClassification.CustomHeaderButtons.Item(0)))
    End Sub
    ' редактировать классификацию
    Private Sub btnEditClassifications_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEditClassifications.ItemClick
        gcnClassification_CustomButtonClick(Me.gcnClassification, New Docking2010.BaseButtonEventArgs(Me.gcnClassification.CustomHeaderButtons.Item(1)))
    End Sub
    ' удалить классификацию
    Private Sub btnDeleteClassifications_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnDeleteClassifications.ItemClick
        gcnClassification_CustomButtonClick(Me.gcnClassification, New Docking2010.BaseButtonEventArgs(Me.gcnClassification.CustomHeaderButtons.Item(2)))
    End Sub
#End Region
    ' удалить или редактировать классификацию клавишей
    Private Sub gvClassification_KeyDown(sender As Object, e As KeyEventArgs) Handles gvClassification.KeyDown
        If sender.FocusedRowHandle < 0 Then Exit Sub
        If e.KeyCode = Keys.Delete Then
            btnDeleteClassifications_ItemClick(e, Nothing)
        End If
        If e.KeyCode = Keys.Enter Then
            btnEditClassifications_ItemClick(e, Nothing)
        End If
    End Sub

#End Region

#Region "Придукция"
    ' настройка таблицы с продукцией
    Private Sub Designer_Products(ByVal ParentId As String)
        EventChangedControl_Products = False
        SelectQueryData(
                        "Books_Products." & Me.Name,
                        "EXEC Books_ClassificationsProducts @IdClassifications = " & ParentId & ", @Parameter = 2, @Function = 1",
                        "GetProducts"
                        )
        If Me.gcProducts.DataSource Is Nothing Then
            Me.gcProducts.DataSource = iDataSet.Tables("Books_Products." & Me.Name)
            HidenAllColumns_Grid(Me.gvProducts, iDataSet.Tables("Books_Products." & Me.Name))
            Me.gvProducts.Columns("WeightSample").Visible = True
            Me.gvProducts.Columns("WeightSample").Caption = "Средний вес пробы, г."
            Me.gvProducts.Columns("Name").Visible = True
            Me.gvProducts.Columns("Name").Caption = "Наименование продукции"
            Me.gvProducts.Columns("WeightSample").BestFit()
        End If
        EventChangedControl_Products = True
        ' активная строка из памяти
        Me.gvProducts.FocusedRowHandle = Me.gvProducts.LocateByValue("Id", CType(NewId_Products, Integer))
    End Sub
    ' группа кнопок продукций
    Private Sub gcnProducts_CustomButtonClick(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles gcnProducts.CustomButtonClick
        Dim btnAddEdit As Boolean = False
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.Caption
            Case "btnAddProducts" : frAddEditProducts.AddEdit = 2 : btnAddEdit = True
            Case "btnEditProducts" : If Me.gvProducts.RowCount <> 0 Then frAddEditProducts.AddEdit = 3 : btnAddEdit = True
            Case "btnDeleteProducts" : If Me.gvProducts.RowCount <> 0 Then btnDeleteProduct()
            Case "btnClearSort_Products" : Me.gvProducts.ClearSorting()
        End Select
        ' если добавление или редактирование
        If btnAddEdit Then
            If frAddEditProducts.ShowDialog() = DialogResult.OK Then
                Designer_Products(Me.gvClassification.GetFocusedRowCellDisplayText("Id"))
            End If
        End If
    End Sub
    ' группа чеков продукций
    Private Sub gcnProducts_CustomButtonChecked(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles gcnProducts.CustomButtonChecked, gcnProducts.CustomButtonUnchecked
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.Caption
            Case "btnSearch_Products"
                Me.gvProducts.OptionsFind.AlwaysVisible = btn.Checked
                ' при отключении очищаем фильтрацию
                If btn.Checked = False Then Me.gvProducts.FindFilterText = Nothing
            Case "btnAutoFilter_Products"
                Me.gvProducts.OptionsView.ShowAutoFilterRow = btn.Checked
                ' при отключении очищаем фильтрацию
                If btn.Checked = False Then Me.gvProducts.ClearColumnsFilter()
        End Select
    End Sub
    ' фокус на продукцию
    Private Sub gvProducts_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvProducts.FocusedRowChanged
        If sender.FocusedRowHandle < 0 Then Exit Sub
        Dim iRow As DataRow = sender.GetFocusedDataRow
        If e.FocusedRowHandle < 0 Then Exit Sub
        If EventChangedControl_Products Then NewId_Products = iRow("Id").ToString
    End Sub
    ' удалить продукцию
    Private Sub btnDeleteProduct()
        Dim RowNumber As Integer = Me.gvProducts.FocusedRowHandle
        If XtraMessageBox.Show("Продукция с наименованием <b>" & Me.gvProducts.GetFocusedRowCellDisplayText("Name") & "</b> будет удалена!" & Chr(10) &
                                           "Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) = DialogResult.Yes Then
            ExecuteScalar(
                          "EXEC Books_ClassificationsProducts " &
                                "@IdProducts = " & Me.gvProducts.GetFocusedRowCellDisplayText("Id") & ", " &
                                "@Parameter = 2, " &
                                "@Function = 4",
                          "Books_ClassificationsProducts.Function = 4"
                          )
            Designer_Products(Me.gvClassification.GetFocusedRowCellDisplayText("Id"))
            Me.gvProducts.FocusedRowHandle = RowNumber - 1
        End If
    End Sub
    ' вызов контекстного меню на продукции
    Private Sub gvProducts_MouseDown(sender As Object, e As MouseEventArgs) Handles gvProducts.MouseDown
        Dim view As GridView = CType(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If e.Button = MouseButtons.Right Then
            Me.btnEditProducts.Enabled = info.InRow
            Me.btnDeleteProducts.Enabled = info.InRow
            Me.pmMenuProducts.ShowPopup(MousePosition)
        End If
        If info.InRow And e.Button = MouseButtons.Left And e.Clicks = 2 Then
            btnEditProducts_ItemClick(e, Nothing)
        End If
    End Sub
#Region "Контекстное меню"
    ' добавить продукцию
    Private Sub btnAddProducts_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAddProducts.ItemClick
        gcnProducts_CustomButtonClick(Me.gcnClassification, New Docking2010.BaseButtonEventArgs(Me.gcnProducts.CustomHeaderButtons.Item(0)))
    End Sub
    ' редактировать продукцию
    Private Sub btnEditProducts_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEditProducts.ItemClick
        gcnProducts_CustomButtonClick(Me.gcnClassification, New Docking2010.BaseButtonEventArgs(Me.gcnProducts.CustomHeaderButtons.Item(1)))
    End Sub
    ' удалить продукцию
    Private Sub btnDeleteProducts_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnDeleteProducts.ItemClick
        gcnProducts_CustomButtonClick(Me.gcnClassification, New Docking2010.BaseButtonEventArgs(Me.gcnProducts.CustomHeaderButtons.Item(2)))
    End Sub
#End Region
    ' удалить или редактировать продукцию клавишей
    Private Sub gvProducts_KeyDown(sender As Object, e As KeyEventArgs) Handles gvProducts.KeyDown
        If sender.FocusedRowHandle < 0 Then Exit Sub
        If e.KeyCode = Keys.Delete And sender.FocusedRowHandle >= 0 Then
            btnDeleteProducts_ItemClick(e, Nothing)
        End If
        If e.KeyCode = Keys.Enter And sender.FocusedRowHandle >= 0 Then
            btnEditProducts_ItemClick(e, Nothing)
        End If
    End Sub
#End Region

    ' проверка полей по таймеру
    Private Sub tmChecked_Tick(sender As Object, e As EventArgs) Handles tmChecked.Tick
        Dim gvClassificationRowCount As Integer = Me.gvClassification.RowCount  ' кол-во классификаций
        Dim gvProductsRowCount As Integer = Me.gvProducts.RowCount              ' кол-во продукций
        ' классификации
        Me.gcnClassification.CustomHeaderButtons.Item(1).Properties.Enabled = (gvClassificationRowCount <> 0)   ' редактировать
        Me.gcnClassification.CustomHeaderButtons.Item(2).Properties.Enabled = (gvClassificationRowCount <> 0)   ' удалить
        ' продукция
        Me.btnAddProducts.Enabled = (gvClassificationRowCount <> 0)                                             ' добавить в меню
        Me.gcnProducts.CustomHeaderButtons.Item(0).Properties.Enabled = (gvClassificationRowCount <> 0)         ' добавить
        Me.gcnProducts.CustomHeaderButtons.Item(1).Properties.Enabled = (gvProductsRowCount <> 0)               ' редактировать
        Me.gcnProducts.CustomHeaderButtons.Item(2).Properties.Enabled = (gvProductsRowCount <> 0)               ' удалить
        ' подсчет столбцов с примененной сортировкой
        Dim ColCount As Integer = 0
        For Each c As GridColumn In Me.gvClassification.SortedColumns
            ColCount += 1
        Next
        Me.gcnClassification.CustomHeaderButtons.Item(6).Properties.Enabled = (ColCount <> 0)
        ' подсчет столбцов с примененной сортировкой
        ColCount = 0
        For Each c As GridColumn In Me.gvProducts.SortedColumns
            ColCount += 1
        Next
        Me.gcnProducts.CustomHeaderButtons.Item(6).Properties.Enabled = (ColCount <> 0)
    End Sub

    ' обновление формы
    Private Sub btnUpdate_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnUpdate.ItemClick
        Designer_Classification()
    End Sub
End Class