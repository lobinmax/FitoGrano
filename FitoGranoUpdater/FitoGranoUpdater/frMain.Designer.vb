<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frMain
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
        Me.TimerCheckUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.acUpdate = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.tmSinhronScin = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TimerCheckUpdate
        '
        Me.TimerCheckUpdate.Enabled = True
        Me.TimerCheckUpdate.Interval = 1000
        '
        'acUpdate
        '
        Me.acUpdate.AllowHotTrack = False
        Me.acUpdate.AllowHtmlText = True
        Me.acUpdate.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.acUpdate.AppearanceCaption.Options.UseFont = True
        Me.acUpdate.AppearanceText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.acUpdate.AppearanceText.Options.UseFont = True
        Me.acUpdate.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Slow
        Me.acUpdate.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal
        '
        'tmSinhronScin
        '
        Me.tmSinhronScin.Enabled = True
        '
        'frMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 53)
        Me.Name = "frMain"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerCheckUpdate As System.Windows.Forms.Timer
    Friend WithEvents acUpdate As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents tmSinhronScin As System.Windows.Forms.Timer
End Class
