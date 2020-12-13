Public Class GenerateRandomDNAseq

    

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        TextBoxNoCodonsUInput.Text = ""

    End Sub

    Private Sub ButtonSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSubmit.Click
        OutputRandomDNASeq.GetInput(TextBoxNoCodonsUInput.Text)
        Me.Close()

    End Sub
End Class