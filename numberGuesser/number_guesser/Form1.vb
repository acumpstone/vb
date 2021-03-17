'Alexis Cumpstone
'Nov 3 2015
'Number Guesser

'To do:
'handle "enter" button
'Add sound/music
'final edit - comments!!!

Public Class formNumberGuesser

    'random Number as an integer
    Dim randNum As Integer
    'time remaining as an integer
    Dim timeLeft As Integer = 60
    'has buttonGuess been clikced, as Boolean
    Dim btnGuessClicked As Boolean

    'Form loads or reloads
    Private Sub formNumberGuesser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Clear TextBox1
        TextBox1.Text = ""
        'Reset the label
        lblGuessStatus.Text = "Guess the number!"
        'Set a random number for the user to guess
        Randomize()
        randNum = Rand(1, 1000)
        btnGuessClicked = False
        'Reset the timer and time left label
        timeLeft = 60
        lblTimeLeft.Text = "60"
        'lblTimeLeft color is black
        lblTimeLeft.ForeColor = Color.Black
        'Stop the timer so it doesn't count down before the user starts guessing
        Timer1.Stop()
        'Enable all buttons and the textbox (the "Reset" button doesn't need to be enabled because it is never disabled)
        btnGuess.Enabled = True
        btnHint1.Enabled = True
        btnHint2.Enabled = True
        TextBox1.Text = ""
        'Starts the music, loop it
        My.Computer.Audio.Play(My.Resources.Countdown_Music_Edited, AudioPlayMode.BackgroundLoop)
    End Sub

    '===============================================
    'Rand Return  a random number in a given range.
    '
    'Parameters:
    ' Low - The lower bounds of the range.
    ' High - The upper bounds of the range.
    '
    'Returns:
    ' Returns a random number from Low..High.
    '===============================================
    Public Function Rand(ByVal Low As Long, ByVal High As Long) As Long
        Rand = Int((High - Low + 1) * Rnd()) + Low
    End Function

    'User clicks "Guess" button
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnGuess.Click
        'Starts the countdown (timer)
        Timer1.Start()

        'If the Guess input is not a number, change the label to tell the user to input a numeric value
        If IsNumeric(TextBox1.Text) = False Then
            lblGuessStatus.Text = "Please input a NUMBER"
        ElseIf TextBox1.Text > randNum Then
            'If the user's input is greater than 1000, refer the user to Hint 1
            If TextBox1.Text >= 1000 Then
                lblGuessStatus.Text = "Please see Hint 1"
            Else
                'If the user's guess is greater than the randNum, tell the user
                lblGuessStatus.Text = "Too high. Guess again!"
            End If
        ElseIf TextBox1.Text < randNum Then
            'If the user's input is less than 0, refer the user to Hint 1
            If TextBox1.Text <= 0 Then
                lblGuessStatus.Text = "Please see Hint 1"
            Else
                'If the user's guess is less than the randNum, tell the user
                lblGuessStatus.Text = "Too low. Guess again!"
            End If
        Else
            'If the guess is neither to high nor low, the guess must be correct
            'Congratulate the user, stop the timer, disable all buttons except for "Reset" (it was never disabled)
            lblGuessStatus.Text = "You have guessed the number!"
            Timer1.Stop()
            btnGuess.Enabled = False
            btnHint1.Enabled = False
            btnHint2.Enabled = False
            'Stop the background music
            My.Computer.Audio.Stop()
        End If

        'the "Guess" button has been clicked, so "btnGuessClicked" is True
        btnGuessClicked = True

    End Sub

    'User clicks "Reset" button
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        'reload the form
        formNumberGuesser_Load(Me, New EventArgs)
    End Sub

    'User clicks "Hint 1" button
    Private Sub btnHint1_Click(sender As System.Object, e As System.EventArgs) Handles btnHint1.Click
        'If the user has clicked the Guess button and thus begun the game
        If btnGuessClicked = True Then
            'Stop the timer while the user reads the hint
            Timer1.Stop()
            'Display the first hint in a message box
            MsgBox("The number is between 1 and 1000")
            'Start the timer back up
            Timer1.Start()
            'Disable the "Hint 1" button
            btnHint1.Enabled = False
        Else
            'Display the first hint in a message box
            MsgBox("The number is between 1 and 1000")
            'Disable the "Hint 1" button
            btnHint1.Enabled = False
        End If
    End Sub

    'User clicks "Hint 2" button
    Private Sub btnHint2_Click(sender As System.Object, e As System.EventArgs) Handles btnHint2.Click
        'If the user has clicked the Guess button and thus begun the game
        If btnGuessClicked = True Then
            'Stop the timer while the user reads the hint
            Timer1.Stop()
            'Display the second hint in a message box
            MsgBox("Try utilizing the binary search strategy to increase your speed.")
            'Start the timer back up
            Timer1.Start()
            'Disable the "Hint 2" button
            btnHint2.Enabled = False
        Else
            'Display the first hint in a message box
            MsgBox("Try utilizing the binary search strategy to increase your speed.")
            'Disable the "Hint 2" button
            btnHint2.Enabled = False
        End If
    End Sub

    'At each timer tick (1000 milliseconds)
    Private Sub Timer1_Tick() Handles Timer1.Tick
        'If there is still time left
        If timeLeft > 0 Then
            'Subtract one second, display new time in the timeLabel
            timeLeft -= 1
            lblTimeLeft.Text = timeLeft
            'If there are 10 seconds or less left
            If timeLeft <= 10 And
                timeLeft >= 2 Then
                'Change the timeLabel text color to red
                lblTimeLeft.ForeColor = Color.Red
                'Play a 'beeping' sound each second to alert the user that time is running out
                My.Computer.Audio.Play(My.Resources.Countdown_Timer_Edited, AudioPlayMode.Background)
            ElseIf timeLeft = 1 Then
                'keep the color of the label red
                lblTimeLeft.ForeColor = Color.Red
                'Play sound effect signalling that the user lost the game (user must wait for the sound to complete to continue)
                My.Computer.Audio.Play(My.Resources.wah_wah_sound_effect_edited, AudioPlayMode.Background)
            End If
        Else
            ' If the user ran out of time, stop the timer, disable and reset the text box, disable all buttons except for the "Reset" button
            Timer1.Stop()
            lblTimeLeft.Text = "0"
            lblGuessStatus.Text = "Time's up!"
            btnGuess.Enabled = False
            btnHint1.Enabled = False
            btnHint2.Enabled = False
            TextBox1.Text = ""
            TextBox1.Enabled = False
        End If

    End Sub
End Class

