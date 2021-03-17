<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTicTacToe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTicTacToe))
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblTurn = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menExitGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.rad2Player = New System.Windows.Forms.RadioButton()
        Me.radEasyAI = New System.Windows.Forms.RadioButton()
        Me.radHardAI = New System.Windows.Forms.RadioButton()
        Me.lblSelectMode = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.BackgroundImage = CType(resources.GetObject("btn1.BackgroundImage"), System.Drawing.Image)
        Me.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn1.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(27, 51)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(100, 100)
        Me.btn1.TabIndex = 0
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.BackgroundImage = CType(resources.GetObject("btn2.BackgroundImage"), System.Drawing.Image)
        Me.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn2.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(133, 51)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(100, 100)
        Me.btn2.TabIndex = 1
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.BackgroundImage = CType(resources.GetObject("btn3.BackgroundImage"), System.Drawing.Image)
        Me.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn3.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(239, 51)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(100, 100)
        Me.btn3.TabIndex = 2
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.BackgroundImage = CType(resources.GetObject("btn4.BackgroundImage"), System.Drawing.Image)
        Me.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn4.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(27, 157)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(100, 100)
        Me.btn4.TabIndex = 3
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.BackgroundImage = CType(resources.GetObject("btn5.BackgroundImage"), System.Drawing.Image)
        Me.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn5.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(133, 157)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(100, 100)
        Me.btn5.TabIndex = 4
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.BackgroundImage = CType(resources.GetObject("btn6.BackgroundImage"), System.Drawing.Image)
        Me.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn6.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(239, 157)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(100, 100)
        Me.btn6.TabIndex = 5
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.BackgroundImage = CType(resources.GetObject("btn7.BackgroundImage"), System.Drawing.Image)
        Me.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn7.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(27, 263)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(100, 100)
        Me.btn7.TabIndex = 6
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.BackgroundImage = CType(resources.GetObject("btn8.BackgroundImage"), System.Drawing.Image)
        Me.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn8.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(133, 263)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(100, 100)
        Me.btn8.TabIndex = 7
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.two_swords_with_shield_black_edited
        Me.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn9.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(239, 263)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(100, 100)
        Me.btn9.TabIndex = 8
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.DarkRed
        Me.btnReset.Location = New System.Drawing.Point(485, 51)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(103, 39)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblTurn
        '
        Me.lblTurn.AutoSize = True
        Me.lblTurn.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurn.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTurn.Location = New System.Drawing.Point(127, 377)
        Me.lblTurn.Name = "lblTurn"
        Me.lblTurn.Size = New System.Drawing.Size(0, 19)
        Me.lblTurn.TabIndex = 11
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(607, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menFile
        '
        Me.menFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menExitGame})
        Me.menFile.Name = "menFile"
        Me.menFile.Size = New System.Drawing.Size(37, 20)
        Me.menFile.Text = "File"
        '
        'menExitGame
        '
        Me.menExitGame.Name = "menExitGame"
        Me.menExitGame.Size = New System.Drawing.Size(92, 22)
        Me.menExitGame.Text = "Exit"
        '
        'btnStartGame
        '
        Me.btnStartGame.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartGame.ForeColor = System.Drawing.Color.DarkRed
        Me.btnStartGame.Location = New System.Drawing.Point(368, 51)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(100, 39)
        Me.btnStartGame.TabIndex = 16
        Me.btnStartGame.Text = "StartGame"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'rad2Player
        '
        Me.rad2Player.AutoSize = True
        Me.rad2Player.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad2Player.ForeColor = System.Drawing.Color.DarkRed
        Me.rad2Player.Location = New System.Drawing.Point(21, 19)
        Me.rad2Player.Name = "rad2Player"
        Me.rad2Player.Size = New System.Drawing.Size(127, 23)
        Me.rad2Player.TabIndex = 17
        Me.rad2Player.Text = "Player vs Player"
        Me.rad2Player.UseVisualStyleBackColor = True
        '
        'radEasyAI
        '
        Me.radEasyAI.AutoSize = True
        Me.radEasyAI.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEasyAI.ForeColor = System.Drawing.Color.DarkRed
        Me.radEasyAI.Location = New System.Drawing.Point(21, 81)
        Me.radEasyAI.Name = "radEasyAI"
        Me.radEasyAI.Size = New System.Drawing.Size(186, 23)
        Me.radEasyAI.TabIndex = 18
        Me.radEasyAI.Text = "Player vs Computer (Easy)"
        Me.radEasyAI.UseVisualStyleBackColor = True
        '
        'radHardAI
        '
        Me.radHardAI.AutoSize = True
        Me.radHardAI.Font = New System.Drawing.Font("Old English Text MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHardAI.ForeColor = System.Drawing.Color.DarkRed
        Me.radHardAI.Location = New System.Drawing.Point(21, 148)
        Me.radHardAI.Name = "radHardAI"
        Me.radHardAI.Size = New System.Drawing.Size(187, 23)
        Me.radHardAI.TabIndex = 19
        Me.radHardAI.Text = "Player vs Computer (Hard)"
        Me.radHardAI.UseVisualStyleBackColor = True
        '
        'lblSelectMode
        '
        Me.lblSelectMode.AutoSize = True
        Me.lblSelectMode.Font = New System.Drawing.Font("Old English Text MT", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectMode.ForeColor = System.Drawing.Color.DarkRed
        Me.lblSelectMode.Location = New System.Drawing.Point(368, 115)
        Me.lblSelectMode.Name = "lblSelectMode"
        Me.lblSelectMode.Size = New System.Drawing.Size(0, 19)
        Me.lblSelectMode.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad2Player)
        Me.GroupBox1.Controls.Add(Me.radEasyAI)
        Me.GroupBox1.Controls.Add(Me.radHardAI)
        Me.GroupBox1.Location = New System.Drawing.Point(368, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 192)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Game Mode:"
        '
        'formTicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 405)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSelectMode)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.lblTurn)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formTicTacToe"
        Me.Text = "Tic Tac Toe"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblTurn As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menExitGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnStartGame As System.Windows.Forms.Button
    Friend WithEvents rad2Player As System.Windows.Forms.RadioButton
    Friend WithEvents radEasyAI As System.Windows.Forms.RadioButton
    Friend WithEvents radHardAI As System.Windows.Forms.RadioButton
    Friend WithEvents lblSelectMode As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
