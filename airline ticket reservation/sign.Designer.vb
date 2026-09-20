<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sign))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.pn = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.reg = New System.Windows.Forms.Button()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(275, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(138, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(158, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(113, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(138, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(153, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Email ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(143, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Password"
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(244, 136)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(195, 20)
        Me.fname.TabIndex = 7
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(244, 173)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(195, 20)
        Me.lname.TabIndex = 8
        '
        'pn
        '
        Me.pn.Location = New System.Drawing.Point(244, 242)
        Me.pn.Name = "pn"
        Me.pn.Size = New System.Drawing.Size(195, 20)
        Me.pn.TabIndex = 10
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(244, 276)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(195, 20)
        Me.email.TabIndex = 11
        '
        'reg
        '
        Me.reg.Image = CType(resources.GetObject("reg.Image"), System.Drawing.Image)
        Me.reg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.reg.Location = New System.Drawing.Point(364, 358)
        Me.reg.Name = "reg"
        Me.reg.Size = New System.Drawing.Size(84, 23)
        Me.reg.TabIndex = 13
        Me.reg.Text = "Sign Up"
        Me.reg.UseVisualStyleBackColor = True
        '
        'gender
        '
        Me.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.gender.Location = New System.Drawing.Point(244, 207)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(195, 21)
        Me.gender.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(265, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(244, 310)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(195, 20)
        Me.pass.TabIndex = 12
        '
        'sign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(594, 411)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.reg)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.pn)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "sign"
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents fname As System.Windows.Forms.TextBox
    Friend WithEvents lname As System.Windows.Forms.TextBox
    Friend WithEvents pn As System.Windows.Forms.TextBox
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents reg As System.Windows.Forms.Button
    Friend WithEvents gender As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pass As System.Windows.Forms.TextBox
End Class
