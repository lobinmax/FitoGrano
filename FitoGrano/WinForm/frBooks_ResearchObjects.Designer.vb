<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frBooks_ResearchObjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frBooks_ResearchObjects))
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions4 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions5 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions6 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions7 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.lbServerName = New DevExpress.XtraBars.BarStaticItem()
        Me.lbDB_name = New DevExpress.XtraBars.BarStaticItem()
        Me.btnUpdate = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.btnAddObject = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditObject = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelObject = New DevExpress.XtraBars.BarButtonItem()
        Me.tmChecked = New System.Windows.Forms.Timer(Me.components)
        Me.gcnObjects = New DevExpress.XtraEditors.GroupControl()
        Me.gcObjects = New DevExpress.XtraGrid.GridControl()
        Me.gvObjects = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Accord = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.acRoot = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.pmObjects = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcnObjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcnObjects.SuspendLayout()
        CType(Me.gcObjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvObjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.pmObjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.AllowShowToolbarsPopup = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.lbServerName, Me.lbDB_name, Me.btnUpdate, Me.BarStaticItem1, Me.BarStaticItem2, Me.btnAddObject, Me.btnEditObject, Me.btnDelObject})
        Me.BarManager1.MaxItemId = 22
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Сервис"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Сервис"
        Me.Bar1.Visible = False
        '
        'Bar3
        '
        Me.Bar3.BarName = "Строка состояния"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.lbServerName), New DevExpress.XtraBars.LinkPersistInfo(Me.lbDB_name), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUpdate)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Строка состояния"
        '
        'lbServerName
        '
        Me.lbServerName.Caption = "Сервер"
        Me.lbServerName.Id = 0
        Me.lbServerName.ImageOptions.Image = CType(resources.GetObject("lbServerName.ImageOptions.Image"), System.Drawing.Image)
        Me.lbServerName.Name = "lbServerName"
        Me.lbServerName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'lbDB_name
        '
        Me.lbDB_name.Caption = "База данных"
        Me.lbDB_name.Id = 1
        Me.lbDB_name.ImageOptions.Image = CType(resources.GetObject("lbDB_name.ImageOptions.Image"), System.Drawing.Image)
        Me.lbDB_name.ImageOptions.LargeImage = CType(resources.GetObject("lbDB_name.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.lbDB_name.Name = "lbDB_name"
        Me.lbDB_name.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnUpdate
        '
        Me.btnUpdate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnUpdate.Caption = "Обновить данные"
        Me.btnUpdate.Id = 2
        Me.btnUpdate.ImageOptions.Image = CType(resources.GetObject("btnUpdate.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageOptions.LargeImage = CType(resources.GetObject("btnUpdate.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnUpdate.Name = "btnUpdate"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(825, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 413)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(825, 27)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 384)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(825, 29)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 384)
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Id = 17
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Id = 18
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'btnAddObject
        '
        Me.btnAddObject.Caption = "Добавить"
        Me.btnAddObject.Id = 19
        Me.btnAddObject.ImageOptions.Image = CType(resources.GetObject("btnAddObject.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddObject.Name = "btnAddObject"
        '
        'btnEditObject
        '
        Me.btnEditObject.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnEditObject.Caption = "Изменить          <i>Enter</i>"
        Me.btnEditObject.Id = 20
        Me.btnEditObject.ImageOptions.Image = CType(resources.GetObject("btnEditObject.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditObject.Name = "btnEditObject"
        '
        'btnDelObject
        '
        Me.btnDelObject.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnDelObject.Caption = "Удалить             <i>Delete</i>"
        Me.btnDelObject.Id = 21
        Me.btnDelObject.ImageOptions.Image = CType(resources.GetObject("btnDelObject.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelObject.Name = "btnDelObject"
        '
        'tmChecked
        '
        Me.tmChecked.Enabled = True
        '
        'gcnObjects
        '
        Me.gcnObjects.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.gcnObjects.Appearance.Options.UseFont = True
        Me.gcnObjects.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.gcnObjects.AppearanceCaption.Options.UseFont = True
        Me.gcnObjects.AppearanceCaption.Options.UseTextOptions = True
        Me.gcnObjects.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        Me.gcnObjects.Controls.Add(Me.gcObjects)
        ButtonImageOptions1.Image = CType(resources.GetObject("ButtonImageOptions1.Image"), System.Drawing.Image)
        ButtonImageOptions2.Image = CType(resources.GetObject("ButtonImageOptions2.Image"), System.Drawing.Image)
        ButtonImageOptions3.Image = CType(resources.GetObject("ButtonImageOptions3.Image"), System.Drawing.Image)
        ButtonImageOptions5.Image = CType(resources.GetObject("ButtonImageOptions5.Image"), System.Drawing.Image)
        ButtonImageOptions6.Image = CType(resources.GetObject("ButtonImageOptions6.Image"), System.Drawing.Image)
        ButtonImageOptions7.Image = CType(resources.GetObject("ButtonImageOptions7.Image"), System.Drawing.Image)
        Me.gcnObjects.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAddObject", False, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Добавить", -1, True, Nothing, True, False, True, Nothing, 2), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnEditObject", False, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Изменить", -1, True, Nothing, True, False, True, Nothing, 2), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnDeleteObject", False, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Удалаить", -1, True, Nothing, True, False, True, Nothing, 2), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("|", True, ButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, False, Nothing, True, False, True, Nothing, -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnSearch_Object", False, ButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать панель поиска", -1, True, Nothing, True, False, True, Nothing, 5), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAutoFilter_Object", False, ButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать строку автофильтра", -1, True, Nothing, True, False, True, Nothing, 6), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnClearSort_Object", False, ButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Очистить сортировку", -1, True, Nothing, True, False, True, Nothing, -1)})
        Me.gcnObjects.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.gcnObjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcnObjects.Location = New System.Drawing.Point(0, 0)
        Me.gcnObjects.Name = "gcnObjects"
        Me.gcnObjects.Size = New System.Drawing.Size(632, 376)
        Me.gcnObjects.TabIndex = 0
        Me.gcnObjects.Text = "Список объектов"
        '
        'gcObjects
        '
        Me.gcObjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcObjects.Location = New System.Drawing.Point(2, 29)
        Me.gcObjects.MainView = Me.gvObjects
        Me.gcObjects.Name = "gcObjects"
        Me.gcObjects.Size = New System.Drawing.Size(628, 345)
        Me.gcObjects.TabIndex = 0
        Me.gcObjects.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvObjects, Me.GridView1})
        '
        'gvObjects
        '
        Me.gvObjects.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvObjects.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvObjects.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        Me.gvObjects.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.gvObjects.Appearance.Preview.Options.UseFont = True
        Me.gvObjects.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvObjects.GridControl = Me.gcObjects
        Me.gvObjects.Name = "gvObjects"
        Me.gvObjects.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvObjects.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvObjects.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvObjects.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvObjects.OptionsBehavior.Editable = False
        Me.gvObjects.OptionsCustomization.AllowColumnMoving = False
        Me.gvObjects.OptionsCustomization.AllowGroup = False
        Me.gvObjects.OptionsDetail.EnableMasterViewMode = False
        Me.gvObjects.OptionsMenu.EnableColumnMenu = False
        Me.gvObjects.OptionsMenu.EnableFooterMenu = False
        Me.gvObjects.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvObjects.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvObjects.OptionsView.AllowHtmlDrawHeaders = True
        Me.gvObjects.OptionsView.AutoCalcPreviewLineCount = True
        Me.gvObjects.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvObjects.OptionsView.ShowGroupPanel = False
        Me.gvObjects.OptionsView.ShowPreview = True
        Me.gvObjects.PreviewIndent = 3
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gcObjects
        Me.GridView1.Name = "GridView1"
        '
        'Accord
        '
        Me.Accord.AllowItemSelection = True
        Me.Accord.AllowSmoothScrolling = False
        Me.Accord.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Spline
        Me.Accord.Appearance.Item.Pressed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Accord.Appearance.Item.Pressed.Options.UseFont = True
        Me.Accord.Cursor = System.Windows.Forms.Cursors.Default
        Me.Accord.DistanceBetweenRootGroups = 10
        Me.Accord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Accord.ElementPositionOnExpanding = DevExpress.XtraBars.Navigation.ElementPositionOnExpanding.Fixed
        Me.Accord.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.acRoot})
        Me.Accord.Location = New System.Drawing.Point(0, 0)
        Me.Accord.Name = "Accord"
        Me.Accord.ScaleImages = DevExpress.Utils.DefaultBoolean.[False]
        Me.Accord.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
        Me.Accord.Size = New System.Drawing.Size(176, 358)
        Me.Accord.TabIndex = 0
        '
        'acRoot
        '
        Me.acRoot.Expanded = True
        Me.acRoot.Height = -1
        Me.acRoot.Name = "acRoot"
        Me.acRoot.Text = "Root"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl1.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.SplitContainerControl1.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 29)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.SplitContainerControl1.Panel1.AppearanceCaption.Options.UseFont = True
        Me.SplitContainerControl1.Panel1.AppearanceCaption.Options.UseTextOptions = True
        Me.SplitContainerControl1.Panel1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SplitContainerControl1.Panel1.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        Me.SplitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Accord)
        Me.SplitContainerControl1.Panel1.MinSize = 30
        Me.SplitContainerControl1.Panel1.ShowCaption = True
        Me.SplitContainerControl1.Panel1.Text = "Виды объектов"
        Me.SplitContainerControl1.Panel2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.SplitContainerControl1.Panel2.AppearanceCaption.Options.UseFont = True
        Me.SplitContainerControl1.Panel2.AppearanceCaption.Options.UseTextOptions = True
        Me.SplitContainerControl1.Panel2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SplitContainerControl1.Panel2.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        Me.SplitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl1.Panel2.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.gcnObjects)
        Me.SplitContainerControl1.Panel2.Text = "Наименование"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(825, 384)
        Me.SplitContainerControl1.SplitterPosition = 180
        Me.SplitContainerControl1.TabIndex = 4
        '
        'pmObjects
        '
        Me.pmObjects.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddObject), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEditObject), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelObject)})
        Me.pmObjects.Manager = Me.BarManager1
        Me.pmObjects.Name = "pmObjects"
        '
        'frBooks_ResearchObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 440)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frBooks_ResearchObjects"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Объекты исследований"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcnObjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcnObjects.ResumeLayout(False)
        CType(Me.gcObjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvObjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.pmObjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents lbServerName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lbDB_name As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btnUpdate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents tmChecked As Timer
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Accord As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents acRoot As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents gcnObjects As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcObjects As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvObjects As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAddObject As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pmObjects As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnEditObject As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelObject As DevExpress.XtraBars.BarButtonItem
End Class
