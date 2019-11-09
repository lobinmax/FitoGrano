Imports System.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frAddEditCountry
    Friend AddEdit As Integer = 2
    Dim iRowCurrent As DataRow
    Dim CanResize As Boolean = False    ' возможно изменение размера формы
    Dim IsResize As Boolean = False     ' происходит изменения размера

    ' Таскание формы за любой участок
    Private Sub Control_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, lbNameForm.MouseDown,
        GroupControl1.MouseDown, GroupControl2.MouseDown
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
    'Загрузка формы
    Private Sub frAddEditContact_Load(sender As Object, e As EventArgs) Handles Me.Load
        clsMyUserFunction.LoadViewForm(Me)
        EventChangedControl = False
        If AddEdit = 2 Then EventChangedControl = True : Me.txtCountryNameShort.Select() : Exit Sub
        Me.lbNameForm.Text = "Редактировать страну"
        ' текущая строка в таблице
        iRowCurrent = iDataSet.Tables("Books_Contries." & frBooks_CountryAgreements.Name).Rows(frBooks_CountryAgreements.gvCountries.FocusedRowHandle)
        Me.txtCountryNameShort.EditValue = iRowCurrent("NameShort")
        Me.txtCountryNameLong.EditValue = iRowCurrent("NameLong")
        Me.txtCountryAlpha1.EditValue = iRowCurrent("Alpha1")
        Me.txtCountryAlpha2.EditValue = iRowCurrent("Alpha2")
        EventChangedControl = True
        Me.txtCountryNameShort.Select()
    End Sub
    ' Кнопка Ok
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If clsForSQL.InDataBase(Me.txtCountryNameShort.Text) = "NULL" Or
           clsForSQL.InDataBase(Me.txtCountryAlpha1.Text) = "NULL" Or
           clsForSQL.InDataBase(Me.txtCountryAlpha2.Text) = "NULL" Then
            XtraMessageBox.Show("Не все обязательные поля заполнены!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim Id As String = "NULL"
        Dim NewId As String
        If AddEdit = 3 Then Id = iRowCurrent("Id")
        NewId = ExecuteScalar(
                              "EXEC Books_CountriesFunction 
                                    @CountryId = " & Id & ", 
                                    @CountryNameShort = " & clsForSQL.InDataBase(Me.txtCountryNameShort.EditValue) & ", 
                                    @CountryNameLong = " & clsForSQL.InDataBase(Me.txtCountryNameLong.EditValue) & ",
                                    @CountryAlpha1 = " & clsForSQL.InDataBase(Me.txtCountryAlpha1.EditValue) & ", 
                                    @CountryAlpha2 = " & clsForSQL.InDataBase(Me.txtCountryAlpha2.EditValue) & ", 
                                    @Parameter = 1, 
                                    @Function = " & AddEdit,
                              "Books_CountriesFunction.Parameter = 1, Function = " & AddEdit
                             )
        If NewId <> "err" Then
            If AddEdit = 2 Then frBooks_CountryAgreements.NewId_Countries = NewId
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
    ' очистить поле
    Private Sub txtProductsName_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCountryNameShort.ButtonClick, txtCountryNameLong.ButtonClick, txtCountryAlpha1.ButtonClick, txtCountryAlpha2.ButtonClick
        Dim btn As EditorButton = e.Button
        If btn.Index = 0 Then sender.Text = ""
    End Sub
    ' перевод курсора по ентору
    Private Sub txtCountryNameLong_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCountryNameLong.KeyDown
        If e.KeyData = Keys.Enter Then Me.GroupControl2.Select()
    End Sub
End Class