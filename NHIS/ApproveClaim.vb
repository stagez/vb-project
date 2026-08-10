Imports MySql.Data.MySqlClient

Public Class ApproveClaim

    Private ReadOnly _claimId As Integer

    ' Constructor accepting only the claim ID
    Public Sub New(claimID As Integer)
        InitializeComponent()
        _claimId = claimID
    End Sub

    Private Sub frmApproveClaims_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClaimData()
    End Sub

    ' Fetches all claim, provider, and patient details from MySQL
    Private Sub LoadClaimData()
        Dim query As String = "SELECT c.id, c.provider_id, c.nhis_number, c.patient_name, c.service_date, " &
                         "c.amount, c.procedure_type, c.diagnosis_code, c.status, " &
                         "p.type AS provider_type, p.region AS provider_region, p.phone AS provider_phone, " &
                         "m.full_name, m.date_of_birth, m.gender, m.phone AS patient_phone, m.membership_type " &
                         "FROM claim2 c " &
                         "LEFT JOIN provider p ON c.provider_id = p.name " &
                         "LEFT JOIN member m ON c.nhis_number = m.nhis_number " &
                         "WHERE c.id = @id"

        Using conn As New MySqlConnection(My.Settings.dbConStr)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandTimeout = 30
                cmd.Parameters.AddWithValue("@id", _claimId)

                Try
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' --- Header ---
                            lblClaimID.Text = "Claim: " & reader("id").ToString()
                            Dim currentStatus As String = reader("status").ToString()
                            lblStatus.Text = currentStatus

                            ' --- Tab 1: Provider Details ---
                            txtProviderName.Text = reader("provider_id").ToString()

                            If txtProviderType IsNot Nothing Then
                                txtProviderType.Text = If(IsDBNull(reader("provider_type")), "—", reader("provider_type").ToString())
                            End If

                            If txtRegion IsNot Nothing Then
                                txtRegion.Text = If(IsDBNull(reader("provider_region")), "—", reader("provider_region").ToString())
                            End If

                            If txtProviderPhone IsNot Nothing Then
                                txtProviderPhone.Text = If(IsDBNull(reader("provider_phone")), "—", reader("provider_phone").ToString())
                            End If

                            ' --- Tab 2: Claim Info ---
                            If Not IsDBNull(reader("service_date")) Then
                                dtpServiceDate.Value = Convert.ToDateTime(reader("service_date"))
                            End If
                            lblAmount.Text = String.Format("GHS {0:N2}", Convert.ToDecimal(reader("amount")))

                            If txtMembershipType IsNot Nothing Then
                                txtMembershipType.Text = If(IsDBNull(reader("membership_type")), "—", reader("membership_type").ToString())
                            End If

                            If txtDiagnosisCode IsNot Nothing Then
                                txtDiagnosisCode.Text = reader("diagnosis_code").ToString()
                            End If

                            If txtProcedure IsNot Nothing Then
                                txtProcedure.Text = reader("procedure_type").ToString()
                            End If

                            ' --- Tab 3: Patient Details ---
                            Dim patientName As String = If(IsDBNull(reader("full_name")), reader("patient_name").ToString(), reader("full_name").ToString())
                            txtPatientName.Text = patientName
                            txtNHISNumber.Text = reader("nhis_number").ToString()

                            If txtDOB IsNot Nothing Then
                                txtDOB.Text = If(IsDBNull(reader("date_of_birth")), "—", reader("date_of_birth").ToString())
                            End If

                            If txtGender IsNot Nothing Then
                                txtGender.Text = If(IsDBNull(reader("gender")), "", reader("gender").ToString())
                            ElseIf txtGender IsNot Nothing Then
                                txtGender.Text = If(IsDBNull(reader("gender")), "—", reader("gender").ToString())
                            End If

                            If txtPatientPhone IsNot Nothing Then
                                txtPatientPhone.Text = If(IsDBNull(reader("patient_phone")), "—", reader("patient_phone").ToString())
                            End If

                            ' --- Action Buttons ---
                            Dim isPending As Boolean = currentStatus.Equals("Pending", StringComparison.OrdinalIgnoreCase)
                            btnApprove.Enabled = isPending
                            btnReject.Enabled = isPending
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading claim details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
    ' Updates status column in MySQL
    Private Function UpdateStatus(newStatus As String) As Boolean
        Dim query As String = "UPDATE claim2 SET status = @status WHERE id = @id"

        Using conn As New MySqlConnection(My.Settings.dbConStr)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@status", newStatus)
                cmd.Parameters.AddWithValue("@id", _claimId)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    MessageBox.Show("Failed to update status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If UpdateStatus("Approved") Then
            MessageBox.Show("Claim Approved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Dim result = MessageBox.Show(
            "Do you want to reject this claim?",
            "Reject Claim",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            If UpdateStatus("Rejected") Then
                MessageBox.Show("Claim Rejected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ApproveClaim_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class