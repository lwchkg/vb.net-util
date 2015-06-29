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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonRetryCancel = New System.Windows.Forms.RadioButton()
        Me.RadioButtonYesNo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonYesNoCancel = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAbortRetryIgnore = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOkCancel = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOkOnly = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonInformation = New System.Windows.Forms.RadioButton()
        Me.RadioButtonExclamation = New System.Windows.Forms.RadioButton()
        Me.RadioButtonQuestion = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCritical = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDefaultButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNone2 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDefaultButton2 = New System.Windows.Forms.RadioButton()
        Me.CheckBoxSystemModal = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMsgBoxSetForeground = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMsgBoxRight = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMsgBoxRtlReading = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxReturn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxStatement = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.LabelPrompt.TabIndex = 1
        Me.LabelPrompt.Text = "Prompt:"
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.Location = New System.Drawing.Point(78, 20)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.Size = New System.Drawing.Size(103, 20)
        Me.TextBoxTitle.TabIndex = 2
        '
        'TextBoxPrompt
        '
        Me.TextBoxPrompt.Location = New System.Drawing.Point(78, 47)
        Me.TextBoxPrompt.Multiline = True
        Me.TextBoxPrompt.Name = "TextBoxPrompt"
        Me.TextBoxPrompt.Size = New System.Drawing.Size(194, 68)
        Me.TextBoxPrompt.TabIndex = 3
        '
        'CheckBoxNoTitle
        '
        Me.CheckBoxNoTitle.AutoSize = True
        Me.CheckBoxNoTitle.Location = New System.Drawing.Point(190, 22)
        Me.CheckBoxNoTitle.Name = "CheckBoxNoTitle"
        Me.CheckBoxNoTitle.Size = New System.Drawing.Size(82, 17)
        Me.CheckBoxNoTitle.TabIndex = 4
        Me.CheckBoxNoTitle.Text = "Use Default"
        Me.CheckBoxNoTitle.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonRetryCancel)
        Me.GroupBox1.Controls.Add(Me.RadioButtonYesNo)
        Me.GroupBox1.Controls.Add(Me.RadioButtonYesNoCancel)
        Me.GroupBox1.Controls.Add(Me.RadioButtonAbortRetryIgnore)
        Me.GroupBox1.Controls.Add(Me.RadioButtonOkCancel)
        Me.GroupBox1.Controls.Add(Me.RadioButtonOkOnly)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 186)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Available Buttons"
        '
        'RadioButtonRetryCancel
        '
        Me.RadioButtonRetryCancel.AutoSize = True
        Me.RadioButtonRetryCancel.Location = New System.Drawing.Point(26, 144)
        Me.RadioButtonRetryCancel.Name = "RadioButtonRetryCancel"
        Me.RadioButtonRetryCancel.Size = New System.Drawing.Size(89, 17)
        Me.RadioButtonRetryCancel.TabIndex = 10
        Me.RadioButtonRetryCancel.Text = "Retry, Cancel"
        Me.RadioButtonRetryCancel.UseVisualStyleBackColor = True
        '
        'RadioButtonYesNo
        '
        Me.RadioButtonYesNo.AutoSize = True
        Me.RadioButtonYesNo.Location = New System.Drawing.Point(26, 121)
        Me.RadioButtonYesNo.Name = "RadioButtonYesNo"
        Me.RadioButtonYesNo.Size = New System.Drawing.Size(63, 17)
        Me.RadioButtonYesNo.TabIndex = 9
        Me.RadioButtonYesNo.Text = "Yes, No"
        Me.RadioButtonYesNo.UseVisualStyleBackColor = True
        '
        'RadioButtonYesNoCancel
        '
        Me.RadioButtonYesNoCancel.AutoSize = True
        Me.RadioButtonYesNoCancel.Location = New System.Drawing.Point(26, 98)
        Me.RadioButtonYesNoCancel.Name = "RadioButtonYesNoCancel"
        Me.RadioButtonYesNoCancel.Size = New System.Drawing.Size(102, 17)
        Me.RadioButtonYesNoCancel.TabIndex = 8
        Me.RadioButtonYesNoCancel.Text = "Yes, No, Cancel"
        Me.RadioButtonYesNoCancel.UseVisualStyleBackColor = True
        '
        'RadioButtonAbortRetryIgnore
        '
        Me.RadioButtonAbortRetryIgnore.AutoSize = True
        Me.RadioButtonAbortRetryIgnore.Location = New System.Drawing.Point(26, 75)
        Me.RadioButtonAbortRetryIgnore.Name = "RadioButtonAbortRetryIgnore"
        Me.RadioButtonAbortRetryIgnore.Size = New System.Drawing.Size(117, 17)
        Me.RadioButtonAbortRetryIgnore.TabIndex = 7
        Me.RadioButtonAbortRetryIgnore.Text = "Abort, Retry, Ignore"
        Me.RadioButtonAbortRetryIgnore.UseVisualStyleBackColor = True
        '
        'RadioButtonOkCancel
        '
        Me.RadioButtonOkCancel.AutoSize = True
        Me.RadioButtonOkCancel.Location = New System.Drawing.Point(26, 52)
        Me.RadioButtonOkCancel.Name = "RadioButtonOkCancel"
        Me.RadioButtonOkCancel.Size = New System.Drawing.Size(78, 17)
        Me.RadioButtonOkCancel.TabIndex = 6
        Me.RadioButtonOkCancel.Text = "Ok, Cancel"
        Me.RadioButtonOkCancel.UseVisualStyleBackColor = True
        '
        'RadioButtonOkOnly
        '
        Me.RadioButtonOkOnly.AutoSize = True
        Me.RadioButtonOkOnly.Checked = True
        Me.RadioButtonOkOnly.Location = New System.Drawing.Point(26, 29)
        Me.RadioButtonOkOnly.Name = "RadioButtonOkOnly"
        Me.RadioButtonOkOnly.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonOkOnly.TabIndex = 0
        Me.RadioButtonOkOnly.TabStop = True
        Me.RadioButtonOkOnly.Text = "Ok"
        Me.RadioButtonOkOnly.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButtonInformation)
        Me.GroupBox2.Controls.Add(Me.RadioButtonExclamation)
        Me.GroupBox2.Controls.Add(Me.RadioButtonQuestion)
        Me.GroupBox2.Controls.Add(Me.RadioButtonCritical)
        Me.GroupBox2.Controls.Add(Me.RadioButtonNone)
        Me.GroupBox2.Location = New System.Drawing.Point(206, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(155, 185)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Standard Icon"
        '
        'RadioButtonInformation
        '
        Me.RadioButtonInformation.AutoSize = True
        Me.RadioButtonInformation.Location = New System.Drawing.Point(21, 121)
        Me.RadioButtonInformation.Name = "RadioButtonInformation"
        Me.RadioButtonInformation.Size = New System.Drawing.Size(77, 17)
        Me.RadioButtonInformation.TabIndex = 10
        Me.RadioButtonInformation.Text = "Information"
        Me.RadioButtonInformation.UseVisualStyleBackColor = True
        '
        'RadioButtonExclamation
        '
        Me.RadioButtonExclamation.AutoSize = True
        Me.RadioButtonExclamation.Location = New System.Drawing.Point(21, 98)
        Me.RadioButtonExclamation.Name = "RadioButtonExclamation"
        Me.RadioButtonExclamation.Size = New System.Drawing.Size(82, 17)
        Me.RadioButtonExclamation.TabIndex = 9
        Me.RadioButtonExclamation.Text = "Exclamation"
        Me.RadioButtonExclamation.UseVisualStyleBackColor = True
        '
        'RadioButtonQuestion
        '
        Me.RadioButtonQuestion.AutoSize = True
        Me.RadioButtonQuestion.Location = New System.Drawing.Point(21, 75)
        Me.RadioButtonQuestion.Name = "RadioButtonQuestion"
        Me.RadioButtonQuestion.Size = New System.Drawing.Size(67, 17)
        Me.RadioButtonQuestion.TabIndex = 8
        Me.RadioButtonQuestion.Text = "Question"
        Me.RadioButtonQuestion.UseVisualStyleBackColor = True
        '
        'RadioButtonCritical
        '
        Me.RadioButtonCritical.AutoSize = True
        Me.RadioButtonCritical.Location = New System.Drawing.Point(21, 52)
        Me.RadioButtonCritical.Name = "RadioButtonCritical"
        Me.RadioButtonCritical.Size = New System.Drawing.Size(56, 17)
        Me.RadioButtonCritical.TabIndex = 7
        Me.RadioButtonCritical.Text = "Critical"
        Me.RadioButtonCritical.UseVisualStyleBackColor = True
        '
        'RadioButtonNone
        '
        Me.RadioButtonNone.AutoSize = True
        Me.RadioButtonNone.Checked = True
        Me.RadioButtonNone.Location = New System.Drawing.Point(21, 29)
        Me.RadioButtonNone.Name = "RadioButtonNone"
        Me.RadioButtonNone.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonNone.TabIndex = 0
        Me.RadioButtonNone.TabStop = True
        Me.RadioButtonNone.Text = "None"
        Me.RadioButtonNone.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButtonDefaultButton3)
        Me.GroupBox3.Controls.Add(Me.RadioButtonNone2)
        Me.GroupBox3.Controls.Add(Me.RadioButtonDefaultButton2)
        Me.GroupBox3.Location = New System.Drawing.Point(386, 132)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(155, 115)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Default Button"
        '
        'RadioButtonDefaultButton3
        '
        Me.RadioButtonDefaultButton3.AutoSize = True
        Me.RadioButtonDefaultButton3.Location = New System.Drawing.Point(22, 75)
        Me.RadioButtonDefaultButton3.Name = "RadioButtonDefaultButton3"
        Me.RadioButtonDefaultButton3.Size = New System.Drawing.Size(65, 17)
        Me.RadioButtonDefaultButton3.TabIndex = 11
        Me.RadioButtonDefaultButton3.Text = "Button 3"
        Me.RadioButtonDefaultButton3.UseVisualStyleBackColor = True
        '
        'RadioButtonNone2
        '
        Me.RadioButtonNone2.AutoSize = True
        Me.RadioButtonNone2.Checked = True
        Me.RadioButtonNone2.Location = New System.Drawing.Point(22, 29)
        Me.RadioButtonNone2.Name = "RadioButtonNone2"
        Me.RadioButtonNone2.Size = New System.Drawing.Size(65, 17)
        Me.RadioButtonNone2.TabIndex = 9
        Me.RadioButtonNone2.TabStop = True
        Me.RadioButtonNone2.Text = "Button 1"
        Me.RadioButtonNone2.UseVisualStyleBackColor = True
        '
        'RadioButtonDefaultButton2
        '
        Me.RadioButtonDefaultButton2.AutoSize = True
        Me.RadioButtonDefaultButton2.Location = New System.Drawing.Point(22, 52)
        Me.RadioButtonDefaultButton2.Name = "RadioButtonDefaultButton2"
        Me.RadioButtonDefaultButton2.Size = New System.Drawing.Size(65, 17)
        Me.RadioButtonDefaultButton2.TabIndex = 10
        Me.RadioButtonDefaultButton2.Text = "Button 2"
        Me.RadioButtonDefaultButton2.UseVisualStyleBackColor = True
        '
        'CheckBoxSystemModal
        '
        Me.CheckBoxSystemModal.AutoSize = True
        Me.CheckBoxSystemModal.Location = New System.Drawing.Point(386, 254)
        Me.CheckBoxSystemModal.Name = "CheckBoxSystemModal"
        Me.CheckBoxSystemModal.Size = New System.Drawing.Size(92, 17)
        Me.CheckBoxSystemModal.TabIndex = 8
        Me.CheckBoxSystemModal.Text = "System Modal"
        Me.CheckBoxSystemModal.UseVisualStyleBackColor = True
        '
        'CheckBoxMsgBoxSetForeground
        '
        Me.CheckBoxMsgBoxSetForeground.AutoSize = True
        Me.CheckBoxMsgBoxSetForeground.Location = New System.Drawing.Point(386, 278)
        Me.CheckBoxMsgBoxSetForeground.Name = "CheckBoxMsgBoxSetForeground"
        Me.CheckBoxMsgBoxSetForeground.Size = New System.Drawing.Size(96, 17)
        Me.CheckBoxMsgBoxSetForeground.TabIndex = 9
        Me.CheckBoxMsgBoxSetForeground.Text = "Always on Top"
        Me.CheckBoxMsgBoxSetForeground.UseVisualStyleBackColor = True
        '
        'CheckBoxMsgBoxRight
        '
        Me.CheckBoxMsgBoxRight.AutoSize = True
        Me.CheckBoxMsgBoxRight.Location = New System.Drawing.Point(386, 302)
        Me.CheckBoxMsgBoxRight.Name = "CheckBoxMsgBoxRight"
        Me.CheckBoxMsgBoxRight.Size = New System.Drawing.Size(89, 17)
        Me.CheckBoxMsgBoxRight.TabIndex = 10
        Me.CheckBoxMsgBoxRight.Text = "Right-Aligned"
        Me.CheckBoxMsgBoxRight.UseVisualStyleBackColor = True
        '
        'CheckBoxMsgBoxRtlReading
        '
        Me.CheckBoxMsgBoxRtlReading.AutoSize = True
        Me.CheckBoxMsgBoxRtlReading.Location = New System.Drawing.Point(495, 302)
        Me.CheckBoxMsgBoxRtlReading.Name = "CheckBoxMsgBoxRtlReading"
        Me.CheckBoxMsgBoxRtlReading.Size = New System.Drawing.Size(47, 17)
        Me.CheckBoxMsgBoxRtlReading.TabIndex = 11
        Me.CheckBoxMsgBoxRtlReading.Text = "RTL"
        Me.CheckBoxMsgBoxRtlReading.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(304, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Show MsgBox"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(440, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Copy to Clipboard"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxReturn
        '
        Me.TextBoxReturn.Location = New System.Drawing.Point(379, 74)
        Me.TextBoxReturn.Name = "TextBoxReturn"
        Me.TextBoxReturn.ReadOnly = True
        Me.TextBoxReturn.Size = New System.Drawing.Size(149, 20)
        Me.TextBoxReturn.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(301, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Return Value:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "MsgBox statement:"
        '
        'TextBoxStatement
        '
        Me.TextBoxStatement.Location = New System.Drawing.Point(26, 353)
        Me.TextBoxStatement.Multiline = True
        Me.TextBoxStatement.Name = "TextBoxStatement"
        Me.TextBoxStatement.ReadOnly = True
        Me.TextBoxStatement.Size = New System.Drawing.Size(515, 78)
        Me.TextBoxStatement.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 451)
        Me.Controls.Add(Me.TextBoxStatement)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxReturn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBoxMsgBoxRtlReading)
        Me.Controls.Add(Me.CheckBoxMsgBoxRight)
        Me.Controls.Add(Me.CheckBoxMsgBoxSetForeground)
        Me.Controls.Add(Me.CheckBoxSystemModal)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBoxNoTitle)
        Me.Controls.Add(Me.TextBoxPrompt)
        Me.Controls.Add(Me.TextBoxTitle)
        Me.Controls.Add(Me.LabelPrompt)
        Me.Controls.Add(Me.LabelTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents LabelPrompt As System.Windows.Forms.Label
    Friend WithEvents TextBoxTitle As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrompt As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxNoTitle As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonRetryCancel As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonYesNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonYesNoCancel As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonAbortRetryIgnore As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonOkCancel As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonOkOnly As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonInformation As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonExclamation As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonQuestion As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCritical As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonNone As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonDefaultButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonNone2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDefaultButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBoxSystemModal As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMsgBoxSetForeground As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMsgBoxRight As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMsgBoxRtlReading As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBoxReturn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxStatement As System.Windows.Forms.TextBox

End Class
