Imports System.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frAddEditResearchMethod
    Friend AddEdit As Integer = 2
    Dim iRowCurrent As DataRow
    ' Таскание формы за любой участок
    Private Sub Control_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, lbNameForm.MouseDown
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
    'Отмена
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, btnClose.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    'Загрузка формы
    Private Sub frAddEditContact_Load(sender As Object, e As EventArgs) Handles Me.Load
        EventChangedControl = False
        If AddEdit = 2 Then EventChangedControl = True : Me.txtMethodName.Select() : Exit Sub
        Me.lbNameForm.Text = "Редактировать метод"
        ' текущая строка в таблице
        iRowCurrent = iDataSet.Tables("Books_Method." & frBooks_ResearchDirection.Name).Rows(frBooks_ResearchDirection.gvMethod.FocusedRowHandle)
        Me.txtMethodName.EditValue = iRowCurrent("Name")
        Me.cheIsPriority.Checked = Convert.ToBoolean(iRowCurrent("IsPriority"))
        Me.txtLongDay.EditValue = iRowCurrent("LongDay")
        EventChangedControl = True

        Me.txtMethodName.Select()
    End Sub
    ' Кнопка Ok
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If clsForSQL.InDataBase(Me.txtMethodName.Text) = "NULL" Then
            XtraMessageBox.Show("Не указано наименование метода исследования!",
                                Application.ProductName,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim ParentId As String = frBooks_ResearchDirection.gvDirection.GetFocusedRowCellDisplayText("Id")
        Dim Id As String = "NULL"
        Dim NewId As String
        If AddEdit = 3 Then Id = iRowCurrent("Id")
        NewId = ExecuteScalar(
                              "EXEC Books_ResearchDirectionMethod 
                                    @IdDirection = " & ParentId & ", 
                                    @IdMethod = " & Id & ", 
                                    @NameMethod = " & clsForSQL.InDataBase(Me.txtMethodName.EditValue) & ", 
                                    @IsPriority = " & clsForSQL.InDataBase(Convert.ToInt64(Me.cheIsPriority.Checked)) & ", 
                                    @LongDay = " & clsForSQL.InDataBase(Convert.ToInt64(Me.txtLongDay.Text)) & ", 
                                    @Parameter = 2, 
                                    @Function = " & AddEdit,
                              "Books_ResearchDirectionMethod.Function = " & AddEdit
                              )

        If NewId <> "err" Then
            If AddEdit = 2 Then frBooks_ResearchDirection.NewId_Method = NewId
            Me.DialogResult = DialogResult.OK
        Else
            Me.txtMethodName.Select()
        End If
    End Sub
    ' очистить поле
    Private Sub txtMethodName_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtMethodName.ButtonClick
        Dim btn As EditorButton = e.Button
        If btn.Index = 0 Then sender.Text = ""
    End Sub
End Class