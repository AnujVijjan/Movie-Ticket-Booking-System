<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_New_Account
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
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Database2DataSet = New WindowsApp1.Database2DataSet()
        Me.AccountManagerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountManagerTableAdapter = New WindowsApp1.Database2DataSetTableAdapters.AccountManagerTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.Database2DataSetTableAdapters.TableAdapterManager()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        UserNameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountManagerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(90, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 41)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Create"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Database2DataSet
        '
        Me.Database2DataSet.DataSetName = "Database2DataSet"
        Me.Database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountManagerBindingSource
        '
        Me.AccountManagerBindingSource.DataMember = "AccountManager"
        Me.AccountManagerBindingSource.DataSource = Me.Database2DataSet
        '
        'AccountManagerTableAdapter
        '
        Me.AccountManagerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountManagerTableAdapter = Me.AccountManagerTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserNameLabel.Location = New System.Drawing.Point(28, 40)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(135, 25)
        UserNameLabel.TabIndex = 7
        UserNameLabel.Text = "User Name:"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountManagerBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(33, 68)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(227, 20)
        Me.UserNameTextBox.TabIndex = 8
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(28, 120)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(121, 25)
        PasswordLabel.TabIndex = 9
        PasswordLabel.Text = "Password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountManagerBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(33, 148)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(227, 20)
        Me.PasswordTextBox.TabIndex = 10
        '
        'Create_New_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(286, 289)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Create_New_Account"
        Me.Text = "Create_New_Account"
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountManagerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Database2DataSet As Database2DataSet
    Friend WithEvents AccountManagerBindingSource As BindingSource
    Friend WithEvents AccountManagerTableAdapter As Database2DataSetTableAdapters.AccountManagerTableAdapter
    Friend WithEvents TableAdapterManager As Database2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
End Class
