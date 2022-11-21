Public Class infi_scrn

    Private Sub infi_scrn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Color.LightBlue
        Me.BackColor = Color.LightBlue
        Me.Height = My.Computer.Screen.Bounds.Size.Height
        Me.Width = My.Computer.Screen.Bounds.Size.Width
     
        Dim M = New Threading.Thread(AddressOf j)
        M.IsBackground = True
        M.Start()
    End Sub
    Sub j()
        Dim j As New Boolean
        j = False
        Do Until j = True
            PictureBox1.Image = takescreenshot()
        Loop

    End Sub


    Private Sub infi_scrn_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = False
    End Sub
End Class