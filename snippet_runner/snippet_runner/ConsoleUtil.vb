Imports System.Runtime.InteropServices
Imports System.Text

Module ConsoleUtil

    <DllImport("Kernel32.dll", EntryPoint:="AllocConsole", ExactSpelling:=False, CharSet:=CharSet.Unicode, setLastError:=True)> _
    Public Function AllocConsole() As Boolean
    End Function

    <DllImport("Kernel32.dll", EntryPoint:="GetConsoleWindow", ExactSpelling:=False, CharSet:=CharSet.Unicode)> _
    Public Function GetConsoleWindow() As IntPtr
    End Function

    <DllImport("user32.dll", EntryPoint:="ShowWindow", ExactSpelling:=False, CharSet:=CharSet.Unicode)> _
    Public Function ShowWindow(hWnd As Integer, nCmdShow As Integer) As Boolean
    End Function

End Module
