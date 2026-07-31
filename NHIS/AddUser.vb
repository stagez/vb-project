Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text


Public Class AddUser

    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If Not isFormComplete(Me) Then
        '    btnSave.Enabled = False
        'End If

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Dim password As String = txtPassword.Text
        Dim length As Integer = password.Length

        ' 1. Handle the blank/empty state first
        If length = 0 Then
            pnlStrength.Width = 0
            lblStrength.Text = ""
            Exit Sub
        End If

        ' 2. Calculate Complexity Score
        Dim score As Integer = 0

        ' Length Milestones
        If length >= 8 Then score += 1
        If length >= 12 Then score += 1

        ' Character Types Checks (Regex)
        If Regex.IsMatch(password, "[a-z]") Then score += 1 ' Lowercase
        If Regex.IsMatch(password, "[A-Z]") Then score += 1 ' Uppercase
        If Regex.IsMatch(password, "[0-9]") Then score += 1 ' Numbers
        ' Special Characters
        If Regex.IsMatch(password, "[!@#$%^&*(),.??""{}|<>_+\-=\[\]\\]") Then score += 1


        ' 3. Update the UI based on the score
        Select Case score
            Case 0, 1, 2
                pnlStrength.Width = 60
                pnlStrength.BackColor = Color.FromArgb(192, 80, 77)
                lblStrength.Text = "Weak"
                lblStrength.ForeColor = Color.FromArgb(192, 80, 77)

            Case 3, 4
                pnlStrength.Width = 120
                pnlStrength.BackColor = Color.FromArgb(230, 162, 60)
                lblStrength.Text = "Fair"
                lblStrength.ForeColor = Color.FromArgb(230, 162, 60)

            Case 5, 6
                pnlStrength.Width = 180
                pnlStrength.BackColor = Color.FromArgb(74, 160, 100)
                lblStrength.Text = "Strong"
                lblStrength.ForeColor = Color.FromArgb(74, 160, 100)
        End Select
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
        End If
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        If Not isValidName(txtName.Text) Then
            ShakeControl(txtName)
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If Not isRequired(txtPassword.Text) Then
            ShakeControl(txtPassword)

        End If
    End Sub

    Private Sub txtRepeatPassword_Leave(sender As Object, e As EventArgs) Handles txtRepeatPassword.Leave
        If Not isRequired(txtRepeatPassword.Text) Then
            ShakeControl(txtRepeatPassword)
        End If
    End Sub

    Private Sub txtPhone_Leave(sender As Object, e As EventArgs) Handles txtPhone.Leave
        If Not isValidPhone(txtPhone.Text) Then
            ShakeControl(txtPhone)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPassword.Text = txtRepeatPassword.Text Then
            If isFormComplete(Me) Then
                Dim hashed As String = HashedPassword(txtPassword.Text)
                Using conn As New MySqlConnection(My.Settings.dbConStrRemote)
                    Dim query As String = "INSERT INTO users(full_name, email, phone, role, password) VALUES (@name, @email, @phone, @role, @password)"
                    Dim cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                    cmd.Parameters.AddWithValue("@role", cboRole.SelectedItem)
                    cmd.Parameters.AddWithValue("@password", hashed)

                    Try
                        conn.Open()
                        Dim rowsAffected As String = cmd.ExecuteNonQuery()
                        MessageBox.Show("User added successfully")
                    Catch ex As Exception
                        MessageBox.Show("Could not add user" & ex.Message)

                    End Try
                End Using
            Else
                MessageBox.Show("Please complete all highlighted fields before submitting.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
                Exit Sub
            End If
        Else
            lblPasswordMatch.Visible = True
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm(Me)
        txtName.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim main As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
        main.LoadForm(New frmDashboard())
    End Sub

    Private Sub AddUser_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim main As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
            main.LoadForm(New frmDashboard())
        End If
    End Sub
End Class