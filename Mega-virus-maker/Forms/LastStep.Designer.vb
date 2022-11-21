<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LastStep
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
        Me.NyX_Theme1 = New Mega_virus_maker_2._0.NYX_Theme()
        Me.NyX_Button1 = New Mega_virus_maker_2._0.NYX_Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.No = New System.Windows.Forms.RadioButton()
        Me.Yes = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NyX_Theme1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NyX_Theme1
        '
        Me.NyX_Theme1.Animated = False
        Me.NyX_Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NyX_Theme1.Colors = New Mega_virus_maker_2._0.Bloom(-1) {}
        Me.NyX_Theme1.Controls.Add(Me.NyX_Button1)
        Me.NyX_Theme1.Controls.Add(Me.GroupBox2)
        Me.NyX_Theme1.Customization = ""
        Me.NyX_Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NyX_Theme1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.NyX_Theme1.Image = Nothing
        Me.NyX_Theme1.Location = New System.Drawing.Point(0, 0)
        Me.NyX_Theme1.Margin = New System.Windows.Forms.Padding(4)
        Me.NyX_Theme1.Movable = True
        Me.NyX_Theme1.Name = "NyX_Theme1"
        Me.NyX_Theme1.NoRounding = False
        Me.NyX_Theme1.Sizable = False
        Me.NyX_Theme1.Size = New System.Drawing.Size(260, 147)
        Me.NyX_Theme1.SmartBounds = True
        Me.NyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NyX_Theme1.TabIndex = 0
        Me.NyX_Theme1.Text = "Last Step"
        Me.NyX_Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.Transparent = False
        '
        'NyX_Button1
        '
        Me.NyX_Button1.Colors = New Mega_virus_maker_2._0.Bloom(-1) {}
        Me.NyX_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NyX_Button1.Customization = ""
        Me.NyX_Button1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.NyX_Button1.Image = Nothing
        Me.NyX_Button1.Location = New System.Drawing.Point(178, 2)
        Me.NyX_Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.NyX_Button1.Name = "NyX_Button1"
        Me.NyX_Button1.NoRounding = False
        Me.NyX_Button1.Size = New System.Drawing.Size(75, 20)
        Me.NyX_Button1.TabIndex = 11
        Me.NyX_Button1.Text = "Set"
        Me.NyX_Button1.Transparent = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.No)
        Me.GroupBox2.Controls.Add(Me.Yes)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(21, 33)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(223, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Require administrator privileges to run"
        '
        'No
        '
        Me.No.AutoSize = True
        Me.No.Checked = True
        Me.No.ForeColor = System.Drawing.Color.Red
        Me.No.Location = New System.Drawing.Point(77, 68)
        Me.No.Margin = New System.Windows.Forms.Padding(4)
        Me.No.Name = "No"
        Me.No.Size = New System.Drawing.Size(41, 19)
        Me.No.TabIndex = 7
        Me.No.TabStop = True
        Me.No.Text = "No"
        Me.ToolTip1.SetToolTip(Me.No, "works normally but may fail in some tasks")
        Me.No.UseVisualStyleBackColor = True
        '
        'Yes
        '
        Me.Yes.AutoSize = True
        Me.Yes.ForeColor = System.Drawing.Color.Red
        Me.Yes.Location = New System.Drawing.Point(77, 37)
        Me.Yes.Margin = New System.Windows.Forms.Padding(4)
        Me.Yes.Name = "Yes"
        Me.Yes.Size = New System.Drawing.Size(45, 19)
        Me.Yes.TabIndex = 6
        Me.Yes.TabStop = True
        Me.Yes.Text = "Yes"
        Me.ToolTip1.SetToolTip(Me.Yes, "Recommended for better control and less failure specially for Windows 10 ")
        Me.Yes.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ShowAlways = True
        '
        'LastStep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 147)
        Me.Controls.Add(Me.NyX_Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LastStep"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LastStep"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NyX_Theme1 As Mega_virus_maker_2._0.NYX_Theme
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents No As System.Windows.Forms.RadioButton
    Friend WithEvents Yes As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents NyX_Button1 As Mega_virus_maker_2._0.NYX_Button
End Class
