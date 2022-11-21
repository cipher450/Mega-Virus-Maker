Imports System.IO
Imports System.Security.Cryptography
Imports System.Text


Module fnc
    Function hash_generator(ByVal hash_type As String, ByVal file_name As String)

        ' On déclare la variable : hash
        Dim hash
        If hash_type.ToLower = "md5" Then
            ' Initialise un objet de hash : md5
            hash = MD5.Create
        ElseIf hash_type.ToLower = "sha1" Then
            ' Initialise un objet de hash : SHA-1
            hash = SHA1.Create()
        ElseIf hash_type.ToLower = "sha256" Then
            ' Initialise un objet de hash : SHA-256
            hash = SHA256.Create()
        ElseIf hash_type.ToLower = "sha512" Then
            hash = SHA512.Create()
        ElseIf hash_type.ToLower = "sha384" Then
            hash = SHA384.Create()
        Else
            MsgBox("Type de hash inconnu : " & hash_type, MsgBoxStyle.Critical)
            Return "Error"
        End If
        ' On déclare une variable qui sera un tableau de bytes (octets)
        Dim hashValue() As Byte

        ' On crée un FileStream pour le fichier passé en paramètre

        Dim fileStream As FileStream = File.OpenRead(file_name)
        ' On positionne le curseur au début du stream
        fileStream.Position = 0
        ' On calcule le hash du fichier
        hashValue = hash.ComputeHash(fileStream)
        ' On convertit le tableau d'octets (bytes) en hexadécimal pour qu'on puisse le lire facilement
        Dim hash_hex = PrintByteArray(hashValue)

        ' On ferme le fichier ouvert
        fileStream.Close()

        ' On retourne le hash
        Return hash_hex

    End Function
    Public Function passwordEncryptSHA(ByVal password As String) As String
        Dim sha As New SHA1CryptoServiceProvider ' declare sha as a new SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte ' and here is a byte variable

        bytesToHash = System.Text.Encoding.ASCII.GetBytes(password) ' covert the password into ASCII code

        bytesToHash = sha.ComputeHash(bytesToHash) ' this is where the magic starts and the encryption begins

        Dim encPassword As String = ""

        For Each b As Byte In bytesToHash
            encPassword += b.ToString("x2")
        Next

        Return encPassword ' boom there goes the encrypted password!

    End Function
    Public Function Readit() As String
        Dim rd As New StreamReader(Form1.setpath)
        Readit = rd.ReadToEnd
        rd.Close()
        Return Readit
    End Function
    Public Function Writeit(ByVal str) As String
        My.Computer.FileSystem.WriteAllText(Form1.setpath, str, True)
    End Function
    Public Function Randome(ByVal lenght As Integer) As String
        Randomize()
        Dim b() As Char
        Dim s As New System.Text.StringBuilder("")
        b = "azertyuioopqsdfghjklmwxcvbn123456789‚ƒ„…†‡ˆ‰Š’•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹ºÂÃÄÅÆÇÈÉÊÒÓÔÕÖ×ØÙÚâãäåæçèéêòóôõö÷øùúÿÚ".ToCharArray()
        For i As Integer = 1 To lenght
            Randomize()
            Dim z As Integer = Int(((b.Length - 2) - 0 + 1) * Rnd()) + 1
            s.Append(b(z))
        Next
        Return s.ToString
    End Function
    Public Function GetTargetPath(LinkFilename As String) As String
        Dim scpath As String = ""
        If LinkFilename.ToLower.EndsWith(".lnk") Then
            Dim theShell As New IWshRuntimeLibrary.WshShell()
            Dim theShortcut As IWshRuntimeLibrary.WshShortcut = CType(theShell.CreateShortcut(LinkFilename), IWshRuntimeLibrary.WshShortcut)
            scpath = theShortcut.TargetPath
            System.Runtime.InteropServices.Marshal.ReleaseComObject(theShortcut)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(theShell)
        End If
        Return scpath
    End Function
    Public Function RC4Encrypt(text As String, encryptkey As String)
        Dim sbox(256)
        Dim key(256)
        Dim temp As Integer
        Dim a As Long
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim cipherby As Integer
        Dim cipher As String

        i = 0
        j = 0

        RC4Initialize(encryptkey, key, sbox)

        For a = 1 To Len(text)
            i = (i + 1) Mod 256
            j = (j + sbox(i)) Mod 256
            temp = sbox(i)
            sbox(i) = sbox(j)
            sbox(j) = temp

            k = sbox((sbox(i) + sbox(j)) Mod 256)

            cipherby = (Asc(Mid$(text, a, 1))) Xor k
            If Len(Hex(cipherby)) = 1 Then
                cipher = cipher & "0" & Hex(cipherby)
            Else
                cipher = cipher & Hex(cipherby)
            End If
        Next

        RC4Encrypt = cipher
    End Function

    Public Function RC4Decrypt(text, encryptkey)
        Dim sbox(256) As Integer
        Dim key(256) As Integer
        Dim Text2 As String
        Dim temp As Integer
        Dim a As Long
        Dim i As Integer
        Dim j As Integer
        Dim k As Long
        Dim w As Integer
        Dim cipherby As Integer
        Dim cipher As String

        For w = 1 To Len(text) Step 2
            Text2 = Text2 & Chr(Dec(Mid$(text, w, 2)))
        Next

        i = 0
        j = 0

        RC4Initialize(encryptkey, key, sbox)

        For a = 1 To Len(Text2)
            i = (i + 1) Mod 256
            j = (j + sbox(i)) Mod 256
            temp = sbox(i)
            sbox(i) = sbox(j)
            sbox(j) = temp

            k = sbox((sbox(i) + sbox(j)) Mod 256)

            cipherby = Asc(Mid$(Text2, a, 1)) Xor k
            cipher = cipher & Chr(cipherby)
        Next

        RC4Decrypt = cipher
    End Function
    Public Function chekup() As String
        Dim local_stubver As String = My.Settings.Stubver
        Dim local_mvmver As String = My.Settings.appversion
        Dim server_appver As String = New System.Net.WebClient().DownloadString("http://pastebin.com/raw/20QTa8ri")
        Dim server_Stubver As String = New System.Net.WebClient().DownloadString("http://pastebin.com/raw/srr5aVhT")
        Dim res As String

        If Not local_stubver = server_Stubver Then
            res += "New Stub is available" & vbNewLine
        End If
        If Not local_mvmver = server_appver Then
            res += "New Builder is available" & vbNewLine

        End If
        If res = Nothing Then
            Return "No update are available for now"
        Else
            Return res
        End If
    End Function
    Public Function RC4Initialize(strPwd, ByRef key, ByRef sbox)
        Dim tempSwap
        Dim a
        Dim b
        Dim intlength As Long

        intlength = Len(strPwd)
        For a = 0 To 255
            key(a) = Asc(Mid$(strPwd, a Mod intlength + 1, 1))
            sbox(a) = a
        Next

        b = 0
        For a = 0 To 255
            b = (b + sbox(a) + key(a)) Mod 256
            tempSwap = sbox(a)
            sbox(a) = sbox(b)
            sbox(b) = tempSwap
        Next
    End Function
    Public Function EncodeBase64(input As String) As String
        Return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input))
    End Function

    Public Function DecodeBase64(input As String) As String
        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input))
    End Function
    Public Function Dec(number) As String
        Dim base As String
        Dim iLen As Integer
        Dim iReturn As Long
        Dim i As Long
        Dim iTemp As String

        base = "0123456789ABCDEF"
        iLen = Len(number)

        For i = 0 To iLen - 1
            iTemp = Mid$(number, iLen - i, 1)
            iReturn = iReturn + (16 ^ i) * (InStr(1, base, iTemp) - 1)
        Next

        Dec = iReturn
    End Function
    Public Function PrintByteArray(ByVal array() As Byte)

        Dim hex_value As String = ""

        ' On parcoure le tableau de bytes (octets)
        Dim i As Integer
        For i = 0 To array.Length - 1

            ' On convertit chaque octet (byte) en hexadécimal
            hex_value += array(i).ToString("X2")

        Next i

        ' On retourne la chaine de caractères en minuscules
        Return hex_value.ToLower

    End Function
    Function RandomString(ByVal StringLength As Integer, Optional ByVal CustomCharacters As String = "", Optional ByVal Letters As Boolean = True, Optional ByVal Numbers As Boolean = True, Optional ByVal Symbols As Boolean = False, Optional ByVal UpperCase As Boolean = True, Optional ByVal LowerCase As Boolean = True) As String
        Dim randomG As New Random
        Dim randomN As Integer
        Const pwChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Const pwNumbers As String = "0123456789"
        Const pwSymbols As String = "`¬!""£$%^&*()_)+-=[]{};':@#~/?.>,<|"""
        Dim str As String = ""
        While str.Length < StringLength
            Dim pwcharList As String = ""
            If Letters = True Then pwcharList &= pwChars
            If Numbers = True Then pwcharList &= pwNumbers
            If Symbols = True Then pwcharList &= pwSymbols
            pwcharList &= CustomCharacters
            randomN = randomG.Next(0, pwcharList.Length)
            If UpperCase = True And LowerCase = True Then
                Dim randomN2 = randomG.Next(0, 2)
                If randomN2 = 0 Then
                    str &= Char.ToUpper(pwcharList(randomN), System.Globalization.CultureInfo.CurrentCulture)
                Else
                    str &= Char.ToLower(pwcharList(randomN), System.Globalization.CultureInfo.CurrentCulture)
                End If
            ElseIf UpperCase = True Then
                str &= Char.ToUpper(pwcharList(randomN), System.Globalization.CultureInfo.CurrentCulture)
            ElseIf LowerCase = True Then
                str &= Char.ToLower(pwcharList(randomN), System.Globalization.CultureInfo.CurrentCulture)
            Else
                str &= pwcharList(randomN)
            End If
        End While
        Return str
    End Function
End Module
