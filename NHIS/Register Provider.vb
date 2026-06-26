Public Class frmRegisterProvider
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles txtProviderID.Leave
        If Not isRequired(txtProviderID.Text) Then
            ShakeControl(txtProviderID)
            txtProviderID.Focus()
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles txtProviderName.Leave
        If Not isValidName(txtProviderName.Text) Then
            ShakeControl(txtProviderName)
            txtProviderName.Focus()
        End If
    End Sub

    Private Sub ComboBox1_Leave(sender As Object, e As EventArgs) Handles cboProviderType.Leave
        If Not isRequired(cboProviderType.Text) Then
            ShakeControl(cboProviderType)
            cboProviderType.Focus()
        End If
    End Sub

    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles txtLincense.Leave
        If Not isRequired(txtLincense.Text) Then
            ShakeControl(txtLincense)
            txtLincense.Focus()
        End If
    End Sub

    Private Sub TextBox14_Leave(sender As Object, e As EventArgs) Handles txtNHISAccreditation.Leave
        If Not isRequired(txtNHISAccreditation.Text) Then
            ShakeControl(txtNHISAccreditation)
            txtNHISAccreditation.Focus()
        End If
    End Sub

    Private Sub ComboBox2_Leave(sender As Object, e As EventArgs) Handles cboRegion.Leave
        If Not isRequired(cboRegion.Text) Then
            ShakeControl(cboRegion)
            cboRegion.Focus()
        End If
    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles txtDistrict.Leave
        If Not isRequired(txtDistrict.Text) Then
            ShakeControl(txtDistrict)
            txtDistrict.Focus()
        End If
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles txtCityTown.Leave
        If Not isRequired(txtCityTown.Text) Then
            ShakeControl(txtCityTown)
            txtCityTown.Focus()
        End If
    End Sub

    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles txtGPSAddress.Leave
        If Not isRequired(txtGPSAddress.Text) Then
            ShakeControl(txtGPSAddress)
            txtGPSAddress.Focus()
        End If
    End Sub

    Private Sub TextBox7_Leave(sender As Object, e As EventArgs) Handles txtPhone.Leave
        If Not isValidPhone(txtPhone.Text) Then
            ShakeControl(txtPhone)
            txtPhone.Focus()
        End If
    End Sub

    Private Sub TextBox8_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If Not isValidEmail(txtEmail.Text) Then
            ShakeControl(txtEmail)
            txtEmail.Focus()
        End If
    End Sub

    Private Sub TextBox10_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If Not isRequired(txtUsername.Text) Then
            ShakeControl(txtUsername)
            txtUsername.Focus()
        End If
    End Sub

    Private Sub TextBox11_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If Not isRequired(txtPassword.Text) Then
            ShakeControl(txtPassword)
            txtPassword.Focus()
        End If
    End Sub

    Private Sub TextBox12_Leave(sender As Object, e As EventArgs) Handles txtComfirmPassword.Leave
        If Not isRequired(txtComfirmPassword.Text) Then
            ShakeControl(txtComfirmPassword)
            txtComfirmPassword.Focus()
        End If
    End Sub

    Private Sub TextBox13_Leave(sender As Object, e As EventArgs) Handles txtRole.Leave
        If Not isRequired(txtRole.Text) Then
            ShakeControl(txtRole)
            txtRole.Focus()
        End If
    End Sub

    Private Sub ComboBox4_Leave(sender As Object, e As EventArgs) Handles cboStatus.Leave
        If Not isRequired(cboStatus.Text) Then
            ShakeControl(cboStatus)
            cboStatus.Focus()
        End If
    End Sub

    Private Sub frmRegisterProvider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isFormComplete(Me) Then
            btnSave.Enabled = False
        End If
    End Sub
End Class