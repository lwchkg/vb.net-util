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

    Dim result As New List(Of Object)
    Dim loaded As Boolean = False

    Private Function escapeString(s) As Object
        If TypeOf s Is String Then
            Return """" & DirectCast(s, String).Replace("""", """""") & """"
        Else
            Return s
        End If
    End Function

    Private Sub displayResult()
        If CheckBoxEscapeStrings.Checked Then
            TextBoxResult.Text = String.Join(vbCrLf, result.ConvertAll(Of Object)(AddressOf escapeString))
        Else
            TextBoxResult.Text = String.Join(vbCrLf, result.ToArray())
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim provider As New VBCodeProvider()

        ' Build the parameters for source compilation.
        Dim cp As New CompilerParameters(assemblyImport)
        cp.GenerateInMemory = True
        cp.CompilerOptions = "/optioninfer+"

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

        method1.Statements.Add(New CodeVariableDeclarationStatement(GetType(List(Of Object)), "buf", New CodeObjectCreateExpression(GetType(List(Of Object)))))

        ' Add the statements
        Dim bufref = New CodeVariableReferenceExpression("buf")
        Dim st As String() = TextBoxSource.Text.Split({vbCrLf}, StringSplitOptions.None)
        For Each s As String In st
            If s.Trim() = "" Then
                method1.Statements.Add(New CodeMethodInvokeExpression(bufref, "Add", New CodePrimitiveExpression(Nothing)))
            ElseIf s.ToUpper().StartsWith("DIM") Then
                method1.Statements.Add(New CodeSnippetExpression(s.Trim()))
                method1.Statements.Add(New CodeMethodInvokeExpression(bufref, "Add", New CodePrimitiveExpression(Nothing)))
            Else
                method1.Statements.Add(New CodeMethodInvokeExpression(bufref, "Add", New CodeSnippetExpression(s.Trim())))
            End If
        Next s
        method1.Statements.Add(New CodeMethodReturnStatement(bufref))

        ' Generate Source
        'Dim sourceWriter As New IO.StringWriter()
        'provider.GenerateCodeFromCompileUnit(compileUnit, sourceWriter, New CodeGeneratorOptions)
        'TextBoxResult.Text = sourceWriter.ToString()
        'Exit Sub

        ' Invoke compilation.
        Dim cr As CompilerResults = provider.CompileAssemblyFromDom(cp, compileUnit)

        Dim errMsg As New List(Of Object)

        If cr.Errors.Count > 0 Then
            ' Display compilation errors.
            errMsg.Add("--- Compile error ---")
            For Each ce As CompilerError In cr.Errors
                errMsg.Add(String.Format("Line {0} - {1}", ce.Line - 19 - nsImport.length, ce.ErrorText))
            Next ce
            TextBoxResult.Text = String.Join(vbCrLf & vbCrLf, errMsg.ToArray())
            TextBoxResult.ForeColor = errorColor
            TextBoxResult.WordWrap = True
            Exit Sub
        End If
        TextBoxResult.ForeColor = Control.DefaultForeColor

        Dim objAssembly As System.Reflection.Assembly = cr.CompiledAssembly
        Dim objClass = objAssembly.CreateInstance("Class" & serial)
        Try
            result = objClass.GetType().InvokeMember("Method" & serial, Reflection.BindingFlags.InvokeMethod, Nothing, objClass, {})
            displayResult()
            TextBoxResult.WordWrap = CheckBoxWordWrap.Checked
        Catch ex As Exception
            TextBoxResult.ForeColor = errorColor
            TextBoxResult.Text = String.Format("--- Runtime error ---" & vbCrLf & vbCrLf & "{0}", ex.InnerException.Message)
            TextBoxResult.WordWrap = True
        End Try

    End Sub

    Private Sub CheckBoxWordWrap_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxWordWrap.CheckedChanged
        If Not loaded Then Exit Sub
        TextBoxSource.WordWrap = CheckBoxWordWrap.Checked
        TextBoxResult.WordWrap = CheckBoxWordWrap.Checked
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loaded = True
        CheckBoxWordWrap_CheckedChanged(CheckBoxWordWrap, New EventArgs())
        Button1_Click(Button1, New EventArgs())

        TextBoxResult.BackColor = TextBoxResult.BackColor
        TextBoxResult.ReadOnly = True
    End Sub

    Private Sub CheckBoxEscapeStrings_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxEscapeStrings.CheckedChanged
        displayResult()
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSource.KeyPress, TextBoxResult.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub
End Class
