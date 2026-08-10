Imports MySql.Data.MySqlClient

Public Class ViewProviders

    Private Sub frmViewProviders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' UI Styling
        dgvViewProviders.RowTemplate.Height = 45
        dgvViewProviders.GridColor = Color.FromArgb(230, 235, 230)
        dgvViewProviders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvViewProviders.DefaultCellStyle.Padding = New Padding(8, 0, 0, 0)
        dgvViewProviders.ColumnHeadersDefaultCellStyle.Padding = New Padding(8, 0, 0, 0)

        ' Load dynamic data from database
        LoadProviders()
    End Sub
    Private Sub LoadProviders()
        dgvViewProviders.Rows.Clear()

        Dim query As String = "SELECT id, name, type, phone, CONCAT(city, ', ', region) AS location FROM provider ORDER BY id"

        Using conn As New MySqlConnection(My.Settings.dbConStr)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim providerId As String = "P" & reader("id").ToString().PadLeft(3, "0"c) ' e.g., P001
                            Dim name As String = reader("name").ToString()
                            Dim type As String = reader("type").ToString()
                            Dim phone As String = reader("phone").ToString()
                            Dim location As String = reader("location").ToString()

                            dgvViewProviders.Rows.Add(providerId, name, type, phone, location)
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading providers: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class