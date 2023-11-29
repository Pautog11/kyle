Public Class allformvb
    Private Sub allformvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User_accDataSet5.customer_table1' table. You can move, or remove it, as needed.
        Me.Customer_table1TableAdapter.Fill(Me.User_accDataSet5.customer_table1)

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
    End Sub
    Public Shared Property SelectedRow As DataGridViewRow
    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        With Guna2DataGridView1.CurrentRow.Cells
            serviceform.txtboxid.Text = .Item(0).Value
            editform.txtbox1.Text = .Item(1).Value
            editform.txtbox2.Text = .Item(2).Value
            editform.txtbox3.Text = .Item(3).Value
            editform.txtbox4.Text = .Item(4).Value
            editform.txtbox5.Text = .Item(5).Value
            editform.txtbox6.Text = .Item(6).Value
            editform.txtbox7.Text = .Item(7).Value
            editform.txtbox8.Text = .Item(8).Value
        End With
        If e.RowIndex >= 0 Then

            SelectedRow = Guna2DataGridView1.Rows(e.RowIndex)
            editform.Show()
        End If
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class