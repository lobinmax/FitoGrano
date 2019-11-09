Imports System.Data
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ButtonsPanelControl
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frBooks_ResearchObjects
    Dim PreferenceForms As String       ' Ветка в реестре для хранения настроек формы 
    Dim SelectedObjectType As String        ' активный тип объекта
    Friend NewId_Object As String       ' Ид нового объекта 
    ' закрытие формы
    Private Sub frBooks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        clsMyUserFunction.RemoveTableDataSet(Me)
        clsMyUserFunction.SaveViewForm(Me)
        RegistryWrite(PreferenceForms, "SplitterPosition", Me.SplitContainerControl1.SplitterPosition)
        RegistryWrite(PreferenceForms, "gvObjects.ShowFilterRow", Me.gvObjects.OptionsView.ShowAutoFilterRow.ToString)
        RegistryWrite(PreferenceForms, "gvObjects.ShowFindPanel", Me.gvObjects.OptionsFind.AlwaysVisible.ToString)
        RegistryWrite(PreferenceForms, "SelectedObject", Me.Accord.SelectedElement.Name)
    End Sub
    ' загрузка формы
    Private Sub frBooks_ResearchObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.acRoot.HeaderVisible = False
        ' загрузка объектов
        Designer_ObjectsTypes()
        ' настройка элементов
        PreferenceForms = pref_UserSettings & Me.Name & "\"
        clsMyUserFunction.LoadViewForm(Me)
        Me.SplitContainerControl1.SplitterPosition = RegistryRead(PreferenceForms, "SplitterPosition", 180)
        Me.gcnObjects.CustomHeaderButtons.Item(4).Properties.Checked = RegistryRead(PreferenceForms, "gvObjects.ShowFindPanel", False)
        Me.gcnObjects.CustomHeaderButtons.Item(5).Properties.Checked = RegistryRead(PreferenceForms, "gvObjects.ShowFilterRow", False)
        Me.Accord.SelectedElement = Me.acRoot.Elements.Item(RegistryRead(PreferenceForms, "SelectedObject", Me.acRoot.Elements.Item(0).Name))
        Me.lbDB_name.Caption = pref_DataBaseName
        Me.lbServerName.Caption = pref_ServerIP
    End Sub
    ' выбор типа объекта
    Private Sub Accord_SelectedElementChanged(sender As Object, e As SelectedElementChangedEventArgs) Handles Accord.SelectedElementChanged
        SelectedObjectType = e.Element.Name
        Designer_Objects()
    End Sub
    ' группа кнопок объектов
    Private Sub gcnObjects_CustomButtonClick(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles gcnObjects.CustomButtonClick
        Dim btnAddEdit As Boolean = False
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.Caption
            Case "btnAddObject" : frAddEditObjects.AddEdit = 2 : btnAddEdit = True
            Case "btnEditObject" : If Me.gvObjects.RowCount <> 0 Then frAddEditObjects.AddEdit = 3 : btnAddEdit = True
            Case "btnDeleteObject" : If Me.gvObjects.RowCount <> 0 Then btnDeleteObject()
            Case "btnClearSort_Object" : Me.gvObjects.ClearSorting()
        End Select
        ' если добавление или редактирование
        If btnAddEdit Then
            If frAddEditObjects.ShowDialog() = DialogResult.OK Then
                Designer_Objects()
                Designer_ObjectsTypes()
            End If
        End If
    End Sub
    ' группа чеков объектов
    Private Sub gcnMethods_CustomButtonChecked(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles gcnObjects.CustomButtonChecked, gcnObjects.CustomButtonUnchecked
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.Caption
            Case "btnSearch_Object"
                Me.gvObjects.OptionsFind.AlwaysVisible = btn.Checked
                ' при отключении очищаем фильтрацию
                If btn.Checked = False Then Me.gvObjects.FindFilterText = Nothing
            Case "btnAutoFilter_Object"
                Me.gvObjects.OptionsView.ShowAutoFilterRow = btn.Checked
                ' при отключении очищаем фильтрацию
                If btn.Checked = False Then Me.gvObjects.ClearColumnsFilter()
        End Select
    End Sub
    ' настройки сетки типов объектов
    Private Sub Designer_ObjectsTypes()
        ' загрузка объектов
        SelectQueryData("Books_ObjectsTypes." & Me.Name, "SELECT * FROM vBooks_ObjectsTypes", "GetObjectsTypes")
        Me.acRoot.Elements.Clear()
        For Each r As DataRow In iDataSet.Tables("Books_ObjectsTypes." & Me.Name).Rows
            Dim el As New AccordionControlElement
            el.Name = "btn" & r("Name")
            el.Text = "<image=#" & r("Icon") & ">   " & r("NameCountHtml")
            el.Tag = r("Id")
            el.Style = ElementStyle.Item
            el.Height = 40
            Me.acRoot.Elements.Add(el)
        Next
        Me.Accord.SelectedElement = Me.acRoot.Elements.Item(SelectedObjectType)
    End Sub
    ' настройки сетки объектов
    Private Sub Designer_Objects()
        EventChangedControl = False
        SelectQueryData("Books_Objects." & Me.Name,
                        "EXEC Books_ObjectsFunc @ObjectTypeId = " & Me.Accord.SelectedElement.Tag & ", 
                        @Function = 1")
        If Me.gcObjects.DataSource Is Nothing Then
            Me.gcObjects.DataSource = iDataSet.Tables("Books_Objects." & Me.Name)
            mdHidenAllColumns.HidenAllColumns_Grid(Me.gvObjects, iDataSet.Tables("Books_Objects." & Me.Name))
            Me.gvObjects.Columns("NameLatin").Visible = True
            Me.gvObjects.Columns("NameLatin").Caption = "Наименование(латин)"
            Me.gvObjects.Columns("Name").Visible = True
            Me.gvObjects.Columns("Name").Caption = "Наименование (русс)"
            Me.gvObjects.PreviewFieldName = "MethodsString"
            Me.gvObjects.BestFitColumns()
        End If
        EventChangedControl = True
        ' активная строка из памяти
        Me.gvObjects.FocusedRowHandle = Me.gvObjects.LocateByValue("Id", CType(NewId_Object, Integer))
    End Sub
    ' удалить или редактировать объект клавиотурой
    Private Sub gvObjects_KeyDown(sender As Object, e As KeyEventArgs) Handles gvObjects.KeyDown
        If sender.FocusedRowHandle < 0 Then Exit Sub
        If e.KeyCode = Keys.Delete Then
            btnDelObject_ItemClick(e, Nothing)
        End If
        If e.KeyCode = Keys.Enter Then
            btnEditObject_ItemClick(e, Nothing)
        End If
    End Sub
    ' удаление объекта
    Private Sub btnDeleteObject()
        Dim RowNumber As Integer = Me.gvObjects.FocusedRowHandle
        If XtraMessageBox.Show("Объект исследования с именем <b>" & Me.gvObjects.GetFocusedRowCellDisplayText("Name") & "</b> будет удален!" & Chr(10) &
                               "Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) = DialogResult.Yes Then
            ExecuteScalar(
                          "EXEC Books_ObjectsFunc " &
                               "@ObjectId = " & Me.gvObjects.GetFocusedRowCellDisplayText("Id") & ", " &
                               "@Function = 4",
                          "Books_ClassificationsProducts.Function = 4"
                          )
            Designer_Objects()
            Designer_ObjectsTypes()
            Me.gvObjects.FocusedRowHandle = RowNumber - 1
        End If
    End Sub
    ' вызов контекстного меню на объектах
    Private Sub gvObjects_MouseDown(sender As Object, e As MouseEventArgs) Handles gvObjects.MouseDown
        Dim view As GridView = CType(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If e.Button = MouseButtons.Right Then
            Me.btnEditObject.Enabled = info.InRow
            Me.btnDelObject.Enabled = info.InRow
            Me.pmObjects.ShowPopup(MousePosition)
        End If
        If info.InRow And e.Button = MouseButtons.Left And e.Clicks = 2 Then
            btnEditObject_ItemClick(e, Nothing)
        End If
    End Sub
    ' фокус на объектах
    Private Sub gvObjects_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvObjects.FocusedRowChanged
        If e.FocusedRowHandle < 0 Then Exit Sub
        Dim iRow As DataRow = sender.GetFocusedDataRow
        If EventChangedControl Then NewId_Object = iRow("Id").ToString
    End Sub

#Region "Контекстное меню на объектах"
    ' добавить объект
    Private Sub btnAddObject_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAddObject.ItemClick
        gcnObjects_CustomButtonClick(Me.gcnObjects, New Docking2010.BaseButtonEventArgs(Me.gcnObjects.CustomHeaderButtons.Item(0)))
    End Sub
    ' редактировать объект
    Private Sub btnEditObject_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEditObject.ItemClick
        gcnObjects_CustomButtonClick(Me.gcnObjects, New Docking2010.BaseButtonEventArgs(Me.gcnObjects.CustomHeaderButtons.Item(1)))
    End Sub
    ' удалить объект
    Private Sub btnDelObject_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnDelObject.ItemClick
        gcnObjects_CustomButtonClick(Me.gcnObjects, New Docking2010.BaseButtonEventArgs(Me.gcnObjects.CustomHeaderButtons.Item(2)))
    End Sub
#End Region

    ' кнопка Обновить
    Private Sub btnUpdate_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnUpdate.ItemClick
        Designer_Objects()
    End Sub
    ' проверка полей по таймеру
    Private Sub tmChecked_Tick(sender As Object, e As EventArgs) Handles tmChecked.Tick
        Dim ObjectsCount As Integer = Me.gvObjects.RowCount
        Me.gcnObjects.CustomHeaderButtons.Item(0).Properties.Enabled = Me.acRoot.Elements.Count <> 0
        Me.btnAddObject.Enabled = Me.acRoot.Elements.Count <> 0
        Me.gcnObjects.CustomHeaderButtons.Item(1).Properties.Enabled = ObjectsCount <> 0
        Me.btnEditObject.Enabled = ObjectsCount <> 0
        Me.gcnObjects.CustomHeaderButtons.Item(2).Properties.Enabled = ObjectsCount <> 0
        Me.btnDelObject.Enabled = ObjectsCount <> 0
        ' подсчет столбцов с примененной сортировкой
        Dim ColCount As Integer = 0
        For Each c As GridColumn In Me.gvObjects.SortedColumns
            ColCount += 1
        Next
        Me.gcnObjects.CustomHeaderButtons.Item(6).Properties.Enabled = (ColCount <> 0)
    End Sub
End Class