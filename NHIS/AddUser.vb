Public Class AddUser

    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbAvatar.Region = New Region(New Drawing2D.GraphicsPath())
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, pbAvatar.Width, pbAvatar.Height)
        pbAvatar.Region = New Region(path)
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Dim length = txtPassword.Text.Length
        If length = 0 Then
            pnlStrength.Width = 0
        ElseIf length < 6 Then
            pnlStrength.Width = 80
            pnlStrength.BackColor = Color.FromArgb(192, 80, 77)   ' red - weak
            lblStrength.Text = "Weak"
            lblStrength.ForeColor = Color.FromArgb(192, 80, 77)
        ElseIf length < 10 Then
            pnlStrength.Width = 160
            pnlStrength.BackColor = Color.FromArgb(230, 162, 60)  ' amber - fair
            lblStrength.Text = "Fair"
            lblStrength.ForeColor = Color.FromArgb(230, 162, 60)
        Else
            pnlStrength.Width = 240
            pnlStrength.BackColor = Color.FromArgb(74, 160, 100)  ' green - strong
            lblStrength.Text = "Strong"
            lblStrength.ForeColor = Color.FromArgb(74, 160, 100)
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select Profile Photo"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"
            ofd.Multiselect = False

            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    Dim img As Image = Image.FromFile(ofd.FileName)

                    ' Check file size (max 2MB)
                    Dim fileInfo As New IO.FileInfo(ofd.FileName)
                    If fileInfo.Length > 2 * 1024 * 1024 Then
                        MessageBox.Show("File is too large. Please choose an image under 2MB.",
                                        "File Too Large",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning)
                        Return
                    End If

                    pbAvatar.Image = img
                    pbAvatar.SizeMode = PictureBoxSizeMode.Zoom

                Catch ex As Exception
                    MessageBox.Show("Could not load image. Please try another file.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If Not isValidEmail(txtEmail.Text) Then
            ShakeControl(txtEmail)
            txtEmail.Focus()
        End If
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        If Not isValidName(txtName.Text) Then
            ShakeControl(txtName)
            txtName.Focus()
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If Not isRequired(txtPassword.Text) Then
            ShakeControl(txtPassword)
            txtPassword.Focus()

        End If
    End Sub

    Private Sub txtRepeatPassword_Leave(sender As Object, e As EventArgs) Handles txtRepeatPassword.Leave
        If Not isRequired(txtRepeatPassword.Text) Then
            ShakeControl(txtRepeatPassword)
            txtRepeatPassword.Focus()
        End If
    End Sub

    Private Sub txtPhone_Leave(sender As Object, e As EventArgs) Handles txtPhone.Leave
        If Not isValidPhone(txtPhone.Text) Then
            ShakeControl(txtPhone)
            txtPhone.Focus()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isFormComplete(Me) Then
            MessageBox.Show(
            "Saved Successfully!",
            "Saved",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm(Me)
        txtName.Focus()
    End Sub
End Class