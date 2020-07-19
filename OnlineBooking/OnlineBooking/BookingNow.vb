
Public Class BookingNow
    Public show_time As String
    Public movie As String
    Dim price As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Seat_TypeComboBox.SelectedItem = "Front Area" Then
            price = 150
        ElseIf Seat_TypeComboBox.SelectedItem = "Back Area" Then
            price = 100
        ElseIf Seat_TypeComboBox.SelectedItem = "Corner" Then
            price = 200
        ElseIf Seat_TypeComboBox.SelectedItem = "Balcony" Then
            price = 170
        ElseIf FoodComboBox.SelectedItem = "Popcorn" Then
            price = price + 80
        ElseIf FoodComboBox.SelectedItem = "Coke" Then
            price = price + 40
        ElseIf FoodComboBox.SelectedItem = "Chips" Then
            price = price + 30
        ElseIf FoodComboBox.SelectedItem = "Hot Dog" Then
            price = price + 200
        End If

        Total_BillTextBox.Text = price
        If Booking_nameTextBox.Text = "" Or PhoneTextBox.Text = "" Or Seat_TypeComboBox.Text = "" Or FoodComboBox.Text = "" Then
            MsgBox("Please Fill All the fields")
        End If
        Total_BillTextBox.Text = price
        BookingTableAdapter.InsertQuery(Booking_nameTextBox.Text, PhoneTextBox.Text, movie, Seat_TypeComboBox.Text, FoodComboBox.Text, Total_BillTextBox.Text, show_time)
        MsgBox("Booking Successfull. Please Reach 45 min. Before Showtime & Pay At the Theatre")
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Booking_nameTextBox.Text = ""
        PhoneTextBox.Text = ""
        Seat_TypeComboBox.Text = ""
        FoodComboBox.Text = ""
        Total_BillTextBox.Text = ""
    End Sub

End Class