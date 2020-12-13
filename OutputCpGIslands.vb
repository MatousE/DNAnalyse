Public Class OutputCpGIslands
    Protected DNASeq As String
    Protected CpGIslandTxtBox As New RichTextBox


    Dim C As Integer
    Dim G As Integer
    Dim TotalCount As Integer



    Private Sub OutputCpGIslands_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim startloop As Integer = 0
        Dim endloop As Integer = 199
        Me.Bounds = New Rectangle(Me.Location, New Size(700, 700))

        CpGIslandTxtBox.Name = "DNAOutputTxtBox"
        CpGIslandTxtBox.Bounds = New Rectangle(Me.Location, New Size(650, 500))
        CpGIslandTxtBox.Multiline = True
        CpGIslandTxtBox.Location = New Point(10, 60)

        Me.Controls.Add(CpGIslandTxtBox)



        RecurssiveGCCalc(startloop, endloop)

    End Sub
    Public Sub GetDNASeq(ByVal SEQ As String)
        DNASeq = SEQ

        Me.Show()



    End Sub

    Public Sub RecurssiveGCCalc(ByVal start As Integer, ByVal endl As Integer)

        Dim TempDbl As Double

        If endl <> DNASeq.Length - 2 Then 'IF Upper bound of loop not equal to DNA sequence length
            For looper = start To endl ' Loop between bounds start to endl
                If DNASeq(looper) = "C" Then ' if DNA character at point looper = C then 
                    C += 1 ' Total Number of Cs +1
                    TotalCount += 1 ' TotalCount + 1
                ElseIf DNASeq(looper) = "G" Then ' if DNA character at point looper = G then 
                    G += 1 ' Total number of Gs + 1
                    TotalCount += 1 ' Total Count + 1
                ElseIf DNASeq(looper) = "A" Then ' if DNA character at point looper = A then 
                    TotalCount += 1 ' Total count + 1
                ElseIf DNASeq(looper) = "T" Then ' if DNA character at point looper = T then 
                    TotalCount += 1 ' Total count + 1
                End If
            Next
            TempDbl = (((G + C) / TotalCount) * 100) ' Calculates the GC content between the bounds of start to endl
            If TempDbl >= 50 Then ' If the GC content in temp is > 50 then there is a CgP island
                CpGIslandTxtBox.Text += "CpG Island Found Between " & start + 1 & " and " & endl + 1 ' Prints the fact that there is a CgP Island
                CpGIslandTxtBox.Text += " %CG: " & Math.Round(TempDbl, 2) ' Prints the GC content
                CpGIslandTxtBox.Text += ControlChars.NewLine
                CpGIslandTxtBox.Text += ControlChars.NewLine
            End If
            C = 0 ' Sets C to 0
            G = 0 ' Sets G to 0
            TotalCount = 0 ' Total cout = 0
            RecurssiveGCCalc(start + 1, endl + 1) ' Calls itself again and increments the start and endl vars by 1
        Else
            ' base case

        End If



    End Sub
End Class