Public Class frmApproveClaims
    Public Sub New(claimID As String, provider As String, membershipType As String, serviceDate As String, amount As String, status As String)
        InitializeComponent()

        ' Populate the header labels
        lblClaimID.Text = "Claim: " & claimID
        lblStatus.Text = status

        ' Tab 1 — Provider
        txtProviderName.Text = provider

        ' Tab 2 — Claim Info
        dtpServiceDate.Value = serviceDate
        lblAmount.Text = "GHS " & amount

        ' Tab 3 — Patient (stubbed for now)
        txtPatientName.Text = "—"
        lblNHISNumber.Text = "—"
    End Sub
    Private Sub btnApprove_Click(sender As Object, e As EventArgs)
        MessageBox.Show(
            "Claim Approved!",
            "Approve",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show(
            "Do you want to reject claim?",
            "Reject Claim",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If result = DialogResult.Yes Then
            MessageBox.Show(
                "Claim rejected!",
                "Reject Claim",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
        End If
    End Sub

End Class