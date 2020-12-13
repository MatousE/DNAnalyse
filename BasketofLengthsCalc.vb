Public Class BasketofLengthsCalc
    Inherits MainClass
    Private Delims As Integer



    Public Sub InportData(ByVal delimcount As Integer)



        Delims = delimcount




        BasketofLengthsForm.Show()


    End Sub
    Public Function GetDelimiter() As Integer


        Return Delims

    End Function


End Class
