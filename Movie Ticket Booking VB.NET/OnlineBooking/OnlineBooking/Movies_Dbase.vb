Public Class Movies_Dbase

    Private Sub Movies_Dbase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookingDataSet.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.BookingDataSet.booking)

    End Sub

    Private Sub BookingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BookingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BookingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)

    End Sub

End Class