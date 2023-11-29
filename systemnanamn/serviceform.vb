Imports System.Data.SqlClient
Public Class serviceform
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Public Property ident As String
    Public Sub cstring()
        con = New SqlConnection("Data Source=HAKDOG;Initial Catalog=user_acc;Integrated Security=True")
    End Sub
    Public Sub connec()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

    End Sub
    Private Sub serviceform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        registerform.Show()
    End Sub
    Public Shared Property SelectedRow As DataGridViewRow
    Private Sub serviceadd_Click(sender As Object, e As EventArgs) Handles serviceadd.Click
        cstring()
        connec()
        If ident = 1 Then
            cmd = New SqlCommand("Insert into service_table values (@st. @price)", con)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@st", txtboxservicename.Text)
            cmd.Parameters.AddWithValue("@price", txtboxserviceprice.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Added Succesfully")
            registerform.Service_tableTableAdapter.Fill(registerform.User_accDataSet1.service_table)
        Else
            cmd = New SqlCommand("Insert into service_table1 values (@st,@price)", con)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@st", txtboxservicename.Text)
            cmd.Parameters.AddWithValue("@price", txtboxserviceprice.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Added Succesfully")
            registerform.Service_tableTableAdapter.Fill(registerform.User_accDataSet1.service_table)
        End If

    End Sub

    Private Sub servicedelete_Click(sender As Object, e As EventArgs) Handles servicedelete.Click
        cstring()
        connec()
        If ident = 1 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                cmd = New SqlCommand("Delete from service_table where SERVICE_TYPE = @service", con)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@service", txtboxservicename.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Delete Succesfully!")
                registerform.Service_tableTableAdapter.Fill(registerform.User_accDataSet1.service_table)
            End If
        Else
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                cmd = New SqlCommand("Delete from service_table1 where SERVICE_TYPE = @service", con)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@service", txtboxservicename.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Delete Succesfully!")
                registerform.Service_table1TableAdapter.Fill(registerform.User_accDataSet2.service_table1)
            End If
        End If
        Me.Hide()

    End Sub

    Private Sub serviceupdate_Click(sender As Object, e As EventArgs) Handles serviceupdate.Click
        cstring()
        connec()
        If ident = 1 Then
            cmd = New SqlCommand("Update service_table set SERVICE_TYPE = @update, PRICE = @price where ID = @id", con)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@update", txtboxservicename.Text)
            cmd.Parameters.AddWithValue("@price", txtboxserviceprice.Text)
            cmd.Parameters.AddWithValue("@id", txtboxid.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update Succesfully!")

            registerform.Service_tableTableAdapter.Fill(registerform.User_accDataSet1.service_table)
        Else
            cmd = New SqlCommand("Update service_table1 set SERVICE_TYPE = @update, PRICE = @price where ID = @id", con)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@update", txtboxservicename.Text)
            cmd.Parameters.AddWithValue("@price", txtboxserviceprice.Text)
            cmd.Parameters.AddWithValue("@id", txtboxid.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update Succesfully!")

            registerform.Service_table1TableAdapter.Fill(registerform.User_accDataSet2.service_table1)

        End If
        audit("admin", "Update")
        Me.Hide()

    End Sub
End Class