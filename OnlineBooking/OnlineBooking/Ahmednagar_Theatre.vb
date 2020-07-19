Public Class Ahmednagar_Theatre
    Private Sub Ahmednagar_Theatre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        _3_Showtimes.Label2.Text = "Asha Square Multiplex:"
        _3_Showtimes.Label3.Text = "Asha Square Multiplex:"
        _3_Showtimes.Label4.Text = "Asha Square Multiplex:"
        _3_Showtimes.Label5.Text = "Asha Square Multiplex:"
        _3_Showtimes.Show()
        _3_Showtimes.Label1.Text = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        _4_Showtimes.Label2.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Label3.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Label4.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Label5.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Show()
        _4_Showtimes.Label1.Text = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _3_Showtimes.Label2.Text = "Asha Square Multiplex:"
        _3_Showtimes.Label3.Text = "Asha Square Multiplex:"
        _3_Showtimes.Label4.Text = "Asha Square Multiplex:"
        _3_Showtimes.Label5.Text = "Asha Square Multiplex:"
        _3_Showtimes.Show()
        _3_Showtimes.Label1.Text = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        _3_Showtimes.Label2.Text = "Asha Square Multiplex:"
        _3_Showtimes.Label3.Text = "Asha Square Multiplex:"
        _3_Showtimes.Label4.Text = "Asha Square Multiplex:"
        _3_Showtimes.Label5.Text = "Asha Square Multiplex:"
        _3_Showtimes.Show()
        _3_Showtimes.Label1.Text = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        _3_Showtimes.Label2.Text = "Asha Square Multiplex:"
        _3_Showtimes.Label3.Text = "Asha Square Multiplex:"
        _3_Showtimes.Label4.Text = "Asha Square Multiplex:"
        _3_Showtimes.Label5.Text = "Asha Square Multiplex:"
        _3_Showtimes.Show()
        _3_Showtimes.Label1.Text = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        _4_Showtimes.Label2.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Label3.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Label4.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Label5.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Show()
        _4_Showtimes.Label1.Text = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        _4_Showtimes.Label2.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Label3.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Label4.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Label5.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Show()
        _4_Showtimes.Label1.Text = Label1.Text
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _4_Showtimes.Label2.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Label3.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Label4.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Label5.Text = "My Cinema E-SQUARE:  Ahmednagar"
        _4_Showtimes.Show()
        _4_Showtimes.Label1.Text = Label1.Text
        Me.Close()
    End Sub
End Class