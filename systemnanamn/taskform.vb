Imports System.Data.SqlClient
Public Class taskform
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
    Private Sub taskform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User_accDataSet6.customer_table1' table. You can move, or remove it, as needed.
        Me.Customer_table1TableAdapter.Fill(Me.User_accDataSet6.customer_table1)
        cstring()
        connec()
        Using cmd = New SqlCommand("Select ID, FIRST_NAME from staff_table", con)
            Dim adapter1 As New SqlDataAdapter(cmd)
            Dim dt1 As New DataTable
            adapter1.Fill(dt1)
            cmbnamefilter.DataSource = dt1
            cmbnamefilter.DisplayMember = "FIRST_NAME"
            cmbnamefilter.ValueMember = "ID"
            cmbnamefilter.StartIndex = 0
        End Using

        Dim todayy As DateTime = Date.Now.ToShortDateString
        Customer_table1TableAdapter.FillByDate(User_accDataSet6.customer_table1, todayy)

        'Using filter = New SqlCommand("SELECT * FROM customer_table1 WHERE ([DATE] LIKE '%" & todayy & "%')", con)
        '    Dim adapt As New SqlDataAdapter(filter)
        '    Dim dtable As New DataTable
        '    adapt.Fill(dtable)
        '    With Guna2DataGridView1
        '        .DataSource = dtable
        '        .AllowUserToAddRows = False
        '        .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Bold)
        '        .ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        '        .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        '        .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        .DefaultCellStyle.Font = New Font("Tahoma", 12)
        '    End With
        'End Using


    End Sub

    Private Sub cmbnamefilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbnamefilter.SelectedIndexChanged

        Me.Customer_table1TableAdapter.name1(Me.User_accDataSet6.customer_table1, cmbnamefilter.Text, Date.Now.ToShortDateString)

    End Sub
    Public Shared Property SelectedRow As DataGridViewRow
    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Dim y As MsgBoxResult = MsgBox("Proceed to payment", MsgBoxStyle.YesNo, "Payment")
        If y = MsgBoxResult.Yes Then
            With Guna2DataGridView1.CurrentRow.Cells
                paymentform.txtboxtotalpayment.Text = .Item(9).Value

            End With
            If e.RowIndex >= 0 Then

                SelectedRow = Guna2DataGridView1.Rows(e.RowIndex)
                Form2.switchpanel(paymentform)


            End If
        End If



    End Sub
End Class