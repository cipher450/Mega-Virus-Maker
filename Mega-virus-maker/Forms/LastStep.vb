Imports System.IO
Public Class LastStep
    Dim Stubs_Folder As String = Application.StartupPath & "\Stub\"

    Sub chekFilesanddir()
        If Directory.Exists(Stubs_Folder) = False Then
            Directory.CreateDirectory(Stubs_Folder)
            File.WriteAllBytes(Stubs_Folder & "Stub_4Y.exe", My.Resources.Stub_4Y)
            File.WriteAllBytes(Stubs_Folder & "Stub_4N.exe", My.Resources.Stub_4N)
        Else
            If File.Exists(Stubs_Folder & "Stub_4Y.exe") = False Then
                File.WriteAllBytes(Stubs_Folder & "Stub_4Y.exe", My.Resources.Stub_4Y)
            End If
            If File.Exists(Stubs_Folder & "Stub_4N.exe") = False Then
                File.WriteAllBytes(Stubs_Folder & "Stub_4N.exe", My.Resources.Stub_4N)
            End If
        End If
    End Sub

    Private Sub NyX_Button1_Click_1(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        Dim o = New Threading.Thread(AddressOf chekFilesanddir)
        o.IsBackground = True
        o.Priority = Threading.ThreadPriority.Highest
        o.Start()
        Do Until o.IsAlive = False

        Loop
        If Yes.Checked = True Then
            Form1.Stubpath = Stubs_Folder & "Stub_4Y.exe"
            Form1.stat.AppendText(".NET Framwork : 4.0" & vbNewLine & vbNewLine)
            Form1.stat.AppendText("Require administrator privileges to run : Yes" & vbNewLine & vbNewLine)
        End If
        If No.Checked = True Then
            Form1.Stubpath = Stubs_Folder & "Stub_4N.exe"
            Form1.stat.AppendText(".NET Framwork : 4.0" & vbNewLine & vbNewLine)
            Form1.stat.AppendText("Require administrator privileges to run : No" & vbNewLine & vbNewLine)
        End If
        Form1.doit()
        Me.Close()
    End Sub

    Private Sub LastStep_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class