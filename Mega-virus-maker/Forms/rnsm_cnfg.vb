Public Class rnsm_cnfg

    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        Form1.BTC = RC4Encrypt(CrystalClearTextBox1.Text, "bCoDkZ3QTETLNnOzpT4e")
        Form1.rnsm_key = RC4Encrypt(CrystalClearTextBox2.Text, "bCoDkZ3QTETLNnOzpT4e")
        Form1.amount = RC4Encrypt(MaskedTextBox1.Text, "bCoDkZ3QTETLNnOzpT4e")
        Me.Hide()
    End Sub

    Private Sub NyX_Button2_Click(sender As Object, e As EventArgs) Handles NyX_Button2.Click
        CrystalClearTextBox2.Text = Randome(50)
    End Sub

    Private Sub CrystalClearTextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class