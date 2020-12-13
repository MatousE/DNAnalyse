<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateRandomDNAseq
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
        Me.ToolPurposeLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.LabelInpt = New System.Windows.Forms.Label()
        Me.TextBoxNoCodonsUInput = New System.Windows.Forms.TextBox()
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ToolPurposeLabel
        '
        Me.ToolPurposeLabel.AutoSize = True
        Me.ToolPurposeLabel.Location = New System.Drawing.Point(12, 13)
        Me.ToolPurposeLabel.Name = "ToolPurposeLabel"
        Me.ToolPurposeLabel.Size = New System.Drawing.Size(393, 13)
        Me.ToolPurposeLabel.TabIndex = 0
        Me.ToolPurposeLabel.Text = "Random DNA Sequence generates a random sequence of the length you specify."
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(12, 26)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(435, 13)
        Me.TitleLabel.TabIndex = 1
        Me.TitleLabel.Text = "Random sequences can be used to evaluate the significance of sequence analysis re" & _
            "sults."
        '
        'LabelInpt
        '
        Me.LabelInpt.AutoSize = True
        Me.LabelInpt.Location = New System.Drawing.Point(12, 57)
        Me.LabelInpt.Name = "LabelInpt"
        Me.LabelInpt.Size = New System.Drawing.Size(354, 13)
        Me.LabelInpt.TabIndex = 2
        Me.LabelInpt.Text = "Enter the number of codons the sequence will have in the text area below"
        '
        'TextBoxNoCodonsUInput
        '
        Me.TextBoxNoCodonsUInput.Location = New System.Drawing.Point(15, 73)
        Me.TextBoxNoCodonsUInput.Name = "TextBoxNoCodonsUInput"
        Me.TextBoxNoCodonsUInput.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxNoCodonsUInput.TabIndex = 3
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Location = New System.Drawing.Point(15, 99)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSubmit.TabIndex = 4
        Me.ButtonSubmit.Text = "Submit"
        Me.ButtonSubmit.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(96, 99)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 5
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'GenerateRandomDNAseq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 356)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonSubmit)
        Me.Controls.Add(Me.TextBoxNoCodonsUInput)
        Me.Controls.Add(Me.LabelInpt)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.ToolPurposeLabel)
        Me.Name = "GenerateRandomDNAseq"
        Me.Text = "GenerateRandomDNAseq"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolPurposeLabel As System.Windows.Forms.Label
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents LabelInpt As System.Windows.Forms.Label
    Friend WithEvents TextBoxNoCodonsUInput As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSubmit As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
End Class
