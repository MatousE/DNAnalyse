Public Class REKeyboard


    Private Sub ButtonA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonA.Click
        RegExpressionTextBox.Text += "A"
    End Sub

    Private Sub CButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CButton.Click
        RegExpressionTextBox.Text += "C"
    End Sub

    Private Sub GButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GButton.Click
        RegExpressionTextBox.Text += "G"
    End Sub

    Private Sub TButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TButton.Click
        RegExpressionTextBox.Text += "T"
    End Sub

    Private Sub PlusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlusButton.Click
        RegExpressionTextBox.Text += "+"
    End Sub

    Private Sub ExlemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExlemButton.Click
        RegExpressionTextBox.Text += "!"
    End Sub

    Private Sub AstrixButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AstrixButton.Click
        RegExpressionTextBox.Text += "*"
    End Sub

    Private Sub ToPowerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToPowerButton.Click
        RegExpressionTextBox.Text += "^"
    End Sub

    Private Sub LineButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineButton.Click
        RegExpressionTextBox.Text += "|"
    End Sub

    Private Sub SlashButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlashButton.Click
        RegExpressionTextBox.Text += "\"
    End Sub

    Private Sub DlrButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DlrButton.Click
        RegExpressionTextBox.Text += "$"
    End Sub

    Private Sub LftBracketButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LftBracketButton.Click
        RegExpressionTextBox.Text += "("
    End Sub

    Private Sub RghtBracketButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RghtBracketButton.Click
        RegExpressionTextBox.Text += ")"
    End Sub

    Private Sub LCrlyBracketButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LCrlyBracketButton.Click
        RegExpressionTextBox.Text += "{"
    End Sub

    Private Sub RCrlyBracketButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RCrlyBracketButton.Click
        RegExpressionTextBox.Text += "}"
    End Sub

    Private Sub LSqrBracketButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSqrBracketButton.Click
        RegExpressionTextBox.Text += "["
    End Sub

    Private Sub RSqrBracketButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RSqrBracketButton.Click
        RegExpressionTextBox.Text += "]"
    End Sub

    Private Sub EnterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterButton.Click

        RegularExpressionClass.GetRegularExpression(RegExpressionTextBox.Text)


    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click

        If RegExpressionTextBox.Text.Length >= 1 Then
            RegExpressionTextBox.Text = RegExpressionTextBox.Text.Substring(0, RegExpressionTextBox.Text.Length - 1)
        End If


    End Sub
End Class