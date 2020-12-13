Public Class PercentageCAGTForm

    Private Sub PrcntCAGT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Chart1.Series.Clear()



        Me.Chart1.Series.Add("C")
        Me.Chart1.Series.Add("A")
        Me.Chart1.Series.Add("G")
        Me.Chart1.Series.Add("T")

        Me.Chart1.Series("C").Points.AddXY(1, PercentageCAGT.GetC)
        Me.Chart1.Series("A").Points.AddXY(2, PercentageCAGT.GetA)
        Me.Chart1.Series("G").Points.AddXY(3, PercentageCAGT.GetG)
        Me.Chart1.Series("T").Points.AddXY(4, PercentageCAGT.GetT)

        CTextBox.Text = PercentageCAGT.GetC
        ATextBox.Text = PercentageCAGT.GetA
        GTextBox.Text = PercentageCAGT.GetG
        TTextBox.Text = PercentageCAGT.GetT
        TotalTextBox.Text = PercentageCAGT.GetTotal



    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub

    Private Sub TotalLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalLabel.Click

    End Sub
End Class