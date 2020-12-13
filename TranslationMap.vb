Public Class TranslationMap

    Structure Proteins

        Dim PrtnName As String
        Dim ProteinArr() As String

    End Structure
    Protected CodonSeq As String
    Protected AllProteins As New List(Of Proteins)

    Protected DNAseq As String
    Dim Prtn1 As String = ""
    Dim Prtn2 As String = ""
    Dim Prtn3 As String = ""
    Protected F As New Proteins
    Protected L As New Proteins
    Protected S As New Proteins
    Protected Y As New Proteins
    Protected STAR As New Proteins
    Protected C As New Proteins
    Protected STAR2 As New Proteins
    Protected W As New Proteins
    Protected L2 As New Proteins
    Protected P As New Proteins
    Protected H As New Proteins
    Protected Q As New Proteins
    Protected R As New Proteins
    Protected I As New Proteins
    Protected M As New Proteins
    Protected T As New Proteins
    Protected N As New Proteins
    Protected K As New Proteins
    Protected S2 As New Proteins
    Protected R2 As New Proteins
    Protected V As New Proteins
    Protected A As New Proteins
    Protected D As New Proteins
    Protected E As New Proteins
    Protected G As New Proteins


    Public Sub SettingVariables()



        F.ProteinArr = {"TTT", "TTC"}
        F.PrtnName = "F"
        AllProteins.Add(F)

        L.ProteinArr = {"TTA", "TTG"}
        L.PrtnName = "L"
        AllProteins.Add(L)

        S.ProteinArr = {"TCT", "TCC", "TCA", "TCG"}
        S.PrtnName = "S"
        AllProteins.Add(S)

        Y.ProteinArr = {"TAT", "TAC"}
        Y.PrtnName = "Y"
        AllProteins.Add(Y)

        STAR.ProteinArr = {"TAA", "TAG"}
        STAR.PrtnName = "*"
        AllProteins.Add(STAR)

        C.ProteinArr = {"TGT", "TGC"}
        C.PrtnName = "C"
        AllProteins.Add(C)

        STAR2.ProteinArr = {"TGA"}
        STAR2.PrtnName = "*"
        AllProteins.Add(STAR2)

        W.ProteinArr = {"TGG"}
        W.PrtnName = "W"
        AllProteins.Add(W)

        L2.ProteinArr = {"CTT", "CTC", "CTA", "CTG"}
        L2.PrtnName = "L"
        AllProteins.Add(L2)

        P.ProteinArr = {"CCT", "CCC", "CCA", "CCG"}
        P.PrtnName = "P"
        AllProteins.Add(P)

        H.ProteinArr = {"CAT", "CAC"}
        H.PrtnName = "H"
        AllProteins.Add(H)

        Q.ProteinArr = {"CAA", "CAG"}
        Q.PrtnName = "Q"
        AllProteins.Add(Q)

        R.ProteinArr = {"CGT", "CGC", "CGA", "CGG"}
        R.PrtnName = "R"
        AllProteins.Add(R)

        I.ProteinArr = {"ATT", "ATC", "ATA"}
        I.PrtnName = "I"
        AllProteins.Add(I)

        M.ProteinArr = {"ATG"}
        M.PrtnName = "M"
        AllProteins.Add(M)

        T.ProteinArr = {"ACT", "ACC", "ACA", "ACG"}
        T.PrtnName = "T"
        AllProteins.Add(T)

        N.ProteinArr = {"AAT", "AAC"}
        N.PrtnName = "N"
        AllProteins.Add(N)

        K.ProteinArr = {"AAA", "AAG"}
        K.PrtnName = "K"
        AllProteins.Add(K)

        S2.ProteinArr = {"AGT", "AGC"}
        S2.PrtnName = "S"
        AllProteins.Add(S2)

        R2.ProteinArr = {"AGA", "AGG"}
        R2.PrtnName = "R"
        AllProteins.Add(R2)

        V.ProteinArr = {"GTT", "GTC", "GTA", "GTG"}
        V.PrtnName = "V"
        AllProteins.Add(V)

        A.ProteinArr = {"GCT", "GCC", "GCA", "GCG"}
        A.PrtnName = "A"
        AllProteins.Add(A)

        D.ProteinArr = {"GAT", "GAC"}
        D.PrtnName = "D"
        AllProteins.Add(D)

        E.ProteinArr = {"GAA", "GAG"}
        E.PrtnName = "E"
        AllProteins.Add(E)

        G.ProteinArr = {"GGT", "GGC", "GGA", "GGG"}
        G.PrtnName = "G"
        AllProteins.Add(G)

    End Sub


    Private Sub TranslationMap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SettingVariables()
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click


        If DNAOrderComboBox.Text.Length > 0 Then
            DNAseq = DNATextBox.Text
            If DNAOrderComboBox.Text = "Reverse" Then
                DNAseq = StrReverse(DNAseq)
            ElseIf DNAOrderComboBox.Text = "Complement" Then
                DNAseq = ""
                For looper = 0 To DNATextBox.Text.Length - 1
                    If DNATextBox.Text(looper) = "A" Then
                        DNAseq += "T"
                    ElseIf DNATextBox.Text(looper) = "T" Then
                        DNAseq += "A"
                    ElseIf DNATextBox.Text(looper) = "G" Then
                        DNAseq += "C"
                    ElseIf DNATextBox.Text(looper) = "C" Then
                        DNAseq += "G"
                    End If
                Next
            ElseIf DNAOrderComboBox.Text = "Reverse Complement" Then
                DNATextBox.Text = StrReverse(DNATextBox.Text)
                DNAseq = ""
                For looper = 0 To DNATextBox.Text.Length - 1
                    If DNATextBox.Text(looper) = "A" Then
                        DNAseq += "T"
                    ElseIf DNATextBox.Text(looper) = "T" Then
                        DNAseq += "A"
                    ElseIf DNATextBox.Text(looper) = "G" Then
                        DNAseq += "C"
                    ElseIf DNATextBox.Text(looper) = "C" Then
                        DNAseq += "G"
                    End If
                Next
            End If




            EditedDNATextBox.Text += DNAseq





            If DNATextBox.Text.Length >= 3 And ReadingFrameComboBox.Text.Length > 0 Then
                Prtn1 = ""
                Prtn2 = ""
                Prtn3 = ""


                SubmitButton.Enabled = False
                If ReadingFrameComboBox.Text = "Reading Frame 1" Then
                    OutputTranslationMap1()
                    TextBox1.Text = ""
                    OutputFinalRF1()
                ElseIf ReadingFrameComboBox.Text = "Reading Frame 2" Then
                    OutputTranslationMap2()
                    TextBox1.Text = ""
                    OutputFinalRF2()
                ElseIf ReadingFrameComboBox.Text = "Reading Frame 3" Then
                    OutputTranslationMap3()
                    TextBox1.Text = ""
                    OutoutFinalRF3()

                ElseIf ReadingFrameComboBox.Text = "Reading Frame 1, 2 & 3" Then
                    OutputTranslationMap1()
                    OutputTranslationMap2()
                    OutputTranslationMap3()
                    TextBox1.Text = ""
                    OutputFinalRF123()

                End If
            Else
                MsgBox("You must have a DNA sequence greater or equal to 3 and select a reading frame")

            End If
        End If
    End Sub
    Protected Sub OutputTranslationMap1()
        Dim temp As String

        For looper = 0 To DNAseq.Length - 3
            temp = DNAseq(looper) + DNAseq(looper + 1) + DNAseq(looper + 2)
            For Each prtn In AllProteins
                For inlooper = 0 To prtn.ProteinArr.Length - 1
                    If temp = prtn.ProteinArr(inlooper) Then
                        Prtn1 += prtn.PrtnName
                        looper += 2
                    End If
                Next
            Next
        Next

      
    End Sub
    Protected Sub OutputTranslationMap2()
        Dim temp As String

        For looper = 1 To DNAseq.Length - 3
            temp = DNAseq(looper) + DNAseq(looper + 1) + DNAseq(looper + 2)
            For Each prtn In AllProteins
                For inlooper = 0 To prtn.ProteinArr.Length - 1
                    If temp = prtn.ProteinArr(inlooper) Then
                        Prtn2 += prtn.PrtnName
                        looper += 2
                    End If
                Next
            Next

        Next
 

    End Sub
    Protected Sub OutputTranslationMap3()

        Dim temp As String


        For looper = 2 To DNAseq.Length - 3
            temp = DNAseq(looper) + DNAseq(looper + 1) + DNAseq(looper + 2)
            For Each prtn In AllProteins
                For inlooper = 0 To prtn.ProteinArr.Length - 1
                    If temp = prtn.ProteinArr(inlooper) Then
                        Prtn3 += prtn.PrtnName
                        looper += 2
                    End If
                Next
            Next

        Next
      
    End Sub
    Protected Sub OutputFinalRF1()


        For looper = 0 To Prtn1.Length - 1

            TextBox1.Text += Prtn1(looper)
            TextBox1.Text += "     "
            TextBox1.Update()
            Threading.Thread.Sleep(1000)

        Next
        TextBox1.Text += ControlChars.NewLine
        TextBox1.Text += DNAseq
        SubmitButton.Enabled = True



    End Sub
    Protected Sub OutputFinalRF2()
        TextBox1.Text += "   "
        For looper = 0 To Prtn2.Length - 1

            TextBox1.Text += Prtn2(looper)
            TextBox1.Text += "      "
            TextBox1.Update()
            Threading.Thread.Sleep(1000)

        Next
        TextBox1.Text += ControlChars.NewLine
        TextBox1.Text += DNAseq
        SubmitButton.Enabled = True


    End Sub
    Protected Sub OutoutFinalRF3()
        TextBox1.Text += "     "
        For looper = 0 To Prtn3.Length - 1

            TextBox1.Text += Prtn3(looper)
            TextBox1.Text += "     "
            TextBox1.Update()

            Threading.Thread.Sleep(1000)


        Next
        TextBox1.Text += ControlChars.NewLine
        TextBox1.Text += DNAseq
        SubmitButton.Enabled = True


    End Sub

    Protected Sub OutputFinalRF123()

        TextBox1.Text += "      "
        For looper = 0 To Prtn3.Length - 1

            TextBox1.Text += Prtn3(looper)
            TextBox1.Text += "        "
            TextBox1.Update()
            Threading.Thread.Sleep(1000)

        Next

        TextBox1.Text += ControlChars.NewLine
        TextBox1.Text += "    "
        For looper = 0 To Prtn2.Length - 1

            TextBox1.Text += Prtn2(looper)
            TextBox1.Text += "        "
            TextBox1.Update()
            Threading.Thread.Sleep(1000)


        Next

        TextBox1.Text += ControlChars.NewLine

        For looper = 0 To Prtn1.Length - 1

            TextBox1.Text += Prtn1(looper)
            TextBox1.Text += "       "
            TextBox1.Update()
            Threading.Thread.Sleep(1000)


        Next

        TextBox1.Text += ControlChars.NewLine
        For looper = 0 To DNAseq.Length - 1
            TextBox1.Text += DNAseq(looper)
            TextBox1.Text += " "
            TextBox1.Update()
            Threading.Thread.Sleep(1000)

        Next

        SubmitButton.Enabled = True






    End Sub

End Class