<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Daynight
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.NyX_Button12 = New Mega_virus_maker_2._0.NYX_Button()
        Me.NyX_Theme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NyX_Theme1
        '
        Me.NyX_Theme1.Animated = True
        Me.NyX_Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NyX_Theme1.Colors = New Mega_virus_maker_2._0.Bloom(-1) {}
        Me.NyX_Theme1.Controls.Add(Me.NyX_Button1)
        Me.NyX_Theme1.Controls.Add(Me.Label18)
        Me.NyX_Theme1.Controls.Add(Me.MaskedTextBox1)
        Me.NyX_Theme1.Controls.Add(Me.NyX_Button12)
        Me.NyX_Theme1.Customization = ""
        Me.NyX_Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NyX_Theme1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.NyX_Theme1.Image = Nothing
        Me.NyX_Theme1.Location = New System.Drawing.Point(0, 0)
        Me.NyX_Theme1.Movable = True
        Me.NyX_Theme1.Name = "NyX_Theme1"
        Me.NyX_Theme1.NoRounding = False
        Me.NyX_Theme1.Sizable = False
        Me.NyX_Theme1.Size = New System.Drawing.Size(238, 96)
        Me.NyX_Theme1.SmartBounds = True
        Me.NyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NyX_Theme1.TabIndex = 0
        Me.NyX_Theme1.Text = "Start date"
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
        Me.NyX_Button1.Location = New System.Drawing.Point(9, 5)
        Me.NyX_Button1.Name = "NyX_Button1"
        Me.NyX_Button1.NoRounding = False
        Me.NyX_Button1.Size = New System.Drawing.Size(19, 17)
        Me.NyX_Button1.TabIndex = 23
        Me.NyX_Button1.Text = "!"
        Me.NyX_Button1.Transparent = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(18, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 15)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Date :"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.Black
        Me.MaskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MaskedTextBox1.ForeColor = System.Drawing.Color.Red
        Me.MaskedTextBox1.Location = New System.Drawing.Point(48, 53)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(148, 21)
        Me.MaskedTextBox1.TabIndex = 21
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'NyX_Button12
        '
        Me.NyX_Button12.Colors = New Mega_virus_maker_2._0.Bloom(-1) {}
        Me.NyX_Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NyX_Button12.Customization = ""
        Me.NyX_Button12.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.NyX_Button12.Image = Nothing
        Me.NyX_Button12.Location = New System.Drawing.Point(166, 3)
        Me.NyX_Button12.Name = "NyX_Button12"
        Me.NyX_Button12.NoRounding = False
        Me.NyX_Button12.Size = New System.Drawing.Size(69, 17)
        Me.NyX_Button12.TabIndex = 20
        Me.NyX_Button12.Text = "Set"
        Me.NyX_Button12.Transparent = False
        '
        'Daynight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 96)
        Me.Controls.Add(Me.NyX_Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Daynight"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daynight"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.ResumeLayout(False)
        Me.NyX_Theme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NyX_Theme1 As Mega_virus_maker_2._0.NYX_Theme
    Friend WithEvents NyX_Button12 As Mega_virus_maker_2._0.NYX_Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents NyX_Button1 As Mega_virus_maker_2._0.NYX_Button
End Class
