Public Class OutputBasketSeqs
    Private allseqs() As String
    Public Sub ImprtFile(ByVal ImportedData() As String)
        allseqs = ImportedData






    End Sub
    Private Sub OutputBasketSeqs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try


            For looper = BasketofLengthsForm.GetMinVal To BasketofLengthsForm.GetMaxVal

                RichOutputTextBox.Text += ControlChars.NewLine

                RichOutputTextBox.Text += allseqs(looper) & ControlChars.NewLine


            Next

            For looper = 0 To RichOutputTextBox.Text.Length - 1
                If RichOutputTextBox.Text(looper) = "C" Then
                    RichOutputTextBox.Select(looper, 1)
                    RichOutputTextBox.SelectionBackColor = Color.Yellow
                End If
                If RichOutputTextBox.Text(looper) = "A" Then
                    RichOutputTextBox.Select(looper, 1)
                    RichOutputTextBox.SelectionBackColor = Color.Red
                End If
                If RichOutputTextBox.Text(looper) = "G" Then
                    RichOutputTextBox.Select(looper, 1)
                    RichOutputTextBox.SelectionBackColor = Color.Green
                End If
                If RichOutputTextBox.Text(looper) = "T" Then
                    RichOutputTextBox.Select(looper, 1)
                    RichOutputTextBox.SelectionBackColor = Color.Cyan

                End If




            Next





        Catch ex As Exception

        End Try


    End Sub

    Private Sub OutputTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichOutputTextBox.TextChanged

    End Sub
End Class