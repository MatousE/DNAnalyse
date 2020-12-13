<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TranslationMap
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
        Me.DNATextBox = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ReadingFrameComboBox = New System.Windows.Forms.ComboBox()
        Me.DNAOrderComboBox = New System.Windows.Forms.ComboBox()
        Me.EditedDNATextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'DNATextBox
        '
        Me.DNATextBox.Location = New System.Drawing.Point(13, 13)
        Me.DNATextBox.Multiline = True
        Me.DNATextBox.Name = "DNATextBox"
        Me.DNATextBox.Size = New System.Drawing.Size(293, 29)
        Me.DNATextBox.TabIndex = 0
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(139, 71)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 21)
        Me.SubmitButton.TabIndex = 1
        Me.SubmitButton.Text = "SUBMIT"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 133)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(531, 348)
        Me.TextBox1.TabIndex = 2
        '
        'ReadingFrameComboBox
        '
        Me.ReadingFrameComboBox.FormattingEnabled = True
        Me.ReadingFrameComboBox.Items.AddRange(New Object() {"Reading Frame 1", "Reading Frame 2", "Reading Frame 3", "Reading Frame 1, 2 & 3"})
        Me.ReadingFrameComboBox.Location = New System.Drawing.Point(12, 48)
        Me.ReadingFrameComboBox.Name = "ReadingFrameComboBox"
        Me.ReadingFrameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ReadingFrameComboBox.TabIndex = 3
        '
        'DNAOrderComboBox
        '
        Me.DNAOrderComboBox.FormattingEnabled = True
        Me.DNAOrderComboBox.Items.AddRange(New Object() {"Standard", "Reverse", "Complement", "Reverse Complement"})
        Me.DNAOrderComboBox.Location = New System.Drawing.Point(12, 71)
        Me.DNAOrderComboBox.Name = "DNAOrderComboBox"
        Me.DNAOrderComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DNAOrderComboBox.TabIndex = 4
        '
        'EditedDNATextBox
        '
        Me.EditedDNATextBox.Location = New System.Drawing.Point(12, 98)
        Me.EditedDNATextBox.Multiline = True
        Me.EditedDNATextBox.Name = "EditedDNATextBox"
        Me.EditedDNATextBox.Size = New System.Drawing.Size(293, 29)
        Me.EditedDNATextBox.TabIndex = 5
        '
        'TranslationMap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 509)
        Me.Controls.Add(Me.EditedDNATextBox)
        Me.Controls.Add(Me.DNAOrderComboBox)
        Me.Controls.Add(Me.ReadingFrameComboBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.DNATextBox)
        Me.Name = "TranslationMap"
        Me.Text = "TranslationMap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DNATextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ReadingFrameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DNAOrderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EditedDNATextBox As System.Windows.Forms.TextBox
End Class
