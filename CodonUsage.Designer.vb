<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodonUsage
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
        Me.TxtBoxLabel = New System.Windows.Forms.Label()
        Me.CodonTextBox = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtBoxLabel
        '
        Me.TxtBoxLabel.AutoSize = True
        Me.TxtBoxLabel.Location = New System.Drawing.Point(12, 9)
        Me.TxtBoxLabel.Name = "TxtBoxLabel"
        Me.TxtBoxLabel.Size = New System.Drawing.Size(145, 13)
        Me.TxtBoxLabel.TabIndex = 0
        Me.TxtBoxLabel.Text = "Paste one FASTA sequence "
        '
        'CodonTextBox
        '
        Me.CodonTextBox.Location = New System.Drawing.Point(15, 26)
        Me.CodonTextBox.Multiline = True
        Me.CodonTextBox.Name = "CodonTextBox"
        Me.CodonTextBox.Size = New System.Drawing.Size(257, 53)
        Me.CodonTextBox.TabIndex = 1
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(15, 86)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 2
        Me.SubmitButton.Text = "SUBMIT"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(96, 86)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "CLEAR"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CodonPlotForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.CodonTextBox)
        Me.Controls.Add(Me.TxtBoxLabel)
        Me.Name = "CodonPlotForm"
        Me.Text = "Codon Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtBoxLabel As System.Windows.Forms.Label
    Friend WithEvents CodonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
End Class
