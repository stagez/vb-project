Public Class frmLogin
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

        btnLogin.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

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
            If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
                MDIMain.Show()
                Me.Hide()
            Else
                lblWrongCredentials.Text = "Invalid username or password."
                lblWrongCredentials.Visible = True
                ShakeControl(txtUsername)
                ShakeControl(txtPassword)
            End If


        End If

    End Sub
End Class
