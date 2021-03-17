<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formNumberGuesser
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
        Me.components = New System.ComponentModel.Container()
        Me.lblGuessStatus = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnHint1 = New System.Windows.Forms.Button()
        Me.btnHint2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGuessStatus
        '
        Me.lblGuessStatus.AutoSize = True
        Me.lblGuessStatus.Font = New System.Drawing.Font("Agency FB", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuessStatus.Location = New System.Drawing.Point(64, 36)
        Me.lblGuessStatus.Name = "lblGuessStatus"
        Me.lblGuessStatus.Size = New System.Drawing.Size(108, 23)
        Me.lblGuessStatus.TabIndex = 0
        Me.lblGuessStatus.Text = "Guess the number!"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Agency FB", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(38, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(76, 28)
        Me.TextBox1.TabIndex = 1
        '
        'btnGuess
        '
        Me.btnGuess.Font = New System.Drawing.Font("Agency FB", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuess.Location = New System.Drawing.Point(136, 72)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(75, 30)
        Me.btnGuess.TabIndex = 2
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Agency FB", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(85, 111)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 30)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnHint1
        '
        Me.btnHint1.Font = New System.Drawing.Font("Agency FB", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHint1.Location = New System.Drawing.Point(49, 169)
        Me.btnHint1.Name = "btnHint1"
        Me.btnHint1.Size = New System.Drawing.Size(54, 31)
        Me.btnHint1.TabIndex = 4
        Me.btnHint1.Text = "Hint 1"
        Me.btnHint1.UseVisualStyleBackColor = True
        '
        'btnHint2
        '
        Me.btnHint2.Font = New System.Drawing.Font("Agency FB", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHint2.Location = New System.Drawing.Point(136, 169)
        Me.btnHint2.Name = "btnHint2"
        Me.btnHint2.Size = New System.Drawing.Size(54, 31)
        Me.btnHint2.TabIndex = 5
        Me.btnHint2.Text = "Hint 2"
        Me.btnHint2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.AutoSize = True
        Me.lblTimeLeft.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft.Location = New System.Drawing.Point(215, 9)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(22, 18)
        Me.lblTimeLeft.TabIndex = 6
        Me.lblTimeLeft.Text = "60"
        '
        'formNumberGuesser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 204)
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Controls.Add(Me.btnHint2)
        Me.Controls.Add(Me.btnHint1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblGuessStatus)
        Me.Name = "formNumberGuesser"
        Me.Text = "Number Guesser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGuessStatus As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnHint1 As System.Windows.Forms.Button
    Friend WithEvents btnHint2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTimeLeft As System.Windows.Forms.Label

End Class
