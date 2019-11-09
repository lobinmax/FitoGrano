Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraTreeList.Nodes

Public Class frAddEditOrganizationsRoleJob
    Dim Id As String = "NULL"   ' Ид текущей записи 
    Friend AddOrEdit As Integer = 2
    ' Таскание формы за любой участок
    Private Sub Control_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelControl1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Cursor = Cursors.NoMove2D
            sender.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, New IntPtr(2), IntPtr.Zero))
            Me.Cursor = Cursors.Default
        End If
    End Sub
    ' Закрытые формы
    Private Sub FrAddEditOrganizations_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    ' Загрузка формы
    Private Sub FrAddEditOrganizations_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim curNode As TreeListNode = frBooks_OrganizationStructure.tlStructure.FocusedNode
        If AddorEdit = 3 Then
            Id = curNode("Id")
            Me.txtNameOrganization.Text = curNode("Name")
            Me.txtNote.Text = curNode("Notes")
        End If
        Me.txtNameOrganization.Select()
    End Sub

    ' Добавление или изменение
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim NewId As String = "Nothing"
        Dim ParentId As String = frBooks_OrganizationStructure.tlStructure.FocusedNode("Id")
        If AddorEdit = 3 Then ParentId = frBooks_OrganizationStructure.tlStructure.FocusedNode("ParentId")
        If CheckeFeilds() = False Then Exit Sub
        NewId = ExecuteScalar(
                        "EXEC OrganizationStructureFunction " &
                            "@Id = " & Id & ", " &
                            "@ParentId = " & ParentId & ", " &
                            "@Name = " & clsForSQL.InDataBase(Me.txtNameOrganization.Text) & ", " &
                            "@Notes = " & clsForSQL.InDataBase(Me.txtNote.Text) & ", " &
                            "@Level = 3, " &
                            "@Function = " & AddorEdit,
                        "EXEC OrganizationStructureFunction. @Function = 2"
                        )
        If NewId IsNot Nothing And AddorEdit = 2 And NewId <> "err" Then
            glNewId = NewId
            Me.DialogResult = DialogResult.OK
        End If
        If NewId Is Nothing And AddorEdit = 3 Then
            Me.DialogResult = DialogResult.OK
        End If

        If NewId = "err" Then Exit Sub
    End Sub
#Region "Очистка полей"
    Private Sub txtNameOrganization_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtNameOrganization.Properties.ButtonClick
        Dim btn As EditorButton = e.Button
        Dim btnCapt As String = btn.Caption
        Me.PanelControl1.Controls(btnCapt).Text = Nothing
    End Sub
    Private Sub btnClearNotes_Click(sender As Object, e As EventArgs) Handles btnClearNotes.Click
        Me.txtNote.Text = Nothing
    End Sub
#End Region
    ' Проверка заполнения полей
    Private Function CheckeFeilds() As Boolean
        If clsForSQL.InDataBase(Me.txtNameOrganization.Text) = "NULL" Then
            XtraMessageBox.Show("Не все обязательные поля заполнены!",
                                Application.ProductName,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                DevExpress.Utils.DefaultBoolean.True)
            Return False
        End If
        Return True
    End Function

End Class