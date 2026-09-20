<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SearchFlightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancilationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchFlightToolStripMenuItem, Me.ReservationToolStripMenuItem, Me.CancilationToolStripMenuItem, Me.TicketStatusToolStripMenuItem, Me.AboutUsToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MaximumSize = New System.Drawing.Size(941, 50)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(941, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SearchFlightToolStripMenuItem
        '
        Me.SearchFlightToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.SearchFlightToolStripMenuItem.Image = CType(resources.GetObject("SearchFlightToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchFlightToolStripMenuItem.Name = "SearchFlightToolStripMenuItem"
        Me.SearchFlightToolStripMenuItem.Size = New System.Drawing.Size(122, 31)
        Me.SearchFlightToolStripMenuItem.Text = "Search Flight"
        '
        'ReservationToolStripMenuItem
        '
        Me.ReservationToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ReservationToolStripMenuItem.Image = CType(resources.GetObject("ReservationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
        Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(114, 31)
        Me.ReservationToolStripMenuItem.Text = "Reservation"
        '
        'CancilationToolStripMenuItem
        '
        Me.CancilationToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CancilationToolStripMenuItem.Image = CType(resources.GetObject("CancilationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CancilationToolStripMenuItem.Name = "CancilationToolStripMenuItem"
        Me.CancilationToolStripMenuItem.Size = New System.Drawing.Size(119, 31)
        Me.CancilationToolStripMenuItem.Text = "Cancellation"
        '
        'TicketStatusToolStripMenuItem
        '
        Me.TicketStatusToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TicketStatusToolStripMenuItem.Image = CType(resources.GetObject("TicketStatusToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TicketStatusToolStripMenuItem.Name = "TicketStatusToolStripMenuItem"
        Me.TicketStatusToolStripMenuItem.Size = New System.Drawing.Size(120, 31)
        Me.TicketStatusToolStripMenuItem.Text = "Ticket Status"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.AboutUsToolStripMenuItem.Image = CType(resources.GetObject("AboutUsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(98, 31)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LogOutToolStripMenuItem.Image = CType(resources.GetObject("LogOutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(90, 31)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1001, 462)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SearchFlightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancilationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TicketStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
