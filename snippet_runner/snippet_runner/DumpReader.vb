Imports System.IO

' DumpReader is a TextReader that dumps input into the output

' Initialization: New DumpReader(reader, writer)
'     reader: the TextReader to read from
'     writer: the TextWriter that the read operations dump to

Public Class DumpReader
    Inherits TextReader

    Private reader As TextReader, writer As TextWriter
    Public Sub New(reader As TextReader, writer As TextWriter)
        Me.reader = reader
        Me.writer = writer
    End Sub

    Public Overrides Function Peek() As Integer
        Return reader.Peek
    End Function

    Public Overrides Function Read() As Integer
        Dim c As Integer = reader.Read

        Dim fg, bg As ConsoleColor
        fg = Console.ForegroundColor
        bg = Console.BackgroundColor
        Console.ForegroundColor = 0
        Console.BackgroundColor = 7

        If c >= 0 Then writer.Write(ChrW(c))

        Console.ForegroundColor = fg
        Console.BackgroundColor = bg

        Return c
    End Function

    Public Overrides Function ReadLine() As String
        Dim s As String = reader.ReadLine()

        Dim fg, bg As ConsoleColor
        fg = Console.ForegroundColor
        bg = Console.BackgroundColor
        Console.ForegroundColor = 0
        Console.BackgroundColor = 7

        writer.WriteLine(s)

        Console.ForegroundColor = fg
        Console.BackgroundColor = bg

        Return s
    End Function
End Class
