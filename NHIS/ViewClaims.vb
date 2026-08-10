Imports MySql.Data.MySqlClient

Public Class ViewClaims

    Private ReadOnly _statusFilter As String

    ' Constructor accepting status ("All", "Pending", "Approved", "Rejected")
    Public Sub New(Optional statusFilter As String = "All")
        InitializeComponent()
        _statusFilter = statusFilter
    End Sub

    Private Sub ViewClaims_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply UI Grid Styling
        dgvViewClaims.RowTemplate.Height = 45
        dgvViewClaims.GridColor = Color.FromArgb(230, 235, 230)
        dgvViewClaims.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

        ' Load claims based on status filter
        LoadClaims(_statusFilter)
    End Sub

    Public Sub LoadClaims(statusFilter As String)
        ' Clear pre-configured rows before loading fresh data
        dgvViewClaims.Rows.Clear()

        Dim query As String = "SELECT id, provider_id, patient_name, service_date, amount, status FROM claim2"

        ' Filter query by status if specified
        If Not String.IsNullOrEmpty(statusFilter) AndAlso Not statusFilter.Equals("All", StringComparison.OrdinalIgnoreCase) Then
            query &= " WHERE status = @status"
        End If

        query &= " ORDER BY id DESC"

        Using conn As New MySqlConnection(My.Settings.dbConStr)
            Using cmd As New MySqlCommand(query, conn)
                If query.Contains("@status") Then
                    cmd.Parameters.AddWithValue("@status", statusFilter)
                End If

                Try
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim claimId As String = reader("id").ToString()
                            Dim provider As String = reader("provider_id").ToString()
                            Dim patient As String = reader("patient_name").ToString()
                            Dim serviceDate As String = Convert.ToDateTime(reader("service_date")).ToString("yyyy-MM-dd")
                            Dim amount As String = String.Format("GHS {0:N2}", Convert.ToDecimal(reader("amount")))
                            Dim status As String = reader("status").ToString()

                            ' Add directly into designer columns
                            dgvViewClaims.Rows.Add(claimId, provider, patient, serviceDate, amount, status)
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading claims: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

End Class