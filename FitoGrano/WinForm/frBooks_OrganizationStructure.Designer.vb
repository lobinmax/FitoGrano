<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frBooks_OrganizationStructure
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frBooks_OrganizationStructure))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.tlStructure = New DevExpress.XtraTreeList.TreeList()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.lbAddressOrganization = New DevExpress.XtraEditors.LabelControl()
        Me.lbPhoneOrganization = New DevExpress.XtraEditors.LabelControl()
        Me.lbEmailOrganization = New DevExpress.XtraEditors.LabelControl()
        Me.lbManagerOrganization = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnAddMenu = New DevExpress.XtraBars.BarSubItem()
        Me.btnAddFilial = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddGroup = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddRoleJob = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCollapsedAll = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExpandedAll = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUpdate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSetCurrentFilial = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.tmUpdateForm = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tlStructure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.PictureEdit1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(663, 100)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(95, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(560, 59)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Структура предприятия ФГБУ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "«Федеральный центр оценки безопасности и качества зер" &
    "на»"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(2, 2)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.AllowFocused = False
        Me.PictureEdit1.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.[False]
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ReadOnly = True
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 96)
        Me.PictureEdit1.TabIndex = 0
        '
        'tlStructure
        '
        Me.tlStructure.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tlStructure.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlStructure.Location = New System.Drawing.Point(0, 100)
        Me.tlStructure.Name = "tlStructure"
        Me.tlStructure.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
        Me.tlStructure.OptionsBehavior.Editable = False
        Me.tlStructure.OptionsBehavior.ResizeNodes = False
        Me.tlStructure.OptionsClipboard.AllowHtmlFormat = DevExpress.Utils.DefaultBoolean.[True]
        Me.tlStructure.OptionsCustomization.AllowBandMoving = False
        Me.tlStructure.OptionsCustomization.AllowBandResizing = False
        Me.tlStructure.OptionsCustomization.AllowColumnMoving = False
        Me.tlStructure.OptionsCustomization.AllowColumnResizing = False
        Me.tlStructure.OptionsCustomization.AllowFilter = False
        Me.tlStructure.OptionsCustomization.AllowSort = False
        Me.tlStructure.OptionsFilter.AllowFilterEditor = False
        Me.tlStructure.OptionsMenu.EnableColumnMenu = False
        Me.tlStructure.OptionsMenu.EnableFooterMenu = False
        Me.tlStructure.OptionsNavigation.AutoFocusNewNode = True
        Me.tlStructure.OptionsNavigation.MoveOnEdit = False
        Me.tlStructure.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.tlStructure.OptionsSelection.SelectNodesOnRightClick = True
        Me.tlStructure.OptionsView.ShowColumns = False
        Me.tlStructure.OptionsView.ShowIndicator = False
        Me.tlStructure.Size = New System.Drawing.Size(663, 343)
        Me.tlStructure.TabIndex = 1
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl2.Controls.Add(Me.lbAddressOrganization)
        Me.PanelControl2.Controls.Add(Me.lbPhoneOrganization)
        Me.PanelControl2.Controls.Add(Me.lbEmailOrganization)
        Me.PanelControl2.Controls.Add(Me.lbManagerOrganization)
        Me.PanelControl2.Controls.Add(Me.SeparatorControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 443)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(663, 87)
        Me.PanelControl2.TabIndex = 2
        '
        'lbAddressOrganization
        '
        Me.lbAddressOrganization.AllowHtmlString = True
        Me.lbAddressOrganization.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbAddressOrganization.Location = New System.Drawing.Point(12, 61)
        Me.lbAddressOrganization.Name = "lbAddressOrganization"
        Me.lbAddressOrganization.Size = New System.Drawing.Size(651, 13)
        Me.lbAddressOrganization.TabIndex = 3
        Me.lbAddressOrganization.Text = "Юридический адрес:"
        '
        'lbPhoneOrganization
        '
        Me.lbPhoneOrganization.AllowHtmlString = True
        Me.lbPhoneOrganization.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbPhoneOrganization.Location = New System.Drawing.Point(314, 42)
        Me.lbPhoneOrganization.Name = "lbPhoneOrganization"
        Me.lbPhoneOrganization.Size = New System.Drawing.Size(349, 13)
        Me.lbPhoneOrganization.TabIndex = 2
        Me.lbPhoneOrganization.Text = "Контакты:"
        '
        'lbEmailOrganization
        '
        Me.lbEmailOrganization.AllowHtmlString = True
        Me.lbEmailOrganization.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbEmailOrganization.Location = New System.Drawing.Point(12, 42)
        Me.lbEmailOrganization.Name = "lbEmailOrganization"
        Me.lbEmailOrganization.Size = New System.Drawing.Size(296, 13)
        Me.lbEmailOrganization.TabIndex = 1
        Me.lbEmailOrganization.Text = "Email:"
        '
        'lbManagerOrganization
        '
        Me.lbManagerOrganization.AllowHtmlString = True
        Me.lbManagerOrganization.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbManagerOrganization.Location = New System.Drawing.Point(12, 12)
        Me.lbManagerOrganization.Name = "lbManagerOrganization"
        Me.lbManagerOrganization.Size = New System.Drawing.Size(651, 13)
        Me.lbManagerOrganization.TabIndex = 0
        Me.lbManagerOrganization.Text = "ФИО руководителя:"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Location = New System.Drawing.Point(12, 21)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(646, 23)
        Me.SeparatorControl1.TabIndex = 51
        '
        'PopupMenu
        '
        Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddMenu), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEditRecord), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDeleteRecord), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCollapsedAll, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExpandedAll), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUpdate), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSetCurrentFilial, True)})
        Me.PopupMenu.Manager = Me.BarManager
        Me.PopupMenu.Name = "PopupMenu"
        '
        'btnAddMenu
        '
        Me.btnAddMenu.Caption = "Добавить ..."
        Me.btnAddMenu.Id = 2
        Me.btnAddMenu.ImageOptions.Image = CType(resources.GetObject("btnAddMenu.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddFilial), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddGroup), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddRoleJob)})
        Me.btnAddMenu.Name = "btnAddMenu"
        '
        'btnAddFilial
        '
        Me.btnAddFilial.Caption = "Добавить филиал"
        Me.btnAddFilial.Id = 3
        Me.btnAddFilial.ImageOptions.Image = CType(resources.GetObject("btnAddFilial.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddFilial.Name = "btnAddFilial"
        '
        'btnAddGroup
        '
        Me.btnAddGroup.Caption = "Добавить группу"
        Me.btnAddGroup.Id = 4
        Me.btnAddGroup.ImageOptions.Image = CType(resources.GetObject("btnAddGroup.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddGroup.ImageOptions.LargeImage = CType(resources.GetObject("btnAddGroup.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAddGroup.Name = "btnAddGroup"
        '
        'btnAddRoleJob
        '
        Me.btnAddRoleJob.Caption = "Добавить должность"
        Me.btnAddRoleJob.Id = 5
        Me.btnAddRoleJob.ImageOptions.Image = CType(resources.GetObject("btnAddRoleJob.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddRoleJob.Name = "btnAddRoleJob"
        '
        'btnEditRecord
        '
        Me.btnEditRecord.Caption = "Изменить"
        Me.btnEditRecord.Id = 0
        Me.btnEditRecord.ImageOptions.Image = CType(resources.GetObject("btnEditRecord.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditRecord.Name = "btnEditRecord"
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.Caption = "Удалить"
        Me.btnDeleteRecord.Id = 6
        Me.btnDeleteRecord.ImageOptions.Image = CType(resources.GetObject("btnDeleteRecord.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        '
        'btnCollapsedAll
        '
        Me.btnCollapsedAll.Caption = "Свернуть все"
        Me.btnCollapsedAll.Id = 8
        Me.btnCollapsedAll.ImageOptions.Image = CType(resources.GetObject("btnCollapsedAll.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCollapsedAll.Name = "btnCollapsedAll"
        '
        'btnExpandedAll
        '
        Me.btnExpandedAll.Caption = "Развернуть все"
        Me.btnExpandedAll.Id = 9
        Me.btnExpandedAll.ImageOptions.Image = CType(resources.GetObject("btnExpandedAll.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExpandedAll.Name = "btnExpandedAll"
        '
        'btnUpdate
        '
        Me.btnUpdate.Caption = "Обновить"
        Me.btnUpdate.Id = 11
        Me.btnUpdate.ImageOptions.Image = CType(resources.GetObject("btnUpdate.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUpdate.Name = "btnUpdate"
        '
        'btnSetCurrentFilial
        '
        Me.btnSetCurrentFilial.Caption = "Назначить филиал текущим"
        Me.btnSetCurrentFilial.Id = 10
        Me.btnSetCurrentFilial.ImageOptions.Image = CType(resources.GetObject("btnSetCurrentFilial.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSetCurrentFilial.Name = "btnSetCurrentFilial"
        '
        'BarManager
        '
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnEditRecord, Me.btnAddMenu, Me.btnAddFilial, Me.btnAddGroup, Me.btnAddRoleJob, Me.btnDeleteRecord, Me.btnCollapsedAll, Me.btnExpandedAll, Me.btnSetCurrentFilial, Me.btnUpdate})
        Me.BarManager.MaxItemId = 12
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(663, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 589)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(663, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 589)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(663, 0)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 589)
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(572, 551)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnCancel.Size = New System.Drawing.Size(77, 26)
        Me.btnCancel.TabIndex = 46
        Me.btnCancel.Tag = "0"
        Me.btnCancel.Text = "Отмена"
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.ImageOptions.Image = CType(resources.GetObject("btnOk.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOk.ImageOptions.ImageIndex = 0
        Me.btnOk.Location = New System.Drawing.Point(489, 551)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnOk.Size = New System.Drawing.Size(77, 26)
        Me.btnOk.TabIndex = 45
        Me.btnOk.Tag = "11"
        Me.btnOk.Text = "OK"
        '
        'tmUpdateForm
        '
        Me.tmUpdateForm.Enabled = True
        Me.tmUpdateForm.Interval = 60000
        '
        'frOrganizationStructure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 589)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.tlStructure)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frOrganizationStructure"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Структура предприятия"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tlStructure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tlStructure As DevExpress.XtraTreeList.TreeList
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbAddressOrganization As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbPhoneOrganization As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbEmailOrganization As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbManagerOrganization As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnEditRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddMenu As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnAddFilial As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddGroup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddRoleJob As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCollapsedAll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExpandedAll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSetCurrentFilial As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUpdate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents tmUpdateForm As Timer
End Class
