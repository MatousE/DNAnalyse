Public Class MeanMedianModeForm





    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MeanTextBox.Text = MeanMedianMode.GetMean
        MedianTextBox.Text = MeanMedianMode.GetMedian
        ModeTextBox.Text = MeanMedianMode.GetMode


    End Sub


 
End Class
