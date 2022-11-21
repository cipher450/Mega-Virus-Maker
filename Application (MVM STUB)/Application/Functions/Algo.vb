Imports System.IO
Imports System.Text
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.Serialization.Formatters
Module Algo
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
    Public Function toBase64(Str As String) As String
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(Str)
        Return Convert.ToBase64String(byt)
    End Function
    Public Function Base64tostr(base64 As String) As String
        Dim b As Byte() = Convert.FromBase64String(base64)
        Return System.Text.Encoding.UTF8.GetString(b)
    End Function
End Module
Public Class ElgAESCrypt

#Region "Attributs"

    Private _UserKey As String
    Private _SecretKey(15) As Byte
    Private _SecretIV(15) As Byte

#End Region

#Region "Proprietés"





    Public Property Key() As Byte()
        Get
            Return _SecretKey
        End Get
        Set(ByVal value As Byte())
            _SecretKey = value
        End Set
    End Property

    Public Property IV() As Byte()
        Get
            Return _SecretIV
        End Get
        Set(ByVal value As Byte())
            _SecretIV = value
        End Set
    End Property

#End Region

#Region "Methodes"
    Private Function GenereCle(ByVal strKey As String) As Boolean

        Dim Resultat As Boolean = False

        Try

            Dim ByteKey(strKey.Length - 1) As Byte
            Dim aEnc As New UTF8Encoding
            aEnc.GetBytes(strKey, 0, strKey.Length, ByteKey, 0)

            Dim ServiceSHA As New SHA1CryptoServiceProvider
            Dim Hashage() As Byte = ServiceSHA.ComputeHash(ByteKey)


            For I As Integer = 0 To 15
                _SecretKey(I) = Hashage(I)
            Next I


            For j As Integer = 15 To 0 Step -1
                _SecretIV(15 - j) = Hashage(j)
            Next

            Resultat = True

        Catch e As Exception
            Resultat = False

        End Try

        Return Resultat

    End Function
    Public Sub EncrypterFichier(ByVal sInputFilename As String, ByVal sOutputFilename As String)

        If Not (File.Exists(sInputFilename)) Then
            Throw New Exception("Vous devez specifier un fichier d'entrée existant !")
        End If

        Dim AES As New AesCryptoServiceProvider()
        Dim AesDecrypt As ICryptoTransform = AES.CreateEncryptor(_SecretKey, _SecretIV)

        Using fsInput As New FileStream(sInputFilename, FileMode.Open, FileAccess.Read, FileShare.Read)

            ' Flux d'entree
            Using fsOutput As New FileStream(sOutputFilename, FileMode.Create, FileAccess.Write, FileShare.None)

                ' Flux de transformation qu'on rattache au flux de sortie
                Using cryptostream As New CryptoStream(fsOutput, AesDecrypt, CryptoStreamMode.Write)

                    ' Ecrit flux d'entre dans un tableau d'octet
                    Dim bytearrayinput(fsInput.Length - 1) As Byte
                    Dim bytesRead As Long = 0

                    bytesRead = fsInput.Read(bytearrayinput, 0, fsInput.Length)

                    If Not (bytesRead = 0) Then
                        ' Crypte tableau d'octet en ecrivant sur le flux de transformation (sortie)
                        cryptostream.Write(bytearrayinput, 0, bytesRead)
                        cryptostream.Flush()
                    End If

                End Using

            End Using

        End Using

    End Sub
    Public Sub DecrypterFichier(ByVal sInputFilename As String, ByVal sOutputFilename As String)

        If Not (File.Exists(sInputFilename)) Then
            Throw New Exception("Vous devez specifier un fichier d'entrée existant !")
        End If

        Dim AES As New AesCryptoServiceProvider()
        Dim AesDecrypt As ICryptoTransform = AES.CreateDecryptor(_SecretKey, _SecretIV)

        Using fsread As New FileStream(sInputFilename, FileMode.Open, FileAccess.Read, FileShare.Read)

            Using cryptostreamDecr As New CryptoStream(fsread, AesDecrypt, CryptoStreamMode.Read)

                Using fsDecrypted As New FileStream(sOutputFilename, FileMode.Create, FileAccess.Write, FileShare.None)

                    Dim bytearrayinput(fsread.Length) As Byte
                    Dim bytesRead As Long = 0

                    bytesRead = cryptostreamDecr.Read(bytearrayinput, 0, fsread.Length)

                    If (bytesRead > 0) Then
                        fsDecrypted.Write(bytearrayinput, 0, bytesRead)
                        fsDecrypted.Flush()
                    End If

                End Using

            End Using

        End Using

    End Sub
#End Region

#Region "Constructeur"

    Public Sub New(ByVal Cle As String)

        _UserKey = Cle

        If Not (GenereCle(Cle)) Then
            Throw New Exception("Erreur à la creation de la cle")
        End If

    End Sub

#End Region

End Class