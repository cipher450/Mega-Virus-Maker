<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Rep = New System.Windows.Forms.Timer(Me.components)
        Me.Spamer = New System.Windows.Forms.Timer(Me.components)
        Me.Rep2 = New System.Windows.Forms.Timer(Me.components)
        Me.task_barshow = New System.Windows.Forms.Timer(Me.components)
        Me.task_barhide = New System.Windows.Forms.Timer(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Rep
        '
        Me.Rep.Enabled = True
        Me.Rep.Interval = 1
        '
        'Spamer
        '
        Me.Spamer.Enabled = True
        Me.Spamer.Interval = 200
        '
        'Rep2
        '
        Me.Rep2.Enabled = True
        Me.Rep2.Interval = 300
        '
        'task_barshow
        '
        Me.task_barshow.Interval = 500
        '
        'task_barhide
        '
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(204, 62)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(121, 97)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 300)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Rep As System.Windows.Forms.Timer
    Friend WithEvents Spamer As System.Windows.Forms.Timer
    Friend WithEvents Rep2 As System.Windows.Forms.Timer
    Friend WithEvents task_barshow As System.Windows.Forms.Timer
    Friend WithEvents task_barhide As System.Windows.Forms.Timer
    Friend WithEvents ListView1 As System.Windows.Forms.ListView

End Class
