Public Class RegisterMember
    Private Sub frmRegisterMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpDOB.MaxDate = DateTime.Today


        dtpDOB.MinDate = DateTime.Today.AddYears(-120)

        dtpExpiryDate.Value = DateTime.Today.AddYears(5) ' Set the expiry date to 5 years from today
    End Sub

    Private Sub txtPatientID_Leave(sender As Object, e As EventArgs)
        If Not isRequired(txtPatientID.Text) Then
            ShakeControl(txtPatientID)
            txtPatientID.Focus()
        End If
    End Sub

    Private Sub txtContactName_Leave(sender As Object, e As EventArgs)
        If Not isValidName(txtContactName.Text) Then
            ShakeControl(txtContactName)
            txtContactName.Focus()
        End If
    End Sub

    Private Sub txtDistrict_Leave(sender As Object, e As EventArgs)
        If Not isRequired(txtDistrict.Text) Then
            ShakeControl(txtDistrict)
            txtDistrict.Focus()
        End If
    End Sub

    Private Sub txtEPhoneNumber_Leave(sender As Object, e As EventArgs)
        If Not isValidPhone(txtEPhoneNumber1.Text) Then
            ShakeControl(txtEPhoneNumber1)
            txtEPhoneNumber1.Focus()
        End If
    End Sub

    Private Sub txtRegion_Leave(sender As Object, e As EventArgs)
        If Not isRequired(txtRegion.Text) Then
            ShakeControl(txtRegion)
            txtRegion.Focus()
        End If
    End Sub

    Private Sub txtRelationship_Leave(sender As Object, e As EventArgs)
        If Not isRequired(cboRelationship1.Text) Then
            ShakeControl(cboRelationship1)
            cboRelationship1.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        ClearForm(Me)
    End Sub

    Private Sub txtContactName_Leave_1(sender As Object, e As EventArgs) Handles txtContactName.Leave
        If Not isValidName(txtContactName.Text) Then
            ShakeControl(txtContactName)
            txtContactName.Focus()
        End If
    End Sub


    Private Sub txtCity_Leave(sender As Object, e As EventArgs) Handles txtCity.Leave
        If Not isRequired(txtCity.Text) Then
            ShakeControl(txtCity)
            txtCity.Focus()

        End If
    End Sub

    Private Sub txtDistrict_Leave_1(sender As Object, e As EventArgs) Handles txtDistrict.Leave
        If Not isRequired(txtDistrict.Text) Then
            ShakeControl(txtDistrict)
            txtDistrict.Focus()
        End If
    End Sub

    Private Sub txtPhoneNumber_Leave(sender As Object, e As EventArgs) Handles txtPhoneNumber.Leave
        If Not isValidPhone(txtPhoneNumber.Text) Then
            ShakeControl(txtPhoneNumber)
            txtPhoneNumber.Focus()
        End If
    End Sub

    Private Sub txtNationality_Leave(sender As Object, e As EventArgs) Handles txtNationality.Leave
        If Not isRequired(txtNationality.Text) Then
            ShakeControl(txtNationality)
            txtNationality.Focus()
        End If
    End Sub

    Private Sub txtNHISNumber_Leave(sender As Object, e As EventArgs) Handles txtNHISNumber.Leave
        If Not isRequired(txtNHISNumber.Text) Then
            ShakeControl(txtNHISNumber)
            txtNHISNumber.Focus()
        End If
    End Sub

    Private Sub txtPatientID_Leave_1(sender As Object, e As EventArgs) Handles txtPatientID.Leave
        If Not isRequired(txtPatientID.Text) Then
            ShakeControl(txtPatientID)
            txtPatientID.Focus()
        End If
    End Sub

    Private Sub txtFullName_Leave(sender As Object, e As EventArgs) Handles txtFullName.Leave
        If Not isValidName(txtFullName.Text) Then
            ShakeControl(txtFullName)
            txtFullName.Focus()
        End If
    End Sub

    Private Sub txtEPhoneNumber1_Leave(sender As Object, e As EventArgs) Handles txtEPhoneNumber1.Leave
        If Not isValidPhone(txtEPhoneNumber1.Text) Then
            ShakeControl(txtEPhoneNumber1)
            txtEPhoneNumber1.Focus()
        End If
    End Sub

    Private Sub cboMembershipType_Leave(sender As Object, e As EventArgs) Handles cboMembershipType.Leave
        If Not isValidCombo(cboMembershipType) Then
            ShakeControl(cboMembershipType)
            cboMembershipType.Focus()
        End If
    End Sub

    Private Sub cboGender_Leave(sender As Object, e As EventArgs) Handles cboGender.Leave
        If Not isValidCombo(cboGender) Then
            ShakeControl(cboGender)
            cboGender.Focus()
        End If
    End Sub

    Private Sub cboRelationship1_Leave(sender As Object, e As EventArgs) Handles cboRelationship1.Leave
        If Not isValidCombo(cboRelationship) Then
            ShakeControl(cboRelationship)
            cboRelationship.Focus()
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If isFormComplete(Me) Then
            MessageBox.Show("Member registered successfully", "Register member", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm(Me)
        txtPatientID.Focus()
    End Sub
End Class