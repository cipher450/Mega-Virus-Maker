Module fnc
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
    Public Function Randome_int(ByVal lenght As Integer) As String
        Randomize()
        Dim b() As Char
        Dim s As New System.Text.StringBuilder("")
        b = "012345679"
        For i As Integer = 1 To lenght
            Randomize()
            Dim z As Integer = Int(((b.Length - 2) - 0 + 1) * Rnd()) + 1
            s.Append(b(z))
        Next
        Return s.ToString
    End Function
    Function takescreenshot() As Image
        Try
            Dim larg As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim hot As Integer = Screen.PrimaryScreen.Bounds.Height

            Dim image As New Bitmap(larg, hot)
            Dim GRAPH As Graphics = Graphics.FromImage(image)
            GRAPH.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy)
            Return image
        Catch ex As Exception

        End Try

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
