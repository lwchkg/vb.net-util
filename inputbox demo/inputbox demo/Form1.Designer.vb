<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.LabelPrompt = New System.Windows.Forms.Label()
        Me.TextBoxTitle = New System.Windows.Forms.TextBox()
        Me.TextBoxPrompt = New System.Windows.Forms.TextBox()
        Me.CheckBoxNoTitle = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxReturn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxStatement = New System.Windows.Forms.TextBox()
        Me.TextBoxDefResp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Location = New System.Drawing.Point(23, 23)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(30, 13)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Title:"
        '
        'LabelPrompt
        '
        Me.LabelPrompt.AutoSize = True
        Me.LabelPrompt.Location = New System.Drawing.Point(23, 48)
        Me.LabelPrompt.Name = "LabelPrompt"
        Me.LabelPrompt.Size = New System.Drawing.Size(43, 13)
        Me.LabelPrompt.TabIndex = 3
        Me.LabelPrompt.Text = "Prompt:"
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.Location = New System.Drawing.Point(78, 20)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.Size = New System.Drawing.Size(103, 20)
        Me.TextBoxTitle.TabIndex = 1
        '
        'TextBoxPrompt
        '
        Me.TextBoxPrompt.Location = New System.Drawing.Point(78, 47)
        Me.TextBoxPrompt.Multiline = True
        Me.TextBoxPrompt.Name = "TextBoxPrompt"
        Me.TextBoxPrompt.Size = New System.Drawing.Size(194, 68)
        Me.TextBoxPrompt.TabIndex = 4
        '
        'CheckBoxNoTitle
        '
        Me.CheckBoxNoTitle.AutoSize = True
        Me.CheckBoxNoTitle.Location = New System.Drawing.Point(190, 22)
        Me.CheckBoxNoTitle.Name = "CheckBoxNoTitle"
        Me.CheckBoxNoTitle.Size = New System.Drawing.Size(82, 17)
        Me.CheckBoxNoTitle.TabIndex = 2
        Me.CheckBoxNoTitle.Text = "Use Default"
        Me.CheckBoxNoTitle.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(304, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Show InputBox"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(440, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Copy to Clipboard"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxReturn
        '
        Me.TextBoxReturn.Location = New System.Drawing.Point(379, 74)
        Me.TextBoxReturn.Name = "TextBoxReturn"
        Me.TextBoxReturn.ReadOnly = True
        Me.TextBoxReturn.Size = New System.Drawing.Size(149, 20)
        Me.TextBoxReturn.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(301, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Return Value:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "InputBox statement:"
        '
        'TextBoxStatement
        '
        Me.TextBoxStatement.Location = New System.Drawing.Point(25, 172)
        Me.TextBoxStatement.Multiline = True
        Me.TextBoxStatement.Name = "TextBoxStatement"
        Me.TextBoxStatement.ReadOnly = True
        Me.TextBoxStatement.Size = New System.Drawing.Size(515, 78)
        Me.TextBoxStatement.TabIndex = 12
        '
        'TextBoxDefResp
        '
        Me.TextBoxDefResp.Location = New System.Drawing.Point(78, 118)
        Me.TextBoxDefResp.Name = "TextBoxDefResp"
        Me.TextBoxDefResp.Size = New System.Drawing.Size(103, 20)
        Me.TextBoxDefResp.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Default:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 273)
        Me.Controls.Add(Me.TextBoxDefResp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxStatement)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxReturn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBoxNoTitle)
        Me.Controls.Add(Me.TextBoxPrompt)
        Me.Controls.Add(Me.TextBoxTitle)
        Me.Controls.Add(Me.LabelPrompt)
        Me.Controls.Add(Me.LabelTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents LabelPrompt As System.Windows.Forms.Label
    Friend WithEvents TextBoxTitle As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrompt As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxNoTitle As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBoxReturn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxStatement As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDefResp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
