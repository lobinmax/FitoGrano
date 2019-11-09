<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frAddEditObjects
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frAddEditObjects))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim UserControlProp1 As FitoGrano.ucTreeListResearchMetods.UserControlProp = New FitoGrano.ucTreeListResearchMetods.UserControlProp()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtObjectNameRU = New DevExpress.XtraEditors.ButtonEdit()
        Me.lbNameForm = New DevExpress.XtraEditors.LabelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtObjectNameLAT = New DevExpress.XtraEditors.ButtonEdit()
        Me.lbGrip = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.tlResearchMetods = New FitoGrano.ucTreeListResearchMetods()
        CType(Me.txtObjectNameRU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObjectNameLAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl13
        '
        Me.LabelControl13.AllowHtmlString = True
        Me.LabelControl13.Location = New System.Drawing.Point(12, 54)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(163, 13)
        Me.LabelControl13.TabIndex = 0
        Me.LabelControl13.Tag = "0"
        Me.LabelControl13.Text = "<color=red>*</color><u> Наименование объкта (русс.):</u>"
        '
        'txtObjectNameRU
        '
        Me.txtObjectNameRU.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObjectNameRU.EnterMoveNextControl = True
        Me.txtObjectNameRU.Location = New System.Drawing.Point(12, 69)
        Me.txtObjectNameRU.Name = "txtObjectNameRU"
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txtObjectNameRU.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Очистить поле", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtObjectNameRU.Properties.Mask.EditMask = "(\d?\d?\d?) \d\d\d-\d\d\d\d"
        Me.txtObjectNameRU.Properties.MaxLength = 300
        Me.txtObjectNameRU.Size = New System.Drawing.Size(409, 22)
        Me.txtObjectNameRU.TabIndex = 1
        '
        'lbNameForm
        '
        Me.lbNameForm.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbNameForm.Appearance.Image = CType(resources.GetObject("lbNameForm.Appearance.Image"), System.Drawing.Image)
        Me.lbNameForm.Appearance.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbNameForm.Appearance.Options.UseFont = True
        Me.lbNameForm.Appearance.Options.UseImage = True
        Me.lbNameForm.Appearance.Options.UseImageAlign = True
        Me.lbNameForm.Appearance.Options.UseTextOptions = True
        Me.lbNameForm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbNameForm.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lbNameForm.Location = New System.Drawing.Point(12, 12)
        Me.lbNameForm.Name = "lbNameForm"
        Me.lbNameForm.Size = New System.Drawing.Size(223, 20)
        Me.lbNameForm.TabIndex = 0
        Me.lbNameForm.Text = "Добавить объект исследования"
        '
        'btnClose
        '
        Me.btnClose.AllowFocus = False
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.AutoSize = True
        Me.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013"
        Me.btnClose.Location = New System.Drawing.Point(397, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnClose.Size = New System.Drawing.Size(24, 22)
        Me.btnClose.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.AllowHtmlString = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 98)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(171, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Tag = "0"
        Me.LabelControl1.Text = "<color=red>*</color><u> Наименование объкта (латин.):</u>"
        '
        'txtObjectNameLAT
        '
        Me.txtObjectNameLAT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObjectNameLAT.EnterMoveNextControl = True
        Me.txtObjectNameLAT.Location = New System.Drawing.Point(12, 113)
        Me.txtObjectNameLAT.Name = "txtObjectNameLAT"
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.txtObjectNameLAT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "Очистить поле", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtObjectNameLAT.Properties.Mask.EditMask = "(\d?\d?\d?) \d\d\d-\d\d\d\d"
        Me.txtObjectNameLAT.Properties.MaxLength = 300
        Me.txtObjectNameLAT.Size = New System.Drawing.Size(409, 22)
        Me.txtObjectNameLAT.TabIndex = 2
        '
        'lbGrip
        '
        Me.lbGrip.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbGrip.Appearance.Image = CType(resources.GetObject("lbGrip.Appearance.Image"), System.Drawing.Image)
        Me.lbGrip.Appearance.Options.UseImage = True
        Me.lbGrip.Enabled = False
        Me.lbGrip.Location = New System.Drawing.Point(419, 439)
        Me.lbGrip.Name = "lbGrip"
        Me.lbGrip.Size = New System.Drawing.Size(16, 15)
        Me.lbGrip.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(344, 419)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnCancel.Size = New System.Drawing.Size(77, 26)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Tag = "0"
        Me.btnCancel.Text = "Отмена"
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.ImageOptions.Image = CType(resources.GetObject("btnOk.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOk.ImageOptions.ImageIndex = 0
        Me.btnOk.Location = New System.Drawing.Point(261, 419)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnOk.Size = New System.Drawing.Size(77, 26)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Tag = "11"
        Me.btnOk.Text = "OK"
        '
        'tlResearchMetods
        '
        Me.tlResearchMetods.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlResearchMetods.Location = New System.Drawing.Point(12, 152)
        Me.tlResearchMetods.Name = "tlResearchMetods"
        Me.tlResearchMetods.Size = New System.Drawing.Size(409, 242)
        Me.tlResearchMetods.TabIndex = 6
        UserControlProp1.btnMultiCheckingIsVisible = False
        Me.tlResearchMetods.UserControlProperty = UserControlProp1
        '
        'frAddEditObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(438, 457)
        Me.Controls.Add(Me.tlResearchMetods)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtObjectNameLAT)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtObjectNameRU)
        Me.Controls.Add(Me.lbNameForm)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lbGrip)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(438, 457)
        Me.Name = "frAddEditObjects"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frAddEditObjects"
        CType(Me.txtObjectNameRU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObjectNameLAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtObjectNameRU As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lbNameForm As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtObjectNameLAT As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lbGrip As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tlResearchMetods As ucTreeListResearchMetods
End Class
