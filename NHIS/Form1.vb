Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Theme1.AppBackground
        btnLogin.BackColor = Theme1.AccentPink

        btnLogin.FlatAppearance.BorderSize = 0
    End Sub

End Class
