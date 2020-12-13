Public Class OutputRandomDNASeq
    Protected DNASeqTxtBox As New RichTextBox
    Public Sub GetInput(ByVal NoCodonds As Integer)



        DNASeqTxtBox.Name = "DNAOutputTxtBox"
        DNASeqTxtBox.Bounds = New Rectangle(Me.Location, New Size(500, 500))
        DNASeqTxtBox.Multiline = True
        DNASeqTxtBox.Location = New Point(10, 60)

        Me.Controls.Add(DNASeqTxtBox)

        Randomize()

        DNASeqTxtBox.Text += ">"

        Dim RandNumberInt As Integer


        For looper = 0 To (NoCodonds * 3) - 1
            RandNumberInt = Int((4 * Rnd()) + 1)
            Select Case RandNumberInt
                Case 1
                    DNASeqTxtBox.Text += "A"
                Case 2
                    DNASeqTxtBox.Text += "C"
                Case 3
                    DNASeqTxtBox.Text += "G"
                Case 4
                    DNASeqTxtBox.Text += "T"
            End Select




        Next
        Me.Show()


    End Sub

    Private Sub OutputRandomDNASeq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class