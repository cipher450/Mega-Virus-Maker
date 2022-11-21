Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.Security.AccessControl
Imports System.Security.Principal

Public Class c_AntiKill
    <DllImport("advapi32.dll", SetLastError:=True)> _
    Shared Function GetKernelObjectSecurity(Handle As IntPtr, securityInformation As Integer, <Out> pSecurityDescriptor As Byte(), nLength As UInteger, ByRef lpnLengthNeeded As UInteger) As Boolean
    End Function
    <DllImport("advapi32.dll", SetLastError:=True)> _
    Shared Function SetKernelObjectSecurity(Handle As IntPtr, securityInformation As Integer, <[In]> pSecurityDescriptor As Byte()) As Boolean
    End Function
    <DllImport("kernel32.dll")> _
    Shared Function GetCurrentProcess() As IntPtr
    End Function
    Protected Function GetProcessSecurityDescriptor(processHandle As IntPtr) As RawSecurityDescriptor
        Dim psd() As Byte = New Byte(1) {}
        Dim bufSizeNeeded As UInteger
        GetKernelObjectSecurity(processHandle, &H4, psd, 0, bufSizeNeeded)
        psd = New Byte(bufSizeNeeded) {}
        If bufSizeNeeded < 0 OrElse bufSizeNeeded > Short.MaxValue Then
            Throw New Win32Exception()
        End If
        If Not GetKernelObjectSecurity(processHandle, &H4, psd, bufSizeNeeded, bufSizeNeeded) Then
            Throw New Win32Exception()
        End If
        Return New RawSecurityDescriptor(psd, 0)
    End Function
    Protected Sub SetProcessSecurityDescriptor(processHandle As IntPtr, dacl As RawSecurityDescriptor)
        Dim rawsd As Byte() = New Byte(dacl.BinaryLength - 1) {}
        dacl.GetBinaryForm(rawsd, 0)
        If Not SetKernelObjectSecurity(processHandle, &H4, rawsd) Then
            Throw New Win32Exception()
        End If
    End Sub
    Public Sub c_ImAntiKill()
        Dim hProcess As IntPtr = GetCurrentProcess()
        Dim dacl = GetProcessSecurityDescriptor(hProcess)
        dacl.DiscretionaryAcl.InsertAce(0, New CommonAce(AceFlags.None, AceQualifier.AccessDenied, CInt(&HF0000 Or &H100000 Or &HFFF), New SecurityIdentifier(WellKnownSidType.WorldSid, Nothing), False, Nothing))
        SetProcessSecurityDescriptor(hProcess, dacl)
        Console.ReadKey()
    End Sub
End Class
