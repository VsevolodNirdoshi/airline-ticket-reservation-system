Imports System.Data.SqlClient
Public Class acollection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        admin.Show()
    End Sub
Dim rdr As SqlDataReader = Nothing

Dim con As SqlConnection = Nothing

Dim cmd As SqlCommand = Nothing
Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    DataGridView1.Font = New Font("Century Schoolbook", 10, FontStyle.Bold)

        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MY\Documents\Visual Studio 2012\Projects\airline ticket reservation\airline ticket reservation\AirlineReservationSystem.mdf;Integrated Security=True;Connect Timeout=30")

        con.Open()
        cmd = New SqlCommand("select * from Collections where Date between @date And @date1", con)
        cmd.Parameters.Add("@date", SqlDbType.NChar, 30, "date").Value = DateTimePicker1.Value.Date
        cmd.Parameters.Add("@date1", SqlDbType.NChar, 30, "date").Value = DateTimePicker2.Value.Date


        Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim myDataSet As DataSet = New DataSet()

        myDA.Fill(myDataSet, "Collections")

        DataGridView1.DataSource = myDataSet.Tables("Collections").DefaultView
        Dim sum As Double = 0

        For Each r As DataGridViewRow In Me.DataGridView1.Rows
            sum = sum + r.Cells(2).Value

            TextBox1.Text = sum

        Next

        Label3.Text = DataGridView1.RowCount - 1

        con.Close()

    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Dim RowsAffected As Integer = 0

        Dim cb As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MY\Documents\Visual Studio 2012\Projects\airline ticket reservation\airline ticket reservation\AirlineReservationSystem.mdf;Integrated Security=True;Connect Timeout=30"

        con = New SqlConnection(cb)

        con.Open()

        cmd = New SqlCommand("delete from Collections where Date between @date And @date1", con)
        cmd.Parameters.Add("@date", SqlDbType.NChar, 30, "date").Value = DateTimePicker1.Text
        cmd.Parameters.Add("@date1", SqlDbType.NChar, 30, "date").Value = DateTimePicker2.Text



        RowsAffected = cmd.ExecuteNonQuery()
        If RowsAffected > 0 Then
            MsgBox("Successfully Deleted")

        Else
            MsgBox("Record Not Found")
        End If


        cmd.ExecuteReader()
        If con.State = ConnectionState.Open Then

            con.Close()
        End If

        con.Close()

    End Sub

Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
    ToolTip1.IsBalloon = True
    ToolTip1.UseAnimation = True
    ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Button1, "To get data between two dates")
End Sub

Private Sub Delete_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Delete.MouseHover
    ToolTip1.IsBalloon = True
    ToolTip1.UseAnimation = True
    ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Delete, "To delete the records")
End Sub

Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
    ToolTip1.IsBalloon = True
    ToolTip1.UseAnimation = True
    ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Button2, "For Exit")
End Sub

Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

End Sub
End Class