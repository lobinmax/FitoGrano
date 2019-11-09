Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Public Class frBooks_OrganizationStructure
    Dim OrganizationStructure As New clsOrganizationStructure
    ' закрытие формы
    Private Sub frOrganizationStructure_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        clsMyUserFunction.RemoveTableDataSet(Me)
    End Sub
    ' Загрузка формы
    Private Sub frOrganizationStructure_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        OrganizationStructure.sender = Me.tlStructure
        OrganizationStructure.TableName = "OrganizationStructure." & Me.Name
        AddHandler tlStructure.NodeCellStyle, AddressOf OrganizationStructure.NodeCellStyle
        OrganizationStructure.GetOrganizationStructure(ExpandedRoot:=1, ExpandedFilials:=0)
        Me.tlStructure.Nodes(0).Expand()
        UpdateInfoRecord(Me.tlStructure.FocusedNode)
    End Sub
    ' Правой кнопкой мыши вызываем контекстное меню
    Private Sub tlStructure_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tlStructure.MouseClick
        Dim tl As TreeList = sender
        Dim hitinfo As TreeListHitInfo = tl.CalcHitInfo(e.Location)
        If Me.tlStructure.Nodes.Count = 0 Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ' если меню вызвано вне строк, можно только добавить филиал
            If hitinfo.InRowCell = False Or IsDBNull(Me.tlStructure.FocusedNode("ParentId")) Then
                Me.btnEditRecord.Enabled = False
                Me.btnDeleteRecord.Enabled = False
                Me.btnAddGroup.Enabled = False
                Me.btnAddRoleJob.Enabled = False
                Me.btnSetCurrentFilial.Enabled = False
                Me.btnAddFilial.Enabled = True
                Me.PopupMenu.ShowPopup(MousePosition)
            Else
                Me.btnEditRecord.Enabled = True
                Me.btnDeleteRecord.Enabled = True
                Me.btnAddFilial.Enabled = Me.tlStructure.FocusedNode.Level = 0
                Me.btnAddGroup.Enabled = Me.tlStructure.FocusedNode.Level = 1
                Me.btnAddRoleJob.Enabled = Me.tlStructure.FocusedNode.Level = 2
                Me.btnAddMenu.Enabled = Me.tlStructure.FocusedNode.Level < 3
                Me.btnSetCurrentFilial.Enabled = Me.tlStructure.FocusedNode.Level = 1
                Me.PopupMenu.ShowPopup(MousePosition)
            End If
        End If
    End Sub
    ' событие изменения фокуса
    Private Sub tlStructure_FocusedNodeChanged(sender As Object, e As FocusedNodeChangedEventArgs) Handles tlStructure.FocusedNodeChanged
        If EventChangedControl = False Then Exit Sub
        ' если Root запись, отменяем фокус
        If IsDBNull(e.Node("ParentId")) Then
            sender.FocusedNode = e.OldNode
            Exit Sub
        End If
        UpdateInfoRecord(e.Node, e.OldNode) ' обновление полей
    End Sub
    ' Для запрета перемещения на Root с помощью стрелок
    Private Sub tlStructure_KeyUp(sender As Object, e As KeyEventArgs) Handles tlStructure.KeyUp
        If IsDBNull(sender.FocusedNode("ParentId")) Then
            e.Handled = True
            sender.FocusedNode = Me.tlStructure.FindNodeByKeyID(OrganizationStructure.SelectionId)
        End If
    End Sub
    ' обработка горячих клавиш
    Private Sub tlStructure_KeyDown(sender As Object, e As KeyEventArgs) Handles tlStructure.KeyDown
        If e.KeyCode = Keys.Delete Then btnDeleteRecord_ItemClick(sender, Nothing)
        If e.KeyCode = Keys.Enter Then btnEditRecord_ItemClick(sender, Nothing)
        If e.KeyCode = Keys.Apps Then tlStructure_MouseClick(sender, Nothing)
    End Sub
    ' двойной клик по ветке дерева
    Private Sub tlStructure_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tlStructure.MouseDoubleClick
        Dim tl As TreeList = sender
        Dim hitinfo As TreeListHitInfo = tl.CalcHitInfo(e.Location)
        If IsNothing(hitinfo.Node) Then Exit Sub
        ' если у ветки нет подветки и это не Root, вызываем диалог редактирования
        If hitinfo.Node.HasChildren = False And IsDBNull(hitinfo.Node("ParentId")) = False Then
            btnEditRecord_ItemClick(sender, Nothing)
        End If
    End Sub
    ' добавить филиал
    Private Sub btnAddFilial_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddFilial.ItemClick
        frAddEditOrganizations.AddOrEdit = 2
        If frAddEditOrganizations.ShowDialog() = DialogResult.OK Then
            OrganizationStructure.SelectionId = glNewId
            OrganizationStructure.GetOrganizationStructure()
        End If
    End Sub
    ' добавить группу
    Private Sub btnAddGroup_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAddGroup.ItemClick
        frAddEditOrganizationsGroup.AddOrEdit = 2
        If frAddEditOrganizationsGroup.ShowDialog() = DialogResult.OK Then
            OrganizationStructure.SelectionId = glNewId
            OrganizationStructure.GetOrganizationStructure()
        End If
    End Sub
    ' добавить должность
    Private Sub btnAddRoleJob_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAddRoleJob.ItemClick
        frAddEditOrganizationsRoleJob.AddOrEdit = 2
        If frAddEditOrganizationsRoleJob.ShowDialog() = DialogResult.OK Then
            OrganizationStructure.SelectionId = glNewId
            OrganizationStructure.GetOrganizationStructure()
        End If
    End Sub
    ' кнопка изменить
    Private Sub btnEditRecord_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEditRecord.ItemClick
        If Me.tlStructure.FocusedNode IsNot Nothing Then
            Select Case Me.tlStructure.FocusedNode.Level
                Case 1 ' филиал
                    frAddEditOrganizations.AddOrEdit = 3
                    If frAddEditOrganizations.ShowDialog() = DialogResult.OK Then
                        OrganizationStructure.GetOrganizationStructure()
                    End If
                Case 2 ' группа
                    frAddEditOrganizationsGroup.AddOrEdit = 3
                    If frAddEditOrganizationsGroup.ShowDialog() = DialogResult.OK Then
                        OrganizationStructure.GetOrganizationStructure()
                    End If
                Case 3 ' Должность
                    frAddEditOrganizationsRoleJob.AddOrEdit = 3
                    If frAddEditOrganizationsRoleJob.ShowDialog() = DialogResult.OK Then
                        OrganizationStructure.GetOrganizationStructure()
                    End If
                Case Else
            End Select
        End If
    End Sub
    ' кнопка удаленния записи
    Private Sub btnDeleteRecord_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnDeleteRecord.ItemClick
        If XtraMessageBox.Show("Запись с именем <b>" & Me.tlStructure.FocusedNode("Name") & "</b> будет удалена!" & Chr(10) &
                               "Вы согласны?",
                               Application.ProductName, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) = DialogResult.Yes Then
            ExecuteQuery(
                        "EXEC OrganizationStructureFunction 
                            @Id = " & Me.tlStructure.FocusedNode("Id") & ", 
                            @Level = " & Me.tlStructure.FocusedNode.Level & ", 
                            @Function = 4"
                        )
            OrganizationStructure.SelectionId = OrganizationStructure.SelectionIdOld
            OrganizationStructure.GetOrganizationStructure()
        End If
    End Sub
    ' обновление полей с информацией о записи
    Private Sub UpdateInfoRecord(ByVal e As TreeListNode, Optional ByVal eOld As TreeListNode = Nothing)
        Me.lbManagerOrganization.Text = "ФИО руководителя: <b>" & e("Manager") & "</b>"
        Me.lbEmailOrganization.Text = "Email: <b>" & e("Email") & "</b>"
        Me.lbPhoneOrganization.Text = "Контакты: <b>" & e("Phones") & "</b>"
        Me.lbAddressOrganization.Text = "Юридический адрес: <b>" & e("Address") & "</b>"
        OrganizationStructure.SelectionId = e("Id")
        If eOld IsNot Nothing Then OrganizationStructure.SelectionIdOld = eOld("Id")
    End Sub
    ' свернуть все
    Private Sub btnCollapsedAll_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCollapsedAll.ItemClick
        For Each n As TreeListNode In Me.tlStructure.Nodes
            For Each n1 As TreeListNode In n.Nodes
                n1.Collapse()
            Next
        Next
    End Sub
    ' развернуть все
    Private Sub btnExpandedAll_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnExpandedAll.ItemClick
        Me.tlStructure.ExpandAll()
    End Sub
    ' назначить филиал текущим
    Private Sub btnSetCurrentFilial_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSetCurrentFilial.ItemClick
        If Me.tlStructure.FocusedNode IsNot Nothing Then
            ExecuteScalar("EXEC OrganizationStructureFunction @Function = 5, @Id = " & clsForSQL.InDataBase(Me.tlStructure.FocusedNode("Id")))
            OrganizationStructure.GetOrganizationStructure()
        End If
    End Sub
    ' кнопка обновления формы
    Private Sub btnUpdate_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnUpdate.ItemClick
        OrganizationStructure.GetOrganizationStructure()
        UpdateInfoRecord(Me.tlStructure.FocusedNode)
    End Sub
    ' обновление формы по таймеру
    Private Sub tmUpdateForm_Tick(sender As Object, e As EventArgs) Handles tmUpdateForm.Tick
        UpdateInfoRecord(Me.tlStructure.FocusedNode)
    End Sub
    ' ок
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.DialogResult = DialogResult.OK
    End Sub
    ' отмена
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class