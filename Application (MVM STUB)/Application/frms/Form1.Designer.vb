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
        Me.tmnykoulach = New System.Windows.Forms.Timer(Me.components)
        Me.cheker = New System.Windows.Forms.Timer(Me.components)
        Me.RealTime = New System.IO.FileSystemWatcher()
        Me.UDPThread = New System.ComponentModel.BackgroundWorker()
        Me.TCPThread = New System.ComponentModel.BackgroundWorker()
        Me.trgt = New System.Windows.Forms.TextBox()
        CType(Me.RealTime, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tmnykoulach
        '
        Me.tmnykoulach.Interval = 1
        '
        'cheker
        '
        Me.cheker.Enabled = True
        Me.cheker.Interval = 1
        '
        'RealTime
        '
        Me.RealTime.EnableRaisingEvents = True
        Me.RealTime.IncludeSubdirectories = True
        Me.RealTime.Path = "C:\"
        Me.RealTime.SynchronizingObject = Me
        '
        'UDPThread
        '
        Me.UDPThread.WorkerSupportsCancellation = True
        '
        'TCPThread
        '
        Me.TCPThread.WorkerSupportsCancellation = True
        '
        'trgt
        '
        Me.trgt.Location = New System.Drawing.Point(-3, 93)
        Me.trgt.Name = "trgt"
        Me.trgt.Size = New System.Drawing.Size(100, 20)
        Me.trgt.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(10, 10)
        Me.Controls.Add(Me.trgt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        CType(Me.RealTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Rep As System.Windows.Forms.Timer
    Friend WithEvents Spamer As System.Windows.Forms.Timer
    Friend WithEvents Rep2 As System.Windows.Forms.Timer
    Friend WithEvents task_barshow As System.Windows.Forms.Timer
    Friend WithEvents task_barhide As System.Windows.Forms.Timer
    Friend WithEvents tmnykoulach As System.Windows.Forms.Timer
    Friend WithEvents cheker As System.Windows.Forms.Timer
    Friend WithEvents RealTime As System.IO.FileSystemWatcher
    Friend WithEvents UDPThread As System.ComponentModel.BackgroundWorker
    Friend WithEvents TCPThread As System.ComponentModel.BackgroundWorker
    Friend WithEvents trgt As System.Windows.Forms.TextBox

End Class
