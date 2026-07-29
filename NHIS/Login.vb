Imports MySql.Data.MySqlClient

Public Class frmLogin
    Dim role As String
    Dim hashedPassword As String
    Private ReadOnly _users As New Dictionary(Of String, String) From {
    {"admin", "admin"},
    {"pascal", "stage"},
    {"gomez", "juan"},
    {"emmanuel", "emma"},
    {"eric", "eric"}
}

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        txtUsername.Focus()

        btnLogin.FlatAppearance.BorderSize = 0
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            lblWrongCredentials.Text = "Please enter both username and password."
            lblWrongCredentials.Visible = True
            Highlight(txtUsername)
            Highlight(txtPassword)
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()
        ' 2. Database Authentication
        Using conn As New MySqlConnection(My.Settings.dbConStrRemote)
            Dim query As String = "SELECT role, password FROM users WHERE full_name = @name"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", txtUsername.Text.Trim())

            Try
                conn.Open()
                Using dR As MySqlDataReader = cmd.ExecuteReader()
                    If dR.Read() Then
                        ' Read values safely
                        Dim storedRole As String = dR("role").ToString()
                        Dim storedHash As String = dR("password").ToString()

                        ' Verify password
                        If VerifyPassword(txtPassword.Text, storedHash) Then
                            MessageBox.Show("Login successful!" & vbCrLf & "Role: " & storedRole)

                            txtPassword.Clear()
                            txtUsername.Clear()
                            lblWrongCredentials.Visible = False

                            Me.Hide()
                            frmMain.Show()
                        Else
                            lblWrongCredentials.Text = "Invalid username or password."
                            lblWrongCredentials.Visible = True
                            Highlight(txtUsername)
                            Highlight(txtPassword)
                        End If
                    Else
                        lblWrongCredentials.Text = "Invalid username or password."
                        lblWrongCredentials.Visible = True
                        Highlight(txtUsername)
                        Highlight(txtPassword)
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Login error: " & ex.Message)
            Finally
                Me.Cursor = Cursors.Default
            End Try
        End Using
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If Not isRequired(txtPassword.Text) Then
            ShakeControl(txtPassword)
        End If
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If Not isRequired(txtUsername.Text) Then
            ShakeControl(txtUsername)
        End If
    End Sub
End Class
