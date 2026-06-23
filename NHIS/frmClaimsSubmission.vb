Public Class frmClaimsSubmission
    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNHISNumber_Leave(sender As Object, e As EventArgs) Handles txtNHISNumber.Leave
        If Not isRequired(txtNHISNumber.Text) Then
            ShakeControl(txtNHISNumber)
            txtNHISNumber.Focus()
        End If
    End Sub

    Private Sub txtPatientName_Leave(sender As Object, e As EventArgs) Handles txtPatientName.Leave
        If Not isValidName(txtPatientName.Text) Then
            ShakeControl(txtPatientName)
            txtPatientName.Focus()
        End If
    End Sub

    Private Sub cboProcedureType_Leave(sender As Object, e As EventArgs) Handles cboProcedureType.Leave
        If Not isRequired(cboProcedureType.Text) Then
            ShakeControl(cboProcedureType)
            cboProcedureType.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm(Me)
    End Sub

    Private Sub frmClaimSubmission_Paint(sender As Object, e As PaintEventArgs) Handles frmClaimSubmission.Paint

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MessageBox.Show("Claims submitted successfully!", "Submit Claim", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txtPatientFullName_Leave(sender As Object, e As EventArgs) Handles txtPatientFullName.Leave
        If Not isValidName(txtPatientFullName.Text) Then
            ShakeControl(txtPatientFullName)
            txtPatientFullName.Focus()
        End If
    End Sub

    Private Sub dtpDateOfBirth_Leave(sender As Object, e As EventArgs) Handles dtpDateOfBirth.Leave
        If Not isValidDOB(dtpDateOfBirth.Text) Then
            ShakeControl(dtpDateOfBirth)
            dtpDateOfBirth.Focus()
        End If
    End Sub

    Private Sub txtProviderID_Leave(sender As Object, e As EventArgs) Handles txtProviderID.Leave
        If Not isRequired(txtProviderID.Text) Then
            ShakeControl(txtProviderID)
            txtProviderID.Focus()
        End If
    End Sub

    Private Sub txtProviderName_Leave(sender As Object, e As EventArgs) Handles txtProviderName.Leave
        If Not isRequired(txtProviderName.Text) Then
            ShakeControl(txtProviderName)
            txtProviderName.Focus()
        End If
    End Sub

    Private Sub txtRegion2_Leave(sender As Object, e As EventArgs) Handles txtRegion2.Leave
        If Not isRequired(txtRegion2.Text) Then
            ShakeControl(txtRegion2)
            txtRegion2.Focus()
        End If
    End Sub


End Class