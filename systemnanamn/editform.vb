Imports System.Data.SqlClient
Public Class editform

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
    Private Sub btnback_Click_1(sender As Object, e As EventArgs) Handles btnback.Click
        allformvb.Show()
        Me.Hide()
    End Sub

    Private Sub customerdelete_Click(sender As Object, e As EventArgs) Handles customerdelete.Click
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            cstring()
            connec()
            cmd = New SqlCommand("Delete from customer_table1 where NAME = @name", con)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@name", txtbox1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Delete Succesfully!")
            allformvb.Customer_table1TableAdapter.Fill(allformvb.User_accDataSet5.customer_table1)
            'bookingform.RemoveTestData(bookingform)
            audit("admin", "Delete")
            Me.Hide()
        End If
    End Sub

    Private Sub editbutton_Click(sender As Object, e As EventArgs) Handles editbutton.Click

    End Sub
End Class