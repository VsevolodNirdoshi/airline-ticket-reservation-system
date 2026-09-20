Imports System.Data.SqlClient

Public Class sign

    Private Sub reg_Click(sender As Object, e As EventArgs) Handles reg.Click
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MY\Documents\Visual Studio 2012\Projects\airline ticket reservation\airline ticket reservation\AirlineReservationSystem.mdf;Integrated Security=True;Connect Timeout=30"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from register where email='" & email.Text & "' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Email ID Already Registered", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()
                cmd = New SqlCommand("INSERT INTO register values('" & fname.Text & "','" & lname.Text & "','" & gender.Text & "','" & pn.Text & "','" & email.Text & "','" & pass.Text & "')", con)
                If (fname.Text = "" And lname.Text = "" And gender.Text = "" And pn.Text = "" And email.Text = "" And pass.Text = "") Then
                    MessageBox.Show("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Successfully Registered.", MsgBoxStyle.Information, "Success")
                    Me.Hide()
                    Login.Show()
                    fname.Clear()
                    lname.Clear()
                    gender.Text = " "
                    pn.Clear()
                    email.Clear()
                    pass.Clear()

                End If
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Login.Show()
    End Sub
End Class