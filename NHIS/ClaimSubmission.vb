Imports MySql.Data.MySqlClient

Public Class frmNewClaim
    Private providersTable As New DataTable()

    Private Sub ClaimSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDOB.MaxDate = DateTime.Today
        dtpDOB.MinDate = DateTime.Today.AddYears(-120)

        ' Disable Save button initially
        btnSave.Enabled = False

        Dim query As String = "SELECT id, name FROM provider ORDER BY id"

        Using conn As New MySqlConnection(My.Settings.dbConStr)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Dim dt As New DataTable()
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using

                    cboProviderID.DataSource = dt
                    cboProviderID.DisplayMember = "name"   ' what shows in the box
                    cboProviderID.ValueMember = "id"       ' what you retrieve as .SelectedValue
                    cboProviderID.SelectedIndex = -1       ' no default selection
                Catch ex As MySqlException
                    MessageBox.Show("Error loading providers: " & ex.Message)
                End Try
            End Using
        End Using

        ' Run validation check after loading provider dropdown
        ValidateForm()
    End Sub

    ' Centralized method to check if all required fields are valid
    Private Sub ValidateForm()
        Dim isProviderSelected As Boolean = cboProviderID.SelectedIndex <> -1
        Dim isNHISValid As Boolean = isRequired(txtNHISNumber.Text)
        Dim isPatientNameValid As Boolean = isValidName(txtPatientFullName.Text)
        Dim isProcedureValid As Boolean = isRequired(cboProcedureType.Text)

        Dim amount As Decimal
        Dim isAmountValid As Boolean = Decimal.TryParse(txtAmount.Text.Trim(), amount) AndAlso amount > 0

        ' Enable button ONLY when all required rules are satisfied
        btnSave.Enabled = isProviderSelected AndAlso
                          isNHISValid AndAlso
                          isPatientNameValid AndAlso
                          isProcedureValid AndAlso
                          isAmountValid
    End Sub

    ' Event handler listening for input changes across form controls
    Private Sub InputFields_Changed(sender As Object, e As EventArgs) Handles _
        txtNHISNumber.TextChanged,
        txtPatientFullName.TextChanged,
        txtAmount.TextChanged,
        cboProcedureType.SelectedIndexChanged,
        cboProcedureType.TextChanged

        ValidateForm()
    End Sub

    Private Sub cboProviderID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProviderID.SelectedIndexChanged
        ValidateForm()

        If cboProviderID.SelectedIndex = -1 Then Return

        Dim providerId As String = cboProviderID.SelectedValue.ToString()
        Dim query As String = "SELECT name, type, district, region, phone FROM provider WHERE id = @id"

        Using conn As New MySqlConnection(My.Settings.dbConStr)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", providerId)
                Try
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtProviderName.Text = reader("name").ToString()
                            txtRegion2.Text = reader("region").ToString()
                            txtProviderPhone.Text = reader("phone").ToString()
                            txtDistrict.Text = reader("district").ToString()
                            txtProviderType.Text = reader("type").ToString()
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Error loading provider details: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim amount As Decimal = Convert.ToDecimal(txtAmount.Text.Trim())

        Try
            Using conn As New MySqlConnection(My.Settings.dbConStr)
                Dim query As String = "INSERT INTO claim2 " &
                    "(provider_id, nhis_number, patient_name, service_date, amount, procedure_type, diagnosis_code, diagnosis_desc, ward_department, additional_note, status) " &
                    "VALUES (@provider_id, @nhis_number, @patient_name, @service_date, @amount, @procedure_type, @diagnosis_code, @diagnosis_desc, @ward, @notes, @status)"

                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@provider_id", cboProviderID.Text)
                cmd.Parameters.AddWithValue("@nhis_number", txtNHISNumber.Text)
                cmd.Parameters.AddWithValue("@patient_name", txtPatientFullName.Text)
                cmd.Parameters.AddWithValue("@service_date", dtpDateSubmitted.Value.Date)
                cmd.Parameters.AddWithValue("@amount", amount)
                cmd.Parameters.AddWithValue("@procedure_type", cboProcedureType.Text)
                cmd.Parameters.AddWithValue("@diagnosis_code", txtDiagnosisCode.Text)
                cmd.Parameters.AddWithValue("@diagnosis_desc", txtDiagnosisDescription.Text)
                cmd.Parameters.AddWithValue("@ward", txtWardDepartment.Text)
                cmd.Parameters.AddWithValue("@notes", txtAdditionalNotes.Text)
                cmd.Parameters.AddWithValue("@status", "Pending")

                conn.Open()
                Dim affected As Integer = cmd.ExecuteNonQuery()

                If affected > 0 Then
                    MessageBox.Show("Claim submitted successfully!", "Submit Claim", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm(Me)
                    ValidateForm() ' Re-disable button after resetting form
                Else
                    MessageBox.Show("Could not submit claim.", "Submit Claim", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error submitting claim: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm(Me)
        ValidateForm() ' Re-evaluate validation state
    End Sub

    ' --- Leave / Focus Handlers ---
    Private Sub txtNHISNumber_Leave(sender As Object, e As EventArgs) Handles txtNHISNumber.Leave
        If Not isRequired(txtNHISNumber.Text) AndAlso txtNHISNumber.Text.Length > 0 Then
            ShakeControl(txtNHISNumber)
        End If
    End Sub

    Private Sub txtPatientFullName_Leave(sender As Object, e As EventArgs) Handles txtPatientFullName.Leave
        If Not isValidName(txtPatientFullName.Text) AndAlso txtPatientFullName.Text.Length > 0 Then
            ShakeControl(txtPatientFullName)
        End If
    End Sub

    Private Sub cboProcedureType_Leave(sender As Object, e As EventArgs) Handles cboProcedureType.Leave
        If Not isRequired(cboProcedureType.Text) AndAlso cboProcedureType.Text.Length > 0 Then
            ShakeControl(cboProcedureType)
        End If
    End Sub

    Private Sub txtRegion2_Leave(sender As Object, e As EventArgs) Handles txtRegion2.Leave
        If Not isRequired(txtRegion2.Text) AndAlso txtRegion2.Text.Length > 0 Then
            Highlight(txtRegion2)
        End If
    End Sub

    ' --- Navigation & UI Handlers ---
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
