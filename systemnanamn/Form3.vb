Public Class Form3
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        audit("admin", "logout")
        Form1.Show()
        Me.Hide()
        Form2.Hide()
    End Sub

    Private Sub btnusermanagement_Click(sender As Object, e As EventArgs) Handles btnusermanagement.Click
        registerform.Show()
        Form2.Hide()
        Me.Hide()
    End Sub
End Class