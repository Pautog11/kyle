Imports System.Data.SqlClient
Public Class registerform
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
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub registerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User_accDataSet7.audit_table' table. You can move, or remove it, as needed.
        Me.Audit_tableTableAdapter.Fill(Me.User_accDataSet7.audit_table)
        'TODO: This line of code loads data into the 'User_accDataSet4.staff_table' table. You can move, or remove it, as needed.
        Me.Staff_tableTableAdapter.Fill(Me.User_accDataSet4.staff_table)
        'TODO: This line of code loads data into the 'User_accDataSet2.service_table1' table. You can move, or remove it, as needed.
        Me.Service_table1TableAdapter.Fill(Me.User_accDataSet2.service_table1)
        'TODO: This line of code loads data into the 'User_accDataSet1.service_table' table. You can move, or remove it, as needed.
        Me.Service_tableTableAdapter.Fill(Me.User_accDataSet1.service_table)
        'TODO: This line of code loads data into the 'User_accDataSet.user_table1' table. You can move, or remove it, as needed.
        Me.User_table1TableAdapter.Fill(Me.User_accDataSet.user_table1)

    End Sub

    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        If txtboxsignupname.Text = Nothing Or txtboxsignupusername.Text = Nothing Or txtboxsignuppassword.Text = Nothing Then
            MessageBox.Show("Please enter empty details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        cstring()
        connec()
        Using cmd As New SqlCommand("SELECT COUNT(*) FROM user_table1 WHERE NAME = @name or USERNAME = @username or PASSWORD = @password", con)
            cmd.Parameters.AddWithValue("@name", txtboxsignupname.Text)
            cmd.Parameters.AddWithValue("@username", txtboxsignupusername.Text)
            cmd.Parameters.AddWithValue("@password", txtboxsignuppassword.Text)

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("its already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End Using
        Using create As New SqlCommand("INSERT INTO user_table1 VALUES (@name, @username, @password)", con)
            create.Parameters.AddWithValue("@name", txtboxsignupname.Text)
            create.Parameters.AddWithValue("@username", txtboxsignupusername.Text)
            create.Parameters.AddWithValue("@password", txtboxsignuppassword.Text)
            If create.ExecuteNonQuery Then
                MessageBox.Show("Account Created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtboxsignupname.Clear()
                txtboxsignupusername.Clear()
                txtboxsignuppassword.Clear()
            End If
            Me.User_table1TableAdapter.Fill(Me.User_accDataSet.user_table1)
        End Using
    End Sub

    Private Sub Guna2DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        With Guna2DataGridView1.CurrentRow.Cells
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                cstring()
                connec()
                cmd = New SqlCommand("Delete from user_table1 where ID = @id", con)
                cmd.Parameters.AddWithValue("@id", .Item(0).Value)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Delete Succesfully!")
            End If
            Me.User_table1TableAdapter.Fill(Me.User_accDataSet.user_table1)
        End With
    End Sub
    Public Shared Property SelectedRow As DataGridViewRow
    Private Sub servicetable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles servicetable.CellClick
        With servicetable.CurrentRow.Cells
            serviceform.txtboxid.Text = .Item(0).Value
            serviceform.txtboxservicename.Text = .Item(1).Value
            serviceform.txtboxserviceprice.Text = .Item(2).Value
        End With
        If e.RowIndex >= 0 Then

            SelectedRow = servicetable.Rows(e.RowIndex)
            serviceform.ident = 1
            serviceform.Show()

        End If
    End Sub

    Private Sub othertable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles othertable.CellClick
        With othertable.CurrentRow.Cells
            serviceform.txtboxid.Text = .Item(0).Value
            serviceform.txtboxservicename.Text = .Item(1).Value
            serviceform.txtboxserviceprice.Text = .Item(2).Value
        End With
        If e.RowIndex >= 0 Then

            SelectedRow = othertable.Rows(e.RowIndex)
            serviceform.ident = 2
            serviceform.Show()

        End If
    End Sub

    Private Sub estheticiantable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles estheticiantable.CellContentClick
        With estheticiantable.CurrentRow.Cells
            editstaff.txtboxid.Text = .Item(0).Value
            editstaff.txtboxstaffname.Text = .Item(1).Value
            editstaff.txtboxstaffln.Text = .Item(2).Value
        End With
        If e.RowIndex >= 0 Then

            SelectedRow = othertable.Rows(e.RowIndex)
            serviceform.ident = 2
            serviceform.Show()

        End If
    End Sub
End Class