Imports WindowsApp1.BookingNow

Public Class _1Showtime
    Private Sub _1Showtime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPage1.Text = System.DateTime.Today.Date.Day.ToString + " Mar " + System.DateTime.Today.DayOfWeek.ToString
        TabPage2.Text = System.DateTime.Today.Date.AddDays(1).Day.ToString + " Mar " + System.DateTime.Today.AddDays(1).DayOfWeek.ToString
        TabPage3.Text = System.DateTime.Today.Date.AddDays(2).Day.ToString + " Mar " + System.DateTime.Today.AddDays(2).DayOfWeek.ToString
        TabPage4.Text = System.DateTime.Today.Date.AddDays(3).Day.ToString + " Mar " + System.DateTime.Today.AddDays(3).DayOfWeek.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage1.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BookingNow.show_time = TabPage3.Text
        BookingNow.movie = Label1.Text
        BookingNow.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BookingNow.show_time = TabPage2.Text
        BookingNow.movie = Label1.Text
        BookingNow.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BookingNow.show_time = TabPage4.Text
        BookingNow.movie = Label1.Text
        BookingNow.Show()
        Me.Close()
    End Sub
End Class