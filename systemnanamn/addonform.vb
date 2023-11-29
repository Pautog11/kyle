Imports System.Data.SqlClient
Public Class addonform
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
    Private Sub serviceaddon_Click(sender As Object, e As EventArgs) Handles serviceaddon.Click
        Dim sum As Decimal
        sum = Val(customerform.txtprice.Text) + Val(txtboxaddonprice.Text)
        customerform.txtprice.Text = sum
        Me.Hide()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        customerform.Show()
        Me.Hide()
    End Sub

    Private Sub addonform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cstring()
        connec()
        cmd = New SqlCommand("Select * from service_table1", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        adapter.Fill(dt)
        cmbaddontype.DataSource = dt
        cmbaddontype.DisplayMember = "SERVICE_TYPE"
        cmbaddontype.ValueMember = "ID"
        cmbaddontype.StartIndex = -1
    End Sub

    Private Sub cmbaddontype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbaddontype.SelectedIndexChanged
        cstring()
        connec()
        cmd = New SqlCommand("Select * from service_table1 where SERVICE_TYPE like '%" & cmbaddontype.Text & "%'", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.Rows.Count > 0 Then
            txtboxaddonprice.Text = dt.Rows(0).Item("PRICE").ToString
        End If

    End Sub
End Class