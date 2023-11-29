Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Public Sub cstring()
        con = New SqlConnection("Data Source=HAKDOG;Initial Catalog=user_acc;Integrated Security=True")
    End Sub
    Public Sub connec()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnenter_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtboxloginusername.Text = Nothing Or txtboxloginpassword.Text = Nothing Then
            MessageBox.Show("Please enter your Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        cstring()
        connec()
        Using cmd As New SqlCommand("SELECT COUNT(*) FROM user_table1 WHERE USERNAME = @username and PASSWORD = @password", con)
            cmd.Parameters.AddWithValue("@username", txtboxloginusername.Text)
            cmd.Parameters.AddWithValue("@password", txtboxloginpassword.Text)

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                Me.Hide()
                Form2.Show()
                txtboxloginusername.Clear()
                txtboxloginpassword.Clear()
            Else
                MessageBox.Show("Incorrect Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtboxloginusername.Clear()
                txtboxloginpassword.Clear()
            End If
        End Using
        audit("admin", "Login")

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        signup.Show()
        Me.Hide()
    End Sub

    Private Sub txtboxloginpassword_IconRightClick(sender As Object, e As EventArgs) Handles txtboxloginpassword.IconRightClick
        'para sa show password
        If txtboxloginpassword.PasswordChar = "●" Then
            txtboxloginpassword.PasswordChar = ""
        Else
            txtboxloginpassword.PasswordChar = "●"
        End If
    End Sub


End Class
