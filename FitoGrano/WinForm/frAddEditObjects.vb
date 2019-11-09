Imports System.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frAddEditObjects
    Friend AddEdit As Integer = 2
    Dim iRowCurrent As DataRow
    Dim CanResize As Boolean = False    ' возможно изменение размера формы
    Dim IsResize As Boolean = False     ' происходит изменения размера
    ' Таскание формы за любой участок
    Private Sub Control_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, lbNameForm.MouseDown, LabelControl1.MouseDown, LabelControl13.MouseDown
        CanResize = True
        If e.Button = Windows.Forms.MouseButtons.Left And IsResize = False Then
            Me.Cursor = Cursors.NoMove2D
            sender.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, New IntPtr(2), IntPtr.Zero))
            Me.Cursor = Cursors.Default
        End If
    End Sub
    ' Закрытие формы
    Private Sub frAddEditContact_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        clsMyUserFunction.SaveViewForm(Me)
    End Sub
    'Отмена
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, btnClose.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    ' изменение размера формы
    Private Sub frAddEditCountry_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.X > Me.Width - 10 And e.Y > Me.Height - 10 Then
            Me.Cursor = Cursors.SizeNWSE
            IsResize = True
        Else
            Cursor = Cursors.Default
            IsResize = False
        End If
        If e.Button = Windows.Forms.MouseButtons.Left And CanResize Then
            Me.Size = New Size(e.X, e.Y)
            Application.DoEvents()
        End If
    End Sub
    ' Невозможно изменение размера формы
    Private Sub lbNameForm_MouseUp(sender As Object, e As MouseEventArgs) Handles lbNameForm.MouseUp
        CanResize = False
    End Sub
    ' загрузка формы
    Private Sub frAddEditObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clsMyUserFunction.LoadViewForm(Me)
        Me.tlResearchMetods.LoadMethodList(IsExpDirection:=False)
        EventChangedControl = False
        If AddEdit = 2 Then EventChangedControl = True : Me.txtObjectNameRU.Select() : Exit Sub
        Me.lbNameForm.Text = "Редактировать объект исследования"
        ' текущая строка в таблице
        iRowCurrent = iDataSet.Tables("Books_Objects." & frBooks_ResearchObjects.Name).Rows(frBooks_ResearchObjects.gvObjects.FocusedRowHandle)
        Me.txtObjectNameRU.EditValue = iRowCurrent("Name")
        Me.txtObjectNameLAT.EditValue = iRowCurrent("NameLatin")
        Me.tlResearchMetods.SetMultiCheckedObjectId(iRowCurrent("Id"))
        EventChangedControl = True
        Me.txtObjectNameRU.Select()
    End Sub
    ' кнопка ОК
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Me.tlResearchMetods.GetMultiStringMethodId = "NULL" Then
            XtraMessageBox.Show("Не указаны методы для объекта исследования!",
                                Application.ProductName,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            Exit Sub
        End If
        If clsForSQL.InDataBase(Me.txtObjectNameRU.Text) = "NULL" Or
            clsForSQL.InDataBase(Me.txtObjectNameLAT.Text) = "NULL" Then
            XtraMessageBox.Show("Не все обязательные поля заполнены!",
                                Application.ProductName,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim ObjectTypeId As String = frBooks_ResearchObjects.Accord.SelectedElement.Tag
        Dim Id As String = "NULL"
        Dim NewId As String
        If AddEdit = 3 Then Id = iRowCurrent("Id")
        NewId = ExecuteScalar(
                              "EXEC Books_ObjectsFunc 
                                    @ObjectId = " & Id & ", 
                                    @ObjectTypeId = " & ObjectTypeId & ", 
                                    @ObjectName = " & clsForSQL.InDataBase(Me.txtObjectNameRU.EditValue) & ", 
                                    @ObjectNameLatin = " & clsForSQL.InDataBase(Me.txtObjectNameLAT.EditValue) & ",
                                    @MethodsMultiString = " & Me.tlResearchMetods.GetMultiStringMethodId & ",
                                    @Function = " & AddEdit,
                              "Books_ObjectsFunc.Function = " & AddEdit
                              )

        If NewId <> "err" Then
            If AddEdit = 2 Then frBooks_ResearchObjects.NewId_Object = NewId
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
    ' очистить поле
    Private Sub txtProductsName_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtObjectNameRU.ButtonClick, txtObjectNameLAT.ButtonClick
        Dim btn As EditorButton = e.Button
        If btn.Index = 0 Then sender.Text = ""
    End Sub
End Class