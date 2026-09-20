<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aScheduleFlight
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aScheduleFlight))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EconomyClassSeatAvailable = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FlightDate = New System.Windows.Forms.DateTimePicker()
        Me.ScheduleID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BusinessClassSeatAvailable = New System.Windows.Forms.TextBox()
        Me.FirstClassSeatAvailable = New System.Windows.Forms.TextBox()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.FlightNo = New System.Windows.Forms.ComboBox()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(456, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(221, 33)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "ADD SCHEDULE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Flight Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Flight No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Schedule ID"
        '
        'EconomyClassSeatAvailable
        '
        Me.EconomyClassSeatAvailable.BackColor = System.Drawing.Color.White
        Me.EconomyClassSeatAvailable.Location = New System.Drawing.Point(165, 119)
        Me.EconomyClassSeatAvailable.Name = "EconomyClassSeatAvailable"
        Me.EconomyClassSeatAvailable.ReadOnly = True
        Me.EconomyClassSeatAvailable.Size = New System.Drawing.Size(100, 22)
        Me.EconomyClassSeatAvailable.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(279, 455)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 28)
        Me.Button2.TabIndex = 104
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FlightDate
        '
        Me.FlightDate.Location = New System.Drawing.Point(199, 224)
        Me.FlightDate.Name = "FlightDate"
        Me.FlightDate.Size = New System.Drawing.Size(134, 20)
        Me.FlightDate.TabIndex = 94
        '
        'ScheduleID
        '
        Me.ScheduleID.Location = New System.Drawing.Point(199, 150)
        Me.ScheduleID.Name = "ScheduleID"
        Me.ScheduleID.Size = New System.Drawing.Size(134, 20)
        Me.ScheduleID.TabIndex = 91
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.EconomyClassSeatAvailable)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BusinessClassSeatAvailable)
        Me.GroupBox1.Controls.Add(Me.FirstClassSeatAvailable)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(101, 267)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 153)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seats Available"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(46, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "First Class"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(46, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Economy Class"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(46, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Business Class"
        '
        'BusinessClassSeatAvailable
        '
        Me.BusinessClassSeatAvailable.BackColor = System.Drawing.Color.White
        Me.BusinessClassSeatAvailable.Location = New System.Drawing.Point(165, 78)
        Me.BusinessClassSeatAvailable.Name = "BusinessClassSeatAvailable"
        Me.BusinessClassSeatAvailable.ReadOnly = True
        Me.BusinessClassSeatAvailable.Size = New System.Drawing.Size(100, 22)
        Me.BusinessClassSeatAvailable.TabIndex = 2
        '
        'FirstClassSeatAvailable
        '
        Me.FirstClassSeatAvailable.BackColor = System.Drawing.Color.White
        Me.FirstClassSeatAvailable.Location = New System.Drawing.Point(165, 34)
        Me.FirstClassSeatAvailable.Name = "FirstClassSeatAvailable"
        Me.FirstClassSeatAvailable.ReadOnly = True
        Me.FirstClassSeatAvailable.Size = New System.Drawing.Size(100, 22)
        Me.FirstClassSeatAvailable.TabIndex = 1
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(675, 455)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(82, 28)
        Me.Delete.TabIndex = 100
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.Location = New System.Drawing.Point(564, 455)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(82, 28)
        Me.Add.TabIndex = 99
        Me.Add.Text = "Save"
        Me.Add.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 300
        Me.ToolTip1.ReshowDelay = 100
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(886, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 28)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "Get Data"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.Location = New System.Drawing.Point(777, 455)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(82, 28)
        Me.Edit.TabIndex = 101
        Me.Edit.Text = "Update"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Submit
        '
        Me.Submit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(370, 145)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(82, 28)
        Me.Submit.TabIndex = 96
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(159, 455)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(82, 28)
        Me.Cancel.TabIndex = 97
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'FlightNo
        '
        Me.FlightNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.FlightNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FlightNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlightNo.FormattingEnabled = True
        Me.FlightNo.Location = New System.Drawing.Point(199, 185)
        Me.FlightNo.Name = "FlightNo"
        Me.FlightNo.Size = New System.Drawing.Size(134, 21)
        Me.FlightNo.TabIndex = 93
        '
        'NewRecord
        '
        Me.NewRecord.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NewRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecord.Location = New System.Drawing.Point(462, 455)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(82, 28)
        Me.NewRecord.TabIndex = 98
        Me.NewRecord.Text = "New"
        Me.NewRecord.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(462, 224)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.Size = New System.Drawing.Size(560, 196)
        Me.DataGridView1.TabIndex = 103
        '
        'aScheduleFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1120, 529)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.FlightDate)
        Me.Controls.Add(Me.ScheduleID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.FlightNo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.NewRecord)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "aScheduleFlight"
        Me.Text = "Schedule Flight"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EconomyClassSeatAvailable As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FlightDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ScheduleID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BusinessClassSeatAvailable As System.Windows.Forms.TextBox
    Friend WithEvents FirstClassSeatAvailable As System.Windows.Forms.TextBox
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents FlightNo As System.Windows.Forms.ComboBox
    Friend WithEvents NewRecord As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
