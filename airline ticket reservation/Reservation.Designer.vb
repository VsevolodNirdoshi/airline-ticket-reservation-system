<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservation))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Destination = New System.Windows.Forms.ComboBox()
        Me.Source = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.SeatPref = New System.Windows.Forms.ComboBox()
        Me.MealPref = New System.Windows.Forms.ComboBox()
        Me.SSR = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Age = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lname = New System.Windows.Forms.TextBox()
        Me.Fname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TravelDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.AirwayClass = New System.Windows.Forms.ComboBox()
        Me.FlightNo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fare = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PnrNo = New System.Windows.Forms.TextBox()
        Me.Rstatus = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PrintTicket = New System.Windows.Forms.Button()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.CheckSeatAvailability = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.Location = New System.Drawing.Point(380, 121)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Submit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(37, 216)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 16)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Destination"
        '
        'Destination
        '
        Me.Destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Destination.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Destination.FormattingEnabled = True
        Me.Destination.Location = New System.Drawing.Point(195, 216)
        Me.Destination.Name = "Destination"
        Me.Destination.Size = New System.Drawing.Size(121, 24)
        Me.Destination.TabIndex = 5
        '
        'Source
        '
        Me.Source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Source.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Source.FormattingEnabled = True
        Me.Source.Location = New System.Drawing.Point(195, 167)
        Me.Source.Name = "Source"
        Me.Source.Size = New System.Drawing.Size(121, 24)
        Me.Source.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(85, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(261, 20)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "*Generate A Security Password"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Gender)
        Me.GroupBox2.Controls.Add(Me.SeatPref)
        Me.GroupBox2.Controls.Add(Me.MealPref)
        Me.GroupBox2.Controls.Add(Me.SSR)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Age)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Lname)
        Me.GroupBox2.Controls.Add(Me.Fname)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(48, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(515, 334)
        Me.GroupBox2.TabIndex = 76
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Passenger Details"
        '
        'Gender
        '
        Me.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.FormattingEnabled = True
        Me.Gender.Location = New System.Drawing.Point(328, 106)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(121, 24)
        Me.Gender.TabIndex = 4
        '
        'SeatPref
        '
        Me.SeatPref.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SeatPref.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatPref.FormattingEnabled = True
        Me.SeatPref.Location = New System.Drawing.Point(228, 153)
        Me.SeatPref.Name = "SeatPref"
        Me.SeatPref.Size = New System.Drawing.Size(121, 24)
        Me.SeatPref.TabIndex = 5
        '
        'MealPref
        '
        Me.MealPref.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MealPref.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MealPref.FormattingEnabled = True
        Me.MealPref.Location = New System.Drawing.Point(228, 198)
        Me.MealPref.Name = "MealPref"
        Me.MealPref.Size = New System.Drawing.Size(121, 24)
        Me.MealPref.TabIndex = 6
        '
        'SSR
        '
        Me.SSR.Location = New System.Drawing.Point(228, 274)
        Me.SSR.Multiline = True
        Me.SSR.Name = "SSR"
        Me.SSR.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SSR.Size = New System.Drawing.Size(177, 45)
        Me.SSR.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(363, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "(Last Name)"
        '
        'Age
        '
        Me.Age.Location = New System.Drawing.Point(100, 111)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(59, 22)
        Me.Age.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(180, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Special Service Request"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(43, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Meal Preference"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(223, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Gender"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(43, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 16)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Seat Preference"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(41, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 16)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Age"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(35, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Passenger"
        '
        'Lname
        '
        Me.Lname.Location = New System.Drawing.Point(328, 30)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(166, 22)
        Me.Lname.TabIndex = 2
        '
        'Fname
        '
        Me.Fname.Location = New System.Drawing.Point(130, 30)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(156, 22)
        Me.Fname.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(154, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "(First Name)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(37, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Source"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TravelDate)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Destination)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Source)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.AirwayClass)
        Me.GroupBox1.Controls.Add(Me.FlightNo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Fare)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(48, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 291)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Flight Details"
        '
        'TravelDate
        '
        Me.TravelDate.Location = New System.Drawing.Point(195, 73)
        Me.TravelDate.Name = "TravelDate"
        Me.TravelDate.Size = New System.Drawing.Size(260, 22)
        Me.TravelDate.TabIndex = 45
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(37, 268)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 16)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "(INR)"
        '
        'AirwayClass
        '
        Me.AirwayClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AirwayClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AirwayClass.FormattingEnabled = True
        Me.AirwayClass.Location = New System.Drawing.Point(195, 121)
        Me.AirwayClass.Name = "AirwayClass"
        Me.AirwayClass.Size = New System.Drawing.Size(121, 24)
        Me.AirwayClass.TabIndex = 3
        '
        'FlightNo
        '
        Me.FlightNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.FlightNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FlightNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlightNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlightNo.FormattingEnabled = True
        Me.FlightNo.Location = New System.Drawing.Point(195, 21)
        Me.FlightNo.Name = "FlightNo"
        Me.FlightNo.Size = New System.Drawing.Size(121, 24)
        Me.FlightNo.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Flight No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Travel Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Class"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fare"
        '
        'Fare
        '
        Me.Fare.BackColor = System.Drawing.Color.White
        Me.Fare.Location = New System.Drawing.Point(195, 261)
        Me.Fare.Name = "Fare"
        Me.Fare.ReadOnly = True
        Me.Fare.Size = New System.Drawing.Size(67, 22)
        Me.Fare.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Location = New System.Drawing.Point(600, 346)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(429, 139)
        Me.GroupBox3.TabIndex = 86
        Me.GroupBox3.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.MintCream
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(323, 102)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 13)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(190, 98)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(120, 20)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.UseSystemPasswordChar = True
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(190, 54)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(120, 20)
        Me.TextBox5.TabIndex = 3
        Me.TextBox5.UseSystemPasswordChar = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(20, 102)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(149, 16)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Re-Enter Password :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(20, 58)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 16)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Password :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(681, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(326, 39)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "RESERVATION FORM"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(615, 490)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(76, 13)
        Me.Label24.TabIndex = 74
        Me.Label24.Text = "*For Privacy"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(609, 303)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(276, 13)
        Me.Label18.TabIndex = 83
        Me.Label18.Text = "* Password Generated on the Reservation Time"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.PnrNo)
        Me.GroupBox5.Controls.Add(Me.Rstatus)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(600, 143)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(503, 154)
        Me.GroupBox5.TabIndex = 77
        Me.GroupBox5.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(187, 69)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(140, 20)
        Me.TextBox2.TabIndex = 49
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(20, 73)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(142, 16)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "*Security Password"
        '
        'PnrNo
        '
        Me.PnrNo.Location = New System.Drawing.Point(187, 22)
        Me.PnrNo.Name = "PnrNo"
        Me.PnrNo.Size = New System.Drawing.Size(141, 20)
        Me.PnrNo.TabIndex = 1
        '
        'Rstatus
        '
        Me.Rstatus.BackColor = System.Drawing.Color.White
        Me.Rstatus.ForeColor = System.Drawing.Color.Red
        Me.Rstatus.Location = New System.Drawing.Point(187, 109)
        Me.Rstatus.Name = "Rstatus"
        Me.Rstatus.ReadOnly = True
        Me.Rstatus.Size = New System.Drawing.Size(141, 20)
        Me.Rstatus.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(28, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 16)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Status"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(375, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Location = New System.Drawing.Point(375, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "Submit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "PNR No."
        '
        'PrintTicket
        '
        Me.PrintTicket.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PrintTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintTicket.Location = New System.Drawing.Point(1139, 375)
        Me.PrintTicket.Name = "PrintTicket"
        Me.PrintTicket.Size = New System.Drawing.Size(98, 45)
        Me.PrintTicket.TabIndex = 82
        Me.PrintTicket.Text = "Print Ticket"
        Me.PrintTicket.UseVisualStyleBackColor = False
        '
        'NewRecord
        '
        Me.NewRecord.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NewRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecord.Location = New System.Drawing.Point(1139, 143)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(98, 46)
        Me.NewRecord.TabIndex = 81
        Me.NewRecord.Text = "New"
        Me.NewRecord.UseVisualStyleBackColor = False
        '
        'CheckSeatAvailability
        '
        Me.CheckSeatAvailability.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CheckSeatAvailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckSeatAvailability.Location = New System.Drawing.Point(1139, 222)
        Me.CheckSeatAvailability.Name = "CheckSeatAvailability"
        Me.CheckSeatAvailability.Size = New System.Drawing.Size(98, 44)
        Me.CheckSeatAvailability.TabIndex = 79
        Me.CheckSeatAvailability.Text = "Check Seat Availability"
        Me.CheckSeatAvailability.UseVisualStyleBackColor = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(1139, 303)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(98, 42)
        Me.Save.TabIndex = 78
        Me.Save.Text = "OK"
        Me.Save.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(1139, 444)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(98, 46)
        Me.cmdExit.TabIndex = 80
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(737, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(241, 19)
        Me.TextBox1.TabIndex = 87
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1285, 676)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.PrintTicket)
        Me.Controls.Add(Me.NewRecord)
        Me.Controls.Add(Me.CheckSeatAvailability)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.cmdExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reservation"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Destination As System.Windows.Forms.ComboBox
    Friend WithEvents Source As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Gender As System.Windows.Forms.ComboBox
    Friend WithEvents SeatPref As System.Windows.Forms.ComboBox
    Friend WithEvents MealPref As System.Windows.Forms.ComboBox
    Friend WithEvents SSR As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Age As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lname As System.Windows.Forms.TextBox
    Friend WithEvents Fname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TravelDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents AirwayClass As System.Windows.Forms.ComboBox
    Friend WithEvents FlightNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Fare As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PnrNo As System.Windows.Forms.TextBox
    Friend WithEvents Rstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PrintTicket As System.Windows.Forms.Button
    Friend WithEvents NewRecord As System.Windows.Forms.Button
    Friend WithEvents CheckSeatAvailability As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
