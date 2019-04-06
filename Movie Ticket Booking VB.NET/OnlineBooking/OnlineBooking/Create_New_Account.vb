Public Class Create_New_Account

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AccountManagerTableAdapter.InsertQuery(UserNameTextBox.Text, PasswordTextBox.Text, "User")
        Me.Close()
    End Sub

End Class