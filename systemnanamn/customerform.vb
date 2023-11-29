Imports System.Data.SqlClient
Public Class customerform
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
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dispose()
        Me.Hide()

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Using check As New SqlCommand("SELECT COUNT(*) FROM customer_table1 WHERE DATE = @date and START_TIME = @time and ESTHETICIANS = @staff", con)
            check.Parameters.AddWithValue("@date", datetimes.Text)
            check.Parameters.AddWithValue("@time", timestart.Text)
            check.Parameters.AddWithValue("@staff", cmbestheticians.Text)

            Dim count = Convert.ToInt32(check.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("its already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End Using
        cstring()
        connec()
        cmd = New SqlCommand("Insert into customer_table1  values (@name, @service, @type , @date, @start, @end, @esthetician, @contact, @price)", con)
        cmd.Connection = con
        cmd.Parameters.AddWithValue("@name", txtboxcname.Text)
        cmd.Parameters.AddWithValue("@service", cmbservice.Text)
        cmd.Parameters.AddWithValue("@type", cmbtype.Text)
        cmd.Parameters.AddWithValue("@date", datetimes.Text)
        cmd.Parameters.AddWithValue("@start", timestart.Text)
        cmd.Parameters.AddWithValue("@end", timeend.Text)
        cmd.Parameters.AddWithValue("@esthetician", cmbestheticians.Text)
        cmd.Parameters.AddWithValue("@contact", txtboxnumber.Text)
        cmd.Parameters.AddWithValue("@price", txtprice.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Added succesfully", MsgBoxStyle.OkOnly, "Customer")
        bookingform.RemoveTestData(bookingform)
        bookingform.CreateTestData()
        'bookingform.Timer2.Enabled = True
        'bookingform.Timer2.Start()
        Dim datestr As String = DateTime.Parse(timestart.Text).Subtract(New TimeSpan(0, 5, 0)).ToString("h:mm:ss tt")
        bookingform.listoftimes.Add(datestr)
        allformvb.Customer_table1TableAdapter.Fill(allformvb.User_accDataSet5.customer_table1)
        audit("admin", "Add")
        Dispose()
    End Sub
    '
    Private Sub customerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetimes.Value = DateTime.Now
        cstring()
        connec()
        cmd = New SqlCommand("Select * from staff_table", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        adapter.Fill(dt)
        cmbestheticians.DataSource = dt
        cmbestheticians.DisplayMember = "FIRST_NAME"
        cmbestheticians.ValueMember = "ID"
        cmbestheticians.StartIndex = -1

    End Sub

    Private Sub cmbservice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbservice.SelectedIndexChanged
        If cmbservice.Text = "Eyelash Extension" Then
            cstring()
            connec()
            cmd = New SqlCommand("Select * from service_table", con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adapter.Fill(dt)
            cmbtype.DataSource = dt
            cmbtype.DisplayMember = "SERVICE_TYPE"
            cmbtype.ValueMember = "ID"
            cmbtype.StartIndex = -1
            ident = 1

        ElseIf cmbservice.Text = "Other Services" Then
            cstring()
            connec()
            cmd = New SqlCommand("Select * from service_table1", con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adapter.Fill(dt)
            cmbtype.DataSource = dt
            cmbtype.DisplayMember = "SERVICE_TYPE"
            cmbtype.ValueMember = "ID"
            cmbtype.StartIndex = -1
            ident = 2
        End If
    End Sub

    Private Sub cmbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtype.SelectedIndexChanged
        If ident = 1 Then
            cstring()
            connec()
            cmd = New SqlCommand("Select * from service_table where SERVICE_TYPE like '%" & cmbtype.Text & "%' ", con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adapter.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtprice.Text = dt.Rows(0).Item("PRICE").ToString
            End If

        ElseIf ident = 2 Then
            cstring()
            connec()
            cmd = New SqlCommand("Select * from service_table1 where SERVICE_TYPE like '%" & cmbtype.Text & "%'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adapter.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtprice.Text = dt.Rows(0).Item("PRICE").ToString
            End If


        End If

    End Sub

    Private Sub btnaddon_Click(sender As Object, e As EventArgs)
        addonform.Show()
    End Sub
End Class