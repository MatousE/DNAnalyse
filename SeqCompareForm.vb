Public Class SeqCompareForm

    Private filename As String
    Private TextSequence As String

    Private Sub SeqCompareForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub FileImportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileImportButton.Click

        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            FileTextBox.Text = OpenFileDialog.FileName

        End If

        filename = OpenFileDialog.FileName



    End Sub
    Public Function GetFileName() As String
        Return filename

    End Function


  
    Private Sub TextImportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextImportButton.Click


        Dim TempSeq As String
        Dim InvalidSeq As Boolean

        TempSeq = SeqTextBox.Text

        If SeqTextBox.Text.Length >= 1 Then
            For looper = 0 To SeqTextBox.Text.Length - 1
                If SeqTextBox.Text(looper) = "C" Or SeqTextBox.Text(looper) = "A" Or SeqTextBox.Text(looper) = "G" Or SeqTextBox.Text(looper) = "T" Then
                    TempSeq += SeqTextBox.Text(looper)
                Else
                    InvalidSeq = True
                    Exit For
                End If
            Next

            If InvalidSeq = True Then

                MsgBox("Invalid Sequence")

            End If
        End If



    End Sub
    Private Sub BLAST()





    End Sub

End Class