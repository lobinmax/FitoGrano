<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frAddEditOrganizationsGroup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frAddEditOrganizationsGroup))
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
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.txtNote = New DevExpress.XtraEditors.MemoEdit()
        Me.txtPhoneOrganization = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmailOrganization = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtNameOrganization = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnClearNotes = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhoneOrganization.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmailOrganization.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameOrganization.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(505, 185)
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
        Me.btnOk.Location = New System.Drawing.Point(422, 185)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnOk.Size = New System.Drawing.Size(77, 26)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Tag = "11"
        Me.btnOk.Text = "OK"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.PictureEdit1)
        Me.PanelControl1.Controls.Add(Me.txtNote)
        Me.PanelControl1.Controls.Add(Me.txtPhoneOrganization)
        Me.PanelControl1.Controls.Add(Me.LabelControl14)
        Me.PanelControl1.Controls.Add(Me.txtEmailOrganization)
        Me.PanelControl1.Controls.Add(Me.txtNameOrganization)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.btnCancel)
        Me.PanelControl1.Controls.Add(Me.btnOk)
        Me.PanelControl1.Controls.Add(Me.btnClearNotes)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(606, 232)
        Me.PanelControl1.TabIndex = 49
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(28, 168)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.AllowFocused = False
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[False]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(43, 43)
        Me.PictureEdit1.TabIndex = 8
        '
        'txtNote
        '
        Me.txtNote.EditValue = ""
        Me.txtNote.EnterMoveNextControl = True
        Me.txtNote.Location = New System.Drawing.Point(28, 126)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Properties.MaxLength = 500
        Me.txtNote.Size = New System.Drawing.Size(554, 36)
        Me.txtNote.TabIndex = 6
        Me.txtNote.Tag = ""
        '
        'txtPhoneOrganization
        '
        Me.txtPhoneOrganization.EnterMoveNextControl = True
        Me.txtPhoneOrganization.Location = New System.Drawing.Point(321, 81)
        Me.txtPhoneOrganization.Name = "txtPhoneOrganization"
        Me.txtPhoneOrganization.Properties.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txtPhoneOrganization.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtPhoneOrganization", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Очистить поле", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtPhoneOrganization.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtPhoneOrganization.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtPhoneOrganization.Size = New System.Drawing.Size(261, 20)
        Me.txtPhoneOrganization.TabIndex = 5
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Options.UseTextOptions = True
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl14.LineVisible = True
        Me.LabelControl14.Location = New System.Drawing.Point(28, 56)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(554, 13)
        Me.LabelControl14.TabIndex = 0
        Me.LabelControl14.Tag = "0"
        Me.LabelControl14.Text = " Контактные данные"
        '
        'txtEmailOrganization
        '
        Me.txtEmailOrganization.EnterMoveNextControl = True
        Me.txtEmailOrganization.Location = New System.Drawing.Point(71, 81)
        Me.txtEmailOrganization.Name = "txtEmailOrganization"
        Me.txtEmailOrganization.Properties.AutoHeight = False
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.txtEmailOrganization.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtEmailOrganization", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "Очистить поле", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtEmailOrganization.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtEmailOrganization.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtEmailOrganization.Size = New System.Drawing.Size(180, 20)
        Me.txtEmailOrganization.TabIndex = 4
        '
        'txtNameOrganization
        '
        Me.txtNameOrganization.EnterMoveNextControl = True
        Me.txtNameOrganization.Location = New System.Drawing.Point(150, 23)
        Me.txtNameOrganization.Name = "txtNameOrganization"
        Me.txtNameOrganization.Properties.AutoHeight = False
        EditorButtonImageOptions3.Image = CType(resources.GetObject("EditorButtonImageOptions3.Image"), System.Drawing.Image)
        Me.txtNameOrganization.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtNameOrganization", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "Очистить поле", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtNameOrganization.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtNameOrganization.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtNameOrganization.Properties.MaxLength = 150
        Me.txtNameOrganization.Size = New System.Drawing.Size(432, 20)
        Me.txtNameOrganization.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.AllowHtmlString = True
        Me.LabelControl6.Location = New System.Drawing.Point(28, 111)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "<u> Комментарий:</u>"
        '
        'LabelControl5
        '
        Me.LabelControl5.AllowHtmlString = True
        Me.LabelControl5.Location = New System.Drawing.Point(259, 82)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "<u>Телефоны:</u>"
        '
        'LabelControl4
        '
        Me.LabelControl4.AllowHtmlString = True
        Me.LabelControl4.Location = New System.Drawing.Point(28, 82)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "<color=red>*</color><u> Email:</u>"
        '
        'LabelControl1
        '
        Me.LabelControl1.AllowHtmlString = True
        Me.LabelControl1.Location = New System.Drawing.Point(28, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "<color=red>*</color><u> Наименование:</u>"
        '
        'btnClearNotes
        '
        Me.btnClearNotes.AllowFocus = False
        Me.btnClearNotes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnClearNotes.ImageOptions.Image = CType(resources.GetObject("btnClearNotes.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClearNotes.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnClearNotes.Location = New System.Drawing.Point(102, 106)
        Me.btnClearNotes.Name = "btnClearNotes"
        Me.btnClearNotes.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnClearNotes.Size = New System.Drawing.Size(22, 22)
        Me.btnClearNotes.TabIndex = 0
        Me.btnClearNotes.ToolTip = "Очистить поле"
        '
        'frAddEditOrganizationsGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(606, 232)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frAddEditOrganizationsGroup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frAddEditSubOrganizations"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhoneOrganization.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmailOrganization.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameOrganization.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameOrganization As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtEmailOrganization As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPhoneOrganization As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnClearNotes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
