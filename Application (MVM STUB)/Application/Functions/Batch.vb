Module Batch
    Public Function LuncheProc(pth As String)

        Dim My_Process As New Process()
        Dim My_Process_Info As New ProcessStartInfo()

        My_Process_Info.FileName = pth
        My_Process_Info.CreateNoWindow = True
        My_Process_Info.UseShellExecute = False
        My_Process.EnableRaisingEvents = True
        My_Process.StartInfo = My_Process_Info
        My_Process.Start()

    End Function
End Module
