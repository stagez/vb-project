Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using conn As New MySqlConnection(My.Settings.dbConStr)
            Dim query As String = "INSERT INTO fake (name, course, department) VALUES (@name, @course, @department)"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@course", txtCourse.Text)
            cmd.Parameters.AddWithValue("@department", txtDepartment.Text)

            Try
                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show(rowsAffected & " rows added successfully")
            Catch ex As Exception
                MessageBox.Show("Insert failed: " & ex.Message)

            End Try
        End Using
    End Sub
End Class