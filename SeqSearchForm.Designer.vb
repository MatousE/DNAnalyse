<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeqSearchForm
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
        Me.TextSeqImportButton = New System.Windows.Forms.Button()
        Me.SnglSeqTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SeqRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'TextSeqImportButton
        '
        Me.TextSeqImportButton.Location = New System.Drawing.Point(397, 12)
        Me.TextSeqImportButton.Name = "TextSeqImportButton"
        Me.TextSeqImportButton.Size = New System.Drawing.Size(75, 34)
        Me.TextSeqImportButton.TabIndex = 9
        Me.TextSeqImportButton.Text = "Import Seq as Text"
        Me.TextSeqImportButton.UseVisualStyleBackColor = True
        '
        'SnglSeqTextBox
        '
        Me.SnglSeqTextBox.Location = New System.Drawing.Point(12, 12)
        Me.SnglSeqTextBox.Multiline = True
        Me.SnglSeqTextBox.Name = "SnglSeqTextBox"
        Me.SnglSeqTextBox.Size = New System.Drawing.Size(379, 34)
        Me.SnglSeqTextBox.TabIndex = 8
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Please ensure the sequence is all on one line"
        '
        'SeqRichTextBox
        '
        Me.SeqRichTextBox.Location = New System.Drawing.Point(12, 70)
        Me.SeqRichTextBox.Name = "SeqRichTextBox"
        Me.SeqRichTextBox.Size = New System.Drawing.Size(460, 334)
        Me.SeqRichTextBox.TabIndex = 11
        Me.SeqRichTextBox.Text = ""
        '
        'SeqSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 459)
        Me.Controls.Add(Me.SeqRichTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextSeqImportButton)
        Me.Controls.Add(Me.SnglSeqTextBox)
        Me.Name = "SeqSearchForm"
        Me.Text = "][pol"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextSeqImportButton As System.Windows.Forms.Button
    Friend WithEvents SnglSeqTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SeqRichTextBox As System.Windows.Forms.RichTextBox
End Class
