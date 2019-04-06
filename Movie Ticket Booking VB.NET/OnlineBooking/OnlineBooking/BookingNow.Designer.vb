<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingNow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Booking_nameTextBox = New System.Windows.Forms.TextBox()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingDataSet = New WindowsApp1.bookingDataSet()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Total_BillTextBox = New System.Windows.Forms.TextBox()
        Me.FoodComboBox = New System.Windows.Forms.ComboBox()
        Me.Seat_TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.BookingTableAdapter = New WindowsApp1.bookingDataSetTableAdapters.bookingTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.bookingDataSetTableAdapters.TableAdapterManager()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 57)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(188, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 57)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "BOOK NOW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "You will pay"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Select Food"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Select Seat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Contact No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Your Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Book my Ticket Now"
        '
        'Booking_nameTextBox
        '
        Me.Booking_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "Booking_name", True))
        Me.Booking_nameTextBox.Location = New System.Drawing.Point(109, 59)
        Me.Booking_nameTextBox.Name = "Booking_nameTextBox"
        Me.Booking_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Booking_nameTextBox.TabIndex = 44
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "booking"
        Me.BookingBindingSource.DataSource = Me.BookingDataSet
        '
        'BookingDataSet
        '
        Me.BookingDataSet.DataSetName = "bookingDataSet"
        Me.BookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(109, 99)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 46
        '
        'Total_BillTextBox
        '
        Me.Total_BillTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "Total_Bill", True))
        Me.Total_BillTextBox.Location = New System.Drawing.Point(109, 265)
        Me.Total_BillTextBox.Name = "Total_BillTextBox"
        Me.Total_BillTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Total_BillTextBox.TabIndex = 54
        '
        'FoodComboBox
        '
        Me.FoodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "Food", True))
        Me.FoodComboBox.FormattingEnabled = True
        Me.FoodComboBox.Items.AddRange(New Object() {"Popcorn", "Coke", "Chips", "Hot Dog"})
        Me.FoodComboBox.Location = New System.Drawing.Point(109, 186)
        Me.FoodComboBox.Name = "FoodComboBox"
        Me.FoodComboBox.Size = New System.Drawing.Size(200, 21)
        Me.FoodComboBox.TabIndex = 57
        '
        'Seat_TypeComboBox
        '
        Me.Seat_TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "Seat_Type", True))
        Me.Seat_TypeComboBox.FormattingEnabled = True
        Me.Seat_TypeComboBox.Items.AddRange(New Object() {"Front Area", "Back Area", "Corner", "Balcony"})
        Me.Seat_TypeComboBox.Location = New System.Drawing.Point(109, 144)
        Me.Seat_TypeComboBox.Name = "Seat_TypeComboBox"
        Me.Seat_TypeComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Seat_TypeComboBox.TabIndex = 58
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bookingTableAdapter = Me.BookingTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.bookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BookingNow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 422)
        Me.Controls.Add(Me.Seat_TypeComboBox)
        Me.Controls.Add(Me.FoodComboBox)
        Me.Controls.Add(Me.Booking_nameTextBox)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.Total_BillTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BookingNow"
        Me.Text = "BookingNow"
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BookingDataSet As bookingDataSet
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As bookingDataSetTableAdapters.bookingTableAdapter
    Friend WithEvents TableAdapterManager As bookingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Booking_nameTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Total_BillTextBox As TextBox
    Friend WithEvents FoodComboBox As ComboBox
    Friend WithEvents Seat_TypeComboBox As ComboBox
End Class
