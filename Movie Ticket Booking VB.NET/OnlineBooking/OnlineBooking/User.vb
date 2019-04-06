Public Class User
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.AccountManager' table. You can move, or remove it, as needed.
        AccountManagerTableAdapter.Fill(Me.Database2DataSet.AccountManager)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AccountManagerBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Validate()
        AccountManagerBindingSource.EndEdit()
        AccountManagerTableAdapter.Update(Me.Database2DataSet.AccountManager)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AccountManagerBindingSource.RemoveCurrent()
    End Sub
End Class