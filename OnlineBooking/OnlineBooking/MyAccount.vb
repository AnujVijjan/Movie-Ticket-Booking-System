Public Class myAccount

    Private Sub myaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.AccountManager' table. You can move, or remove it, as needed.
        Me.AccountManagerTableAdapter.Fill(Me.Database2DataSet.AccountManager)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog()
        open.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp"
        If open.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = System.IO.Path.GetFullPath(open.FileName)
            PictureBox1.Image = New Bitmap(open.FileName)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            'Me.Icon = PictureBox1.Image
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.AccountManagerTableAdapter.UpdateQuery(TextBox1.Text, SettingsUser)
        MsgBox("Updated Password Successfully")
        My.Settings.Save()
    End Sub

End Class