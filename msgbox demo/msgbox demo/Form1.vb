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
        Dim title As Object = If(CheckBoxNoTitle.Checked, Nothing, TextBoxTitle.Text)
        Dim buttons As New List(Of String)
        Dim prompt As Object = TextBoxPrompt.Text

        For Each c As Object In Me.Controls
            If c.name.startswith("GroupBox") Then
                For Each c1 As Object In c.Controls
                    If c1.Name.StartsWith("RadioButton") AndAlso c1.Checked Then
                        Dim s As String = c1.Name.Replace("RadioButton", "")
                        If Not s.StartsWith("None") And s <> "OkOnly" Then
                            buttons.Add("vb" & s)
                        End If
                    End If
                Next
            End If

            If c.Name.StartsWith("CheckBox") AndAlso c.Checked Then
                Dim s As String = c.Name.Replace("CheckBox", "")
                If s <> "NoTitle" Then
                    buttons.Add("vb" & s)
                End If
            End If
        Next

        If Not IsNothing(title) Then
            Return (String.Format("MsgBox({0}, {1}, {2})", toStrExpr(prompt), If(buttons.Count, String.Join(" + ", buttons), ""), toStrExpr(title)))
        ElseIf buttons.Count Then
            Return (String.Format("MsgBox({0}, {1})", toStrExpr(prompt), String.Join(" + ", buttons)))
        Else
            Return (String.Format("MsgBox({0})", toStrExpr(prompt)))
        End If
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName

        For Each c As Object In Me.Controls
            If c.name.startswith("GroupBox") Then
                For Each c1 As Object In c.Controls
                    If c1.Name.StartsWith("RadioButton") Then
                        AddHandler CType(c1, RadioButton).CheckedChanged, AddressOf updateStatement
                    End If
                Next
            End If

            If c.Name.StartsWith("CheckBox") Then
                AddHandler CType(c, CheckBox).CheckedChanged, AddressOf updateStatement
            End If
        Next
        updateStatement(Nothing, Nothing)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim title As Object = If(CheckBoxNoTitle.Checked, Nothing, TextBoxTitle.Text)
        Dim button As MsgBoxStyle = 0
        Dim prompt As Object = TextBoxPrompt.Text

        For Each c As Object In Me.Controls
            If c.name.startswith("GroupBox") Then
                For Each c1 As Object In c.Controls
                    If c1.Name.StartsWith("RadioButton") AndAlso c1.Checked Then
                        Dim s As String = c1.Name.Replace("RadioButton", "")
                        If Not s.StartsWith("None") Then
                            button += [Enum].Parse(GetType(MsgBoxStyle), s)
                        End If
                    End If
                Next
            End If

            If c.Name.StartsWith("CheckBox") AndAlso c.Checked Then
                Dim s As String = c.Name.Replace("CheckBox", "")
                If s <> "NoTitle" Then
                    button += [Enum].Parse(GetType(MsgBoxStyle), s)
                End If
            End If
        Next

        Dim ret As MsgBoxResult = MsgBox(prompt, button, title)
        TextBoxReturn.Text = String.Format("vb{0} ({1})", ret.ToString, CInt(ret))
    End Sub

    Private Sub CheckBoxNoTitle_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxNoTitle.CheckedChanged
        TextBoxTitle.Enabled = Not CheckBoxNoTitle.Checked
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Clipboard.SetText(getMsgBoxStr())
    End Sub

    Private Sub updateStatement(sender As System.Object, e As System.EventArgs) Handles TextBoxPrompt.TextChanged, TextBoxTitle.TextChanged
        TextBoxStatement.Text = getMsgBoxStr()
    End Sub
End Class
