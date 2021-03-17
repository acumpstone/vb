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
        Me.lblEnterChange = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.txtBoxEnterChange = New System.Windows.Forms.TextBox()
        Me.lblNumQuarters = New System.Windows.Forms.Label()
        Me.lblNumDimes = New System.Windows.Forms.Label()
        Me.lblNumNickels = New System.Windows.Forms.Label()
        Me.lblNumPennies = New System.Windows.Forms.Label()
        Me.btnMakeChange = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnterChange
        '
        Me.lblEnterChange.AutoSize = True
        Me.lblEnterChange.Location = New System.Drawing.Point(13, 13)
        Me.lblEnterChange.Name = "lblEnterChange"
        Me.lblEnterChange.Size = New System.Drawing.Size(138, 13)
        Me.lblEnterChange.TabIndex = 0
        Me.lblEnterChange.Text = "Enter the change (in cents):"
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Location = New System.Drawing.Point(31, 70)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(50, 13)
        Me.lblQuarters.TabIndex = 1
        Me.lblQuarters.Text = "Quarters:"
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Location = New System.Drawing.Point(31, 104)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(39, 13)
        Me.lblDimes.TabIndex = 2
        Me.lblDimes.Text = "Dimes:"
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Location = New System.Drawing.Point(31, 138)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(45, 13)
        Me.lblNickels.TabIndex = 3
        Me.lblNickels.Text = "Nickels:"
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(31, 175)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(48, 13)
        Me.lblPennies.TabIndex = 4
        Me.lblPennies.Text = "Pennies:"
        '
        'txtBoxEnterChange
        '
        Me.txtBoxEnterChange.Location = New System.Drawing.Point(157, 13)
        Me.txtBoxEnterChange.Name = "txtBoxEnterChange"
        Me.txtBoxEnterChange.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxEnterChange.TabIndex = 5
        '
        'lblNumQuarters
        '
        Me.lblNumQuarters.AutoSize = True
        Me.lblNumQuarters.Location = New System.Drawing.Point(112, 70)
        Me.lblNumQuarters.Name = "lblNumQuarters"
        Me.lblNumQuarters.Size = New System.Drawing.Size(0, 13)
        Me.lblNumQuarters.TabIndex = 6
        '
        'lblNumDimes
        '
        Me.lblNumDimes.AutoSize = True
        Me.lblNumDimes.Location = New System.Drawing.Point(112, 104)
        Me.lblNumDimes.Name = "lblNumDimes"
        Me.lblNumDimes.Size = New System.Drawing.Size(0, 13)
        Me.lblNumDimes.TabIndex = 7
        '
        'lblNumNickels
        '
        Me.lblNumNickels.AutoSize = True
        Me.lblNumNickels.Location = New System.Drawing.Point(112, 138)
        Me.lblNumNickels.Name = "lblNumNickels"
        Me.lblNumNickels.Size = New System.Drawing.Size(0, 13)
        Me.lblNumNickels.TabIndex = 8
        '
        'lblNumPennies
        '
        Me.lblNumPennies.AutoSize = True
        Me.lblNumPennies.Location = New System.Drawing.Point(112, 175)
        Me.lblNumPennies.Name = "lblNumPennies"
        Me.lblNumPennies.Size = New System.Drawing.Size(0, 13)
        Me.lblNumPennies.TabIndex = 9
        '
        'btnMakeChange
        '
        Me.btnMakeChange.Location = New System.Drawing.Point(183, 93)
        Me.btnMakeChange.Name = "btnMakeChange"
        Me.btnMakeChange.Size = New System.Drawing.Size(89, 76)
        Me.btnMakeChange.TabIndex = 10
        Me.btnMakeChange.Text = "Make Change"
        Me.btnMakeChange.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnMakeChange)
        Me.Controls.Add(Me.lblNumPennies)
        Me.Controls.Add(Me.lblNumNickels)
        Me.Controls.Add(Me.lblNumDimes)
        Me.Controls.Add(Me.lblNumQuarters)
        Me.Controls.Add(Me.txtBoxEnterChange)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblEnterChange)
        Me.Name = "Form1"
        Me.Text = "Change Maker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterChange As System.Windows.Forms.Label
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblNickels As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    Friend WithEvents txtBoxEnterChange As System.Windows.Forms.TextBox
    Friend WithEvents lblNumQuarters As System.Windows.Forms.Label
    Friend WithEvents lblNumDimes As System.Windows.Forms.Label
    Friend WithEvents lblNumNickels As System.Windows.Forms.Label
    Friend WithEvents lblNumPennies As System.Windows.Forms.Label
    Friend WithEvents btnMakeChange As System.Windows.Forms.Button

End Class
