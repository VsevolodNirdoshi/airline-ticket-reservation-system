Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationToolStripMenuItem.Click
        Reservation.Show()
    End Sub

    Private Sub SearchFlightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchFlightToolStripMenuItem.Click
        searchf.Show()
    End Sub

    Private Sub CancilationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancilationToolStripMenuItem.Click
        Cancellation.Show()
    End Sub

    Private Sub TicketStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketStatusToolStripMenuItem.Click
        Ticket_Status.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        About_Us.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class