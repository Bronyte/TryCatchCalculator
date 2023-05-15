<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox_Input = New GroupBox()
        RadioButton_Subtract = New RadioButton()
        RadioButton_Add = New RadioButton()
        RadioButton_Divide = New RadioButton()
        RadioButton_Multiply = New RadioButton()
        TextBox_Num2 = New TextBox()
        TextBox_Num1 = New TextBox()
        Label_Num2 = New Label()
        Label_Num1 = New Label()
        Button_Calulate = New Button()
        Label_Answer = New Label()
        Label_Value = New Label()
        GroupBox_Input.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox_Input
        ' 
        GroupBox_Input.Controls.Add(RadioButton_Subtract)
        GroupBox_Input.Controls.Add(RadioButton_Add)
        GroupBox_Input.Controls.Add(RadioButton_Divide)
        GroupBox_Input.Controls.Add(RadioButton_Multiply)
        GroupBox_Input.Controls.Add(TextBox_Num2)
        GroupBox_Input.Controls.Add(TextBox_Num1)
        GroupBox_Input.Controls.Add(Label_Num2)
        GroupBox_Input.Controls.Add(Label_Num1)
        GroupBox_Input.Location = New Point(12, 12)
        GroupBox_Input.Name = "GroupBox_Input"
        GroupBox_Input.Size = New Size(348, 111)
        GroupBox_Input.TabIndex = 0
        GroupBox_Input.TabStop = False
        GroupBox_Input.Text = "Input"
        ' 
        ' RadioButton_Subtract
        ' 
        RadioButton_Subtract.AutoSize = True
        RadioButton_Subtract.Location = New Point(159, 63)
        RadioButton_Subtract.Name = "RadioButton_Subtract"
        RadioButton_Subtract.Size = New Size(69, 19)
        RadioButton_Subtract.TabIndex = 2
        RadioButton_Subtract.TabStop = True
        RadioButton_Subtract.Text = "Subtract"
        RadioButton_Subtract.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_Add
        ' 
        RadioButton_Add.AutoSize = True
        RadioButton_Add.Location = New Point(159, 34)
        RadioButton_Add.Name = "RadioButton_Add"
        RadioButton_Add.Size = New Size(47, 19)
        RadioButton_Add.TabIndex = 2
        RadioButton_Add.TabStop = True
        RadioButton_Add.Text = "Add"
        RadioButton_Add.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_Divide
        ' 
        RadioButton_Divide.AutoSize = True
        RadioButton_Divide.Location = New Point(232, 63)
        RadioButton_Divide.Name = "RadioButton_Divide"
        RadioButton_Divide.Size = New Size(58, 19)
        RadioButton_Divide.TabIndex = 2
        RadioButton_Divide.TabStop = True
        RadioButton_Divide.Text = "Divide"
        RadioButton_Divide.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_Multiply
        ' 
        RadioButton_Multiply.AutoSize = True
        RadioButton_Multiply.Location = New Point(232, 34)
        RadioButton_Multiply.Name = "RadioButton_Multiply"
        RadioButton_Multiply.Size = New Size(69, 19)
        RadioButton_Multiply.TabIndex = 2
        RadioButton_Multiply.TabStop = True
        RadioButton_Multiply.Text = "Multiply"
        RadioButton_Multiply.UseVisualStyleBackColor = True
        ' 
        ' TextBox_Num2
        ' 
        TextBox_Num2.Location = New Point(75, 59)
        TextBox_Num2.Name = "TextBox_Num2"
        TextBox_Num2.Size = New Size(61, 23)
        TextBox_Num2.TabIndex = 1
        ' 
        ' TextBox_Num1
        ' 
        TextBox_Num1.Location = New Point(75, 30)
        TextBox_Num1.Name = "TextBox_Num1"
        TextBox_Num1.Size = New Size(61, 23)
        TextBox_Num1.TabIndex = 1
        ' 
        ' Label_Num2
        ' 
        Label_Num2.AutoSize = True
        Label_Num2.Location = New Point(6, 63)
        Label_Num2.Name = "Label_Num2"
        Label_Num2.Size = New Size(63, 15)
        Label_Num2.TabIndex = 0
        Label_Num2.Text = "Number 2:"
        ' 
        ' Label_Num1
        ' 
        Label_Num1.AutoSize = True
        Label_Num1.Location = New Point(6, 33)
        Label_Num1.Name = "Label_Num1"
        Label_Num1.Size = New Size(63, 15)
        Label_Num1.TabIndex = 0
        Label_Num1.Text = "Number 1:"
        ' 
        ' Button_Calulate
        ' 
        Button_Calulate.Location = New Point(106, 145)
        Button_Calulate.Name = "Button_Calulate"
        Button_Calulate.Size = New Size(75, 23)
        Button_Calulate.TabIndex = 1
        Button_Calulate.Text = "Calculate"
        Button_Calulate.UseVisualStyleBackColor = True
        ' 
        ' Label_Answer
        ' 
        Label_Answer.AutoSize = True
        Label_Answer.Location = New Point(227, 149)
        Label_Answer.Name = "Label_Answer"
        Label_Answer.Size = New Size(49, 15)
        Label_Answer.TabIndex = 2
        Label_Answer.Text = "Answer:"
        ' 
        ' Label_Value
        ' 
        Label_Value.AutoSize = True
        Label_Value.Location = New Point(282, 149)
        Label_Value.Name = "Label_Value"
        Label_Value.Size = New Size(41, 15)
        Label_Value.TabIndex = 2
        Label_Value.Text = "VALUE"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(369, 180)
        Controls.Add(Label_Value)
        Controls.Add(Label_Answer)
        Controls.Add(Button_Calulate)
        Controls.Add(GroupBox_Input)
        Name = "Form1"
        Text = "Calculator"
        GroupBox_Input.ResumeLayout(False)
        GroupBox_Input.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox_Input As GroupBox
    Friend WithEvents Label_Num1 As Label
    Friend WithEvents RadioButton_Subtract As RadioButton
    Friend WithEvents RadioButton_Add As RadioButton
    Friend WithEvents RadioButton_Multiply As RadioButton
    Friend WithEvents TextBox_Num2 As TextBox
    Friend WithEvents TextBox_Num1 As TextBox
    Friend WithEvents Label_Num2 As Label
    Friend WithEvents RadioButton_Divide As RadioButton
    Friend WithEvents Button_Calulate As Button
    Friend WithEvents Label_Answer As Label
    Friend WithEvents Label_Value As Label
End Class
