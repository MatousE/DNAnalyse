Imports System.Text.RegularExpressions
Public Class RegularExpressionClass
    Inherits MainClass
    Protected AllSeqs As String
    Protected RegexStr As String
    Protected SplitArrSqs() As String
    Public Sub GetAllString(ByVal AllImportedSequences As String)

        AllSeqs = AllImportedSequences
        REKeyboard.Show()


    End Sub

    Public Sub GetRegularExpression(ByVal RegExpr As String)

        RegexStr = RegExpr

        ApplyingRegExpToAllSeqs()

    End Sub
    Private Sub ApplyingRegExpToAllSeqs()
        Try


            Dim SplitArr() As String = Regex.Split(AllSeqs, RegexStr)

            SplitArrSqs = SplitArr

            OutputRegExprSeqs.Show()

        Catch ex As Exception

        End Try



    End Sub
    Public Function GetSplitArr()

        Return SplitArrSqs

    End Function


End Class
