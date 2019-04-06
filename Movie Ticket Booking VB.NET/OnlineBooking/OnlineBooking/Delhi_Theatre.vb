Public Class Delhi_Theatre

    Private Sub Delhi_Theatre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _1Showtime.Label1.Text = Label1.Text
        _2_Showtimes.Label1.Text = Label1.Text
        _3_Showtimes.Label1.Text = Label1.Text
        _5_Showtimes.Label1.Text = Label1.Text
        _4_Showtimes.Label1.Text = Label1.Text
        TabPage1.Text = System.DateTime.Today.Date.Day.ToString + " Mar " + System.DateTime.Today.DayOfWeek.ToString
        TabPage2.Text = System.DateTime.Today.Date.AddDays(1).Day.ToString + " Mar " + System.DateTime.Today.AddDays(1).DayOfWeek.ToString
        TabPage3.Text = System.DateTime.Today.Date.AddDays(2).Day.ToString + " Mar " + System.DateTime.Today.AddDays(2).DayOfWeek.ToString
        TabPage4.Text = System.DateTime.Today.Date.AddDays(3).Day.ToString + " Mar " + System.DateTime.Today.AddDays(3).DayOfWeek.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _1Showtime.Label2.Text = "Amba Cinema: Delhi"
        _1Showtime.Label3.Text = "Amba Cinema: Delhi"
        _1Showtime.Label4.Text = "Amba Cinema: Delhi"
        _1Showtime.Label5.Text = "Amba Cinema: Delhi"
        _1Showtime.Show()
        _1Showtime.Label1.Text = Label1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _5_Showtimes.Label2.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Label3.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Label4.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Label5.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Show()
        _5_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        _5_Showtimes.Label2.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Label3.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Label4.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Label5.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Show()
        _5_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        _3_Showtimes.Label2.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Label3.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Label4.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Label5.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Show()
        _3_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        _4_Showtimes.Label2.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Label3.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Label4.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Label5.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Show()
        _4_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        _4_Showtimes.Label2.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Label3.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Label4.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Label5.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Show()
        _4_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        _4_Showtimes.Label2.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Label3.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Label4.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Label5.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Show()
        _4_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        _4_Showtimes.Label2.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Label3.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Label4.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Label5.Text = "PVR: Anupam, Delhi"
        _4_Showtimes.Show()
        _4_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        _3_Showtimes.Label2.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Label3.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Label4.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Label5.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Show()
        _3_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        _5_Showtimes.Label2.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Label3.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Label4.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Label5.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Show()
        _5_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        _5_Showtimes.Label2.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Label3.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Label4.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Label5.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Show()
        _5_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        _1Showtime.Label2.Text = "Amba Cinema: Delhi"
        _1Showtime.Label3.Text = "Amba Cinema: Delhi"
        _1Showtime.Label4.Text = "Amba Cinema: Delhi"
        _1Showtime.Label5.Text = "Amba Cinema: Delhi"
        _1Showtime.Show()
        _1Showtime.Label1.Text = Label1.Text
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        _1Showtime.Label2.Text = "Amba Cinema: Delhi"
        _1Showtime.Label3.Text = "Amba Cinema: Delhi"
        _1Showtime.Label4.Text = "Amba Cinema: Delhi"
        _1Showtime.Label5.Text = "Amba Cinema: Delhi"
        _1Showtime.Show()
        _1Showtime.Label1.Text = Label1.Text
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        _1Showtime.Label2.Text = "Amba Cinema: Delhi"
        _1Showtime.Label3.Text = "Amba Cinema: Delhi"
        _1Showtime.Label4.Text = "Amba Cinema: Delhi"
        _1Showtime.Label5.Text = "Amba Cinema: Delhi"
        _1Showtime.Show()
        _1Showtime.Label1.Text = Label1.Text
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        _5_Showtimes.Label2.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Label3.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Label4.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Label5.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Show()
        _5_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        _5_Showtimes.Label2.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Label3.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Label4.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Label5.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Show()
        _5_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        _3_Showtimes.Label2.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Label3.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Label4.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Label5.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Show()
        _3_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        _5_Showtimes.Label2.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Label3.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Label4.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Label5.Text = "Carnival: Odeon Complex"
        _5_Showtimes.Show()
        _5_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        _5_Showtimes.Label2.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Label3.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Label4.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Label5.Text = "Cinepolis: DLF Place, Saket"
        _5_Showtimes.Show()
        _5_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        _3_Showtimes.Label2.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Label3.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Label4.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Label5.Text = "PVR: 3CS, Delhi"
        _3_Showtimes.Show()
        _3_Showtimes.Label1.Text = Label1.Text
    End Sub
End Class