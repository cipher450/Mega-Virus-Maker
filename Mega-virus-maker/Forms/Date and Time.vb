Public Class Date_and_Time

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub
    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub

    Private Sub NyX_Button5_Click(sender As Object, e As EventArgs) Handles NyX_Button5.Click
        Form1.S_date = MaskedTextBox1.Text
        Form1.S_time = MaskedTextBox2.Text
        Me.Hide()
    End Sub

    Private Sub NyX_Theme1_Click(sender As Object, e As EventArgs) Handles NyX_Theme1.Click

    End Sub
End Class