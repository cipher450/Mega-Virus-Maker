Public Class Wendy

    Private Sub Wendy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If MessageBox.Show("flashy colors will be displayed do you want to continue ", "seizure warning ", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Me.Height = My.Computer.Screen.Bounds.Size.Height
                Me.Width = My.Computer.Screen.Bounds.Size.Width
            Else
                Me.Close()
            End If
        Catch ex As Exception

        End Try

      
    End Sub

    Private Sub Wendy_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub red_Tick(sender As Object, e As EventArgs) Handles red.Tick
        On Error Resume Next
        Dim s As New Random


        Dim i1 As Integer = s.Next(255)
        Dim i2 As Integer = s.Next(255)

        Dim i3 As Integer = s.Next(255)


        Me.BackColor = Color.FromArgb(i1, i3, i2)
    End Sub
End Class