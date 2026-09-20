<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aaircraft
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aaircraft))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Submit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EconomyClassSeats = New System.Windows.Forms.TextBox()
        Me.BusinessClassSeats = New System.Windows.Forms.TextBox()
        Me.FirstClassSeats = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AirlineName = New System.Windows.Forms.TextBox()
        Me.AircraftTypeId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Delete = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AircraftTypeIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AirlineNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstClassSeatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusinessClassSeatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EconomyClassSeatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AircraftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AirlineReservationSystemDataSet = New airline_ticket_reservation.AirlineReservationSystemDataSet()
        Me.AircraftBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AirlineName1 = New System.Windows.Forms.ComboBox()
        Me.SearchByName = New System.Windows.Forms.Label()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.AircraftTableAdapter1 = New airline_ticket_reservation.AirlineReservationSystemDataSetTableAdapters.AircraftTableAdapter()
        Me.TableAdapterManager1 = New airline_ticket_reservation.AirlineReservationSystemDataSetTableAdapters.TableAdapterManager()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AircraftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirlineReservationSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AircraftBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(385, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 33)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "ADD AIRCRAFT"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(314, 418)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 28)
        Me.Button2.TabIndex = 102
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cancel.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(189, 418)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 28)
        Me.Cancel.TabIndex = 94
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Submit
        '
        Me.Submit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Submit.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(376, 93)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(82, 28)
        Me.Submit.TabIndex = 92
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.EconomyClassSeats)
        Me.GroupBox1.Controls.Add(Me.BusinessClassSeats)
        Me.GroupBox1.Controls.Add(Me.FirstClassSeats)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 188)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seats"
        '
        'EconomyClassSeats
        '
        Me.EconomyClassSeats.Location = New System.Drawing.Point(149, 135)
        Me.EconomyClassSeats.Name = "EconomyClassSeats"
        Me.EconomyClassSeats.Size = New System.Drawing.Size(142, 22)
        Me.EconomyClassSeats.TabIndex = 3
        '
        'BusinessClassSeats
        '
        Me.BusinessClassSeats.Location = New System.Drawing.Point(149, 91)
        Me.BusinessClassSeats.Name = "BusinessClassSeats"
        Me.BusinessClassSeats.Size = New System.Drawing.Size(142, 22)
        Me.BusinessClassSeats.TabIndex = 2
        '
        'FirstClassSeats
        '
        Me.FirstClassSeats.Location = New System.Drawing.Point(149, 48)
        Me.FirstClassSeats.Name = "FirstClassSeats"
        Me.FirstClassSeats.Size = New System.Drawing.Size(142, 22)
        Me.FirstClassSeats.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Economy Class"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "First Class"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Business Class"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Airline Name"
        '
        'AirlineName
        '
        Me.AirlineName.Location = New System.Drawing.Point(175, 150)
        Me.AirlineName.Multiline = True
        Me.AirlineName.Name = "AirlineName"
        Me.AirlineName.Size = New System.Drawing.Size(142, 22)
        Me.AirlineName.TabIndex = 88
        '
        'AircraftTypeId
        '
        Me.AircraftTypeId.Location = New System.Drawing.Point(175, 93)
        Me.AircraftTypeId.Multiline = True
        Me.AircraftTypeId.Name = "AircraftTypeId"
        Me.AircraftTypeId.Size = New System.Drawing.Size(142, 22)
        Me.AircraftTypeId.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 16)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Aircraft Type ID"
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Delete.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Delete.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(685, 439)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(82, 28)
        Me.Delete.TabIndex = 97
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 300
        Me.ToolTip1.ReshowDelay = 100
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AircraftTypeIdDataGridViewTextBoxColumn, Me.AirlineNameDataGridViewTextBoxColumn, Me.FirstClassSeatsDataGridViewTextBoxColumn, Me.BusinessClassSeatsDataGridViewTextBoxColumn, Me.EconomyClassSeatsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AircraftBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(434, 171)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(586, 225)
        Me.DataGridView1.TabIndex = 101
        '
        'AircraftTypeIdDataGridViewTextBoxColumn
        '
        Me.AircraftTypeIdDataGridViewTextBoxColumn.DataPropertyName = "AircraftTypeId"
        Me.AircraftTypeIdDataGridViewTextBoxColumn.HeaderText = "AircraftTypeId"
        Me.AircraftTypeIdDataGridViewTextBoxColumn.Name = "AircraftTypeIdDataGridViewTextBoxColumn"
        Me.AircraftTypeIdDataGridViewTextBoxColumn.Width = 98
        '
        'AirlineNameDataGridViewTextBoxColumn
        '
        Me.AirlineNameDataGridViewTextBoxColumn.DataPropertyName = "AirlineName"
        Me.AirlineNameDataGridViewTextBoxColumn.HeaderText = "AirlineName"
        Me.AirlineNameDataGridViewTextBoxColumn.Name = "AirlineNameDataGridViewTextBoxColumn"
        Me.AirlineNameDataGridViewTextBoxColumn.Width = 88
        '
        'FirstClassSeatsDataGridViewTextBoxColumn
        '
        Me.FirstClassSeatsDataGridViewTextBoxColumn.DataPropertyName = "FirstClassSeats"
        Me.FirstClassSeatsDataGridViewTextBoxColumn.HeaderText = "FirstClassSeats"
        Me.FirstClassSeatsDataGridViewTextBoxColumn.Name = "FirstClassSeatsDataGridViewTextBoxColumn"
        Me.FirstClassSeatsDataGridViewTextBoxColumn.Width = 103
        '
        'BusinessClassSeatsDataGridViewTextBoxColumn
        '
        Me.BusinessClassSeatsDataGridViewTextBoxColumn.DataPropertyName = "BusinessClassSeats"
        Me.BusinessClassSeatsDataGridViewTextBoxColumn.HeaderText = "BusinessClassSeats"
        Me.BusinessClassSeatsDataGridViewTextBoxColumn.Name = "BusinessClassSeatsDataGridViewTextBoxColumn"
        Me.BusinessClassSeatsDataGridViewTextBoxColumn.Width = 126
        '
        'EconomyClassSeatsDataGridViewTextBoxColumn
        '
        Me.EconomyClassSeatsDataGridViewTextBoxColumn.DataPropertyName = "EconomyClassSeats"
        Me.EconomyClassSeatsDataGridViewTextBoxColumn.HeaderText = "EconomyClassSeats"
        Me.EconomyClassSeatsDataGridViewTextBoxColumn.Name = "EconomyClassSeatsDataGridViewTextBoxColumn"
        Me.EconomyClassSeatsDataGridViewTextBoxColumn.Width = 128
        '
        'AircraftBindingSource
        '
        Me.AircraftBindingSource.DataMember = "Aircraft"
        Me.AircraftBindingSource.DataSource = Me.AirlineReservationSystemDataSet
        '
        'AirlineReservationSystemDataSet
        '
        Me.AirlineReservationSystemDataSet.DataSetName = "AirlineReservationSystemDataSet"
        Me.AirlineReservationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AirlineName1
        '
        Me.AirlineName1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.AirlineName1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AirlineName1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AirlineName1.FormattingEnabled = True
        Me.AirlineName1.Location = New System.Drawing.Point(638, 119)
        Me.AirlineName1.Name = "AirlineName1"
        Me.AirlineName1.Size = New System.Drawing.Size(161, 21)
        Me.AirlineName1.TabIndex = 91
        '
        'SearchByName
        '
        Me.SearchByName.AutoSize = True
        Me.SearchByName.BackColor = System.Drawing.Color.Transparent
        Me.SearchByName.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchByName.ForeColor = System.Drawing.Color.Black
        Me.SearchByName.Location = New System.Drawing.Point(634, 68)
        Me.SearchByName.Name = "SearchByName"
        Me.SearchByName.Size = New System.Drawing.Size(187, 22)
        Me.SearchByName.TabIndex = 100
        Me.SearchByName.Text = "Search By Airline Name"
        '
        'NewRecord
        '
        Me.NewRecord.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NewRecord.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecord.ImageKey = "(none)"
        Me.NewRecord.Location = New System.Drawing.Point(939, -65)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(96, 47)
        Me.NewRecord.TabIndex = 95
        Me.NewRecord.Tag = ""
        Me.NewRecord.Text = "New"
        Me.NewRecord.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(456, 439)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 28)
        Me.Button1.TabIndex = 99
        Me.Button1.Text = "Get Data"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Add.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.Location = New System.Drawing.Point(566, 439)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(82, 28)
        Me.Add.TabIndex = 96
        Me.Add.Text = "Save"
        Me.Add.UseVisualStyleBackColor = False
        '
        'AircraftTableAdapter1
        '
        Me.AircraftTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AircraftTableAdapter = Me.AircraftTableAdapter1
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CancelReservationTableAdapter = Nothing
        Me.TableAdapterManager1.CollectionsTableAdapter = Nothing
        Me.TableAdapterManager1.FlightsTableAdapter = Nothing
        Me.TableAdapterManager1.RefundsTableAdapter = Nothing
        Me.TableAdapterManager1.ReservationsTableAdapter = Nothing
        Me.TableAdapterManager1.ScheduleflightsTableAdapter = Nothing
        Me.TableAdapterManager1.SectorTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = airline_ticket_reservation.AirlineReservationSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.usersTableAdapter = Nothing
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Edit.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.Location = New System.Drawing.Point(817, 439)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(82, 28)
        Me.Edit.TabIndex = 98
        Me.Edit.Text = "Update"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(938, 439)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 28)
        Me.Button3.TabIndex = 104
        Me.Button3.Text = "Next >>"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'aaircraft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 485)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AirlineName)
        Me.Controls.Add(Me.AircraftTypeId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AirlineName1)
        Me.Controls.Add(Me.SearchByName)
        Me.Controls.Add(Me.NewRecord)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Add)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "aaircraft"
        Me.Text = "Enter aircraft details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AircraftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirlineReservationSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AircraftBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents EconomyClassSeats As System.Windows.Forms.TextBox
    Friend WithEvents BusinessClassSeats As System.Windows.Forms.TextBox
    Friend WithEvents FirstClassSeats As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AirlineName As System.Windows.Forms.TextBox
    Friend WithEvents AircraftTypeId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AirlineName1 As System.Windows.Forms.ComboBox
    Private WithEvents SearchByName As System.Windows.Forms.Label
    Friend WithEvents NewRecord As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents AircraftBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AircraftTableAdapter1 As airline_ticket_reservation.AirlineReservationSystemDataSetTableAdapters.AircraftTableAdapter
    Friend WithEvents TableAdapterManager1 As airline_ticket_reservation.AirlineReservationSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AircraftTypeIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AirlineNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstClassSeatsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BusinessClassSeatsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EconomyClassSeatsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AircraftBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AirlineReservationSystemDataSet As airline_ticket_reservation.AirlineReservationSystemDataSet
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
