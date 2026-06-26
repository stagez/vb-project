Public Class frmLogin
    Private ReadOnly _users As New Dictionary(Of String, String) From {
    {"admin", "admin"},
    {"pascal", "stage"},
    {"gomez", "juan"},
    {"emmanuel", "emma"},
    {"eric", "eric"}
}
    Private Async Sub ShakeControl(ctrl As Control)
        Dim originalLeft = ctrl.Left
        Dim originalBack = ctrl.BackColor

        ctrl.BackColor = Color.FromArgb(255, 220, 220) ' light red tint

        Dim moves = {-6, 6, -5, 5, -3, 3, -1, 1}
        For Each offset In moves
            ctrl.Left = originalLeft + offset
            Await Task.Delay(30)
        Next

        ctrl.Left = originalLeft
        Await Task.Delay(300)
        ctrl.BackColor = originalBack
    End Sub
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        txtUsername.Focus()

        btnLogin.FlatAppearance.BorderSize = 0
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            lblWrongCredentials.Text = "Please enter both username and password."
            lblWrongCredentials.Visible = True
            ShakeControl(txtUsername)
            ShakeControl(txtPassword)
            Return
        Else
            ' Simulate credential check (replace with real authentication logic)
            If _users.ContainsKey(txtUsername.Text) AndAlso _users(txtUsername.Text) = txtPassword.Text Then
                frmMain.Show()
                txtPassword.Clear()
                txtUsername.Clear()
                Me.Hide()
            Else
                lblWrongCredentials.Text = "Invalid username or password."
                lblWrongCredentials.Visible = True
                ShakeControl(txtUsername)
                ShakeControl(txtPassword)
            End If


        End If

    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If Not isRequired(txtPassword.Text) Then
            ShakeControl(txtPassword)
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If Not isRequired(txtUsername.Text) Then
            ShakeControl(txtUsername)
            txtUsername.Focus()
        End If
    End Sub
End Class
