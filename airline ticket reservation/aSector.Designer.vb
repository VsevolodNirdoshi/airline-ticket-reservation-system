<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aSector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aSector))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BusinessClassFare = New System.Windows.Forms.TextBox()
        Me.EconomyClassFare = New System.Windows.Forms.TextBox()
        Me.FirstClassFare = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Add = New System.Windows.Forms.Button()
        Me.SectorID = New System.Windows.Forms.TextBox()
        Me.Source = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.WeekDays = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Destination = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SectorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeekdaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstClassFareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusinessClassFareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EconomyClassFareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AirlineReservationSystemDataSet = New airline_ticket_reservation.AirlineReservationSystemDataSet()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.SectorTableAdapter = New airline_ticket_reservation.AirlineReservationSystemDataSetTableAdapters.SectorTableAdapter()
        Me.TableAdapterManager = New airline_ticket_reservation.AirlineReservationSystemDataSetTableAdapters.TableAdapterManager()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirlineReservationSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(428, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 33)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "ADD SECTOR"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(384, 527)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 28)
        Me.Button2.TabIndex = 108
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.Location = New System.Drawing.Point(870, 495)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(82, 28)
        Me.Edit.TabIndex = 102
        Me.Edit.Text = "Update"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(756, 495)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(82, 28)
        Me.Delete.TabIndex = 101
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.BusinessClassFare)
        Me.GroupBox1.Controls.Add(Me.EconomyClassFare)
        Me.GroupBox1.Controls.Add(Me.FirstClassFare)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(127, 335)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 140)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fares"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(26, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "First Class"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(26, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Economy Class"
        '
        'BusinessClassFare
        '
        Me.BusinessClassFare.Location = New System.Drawing.Point(150, 67)
        Me.BusinessClassFare.Name = "BusinessClassFare"
        Me.BusinessClassFare.Size = New System.Drawing.Size(100, 22)
        Me.BusinessClassFare.TabIndex = 2
        '
        'EconomyClassFare
        '
        Me.EconomyClassFare.Location = New System.Drawing.Point(150, 99)
        Me.EconomyClassFare.Name = "EconomyClassFare"
        Me.EconomyClassFare.Size = New System.Drawing.Size(100, 22)
        Me.EconomyClassFare.TabIndex = 3
        '
        'FirstClassFare
        '
        Me.FirstClassFare.Location = New System.Drawing.Point(150, 32)
        Me.FirstClassFare.Name = "FirstClassFare"
        Me.FirstClassFare.Size = New System.Drawing.Size(100, 22)
        Me.FirstClassFare.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(26, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Business Class"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(124, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Week Days"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Source"
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.Location = New System.Drawing.Point(646, 495)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(82, 28)
        Me.Add.TabIndex = 100
        Me.Add.Text = "Save"
        Me.Add.UseVisualStyleBackColor = False
        '
        'SectorID
        '
        Me.SectorID.Location = New System.Drawing.Point(262, 104)
        Me.SectorID.Name = "SectorID"
        Me.SectorID.Size = New System.Drawing.Size(121, 20)
        Me.SectorID.TabIndex = 90
        '
        'Source
        '
        Me.Source.Location = New System.Drawing.Point(262, 141)
        Me.Source.Multiline = True
        Me.Source.Name = "Source"
        Me.Source.Size = New System.Drawing.Size(121, 23)
        Me.Source.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Sector ID"
        '
        'Submit
        '
        Me.Submit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(434, 99)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(82, 28)
        Me.Submit.TabIndex = 97
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(262, 527)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(82, 28)
        Me.Cancel.TabIndex = 98
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 300
        Me.ToolTip1.ReshowDelay = 100
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(443, 234)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(37, 23)
        Me.Button5.TabIndex = 107
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'WeekDays
        '
        Me.WeekDays.Location = New System.Drawing.Point(262, 227)
        Me.WeekDays.Multiline = True
        Me.WeekDays.Name = "WeekDays"
        Me.WeekDays.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.WeekDays.Size = New System.Drawing.Size(163, 57)
        Me.WeekDays.TabIndex = 95
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"Sunday,", "Monday,", "Tuesday,", "Wednesday,", "Thursday,", "Friday,", "Saturday"})
        Me.ListBox1.Location = New System.Drawing.Point(486, 186)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(106, 148)
        Me.ListBox1.TabIndex = 106
        Me.ListBox1.Visible = False
        '
        'Destination
        '
        Me.Destination.Location = New System.Drawing.Point(262, 178)
        Me.Destination.Name = "Destination"
        Me.Destination.Size = New System.Drawing.Size(121, 20)
        Me.Destination.TabIndex = 94
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(139, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Destination"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(971, 495)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 28)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "GetData"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SectorIDDataGridViewTextBoxColumn, Me.SourceDataGridViewTextBoxColumn, Me.DestinationDataGridViewTextBoxColumn, Me.WeekdaysDataGridViewTextBoxColumn, Me.FirstClassFareDataGridViewTextBoxColumn, Me.BusinessClassFareDataGridViewTextBoxColumn, Me.EconomyClassFareDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SectorBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(613, 166)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(508, 193)
        Me.DataGridView1.TabIndex = 104
        '
        'SectorIDDataGridViewTextBoxColumn
        '
        Me.SectorIDDataGridViewTextBoxColumn.DataPropertyName = "SectorID"
        Me.SectorIDDataGridViewTextBoxColumn.HeaderText = "SectorID"
        Me.SectorIDDataGridViewTextBoxColumn.Name = "SectorIDDataGridViewTextBoxColumn"
        Me.SectorIDDataGridViewTextBoxColumn.Width = 74
        '
        'SourceDataGridViewTextBoxColumn
        '
        Me.SourceDataGridViewTextBoxColumn.DataPropertyName = "Source"
        Me.SourceDataGridViewTextBoxColumn.HeaderText = "Source"
        Me.SourceDataGridViewTextBoxColumn.Name = "SourceDataGridViewTextBoxColumn"
        Me.SourceDataGridViewTextBoxColumn.Width = 66
        '
        'DestinationDataGridViewTextBoxColumn
        '
        Me.DestinationDataGridViewTextBoxColumn.DataPropertyName = "Destination"
        Me.DestinationDataGridViewTextBoxColumn.HeaderText = "Destination"
        Me.DestinationDataGridViewTextBoxColumn.Name = "DestinationDataGridViewTextBoxColumn"
        Me.DestinationDataGridViewTextBoxColumn.Width = 85
        '
        'WeekdaysDataGridViewTextBoxColumn
        '
        Me.WeekdaysDataGridViewTextBoxColumn.DataPropertyName = "Weekdays"
        Me.WeekdaysDataGridViewTextBoxColumn.HeaderText = "Weekdays"
        Me.WeekdaysDataGridViewTextBoxColumn.Name = "WeekdaysDataGridViewTextBoxColumn"
        Me.WeekdaysDataGridViewTextBoxColumn.Width = 83
        '
        'FirstClassFareDataGridViewTextBoxColumn
        '
        Me.FirstClassFareDataGridViewTextBoxColumn.DataPropertyName = "FirstClassFare"
        Me.FirstClassFareDataGridViewTextBoxColumn.HeaderText = "FirstClassFare"
        Me.FirstClassFareDataGridViewTextBoxColumn.Name = "FirstClassFareDataGridViewTextBoxColumn"
        Me.FirstClassFareDataGridViewTextBoxColumn.Width = 97
        '
        'BusinessClassFareDataGridViewTextBoxColumn
        '
        Me.BusinessClassFareDataGridViewTextBoxColumn.DataPropertyName = "BusinessClassFare"
        Me.BusinessClassFareDataGridViewTextBoxColumn.HeaderText = "BusinessClassFare"
        Me.BusinessClassFareDataGridViewTextBoxColumn.Name = "BusinessClassFareDataGridViewTextBoxColumn"
        Me.BusinessClassFareDataGridViewTextBoxColumn.Width = 120
        '
        'EconomyClassFareDataGridViewTextBoxColumn
        '
        Me.EconomyClassFareDataGridViewTextBoxColumn.DataPropertyName = "EconomyClassFare"
        Me.EconomyClassFareDataGridViewTextBoxColumn.HeaderText = "EconomyClassFare"
        Me.EconomyClassFareDataGridViewTextBoxColumn.Name = "EconomyClassFareDataGridViewTextBoxColumn"
        Me.EconomyClassFareDataGridViewTextBoxColumn.Width = 122
        '
        'SectorBindingSource
        '
        Me.SectorBindingSource.DataMember = "Sector"
        Me.SectorBindingSource.DataSource = Me.AirlineReservationSystemDataSet
        '
        'AirlineReservationSystemDataSet
        '
        Me.AirlineReservationSystemDataSet.DataSetName = "AirlineReservationSystemDataSet"
        Me.AirlineReservationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NewRecord
        '
        Me.NewRecord.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NewRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecord.Location = New System.Drawing.Point(539, 495)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(82, 28)
        Me.NewRecord.TabIndex = 99
        Me.NewRecord.Text = "New"
        Me.NewRecord.UseVisualStyleBackColor = False
        '
        'SectorTableAdapter
        '
        Me.SectorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AircraftTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CancelReservationTableAdapter = Nothing
        Me.TableAdapterManager.CollectionsTableAdapter = Nothing
        Me.TableAdapterManager.FlightsTableAdapter = Nothing
        Me.TableAdapterManager.RefundsTableAdapter = Nothing
        Me.TableAdapterManager.ReservationsTableAdapter = Nothing
        Me.TableAdapterManager.ScheduleflightsTableAdapter = Nothing
        Me.TableAdapterManager.SectorTableAdapter = Me.SectorTableAdapter
        Me.TableAdapterManager.UpdateOrder = airline_ticket_reservation.AirlineReservationSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1073, 495)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 28)
        Me.Button3.TabIndex = 110
        Me.Button3.Text = "Next >>"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'aSector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1213, 599)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.SectorID)
        Me.Controls.Add(Me.Source)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.WeekDays)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Destination)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.NewRecord)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "aSector"
        Me.Text = "Enter Sector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirlineReservationSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BusinessClassFare As System.Windows.Forms.TextBox
    Friend WithEvents EconomyClassFare As System.Windows.Forms.TextBox
    Friend WithEvents FirstClassFare As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents SectorID As System.Windows.Forms.TextBox
    Friend WithEvents Source As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents WeekDays As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Destination As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NewRecord As System.Windows.Forms.Button
    Friend WithEvents AirlineReservationSystemDataSet As airline_ticket_reservation.AirlineReservationSystemDataSet
    Friend WithEvents SectorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SectorTableAdapter As airline_ticket_reservation.AirlineReservationSystemDataSetTableAdapters.SectorTableAdapter
    Friend WithEvents TableAdapterManager As airline_ticket_reservation.AirlineReservationSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SectorIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SourceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DestinationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WeekdaysDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstClassFareDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BusinessClassFareDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EconomyClassFareDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
