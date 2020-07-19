Public Class Mumbai_South_And_Central
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        South_And_Central_Theatre.Label1.Text = LinkLabel1.Text
        South_And_Central_Theatre.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        South_And_Central_Theatre.Label1.Text = LinkLabel2.Text
        South_And_Central_Theatre.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        South_And_Central_Theatre.Label1.Text = LinkLabel3.Text
        South_And_Central_Theatre.Show()
    End Sub
End Class