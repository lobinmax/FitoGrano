<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frSecurityUsers
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
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frSecurityUsers))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.gcPerformers = New DevExpress.XtraGrid.GridControl()
        Me.gvPerformers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btnAddPerformer = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditPerformer = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelPerformer = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUpdate = New DevExpress.XtraBars.BarButtonItem()
        Me.barStatusBar = New DevExpress.XtraBars.Bar()
        Me.lbServerName = New DevExpress.XtraBars.BarStaticItem()
        Me.lbDB_name = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.btnSecurityUsers = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchControl1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.btnAddPerformer_pm = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditPerformer_pm = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelPerformer_pm = New DevExpress.XtraBars.BarButtonItem()
        Me.tlRightsPerformer = New DevExpress.XtraTreeList.TreeList()
        Me.gcPerformerInformation = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lbxPerfGroups = New DevExpress.XtraEditors.ListBoxControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRoleJob = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmail = New DevExpress.XtraEditors.ButtonEdit()
        Me.gcContacts = New DevExpress.XtraEditors.GroupControl()
        Me.lbxContacts = New DevExpress.XtraEditors.ListBoxControl()
        Me.txtAddress = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRoomNumber = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtSex = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtDtBirth = New DevExpress.XtraEditors.ButtonEdit()
        Me.tmChecked = New System.Windows.Forms.Timer(Me.components)
        Me.pmMenuPerformers = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.gcPerformers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPerformers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tlRightsPerformer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPerformerInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcPerformerInformation.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.lbxPerfGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoleJob.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcContacts.SuspendLayout()
        CType(Me.lbxContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoomNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSex.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDtBirth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pmMenuPerformers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FireScrollEventOnMouseWheel = True
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.AppearanceCaption.Options.UseTextOptions = True
        Me.SplitContainerControl1.Panel1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SplitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl1.Panel1.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.gcPerformers)
        Me.SplitContainerControl1.Panel1.ShowCaption = True
        Me.SplitContainerControl1.Panel1.Text = "Исполнители базы данных"
        Me.SplitContainerControl1.Panel2.AppearanceCaption.Options.UseTextOptions = True
        Me.SplitContainerControl1.Panel2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SplitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.tlRightsPerformer)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.gcPerformerInformation)
        Me.SplitContainerControl1.Panel2.ShowCaption = True
        Me.SplitContainerControl1.Panel2.Text = "Определение разрешений"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1251, 515)
        Me.SplitContainerControl1.SplitterPosition = 442
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'gcPerformers
        '
        Me.gcPerformers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPerformers.Location = New System.Drawing.Point(0, 0)
        Me.gcPerformers.MainView = Me.gvPerformers
        Me.gcPerformers.MenuManager = Me.BarManager
        Me.gcPerformers.Name = "gcPerformers"
        Me.gcPerformers.Size = New System.Drawing.Size(438, 489)
        Me.gcPerformers.TabIndex = 0
        Me.gcPerformers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPerformers})
        '
        'gvPerformers
        '
        Me.gvPerformers.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvPerformers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvPerformers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvPerformers.GridControl = Me.gcPerformers
        Me.gvPerformers.Name = "gvPerformers"
        Me.gvPerformers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvPerformers.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvPerformers.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvPerformers.OptionsBehavior.Editable = False
        Me.gvPerformers.OptionsCustomization.AllowColumnMoving = False
        Me.gvPerformers.OptionsCustomization.AllowGroup = False
        Me.gvPerformers.OptionsDetail.EnableMasterViewMode = False
        Me.gvPerformers.OptionsFilter.AllowFilterEditor = False
        Me.gvPerformers.OptionsMenu.EnableColumnMenu = False
        Me.gvPerformers.OptionsMenu.EnableFooterMenu = False
        Me.gvPerformers.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvPerformers.OptionsView.ShowGroupPanel = False
        Me.gvPerformers.OptionsView.ShowIndicator = False
        '
        'BarManager
        '
        Me.BarManager.AllowCustomization = False
        Me.BarManager.AllowMoveBarOnToolbar = False
        Me.BarManager.AllowQuickCustomization = False
        Me.BarManager.AllowShowToolbarsPopup = False
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.barStatusBar})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Images = Me.ImageCollection
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSecurityUsers, Me.BarStaticItem2, Me.btnAddPerformer, Me.btnEditPerformer, Me.btnDelPerformer, Me.btnUpdate, Me.lbServerName, Me.lbDB_name, Me.BarEditItem1, Me.btnAddPerformer_pm, Me.btnEditPerformer_pm, Me.btnDelPerformer_pm})
        Me.BarManager.MainMenu = Me.Bar2
        Me.BarManager.MaxItemId = 19
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl1})
        Me.BarManager.StatusBar = Me.barStatusBar
        '
        'Bar2
        '
        Me.Bar2.BarName = "Главное меню"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddPerformer), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEditPerformer), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelPerformer), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUpdate, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawBorder = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Главное меню"
        '
        'btnAddPerformer
        '
        Me.btnAddPerformer.Caption = "Добавить исполнителя"
        Me.btnAddPerformer.Id = 9
        Me.btnAddPerformer.ImageOptions.ImageIndex = 1
        Me.btnAddPerformer.Name = "btnAddPerformer"
        '
        'btnEditPerformer
        '
        Me.btnEditPerformer.Caption = "Редактировать исполнителя"
        Me.btnEditPerformer.Id = 10
        Me.btnEditPerformer.ImageOptions.ImageIndex = 2
        Me.btnEditPerformer.Name = "btnEditPerformer"
        '
        'btnDelPerformer
        '
        Me.btnDelPerformer.Caption = "Удалить исполнителя"
        Me.btnDelPerformer.Id = 11
        Me.btnDelPerformer.ImageOptions.ImageIndex = 0
        Me.btnDelPerformer.Name = "btnDelPerformer"
        '
        'btnUpdate
        '
        Me.btnUpdate.Caption = "Обновить форму"
        Me.btnUpdate.Id = 12
        Me.btnUpdate.ImageOptions.ImageIndex = 3
        Me.btnUpdate.Name = "btnUpdate"
        '
        'barStatusBar
        '
        Me.barStatusBar.BarName = "Строка состояния"
        Me.barStatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.barStatusBar.DockCol = 0
        Me.barStatusBar.DockRow = 0
        Me.barStatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.barStatusBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.lbServerName), New DevExpress.XtraBars.LinkPersistInfo(Me.lbDB_name)})
        Me.barStatusBar.OptionsBar.AllowQuickCustomization = False
        Me.barStatusBar.OptionsBar.DrawBorder = False
        Me.barStatusBar.OptionsBar.DrawDragBorder = False
        Me.barStatusBar.OptionsBar.DrawSizeGrip = True
        Me.barStatusBar.OptionsBar.UseWholeRow = True
        Me.barStatusBar.Text = "Строка состояния"
        '
        'lbServerName
        '
        Me.lbServerName.Caption = "Сервер"
        Me.lbServerName.Id = 13
        Me.lbServerName.ImageOptions.ImageIndex = 4
        Me.lbServerName.Name = "lbServerName"
        Me.lbServerName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'lbDB_name
        '
        Me.lbDB_name.Caption = "База данных"
        Me.lbDB_name.Id = 14
        Me.lbDB_name.ImageOptions.ImageIndex = 5
        Me.lbDB_name.Name = "lbDB_name"
        Me.lbDB_name.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(1251, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 539)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(1251, 27)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 515)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1251, 24)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 515)
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection.Images.SetKeyName(0, "DelUser_16x16.png")
        Me.ImageCollection.Images.SetKeyName(1, "AddUser_16x16.png")
        Me.ImageCollection.Images.SetKeyName(2, "EditUser_16x16.png")
        Me.ImageCollection.InsertGalleryImage("recurrence_16x16.png", "office2013/scheduling/recurrence_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/scheduling/recurrence_16x16.png"), 3)
        Me.ImageCollection.Images.SetKeyName(3, "recurrence_16x16.png")
        Me.ImageCollection.Images.SetKeyName(4, "IP_16x16.png")
        Me.ImageCollection.InsertGalleryImage("database_16x16.png", "images/data/database_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/database_16x16.png"), 5)
        Me.ImageCollection.Images.SetKeyName(5, "database_16x16.png")
        '
        'btnSecurityUsers
        '
        Me.btnSecurityUsers.Caption = "Исполнители и безопасность"
        Me.btnSecurityUsers.Id = 1
        Me.btnSecurityUsers.ImageOptions.ImageIndex = 5
        Me.btnSecurityUsers.Name = "btnSecurityUsers"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "BarStaticItem2"
        Me.BarStaticItem2.Id = 8
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemSearchControl1
        Me.BarEditItem1.Id = 15
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemSearchControl1
        '
        Me.RepositoryItemSearchControl1.AutoHeight = False
        Me.RepositoryItemSearchControl1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl1.Name = "RepositoryItemSearchControl1"
        '
        'btnAddPerformer_pm
        '
        Me.btnAddPerformer_pm.Caption = "Добавить"
        Me.btnAddPerformer_pm.Id = 16
        Me.btnAddPerformer_pm.ImageOptions.Image = CType(resources.GetObject("btnAddPerformer_pm.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddPerformer_pm.Name = "btnAddPerformer_pm"
        '
        'btnEditPerformer_pm
        '
        Me.btnEditPerformer_pm.Caption = "Изменить"
        Me.btnEditPerformer_pm.Id = 17
        Me.btnEditPerformer_pm.ImageOptions.Image = CType(resources.GetObject("btnEditPerformer_pm.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditPerformer_pm.Name = "btnEditPerformer_pm"
        '
        'btnDelPerformer_pm
        '
        Me.btnDelPerformer_pm.Caption = "Удалить"
        Me.btnDelPerformer_pm.Id = 18
        Me.btnDelPerformer_pm.ImageOptions.Image = CType(resources.GetObject("btnDelPerformer_pm.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelPerformer_pm.Name = "btnDelPerformer_pm"
        '
        'tlRightsPerformer
        '
        Me.tlRightsPerformer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tlRightsPerformer.Caption = "Права сотрудника"
        Me.tlRightsPerformer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlRightsPerformer.Location = New System.Drawing.Point(0, 193)
        Me.tlRightsPerformer.Name = "tlRightsPerformer"
        Me.tlRightsPerformer.OptionsView.ShowCaption = True
        Me.tlRightsPerformer.Size = New System.Drawing.Size(796, 296)
        Me.tlRightsPerformer.TabIndex = 1
        '
        'gcPerformerInformation
        '
        Me.gcPerformerInformation.AllowHtmlText = True
        Me.gcPerformerInformation.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.gcPerformerInformation.CaptionImageOptions.Image = CType(resources.GetObject("gcPerformerInformation.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.gcPerformerInformation.Controls.Add(Me.GroupControl1)
        Me.gcPerformerInformation.Controls.Add(Me.LabelControl2)
        Me.gcPerformerInformation.Controls.Add(Me.txtRoleJob)
        Me.gcPerformerInformation.Controls.Add(Me.LabelControl5)
        Me.gcPerformerInformation.Controls.Add(Me.txtEmail)
        Me.gcPerformerInformation.Controls.Add(Me.gcContacts)
        Me.gcPerformerInformation.Controls.Add(Me.txtAddress)
        Me.gcPerformerInformation.Controls.Add(Me.LabelControl7)
        Me.gcPerformerInformation.Controls.Add(Me.LabelControl4)
        Me.gcPerformerInformation.Controls.Add(Me.LabelControl3)
        Me.gcPerformerInformation.Controls.Add(Me.LabelControl1)
        Me.gcPerformerInformation.Controls.Add(Me.txtRoomNumber)
        Me.gcPerformerInformation.Controls.Add(Me.txtSex)
        Me.gcPerformerInformation.Controls.Add(Me.txtDtBirth)
        ButtonImageOptions1.Image = CType(resources.GetObject("ButtonImageOptions1.Image"), System.Drawing.Image)
        ButtonImageOptions2.Image = CType(resources.GetObject("ButtonImageOptions2.Image"), System.Drawing.Image)
        ToolTipItem1.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipItem1.Appearance.Options.UseImage = True
        ToolTipItem1.ImageOptions.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ToolTipItem1.Text = "Свернуть / Развернуть"
        ToolTipTitleItem1.Text = "Подсказка ..."
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.gcPerformerInformation.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", False, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Статистика подключений к базе данных", -1, True, Nothing, True, False, True, Nothing, 0), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", False, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, SuperToolTip1, True, False, True, "0", 2)})
        Me.gcPerformerInformation.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.gcPerformerInformation.Dock = System.Windows.Forms.DockStyle.Top
        Me.gcPerformerInformation.Location = New System.Drawing.Point(0, 0)
        Me.gcPerformerInformation.Name = "gcPerformerInformation"
        Me.gcPerformerInformation.Size = New System.Drawing.Size(796, 193)
        Me.gcPerformerInformation.TabIndex = 0
        Me.gcPerformerInformation.Text = " Информация о сотруднике"
        '
        'GroupControl1
        '
        Me.GroupControl1.AllowHtmlText = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl1.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.lbxPerfGroups)
        Me.GroupControl1.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl1.Location = New System.Drawing.Point(585, 39)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(209, 143)
        Me.GroupControl1.TabIndex = 50
        Me.GroupControl1.Text = "Группы пользователя:</u>"
        '
        'lbxPerfGroups
        '
        Me.lbxPerfGroups.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbxPerfGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxPerfGroups.HotTrackItems = True
        Me.lbxPerfGroups.ItemAutoHeight = True
        Me.lbxPerfGroups.ItemHeight = 16
        Me.lbxPerfGroups.Location = New System.Drawing.Point(2, 23)
        Me.lbxPerfGroups.Name = "lbxPerfGroups"
        Me.lbxPerfGroups.ShowFocusRect = False
        Me.lbxPerfGroups.Size = New System.Drawing.Size(205, 118)
        Me.lbxPerfGroups.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.lbxPerfGroups.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.AllowHtmlString = True
        Me.LabelControl2.Location = New System.Drawing.Point(233, 137)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl2.TabIndex = 44
        Me.LabelControl2.Text = "<u>Email:</u>"
        '
        'txtRoleJob
        '
        Me.txtRoleJob.Location = New System.Drawing.Point(72, 162)
        Me.txtRoleJob.MenuManager = Me.BarManager
        Me.txtRoleJob.Name = "txtRoleJob"
        Me.txtRoleJob.Properties.AllowFocused = False
        Me.txtRoleJob.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtRoleJob.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtRoleJob.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtRoleJob.Size = New System.Drawing.Size(507, 20)
        Me.txtRoleJob.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.AllowHtmlString = True
        Me.LabelControl5.Location = New System.Drawing.Point(5, 163)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "<u>Должность:</u>"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(325, 136)
        Me.txtEmail.MenuManager = Me.BarManager
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.AllowFocused = False
        Me.txtEmail.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtEmail.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtEmail.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtEmail.Size = New System.Drawing.Size(254, 20)
        Me.txtEmail.TabIndex = 45
        '
        'gcContacts
        '
        Me.gcContacts.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.gcContacts.CaptionImageOptions.Image = CType(resources.GetObject("gcContacts.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.gcContacts.Controls.Add(Me.lbxContacts)
        Me.gcContacts.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.gcContacts.Location = New System.Drawing.Point(5, 39)
        Me.gcContacts.Name = "gcContacts"
        Me.gcContacts.Size = New System.Drawing.Size(222, 117)
        Me.gcContacts.TabIndex = 43
        Me.gcContacts.Text = " Контакты пользователя"
        '
        'lbxContacts
        '
        Me.lbxContacts.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.lbxContacts.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.lbxContacts.ContextButtonOptions.AllowHtmlText = True
        Me.lbxContacts.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbxContacts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxContacts.HotTrackItems = True
        Me.lbxContacts.ItemAutoHeight = True
        Me.lbxContacts.ItemHeight = 16
        Me.lbxContacts.Location = New System.Drawing.Point(2, 23)
        Me.lbxContacts.Name = "lbxContacts"
        Me.lbxContacts.ShowFocusRect = False
        Me.lbxContacts.ShowToolTipForTrimmedText = DevExpress.Utils.DefaultBoolean.[True]
        Me.lbxContacts.Size = New System.Drawing.Size(218, 92)
        Me.lbxContacts.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.lbxContacts.TabIndex = 12
        Me.lbxContacts.Tag = "0"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(233, 54)
        Me.txtAddress.MenuManager = Me.BarManager
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.AllowFocused = False
        Me.txtAddress.Properties.AutoHeight = False
        Me.txtAddress.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtAddress.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtAddress.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtAddress.Size = New System.Drawing.Size(346, 20)
        Me.txtAddress.TabIndex = 0
        '
        'LabelControl7
        '
        Me.LabelControl7.AllowHtmlString = True
        Me.LabelControl7.Location = New System.Drawing.Point(233, 111)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl7.TabIndex = 13
        Me.LabelControl7.Text = "<u>Пол сотрудника:</u>"
        '
        'LabelControl4
        '
        Me.LabelControl4.AllowHtmlString = True
        Me.LabelControl4.Location = New System.Drawing.Point(426, 85)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "<u>Кабинет:</u>"
        '
        'LabelControl3
        '
        Me.LabelControl3.AllowHtmlString = True
        Me.LabelControl3.Location = New System.Drawing.Point(233, 85)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "<u>Дата рождения:</u>"
        '
        'LabelControl1
        '
        Me.LabelControl1.AllowHtmlString = True
        Me.LabelControl1.Location = New System.Drawing.Point(233, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "<u>Домашний адрес:</u>"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.EditValue = ""
        Me.txtRoomNumber.Location = New System.Drawing.Point(479, 84)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Properties.AllowFocused = False
        Me.txtRoomNumber.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtRoomNumber.Properties.AutoHeight = False
        Me.txtRoomNumber.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtRoomNumber.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtRoomNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtRoomNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomNumber.TabIndex = 7
        '
        'txtSex
        '
        Me.txtSex.EditValue = ""
        Me.txtSex.Location = New System.Drawing.Point(325, 110)
        Me.txtSex.MenuManager = Me.BarManager
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Properties.AllowFocused = False
        Me.txtSex.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtSex.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtSex.Size = New System.Drawing.Size(132, 20)
        Me.txtSex.TabIndex = 14
        '
        'txtDtBirth
        '
        Me.txtDtBirth.Location = New System.Drawing.Point(325, 84)
        Me.txtDtBirth.Name = "txtDtBirth"
        Me.txtDtBirth.Properties.AllowFocused = False
        Me.txtDtBirth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDtBirth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDtBirth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtDtBirth.Size = New System.Drawing.Size(92, 20)
        Me.txtDtBirth.TabIndex = 5
        '
        'tmChecked
        '
        Me.tmChecked.Enabled = True
        '
        'pmMenuPerformers
        '
        Me.pmMenuPerformers.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddPerformer_pm), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEditPerformer_pm), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelPerformer_pm)})
        Me.pmMenuPerformers.Manager = Me.BarManager
        Me.pmMenuPerformers.Name = "pmMenuPerformers"
        '
        'frSecurityUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 566)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1267, 604)
        Me.Name = "frSecurityUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Испонители и безопасность"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.gcPerformers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPerformers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tlRightsPerformer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPerformerInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcPerformerInformation.ResumeLayout(False)
        Me.gcPerformerInformation.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.lbxPerfGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoleJob.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcContacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcContacts.ResumeLayout(False)
        CType(Me.lbxContacts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoomNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSex.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDtBirth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pmMenuPerformers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barStatusBar As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnSecurityUsers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btnAddPerformer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents btnEditPerformer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelPerformer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUpdate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gcPerformers As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPerformers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tlRightsPerformer As DevExpress.XtraTreeList.TreeList
    Friend WithEvents gcPerformerInformation As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbServerName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lbDB_name As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAddress As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtRoomNumber As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents gcContacts As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbxContacts As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents txtSex As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtRoleJob As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtDtBirth As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents tmChecked As Timer
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmail As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbxPerfGroups As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents btnAddPerformer_pm As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditPerformer_pm As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelPerformer_pm As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pmMenuPerformers As DevExpress.XtraBars.PopupMenu
End Class
