Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frAddEditPerformer
    Friend AddOrEdit As Integer = 2
    Friend PerformerId As String = "NULL"
    Friend NewRecord_HistoryRoleJobs As Date    ' Дата добавленной записи в историю должностей
    Friend NewRecord_Contact As String          ' ид добавленнго контакта
    Dim iCurrentRow As DataRow
    ' закрытие формы
    Private Sub frAddEditPerformer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.gvHistoryRoleJobs.RowCount = 0 And PerformerId <> "NULL" Then
            XtraMessageBox.Show("Форма не может быть закрыта, т.к. сотруднику не назначена должность!",
                                Application.ProductName,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop)
            e.Cancel = True : Exit Sub
        End If
        clsMyUserFunction.RemoveTableDataSet(Me)
    End Sub
    ' загрузка формы
    Private Sub frAddEditPerformer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Select Case AddOrEdit
            Case 2
                Me.Text = "Добавить исполнителя базы данных"
            Case 3
                Me.Text = "Редактировать исполнителя базы данных"
                iCurrentRow = frSecurityUsers.gvPerformers.GetFocusedDataRow
                PerformerId = clsForSQL.OutDataBase(iCurrentRow("PerformerId"))
        End Select

        Dim ret As New ImageCollection()
        ret.ImageSize = New Size(16, 16)
        ret.AddImage(My.Resources.SexWomen_16x16)
        ret.AddImage(My.Resources.SexMen_16x16)
        Me.cmdSex.Properties.SmallImages = ret
        Me.cmdSex.Properties.Items.AddEnum(Of SexType)()

        Me.txtLogin.EditValue = If(iCurrentRow IsNot Nothing, iCurrentRow("Login"), "")
        Me.txtPassword1.EditValue = If(iCurrentRow IsNot Nothing, iCurrentRow("Password"), "")
        Me.txtPassword2.EditValue = If(iCurrentRow IsNot Nothing, iCurrentRow("Password"), "")
        Me.txtSurname.EditValue = If(iCurrentRow IsNot Nothing, iCurrentRow("Surname"), "")
        Me.txtName.EditValue = If(iCurrentRow IsNot Nothing, iCurrentRow("Name"), "")
        Me.txtPatronymic.EditValue = If(iCurrentRow IsNot Nothing, iCurrentRow("Patronymic"), "")
        Me.txtAddress.EditValue = If(iCurrentRow IsNot Nothing, iCurrentRow("Address"), "")
        Me.txtDtBirth.EditValue = If(iCurrentRow IsNot Nothing, iCurrentRow("DtBirth"), "")
        Me.txtRoomNumber.EditValue = If(iCurrentRow IsNot Nothing, iCurrentRow("RoomNumber"), "")
        Me.cmdSex.SelectedIndex = If(iCurrentRow IsNot Nothing, iCurrentRow("SexId"), 1)
        Me.txtEmail.EditValue = If(iCurrentRow IsNot Nothing, iCurrentRow("Email"), "")

        DesignerPerformerContacts() ' контакты пользователя
        DesignerHistoryRoleJobs()   ' история должностных обязанностей

        ' Группы пользователей 
        SelectQueryData(
                        "PerformersRightGroups." & Me.Name,
                        "SELECT prg.Id,
                                prg.Name,
                                CAST(CASE WHEN(
                                               SELECT pg.PerformerId 
                                               FROM vPerformersGroups pg 
                                               WHERE pg.PerformerGroupsId = prg.Id AND pg.PerformerId = " & PerformerId & " 
                                               ) IS NULL THEN 'FALSE' ELSE 'TRUE' END  AS BIT) AS Checked
                        FROM dbo.vPerformersRightGroups prg",
                        "GetPerformersRightGroups"
                        )
        Me.lbxPerfGroups.DataSource = iDataSet.Tables("PerformersRightGroups." & Me.Name)
        Me.lbxPerfGroups.DisplayMember = "Name"
        Me.lbxPerfGroups.ValueMember = "Id"
        Me.lbxPerfGroups.CheckMember = "Checked"
        Me.txtLogin.Select()
    End Sub

#Region "Дизайнеры"
    ' дизайнер истории должностей
    Private Sub DesignerHistoryRoleJobs()
        SelectQueryData(
                        "HistoryRoleJobs." & Me.Name,
                        "EXEC PerformersHistoryRJFuction @PerformerId = " & PerformerId & ", @Function = 1",
                        "GetHistoryRoleJobs"
                        )
        If Me.gcHistoryRoleJobs.DataSource Is Nothing Then
            Me.gcHistoryRoleJobs.DataSource = iDataSet.Tables("HistoryRoleJobs." & Me.Name)
            With Me.gvHistoryRoleJobs
                .PopulateColumns(iDataSet.Tables("HistoryRoleJobs." & Me.Name))
                .Columns("DtChange").Caption = "Дата"
                .Columns("RoleJobsId").Visible = False
                .Columns("RoleJobs").Caption = "Наименование должности"
                .Columns("DtUpdate").Caption = "Изменено"
                .Columns("Updater").Caption = "Автор"
                .BestFitColumns()
            End With
        End If
        ' сортировка таблицы через датасет
        clsMyUserFunction.SortDataTable(iDataSet.Tables("HistoryRoleJobs." & Me.Name), "DtChange")
        ' фокус на строку по Дате
        Me.gvHistoryRoleJobs.FocusedRowHandle = Me.gvHistoryRoleJobs.LocateByValue("DtChange", NewRecord_HistoryRoleJobs)
    End Sub
    ' дизайнер контактов пользователя
    Private Sub DesignerPerformerContacts()
        SelectQueryData(
                       "PerformersContacts." & Me.Name,
                       "EXEC PerformersContactsFunction @PerformerId = " & PerformerId & ", @Function = 1",
                       "GetPerformersContacts"
                       )
        If Me.lbxContacts.DataSource Is Nothing Then
            Me.lbxContacts.DataSource = iDataSet.Tables("PerformersContacts." & Me.Name)
            Me.lbxContacts.DisplayMember = "NumberString"
        End If
    End Sub
#End Region

#Region "Контакты пользователя"
    ' добавить контакт пользователя
    Private Sub gcContacts_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles gcContacts.CustomButtonClick
        If e.Button.Properties.Caption = "btnAddContact" Then
            If frAddEditContact.ShowDialog() = DialogResult.OK Then
                DesignerPerformerContacts()
            End If
        End If
    End Sub
    ' редактировать и удалить контакт пользователя
    Private Sub lbxContacts_ContextButtonClick(sender As Object, e As DevExpress.Utils.ContextItemClickEventArgs) Handles lbxContacts.ContextButtonClick
        Dim btn As ContextButton = e.Item
        Select Case btn.Name
            Case "btnEditPerfPhone" ' Редактировать
                frAddEditContact.AddEdit = 3
                If frAddEditContact.ShowDialog() = DialogResult.OK Then DesignerPerformerContacts()
            Case "btnDelPerfPhone"  ' Удалить
                Dim iRow As DataRowView = CType(lbxContacts.SelectedItem, DataRowView)
                If XtraMessageBox.Show("Выбранный контакт пользователя <b><u>" & iRow("ContactType") & " - " & iRow("Number") & "</u></b> будет удален!" & Chr(10) &
                                       "Вы согласны?",
                                       Application.ProductName,
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question,
                                       DefaultBoolean.True) = DialogResult.Yes Then
                    If ExecuteScalar("EXEC PerformersContactsFunction " &
                                        "@ContactId = " & iRow("ContactId") & ", " &
                                        "@Function = 4") Then
                        DesignerPerformerContacts()
                    End If
                End If
        End Select
    End Sub
    ' движение по контактам пользователя для отображения типа контакта
    Private Sub lbxContacts_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lbxContacts.MouseMove
        Dim listBoxControl As ListBoxControl = TryCast(sender, ListBoxControl)
        Dim index As Integer = listBoxControl.IndexFromPoint(New Point(e.X, e.Y))
        If index <> -1 Then
            Dim item As String = iDataSet.Tables("PerformersContacts." & Me.Name).Rows(index).Item("ContactType") 'TryCast(listBoxControl.GetItem(index), String)
            ToolTipController1.SetAllowHtmlText(listBoxControl, DefaultBoolean.True)
            ToolTipController1.ShowHint(item, listBoxControl.PointToScreen(New Point(e.X, e.Y)))
        Else
            ToolTipController1.HideHint()
        End If
    End Sub
    ' уход курсора от контактов пользователя
    Private Sub lbxContacts_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles lbxContacts.MouseLeave
        ToolTipController1.HideHint()
    End Sub
#End Region

#Region "История должностных обязанностей"
    ' добавить должность
    Private Sub btnAddRoleJobs_Click(sender As Object, e As EventArgs) Handles btnAddRoleJobs.Click
        If frAddEditHistoryRoleJobs.ShowDialog() = DialogResult.OK Then
            DesignerHistoryRoleJobs()
        End If
    End Sub
    ' редактировать должность
    Private Sub btnEditRoleJobs_Click(sender As Object, e As EventArgs) Handles btnEditRoleJobs.Click
        frAddEditHistoryRoleJobs.AddEdit = 3
        If frAddEditHistoryRoleJobs.ShowDialog() = DialogResult.OK Then
            DesignerHistoryRoleJobs()
        End If
    End Sub
    ' удалить должность
    Private Sub btnDeleteRoleJobs_Click(sender As Object, e As EventArgs) Handles btnDeleteRoleJobs.Click
        If XtraMessageBox.Show("Выбранная запись будет удалена!" & Chr(10) &
                               "Вы согласны?",
                               Application.ProductName,
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) = DialogResult.Yes Then
            If ExecuteScalar(
                          "EXEC PerformersHistoryRJFuction 
                            @PerformerId = " & PerformerId & ", 
                            @DtChange = " & clsForSQL.InDataBase(Me.gvHistoryRoleJobs.GetFocusedRowCellDisplayText("DtChange")) & ",
                            @Function = 4",
                          "DeleteRoleJob"
                          ) = 1 Then
                DesignerHistoryRoleJobs()
            End If
        End If
    End Sub
#End Region

    ' таймер проверки полей
    Private Sub tmrCheckedFields_Tick(sender As Object, e As EventArgs) Handles tmrCheckedFields.Tick
        ' если обязательные поля не заполнены
        If clsForSQL.InDataBase(Me.txtLogin.Text) = "NULL" Or
           clsForSQL.InDataBase(Me.txtPassword1.Text) = "NULL" Or
           clsForSQL.InDataBase(Me.txtPassword2.Text) = "NULL" Or
           clsForSQL.InDataBase(Me.txtSurname.Text) = "NULL" Or
           clsForSQL.InDataBase(Me.txtName.Text) = "NULL" Or
           clsForSQL.InDataBase(Me.txtPatronymic.Text) = "NULL" Or
           Me.lbxPerfGroups.CheckedItemsCount = 0 Or
           Me.txtPassword1.ErrorText <> "" Or
           Me.txtPassword2.ErrorText <> "" Then
            Me.btnSave.Enabled = False  ' нельзя сохранить
            Me.btnOk.Enabled = False
        Else
            Me.btnSave.Enabled = True   ' можно сохранить
            Me.btnOk.Enabled = PerformerId <> "NULL" And Me.gvHistoryRoleJobs.RowCount <> 0
        End If
        ' редактировать и удалить дожность если только есть записи
        Me.btnEditRoleJobs.Enabled = Me.gvHistoryRoleJobs.RowCount <> 0
        Me.btnDeleteRoleJobs.Enabled = Me.gvHistoryRoleJobs.RowCount <> 0
        ' активность кнопок если пользователь еже создан 
        Me.gcContacts.Enabled = PerformerId <> "NULL"
        Me.gcHistoryRoleJobs.Enabled = PerformerId <> "NULL"
        Me.btnAddRoleJobs.Enabled = PerformerId <> "NULL"
    End Sub
    ' получение ид выбранных групп работников
    Private Function GetSelectedGroups() As String
        Dim text As String = String.Empty
        For Each item As Object In Me.lbxPerfGroups.CheckedItems
            Dim row As DataRowView = TryCast(item, DataRowView)
            text &= String.Format("{0},", row("Id"))
        Next item
        Return text.TrimEnd(",")
    End Function
    ' проверка совпадения паролей при выходе из поля
    Private Sub txtPassword2_Properties_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles _
        txtPassword1.Properties.Validating, txtPassword2.Properties.Validating
        CheckedPassword()
    End Sub
    ' проверка совпадения паролей
    Private Sub CheckedPassword()
        If Me.txtPassword1.EditValue <> Me.txtPassword2.EditValue Then
            Me.txtPassword1.ErrorText = "Пароль не совпадают ..."
            Me.txtPassword2.ErrorText = "Пароль не совпадают ..."
            Me.btnSave.Enabled = False
        Else
            Me.txtPassword1.ErrorText = Nothing
            Me.txtPassword2.ErrorText = Nothing
        End If
    End Sub
    ' проверка совпадения паролей при вводе значений
    Private Sub txtPassword2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword1.TextChanged, txtPassword2.TextChanged
        CheckedPassword()
    End Sub
    ' кнопка сохранить и Ок
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click, btnOk.Click
        Dim perf As String
        perf = ExecuteScalar(
                         "EXEC PerformersFunctions " &
                            "@PerformerId = " & PerformerId & ", " &
                            "@Login = " & clsForSQL.InDataBase(Me.txtLogin.Text) & ", " &
                            "@Password = " & clsForSQL.InDataBase(Me.txtPassword1.Text) & ", " &
                            "@Surname = " & clsForSQL.InDataBase(Me.txtSurname.Text) & ", " &
                            "@Name = " & clsForSQL.InDataBase(Me.txtName.Text) & ", " &
                            "@Patronymic = " & clsForSQL.InDataBase(Me.txtPatronymic.Text) & ", " &
                            "@Address = " & clsForSQL.InDataBase(Me.txtAddress.Text) & ", " &
                            "@DtBirth = " & clsForSQL.InDataBase(Me.txtDtBirth.Text) & ", " &
                            "@RoomNumber = " & clsForSQL.InDataBase(Me.txtRoomNumber.Text) & ", " &
                            "@PerformersGroups = " & clsForSQL.InDataBase(GetSelectedGroups) & ", " &
                            "@SexId = " & clsForSQL.InDataBase(Me.cmdSex.SelectedIndex) & ", " &
                            "@Email = " & clsForSQL.InDataBase(Me.txtEmail.Text) & ", " &
                            "@Function = " & AddOrEdit,
                        "CreateUser"
                        )
        If perf <> "err" And perf IsNot Nothing Then
            PerformerId = perf
            frSecurityUsers.NewRecord_PerformeId = perf
            If AddOrEdit = 2 Then
                XtraMessageBox.Show("Логин <b>" & Me.txtLogin.Text & "</b> успешно добавлен в базу данных <b>" & pref_DataBaseName & "</b>!" & Chr(10) &
                                    "Теперь необходимо присвоить сотруднику должность ...",
                                    Application.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information,
                                    DefaultBoolean.True)
                AddOrEdit = 3
            End If
            ' закрытие формы только по кнопке Ок
            If sender.Name = "btnOk" Then Me.DialogResult = DialogResult.OK
        End If
    End Sub
    ' выделение текста в полях при входе
    Private Sub txtLogin_Enter(sender As Object, e As EventArgs) Handles _
            txtLogin.Properties.Enter, txtPassword1.Properties.Enter, txtPassword2.Properties.Enter,
            txtSurname.Properties.Enter, txtName.Properties.Enter, txtPatronymic.Properties.Enter,
            txtAddress.Properties.Enter, txtDtBirth.Properties.Enter, txtRoomNumber.Properties.Enter,
            txtEmail.Properties.Enter
        sender.SelectAll()
    End Sub
    ' очищение текста в полях
    Private Sub txtLogin_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles _
            txtLogin.ButtonClick, txtPassword1.ButtonClick, txtPassword2.ButtonClick,
            txtSurname.ButtonClick, txtName.ButtonClick, txtPatronymic.ButtonClick,
            txtAddress.ButtonClick, txtDtBirth.ButtonClick, txtRoomNumber.ButtonClick,
            txtEmail.ButtonClick
        Dim btn As EditorButton = e.Button
        If btn.Caption <> "" Then Me.Controls(btn.Caption).Text = Nothing
    End Sub
End Class