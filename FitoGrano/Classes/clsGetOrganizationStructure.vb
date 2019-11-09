Public Class clsOrganizationStructure
    Dim ImageCol As New DevExpress.Utils.ImageCollection    ' Коллекция иконок
    Dim ndList As New List(Of ConditionNodeList)            ' Коллекция состояний нодов
    Dim NodeList As ConditionNodeList                       ' Запись для добавления в коллекцию

    Public SelectionIdOld As Integer                        ' Ид предыдущей выбранной выбранной записи
    Public SelectionId As Integer = 99999                   ' Ид выбранной записи
    Public sender As DevExpress.XtraTreeList.TreeList       ' Элемент TreeList
    Public TableName As String = "OrganizationStructure"    ' Имя таблицы в ДС

    ' коллекции состяния нодов
    Private Structure ConditionNodeList
        Dim Id As Integer           ' Ид нода
        Dim Expanded As Boolean     ' Состояноие нода
    End Structure

    ' Заполняем коллекцию
    Private Sub Filling_ndList(Optional node As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing,
                               Optional IsFirstRun As Boolean = True)
        If IsFirstRun Then ndList.Clear()
        Select Case IsFirstRun
            Case True ' Первый запуск
                For Each nd As DevExpress.XtraTreeList.Nodes.TreeListNode In sender.Nodes
                    NodeList.Id = nd("Id")
                    NodeList.Expanded = nd.Expanded
                    ndList.Add(NodeList)
                    If nd.HasChildren Then Filling_ndList(nd, False)
                Next

            Case Else ' рекурсия
                For Each nd As DevExpress.XtraTreeList.Nodes.TreeListNode In node.Nodes
                    NodeList.Id = nd("Id")
                    NodeList.Expanded = nd.Expanded
                    ndList.Add(NodeList)
                    If nd.HasChildren Then Filling_ndList(nd, False)
                Next
        End Select
    End Sub

    Public Sub GetOrganizationStructure(Optional ExpandedRoot As Integer = 1,
                                        Optional ExpandedFilials As Integer = 1,
                                        Optional ExpandedGroups As Integer = 0,
                                        Optional ExpandedRoleJob As Integer = 0,
                                        Optional OnlyCurentFillial As String = "NULL"
                                        )

        If sender.Nodes.Count <> 0 Then Filling_ndList()
        EventChangedControl = False
        ImageCol.Clear()
        ImageCol.AddImage(My.Resources.company_16x16)
        ImageCol.AddImage(My.Resources.organization_16x16)
        ImageCol.AddImage(My.Resources.group_people_16x16)
        ImageCol.AddImage(My.Resources.performer_16x16)
        ImageCol.AddImage(My.Resources.current_16x16)

        SelectQueryData( TableName, "EXEC OrganizationStructureFunction 
                                @ExpandedRoot = " & ExpandedRoot & ", 
                                @ExpandedFilials = " & ExpandedFilials & ", 
                                @ExpandedGroups = " & ExpandedGroups & ", 
                                @ExpandedRoleJob = " & ExpandedRoleJob & ",
                                @OnlyCurentFillial = " & OnlyCurentFillial & ",
                                @Function = 1", "GetOrganizationStructure" )
        If sender.DataSource Is Nothing Then
            sender.ClearNodes()
            sender.DataSource = iDataSet.Tables(TableName)
            sender.KeyFieldName = "Id"
            sender.ParentFieldName = "ParentId"
            sender.StateImageList = ImageCol
            sender.PopulateColumns()
            HidenAllColumns_TreeList(sender)
            sender.Columns("Name").Visible = sender.Columns.Count <> 0
        End If
        EventChangedControl = True
        ' всем нодам присваиваем иконку
        For Each nd As DevExpress.XtraTreeList.Nodes.TreeListNode In sender.Nodes
            FillSelectImageIndex(nd)
        Next
        ' извлечение из коллекций состояний нодов
        For Each n In ndList
            If sender.FindNodeByKeyID(n.Id) IsNot Nothing Then
                sender.FindNodeByKeyID(n.Id).Expanded = n.Expanded
            End If
        Next
        sender.FocusedNode = sender.FindNodeByKeyID(SelectionId)
    End Sub

    ' цикл по всем дочерним узлам
    Private Sub FillSelectImageIndex(ByVal ParentNode As DevExpress.XtraTreeList.Nodes.TreeListNode)
        ParentNode.Expanded = ParentNode("IsExpanded")
        ParentNode.StateImageIndex = ParentNode.Level
        For Each nd As DevExpress.XtraTreeList.Nodes.TreeListNode In ParentNode.Nodes
            FillSelectImageIndex(nd)
        Next
    End Sub

    ' выделение текущего филиала
    Public Sub NodeCellStyle(sender As Object, e As DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs)
        If EventChangedControl = False Then Exit Sub
        If e.Column.FieldName <> "Name" Then Exit Sub
        If e.Node("IsCurrent") Then
            e.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25, FontStyle.Bold Or FontStyle.Underline)
            e.Node.StateImageIndex = 4
        End If
    End Sub
End Class
