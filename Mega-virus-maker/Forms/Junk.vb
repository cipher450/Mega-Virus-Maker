Public Class Junk

    Private Sub CrystalClearTextBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles CrystalClearTextBox3.MouseMove


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) = False Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub NyX_Button2_Click(sender As Object, e As EventArgs) Handles NyX_Button2.Click
        Try
            CrystalClearTextBox3.Text = RandomString(TextBox1.Text, "", True, True, True, True, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            TextBox1.Text = "10000"
        End Try

    End Sub

    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        Form1.jnk_str = TextBox1.Text
        Me.Hide()
    End Sub
End Class