Public Class CGContentForm

    Private Sub CGContentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        TextBox1.Text = CGContentCalc.GetCGContent
        TextBox1.Text += "%"

        Me.CGPieChart.Series.Clear()

        Me.CGPieChart.Series.Add("C")
        Me.CGPieChart.Series.Add("A")
        Me.CGPieChart.Series.Add("G")
        Me.CGPieChart.Series.Add("T")


        Me.CGPieChart.Series("C").Points.AddXY(1, CGContentCalc.GetC)
        Me.CGPieChart.Series("A").Points.AddXY(2, CGContentCalc.GetA)
        Me.CGPieChart.Series("G").Points.AddXY(3, CGContentCalc.GetG)
        Me.CGPieChart.Series("T").Points.AddXY(4, CGContentCalc.GetT)

        'Me.CGPieChart.Series("G").Points.
        'Me.CGPieChart.Series("T").Points.







    End Sub


    
    Private Sub CGPieChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CGPieChart.Click

    End Sub
End Class