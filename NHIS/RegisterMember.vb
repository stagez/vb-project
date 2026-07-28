Public Class RegisterMember
    Private Sub frmRegisterMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpDOB.MaxDate = DateTime.Today


        dtpDOB.MinDate = DateTime.Today.AddYears(-120)

        dtpExpiryDate.Value = DateTime.Today.AddYears(5) ' Set the expiry date to 5 years from today

        If Not isFormComplete(Me) Then
            btnRegister.Enabled = False
        End If
    End Sub

    Private Sub txtPatientID_Leave(sender As Object, e As EventArgs)
        If Not isRequired(txtPatientID.Text) Then
            Highlight(txtPatientID)
        End If
    End Sub

    Private Sub txtContactName_Leave(sender As Object, e As EventArgs)
        If Not isValidName(txtContactName.Text) Then
            Highlight(txtContactName)
        End If
    End Sub

    Private Sub txtDistrict_Leave(sender As Object, e As EventArgs)
        If Not isRequired(txtDistrict.Text) Then
            Highlight(txtDistrict)
        End If
    End Sub

    Private Sub txtEPhoneNumber_Leave(sender As Object, e As EventArgs)
        If Not isValidPhone(txtEPhoneNumber1.Text) Then
            Highlight(txtEPhoneNumber1)

        End If
    End Sub

    Private Sub txtRegion_Leave(sender As Object, e As EventArgs)
        If Not isRequired(txtRegion.Text) Then
            Highlight(txtRegion)
        End If
    End Sub

    Private Sub txtRelationship_Leave(sender As Object, e As EventArgs)
        If Not isRequired(cboRelationship1.Text) Then
            ShakeControl(cboRelationship1)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        ClearForm(Me)
    End Sub

    Private Sub txtContactName_Leave_1(sender As Object, e As EventArgs) Handles txtContactName.Leave
        If Not isValidName(txtContactName.Text) Then
            Highlight(txtContactName)
        End If
    End Sub


    Private Sub txtCity_Leave(sender As Object, e As EventArgs) Handles txtCity.Leave
        If Not isRequired(txtCity.Text) Then
            Highlight(txtCity)
        End If
    End Sub

    Private Sub txtDistrict_Leave_1(sender As Object, e As EventArgs) Handles txtDistrict.Leave
        If Not isRequired(txtDistrict.Text) Then
            Highlight(txtDistrict)
        End If
    End Sub

    Private Sub txtPhoneNumber_Leave(sender As Object, e As EventArgs) Handles txtPhoneNumber.Leave
        If Not isValidPhone(txtPhoneNumber.Text) Then
            Highlight(txtPhoneNumber)
        End If
    End Sub

    Private Sub txtNationality_Leave(sender As Object, e As EventArgs) Handles txtNationality.Leave
        If Not isRequired(txtNationality.Text) Then
            Highlight(txtNationality)
        End If
    End Sub

    Private Sub txtNHISNumber_Leave(sender As Object, e As EventArgs) Handles txtNHISNumber.Leave
        If Not isRequired(txtNHISNumber.Text) Then
            Highlight(txtNHISNumber)
        End If
    End Sub

    Private Sub txtPatientID_Leave_1(sender As Object, e As EventArgs) Handles txtPatientID.Leave
        If Not isRequired(txtPatientID.Text) Then
            Highlight(txtPatientID)
        End If
    End Sub

    Private Sub txtFullName_Leave(sender As Object, e As EventArgs) Handles txtFullName.Leave
        If Not isValidName(txtFullName.Text) Then
            Highlight(txtFullName)
        End If
    End Sub

    Private Sub txtEPhoneNumber1_Leave(sender As Object, e As EventArgs) Handles txtEPhoneNumber1.Leave
        If Not isValidPhone(txtEPhoneNumber1.Text) Then
            Highlight(txtPhoneNumber)

        End If
    End Sub

    Private Sub cboMembershipType_Leave(sender As Object, e As EventArgs) Handles cboMembershipType.Leave
        If Not isValidCombo(cboMembershipType) Then
            ShakeControl(cboMembershipType)
        End If
    End Sub

    Private Sub cboGender_Leave(sender As Object, e As EventArgs) Handles cboGender.Leave
        If Not isValidCombo(cboGender) Then
            ShakeControl(cboGender)
        End If
    End Sub

    Private Sub cboRelationship1_Leave(sender As Object, e As EventArgs) Handles cboRelationship1.Leave
        If Not isValidCombo(cboRelationship) Then
            ShakeControl(cboRelationship)
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim main As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
        main.LoadForm(New frmDashboard())
    End Sub

    Private Sub RegisterMember_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim main As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
            main.LoadForm(New frmDashboard())
        End If
    End Sub

    Private Sub RegisterMember_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim x As Integer = Math.Max(0, (Me.ClientSize.Width - pnlMainContainer.Width) \ 2)
        Dim y As Integer = Math.Max(0, (Me.ClientSize.Height - pnlMainContainer.Height) \ 2)

        pnlMainContainer.Location = New Point(x, y)
    End Sub

    Private Sub RegisterMember_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.AutoScrollPosition = New Point(0, 0)
    End Sub
End Class