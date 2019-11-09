Imports System.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frAddEditCountryAgreement
    Friend AddEdit As Integer = 2
    Dim iRowCurrent As DataRow
    Dim CanResize As Boolean = False    ' возможно изменение размера формы
    Dim IsResize As Boolean = False     ' происходит изменения размера

    ' Таскание формы за любой участок
    Private Sub Control_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, lbNameForm.MouseDown, lbCountryName.MouseDown, lbCountryName.MouseDown
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
        Me.lbCountryName.Text = "<image=#earth_16x16> " & frBooks_CountryAgreements.gvCountries.GetFocusedRowCellDisplayText("Name_a1")
        If AddEdit = 2 Then
            EventChangedControl = True
            Me.txtAgreementDtBegin.EditValue = Now.ToShortDateString
            Me.txtAgreementText.Select()
            Exit Sub
        End If
        Me.lbNameForm.Text = "Редактировать соглашение"
        ' текущая строка в таблице
        iRowCurrent = frBooks_CountryAgreements.gvAgreement.GetFocusedDataRow
        Me.txtAgreementText.Text = iRowCurrent("AgreementText")
        EventChangedControl = True
        Me.txtAgreementText.Select()
    End Sub
    ' Кнопка Ok
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If clsForSQL.InDataBase(Me.txtAgreementText.EditValue) = "NULL" Then
            XtraMessageBox.Show("Не указан текст соглашения!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim Id As String = "NULL"
        Dim NewId As String
        If AddEdit = 3 Then Id = iRowCurrent("Id")
        NewId = ExecuteScalar(
                              "EXEC Books_CountriesFunction 
                                    @CountryId = " & frBooks_CountryAgreements.gvCountries.GetFocusedRowCellDisplayText("Id") & ", 
                                    @AgreementId = " & Id & ", 
                                    @AgreementText = " & clsForSQL.InDataBase(Me.txtAgreementText.EditValue) & ",
                                    @Parameter = 2, 
                                    @Function = " & AddEdit,
                              "Books_CountriesFunction.Parameter = 2, Function = " & AddEdit
                             )
        If NewId <> "err" Then
            If AddEdit = 2 Then frBooks_CountryAgreements.NewId_Countries = NewId
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
    ' удалить дату прекращения
    Private Sub txtAgreementDtEnd_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtAgreementDtEnd.ButtonClick
        Dim btn As EditorButton = e.Button
        If btn.Caption = "btnClearAgreementDtEnd" Then Me.txtAgreementDtEnd.Properties.NullDate = Nothing
    End Sub
End Class