Public Class Form1

    Dim num1 As Double
    Dim num2 As Double

    Dim result As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Hide Output label
        Label_Value.Text = ""

    End Sub


    'Perform arithmetic operation based on input. Display Result
    Private Sub Button_Calulate_Click(sender As Object, e As EventArgs) Handles Button_Calulate.Click


        Try
            If String.IsNullOrEmpty(TextBox_Num1.Text) Or String.IsNullOrEmpty(TextBox_Num1.Text) Then
                Throw New Exception("It appears some of your entries are empty. Please fill in all fields.")
            Else
                'Assign Input using Double Data Type Conversion
                num1 = CDbl(TextBox_Num1.Text)
                num2 = CDbl(TextBox_Num2.Text)

                'Perform Operation based on User Selection
                If RadioButton_Add.Checked Then
                    result = num1 + num2
                ElseIf RadioButton_Subtract.Checked Then
                    result = num1 - num2
                ElseIf RadioButton_Multiply.Checked Then
                    result = num1 * num2
                ElseIf RadioButton_Divide.Checked Then
                    'Check if the Divisor (Number 2) is zero
                    If num2 = 0 Then
                        'Throw Exception
                        Throw New Exception("Mathematical Error. Division by Zero is Undefined ")
                    Else
                        result = num1 / num2
                    End If
                Else
                    'Throw Exception if None of the RadioButtons has been selected
                    Throw New Exception("Error: Please select an operator")
                End If
            End If
            'Assign output using String Data Type Conversion. Rounding Decimal to prevent long tails behind the decimal.
            Label_Value.Text = CStr(Math.Round(result, 5))
        Catch ex As Exception
            'Pop caught Exceptions in a New MessageBox
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
