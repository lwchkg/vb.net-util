Public Class Form1

    Public Shared Function toStrExpr(s As String) As String
        Dim rx As New System.Text.RegularExpressions.Regex("(\r\n|\r|\n)")
        Dim buf = rx.Split(s.Replace("""", """"""))

        Dim s1 As String = ""
        Dim i As Integer

        For i = 0 To buf.Count - 1
            If buf(i) = "" Then Continue For
            If s1 <> "" Then s1 &= " & "
            If i Mod 2 = 0 Then
                s1 &= """" & buf(i) & """"
            Else
                s1 &= "vbCrLf"
            End If
        Next

        If s1 = "" Then s1 = """"""
        Return s1
    End Function

    Private Function getMsgBoxStr() As String
        Dim title As String = If(CheckBoxNoTitle.Checked, "", TextBoxTitle.Text)
        Dim prompt As String = TextBoxPrompt.Text
        Dim defresp As String = TextBoxDefResp.Text

        If defresp <> "" Then
            Return (String.Format("InputBox({0}, {1}, {2})", toStrExpr(prompt),
                                  If(title <> "", toStrExpr(title), ""), toStrExpr(defresp)))
        ElseIf title <> "" Then
            Return (String.Format("InputBox({0}, {1})", toStrExpr(prompt), toStrExpr(title)))
        Else
            Return (String.Format("InputBox({0})", toStrExpr(prompt)))
        End If
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName
        updateStatement(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim title As Object = If(CheckBoxNoTitle.Checked, "", TextBoxTitle.Text)
        Dim prompt As Object = TextBoxPrompt.Text
        Dim defresp As String = TextBoxDefResp.Text

        If defresp <> "" Then
            TextBoxReturn.Text = toStrExpr(InputBox(prompt, title, defresp))
        Else
            TextBoxReturn.Text = toStrExpr(InputBox(prompt, title))
        End If
    End Sub

    Private Sub CheckBoxNoTitle_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxNoTitle.CheckedChanged
        TextBoxTitle.Enabled = Not CheckBoxNoTitle.Checked
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Clipboard.SetText(getMsgBoxStr())
    End Sub

    Private Sub updateStatement(sender As System.Object, e As System.EventArgs) Handles TextBoxPrompt.TextChanged,
                TextBoxTitle.TextChanged, TextBoxDefResp.TextChanged, CheckBoxNoTitle.CheckedChanged
        TextBoxStatement.Text = getMsgBoxStr()
    End Sub
End Class
