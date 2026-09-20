<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AFlight
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AFlight))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Submit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.AircraftTypeID = New System.Windows.Forms.ComboBox()
        Me.SectorID = New System.Windows.Forms.ComboBox()
        Me.ArrivalTime = New System.Windows.Forms.TextBox()
        Me.FlightNo = New System.Windows.Forms.TextBox()
        Me.DepartureTime = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 300
        Me.ToolTip1.ReshowDelay = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(424, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 33)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "ADD FLIGHT"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(252, 399)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 28)
        Me.Button2.TabIndex = 107
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(136, 399)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(82, 28)
        Me.Cancel.TabIndex = 100
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Submit
        '
        Me.Submit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(441, 95)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(82, 28)
        Me.Submit.TabIndex = 99
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
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
        Me.DataGridView1.Location = New System.Drawing.Point(441, 150)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(610, 198)
        Me.DataGridView1.TabIndex = 106
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.Location = New System.Drawing.Point(759, 399)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(82, 28)
        Me.Edit.TabIndex = 104
        Me.Edit.Text = "Update"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(869, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 28)
        Me.Button1.TabIndex = 105
        Me.Button1.Text = "Get Data"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(652, 399)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(82, 28)
        Me.Delete.TabIndex = 103
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.Location = New System.Drawing.Point(542, 399)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(82, 28)
        Me.Add.TabIndex = 102
        Me.Add.Text = "Save"
        Me.Add.UseVisualStyleBackColor = False
        '
        'NewRecord
        '
        Me.NewRecord.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NewRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecord.Location = New System.Drawing.Point(441, 399)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(82, 28)
        Me.NewRecord.TabIndex = 101
        Me.NewRecord.Text = "New"
        Me.NewRecord.UseVisualStyleBackColor = False
        '
        'AircraftTypeID
        '
        Me.AircraftTypeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.AircraftTypeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AircraftTypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AircraftTypeID.FormattingEnabled = True
        Me.AircraftTypeID.Location = New System.Drawing.Point(283, 273)
        Me.AircraftTypeID.Name = "AircraftTypeID"
        Me.AircraftTypeID.Size = New System.Drawing.Size(121, 21)
        Me.AircraftTypeID.TabIndex = 96
        '
        'SectorID
        '
        Me.SectorID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SectorID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SectorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SectorID.FormattingEnabled = True
        Me.SectorID.Location = New System.Drawing.Point(283, 327)
        Me.SectorID.Name = "SectorID"
        Me.SectorID.Size = New System.Drawing.Size(121, 21)
        Me.SectorID.TabIndex = 98
        '
        'ArrivalTime
        '
        Me.ArrivalTime.Location = New System.Drawing.Point(283, 226)
        Me.ArrivalTime.Name = "ArrivalTime"
        Me.ArrivalTime.Size = New System.Drawing.Size(121, 20)
        Me.ArrivalTime.TabIndex = 95
        '
        'FlightNo
        '
        Me.FlightNo.Location = New System.Drawing.Point(283, 100)
        Me.FlightNo.Multiline = True
        Me.FlightNo.Name = "FlightNo"
        Me.FlightNo.Size = New System.Drawing.Size(121, 20)
        Me.FlightNo.TabIndex = 91
        '
        'DepartureTime
        '
        Me.DepartureTime.Location = New System.Drawing.Point(283, 175)
        Me.DepartureTime.Name = "DepartureTime"
        Me.DepartureTime.Size = New System.Drawing.Size(121, 20)
        Me.DepartureTime.TabIndex = 92
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(118, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Sector ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 16)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Aircraft Type ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Departure Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Arrival Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Flight No."
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(969, 399)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 28)
        Me.Button3.TabIndex = 109
        Me.Button3.Text = "Next >>"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'AFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1085, 512)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.NewRecord)
        Me.Controls.Add(Me.AircraftTypeID)
        Me.Controls.Add(Me.SectorID)
        Me.Controls.Add(Me.ArrivalTime)
        Me.Controls.Add(Me.FlightNo)
        Me.Controls.Add(Me.DepartureTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AFlight"
        Me.Text = "Enter flight details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents NewRecord As System.Windows.Forms.Button
    Friend WithEvents AircraftTypeID As System.Windows.Forms.ComboBox
    Friend WithEvents SectorID As System.Windows.Forms.ComboBox
    Friend WithEvents ArrivalTime As System.Windows.Forms.TextBox
    Friend WithEvents FlightNo As System.Windows.Forms.TextBox
    Friend WithEvents DepartureTime As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
