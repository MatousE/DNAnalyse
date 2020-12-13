Imports System.IO
Public Class MainClass
    Dim AllAvailableString As String
    Dim AllAvaialbleSeqArray() As String
    Dim DelimiterCount As Integer


    Public Sub Main(ByVal FILENAme As String)




        Try
            Dim alltext = System.IO.File.ReadAllText(FILENAme)



            Dim Delimiter As Integer = 0

            AllAvailableString = alltext

            For looper = 0 To alltext.Length - 1
                If alltext(looper) = ">" Then
                    Delimiter += 1
                End If
            Next



            ProgressBar1.Maximum = Delimiter

            Me.Enabled = False

            ProgressBar1.Visible = True
            ProgressBar1.Enabled = True

            '## Splits the DNA 
            Dim Dcount As Integer
            Dim SLength As Integer

            MsgBox("Please wait whilst your DNA seqs are being processed")

            Dim ListOfSeq(Delimiter) As String
            Do Until SLength = alltext.Length - 1

                If alltext(SLength) = "C" Then
                    ListOfSeq(Dcount) += "C"
                ElseIf alltext(SLength) = "A" Then
                    ListOfSeq(Dcount) += "A"
                ElseIf alltext(SLength) = "G" Then
                    ListOfSeq(Dcount) += "G"
                ElseIf alltext(SLength) = "T" Then
                    ListOfSeq(Dcount) += "T"
                ElseIf alltext(SLength) = ">" Then
                    Dcount += 1
                    ProgressBar1.Increment(1)
                End If


                SLength += 1

            Loop
            MsgBox("Your DNA file has been loaded")
            Me.Enabled = True

            DelimiterCount = Delimiter

            ReDim AllAvaialbleSeqArray(Delimiter)


            For looper = 0 To ListOfSeq.Length - 1
                AllAvaialbleSeqArray(looper) = ListOfSeq(looper)


            Next


        Catch ex As Exception


        End Try
    End Sub
    Private Sub ImportFileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportFileButton.Click


        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName

        End If

        Dim filename As String = OpenFileDialog1.FileName


        Main(filename)




    End Sub




    Public Sub BeginDNASearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeginDNASearch.Click

        If ComboBoxForFileTools.Text.Length > 0 Then
            If ComboBoxForFileTools.Text = "%C,A,G,T" Then
                PercentageCAGT.CalculationRepresentation(AllAvailableString)
            ElseIf ComboBoxForFileTools.Text = "Mean, Median & Modal Length" Then
                MeanMedianMode.CalculateMeanModeMedian(AllAvaialbleSeqArray, DelimiterCount)
            ElseIf ComboBoxForFileTools.Text = "CG Content" Then
                CGContentCalc.CGCalculator(AllAvailableString)
            ElseIf ComboBoxForFileTools.Text = "Basket of Lengths" Then
                OutputBasketSeqs.ImprtFile(AllAvaialbleSeqArray)
                BasketofLengthsCalc.InportData(DelimiterCount)
            ElseIf ComboBoxForFileTools.Text = "Search for Seq in File" Then
                SeqSearchForm.ImprtSeqs(AllAvaialbleSeqArray)
                SeqSearchForm.Show()
            ElseIf ComboBoxForFileTools.Text = "Regular Expression" Then
                RegularExpressionClass.GetAllString(AllAvailableString)
            End If
        Else
            If ComboBoxForNonFileTools.Text = "Codon Usage" Then
                CodonUsage.Show()
            ElseIf ComboBoxForNonFileTools.Text = "Start and Stop Codons" Then
                StartAndStopCodonGetSeq.Show()
            ElseIf ComboBoxForNonFileTools.Text = "CpG Islands" Then
                CpGIslandForm.Show()
            ElseIf ComboBoxForNonFileTools.Text = "Random DNA Sequence" Then
                GenerateRandomDNAseq.Show()
            ElseIf ComboBoxForNonFileTools.Text = "PCR Primer Stats" Then
                PCRPrimerStatsForm.Show()
            ElseIf ComboBoxForNonFileTools.Text = "Translation Map" Then
                TranslationMap.Show()

            End If
        End If











    End Sub




    Private Sub MainClass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        Needs.Text = ("If You Would Like to Import DNA Sequences From A Text File Then You Can Use the File Directory To Do So")


    End Sub


    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
