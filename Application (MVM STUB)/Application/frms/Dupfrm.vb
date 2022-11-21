Public Class Dupfrm

    Private Sub Dupfrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim g As New Dupfrm
            g.ShowInTaskbar = False
            g.ShowIcon = False
           
            g.Show()
        End If
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            e.Cancel = True
            Dim g As New Dupfrm
            g.ShowInTaskbar = False
            g.ShowIcon = False

            g.Show()
        End If

        If e.CloseReason = CloseReason.FormOwnerClosing Then
            e.Cancel = True
            Dim g As New Dupfrm
            g.ShowInTaskbar = False
            g.ShowIcon = False

            g.Show()
        End If

        If e.CloseReason = CloseReason.WindowsShutDown Then
            e.Cancel = True
            Dim g As New Dupfrm
            g.ShowInTaskbar = False
            g.ShowIcon = False

            g.Show()
        End If

        
    End Sub

    Private Sub Dupfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim g As New Dupfrm
        g.ShowInTaskbar = False
        g.ShowIcon = False
        g.Show()
    End Sub
End Class