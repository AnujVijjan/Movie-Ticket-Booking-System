Public Class Delhi
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Delhi_Theatre.Label1.Text = LinkLabel1.Text
        Delhi_Theatre.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Delhi_Theatre.Label1.Text = LinkLabel2.Text
        Delhi_Theatre.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Delhi_Theatre.Label1.Text = LinkLabel3.Text
        Delhi_Theatre.Show()
    End Sub
End Class