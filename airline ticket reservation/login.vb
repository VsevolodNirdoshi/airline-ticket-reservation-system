Imports System.Data.SqlClient
Public Class Login
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles log.Click
        If Username.Text = "1" And Password.Text = "1" Then
            MessageBox.Show("Login Successfully")
            Me.Hide()
            admin.Show()
            Username.Clear()
            Password.Clear()
        Else
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MY\Documents\Visual Studio 2012\Projects\airline ticket reservation\airline ticket reservation\AirlineReservationSystem.mdf;Integrated Security=True;Connect Timeout=30"
            Dim objcon As SqlConnection = Nothing
            Dim objcmd As SqlCommand = Nothing

            Try
                objcon = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MY\Documents\Visual Studio 2012\Projects\airline ticket reservation\airline ticket reservation\AirlineReservationSystem.mdf;Integrated Security=True;Connect Timeout=30")
                objcon.Open()
                Dim stmt As String = " select * from register where email ='" & Username.Text & "' AND pass ='" & Password.Text & "' "
                objcmd = New SqlCommand(stmt, objcon)
                Dim reader As SqlDataReader = objcmd.ExecuteReader
                If reader.Read Then
                    MessageBox.Show("Login Successfully")
                    Me.Hide()
                    Main.Show()
                    Username.Clear()
                    Password.Clear()
                Else
                    MessageBox.Show("Invalid Login Please Check!")
                    Username.Clear()
                    Password.Clear()
                End If
            Catch ex As Exception
                MsgBox("MMSQL ERROR")
            End Try
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signup.Click
        Me.Close()
        sign.Show()
    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged

    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub
End Class
