Public Class CpGIslandForm
    Protected GetDNATxtBox As New RichTextBox
    Private Sub CpGIslandForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GetDNATxtBox.Name = "DNAOutputTxtBox"
        GetDNATxtBox.Bounds = New Rectangle(Me.Location, New Size(400, 100))
        GetDNATxtBox.Multiline = True
        GetDNATxtBox.Location = New Point(10, 60)

        Me.Controls.Add(GetDNATxtBox)

    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click

        If GetDNATxtBox.Text.Length >= 200 Then



            If ComboBoxSites.Text = "Show CpG Sites " Then
                SitesOutput.CpGSites(GetDNATxtBox.Text)
            ElseIf ComboBoxSites.Text = "Show GpC Sites" Then
                SitesOutput.GpCSites(GetDNATxtBox.Text)
            ElseIf ComboBoxSites.Text = "CpG Islands" Then
                OutputCpGIslands.GetDNASeq(GetDNATxtBox.Text)
            ElseIf ComboBoxSites.Text = "CpG and GcP Sites" Then
                SitesOutput.Both(GetDNATxtBox.Text)
            End If


        Else
            MsgBox("Must be greater than 200")

        End If



    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        GetDNATxtBox.Text = ""

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSites.SelectedIndexChanged

    End Sub
End Class