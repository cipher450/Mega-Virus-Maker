Public Class Ext_Custom

    Private Sub NyX_Theme1_Click(sender As Object, e As EventArgs) Handles NyX_Theme1.Click

    End Sub

    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        Form1.dlt_custo_ext = ComboBox1.Text
        Form1.NyX_CheckBox71.Text = "Delete " & ComboBox1.Text & " files"
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        With ComboBox1
            '
            If .Text = "Ohter :" Or .Text = "Compressed Files :" Or .Text = "Executable Files :" Or .Text = "Page Layout Files :" Or .Text = "Text Files :" Or .Text = "Data Files :" Or .Text = "Audio Files :" Or .Text = "Video Files  :" _
                Or .Text = "3D Image Files :" Or .Text = "Vector Image Files :" Or .Text = "Image Files :" Or .Text = "" Then

                ComboBox1.Text = ".RAR"

            End If

        End With
    End Sub

    Private Sub Custom_Exts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class