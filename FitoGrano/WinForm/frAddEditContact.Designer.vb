<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frAddEditContact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frAddEditContact))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.lbNameForm = New DevExpress.XtraEditors.LabelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPhoneNumber = New DevExpress.XtraEditors.ButtonEdit()
        Me.rgContactsTypes = New DevExpress.XtraEditors.RadioGroup()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtPhoneNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgContactsTypes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.LabelControl13)
        Me.PanelControl1.Controls.Add(Me.lbNameForm)
        Me.PanelControl1.Controls.Add(Me.btnClose)
        Me.PanelControl1.Controls.Add(Me.btnCancel)
        Me.PanelControl1.Controls.Add(Me.btnOk)
        Me.PanelControl1.Controls.Add(Me.txtPhoneNumber)
        Me.PanelControl1.Controls.Add(Me.rgContactsTypes)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(247, 194)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl13
        '
        Me.LabelControl13.AllowHtmlString = True
        Me.LabelControl13.Location = New System.Drawing.Point(17, 36)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl13.TabIndex = 18
        Me.LabelControl13.Tag = "0"
        Me.LabelControl13.Text = "<color=red>*</color><u> Номер контакта:</u>"
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
        Me.lbNameForm.Location = New System.Drawing.Point(5, 5)
        Me.lbNameForm.Name = "lbNameForm"
        Me.lbNameForm.Size = New System.Drawing.Size(137, 20)
        Me.lbNameForm.TabIndex = 17
        Me.lbNameForm.Text = "Добавить контакт"
        '
        'btnClose
        '
        Me.btnClose.AllowFocus = False
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.AutoSize = True
        Me.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnClose.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013"
        Me.btnClose.Location = New System.Drawing.Point(218, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnClose.Size = New System.Drawing.Size(24, 22)
        Me.btnClose.TabIndex = 16
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnCancel.Location = New System.Drawing.Point(188, 153)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnCancel.Size = New System.Drawing.Size(38, 26)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Tag = "0"
        '
        'btnOk
        '
        Me.btnOk.ImageOptions.Image = CType(resources.GetObject("btnOk.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOk.ImageOptions.ImageIndex = 0
        Me.btnOk.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnOk.Location = New System.Drawing.Point(144, 153)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnOk.Size = New System.Drawing.Size(38, 26)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Tag = "11"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.EnterMoveNextControl = True
        Me.txtPhoneNumber.Location = New System.Drawing.Point(17, 51)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txtPhoneNumber.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Очистить поле", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtPhoneNumber.Properties.Mask.EditMask = "(\d?\d?\d?) \d\d\d-\d\d\d\d"
        Me.txtPhoneNumber.Properties.MaxLength = 50
        Me.txtPhoneNumber.Size = New System.Drawing.Size(209, 22)
        Me.txtPhoneNumber.TabIndex = 1
        '
        'rgContactsTypes
        '
        Me.rgContactsTypes.EditValue = "PhoneMobile_12x12"
        Me.rgContactsTypes.EnterMoveNextControl = True
        Me.rgContactsTypes.Location = New System.Drawing.Point(17, 77)
        Me.rgContactsTypes.Name = "rgContactsTypes"
        Me.rgContactsTypes.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("PhoneMobile_12x12", "Сотовый", True, "\+7(\d?\d?\d?) \d\d\d-\d\d-\d\d"), New DevExpress.XtraEditors.Controls.RadioGroupItem("PhoneHome_12x12", "Домашний", True, "\+7(\d?\d?\d?) \d\d\d-\d\d-\d\d"), New DevExpress.XtraEditors.Controls.RadioGroupItem("PhoneWork_12x12", "Рабочий", True, ""), New DevExpress.XtraEditors.Controls.RadioGroupItem("PhoneOther_12x12", "Другой", True, "")})
        Me.rgContactsTypes.Size = New System.Drawing.Size(209, 60)
        Me.rgContactsTypes.TabIndex = 0
        '
        'frAddEditContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(247, 194)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frAddEditContact"
        Me.ShowInTaskbar = False
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtPhoneNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgContactsTypes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtPhoneNumber As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents rgContactsTypes As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbNameForm As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
End Class
