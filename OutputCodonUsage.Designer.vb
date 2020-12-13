<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutputCodonUsage
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
        Me.CodonChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.CodonPlotTextBox = New System.Windows.Forms.RichTextBox()
        CType(Me.CodonChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodonChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.CodonChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.CodonChart.Legends.Add(Legend1)
        Me.CodonChart.Location = New System.Drawing.Point(488, 13)
        Me.CodonChart.Name = "CodonChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.CodonChart.Series.Add(Series1)
        Me.CodonChart.Size = New System.Drawing.Size(781, 439)
        Me.CodonChart.TabIndex = 1
        Me.CodonChart.Text = "Chart1"
        '
        'CodonPlotTextBox
        '
        Me.CodonPlotTextBox.Location = New System.Drawing.Point(11, 24)
        Me.CodonPlotTextBox.Name = "CodonPlotTextBox"
        Me.CodonPlotTextBox.Size = New System.Drawing.Size(455, 379)
        Me.CodonPlotTextBox.TabIndex = 2
        Me.CodonPlotTextBox.Text = ""
        '
        'OutputCodonUsage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 483)
        Me.Controls.Add(Me.CodonPlotTextBox)
        Me.Controls.Add(Me.CodonChart)
        Me.Name = "OutputCodonUsage"
        Me.Text = "Output Of Codon Plot"
        CType(Me.CodonChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CodonChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents CodonPlotTextBox As System.Windows.Forms.RichTextBox
End Class
