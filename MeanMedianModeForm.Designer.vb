<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MeanMedianModeForm
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
        Me.MeanLabel = New System.Windows.Forms.Label()
        Me.MedianLabel = New System.Windows.Forms.Label()
        Me.ModeLabel = New System.Windows.Forms.Label()
        Me.MeanTextBox = New System.Windows.Forms.TextBox()
        Me.MedianTextBox = New System.Windows.Forms.TextBox()
        Me.ModeTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'MeanLabel
        '
        Me.MeanLabel.AutoSize = True
        Me.MeanLabel.Location = New System.Drawing.Point(9, 22)
        Me.MeanLabel.Name = "MeanLabel"
        Me.MeanLabel.Size = New System.Drawing.Size(40, 13)
        Me.MeanLabel.TabIndex = 0
        Me.MeanLabel.Text = "Mean: "
        '
        'MedianLabel
        '
        Me.MedianLabel.AutoSize = True
        Me.MedianLabel.Location = New System.Drawing.Point(1, 48)
        Me.MedianLabel.Name = "MedianLabel"
        Me.MedianLabel.Size = New System.Drawing.Size(48, 13)
        Me.MedianLabel.TabIndex = 1
        Me.MedianLabel.Text = "Median: "
        '
        'ModeLabel
        '
        Me.ModeLabel.AutoSize = True
        Me.ModeLabel.Location = New System.Drawing.Point(9, 74)
        Me.ModeLabel.Name = "ModeLabel"
        Me.ModeLabel.Size = New System.Drawing.Size(40, 13)
        Me.ModeLabel.TabIndex = 2
        Me.ModeLabel.Text = "Mode: "
        '
        'MeanTextBox
        '
        Me.MeanTextBox.Location = New System.Drawing.Point(55, 19)
        Me.MeanTextBox.Name = "MeanTextBox"
        Me.MeanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MeanTextBox.TabIndex = 3
        '
        'MedianTextBox
        '
        Me.MedianTextBox.Location = New System.Drawing.Point(55, 45)
        Me.MedianTextBox.Name = "MedianTextBox"
        Me.MedianTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MedianTextBox.TabIndex = 4
        '
        'ModeTextBox
        '
        Me.ModeTextBox.Location = New System.Drawing.Point(55, 71)
        Me.ModeTextBox.Name = "ModeTextBox"
        Me.ModeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModeTextBox.TabIndex = 5
        '
        'MeanMedianModeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ModeTextBox)
        Me.Controls.Add(Me.MedianTextBox)
        Me.Controls.Add(Me.MeanTextBox)
        Me.Controls.Add(Me.ModeLabel)
        Me.Controls.Add(Me.MedianLabel)
        Me.Controls.Add(Me.MeanLabel)
        Me.Name = "MeanMedianModeForm"
        Me.Text = "DNAnalyse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MeanLabel As System.Windows.Forms.Label
    Friend WithEvents MedianLabel As System.Windows.Forms.Label
    Friend WithEvents ModeLabel As System.Windows.Forms.Label
    Friend WithEvents MeanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModeTextBox As System.Windows.Forms.TextBox
End Class
