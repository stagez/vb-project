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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not isFormComplete(Me) Then
            MessageBox.Show("Please complete the form.", "Submit Claim", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New MySql.Data.MySqlClient.MySqlConnection(My.Settings.dbConStr)
                Dim query As String = "INSERT INTO claims (claim_id, provider_id, provider_name, nhis_number, patient_name, service_date, procedure_type, diagnosis_code, diagnosis_desc, ward_department, additional_notes, status) VALUES (@claim_id,@provider_id,@provider_name,@nhis_number,@patient_name,@service_date,@procedure_type,@diagnosis_code,@diagnosis_desc,@ward,@notes,@status)"
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@claim_id", Guid.NewGuid().ToString())
                cmd.Parameters.AddWithValue("@provider_id", txtProviderID.Text)
                cmd.Parameters.AddWithValue("@provider_name", txtProviderName.Text)
                cmd.Parameters.AddWithValue("@nhis_number", txtNHISNumber.Text)
                cmd.Parameters.AddWithValue("@patient_name", txtPatientFullName.Text)
                cmd.Parameters.AddWithValue("@service_date", dtpDateSubmitted.Value.Date)
                cmd.Parameters.AddWithValue("@procedure_type", cboProcedureType.Text)
                cmd.Parameters.AddWithValue("@diagnosis_code", txtDiagnosisCode.Text)
                cmd.Parameters.AddWithValue("@diagnosis_desc", txtDiagnosisDescription.Text)
                cmd.Parameters.AddWithValue("@ward", txtWardDepartment.Text)
                cmd.Parameters.AddWithValue("@notes", txtAdditionalNotes.Text)
                cmd.Parameters.AddWithValue("@status", "Pending")

                conn.Open()
                Dim affected = cmd.ExecuteNonQuery()
                If affected > 0 Then
                    MessageBox.Show("Claim submitted successfully!", "Submit Claim", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm(Me)
                Else
                    MessageBox.Show("Could not submit claim.", "Submit Claim", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error submitting claim: " & ex.Message)
        End Try
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

        ' Wire up live validation to enable/disable the Submit button
        WireValidation(Me, btnSave)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim main As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
        main.LoadForm(New frmDashboard())
    End Sub

    Private Sub frmNewClaim_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim main As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
            main.LoadForm(New frmDashboard())
        End If
    End Sub

    Private Sub frmNewClaim_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim x As Integer = Math.Max(0, (Me.ClientSize.Width - pnlMainContainer.Width) \ 2)
        Dim y As Integer = Math.Max(0, (Me.ClientSize.Height - pnlMainContainer.Height) \ 2)
    End Sub
End Class