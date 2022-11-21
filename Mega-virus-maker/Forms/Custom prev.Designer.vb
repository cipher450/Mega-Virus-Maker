<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Custom_prev
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
        Me.NyX_Theme1 = New Mega_virus_maker_2._0.NYX_Theme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NyX_Button5 = New Mega_virus_maker_2._0.NYX_Button()
        Me.NyX_Theme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NyX_Theme1
        '
        Me.NyX_Theme1.Animated = True
        Me.NyX_Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NyX_Theme1.Colors = New Mega_virus_maker_2._0.Bloom(-1) {}
        Me.NyX_Theme1.Controls.Add(Me.Label1)
        Me.NyX_Theme1.Controls.Add(Me.ComboBox1)
        Me.NyX_Theme1.Controls.Add(Me.NyX_Button5)
        Me.NyX_Theme1.Customization = ""
        Me.NyX_Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NyX_Theme1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.NyX_Theme1.Image = Nothing
        Me.NyX_Theme1.Location = New System.Drawing.Point(0, 0)
        Me.NyX_Theme1.Movable = True
        Me.NyX_Theme1.Name = "NyX_Theme1"
        Me.NyX_Theme1.NoRounding = False
        Me.NyX_Theme1.Sizable = False
        Me.NyX_Theme1.Size = New System.Drawing.Size(254, 105)
        Me.NyX_Theme1.SmartBounds = True
        Me.NyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NyX_Theme1.TabIndex = 0
        Me.NyX_Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(28, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "select a programme or set one:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Red
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"devenv", "CCleaner64", "VCDDaemon", "IDMan", "javaw", "vlc", "wmplayer", "qbittorrent", "notepad++", "notepad", "MSIAfterburner", "RAVCpl64", "cheatengine-i386", "wordpad", "Foxit Reader"})
        Me.ComboBox1.Location = New System.Drawing.Point(54, 62)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(137, 23)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.Text = "wmplayer"
        '
        'NyX_Button5
        '
        Me.NyX_Button5.Colors = New Mega_virus_maker_2._0.Bloom(-1) {}
        Me.NyX_Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NyX_Button5.Customization = ""
        Me.NyX_Button5.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.NyX_Button5.Image = Nothing
        Me.NyX_Button5.Location = New System.Drawing.Point(158, 4)
        Me.NyX_Button5.Name = "NyX_Button5"
        Me.NyX_Button5.NoRounding = False
        Me.NyX_Button5.Size = New System.Drawing.Size(92, 17)
        Me.NyX_Button5.TabIndex = 12
        Me.NyX_Button5.Text = "Set"
        Me.NyX_Button5.Transparent = False
        '
        'Custom_prev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 105)
        Me.Controls.Add(Me.NyX_Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Custom_prev"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom_prev"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.ResumeLayout(False)
        Me.NyX_Theme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NyX_Theme1 As Mega_virus_maker_2._0.NYX_Theme
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents NyX_Button5 As Mega_virus_maker_2._0.NYX_Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
