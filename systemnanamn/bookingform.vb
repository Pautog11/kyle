Imports System.Data.SqlClient
Public Class bookingform
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim currenttime As String
    Dim msgtime As String

    Public Property listoftimes As New List(Of String)
    Public Sub cstring()
        con = New SqlConnection("Data Source=HAKDOG;Initial Catalog=user_acc;Integrated Security=True")
    End Sub
    Public Sub connec()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

    End Sub

    Private calendarinfo As MonthcalendarInfo

    Private Sub bookingform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateMonth()
        SizeMonth()
        CreateWeek()
        SizeWeek()
        Createday()
        sizeday()
        calendarinfo = New MonthcalendarInfo(2023, 11)
        pCalendar()
        CreateTestData()


        ' ADD ALL THE DATES AND TIMES IN THE LIST OF TIMES
        cstring()
        connec()
        Dim curr As Date = Date.Now
        Using cmd = New SqlCommand("Select [DATE], START_TIME from customer_table1", con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dataSetTable As New DataSet
            adapter.Fill(dataSetTable)
            Dim table = dataSetTable.Tables(0)
            Dim dbdate As Date
            Dim dbtime As DateTime
            If table.Rows.Count > 0 Then
                For c = 0 To table.Rows.Count - 1
                    Dim datestr As String() = table.Rows.Item(c).Item("DATE").ToString.Split("/")
                    'MsgBox(table.Rows.Item(c).Item("DATE"))
                    dbdate = New Date(datestr(2), datestr(0), datestr(1))

                    If curr.ToShortDateString = dbdate.ToShortDateString Then
                        dbtime = DateTime.Parse(table.Rows.Item(c).Item("START_TIME")).Subtract(New TimeSpan(0, 5, 0)).ToString("hh:mm tt")

                        listoftimes.Add(dbtime)
                    End If
                Next
            End If
        End Using
    End Sub
    Private Sub CreateMonth()
        Dim lbl As Label = New Label()
        lbl.Name = "LblMonthYear"
        lbl.Font = New Font("Segoe UI", 24, FontStyle.Regular)
        lbl.ForeColor = Color.FromArgb(7, 19, 48)
        lbl.AutoSize = True
        lbl.Text = "Month Year"
        monthcontainer.Controls.Add(lbl)
    End Sub
    Private Sub SizeMonth()
        Dim x As Integer
        Dim y As Integer
        Dim lbl As Label

        If monthcontainer.Controls.Count > 0 Then

            lbl = monthcontainer.Controls.Find("LblMonthYear", False).First
            x = (monthcontainer.Width - lbl.Width) / 2
            y = (monthcontainer.Height - lbl.Height) / 2
            lbl.Location = New Point(x, y)
        End If

    End Sub
    Private Sub CreateWeek()
        Dim lbl As Label
        Dim days As String() = New String(6) {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}
        For i = 0 To 6
            lbl = New Label
            lbl.Name = String.Format("Lbl{0}", days(i))
            lbl.Text = days(i)
            lbl.AutoSize = False
            lbl.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            lbl.TextAlign = ContentAlignment.MiddleCenter
            weekcontainer.Controls.Add(lbl)
        Next
    End Sub
    Private Sub SizeWeek()
        SizeWidthEqually(weekcontainer)
    End Sub
    Private Sub SizeWidthEqually(ByVal c As Control)
        Dim width As Integer
        Dim x As Integer

        If c.Controls.Count = 0 Then
            Return
        End If

        width = c.Width / c.Controls.Count

        For Each ctrl As Control In c.Controls
            ctrl.Height = c.Height
            ctrl.Width = width
            ctrl.Location = New Point(x, 0)
            x += width
        Next
    End Sub

    Private Sub Createday()
        Dim dayPanel As Panel
        Dim dayOfMonthLbl As Label
        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                dayPanel = New Panel
                dayPanel.Name = String.Format("PnlDay{0}{1}", rowIndex, colIndex)
                dayOfMonthLbl = New Label
                dayOfMonthLbl.Name = String.Format("LblDayOfMonth{0}{1}", rowIndex, colIndex)
                dayOfMonthLbl.Text = dayOfMonthLbl.Name
                dayPanel.Controls.Add(dayOfMonthLbl)

                Select Case rowIndex
                    Case 0
                        daycontainerrow1.Controls.Add(dayPanel)
                    Case 1
                        daycontainerrow2.Controls.Add(dayPanel)
                    Case 2
                        daycontainerrow3.Controls.Add(dayPanel)
                    Case 3
                        daycontainerrow4.Controls.Add(dayPanel)
                    Case 4
                        daycontainerrow5.Controls.Add(dayPanel)
                    Case 5
                        daycontainerrow6.Controls.Add(dayPanel)
                End Select
            Next
        Next
    End Sub
    Private Sub sizeday()
        SizeWidthEqually(daycontainerrow1)
        SizeWidthEqually(daycontainerrow2)
        SizeWidthEqually(daycontainerrow3)
        SizeWidthEqually(daycontainerrow4)
        SizeWidthEqually(daycontainerrow5)
        SizeWidthEqually(daycontainerrow6)

    End Sub
    Private Sub pCalendar()
        Dim lbl As Control
        Dim lblName As String
        lbl = monthcontainer.Controls.Find("LblMonthYear", False).FirstOrDefault
        lbl.Text = String.Format("{0} {1}", MonthName(calendarinfo.Month), calendarinfo.Year)
        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                lblName = String.Format("LblDayOfMonth{0}{1}", rowIndex, colIndex)
                lbl = Me.Controls.Find(lblName, True).FirstOrDefault

                lbl.Text = calendarinfo.DayInMonth(rowIndex, colIndex)
                If calendarinfo.IsActiveMonth(rowIndex, colIndex) Then
                    lbl.ForeColor = Color.Black
                Else
                    lbl.ForeColor = Color.Gray
                End If

                If calendarinfo.IsToday(rowIndex, colIndex) Then
                    lbl.ForeColor = Color.Red
                End If

            Next
        Next
    End Sub

    Private Sub monthcontainer_Click(sender As Object, e As EventArgs) Handles monthcontainer.Click
        Dim pointClicked As Point
        Dim midpointX As Integer
        Dim activeMonth As DateTime
        Dim newMonth As DateTime

        midpointX = monthcontainer.Width / 2
        pointClicked = monthcontainer.PointToClient(Cursor.Position)
        activeMonth = New Date(calendarinfo.Year, calendarinfo.Month, 1)
        If pointClicked.X < midpointX Then
            newMonth = activeMonth.AddMonths(-1)
        Else
            newMonth = activeMonth.AddMonths(1)
        End If
        calendarinfo.GoToMonth(newMonth.Year, newMonth.Month)

        pCalendar()
        RemoveTestData(Me)
        CreateTestData()


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        customerform.Show()

    End Sub

    Public Sub CreateTestData()
        Dim dates As New List(Of Date)
        Dim name As New List(Of String)
        Dim col As Integer
        Dim row As Integer
        Dim pnl As Panel
        Dim pnlName As String
        Dim lbl As LinkLabel


        cstring()
        connec()

        Dim namef As String = Nothing
        Dim datef As String = Nothing
        Using cmd As New SqlCommand("SELECT NAME, DATE FROM customer_table1", con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dataSetTable As New DataSet
            adapter.Fill(dataSetTable)
            Dim table = dataSetTable.Tables(0)

            If table.Rows.Count > 0 Then
                For c = 0 To table.Rows.Count - 1
                    namef = table.Rows.Item(c).Item("NAME")
                    datef = Date.Parse(table.Rows.Item(c).Item("DATE"))
                    If Not dates.Contains(datef) Then
                        dates.Add(datef)
                        name.Add(namef)
                    End If
                Next
            End If
        End Using

        ' ADDS ALL THE SCHEDS HERE
        For i = 0 To dates.Count - 1
            If calendarinfo.DateExists(dates(i)) Then
                col = calendarinfo.Col(dates(i))
                row = calendarinfo.Row(dates(i))
                pnlName = String.Format("PnlDay{0}{1}", row, col)
                pnl = Controls.Find(pnlName, True).First
                lbl = New LinkLabel
                lbl.Name = String.Format("LblTest{0}{1}", row, col)
                lbl.BackColor = Color.FromArgb(137, 207, 241)
                lbl.Text = name(i)
                lbl.LinkColor = Color.Black
                lbl.TextAlign = ContentAlignment.MiddleLeft
                lbl.Location = New Point(0, 25)
                AddHandler lbl.Click, AddressOf shoutSomething
                If Not Timer2.Enabled Then
                    Timer2.Start()
                End If
                pnl.Controls.Add(lbl)
            End If
        Next

    End Sub

    Public Sub shoutSomething(sender As Object, e As EventArgs)
        'cstring()
        'connec()
        'cmd = New SqlCommand("Select * from customer_table1", con)
        'Using dr As SqlDataReader = cmd.ExecuteReader()
        '    dr.Read()
        '    editform.txtbox1.Text = dr("NAME").ToString()
        '    editform.txtbox2.Text = dr("SERVICE").ToString()
        '    editform.txtbox3.Text = dr("TYPE").ToString()
        '    editform.txtbox4.Text = dr("DATE").ToString()
        '    editform.txtbox5.Text = dr("START_TIME").ToString()
        '    editform.txtbox6.Text = dr("END_TIME").ToString()
        '    editform.txtbox7.Text = dr("ESTHETICIANS").ToString()
        '    editform.txtbox8.Text = dr("CONTACT_NUMBER").ToString()
        '    editform.Show()
        'End Using
        allformvb.Show()

    End Sub

    Public Sub RemoveTestData(c As Control)
        For Each ctrl As Control In c.Controls
            RemoveTestData(ctrl)
        Next
        If c.Name.StartsWith("LblTest") Then
            c.Parent.Controls.Remove(c)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currenttime = Date.Now.ToString("h:mm:ss tt")
        Label1.Text = currenttime
    End Sub

    Dim notifcount As Integer = 0
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim curr As Date = Date.Now
        For i = 0 To listoftimes.Count - 1

            If currenttime = listoftimes(i) Then
                listoftimes.RemoveAt(i)
                Timer2.Enabled = False
                Timer2.Stop()
                Timer2.Dispose()
                MsgBox("Sample pa lang")

                Return
            End If
        Next

    End Sub
End Class