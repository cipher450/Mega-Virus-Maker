Public Class Cur

    Private Sub Cur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = My.Computer.Screen.Bounds.Size.Height
        Me.Width = My.Computer.Screen.Bounds.Size.Width
        Windows.Forms.Cursor.Hide()
    End Sub
End Class