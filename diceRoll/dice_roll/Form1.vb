Public Class formDiceRoll


    Dim random As Integer 'Random number for dice roller


    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        random = Rand(1, 6)
        Select Case random
            Case 1
                PictureBox1.Image = My.Resources.dice_face_1
            Case 2
                PictureBox1.Image = My.Resources.dice_face_2
            Case 3
                PictureBox1.Image = My.Resources.dice_face_3
            Case 4
                PictureBox1.Image = My.Resources.dice_face_4
            Case 5
                PictureBox1.Image = My.Resources.dice_face_5
            Case 6
                PictureBox1.Image = My.Resources.dice_face_6
        End Select
    End Sub

    '===============================================
    'Rand Return
    'a random number in a given range.
    '
    'Parameters:
    ' Low The
    'lower bounds of the range.
    ' High The
    'upper bounds of the range.
    '
    'Returns:
    ' Returns a random number from Low..High.
    '===============================================
    Public Function Rand(ByVal Low As Long, ByVal High As Long) As Long
        Rand = Int((High - Low + 1) * Rnd()) + Low
    End Function

    'To run Rand, write Rand(1, 6)

    Private Sub formDiceRoll_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class
