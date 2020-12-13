Class MeanMedianMode

    Inherits MainClass

    Private Mean As Integer
    Private Median As Integer
    Private Mode As Integer

    Public Sub CalculateMeanModeMedian(ByVal InputString() As String, ByVal Delims As Integer)




        CalculateMean(InputString)
        CalculateMedian(Delims, InputString)


        CalculateMode(InputString, Delims)


        MeanMedianModeForm.Show()




    End Sub
    Private Sub CalculateMean(ByVal SplitSeqs() As String)
        Dim total As Integer
        For loopert = 0 To SplitSeqs.Length - 1
            total += Len(SplitSeqs(loopert))
        Next
        Mean = total / SplitSeqs.Length


    End Sub
    Private Sub CalculateMedian(ByVal Delimters As Integer, ByVal SplitSeqs() As String)


        Dim Half As Integer
        Half = Delimters / 2

        Half = Math.Round(Half, 0)




        Median = Len(SplitSeqs(Half))


    End Sub
    Private Sub CalculateMode(ByVal ListOfSeqs() As String, ByVal Delimters As Integer)
        Dim MaxLength As Integer
        Dim ListOfLength(Delimters) As Integer
        Dim TempLength As Integer


        MaxLength = Len(ListOfSeqs(Delimters))


        For looper = 1 To ListOfSeqs.Length - 1

            TempLength = Len(ListOfSeqs(looper))
            ListOfLength(TempLength) += 1

        Next


        For looper = 0 To ListOfLength.Length - 2
            If ListOfLength(looper + 1) > ListOfLength(looper) Then
                Mode = ListOfLength(looper + 1)
            End If



        Next


    End Sub
    Public Function GetMean() As String




        Return Mean


    End Function
    Public Function GetMedian() As String

        Return Median

    End Function
    Public Function GetMode() As String


        Return Mode

    End Function
End Class