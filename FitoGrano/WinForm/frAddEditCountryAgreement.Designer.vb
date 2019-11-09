<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frAddEditCountryAgreement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frAddEditCountryAgreement))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.lbNameForm = New DevExpress.XtraEditors.LabelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.lbCountryName = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAgreementText = New DevExpress.XtraEditors.MemoEdit()
        Me.lbGrip = New DevExpress.XtraEditors.LabelControl()
        Me.txtAgreementDtBegin = New DevExpress.XtraEditors.DateEdit()
        Me.txtAgreementDtEnd = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtAgreementText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAgreementDtBegin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAgreementDtBegin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAgreementDtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAgreementDtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lbNameForm.Size = New System.Drawing.Size(161, 20)
        Me.lbNameForm.TabIndex = 0
        Me.lbNameForm.Text = "Добавить соглашение"
        '
        'btnClose
        '
        Me.btnClose.AllowFocus = False
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.AutoSize = True
        Me.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnClose.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013"
        Me.btnClose.Location = New System.Drawing.Point(455, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnClose.Size = New System.Drawing.Size(24, 22)
        Me.btnClose.TabIndex = 0
        '
        'lbCountryName
        '
        Me.lbCountryName.AllowHtmlString = True
        Me.lbCountryName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCountryName.Appearance.Options.UseTextOptions = True
        Me.lbCountryName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbCountryName.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        Me.lbCountryName.AutoEllipsis = True
        Me.lbCountryName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbCountryName.LineVisible = True
        Me.lbCountryName.Location = New System.Drawing.Point(12, 55)
        Me.lbCountryName.Name = "lbCountryName"
        Me.lbCountryName.Size = New System.Drawing.Size(467, 13)
        Me.lbCountryName.TabIndex = 0
        Me.lbCountryName.Tag = "0"
        Me.lbCountryName.Text = " <image=#earth_16x16> Наименование страны"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(402, 265)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnCancel.Size = New System.Drawing.Size(77, 26)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Tag = "0"
        Me.btnCancel.Text = "Отмена"
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.ImageOptions.Image = CType(resources.GetObject("btnOk.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOk.ImageOptions.ImageIndex = 0
        Me.btnOk.Location = New System.Drawing.Point(319, 265)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnOk.Size = New System.Drawing.Size(77, 26)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Tag = "11"
        Me.btnOk.Text = "OK"
        '
        'txtAgreementText
        '
        Me.txtAgreementText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAgreementText.Location = New System.Drawing.Point(12, 83)
        Me.txtAgreementText.Name = "txtAgreementText"
        Me.txtAgreementText.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtAgreementText.Properties.MaxLength = 500
        Me.txtAgreementText.Properties.NullText = "Введите текст соглашения ..."
        Me.txtAgreementText.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAgreementText.Size = New System.Drawing.Size(467, 102)
        Me.txtAgreementText.TabIndex = 1
        '
        'lbGrip
        '
        Me.lbGrip.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbGrip.Appearance.Image = CType(resources.GetObject("lbGrip.Appearance.Image"), System.Drawing.Image)
        Me.lbGrip.Appearance.Options.UseImage = True
        Me.lbGrip.Enabled = False
        Me.lbGrip.Location = New System.Drawing.Point(474, 287)
        Me.lbGrip.Name = "lbGrip"
        Me.lbGrip.Size = New System.Drawing.Size(16, 15)
        Me.lbGrip.TabIndex = 4
        '
        'txtAgreementDtBegin
        '
        Me.txtAgreementDtBegin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAgreementDtBegin.EditValue = Nothing
        Me.txtAgreementDtBegin.EnterMoveNextControl = True
        Me.txtAgreementDtBegin.Location = New System.Drawing.Point(154, 201)
        Me.txtAgreementDtBegin.Name = "txtAgreementDtBegin"
        Me.txtAgreementDtBegin.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtAgreementDtBegin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAgreementDtBegin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAgreementDtBegin.Properties.TodayDate = New Date(2018, 11, 26, 22, 56, 49, 0)
        Me.txtAgreementDtBegin.Size = New System.Drawing.Size(123, 20)
        Me.txtAgreementDtBegin.TabIndex = 2
        '
        'txtAgreementDtEnd
        '
        Me.txtAgreementDtEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAgreementDtEnd.EditValue = Nothing
        Me.txtAgreementDtEnd.EnterMoveNextControl = True
        Me.txtAgreementDtEnd.Location = New System.Drawing.Point(154, 230)
        Me.txtAgreementDtEnd.Name = "txtAgreementDtEnd"
        Me.txtAgreementDtEnd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txtAgreementDtEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "btnClearAgreementDtEnd", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Удалить дату", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtAgreementDtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAgreementDtEnd.Properties.TodayDate = New Date(2018, 11, 26, 22, 56, 49, 0)
        Me.txtAgreementDtEnd.Size = New System.Drawing.Size(123, 20)
        Me.txtAgreementDtEnd.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(21, 233)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Дата прекращения:"
        '
        'LabelControl1
        '
        Me.LabelControl1.AllowHtmlString = True
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(12, 202)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(136, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "<color=red>*</color><u> Дата вступления в силу:"
        '
        'frAddEditCountryAgreement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(491, 303)
        Me.Controls.Add(Me.txtAgreementDtEnd)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtAgreementDtBegin)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtAgreementText)
        Me.Controls.Add(Me.lbCountryName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lbNameForm)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lbGrip)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(724, 484)
        Me.MinimumSize = New System.Drawing.Size(425, 264)
        Me.Name = "frAddEditCountryAgreement"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frAddEditCountryAgreement"
        CType(Me.txtAgreementText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAgreementDtBegin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAgreementDtBegin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAgreementDtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAgreementDtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbNameForm As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbCountryName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAgreementText As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lbGrip As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAgreementDtBegin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtAgreementDtEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
