Public Class OutputSASCodon
    Protected DNASeq As String
    Protected DNATxtBox As New RichTextBox

    Protected StopCodon() As String = {"TAA", "TAG", "TGA"}
    Public Sub GetSeq(ByVal seq As String)

        DNASeq = seq

        DNATxtBox.Name = "DNAOutputTxtBox"
        DNATxtBox.Bounds = New Rectangle(Me.Location, New Size(500, 500))
        DNATxtBox.Multiline = True
        DNATxtBox.Location = New Point(10, 20)

        Me.Controls.Add(DNATxtBox)

        Me.Show()
        CodonSearch()



    End Sub

    Public Sub CodonSearch()
        Dim TempStr As String
        Dim PositionsOfStartCodons As New List(Of Integer)
        Dim PositionsOfStopCodons As New List(Of Integer)
        Dim CountInt As Integer = 0


        For StartSearchLooper = 0 To DNASeq.Length - 3
            TempStr = DNASeq(StartSearchLooper) + DNASeq(StartSearchLooper + 1) + DNASeq(StartSearchLooper + 2)
            If TempStr = "ATG" Then
                PositionsOfStartCodons.Add(StartSearchLooper)

            End If
            StartSearchLooper += 2
        Next

        DNATxtBox.Text += DNASeq

        For Each Position In PositionsOfStartCodons
            DNATxtBox.Select(Position, 3)
            DNATxtBox.SelectionBackColor = Color.Green
        Next



        For CodonLooper = 0 To StopCodon.Length - 1

            For StopSearchLooper = 0 To DNASeq.Length - 3
                TempStr = DNASeq(StopSearchLooper) + DNASeq(StopSearchLooper + 1) + DNASeq(StopSearchLooper + 2)
                If TempStr = StopCodon(CodonLooper) Then
                    PositionsOfStopCodons.Add(StopSearchLooper)
                End If
                StopSearchLooper += 2
            Next
        Next

       

        For Each Position In PositionsOfStopCodons
            DNATxtBox.Select(Position, 3)
            DNATxtBox.SelectionBackColor = Color.Red
        Next



    End Sub

   
End Class