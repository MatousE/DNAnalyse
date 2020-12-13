Public Class PercentageCAGT
    Inherits MainClass
    Private C, A, G, T, Total As Integer

    Dim Cpercent, Apercent, Gpercent, Tpercent As Decimal
    Public Sub CalculationRepresentation(ByVal alltext As String)





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

        Total = C + A + G + T

        Cpercent = (C / Total) * 100
        Apercent = (A / Total) * 100
        Gpercent = (G / Total) * 100
        Tpercent = (T / Total) * 100



      

        PercentageCAGTForm.Show()


    End Sub
    
    Public Function GetTotal() As Integer
        Return Total


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

    Public Function GetCPer() As Integer
        Return Cpercent


    End Function
    Public Function GetAPer() As Integer
        Return Apercent


    End Function
    Public Function GetGPer() As Decimal
        Return Gpercent


    End Function
    Public Function GetPerT() As Decimal
        Return Tpercent


    End Function
    Private Sub PercentageCAGT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub






    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'PercentageCAGT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(316, 256)
        Me.Name = "PercentageCAGT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
