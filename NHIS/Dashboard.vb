Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvClaims.RowTemplate.Height = 45

        dgvClaims.GridColor = Color.FromArgb(230, 235, 230)
        dgvClaims.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

        dgvClaims.DefaultCellStyle.Padding = New Padding(8, 0, 0, 0)
        dgvClaims.ColumnHeadersDefaultCellStyle.Padding = New Padding(8, 0, 0, 0)



        'lblTotalCount.Text = "128"
        'lblPendingCount.Text = "34"
        'lblApprovedCount.Text = "81"
        'lblRejectedCount.Text = "13"

        AnimateCount(lblTotalCount, 128)
        AnimateCount(lblPendingCount, 34)
        AnimateCount(lblApprovedCount, 81)
        AnimateCount(lblRejectedCount, 13)


        ' --- Recent Claims stubs ---
        dgvClaims.Rows.Add("CLM-001", "Ridge Hospital", "2025-06-01", "450.00", "Approved")
        dgvClaims.Rows.Add("CLM-002", "Tema Polyclinic", "2025-06-03", "120.00", "Pending")
        dgvClaims.Rows.Add("CLM-003", "Korle Bu Teaching", "2025-06-05", "890.00", "Rejected")
        dgvClaims.Rows.Add("CLM-004", "Trust Hospital", "2025-06-07", "300.00", "Approved")
        dgvClaims.Rows.Add("CLM-005", "Nyaho Medical", "2025-06-09", "670.00", "Pending")
    End Sub
    Private Sub AnimateCount(lbl As Label, targetValue As Integer)
        Dim timer As New Timer()
        Dim current As Integer = 0
        Dim steps As Integer = 30
        Dim increment As Integer = Math.Max(1, targetValue \ steps)

        AddHandler timer.Tick, Sub(s, e)
                                   current += increment
                                   If current >= targetValue Then
                                       current = targetValue
                                       timer.Stop()
                                   End If
                                   lbl.Text = current.ToString()
                               End Sub

        timer.Interval = 16  ' ~60fps
        timer.Start()
    End Sub

    Private Sub dgvClaims_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClaims.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim row = dgvClaims.Rows(e.RowIndex)

        Dim claimID = row.Cells(0).Value?.ToString()
        Dim provider = row.Cells(1).Value?.ToString()
        Dim membershipType = row.Cells(2).Value?.ToString()
        Dim serviceDate = row.Cells(3).Value?.ToString()
        Dim amount = row.Cells(4).Value?.ToString()
        Dim status = row.Cells(5).Value?.ToString()


    End Sub
End Class