Public Class lnch

    Private Sub lnch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub

    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        If NyX_CheckBox1.Checked = True Then
            Writeit("lice")
            Form1.Show()
            Me.Close()
        Else
            End
        End If
    End Sub

    Private Sub NyX_Button2_Click(sender As Object, e As EventArgs) Handles NyX_Button2.Click
        End
    End Sub
End Class