<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GeneralEnqueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AircraftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlightsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AirlineScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AirlineTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancellationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralEnqueryToolStripMenuItem, Me.AirlineScheduleToolStripMenuItem, Me.AirlineTicketToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(988, 36)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GeneralEnqueryToolStripMenuItem
        '
        Me.GeneralEnqueryToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.GeneralEnqueryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AircraftToolStripMenuItem, Me.SectorToolStripMenuItem, Me.FlightsToolStripMenuItem})
        Me.GeneralEnqueryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralEnqueryToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.GeneralEnqueryToolStripMenuItem.Name = "GeneralEnqueryToolStripMenuItem"
        Me.GeneralEnqueryToolStripMenuItem.Size = New System.Drawing.Size(205, 32)
        Me.GeneralEnqueryToolStripMenuItem.Text = "Add Airline Detail"
        '
        'AircraftToolStripMenuItem
        '
        Me.AircraftToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AircraftToolStripMenuItem.Image = CType(resources.GetObject("AircraftToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AircraftToolStripMenuItem.Name = "AircraftToolStripMenuItem"
        Me.AircraftToolStripMenuItem.Size = New System.Drawing.Size(160, 32)
        Me.AircraftToolStripMenuItem.Text = "Aircraft"
        '
        'SectorToolStripMenuItem
        '
        Me.SectorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.SectorToolStripMenuItem.Image = CType(resources.GetObject("SectorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SectorToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.SectorToolStripMenuItem.Name = "SectorToolStripMenuItem"
        Me.SectorToolStripMenuItem.Size = New System.Drawing.Size(160, 32)
        Me.SectorToolStripMenuItem.Text = "Sector"
        '
        'FlightsToolStripMenuItem
        '
        Me.FlightsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FlightsToolStripMenuItem.Image = CType(resources.GetObject("FlightsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FlightsToolStripMenuItem.Name = "FlightsToolStripMenuItem"
        Me.FlightsToolStripMenuItem.Size = New System.Drawing.Size(160, 32)
        Me.FlightsToolStripMenuItem.Text = "Flights"
        '
        'AirlineScheduleToolStripMenuItem
        '
        Me.AirlineScheduleToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AirlineScheduleToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AirlineScheduleToolStripMenuItem.Name = "AirlineScheduleToolStripMenuItem"
        Me.AirlineScheduleToolStripMenuItem.Size = New System.Drawing.Size(237, 32)
        Me.AirlineScheduleToolStripMenuItem.Text = "Add Airline Schedule"
        '
        'AirlineTicketToolStripMenuItem
        '
        Me.AirlineTicketToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AirlineTicketToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservationToolStripMenuItem, Me.CancellationToolStripMenuItem})
        Me.AirlineTicketToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AirlineTicketToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AirlineTicketToolStripMenuItem.Name = "AirlineTicketToolStripMenuItem"
        Me.AirlineTicketToolStripMenuItem.Size = New System.Drawing.Size(157, 32)
        Me.AirlineTicketToolStripMenuItem.Text = "Airline Ticket"
        '
        'ReservationToolStripMenuItem
        '
        Me.ReservationToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ReservationToolStripMenuItem.Image = CType(resources.GetObject("ReservationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
        Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(186, 32)
        Me.ReservationToolStripMenuItem.Text = "Collection"
        '
        'CancellationToolStripMenuItem
        '
        Me.CancellationToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.CancellationToolStripMenuItem.Image = CType(resources.GetObject("CancellationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CancellationToolStripMenuItem.Name = "CancellationToolStripMenuItem"
        Me.CancellationToolStripMenuItem.Size = New System.Drawing.Size(186, 32)
        Me.CancellationToolStripMenuItem.Text = "Refund"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(106, 32)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(988, 454)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "admin"
        Me.Text = "Admin Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GeneralEnqueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AircraftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlightsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AirlineScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AirlineTicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancellationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
