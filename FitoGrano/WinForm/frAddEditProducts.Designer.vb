<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frAddEditProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frAddEditProducts))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.lbNameForm = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProductsName = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.txtWeightSample = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.txtProductsName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWeightSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnClose.TabIndex = 17
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
        Me.lbNameForm.Size = New System.Drawing.Size(160, 20)
        Me.lbNameForm.TabIndex = 18
        Me.lbNameForm.Text = "Добавить продукцию"
        '
        'LabelControl13
        '
        Me.LabelControl13.AllowHtmlString = True
        Me.LabelControl13.Location = New System.Drawing.Point(12, 54)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(144, 13)
        Me.LabelControl13.TabIndex = 20
        Me.LabelControl13.Tag = "0"
        Me.LabelControl13.Text = "<color=red>*</color><u> Наименование продукции:</u>"
        '
        'txtProductsName
        '
        Me.txtProductsName.EnterMoveNextControl = True
        Me.txtProductsName.Location = New System.Drawing.Point(12, 69)
        Me.txtProductsName.Name = "txtProductsName"
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txtProductsName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Очистить поле", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtProductsName.Properties.Mask.EditMask = "(\d?\d?\d?) \d\d\d-\d\d\d\d"
        Me.txtProductsName.Properties.MaxLength = 50
        Me.txtProductsName.Size = New System.Drawing.Size(329, 22)
        Me.txtProductsName.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.AllowHtmlString = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 106)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(188, 13)
        Me.LabelControl1.TabIndex = 22
        Me.LabelControl1.Tag = "0"
        Me.LabelControl1.Text = "<color=red>*</color><u> Средний размер пробы продукции:</u>"
        '
        'LabelControl2
        '
        Me.LabelControl2.AllowHtmlString = True
        Me.LabelControl2.Location = New System.Drawing.Point(323, 106)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl2.TabIndex = 23
        Me.LabelControl2.Tag = "0"
        Me.LabelControl2.Text = "<u> гр.</u>"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(264, 150)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnCancel.Size = New System.Drawing.Size(77, 26)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Tag = "0"
        Me.btnCancel.Text = "Отмена"
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.ImageOptions.Image = CType(resources.GetObject("btnOk.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOk.ImageOptions.ImageIndex = 0
        Me.btnOk.Location = New System.Drawing.Point(181, 150)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnOk.Size = New System.Drawing.Size(77, 26)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Tag = "11"
        Me.btnOk.Text = "OK"
        '
        'txtWeightSample
        '
        Me.txtWeightSample.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtWeightSample.EnterMoveNextControl = True
        Me.txtWeightSample.Location = New System.Drawing.Point(206, 105)
        Me.txtWeightSample.Name = "txtWeightSample"
        Me.txtWeightSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtWeightSample.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtWeightSample.Properties.IsFloatValue = False
        Me.txtWeightSample.Properties.Mask.EditMask = "n0"
        Me.txtWeightSample.Properties.MaxLength = 50
        Me.txtWeightSample.Size = New System.Drawing.Size(111, 20)
        Me.txtWeightSample.TabIndex = 2
        '
        'frAddEditProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(353, 188)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtProductsName)
        Me.Controls.Add(Me.lbNameForm)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtWeightSample)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frAddEditProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frAddEditProducts"
        CType(Me.txtProductsName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWeightSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbNameForm As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProductsName As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtWeightSample As DevExpress.XtraEditors.SpinEdit
End Class
