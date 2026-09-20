Public Class admin

    Private Sub AircraftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AircraftToolStripMenuItem.Click
        aaircraft.Show()
    End Sub

    Private Sub SectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectorToolStripMenuItem.Click
        aSector.Show()
    End Sub

    Private Sub FlightsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlightsToolStripMenuItem.Click
        AFlight.Show()
    End Sub

    Private Sub AirlineScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AirlineScheduleToolStripMenuItem.Click
        aScheduleFlight.Show()
    End Sub

    Private Sub ReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationToolStripMenuItem.Click
        acollection.Show()
    End Sub

    Private Sub CancellationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancellationToolStripMenuItem.Click
        aRefund.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class