Public Class Ddos

  

    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        Form1.TCP = NyX_CheckBox1.Checked
        Form1.UDP = NyX_CheckBox2.Checked
        Form1.TARGET = CrystalClearTextBox1.Text
        Form1.PORT = CrystalClearTextBox2.Text
        Form1.syn = NyX_CheckBox3.Checked
        Form1.Packet = CrystalClearTextBox3.Text

        Me.Hide()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)

    End Sub

    Private Sub NyX_CheckBox1_CheckedChanged(sender As Object) Handles NyX_CheckBox1.CheckedChanged
        NyX_CheckBox2.Checked = False
        NyX_CheckBox1.Checked = True
        NyX_CheckBox3.Checked = False
        CrystalClearTextBox3.Visible = False
        Label2.Visible = False
        NyX_Button2.Visible = False
    End Sub

    Private Sub NyX_CheckBox2_CheckedChanged(sender As Object) Handles NyX_CheckBox2.CheckedChanged
        NyX_CheckBox2.Checked = True
        NyX_CheckBox1.Checked = False
        NyX_CheckBox3.Checked = False

        CrystalClearTextBox3.Visible = True
        Label2.Visible = True
        NyX_Button2.Visible = True

        NyX_Button2.Visible = NyX_CheckBox2.Checked
    End Sub

    


    Private Sub NyX_Button2_Click(sender As Object, e As EventArgs) Handles NyX_Button2.Click
        CrystalClearTextBox3.Text = Randome(200)

    End Sub

    Private Sub NyX_CheckBox3_CheckedChanged(sender As Object) Handles NyX_CheckBox3.CheckedChanged
        NyX_CheckBox2.Checked = False
        NyX_CheckBox1.Checked = False
        NyX_CheckBox3.Checked = True
        CrystalClearTextBox3.Visible = False
        Label2.Visible = False
        NyX_Button2.Visible = False
    End Sub
End Class