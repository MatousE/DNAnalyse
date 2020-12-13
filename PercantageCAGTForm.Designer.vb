<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PercentageCAGTForm
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.CLabel = New System.Windows.Forms.Label()
        Me.CTextBox = New System.Windows.Forms.TextBox()
        Me.ATextBox = New System.Windows.Forms.TextBox()
        Me.ALabel = New System.Windows.Forms.Label()
        Me.GTextBox = New System.Windows.Forms.TextBox()
        Me.GLabel = New System.Windows.Forms.Label()
        Me.TTextBox = New System.Windows.Forms.TextBox()
        Me.TLabel = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(300, 300)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'CLabel
        '
        Me.CLabel.AutoSize = True
        Me.CLabel.Location = New System.Drawing.Point(343, 24)
        Me.CLabel.Name = "CLabel"
        Me.CLabel.Size = New System.Drawing.Size(20, 13)
        Me.CLabel.TabIndex = 1
        Me.CLabel.Text = "C: "
        '
        'CTextBox
        '
        Me.CTextBox.Location = New System.Drawing.Point(369, 21)
        Me.CTextBox.Name = "CTextBox"
        Me.CTextBox.Size = New System.Drawing.Size(120, 20)
        Me.CTextBox.TabIndex = 2
        '
        'ATextBox
        '
        Me.ATextBox.Location = New System.Drawing.Point(369, 47)
        Me.ATextBox.Name = "ATextBox"
        Me.ATextBox.Size = New System.Drawing.Size(120, 20)
        Me.ATextBox.TabIndex = 4
        '
        'ALabel
        '
        Me.ALabel.AutoSize = True
        Me.ALabel.Location = New System.Drawing.Point(343, 50)
        Me.ALabel.Name = "ALabel"
        Me.ALabel.Size = New System.Drawing.Size(20, 13)
        Me.ALabel.TabIndex = 3
        Me.ALabel.Text = "A: "
        '
        'GTextBox
        '
        Me.GTextBox.Location = New System.Drawing.Point(369, 73)
        Me.GTextBox.Name = "GTextBox"
        Me.GTextBox.Size = New System.Drawing.Size(120, 20)
        Me.GTextBox.TabIndex = 6
        '
        'GLabel
        '
        Me.GLabel.AutoSize = True
        Me.GLabel.Location = New System.Drawing.Point(343, 76)
        Me.GLabel.Name = "GLabel"
        Me.GLabel.Size = New System.Drawing.Size(21, 13)
        Me.GLabel.TabIndex = 5
        Me.GLabel.Text = "G: "
        '
        'TTextBox
        '
        Me.TTextBox.Location = New System.Drawing.Point(369, 99)
        Me.TTextBox.Name = "TTextBox"
        Me.TTextBox.Size = New System.Drawing.Size(120, 20)
        Me.TTextBox.TabIndex = 8
        '
        'TLabel
        '
        Me.TLabel.AutoSize = True
        Me.TLabel.Location = New System.Drawing.Point(343, 102)
        Me.TLabel.Name = "TLabel"
        Me.TLabel.Size = New System.Drawing.Size(20, 13)
        Me.TLabel.TabIndex = 7
        Me.TLabel.Text = "T: "
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(369, 125)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(120, 20)
        Me.TotalTextBox.TabIndex = 9
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(326, 128)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(37, 13)
        Me.TotalLabel.TabIndex = 10
        Me.TotalLabel.Text = "Total: "
        '
        'PercentageCAGTForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 360)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.TTextBox)
        Me.Controls.Add(Me.TLabel)
        Me.Controls.Add(Me.GTextBox)
        Me.Controls.Add(Me.GLabel)
        Me.Controls.Add(Me.ATextBox)
        Me.Controls.Add(Me.ALabel)
        Me.Controls.Add(Me.CTextBox)
        Me.Controls.Add(Me.CLabel)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "PercentageCAGTForm"
        Me.Text = "PrcntCAGT"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents CLabel As System.Windows.Forms.Label
    Friend WithEvents CTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ATextBox As System.Windows.Forms.TextBox
    Friend WithEvents ALabel As System.Windows.Forms.Label
    Friend WithEvents GTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GLabel As System.Windows.Forms.Label
    Friend WithEvents TTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TLabel As System.Windows.Forms.Label
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
End Class
