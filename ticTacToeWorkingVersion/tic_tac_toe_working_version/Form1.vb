'Alexis Cumpstone
'October 19 2015 - December 3 2015
'Tic Tac Toe


'Thank you to Mr.Gibson (Destroyer of Worlds) and Sterling for help with the following code

Public Class formTicTacToe

    'Global variable for player's turn as an integer (1, 2, etc.)
    Dim turn As Integer
    'Global variable for number of squares used in game as integer (1, 2, etc.) 
    Dim squaresUsed As Integer
    'Flag for which game mode is selected
    Dim gameMode As Integer



    Private Sub checkWin()
        'If it is the first player's turn, check if there is a winning line of X's in any one of the 3 vertical lines, 3 horizontal lines, or both diagonal lines
        If turn = 1 Then
            'If player 1 wins
            If (btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X") Or
                (btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X") Or
                (btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X") Or
                (btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X") Or
                (btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X") Or
                (btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X") Or
                (btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X") Or
                (btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X") Then
                'Show the message box congratulating player 1
                MessageBox.Show("Player 1 has defeated the mighty Player 2!")
                'Reload the game
                formTicTacToe_Load(Me, New System.EventArgs)
                btnStartGame.Enabled = False
                btnReset.Enabled = True
                lblTurn.Text = ""
                btn3.Enabled = False
                'If player 1 has not won and every number button has been pressed, a tie has occured
            ElseIf squaresUsed = 9 Then
                'If a tie has occured:
                'Show a message box prompting a rematch
                MessageBox.Show("This battle has ended in a draw. Rematch now to defend thy honor!")
                'Reload the game
                formTicTacToe_Load(Me, New System.EventArgs)
                btnStartGame.Enabled = False
                btnReset.Enabled = True
                lblTurn.Text = ""
            End If
            'If it is the second player's turn, check if there is a winning line of O's in any one of the 3 vertical lines, 3 horizontal lines, or both diagonal lines
        ElseIf turn = 2 Then
            'If player 2 wins
            If (btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O") Or
                (btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O") Or
                (btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O") Or
                (btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O") Or
                (btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O") Or
                (btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O") Or
                (btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O") Or
                (btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O") Then
                'Show the message box congratulating player 2
                MessageBox.Show("Player 2 has vanquished the admirable Player 1!")
                formTicTacToe_Load(Me, New System.EventArgs)
                btnStartGame.Enabled = False
                btnReset.Enabled = True
                lblTurn.Text = ""
                'If player 1 has not won and every number button has been pressed, a tie has occured
            ElseIf squaresUsed = 9 Then
                'If a tie has occured:
                'Show a message box prompting a rematch
                MessageBox.Show("This battle has ended in a draw. Rematch now to defend thy honor!")
                'Reload the game
                formTicTacToe_Load(Me, New System.EventArgs)
                btnStartGame.Enabled = False
                btnReset.Enabled = True
                lblTurn.Text = ""
            End If
        End If
    End Sub

    Private Sub easyAI()

    End Sub




    'When each number button is clicked:
    'Disable the clicked button
    'Mark the clicked button with a corresponding "X" or "O", depending on whose turn it is
    'Check if anyone has won or tied
    'If not, it is the other player's turn (Change lblTurn.Text accordingly)

    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        Me.btn1.Enabled = False

        'squaresUsed equals its previous value plus one
        squaresUsed += 1

        If turn = 1 Then
            lblTurn.Text = "2nd Player's Turn"
            btn1.Text = "X"
            checkWin()
            turn = 2
        Else
            If gameMode = 1 Then
                lblTurn.Text = "1st Player's Turn"
                btn1.Text = "O"
                checkWin()
                turn = 1
            ElseIf gameMode = 2 Then
                easyAI()
            End If
        End If
    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        Me.btn2.Enabled = False

        'squaresUsed equals its previous value plus one
        squaresUsed += 1

        If turn = 1 Then
            lblTurn.Text = "2nd Player's Turn"
            btn2.Text = "X"
            checkWin()
            turn = 2
        Else
            If gameMode = 1 Then
                lblTurn.Text = "1st Player's Turn"
                btn2.Text = "O"
                checkWin()
                turn = 1
            ElseIf gameMode = 2 Then
                easyAI()
            End If
        End If
    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        Me.btn3.Enabled = False

        'squaresUsed equals its previous value plus one
        squaresUsed += 1

        If turn = 1 Then
            lblTurn.Text = "2nd Player's Turn"
            btn3.Text = "X"
            checkWin()
            turn = 2
        Else
            If gameMode = 1 Then
                lblTurn.Text = "1st Player's Turn"
                btn3.Text = "O"
                checkWin()
                turn = 1
            ElseIf gameMode = 2 Then
                easyAI()
            End If
        End If
    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btn4.Click
        Me.btn4.Enabled = False

        'squaresUsed equals its previous value plus one
        squaresUsed += 1

        If turn = 1 Then
            lblTurn.Text = "2nd Player's Turn"
            btn4.Text = "X"
            checkWin()
            turn = 2
        Else
            If gameMode = 1 Then
                lblTurn.Text = "1st Player's Turn"
                btn4.Text = "O"
                checkWin()
                turn = 1
            ElseIf gameMode = 2 Then
                easyAI()
            End If
        End If
    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click
        Me.btn5.Enabled = False

        'squaresUsed equals its previous value plus one
        squaresUsed += 1

        If turn = 1 Then
            lblTurn.Text = "2nd Player's Turn"
            btn5.Text = "X"
            checkWin()
            turn = 2
        Else
            If gameMode = 1 Then
                lblTurn.Text = "1st Player's Turn"
                btn5.Text = "O"
                checkWin()
                turn = 1
            ElseIf gameMode = 2 Then
                easyAI()
            End If
        End If
    End Sub

    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs) Handles btn6.Click
        Me.btn6.Enabled = False

        'squaresUsed equals its previous value plus one
        squaresUsed += 1

        If turn = 1 Then
            lblTurn.Text = "2nd Player's Turn"
            btn6.Text = "X"
            checkWin()
            turn = 2
        Else
            If gameMode = 1 Then
                lblTurn.Text = "1st Player's Turn"
                btn6.Text = "O"
                checkWin()
                turn = 1
            ElseIf gameMode = 2 Then
                easyAI()
            End If
        End If
    End Sub

    Private Sub btn7_Click(sender As System.Object, e As System.EventArgs) Handles btn7.Click
        Me.btn7.Enabled = False

        'squaresUsed equals its previous value plus one
        squaresUsed += 1

        If turn = 1 Then
            lblTurn.Text = "2nd Player's Turn"
            btn7.Text = "X"
            checkWin()
            turn = 2
        Else
            If gameMode = 1 Then
                lblTurn.Text = "1st Player's Turn"
                btn7.Text = "O"
                checkWin()
                turn = 1
            ElseIf gameMode = 2 Then
                easyAI()
            End If
        End If
    End Sub

    Private Sub btn8_Click(sender As System.Object, e As System.EventArgs) Handles btn8.Click
        Me.btn8.Enabled = False

        'squaresUsed equals its previous value plus one
        squaresUsed += 1

        If turn = 1 Then
            lblTurn.Text = "2nd Player's Turn"
            btn8.Text = "X"
            checkWin()
            turn = 2
        Else
            If gameMode = 1 Then
                lblTurn.Text = "1st Player's Turn"
                btn8.Text = "O"
                checkWin()
                turn = 1
            ElseIf gameMode = 2 Then
                easyAI()
            End If
        End If
    End Sub

    Private Sub btn9_Click(sender As System.Object, e As System.EventArgs) Handles btn9.Click
        Me.btn9.Enabled = False

        'squaresUsed equals its previous value plus one
        squaresUsed += 1

        If turn = 1 Then
            lblTurn.Text = "2nd Player's Turn"
            btn9.Text = "X"
            checkWin()
            turn = 2
        Else
            If gameMode = 1 Then
                lblTurn.Text = "1st Player's Turn"
                btn9.Text = "O"
                checkWin()
                turn = 1
            ElseIf gameMode = 2 Then
                easyAI()
            End If
        End If
    End Sub

    'When the "Exit" menu strip item is clicked, exit the application
    Private Sub menExitGame_Click(sender As System.Object, e As System.EventArgs) Handles menExitGame.Click
        End
    End Sub

    'When the game loads:
    'Reset all the number button's text
    'Disable every button except for StartGame
    'The label displaying the current player's turn is blank
    Private Sub formTicTacToe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTurn.Text = ""

        turn = 1

        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""

        Me.btn1.Enabled = False
        Me.btn2.Enabled = False
        Me.btn3.Enabled = False
        Me.btn4.Enabled = False
        Me.btn5.Enabled = False
        Me.btn6.Enabled = False
        Me.btn7.Enabled = False
        Me.btn8.Enabled = False
        Me.btn9.Enabled = False
        Me.btnStartGame.Enabled = True
        Me.btnReset.Enabled = False
        Me.rad2Player.Enabled = False
        Me.radEasyAI.Enabled = False
        Me.radHardAI.Enabled = False

        Me.rad2Player.Checked = False
        Me.radEasyAI.Checked = False
        Me.radHardAI.Checked = False

        gameMode = 0

        squaresUsed = 0


    End Sub


    'When the Reset button is clicked:
    'Reload the game
    'lblTurn's text is blank
    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        formTicTacToe_Load(Me, New System.EventArgs)
    End Sub

    'When the start game button is clicked:
    'Sets turn to equal 1 (Player 1 goes first)
    'lblTurn displays that it is player 1's turn
    'Every button is enabled except for the "Start Game" button
    Private Sub btnStartGame_Click(sender As System.Object, e As System.EventArgs) Handles btnStartGame.Click

        'Display "Select a Game Mode" through the label
        lblSelectMode.Text = "Select a Game Mode:"
        btnStartGame.Enabled = False

        Me.rad2Player.Enabled = True
        Me.radEasyAI.Enabled = True
        Me.radHardAI.Enabled = True

    End Sub

    Private Sub rad2Player_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rad2Player.CheckedChanged
        If rad2Player.Enabled = True Then
            gameMode = 1
            lblSelectMode.Enabled = False
            radEasyAI.Enabled = False
            radHardAI.Enabled = False

            btn1.Enabled = True
            btn2.Enabled = True
            btn3.Enabled = True
            btn4.Enabled = True
            btn5.Enabled = True
            btn6.Enabled = True
            btn7.Enabled = True
            btn8.Enabled = True
            btn9.Enabled = True
            btnReset.Enabled = True
        End If

    End Sub

    Private Sub radEasyAI_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radEasyAI.CheckedChanged

        gameMode = 2
        lblSelectMode.Enabled = False
        rad2Player.Enabled = False
        radHardAI.Enabled = False

        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        btnReset.Enabled = True
    End Sub

    Private Sub radHardAI_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radHardAI.CheckedChanged
        gameMode = 3
        lblSelectMode.Enabled = False
        rad2Player.Enabled = False
        radEasyAI.Enabled = False

        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        btnReset.Enabled = True
    End Sub
End Class


