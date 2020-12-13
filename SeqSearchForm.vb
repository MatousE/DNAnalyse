Imports System.IO
Public Class SeqSearchForm
    Dim filename As String
    Dim ImportedSeq As String
    Dim allseqs() As String
    Dim count As Integer

    Private Sub SeqSearchForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
987:

        SeqRichTextBox.Visible = False


    End Sub
    Public Sub ImprtSeqs(ByVal InputString() As String)
        allseqs = InputString
      
    End Sub

    
    Private Sub TextSeqImportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextSeqImportButton.Click

        SeqRichTextBox.Text = ""

        TextSeqImportButton.Enabled = False


        System.Array.Sort(allseqs)

        Dim invalidseq As Boolean


        For looper = 0 To SnglSeqTextBox.Text.Length - 1
            If SnglSeqTextBox.Text(looper) = "C" Or
                SnglSeqTextBox.Text(looper) = "A" Or
                SnglSeqTextBox.Text(looper) = "G" Or
                SnglSeqTextBox.Text(looper) = "T" Then

            Else
                invalidseq = True
                Exit For
            End If
        Next


        If invalidseq = False Then
            SeqRichTextBox.Visible = True
            RecurssiveBinarySearch(SnglSeqTextBox.Text, allseqs.Length, 0)
        Else
            TextSeqImportButton.Enabled = True
            MsgBox("Invalid Sequence")
        End If




    

    End Sub

    Private Sub RecurssiveBinarySearch(ByVal Target As String, ByVal High As Integer, ByVal Low As Integer)
        Dim H As Integer = High
        Dim M As Integer
        Dim L As Integer = Low
        Dim Targ As String = Target

        count += 1

        M = (L + H) \ 2 'Midpoint = LowPoint + HeighPoint \ 2

        If L > H Then ' If LowPoint > HeighPoint then Target is not in list
            SeqRichTextBox.Text += ControlChars.NewLine
            SeqRichTextBox.Text += ("Not In List") 'Base Case 1 which ends the recurssion
        ElseIf allseqs(M) > Target Then ' If the MidPoint Sequence > Target
            SeqRichTextBox.Text += allseqs(M)
            SeqRichTextBox.Text += ControlChars.NewLine
            SeqRichTextBox.Text += " Not Equal To "
            SeqRichTextBox.Text += ControlChars.NewLine
            SeqRichTextBox.Text += Target
            SeqRichTextBox.Text += ControlChars.NewLine
            SeqRichTextBox.Text += ControlChars.NewLine
            RecurssiveBinarySearch(Targ, M - 1, L) 'Makes the HighPoint = Midpoint -1 to lower the bounds of the search
        ElseIf allseqs(M) < Target Then ' If the MidPoint Sequence < Target
            SeqRichTextBox.Text += allseqs(M)
            SeqRichTextBox.Text += ControlChars.NewLine
            SeqRichTextBox.Text += " Not Equal To "
            SeqRichTextBox.Text += ControlChars.NewLine
            SeqRichTextBox.Text += Target
            SeqRichTextBox.Text += ControlChars.NewLine
            SeqRichTextBox.Text += ControlChars.NewLine
            TextSeqImportButton.Enabled = True
            RecurssiveBinarySearch(Targ, H, M + 1) ' Makes the LowPoint = Midpoint +1 to lower the bounds of the search 
        Else ' Else the Target Sequence has been found
            SeqRichTextBox.Text += ControlChars.NewLine
            SeqRichTextBox.Text += ("Found") 'BaseCase2
            TextSeqImportButton.Enabled = True
        End If
    End Sub
End Class