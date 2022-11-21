Imports System.Runtime.InteropServices
Public Class About

#Region "pic_fx"

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Image = My.Resources._25232


    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources._25231
    End Sub

#End Region

    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stat.Text = stat.Text.Replace("<ahsh513>", hash_generator("sha512", Application.ExecutablePath))
    End Sub

    Private Sub About_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For FadeOut = 90 To 10 Step -10
            Me.Opacity = FadeOut / 100
            Me.Refresh()
            Threading.Thread.Sleep(40)
        Next
    End Sub


    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetText(stat.Text)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Try
            Dim k As New SaveFileDialog
            k.Filter = "text file|*.txt"
            If k.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(k.FileName, stat.Text, False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub




    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://github.com/cipher450")
    End Sub


    Private Sub Stat_TextChanged(sender As Object, e As EventArgs) Handles stat.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub
End Class