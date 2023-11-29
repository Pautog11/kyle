Public Class signup
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub txtboxsignuppassword_IconRightClick(sender As Object, e As EventArgs) Handles txtboxsignuppassword.IconRightClick
        'If txtboxsignuppassword.PasswordChar = "●" Then
        '    txtboxsignuppassword.PasswordChar = ""
        'Else
        '    txtboxsignuppassword.PasswordChar = "●"
        'End If
    End Sub
End Class