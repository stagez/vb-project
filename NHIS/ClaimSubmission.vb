Public Class frmNewClaim
    Private Sub txtNHISNumber_Leave(sender As Object, e As EventArgs) Handles txtNHISNumber.Leave
        If Not isRequired(txtNHISNumber.Text) Then
            ShakeControl(txtNHISNumber)
            txtNHISNumber.Focus()
        End If
    End Sub

    Private Sub txtPatientName_Leave(sender As Object, e As EventArgs) Handles txtPatientName.Leave
        If Not isValidName(txtPatientName.Text) Then
            Highlight(txtPatientFullName)
        End If
    End Sub

    Private Sub cboProcedureType_Leave(sender As Object, e As EventArgs) Handles cboProcedureType.Leave
        If Not isRequired(cboProcedureType.Text) Then
            ShakeControl(cboProcedureType)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        ClearForm(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        If isFormComplete(Me) Then
            MessageBox.Show("Claims submitted successfully!", "Submit Claim", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtPatientFullName_Leave(sender As Object, e As EventArgs) Handles txtPatientFullName.Leave
        If Not isValidName(txtPatientFullName.Text) Then
            ShakeControl(txtPatientFullName)
            txtPatientFullName.Focus()
        End If
    End Sub

    Private Sub txtProviderID_Leave(sender As Object, e As EventArgs) Handles txtProviderID.Leave
        If Not isRequired(txtProviderID.Text) Then
            Highlight(txtProviderID)
        End If
    End Sub

    Private Sub txtProviderName_Leave(sender As Object, e As EventArgs) Handles txtProviderName.Leave
        If Not isRequired(txtProviderName.Text) Then
            Highlight(txtProviderID)
        End If
    End Sub

    Private Sub txtRegion2_Leave(sender As Object, e As EventArgs) Handles txtRegion2.Leave
        If Not isRequired(txtRegion2.Text) Then
            Highlight(txtRegion2)
        End If
    End Sub

    Private Sub ClaimSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDOB.MaxDate = DateTime.Today
        dtpDOB.MinDate = DateTime.Today.AddYears(-120)

        If Not isFormComplete(Me) Then
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim main As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
        main.LoadForm(New frmDashboard())
    End Sub
End Class