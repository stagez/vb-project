Public Class ApproveClaim
    Public Sub New(claimID As String, provider As String, serviceDate As String, amount As String, status As String)
        InitializeComponent()

        ' Populate the header labels
        lblClaimID.Text = "Claim: " & claimID
        lblStatus.Text = status

        ' Tab 1 — Provider
        txtProviderName.Text = provider

        dtpServiceDate.Value = serviceDate
        lblAmount.Text = "GHS " & amount

        txtPatientName.Text = "—"
        txtNHISNumber.Text = "—"
    End Sub
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        MessageBox.Show(
            "Claim Approved!",
            "Approve",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
        Me.Close()
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
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
            Me.Close()
        End If
    End Sub

    Private Sub frmApproveClaims_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not lblStatus.Text = "Pending" Then
            btnApprove.Enabled = False
            btnReject.Enabled = False
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ApproveClaim_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim main As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
            main.LoadForm(New frmDashboard())
        End If
    End Sub
End Class