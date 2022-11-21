Public Class frm3

    Private Sub frm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NyX_Button5_Click(sender As Object, e As EventArgs) Handles NyX_Button5.Click
        Form1.D_selectdProc = ComboBox1.Text
        Me.Hide()
    End Sub
End Class