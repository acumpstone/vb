'Alexis Cumpstone
'December 7 2015

Public Class Form1

    'When the Encrypt button is clicked
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnEncrypt.Click
        'Store the value of the track bar in a local variable
        Dim selectedNum As Integer = TrackBar1.Value
        'Reset the second text box each time the user presses the button
        TextBox2.Text = ""
        'Store the submitted string into another local variables
        Dim startString As String = TextBox1.Text
        'For each index of the string:
        For index As Integer = 0 To startString.Length - 1 Step 1
            'Store the unicode value of each character in the startString
            Dim stringNum As Integer = AscW(startString.Substring(index, 1))
            'Add the value of the track bar to stringNum
            stringNum += selectedNum
            'Store the corresponding character of each changed unicode value in a third local varibale
            Dim finalString As String = ChrW(stringNum)
            'Display the final string in the second text box
            TextBox2.Text += finalString
        Next

    End Sub

    Private Sub btnQuestion_Click(sender As System.Object, e As System.EventArgs) Handles btnQuestion.Click
        'When the first "?" button is pressed, display the encryption/decryption instructions in a message box
        MsgBox("To encrypt your message, type it into the first text box, select a positive number on the track bar, and press the encrypt/decrypt button. To decrypt your message, type the encrypted message in the first text box. Then, select the correpsonding negative value used to encrypt the message (if a value of 3 was used the encrypt the message, a value of -3 would be used to decrypt it). Finally, press the encrypt/decrypt button.")
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'When the form loads, start playing the mission impossible theme in the backround in a loop
        My.Computer.Audio.Play(My.Resources.missionImpossibleTheme, AudioPlayMode.BackgroundLoop)
    End Sub

    'When the backwards button is clicked:
    Private Sub btnBackwards_Click(sender As System.Object, e As System.EventArgs) Handles btnBackwards.Click
        'Reset the second text box each time the user presses the button
        TextBox2.Text = ""
        'Store the submitted string into a local variables
        Dim startString As String = TextBox1.Text
        'Set space aside for the final backwards string (this allows use of it outside the for loop)
        Dim finalString As String = ""
        'For each index of the string (going backwards):
        For index As Integer = startString.Length - 1 To 0 Step -1
            'Store the current character into a local variable
            finalString += startString.Substring(index, 1)
        Next
        'Display the finalString in the second text box
        TextBox2.Text = finalString
    End Sub

    Private Sub btnBackwardsInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnBackwardsInfo.Click
        'When the second "?" button is pressed, display the monogram instructions in a message box
        MsgBox("Enter some text into the first text box, and press the backwards button to see your message displayed backwards.")
    End Sub

    'When the monogram button is clicked:
    Private Sub btnMonograms_Click(sender As System.Object, e As System.EventArgs) Handles btnAcronym.Click
        'Reset the second text box each time the user presses the button
        TextBox2.Text = ""
        'Store the submitted string into a local variables
        Dim startString As String = TextBox1.Text
        'Set space aside for the final backwards string (this allows use of it outside the for loop)
        Dim finalString As String = ""
        'For each index of the startString:
        For index As Integer = 0 To startString.Length - 1 Step 1

            Dim currentChar = startString.Substring(index, 1)
            If index = 0 Then
                finalString += currentChar
            End If
            If currentChar = " " Then
                finalString += startString.Substring(index + 1, 1)
            End If
        Next
        'Display the finalString in the second text box
        TextBox2.Text = finalString.ToUpper
    End Sub

    Private Sub btnMonogramInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnAcronymInfo.Click
        'When the third "?" button is pressed, display the acronym instructions in a message box
        MsgBox("The Acronym button turns your submitted string into a word using the first letter of each submitted word.")
    End Sub
End Class
