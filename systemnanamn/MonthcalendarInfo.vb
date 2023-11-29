Imports System.Data.SqlClient

Public Class MonthcalendarInfo
    Private Months As Integer
    Private Years As Integer
    Private ReadOnly Days(5, 6) As DateTime 'Multidimensional array
    Public ReadOnly Property Month
        Get
            Return Months
        End Get
    End Property
    Public ReadOnly Property Year
        Get
            Return Years
        End Get
    End Property
    Public Sub New()
        Months = Now.Month
        Years = Now.Year
        SetDays()
    End Sub
    Public Sub New(year As Integer, month As Integer)
        If year < 1 Or year > 9999 Then
            Throw New ArgumentOutOfRangeException("year")
        End If
        If month < 1 Or month > 12 Then
            Throw New ArgumentOutOfRangeException("month")
        End If
        Months = month
        Years = year
        SetDays()
    End Sub
    Private Sub SetDays()
        Dim firstDayofMonth As DateTime
        Dim column As Integer
        Dim firstDayofGrid As DateTime
        Dim gridDate As DateTime

        firstDayofMonth = New Date(Years, Months, 1)
        column = CInt(firstDayofMonth.DayOfWeek)
        firstDayofGrid = firstDayofMonth.AddDays(column * -1)

        gridDate = firstDayofGrid
        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                Days(rowIndex, colIndex) = gridDate
                gridDate = gridDate.AddDays(1)
            Next
        Next
        Return

    End Sub
    Public Sub GoToMonth(year As Integer, month As Integer)
        If year < 1 Or year > 9999 Then
            Throw New ArgumentOutOfRangeException("year")
        End If
        If month < 1 Or month > 12 Then
            Throw New ArgumentOutOfRangeException("month")
        End If
        Years = year
        Months = month
        SetDays()
    End Sub
    Public Function DayInMonth(row As Integer, column As Integer) As Integer
        If row < 0 Or row > 5 Then
            Throw New ArgumentOutOfRangeException("row")
        End If
        If column < 0 Or column > 6 Then
            Throw New ArgumentOutOfRangeException("column")
        End If
        Return Days(row, column).Day
    End Function
    Public Function IsActiveMonth(row As Integer, column As Integer) As Boolean
        If row < 0 Or row > 5 Then
            Throw New ArgumentOutOfRangeException("row")
        End If
        If column < 0 Or column > 6 Then
            Throw New ArgumentOutOfRangeException("column")
        End If
        Return Days(row, column).Month = Month
    End Function
    Public Function IsToday(row As Integer, column As Integer) As Boolean
        If row < 0 Or row > 5 Then
            Throw New ArgumentOutOfRangeException("row")
        End If
        If column < 0 Or column > 6 Then
            Throw New ArgumentOutOfRangeException("column")
        End If
        Return Days(row, column).Date = Now.Date
    End Function
    Public Function Row(dt As DateTime) As Integer
        Dim colIndex = 0
        Dim rowIndex = 0
        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                If Days(rowIndex, colIndex) = dt Then
                    Return rowIndex
                End If
            Next
        Next
        Return -1
    End Function
    Public Function Col(dt As DateTime) As Integer
        Dim colIndex = 0
        Dim rowIndex = 0
        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                If Days(rowIndex, colIndex) = dt Then
                    Return colIndex
                End If
            Next
        Next
        Return -1
    End Function
    Public Function DateExists(dt As DateTime) As Boolean
        If Row(dt) > -1 Then

            Return True
        End If
        Return False
    End Function



End Class
Module x
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
    Public Sub audit(un As String, a As String)
        cstring()
        connec()
        Using addaudit As New SqlCommand("Insert into audit_table  values (@username, @date, @action)", con)
            addaudit.Connection = con
            addaudit.Parameters.AddWithValue("@username", un)
            addaudit.Parameters.AddWithValue("@date", DateTime.Now)
            addaudit.Parameters.AddWithValue("@action", a)
            addaudit.ExecuteNonQuery()

        End Using
    End Sub
End Module