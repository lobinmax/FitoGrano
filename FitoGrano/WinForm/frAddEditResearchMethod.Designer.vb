<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frAddEditResearchMethod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frAddEditResearchMethod))
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMethodName = New DevExpress.XtraEditors.ButtonEdit()
        Me.lbNameForm = New DevExpress.XtraEditors.LabelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cheIsPriority = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLongDay = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.txtMethodName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheIsPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLongDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(264, 183)
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
        Me.btnOk.Location = New System.Drawing.Point(181, 183)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnOk.Size = New System.Drawing.Size(77, 26)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Tag = "11"
        Me.btnOk.Text = "OK"
        '
        'LabelControl13
        '
        Me.LabelControl13.AllowHtmlString = True
        Me.LabelControl13.Location = New System.Drawing.Point(12, 54)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(200, 13)
        Me.LabelControl13.TabIndex = 0
        Me.LabelControl13.Tag = "0"
        Me.LabelControl13.Text = "<color=red>*</color><u> Наименование метода исследования:</u>"
        '
        'txtMethodName
        '
        Me.txtMethodName.EnterMoveNextControl = True
        Me.txtMethodName.Location = New System.Drawing.Point(12, 69)
        Me.txtMethodName.Name = "txtMethodName"
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.txtMethodName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "Очистить поле", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtMethodName.Properties.Mask.EditMask = "(\d?\d?\d?) \d\d\d-\d\d\d\d"
        Me.txtMethodName.Properties.MaxLength = 200
        Me.txtMethodName.Size = New System.Drawing.Size(329, 22)
        Me.txtMethodName.TabIndex = 1
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
        Me.lbNameForm.Size = New System.Drawing.Size(217, 20)
        Me.lbNameForm.TabIndex = 0
        Me.lbNameForm.Text = "Добавить метод исследования"
        '
        'btnClose
        '
        Me.btnClose.AllowFocus = False
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.AutoSize = True
        Me.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnClose.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013"
        Me.btnClose.Location = New System.Drawing.Point(317, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnClose.Size = New System.Drawing.Size(24, 22)
        Me.btnClose.TabIndex = 0
        '
        'cheIsPriority
        '
        Me.cheIsPriority.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.cheIsPriority.EnterMoveNextControl = True
        Me.cheIsPriority.Location = New System.Drawing.Point(12, 106)
        Me.cheIsPriority.Name = "cheIsPriority"
        Me.cheIsPriority.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.cheIsPriority.Properties.AutoWidth = True
        Me.cheIsPriority.Properties.Caption = "<color=red>*</color><u> Метод является приоритетным"
        Me.cheIsPriority.Size = New System.Drawing.Size(191, 19)
        Me.cheIsPriority.TabIndex = 2
        Me.cheIsPriority.ToolTip = "Выберите если пробу нужно добавить в начало"
        '
        'LabelControl1
        '
        Me.LabelControl1.AllowHtmlString = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 144)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(224, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Tag = "0"
        Me.LabelControl1.Text = "<color=red>*</color><u> Продолжительность исследования, дней:</u>"
        '
        'txtLongDay
        '
        Me.txtLongDay.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtLongDay.EnterMoveNextControl = True
        Me.txtLongDay.Location = New System.Drawing.Point(242, 141)
        Me.txtLongDay.Name = "txtLongDay"
        Me.txtLongDay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLongDay.Properties.IsFloatValue = False
        Me.txtLongDay.Properties.Mask.EditMask = "N00"
        Me.txtLongDay.Properties.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtLongDay.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtLongDay.Size = New System.Drawing.Size(99, 20)
        Me.txtLongDay.TabIndex = 3
        '
        'frAddEditResearchMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(353, 221)
        Me.Controls.Add(Me.txtLongDay)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cheIsPriority)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtMethodName)
        Me.Controls.Add(Me.lbNameForm)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frAddEditResearchMethod"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frAddEditResearchMethod"
        CType(Me.txtMethodName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheIsPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLongDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMethodName As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lbNameForm As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cheIsPriority As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLongDay As DevExpress.XtraEditors.SpinEdit
End Class
