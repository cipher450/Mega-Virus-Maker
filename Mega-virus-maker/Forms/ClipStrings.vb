Public Class ClipStrings

    Private Sub NyX_Theme1_Click(sender As Object, e As EventArgs) Handles NyX_Theme1.Click

    End Sub

    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        Form1.set_clip_text = CLP_TEXT.Text
        Me.Hide()
    End Sub
End Class