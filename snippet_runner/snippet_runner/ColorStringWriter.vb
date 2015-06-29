Imports System.IO

Public Structure ColorInfo
    Public startPos As Integer
    Public color As Integer
    Public Sub New(startPos As Integer, color As Integer)
        Me.startPos = startPos
        Me.color = color
    End Sub
End Structure

Public Class ColorStringWriter
    Inherits TextWriter
    Dim buf As New System.Text.StringBuilder
    Dim currentColor As Integer = -1
    Public colorData As New List(Of ColorInfo)

    Public Overrides Sub Write(value As Char)
        Dim c As Integer = Console.ForegroundColor + Console.BackgroundColor * 16
        If c <> currentColor Then
            colorData.Add(New ColorInfo(buf.Length, c))
            currentColor = c
        End If
        buf.Append(value)
    End Sub

    Public Overrides Sub Write(value As String)
        Dim c As Integer = Console.ForegroundColor + Console.BackgroundColor * 16
        If c <> currentColor Then
            colorData.Add(New ColorInfo(buf.Length, c))
            currentColor = c
        End If
        buf.Append(value)
    End Sub

    Public Overrides Function ToString() As String
        Return buf.ToString
    End Function

    Public Overrides ReadOnly Property Encoding As System.Text.Encoding
        Get
            Return New System.Text.UnicodeEncoding()
        End Get
    End Property
End Class
