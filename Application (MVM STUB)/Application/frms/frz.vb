Public Class frz

    Private Sub frz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = takescreenshot()
        Me.Height = My.Computer.Screen.Bounds.Size.Height
        Me.Width = My.Computer.Screen.Bounds.Size.Width
    End Sub

    Private Sub frz_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub
End Class