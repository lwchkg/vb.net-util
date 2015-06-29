Public Class FormInstructions

    Private Sub FormInstructions_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        Dim filestream As New System.IO.MemoryStream(My.Resources.Instructions)
        RichTextBox1.LoadFile(filestream, RichTextBoxStreamType.RichText)
    End Sub
End Class