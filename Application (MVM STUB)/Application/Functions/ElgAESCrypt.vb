Imports System.IO
Imports System.Text
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.Serialization.Formatters


' ------------------------------------------------------------------

Public Class ElgAESCrypt

#Region "Attributs"

    Private _UserKey As String      ' Cle entrée parl'utilisateur (en toute lettre)
    Private _SecretKey(15) As Byte  ' Cle secrete sur 128 bits generer par la fonction "GenereCle"
    Private _SecretIV(15) As Byte   ' Vecteur d'initialisation sur 128 bits generer par par la fonction "GenereCle"

#End Region

#Region "Proprietés"

    ''' <summary>
    ''' Cle secrete generée par la fonction <c>GenereCle</c>
    ''' </summary>    
    ''' <returns>Renvoi un tableau de Byte du vecteur</returns>
    ''' <remarks>Non utilisé ici, mais permet à l'utilisateur de pouvoir la récupérer si besoin</remarks>
    Public Property Key() As Byte()
        Get
            Return _SecretKey
        End Get
        Set(ByVal value As Byte())
            _SecretKey = value
        End Set
    End Property

    ''' <summary>
    '''  Vecteur d'initialisation generé par la fonction <c>GenereCle</c>
    ''' </summary>
    ''' <returns>Renvoi un tableau de Byte de la cle</returns>
    ''' <remarks>Non utilisé ici, mais permet à l'utilisateur de pouvoir la récupérer si besoin</remarks>
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

    ''' <summary>        
    ''' La methode créée un hashage SHA de la cle entrée par l'utilisateur et recupère les 15 premier byte
    ''' et les entre ensuite comme cle (Key) et vecteur d'initialisation (IV), ce qui augmente encore la 
    ''' sécurité du cryptage d'un cran, et facilite l'uilisation de la classe de cryptage (1 seule cle).
    ''' </summary>
    ''' <param name="strKey">Cle entrée par l'utilisateur</param>
    ''' <returns>Information permettant de savoir si la procedure a fonctionné</returns>
    ''' <remarks></remarks>
    Private Function GenereCle(ByVal strKey As String) As Boolean

        Dim Resultat As Boolean = False

        Try

            ' Conversion de la clé utilisateur en tableau de byte
            Dim ByteKey(strKey.Length - 1) As Byte
            Dim aEnc As New UTF8Encoding
            aEnc.GetBytes(strKey, 0, strKey.Length, ByteKey, 0)

            'Hashage de la clé en utilisant SHA1
            Dim ServiceSHA As New SHA1CryptoServiceProvider
            Dim Hashage() As Byte = ServiceSHA.ComputeHash(ByteKey)

            ' Creation de la clé pour la valeur "Key" en prenant les 16 premier 
            ' caractere du hashage
            For I As Integer = 0 To 15
                _SecretKey(I) = Hashage(I)
            Next I

            ' Creation de la clé pour la valeur "IV" en prenant les 16 premier 
            ' caractere du hashage, mais en les plaçant dans le sens inverse
            For j As Integer = 15 To 0 Step -1
                _SecretIV(15 - j) = Hashage(j)
            Next

            Resultat = True

        Catch e As Exception
            Resultat = False

        End Try

        Return Resultat

    End Function


    ''' <summary>
    ''' Encrypte un fichier dans un autre
    ''' </summary>
    ''' <param name="sInputFilename">Fichier non crypter</param>
    ''' <param name="sOutputFilename">Fichier crypter</param>    
    ''' <remarks></remarks>
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


    ''' <summary>
    ''' Decrypte un fichier crypté dans un autre
    ''' </summary>
    ''' <param name="sInputFilename">Fichier crypté</param>
    ''' <param name="sOutputFilename">Fichier non crypté</param>    
    ''' <remarks></remarks>
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


    ''' <summary>
    ''' Encrypte une chaine de texte
    ''' </summary>
    ''' <param name="Chaine">Chaine en clair</param>
    ''' <returns>Chaine cryptée</returns>
    ''' <remarks></remarks>
    Public Function EncrypterChaine(ByVal Chaine As String) As String

        ' Objets AES
        Dim AES As New AesCryptoServiceProvider()
        Dim AesDecrypt As ICryptoTransform = AES.CreateEncryptor(_SecretKey, _SecretIV)

        ' Buffer de stockages
        Dim BufferEntree() As Byte

        ' Chaine tampon pour stocker resultat final
        Dim ChaineSortie As String = String.Empty

        ' On place la chaine en claire dans le buffer d'entrée
        BufferEntree = Encoding.ASCII.GetBytes(Chaine.ToCharArray)

        ' Flux de travail 
        Dim msSortie As New MemoryStream()

        ' Flux de transformation (lié au flux msInput)
        Dim cryptostream As New CryptoStream(msSortie, AesDecrypt, CryptoStreamMode.Write)

        ' On ecrit la chaine (en claire) du buffer d'entrée dans le flux de sortie (qui sera transformé au passage)
        cryptostream.Write(BufferEntree, 0, BufferEntree.Length)
        cryptostream.FlushFinalBlock()

        ' On stocke resultat avant de fermer les flux
        ChaineSortie = Convert.ToBase64String(msSortie.ToArray)

        ' On ferme les flux
        msSortie.Close()
        cryptostream.Close()

        Return ChaineSortie

    End Function


    ''' <summary>
    ''' Decrypte une chaine de texte
    ''' </summary>
    ''' <param name="ChaineCrypte">Chaine cryptée</param>
    ''' <returns>Chaine décryptée</returns>
    ''' <remarks></remarks>
    Public Function DecrypterChaine(ByVal ChaineCrypte As String) As String

        ' Objets AES
        Dim AES As New AesCryptoServiceProvider()
        Dim AesDecrypt As ICryptoTransform = AES.CreateDecryptor(_SecretKey, _SecretIV)

        ' Buffers de stockage
        Dim BufferEntree() As Byte  ' Buffer contenant la chaine d'entrée
        Dim BufferSortie() As Byte  ' Buffer contenant la chaine de sortie

        ' On convertie la chaine crypter pour la placer dans le buffer
        BufferEntree = Convert.FromBase64String(ChaineCrypte)

        ' On dimenssione le buffer de sortie
        ReDim BufferSortie(BufferEntree.Length)

        ' Flux d'entree qu'on rattache au buffer d'entrée
        Dim msInput As New MemoryStream(BufferEntree)

        ' Flux de transformation qu'on rattache au flux d'entrée
        Dim cryptostream As New CryptoStream(msInput, AesDecrypt, CryptoStreamMode.Read)

        ' On ecrit le resultat decrypté dans le buffer de sortie
        cryptostream.Read(BufferSortie, 0, BufferSortie.Length)

        ' On ferme les flux
        msInput.Close()
        cryptostream.Close()

        ' Retourne la chaine resultante
        Return Encoding.ASCII.GetString(BufferSortie)

    End Function

#End Region

#Region "Constructeur"

    ''' <summary>
    ''' Constructeur par defaut
    ''' </summary>
    ''' <param name="Cle">Cle entrée par l'utilisateur</param>
    ''' <remarks>Les cles sont calculés en fonction du parametre cle</remarks>
    Public Sub New(ByVal Cle As String)

        _UserKey = Cle

        If Not (GenereCle(Cle)) Then
            Throw New Exception("Erreur à la creation de la cle")
        End If

    End Sub

#End Region

End Class
