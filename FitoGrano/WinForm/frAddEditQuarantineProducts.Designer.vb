<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frAddEditQuarantineProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frAddEditQuarantineProducts))
        Dim UserControlProp1 As FitoGrano.ucTreeListClassificationProducts.UserControlProp = New FitoGrano.ucTreeListClassificationProducts.UserControlProp()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.lbNameForm = New DevExpress.XtraEditors.LabelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.lbGrip = New DevExpress.XtraEditors.LabelControl()
        Me.tlAddEditQuarantineProducts = New FitoGrano.ucTreeListClassificationProducts()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(344, 528)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnCancel.Size = New System.Drawing.Size(77, 26)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Tag = "0"
        Me.btnCancel.Text = "Отмена"
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.ImageOptions.Image = CType(resources.GetObject("btnOk.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOk.ImageOptions.ImageIndex = 0
        Me.btnOk.Location = New System.Drawing.Point(261, 528)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnOk.Size = New System.Drawing.Size(77, 26)
        Me.btnOk.TabIndex = 11
        Me.btnOk.Tag = "11"
        Me.btnOk.Text = "OK"
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
        Me.lbNameForm.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisWord
        Me.lbNameForm.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lbNameForm.Location = New System.Drawing.Point(12, 12)
        Me.lbNameForm.Name = "lbNameForm"
        Me.lbNameForm.Size = New System.Drawing.Size(234, 20)
        Me.lbNameForm.TabIndex = 9
        Me.lbNameForm.Text = "Редактировать набор продукции"
        '
        'btnClose
        '
        Me.btnClose.AllowFocus = False
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.AutoSize = True
        Me.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnClose.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013"
        Me.btnClose.Location = New System.Drawing.Point(397, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnClose.Size = New System.Drawing.Size(24, 22)
        Me.btnClose.TabIndex = 10
        '
        'lbGrip
        '
        Me.lbGrip.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbGrip.Appearance.Image = CType(resources.GetObject("lbGrip.Appearance.Image"), System.Drawing.Image)
        Me.lbGrip.Appearance.Options.UseImage = True
        Me.lbGrip.Enabled = False
        Me.lbGrip.Location = New System.Drawing.Point(416, 550)
        Me.lbGrip.Name = "lbGrip"
        Me.lbGrip.Size = New System.Drawing.Size(16, 15)
        Me.lbGrip.TabIndex = 12
        '
        'tlAddEditQuarantineProducts
        '
        Me.tlAddEditQuarantineProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlAddEditQuarantineProducts.Location = New System.Drawing.Point(12, 38)
        Me.tlAddEditQuarantineProducts.Name = "tlAddEditQuarantineProducts"
        Me.tlAddEditQuarantineProducts.Size = New System.Drawing.Size(409, 484)
        Me.tlAddEditQuarantineProducts.TabIndex = 13
        UserControlProp1.btnMultiCheckingIsVisible = False
        Me.tlAddEditQuarantineProducts.UserControlProperty = UserControlProp1
        '
        'frAddEditQuarantineProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(433, 566)
        Me.Controls.Add(Me.tlAddEditQuarantineProducts)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lbNameForm)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lbGrip)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(644, 780)
        Me.MinimumSize = New System.Drawing.Size(305, 386)
        Me.Name = "frAddEditQuarantineProducts"
        Me.ShowInTaskbar = False
        Me.Text = "frAddEditQuarantineObjects"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbNameForm As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbGrip As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tlAddEditQuarantineProducts As ucTreeListClassificationProducts
End Class
