Imports System.Math
Public Class PCRPrimerStatsForm

    Private Sub PCRPrimerStatsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        PCRPrimerLabel.Text = "PCR Primer Stats accepts a single PCR primer sequences and returns a report describing the properties of the submited primer, including melting temperature, percent GC content"
        Button1.Name = "CalculateButton"
        Button1.Text = "Calculate"
        ReverseComplementLabel.Text = "Reverse Complement Strand(5' to 3')"
        PhysicalConstantsLabel.Text = "Physical Constants"
        MeltingTempLabel.Text = "Melting Temperature (TM) Calculations"
        BasicLabel.Text = "°C (Basic)"
  
    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim PCRPrimer As String
        Dim reversePCRPrimer As String
        Dim RevereseComplement As String = ""
        Dim NumA As Integer
        Dim NumC As Integer
        Dim NumG As Integer
        Dim NumT As Integer




        PCRPrimer = PCRPrimerRichTextBox.Text

        reversePCRPrimer = StrReverse(PCRPrimer)

        For looper = 0 To reversePCRPrimer.Length - 1
            If reversePCRPrimer(looper) = "A" Then
                RevereseComplement += "T"
            ElseIf reversePCRPrimer(looper) = "T" Then
                RevereseComplement += "A"
            ElseIf reversePCRPrimer(looper) = "G" Then
                RevereseComplement += "C"
            ElseIf reversePCRPrimer(looper) = "C" Then
                RevereseComplement += "G"
            End If
        Next

        ReverseComplementTextBox.Text = RevereseComplement

        LengthTextBox.Text = RevereseComplement.Length.ToString

        For looper = 0 To RevereseComplement.Length - 1
            If RevereseComplement(looper) = "A" Then
                NumA += 1
            ElseIf RevereseComplement(looper) = "C" Then
                NumC += 1
            ElseIf RevereseComplement(looper) = "G" Then
                NumG += 1
            ElseIf RevereseComplement(looper) = "T" Then
                NumT += 1
            End If
        Next



        MolecularWeightTextBox.Text = (NumA * 313.21) + (NumT * 304.2) + (NumC * 289.18) + (NumG * 329.21) - 61.96 + 79.0

        GCContentTextBox.Text = Round((((NumG + NumC) / (NumC + NumA + NumG + NumT)) * 100), 1)




        If RevereseComplement.Length >= 13 Then
            BasicTempTextBox.Text = 64.9 + 41 * ((NumG + NumC) - 16.4) / (NumA + NumC + NumG + NumT)
        ElseIf RevereseComplement.Length < 13 Then
            BasicTempTextBox.Text = ((NumA + NumT) * 2) + (NumG + NumC) * 4
        End If


     


    End Sub



End Class