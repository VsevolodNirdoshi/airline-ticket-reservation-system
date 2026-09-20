<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_ticket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Print_ticket))
        Me.prndocPrintTicket = New System.Drawing.Printing.PrintDocument()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.prndlgPrintTicket = New System.Windows.Forms.PrintDialog()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPrint = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'prndocPrintTicket
        '
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(561, 531)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 28)
        Me.Button2.TabIndex = 73
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'prndlgPrintTicket
        '
        Me.prndlgPrintTicket.Document = Me.prndocPrintTicket
        Me.prndlgPrintTicket.UseEXDialog = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(370, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(224, 39)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "PRINT TICKET"
        '
        'txtPrint
        '
        Me.txtPrint.Location = New System.Drawing.Point(106, 109)
        Me.txtPrint.Name = "txtPrint"
        Me.txtPrint.Size = New System.Drawing.Size(716, 370)
        Me.txtPrint.TabIndex = 74
        Me.txtPrint.Text = ""
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(339, 531)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 28)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "&Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Print_ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(909, 606)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPrint)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Print_ticket"
        Me.Text = "Print_ticket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents prndocPrintTicket As System.Drawing.Printing.PrintDocument
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents prndlgPrintTicket As System.Windows.Forms.PrintDialog
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPrint As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
