Public Class CodonUsage
    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click

        OutputCodonUsage.PassCodon(CodonTextBox.Text)
        Me.Close()

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click

        CodonTextBox.Text = ""

    End Sub
End Class