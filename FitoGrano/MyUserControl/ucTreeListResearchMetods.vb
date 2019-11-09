Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors.ButtonsPanelControl
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Public Class ucTreeListResearchMetods
    Dim ImageCol As New ImageCollection                     ' Коллекция иконок
    Dim SelectedItemId As Integer                           ' Текущая ветка
    Dim _TableName As String
    Dim _IsExpDirection As String
    Dim ndList As New List(Of ConditionNodeList)            ' Коллекция состояний нодов
    Dim NodeList As ConditionNodeList                       ' Запись для добавления в коллекцию
    Dim PreferenceForms As String                           ' Ветка в реестре для хранения настроек формы 
    Public Property UserControlProperty() As UserControlProp

    <TypeConverter(GetType(ExpandableObjectConverter))>
    Public Class UserControlProp
        Public _btnMultiCheckingIsVisible As Boolean = True
        Public _ColumnsNameInTreeList As String = "Name"
        Public _tlMethodsViewCheckBoxes As Boolean = True

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
        <Description("Вкл/выкл чекбоксы в дереве направлений"), DefaultValue(True)>
        Public Property tlMethodsViewCheckBoxes() As Boolean
            Get
                Return _tlMethodsViewCheckBoxes
            End Get
            Set
                _tlMethodsViewCheckBoxes = Value
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
        ' загрузка наcтроек
        Me.gcnMethods.CustomHeaderButtons.Item(0).Properties.Checked = RegistryRead(PreferenceForms, "gcnMethods.btnMultiCheck", False)
        Me.gcnMethods.CustomHeaderButtons.Item(1).Properties.Checked = RegistryRead(PreferenceForms, "gcnMethods.btnShowSearchRow", False)
        Me.gcnMethods.CustomHeaderButtons.Item(2).Properties.Checked = RegistryRead(PreferenceForms, "gcnMethods.btnShowFilterRow", False)
        ' событие выгрузки родительской формы
        AddHandler Me.ParentForm.FormClosing, AddressOf ParentForm_FormClosing
        Me.gcnMethods.CustomHeaderButtons.Item(0).Properties.Visible = UserControlProperty._btnMultiCheckingIsVisible
        Me.tlMethods.OptionsView.ShowCheckBoxes = UserControlProperty._tlMethodsViewCheckBoxes
        Me.gcnMethods.CustomHeaderButtons.Item(0).Properties.Checked = UserControlProperty._tlMethodsViewCheckBoxes
    End Sub
    ' выгрузка родительской формы
    Private Sub ParentForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        clsMyUserFunction.RemoveTableDataSet(sender)
        RegistryWrite(PreferenceForms, "gcnMethods.btnMultiCheck", Me.tlMethods.OptionsView.ShowCheckBoxes.ToString)
        RegistryWrite(PreferenceForms, "gcnMethods.btnShowSearchRow", Me.tlMethods.OptionsFind.AlwaysVisible.ToString)
        RegistryWrite(PreferenceForms, "gcnMethods.btnShowFilterRow", Me.tlMethods.OptionsView.ShowAutoFilterRow.ToString)
    End Sub

    ' Заполняем коллекцию при первом запуске и извлекаем при последующих
    Private Sub Filling_ndList(Optional node As TreeListNode = Nothing,
                               Optional IsFirstRun As Boolean = True)
        If IsFirstRun Then ndList.Clear()
        Select Case IsFirstRun
            Case True ' Первый запуск
                For Each nd As TreeListNode In Me.tlMethods.Nodes
                    NodeList.Id = nd("Id")
                    NodeList.Expanded = nd.Expanded
                    If tlMethods.OptionsView.ShowCheckBoxes Then NodeList.Checked = nd.Checked
                    ndList.Add(NodeList)
                    If nd.HasChildren Then Filling_ndList(nd, False)
                Next

            Case Else ' рекурсия
                For Each nd As TreeListNode In node.Nodes
                    NodeList.Id = nd("Id")
                    NodeList.Expanded = nd.Expanded
                    If tlMethods.OptionsView.ShowCheckBoxes Then NodeList.Checked = nd.Checked
                    ndList.Add(NodeList)
                    If nd.HasChildren Then Filling_ndList(nd, False)
                Next
        End Select
    End Sub

    ''' <summary>Загрузка списка контролеров из базы данных</summary>
    ''' <param name="TableName">Имя таблицы для загрузки данных</param>
    ''' <param name="IsExpDirection">Развернуть узлы направлений</param>
    Public Sub LoadMethodList(Optional ByVal TableName As String = Nothing,
                              Optional ByVal IsExpDirection As Boolean = True)
        If TableName Is Nothing Then TableName = "ResearchMethods." & ParentForm.Name

        _TableName = TableName
        _IsExpDirection = IsExpDirection
        ' загружаем изображения в коллекцию
        If Me.tlMethods.Nodes.Count <> 0 Then Filling_ndList()
        EventChangedControl = False

        ImageCol.Clear()
        ImageCol.AddImage(My.Resources.directions_16x16)
        ImageCol.AddImage(My.Resources.microscope_16x16)
        SelectQueryData(
                       TableName,
                       "EXEC GetTreeListResearchMethods " &
                           "@IsExpDirection = " & Convert.ToInt16(IsExpDirection),
                       "Class.GetResearchMethods"
                       )

        If Me.tlMethods.DataSource Is Nothing Then
            With Me.tlMethods
                .ClearNodes()
                .DataSource = iDataSet.Tables(TableName)
                .ParentFieldName = "ParentId"
                .KeyFieldName = "Id"
                .BestFitColumns(True)
                .StateImageList = ImageCol
                HidenAllColumns_TreeList(Me.tlMethods)
                ' если столбец существует, показываем его
                If Not IsNothing(.Columns(UserControlProperty.ColumnsNameInTreeList)) Then
                    .Columns(UserControlProperty.ColumnsNameInTreeList).Visible = True
                End If
            End With
        End If
        EventChangedControl = True
        ' всем нодам присваиваем иконку
        For Each nd As TreeListNode In Me.tlMethods.Nodes
            FillSelectImageIndex(nd)
            SettingsNode(nd)
        Next
        ' извлечение из коллекций состояний нодов
        For Each n In ndList
            If Me.tlMethods.FindNodeByKeyID(n.Id) IsNot Nothing Then
                Me.tlMethods.FindNodeByKeyID(n.Id).Expanded = n.Expanded
                Me.tlMethods.FindNodeByKeyID(n.Id).Checked = n.Checked
            End If
        Next
        Me.tlMethods.FocusedNode = Me.tlMethods.FindNodeByKeyID(SelectedItemId)
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
        nd.StateImageIndex = nd.Level
    End Sub

    ' запоминаем активный элемент
    Private Sub tlMethods_FocusedNodeChanged(sender As Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles tlMethods.FocusedNodeChanged
        If e.Node Is Nothing Or EventChangedControl = False Then Exit Sub
        SelectedItemId = e.Node("Id")
    End Sub

    ' группа Кнопок
    Private Sub gcnMethods_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles gcnMethods.CustomButtonChecked, gcnMethods.CustomButtonUnchecked, gcnMethods.CustomButtonClick
        Dim btn As GroupBoxButton = e.Button
        Select Case btn.VisibleIndex
            Case 0 ' btnMultiCheck
                Me.tlMethods.OptionsView.ShowCheckBoxes = btn.Checked

            Case 1 ' btnShowSearchRow
                Me.tlMethods.OptionsFind.AlwaysVisible = btn.Checked
                If btn.Checked = False Then Me.tlMethods.FindFilterText = Nothing' при отключении очищаем фильтрацию

            Case 2 ' btnShowFilterRow
                Me.tlMethods.OptionsView.ShowAutoFilterRow = btn.Checked
                If btn.Checked = False Then Me.tlMethods.ClearColumnsFilter()' при отключении очищаем фильтрацию

            Case 4 ' btnExpandedAll
                Me.tlMethods.ExpandAll()

            Case 5 ' btnCollapsedAll
                Me.tlMethods.CollapseAll()

            Case 7 ' btnCheckAll
                If IsMultiChecked() Then Me.tlMethods.CheckAll()

            Case 8 ' btnUncheckAll
                If IsMultiChecked() Then Me.tlMethods.UncheckAll()

            Case 10 ' btnEditBooks
                frBooks_ResearchDirection.ShowDialog()
                tmWaitAnimation.StartWaitingIndicator(Me.tlMethods, 0)
                LoadMethodList(_TableName, _IsExpDirection)
                tmWaitAnimation.StopWaitingIndicator()
            Case 11 ' btnUpdate
                tmWaitAnimation.StartWaitingIndicator(Me.tlMethods, 0)
                LoadMethodList(_TableName, _IsExpDirection)
                tmWaitAnimation.StopWaitingIndicator()
        End Select
    End Sub
#Region "Функции"

    ''' <summary>
    ''' Ид активного узла
    ''' </summary>
    Public Function GetFocusedId() As String
        If Me.tlMethods.FocusedNode Is Nothing Then Return "NULL" : Exit Function
        Return Me.tlMethods.FocusedNode("Id")
    End Function

    ''' <summary>
    ''' Уровень активного узла
    ''' </summary>
    Public Function GetFocusedLevel() As Integer
        If Me.tlMethods.FocusedNode Is Nothing Then Exit Function
        Return Me.tlMethods.FocusedNode("Level")
    End Function

    ''' <summary>
    ''' Ид активного направления
    ''' </summary>
    Public Function GetFocusedDirectionId() As String
        If Me.tlMethods.FocusedNode Is Nothing Then Return "NULL" : Exit Function
        Return Me.tlMethods.FocusedNode("DirectionId")
    End Function

    ''' <summary>
    ''' Ид активного метода
    ''' </summary>
    Public Function GetFocusedMethodId() As String
        If Me.tlMethods.FocusedNode Is Nothing Then Return "NULL" : Exit Function
        Return Me.tlMethods.FocusedNode("MethodId")
    End Function

    ''' <summary>
    ''' Имя активного направления
    ''' </summary>
    Public Function GetFocusedDirectionName() As String
        If Me.tlMethods.FocusedNode Is Nothing Then Return "NULL" : Exit Function
        Return Me.tlMethods.FocusedNode("DirectionName")
    End Function

    ''' <summary>
    ''' Имя активного метода
    ''' </summary>
    Public Function GetFocusedMethodName() As String
        If Me.tlMethods.FocusedNode Is Nothing Then Return "NULL" : Exit Function
        Return Me.tlMethods.FocusedNode("MethodName")
    End Function

    ''' <summary>
    ''' Мультистрока Ид направлений
    ''' </summary>
    Public Function GetMultiStringDirectionId() As String
        Dim sender As TreeList = Me.tlMethods       ' TreeList
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
                MultiString += sep & n.Item("DirectionId")
                sep = ","
            End If
        Next
        Return Replace("'" & Replace(MultiString, "NULL", "") & "'", "''", "NULL")
    End Function

    ''' <summary>
    ''' Мультистрока Ид методов
    ''' </summary>
    Public Function GetMultiStringMethodId() As String
        Dim sender As TreeList = Me.tlMethods       ' TreeList
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
                MultiString += sep & n.Item("MethodId")
                sep = ","
            End If
        Next
        Return Replace("'" & Replace(MultiString, "NULL", "") & "'", "''", "NULL")
    End Function

    ''' <summary>
    ''' Мультистрока имен направлений
    ''' </summary>
    Public Function GetMultiStringDirectionName() As String
        Dim sender As TreeList = Me.tlMethods       ' TreeList
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
                MultiString += sep & n.Item("DirectionName")
                sep = ","
            End If
        Next
        Return Replace("'" & Replace(MultiString, "NULL", "") & "'", "''", "NULL")
    End Function

    ''' <summary>
    ''' Мультистрока имен методов
    ''' </summary>
    Public Function GetMultiStringMethodName() As String
        Dim sender As TreeList = Me.tlMethods       ' TreeList
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
                MultiString += sep & n.Item("MethodName")
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
        Return Me.tlMethods.OptionsView.ShowCheckBoxes
    End Function

    ''' <summary>
    ''' Задать чеки по объекту из базы
    ''' </summary>
    ''' <param name="ObjectId">Ид объекта исследования</param>>
    ''' <returns></returns>
    Public Function SetMultiCheckedObjectId(ByVal ObjectId As String) As Boolean
        Dim checkEdit As DevExpress.XtraEditors.CheckEdit
        SelectQueryData("CheckedObjectId." & ParentForm.Name,
                        "SELECT DirectionId, MethodId FROM vBooks_Objects WHERE Id = " & ObjectId,
                        "SetMultiCheckedObjectId")
        For Each r As System.Data.DataRow In iDataSet.Tables("CheckedObjectId." & ParentForm.Name).Rows
            Me.tlMethods.FindNodeByKeyID(CType(r("DirectionId"), Integer)).Checked = True
            Me.tlMethods.FindNodeByKeyID(CType(r("DirectionId"), Integer)).Expand()
            Me.tlMethods.FindNodeByKeyID(CType(r("MethodId"), Integer)).Checked = True
            Me.tlMethods.FindNodeByKeyID(CType(r("MethodId"), Integer)).ParentNode.Expand()
        Next
    End Function
#End Region
End Class
