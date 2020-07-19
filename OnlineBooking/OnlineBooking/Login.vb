Public Class Login

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.AccountManager' table. You can move, or remove it, as needed.
        Me.AccountManagerTableAdapter.Fill(Me.Database2DataSet.AccountManager)

        'Me.AccountManagerTableAdapter.Fill(Me.Database2DataSet.AccountManager)

        ProgressBar1.Maximum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Visible = True
        ProgressBar1.Value = 0

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label4.Visible = True
        ProgressBar1.Value = 0
        ProgressBar1.Enabled = True
        Timer1.Enabled = True
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 5
        Label4.Text = ProgressBar1.Value & "%" & "Completed"
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            If AccountTypeComboBox.SelectedItem Is Nothing Then
                ErrorProvider1.SetError(AccountTypeComboBox, "Select Account Type !!!")
            Else
                ErrorProvider1.Clear()
                If AccountTypeComboBox.SelectedItem.ToString = "Admin" Then
                    Call Admin_Pro()
                Else
                    Call User()
                End If
            End If
        End If
    End Sub
    Private Sub Admin_Pro()

        If (Me.UserNameTextBox.Text = "GPAN" And Me.PasswordTextBox.Text = "1234") Then
            ErrorProvider1.Clear()
            ProgressBar1.Value = 0
            Admin.Show()
        ElseIf UserNameTextBox.Text <> "GPAN" And PasswordTextBox.Text <> "1234" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(UserNameTextBox, "Please Enter Correct UserName")
            ErrorProvider1.SetError(PasswordTextBox, "Please Enter Correct Password")
        ElseIf UserNameTextBox.Text = "GPAN" And Me.PasswordTextBox.Text <> "1234" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(PasswordTextBox, "Please Enter Correct Password")
        ElseIf UserNameTextBox.Text <> "GPAN" And Me.PasswordTextBox.Text = "1234" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(UserNameTextBox, "Please Enter Correct UserName")
        End If
    End Sub

    Private Sub User()
        Dim login = AccountManagerTableAdapter.MainQuery(UserNameTextBox.Text, PasswordTextBox.Text)
        If (login Is Nothing) Then
            ErrorProvider1.SetError(UserNameTextBox, "Please Enter Correct UserName")
            ErrorProvider1.SetError(PasswordTextBox, "Please Enter Correct Password")
        Else
            ErrorProvider1.Clear()
            WindowsApp1.Location.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Create_New_Account.Show()
    End Sub
End Class
