Public Class OutputRegExprSeqs
    Protected AllSplitRESeqs() As String
    Protected JointSeqStr As String

    Private Sub OutputRegExprSeqs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Show()

        AllSplitRESeqs = RegularExpressionClass.GetSplitArr


        Dim CountInt As Integer


        For Each SeqSplit In AllSplitRESeqs
            CountInt += 1
            If CountInt Mod 2 = 0 Then
                JointSeqStr += "$"
                JointSeqStr += SeqSplit
                JointSeqStr += "!"
            Else
                JointSeqStr += SeqSplit
            End If
        Next

        JointSeqStr = JointSeqStr.Substring(0, JointSeqStr.Length - 1)


        RegExprRichTextBox.Text += JointSeqStr


        For looper = 0 To RegExprRichTextBox.Text.Length - 1

            If RegExprRichTextBox.Text(looper) = "$" Then
                For inlooper = looper To RegExprRichTextBox.Text.Length - 1
                    If RegExprRichTextBox.Text(inlooper) <> "!" Then
                        RegExprRichTextBox.Select(inlooper, 1)
                        RegExprRichTextBox.SelectionBackColor = Color.Red
                        RegExprRichTextBox.Update()
                        Threading.Thread.Sleep(50)

                    Else
                        Exit For
                    End If



                Next
            End If

        Next















    End Sub

    Private Function HighlightToNextPoint(ByVal StartParkPos As Integer)

        For looper = StartParkPos To JointSeqStr.Length - 1
            If JointSeqStr(looper) = "!" Then
                Return looper

            End If
        Next


    End Function

End Class