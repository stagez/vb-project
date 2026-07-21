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

        Using conn As New MySqlConnection(My.Settings.dbConStr)
            Dim query As String = "SELECT * FROM users WHERE full_name ='" & txtUsername.Text & "'"
            Dim cmd As New MySqlCommand(query, conn)

            'cmd.Parameters.AddWithValue("@name", txtName.Text)
            'cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            'cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
            'cmd.Parameters.AddWithValue("@role", cboRole.SelectedText)
            'cmd.Parameters.AddWithValue("@password", hashed)

            Try
                conn.Open()
                Dim dR As MySqlDataReader
                dR = cmd.ExecuteReader
                If dR.HasRows Then
                    While dR.Read
                        role = dR(4)
                        hashedPassword = dR(5)
                        If hashedPassword IsNot Nothing AndAlso VerifyPassword(txtPassword.Text, hashedPassword) Then
                            If role = "Administrator" Then
                                MsgBox("Login successful" + vbCr + "You have admin access")
                                Me.Hide()
                                frmMain.Show()
                            End If


                        End If
                    End While
                End If

                MessageBox.Show("User added successfully")
            Catch ex As Exception
                MessageBox.Show("Could not add user" & ex.Message)

            End Try
        End Using


        If String.IsNullOrWhiteSpace(txtUsername.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            lblWrongCredentials.Text = "Please enter both username and password."
            lblWrongCredentials.Visible = True
            Highlight(txtUsername)
            Highlight(txtPassword)
            Return
        Else
            ' Simulate credential check (replace with real authentication logic)
            If _users.ContainsKey(txtUsername.Text) AndAlso _users(txtUsername.Text) = txtPassword.Text Then
                frmMain.Show()
                txtPassword.Clear()
                txtUsername.Clear()
                Me.Hide()
                txtUsername.Focus()
            Else
                lblWrongCredentials.Text = "Invalid username or password."
                lblWrongCredentials.Visible = True
                Highlight(txtUsername)
                Highlight(txtPassword)
            End If




        End If

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
