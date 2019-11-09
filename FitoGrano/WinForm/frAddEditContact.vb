Imports System.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frAddEditContact 'W = 235; H = 142
    Friend AddEdit As Integer = 2
    Dim iRowCurrent As DataRowView
    Dim ContactId As String = "NULL"
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
    Private Sub frAddEditContact_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    'Загрузка формы
    Private Sub frAddEditContact_Load(sender As Object, e As EventArgs) Handles Me.Load
        If IsNumeric(frAddEditPerformer.PerformerId) = False Then
            XtraMessageBox.Show("Не удалось определить пользователя, для добавления контакта ...",
                                Application.ProductName,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            Me.Close()
        End If
        If AddEdit = 3 Then
            Me.lbNameForm.Text = "Редактировать контакт"
            iRowCurrent = CType(frAddEditPerformer.lbxContacts.SelectedItem, DataRowView)
            ContactId = clsForSQL.OutDataBase(iRowCurrent("ContactId"))
        End If
        Me.Location = MousePosition
        rgContactsTypes_SelectedIndexChanged(Me.rgContactsTypes, e)
        Me.txtPhoneNumber.Text = If(iRowCurrent IsNot Nothing, clsForSQL.OutDataBase(iRowCurrent("Number")), "")
        Me.rgContactsTypes.SelectedIndex = If(iRowCurrent IsNot Nothing, clsForSQL.OutDataBase(iRowCurrent("ContactTypeId")), 0)
        Me.txtPhoneNumber.Select()
    End Sub
    ' Добавление новой записи
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim _ContactId As String
        If clsForSQL.InDataBase(Me.txtPhoneNumber.Text) = "NULL" Then Exit Sub
        _ContactId = ExecuteScalar(
                          "EXEC PerformersContactsFunction " &
                                "@ContactId = " & ContactId & ", " &
                                "@PerformerId = " & frAddEditPerformer.PerformerId & ", " &
                                "@ContactTypeId = " & Me.rgContactsTypes.SelectedIndex & ", " &
                                "@Number = " & clsForSQL.InDataBase(Me.txtPhoneNumber.Text) & ", " &
                                "@Function = " & AddEdit,
                          If(AddEdit = 2, "Add", "Edit") & "PerformerContact"
                          )
        Select Case AddEdit
            Case 2
                If _ContactId <> "err" And _ContactId IsNot Nothing Then
                    frAddEditPerformer.NewRecord_Contact = _ContactId
                    Me.DialogResult = DialogResult.OK
                End If
            Case 3
                If _ContactId <> "err" And _ContactId IsNot Nothing Then
                    If CType(_ContactId, Boolean) Then
                        Me.DialogResult = DialogResult.OK
                    End If
                End If
        End Select
    End Sub
    'Отмена
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, btnClose.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    ' Очистить поле
    Private Sub txtPhoneNumber_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtPhoneNumber.Properties.ButtonClick
        Dim btn As EditorButton = e.Button
        If btn.Index = 0 Then sender.Text = ""
    End Sub
    ' смена типа контакта
    Private Sub rgContactsTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgContactsTypes.SelectedIndexChanged
        ' получаем иконку из ресурсов по имени 
        Dim img As System.Drawing.Image = My.Resources.ResourceManager.GetObject(Me.rgContactsTypes.Properties.Items.Item(Me.rgContactsTypes.SelectedIndex).Value.ToString())
        Dim maskedit As String = sender.Properties.Items.Item(Me.rgContactsTypes.SelectedIndex).Tag.ToString() ' текст маски
        Me.txtPhoneNumber.Properties.ContextImageOptions.Image = img ' меняем иконку на поле 
        If maskedit = "" Then
            Me.txtPhoneNumber.Properties.Mask.EditMask = ""
            Me.txtPhoneNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Else
            Me.txtPhoneNumber.Properties.Mask.EditMask = maskedit
            Me.txtPhoneNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        End If
    End Sub
End Class