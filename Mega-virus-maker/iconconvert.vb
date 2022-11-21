Class PngIconConverter
    Public Shared Function Convert(ByVal input_stream As System.IO.Stream, ByVal output_stream As System.IO.Stream, ByVal size As Integer, Optional ByVal keep_aspect_ratio As Boolean = False) As Boolean
        Dim input_bit As System.Drawing.Bitmap = CType(System.Drawing.Bitmap.FromStream(input_stream), System.Drawing.Bitmap)

        If input_bit IsNot Nothing Then
            Dim width, height As Integer

            If keep_aspect_ratio Then
                width = size
                height = input_bit.Height / input_bit.Width * size
            Else
                width = CSharpImpl.__Assign(height, size)
            End If

            Dim new_bit As System.Drawing.Bitmap = New System.Drawing.Bitmap(input_bit, New System.Drawing.Size(width, height))

            If new_bit IsNot Nothing Then
                Dim mem_data As System.IO.MemoryStream = New System.IO.MemoryStream()
                new_bit.Save(mem_data, System.Drawing.Imaging.ImageFormat.Png)
                Dim icon_writer As System.IO.BinaryWriter = New System.IO.BinaryWriter(output_stream)

                If output_stream IsNot Nothing AndAlso icon_writer IsNot Nothing Then
                    icon_writer.Write(CByte(0))
                    icon_writer.Write(CByte(0))
                    icon_writer.Write(CShort(1))
                    icon_writer.Write(CShort(1))
                    icon_writer.Write(CByte(width))
                    icon_writer.Write(CByte(height))
                    icon_writer.Write(CByte(0))
                    icon_writer.Write(CByte(0))
                    icon_writer.Write(CShort(0))
                    icon_writer.Write(CShort(32))
                    icon_writer.Write(CInt(mem_data.Length))
                    icon_writer.Write(CInt((6 + 16)))
                    icon_writer.Write(mem_data.ToArray())
                    icon_writer.Flush()
                    Return True
                End If
            End If

            Return False
        End If

        Return False
    End Function

    Public Shared Function Convertico(ByVal input_image As String, ByVal output_icon As String, ByVal size As Integer, Optional ByVal keep_aspect_ratio As Boolean = False) As Boolean
        Dim input_stream As System.IO.FileStream = New System.IO.FileStream(input_image, System.IO.FileMode.Open)
        Dim output_stream As System.IO.FileStream = New System.IO.FileStream(output_icon, System.IO.FileMode.OpenOrCreate)
        Dim result As Boolean = Convert(input_stream, output_stream, size, keep_aspect_ratio)
        input_stream.Close()
        output_stream.Close()
        Return result
    End Function

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class
