'Imports GemBox.Document

Public Class BasketofLengthsForm
    Private MaximumVal As Integer
    Private MinimumVal As Integer


    Private Sub BasketofLengthsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim delimtemp As Integer = BasketofLengthsCalc.GetDelimiter()

        MinTrackBar.Minimum = 1
        MaximumTrackBar.Minimum = 1

        MinTrackBar.Maximum = delimtemp
        MaximumTrackBar.Maximum = delimtemp





    End Sub

    Private Sub MinTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinTrackBar.Scroll

        MinimumLengthTextBox.Text = MinTrackBar.Value


    End Sub

    Private Sub MaximumTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaximumTrackBar.Scroll

        MaximumTextBox.Text = MaximumTrackBar.Value

    End Sub


    Private Sub BeginViewing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeginViewing.Click

        If MinTrackBar.Value > MaximumTrackBar.Value Then
            MsgBox("Your minimum value is greater than your maximum")
        Else
            MinimumVal = MinTrackBar.Value
            MaximumVal = MaximumTrackBar.Value
            OutputBasketSeqs.Show()

        End If


    End Sub
    Public Function GetMinVal() As Integer
        Return MinimumVal

    End Function
    Public Function GetMaxVal() As Integer


        Return MaximumVal

    End Function
End Class