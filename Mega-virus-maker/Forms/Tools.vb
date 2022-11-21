Public Class Tools

    Sub dec()
        Try
            TextBox3.Text = RC4Decrypt(TextBox2.Text, TextBox1.Text)
        Catch ex As Exception
            TextBox3.Text = "error : " & ex.Message
            Exit Sub
        End Try

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If Not TextBox1.Text = "" Then
            Dim l = New Threading.Thread(AddressOf dec)
            l.IsBackground = True
            l.Start()
        End If

    End Sub

    Private Sub NyX_Button22_Click(sender As Object, e As EventArgs) Handles NyX_Button22.Click
        Me.Close()
    End Sub

    Private Sub Tools_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrystalClearTextBox1.Text = Form1.TextBox7.Text
    End Sub

    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        Shell("cmd.exe /C taskkill /f /im  " & CrystalClearTextBox1.Text & ".exe")
    End Sub
End Class