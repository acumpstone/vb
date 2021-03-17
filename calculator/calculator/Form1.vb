'Calculator
'Alexis Cumpstone
'October 13 2015
'Victoria High School

'Thanks to Sterling and Mr.Gibson who helped with the following code.

Public Class formCalculator

    'Declares variables for the final answer, 
    'first and second number entered
    'and the chosen operation
    Dim finalAnswer As Double
    Dim firstNumber As Double
    Dim secondNumber As Double = 0
    Dim operation As Integer



    'When user clicks a button, inputs the corresponding number/symbol into txtBox1
    Private Sub btnChangeSign_Click(sender As System.Object, e As System.EventArgs) Handles btnChangeSign.Click
        txtBox1.Text = "-" + txtBox1.Text
        'Disable the negative button so the number cannot have more than one negative sign
        btnChangeSign.Enabled = False
    End Sub

    Private Sub btnDecimal_Click(sender As System.Object, e As System.EventArgs) Handles btnDecimal.Click
        txtBox1.Text = txtBox1.Text + "."
        'Disable the decimal button so the number cannot have more than one decimal 
        btnDecimal.Enabled = False
    End Sub

    Private Sub btn0_Click(sender As System.Object, e As System.EventArgs) Handles btn0.Click
        If Me.txtBox1.Text = "0" And btnDecimal.Enabled = True Then
            Me.txtBox1.Text = 0
        Else
            txtBox1.Text = txtBox1.Text = "0"
        End If
    End Sub

    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        If Me.txtBox1.Text = "0" And btnDecimal.Enabled = True Then
            Me.txtBox1.Text = 1
        Else
            txtBox1.Text = txtBox1.Text + "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        If Me.txtBox1.Text = "0" And btnDecimal.Enabled = True Then
            Me.txtBox1.Text = 2
        Else
            txtBox1.Text = txtBox1.Text + "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        If Me.txtBox1.Text = "0" And btnDecimal.Enabled = True Then
            Me.txtBox1.Text = 3
        Else
            txtBox1.Text = txtBox1.Text + "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btn4.Click
        If Me.txtBox1.Text = "0" And btnDecimal.Enabled = True Then
            Me.txtBox1.Text = 4
        Else
            txtBox1.Text = txtBox1.Text + "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click
        If Me.txtBox1.Text = "0" And btnDecimal.Enabled = True Then
            Me.txtBox1.Text = 5
        Else
            txtBox1.Text = txtBox1.Text + "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs) Handles btn6.Click
        If Me.txtBox1.Text = "0" And btnDecimal.Enabled = True Then
            Me.txtBox1.Text = 6
        Else
            txtBox1.Text = txtBox1.Text + "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As System.Object, e As System.EventArgs) Handles btn7.Click
        If Me.txtBox1.Text = "0" And btnDecimal.Enabled = True Then
            Me.txtBox1.Text = 7
        Else
            txtBox1.Text = txtBox1.Text + "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As System.Object, e As System.EventArgs) Handles btn8.Click
        If Me.txtBox1.Text = "0" And btnDecimal.Enabled = True Then
            Me.txtBox1.Text = 8
        Else
            txtBox1.Text = txtBox1.Text + "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As System.Object, e As System.EventArgs) Handles btn9.Click
        If Me.txtBox1.Text = "0" And btnDecimal.Enabled = True Then
            Me.txtBox1.Text = 9
        Else
            txtBox1.Text = txtBox1.Text + "9"
        End If
    End Sub

    'when an operation button is clicked:
    'whatever is in the textbox is stored in the global variable firstNumber
    'the the label is changed to display "2nd value"
    'the textbox is cleared
    'the decimal, negative, and equals signs are enabled
    'the operation buttons are disabled
    'a value is stored in the global variable "operation" based on what button the user clicked

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        firstNumber = Me.txtBox1.Text
        Me.lblValue1.Text = "2nd Value"
        Me.txtBox1.Text = "0"
        btnDecimal.Enabled = True
        btnChangeSign.Enabled = True
        btnEquals.Enabled = True
        btnAdd.Enabled = False
        btnSubtract.Enabled = False
        btnMultiply.Enabled = False
        btnDivide.Enabled = False
        operation = 3
    End Sub

    Private Sub btnSubtract_Click(sender As System.Object, e As System.EventArgs) Handles btnSubtract.Click
        firstNumber = Me.txtBox1.Text
        Me.lblValue1.Text = "2nd Value"
        Me.txtBox1.Text = "0"
        btnDecimal.Enabled = True
        btnChangeSign.Enabled = True
        btnEquals.Enabled = True
        btnAdd.Enabled = False
        btnSubtract.Enabled = False
        btnMultiply.Enabled = False
        btnDivide.Enabled = False
        operation = 4
    End Sub

    Private Sub btnMultiply_Click(sender As System.Object, e As System.EventArgs) Handles btnMultiply.Click
        firstNumber = Me.txtBox1.Text
        Me.lblValue1.Text = "2nd Value"
        Me.txtBox1.Text = "0"
        btnDecimal.Enabled = True
        btnChangeSign.Enabled = True
        btnEquals.Enabled = True
        btnAdd.Enabled = False
        btnSubtract.Enabled = False
        btnMultiply.Enabled = False
        btnDivide.Enabled = False
        operation = 1
    End Sub

    Private Sub btnDivide_Click(sender As System.Object, e As System.EventArgs) Handles btnDivide.Click
        firstNumber = Me.txtBox1.Text
        Me.lblValue1.Text = "2nd Value"
        Me.txtBox1.Text = "0"
        btnDecimal.Enabled = True
        btnChangeSign.Enabled = True
        btnEquals.Enabled = True
        btnAdd.Enabled = False
        btnSubtract.Enabled = False
        btnMultiply.Enabled = False
        btnDivide.Enabled = False
        operation = 2
    End Sub

    'When the clear button is clicked:
    'set the value of the firstNumber and secondNumber variables to nothing
    'change lblValue1's text to 1st value
    'erase all character from the text box
    'enable all buttons except for the equals button

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        firstNumber = 0
        secondNumber = 0
        Me.lblValue1.Text = "1st Value"
        Me.txtBox1.Text = "0"
        btnDecimal.Enabled = True
        btnChangeSign.Enabled = True
        btnAdd.Enabled = True
        btnSubtract.Enabled = True
        btnMultiply.Enabled = True
        btnDivide.Enabled = True
        btnEquals.Enabled = False
        btnClear.Enabled = True
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        btn0.Enabled = True
    End Sub

    'When the equals button is clicked, perform the calculation based on the first and second number inputed, as well as the operation selected

    Private Sub btnEquals_Click(sender As System.Object, e As System.EventArgs) Handles btnEquals.Click
        secondNumber = Me.txtBox1.Text
        If operation = 1 Then
            'multiply
            finalAnswer = firstNumber * secondNumber
            Me.txtBox1.Text = finalAnswer
        ElseIf operation = 2 Then
            'divide
            If secondNumber = 0 Then
                'Anything divided by zero is arguably infinity
                Me.txtBox1.Text = "Infinity"
            Else
                finalAnswer = firstNumber / secondNumber
                Me.txtBox1.Text = finalAnswer
            End If
        ElseIf operation = 3 Then
            'add
            finalAnswer = firstNumber + secondNumber
            Me.txtBox1.Text = finalAnswer
        ElseIf operation = 4 Then
            'minus
            finalAnswer = firstNumber - secondNumber
            Me.txtBox1.Text = finalAnswer
        End If

        'resets the value of the operation variable
        operation = 0

        'Disables everything except the clear button

        btnDecimal.Enabled = False
        btnChangeSign.Enabled = False
        btnAdd.Enabled = False
        btnSubtract.Enabled = False
        btnMultiply.Enabled = False
        btnDivide.Enabled = False
        btnEquals.Enabled = False
        btnClear.Enabled = True
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
        btn0.Enabled = False

    End Sub

    'When the 'Exit' button is clicked, end the program

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
