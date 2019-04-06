Public Class _5_Showtimes
    Private Sub _5_Showtimes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPage1.Text = System.DateTime.Today.Date.Day.ToString + " Mar " + System.DateTime.Today.DayOfWeek.ToString
        TabPage2.Text = System.DateTime.Today.Date.AddDays(1).Day.ToString + " Mar " + System.DateTime.Today.AddDays(1).DayOfWeek.ToString
        TabPage3.Text = System.DateTime.Today.Date.AddDays(2).Day.ToString + " Mar " + System.DateTime.Today.AddDays(2).DayOfWeek.ToString
        TabPage4.Text = System.DateTime.Today.Date.AddDays(3).Day.ToString + " Mar " + System.DateTime.Today.AddDays(3).DayOfWeek.ToString
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage1.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage1.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage1.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage1.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage1.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage2.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage2.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage2.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage2.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage2.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage3.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage3.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage3.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage3.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage3.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage4.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage4.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage4.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage4.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BookingNow.Show()
        BookingNow.show_time = TabPage4.Text
        BookingNow.movie = Label1.Text
        Me.Close()
    End Sub
End Class