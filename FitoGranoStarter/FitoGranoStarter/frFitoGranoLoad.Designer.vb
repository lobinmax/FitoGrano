<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frFitoGranoLoad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frFitoGranoLoad))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.VisualControl = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.ProgressViewPanel = New DevExpress.XtraEditors.PanelControl()
        Me.ProgressControl = New DevExpress.XtraEditors.ProgressBarControl()
        Me.lbFileName = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ProgressViewPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProgressViewPanel.SuspendLayout()
        CType(Me.ProgressControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.VisualControl)
        Me.PanelControl1.Controls.Add(Me.PictureEdit1)
        Me.PanelControl1.Controls.Add(Me.ProgressViewPanel)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(384, 115)
        Me.PanelControl1.TabIndex = 0
        '
        'VisualControl
        '
        Me.VisualControl.AnimationAcceleration = 5.0!
        Me.VisualControl.AnimationElementCount = 8
        Me.VisualControl.AnimationSpeed = 4.0!
        Me.VisualControl.AnimationToTextDistance = 2
        Me.VisualControl.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.VisualControl.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.VisualControl.Appearance.Options.UseBackColor = True
        Me.VisualControl.Appearance.Options.UseForeColor = True
        Me.VisualControl.BarAnimationElementThickness = 2
        Me.VisualControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.VisualControl.Caption = "Пожалуйста подождите"
        Me.VisualControl.Description = "Проверка обновлений ..."
        Me.VisualControl.LineAnimationElementHeight = 8
        Me.VisualControl.Location = New System.Drawing.Point(132, 28)
        Me.VisualControl.Name = "VisualControl"
        Me.VisualControl.ShowToolTips = False
        Me.VisualControl.Size = New System.Drawing.Size(237, 62)
        Me.VisualControl.TabIndex = 1
        Me.VisualControl.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line
        '
        'ProgressViewPanel
        '
        Me.ProgressViewPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ProgressViewPanel.Controls.Add(Me.ProgressControl)
        Me.ProgressViewPanel.Controls.Add(Me.lbFileName)
        Me.ProgressViewPanel.Location = New System.Drawing.Point(12, 109)
        Me.ProgressViewPanel.Name = "ProgressViewPanel"
        Me.ProgressViewPanel.Size = New System.Drawing.Size(357, 39)
        Me.ProgressViewPanel.TabIndex = 10
        Me.ProgressViewPanel.Visible = False
        '
        'ProgressControl
        '
        Me.ProgressControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressControl.EditValue = "0"
        Me.ProgressControl.Location = New System.Drawing.Point(0, 13)
        Me.ProgressControl.Name = "ProgressControl"
        Me.ProgressControl.Properties.AllowFocused = False
        Me.ProgressControl.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressControl.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.ProgressControl.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.ProgressControl.Properties.EndColor = System.Drawing.Color.Empty
        Me.ProgressControl.Properties.LookAndFeel.SkinName = "Metropolis Dark"
        Me.ProgressControl.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ProgressControl.Properties.PercentView = False
        Me.ProgressControl.Properties.StartColor = System.Drawing.Color.Empty
        Me.ProgressControl.Properties.Step = 1
        Me.ProgressControl.ShowProgressInTaskBar = True
        Me.ProgressControl.Size = New System.Drawing.Size(357, 18)
        Me.ProgressControl.TabIndex = 2
        '
        'lbFileName
        '
        Me.lbFileName.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbFileName.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lbFileName.Appearance.Options.UseBackColor = True
        Me.lbFileName.Appearance.Options.UseFont = True
        Me.lbFileName.Appearance.Options.UseTextOptions = True
        Me.lbFileName.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisWord
        Me.lbFileName.AutoEllipsis = True
        Me.lbFileName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbFileName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbFileName.Location = New System.Drawing.Point(0, 0)
        Me.lbFileName.Name = "lbFileName"
        Me.lbFileName.Size = New System.Drawing.Size(357, 13)
        Me.lbFileName.TabIndex = 9
        Me.lbFileName.Text = "DevExpress.XtraLayout.v17.1.xml"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 5)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.AllowFocused = False
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ReadOnly = True
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[False]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Properties.UseDisabledStatePainter = False
        Me.PictureEdit1.Size = New System.Drawing.Size(112, 104)
        Me.PictureEdit1.TabIndex = 0
        '
        'frFitoGranoLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 115)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frFitoGranoLoad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ПК FitoGrano. Обновление"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.ProgressViewPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProgressViewPanel.ResumeLayout(False)
        CType(Me.ProgressControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents VisualControl As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents ProgressControl As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbFileName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProgressViewPanel As DevExpress.XtraEditors.PanelControl
End Class
