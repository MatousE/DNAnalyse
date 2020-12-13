<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutputSASCodon
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
        Me.RedLable = New System.Windows.Forms.Label()
        Me.StartLable = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RedLable
        '
        Me.RedLable.AutoSize = True
        Me.RedLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedLable.ForeColor = System.Drawing.Color.Red
        Me.RedLable.Location = New System.Drawing.Point(589, 27)
        Me.RedLable.Name = "RedLable"
        Me.RedLable.Size = New System.Drawing.Size(110, 18)
        Me.RedLable.TabIndex = 0
        Me.RedLable.Text = "STOP CODON"
        '
        'StartLable
        '
        Me.StartLable.AutoSize = True
        Me.StartLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartLable.ForeColor = System.Drawing.Color.DarkGreen
        Me.StartLable.Location = New System.Drawing.Point(589, 59)
        Me.StartLable.Name = "StartLable"
        Me.StartLable.Size = New System.Drawing.Size(117, 18)
        Me.StartLable.TabIndex = 1
        Me.StartLable.Text = "START CODON"
        '
        'OutputSASCodon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 561)
        Me.Controls.Add(Me.StartLable)
        Me.Controls.Add(Me.RedLable)
        Me.Name = "OutputSASCodon"
        Me.Text = "OutputSASCodon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RedLable As System.Windows.Forms.Label
    Friend WithEvents StartLable As System.Windows.Forms.Label
End Class
