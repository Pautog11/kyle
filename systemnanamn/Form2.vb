Imports System.Data.SqlClient
Public Class Form2
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Public id As Integer = Nothing
    Public Sub cstring()
        con = New SqlConnection("Data Source=HAKDOG;Initial Catalog=user_acc;Integrated Security=True")
    End Sub
    Public Sub connec()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Private Sub btnsetting_Click(sender As Object, e As EventArgs) Handles btnsetting.Click
        Form3.Show()

    End Sub

    Private Sub btnsetting_Leave(sender As Object, e As EventArgs) Handles btnsetting.Leave
        Form3.Hide()
    End Sub
    Public Sub switchpanel(ByVal panel As Form)
        'para ishow yung form sa panel
        mainpanel.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        mainpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub mainpanel_Paint(sender As Object, e As PaintEventArgs) Handles mainpanel.Paint
        switchpanel(bookingform)
    End Sub

    Private Sub btnbooking_Click_1(sender As Object, e As EventArgs) Handles btnbooking.Click
        switchpanel(bookingform)
    End Sub

    Private Sub btnreports_Click(sender As Object, e As EventArgs) Handles btnreports.Click

    End Sub

    Private Sub btntask_Click_1(sender As Object, e As EventArgs) Handles btntask.Click
        switchpanel(taskform)
    End Sub
End Class