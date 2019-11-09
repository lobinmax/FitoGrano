Imports System.Data
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ButtonsPanelControl
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraTab
Imports DevExpress.XtraTreeList.Nodes

Public Class frBooks_CountryAgreements
    Dim PreferenceForms As String       ' Ветка в реестре для хранения настроек формы 
    Friend NewId_Countries As String    ' Ид новой страны
    Friend NewId_Agreement As String    ' Ид нового соглашения

    ' закрытие формы
    Private Sub frBooks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        clsMyUserFunction.RemoveTableDataSet(Me)
        clsMyUserFunction.SaveViewForm(Me)
        RegistryWrite(PreferenceForms, "SplitterPosition", Me.SplitContainerControl1.SplitterPosition)
        RegistryWrite(PreferenceForms, "gvCountries.ShowFilterRow", Me.gvCountries.OptionsView.ShowAutoFilterRow.ToString)
        RegistryWrite(PreferenceForms, "gvCountries.ShowFindPanel", Me.gvCountries.OptionsFind.AlwaysVisible.ToString)
        RegistryWrite(PreferenceForms, "gvAgreements.ShowFilterRow", Me.gvAgreement.OptionsView.ShowAutoFilterRow.ToString)
        RegistryWrite(PreferenceForms, "gvAgreements.ShowFindPanel", Me.gvAgreement.OptionsFind.AlwaysVisible.ToString)
    End Sub
    ' загрузка формы
    Private Sub frBooks_ResearchObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' настройка элементов
        PreferenceForms = pref_UserSettings & Me.Name & "\"
        clsMyUserFunction.LoadViewForm(Me)
        Me.SplitContainerControl1.SplitterPosition = RegistryRead(PreferenceForms, "SplitterPosition", 252)
        Me.gcnCountries.CustomHeaderButtons.Item(4).Properties.Checked = RegistryRead(PreferenceForms, "gvCountries.ShowFindPanel", False)
        Me.gcnCountries.CustomHeaderButtons.Item(5).Properties.Checked = RegistryRead(PreferenceForms, "gvCountries.ShowFilterRow", False)
        Me.gcnAgreements.CustomHeaderButtons.Item(4).Properties.Checked = RegistryRead(PreferenceForms, "gvAgreements.ShowFindPanel", False)
        Me.gcnAgreements.CustomHeaderButtons.Item(5).Properties.Checked = RegistryRead(PreferenceForms, "gvAgreements.ShowFilterRow", False)
        Me.lbProductIdIsNull.Parent = Me.tlObjectsQurantine.tlQurantineObjects
        Me.tlObjectsQurantine.tlQurantineObjects.OptionsView.ShowPreview = True
        Me.tlObjectsQurantine.tlQurantineObjects.PreviewFieldName = "PreviewString"
        Me.tlObjectsQurantine.tlQurantineObjects.OptionsView.AutoCalcPreviewLineCount = True
        Me.tlObjectsQurantine.tlQurantineObjects.OptionsView.ShowHorzLines = True
        Me.tlObjectsQurantine.tlQurantineObjects.OptionsView.ShowVertLines = True

        ' измерение содержания
        SelectQueryData("Units." & Me.Name, "SELECT bu.Id, bu.Name FROM Books_Units bu", "GetUnits")
        Me.cmbUnits.Properties.DataSource = iDataSet.Tables("Units." & Me.Name)
        Me.cmbUnits.Properties.ValueMember = "Id"
        Me.cmbUnits.Properties.DisplayMember = "Name"
        Me.cmbUnits.Properties.KeyMember = "Name"

        Me.cmbUnits.Properties.PopulateColumns()
        Me.cmbUnits.Properties.Columns("Id").Visible = False


        Dim SelectedTabPage As String = RegistryRead(PreferenceForms, "SelectedTabPage", "")
        For Each tb As XtraTabPage In Me.XtraTabControl.TabPages
            If tb.Name = SelectedTabPage Then
                Me.XtraTabControl.SelectedTabPage = tb
            End If
        Next
        Me.lbDB_name.Caption = pref_DataBaseName
        Me.lbServerName.Caption = pref_ServerIP
        Designer_Countries()

        ' активируем событие на первой строке в странах
        gvCountries_FocusedRowChanged(gvCountries, New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(0, 0))

        ' добавляем обработку событий на дереве продукции
        AddHandler Me.tlClassificationProducts.tlClassification.AfterFocusNode, AddressOf tlClassification_AfterFocusNode
        AddHandler Me.tlObjectsQurantine.tlQurantineObjects.AfterFocusNode, AddressOf tlQurantineObjects_AfterFocusNode
    End Sub

#Region "Страны"
    ' настройка списка стран
    Private Sub Designer_Countries()
        EventChangedControl = False
        SelectQueryData(
                       "Books_Contries." & Me.Name,
                       "EXEC Books_CountriesFunction @Parameter = 1, @Function = 1",
                       "GetCountries"
                       )
        If Me.gcCountries.DataSource Is Nothing Then
            Me.gcCountries.DataSource = iDataSet.Tables("Books_Contries." & Me.Name)
            mdHidenAllColumns.HidenAllColumns_Grid(Me.gvCountries, iDataSet.Tables("Books_Contries." & Me.Name))
            Me.gvCountries.Columns("Name_a1").Visible = True
            Me.gvCountries.Columns("Name_a1").Caption = "Наименование"
        End If
        EventChangedControl = True
        Me.gvCountries.FocusedRowHandle = Me.gvCountries.LocateByValue("Id", CType(NewId_Countries, Integer))
    End Sub
    ' группа кнопок стран
    Private Sub gcnObjects_CustomButtonClick(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles gcnCountries.CustomButtonClick
        Dim btnAddEdit As Boolean = False
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.VisibleIndex
            Case 0 : frAddEditCountry.AddEdit = 2 : btnAddEdit = True
            Case 1 : If Me.gvCountries.RowCount <> 0 Then frAddEditCountry.AddEdit = 3 : btnAddEdit = True
            Case 2 : If Me.gvCountries.RowCount <> 0 Then DeleteCountry()
            Case 6 : Me.gvCountries.ClearSorting()
        End Select
        ' если добавление или редактирование
        If btnAddEdit Then
            If frAddEditCountry.ShowDialog() = DialogResult.OK Then
                Designer_Countries()
            End If
        End If
    End Sub
    ' группа чеков стран
    Private Sub gcnCountries_CustomButtonChecked(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles gcnCountries.CustomButtonChecked, gcnCountries.CustomButtonUnchecked
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.VisibleIndex
            Case 4
                Me.gvCountries.OptionsFind.AlwaysVisible = btn.Checked
                ' при отключении очищаем фильтрацию
                If btn.Checked = False Then Me.gvCountries.FindFilterText = Nothing
            Case 5
                Me.gvCountries.OptionsView.ShowAutoFilterRow = btn.Checked
                ' при отключении очищаем фильтрацию
                If btn.Checked = False Then Me.gvCountries.ClearColumnsFilter()
        End Select
    End Sub
    ' удалить или редактировать объект клавиатурой
    Private Sub gvCountries_KeyDown(sender As Object, e As KeyEventArgs) Handles gvCountries.KeyDown
        If sender.FocusedRowHandle < 0 Then Exit Sub
        If e.KeyCode = Keys.Delete Then ' удаление
            btnDelCountry_ItemClick(e, Nothing)
        End If
        If e.KeyCode = Keys.Enter Then ' редиктирование
            btnEditCountry_ItemClick(e, Nothing)
        End If
    End Sub
    ' удаление страны
    Private Sub DeleteCountry()
        Dim RowNumber As Integer = Me.gvCountries.FocusedRowHandle
        Dim vl As String    ' что вернет сервер 
        If XtraMessageBox.Show("Страна с именем <b>" & Me.gvCountries.GetFocusedRowCellDisplayText("NameShort") & "</b> будет удалена!" & Chr(10) &
                               "Имейте ввиду что так же будут удалены все сущности принадлежащие данной стране! " & Chr(10) &
                               "Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) = DialogResult.Yes Then
            vl = ExecuteScalar(
                          "EXEC Books_CountriesFunction " &
                               "@CountryId = " & Me.gvCountries.GetFocusedRowCellDisplayText("Id") & ", " &
                               "@Parameter = 1," &
                               "@Function = 4",
                          "Books_CountriesFunction.Function = 4, Parameter = 1"
                          )
            If vl <> "err" Then
                Me.gvCountries.FocusedRowHandle = RowNumber - 1
            End If
            Designer_Countries()
        End If
    End Sub
    ' вызов контекстного меню на объектах
    Private Sub gvCountries_MouseDown(sender As Object, e As MouseEventArgs) Handles gvCountries.MouseDown
        Dim view As GridView = CType(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If e.Button = MouseButtons.Right Then
            Me.btnEditCountry.Enabled = info.InRow
            Me.btnDeleteCountry.Enabled = info.InRow
            Me.pmMenuCountries.ShowPopup(MousePosition)
        End If
        ' двойной клик для редактирования
        If info.InRow And e.Button = MouseButtons.Left And e.Clicks = 2 Then
            btnEditCountry_ItemClick(e, Nothing)
        End If
    End Sub

#Region "Контекстное меню на странах"
    ' добавить страну
    Private Sub btnAddCountry_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAddCountry.ItemClick
        gcnObjects_CustomButtonClick(Me.gcnCountries, New Docking2010.BaseButtonEventArgs(Me.gcnCountries.CustomHeaderButtons.Item(0)))
    End Sub
    ' редактировать страну
    Private Sub btnEditCountry_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEditCountry.ItemClick
        gcnObjects_CustomButtonClick(Me.gcnCountries, New Docking2010.BaseButtonEventArgs(Me.gcnCountries.CustomHeaderButtons.Item(1)))
    End Sub
    ' удалить страну
    Private Sub btnDelCountry_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnDeleteCountry.ItemClick
        gcnObjects_CustomButtonClick(Me.gcnCountries, New Docking2010.BaseButtonEventArgs(Me.gcnCountries.CustomHeaderButtons.Item(2)))
    End Sub
#End Region
    ' фокус на стране
    Private Sub gvCountries_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvCountries.FocusedRowChanged
        If e.FocusedRowHandle < 0 Then Exit Sub
        Dim iRow As DataRow = sender.GetFocusedDataRow
        If EventChangedControl Then
            NewId_Countries = iRow("Id").ToString
            ' настройка Карантинов
            Designer_Quarantine()
            Me.tlClassificationProducts.SetCaptionTreeList("Классификация продукции: " & Chr(10) &
                                                           Me.gvCountries.GetFocusedRowCellDisplayText("NameShort"))
            ' настройка Соглашений
            Designer_Agreements()
        End If
    End Sub
#End Region


#Region "Карантинные объекты"
    Private Sub Designer_Quarantine()
        tlClassificationProducts.LoadTreeList(CountryId:=Me.gvCountries.GetFocusedRowCellDisplayText("Id"), FilterParametr:="=")
    End Sub

    Private Sub tlClassification_AfterFocusNode()
        Dim CountryId As String = Me.gvCountries.GetFocusedRowCellDisplayText("Id")
        Dim ProductId As String = Me.tlClassificationProducts.GetFocusedProductId

        If ProductId = "NULL" Then
            Me.tlObjectsQurantine.ClearDataSet()
            Me.lbProductIdIsNull.Visible = True
        Else
            Me.lbProductIdIsNull.Visible = False
            Me.tlObjectsQurantine.LoadTreeList(TableName:=Nothing,
                                               CountryId:=CountryId,
                                               ProductId:=ProductId)
        End If
    End Sub

    Private Sub tlQurantineObjects_AfterFocusNode()
        Dim nd As TreeListNode = Me.tlObjectsQurantine.tlQurantineObjects.FocusedNode

        If nd("Level") = 0 Then
            Me.gcObjectIformation.Visible = False
            Me.tlObjectsQurantine.Size = New System.Drawing.Size(Me.tlObjectsQurantine.Size.Width, Me.tlClassificationProducts.Size.Height)
        Else
            Me.gcObjectIformation.Visible = True
            Me.txtNorma.EditValue = nd("NormValue")
            Me.cmbUnits.EditValue = nd("UnitId")
        End If
    End Sub
#End Region

#Region "Соглашения"
    ' настройка списка соглашений
    Private Sub Designer_Agreements()
        EventChangedControl = False
        SelectQueryData(
                       "Books_Agreementss." & Me.Name,
                       "EXEC Books_CountriesFunction 
                            @CountryId = " & Me.gvCountries.GetFocusedRowCellDisplayText("Id") & ", 
                            @Parameter = 2, 
                            @Function = 1",
                       "GetAgreements"
                       )
        If Me.gcAgreement.DataSource Is Nothing Then
            Me.gcAgreement.DataSource = iDataSet.Tables("Books_Agreementss." & Me.Name)
            mdHidenAllColumns.HidenAllColumns_Grid(Me.gvAgreement, iDataSet.Tables("Books_Agreementss." & Me.Name))
            Me.gvAgreement.Columns("AgreementText").Visible = True
            Me.gvAgreement.Columns("AgreementText").Caption = "Текст соглашения"
            ' для многострочного отображения подключаем репозиторий
            Me.gvAgreement.Columns("AgreementText").ColumnEdit = New RepositoryItemMemoEdit
        End If
        EventChangedControl = True
        Me.gvAgreement.FocusedRowHandle = Me.gvAgreement.LocateByValue("Id", CType(NewId_Agreement, Integer))
    End Sub
    ' группа кнопок соглашений
    Private Sub gcnAgreements_CustomButtonClick(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles gcnAgreements.CustomButtonClick
        Dim btnAddEdit As Boolean = False
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.VisibleIndex
            Case 0 : frAddEditCountryAgreement.AddEdit = 2 : btnAddEdit = True
            Case 1 : If Me.gvAgreement.RowCount <> 0 Then frAddEditCountryAgreement.AddEdit = 3 : btnAddEdit = True
            Case 2 : If Me.gvAgreement.RowCount <> 0 Then DeleteAgreement()
            Case 6 : Me.gvAgreement.ClearSorting()
        End Select
        ' если добавление или редактирование
        If btnAddEdit Then
            If frAddEditCountryAgreement.ShowDialog() = DialogResult.OK Then
                Designer_Agreements()
            End If
        End If
    End Sub
    ' группа чеков соглашений
    Private Sub gcnAgreements_CustomButtonChecked(sender As Object, e As Docking2010.BaseButtonEventArgs) Handles gcnAgreements.CustomButtonChecked, gcnAgreements.CustomButtonUnchecked
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.VisibleIndex
            Case 4
                Me.gvAgreement.OptionsFind.AlwaysVisible = btn.Checked
                ' при отключении очищаем фильтрацию
                If btn.Checked = False Then Me.gvAgreement.FindFilterText = Nothing
            Case 5
                Me.gvAgreement.OptionsView.ShowAutoFilterRow = btn.Checked
                ' при отключении очищаем фильтрацию
                If btn.Checked = False Then Me.gvAgreement.ClearColumnsFilter()
        End Select
    End Sub
    ' удаление соглашения
    Private Sub DeleteAgreement()
        Dim RowNumber As Integer = Me.gvAgreement.FocusedRowHandle
        Dim vl As String    ' что вернет сервер 
        If XtraMessageBox.Show("Соглашение по стране <b>" & Me.gvCountries.GetFocusedRowCellDisplayText("Name_a1") & "</b> будет удалено!" & Chr(10) &
                               "Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) = DialogResult.Yes Then
            vl = ExecuteScalar(
                              "EXEC Books_CountriesFunction " &
                              "@AgreementId = " & Me.gvAgreement.GetFocusedRowCellDisplayText("AgreementId") & ", " &
                              "@Parameter = 2," &
                              "@Function = 4",
                              "Books_CountriesFunction.Function = 4, Parameter = 2"
                              )
            If vl <> "err" Then
                Me.gvAgreement.FocusedRowHandle = RowNumber - 1
                Designer_Agreements()
            End If
        End If
    End Sub
    ' вызов контекстного меню на объектах
    Private Sub gvAgreement_MouseDown(sender As Object, e As MouseEventArgs) Handles gvAgreement.MouseDown
        Dim view As GridView = CType(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If e.Button = MouseButtons.Right Then
            Me.btnEditAgreement.Enabled = info.InRow
            Me.btnDeleteAgreement.Enabled = info.InRow
            Me.pmMenuAgreements.ShowPopup(MousePosition)
        End If
        ' двойной клик для редактирования
        If info.InRow And e.Button = MouseButtons.Left And e.Clicks = 2 Then
            btnEditAgreement_ItemClick(e, Nothing)
        End If
    End Sub

#Region "Контекстное меню на соглашениях"
    ' добавить соглашение
    Private Sub btnAddAgreement_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAddAgreement.ItemClick
        gcnAgreements_CustomButtonClick(Me.gcnAgreements, New Docking2010.BaseButtonEventArgs(Me.gcnAgreements.CustomHeaderButtons.Item(0)))
    End Sub
    ' редактировать соглашение
    Private Sub btnEditAgreement_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEditAgreement.ItemClick
        gcnAgreements_CustomButtonClick(Me.gcnAgreements, New Docking2010.BaseButtonEventArgs(Me.gcnAgreements.CustomHeaderButtons.Item(1)))
    End Sub
    ' удалить Соглашение
    Private Sub btnDeleteAgreement_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnDeleteAgreement.ItemClick
        gcnAgreements_CustomButtonClick(Me.gcnAgreements, New Docking2010.BaseButtonEventArgs(Me.gcnAgreements.CustomHeaderButtons.Item(2)))
    End Sub
#End Region
    ' фокус на соглашении
    Private Sub gvAgreement_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvAgreement.FocusedRowChanged
        If e.FocusedRowHandle < 0 Then Exit Sub
        Dim iRow As DataRow = sender.GetFocusedDataRow
        If EventChangedControl Then NewId_Agreement = iRow("AgreementId").ToString
    End Sub
#End Region






    Private Sub XtraTabControl_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles XtraTabControl.SelectedPageChanged
        If Me.XtraTabControl.SelectedTabPage IsNot Nothing Then
            RegistryWrite(PreferenceForms, "SelectedTabPage", Me.XtraTabControl.SelectedTabPage.Name.ToString)
        End If
    End Sub

    ' проверка полей по таймеру
    Private Sub tmChecked_Tick(sender As Object, e As EventArgs) Handles tmChecked.Tick
        Dim CountryCount As Integer = Me.gvCountries.RowCount
        Dim AgreementCount As Integer = Me.gvAgreement.RowCount

        ' страны
        Me.gcnCountries.CustomHeaderButtons.Item(1).Properties.Enabled = CountryCount <> 0
        Me.btnEditCountry.Enabled = CountryCount <> 0
        Me.gcnCountries.CustomHeaderButtons.Item(2).Properties.Enabled = CountryCount <> 0
        Me.btnDeleteCountry.Enabled = CountryCount <> 0

        ' соглашения
        Me.gcnAgreements.CustomHeaderButtons.Item(0).Properties.Enabled = CountryCount <> 0
        Me.btnAddAgreement.Enabled = CountryCount <> 0
        Me.gcnAgreements.CustomHeaderButtons.Item(1).Properties.Enabled = AgreementCount <> 0
        Me.btnEditAgreement.Enabled = AgreementCount <> 0
        Me.gcnAgreements.CustomHeaderButtons.Item(2).Properties.Enabled = AgreementCount <> 0
        Me.btnDeleteAgreement.Enabled = AgreementCount <> 0

        ' подсчет столбцов с примененной сортировкой
        ' Страны
        Dim ColCount As Integer = 0
        For Each c As GridColumn In Me.gvCountries.SortedColumns
            ColCount += 1
        Next
        Me.gcnCountries.CustomHeaderButtons.Item(6).Properties.Enabled = (ColCount <> 0)

        ' Соглашения
        For Each c As GridColumn In Me.gvAgreement.SortedColumns
            ColCount += 1
        Next
        Me.gcnAgreements.CustomHeaderButtons.Item(6).Properties.Enabled = (ColCount <> 0)
    End Sub

    Private Sub btnUpdate_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnUpdate.ItemClick
        MsgBox("Не реализовано ...")
    End Sub

    Private Sub lbProductIdIsNull_Click(sender As Object, e As EventArgs) Handles lbProductIdIsNull.Click

    End Sub
End Class