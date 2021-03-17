<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.btnQuestion = New System.Windows.Forms.Button()
        Me.btnBackwards = New System.Windows.Forms.Button()
        Me.btnBackwardsInfo = New System.Windows.Forms.Button()
        Me.btnAcronymInfo = New System.Windows.Forms.Button()
        Me.btnAcronym = New System.Windows.Forms.Button()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(67, 26)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 52)
        Me.TextBox1.TabIndex = 0
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Font = New System.Drawing.Font("Agency FB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncrypt.ForeColor = System.Drawing.Color.DarkRed
        Me.btnEncrypt.Location = New System.Drawing.Point(67, 164)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(99, 28)
        Me.btnEncrypt.TabIndex = 2
        Me.btnEncrypt.Text = "Encrypt/Decrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(67, 309)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(148, 51)
        Me.TextBox2.TabIndex = 3
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.DarkRed
        Me.TrackBar1.Location = New System.Drawing.Point(90, 98)
        Me.TrackBar1.Maximum = 3
        Me.TrackBar1.Minimum = -3
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(111, 45)
        Me.TrackBar1.TabIndex = 4
        '
        'btnQuestion
        '
        Me.btnQuestion.Font = New System.Drawing.Font("Agency FB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuestion.ForeColor = System.Drawing.Color.DarkRed
        Me.btnQuestion.Location = New System.Drawing.Point(195, 164)
        Me.btnQuestion.Name = "btnQuestion"
        Me.btnQuestion.Size = New System.Drawing.Size(20, 28)
        Me.btnQuestion.TabIndex = 5
        Me.btnQuestion.Text = "?"
        Me.btnQuestion.UseVisualStyleBackColor = True
        '
        'btnBackwards
        '
        Me.btnBackwards.Font = New System.Drawing.Font("Agency FB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackwards.ForeColor = System.Drawing.Color.DarkRed
        Me.btnBackwards.Location = New System.Drawing.Point(67, 209)
        Me.btnBackwards.Name = "btnBackwards"
        Me.btnBackwards.Size = New System.Drawing.Size(99, 26)
        Me.btnBackwards.TabIndex = 6
        Me.btnBackwards.Text = "Backwards"
        Me.btnBackwards.UseVisualStyleBackColor = True
        '
        'btnBackwardsInfo
        '
        Me.btnBackwardsInfo.Font = New System.Drawing.Font("Agency FB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackwardsInfo.ForeColor = System.Drawing.Color.DarkRed
        Me.btnBackwardsInfo.Location = New System.Drawing.Point(195, 207)
        Me.btnBackwardsInfo.Name = "btnBackwardsInfo"
        Me.btnBackwardsInfo.Size = New System.Drawing.Size(20, 28)
        Me.btnBackwardsInfo.TabIndex = 7
        Me.btnBackwardsInfo.Text = "?"
        Me.btnBackwardsInfo.UseVisualStyleBackColor = True
        '
        'btnAcronymInfo
        '
        Me.btnAcronymInfo.Font = New System.Drawing.Font("Agency FB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcronymInfo.ForeColor = System.Drawing.Color.DarkRed
        Me.btnAcronymInfo.Location = New System.Drawing.Point(195, 253)
        Me.btnAcronymInfo.Name = "btnAcronymInfo"
        Me.btnAcronymInfo.Size = New System.Drawing.Size(20, 28)
        Me.btnAcronymInfo.TabIndex = 9
        Me.btnAcronymInfo.Text = "?"
        Me.btnAcronymInfo.UseVisualStyleBackColor = True
        '
        'btnAcronym
        '
        Me.btnAcronym.Font = New System.Drawing.Font("Agency FB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcronym.ForeColor = System.Drawing.Color.DarkRed
        Me.btnAcronym.Location = New System.Drawing.Point(67, 255)
        Me.btnAcronym.Name = "btnAcronym"
        Me.btnAcronym.Size = New System.Drawing.Size(99, 26)
        Me.btnAcronym.TabIndex = 8
        Me.btnAcronym.Text = "Acronym"
        Me.btnAcronym.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(284, 399)
        Me.Controls.Add(Me.btnAcronymInfo)
        Me.Controls.Add(Me.btnAcronym)
        Me.Controls.Add(Me.btnBackwardsInfo)
        Me.Controls.Add(Me.btnBackwards)
        Me.Controls.Add(Me.btnQuestion)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Encryption"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents btnQuestion As System.Windows.Forms.Button
    Friend WithEvents btnBackwards As System.Windows.Forms.Button
    Friend WithEvents btnBackwardsInfo As System.Windows.Forms.Button
    Friend WithEvents btnAcronymInfo As System.Windows.Forms.Button
    Friend WithEvents btnAcronym As System.Windows.Forms.Button

End Class
