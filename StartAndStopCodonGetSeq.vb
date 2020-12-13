Public Class StartAndStopCodonGetSeq

  
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click


        DNATextBox.Text = ""

    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click



        OutputSASCodon.GetSeq(DNATextBox.Text)
        Me.Close()


    End Sub
End Class