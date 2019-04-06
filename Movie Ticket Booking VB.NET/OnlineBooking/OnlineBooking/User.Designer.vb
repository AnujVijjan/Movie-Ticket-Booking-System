<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.Database2DataSet = New WindowsApp1.Database2DataSet()
        Me.AccountManagerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountManagerTableAdapter = New WindowsApp1.Database2DataSetTableAdapters.AccountManagerTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.Database2DataSetTableAdapters.TableAdapterManager()
        Me.AccountManagerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountManagerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountManagerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'AccountManagerDataGridView
        '
        Me.AccountManagerDataGridView.AutoGenerateColumns = False
        Me.AccountManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountManagerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.AccountManagerDataGridView.DataSource = Me.AccountManagerBindingSource
        Me.AccountManagerDataGridView.Location = New System.Drawing.Point(1, 3)
        Me.AccountManagerDataGridView.Name = "AccountManagerDataGridView"
        Me.AccountManagerDataGridView.Size = New System.Drawing.Size(345, 252)
        Me.AccountManagerDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "AccountType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "AccountType"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(130, 290)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(251, 290)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 429)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AccountManagerDataGridView)
        Me.Name = "User"
        Me.Text = "User"
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountManagerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountManagerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Database2DataSet As Database2DataSet
    Friend WithEvents AccountManagerBindingSource As BindingSource
    Friend WithEvents AccountManagerTableAdapter As Database2DataSetTableAdapters.AccountManagerTableAdapter
    Friend WithEvents TableAdapterManager As Database2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccountManagerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
