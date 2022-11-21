<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        Me.NyX_Theme1 = New Mega_virus_maker_2._0.NYX_Theme()
        Me.NyX_Button1 = New Mega_virus_maker_2._0.NYX_Button()
        Me.stat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NyX_Theme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NyX_Theme1
        '
        Me.NyX_Theme1.Animated = True
        Me.NyX_Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NyX_Theme1.Colors = New Mega_virus_maker_2._0.Bloom(-1) {}
        Me.NyX_Theme1.Controls.Add(Me.NyX_Button1)
        Me.NyX_Theme1.Controls.Add(Me.stat)
        Me.NyX_Theme1.Controls.Add(Me.Label2)
        Me.NyX_Theme1.Controls.Add(Me.Label1)
        Me.NyX_Theme1.Controls.Add(Me.PictureBox1)
        Me.NyX_Theme1.Customization = ""
        Me.NyX_Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NyX_Theme1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.NyX_Theme1.Image = Nothing
        Me.NyX_Theme1.Location = New System.Drawing.Point(0, 0)
        Me.NyX_Theme1.Movable = True
        Me.NyX_Theme1.Name = "NyX_Theme1"
        Me.NyX_Theme1.NoRounding = False
        Me.NyX_Theme1.Sizable = False
        Me.NyX_Theme1.Size = New System.Drawing.Size(540, 233)
        Me.NyX_Theme1.SmartBounds = True
        Me.NyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NyX_Theme1.TabIndex = 0
        Me.NyX_Theme1.Text = "Loading"
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
        Me.NyX_Button1.Location = New System.Drawing.Point(418, 190)
        Me.NyX_Button1.Name = "NyX_Button1"
        Me.NyX_Button1.NoRounding = False
        Me.NyX_Button1.Size = New System.Drawing.Size(100, 25)
        Me.NyX_Button1.TabIndex = 17
        Me.NyX_Button1.Text = "Ok"
        Me.NyX_Button1.Transparent = False
        '
        'stat
        '
        Me.stat.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.stat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.stat.Font = New System.Drawing.Font("NSimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stat.ForeColor = System.Drawing.Color.Red
        Me.stat.Location = New System.Drawing.Point(257, 37)
        Me.stat.Multiline = True
        Me.stat.Name = "stat"
        Me.stat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.stat.Size = New System.Drawing.Size(261, 149)
        Me.stat.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(100, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "please wait..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(33, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "The creation of your vitus is in progress"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(63, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 233)
        Me.Controls.Add(Me.NyX_Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loading"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.ResumeLayout(False)
        Me.NyX_Theme1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NyX_Theme1 As Mega_virus_maker_2._0.NYX_Theme
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents stat As System.Windows.Forms.TextBox
    Friend WithEvents NyX_Button1 As Mega_virus_maker_2._0.NYX_Button
End Class
