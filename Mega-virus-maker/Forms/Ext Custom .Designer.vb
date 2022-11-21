<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ext_Custom
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
        Me.NyX_Button1 = New Mega_virus_maker_2._0.NYX_Button()
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
        Me.NyX_Theme1.Controls.Add(Me.NyX_Button1)
        Me.NyX_Theme1.Customization = ""
        Me.NyX_Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NyX_Theme1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.NyX_Theme1.Image = Nothing
        Me.NyX_Theme1.Location = New System.Drawing.Point(0, 0)
        Me.NyX_Theme1.Movable = True
        Me.NyX_Theme1.Name = "NyX_Theme1"
        Me.NyX_Theme1.NoRounding = False
        Me.NyX_Theme1.Sizable = True
        Me.NyX_Theme1.Size = New System.Drawing.Size(258, 107)
        Me.NyX_Theme1.SmartBounds = True
        Me.NyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.NyX_Theme1.TabIndex = 1
        Me.NyX_Theme1.Text = "Custom extension"
        Me.NyX_Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(19, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Extension :"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Name", Global.Mega_virus_maker_2._0.My.MySettings.Default, "Ext", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.ForeColor = System.Drawing.Color.Red
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Text Files :", ".DOC", ".DOCX", ".LOG", ".MSG", ".RTF", ".TXT", "Data Files :", ".DAT", ".PPS", ".XML", "Audio Files :", ".WMA", ".WAV", ".MP3", ".MPA", ".M4A", ".M3U", ".AIF", "Video Files  :", ".3G2", ".ASF", ".AVI", ".FLV", ".M4V", ".MOV", ".MP4", ".MPG", ".RM", ".SRT", ".SWF", ".VOB", ".WMV", "3D Image Files :", ".3DM", ".3DS", ".MAX", ".OBJ", "Image Files :", ".BMP", ".DDS", ".GIF", ".HEIC", ".JPG", ".PNG", ".PSD", ".PSPIMAGE", ".TGA", ".THM", ".TIF", ".TIFF", ".YUV", "Vector Image Files :", ".AI", ".EPS", ".SVG", "Page Layout Files :", ".INDD", ".PCT", ".PDF", "Executable Files :", ".APK", ".APP", ".BAT", ".CGI", ".COM", ".EXE", ".GADGET", ".JAR", ".WSF", "Compressed Files :", ".7Z", ".CBR", ".DEB", ".GZ", ".PKG", ".RAR", ".RPM", ".SITX", ".TAR.GZ", ".ZIP", ".ZIPX", "Ohter :", ".DLL", ".ICO", ".SYS", ".LNK", ".INI", ".BIN", ".C", ".VB", ".VBS", ".BAT", ".PY", ".PHP", ".HTML", ".BAK", ".TORRENT", ".MSI"})
        Me.ComboBox1.Location = New System.Drawing.Point(63, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(139, 23)
        Me.ComboBox1.TabIndex = 2
        '
        'NyX_Button1
        '
        Me.NyX_Button1.Colors = New Mega_virus_maker_2._0.Bloom(-1) {}
        Me.NyX_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NyX_Button1.Customization = ""
        Me.NyX_Button1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.NyX_Button1.Image = Nothing
        Me.NyX_Button1.Location = New System.Drawing.Point(4, 4)
        Me.NyX_Button1.Name = "NyX_Button1"
        Me.NyX_Button1.NoRounding = False
        Me.NyX_Button1.Size = New System.Drawing.Size(74, 15)
        Me.NyX_Button1.TabIndex = 0
        Me.NyX_Button1.Text = "Set"
        Me.NyX_Button1.Transparent = False
        '
        'Ext_Custom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 107)
        Me.Controls.Add(Me.NyX_Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ext_Custom"
        Me.Text = "Ext_Custom"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.ResumeLayout(False)
        Me.NyX_Theme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NyX_Theme1 As Mega_virus_maker_2._0.NYX_Theme
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents NyX_Button1 As Mega_virus_maker_2._0.NYX_Button
End Class
