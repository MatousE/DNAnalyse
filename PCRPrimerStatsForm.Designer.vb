<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PCRPrimerStatsForm
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
        Me.PCRPrimerLabel = New System.Windows.Forms.Label()
        Me.PCRPrimerRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReverseComplementLabel = New System.Windows.Forms.Label()
        Me.ReverseComplementTextBox = New System.Windows.Forms.TextBox()
        Me.PhysicalConstantsLabel = New System.Windows.Forms.Label()
        Me.LengthLabel = New System.Windows.Forms.Label()
        Me.LengthTextBox = New System.Windows.Forms.TextBox()
        Me.MolecularWeightLabel = New System.Windows.Forms.Label()
        Me.MolecularWeightTextBox = New System.Windows.Forms.TextBox()
        Me.GCContentLabel = New System.Windows.Forms.Label()
        Me.GCContentTextBox = New System.Windows.Forms.TextBox()
        Me.MeltingTempLabel = New System.Windows.Forms.Label()
        Me.BasicLabel = New System.Windows.Forms.Label()
        Me.BasicTempTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PCRPrimerLabel
        '
        Me.PCRPrimerLabel.AutoSize = True
        Me.PCRPrimerLabel.Location = New System.Drawing.Point(12, 9)
        Me.PCRPrimerLabel.Name = "PCRPrimerLabel"
        Me.PCRPrimerLabel.Size = New System.Drawing.Size(39, 13)
        Me.PCRPrimerLabel.TabIndex = 0
        Me.PCRPrimerLabel.Text = "Label1"
        '
        'PCRPrimerRichTextBox
        '
        Me.PCRPrimerRichTextBox.Location = New System.Drawing.Point(13, 26)
        Me.PCRPrimerRichTextBox.Name = "PCRPrimerRichTextBox"
        Me.PCRPrimerRichTextBox.Size = New System.Drawing.Size(580, 57)
        Me.PCRPrimerRichTextBox.TabIndex = 1
        Me.PCRPrimerRichTextBox.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReverseComplementLabel
        '
        Me.ReverseComplementLabel.AutoSize = True
        Me.ReverseComplementLabel.Location = New System.Drawing.Point(12, 124)
        Me.ReverseComplementLabel.Name = "ReverseComplementLabel"
        Me.ReverseComplementLabel.Size = New System.Drawing.Size(39, 13)
        Me.ReverseComplementLabel.TabIndex = 3
        Me.ReverseComplementLabel.Text = "Label1"
        '
        'ReverseComplementTextBox
        '
        Me.ReverseComplementTextBox.Location = New System.Drawing.Point(12, 140)
        Me.ReverseComplementTextBox.Name = "ReverseComplementTextBox"
        Me.ReverseComplementTextBox.Size = New System.Drawing.Size(368, 20)
        Me.ReverseComplementTextBox.TabIndex = 4
        '
        'PhysicalConstantsLabel
        '
        Me.PhysicalConstantsLabel.AutoSize = True
        Me.PhysicalConstantsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhysicalConstantsLabel.Location = New System.Drawing.Point(12, 163)
        Me.PhysicalConstantsLabel.Name = "PhysicalConstantsLabel"
        Me.PhysicalConstantsLabel.Size = New System.Drawing.Size(49, 16)
        Me.PhysicalConstantsLabel.TabIndex = 5
        Me.PhysicalConstantsLabel.Text = "Label1"
        '
        'LengthLabel
        '
        Me.LengthLabel.AutoSize = True
        Me.LengthLabel.Location = New System.Drawing.Point(12, 192)
        Me.LengthLabel.Name = "LengthLabel"
        Me.LengthLabel.Size = New System.Drawing.Size(43, 13)
        Me.LengthLabel.TabIndex = 6
        Me.LengthLabel.Text = "Length:"
        '
        'LengthTextBox
        '
        Me.LengthTextBox.Location = New System.Drawing.Point(61, 192)
        Me.LengthTextBox.Name = "LengthTextBox"
        Me.LengthTextBox.Size = New System.Drawing.Size(81, 20)
        Me.LengthTextBox.TabIndex = 7
        '
        'MolecularWeightLabel
        '
        Me.MolecularWeightLabel.AutoSize = True
        Me.MolecularWeightLabel.Location = New System.Drawing.Point(149, 195)
        Me.MolecularWeightLabel.Name = "MolecularWeightLabel"
        Me.MolecularWeightLabel.Size = New System.Drawing.Size(93, 13)
        Me.MolecularWeightLabel.TabIndex = 8
        Me.MolecularWeightLabel.Text = "Molecular Weight:"
        '
        'MolecularWeightTextBox
        '
        Me.MolecularWeightTextBox.Location = New System.Drawing.Point(248, 195)
        Me.MolecularWeightTextBox.Name = "MolecularWeightTextBox"
        Me.MolecularWeightTextBox.Size = New System.Drawing.Size(81, 20)
        Me.MolecularWeightTextBox.TabIndex = 9
        '
        'GCContentLabel
        '
        Me.GCContentLabel.AutoSize = True
        Me.GCContentLabel.Location = New System.Drawing.Point(337, 198)
        Me.GCContentLabel.Name = "GCContentLabel"
        Me.GCContentLabel.Size = New System.Drawing.Size(65, 13)
        Me.GCContentLabel.TabIndex = 10
        Me.GCContentLabel.Text = "GC Content:"
        '
        'GCContentTextBox
        '
        Me.GCContentTextBox.Location = New System.Drawing.Point(408, 195)
        Me.GCContentTextBox.Name = "GCContentTextBox"
        Me.GCContentTextBox.Size = New System.Drawing.Size(81, 20)
        Me.GCContentTextBox.TabIndex = 11
        '
        'MeltingTempLabel
        '
        Me.MeltingTempLabel.AutoSize = True
        Me.MeltingTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeltingTempLabel.Location = New System.Drawing.Point(12, 224)
        Me.MeltingTempLabel.Name = "MeltingTempLabel"
        Me.MeltingTempLabel.Size = New System.Drawing.Size(49, 16)
        Me.MeltingTempLabel.TabIndex = 12
        Me.MeltingTempLabel.Text = "Label1"
        '
        'BasicLabel
        '
        Me.BasicLabel.AutoSize = True
        Me.BasicLabel.Location = New System.Drawing.Point(99, 249)
        Me.BasicLabel.Name = "BasicLabel"
        Me.BasicLabel.Size = New System.Drawing.Size(39, 13)
        Me.BasicLabel.TabIndex = 13
        Me.BasicLabel.Text = "Label1"
        '
        'BasicTempTextBox
        '
        Me.BasicTempTextBox.Location = New System.Drawing.Point(15, 246)
        Me.BasicTempTextBox.Name = "BasicTempTextBox"
        Me.BasicTempTextBox.Size = New System.Drawing.Size(81, 20)
        Me.BasicTempTextBox.TabIndex = 14
        '
        'PCRPrimerStatsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 405)
        Me.Controls.Add(Me.BasicTempTextBox)
        Me.Controls.Add(Me.BasicLabel)
        Me.Controls.Add(Me.MeltingTempLabel)
        Me.Controls.Add(Me.GCContentTextBox)
        Me.Controls.Add(Me.GCContentLabel)
        Me.Controls.Add(Me.MolecularWeightTextBox)
        Me.Controls.Add(Me.MolecularWeightLabel)
        Me.Controls.Add(Me.LengthTextBox)
        Me.Controls.Add(Me.LengthLabel)
        Me.Controls.Add(Me.PhysicalConstantsLabel)
        Me.Controls.Add(Me.ReverseComplementTextBox)
        Me.Controls.Add(Me.ReverseComplementLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PCRPrimerRichTextBox)
        Me.Controls.Add(Me.PCRPrimerLabel)
        Me.Name = "PCRPrimerStatsForm"
        Me.Text = "PCRPrimerStatsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PCRPrimerLabel As System.Windows.Forms.Label
    Friend WithEvents PCRPrimerRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReverseComplementLabel As System.Windows.Forms.Label
    Friend WithEvents ReverseComplementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhysicalConstantsLabel As System.Windows.Forms.Label
    Friend WithEvents LengthLabel As System.Windows.Forms.Label
    Friend WithEvents LengthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MolecularWeightLabel As System.Windows.Forms.Label
    Friend WithEvents MolecularWeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GCContentLabel As System.Windows.Forms.Label
    Friend WithEvents GCContentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MeltingTempLabel As System.Windows.Forms.Label
    Friend WithEvents BasicLabel As System.Windows.Forms.Label
    Friend WithEvents BasicTempTextBox As System.Windows.Forms.TextBox
End Class
