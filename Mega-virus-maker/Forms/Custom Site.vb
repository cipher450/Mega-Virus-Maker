
Public Class Custom_Site

    Private Sub NyX_Theme1_Click(sender As Object, e As EventArgs) Handles NyX_Theme1.Click

    End Sub

    Private Sub NyX_Button12_Click(sender As Object, e As EventArgs) Handles NyX_Button12.Click

        Form1.infi_website = NyX_CheckBox1.Checked
        Form1.sel_custo_site = TextBox7.Text
        Me.Hide()
    End Sub
End Class