Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ButtonsPanelControl
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Public Class ucTreeListObjectsQurantine
    Dim ImageCol As New ImageCollection                     ' Коллекция иконок
    Dim SelectedItemId As Integer                           ' Текущая ветка
    Dim _TableName As String
    Dim _CountryId As String
    Dim _ProductId As String

    Dim ndList As New List(Of ConditionNodeList)            ' Коллекция состояний нодов
    Dim NodeList As ConditionNodeList                       ' Запись для добавления в коллекцию
    Dim PreferenceForms As String                           ' Ветка в реестре для хранения настроек формы 
    Public Property UserControlProperty() As UserControlProp

    <TypeConverter(GetType(ExpandableObjectConverter))>
    Public Class UserControlProp
        Public _btnMultiCheckingIsVisible As Boolean = True
        Public _ColumnsNameInTreeList As String = "Name"
        Public _IsCheckBoxes As Boolean = True
        Public _IsShortForm As Boolean = False

        <Description("Имя отбражаемого столбца"), DefaultValue("Name")>
        Public Property ColumnsNameInTreeList() As String
            Get
                If _ColumnsNameInTreeList Is Nothing Then
                    Return "Name"
                Else
                    Return _ColumnsNameInTreeList
                End If
            End Get
            Set
                If Value Is Nothing Then
                    _ColumnsNameInTreeList = "Name"
                Else
                    _ColumnsNameInTreeList = Value
                End If
            End Set
        End Property
        <Description("Видимость кнопки мультивыбор"), DefaultValue(True)>
        Public Property btnMultiCheckingIsVisible() As Boolean
            Get
                Return _btnMultiCheckingIsVisible
            End Get
            Set
                _btnMultiCheckingIsVisible = Value
            End Set
        End Property
        <Description("Вкл/выкл чекбоксы в дереве"), DefaultValue(True)>
        Public Property IsCheckBoxes() As Boolean
            Get
                Return _IsCheckBoxes
            End Get
            Set
                _IsCheckBoxes = Value
            End Set
        End Property
        <Description("Вкл/выкл усеченной формы. Только TreeList для выбора узлов"), DefaultValue(False)>
        Public Property IsShortForm() As Boolean
            Get
                Return _IsShortForm
            End Get
            Set
                _IsShortForm = Value
            End Set
        End Property
    End Class

    Public Sub New()
        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавить код инициализации после вызова InitializeComponent().
        UserControlProperty = New UserControlProp() ' подключаем дополнительные свойства 
    End Sub
    ' коллекции состяния нодов
    Private Structure ConditionNodeList
        Dim Id As Integer           ' Ид нода
        Dim Expanded As Boolean     ' Состояноие нода
        Dim Checked As Boolean      ' Чек нода
    End Structure

    ' загрузка контрола
    Private Sub ucTreeListResearchMetods_Load(sender As Object, e As EventArgs) Handles Me.Load
        PreferenceForms = pref_UserSettings & Me.ParentForm.Name & "\"
        If UserControlProperty._IsShortForm Then
            Me.gcnQurantineObjects.Visible = False
            Me.tlQurantineObjects.Parent = Me
        Else
            ' загрузка наcтроек
            Me.gcnQurantineObjects.CustomHeaderButtons.Item(2).Properties.Checked = RegistryRead(PreferenceForms, "gcnQurantineObjects.btnMultiCheck", False)
            Me.gcnQurantineObjects.CustomHeaderButtons.Item(3).Properties.Checked = RegistryRead(PreferenceForms, "gcnQurantineObjects.btnShowSearchRow", False)
            Me.gcnQurantineObjects.CustomHeaderButtons.Item(4).Properties.Checked = RegistryRead(PreferenceForms, "gcnQurantineObjects.btnShowFilterRow", False)
            Me.gcnQurantineObjects.CustomHeaderButtons.Item(2).Properties.Visible = UserControlProperty._btnMultiCheckingIsVisible
            Me.gcnQurantineObjects.CustomHeaderButtons.Item(2).Properties.Checked = UserControlProperty._IsCheckBoxes
            ' проставить чеки недоступны без OptionsView.ShowCheckBoxes = True
            Me.gcnQurantineObjects.CustomHeaderButtons.Item(9).Properties.Enabled = Me.tlQurantineObjects.OptionsView.ShowCheckBoxes
            Me.gcnQurantineObjects.CustomHeaderButtons.Item(10).Properties.Enabled = Me.tlQurantineObjects.OptionsView.ShowCheckBoxes
        End If
        ' событие выгрузки родительской формы
        AddHandler Me.ParentForm.FormClosing, AddressOf ParentForm_FormClosing
        Me.tlQurantineObjects.OptionsView.ShowCheckBoxes = UserControlProperty._IsCheckBoxes
    End Sub
    ' выгрузка родительской формы
    Private Sub ParentForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        clsMyUserFunction.RemoveTableDataSet(sender)
        RegistryWrite(PreferenceForms, "gcnQurantineObjects.btnMultiCheck", Me.tlQurantineObjects.OptionsView.ShowCheckBoxes.ToString)
        RegistryWrite(PreferenceForms, "gcnQurantineObjects.btnShowSearchRow", Me.tlQurantineObjects.OptionsFind.AlwaysVisible.ToString)
        RegistryWrite(PreferenceForms, "gcnQurantineObjects.btnShowFilterRow", Me.tlQurantineObjects.OptionsView.ShowAutoFilterRow.ToString)
    End Sub

    ' Заполняем коллекцию при первом запуске и извлекаем при последующих
    Private Sub Filling_ndList(Optional node As TreeListNode = Nothing,
                               Optional IsFirstRun As Boolean = True)
        If IsFirstRun Then ndList.Clear()
        Select Case IsFirstRun
            Case True ' Первый запуск
                For Each nd As TreeListNode In Me.tlQurantineObjects.Nodes
                    NodeList.Id = nd("Id")
                    NodeList.Expanded = nd.Expanded
                    If tlQurantineObjects.OptionsView.ShowCheckBoxes Then NodeList.Checked = nd.Checked
                    ndList.Add(NodeList)
                    If nd.HasChildren Then Filling_ndList(nd, False)
                Next

            Case Else ' рекурсия
                For Each nd As TreeListNode In node.Nodes
                    NodeList.Id = nd("Id")
                    NodeList.Expanded = nd.Expanded
                    If tlQurantineObjects.OptionsView.ShowCheckBoxes Then NodeList.Checked = nd.Checked
                    ndList.Add(NodeList)
                    If nd.HasChildren Then Filling_ndList(nd, False)
                Next
        End Select
    End Sub

    ''' <summary>Загрузка списка контролеров из базы данных</summary>
    ''' <param name="TableName">Имя таблицы для загрузки данных</param>
    ''' <param name="CountryId">Если NULL, выгружается вся продукция, иначе по стране</param>
    ''' <param name="ProductId">Если NULL, выгружается вся продукция, иначе по продукция</param>
    Public Sub LoadTreeList(Optional ByVal TableName As String = Nothing,
                              Optional ByVal CountryId As String = "NULL",
                              Optional ByVal ProductId As String = "NULL")
        If TableName Is Nothing Then TableName = "ObjectsQurantine." & ParentForm.Name

        _TableName = TableName
        _CountryId = CountryId
        _ProductId = ProductId
        ' загружаем изображения в коллекцию
        If Me.tlQurantineObjects.Nodes.Count <> 0 Then Filling_ndList()
        EventChangedControl = False

        ImageCol.Clear()
        ImageCol.AddImage(My.Resources.microscope_16x16)
        ImageCol.AddImage(My.Resources.bakterii_16x16)
        ImageCol.AddImage(My.Resources.virus_16x16)
        ImageCol.AddImage(My.Resources.gribi16x16)
        ImageCol.AddImage(My.Resources.cleshi_16x16)
        ImageCol.AddImage(My.Resources.molliuski_16x16)
        ImageCol.AddImage(My.Resources.nasekomye_16x16)
        ImageCol.AddImage(My.Resources.nematody_16x16)
        ImageCol.AddImage(My.Resources.sorniaki_16x16)
        SelectQueryData(
                       TableName,
                       "EXEC GetTreeListObjectsQurantine " &
                           "@CountryId = " & CountryId & ", " &
                           "@ProductId = " & ProductId,
                       "Class.GetObjectsQurantine"
                       )

        If Me.tlQurantineObjects.DataSource Is Nothing Then
            With Me.tlQurantineObjects
                .ClearNodes()
                .DataSource = iDataSet.Tables(TableName)
                .ParentFieldName = "ParentId"
                .KeyFieldName = "Id"
                .BestFitColumns(True)
                .StateImageList = ImageCol
                HidenAllColumns_TreeList(Me.tlQurantineObjects)
                ' если столбец существует, показываем его
                If Not IsNothing(.Columns(UserControlProperty.ColumnsNameInTreeList)) Then
                    .Columns(UserControlProperty.ColumnsNameInTreeList).Visible = True
                End If
            End With
        End If
        EventChangedControl = True
        ' всем нодам присваиваем иконку
        For Each nd As TreeListNode In Me.tlQurantineObjects.Nodes
            FillSelectImageIndex(nd)
            SettingsNode(nd)
        Next
        ' извлечение из коллекций состояний нодов
        For Each n In ndList
            If Me.tlQurantineObjects.FindNodeByKeyID(n.Id) IsNot Nothing Then
                Me.tlQurantineObjects.FindNodeByKeyID(n.Id).Expanded = n.Expanded
                Me.tlQurantineObjects.FindNodeByKeyID(n.Id).Checked = n.Checked
            End If
        Next
        Me.tlQurantineObjects.FocusedNode = Me.tlQurantineObjects.FindNodeByKeyID(SelectedItemId)
    End Sub
    ' цикл по всем дочерним узлам
    Private Sub FillSelectImageIndex(ByVal ParentNode As TreeListNode)
        For Each nd As TreeListNode In ParentNode.Nodes
            FillSelectImageIndex(nd)
            SettingsNode(nd)
        Next
    End Sub
    Private Sub SettingsNode(ByVal nd As TreeListNode)
        nd.Expanded = nd("IsExpanded")
        nd.StateImageIndex = nd("IconIndex")
    End Sub

    ' запоминаем активный элемент
    Private Sub tlClassification_FocusedNodeChanged(sender As Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles tlQurantineObjects.FocusedNodeChanged
        If e.Node Is Nothing Or EventChangedControl = False Then Exit Sub
        SelectedItemId = e.Node("Id")
    End Sub

    ' группа Кнопок
    Private Sub gcnClassification_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles gcnQurantineObjects.CustomButtonChecked, gcnQurantineObjects.CustomButtonUnchecked, gcnQurantineObjects.CustomButtonClick
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.VisibleIndex
            Case 0 ' btnEditCheckingProducts
                If frAddEditQuarantineProducts.ShowDialog = DialogResult.OK Then
                    UpdateTreeList()
                End If

            Case 2 ' btnMultiCheck
                Me.tlQurantineObjects.OptionsView.ShowCheckBoxes = btn.Checked
                Me.gcnQurantineObjects.CustomHeaderButtons.Item(9).Properties.Enabled = btn.Checked
                Me.gcnQurantineObjects.CustomHeaderButtons.Item(10).Properties.Enabled = btn.Checked

            Case 3 ' btnShowSearchRow
                Me.tlQurantineObjects.OptionsFind.AlwaysVisible = btn.Checked
                If btn.Checked = False Then Me.tlQurantineObjects.FindFilterText = Nothing' при отключении очищаем фильтрацию

            Case 4 ' btnShowFilterRow
                Me.tlQurantineObjects.OptionsView.ShowAutoFilterRow = btn.Checked
                If btn.Checked = False Then Me.tlQurantineObjects.ClearColumnsFilter()' при отключении очищаем фильтрацию

            Case 6 ' btnExpandedAll
                Me.tlQurantineObjects.ExpandAll()

            Case 7 ' btnCollapsedAll
                Me.tlQurantineObjects.CollapseAll()

            Case 9 ' btnCheckAll
                If IsMultiChecked() Then Me.tlQurantineObjects.CheckAll()

            Case 10 ' btnUncheckAll
                If IsMultiChecked() Then Me.tlQurantineObjects.UncheckAll()

            Case 12 ' btnEditBooks
                Dim dr As DialogResult
                dr = XtraMessageBox.Show("Редактирование справочной информации:" & Chr(10) &
                                    "<b>Да</b> - Справочник Направления исследований" & Chr(10) &
                                    "<b>Нет</b> - Справочник Объекты исследований",
                                    Application.ProductName,
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Question,
                                    DefaultBoolean.True)
                If dr = DialogResult.Yes Then frBooks_ResearchDirection.ShowDialog()
                If dr = DialogResult.No Then frBooks_ResearchObjects.ShowDialog()
                UpdateTreeList()
            Case 13 ' btnUpdate
                UpdateTreeList()
        End Select
    End Sub
#Region "Функции"
    ''' <summary>
    ''' Ид активного узла
    ''' </summary>
    Public Function GetFocusedId() As String
        If Me.tlQurantineObjects.FocusedNode Is Nothing Then Return "NULL" : Exit Function
        Return Me.tlQurantineObjects.FocusedNode("Id")
    End Function

    ''' <summary>
    ''' Уровень активного узла
    ''' </summary>
    Public Function GetFocusedLevel() As Integer
        If Me.tlQurantineObjects.FocusedNode Is Nothing Then Exit Function
        Return Me.tlQurantineObjects.FocusedNode("Level")
    End Function

    ''' <summary>
    ''' Ид активной классификации
    ''' </summary>
    Public Function GetFocusedClassificationId() As String
        If Me.tlQurantineObjects.FocusedNode Is Nothing Then Return "NULL" : Exit Function
        Return Me.tlQurantineObjects.FocusedNode("ClassificationId")
    End Function

    ''' <summary>
    ''' Ид активной продукции
    ''' </summary>
    Public Function GetFocusedProductId() As String
        If Me.tlQurantineObjects.FocusedNode Is Nothing Then Return "NULL" : Exit Function
        Return Me.tlQurantineObjects.FocusedNode("ProductId")
    End Function

    ''' <summary>
    ''' Имя активной классификации
    ''' </summary>
    Public Function GetFocusedClassificationName() As String
        If Me.tlQurantineObjects.FocusedNode Is Nothing Then Return "NULL" : Exit Function
        Return Me.tlQurantineObjects.FocusedNode("ClassificationName")
    End Function

    ''' <summary>
    ''' Имя активной подукции
    ''' </summary>
    Public Function GetFocusedProductName() As String
        If Me.tlQurantineObjects.FocusedNode Is Nothing Then Return "NULL" : Exit Function
        Return Me.tlQurantineObjects.FocusedNode("ProductName")
    End Function

    ''' <summary>
    ''' Мультистрока Ид классификаций
    ''' </summary>
    Public Function GetMultiStringClassificationId() As String
        Dim sender As TreeList = Me.tlQurantineObjects       ' TreeList
        Dim nd As TreeListNode = sender.FocusedNode ' Активный узел
        Dim sep As String                           ' разделитель для мультистроки
        Dim MultiString As String                   ' Строка накопитель
        If nd Is Nothing Or sender.OptionsView.ShowCheckBoxes = False Then
            Return "NULL" : Exit Function
        End If
        ' собираем чекнутые строки если они есть или если чекнут Root значит фильтра нет
        If sender.GetAllCheckedNodes.Count = 0 Then Return "NULL"
        For Each n As TreeListNode In sender.GetAllCheckedNodes
            ' среди контролеров
            If n("Level") = 0 Then
                MultiString += sep & n.Item("ClassificationId")
                sep = ","
            End If
        Next
        Return Replace("'" & Replace(MultiString, "NULL", "") & "'", "''", "NULL")
    End Function

    ''' <summary>
    ''' Мультистрока Ид продукций
    ''' </summary>
    Public Function GetMultiStringProductId() As String
        Dim sender As TreeList = Me.tlQurantineObjects       ' TreeList
        Dim nd As TreeListNode = sender.FocusedNode ' Активный узел
        Dim sep As String                           ' разделитель для мультистроки
        Dim MultiString As String                   ' Строка накопитель
        If nd Is Nothing Or sender.OptionsView.ShowCheckBoxes = False Then
            Return "NULL" : Exit Function
        End If
        ' собираем чекнутые строки если они есть или если чекнут Root значит фильтра нет
        If sender.GetAllCheckedNodes.Count = 0 Then Return "NULL"
        For Each n As TreeListNode In sender.GetAllCheckedNodes
            ' среди контролеров
            If n("Level") = 1 Then
                MultiString += sep & n.Item("ProductId")
                sep = ","
            End If
        Next
        Return Replace("'" & Replace(MultiString, "NULL", "") & "'", "''", "NULL")
    End Function

    ''' <summary>
    ''' Мультистрока имен классификаций
    ''' </summary>
    Public Function GetMultiStringClassificationName() As String
        Dim sender As TreeList = Me.tlQurantineObjects       ' TreeList
        Dim nd As TreeListNode = sender.FocusedNode ' Активный узел
        Dim sep As String                           ' разделитель для мультистроки
        Dim MultiString As String                   ' Строка накопитель
        If nd Is Nothing Or sender.OptionsView.ShowCheckBoxes = False Then
            Return "NULL" : Exit Function
        End If
        ' собираем чекнутые строки если они есть или если чекнут Root значит фильтра нет
        If sender.GetAllCheckedNodes.Count = 0 Or sender.Nodes(0).Checked Then Return "NULL"
        For Each n As TreeListNode In sender.GetAllCheckedNodes
            ' среди контролеров
            If n("Level") = 0 Then
                MultiString += sep & n.Item("ClassificationName")
                sep = ","
            End If
        Next
        Return Replace("'" & Replace(MultiString, "NULL", "") & "'", "''", "NULL")
    End Function

    ''' <summary>
    ''' Мультистрока имен продукций
    ''' </summary>
    Public Function GetMultiStringProductName() As String
        Dim sender As TreeList = Me.tlQurantineObjects       ' TreeList
        Dim nd As TreeListNode = sender.FocusedNode ' Активный узел
        Dim sep As String                           ' разделитель для мультистроки
        Dim MultiString As String                   ' Строка накопитель
        If nd Is Nothing Or sender.OptionsView.ShowCheckBoxes = False Then
            Return "NULL" : Exit Function
        End If
        ' собираем чекнутые строки если они есть или если чекнут Root значит фильтра нет
        If sender.GetAllCheckedNodes.Count = 0 Or sender.Nodes(0).Checked Then Return "NULL"
        For Each n As TreeListNode In sender.GetAllCheckedNodes
            ' среди контролеров
            If n("Level") = 1 Then
                MultiString += sep & n.Item("ProductName")
                sep = ","
            End If
        Next
        Return Replace("'" & Replace(MultiString, "NULL", "") & "'", "''", "NULL")
    End Function

    ''' <summary>
    ''' Активность мультивыбора
    ''' </summary>
    ''' <returns></returns>
    Public Function IsMultiChecked() As Boolean
        Return Me.tlQurantineObjects.OptionsView.ShowCheckBoxes
    End Function

    ''' <summary>
    ''' Задать чеки по объекту из базы
    ''' </summary>
    ''' <param name="CountryId">Ид страны</param>>
    ''' <returns></returns>
    Public Function SetMultiCheckedProductId(ByVal CountryId As String) As Boolean
        'Dim checkEdit As DevExpress.XtraEditors.CheckEdit
        'SelectQueryData("CheckedProductsId." & ParentForm.Name,
        '                "SELECT ClassificationId, ProductId FROM vBooks_CountriesProducts WHERE CountryId = " & CountryId,
        '                "SetMultiCheckedProductId")
        'For Each r As System.Data.DataRow In iDataSet.Tables("CheckedProductsId." & ParentForm.Name).Rows
        '    Me.tlQurantineProducts.FindNodeByKeyID(CType(r("ClassificationId"), Integer)).Checked = True
        '    Me.tlQurantineProducts.FindNodeByKeyID(CType(r("ClassificationId"), Integer)).Expand()
        '    Me.tlQurantineProducts.FindNodeByKeyID(CType(r("ProductId"), Integer)).Checked = True
        '    Me.tlQurantineProducts.FindNodeByKeyID(CType(r("ProductId"), Integer)).ParentNode.Expand()
        'Next
    End Function

    ''' <summary>
    ''' Обновление с текущими параметрами
    ''' </summary> 
    Public Sub UpdateTreeList()
        tmWaitAnimation.StartWaitingIndicator(Me.tlQurantineObjects, 0)
        LoadTreeList(_TableName, _CountryId, _ProductId)
        tmWaitAnimation.StopWaitingIndicator()
    End Sub

    ''' <summary>
    ''' Задать Caption для дерева
    ''' </summary> 
    ''' ''' <param name="iValue">Строка значения для Caption</param>>
    Public Sub SetCaptionTreeList(ByVal iValue As String)
        Me.tlQurantineObjects.Caption = CType(iValue, String)
    End Sub

    ''' <summary>
    ''' Очистить DataSet привязанный к TreeListView
    ''' </summary>
    Public Sub ClearDataSet()
        If iDataSet.Tables.Contains(_TableName) Then iDataSet.Tables(_TableName).Clear()
    End Sub
#End Region
End Class
