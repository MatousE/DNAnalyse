<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CGContentForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CGContentLabel = New System.Windows.Forms.Label()
        Me.CGPieChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.CGPieChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(86, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 20)
        Me.TextBox1.TabIndex = 0
        '
        'CGContentLabel
        '
        Me.CGContentLabel.AutoSize = True
        Me.CGContentLabel.Location = New System.Drawing.Point(15, 15)
        Me.CGContentLabel.Name = "CGContentLabel"
        Me.CGContentLabel.Size = New System.Drawing.Size(65, 13)
        Me.CGContentLabel.TabIndex = 1
        Me.CGContentLabel.Text = "CG Content:"
        '
        'CGPieChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.CGPieChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.CGPieChart.Legends.Add(Legend1)
        Me.CGPieChart.Location = New System.Drawing.Point(12, 38)
        Me.CGPieChart.Name = "CGPieChart"
        Me.CGPieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.CGPieChart.Series.Add(Series1)
        Me.CGPieChart.Size = New System.Drawing.Size(300, 300)
        Me.CGPieChart.TabIndex = 2
        Me.CGPieChart.Text = "Chart1"
        '
        'CGContentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 388)
        Me.Controls.Add(Me.CGPieChart)
        Me.Controls.Add(Me.CGContentLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "CGContentForm"
        Me.Text = "DNAnalyse"
        CType(Me.CGPieChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CGContentLabel As System.Windows.Forms.Label
    Friend WithEvents CGPieChart As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
