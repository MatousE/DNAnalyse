<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasketofLengthsForm
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
        Me.MinTrackBar = New System.Windows.Forms.TrackBar()
        Me.MinimumLengthTextBox = New System.Windows.Forms.TextBox()
        Me.MinSeqNo = New System.Windows.Forms.Label()
        Me.MaxSeqNumberLabel = New System.Windows.Forms.Label()
        Me.MaximumTextBox = New System.Windows.Forms.TextBox()
        Me.MaximumTrackBar = New System.Windows.Forms.TrackBar()
        Me.BeginViewing = New System.Windows.Forms.Button()
        CType(Me.MinTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaximumTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MinTrackBar
        '
        Me.MinTrackBar.Location = New System.Drawing.Point(12, 25)
        Me.MinTrackBar.Name = "MinTrackBar"
        Me.MinTrackBar.Size = New System.Drawing.Size(174, 45)
        Me.MinTrackBar.TabIndex = 0
        '
        'MinimumLengthTextBox
        '
        Me.MinimumLengthTextBox.Location = New System.Drawing.Point(192, 25)
        Me.MinimumLengthTextBox.Name = "MinimumLengthTextBox"
        Me.MinimumLengthTextBox.Size = New System.Drawing.Size(80, 20)
        Me.MinimumLengthTextBox.TabIndex = 1
        '
        'MinSeqNo
        '
        Me.MinSeqNo.AutoSize = True
        Me.MinSeqNo.Location = New System.Drawing.Point(9, 9)
        Me.MinSeqNo.Name = "MinSeqNo"
        Me.MinSeqNo.Size = New System.Drawing.Size(110, 13)
        Me.MinSeqNo.TabIndex = 2
        Me.MinSeqNo.Text = "Minimum Seq Number"
        '
        'MaxSeqNumberLabel
        '
        Me.MaxSeqNumberLabel.AutoSize = True
        Me.MaxSeqNumberLabel.Location = New System.Drawing.Point(9, 73)
        Me.MaxSeqNumberLabel.Name = "MaxSeqNumberLabel"
        Me.MaxSeqNumberLabel.Size = New System.Drawing.Size(113, 13)
        Me.MaxSeqNumberLabel.TabIndex = 3
        Me.MaxSeqNumberLabel.Text = "Maximum Seq Number"
        '
        'MaximumTextBox
        '
        Me.MaximumTextBox.Location = New System.Drawing.Point(192, 89)
        Me.MaximumTextBox.Multiline = True
        Me.MaximumTextBox.Name = "MaximumTextBox"
        Me.MaximumTextBox.Size = New System.Drawing.Size(80, 20)
        Me.MaximumTextBox.TabIndex = 4
        '
        'MaximumTrackBar
        '
        Me.MaximumTrackBar.Location = New System.Drawing.Point(12, 89)
        Me.MaximumTrackBar.Name = "MaximumTrackBar"
        Me.MaximumTrackBar.Size = New System.Drawing.Size(174, 45)
        Me.MaximumTrackBar.TabIndex = 5
        '
        'BeginViewing
        '
        Me.BeginViewing.Location = New System.Drawing.Point(12, 128)
        Me.BeginViewing.Name = "BeginViewing"
        Me.BeginViewing.Size = New System.Drawing.Size(75, 23)
        Me.BeginViewing.TabIndex = 6
        Me.BeginViewing.Text = "Begin"
        Me.BeginViewing.UseVisualStyleBackColor = True
        '
        'BasketofLengthsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BeginViewing)
        Me.Controls.Add(Me.MaximumTrackBar)
        Me.Controls.Add(Me.MaximumTextBox)
        Me.Controls.Add(Me.MaxSeqNumberLabel)
        Me.Controls.Add(Me.MinSeqNo)
        Me.Controls.Add(Me.MinimumLengthTextBox)
        Me.Controls.Add(Me.MinTrackBar)
        Me.Name = "BasketofLengthsForm"
        Me.Text = "DNAnalyse"
        CType(Me.MinTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaximumTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MinTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents MinimumLengthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MinSeqNo As System.Windows.Forms.Label
    Friend WithEvents MaxSeqNumberLabel As System.Windows.Forms.Label
    Friend WithEvents MaximumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaximumTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents BeginViewing As System.Windows.Forms.Button
End Class
