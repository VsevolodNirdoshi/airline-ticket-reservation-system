<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print_cancle_ticket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(print_cancle_ticket))
        Me.txtPrint = New System.Windows.Forms.RichTextBox()
        Me.prndocPrintTicket = New System.Drawing.Printing.PrintDocument()
        Me.prndlgPrintTicket = New System.Windows.Forms.PrintDialog()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPrint
        '
        Me.txtPrint.Location = New System.Drawing.Point(96, 111)
        Me.txtPrint.Name = "txtPrint"
        Me.txtPrint.Size = New System.Drawing.Size(716, 370)
        Me.txtPrint.TabIndex = 74
        Me.txtPrint.Text = ""
        '
        'prndocPrintTicket
        '
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
        Me.Label15.Location = New System.Drawing.Point(318, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(353, 39)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "CANCLE TICKET PRINT"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(528, 525)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 28)
        Me.Button2.TabIndex = 73
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(301, 525)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 28)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "&Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'print_cancle_ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(937, 605)
        Me.Controls.Add(Me.txtPrint)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "print_cancle_ticket"
        Me.Text = "print_cancle_ticket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPrint As System.Windows.Forms.RichTextBox
    Friend WithEvents prndocPrintTicket As System.Drawing.Printing.PrintDocument
    Friend WithEvents prndlgPrintTicket As System.Windows.Forms.PrintDialog
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
