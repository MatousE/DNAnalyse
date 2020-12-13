Public Class SitesOutput
    Protected SitesOutputTxtBox As New RichTextBox
    Public Sub CpGSites(ByVal SEQ As String)
        SitesOutputTxtBox.Name = "DNAOutputTxtBox"
        SitesOutputTxtBox.Bounds = New Rectangle(Me.Location, New Size(500, 500))
        SitesOutputTxtBox.Multiline = True
        SitesOutputTxtBox.Location = New Point(10, 60)

        Me.Controls.Add(SitesOutputTxtBox)

        Me.Show()


        Dim tempstr As String

        SitesOutputTxtBox.Text += SEQ

        For looper = 0 To SEQ.Length - 2
            tempstr = SEQ(looper) + SEQ(looper + 1)
            If tempstr = "CG" Then
                SitesOutputTxtBox.Select(looper, 2)
                SitesOutputTxtBox.SelectionBackColor = Color.Green
            End If


        Next

    End Sub
    Public Sub GpCSites(ByVal SEQ As String)
        SitesOutputTxtBox.Name = "DNAOutputTxtBox"
        SitesOutputTxtBox.Bounds = New Rectangle(Me.Location, New Size(500, 500))
        SitesOutputTxtBox.Multiline = True
        SitesOutputTxtBox.Location = New Point(10, 60)

        Me.Controls.Add(SitesOutputTxtBox)
        Me.Show()

        Dim tempstr As String

        SitesOutputTxtBox.Text += SEQ

        For looper = 0 To SEQ.Length - 2
            tempstr = SEQ(looper) + SEQ(looper + 1)
            If tempstr = "GC" Then
                SitesOutputTxtBox.Select(looper, 2)
                SitesOutputTxtBox.SelectionBackColor = Color.Red
            End If


        Next

    End Sub
    Public Sub Both(ByVal SEQ As String)
        SitesOutputTxtBox.Name = "DNAOutputTxtBox"
        SitesOutputTxtBox.Bounds = New Rectangle(Me.Location, New Size(500, 500))
        SitesOutputTxtBox.Multiline = True
        SitesOutputTxtBox.Location = New Point(10, 60)

        Me.Controls.Add(SitesOutputTxtBox)
        Me.Show()

        Dim tempstr As String

        SitesOutputTxtBox.Text += SEQ

        For looper = 0 To SEQ.Length - 2
            tempstr = SEQ(looper) + SEQ(looper + 1)
            If tempstr = "GC" Then
                SitesOutputTxtBox.Select(looper, 2)
                SitesOutputTxtBox.SelectionBackColor = Color.Red
            End If


        Next
        For looper = 0 To SEQ.Length - 2
            tempstr = SEQ(looper) + SEQ(looper + 1)
            If tempstr = "CG" Then
                SitesOutputTxtBox.Select(looper, 2)
                SitesOutputTxtBox.SelectionBackColor = Color.Green
            End If


        Next



    End Sub

End Class