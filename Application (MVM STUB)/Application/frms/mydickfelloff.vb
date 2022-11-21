Public Class mydickfelloff
    Dim oldloc As New Point(0, 0)
    Dim oldcur As New Point(0, 0)
    Dim timer1 As New Timer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image.Save(IO.Path.GetTempPath & "\dagi.jpg")
        Timer2.Interval = 1 'every 2 millaseconds
        Timer2.Enabled = True
        UpdatePositions()

    End Sub

    Private Sub timer1_tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Location = oldloc - oldcur + System.Windows.Forms.Cursor.Position
        UpdatePositions()
    End Sub
    Private Sub UpdatePositions()
        oldloc = Me.Location
        oldcur = System.Windows.Forms.Cursor.Position
    End Sub
    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        Timer2.Start()
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Timer2.Start()
    End Sub

    Private Sub mydickfelloff_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

  
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class