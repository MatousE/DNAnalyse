Public Class CGContentCalc
    Inherits MainClass
    Private C, A, G, T, Total As Integer
    Private CGCOntent As Decimal
    Public Sub CGCalculator(ByVal alltext As String)



        For outLooper = 0 To alltext.Length - 1

            If alltext(outLooper) = "C" Then
                C += 1
            ElseIf alltext(outLooper) = "A" Then
                A += 1
            ElseIf alltext(outLooper) = "G" Then
                G += 1
            ElseIf alltext(outLooper) = "T" Then
                T += 1
            End If
        Next


        CGCOntent = (((G + C) / (C + A + G + T)) * 100)
        CGContentForm.Show()


    End Sub
    Public Function GetCGContent() As Decimal
        Return CGCOntent

    End Function
    Public Function GetC() As Integer
        Return C

    End Function
    Public Function GetA() As Integer
        Return A

    End Function
    Public Function GetG() As Integer
        Return G

    End Function
    Public Function GetT() As Integer
        Return T

    End Function
End Class
