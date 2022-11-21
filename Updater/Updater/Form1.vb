Imports System.IO
Public Class Form1
    Dim mvmpath As String = Application.StartupPath & "\Mega virus maker.exe"
    Dim tempfile As String = IO.Path.GetTempPath & "\mvm.exe"
    Dim Stubs_Folder As String = Application.StartupPath & "\Stub\"
    Dim l As String = vbNewLine
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If File.Exists(tempfile) = True Then
                Threading.Thread.Sleep(10000)
                If Directory.Exists(Stubs_Folder) = True Then
                    For Each f As String In Directory.GetFiles(Stubs_Folder)
                        File.Delete(f)
                    Next

                End If
                File.Delete(mvmpath)
                File.Move(tempfile, mvmpath)
                MsgBox("Update successfully done", MsgBoxStyle.Information)
                Process.Start(mvmpath)
                File.Delete(tempfile)
                End
            Else
                End
            End If

        Catch ex As Exception
            MsgBox("Error : " & ex.Message & l & l & "Here are some tips to solve the problem : " & l & "1-Try and restart all process with admin privileges" & l & "2-If you renamed Mega virus maker exe then rename it again to 'Mega virus maker.exe'" & l & "2-Go to " & tempfile & " and copy 'mvm.exe' to the mega virus maker path and replace 'Mega virus maker.exe' with 'mvm.exe' and rename it to 'Mega virus maker.exe' " & l & "4-if non of this works go to https://proxy-hacker.blogspot.com/p/mega-virus-maker.html and download it from three.", MsgBoxStyle.Critical)
            End
        End Try


    End Sub
End Class
