Public Class dwnrun

    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        CrystalClearTextBox1.Text = Clipboard.GetText
    End Sub

    Private Sub CrystalClearTextBox1_TextChanged(sender As Object, e As EventArgs) Handles CrystalClearTextBox1.TextChanged
        If CrystalClearTextBox1.Text.Contains("pastebin") Then
            If Not CrystalClearTextBox1.Text.Contains("raw") Then
                Label2.Text = "make sure that you put a raw link to your pastbin file" & vbNewLine & vbNewLine & "Example : " & "https://pastebin.com/raw/Hsg41KBK"
            End If
        End If

    End Sub

    Private Sub NyX_Button2_Click(sender As Object, e As EventArgs) Handles NyX_Button2.Click
        Me.Close()
    End Sub
End Class