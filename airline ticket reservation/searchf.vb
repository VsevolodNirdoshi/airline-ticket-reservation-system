Imports System.Data.SqlClient
Public Class searchf
    Dim con As New SqlConnection
    Dim dt As New DataTable
    Dim adp As SqlDataAdapter
    Private Const ConnectionString As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MY\Documents\Visual Studio 2012\Projects\airline ticket reservation\airline ticket reservation\AirlineReservationSystem.mdf;Integrated Security=True;Connect Timeout=30"
    Private ReadOnly Property Connection() As SqlConnection
        Get
            Dim ConnectionToFetch As New SqlConnection(ConnectionString)
            ConnectionToFetch.Open()
            Return ConnectionToFetch
        End Get
    End Property
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Main.Show()
    End Sub
    Public Function GetData() As DataView
        Dim SelectQry = "SELECT AirlineName,FlightNo,DepartureTime,ArrivalTime,WeekDays FROM aircraft,flights,sector where aircraft.AircraftTypeId=flights.AircraftTypeId and Flights.sectorid=sector.sectorid and Source = '" & Source.Text & "' and Destination = '" & Destination.Text & "'"
        Dim SampleSource As New DataSet
        Dim TableView As DataView
        Try
            Dim SampleCommand As New SqlCommand()
            Dim SampleDataAdapter = New SqlDataAdapter()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = Connection
            SampleDataAdapter.SelectCommand = SampleCommand
            SampleDataAdapter.Fill(SampleSource)
            TableView = SampleSource.Tables(0).DefaultView
        Catch ex As Exception
            Throw ex
        End Try
        Return TableView
    End Function
    Sub populatesource()
        Dim conn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MY\Documents\Visual Studio 2012\Projects\airline ticket reservation\airline ticket reservation\AirlineReservationSystem.mdf;Integrated Security=True;Connect Timeout=30")

        conn.Open()

        Dim sql As New SqlCommand("Select distinct Source from Sector", conn)
        sql.CommandType = CommandType.Text

        Dim adapt As New SqlDataAdapter
        adapt.SelectCommand = sql
        adapt.SelectCommand.ExecuteNonQuery()

        Dim dset As New DataSet
        adapt.Fill(dset, "Sector")

        conn.Close()
        Source.DataSource = dset.Tables("sector")
        Source.DisplayMember = "source"
        Source.ValueMember = "source"

    End Sub
    Sub populatedestination()
        Dim conn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MY\Documents\Visual Studio 2012\Projects\airline ticket reservation\airline ticket reservation\AirlineReservationSystem.mdf;Integrated Security=True;Connect Timeout=30")

        conn.Open()

        Dim sql As New SqlCommand("Select distinct destination from sector", conn)
        sql.CommandType = CommandType.Text

        Dim adapt As New SqlDataAdapter
        adapt.SelectCommand = sql
        adapt.SelectCommand.ExecuteNonQuery()

        Dim dset As New DataSet
        adapt.Fill(dset, "sector")

        conn.Close()
        Destination.DataSource = dset.Tables("sector")
        Destination.DisplayMember = "destination"
        Destination.ValueMember = "destination"

    End Sub

    Private Sub Search_Flight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Visible = False
        populatesource()
        populatedestination()
        Source.Text = "select"
        Destination.Text = "select"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Visible = True
        DataGridView1.DataSource = GetData()
    End Sub
    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Button1, "Serach flights between entered two locations")
    End Sub
    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Button1, "For exit")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        fno.Text = selectedRow.Cells(1).Value.ToString()
    End Sub

    Private Sub fno_TextChanged(sender As Object, e As EventArgs) Handles fno.TextChanged
        fno.ReadOnly = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Reservation.Show()
        Reservation.FlightNo.Text = fno.Text
    End Sub
End Class