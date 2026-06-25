Public Class frmViewClaims
    Private Sub frmViewClaims_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvViewClaims.RowTemplate.Height = 45

        dgvViewClaims.GridColor = Color.FromArgb(230, 235, 230)
        dgvViewClaims.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

        dgvViewClaims.DefaultCellStyle.Padding = New Padding(8, 0, 0, 0)
        dgvViewClaims.ColumnHeadersDefaultCellStyle.Padding = New Padding(8, 0, 0, 0)

        dgvViewClaims.Rows.Add("CLM-001", "Korle Bu Teaching Hospital", "SSNIT Contributor", "2025-05-10", "450.00", "Approved")
        dgvViewClaims.Rows.Add("CLM-002", "UEW Student Hospital", "Under 18", "2025-05-14", "120.00", "Pending")
        dgvViewClaims.Rows.Add("CLM-003", "Reach Hospital", "Indigent", "2025-05-18", "890.00", "Rejected")
        dgvViewClaims.Rows.Add("CLM-004", "Temale Teaching Hospital", "Pregnant Woman", "2025-05-22", "300.00", "Approved")
        dgvViewClaims.Rows.Add("CLM-005", "Korle Bu Teaching Hospital", "SSNIT Pensioner", "2025-05-28", "670.00", "Pending")
        dgvViewClaims.Rows.Add("CLM-006", "UEW Student Hospital", "Under 18", "2025-06-01", "200.00", "Approved")
        dgvViewClaims.Rows.Add("CLM-007", "Reach Hospital", "SSNIT Contributor", "2025-06-05", "540.00", "Pending")
    End Sub
End Class