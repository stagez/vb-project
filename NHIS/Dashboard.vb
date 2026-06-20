Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalCount.Text = "128"
        lblPendingCount.Text = "34"
        lblApprovedCount.Text = "81"
        lblRejectedCount.Text = "13"

        ' --- Recent Claims stubs ---
        dgvClaims.Rows.Add("CLM-001", "Ridge Hospital", "2025-06-01", "450.00", "Approved")
        dgvClaims.Rows.Add("CLM-002", "Tema Polyclinic", "2025-06-03", "120.00", "Pending")
        dgvClaims.Rows.Add("CLM-003", "Korle Bu Teaching", "2025-06-05", "890.00", "Rejected")
        dgvClaims.Rows.Add("CLM-004", "Trust Hospital", "2025-06-07", "300.00", "Approved")
        dgvClaims.Rows.Add("CLM-005", "Nyaho Medical", "2025-06-09", "670.00", "Pending")
    End Sub
End Class