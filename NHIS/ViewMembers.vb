Imports MySql.Data.MySqlClient

Public Class ViewMembers

    Private Sub frmViewMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' UI Styling
        dgvMembers.RowTemplate.Height = 45
        dgvMembers.GridColor = Color.FromArgb(230, 235, 230)
        dgvMembers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvMembers.DefaultCellStyle.Padding = New Padding(8, 0, 0, 0)
        dgvMembers.ColumnHeadersDefaultCellStyle.Padding = New Padding(8, 0, 0, 0)

        ' Load dynamic data from MySQL database
        LoadMembers()
    End Sub

    Private Sub LoadMembers()
        dgvMembers.Rows.Clear()

        Dim query As String = "SELECT id, full_name, nhis_number, membership_type, gender, phone, region FROM member ORDER BY id"

        Using conn As New MySqlConnection(My.Settings.dbConStr)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Format ID as PAT-001, PAT-002, etc.
                            Dim patientId As String = "PAT-" & reader("id").ToString().PadLeft(3, "0"c)
                            Dim fullName As String = reader("full_name").ToString()
                            Dim nhisNum As String = reader("nhis_number").ToString()
                            Dim membershipType As String = reader("membership_type").ToString()
                            Dim gender As String = reader("gender").ToString()
                            Dim phone As String = reader("phone").ToString()
                            Dim region As String = reader("region").ToString()

                            dgvMembers.Rows.Add(patientId, fullName, nhisNum, membershipType, gender, phone, region)
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading members: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class