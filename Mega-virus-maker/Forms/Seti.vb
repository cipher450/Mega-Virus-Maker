Imports System.Net

Public Class Seti
    Public nowversion As String = Application.ProductVersion
    Dim mvm, stub As Boolean
    Dim Stub_path As String = Application.StartupPath & "\Stub.exe"
   
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
    
    Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
        If CheckForInternetConnection() = True Then
            Dim trd As New Threading.Thread(AddressOf chekup)
            trd.IsBackground = True
            trd.Start()
        Else
            MsgBox("There is no internet Connection ", MsgBoxStyle.Critical, "no internet Connection")
        End If
      

    End Sub
    Public Sub chekup()
        Porgbar.Value = 10

        Dim appver1 As String = New System.Net.WebClient().DownloadString("http://pastebin.com/raw/20QTa8ri")
        Porgbar.Value = 15
        Dim Stubver1 As String = New System.Net.WebClient().DownloadString("http://pastebin.com/raw/srr5aVhT")
        Porgbar.Value = 20
        If Appver.Text = appver1 Then
            Pic_mvm.Image = My.Resources._1493697422_Tick_Mark_Dark
            Pic_mvm.Cursor = Cursors.Arrow
            Porgbar.Value = 25
            mvm = False
        Else
            Pic_mvm.Image = My.Resources.icons8_available_updates_96
            Pic_mvm.Cursor = Cursors.Hand
            Porgbar.Value = 30
            mvm = True
        End If
        Porgbar.Value = 40
        If Stbver.Text = Stubver1 Then
            Pic_stb.Image = My.Resources._1493697422_Tick_Mark_Dark
            Pic_stb.Cursor = Cursors.Arrow
            Porgbar.Value = 60
            stub = False
        Else
            Pic_stb.Image = My.Resources.icons8_available_updates_96
            Pic_stb.Cursor = Cursors.Hand
            Porgbar.Value = 60
            stub = True
        End If
        Try
            Label4.Text = New System.Net.WebClient().DownloadString("http://pastebin.com/raw/a9ar3Ja6")
        Catch ex As Exception
            Label4.Text = "?/?"
        End Try
        If Stbver.Text = Stubver1 And Appver.Text = appver1 Then
            Porgbar.Value = 100
            MsgBox("no update is available", MsgBoxStyle.Information)

            Porgbar.Value = 0
        Else
            Porgbar.Value = 100

            MsgBox("an update is available ! click the icon to start update", MsgBoxStyle.Information)

            Porgbar.Value = 0
        End If

    End Sub
    Private Function GetFileVersionInfo(ByVal filename As String) As String
        Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion).Major & "." & Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion).Minor & "." & Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion).Revision
    End Function
    
    Private Sub Seti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TotalVir.Text = Form1.cb
            Stbver.Text = GetFileVersionInfo(Stub_path) & ".0"

            Appver.Text = nowversion
        Catch ex As Exception
        End Try
      
    End Sub


    Private Sub NyX_Button4_Click(sender As Object, e As EventArgs) Handles NyX_Button4.Click
        Dim j As String = Readit()
        If CheckBox1.Checked = True Then
            My.Settings.AppPass = passwordEncryptSHA(TextBox1.Text)
            TextBox1.Enabled = False
            NyX_Button4.Enabled = False
        Else
            TextBox1.Enabled = True
            NyX_Button4.Enabled = True
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim j As String = Readit()
        If CheckBox1.Checked = True Then
            Writeit("lock")
        Else
            j = j.Replace("lock", "")
            Writeit(j)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            Label4.Text = New System.Net.WebClient().DownloadString("http://pastebin.com/raw/a9ar3Ja6")
        Catch ex As Exception
            Label4.Text = "?/?"
        End Try
    End Sub
    Dim err As String
    Function DownloadFile(ByRef URL As String, ByRef DestinationPath As String) As Boolean
        Try
            My.Computer.Network.DownloadFile(URL, DestinationPath, vbNullString, vbNullString, True, 5000, True)
            Return True
        Catch ex As Exception
            Return False
            err = ex.Message
        End Try

    End Function
    Private Sub Pic_mvm_Click(sender As Object, e As EventArgs) Handles Pic_mvm.Click
        Try
            If mvm = True Then
                If MessageBox.Show("Do you want download the update ?", "an update is available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim pastbin_url As String = New System.Net.WebClient().DownloadString("https://pastebin.com/raw/jek5RpCc")
                    Dim tempfile As String = IO.Path.GetTempPath & "\mvm.exe"
                    If IO.File.Exists(tempfile) = True Then
                        IO.File.Delete(tempfile)
                    End If
                    'Application.StartupPath & "\Mega Virus Maker.exe"
                    DownloadFile(pastbin_url, tempfile)
                    If IO.File.Exists(Application.StartupPath & "\Updater.exe") = False Then
                        My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Updater.exe", My.Resources.Updater, False)
                    End If
                    Process.Start(Application.StartupPath & "\Updater.exe")
                    End
                End If
            Else
                MsgBox("Your version is up to date", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub Pic_stb_Click(sender As Object, e As EventArgs) Handles Pic_stb.Click
        Try
            If stub = True Then
                If MessageBox.Show("Do you want download the update ?", "an update is available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim pastbin_url As String = New System.Net.WebClient().DownloadString("https://pastebin.com/raw/jek5RpCc")
                    Dim tempfile As String = IO.Path.GetTempPath & "\mvm.exe"
                    If IO.File.Exists(tempfile) = True Then
                        IO.File.Delete(tempfile)
                    End If
                    'Application.StartupPath & "\Mega Virus Maker.exe"
                    DownloadFile(pastbin_url, tempfile)
                    If IO.File.Exists(Application.StartupPath & "\Updater.exe") = False Then
                        My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Updater.exe", My.Resources.Updater, False)
                    End If
                    Process.Start(Application.StartupPath & "\Updater.exe")
                    End
                End If
            Else
                MsgBox("Your version is up to date", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub


   
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Dim j As String = Readit()
        If CheckBox4.Checked = True Then
            Writeit("Chekup")
        Else
            j = j.Replace("Chekup", "")
            Writeit(j)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        MsgBox("Pas encore fini desoler les français XD", MsgBoxStyle.Exclamation)

    End Sub

    Private Sub NyX_Button2_Click(sender As Object, e As EventArgs) Handles NyX_Button2.Click
        IO.File.Delete(Form1.setpath)
        My.Settings.lock = False
        My.Settings.AppPass = ""
        My.Settings.Chekstrt = False
        My.Settings.Virusname = "Virus"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub CrystalClearTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CrystalClearTabControl1.SelectedIndexChanged

    End Sub
End Class