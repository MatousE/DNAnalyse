<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutputRegExprSeqs
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
        Me.RegExprRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RegExprRichTextBox
        '
        Me.RegExprRichTextBox.Location = New System.Drawing.Point(13, 12)
        Me.RegExprRichTextBox.Name = "RegExprRichTextBox"
        Me.RegExprRichTextBox.Size = New System.Drawing.Size(963, 599)
        Me.RegExprRichTextBox.TabIndex = 0
        Me.RegExprRichTextBox.Text = ""
        '
        'OutputRegExprSeqs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 625)
        Me.Controls.Add(Me.RegExprRichTextBox)
        Me.Name = "OutputRegExprSeqs"
        Me.Text = "Regular Expression Output"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RegExprRichTextBox As System.Windows.Forms.RichTextBox
End Class
