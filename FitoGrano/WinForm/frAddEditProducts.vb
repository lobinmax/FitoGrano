Imports System.Data
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frAddEditProducts
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
        If AddEdit = 2 Then EventChangedControl = True : Me.txtProductsName.Select() : Exit Sub
        Me.lbNameForm.Text = "Редактировать продукцию"
        ' текущая строка в таблице
        iRowCurrent = iDataSet.Tables("Books_Products." & frBooks_ClassificationProducts.Name).Rows(frBooks_ClassificationProducts.gvProducts.FocusedRowHandle)
        Me.txtProductsName.EditValue = iRowCurrent("Name")
        Me.txtWeightSample.EditValue = iRowCurrent("WeightSample")
        EventChangedControl = True

        Me.txtProductsName.Select()
    End Sub
    ' Кнопка Ok
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Me.txtWeightSample.EditValue = 0 Or
            clsForSQL.InDataBase(Me.txtProductsName.Text) = "NULL" Then
            XtraMessageBox.Show("Не все обязательные поля заполнены!",
                                Application.ProductName,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim ParentId As String = frBooks_ClassificationProducts.gvClassification.GetFocusedRowCellDisplayText("Id")
        Dim Id As String = "NULL"
        Dim NewId As String
        If AddEdit = 3 Then Id = iRowCurrent("Id")
        NewId = ExecuteScalar(
                              "EXEC Books_ClassificationsProducts 
                                    @IdClassifications = " & ParentId & ", 
                                    @IdProducts = " & Id & ", 
                                    @NameProducts = " & clsForSQL.InDataBase(Me.txtProductsName.EditValue) & ", 
                                    @WeightSample = " & clsForSQL.InDataBase(Me.txtWeightSample.EditValue) & ", 
                                    @Parameter = 2, 
                                    @Function = " & AddEdit,
                              "Books_ClassificationsProducts.Function = " & AddEdit
                              )

        If NewId <> "err" Then
            If AddEdit = 2 Then frBooks_ClassificationProducts.NewId_Products = NewId
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
    ' очистить поле
    Private Sub txtProductsName_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtProductsName.ButtonClick
        Dim btn As EditorButton = e.Button
        If btn.Index = 0 Then sender.Text = ""
    End Sub
End Class