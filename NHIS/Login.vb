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
          Dim query As String = "SELECT id, name, email, phone, role, password FROM users WHERE name = @name"
          Dim cmd As New MySqlCommand(query, conn)
          cmd.Parameters.AddWithValue("@name", txtUsername.Text)

          Try
              conn.Open()
              Dim dR As MySqlDataReader = cmd.ExecuteReader()

              If dR.HasRows Then
                  dR.Read()
                  Dim storedRole As String = dR("role").ToString()
                  Dim storedHash As String = dR("password").ToString()

                  dR.Close() ' close reader before showing UI / using conn further

                  If VerifyPassword(txtPassword.Text, storedHash) Then
                      If storedRole = "Administrator" Then
                          MsgBox("Login successful" & vbCrLf & "You have admin access")
                          Me.Hide()
                      frmMain.Show()
                  Else
                      MsgBox("Login successful" & vbCrLf & "Standard user access")
                      Me.Hide()
                      frmMain.Show() ' or a different form for non-admins
                  End If
              Else
                  MessageBox.Show("Invalid username or password.")
              End If
          Else
              dR.Close()
              MessageBox.Show("Invalid username or password.")
          End If

      Catch ex As Exception
          MessageBox.Show("Login error: " & ex.Message)
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
