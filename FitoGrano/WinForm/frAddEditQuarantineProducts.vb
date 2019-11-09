Public Class frAddEditQuarantineProducts
    ' Ид выбранной страны
    Dim CurrentCountryId As String = frBooks_CountryAgreements.gvCountries.GetFocusedRowCellDisplayText("Id")
    Dim CanResize As Boolean = False    ' возможно изменение размера формы
    Dim IsResize As Boolean = False     ' происходит изменения размера

    ' Таскание формы за любой участок
    Private Sub Control_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, lbNameForm.MouseDown
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
        Me.Location = Cursor.Position
        clsMyUserFunction.LoadViewForm(Me)
        tlAddEditQuarantineProducts.LoadTreeList(ShowCountProducts:=1, IsExpClassification:=0)
        tlAddEditQuarantineProducts.SetMultiCheckedProductId(CurrentCountryId)
        Me.tlAddEditQuarantineProducts.SetCaptionTreeList("Классификация продукции: " & Chr(10) &
                                                          frBooks_CountryAgreements.gvCountries.GetFocusedRowCellDisplayText("NameShort"))
    End Sub
    ' Кнопка Ok
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim NewId As String
        NewId = ExecuteScalar(
                              "Books_CountriesFunction 
                                    @CountryId = " & CurrentCountryId & ", 
                                    @ProductsMultyString = " & Me.tlAddEditQuarantineProducts.GetMultiStringProductId & ", 
                                    @Parameter = 3",
                              "Books_CountriesFunction.SetProducts"
                             )
        If NewId <> "err" Then
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
End Class