Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frSecurityUsers
    Friend NewRecord_PerformeId As String

    ' закрытие формы
    Private Sub frSecurityUsers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        clsMyUserFunction.RemoveTableDataSet(Me)
    End Sub
    ' загрузка формы
    Private Sub frSecurityUsers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.lbServerName.Caption = pref_ServerIP
        Me.lbDB_name.Caption = pref_DataBaseName
        DesignerPerformers()
        'gvPerformers_RowCellClick(Me.gvPerformers, Nothing)
    End Sub

#Region "Дизайнеры"
    ' дизайнер исполнителей
    Private Sub DesignerPerformers()
        EventChangedControl = False
        SelectQueryData("Performers." & Me.Name, "EXEC PerformersFunctions @Function = 1")
        If Me.gcPerformers.DataSource Is Nothing Then
            Me.gcPerformers.DataSource = iDataSet.Tables("Performers." & Me.Name)
            mdHidenAllColumns.HidenAllColumns_Grid(Me.gvPerformers, iDataSet.Tables("Performers." & Me.Name))
            With Me.gvPerformers
                .Columns("RolesJobShort").Visible = True
                .Columns("RolesJobShort").Caption = "Должность"
                .Columns("SNP").Visible = True
                .Columns("SNP").Caption = "ФИО"
            End With
        End If
        EventChangedControl = True
        Me.gvPerformers.BestFitColumns()
        Me.gvPerformers.FocusedRowHandle = Me.gvPerformers.LocateByValue("PerformerId", CType(NewRecord_PerformeId, Integer))
    End Sub
    ' дизайнер контактов пользователя
    Private Sub DesignerPerformerContacts(ByRef PerformerId As String)
        PerformerId = clsForSQL.InDataBase(PerformerId)
        SelectQueryData(
                            "PerformersContacts." & Me.Name,
                            "EXEC PerformersContactsFunction @PerformerId = " & PerformerId & ", @Function = 1",
                            "GetPerformersContacts"
                            )
        Me.lbxContacts.DataSource = iDataSet.Tables("PerformersContacts." & Me.Name)
        Me.lbxContacts.DisplayMember = "NumberString"
    End Sub
    ' Дизайнер групп пользователей 
    Private Sub DesignerPerfGroups(ByRef PerformerId As String)
        PerformerId = clsForSQL.InDataBase(PerformerId)
        SelectQueryData(
                        "PerformersRightGroups." & Me.Name,
                        "SELECT * FROM vPerformersGroups pg 
                         WHERE pg.PerformerId = " & PerformerId,
                        "GetPerformersRightGroups"
                        )
        Me.lbxPerfGroups.DataSource = iDataSet.Tables("PerformersRightGroups." & Me.Name)
        Me.lbxPerfGroups.DisplayMember = "Name"
        Me.lbxPerfGroups.ValueMember = "Id"
    End Sub
#End Region

#Region "События gvPerformers"
    ' изменение фокуса в таблиуе исполнителей
    Private Sub gvPerformers_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvPerformers.FocusedRowChanged
        Dim iRow As DataRow = sender.GetFocusedDataRow
        If EventChangedControl Then NewRecord_PerformeId = iRow("PerformerId").ToString
        Me.txtAddress.Text = iRow("Address").ToString
        Me.gcPerformerInformation.Text = " Информация о сотруднике <u>" & iRow("SNP").ToString & "</u>"
        Me.txtDtBirth.Text = If(iRow("DtBirth").ToString <> "", CType(iRow("DtBirth").ToString, Date).ToShortDateString, "")
        Me.txtRoleJob.Text = iRow("RolesJobShort").ToString
        Me.txtRoomNumber.Text = iRow("RoomNumber").ToString
        Me.txtSex.Text = iRow("Sex").ToString
        Me.txtSex.Properties.ContextImageOptions.Image = If(iRow("SexId").ToString = 0, My.Resources.SexWomen_16x16, My.Resources.SexMen_16x16)
        Me.txtEmail.Text = iRow("Email").ToString
        DesignerPerformerContacts(iRow("PerformerId").ToString)
        DesignerPerfGroups(iRow("PerformerId").ToString)
    End Sub
    ' двойной клик по исполнителю
    Private Sub gvPerformers_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gvPerformers.RowCellClick
        If e.Clicks = 2 And e.Button = Windows.Forms.MouseButtons.Left And btnEditPerformer.Enabled Then
            btnEditPerformer_ItemClick(btnEditPerformer, Nothing)
        End If
        If e.Clicks = 1 Then
            gvPerformers_FocusedRowChanged(gvPerformers, Nothing)
        End If
    End Sub
    ' Перехват кнопки DELETE на исполнителях
    Private Sub gvPerformers_KeyDown(sender As Object, e As KeyEventArgs) Handles gvPerformers.KeyDown
        If e.KeyData = Keys.Delete Then
            btnDelPerformer_ItemClick(btnDelPerformer, Nothing)
        End If
    End Sub
    ' вызов контекстного меню на исполнителях
    Private Sub gvPerformers_MouseDown(sender As Object, e As MouseEventArgs) Handles gvPerformers.MouseDown
        Dim view As GridView = CType(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If e.Button = MouseButtons.Right And e.Clicks = 1 Then
            Me.btnEditPerformer_pm.Enabled = info.InRow
            Me.btnDelPerformer_pm.Enabled = info.InRow
            Me.pmMenuPerformers.ShowPopup(MousePosition)
        End If
    End Sub
#End Region

#Region "Управление исполнителями"
    ' добавить исполнителя
    Private Sub btnAddPerformer_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddPerformer.ItemClick, btnAddPerformer_pm.ItemClick
        frAddEditPerformer.AddOrEdit = 2
        If frAddEditPerformer.ShowDialog() = DialogResult.OK Then
            DesignerPerformers()
        End If
    End Sub
    ' редиктировать исполнителя
    Private Sub btnEditPerformer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditPerformer.ItemClick, btnEditPerformer_pm.ItemClick
        frAddEditPerformer.AddOrEdit = 3
        If frAddEditPerformer.ShowDialog = DialogResult.OK Then
            DesignerPerformers()
        End If
    End Sub
    ' удалить исполнителя
    Private Sub btnDelPerformer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelPerformer.ItemClick, btnDelPerformer_pm.ItemClick
        If XtraMessageBox.Show("Пользователь <b><u>" & Me.gvPerformers.GetFocusedRowCellDisplayText("SNP") & "</u></b> будет удален." & Chr(10) &
                               "Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultBoolean.True) = DialogResult.Yes Then
            If ExecuteScalar(
                             "EXEC PerformersFunctions 
                                @Login = " & Me.gvPerformers.GetFocusedRowCellDisplayText("Login") & ", 
                                @Function = 4",
                             "DeleteUser"
                             ) <> "err" Then
                DesignerPerformers()
            End If
        End If
    End Sub
#End Region

    ' контектные кнопки информации о сотруднике
    Private Sub gcPerformerInformation_CustomButtonClick(sender As System.Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles gcPerformerInformation.CustomButtonClick
        Dim _min As Integer = 30
        Dim _max As Integer = 193
        Select Case e.Button.Properties.GroupIndex
            Case 0 ' Статистика подключений

            Case 2 ' Свернуть / Развернуть
                Select Case e.Button.Properties.Tag
                    Case 0 ' свернуть
                        e.Button.Properties.Tag = 1
                        e.Button.Properties.ImageOptions.Image = My.Resources.down_20x20
                        Me.gcPerformerInformation.Size = New Size(Me.gcPerformerInformation.Size.Width, 30)
                        Me.tlRightsPerformer.Location = New Point(Me.tlRightsPerformer.Location.X, Me.tlRightsPerformer.Location.Y - (_max - _min))
                        Me.tlRightsPerformer.Size = New Point(Me.tlRightsPerformer.Size.Width, Me.tlRightsPerformer.Size.Height + (_max - _min))
                    Case 1 ' развернуть
                        e.Button.Properties.Tag = 0
                        e.Button.Properties.ImageOptions.Image = My.Resources.up_20x20
                        Me.gcPerformerInformation.Size = New Size(Me.gcPerformerInformation.Size.Width, 193)
                        Me.tlRightsPerformer.Location = New Point(Me.tlRightsPerformer.Location.X, Me.tlRightsPerformer.Location.Y + (_max - _min))
                        Me.tlRightsPerformer.Size = New Point(Me.tlRightsPerformer.Size.Width, Me.tlRightsPerformer.Size.Width - (_max - _min))
                End Select
        End Select
    End Sub
    ' таймер для активности кнопок
    Private Sub tmChecked_Tick(sender As Object, e As EventArgs) Handles tmChecked.Tick
        Dim gvPerformersRowCount As Integer = Me.gvPerformers.RowCount

        SplitContainerControl1.Panel2.Enabled = gvPerformersRowCount <> 0
        Me.btnEditPerformer.Enabled = gvPerformersRowCount <> 0
        Me.btnDelPerformer.Enabled = gvPerformersRowCount <> 0
    End Sub
    ' обновить форму
    Private Sub btnUpdate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUpdate.ItemClick
        DesignerPerformers()
    End Sub
End Class