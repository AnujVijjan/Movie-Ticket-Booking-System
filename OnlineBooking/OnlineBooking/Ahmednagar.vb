Public Class Ahmednagar
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Ahmednagar_Theatre.Label1.Text = LinkLabel1.Text
        Ahmednagar_Theatre.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Ahmednagar_Theatre.Label1.Text = LinkLabel2.Text
        Ahmednagar_Theatre.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Ahmednagar_Theatre.Label1.Text = LinkLabel3.Text
        Ahmednagar_Theatre.Show()
    End Sub
End Class