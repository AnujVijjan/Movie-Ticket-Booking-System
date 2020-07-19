Public Class South_And_Central_Theatre

    Private Sub South_And_Central_Theatre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        _3_Showtimes.Label2.Text = "Anand Cinema: Thane"
        _3_Showtimes.Label3.Text = "Anand Cinema: Thane"
        _3_Showtimes.Label4.Text = "Anand Cinema: Thane"
        _3_Showtimes.Label5.Text = "Anand Cinema: Thane"
        _3_Showtimes.Show()
        _3_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _5_Showtimes.Label2.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Label3.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Label4.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Label5.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Show()
        _5_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        _4_Showtimes.Label2.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Label3.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Label4.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Label5.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Show()
        _4_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        _2_Showtimes.Label2.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Label3.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Label4.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Label5.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Show()
        _2_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        _3_Showtimes.Label2.Text = "Anand Cinema: Thane"
        _3_Showtimes.Label3.Text = "Anand Cinema: Thane"
        _3_Showtimes.Label4.Text = "Anand Cinema: Thane"
        _3_Showtimes.Label5.Text = "Anand Cinema: Thane"
        _3_Showtimes.Show()
        _3_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        _3_Showtimes.Label2.Text = "Anand Cinema: Thane"
        _3_Showtimes.Label3.Text = "Anand Cinema: Thane"
        _3_Showtimes.Label4.Text = "Anand Cinema: Thane"
        _3_Showtimes.Label5.Text = "Anand Cinema: Thane"
        _3_Showtimes.Show()
        _3_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        _3_Showtimes.Label2.Text = "Anand Cinema: Thane"
        _3_Showtimes.Label3.Text = "Anand Cinema: Thane"
        _3_Showtimes.Label4.Text = "Anand Cinema: Thane"
        _3_Showtimes.Label5.Text = "Anand Cinema: Thane"
        _3_Showtimes.Show()
        _3_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        _5_Showtimes.Label2.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Label3.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Label4.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Label5.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Show()
        _5_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        _5_Showtimes.Label2.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Label3.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Label4.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Label5.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Show()
        _5_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        _2_Showtimes.Label2.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Label3.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Label4.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Label5.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Show()
        _2_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        _2_Showtimes.Label2.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Label3.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Label4.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Label5.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Show()
        _2_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        _2_Showtimes.Label2.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Label3.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Label4.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Label5.Text = "Carnival: Huma, Kanjurmarg"
        _2_Showtimes.Show()
        _2_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        _4_Showtimes.Label2.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Label3.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Label4.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Label5.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Show()
        _4_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        _4_Showtimes.Label2.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Label3.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Label4.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Label5.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Show()
        _4_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        _4_Showtimes.Label2.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Label3.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Label4.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Label5.Text = "Carnival: Dreams Mall, Bhandup"
        _4_Showtimes.Show()
        _4_Showtimes.Label1.Text = Label1.Text
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        _5_Showtimes.Label2.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Label3.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Label4.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Label5.Text = "Bharat Cineplex: Kurla (W)"
        _5_Showtimes.Show()
        _5_Showtimes.Label1.Text = Label1.Text
    End Sub
End Class