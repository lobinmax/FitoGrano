<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frAddEditHistoryRoleJobs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frAddEditHistoryRoleJobs))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lbNameForm = New DevExpress.XtraEditors.LabelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbRoleJobsFilial = New DevExpress.XtraEditors.TreeListLookUpEdit()
        Me.tlRoleJobsFilial = New DevExpress.XtraTreeList.TreeList()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDtBegin = New DevExpress.XtraEditors.DateEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cmbRoleJobsFilial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tlRoleJobsFilial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDtBegin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDtBegin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.lbNameForm)
        Me.PanelControl1.Controls.Add(Me.btnClose)
        Me.PanelControl1.Controls.Add(Me.btnCancel)
        Me.PanelControl1.Controls.Add(Me.btnOk)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.cmbRoleJobsFilial)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.txtDtBegin)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(489, 203)
        Me.PanelControl1.TabIndex = 0
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
        Me.lbNameForm.Location = New System.Drawing.Point(12, 9)
        Me.lbNameForm.Name = "lbNameForm"
        Me.lbNameForm.Size = New System.Drawing.Size(241, 20)
        Me.lbNameForm.TabIndex = 16
        Me.lbNameForm.Text = "Присвоить должность сотруднику"
        '
        'btnClose
        '
        Me.btnClose.AllowFocus = False
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.AutoSize = True
        Me.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013"
        Me.btnClose.Location = New System.Drawing.Point(460, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnClose.Size = New System.Drawing.Size(24, 22)
        Me.btnClose.TabIndex = 15
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(382, 157)
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
        Me.btnOk.Location = New System.Drawing.Point(299, 157)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnOk.Size = New System.Drawing.Size(77, 26)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Tag = "11"
        Me.btnOk.Text = "OK"
        '
        'LabelControl1
        '
        Me.LabelControl1.AllowHtmlString = True
        Me.LabelControl1.Location = New System.Drawing.Point(24, 97)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(136, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Tag = "0"
        Me.LabelControl1.Text = "<u>Наименование должности:</u>"
        '
        'cmbRoleJobsFilial
        '
        Me.cmbRoleJobsFilial.EnterMoveNextControl = True
        Me.cmbRoleJobsFilial.Location = New System.Drawing.Point(24, 116)
        Me.cmbRoleJobsFilial.Name = "cmbRoleJobsFilial"
        Me.cmbRoleJobsFilial.Properties.AllowFocused = False
        Me.cmbRoleJobsFilial.Properties.Appearance.Options.UseTextOptions = True
        Me.cmbRoleJobsFilial.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        Me.cmbRoleJobsFilial.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmbRoleJobsFilial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRoleJobsFilial.Properties.ContextImageOptions.Image = CType(resources.GetObject("cmbRoleJobsFilial.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.cmbRoleJobsFilial.Properties.NullText = "[Должность не выбрана]"
        Me.cmbRoleJobsFilial.Properties.TreeList = Me.tlRoleJobsFilial
        Me.cmbRoleJobsFilial.Size = New System.Drawing.Size(435, 20)
        Me.cmbRoleJobsFilial.TabIndex = 2
        '
        'tlRoleJobsFilial
        '
        Me.tlRoleJobsFilial.Location = New System.Drawing.Point(0, 0)
        Me.tlRoleJobsFilial.Name = "tlRoleJobsFilial"
        Me.tlRoleJobsFilial.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
        Me.tlRoleJobsFilial.OptionsBehavior.Editable = False
        Me.tlRoleJobsFilial.OptionsMenu.EnableColumnMenu = False
        Me.tlRoleJobsFilial.OptionsMenu.EnableFooterMenu = False
        Me.tlRoleJobsFilial.OptionsMenu.ShowAutoFilterRowItem = False
        Me.tlRoleJobsFilial.OptionsNavigation.AutoMoveRowFocus = True
        Me.tlRoleJobsFilial.OptionsSelection.SelectNodesOnRightClick = True
        Me.tlRoleJobsFilial.OptionsView.ShowColumns = False
        Me.tlRoleJobsFilial.OptionsView.ShowHorzLines = False
        Me.tlRoleJobsFilial.OptionsView.ShowIndentAsRowStyle = True
        Me.tlRoleJobsFilial.OptionsView.ShowIndicator = False
        Me.tlRoleJobsFilial.OptionsView.ShowVertLines = False
        Me.tlRoleJobsFilial.Size = New System.Drawing.Size(400, 200)
        Me.tlRoleJobsFilial.TabIndex = 0
        '
        'LabelControl8
        '
        Me.LabelControl8.AllowHtmlString = True
        Me.LabelControl8.Location = New System.Drawing.Point(24, 58)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(160, 13)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Tag = "0"
        Me.LabelControl8.Text = "<u>Дата вступления в должность:</u>"
        '
        'txtDtBegin
        '
        Me.txtDtBegin.EditValue = Nothing
        Me.txtDtBegin.EnterMoveNextControl = True
        Me.txtDtBegin.Location = New System.Drawing.Point(190, 57)
        Me.txtDtBegin.Name = "txtDtBegin"
        Me.txtDtBegin.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtDtBegin.Properties.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txtDtBegin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtDtBegin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDtBegin.Size = New System.Drawing.Size(158, 20)
        Me.txtDtBegin.TabIndex = 1
        Me.txtDtBegin.Tag = "7"
        '
        'frAddEditHistoryRoleJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(489, 203)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frAddEditHistoryRoleJobs"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frAddEditHistoryRoleJobs"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cmbRoleJobsFilial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tlRoleJobsFilial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDtBegin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDtBegin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDtBegin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbRoleJobsFilial As DevExpress.XtraEditors.TreeListLookUpEdit
    Friend WithEvents tlRoleJobsFilial As DevExpress.XtraTreeList.TreeList
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbNameForm As DevExpress.XtraEditors.LabelControl
End Class
