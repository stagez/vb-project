Imports MySql.Data.MySqlClient

Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' DataGridView UI Styling
        dgvClaims.RowTemplate.Height = 45
        dgvClaims.GridColor = Color.FromArgb(230, 235, 230)
        dgvClaims.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvClaims.DefaultCellStyle.Padding = New Padding(8, 0, 0, 0)
        dgvClaims.ColumnHeadersDefaultCellStyle.Padding = New Padding(8, 0, 0, 0)

        ' Load data and counts from MySQL database
        LoadDashboardData()
    End Sub

    Private Sub LoadDashboardData()
        ' Clear existing rows before loading
        dgvClaims.Rows.Clear()

        Dim totalCount As Integer = 0
        Dim pendingCount As Integer = 0
        Dim approvedCount As Integer = 0
        Dim rejectedCount As Integer = 0

        Try
            Using conn As New MySqlConnection(My.Settings.dbConStr)
                conn.Open()

                ' 1. Fetch metrics from claim2 table
                Dim countQuery As String = "SELECT " &
                    "COUNT(*) AS Total, " &
                    "SUM(CASE WHEN status = 'Pending' THEN 1 ELSE 0 END) AS Pending, " &
                    "SUM(CASE WHEN status = 'Approved' THEN 1 ELSE 0 END) AS Approved, " &
                    "SUM(CASE WHEN status = 'Rejected' THEN 1 ELSE 0 END) AS Rejected " &
                    "FROM claim2"

                Using cmdCount As New MySqlCommand(countQuery, conn)
                    Using reader As MySqlDataReader = cmdCount.ExecuteReader()
                        If reader.Read() Then
                            totalCount = If(IsDBNull(reader("Total")), 0, Convert.ToInt32(reader("Total")))
                            pendingCount = If(IsDBNull(reader("Pending")), 0, Convert.ToInt32(reader("Pending")))
                            approvedCount = If(IsDBNull(reader("Approved")), 0, Convert.ToInt32(reader("Approved")))
                            rejectedCount = If(IsDBNull(reader("Rejected")), 0, Convert.ToInt32(reader("Rejected")))
                        End If
                    End Using
                End Using

                ' 2. Fetch rows for the DataGridView
                Dim dataQuery As String = "SELECT id, provider_id, service_date, amount, status FROM claim2 ORDER BY id DESC"

                Using cmdData As New MySqlCommand(dataQuery, conn)
                    Using reader As MySqlDataReader = cmdData.ExecuteReader()
                        While reader.Read()
                            ' Format dates and decimal values appropriately
                            Dim claimID As String = reader("id").ToString()
                            Dim provider As String = reader("provider_id").ToString()
                            Dim serviceDate As String = Convert.ToDateTime(reader("service_date")).ToString("yyyy-MM-dd")
                            Dim amount As String = Convert.ToDecimal(reader("amount")).ToString("N2")
                            Dim status As String = reader("status").ToString()

                            dgvClaims.Rows.Add(claimID, provider, serviceDate, amount, status)
                        End While
                    End Using
                End Using
            End Using

            ' Trigger counter animations with database values
            AnimateCount(lblTotalCount, totalCount)
            AnimateCount(lblPendingCount, pendingCount)
            AnimateCount(lblApprovedCount, approvedCount)
            AnimateCount(lblRejectedCount, rejectedCount)

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AnimateCount(lbl As Label, targetValue As Integer)
        ' If target is 0, display immediately without running a timer
        If targetValue <= 0 Then
            lbl.Text = "0"
            Return
        End If

        Dim timer As New Timer()
        Dim current As Integer = 0
        Dim steps As Integer = 30
        Dim increment As Integer = Math.Max(1, targetValue \ steps)

        AddHandler timer.Tick, Sub(s, e)
                                   current += increment
                                   If current >= targetValue Then
                                       current = targetValue
                                       timer.Stop()
                                       timer.Dispose()
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
        Dim serviceDate = row.Cells(2).Value?.ToString()
        Dim amount = row.Cells(3).Value?.ToString()
        Dim status = row.Cells(4).Value?.ToString()

        ' Convert claimID to Integer before passing it
        Dim claimIdInt As Integer = Convert.ToInt32(claimID)

        Dim frm As New ApproveClaim(claimIdInt)
        If frm.ShowDialog() = DialogResult.OK Then
            ' Refresh dashboard grid and counts when a claim is updated/approved
            LoadDashboardData()
        End If
    End Sub

End Class
