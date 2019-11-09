Imports System.ComponentModel
Imports System.Data

Public Class frAddEditHistoryRoleJobs
    Friend AddEdit As Integer = 2
    Dim iRowCurrent As DataRow
    ' Таскание формы за любой участок
    Private Sub Control_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelControl1.MouseDown, lbNameForm.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Cursor = Cursors.NoMove2D
            sender.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, New IntPtr(2), IntPtr.Zero))
            Me.Cursor = Cursors.Default
        End If
    End Sub
    ' Закрытие формы
    Private Sub frAddEditHistoryRoleJobs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing, btnClose.Click
        clsMyUserFunction.RemoveTableDataSet(Me)
    End Sub
    ' загрузка формы
    Private Sub frAddEditHistoryRoleJobs_Load(sender As Object, e As EventArgs) Handles Me.Load
        EventChangedControl = False
        If AddEdit = 3 Then Me.lbNameForm.Text = "Редактировать должности сотрудника"
        Me.Location = MousePosition
        Me.txtDtBegin.EditValue = Now
        Me.txtDtBegin.Select()
        ' дерево должностей
        Dim RoleJobsFilial As New clsOrganizationStructure With {
                                                    .sender = Me.cmbRoleJobsFilial.Properties.TreeList,
                                                    .TableName = "tlRoleJobsFilial." & Me.Name
                                                                }
        Me.cmbRoleJobsFilial.Properties.DisplayMember = "RoleJobsString"
        Me.cmbRoleJobsFilial.Properties.ValueMember = "Id"
        RoleJobsFilial.GetOrganizationStructure(ExpandedRoot:=1, OnlyCurentFillial:="1")
        AddHandler tlRoleJobsFilial.NodeCellStyle, AddressOf RoleJobsFilial.NodeCellStyle
        ' если новая запись выходим из процедуры
        If AddEdit = 2 Then EventChangedControl = True : Exit Sub
        ' текущая строка в таблице
        iRowCurrent = iDataSet.Tables("HistoryRoleJobs." & frAddEditPerformer.Name).Rows(frAddEditPerformer.gvHistoryRoleJobs.FocusedRowHandle)
        Me.cmbRoleJobsFilial.EditValue = iRowCurrent("RoleJobsId")
        Me.txtDtBegin.EditValue = iRowCurrent("DtChange")
        Me.tlRoleJobsFilial.FocusedNode = Me.tlRoleJobsFilial.FindNodeByKeyID(iRowCurrent("RoleJobsId"))
        EventChangedControl = True
    End Sub
    ' отмена закрытия выпадающего дерева
    Private Sub cmbRoleJobsFilial_QueryCloseUp(sender As Object, e As CancelEventArgs) Handles cmbRoleJobsFilial.QueryCloseUp
        If sender.Properties.TreeList.FocusedNode Is Nothing Then Exit Sub
        ' выбираем только должность
        e.Cancel = sender.Properties.TreeList.FocusedNode("Level") <> 3
    End Sub
    ' событие проверки корректности даты
    Private Sub txtDtBegin_Properties_Validating(sender As Object, e As CancelEventArgs) Handles txtDtBegin.Properties.Validating
        If CheckingDtBegin() Then
            sender.ErrorText = Nothing
            Me.btnOk.Enabled = True
        Else
            Me.txtDtBegin.Focus()
            Me.txtDtBegin.SelectAll()
            Me.txtDtBegin.ErrorText = "Указанная дата уже присутствует в истории ..."
            Me.btnOk.Enabled = False
        End If
    End Sub
    ' событие изменения даты
    Private Sub txtDtBegin_EditValueChanged(sender As Object, e As EventArgs) Handles txtDtBegin.EditValueChanged
        If EventChangedControl = False Then Exit Sub
        txtDtBegin_Properties_Validating(sender, New CancelEventArgs)
    End Sub
    ' Проверка уникальности даты
    Private Function CheckingDtBegin() As Boolean
        Dim dt As DataTable = iDataSet.Tables("HistoryRoleJobs." & frAddEditPerformer.Name)
        Dim dt_NewValue As Date = Me.txtDtBegin.EditValue   ' введенная дата 
        Dim dt_dsValue As Date                              ' дата из таблицы для сравнения
        Dim dt_dsCurValue As Date                           ' выбранная дата в таблице
        ' если редактирование
        If AddEdit = 3 Then
            ' сравниваем новую и редактируемую дату
            dt_dsCurValue = iRowCurrent("DtChange")
            If dt_dsCurValue.ToShortDateString = dt_NewValue.ToShortDateString Then Return True
        End If
        ' проходим по таблице в поисках совпадения
        For Each r As DataRow In dt.Rows
            If IsDBNull(r("DtChange")) Then Continue For
            dt_dsValue = r("DtChange")
            ' если совпадение найдено
            If dt_dsValue.ToShortDateString = dt_NewValue.ToShortDateString Then
                Return False
            End If
        Next
        Return True
    End Function
    ' проверка назначения должности
    Private Function CheckingRoleJobs() As Boolean
        If clsForSQL.InDataBase(Me.cmbRoleJobsFilial.EditValue) = "NULL" Then
            Me.cmbRoleJobsFilial.ErrorText = "Должность не назначена ..."
            Me.btnOk.Enabled = False
            Return False
        Else
            Me.cmbRoleJobsFilial.ErrorText = Nothing
            Me.btnOk.Enabled = True
            Return True
        End If
    End Function
    ' Ок
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If CheckingRoleJobs() = False Then Exit Sub ' проверка назначения должности  
        If ExecuteScalar(
                        "EXEC PerformersHistoryRJFuction 
                            @PerformerId = " & frAddEditPerformer.PerformerId & ", 
                            @DtChange = " & clsForSQL.InDataBase(Me.txtDtBegin.Text) & ", 
                            @DtChangeOld = " & If(AddEdit = 2, "NULL", clsForSQL.InDataBase(iRowCurrent("DtChange"), "DateTime")) & ", 
                            @RoleJobsId = " & Me.cmbRoleJobsFilial.EditValue & ", 
                            @Function = " & AddEdit,
                        "SetRoleJob"
                              ) = 1 Then
            ' передача даты новой записи
            frAddEditPerformer.NewRecord_HistoryRoleJobs = Me.txtDtBegin.Text
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
    ' отмена
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    ' событие изменения должности
    Private Sub cmbRoleJobsFvilial_EditValueChanged(sender As Object, e As EventArgs) Handles cmbRoleJobsFilial.EditValueChanged
        CheckingRoleJobs()
    End Sub
End Class