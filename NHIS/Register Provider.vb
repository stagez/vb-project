Imports MySql.Data.MySqlClient
Public Class frmRegisterProvider
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles txtProviderID.Leave
        If Not isRequired(txtProviderID.Text) Then
            Highlight(txtProviderID)
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles txtProviderName.Leave
        If Not isValidName(txtProviderName.Text) Then
            Highlight(txtProviderName)
        End If
    End Sub

    Private Sub ComboBox1_Leave(sender As Object, e As EventArgs) Handles cboProviderType.Leave
        If Not isRequired(cboProviderType.Text) Then
            ShakeControl(cboProviderType)
        End If
    End Sub

    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles txtLincense.Leave
        If Not isRequired(txtLincense.Text) Then
            Highlight(txtLincense)
        End If
    End Sub

    Private Sub TextBox14_Leave(sender As Object, e As EventArgs) Handles txtNHISAccreditation.Leave
        If Not isRequired(txtNHISAccreditation.Text) Then
            Highlight(txtNHISAccreditation)
        End If
    End Sub

    Private Sub ComboBox2_Leave(sender As Object, e As EventArgs) Handles cboRegion.Leave
        If Not isRequired(cboRegion.Text) Then
            ShakeControl(cboRegion)
        End If
    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles txtDistrict.Leave
        If Not isRequired(txtDistrict.Text) Then
            Highlight(txtDistrict)
        End If
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles txtCityTown.Leave
        If Not isRequired(txtCityTown.Text) Then
            Highlight(txtCityTown)
        End If
    End Sub

    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles txtGPSAddress.Leave
        If Not isRequired(txtGPSAddress.Text) Then
            Highlight(txtGPSAddress)
        End If
    End Sub

    Private Sub TextBox7_Leave(sender As Object, e As EventArgs) Handles txtPhone.Leave
        If Not isValidPhone(txtPhone.Text) Then
            Highlight(txtPhone)
        End If
    End Sub

    Private Sub TextBox8_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If Not isValidEmail(txtEmail.Text) Then
            Highlight(txtEmail)
        End If
    End Sub

    Private Sub TextBox10_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If Not isRequired(txtUsername.Text) Then
            Highlight(txtUsername)
        End If
    End Sub

    Private Sub TextBox11_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If Not isRequired(txtPassword.Text) Then
            Highlight(txtPassword)
        End If
    End Sub

    Private Sub TextBox12_Leave(sender As Object, e As EventArgs) Handles txtComfirmPassword.Leave
        If Not isRequired(txtComfirmPassword.Text) Then
            Highlight(txtComfirmPassword)
        End If
    End Sub

    Private Sub TextBox13_Leave(sender As Object, e As EventArgs) Handles txtRole.Leave
        If Not isRequired(txtRole.Text) Then
            Highlight(txtRole)
        End If
    End Sub

    Private Sub ComboBox4_Leave(sender As Object, e As EventArgs) Handles cboStatus.Leave
        If Not isRequired(cboStatus.Text) Then
            ShakeControl(cboStatus)
        End If
    End Sub

    Private Sub frmRegisterProvider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If Not isFormComplete(Me) Then
        '    btnSave.Enabled = False
        'End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Dim main As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
        main.LoadForm(New frmDashboard())
    End Sub

    Private Sub frmRegisterProvider_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim main As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
            main.LoadForm(New frmDashboard())
        End If
    End Sub

    Private Sub frmRegisterProvider_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim x As Integer = Math.Max(0, (Me.ClientSize.Width - pnlMainContainer.Width) \ 2)
        Dim y As Integer = Math.Max(0, (Me.ClientSize.Height - pnlMainContainer.Height) \ 2)

        pnlMainContainer.Location = New Point(x, y)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using conn As New MySqlConnection(My.Settings.dbConStrRemote)
            Dim query As String = "INSERT INTO Provider(name, type, region, district, GPS, city, email, phone,
                                            license_number, NHIS_accreditation) VALUES(@name, @type, @region,
                                            @district, @GPS, @city, @email, @phone, @license_number, @NHIS)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", txtProviderName.Text)
            cmd.Parameters.AddWithValue("@type", cboProviderType.SelectedItem)
            cmd.Parameters.AddWithValue("@region", cboRegion.SelectedItem)
            cmd.Parameters.AddWithValue("@district", txtDistrict.Text)
            cmd.Parameters.AddWithValue("@GPS", txtGPSAddress.Text)
            cmd.Parameters.AddWithValue("@city", txtCityTown.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@license_number", txtLincense.Text)
            cmd.Parameters.AddWithValue("@NHIS", txtNHISAccreditation.Text)

            Try
                conn.Open()
                Dim hasRows As Integer = cmd.ExecuteNonQuery()
                Me.Cursor = Cursors.WaitCursor
                If hasRows Then
                    MessageBox.Show("Provider added successfully")
                End If
            Catch ex As Exception
                MessageBox.Show("Something bad happend " & ex.Message)
            Finally
                Me.Cursor = DefaultCursor
            End Try

        End Using
    End Sub
End Class