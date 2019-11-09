Partial Public Class frLogin
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frLogin))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.ChB_ShowPass = New DevExpress.XtraEditors.CheckEdit()
        Me.FormIsShort = New DevExpress.XtraEditors.SimpleButton()
        Me.Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ok = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Pass = New DevExpress.XtraEditors.TextEdit()
        Me.User = New DevExpress.XtraEditors.MRUEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.BD = New DevExpress.XtraEditors.MRUEdit()
        Me.Server = New DevExpress.XtraEditors.MRUEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.ChB_ShowPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Server.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChB_ShowPass
        '
        Me.ChB_ShowPass.Location = New System.Drawing.Point(255, 110)
        Me.ChB_ShowPass.Name = "ChB_ShowPass"
        Me.ChB_ShowPass.Properties.Caption = "Показать пароль"
        Me.ChB_ShowPass.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ChB_ShowPass.Size = New System.Drawing.Size(226, 19)
        Me.ChB_ShowPass.TabIndex = 25
        '
        'FormIsShort
        '
        Me.FormIsShort.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.FormIsShort.Appearance.Options.UseForeColor = True
        Me.FormIsShort.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.FormIsShort.ImageOptions.Image = CType(resources.GetObject("FormIsShort.ImageOptions.Image"), System.Drawing.Image)
        Me.FormIsShort.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.FormIsShort.Location = New System.Drawing.Point(462, 175)
        Me.FormIsShort.Name = "FormIsShort"
        Me.FormIsShort.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.FormIsShort.Size = New System.Drawing.Size(20, 20)
        Me.FormIsShort.TabIndex = 32
        Me.FormIsShort.ToolTip = "Параметры подключения"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(373, 135)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.Cancel.Size = New System.Drawing.Size(109, 23)
        Me.Cancel.TabIndex = 31
        Me.Cancel.Text = "Отмена"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseImageAlign = True
        Me.LabelControl1.Location = New System.Drawing.Point(256, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl1.TabIndex = 29
        Me.LabelControl1.Text = "Имя пользователя"
        '
        'ok
        '
        Me.ok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ok.Location = New System.Drawing.Point(256, 135)
        Me.ok.Name = "ok"
        Me.ok.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.ok.Size = New System.Drawing.Size(109, 23)
        Me.ok.TabIndex = 28
        Me.ok.Text = "Войти"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.LabelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseImageAlign = True
        Me.LabelControl2.Location = New System.Drawing.Point(256, 69)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 30
        Me.LabelControl2.Text = "Пароль"
        '
        'Pass
        '
        Me.Pass.EditValue = "123123"
        Me.Pass.Location = New System.Drawing.Point(256, 84)
        Me.Pass.Name = "Pass"
        Me.Pass.Properties.ContextImageOptions.Image = CType(resources.GetObject("Pass.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.Pass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Pass.Size = New System.Drawing.Size(226, 20)
        Me.Pass.TabIndex = 27
        '
        'User
        '
        Me.User.EnterMoveNextControl = True
        Me.User.Location = New System.Drawing.Point(256, 36)
        Me.User.Name = "User"
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.User.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Очистить историю логинов", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.User.Properties.ContextImageOptions.Image = CType(resources.GetObject("User.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.User.Properties.DropDownRows = 4
        Me.User.Properties.ImmediatePopup = False
        Me.User.Properties.PopupSizeable = True
        Me.User.Properties.ValidateOnEnterKey = False
        Me.User.Size = New System.Drawing.Size(226, 22)
        Me.User.TabIndex = 26
        Me.User.Tag = ""
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseImageAlign = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl3.LineVisible = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 174)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(444, 22)
        Me.LabelControl3.TabIndex = 33
        Me.LabelControl3.Text = "Параметры подключения к серверу"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.LabelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseImageAlign = True
        Me.LabelControl4.Location = New System.Drawing.Point(256, 204)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl4.TabIndex = 37
        Me.LabelControl4.Text = "База данных:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.LabelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseImageAlign = True
        Me.LabelControl5.Location = New System.Drawing.Point(15, 205)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl5.TabIndex = 35
        Me.LabelControl5.Text = "SQL - Сервер:"
        '
        'BD
        '
        Me.BD.Location = New System.Drawing.Point(256, 219)
        Me.BD.Name = "BD"
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.BD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "Очистить историю баз данных", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.BD.Properties.ContextImageOptions.Image = CType(resources.GetObject("BD.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.BD.Properties.ImmediatePopup = False
        Me.BD.Properties.PopupFormMinSize = New System.Drawing.Size(210, 0)
        Me.BD.Properties.PopupSizeable = True
        Me.BD.Properties.ValidateOnEnterKey = False
        Me.BD.Size = New System.Drawing.Size(226, 22)
        Me.BD.TabIndex = 36
        '
        'Server
        '
        Me.Server.Location = New System.Drawing.Point(12, 219)
        Me.Server.Name = "Server"
        EditorButtonImageOptions3.Image = CType(resources.GetObject("EditorButtonImageOptions3.Image"), System.Drawing.Image)
        Me.Server.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "Очистить историю имен серверов", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.Server.Properties.ContextImageOptions.Image = CType(resources.GetObject("Server.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.Server.Properties.ImmediatePopup = False
        Me.Server.Properties.PopupFormMinSize = New System.Drawing.Size(210, 0)
        Me.Server.Properties.PopupSizeable = True
        Me.Server.Properties.ValidateOnEnterKey = False
        Me.Server.Size = New System.Drawing.Size(222, 22)
        SuperToolTip1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipItem1.Text = "IP адрес сервера в формате" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<u><b>ХХХ.ХХХ.ХХХ.ХХХ</b></u>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Например: 10.60.161.10" &
    "5"
        ToolTipTitleItem1.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipTitleItem1.Appearance.Options.UseImage = True
        ToolTipTitleItem1.ImageOptions.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ToolTipTitleItem1.Text = "Подсказка"
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.Server.SuperTip = SuperToolTip1
        Me.Server.TabIndex = 34
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.AllowFocused = False
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(224, 153)
        Me.PictureEdit1.TabIndex = 24
        '
        'frLogin
        '
        Me.AcceptButton = Me.ok
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(493, 253)
        Me.Controls.Add(Me.BD)
        Me.Controls.Add(Me.Server)
        Me.Controls.Add(Me.ChB_ShowPass)
        Me.Controls.Add(Me.FormIsShort)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl3)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Добро пожаловать в FitoGrano"
        CType(Me.ChB_ShowPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Server.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents ChB_ShowPass As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FormIsShort As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ok As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Pass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents User As DevExpress.XtraEditors.MRUEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BD As DevExpress.XtraEditors.MRUEdit
    Friend WithEvents Server As DevExpress.XtraEditors.MRUEdit

#End Region

End Class
