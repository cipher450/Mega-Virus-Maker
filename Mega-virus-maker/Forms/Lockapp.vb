Public Class Lockapp

    Private Sub NyX_Button2_Click(sender As Object, e As EventArgs) Handles NyX_Button2.Click
        If passwordEncryptSHA(CrystalClearTextBox1.Text) = My.Settings.AppPass Then
            Form1.Enabled = True
            Form1.WindowState = FormWindowState.Normal
            Me.Close()
        Else
            MsgBox("Wrong password !", MsgBoxStyle.Critical, "WHAT THE FUCK !")
            Form1.Timer1.Stop()
            Form1.Enabled = False
        End If
    End Sub

    Private Sub Lockapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Timer1.Stop()
        Form1.Enabled = False
    End Sub

    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        End
    End Sub
End Class