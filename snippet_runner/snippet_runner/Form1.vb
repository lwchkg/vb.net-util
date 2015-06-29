Imports System.CodeDom
Imports System.CodeDom.Compiler

Public Class Form1

    Private serial As String = "148eb8e839ec91ad9c73beaf2ee7fa80" ' Just a preset random number
    Private errorColor As Color = Color.Red
    Private assemblyImport = {
        "System.Windows.Forms.dll",
        "System.Drawing.dll"
    }
    Private nsImport = {
        "System",
        "Microsoft.VisualBasic",
        "System.Diagnostics",
        "System.Windows.Forms",
        "System.Drawing"
    }

    Dim result As New Object
    Dim loaded As Boolean = False

    ' Default text colors
    Dim textBgColor = Color.Black
    Dim textFgColor = Color.LightGray
    Dim titleBgColor = Color.LightGray
    Dim titleFgColor = Color.Black

    ' Array to convert ConsoleColor to System.Drawing.Color
    Dim ConsoleColors() As Color = {
        Color.Black, Color.Navy, Color.Green, Color.Teal,
        Color.Maroon, Color.Purple, Color.Olive, Color.Silver,
        Color.Gray, Color.Blue, Color.Lime, Color.Cyan,
        Color.Red, Color.Magenta, Color.Yellow, Color.White
    }

    Private Sub addColoredText(s As String,
                               Optional fgColor As Color? = Nothing, Optional bgColor As Color? = Nothing, Optional font As Font = Nothing)
        Dim c = RichTextBoxResult
        If fgColor Is Nothing Then fgColor = Me.textFgColor
        If bgColor Is Nothing Then bgColor = Me.textBgColor

        Dim p = c.TextLength
        c.AppendText(s)
        c.Select(p, c.TextLength - p + 1)
        c.SelectionColor = fgColor
        c.SelectionBackColor = bgColor
        If font IsNot Nothing Then c.SelectionFont = font
    End Sub

    Private Sub addResult(maintext As String, title As String,
                          Optional textFgColor As Color? = Nothing, Optional textBgColor As Color? = Nothing,
                          Optional titleFgColor As Color? = Nothing, Optional titleBgColor As Color? = Nothing)
        Dim c = RichTextBoxResult
        If titleFgColor Is Nothing Then titleFgColor = Me.titleFgColor
        If titleBgColor Is Nothing Then titleBgColor = Me.titleBgColor

        If c.TextLength Then c.AppendText(vbCrLf & vbCrLf)

        Dim cf = c.SelectionFont
        Dim tf = New Font(cf.FontFamily, cf.Size, FontStyle.Bold)

        addColoredText(" --- " & title & " --- " & vbCrLf, titleFgColor, titleBgColor, tf)
        addColoredText(maintext, textFgColor, textBgColor)
    End Sub

    Private Sub addResultColor(maintext As String, colors As List(Of ColorInfo), title As String,
                               Optional titleFgColor As Color? = Nothing, Optional titleBgColor As Color? = Nothing)
        Dim c = RichTextBoxResult
        If titleFgColor Is Nothing Then titleFgColor = Me.titleFgColor
        If titleBgColor Is Nothing Then titleBgColor = Me.titleBgColor

        If c.TextLength Then c.AppendText(vbCrLf & vbCrLf)

        Dim cf = c.SelectionFont
        Dim tf = New Font(cf.FontFamily, cf.Size, FontStyle.Bold)

        addColoredText(" --- " & title & " --- " & vbCrLf, titleFgColor, titleBgColor, tf)

        Dim i As Integer
        Dim temppos As Integer = 1, tempCo As Integer = 7, co As Integer
        Dim l = maintext.Length \ 2, l1 As Integer = 0

        For i = 0 To colors.Count - 2
            addColoredText(maintext.Substring(colors(i).startPos, colors(i + 1).startPos - colors(i).startPos),
                           ConsoleColors(colors(i).color Mod 16), ConsoleColors(colors(i).color \ 16))
        Next
        addColoredText(maintext.Substring(colors(i).startPos),
                       ConsoleColors(colors(i).color Mod 16), ConsoleColors(colors(i).color \ 16))
    End Sub

    Private Function escapeString(s) As Object
        If TypeOf s Is String Then
            Return """" & DirectCast(s, String).Replace("""", """""") & """"
        Else
            Return s
        End If
    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ' Add hidden console on first run to allow colors to be set 
        ' (i.e. Console.ForegroundColor and Console.BackgroundColor)
        ' Doesn't work if set on MyBase.Load
        Dim handle = GetConsoleWindow()
        If handle = IntPtr.Zero Then
            AllocConsole()
            handle = GetConsoleWindow()
            ShowWindow(handle, 0)
        End If

        Dim provider As New VBCodeProvider()

        ' Build the parameters for source compilation.
        Dim cp As New CompilerParameters(assemblyImport)
        cp.GenerateInMemory = True
        cp.CompilerOptions = "/d:TRACE=TRUE /d:DEBUG=TRUE /optioninfer+"

        ' Create a new CodeCompileUnit to contain the program graph.
        Dim compileUnit As New CodeCompileUnit()

        ' Add the namespace
        Dim ns1 As New CodeNamespace()
        compileUnit.Namespaces.Add(ns1)

        ' Add the new namespace import for the System namespace.
        For Each ns As String In nsImport
            ns1.Imports.Add(New CodeNamespaceImport(ns))
        Next ns

        ' Add the new class
        Dim class1 As New CodeTypeDeclaration("Class" & serial)
        ns1.Types.Add(class1)

        ' Add the method
        Dim method1 As New CodeMemberMethod()
        class1.Members.Add(method1)

        method1.Name = "Method" & serial
        method1.Attributes = MemberAttributes.Public + MemberAttributes.Static
        method1.ReturnType = New CodeTypeReference(GetType(Object))

        ' Add the statements
        method1.Statements.Add(New CodeSnippetExpression(TextBoxSource.Text))

        ' Generate Source
        'Dim sourceWriter As New IO.StringWriter()
        'provider.GenerateCodeFromCompileUnit(compileUnit, sourceWriter, New CodeGeneratorOptions)
        'TextBoxResult.Text = sourceWriter.ToString()
        'Exit Sub

        ' Invoke compilation.
        'Dim cr As CompilerResults = provider.CompileAssemblyFromSource(cp, sourceWriter.ToString)
        Dim cr As CompilerResults = provider.CompileAssemblyFromDom(cp, compileUnit)

        Dim hasError As Boolean = False
        Dim exStore As New Exception
        Dim errMsg As New List(Of Object)

        If cr.Errors.Count > 0 Then
            RichTextBoxResult.Clear()
            ' Display compilation errors.
            For Each ce As CompilerError In cr.Errors
                errMsg.Add(String.Format("Line {0} - {1}", ce.Line - 18 - nsImport.length, ce.ErrorText))
            Next ce
            addResult(vbCrLf & String.Join(vbCrLf & vbCrLf, errMsg.ToArray()), "Compile error", errorColor)
            RichTextBoxResult.WordWrap = True
            Exit Sub
        End If

        Dim objAssembly As System.Reflection.Assembly = cr.CompiledAssembly
        Dim objClass = objAssembly.CreateInstance("Class" & serial)

        ' Prepare console and debug
        Dim consolewriter As System.IO.TextWriter
        If CheckBoxColor.Checked Then
            consolewriter = New ColorStringWriter()
        Else
            consolewriter = New System.IO.StringWriter()
        End If

        Dim debugWriter = New System.IO.StringWriter()
        Dim debugListener = New TextWriterTraceListener(debugWriter)

        Console.SetOut(consolewriter)
        If CheckBoxDumpInput.Checked Then
            Console.SetIn(New DumpReader(New System.IO.StringReader(TextBoxInput.Text), consolewriter))
        Else
            Console.SetIn(New System.IO.StringReader(TextBoxInput.Text))
        End If
        Debug.Listeners.Add(debugListener)

        ' Run code
        Try
            result = objClass.GetType().InvokeMember("Method" & serial, Reflection.BindingFlags.InvokeMethod, Nothing, objClass, {})
        Catch ex As Exception
            hasError = True
            exStore = ex
        Finally
            Debug.Listeners.Remove(debugListener)
        End Try

        ' Reset console and debug
        Debug.Flush()
        Console.ResetColor()

        ' Output results
        RichTextBoxResult.Clear()

        RichTextBoxResult.WordWrap = CheckBoxWordWrap.Checked Or hasError ' If error happened, force word wrap.
        If CheckBoxColor.Checked Then
            addResultColor(consolewriter.ToString(), DirectCast(consolewriter, ColorStringWriter).colorData, "Console output")
        Else
            addResult(consolewriter.ToString(), "Console output")
        End If

        Dim s = debugWriter.ToString
        If s <> "" Then addResult(debugWriter.ToString(), "Debug/trace output")

        If result IsNot Nothing Then addResult(result.ToString(), "Return value")

        If hasError Then
            addResult(exStore.InnerException.Message, "Runtime error", errorColor)
        End If

    End Sub

    Private Sub CheckBoxWordWrap_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxWordWrap.CheckedChanged
        If Not loaded Then Exit Sub
        TextBoxSource.WordWrap = CheckBoxWordWrap.Checked
        RichTextBoxResult.WordWrap = CheckBoxWordWrap.Checked
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loaded = True
        CheckBoxWordWrap_CheckedChanged(CheckBoxWordWrap, New EventArgs())
        Button1_Click(Button1, New EventArgs())

        RichTextBoxResult.ReadOnly = True
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSource.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub ButtonShowInstructions_Click(sender As System.Object, e As System.EventArgs) Handles ButtonShowInstructions.Click
        FormInstructions.Show()
        FormInstructions.Focus()
    End Sub
End Class
