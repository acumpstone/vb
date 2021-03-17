'Alexis Cumpstone
'Started November 23, 2015



Public Class Form1

    'Stores space for the amount of change the user is requesting, as an integer
    Dim changeAmount As Integer


    Private Sub btnMakeChange_Click(sender As System.Object, e As System.EventArgs) Handles btnMakeChange.Click

        'If the user has entered a numeric value less than 100 into txtBoxEnterChange
        If IsNumeric(txtBoxEnterChange.Text) = True And
            txtBoxEnterChange.Text < 100 And
            txtBoxEnterChange.Text >= 0 Then
            'Store the entered value into the changeAmount variable
            changeAmount = txtBoxEnterChange.Text
        Else
            'Tell the user to enter a numeric value less than 100
            MsgBox("Please enter a numeric value less than 100 and more than 0 into the text box.")
        End If

        If changeAmount >= 75 Then
            lblNumQuarters.Text = "3"
            If (changeAmount - 75) >= 20 Then
                lblNumDimes.Text = "2"
                lblNumNickels.Text = "0"
                lblNumPennies.Text = changeAmount - 95
            ElseIf (changeAmount - 75) >= 10 Then
                lblNumDimes.Text = "1"
                If (changeAmount - 85) >= 5 Then
                    lblNumNickels.Text = "1"
                    lblNumPennies.Text = changeAmount - 90
                Else
                    lblNumNickels.Text = "0"
                    lblNumPennies.Text = changeAmount - 85
                End If
            ElseIf (changeAmount - 75) >= 5 Then
                lblNumDimes.Text = "0"
                lblNumNickels.Text = "1"
                lblNumPennies.Text = changeAmount - 80
            Else
                lblNumDimes.Text = "0"
                lblNumNickels.Text = "0"
                lblNumPennies.Text = changeAmount - 75
            End If
        ElseIf changeAmount >= 50 Then
            lblNumQuarters.Text = "2"
            If (changeAmount - 50) >= 20 Then
                lblNumDimes.Text = "2"
                lblNumNickels.Text = "0"
                lblNumPennies.Text = changeAmount - 70
            ElseIf (changeAmount - 50) >= 10 Then
                lblNumDimes.Text = "1"
                If (changeAmount - 60) >= 5 Then
                    lblNumNickels.Text = "1"
                    lblNumPennies.Text = changeAmount - 65
                Else
                    lblNumNickels.Text = "0"
                    lblNumPennies.Text = changeAmount - 60
                End If
            ElseIf (changeAmount - 50) >= 5 Then
                lblNumDimes.Text = "0"
                lblNumNickels.Text = "1"
                lblNumPennies.Text = changeAmount - 55
            Else
                lblNumDimes.Text = "0"
                lblNumNickels.Text = "0"
                lblNumPennies.Text = changeAmount - 50
            End If
        ElseIf changeAmount >= 25 Then
            lblNumQuarters.Text = "1"
            If (changeAmount - 25) >= 20 Then
                lblNumDimes.Text = "2"
                lblNumNickels.Text = "0"
                lblNumPennies.Text = changeAmount - 45
            ElseIf (changeAmount - 25) >= 10 Then
                lblNumDimes.Text = "1"
                If (changeAmount - 35) >= 5 Then
                    lblNumNickels.Text = "1"
                    lblNumPennies.Text = changeAmount - 40
                Else
                    lblNumNickels.Text = "0"
                    lblNumPennies.Text = changeAmount - 35
                End If
            ElseIf (changeAmount - 25) >= 5 Then
                lblNumDimes.Text = "0"
                lblNumNickels.Text = "1"
                lblNumPennies.Text = changeAmount - 30
            Else
                lblNumDimes.Text = "0"
                lblNumNickels.Text = "0"
                lblNumPennies.Text = changeAmount - 25
            End If
        ElseIf changeAmount >= 20 Then
            lblNumQuarters.Text = "0"
            lblNumDimes.Text = "2"
            lblNumNickels.Text = "0"
            lblNumPennies.Text = changeAmount - 20
        ElseIf changeAmount >= 10 Then
            lblNumQuarters.Text = "0"
            lblNumDimes.Text = "1"
            If (changeAmount - 10) >= 5 Then
                lblNumNickels.Text = "1"
                lblNumPennies.Text = changeAmount - 15
            Else
                lblNumNickels.Text = "0"
                lblNumPennies.Text = changeAmount - 10
            End If
        ElseIf changeAmount >= 5 Then
            lblNumQuarters.Text = "0"
            lblNumDimes.Text = "0"
            lblNumNickels.Text = "1"
            lblNumPennies.Text = changeAmount - 5
        Else
            lblNumQuarters.Text = "0"
            lblNumDimes.Text = "0"
            lblNumNickels.Text = "0"
            lblNumPennies.Text = changeAmount
        End If

    End Sub
End Class
