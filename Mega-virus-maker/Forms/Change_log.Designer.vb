<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_log
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
        Me.NyX_Button1 = New Mega_virus_maker_2._0.NYX_Button()
        Me.stat = New System.Windows.Forms.TextBox()
        Me.NyX_Theme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NyX_Theme1
        '
        Me.NyX_Theme1.Animated = False
        Me.NyX_Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NyX_Theme1.Colors = New Mega_virus_maker_2._0.Bloom(-1) {}
        Me.NyX_Theme1.Controls.Add(Me.NyX_Button1)
        Me.NyX_Theme1.Controls.Add(Me.stat)
        Me.NyX_Theme1.Customization = ""
        Me.NyX_Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NyX_Theme1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.NyX_Theme1.Image = Nothing
        Me.NyX_Theme1.Location = New System.Drawing.Point(0, 0)
        Me.NyX_Theme1.Movable = True
        Me.NyX_Theme1.Name = "NyX_Theme1"
        Me.NyX_Theme1.NoRounding = False
        Me.NyX_Theme1.Sizable = False
        Me.NyX_Theme1.Size = New System.Drawing.Size(839, 405)
        Me.NyX_Theme1.SmartBounds = True
        Me.NyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.NyX_Theme1.TabIndex = 0
        Me.NyX_Theme1.Text = "Change log"
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
        Me.NyX_Button1.Location = New System.Drawing.Point(730, 3)
        Me.NyX_Button1.Name = "NyX_Button1"
        Me.NyX_Button1.NoRounding = False
        Me.NyX_Button1.Size = New System.Drawing.Size(105, 16)
        Me.NyX_Button1.TabIndex = 108
        Me.NyX_Button1.Text = "Close"
        Me.NyX_Button1.Transparent = False
        '
        'stat
        '
        Me.stat.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.stat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.stat.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.stat.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stat.ForeColor = System.Drawing.Color.Red
        Me.stat.Location = New System.Drawing.Point(0, 28)
        Me.stat.Multiline = True
        Me.stat.Name = "stat"
        Me.stat.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.stat.Size = New System.Drawing.Size(839, 377)
        Me.stat.TabIndex = 107
        '
        'Change_log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 405)
        Me.Controls.Add(Me.NyX_Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Change_log"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Change log"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.ResumeLayout(False)
        Me.NyX_Theme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NyX_Theme1 As Mega_virus_maker_2._0.NYX_Theme
    Friend WithEvents NyX_Button1 As Mega_virus_maker_2._0.NYX_Button
    Friend WithEvents stat As System.Windows.Forms.TextBox
End Class
