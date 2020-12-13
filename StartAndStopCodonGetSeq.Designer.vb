<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartAndStopCodonGetSeq
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
        Me.DNATextBox = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtBoxLabel
        '
        Me.TxtBoxLabel.AutoSize = True
        Me.TxtBoxLabel.Location = New System.Drawing.Point(13, 13)
        Me.TxtBoxLabel.Name = "TxtBoxLabel"
        Me.TxtBoxLabel.Size = New System.Drawing.Size(132, 13)
        Me.TxtBoxLabel.TabIndex = 0
        Me.TxtBoxLabel.Text = "Enter DNA sequence here"
        '
        'DNATextBox
        '
        Me.DNATextBox.Location = New System.Drawing.Point(16, 29)
        Me.DNATextBox.Multiline = True
        Me.DNATextBox.Name = "DNATextBox"
        Me.DNATextBox.Size = New System.Drawing.Size(256, 62)
        Me.DNATextBox.TabIndex = 1
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(16, 97)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(82, 27)
        Me.SubmitButton.TabIndex = 2
        Me.SubmitButton.Text = "SUBMIT"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(104, 97)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(82, 27)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "CLEAR"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'StartAndStopCodonGetSeq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.DNATextBox)
        Me.Controls.Add(Me.TxtBoxLabel)
        Me.Name = "StartAndStopCodonGetSeq"
        Me.Text = "StartAndStopCodonGetSeq"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents TxtBoxLabel As System.Windows.Forms.Label
    Friend WithEvents DNATextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
End Class
