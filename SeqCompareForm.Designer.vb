<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeqCompareForm
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
        Me.FileTextBox = New System.Windows.Forms.TextBox()
        Me.FileImportButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.OrLabel = New System.Windows.Forms.Label()
        Me.SeqTextBox = New System.Windows.Forms.TextBox()
        Me.TextImportButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FileTextBox
        '
        Me.FileTextBox.Location = New System.Drawing.Point(12, 12)
        Me.FileTextBox.Name = "FileTextBox"
        Me.FileTextBox.Size = New System.Drawing.Size(175, 20)
        Me.FileTextBox.TabIndex = 0
        '
        'FileImportButton
        '
        Me.FileImportButton.Location = New System.Drawing.Point(193, 10)
        Me.FileImportButton.Name = "FileImportButton"
        Me.FileImportButton.Size = New System.Drawing.Size(75, 23)
        Me.FileImportButton.TabIndex = 1
        Me.FileImportButton.Text = "Import File"
        Me.FileImportButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'OrLabel
        '
        Me.OrLabel.AutoSize = True
        Me.OrLabel.Location = New System.Drawing.Point(100, 39)
        Me.OrLabel.Name = "OrLabel"
        Me.OrLabel.Size = New System.Drawing.Size(23, 13)
        Me.OrLabel.TabIndex = 2
        Me.OrLabel.Text = "OR"
        '
        'SeqTextBox
        '
        Me.SeqTextBox.Location = New System.Drawing.Point(12, 55)
        Me.SeqTextBox.Multiline = True
        Me.SeqTextBox.Name = "SeqTextBox"
        Me.SeqTextBox.Size = New System.Drawing.Size(175, 34)
        Me.SeqTextBox.TabIndex = 3
        '
        'TextImportButton
        '
        Me.TextImportButton.Location = New System.Drawing.Point(193, 55)
        Me.TextImportButton.Name = "TextImportButton"
        Me.TextImportButton.Size = New System.Drawing.Size(75, 34)
        Me.TextImportButton.TabIndex = 4
        Me.TextImportButton.Text = "Import Text"
        Me.TextImportButton.UseVisualStyleBackColor = True
        '
        'SeqCompareForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TextImportButton)
        Me.Controls.Add(Me.SeqTextBox)
        Me.Controls.Add(Me.OrLabel)
        Me.Controls.Add(Me.FileImportButton)
        Me.Controls.Add(Me.FileTextBox)
        Me.Name = "SeqCompareForm"
        Me.Text = "DNAnalyse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FileImportButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OrLabel As System.Windows.Forms.Label
    Friend WithEvents SeqTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextImportButton As System.Windows.Forms.Button
End Class
