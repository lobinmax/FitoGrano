<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frMain
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frMain))
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarLinkContainerItem1 = New DevExpress.XtraBars.BarLinkContainerItem()
        Me.btnClassificationProducts = New DevExpress.XtraBars.BarButtonItem()
        Me.btnResearchDirection = New DevExpress.XtraBars.BarButtonItem()
        Me.btnResearchObjects = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOrganizationStructure = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCountryAgreements = New DevExpress.XtraBars.BarButtonItem()
        Me.btnServises = New DevExpress.XtraBars.BarLinkContainerItem()
        Me.btnSecurityUsers = New DevExpress.XtraBars.BarButtonItem()
        Me.btnChangeSkin = New DevExpress.XtraBars.SkinBarSubItem()
        Me.barStatusBar = New DevExpress.XtraBars.Bar()
        Me.lbDivisionName = New DevExpress.XtraBars.BarStaticItem()
        Me.lbServerName = New DevExpress.XtraBars.BarStaticItem()
        Me.lbDataBaseName = New DevExpress.XtraBars.BarStaticItem()
        Me.lbUserName = New DevExpress.XtraBars.BarStaticItem()
        Me.lbDateTime = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinBarSubItem1 = New DevExpress.XtraBars.SkinBarSubItem()
        Me.BarToolbarsListItem1 = New DevExpress.XtraBars.BarToolbarsListItem()
        Me.SkinBarSubItem2 = New DevExpress.XtraBars.SkinBarSubItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ptbFone = New DevExpress.XtraEditors.PictureEdit()
        Me.ptbGerb = New DevExpress.XtraEditors.PictureEdit()
        Me.tmrDateTime = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbFone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbGerb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnServises, Me.btnSecurityUsers, Me.BarLinkContainerItem1, Me.lbDivisionName, Me.lbDataBaseName, Me.lbServerName, Me.lbUserName, Me.lbDateTime, Me.BarStaticItem2, Me.btnOrganizationStructure, Me.BarButtonItem1, Me.BarButtonItem2, Me.SkinBarSubItem1, Me.BarToolbarsListItem1, Me.SkinBarSubItem2, Me.BarEditItem1, Me.btnChangeSkin, Me.btnClassificationProducts, Me.btnResearchDirection, Me.btnResearchObjects, Me.btnCountryAgreements})
        Me.BarManager.MainMenu = Me.Bar2
        Me.BarManager.MaxItemId = 21
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.BarManager.StatusBar = Me.barStatusBar
        '
        'Bar2
        '
        Me.Bar2.BarName = "Главное меню"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarLinkContainerItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.btnServises)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawBorder = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Главное меню"
        '
        'BarLinkContainerItem1
        '
        Me.BarLinkContainerItem1.Caption = "Справочники"
        Me.BarLinkContainerItem1.Id = 2
        Me.BarLinkContainerItem1.ImageOptions.Image = CType(resources.GetObject("BarLinkContainerItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarLinkContainerItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnClassificationProducts), New DevExpress.XtraBars.LinkPersistInfo(Me.btnResearchDirection), New DevExpress.XtraBars.LinkPersistInfo(Me.btnResearchObjects), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCountryAgreements), New DevExpress.XtraBars.LinkPersistInfo(Me.btnOrganizationStructure)})
        Me.BarLinkContainerItem1.Name = "BarLinkContainerItem1"
        Me.BarLinkContainerItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnClassificationProducts
        '
        Me.btnClassificationProducts.Caption = "Классификация продукции"
        Me.btnClassificationProducts.Id = 17
        Me.btnClassificationProducts.ImageOptions.Image = CType(resources.GetObject("btnClassificationProducts.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClassificationProducts.Name = "btnClassificationProducts"
        '
        'btnResearchDirection
        '
        Me.btnResearchDirection.Caption = "Направление исследований"
        Me.btnResearchDirection.Id = 18
        Me.btnResearchDirection.ImageOptions.Image = CType(resources.GetObject("btnResearchDirection.ImageOptions.Image"), System.Drawing.Image)
        Me.btnResearchDirection.Name = "btnResearchDirection"
        '
        'btnResearchObjects
        '
        Me.btnResearchObjects.Caption = "Объекты исследований"
        Me.btnResearchObjects.Id = 19
        Me.btnResearchObjects.ImageOptions.Image = CType(resources.GetObject("btnResearchObjects.ImageOptions.Image"), System.Drawing.Image)
        Me.btnResearchObjects.Name = "btnResearchObjects"
        '
        'btnOrganizationStructure
        '
        Me.btnOrganizationStructure.Caption = "Структура учреждения"
        Me.btnOrganizationStructure.Id = 9
        Me.btnOrganizationStructure.ImageOptions.ImageIndex = 7
        Me.btnOrganizationStructure.Name = "btnOrganizationStructure"
        '
        'btnCountryAgreements
        '
        Me.btnCountryAgreements.Caption = "Страны и соглашения"
        Me.btnCountryAgreements.Id = 20
        Me.btnCountryAgreements.ImageOptions.Image = CType(resources.GetObject("btnCountryAgreements.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCountryAgreements.Name = "btnCountryAgreements"
        '
        'btnServises
        '
        Me.btnServises.Caption = "Сервис"
        Me.btnServises.Id = 0
        Me.btnServises.ImageOptions.ImageIndex = 6
        Me.btnServises.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSecurityUsers), New DevExpress.XtraBars.LinkPersistInfo(Me.btnChangeSkin)})
        Me.btnServises.Name = "btnServises"
        Me.btnServises.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnSecurityUsers
        '
        Me.btnSecurityUsers.Caption = "Исполнители и безопасность"
        Me.btnSecurityUsers.Id = 1
        Me.btnSecurityUsers.ImageOptions.ImageIndex = 5
        Me.btnSecurityUsers.Name = "btnSecurityUsers"
        '
        'btnChangeSkin
        '
        Me.btnChangeSkin.Caption = "Сменить оформление"
        Me.btnChangeSkin.Id = 16
        Me.btnChangeSkin.ImageOptions.Image = CType(resources.GetObject("btnChangeSkin.ImageOptions.Image"), System.Drawing.Image)
        Me.btnChangeSkin.Name = "btnChangeSkin"
        '
        'barStatusBar
        '
        Me.barStatusBar.BarName = "Строка состояния"
        Me.barStatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.barStatusBar.DockCol = 0
        Me.barStatusBar.DockRow = 0
        Me.barStatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.barStatusBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.lbDivisionName), New DevExpress.XtraBars.LinkPersistInfo(Me.lbServerName), New DevExpress.XtraBars.LinkPersistInfo(Me.lbDataBaseName), New DevExpress.XtraBars.LinkPersistInfo(Me.lbUserName), New DevExpress.XtraBars.LinkPersistInfo(Me.lbDateTime)})
        Me.barStatusBar.OptionsBar.AllowQuickCustomization = False
        Me.barStatusBar.OptionsBar.DrawBorder = False
        Me.barStatusBar.OptionsBar.DrawDragBorder = False
        Me.barStatusBar.OptionsBar.UseWholeRow = True
        Me.barStatusBar.Text = "Строка состояния"
        '
        'lbDivisionName
        '
        Me.lbDivisionName.Caption = "Новороссийский филиал"
        Me.lbDivisionName.Id = 3
        Me.lbDivisionName.ImageOptions.ImageIndex = 0
        Me.lbDivisionName.Name = "lbDivisionName"
        Me.lbDivisionName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'lbServerName
        '
        Me.lbServerName.Caption = "LOBIN_MAX"
        Me.lbServerName.Id = 5
        Me.lbServerName.ImageOptions.ImageIndex = 2
        Me.lbServerName.Name = "lbServerName"
        Me.lbServerName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'lbDataBaseName
        '
        Me.lbDataBaseName.Caption = "fgNovorossiysk"
        Me.lbDataBaseName.Id = 4
        Me.lbDataBaseName.ImageOptions.ImageIndex = 1
        Me.lbDataBaseName.Name = "lbDataBaseName"
        Me.lbDataBaseName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'lbUserName
        '
        Me.lbUserName.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
        Me.lbUserName.Caption = "Лобин М.А."
        Me.lbUserName.Id = 6
        Me.lbUserName.ImageOptions.ImageIndex = 3
        Me.lbUserName.Name = "lbUserName"
        Me.lbUserName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'lbDateTime
        '
        Me.lbDateTime.Caption = "01.01.2019 15:15:00"
        Me.lbDateTime.Id = 7
        Me.lbDateTime.ImageOptions.ImageIndex = 4
        Me.lbDateTime.Name = "lbDateTime"
        Me.lbDateTime.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(742, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 478)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(742, 27)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 454)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(742, 24)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 454)
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection.Images.SetKeyName(0, "capofgrane.png")
        Me.ImageCollection.InsertGalleryImage("database_16x16.png", "images/data/database_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/database_16x16.png"), 1)
        Me.ImageCollection.Images.SetKeyName(1, "database_16x16.png")
        Me.ImageCollection.Images.SetKeyName(2, "IP_16x16.png")
        Me.ImageCollection.InsertGalleryImage("user_16x16.png", "images/people/user_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/user_16x16.png"), 3)
        Me.ImageCollection.Images.SetKeyName(3, "user_16x16.png")
        Me.ImageCollection.InsertGalleryImage("showworktimeonly_16x16.png", "office2013/scheduling/showworktimeonly_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/scheduling/showworktimeonly_16x16.png"), 4)
        Me.ImageCollection.Images.SetKeyName(4, "showworktimeonly_16x16.png")
        Me.ImageCollection.InsertGalleryImage("editrangepermission_16x16.png", "images/richedit/editrangepermission_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/richedit/editrangepermission_16x16.png"), 5)
        Me.ImageCollection.Images.SetKeyName(5, "editrangepermission_16x16.png")
        Me.ImageCollection.InsertGalleryImage("viewsetting_16x16.png", "devav/actions/viewsetting_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/viewsetting_16x16.png"), 6)
        Me.ImageCollection.Images.SetKeyName(6, "viewsetting_16x16.png")
        Me.ImageCollection.Images.SetKeyName(7, "company.png")
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "BarStaticItem2"
        Me.BarStaticItem2.Id = 8
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 10
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 11
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'SkinBarSubItem1
        '
        Me.SkinBarSubItem1.Caption = "SkinBarSubItem1"
        Me.SkinBarSubItem1.Id = 12
        Me.SkinBarSubItem1.Name = "SkinBarSubItem1"
        '
        'BarToolbarsListItem1
        '
        Me.BarToolbarsListItem1.Caption = "BarToolbarsListItem1"
        Me.BarToolbarsListItem1.Id = 13
        Me.BarToolbarsListItem1.Name = "BarToolbarsListItem1"
        '
        'SkinBarSubItem2
        '
        Me.SkinBarSubItem2.Caption = "SkinBarSubItem2"
        Me.SkinBarSubItem2.Id = 14
        Me.SkinBarSubItem2.Name = "SkinBarSubItem2"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit1
        Me.BarEditItem1.Id = 15
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'ptbFone
        '
        Me.ptbFone.Cursor = System.Windows.Forms.Cursors.Default
        Me.ptbFone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ptbFone.EditValue = CType(resources.GetObject("ptbFone.EditValue"), Object)
        Me.ptbFone.Location = New System.Drawing.Point(0, 24)
        Me.ptbFone.MenuManager = Me.BarManager
        Me.ptbFone.Name = "ptbFone"
        Me.ptbFone.Properties.AllowFocused = False
        Me.ptbFone.Properties.ReadOnly = True
        Me.ptbFone.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.ptbFone.Properties.ShowMenu = False
        Me.ptbFone.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.ptbFone.Size = New System.Drawing.Size(742, 454)
        Me.ptbFone.TabIndex = 4
        '
        'ptbGerb
        '
        Me.ptbGerb.Cursor = System.Windows.Forms.Cursors.Default
        Me.ptbGerb.EditValue = CType(resources.GetObject("ptbGerb.EditValue"), Object)
        Me.ptbGerb.Location = New System.Drawing.Point(600, 12)
        Me.ptbGerb.MenuManager = Me.BarManager
        Me.ptbGerb.Name = "ptbGerb"
        Me.ptbGerb.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ptbGerb.Properties.Appearance.Options.UseBackColor = True
        Me.ptbGerb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ptbGerb.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.ptbGerb.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.ptbGerb.Size = New System.Drawing.Size(130, 130)
        Me.ptbGerb.TabIndex = 9
        '
        'tmrDateTime
        '
        Me.tmrDateTime.Enabled = True
        '
        'frMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 505)
        Me.Controls.Add(Me.ptbGerb)
        Me.Controls.Add(Me.ptbFone)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frMain"
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbFone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbGerb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barStatusBar As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ptbFone As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnServises As DevExpress.XtraBars.BarLinkContainerItem
    Friend WithEvents btnSecurityUsers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarLinkContainerItem1 As DevExpress.XtraBars.BarLinkContainerItem
    Friend WithEvents ptbGerb As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lbDivisionName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents lbDataBaseName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lbServerName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lbUserName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lbDateTime As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents tmrDateTime As System.Windows.Forms.Timer
    Friend WithEvents btnOrganizationStructure As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SkinBarSubItem1 As DevExpress.XtraBars.SkinBarSubItem
    Friend WithEvents btnChangeSkin As DevExpress.XtraBars.SkinBarSubItem
    Friend WithEvents BarToolbarsListItem1 As DevExpress.XtraBars.BarToolbarsListItem
    Friend WithEvents SkinBarSubItem2 As DevExpress.XtraBars.SkinBarSubItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnClassificationProducts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnResearchDirection As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnResearchObjects As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCountryAgreements As DevExpress.XtraBars.BarButtonItem
End Class
