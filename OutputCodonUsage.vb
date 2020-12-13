Public Class OutputCodonUsage
    Structure AmAcid

        Dim AmAcidName As String
        Dim AmAcidsArr() As String
        Dim AmAcidCount() As Integer
        Dim AmAcidFranctionOf() As Double

    End Structure
    Protected CodonSeqStr As String
    Protected AllAmenoAcids As New List(Of AmAcid)
    Protected ALA As New AmAcid
    Protected CYS As New AmAcid
    Protected ASP As New AmAcid
    Protected GLU As New AmAcid
    Protected PHE As New AmAcid
    Protected GLY As New AmAcid
    Protected HIS As New AmAcid
    Protected ILE As New AmAcid
    Protected LYS As New AmAcid
    Protected LEU As New AmAcid
    Protected MET As New AmAcid
    Protected ASN As New AmAcid
    Protected PRO As New AmAcid
    Protected GLN As New AmAcid
    Protected ARG As New AmAcid
    Protected SER As New AmAcid
    Protected THR As New AmAcid
    Protected VAL As New AmAcid
    Protected TRP As New AmAcid
    Protected TYR As New AmAcid
    Public Sub PassCodon(ByVal Codon As String)

        CodonSeqStr = Codon

        ALA.AmAcidsArr = {"GCG", "GCA", "GCT", "GCC"}
        ALA.AmAcidCount = {0, 0, 0, 0}
        ALA.AmAcidName = "ALA"
        ALA.AmAcidFranctionOf = {0, 0, 0, 0}
        AllAmenoAcids.Add(ALA)

        CYS.AmAcidsArr = {"TGT", "TGC"}
        CYS.AmAcidCount = {0, 0}
        CYS.AmAcidName = "CYS"
        CYS.AmAcidFranctionOf = {0, 0}
        AllAmenoAcids.Add(CYS)

        ASP.AmAcidsArr = {"GAT", "GAC"}
        ASP.AmAcidCount = {0, 0}
        ASP.AmAcidName = "ASP"
        ASP.AmAcidFranctionOf = {0, 0}
        AllAmenoAcids.Add(ASP)

        GLU.AmAcidsArr = {"GAG", "GAA"}
        GLU.AmAcidCount = {0, 0}
        GLU.AmAcidName = "GLU"
        GLU.AmAcidFranctionOf = {0, 0}
        AllAmenoAcids.Add(GLU)

        PHE.AmAcidsArr = {"TTT", "TTC"}
        PHE.AmAcidCount = {0, 0}
        PHE.AmAcidName = "PHE"
        PHE.AmAcidFranctionOf = {0, 0}
        AllAmenoAcids.Add(PHE)

        GLY.AmAcidsArr = {"GGG", "GGA", "GGT", "GGC"}
        GLY.AmAcidCount = {0, 0, 0, 0}
        GLY.AmAcidName = "GLY"
        GLY.AmAcidFranctionOf = {0, 0, 0, 0}
        AllAmenoAcids.Add(GLY)

        HIS.AmAcidsArr = {"CAT", "CAC"}
        HIS.AmAcidCount = {0, 0}
        HIS.AmAcidName = "HIS"
        HIS.AmAcidFranctionOf = {0, 0}
        AllAmenoAcids.Add(HIS)

        ILE.AmAcidsArr = {"ATA", "ATT", "ATC"}
        ILE.AmAcidCount = {0, 0, 0}
        ILE.AmAcidName = "ILE"
        ILE.AmAcidFranctionOf = {0, 0, 0}
        AllAmenoAcids.Add(ILE)

        LYS.AmAcidsArr = {"AAG", "AAA"}
        LYS.AmAcidCount = {0, 0}
        LYS.AmAcidName = "LYS"
        LYS.AmAcidFranctionOf = {0, 0}
        AllAmenoAcids.Add(LYS)

        LEU.AmAcidsArr = {"TTG", "TTA", "CTG", "CTA", "CTT", "CTC"}
        LEU.AmAcidCount = {0, 0, 0, 0, 0, 0}
        LEU.AmAcidName = "LEU"
        LEU.AmAcidFranctionOf = {0, 0, 0, 0, 0, 0}
        AllAmenoAcids.Add(LEU)

        MET.AmAcidsArr = {"ATG"}
        MET.AmAcidCount = {0}
        MET.AmAcidName = "MET"
        MET.AmAcidFranctionOf = {0}
        AllAmenoAcids.Add(MET)

        ASN.AmAcidsArr = {"AAT", "AAC"}
        ASN.AmAcidCount = {0, 0}
        ASN.AmAcidName = "ASN"
        ASN.AmAcidFranctionOf = {0, 0}
        AllAmenoAcids.Add(ASN)

        PRO.AmAcidsArr = {"CCG", "CCA", "CCT", "CCC"}
        PRO.AmAcidCount = {0, 0, 0, 0}
        PRO.AmAcidName = "PRO"
        PRO.AmAcidFranctionOf = {0, 0, 0, 0}
        AllAmenoAcids.Add(PRO)

        GLN.AmAcidsArr = {"CAG", "CAA"}
        GLN.AmAcidCount = {0, 0}
        GLN.AmAcidName = "GLN"
        GLN.AmAcidFranctionOf = {0, 0}
        AllAmenoAcids.Add(GLN)

        ARG.AmAcidsArr = {"AGA", "CGG", "CGA", "CGT", "CGC"}
        ARG.AmAcidCount = {0, 0, 0, 0, 0}
        ARG.AmAcidName = "ARG"
        ARG.AmAcidFranctionOf = {0, 0, 0, 0, 0}
        AllAmenoAcids.Add(ARG)

        SER.AmAcidsArr = {"AGT", "AGC", "TCG", "TCA", "TCT", "TCC"}
        SER.AmAcidCount = {0, 0, 0, 0, 0, 0}
        SER.AmAcidName = "SER"
        SER.AmAcidFranctionOf = {0, 0, 0, 0, 0, 0}
        AllAmenoAcids.Add(SER)

        THR.AmAcidsArr = {"ACG", "ACA", "ACT", "ACC"}
        THR.AmAcidCount = {0, 0, 0, 0}
        THR.AmAcidName = "THR"
        THR.AmAcidFranctionOf = {0, 0, 0, 0}
        AllAmenoAcids.Add(THR)

        VAL.AmAcidsArr = {"GTG", "GTA", "GTT", "GTC"}
        VAL.AmAcidCount = {0, 0, 0, 0}
        VAL.AmAcidName = "VAL"
        VAL.AmAcidFranctionOf = {0, 0, 0, 0}
        AllAmenoAcids.Add(VAL)

        TRP.AmAcidsArr = {"TGG"}
        TRP.AmAcidCount = {0}
        TRP.AmAcidName = "TRP"
        TRP.AmAcidFranctionOf = {0}
        AllAmenoAcids.Add(TRP)

        TYR.AmAcidsArr = {"TAT", "TAC"}
        TYR.AmAcidCount = {0, 0}
        TYR.AmAcidName = "TYR"
        TYR.AmAcidFranctionOf = {0, 0}
        AllAmenoAcids.Add(TYR)

        Me.Show()
        Output()

    End Sub

    Private Sub Output()

        Dim TempStr As String
        Dim TotalNo As Integer = 0




        For Each AmAcido In AllAmenoAcids 'Goes through each amino acid structure
            For outerlooper = 0 To AmAcido.AmAcidsArr.Length - 1 ' Looper between Amino Acid 
                For inlooper = 0 To CodonSeqStr.Length - 3
                    TempStr = CodonSeqStr(inlooper) + CodonSeqStr(inlooper + 1) + CodonSeqStr(inlooper + 2)
                    If TempStr = AmAcido.AmAcidsArr(outerlooper) Then
                        TotalNo += 1
                        AmAcido.AmAcidCount(outerlooper) += 1
                    End If
                    inlooper += 2
                Next
            Next
        Next







        For Each AmAcidNo In AllAmenoAcids
            For outlooper = 0 To AmAcidNo.AmAcidFranctionOf.Length - 1
                AmAcidNo.AmAcidFranctionOf(outlooper) = (AmAcidNo.AmAcidCount(outlooper) / TotalNo) * 100
            Next
        Next


        CodonPlotTextBox.Text += ControlChars.NewLine
        CodonPlotTextBox.Text += ("AmAcid" & "    " & "Codon" & "     " & "Number" & "     " & "Fraction")
        CodonPlotTextBox.Text += ControlChars.NewLine
        CodonPlotTextBox.Text += ControlChars.NewLine

        For Each AmCount In AllAmenoAcids


            For outerlooper = 0 To AmCount.AmAcidCount.Length - 1

                CodonPlotTextBox.Text += (AmCount.AmAcidName & "          " & AmCount.AmAcidsArr(outerlooper) & "         " & AmCount.AmAcidCount(outerlooper) & "                " & AmCount.AmAcidFranctionOf(outerlooper) & "%")
                CodonPlotTextBox.Text += ControlChars.NewLine

            Next

            CodonPlotTextBox.Text += ControlChars.NewLine
            CodonPlotTextBox.Text += ("")

        Next
        Dim NoInt As Integer = 0


        Me.CodonChart.Series.Clear()

        Me.CodonChart.Series.Add("Amino Acid")
        Me.CodonChart.ChartAreas("ChartArea1").AxisX.Interval = 1


        For Each AmAcidstr In AllAmenoAcids
            For inlooper = 0 To AmAcidstr.AmAcidFranctionOf.Length - 1
                NoInt += 1

                Me.CodonChart.Series("Amino Acid").Points.AddXY(AmAcidstr.AmAcidsArr(inlooper), AmAcidstr.AmAcidCount(inlooper))


            Next
        Next





    End Sub
End Class