<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CpGIslandForm
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
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ComboBoxSites = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(12, 237)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(137, 31)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "SUBMIT"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(155, 237)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(137, 31)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "CLEAR"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ComboBoxSites
        '
        Me.ComboBoxSites.FormattingEnabled = True
        Me.ComboBoxSites.Items.AddRange(New Object() {"Show CpG Sites ", "Show GpC Sites", "CpG and GcP Sites", "CpG Islands"})
        Me.ComboBoxSites.Location = New System.Drawing.Point(13, 210)
        Me.ComboBoxSites.Name = "ComboBoxSites"
        Me.ComboBoxSites.Size = New System.Drawing.Size(279, 21)
        Me.ComboBoxSites.TabIndex = 2
        '
        'ComboBoxLabel
        '
        Me.ComboBoxLabel.AutoSize = True
        Me.ComboBoxLabel.Location = New System.Drawing.Point(13, 191)
        Me.ComboBoxLabel.Name = "ComboBoxLabel"
        Me.ComboBoxLabel.Size = New System.Drawing.Size(249, 13)
        Me.ComboBoxLabel.TabIndex = 3
        Me.ComboBoxLabel.Text = "Below You Can Select Different CpG Related Tools"
        '
        'CpGIslandForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 335)
        Me.Controls.Add(Me.ComboBoxLabel)
        Me.Controls.Add(Me.ComboBoxSites)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Name = "CpGIslandForm"
        Me.Text = "CpGIslandForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ComboBoxSites As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxLabel As System.Windows.Forms.Label
End Class
